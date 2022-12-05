using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

using Mono.Cecil;
using Xamarin.Tests;
using Xamarin.Utils;
using System.Configuration.Assemblies;
using MethodAttributes = Mono.Cecil.MethodAttributes;
using ICustomAttributeProvider = Mono.Cecil.ICustomAttributeProvider;
using static Cecil.Tests.Test;
using System.Xml.Linq;



#nullable enable

namespace Cecil.Tests {
	[TestFixture]
	public class ApiAvailabilityTest {
		protected bool LogProgress = false;
		protected int Errors = 0;

		void AssertIfErrors (string message)
		{
			if (Errors == 0)
				return;
			Assert.Fail (message);
		}

		void AddErrorLine (string message)
		{
			Console.Error.WriteLine (message);
			Errors++;
		}

		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformAssemblyDefinitions))]
		public void Introduced (AssemblyInfo info)
		{
			var platform = info.Platform;
			//LogProgress = true;
			Errors = 0;
			foreach (var t in info.Assembly.EnumerateAttributeProviders ()) {
				CheckAvailability (info.Platform, t, out var taVersion);
			}
			AssertIfErrors ($"{Errors} API with unneeded or incorrect version information");
		}

		string ToString (ICustomAttributeProvider cap)
		{
			var s = cap.ToString ();
			if (cap is MemberInfo mi) {
				var i = s.IndexOf (' ');
				if (i != -1) {
					// a method/property without the declaring type is hard to track down
					s = s.Insert (i + 1, mi.DeclaringType + "::");
				}
			}
			return s;
		}

		protected CustomAttribute? CheckAvailability (ApplePlatform platform, ICustomAttributeProvider cap, out Version? aaVersion)
		{
			aaVersion = null;

			var aa = GetAvailable (cap, platform, out aaVersion);
			if (aa is null)
				return null;

			if (aaVersion is not null) {
				try {
					// FIXME should be `<=` but that another large change best done in a different PR
					var minimum = Xamarin.SdkVersions.GetMinVersion (platform);
					var maximum = Xamarin.SdkVersions.GetVersion (platform);
					if (minimum is null)
						Console.WriteLine ("STOP");
					var isAvailableBeforeMinimum = aaVersion < minimum;
					if (isAvailableBeforeMinimum)
						AddErrorLine ($"[FAIL] {aaVersion} <= {minimum} (Min) on '{ToString (cap)}'.");
					if (aaVersion > maximum)
						AddErrorLine ($"[FAIL] {aaVersion} > {maximum} (Max) on '{ToString (cap)}'.");
				} catch (Exception e) {
					Console.WriteLine (e);
				}
			}
			return aa;
		}

		bool IsUnavailable (ICustomAttributeProvider cap, ApplePlatform platform, out Version? version)
		{
			var rv = GetUnsupported (cap, platform, out version);
			return rv is not null;
		}

		CustomAttribute? GetUnsupported (ICustomAttributeProvider cap, ApplePlatform platform, out Version? version)
		{
			GetAvailabilityAttributes (cap, platform, out var _, out var _, out var _, out var _, out var attribute, out version);
			return attribute;
		}

		CustomAttribute? GetAvailable (ICustomAttributeProvider cap, ApplePlatform platform, out Version? version)
		{
			GetAvailabilityAttributes (cap, platform, out var attribute, out version, out var _, out var _, out var _, out var _);
			return attribute;
		}

		CustomAttribute? GetObsolete (ICustomAttributeProvider cap, ApplePlatform platform, out Version? version)
		{
			GetAvailabilityAttributes (cap, platform, out var _, out var _, out var attribute, out version, out var _, out var _);
			return attribute;
		}

		void GetAvailabilityAttributes (ICustomAttributeProvider provider, ApplePlatform platform, out CustomAttribute? supported, out Version? supportedVersion, out CustomAttribute? obsoleted, out Version? obsoletedVersion, out CustomAttribute? unsupported, out Version? unsupportedVersion)
		{
			supported = null;
			obsoleted = null;
			unsupported = null;
			supportedVersion = null;
			obsoletedVersion = null;
			unsupportedVersion = null;

			if (!provider.HasCustomAttributes)
				return;

			foreach (var a in provider.CustomAttributes) {
				var attributeType = a.AttributeType;
				if (attributeType.Namespace != "System.Runtime.Versioning")
					continue;

				if (!a.HasConstructorArguments || a.ConstructorArguments.Count != 1 || !a.ConstructorArguments [0].Type.Is ("System", "String"))
					continue;

				var platformName = (string) a.ConstructorArguments [0].Value;
				if (!OSPlatformAttributeExtensions.TryParse (platformName, out ApplePlatform? attributePlatform, out var version))
					continue;
				if (attributePlatform != platform)
					continue;

				switch (attributeType.Name) {
				case "UnsupportedOSPlatformAttribute":
					unsupported = a;
					unsupportedVersion = version;
					break;
				case "SupportedOSPlatformAttribute":
					supported = a;
					supportedVersion = version;
					break;
				case "ObsoletedOSPlatformAttribute":
					obsoleted = a;
					obsoletedVersion = version;
					break;
				default:
					throw new NotImplementedException (attributeType.FullName);
				}
			}
		}

		void CheckUnavailable (ApplePlatform platform, TypeDefinition t, CustomAttribute? typeUnavailableAttribute, Version? typeUnavailableVersion, IMemberDefinition m)
		{
			// Turns out Version (13, 1, 0) > Version (13, 1) since undefined fields are -1
			// However, we consider them equal, so force a 0 Build if set to -1
			if (typeUnavailableVersion?.Build == -1) {
				typeUnavailableVersion = new Version (typeUnavailableVersion.Major, typeUnavailableVersion.Minor, 0);
			}

			var ma = GetAvailable (m, platform, out var availableVersion);
			if (typeUnavailableAttribute is not null && ma is not null) {
				if (typeUnavailableVersion is not null && availableVersion is not null) {
					if (availableVersion >= typeUnavailableVersion)
						AddErrorLine ($"[FAIL] {m.DeclaringType.FullName}.{m.AsString ()} is marked available in {availableVersion} with '{ma.AsOSPlatformAttributeString ()}', but the type {t.FullName} is marked unavailable in {typeUnavailableVersion} with '{typeUnavailableAttribute.AsOSPlatformAttributeString ()}'");
				} else if (typeUnavailableVersion is not null && availableVersion is null) {
					// Available with no version and unavailable is a common valid pattern in NET-land
				} else {
					AddErrorLine ($"[FAIL] in {m.DeclaringType.FullName}.{m.AsString ()} is marked available with '{ma.AsOSPlatformAttributeString ()}', but the type {t.FullName} is marked unavailable with '{typeUnavailableAttribute.AsOSPlatformAttributeString ()}'");
				}
			}

			var mu = GetUnsupported (m, platform, out var unavailableVersion);
			if (mu is not null && ma is not null) {
				if (availableVersion is not null && unavailableVersion is not null) {
					if (platform == ApplePlatform.MacCatalyst) {
						if (availableVersion > unavailableVersion)
							AddErrorLine ($"[FAIL] {m} is marked both '{mu.AsOSPlatformAttributeString ()}' and '{ma.AsOSPlatformAttributeString ()}', and it's available in version {availableVersion} which is > than the unavailable version {unavailableVersion}");
					} else {
						if (availableVersion >= unavailableVersion)
							AddErrorLine ($"[FAIL] {m} is marked both '{mu.AsOSPlatformAttributeString ()}' and '{ma.AsOSPlatformAttributeString ()}', and it's available in version {availableVersion} which is >= than the unavailable version {unavailableVersion}");
					}
				} else if (availableVersion is null && unavailableVersion is null) {
					// As documented in https://docs.microsoft.com/en-us/dotnet/standard/analyzers/platform-compat-analyzer#advanced-scenarios-for-attribute-combinations
					// it is valid, and required in places to declare a type both availabile and unavailable on a given platform.
					// Example:
					// 		[SupportedOSPlatform ("macos")]
					// 		[UnsupportedOSPlatform ("macos10.13")]
					// This API was introduced on macOS but became unavailable on 10.13
					// The legacy attributes described this with Deprecated, and did not need to double declare
					AddErrorLine ($"[FAIL] {m} in {m.DeclaringType.FullName} is marked both {mu.AsOSPlatformAttributeString ()})] and {ma.AsOSPlatformAttributeString ()}: {m.RenderLocation ()} ");
				}
			}
		}

		[Ignore ("whatever")]
		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformAssemblyDefinitions))]
		public void ObsoleteAndUnavailable (AssemblyInfo info)
		{
			foreach (var type in info.Assembly.FilterTypes ()) {
				TestObsoleteAndUnavilable (info.Platform, type);
			}

			foreach (var method in info.Assembly.FilterMethods ()) {
				TestObsoleteAndUnavilable (info.Platform, method);
			}
			foreach (var property in info.Assembly.FilterProperties ()) {
				TestObsoleteAndUnavilable (info.Platform, property);
			}
			foreach (var field in info.Assembly.FilterFields ()) {
				TestObsoleteAndUnavilable (info.Platform, field);
			}
			AssertIfErrors ($"{Errors} members with identical availability attributes");
		}

		void TestObsoleteAndUnavilable (ApplePlatform platform, IMemberDefinition provider)
		{
			GetAvailabilityAttributes (provider, platform, out var _, out var _, out var obsoleted, out var _, out var unsupported, out var _);

			if (obsoleted is null || unsupported is null)
				return;
			var obsoletedPlatformName = obsoleted.GetOSPlatformAttributePlatformName ();
			var unsupportedPlatformName = unsupported.GetOSPlatformAttributePlatformName ();
			if (obsoletedPlatformName == unsupportedPlatformName)
				AddErrorLine ($"[FAIL] {provider.AsFullName ()}: declares identical availability attributes: '{obsoleted.AsOSPlatformAttributeString ()}' vs '{unsupported.AsOSPlatformAttributeString ()}'");
		}

		[TestCaseSource (typeof (Helper), nameof (Helper.NetPlatformAssemblyDefinitions))]
		public void Unavailable (AssemblyInfo info)
		{
			var assembly = info.Assembly;
			var platform = info.Platform;

			//LogProgress = true;
			Errors = 0;
			foreach (var t in assembly.FilterTypes ()) {
				if (SkipUnavailable (t))
					continue;
				if (LogProgress)
					Console.WriteLine ($"T: {t}");
				var tu = GetUnsupported (t, platform, out var unavailableVersion);
				var ta = GetAvailable (t, platform, out var availableVersion);
				if (tu is not null && ta is not null) {
					if (availableVersion is not null && unavailableVersion is not null) {
						// Apple is introducing and deprecating numerous APIs in the same Mac Catalyst version,
						// so specifically for Mac Catalyst, we do a simple 'greater than' version check,
						// instead of a 'greater than or equal' version like we do for the other platforms.
#if !NET // https://github.com/xamarin/xamarin-macios/issues/14802
						//if (Platform == ApplePlatform.MacCatalyst)
						//{
						//	if (availableVersion > unavailableVersion)
						//		AddErrorLine($"[FAIL] {t.FullName} is marked both [Unavailable ({Platform})] and {ta}, and it's available in version {availableVersion} which is > than the unavailable version {unavailableVersion}");

						//}
						//else
						//{
						//	if (availableVersion >= unavailableVersion)
						//		AddErrorLine($"[FAIL] {t.FullName} is marked both [Unavailable ({Platform})] and {ta}, and it's available in version {availableVersion} which is >= than the unavailable version {unavailableVersion}");
						//}
#endif
					} else {
						// As documented in https://docs.microsoft.com/en-us/dotnet/standard/analyzers/platform-compat-analyzer#advanced-scenarios-for-attribute-combinations
						// it is valid, and required in places to declare a type both availabile and unavailable on a given platform.
						// Example:
						// 		[SupportedOSPlatform ("macos")]
						// 		[UnsupportedOSPlatform ("macos10.13")]
						// This API was introduced on macOS but became unavailable on 10.13
						// The legacy attributes described this with Deprecated, and did not need to double declare
#if !NET
						//AddErrorLine($"[FAIL] {t.FullName} is marked both [Unavailable ({Platform})] and {ta}. Available: {availableVersion} Unavailable: {unavailableVersion}");
#endif
					}
				}

				if (t.HasProperties) {
					foreach (var p in t.Properties) {
						if (SkipUnavailable (t, p.Name))
							continue;
						if (LogProgress)
							Console.WriteLine ($"P: {p.Name}");
						CheckUnavailable (platform, t, tu, unavailableVersion, p);
					}
				}

				if (t.HasMethods) {
					foreach (var m in t.Methods) {
						if (SkipUnavailable (t, m.Name))
							continue;
						if (LogProgress)
							Console.WriteLine ($"M: {m.Name}");
						CheckUnavailable (platform, t, tu, unavailableVersion, m);
					}
				}
			}
			AssertIfErrors ($"{Errors} API with mixed [Unavailable] and availability attributes");
		}

		protected virtual bool SkipUnavailable (TypeDefinition type)
		{
			return false;
#if __MACCATALYST__
			switch (type.Namespace) {
			case "AddressBook": {
				// The entire framework was introduced and deprecated in the same Mac Catalyst version
				return true;
			}
			}
#endif

			switch (type.FullName) {
#if __MACCATALYST__
			case "SafariServices.SFContentBlockerErrorCode":
			case "SafariServices.SFContentBlockerErrorCodeExtensions":
				// introduced and deprecated in the same Mac Catalyst version
				return true;
#endif
			}
			return false;
		}

		protected virtual bool SkipUnavailable (TypeDefinition type, string memberName)
		{
			return false;
			switch (type.FullName) {
#if __MACOS__
			case "AppKit.NSDrawer":
				switch (memberName) {
				case "AccessibilityChildrenInNavigationOrder":
				case "get_AccessibilityChildrenInNavigationOrder":
				case "set_AccessibilityChildrenInNavigationOrder":
				case "AccessibilityCustomActions":
				case "get_AccessibilityCustomActions":
				case "set_AccessibilityCustomActions":
				case "AccessibilityCustomRotors":
				case "get_AccessibilityCustomRotors":
				case "set_AccessibilityCustomRotors":
					// NSDrawer was deprecated in macOS 10.13, but implements (and inlines) NSAccessibility, which added several new members in macOS 10.13, so ignore those members here.
					return true;
				}
				break;
			case "GLKit.GLKTextureLoader":
				switch (memberName) {
				case "GrayscaleAsAlpha":
				case "get_GrayscaleAsAlpha":
					// GLKTextureLoader is deprecated, but the GLKTextureLoaderGrayscaleAsAlpha value, which we've put inside the GLKTextureLoader class, isn't.
					return true;
				}
				break;
#endif
#if __MACCATALYST__
			case "AudioUnit.AudioComponent":
				switch (memberName) {
				case "LastActiveTime":
					// introduced and deprecated in the same Mac Catalyst version
					return true;
				}
				break;
			// Apple itself is inconsistent in the availability of the type compared to these selectors
			case "AVFoundation.AVCaptureStillImageOutput":
				switch (memberName) {
				case "AutomaticallyEnablesStillImageStabilizationWhenAvailable":
				case "CapturingStillImage":
				case "HighResolutionStillImageOutputEnabled":
				case "IsStillImageStabilizationActive":
				case "IsStillImageStabilizationSupported":
					return true;
				}
				break;
#endif
			case "CarPlay.CPApplicationDelegate":
				switch (memberName) {
				case "DidDiscardSceneSessions":
				case "GetConfiguration":
				case "GetHandlerForIntent":
				case "ShouldAutomaticallyLocalizeKeyCommands":
				case "ShouldRestoreSecureApplicationState":
				case "ShouldSaveSecureApplicationState":
					// CPApplicationDelegate is deprecated in macOS 10.15, but these members are pulled in from the UIApplicationDelegate protocol (which is not deprecated)
					return true;
				}
				break;
			case "CoreMedia.CMTimebase": {
				switch (memberName) {
				case "SetMasterTimebase":
				case "SetMasterClock":
					// These APIs were introduced and deprecated in the same version
					return true;
				}
				break;
			}
			case "GameKit.GKScore": {
				switch (memberName) {
				case "ReportLeaderboardScores":
				case "ReportLeaderboardScoresAsync":
					// Apple introduced and deprecated this method in the same OS version.
					return true;
				}
				break;
			}
			case "Intents.INNoteContentTypeResolutionResult": {
				switch (memberName) {
				case "GetConfirmationRequired":
				case "GetUnsupported":
					// These are static members that have been re-implemented from the base class - the base class isn't deprecated, while INNoteContentTypeResolutionResult is.
					return true;
				}
				break;
			}
			case "MobileCoreServices.UTType": {
				switch (memberName) {
				case "UniversalSceneDescriptionMobile":
				case "get_UniversalSceneDescriptionMobile":
					// Apple added new members to a deprecated enum
					return true;
				}
				break;
			}
			case "SceneKit.SCNLayer": {
				switch (memberName) {
				case "CurrentViewport":
				case "TemporalAntialiasingEnabled":
				case "get_CurrentViewport":
				case "get_TemporalAntialiasingEnabled":
				case "set_TemporalAntialiasingEnabled":
				case "get_UsesReverseZ":
				case "set_UsesReverseZ":
				case "UsesReverseZ":
					// SCNLayer is deprecated in macOS 10.15, but these members are pulled in from the SCNSceneRenderer protocol (which is not deprecated)
					return true;
				}
				break;
			}
			}
			return false;
		}
	}
}
