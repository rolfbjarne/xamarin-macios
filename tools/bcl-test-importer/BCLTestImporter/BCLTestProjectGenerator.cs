using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BCLTestImporter {
	/// <summary>
	/// Class that knows how to generate .csproj files based on a BCLTestProjectDefinition.
	/// </summary>
	public class BCLTestProjectGenerator {

		static string NUnitPattern = "monotouch_*_test.dll"; 
		static string xUnitPattern = "monotouch_*_xunit-test.dll";
		internal static readonly string ProjectGuidKey = "%PROJECT GUID%";
		internal static readonly string NameKey = "%NAME%";
		internal static readonly string ReferencesKey = "%REFERENCES%";
		internal static readonly string RegisterTypeKey = "%REGISTER TYPE%";
		internal static readonly string ContentKey = "%CONTENT RESOURCES%";
		internal static readonly string PlistKey = "%PLIST PATH%";
		internal static readonly string WatchOSTemplatePathKey = "%TEMPLATE PATH%";
		internal static readonly string WatchOSCsporjAppKey = "%WATCH APP PROJECT PATH%";
		internal static readonly string WatchOSCsporjExtensionKey  ="%WATCH EXTENSION PROJECT PATH%";
		internal static readonly string TargetFrameworkVersionKey = "%TARGET FRAMEWORK VERSION%";
		internal static readonly string TargetExtraInfoKey = "%TARGET EXTRA INFO%";
		internal static readonly string DefineConstantsKey = "%DEFINE CONSTANTS%";
		internal static readonly string DownloadPathKey = "%DOWNLOAD PATH%";
		static readonly Dictionary<Platform, string> plistTemplateMatches = new Dictionary<Platform, string> {
			{Platform.iOS, "Info.plist.in"},
			{Platform.TvOS, "Info-tv.plist.in"},
			{Platform.WatchOS, "Info-watchos.plist.in"},
			{Platform.MacOSFull, "Info-mac.plist.in"},
			{Platform.MacOSModern, "Info-mac.plist.in"},
		};
		static readonly Dictionary<Platform, string> projectTemplateMatches = new Dictionary<Platform, string> {
			{Platform.iOS, "BCLTests.csproj.in"},
			{Platform.TvOS, "BCLTests-tv.csproj.in"},
			{Platform.WatchOS, "BCLTests-watchos.csproj.in"},
			{Platform.MacOSFull, "BCLTests-mac.csproj.in"},
			{Platform.MacOSModern, "BCLTests-mac.csproj.in"},
		};
		static readonly Dictionary<WatchAppType, string> watchOSProjectTemplateMatches = new Dictionary<WatchAppType, string>
		{
			{ WatchAppType.App, "BCLTests-watchos-app.csproj.in"},
			{ WatchAppType.Extension, "BCLTests-watchos-extension.csproj.in"}
		};

		public enum WatchAppType {
			App,
			Extension
		}

		static readonly Dictionary<WatchAppType, string> watchOSPlistTemplateMatches = new Dictionary<WatchAppType, string> {
			{WatchAppType.App, "Info-watchos-app.plist.in"},
			{WatchAppType.Extension, "Info-watchos-extension.plist.in"}
		};

		//list of reference that we are already adding, and we do not want to readd (although it is just a warning)
		static readonly List<string> excludeDlls = new List<string> {
			"mscorlib",
			"nunitlite",
			"System",
			"System.Xml",
			"System.Xml.Linq",
			"System.Core",
			"xunit.core",
			"xunit.abstractions",
			"xunit.assert",
			"Xunit.NetCore.Extensions",
		};

		// we have two different types of list, those that are for the iOS like projects (ios, tvos and watch os) and those 
		// for mac
		static readonly List<(string name, string[] assemblies, string group)> commoniOSTestProjects = new List<(string name, string[] assemblies, string group)> {
			// NUNIT TESTS

			// BCL tests group 1
			(name:"SystemCoreTests", assemblies: new [] {"monotouch_System.Core_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemNumericsTests", assemblies: new [] {"monotouch_System.Numerics_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemRuntimeSerializationTests", assemblies: new [] {"monotouch_System.Runtime.Serialization_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemTransactionsTests", assemblies: new [] {"monotouch_System.Transactions_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemXmlTests", assemblies: new [] {"monotouch_System.Xml_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemXmlLinqTests", assemblies: new [] {"monotouch_System.Xml.Linq_test.dll"}, group: "BCL tests group 1"),
			(name:"MonoSecurityTests", assemblies: new [] {"monotouch_Mono.Security_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemComponentModelDataAnnotationsTests", assemblies: new [] {"monotouch_System.ComponentModel.DataAnnotations_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemJsonTests", assemblies: new [] {"monotouch_System.Json_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemServiceModelWebTests", assemblies: new [] {"monotouch_System.ServiceModel.Web_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemIOCompressionTests", assemblies: new [] {"monotouch_System.IO.Compression_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemIOCompressionFileSystemTests", assemblies: new [] {"monotouch_System.IO.Compression.FileSystem_test.dll"}, group: "BCL tests group 1"),
			(name:"MonoCSharpTests", assemblies: new [] {"monotouch_Mono.CSharp_test.dll"}, group: "BCL tests group 1"),
			(name:"SystemSecurityTests", assemblies: new [] {"monotouch_System.Security_test.dll"}, group: "BCL tests group 1"),
			(name:"MonoDataSqliteTests", assemblies: new [] {"monotouch_Mono.Data.Sqlite_test.dll"}, group: "BCL tests group 1"),
			(name:"MonoRuntimeTests", assemblies: new [] {"monotouch_Mono.Runtime.Tests_test.dll"}, group: "BCL tests group 1"),

			// BCL tests group 2
			(name:"SystemTests", assemblies: new[] {"monotouch_System_test.dll"}, group: "BCL tests group 2"),
			(name:"SystemDataTests", assemblies: new [] {"monotouch_System.Data_test.dll"}, group: "BCL tests group 2"),
			(name:"SystemNetHttpTests", assemblies: new [] {"monotouch_System.Net.Http_test.dll"}, group: "BCL tests group 2"),
			(name:"MonoDataTdsTests", assemblies: new [] {"monotouch_Mono.Data.Tds_test.dll"}, group: "BCL tests group 2"),
			(name:"SystemServiceModelTests", assemblies: new [] {"monotouch_System.ServiceModel_test.dll"}, group: "BCL tests group 2"),
			(name:"CorlibTests", assemblies: new [] {"monotouch_corlib_test.dll"}, group: "BCL tests group 2"),
			(name:"SystemWebServicesTests", assemblies: new [] {"monotouch_System.Web.Services_test.dll"}, group: "BCL tests group 2"),

			// XUNIT TESTS 

			// BCL tests group 3
			(name:"SystemDataXunit", assemblies: new [] {"monotouch_System.Data_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemJsonXunit", assemblies: new [] {"monotouch_System.Json_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemSecurityXunit", assemblies: new [] {"monotouch_System.Security_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemLinqXunit", assemblies: new [] {"monotouch_System.Xml.Linq_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemComponentModelCompositionXunit", assemblies: new [] {"monotouch_System.ComponentModel.Composition_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemRuntimeSerializationXunit", assemblies: new [] {"monotouch_System.Runtime.Serialization_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemXmlXunit", assemblies: new [] {"monotouch_System.Xml_xunit-test.dll"}, group: "BCL tests group 3"),
			(name:"SystemRuntimeCompilerServicesUnsafeXunit", assemblies: new [] {"monotouch_System.Runtime.CompilerServices.Unsafe_xunit-test.dll"}, group: "BCL tests group 3"),

			// BCL tests group 4
			(name:"SystemNumericsXunit", assemblies: new [] {"monotouch_System.Numerics_xunit-test.dll"}, group: "BCL tests group 4"),
			(name:"SystemCoreXunit", assemblies: new [] {"monotouch_System.Core_xunit-test.dll"}, group: "BCL tests group 4"),
			(name:"SystemXunit", assemblies: new [] {"monotouch_System_xunit-test.dll"}, group: "BCL tests group 4"),
			(name:"MicrosoftCSharpXunit", assemblies: new [] {"monotouch_Microsoft.CSharp_xunit-test.dll"}, group: "BCL tests group 4"),

			// BCL tests group 5
			(name:"CorlibXunit", assemblies: new [] {"monotouch_corlib_xunit-test.dll"}, group: "BCL tests group 5"),

			// BCL tests group 6
			(name:"SystemNetHttpUnitTestsXunit", assemblies: new [] {"monotouch_System.Net.Http.UnitTests_xunit-test.dll"}, group: "BCL tests group 6"),
			(name:"SystemNetHttpFunctionalTestsXunit", assemblies: new [] {"monotouch_System.Net.Http.FunctionalTests_xunit-test.dll"}, group: "BCL tests group 6"),
		};
			
		static readonly List <string> CommonIgnoredAssemblies = new List <string> {
			"monotouch_Commons.Xml.Relaxng_test.dll", // not supported by xamarin
			"monotouch_Cscompmgd_test.dll", // not supported by xamarin
			"monotouch_I18N.CJK_test.dll",
			"monotouch_I18N.MidEast_test.dll",
			"monotouch_I18N.Other_test.dll",
			"monotouch_I18N.Rare_test.dll",
			"monotouch_I18N.West_test.dll",
			"monotouch_Mono.C5_test.dll", // not supported by xamarin
			"monotouch_Mono.CodeContracts_test.dll", // not supported by xamarin
			"monotouch_Novell.Directory.Ldap_test.dll", // not supported by xamarin
			"monotouch_Mono.Profiler.Log_xunit-test.dll", // special tests that need an extra app to connect as a profiler
		};
		
		// list of assemblies that are going to be ignored, any project with an assemblies that is ignored will
		// be ignored

		static readonly List<string> iOSIgnoredAssemblies = new List<string> {};

		static readonly List<string> tvOSIgnoredAssemblies = new List<string> {
			"monotouch_corlib_xunit-test.dll", // ignored due to https://github.com/xamarin/maccore/issues/1611 until mono fixes it
			"monotouch_System_xunit-test.dll", // ignored due to https://github.com/xamarin/maccore/issues/1610
		};

		static readonly List<string> watcOSIgnoredAssemblies = new List<string> {
			"monotouch_Mono.Security_test.dll",
			"monotouch_Mono.Data.Tds_test.dll", // not present in the watch tests dlls
		};

		private static readonly List<(string name, string[] assemblies, string group)> macTestProjects = new List<(string name, string[] assemblies, string group)> {
		
			// NUNIT Projects
			(name:"MonoDataSqliteTests", assemblies: new [] {"xammac_net_4_5_Mono.Data.Sqlite_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"MonoDataTdsTests", assemblies: new [] {"xammac_net_4_5_Mono.Data.Tds_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"MonoMessagingTests", assemblies: new [] {"xammac_net_4_5_Mono.Messaging_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"MonoPoxisTests", assemblies: new [] {"xammac_net_4_5_Mono.Posix_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"MonoSecurityTests", assemblies: new [] {"xammac_net_4_5_Mono.Security_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemConfigurationTests", assemblies: new [] {"xammac_net_4_5_System.Configuration_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemDataLinqTests", assemblies: new [] {"xammac_net_4_5_System.Data.Linq_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemDataTests", assemblies: new [] {"xammac_net_4_5_System.Data_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemIOCompressionFileSystemTests", assemblies: new [] {"xammac_net_4_5_System.IO.Compression.FileSystem_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemIOCompressionTests", assemblies: new [] {"xammac_net_4_5_System.IO.Compression_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemIdentityModelTests", assemblies: new [] {"xammac_net_4_5_System.IdentityModel_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemJsonTests", assemblies: new [] {"xammac_net_4_5_System.Json_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemMessagingTests", assemblies: new [] {"xammac_net_4_5_System.Messaging_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemNetHttpWebRequestTests", assemblies: new [] {"xammac_net_4_5_System.Net.Http.WebRequest_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemNumericsTests", assemblies: new [] {"xammac_net_4_5_System.Numerics_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemRuntimeSerializationFormattersSoapTests", assemblies: new [] {"xammac_net_4_5_System.Runtime.Serialization.Formatters.Soap_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemRuntimeSerializationTests", assemblies: new [] {"xammac_net_4_5_System.Runtime.Serialization_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemServiceModelWebTest", assemblies: new [] {"xammac_net_4_5_System.ServiceModel.Web_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemServiceModelTests", assemblies: new [] {"xammac_net_4_5_System.ServiceModel_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemTransactionsTests", assemblies: new [] {"xammac_net_4_5_System.Transactions_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemWebServicesTests", assemblies: new [] {"xammac_net_4_5_System.Web.Services_test.dll"}, group: "Mac OS X BCL tests group 1"),
			(name:"SystemXmlLinqTests", assemblies: new [] {"xammac_net_4_5_System.Xml.Linq_test.dll"}, group: "Mac OS X BCL tests group 1"),
		
			(name:"SystemNetHttpTests", assemblies: new [] {"xammac_net_4_5_System.Net.Http_test.dll"}, group: "Mac OS X BCL tests group 2"), // do not mix with SystemNetHttpWebRequestTests since there is a type collision
			(name:"SystemComponentModelDataAnnotationsTests", assemblies: new [] {"xammac_net_4_5_System.ComponentModel.DataAnnotations_test.dll"}, group: "Mac OS X BCL tests group 2"),
			(name:"SystemCoreTests", assemblies: new [] {"xammac_net_4_5_System.Core_test.dll"}, group: "Mac OS X BCL tests group 2"),
			(name:"SystemSecurityTests", assemblies: new [] {"xammac_net_4_5_System.Security_test.dll"}, group: "Mac OS X BCL tests group 2"),
			(name:"SystemXmlTests", assemblies: new [] {"xammac_net_4_5_System.Xml_test.dll"}, group: "Mac OS X BCL tests group 2"),
			(name:"SystemTests", assemblies: new [] {"xammac_net_4_5_System_test.dll"}, group: "Mac OS X BCL tests group 2"),
			(name:"MonoCSharpTests", assemblies: new [] {"xammac_net_4_5_Mono.CSharp_test.dll"}, group: "Mac OS X BCL tests group 2"), // if add to the first group, it blocks 'til a timeout, mono issue
			
			(name:"CorlibTests", assemblies: new [] {"xammac_net_4_5_corlib_test.dll"}, group: "Mac OS X BCL tests group 3"),
			
			// xUnit Projects
			(name:"MicrosoftCSharpXunit", assemblies: new [] {"xammac_net_4_5_Microsoft.CSharp_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemComponentModelCompositionXunit", assemblies: new [] {"xammac_net_4_5_System.ComponentModel.Composition_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemCoreXunit", assemblies: new [] {"xammac_net_4_5_System.Core_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemDataXunit", assemblies: new [] {"xammac_net_4_5_System.Data_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemJsonXunit", assemblies: new [] {"xammac_net_4_5_System.Json_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemNetHttpFunctionalTestsXunit", assemblies: new [] {"xammac_net_4_5_System.Net.Http.FunctionalTests_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemNetHttpUnitTestsXunit", assemblies: new [] {"xammac_net_4_5_System.Net.Http.UnitTests_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemNumericsXunit", assemblies: new [] {"xammac_net_4_5_System.Numerics_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemRuntimeCompilerServicesUnsafeXunit", assemblies: new [] {"xammac_net_4_5_System.Runtime.CompilerServices.Unsafe_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemSecurityXunit", assemblies: new [] {"xammac_net_4_5_System.Security_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemXmlLinqXunit", assemblies: new [] {"xammac_net_4_5_System.Xml.Linq_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemXmlXunit", assemblies: new [] {"xammac_net_4_5_System.Xml_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			(name:"SystemXunit", assemblies: new [] {"xammac_net_4_5_System_xunit-test.dll"}, group: "Mac OS X BCL tests group 4"),
			
			(name:"CorlibXunit", assemblies: new [] {"xammac_net_4_5_corlib_xunit-test.dll"}, group: "Mac OS X BCL tests group 5"),

		};
		
		static readonly List<(string assembly, Platform[] platforms)> macIgnoredAssemblies = new List<(string assembly, Platform[] platforms)> {
			(assembly: "xammac_net_4_5_I18N.CJK_test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), 
			(assembly: "xammac_net_4_5_I18N.MidEast_test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), 
			(assembly: "xammac_net_4_5_I18N.Other_test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), 
			(assembly: "xammac_net_4_5_I18N.Rare_test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), 
			(assembly: "xammac_net_4_5_I18N.West_test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), 
			(assembly: "xammac_net_4_5_System.Runtime.Serialization.Formatters.Soap_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_System.Net.Http.WebRequest_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_System.Messaging_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_System.IdentityModel_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_System.Data.Linq_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_Mono.Posix_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_Mono.Messaging_test.dll", platforms: new [] { Platform.MacOSModern}), // not present 
			(assembly: "xammac_net_4_5_System.Data_test.dll", platforms: new [] { Platform.MacOSModern }), // tests use 'System.Configuration.IConfigurationSectionHandler' not present in modern 
			(assembly: "xammac_net_4_5_System.Configuration_test.dll", platforms: new [] { Platform.MacOSModern }), // Not present in modern, ergo all tests will fail
			(assembly: "xammac_net_4_5_corlib_xunit-test.dll", platforms: new [] { Platform.MacOSFull, Platform.MacOSModern }), // issues https://github.com/xamarin/maccore/issues/1203
		};

		readonly bool isCodeGeneration;
		public bool Override { get; set; }
		public bool GroupTests { get; set; }
		public string OutputDirectoryPath { get; private  set; }
		public string MonoRootPath { get; private set; }
		public string iOSMonoSDKPath { get; set; }
		public string MacMonoSDKPath { get; set; }
		public string ProjectTemplateRootPath { get; private set; }
		public string PlistTemplateRootPath{ get; private set; }
		public string RegisterTypesTemplatePath { get; private set; }
		public Func<string, Guid> GuidGenerator { get; set; }
		string GeneratedCodePathRoot => Path.Combine (OutputDirectoryPath, "generated");
		string WatchContainerTemplatePath => Path.Combine (OutputDirectoryPath, "templates", "watchOS", "Container").Replace ("/", "\\");
		string WatchAppTemplatePath => Path.Combine (OutputDirectoryPath, "templates", "watchOS", "App").Replace ("/", "\\");
		string WatchExtensionTemplatePath => Path.Combine (OutputDirectoryPath, "templates", "watchOS", "Extension").Replace ("/", "\\");

		public BCLTestProjectGenerator (string outputDirectory)
		{
			OutputDirectoryPath = outputDirectory ?? throw new ArgumentNullException (nameof (outputDirectory));
		}
		
		public BCLTestProjectGenerator (string outputDirectory, string monoRootPath, string projectTemplatePath, string registerTypesTemplatePath, string plistTemplatePath)
		{
			isCodeGeneration = true;
			OutputDirectoryPath = outputDirectory ?? throw new ArgumentNullException (nameof (outputDirectory));
			MonoRootPath = monoRootPath ?? throw new ArgumentNullException (nameof (monoRootPath));
			ProjectTemplateRootPath = projectTemplatePath ?? throw new ArgumentNullException (nameof (projectTemplatePath));
			PlistTemplateRootPath = plistTemplatePath ?? throw new ArgumentNullException (nameof (plistTemplatePath));
			RegisterTypesTemplatePath = registerTypesTemplatePath ?? throw new ArgumentNullException (nameof (registerTypesTemplatePath));
		}

		string GetReleaseDownload (Platform platform)
		{
			switch (platform) {
			case Platform.iOS:
			case Platform.TvOS:
			case Platform.WatchOS:
				// simply, try to find the dir with the pattern
				return iOSMonoSDKPath;
			case Platform.MacOSFull:
			case Platform.MacOSModern:
				return MacMonoSDKPath;
			default:
				return null;
			}
		}

		/// <summary>
		/// Returns the path to be used to store the project file depending on the platform.
		/// </summary>
		/// <param name="projectName">The name of the project being generated.</param>
		/// <param name="platform">The supported platform by the project.</param>
		/// <returns></returns>
		internal string GetProjectPath (string projectName, Platform platform)
		{
			switch (platform) {
			case Platform.iOS:
				return Path.Combine (OutputDirectoryPath, $"{projectName}.csproj");
			case Platform.TvOS:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-tvos.csproj");
			case Platform.WatchOS:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-watchos.csproj");
			case Platform.MacOSFull:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-mac-full.csproj");
			case Platform.MacOSModern:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-mac-modern.csproj");
			default:
				return null;
			}
		}
		
		internal string GetProjectPath (string projectName, WatchAppType appType)
		{
			switch (appType) {
			case WatchAppType.App:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-watchos-app.csproj");
			default:
				return Path.Combine (OutputDirectoryPath, $"{projectName}-watchos-extension.csproj");
			}
		}

		/// <summary>
		/// Returns the path to be used to store the projects plist file depending on the platform.
		/// </summary>
		/// <param name="rootDir">The root dir to use.</param>
		/// <param name="platform">The platform that is supported by the project.</param>
		/// <returns></returns>
		internal static string GetPListPath (string rootDir, Platform platform)
		{
			switch (platform) {
			case Platform.iOS:
				return Path.Combine (rootDir, "Info.plist");
			case Platform.TvOS:
				return Path.Combine (rootDir, "Info-tv.plist");
			case Platform.WatchOS:
				return Path.Combine (rootDir, "Info-watchos.plist");
			case Platform.MacOSFull:
			case Platform.MacOSModern:
				return Path.Combine (rootDir, "Info-mac.plist");
			default:
				return Path.Combine (rootDir, "Info.plist");
			}
		}

		internal static string GetPListPath (string rootDir, WatchAppType appType)
		{
			switch (appType) {
				case WatchAppType.App:
					return Path.Combine (rootDir, "Info-watchos-app.plist");
				default:
					return Path.Combine (rootDir, "Info-watchos-extension.plist");
			}
		}
		
		// creates the reference node
		internal static string GetReferenceNode (string assemblyName, string hintPath = null)
		{
			// lets not complicate our life with Xml, we just need to replace two things
			if (string.IsNullOrEmpty (hintPath)) {
				return $"<Reference Include=\"{assemblyName}\" />";
			} else {
				// the hint path is using unix separators, we need to use windows ones
				hintPath = hintPath.Replace ('/', '\\');
				var sb = new StringBuilder ();
				sb.AppendLine ($"<Reference Include=\"{assemblyName}\" >");
				sb.AppendLine ($"<HintPath>{hintPath}</HintPath>");
				sb.AppendLine ("</Reference>");
				return sb.ToString ();
			}
		}

		internal static string GetRegisterTypeNode (string registerPath)
		{
			var sb = new StringBuilder ();
			sb.AppendLine ($"<Compile Include=\"{registerPath}\">");
			sb.AppendLine ($"<Link>{Path.GetFileName (registerPath)}</Link>");
			sb.AppendLine ("</Compile>");
			return sb.ToString ();
		}

		internal static string GetContentNode (string resourcePath)
		{
			var sb = new StringBuilder ();
			sb.AppendLine ($"<Content Include=\"{resourcePath}\">");
			sb.AppendLine ($"<Link>{Path.GetFileName (resourcePath)}</Link>");
			sb.AppendLine ("<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>");
			sb.AppendLine ("</Content>");
			return sb.ToString ();
		}

		internal static string GetCommonIgnoreFileName (string name, Platform platform)
		{
			switch (platform) {
			case Platform.TvOS:
				return $"common-{name.Replace ("monotouch_tv_", "monotouch_")}.ignore";
			case Platform.WatchOS:
				return $"common-{name.Replace ("monotouch_watch_", "monotouch_")}.ignore";
			default:
				return $"common-{name}.ignore";
			}
		} 
		
		internal static string[] GetIgnoreFileNames (string name, Platform platform)
		{
			switch (platform) {
			case Platform.iOS:
				return new string [] { $"iOS-{name}.ignore" };
			case Platform.MacOSFull:
				return new string [] { $"macOSFull-{name}.ignore", $"macOS-{name}.ignore" };
			case Platform.MacOSModern:
				return new string [] { $"macOSModern-{name.Replace ("xammac_", "xammac_net_4_5_")}.ignore", $"macOS-{name.Replace ("xammac_", "xammac_net_4_5_")}.ignore" };
			case Platform.TvOS:
				return new string [] { $"tvOS-{name.Replace ("monotouch_tv_", "monotouch_")}.ignore" };
			case Platform.WatchOS:
				return new string [] { $"watchOS-{name.Replace ("monotouch_watch_", "monotouch_")}.ignore" };
			default:
				return null;
			}
		}
		
		internal static IEnumerable<string> GetIgnoreFiles (string templatePath, string projectName, List<(string assembly, string hintPath)> assemblies, Platform platform)
		{
			// check if the common and plaform paths can be found in the template path, if they are, we return them
			var templateDir = Path.GetDirectoryName (templatePath);
			var commonIgnore = Path.Combine (templateDir, GetCommonIgnoreFileName (projectName, platform));
			if (File.Exists (commonIgnore))
				yield return commonIgnore;
			foreach (var platformFile in GetIgnoreFileNames (projectName, platform)) {
				var platformIgnore = Path.Combine (templateDir, platformFile);
				if (File.Exists (platformIgnore))
					yield return platformIgnore;
			}
			// do we have ignores per files and not the project name? Add them
			foreach (var (assembly, hintPath) in assemblies) {
				foreach (var platformFile in GetIgnoreFileNames (assembly, platform)) {
					var commonAssemblyIgnore = Path.Combine (templateDir, GetCommonIgnoreFileName (assembly, platform));
					if (File.Exists (commonAssemblyIgnore))
						yield return commonAssemblyIgnore;
					var platformAssemblyIgnore = Path.Combine (templateDir, platformFile);
					if (File.Exists (platformAssemblyIgnore))
						yield return platformAssemblyIgnore;
				}
			}
		}

		/// <summary>
		/// Returns is a project should be ignored in a platform. A project is ignored in one of the assemblies in the
		/// project is ignored in the platform.
		/// </summary>
		/// <param name="project">The project which is under test.</param>
		/// <param name="platform">The platform to which we are testing against.</param>
		/// <returns>If the project should be ignored in a platform or not.</returns>
		bool IsIgnored(BCLTestProjectDefinition project, Platform platform)
		{
			foreach (var a in project.TestAssemblies){
				if (CommonIgnoredAssemblies.Contains (a.Name))
					return true;
				switch (platform){
				case Platform.iOS:
					return iOSIgnoredAssemblies.Contains (a.Name);
				case Platform.TvOS:
					return tvOSIgnoredAssemblies.Contains (a.Name);
				case Platform.WatchOS:
					return watcOSIgnoredAssemblies.Contains (a.Name);
				case Platform.MacOSFull:
					return macIgnoredAssemblies.Any ((ignored) => (ignored.assembly == a.Name) && ignored.platforms.Contains (Platform.MacOSFull));
				case Platform.MacOSModern:
					return macIgnoredAssemblies.Any ((ignored) => (ignored.assembly == a.Name) && ignored.platforms.Contains (Platform.MacOSModern));
				}
			}
			return false;
		}
		
		bool IsIgnored (string a, Platform platform)
		{
			if (CommonIgnoredAssemblies.Contains (a))
				return true;
			switch (platform) {
			case Platform.iOS:
				return iOSIgnoredAssemblies.Contains (a);
			case Platform.TvOS:
				return tvOSIgnoredAssemblies.Contains (a);
			case Platform.WatchOS:
				return watcOSIgnoredAssemblies.Contains (a);
			case Platform.MacOSFull:
				return macIgnoredAssemblies.Any ((ignored) => (ignored.assembly == a) && ignored.platforms.Contains (Platform.MacOSFull));
			case Platform.MacOSModern:
				return macIgnoredAssemblies.Any ((ignored) => (ignored.assembly == a) && ignored.platforms.Contains (Platform.MacOSModern));
			}
			return false;
		}

		async Task<List<(string name, string path, bool xunit, string failure)>> GenerateWatchOSTestProjectsAsync (
			IEnumerable<(string name, string[] assemblies)> projects, string generatedDir)
		{
			var projectPaths = new List<(string name, string path, bool xunit, string failure)> ();
			foreach (var def in projects) {
				// each watch os project requires 3 different ones:
				// 1. The app
				// 2. The container
				// 3. The extensions
				// TODO: The following is very similar to what is done in the iOS generation. Must be grouped
				var projectDefinition = new BCLTestProjectDefinition (def.name, def.assemblies);
				if (IsIgnored (projectDefinition, Platform.WatchOS)) // if it is ignored, continue
					continue;

				if (!projectDefinition.Validate ())
					throw new InvalidOperationException ("xUnit and NUnit assemblies cannot be mixed in a test project.");
				var generatedCodeDir = Path.Combine (generatedDir, projectDefinition.Name, "watch");
				if (!Directory.Exists (generatedCodeDir)) {
					Directory.CreateDirectory (generatedCodeDir);
				}
				var registerTypePath = Path.Combine (generatedCodeDir, "RegisterType.cs");
				string failure = null;
				string rootProjectPath = GetProjectPath (projectDefinition.Name, Platform.WatchOS); ;
				try {
					// create the plist for each of the apps
					var projectData = new Dictionary<WatchAppType, (string plist, string project)> ();
					foreach (var appType in new [] { WatchAppType.Extension, WatchAppType.App }) {
						(string plist, string project) data;
						var plistTemplate = Path.Combine (PlistTemplateRootPath, watchOSPlistTemplateMatches [appType]);
						var plist = await BCLTestInfoPlistGenerator.GenerateCodeAsync (plistTemplate, projectDefinition.Name);
						data.plist = GetPListPath (generatedCodeDir, appType);
						using (var file = new StreamWriter (data.plist, false)) { // false is do not append
							await file.WriteAsync (plist);
						}

						string generatedProject;
						var projetTemplate = Path.Combine (ProjectTemplateRootPath, watchOSProjectTemplateMatches [appType]);
						switch (appType) {
						case WatchAppType.App:
							generatedProject = await GenerateWatchAppAsync (projectDefinition.Name, projetTemplate, data.plist);
							break;
						default:
							var info = projectDefinition.GetAssemblyInclusionInformation (GetReleaseDownload (Platform.WatchOS), Platform.WatchOS, true);
							generatedProject = await GenerateWatchExtensionAsync (projectDefinition.Name, projetTemplate, data.plist, registerTypePath, info);
							failure = failure ?? info.FailureMessage;
							break;
						}
						data.project = GetProjectPath (projectDefinition.Name, appType);
						using (var file = new StreamWriter (data.project, false)) { // false is do not append
							await file.WriteAsync (generatedProject);
						}

						projectData [appType] = data;
					} // foreach app type

					var rootPlistTemplate = Path.Combine (PlistTemplateRootPath, plistTemplateMatches [Platform.WatchOS]);
					var rootPlist = await BCLTestInfoPlistGenerator.GenerateCodeAsync (rootPlistTemplate, projectDefinition.Name);
					var infoPlistPath = GetPListPath (generatedCodeDir, Platform.WatchOS);
					using (var file = new StreamWriter (infoPlistPath, false)) { // false is do not append
						await file.WriteAsync (rootPlist);
					}

					var projectTemplatePath = Path.Combine (ProjectTemplateRootPath, projectTemplateMatches [Platform.WatchOS]);
					using (var file = new StreamWriter (rootProjectPath, false)) // false is do not append
					using (var reader = new StreamReader (projectTemplatePath)) {
						var template = await reader.ReadToEndAsync ();
						var generatedRootProject = GenerateWatchProject (def.name, template, infoPlistPath);
						await file.WriteAsync (generatedRootProject);
					}
					var typesPerAssembly = projectDefinition.GetTypeForAssemblies (GetReleaseDownload (Platform.iOS), Platform.WatchOS, true);
					var registerCode = await RegisterTypeGenerator.GenerateCodeAsync (typesPerAssembly,
						projectDefinition.IsXUnit, RegisterTypesTemplatePath);
					using (var file = new StreamWriter (registerTypePath, false)) { // false is do not append
						await file.WriteAsync (registerCode);
					}

					failure = failure ?? typesPerAssembly.FailureMessage;
				} catch (Exception e) {
					failure = e.Message;
				}
				// we have the 3 projects we depend on, we need the root one, the one that will be used by harness
				projectPaths.Add ((name: projectDefinition.Name, path: rootProjectPath, xunit: projectDefinition.IsXUnit, failure: failure));
			} // foreach project

			return projectPaths;
		}
		
		async Task<List<(string name, string path, bool xunit, string failure)>> GenerateiOSTestProjectsAsync (
			IEnumerable<(string name, string[] assemblies)> projects, Platform platform, string generatedDir)
		{
			if (platform == Platform.WatchOS) 
				throw new ArgumentException (nameof (platform));
			if (!projects.Any()) // return an empty list
				return new List<(string name, string path, bool xunit, string failure)> ();
			var projectPaths = new List<(string name, string path, bool xunit, string failure)> ();
			foreach (var def in projects) {
				if (def.assemblies.Length == 0)
					continue;
				var projectDefinition = new BCLTestProjectDefinition (def.name, def.assemblies);
				if (IsIgnored (projectDefinition, platform)) // some projects are ignored, so we just continue
					continue;

				if (!projectDefinition.Validate ())
					throw new InvalidOperationException ("xUnit and NUnit assemblies cannot be mixed in a test project.");
				// generate the required type registration info
				var generatedCodeDir = Path.Combine (generatedDir, projectDefinition.Name, (platform == Platform.iOS)?"ios": "tv");
				if (!Directory.Exists (generatedCodeDir)) {
					Directory.CreateDirectory (generatedCodeDir);
				}
				var registerTypePath = Path.Combine (generatedCodeDir, "RegisterType.cs");

				string projectPath = GetProjectPath (projectDefinition.Name, platform);
				string failure = null;
				try {
					var plistTemplate = Path.Combine (PlistTemplateRootPath, plistTemplateMatches [platform]);
					var plist = await BCLTestInfoPlistGenerator.GenerateCodeAsync (plistTemplate, projectDefinition.Name);
					var infoPlistPath = GetPListPath (generatedCodeDir, platform);
					using (var file = new StreamWriter (infoPlistPath, false)) { // false is do not append
						await file.WriteAsync (plist);
					}

					var projectTemplatePath = Path.Combine (ProjectTemplateRootPath, projectTemplateMatches [platform]);
					var info = projectDefinition.GetAssemblyInclusionInformation (GetReleaseDownload (platform), platform, true);
					var generatedProject = await GenerateAsync (projectDefinition.Name, registerTypePath, info, projectTemplatePath, infoPlistPath, platform);
					using (var file = new StreamWriter (projectPath, false)) { // false is do not append
						await file.WriteAsync (generatedProject);
					}
					var typesPerAssembly = projectDefinition.GetTypeForAssemblies (GetReleaseDownload (platform), platform, true);
					var registerCode = await RegisterTypeGenerator.GenerateCodeAsync (typesPerAssembly,
						projectDefinition.IsXUnit, RegisterTypesTemplatePath);

					using (var file = new StreamWriter (registerTypePath, false)) { // false is do not append
						await file.WriteAsync (registerCode);
					}

					failure = failure ?? info.FailureMessage;
					failure = failure ?? typesPerAssembly.FailureMessage;
				} catch (Exception e) {
					failure = e.Message;
				}
				projectPaths.Add ((name: projectDefinition.Name, path: projectPath, xunit: projectDefinition.IsXUnit, failure: failure));
			} // foreach project

			return projectPaths;
		}
		
		async Task<List<(string name, string path, bool xunit, string failure)>> GenerateMacTestProjectsAsync (
			IEnumerable<(string name, string[] assemblies)> projects, string generatedDir, Platform platform)
		{
			var projectPaths = new List<(string name, string path, bool xunit, string failure)> ();
			foreach (var def in projects) {
				if (!def.assemblies.Any ())
					continue;
				var projectDefinition = new BCLTestProjectDefinition (def.name, def.assemblies);
				if (IsIgnored (projectDefinition, platform)) // some projects are ignored, so we just continue
					continue;

				if (!projectDefinition.Validate ())
					throw new InvalidOperationException ("xUnit and NUnit assemblies cannot be mixed in a test project.");
				// generate the required type registration info
				var generatedCodeDir = Path.Combine (generatedDir, projectDefinition.Name, "mac");
				Directory.CreateDirectory (generatedCodeDir);
				var registerTypePath = Path.Combine (generatedCodeDir, "RegisterType-mac.cs");

				var typesPerAssembly = projectDefinition.GetTypeForAssemblies (GetReleaseDownload (platform), platform, true);
				var registerCode = await RegisterTypeGenerator.GenerateCodeAsync (typesPerAssembly,
					projectDefinition.IsXUnit, RegisterTypesTemplatePath);

				using (var file = new StreamWriter (registerTypePath, false)) { // false is do not append
					await file.WriteAsync (registerCode);
				}
				
				var plistTemplate = Path.Combine (PlistTemplateRootPath, plistTemplateMatches[platform]);
				var plist = await BCLTestInfoPlistGenerator.GenerateCodeAsync (plistTemplate, projectDefinition.Name);
				var infoPlistPath = GetPListPath (generatedCodeDir, platform);
				using (var file = new StreamWriter (infoPlistPath, false)) { // false is do not append
					await file.WriteAsync (plist);
				}

				var projectTemplatePath = Path.Combine (ProjectTemplateRootPath, projectTemplateMatches[platform]);
				var info = projectDefinition.GetAssemblyInclusionInformation (GetReleaseDownload (platform), platform, true);
				var generatedProject = await GenerateMacAsync (projectDefinition.Name, registerTypePath,
					info, projectTemplatePath, infoPlistPath, platform);
					
				var projectPath = GetProjectPath (projectDefinition.Name, platform);
				projectPaths.Add ((name: projectDefinition.Name, path: projectPath, xunit: projectDefinition.IsXUnit, failure: null));
				using (var file = new StreamWriter (projectPath, false)) { // false is do not append
					await file.WriteAsync (generatedProject);
				}
			}
			return projectPaths;
		}

		/// <summary>
		/// Generates all the project files for the given projects and platform
		/// </summary>
		/// <param name="projects">The list of projects to be generated.</param>
		/// <param name="platform">The platform to which the projects have to be generated. Each platform
		/// has its own details.</param>
		/// <param name="generatedDir">The dir where the projects will be saved.</param>
		/// <returns></returns>
		public async Task<List<(string name, string path, bool xunit, string failure)>> GenerateTestProjectsAsync (
			IEnumerable<(string name, string[] assemblies)> projects, Platform platform, string generatedDir)
		{
			var result = new List<(string name, string path, bool xunit, string failure)> ();
			switch (platform) {
			case Platform.WatchOS:
				result = await GenerateWatchOSTestProjectsAsync (projects, generatedDir);
				break;
			case Platform.iOS:
			case Platform.TvOS:
				result = await GenerateiOSTestProjectsAsync (projects, platform, generatedDir);
				break;
			case Platform.MacOSFull:
			case Platform.MacOSModern:
				result = await GenerateMacTestProjectsAsync (projects, generatedDir, platform);
				break;
			}
			return result;
		}
		
		List <(string name, string[] assemblies)> GetProjectDefinitions (List<(string name, string [] assemblies, string group)> definitions, Platform platform)
		{

			List<(string name, string [] assemblies)> testProjects = new List<(string name, string [] assemblies)> ();
			if (GroupTests && platform != Platform.WatchOS) {
				// build the grouped apps 
				var groupedApps = new Dictionary<string, List<string>> ();
				foreach (var (name, assemblies, group) in definitions) {
					var validAssemblies = new List<string> ();
					foreach (var a in assemblies) { // filter ignored assemblies
						if (!IsIgnored (a, platform)) 
							validAssemblies.Add (a);
					}
					if (groupedApps.ContainsKey (group)) {
						groupedApps [group].AddRange (validAssemblies);
					} else {
						groupedApps [group] = new List<string> (validAssemblies);
					}
				}
				foreach (var group in groupedApps.Keys) {
					testProjects.Add ((name: group, assemblies: groupedApps [group].ToArray ()));
				}
			} else {
				foreach (var (name, assemblies, group) in definitions) {
					testProjects.Add ((name, assemblies));
				}
			}
			return testProjects;
		}
		// generates a project per platform of the common projects. 
		async Task<List<(string name, string path, bool xunit, List<Platform> platforms, string failure)>> GenerateAllCommonTestProjectsAsync ()
		{
			var projectPaths = new List<(string name, string path, bool xunit, List<Platform> platforms, string failure)> ();
			if (!isCodeGeneration)
				throw new InvalidOperationException ("Project generator was instantiated to delete the generated code.");
			var generatedCodePathRoot = GeneratedCodePathRoot;
			if (!Directory.Exists (generatedCodePathRoot)) {
				Directory.CreateDirectory (generatedCodePathRoot);
			}

			var projects = new Dictionary<string, (string path, bool xunit, List<Platform> platforms, string failure)> ();
			foreach (var platform in new [] {Platform.iOS, Platform.TvOS, Platform.WatchOS}) {
				var generated = await GenerateTestProjectsAsync (GetProjectDefinitions (commoniOSTestProjects, platform), platform, generatedCodePathRoot);
				foreach (var (name, path, xunit, failure) in generated) {
					if (!projects.ContainsKey (name)) {
						projects [name] = (path, xunit, new List<Platform> { platform }, failure);
					} else {
						projects [name].platforms.Add (platform);
					}
				}
			} // foreach platform
			
			// return the grouped projects
			foreach (var name in projects.Keys) {
				projectPaths.Add ((name, projects[name].path, projects[name].xunit, projects[name].platforms, projects[name].failure));
			}
			return projectPaths;
		}
		
		// creates all the projects that have already been defined
		public async Task<List<(string name, string path, bool xunit, List<Platform> platforms, string failure)>> GenerateAlliOSTestProjectsAsync ()
		{
			var projectPaths = new List<(string name, string path, bool xunit, List<Platform> platforms, string failure)> ();
			if (!isCodeGeneration)
				throw new InvalidOperationException ("Project generator was instantiated to delete the generated code.");
			var generatedCodePathRoot = GeneratedCodePathRoot;
			if (!Directory.Exists (generatedCodePathRoot)) {
				Directory.CreateDirectory (generatedCodePathRoot);
			}
			// generate all the common projects
			projectPaths.AddRange (await GenerateAllCommonTestProjectsAsync ());

			return projectPaths;
		}

		public List<(string name, string path, bool xunit, List<Platform> platforms, string failure)> GenerateAlliOSTestProjects () => GenerateAlliOSTestProjectsAsync ().Result;
		
		public async Task<List<(string name, string path, bool xunit, string failure)>> GenerateAllMacTestProjectsAsync (Platform platform)
		{
			if (!isCodeGeneration)
				throw new InvalidOperationException ("Project generator was instantiated to delete the generated code.");
			var generatedCodePathRoot = GeneratedCodePathRoot;
			if (!Directory.Exists (generatedCodePathRoot)) {
				Directory.CreateDirectory (generatedCodePathRoot);
			}
			var generated = await GenerateTestProjectsAsync (GetProjectDefinitions (macTestProjects, platform), platform, generatedCodePathRoot);
			return generated;
		}

		public List<(string name, string path, bool xunit, string failure)> GenerateAllMacTestProjects (Platform platform) => GenerateAllMacTestProjectsAsync (platform).Result;

		/// <summary>
		/// Generates an iOS project for testing purposes. The generated project will contain the references to the
		/// mono test assemblies to run.
		/// </summary>
		/// <param name="projectName">The name of the project under generation.</param>
		/// <param name="registerPath">The path to the code that register the types so that the assemblies are not linked.</param>
		/// <param name="info">The list of assemblies to be added to the project and their hint paths.</param>
		/// <param name="templatePath">A path to the template used to generate the path.</param>
		/// <param name="infoPlistPath">The path to the info plist of the project.</param>
		/// <returns></returns>
		async Task<string> GenerateAsync (string projectName, string registerPath, (string FailureMessage, List<(string assembly, string hintPath)> Assemblies) info, string templatePath, string infoPlistPath, Platform platform)
		{
			var downloadPath = GetReleaseDownload (platform).Replace ("/", "\\");
			// fix possible issues with the paths to be included in the msbuild xml
			infoPlistPath = infoPlistPath.Replace ('/', '\\');
			var sb = new StringBuilder ();
			if (!string.IsNullOrEmpty (info.FailureMessage)) {
				WriteReferenceFailure (sb, info.FailureMessage);
			} else {
				foreach (var assemblyInfo in info.Assemblies) {
					if (!excludeDlls.Contains (assemblyInfo.assembly))
						sb.AppendLine (GetReferenceNode (assemblyInfo.assembly, assemblyInfo.hintPath));
				}
			}
			
			var contentFiles = new StringBuilder ();
			foreach (var path in GetIgnoreFiles (templatePath, projectName, info.Assemblies, platform)) {
				contentFiles.Append (GetContentNode (path));
			}
			var projectGuid = GuidGenerator?.Invoke (projectName) ?? Guid.NewGuid ();
			using (var reader = new StreamReader(templatePath)) {
				var result = await reader.ReadToEndAsync ();
				result = result.Replace (DownloadPathKey, downloadPath);
				result = result.Replace (ProjectGuidKey, projectGuid.ToString ().ToUpperInvariant ());
				result = result.Replace (NameKey, projectName);
				result = result.Replace (ReferencesKey, sb.ToString ());
				result = result.Replace (RegisterTypeKey, GetRegisterTypeNode (registerPath));
				result = result.Replace (PlistKey, infoPlistPath);
				result = result.Replace (ContentKey, contentFiles.ToString ());
				return result;
			}
		}
		
		async Task<string> GenerateMacAsync (string projectName, string registerPath,  (string FailureMessage, List<(string assembly, string hintPath)> Assemblies) info, string templatePath, string infoPlistPath, Platform platform)
		{
			var downloadPath = Path.Combine(GetReleaseDownload (platform), "mac-bcl", platform == Platform.MacOSFull? "xammac_net_4_5" : "xammac").Replace ("/", "\\");
			infoPlistPath = infoPlistPath.Replace ('/', '\\');
			var sb = new StringBuilder ();
			if (!string.IsNullOrEmpty (info.FailureMessage)) {
				WriteReferenceFailure (sb, info.FailureMessage);
			} else {
				foreach (var assemblyInfo in info.Assemblies) {
					if (!excludeDlls.Contains (assemblyInfo.assembly))
						sb.AppendLine (GetReferenceNode (assemblyInfo.assembly, assemblyInfo.hintPath));
				}
			}

			var contentFiles = new StringBuilder ();
			foreach (var path in GetIgnoreFiles (templatePath, projectName, info.Assemblies, platform)) {
				contentFiles.Append (GetContentNode (path));
			}
			var projectGuid = GuidGenerator?.Invoke (projectName) ?? Guid.NewGuid ();
			using (var reader = new StreamReader(templatePath)) {
				var result = await reader.ReadToEndAsync ();
				result = result.Replace (DownloadPathKey, downloadPath);
				result = result.Replace (ProjectGuidKey, projectGuid.ToString ().ToUpperInvariant ());
				result = result.Replace (NameKey, projectName);
				result = result.Replace (ReferencesKey, sb.ToString ());
				result = result.Replace (RegisterTypeKey, GetRegisterTypeNode (registerPath));
				result = result.Replace (PlistKey, infoPlistPath);
				result = result.Replace (ContentKey, contentFiles.ToString ());
				switch (platform){
				case Platform.MacOSFull:
					result = result.Replace (TargetFrameworkVersionKey, "v4.5.2");
					result = result.Replace (TargetExtraInfoKey,
						"<UseXamMacFullFramework>true</UseXamMacFullFramework>");
					result = result.Replace (DefineConstantsKey, "XAMCORE_2_0;ADD_BCL_EXCLUSIONS;XAMMAC_4_5");
					break;
				case Platform.MacOSModern:
					result = result.Replace (TargetFrameworkVersionKey, "v2.0");
					result = result.Replace (TargetExtraInfoKey,
						"<TargetFrameworkIdentifier>Xamarin.Mac</TargetFrameworkIdentifier>");
					result = result.Replace (DefineConstantsKey, "XAMCORE_2_0;ADD_BCL_EXCLUSIONS;MOBILE;XAMMAC");
					break;
				}
				return result;
			}
		}

		internal string GenerateWatchProject (string projectName, string template, string infoPlistPath)
		{
				var result = template.Replace (NameKey, projectName);
				result = result.Replace (WatchOSTemplatePathKey, WatchContainerTemplatePath);
				result = result.Replace (PlistKey, infoPlistPath);
				result = result.Replace (WatchOSCsporjAppKey, GetProjectPath (projectName, WatchAppType.App).Replace ("/", "\\"));
				return result;
		}

		async Task<string> GenerateWatchAppAsync (string projectName, string templatePath, string infoPlistPath)
		{
			using (var reader = new StreamReader(templatePath)) {
				var result = await reader.ReadToEndAsync ();
				result = result.Replace (NameKey, projectName);
				result = result.Replace (WatchOSTemplatePathKey, WatchAppTemplatePath);
				result = result.Replace (PlistKey, infoPlistPath);
				result = result.Replace (WatchOSCsporjExtensionKey, GetProjectPath (projectName, WatchAppType.Extension).Replace ("/", "\\"));
				return result;
			}
		}

		static void WriteReferenceFailure (StringBuilder sb, string failureMessage)
		{
			sb.AppendLine ($"<!-- Failed to load all assembly references; please 'git clean && make' the tests/ directory to re-generate the project files -->");
			sb.AppendLine ($"<!-- Failure message: {failureMessage} --> ");
			sb.AppendLine ("<Reference Include=\"ProjectGenerationFailure_PleaseRegenerateProjectFiles.dll\" />"); // Make sure the project fails to build.
		}

		async Task<string> GenerateWatchExtensionAsync (string projectName, string templatePath, string infoPlistPath, string registerPath, (string FailureMessage, List<(string assembly, string hintPath)> Assemblies) info)
		{
			var downloadPath = GetReleaseDownload (Platform.WatchOS).Replace ("/", "\\");
			var sb = new StringBuilder ();
			if (!string.IsNullOrEmpty (info.FailureMessage)) {
				WriteReferenceFailure (sb, info.FailureMessage);
			} else {
				foreach (var assemblyInfo in info.Assemblies) {
					if (!excludeDlls.Contains (assemblyInfo.assembly))
						sb.AppendLine (GetReferenceNode (assemblyInfo.assembly, assemblyInfo.hintPath));
				}
			}
			
			var contentFiles = new StringBuilder ();
			foreach (var path in GetIgnoreFiles (templatePath, projectName, info.Assemblies, Platform.WatchOS)) {
				contentFiles.Append (GetContentNode (path));
			}
			
			using (var reader = new StreamReader(templatePath)) {
				var result = await reader.ReadToEndAsync ();
				result = result.Replace (DownloadPathKey, downloadPath);
				result = result.Replace (NameKey, projectName);
				result = result.Replace (WatchOSTemplatePathKey, WatchExtensionTemplatePath);
				result = result.Replace (PlistKey, infoPlistPath);
				result = result.Replace (RegisterTypeKey, GetRegisterTypeNode (registerPath));
				result = result.Replace (ReferencesKey, sb.ToString ());
				result = result.Replace (ContentKey, contentFiles.ToString ());
				return result;
			}
		}

		/// <summary>
		/// Removes all the generated files by the tool.
		/// </summary>
		public void CleanOutput ()
		{
			if (isCodeGeneration)
				throw new InvalidOperationException ("Project generator was instantiated to project generation.");
			if (Directory.Exists (GeneratedCodePathRoot))
				Directory.Delete (GeneratedCodePathRoot, true);
			// delete all the common projects
			foreach (var platform in new [] {Platform.iOS, Platform.TvOS}) {
				foreach (var testProject in commoniOSTestProjects) {
					var projectPath = GetProjectPath (testProject.name, platform);
					if (File.Exists (projectPath))
						File.Delete (projectPath);
				}
			}
			// delete each of the generated project files
			foreach (var projectDefinition in commoniOSTestProjects) {
				var projectPath = GetProjectPath (projectDefinition.name, Platform.iOS);
				if (File.Exists (projectPath))
					File.Delete (projectPath);
			}	
		}

		/// <summary>
		/// Returns if all the test assemblies found in the mono path 
		/// </summary>
		/// <param name="missingAssemblies"></param>
		/// <returns></returns>
		public bool AllTestAssembliesAreRan (out Dictionary<Platform, List<string>> missingAssemblies, bool wasDownloaded)
		{
			missingAssemblies = new Dictionary<Platform, List<string>> ();
			foreach (var platform in new [] {Platform.iOS, Platform.TvOS, Platform.WatchOS}) {
				var testDir = wasDownloaded ? BCLTestAssemblyDefinition.GetTestDirectoryFromDownloadsPath (GetReleaseDownload (platform), platform)
					: BCLTestAssemblyDefinition.GetTestDirectoryFromMonoPath (MonoRootPath, platform);
				var missingAssembliesPlatform = Directory.GetFiles (testDir, NUnitPattern).Select (Path.GetFileName).Union (
					Directory.GetFiles (testDir, xUnitPattern).Select (Path.GetFileName)).ToList ();
				
				foreach (var assembly in CommonIgnoredAssemblies) {
					missingAssembliesPlatform.Remove (new BCLTestAssemblyDefinition (assembly).GetName (platform));
				}
				
				// loop over the mono root path and grab all the assemblies, then intersect the found ones with the added
				// and ignored ones.
				foreach (var projectDefinition in commoniOSTestProjects) {
					foreach (var testAssembly in projectDefinition.assemblies) {
						missingAssembliesPlatform.Remove (new BCLTestAssemblyDefinition (testAssembly).GetName (platform));
					}
				}

				if (missingAssembliesPlatform.Count != 0) {
					missingAssemblies[platform] = missingAssembliesPlatform;
				}
			}
			return missingAssemblies.Keys.Count == 0;
		}
	}
}
