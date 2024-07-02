using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;
using Mono.Options;

namespace xsiminstaller {
	class MainClass {
		static bool print_simulators;
		static int verbose;

		static string TempDirectory {
			get {
				var rv = Path.Combine (Path.GetTempPath (), "x-provisioning");
				Directory.CreateDirectory (rv);
				return rv;
			}
		}

		static bool TryExecuteAndCapture (out string stdout, string filename, params string [] arguments)
		{
			var rv = TryExecuteAndCapture (out stdout, out var stderr, filename, arguments);
			if (!rv)
				Console.WriteLine (stderr);
			return rv;
		}

		static bool TryExecuteAndCapture (out string stdout, out string stderr, string filename, params string [] arguments)
		{
			using (var p = new Process ()) {
				p.StartInfo.FileName = filename;
				foreach (var arg in arguments)
					p.StartInfo.ArgumentList.Add (arg);
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardError = true;
				p.StartInfo.UseShellExecute = false;
				var quotedArguments = Xamarin.Utils.StringUtils.FormatArguments (arguments);
				if (verbose > 0)
					Console.WriteLine ($"{filename} {quotedArguments}");
				var output = new StringBuilder ();
				var error = new StringBuilder ();
				var outputDone = new ManualResetEvent (false);
				var errorDone = new ManualResetEvent (false);
				p.OutputDataReceived += (sender, args) => {
					if (args.Data is null) {
						outputDone.Set ();
					} else {
						output.AppendLine (args.Data);
					}
				};
				p.ErrorDataReceived += (sender, args) => {
					if (args.Data is null) {
						errorDone.Set ();
					} else {
						error.AppendLine (args.Data);
					}
				};
				p.Start ();
				p.BeginErrorReadLine ();
				p.BeginOutputReadLine ();
				p.WaitForExit ();
				outputDone.WaitOne ();
				errorDone.WaitOne ();
				stdout = output.ToString ();
				stderr = error.ToString ();
				if (verbose > 0 && p.ExitCode != 0)
					Console.WriteLine ($"Failed to execute '{filename} {quotedArguments}', exit code: {p.ExitCode}\n{stdout}\n{stderr}");
				return p.ExitCode == 0;
			}
		}

