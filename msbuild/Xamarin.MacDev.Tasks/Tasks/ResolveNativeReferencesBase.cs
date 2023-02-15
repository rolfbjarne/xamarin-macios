using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin;
using Xamarin.Bundler;
using Xamarin.MacDev;
using Xamarin.MacDev.Tasks;
using Xamarin.Localization.MSBuild;
using Xamarin.Utils;
using System.Xml.Linq;


#nullable enable

namespace Xamarin.MacDev.Tasks {

	// We can get numerous types of native references:
	//
	//	*.dylib
	//  *.a
	//  *.framework
	//  *.xcframework
	//
	// They can come from:
	//
	//  - A NativeReference to the file/directory on disk (or even a file inside the directory).
	//  - A NativeReference to a zip of the above
	//  - A binding resource package next to an assembly
	//  - A zipped binding resource package
	//
	// Special considerations:
	// - We can only extract the files we need from any zipped reference, because this task must work on Windows (without a connection to a Mac),
	//   and a zip may contain symlinks for a different platform (and thus won't be needed). Example: an xcframework
	//   with a framework for macOS will likely have symlink, but that shouldn't prevent the xcframework from being
	//   consumed in a build for iOS.
	//

	public abstract class ResolveNativeReferencesBase : XamarinTask {
		#region Inputs

		[Required]
		public string? Architectures { get; set; }

		[Required]
		public string IntermediateOutputPath { get; set; } = string.Empty;

		public ITaskItem [] NativeReferences { get; set; } = Array.Empty<ITaskItem> ();

		public ITaskItem [] References { get; set; } = Array.Empty<ITaskItem> ();

		[Required]
		public bool SdkIsSimulator { get; set; }

		#endregion

		#region Outputs

		[Output]
		public ITaskItem []? NativeFrameworks { get; set; }

		#endregion

		string GetIntermediateDecompressionDir (ITaskItem item)
		{
			return GetIntermediateDecompressionDir (item.ItemSpec);
		}

		string GetIntermediateDecompressionDir (string item)
		{
			return Path.Combine (IntermediateOutputPath, Path.GetFileName (item));
		}
		// returns the Mach-O file for the given path:
		// * for frameworks, returns foo.framework/foo
		// * for anything else, returns the input path
		[return: NotNullIfNotNull (nameof (path))]
		static string? GetActualLibrary (string? path)
		{
			if (path is null)
				return null;

			if (path.EndsWith (".framework", StringComparison.OrdinalIgnoreCase))
				return Path.Combine (path, Path.GetFileNameWithoutExtension (path));

			return path;
		}

		public override bool Execute ()
		{
			var native_frameworks = new List<ITaskItem> ();

			// there can be direct native references inside a project
			foreach (var nr in NativeReferences) {
				ProcessNativeReference (nr, native_frameworks);
			}
			
			// or (managed) reference to an assembly that bind a framework
			foreach (var r in References) {
				// look for sidecar's manifest
				var resources = Path.ChangeExtension (r.ItemSpec, ".resources");
				if (Directory.Exists (resources)) {
					ProcessNativeReference (r, resources, native_frameworks);
				} else {
					resources = resources + ".zip";
					if (File.Exists (resources))
						ProcessNativeReference (r, resources, native_frameworks);
				}
			}

			NativeFrameworks = native_frameworks.ToArray ();

			return !Log.HasLoggedErrors;
		}

		void ProcessNativeReference (ITaskItem item, List<ITaskItem> native_frameworks)
		{
			ProcessNativeReference (item, item.ItemSpec, native_frameworks);
		}

