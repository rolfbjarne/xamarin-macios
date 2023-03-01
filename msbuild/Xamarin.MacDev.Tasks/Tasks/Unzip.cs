using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Bundler;
using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	/// <summary>
	/// This task will extract the specified zip file into the specified extraction path.
	/// This task works on Windows too, but if the task encounters a symlink while extracting, an error will be shown.
	/// </summary>
	public class Unzip : XamarinTask, ITaskCallback {
		[Required]
		public string ZipFilePath { get; set; } = string.Empty;

		[Required]
		public string ExtractionPath { get; set; } = string.Empty;

		// The file or directory to extract from the zip file.
		// If not specified, the entire zip file is extracted.
		public string Resource { get; set; } = string.Empty;

		[Output]
		public ITaskItem [] TouchedFiles { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			return ExecuteLocally ();
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => true;

		public bool ShouldCreateOutputFile (ITaskItem item) => true;

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Enumerable.Empty<ITaskItem> ();

		bool ExecuteLocally ()
		{
			var createdFiles = new List<string> ();
			if (!TryDecompress (Log, ZipFilePath, Resource, ExtractionPath, createdFiles, out var _))
				return false;

			TouchedFiles = createdFiles.Select (v => new TaskItem (v)).ToArray ();

			return !Log.HasLoggedErrors;
		}

		/// <summary>
		/// Extracts the specified resource (may be either a file or a directory) from the given zip file.
		/// A stamp file will be created to avoid re-extracting unnecessarily.s
		///
		/// Fails if:
		/// * The resource is or contains a symlink and we're executing on Windows.
		/// * The resource isn't found inside the zip file.
		/// </summary>
		/// <param name="log"></param>
		/// <param name="zip">The zip to search in</param>
		/// <param name="resource">The relative path inside the zip to extract (may be a file or a directory). This may also be an empty string or null to extract the entire zip archive.</param>
		/// <param name="createdFiles"></param>
		/// <param name="decompressionDir">The location on disk to store the extracted results</param>
		/// <param name="decompressedResource">The location on disk to the extracted resource</param>
		/// <returns></returns>
		public static bool TryDecompress (TaskLoggingHelper log, string zip, string? resource, string decompressionDir, List<string> createdFiles, [NotNullWhen (true)] out string? decompressedResource)
		{
			decompressedResource = Path.Combine (decompressionDir, resource);

			var stampFile = decompressedResource + ".stamp";

			if (FileCopier.IsUptodate (zip, stampFile, GetFileCopierReportErrorCallback (log), GetFileCopierLogCallback (log), check_stamp: false))
				return true;

			bool rv;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
				rv = TryDecompressUsingSystemIOCompression (log, zip, resource, decompressionDir);
			} else if (!string.IsNullOrEmpty (Environment.GetEnvironmentVariable ("XAMARIN_USE_SYSTEM_IO_COMPRESSION"))) {
				rv = TryDecompressUsingSystemIOCompression (log, zip, resource, decompressionDir);
			} else {
				rv = TryDecompressUsingUnzip (log, zip, resource, decompressionDir);
			}

			if (rv) {
				Directory.CreateDirectory (Path.GetDirectoryName (stampFile));
				using var touched = new FileStream (stampFile, FileMode.Create, FileAccess.Write);
				createdFiles.Add (stampFile);
			}

			if (File.Exists (decompressedResource)) {
				createdFiles.Add (decompressedResource);
			} else if (Directory.Exists (decompressedResource)) {
				createdFiles.AddRange (Directory.GetFiles (decompressedResource, "*", SearchOption.AllDirectories));
			}

			return rv;
		}

		// The dir separator character in zip files is always "/", even on Windows
		public const char ZipDirectorySeparator = '/';

		static bool TryDecompressUsingUnzip (TaskLoggingHelper log, string zip, string? resource, string decompressionDir)
		{
			var archive = ZipFile.OpenRead (zip);

			var zipPattern = string.Empty;
#if NET
			if (!string.IsNullOrEmpty (resource)) {
#else
			if (resource is not null && !string.IsNullOrEmpty (resource)) {
#endif
				resource = resource.Replace ('\\', ZipDirectorySeparator);
				var entry = archive.GetEntry (resource);
				if (entry is null) {
					entry = archive.GetEntry (resource + ZipDirectorySeparator);
					if (entry is null) {
						log.LogError (MSBStrings.E7112 /* Could not find the file or directory '{0}' in the zip file '{1}'. */, resource, zip);
						return false;
					}
				}
				zipPattern = entry.FullName;
			}

			if (zipPattern.Length > 0 && zipPattern [zipPattern.Length - 1] == ZipDirectorySeparator) {
				zipPattern += "*";
			}

			var args = new List<string> {
				"-u", // update any existing files
				"-o", // overwrite existing files without prompting
				"-d", decompressionDir,
				zip,
			};
			if (!string.IsNullOrEmpty (zipPattern))
				args.Add (zipPattern);
			var rv = ExecuteAsync (log, "unzip", args).Result;
			return rv.ExitCode == 0;
		}

		static bool TryDecompressUsingSystemIOCompression (TaskLoggingHelper log, string zip, string? resource, string decompressionDir)
		{
			var rv = true;

			// canonicalize input
#if NET
			if (!string.IsNullOrEmpty (resource)) {
#else
			if (resource is not null && !string.IsNullOrEmpty (resource)) {
#endif
				resource = resource.TrimEnd ('/', '\\');
				resource = resource.Replace ('\\', ZipDirectorySeparator);
			} else {
				resource = string.Empty;
			}
			var resourceAsDir = resource + ZipDirectorySeparator;

			var archive = ZipFile.OpenRead (zip);
			foreach (var entry in archive.Entries) {
				var entryPath = entry.FullName;
				if (entryPath.Length == 0)
					continue;

				if (string.IsNullOrEmpty (resource)) {
					// yep, we want this entry
				} else if (entryPath.StartsWith (resourceAsDir, StringComparison.Ordinal)) {
					// yep, we want this entry
				} else if (entryPath == resource) {
					// we want this one too
				} else {
					// but otherwise nope
					continue;
				}

				// Check if the file or directory is a symlink, and show an error if so. Symlinks are only supported
				// on non-Windows platforms.
				var entryAttributes = ((uint) GetExternalAttributes (entry)) >> 16;
				const uint S_IFLNK = 0xa000; // #define S_IFLNK  0120000  /* symbolic link */
				var isSymlink = (entryAttributes & S_IFLNK) == S_IFLNK;
				if (isSymlink) {
					log.LogError (MSBStrings.E7113 /* Can't process the zip file '{0}' on this platform: the file '{1}' is a symlink. */, zip, entryPath);
					rv = false;
					continue;
				}

				var isDir = entryPath [entryPath.Length - 1] == ZipDirectorySeparator;
				var targetPath = Path.Combine (decompressionDir, entryPath);
				if (isDir) {
					Directory.CreateDirectory (targetPath);
				} else {
					Directory.CreateDirectory (Path.GetDirectoryName (targetPath));
					using var streamWrite = File.OpenWrite (targetPath);
					using var streamRead = entry.Open ();
					streamRead.CopyTo (streamWrite);
				}
			}

			return rv;
		}

		static int GetExternalAttributes (ZipArchiveEntry self)
		{
			// The ZipArchiveEntry.ExternalAttributes property is available in .NET 4.7.2 (which we need to target for builds on Windows) and .NET 5+, but not netstandard2.0 (which is the latest netstandard .NET 4.7.2 supports).
			// Since the property will always be available at runtime, just call it using reflection.
#if NET
			return self.ExternalAttributes;
#else
			var property = typeof (ZipArchiveEntry).GetProperty ("ExternalAttributes", BindingFlags.Instance | BindingFlags.Public);
			return (int) property.GetValue (self);
#endif
		}
	}
}
