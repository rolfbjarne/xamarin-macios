using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using NUnit.Framework;

using Xamarin.iOS.Tasks;
using Xamarin.Utils;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	[TestFixture]
	public class ComputeCodesignItemsTaskTests : TestBase {

		[Test]
		[TestCase (ApplePlatform.iOS, true)]
		[TestCase (ApplePlatform.iOS, false)]
		[TestCase (ApplePlatform.TVOS, true)]
		[TestCase (ApplePlatform.TVOS, false)]
		[TestCase (ApplePlatform.WatchOS, false)]
		[TestCase (ApplePlatform.MacOSX, true)]
		[TestCase (ApplePlatform.MacOSX, false)]
		[TestCase (ApplePlatform.MacCatalyst, true)]
		public void Compute (ApplePlatform platform, bool isDotNet)
		{
			var tmpdir = Cache.CreateTemporaryDirectory ();

			var currentDir = Environment.CurrentDirectory;
			try {
				Environment.CurrentDirectory = tmpdir;
				var codesignItems = new List<ITaskItem> ();
				var codesignBundle = new List<ITaskItem> ();
				var generateDSymItems = new List<ITaskItem> ();
				var nativeStripItems = new List<ITaskItem> ();

				var bundleAppMetadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "CompiledEntitlements.plist" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "bundle-app-extra-args" },
					{ "CodesignKeychain", "bundle-app-keychain" },
					{ "CodesignResourceRules", "bundle-app-resource-rules" },
					{ "CodesignSigningKey", "bundle-app-signing-key" },
					{ "CodesignStampFile", "bundle-app-stamp-file" },
					{ "CodesignUseHardenedRuntime", "bundle-app-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "bundle-app-use-secure-timestamp" },
				};

				var p1Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "p1.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "p1.appex-extra-args" },
					{ "CodesignKeychain", "p1.appex-keychain" },
					{ "CodesignResourceRules", "p1.appex-resource-rules" },
					{ "CodesignSigningKey", "" }, // empty code signing key
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "p1.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "p1.appex-use-secure-timestamp" },
				};
				var p1MetadataNativeLibraries = new Dictionary<string, string> (p1Metadata);
				p1MetadataNativeLibraries ["CodesignSigningKey"] = "-";
				p1MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var p2Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "p2.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "p2.appex-extra-args" },
					{ "CodesignKeychain", "p2.appex-keychain" },
					{ "CodesignResourceRules", "p2.appex-resource-rules" },
					{ "CodesignSigningKey", "p2.appex-signing-key" },
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "p2.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "p2.appex-use-secure-timestamp" },
				};
				var p2MetadataNativeLibraries = new Dictionary<string, string> (p2Metadata);
				p2MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var p3Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "p3.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "p3.appex-extra-args" },
					{ "CodesignKeychain", "p3.appex-keychain" },
					{ "CodesignResourceRules", "p3.appex-resource-rules" },
					{ "CodesignSigningKey", "p3.appex-signing-key" },
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "p3.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "p3.appex-use-secure-timestamp" },
				};
				var p3MetadataNativeLibraries = new Dictionary<string, string> (p3Metadata);
				p3MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var w1Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "CompiledEntitlements.plist" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "bundle-app-extra-args" },
					{ "CodesignKeychain", "bundle-app-keychain" },
					{ "CodesignResourceRules", "bundle-app-resource-rules" },
					{ "CodesignSigningKey", "bundle-app-signing-key" },
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "bundle-app-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "bundle-app-use-secure-timestamp" },
				};

				var wp1Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "wp1.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "wp1.appex-extra-args" },
					{ "CodesignKeychain", "wp1.appex-keychain" },
					{ "CodesignResourceRules", "wp1.appex-resource-rules" },
					{ "CodesignSigningKey", "" }, // empty code signing key
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "wp1.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "wp1.appex-use-secure-timestamp" },
				};
				var wp1MetadataNativeLibraries = new Dictionary<string, string> (wp1Metadata);
				wp1MetadataNativeLibraries ["CodesignSigningKey"] = "-";
				wp1MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var wp2Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "wp2.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "wp2.appex-extra-args" },
					{ "CodesignKeychain", "wp2.appex-keychain" },
					{ "CodesignResourceRules", "wp2.appex-resource-rules" },
					{ "CodesignSigningKey", "wp2.appex-signing-key" },
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "wp2.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "wp2.appex-use-secure-timestamp" },
				};
				var wp2MetadataNativeLibraries = new Dictionary<string, string> (wp2Metadata);
				wp2MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var wp3Metadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "wp3.appex-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "wp3.appex-extra-args" },
					{ "CodesignKeychain", "wp3.appex-keychain" },
					{ "CodesignResourceRules", "wp3.appex-resource-rules" },
					{ "CodesignSigningKey", "wp3.appex-signing-key" },
					{ "CodesignStampFile", "" }, // empty stamp file
					{ "CodesignUseHardenedRuntime", "wp3.appex-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "wp3.appex-use-secure-timestamp" },
				};
				var wp3MetadataNativeLibraries = new Dictionary<string, string> (wp3Metadata);
				wp3MetadataNativeLibraries ["CodesignStampFile"] = "_CodeSignature/CodeResources";

				var createDumpMetadata = new Dictionary<string, string> {
					{ "CodesignDisableTimestamp", "true" },
					{ "CodesignEntitlements" , "createdump-entitlements" },
					{ "CodesignExecutable", "true" },
					{ "CodesignExtraArgs", "createdump-extra-args" },
					{ "CodesignKeychain", "createdump-keychain" },
					{ "CodesignResourceRules", "createdump-resource-rules" },
					{ "CodesignSigningKey", "createdump-signing-key" },
					{ "CodesignStampFile", "createdump-stamp-file" },
					{ "CodesignUseHardenedRuntime", "createdump-use-hardened-runtime" },
					{ "CodesignUseSecureTimestamp", "createdump-use-secure-timestamp" },
				};

				codesignItems = new List<ITaskItem> {
					new TaskItem ("Bundle.app/Contents/MonoBundle/createdump", createDumpMetadata),
				};

				codesignBundle = new List<ITaskItem> {
					new TaskItem ("Bundle.app", bundleAppMetadata),
					new TaskItem ("Bundle.app/PlugIns/P1.appex", p1Metadata),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex", p2Metadata),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex/PlugIns/P3.appex", p3Metadata),
					new TaskItem ("Bundle.app/Watch/W1.app", w1Metadata),
					new TaskItem ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex", wp1Metadata),
					new TaskItem ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex", wp2Metadata),
					new TaskItem ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex", wp3Metadata),
				};

				nativeStripItems = new List<ITaskItem> {
					new TaskItem ("Bundle.app/Bundle", new Dictionary<string, string> { { "StripStampFile", "bundle-strip-stamp-file" } } ),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/P1"),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex/P2"),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex/PlugIns/P3.appex/P3", new Dictionary<string, string> { { "StripStampFile", "p3-strip-stamp-file" } } ),
					new TaskItem ("Bundle.app/Watch/W1.app/W1"),
					new TaskItem ("Bundle.app/Watch/W1W1app/PlugIns/WP1.appex/WP1"),
					new TaskItem ("Bundle.app/Watch/Watch.app/PlugIns/WP1.appex/PlugIns/WP2.appex/WP2"),
					new TaskItem ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/WP3", new Dictionary<string, string> { { "StripStampFile", "wp3-strip-stamp-file" } } ),
				};

				generateDSymItems = new List<ITaskItem> {
					new TaskItem ("Bundle.app/Bundle"),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/P1"),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex/P2"),
					new TaskItem ("Bundle.app/PlugIns/P1.appex/PlugIns/P2.appex/PlugIns/P3.appex/P3"),
					new TaskItem ("Bundle.app/Watch/W1.app/W1"),
					new TaskItem ("Bundle.app/Watch/W1W1app/PlugIns/WP1.appex/WP1"),
					new TaskItem ("Bundle.app/Watch/Watch.app/PlugIns/WP1.appex/PlugIns/WP2.appex/WP2"),
					new TaskItem ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/WP3"),
				};

				var infos = new CodesignInfo [] {
					new CodesignInfo ("Bundle.app", P.All, bundleAppMetadata),
					new CodesignInfo ("Bundle.app/a.dylib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/a.dylib")),
					new CodesignInfo ("Bundle.app/Contents/b.dylib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Contents/b.dylib")),
					new CodesignInfo ("Bundle.app/Contents/MonoBundle/c.dylib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Contents/MonoBundle/c.dylib")),
					new CodesignInfo ("Bundle.app/Contents/MonoBundle/SubDir/d.dylib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Contents/MonoBundle/SubDir/d.dylib")),
					new CodesignInfo ("Bundle.app/M1.metallib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/M1.metallib")),
					new CodesignInfo ("Bundle.app/Resources/M2.metallib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Resources/M2.metallib")),
					new CodesignInfo ("Bundle.app/Contents/Resources/M3.metallib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Contents/Resources/M3.metallib")),
					new CodesignInfo ("Bundle.app/Contents/Resources/SubDir/M4.metallib", P.All, bundleAppMetadata.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/Contents/Resources/SubDir/M4.metallib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex", P.All, p1Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/P1a.dylib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/P1a.dylib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Contents/P1b.dylib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Contents/P1b.dylib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Contents/MonoBundle/P1c.dylib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Contents/MonoBundle/P1c.dylib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Contents/MonoBundle/SubDir/P1d.dylib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Contents/MonoBundle/SubDir/P1d.dylib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/PM1.metallib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/PM1.metallib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Resources/PM2.metallib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Resources/PM2.metallib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Contents/Resources/PM3.metallib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Contents/Resources/PM3.metallib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/Contents/Resources/SubDir/PM4.metallib", P.All, p1MetadataNativeLibraries.Set ("CodesignStampFile", "codesign-stamp-path/Bundle.app/PlugIns/P1.appex/Contents/Resources/SubDir/PM4.metallib")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex", P.All, p2Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/P2a.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Contents/P2b.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Contents/MonoBundle/P2c.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Contents/MonoBundle/SubDir/P2d.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/P2M1.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Resources/P2M2.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Contents/Resources/P2M3.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/Contents/Resources/SubDir/P2M4.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex", P.All, p3Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/P3a.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/P3b.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/MonoBundle/P3c.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/MonoBundle/SubDir/P3d.dylib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/P3M1.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Resources/P3M2.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/Resources/P3M3.metallib", P.All),
					new CodesignInfo ("Bundle.app/PlugIns/P1.appex/plugins/P2.appex/PlugIns/P3.appex/Contents/Resources/SubDir/P3M4.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app", P.All, w1Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Contents/b.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Contents/MonoBundle/c.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Contents/MonoBundle/SubDir/d.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/W1M1.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Resources/W1M2.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Contents/Resources/W1M3.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/Contents/Resources/SubDir/W1M4.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex", P.All, wp1Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/W1a.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Contents/W1b.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Contents/MonoBundle/W1c.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Contents/MonoBundle/SubDir/W1d.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/W1M1.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Resources/W1M2.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Contents/Resources/W1M3.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/Contents/Resources/SubDir/W1M4.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex", P.All, wp2Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/W2a.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/W2b.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/MonoBundle/W2c.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/MonoBundle/SubDir/W2c.dylib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/W2M1.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Resources/W2M2.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/Resources/W2M3.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/Contents/Resources/SubDir/W2M4.metallib", P.All),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex", P.All, wp3Metadata.Set ("CodesignStampFile", "_CodeSignature/CodeResources")),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/W3a.dylib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/W3b.dylib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/MonoBundle/W3c.dylib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/MonoBundle/SubDir/W3c.dylib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/W3M1.metallib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Resources/W3M2.metallib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/Resources/W3M3.metallib", P.All, wp3MetadataNativeLibraries),
					new CodesignInfo ("Bundle.app/Watch/W1.app/PlugIns/WP1.appex/PlugIns/WP2.appex/PlugIns/WP3.appex/Contents/Resources/SubDir/W3M4.metallib", P.All, wp3MetadataNativeLibraries),

					new CodesignInfo ("Bundle.app/Contents/MonoBundle/createdump", P.All, createDumpMetadata),
				};

				var allFiles = infos.Select (v => v.ItemSpec).ToArray ();
				Touch (tmpdir, allFiles);

				var task = CreateTask<ComputeCodesignItems> ();
				task.AppBundleDir = "Bundle.app";
				task.CodesignBundle = codesignBundle.ToArray ();
				task.CodesignItems = codesignItems.ToArray ();
				task.CodesignStampPath = "codesign-stamp-path/";
				task.GenerateDSymItems = generateDSymItems.ToArray ();
				task.NativeStripItems = nativeStripItems.ToArray ();
				task.TargetFrameworkMoniker = TargetFramework.GetTargetFramework (platform, isDotNet).ToString ();
				Assert.IsTrue (task.Execute (), "Execute");

				var outputCodesignItems = task.OutputCodesignItems;
				Assert.That (outputCodesignItems.Select (v => v.ItemSpec), Is.Unique, "Uniqueness");

				foreach (var item in outputCodesignItems)
					Console.WriteLine ($"Item to sign: {item.ItemSpec}");

				var failures = new List<string> ();
				var itemsFound = new List<ITaskItem> ();
				foreach (var info in infos) {
					var item = outputCodesignItems.SingleOrDefault (v => string.Equals (v.ItemSpec, info.ItemSpec, StringComparison.OrdinalIgnoreCase));
					info.CodesignItem = item;
					if (IsPlatform (info.SignedOn, platform)) {
						if (item is null) {
							failures.Add ($"Expected '{info.ItemSpec}' to be signed.");
							continue;
						}
					} else {
						if (item is not null) {
							failures.Add ($"Did not expect '{info.ItemSpec}' to be signed.");
							continue;
						}
					}

					if (item is null)
						continue;
					itemsFound.Add (item);

					foreach (var kvp in info.Metadata) {
						var metadata = item.GetMetadata (kvp.Key);
						if (metadata == string.Empty && kvp.Value != string.Empty) {
							failures.Add ($"Item '{info.ItemSpec}': Expected metadata '{kvp.Key}' not found (with value '{kvp.Value}').");
						} else if (!string.Equals (metadata, kvp.Value)) {
							failures.Add ($"Item '{info.ItemSpec}': Expected value '{kvp.Value}' for metadata '{kvp.Key}', but got '{metadata}' instead.");
						}
					}

					var customMetadata = item.CopyCustomMetadata ();
					foreach (var key in customMetadata.Keys.ToList ()) {
						if (info.Metadata?.ContainsKey (key) == true)
							customMetadata.Remove (key);
					}
					foreach (var custom in customMetadata) {
						failures.Add ($"Item '{info.ItemSpec}': Unexpected metadata '{custom.Key}' (with value '{custom.Value}').");
					}
				}

				var itemsNotFound = outputCodesignItems.Where (v => !itemsFound.Contains (v)).ToArray ();
				foreach (var itemNotFound in itemsNotFound) {
					failures.Add ($"Did not expect '{itemNotFound.ItemSpec}' to be signed.");
				}

				Console.WriteLine ($"{failures.Count} failures");
				foreach (var f in failures)
					Console.WriteLine (f);
				Console.WriteLine ($"{failures.Count} failures");
				Assert.That (failures, Is.Empty, "Failures");
			} finally {
				Environment.CurrentDirectory = currentDir;
			}
		}

		bool IsPlatform (P platforms, ApplePlatform platform)
		{
			switch (platform) {
			case ApplePlatform.iOS:
				return (platforms & P.iOS) == P.iOS;
			case ApplePlatform.TVOS:
				return (platforms & P.tvOS) == P.tvOS;
			case ApplePlatform.MacOSX:
				return (platforms & P.macOS) == P.macOS;
			case ApplePlatform.WatchOS:
				return (platforms & P.watchOS) == P.watchOS;
			case ApplePlatform.MacCatalyst:
				return (platforms & P.MacCatalyst) == P.MacCatalyst;
			default:
				throw new NotImplementedException ();
			}
		}

		void Touch (string root, params string [] files)
		{
			foreach (var f in files) {
				var file = Path.Combine (root, f);
				if (file.EndsWith (".appex", StringComparison.OrdinalIgnoreCase) || file.EndsWith (".app", StringComparison.OrdinalIgnoreCase)) {
					Directory.CreateDirectory (f);
				} else {
					Directory.CreateDirectory (Path.GetDirectoryName (file));
					File.WriteAllText (file, string.Empty);
				}
			}
		}

		class CodesignInfo {
			public string ItemSpec;
			public P SignedOn;
			public Dictionary<string, string> Metadata;
			public ITaskItem? CodesignItem;

			public CodesignInfo (string item, P signedOn, Dictionary<string, string>? metadata = null)
			{
				ItemSpec = item;
				SignedOn = signedOn;
				Metadata = metadata ?? new Dictionary<string, string> ();
			}
		}

		[Flags]
		enum P {
			None = 0,
			iOS = 1,
			tvOS = 2,
			watchOS = 4,
			macOS = 8,
			MacCatalyst = 16,
			Mobile = iOS | tvOS | watchOS,
			Desktop = macOS | MacCatalyst,
			All = Mobile | Desktop,
		}

	}

	public static class Dictionary_Extensions {
		public static Dictionary<string, string> Set (this Dictionary<string, string> self, string key, string value)
		{
			var rv = new Dictionary<string, string> (self);
			rv [key] = value;
			return rv;
		}
	}

	public static class ITaskItem_Extensions {
		public static Dictionary<string, string> CopyCustomMetadata (this ITaskItem self)
		{
			var rv = new Dictionary<string, string> ();
			foreach (DictionaryEntry de in self.CloneCustomMetadata ()) {
				rv [(string) de.Key] = (string) de.Value;
			}
			return rv;
		}
	}
}