		void ProcessNativeReference (ITaskItem item, string name, List<ITaskItem> native_frameworks)
		{
			var parentDirectory = Path.GetDirectoryName (name);

			// framework
			if (name.EndsWith (".framework", StringComparison.OrdinalIgnoreCase)) {
				var nr = new TaskItem (item);
				nr.ItemSpec = GetActualLibrary (name);
				nr.SetMetadata ("Kind", "Framework");
				native_frameworks.Add (nr);
				return;
			} else if (parentDirectory.EndsWith (".framework", StringComparison.OrdinalIgnoreCase) && Path.GetFileName (name) == Path.GetFileNameWithoutExtension (parentDirectory)) {
				var nr = new TaskItem (item);
				nr.ItemSpec = GetActualLibrary (name);
				nr.SetMetadata ("Kind", "Framework");
				native_frameworks.Add (nr);
				return;
			}

			// dynamic library
			if (name.EndsWith (".dylib", StringComparison.OrdinalIgnoreCase)) {
				var nr = new TaskItem (item);
				nr.ItemSpec = name;
				nr.SetMetadata ("Kind", "Dynamic");
				native_frameworks.Add (nr);
				return;
			}

			// static library
			if (name.EndsWith (".a", StringComparison.OrdinalIgnoreCase)) {
				var nr = new TaskItem (item);
				nr.ItemSpec = name;
				nr.SetMetadata ("Kind", "Static");
				native_frameworks.Add (nr);
				return;
			}

			// (compressed) xcframework
			if (name.EndsWith (".xcframework", StringComparison.OrdinalIgnoreCase) || name.EndsWith (".xcframework.zip", StringComparison.OrdinalIgnoreCase)) {
				if (!TryResolveXCFramework (Log, TargetFrameworkMoniker, SdkIsSimulator, Architectures, name, GetIntermediateDecompressionDir (item), out var frameworkPath))
					return;
				var nr = new TaskItem (item);
				nr.ItemSpec = GetActualLibrary (frameworkPath);
				nr.SetMetadata ("Kind", "Framework");
				native_frameworks.Add (nr);
				return;
			}

			// compressed framework
			if (name.EndsWith (".framework.zip", StringComparison.OrdinalIgnoreCase)) {
				if (!TryDecompress (Log, name, Path.GetFileNameWithoutExtension (name), GetIntermediateDecompressionDir (item), out var frameworkPath))
					return;
				var nr = new TaskItem (item);
				nr.ItemSpec = GetActualLibrary (frameworkPath);
				nr.SetMetadata ("Kind", "Framework");
				native_frameworks.Add (nr);
				return;
			}

			// sidecar / binding resource package
			if (name.EndsWith (".resources", StringComparison.OrdinalIgnoreCase)) {
				ProcessSidecar (item, name, native_frameworks);
				return;
			}

			// compressed sidecar / binding resource package
			if (name.EndsWith (".resources.zip", StringComparison.OrdinalIgnoreCase)) {
				ProcessSidecar (item, name, native_frameworks);
				return;
			}

			Log.LogWarning ("Unknown native reference: {0}", item.ItemSpec);
		}

		static bool TryGetSidecarManifest (TaskLoggingHelper log, string resources, [NotNullWhen (true)] out string? manifestContents)
		{
			using var stream = TryGetPotentiallyCompressedFile (log, resources, "manifest");

			if (stream is null) {
				manifestContents = null;
				return false;
			}

			using var streamReader = new StreamReader (stream);
			manifestContents = streamReader.ReadToEnd ();
			return true;
		}

		static bool TryGetInfoPlist (TaskLoggingHelper log, string resourcePath, string xcframework, [NotNullWhen (true)] out PDictionary? plist)
		{
			var manifestPath = Path.Combine (xcframework, "Info.plist");
			var stream = TryGetPotentiallyCompressedFile (log, resourcePath, manifestPath);
			if (stream is null) {
				plist = null;
				return false;
			}

			plist = (PDictionary?) PDictionary.FromStream (stream);
			if (plist is null) {
				log.LogError (MSBStrings.E0003 /* FIXME */, resourcePath, manifestPath);
				return false;
			}

			return true;
		}

		static bool IsCompressed (string path)
		{
			return path.EndsWith (".zip", StringComparison.OrdinalIgnoreCase);
		}

		static Stream? TryGetPotentiallyCompressedFile (TaskLoggingHelper log, string resources, string relativeFilePath)
		{
			// Check if we have a zipped resources, and if so, extract the manifest from the zip file
			if (IsCompressed (resources)) {
				if (!File.Exists (resources)) {
					log.LogWarning (MSBStrings.W7107 /* The zip file '{0}' does not exist */, resources);
					return null;
				}
				using var zip = ZipFile.OpenRead (resources);
				var contentEntry = zip.GetEntry (relativeFilePath.Replace ('\\', '/')); // directory separator character is '/' on all platforms in zip files.
				if (contentEntry is null) {
					log.LogWarning (MSBStrings.W7106 /* Expected a file named '{1}' in the zip file {0}. */, resources, relativeFilePath);
					return null;
				}

				using var contentStream = contentEntry.Open ();
				var memoryStream = new MemoryStream ();
				contentStream.CopyTo (memoryStream);
				memoryStream.Position = 0;
				return memoryStream;
			}

			if (!Directory.Exists (resources)) {
				log.LogWarning (MSBStrings.W7108 /* The file '{0}' does not exist. */, resources);
				return null;
			}

			var contentPath = Path.Combine (resources, relativeFilePath);
			if (!File.Exists (contentPath)) {
				log.LogWarning (MSBStrings.W7108 /* The file '{0}' does not exist. */, contentPath);
				return null;
			}

			return File.OpenRead (contentPath);
		}