		public async static Task<int> Main (string [] args)
		{
			var exit_code = 0;
			string? xcode_app = null;
			var install = new List<string> ();
			var only_check = false;
			var force = false;
			var printHelp = false;

			var os = new OptionSet {
				{ "xcode=", "The Xcode.app to use", (v) => xcode_app = v },
				{ "install=", "ID of simulator to install. Can be repeated multiple times.", (v) => install.Add (v) },
				{ "only-check", "Only check if the simulators are installed or not. Prints the name of any missing simulators, and returns 1 if any non-installed simulators were found.", (v) => only_check = true },
				{ "print-simulators", "Print all detected simulators.", (v) => print_simulators = true },
				{ "f|force", "Install again even if already installed.", (v) => force = true },
				{ "v|verbose", "Increase verbosity", (v) => verbose++ },
				{ "q|quiet", "Decrease verbosity", (v) => verbose-- },
				{ "h|help", "Print this help message", (v) => printHelp = true },
			};

			var others = os.Parse (args);
			if (others.Any ()) {
				Console.WriteLine ("Unexpected arguments:");
				foreach (var arg in others)
					Console.WriteLine ("\t{0}", arg);
				Console.WriteLine ("Expected arguments are:");
				os.WriteOptionDescriptions (Console.Out);
				return 1;
			}

			if (printHelp) {
				os.WriteOptionDescriptions (Console.Out);
				return 0;
			}

			if (string.IsNullOrEmpty (xcode_app)) {
				Console.WriteLine ("--xcode is required.");
				return 1;
			} else if (!Directory.Exists (xcode_app)) {
				Console.WriteLine ("The Xcode directory {0} does not exist.", xcode_app);
				return 1;
			}

			var plist = Path.Combine (xcode_app, "Contents", "Info.plist");
			if (!File.Exists (plist)) {
				Console.WriteLine ($"The Info.plist '{plist}' does not exist.");
				return 1;
			}

			if (!TryExecuteAndCapture (out var xcodeVersion, "/usr/libexec/PlistBuddy", $"-c", "Print :DTXcode", plist))
				return 1;
			xcodeVersion = xcodeVersion.Trim ();
			xcodeVersion = xcodeVersion.Insert (xcodeVersion.Length - 2, ".");
			xcodeVersion = xcodeVersion.Insert (xcodeVersion.Length - 1, ".");

			var indexName = $"index-{xcodeVersion}.dvtdownloadableindex";
			var tmpfile = Path.Combine (TempDirectory, indexName);
			if (!File.Exists (tmpfile)) {
				// Try multiple urls
				var urls = new string [] {
					/*
					 * The following url was found while debugging Xcode, the "index2" part is actually hardcoded:
					 * 
					 *	DVTFoundation`-[DVTDownloadableIndexSource identifier]:
					 *		0x103db478d <+0>:  pushq  %rbp
					 *		0x103db478e <+1>:  movq   %rsp, %rbp
					 *		0x103db4791 <+4>:  leaq   0x53f008(%rip), %rax      ; @"index2"
					 *		0x103db4798 <+11>: popq   %rbp
					 *		0x103db4799 <+12>: retq
					 * 
					 */
					"https://devimages-cdn.apple.com/downloads/xcode/simulators/index2.dvtdownloadableindex",
				};
				var anyFailures = false;
				var wc = new HttpClient ();
				foreach (var url in urls) {
					var uri = new Uri (url);
					try {
						if (verbose > 0)
							Console.WriteLine ($"Downloading '{uri}'");
						else if (anyFailures)
							Console.WriteLine ($"Attempting fallback url '{uri}'");

						var response = await wc.GetAsync (uri);
						using var file = new FileStream (tmpfile, FileMode.Create, FileAccess.Write, FileShare.None);
						await response.Content.CopyToAsync (file);
					} catch (Exception ex) {
						File.Delete (tmpfile); // Make sure there are no downloaded remnants
											   // 403 means 404
						if (ex is WebException we && (we.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.Forbidden) {
							Console.WriteLine ($"Failed to download {url}: Not found"); // Apple's servers return a 403 if the file doesn't exist, which can be quite confusing, so show a better error.
						} else {
							Console.WriteLine ($"Failed to download {url}: {ex}");
						}
						anyFailures = true;
					}
				}

				if (!File.Exists (tmpfile)) {
					// We couldn't download the list of simulators, but the simulator(s) we were requested to install might already be installed.
					// Don't fail in that case (we'd miss any potential updates, but that's probably not too bad).
					if (install.Count > 0) {
						if (verbose > 0)
							Console.WriteLine ("Checking if all the requested simulators are already installed");
						foreach (var name in install) {
							if (!IsInstalled (name, out var _)) {
								Console.WriteLine (verbose > 0 ? $"The simulator '{name}' is not installed." : name);
								exit_code = 1;
							} else if (verbose > 0) {
								Console.WriteLine ($"The simulator '{name}' is installed.");
							}
						}
						// We can't install any missing simulators, because we don't have the download url (since we couldn't download the .dvtdownloadableindex file), so just exit.
						return exit_code;
					}
					return 1;
				}
			}

			if (!TryExecuteAndCapture (out var xml, "plutil", "-convert", "xml1", "-o", "-", tmpfile))
				return 1;

			var doc = new XmlDocument ();
			doc.LoadXml (xml);

			var downloadables = doc.SelectNodes ("//plist/dict/key[text()='downloadables']/following-sibling::array[1]/dict");
			if (downloadables is not null) {
				foreach (XmlNode downloadable in downloadables) {
					var nameNode = downloadable.SelectSingleNode ("key[text()='name']/following-sibling::string");
					var versionNode = downloadable.SelectSingleNode ("key[text()='version']/following-sibling::string");
					var sourceNode = downloadable.SelectSingleNode ("key[text()='source']/following-sibling::string");
					var identifierNode = downloadable.SelectSingleNode ("key[text()='identifier']/following-sibling::string");
					var fileSizeNode = downloadable.SelectSingleNode ("key[text()='fileSize']/following-sibling::integer|key[text()='fileSize']/following-sibling::real");
					var installPrefixNode = downloadable.SelectSingleNode ("key[text()='userInfo']/following-sibling::dict/key[text()='InstallPrefix']/following-sibling::string");

					var version = versionNode?.InnerText ?? string.Empty;
					var versions = version.Split ('.');
					var versionMajor = versions [0];
					var versionMinor = versions [1];
					var dict = new Dictionary<string, string> () {
						{ "DOWNLOADABLE_VERSION_MAJOR", versionMajor },
						{ "DOWNLOADABLE_VERSION_MINOR", versionMinor },
						{ "DOWNLOADABLE_VERSION", version },
					};

					var identifier = Replace (identifierNode?.InnerText, dict);

					var name = Replace (nameNode?.InnerText, dict) ?? string.Empty;
					var source = Replace (sourceNode?.InnerText, dict);
					var installPrefix = Replace (installPrefixNode?.InnerText, dict);

					if (string.IsNullOrEmpty (identifier)) {
						if (verbose >= 0)
							Console.WriteLine ($"No identifier found for {name}");
						continue;
					}

					dict.Add ("DOWNLOADABLE_IDENTIFIER", identifier);

					if (installPrefix is null) {
						// This is just guesswork
						var simRuntimeName = name.Replace (" Simulator", ".simruntime");
						installPrefix = $"/Library/Developer/CoreSimulator/Profiles/Runtimes/{simRuntimeName}";
					}

					double.TryParse (fileSizeNode?.InnerText, out var parsedFileSize);
					var fileSize = (long) parsedFileSize;

					var installed = false;
					var updateAvailable = false;

					if (only_check && !install.Contains (identifier))
						continue;

					if (IsInstalled (identifier, out var installedVersion)) {
						if (installedVersion >= Version.Parse (version)) {
							installed = true;
						} else {
							updateAvailable = true;
						}
					}

					var doInstall = false;
					if (install.Contains (identifier)) {
						if (force) {
							doInstall = true;
							if (!only_check && verbose >= 0 && installed)
								Console.WriteLine ($"The simulator '{identifier}' is already installed, but will be installed again because --force was specified.");
						} else if (installed) {
							if (!only_check && verbose >= 0)
								Console.WriteLine ($"Not installing '{identifier}' because it's already installed and up-to-date.");
						} else {
							doInstall = true;
						}
						install.Remove (identifier);
					}

					if (print_simulators) {
						Console.WriteLine (name);
						Console.Write ($"  Version: {version}");
						if (updateAvailable)
							Console.WriteLine ($" (an earlier version is installed: {installedVersion}");
						else if (!installed)
							Console.WriteLine ($" (not installed)");
						else
							Console.WriteLine ($" (installed)");
						Console.WriteLine ($"  Source: {source}");
						Console.WriteLine ($"  Identifier: {identifier}");
						Console.WriteLine ($"  InstallPrefix: {installPrefix}");
					}

					if (only_check) {
						if (doInstall) {
							if (updateAvailable) {
								Console.WriteLine (verbose > 0 ? $"The simulator '{name}' is installed, but an update is available." : name);
							} else {
								Console.WriteLine (verbose > 0 ? $"The simulator '{name}' is not installed." : name);
							}
							exit_code = 1;
						} else if (verbose > 0) {
							Console.WriteLine ($"The simulator '{name}' is installed.");
						}
					}
					if (doInstall && !only_check) {
						Console.WriteLine ($"Installing {name}...");
						if (await InstallAsync (source, fileSize, installPrefix)) {
							Console.WriteLine ($"Installed {name} successfully.");
						} else {
							Console.WriteLine ($"Failed to install {name}.");
							return 1;
						}
					}
				}
			}

			if (install.Count > 0) {
				Console.WriteLine ("Unknown simulators: {0}", string.Join (", ", install));
				return 1;
			}

			return exit_code;
		}

		static bool IsInstalled (string identifier, out Version? installedVersion)
		{
			if (TryExecuteAndCapture (out var pkgInfo, out _, $"pkgutil", "--pkg-info", identifier)) {
				var lines = pkgInfo.Split ('\n');
				var version = lines.First ((v) => v.StartsWith ("version: ", StringComparison.Ordinal)).Substring ("version: ".Length);
				installedVersion = Version.Parse (version);
				return true;
			}

			installedVersion = null;
			return false;
		}

		static async Task<bool> InstallAsync (string? source, long fileSize, string installPrefix)
		{
			if (string.IsNullOrEmpty (source)) {
				Console.WriteLine ($"Failed to install, no source provided.");
				return false;
			}

			var download_dir = TempDirectory;
			var filename = Path.GetFileName (source);
			var download_path = Path.Combine (download_dir, filename);
			var download = true;

			if (!File.Exists (download_path)) {
				Console.WriteLine ($"Downloading '{source}' to '{download_path}' (size: {fileSize} bytes = {fileSize / 1024.0 / 1024.0:N2} MB)...");
			} else if (new FileInfo (download_path).Length != fileSize) {
				Console.WriteLine ($"Downloading '{source}' to '{download_path}' because the existing file's size {new FileInfo (download_path).Length} does not match the expected size {fileSize}...");
			} else {
				download = false;
			}
			if (download) {
				var downloadDone = new ManualResetEvent (false);
				var wc = new HttpClient ();
				long lastProgress = 0;
				var watch = Stopwatch.StartNew ();
				var downloadProgressChanged = (DownloadProgressChangedEventArgs progress_args) => {
					var progress = progress_args.BytesReceived * 100 / fileSize;
					if (progress > lastProgress) {
						lastProgress = progress;
						var duration = watch.Elapsed.TotalSeconds;
						var speed = progress_args.BytesReceived / duration;
						var timeLeft = TimeSpan.FromSeconds ((long) ((progress_args.TotalBytesToReceive - progress_args.BytesReceived) / speed));
						Console.WriteLine ($"Downloaded {progress_args.BytesReceived:N0}/{fileSize:N0} bytes = {progress}% in {duration:N1}s ({speed / 1024.0 / 1024.0:N1} MB/s; approximately {timeLeft} left)");
					}
				};
				var downloadFileCompleted = (AsyncCompletedEventArgs download_args) => {
					Console.WriteLine ($"Download completed in {watch.Elapsed.TotalSeconds}s");
					if (download_args.Error is not null) {
						Console.WriteLine ($"    with error: {download_args.Error}");
					}
					downloadDone.Set ();
				};

				using var file = new FileStream (download_path, FileMode.Create, FileAccess.Write, FileShare.None);
				var response = await wc.GetAsync (new Uri (source), HttpCompletionOption.ResponseHeadersRead);
				var contentLength = response.Content.Headers.ContentLength;

				using var responseStream = await response.Content.ReadAsStreamAsync ();

				var buffer = new byte [40960];
				long totalBytesRead = 0;
				int bytesRead;
				while ((bytesRead = await responseStream.ReadAsync (buffer, 0, buffer.Length)) > 0) {
					file.Write (buffer, 0, bytesRead);
					totalBytesRead += bytesRead;
					downloadProgressChanged (new DownloadProgressChangedEventArgs () { BytesReceived = totalBytesRead, TotalBytesToReceive = contentLength ?? -1 });
				}
				downloadFileCompleted (new AsyncCompletedEventArgs (null, false, null));
				downloadDone.WaitOne ();
			}
			var mount_point = Path.Combine (download_dir, filename + "-mount");
			Directory.CreateDirectory (mount_point);
			try {
				Console.WriteLine ($"Mounting '{download_path}' into '{mount_point}'...");
				if (!TryExecuteAndCapture (out _, "hdiutil", "attach", download_path, "-mountpoint", mount_point, "-quiet", "-nobrowse")) {
					Console.WriteLine ("Mount failure!");
					return false;
				}

				try {
					var packages = Directory.GetFiles (mount_point, "*.pkg");
					if (packages.Length == 0) {
						Console.WriteLine ("Found no *.pkg files in the dmg.");
						return false;
					} else if (packages.Length > 1) {
						Console.WriteLine ("Found more than one *.pkg file in the dmg:\n\t{0}", string.Join ("\n\t", packages));
						return false;
					}

					// According to the package manifest, the package's install location is /.
					// That's obviously not where it's installed, but I have no idea how Apple does it
					// So instead decompress the package, modify the package manifest, re-create the package, and then install it.
					var expanded_path = Path.Combine (download_dir + "-expanded-pkg");
					if (Directory.Exists (expanded_path))
						Directory.Delete (expanded_path, true);
					Console.WriteLine ($"Expanding '{packages [0]}' into '{expanded_path}'...");
					if (!TryExecuteAndCapture (out _, "pkgutil", "--expand", packages [0], expanded_path)) {
						Console.WriteLine ($"Failed to expand {packages [0]}");
						return false;
					}

					try {
						var packageInfoPath = Path.Combine (expanded_path, "PackageInfo");
						var packageInfoDoc = new XmlDocument ();
						packageInfoDoc.Load (packageInfoPath);
						// Add the install-location attribute to the pkg-info node
						var attr = packageInfoDoc.CreateAttribute ("install-location");
						attr.Value = installPrefix;
						packageInfoDoc.SelectSingleNode ("/pkg-info")!.Attributes!.Append (attr);
						packageInfoDoc.Save (packageInfoPath);

						var fixed_path = Path.Combine (Path.GetDirectoryName (download_path)!, Path.GetFileNameWithoutExtension (download_path) + "-fixed.pkg");
						if (File.Exists (fixed_path))
							File.Delete (fixed_path);
						try {
							Console.WriteLine ($"Creating fixed package '{fixed_path}' from '{expanded_path}'...");
							if (!TryExecuteAndCapture (out _, "pkgutil", "--flatten", expanded_path, fixed_path)) {
								Console.WriteLine ("Failed to create fixed package.");
								return false;
							}

							Console.WriteLine ($"Installing '{fixed_path}'...");
							if (!TryExecuteAndCapture (out _, "sudo", "installer", "-pkg", fixed_path, "-target", "/", "-verbose", "-dumplog")) {
								Console.WriteLine ("Failed to install package.");
								return false;
							}
						} finally {
							if (File.Exists (fixed_path))
								File.Delete (fixed_path);
						}
					} finally {
						Directory.Delete (expanded_path, true);
					}
				} finally {
					if (!TryExecuteAndCapture (out _, "hdiutil", "detach", mount_point, "-quiet", "-force"))
						Console.WriteLine ($"Failed to detach {mount_point}");
				}
			} finally {
				try {
					Directory.Delete (mount_point, true);
				} catch (IOException ioex) {
					Console.WriteLine ($"Unable to remove: {mount_point}");
					Console.WriteLine ($"    with error: {ioex}");
				}
			}

			File.Delete (download_path);

			return true;
		}

		[return: NotNullIfNotNull ("value")]
		static string? Replace (string? value, Dictionary<string, string> replacements)
		{
			if (value is null)
				return null;
			foreach (var kvp in replacements)
				value = value.Replace ($"$({kvp.Key})", kvp.Value);
			return value;
		}
	}
}

class DownloadProgressChangedEventArgs {
	public long TotalBytesToReceive;
	public long BytesReceived;
}