		void ProcessSidecar (ITaskItem r, string resources, List<ITaskItem> native_frameworks)
		{
			if (!TryGetSidecarManifest (Log, resources, out var manifestContents))
				return;

			var isCompressed = IsCompressed (resources);
			XmlDocument document = new XmlDocument ();
			document.LoadXmlWithoutNetworkAccess (manifestContents);
			foreach (XmlNode referenceNode in document.GetElementsByTagName ("NativeReference")) {
				ITaskItem t = new TaskItem (r);
				var name = referenceNode.Attributes ["Name"].Value;
				switch (Path.GetExtension (name)) {
				case ".xcframework": {
					if (!TryResolveXCFramework (Log, TargetFrameworkMoniker, SdkIsSimulator, Architectures, resources, name, GetIntermediateDecompressionDir (resources), out var frameworkPath))
						continue;
					t.ItemSpec = GetActualLibrary (frameworkPath);
					t.SetMetadata ("Kind", "Framework");
					break;
				}
				case ".framework": {
					string? frameworkPath;
					if (isCompressed) {
						if (!TryDecompress (Log, resources, name, GetIntermediateDecompressionDir (resources), out frameworkPath))
							continue;
					} else {
						frameworkPath = Path.Combine (resources, name);
					}
					t.ItemSpec = GetActualLibrary (frameworkPath);
					t.SetMetadata ("Kind", "Framework");
					break;
				}
				case ".dylib": // macOS
					string? dylibPath;
					if (isCompressed) {
						if (!TryDecompress (Log, resources, name, GetIntermediateDecompressionDir (resources), out dylibPath))
							continue;
					} else {
						dylibPath = Path.Combine (resources, name);
					}
					t.ItemSpec = dylibPath;
					t.SetMetadata ("Kind", "Dynamic");
					break;
				case ".a": // static library
					string? aPath;
					if (isCompressed) {
						if (!TryDecompress (Log, resources, name, GetIntermediateDecompressionDir (resources), out aPath))
							continue;
					} else {
						aPath = Path.Combine (resources, name);
					}
					t.ItemSpec = aPath;
					t.SetMetadata ("Kind", "Static");
					break;
				default:
					Log.LogWarning (MSBStrings.W7105 /* Unexpected extension '{0}' for native reference '{1}' in binding resource package '{2}'. */, Path.GetExtension (name), name, r.ItemSpec);
					t = r;
					break;
				}

				// defaults
				t.SetMetadata ("ForceLoad", "False");
				t.SetMetadata ("NeedsGccExceptionHandling", "False");
				t.SetMetadata ("IsCxx", "False");
				t.SetMetadata ("SmartLink", "True");

				// values from manifest, overriding defaults if provided
				foreach (XmlNode attribute in referenceNode.ChildNodes)
					t.SetMetadata (attribute.Name, attribute.InnerText);

				native_frameworks.Add (t);
			}
		}

		/// <summary>
		/// Resolve an xcframework into a framework for a given platform. 
		/// </summary>
		/// <param name="log">The log to log any errors and/or warnings.</param>
		/// <param name="isSimulator">If we're targeting the simulator</param>
		/// <param name="targetFrameworkMoniker">The target framework moniker.</param>
		/// <param name="architectures">The target architectures</param>
		/// <param name="path">Either the path to a compressed xcframework (*.xcframework.zip), or an xcframework (*.xcframework).</param>
		/// <param name="frameworkPath">A full path to the resolved framework within the xcframework. If 'resourcePath' is compressed, this will point to where the framework is decompressed on disk.</param>
		/// <param name="intermediateDecompressionDir"></param>
		/// <returns>True if a framework was succsesfully found. Otherwise false, and an error will have been printed to the log.</returns>
		public static bool TryResolveXCFramework (TaskLoggingHelper log, string targetFrameworkMoniker, bool isSimulator, string? architectures, string path, string intermediateDecompressionDir, [NotNullWhen (true)] out string? frameworkPath)
		{
			string resourcePath;
			string xcframework;

			if (path.EndsWith (".zip", StringComparison.OrdinalIgnoreCase)) {
				resourcePath = path;
				xcframework = Path.GetFileNameWithoutExtension (path); // Remove the .zip extension
			} else {
				resourcePath = Path.GetDirectoryName (path);
				xcframework = Path.GetFileName (path);
			}
			return TryResolveXCFramework (log, targetFrameworkMoniker, isSimulator, architectures, resourcePath, xcframework, intermediateDecompressionDir, out frameworkPath);
		}

		/// <summary>
		/// Resolve an xcframework into a framework for a given platform. 
		/// </summary>
		/// <param name="log">The log to log any errors and/or warnings.</param>
		/// <param name="isSimulator">If we're targeting the simulator</param>
		/// <param name="targetFrameworkMoniker">The target framework moniker.</param>
		/// <param name="architectures">The target architectures</param>
		/// <param name="resourcePath">Either the path to a compressed xcframework, or the containing directory of an xcframework.</param>
		/// <param name="xcframework">The name of the xcframework.</param>
		/// <param name="frameworkPath">A full path to the resolved .framework within the xcframework. If 'resourcePath' is compressed, this will point to where the framework is decompressed on disk.</param>
		/// <param name="intermediateDecompressionDir"></param>
		/// <returns>True if a framework was succsesfully found. Otherwise false, and an error will have been printed to the log.</returns>
		public static bool TryResolveXCFramework (TaskLoggingHelper log, string targetFrameworkMoniker, bool isSimulator, string? architectures, string resourcePath, string xcframework, string intermediateDecompressionDir, [NotNullWhen (true)] out string? frameworkPath)
		{
			frameworkPath = null;
			log.LogMessage (MessageImportance.Low, $"TryResolveXCFramework ({targetFrameworkMoniker}, {isSimulator}, {architectures}, {resourcePath}, {xcframework}, {intermediateDecompressionDir})");
			try {
				if (!TryGetInfoPlist (log, resourcePath, xcframework, out var plist)) {
					log.LogMessage (MessageImportance.Low, $"TryResolveXCFramework ({targetFrameworkMoniker}, {isSimulator}, {architectures}, {resourcePath}, {xcframework}, {intermediateDecompressionDir}): no info.plist");
					return false;
				}

				var isCompressed = IsCompressed (resourcePath);
				var xcframeworkPath = isCompressed ? resourcePath : Path.Combine (resourcePath, xcframework);
				if (!TryResolveXCFramework (log, plist, xcframeworkPath, targetFrameworkMoniker, isSimulator, architectures!, out var frameworkRelativePath)) {
					log.LogMessage (MessageImportance.Low, $"TryResolveXCFramework ({targetFrameworkMoniker}, {isSimulator}, {architectures}, {resourcePath}, {xcframework}, {intermediateDecompressionDir}): failed 1");
					return false;
				}

				if (!isCompressed) {
					frameworkPath = Path.Combine (resourcePath, xcframework, frameworkRelativePath);
					return true;
				}

				var zipResource = Path.Combine (xcframework, Path.GetDirectoryName (frameworkRelativePath)).Replace ('\\', zipDirectorySeparator);
				if (!TryDecompress (log, resourcePath, zipResource, intermediateDecompressionDir, out var decompressedPath)) {
					log.LogMessage (MessageImportance.Low, $"TryResolveXCFramework ({targetFrameworkMoniker}, {isSimulator}, {architectures}, {resourcePath}, {xcframework}, {intermediateDecompressionDir}): failed unzip");
					return false;
				}

				frameworkPath = Path.Combine (intermediateDecompressionDir, zipResource);

				log.LogMessage (MessageImportance.Low, $"TryResolveXCFramework ({targetFrameworkMoniker}, {isSimulator}, {architectures}, {resourcePath}, {xcframework}, {intermediateDecompressionDir}): yay");

				return true;
			} catch (Exception) {
				log.LogError (MSBStrings.E0174, resourcePath);
			}

			return false;
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
		/// <param name="resource">The relative path inside the zip to extract (may be a file or a directory).</param>
		/// <param name="decompressionDir">The location on disk to store the extracted results</param>
		/// <param name="decompressedResource">The location on disk to the extracted resource</param>
		/// <returns></returns>
		static bool TryDecompress (TaskLoggingHelper log, string zip, string resource, string decompressionDir, [NotNullWhen (true)] out string? decompressedResource)
		{
			decompressedResource = Path.Combine (decompressionDir, resource);

			var stampFile = decompressedResource + ".stamp";

			log.LogMessage (MessageImportance.Low, $"TryDecompress (zip: {zip}, resource: {resource}, decompressionDir: {decompressionDir}) => decompressedResource: {decompressedResource} stampFile: {stampFile}");

			if (FileCopier.IsUptodate (zip, stampFile, GetFileCopierReportErrorCallback (log), GetFileCopierLogCallback (log), check_stamp: false)) {
				log.LogMessage (MessageImportance.Low, $"TryDecompress: {resource} is up-to-date");
				return true;
			}

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
			}
			return rv;
		}

		// The dir separator character in zip files is always "/", even on Windows
		const char zipDirectorySeparator = '/';

		static bool TryDecompressUsingUnzip (TaskLoggingHelper log, string zip, string resource, string decompressionDir)
		{
			var archive = ZipFile.OpenRead (zip);
			resource = resource.Replace ('\\', zipDirectorySeparator);
			var entry = archive.GetEntry (resource);
			if (entry is null) {
				entry = archive.GetEntry (resource + zipDirectorySeparator);
				if (entry is null) {
					log.LogError ("Could not find the entry {0} in the zip file {1}", resource, zip);
					return false;
				}
			}

			log.LogMessage (MessageImportance.Low, $"Unzipping entry {entry.FullName} from {zip}, resource: {resource}");

			var zipPattern = entry.FullName;
			if (zipPattern.Length > 0 && zipPattern [zipPattern.Length - 1] == zipDirectorySeparator) {
				zipPattern += "*";
			}

			var args = new string [] {
				"-u", "-o",
				"-d", decompressionDir,
				zip,
				zipPattern,
			};
			var rv = ExecuteAsync (log, "unzip", args).Result;
			return rv.ExitCode == 0;
		}

		static bool TryDecompressUsingSystemIOCompression (TaskLoggingHelper log, string zip, string resource, string decompressionDir)
		{
			var rv = true;

			// Action<string> log = Console.WriteLine;

			log.LogMessage (MessageImportance.Low, $"TryDecompressUsingSystemIOCompression ({zip}, {resource}, {decompressionDir})");

			// canonicalize input
			resource = resource.TrimEnd ('/', '\\');
			resource = resource.Replace ('\\', zipDirectorySeparator);
			var resourceAsDir = resource + zipDirectorySeparator;

			var targetDirectory = Path.Combine (decompressionDir, Path.GetDirectoryName (resource));
			var archive = ZipFile.OpenRead (zip);
			foreach (var entry in archive.Entries) {
				if (entry.Name.Length == 0)
					continue;

				if (entry.Name.StartsWith (resourceAsDir, StringComparison.Ordinal)) {
					// yep
					log.LogMessage (MessageImportance.Low, $"TryDecompressUsingSystemIOCompression ({zip}, {resource}, {decompressionDir}) entry {entry.Name} matching as directory.");
				} else if (entry.Name == resource) {
					// also yep
					log.LogMessage (MessageImportance.Low, $"TryDecompressUsingSystemIOCompression ({zip}, {resource}, {decompressionDir}) entry {entry.Name} matching as file");
				} else {
					// nope
					log.LogMessage (MessageImportance.Low, $"TryDecompressUsingSystemIOCompression ({zip}, {resource}, {decompressionDir}) entry {entry.Name} not matching resource.");
					continue;
				}

				var entryAttributes = ((uint) GetExternalAttributes (entry)) >> 16;
				const uint S_IFLNK = 0xa000; // #define S_IFLNK  0120000  /* symbolic link */
				var isSymlink = (entryAttributes & S_IFLNK) == S_IFLNK;

				if (isSymlink) {
					log.LogError ($"TryDecompressUsingSystemIOCompression ({zip}, {resource}, {decompressionDir}) entry {entry.Name} is a symlink.");
					rv = false;
					continue;
				}

				var isDir = entry.Name [entry.Name.Length - 1] == zipDirectorySeparator;
				var targetPath = Path.Combine (decompressionDir, entry.Name);
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

		/// <summary>
		/// Resolve an xcframework into a framework for a given platform. 
		/// </summary>
		/// <param name="log">The log to log any errors and/or warnings.</param>
		/// <param name="plist">The plist inside the xcframework.</param>
		/// <param name="xcframeworkPath">The path to the xcframework. This is only used for error messages, so it can also point to a compressed xcframework.</param>
		/// <param name="isSimulator">If we're targeting the simulator</param>
		/// <param name="targetFrameworkMoniker">The target framework moniker.</param>
		/// <param name="architectures">The target architectures</param>
		/// <param name="frameworkPath">A relative path to the resolved framework within the xcframework.</param>
		/// <returns>True if a framework was succsesfully found. Otherwise false, and an error will have been printed to the log.</returns>
		internal static bool TryResolveXCFramework (TaskLoggingHelper log, PDictionary plist, string xcframeworkPath, string targetFrameworkMoniker, bool isSimulator, string architectures, [NotNullWhen (true)] out string? frameworkPath)
		{
			frameworkPath = null;
			var platform = PlatformFrameworkHelper.GetFramework (targetFrameworkMoniker);
			string platformName;
			switch (platform) {
			case ApplePlatform.MacCatalyst:
				platformName = "ios";
				break;
			case Utils.ApplePlatform.MacOSX:
				// PlatformFrameworkHelper.GetOperatingSystem returns "osx" which does not work for xcframework
				platformName = "macos";
				break;
			default:
				platformName = PlatformFrameworkHelper.GetOperatingSystem (targetFrameworkMoniker);
				break;
			}

			string? variant;
			if (platform == ApplePlatform.MacCatalyst) {
				variant = "maccatalyst";
			} else if (isSimulator) {
				variant = "simulator";
			} else {
				variant = null;
			}

			// plist structure https://github.com/spouliot/xcframework#infoplist
			var bundle_package_type = (PString?) plist ["CFBundlePackageType"];
			if (bundle_package_type?.Value != "XFWK") {
				log.LogError (MSBStrings.E0174 /* The xcframework {0} has an incorrect or unknown format and cannot be processed. */, xcframeworkPath);
				return false;
			}
			var available_libraries = plist.GetArray ("AvailableLibraries");
			if ((available_libraries == null) || (available_libraries.Count == 0)) {
				log.LogError (MSBStrings.E0174 /* The xcframework {0} has an incorrect or unknown format and cannot be processed. */, xcframeworkPath);
				return false;
			}

			var archs = architectures.Split (new char [] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (PDictionary item in available_libraries) {
				var supported_platform = (PString?) item ["SupportedPlatform"];
				if (!string.Equals (supported_platform?.Value, platformName, StringComparison.OrdinalIgnoreCase))
					continue;
				// optional key
				var supported_platform_variant = (PString?) item ["SupportedPlatformVariant"];
				if (supported_platform_variant?.Value != variant)
					continue;
				var supported_architectures = (PArray?) item ["SupportedArchitectures"];
				// each architecture we request must be present in the xcframework
				// but extra architectures in the xcframework are perfectly fine
				foreach (var arch in archs) {
					bool found = false;
					foreach (PString xarch in supported_architectures!) {
						found = String.Equals (arch, xarch.Value, StringComparison.OrdinalIgnoreCase);
						if (found)
							break;
					}
					if (!found) {
						log.LogError (MSBStrings.E0175 /* No matching framework found inside '{0}'. SupportedPlatform: '{0}', SupportedPlatformVariant: '{1}', SupportedArchitectures: '{2}'. */, xcframeworkPath, platformName, variant, architectures);
						return false;
					}
				}
				var library_path = (PString?) item ["LibraryPath"];
				var library_identifier = (PString?) item ["LibraryIdentifier"];
				frameworkPath = GetActualLibrary (Path.Combine (library_identifier!, library_path!));
				return true;
			}

			log.LogError (MSBStrings.E0175 /* No matching framework found inside '{0}'. SupportedPlatform: '{0}', SupportedPlatformVariant: '{1}', SupportedArchitectures: '{2}'. */, xcframeworkPath, platformName, variant, architectures);
			return false;
		}
	}
}
