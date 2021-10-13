//
// Copyright 2015 Xamarin Inc
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;
using CoreFoundation;
using Foundation;

namespace CoreFoundation {

	public partial class CFBundle : NativeObject {

		public enum PackageType {
			Application,
			Framework,
			Bundle
		}

		public struct PackageInfo {
			public PackageInfo (CFBundle.PackageType type, string creator)
			{
				this.Type = type;
				this.Creator = creator;
			}

			public PackageType Type { get; private set; }
			public string Creator { get; private set; }
		}

		internal CFBundle (IntPtr handle)
			: base (handle, false)
		{
		}

		internal CFBundle (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFBundleRef */ IntPtr CFBundleCreate ( /* CFAllocatorRef can be null */ IntPtr allocator, /* CFUrlRef */ IntPtr bundleURL);

		static IntPtr Create (NSUrl bundleUrl)
		{
			if (bundleUrl is null)
				throw new ArgumentNullException (nameof (bundleUrl));

			return CFBundleCreate (IntPtr.Zero, bundleUrl.Handle);

		}

		public CFBundle (NSUrl bundleUrl)
			: base (Create (bundleUrl), true)
		{
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArrayRef */ IntPtr CFBundleCreateBundlesFromDirectory (/* CFAllocatorRef can be null */ IntPtr allocator, /* CFUrlRef */ IntPtr directoryURL, /* CFStringRef */ IntPtr bundleType);

		public static CFBundle[] GetBundlesFromDirectory (NSUrl directoryUrl, string bundleType)
		{
			if (directoryUrl is null) // NSUrl cannot be "" by definition
				throw new ArgumentNullException (nameof (directoryUrl));
			if (String.IsNullOrEmpty (bundleType))
				throw new ArgumentException (nameof (bundleType));
			using (var bundleTypeCFSting = new CFString (bundleType))
			using (var cfBundles = new CFArray (CFBundleCreateBundlesFromDirectory (IntPtr.Zero, directoryUrl.Handle, bundleTypeCFSting.Handle), true)) {
				var managedBundles = new CFBundle [cfBundles.Count];
				for (int index = 0; index < cfBundles.Count; index++) {
					// follow the create rules, therefore we do have ownership of each of the cfbundles
					managedBundles [index] = new CFBundle (cfBundles.GetValue (index), true);
				}
				return managedBundles;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static IntPtr CFBundleGetAllBundles ();
		
		public static CFBundle[] GetAll ()
		{
			// as per apple documentation: 
			// CFBundleGetAllBundles
			//
			// 	'This function is potentially expensive and not thread-safe'
			//
			// This means, that we should not trust the size of the array, since is a get and
			// might be modified by a diff thread. We are going to clone the array and make sure
			// that Apple does not modify the array while we work with it. That avoids changes
			// in the index or in the bundles returned.
			using (var cfBundles = new CFArray (CFBundleGetAllBundles ()))
			using (var cfBundlesCopy = cfBundles.Clone () ) {
				var bundleCount = cfBundlesCopy.Count; // the property is a C call, calling everytime we loop is not needed
				var managedBundles = new CFBundle [bundleCount];
				for (int index = 0; index < bundleCount; index++) {
					// follow the get rule, we do not own the object
					managedBundles [index] = new CFBundle (cfBundlesCopy.GetValue (index), false);
				}
				return managedBundles;
			}
		}


		[DllImport (Constants.CoreFoundationLibrary)]
		extern static IntPtr CFBundleGetBundleWithIdentifier (/* CFStringRef */ IntPtr bundleID);
		
		public static CFBundle? Get (string bundleID)
		{
			if (String.IsNullOrEmpty (bundleID))
				throw new ArgumentException (nameof (bundleID));
			using (var cfBundleId = new CFString (bundleID)) {
				var cfBundle = CFBundleGetBundleWithIdentifier (cfBundleId.Handle);
				if (cfBundle == IntPtr.Zero)
					return null;
				// follow the Get rule and retain the obj
				return new CFBundle (cfBundle, false);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static IntPtr CFBundleGetMainBundle ();

		public static CFBundle? GetMain ()
		{
			var cfBundle = CFBundleGetMainBundle ();
			if (cfBundle == IntPtr.Zero)
				return null;
			// follow the get rule and retain
			return new CFBundle (cfBundle, false);
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundleIsExecutableLoaded (IntPtr bundle);
		
		public bool HasLoadedExecutable {
			get { return CFBundleIsExecutableLoaded (Handle); }
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundlePreflightExecutable (IntPtr bundle, out IntPtr error);
		
		public bool PreflightExecutable (out NSError error)
		{
			IntPtr errorPtr = IntPtr.Zero;
			// follow the create rule, no need to retain
			var loaded = CFBundlePreflightExecutable (Handle, out errorPtr);
			error = Runtime.GetNSObject<NSError> (errorPtr);
			return loaded;
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundleLoadExecutableAndReturnError (IntPtr bundle, out IntPtr error);
		
		public bool LoadExecutable (out NSError error)
		{
			IntPtr errorPtr = IntPtr.Zero;
			// follows the create rule, no need to retain
			var loaded = CFBundleLoadExecutableAndReturnError (Handle, out errorPtr);
			error = Runtime.GetNSObject<NSError> (errorPtr);
			return loaded;
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static void CFBundleUnloadExecutable (IntPtr bundle);
		
		public void UnloadExecutable ()
		{
			CFBundleUnloadExecutable (Handle);
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyAuxiliaryExecutableURL (IntPtr bundle, /* CFStringRef */ IntPtr executableName);
		
		public NSUrl? GetAuxiliaryExecutableUrl (string executableName)
		{
			if (String.IsNullOrEmpty (executableName))
				throw new ArgumentException (nameof (executableName));
			using (var cfExecutableName = new CFString (executableName)) {
				// follows the create rule no need to retain
				var urlHandle = CFBundleCopyAuxiliaryExecutableURL (Handle, cfExecutableName.Handle);
				if (urlHandle == IntPtr.Zero)
					return null;
				return Runtime.GetNSObject<NSUrl> (urlHandle, true);
			}
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyBuiltInPlugInsURL (IntPtr bundle);
		
		public NSUrl BuiltInPlugInsUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopyBuiltInPlugInsURL (Handle), true);
			}
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyExecutableURL (IntPtr bundle);
		
		public NSUrl ExecutableUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopyExecutableURL (Handle), true);
			}
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyPrivateFrameworksURL (IntPtr bundle);
		
		public NSUrl PrivateFrameworksUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopyPrivateFrameworksURL (Handle), true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyResourcesDirectoryURL (IntPtr bundle);
		
		public NSUrl ResourcesDirectoryUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopyResourcesDirectoryURL (Handle), true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopySharedFrameworksURL (IntPtr bundle);
		
		public NSUrl SharedFrameworksUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopySharedFrameworksURL (Handle), true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopySharedSupportURL (IntPtr bundle);

		public NSUrl SharedSupportUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopySharedSupportURL (Handle), true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopySupportFilesDirectoryURL (IntPtr bundle);
		
		public NSUrl SupportFilesDirectoryUrl {
			get {
				return Runtime.GetNSObject<NSUrl> (CFBundleCopySupportFilesDirectoryURL (Handle), true);
			}
		}

		// the parameters do not take CFString because we want to be able to pass null (IntPtr.Zero) to the resource type and subdir names
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyResourceURL (IntPtr bundle, /* CFStringRef */ IntPtr resourceName, /* CFString */ IntPtr resourceType, /* CFString */ IntPtr subDirName);
		
		public NSUrl GetResourceUrl (string resourceName, string resourceType, string subDirName)
		{
			if (String.IsNullOrEmpty (resourceName))
				throw new ArgumentException (nameof (resourceName));

			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));

			using (CFString cfResourceName = new CFString (resourceName),
					cfResourceType = new CFString (resourceType),
					cfDirName = (subDirName is null) ? new CFString ("") : new CFString (subDirName)) {
				// follows the create rules and therefore we do not need to retain
				var urlHandle = CFBundleCopyResourceURL (Handle, cfResourceName.Handle, cfResourceType.Handle,
								   	 String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfDirName.Handle);
				return Runtime.GetNSObject<NSUrl> (urlHandle, true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyResourceURLInDirectory (/* CFUrlRef */ IntPtr bundleURL, /* CFStringRef */ IntPtr resourceName, /* CFStringRef */ IntPtr resourceType, /* CFStringRef */ IntPtr subDirName);
		
		public static NSUrl GetResourceUrl (NSUrl bundleUrl, string resourceName, string resourceType, string subDirName)
		{
			if (bundleUrl is null)
				throw new ArgumentNullException (nameof (bundleUrl));

			if (String.IsNullOrEmpty (resourceName))
				throw new ArgumentException (nameof (resourceName));

			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));

			// follows the create rules and therefore we do not need to retain
			using (CFString cfResourceName = new CFString (resourceName),
					cfResourceType = new CFString (resourceType),
					cfSubDirName = new CFString (subDirName ?? string.Empty)) {
				var urlHandle = CFBundleCopyResourceURLInDirectory (bundleUrl.Handle, cfResourceName.Handle, cfResourceType.Handle,
										      String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfSubDirName.Handle);
				return Runtime.GetNSObject<NSUrl> (urlHandle, true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyResourceURLsOfType (IntPtr bundle, /* CFStringRef */ IntPtr resourceType, /* CFStringRef */ IntPtr subDirName);
		
		public NSUrl[] GetResourceUrls (string resourceType, string subDirName)
		{
			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));
			
			using (CFString cfResourceType = new CFString (resourceType),
					cfSubDir = new CFString (subDirName ?? string.Empty))
			using (var cfArray = new CFArray (CFBundleCopyResourceURLsOfType (Handle, cfResourceType.Handle,
										     String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfSubDir.Handle), true)) {
				var result = new NSUrl [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index++) {
					result [index] = Runtime.GetNSObject<NSUrl> (cfArray.GetValue (index), true);
				}
				return result;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyResourceURLsOfTypeInDirectory (/* CFUrlRef */ IntPtr bundleURL, /* CFStringRef */ IntPtr resourceType, /* CFStringRef */ IntPtr subDirName);

		public static NSUrl[] GetResourceUrls (NSUrl bundleUrl, string resourceType, string subDirName)
		{
			if (bundleUrl is null)
				throw new ArgumentNullException (nameof (bundleUrl));

			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));
			
			using (CFString cfResourceType = new CFString (resourceType),
			                cfSubDir = new CFString (subDirName ?? string.Empty))
			using (var cfArray = new CFArray (CFBundleCopyResourceURLsOfTypeInDirectory (bundleUrl.Handle, cfResourceType.Handle,
					                                                        String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfSubDir.Handle), true)) {
				var result = new NSUrl [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index++) {
					result [index] = Runtime.GetNSObject<NSUrl> (cfArray.GetValue (index), true);
				}
				return result;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyResourceURLForLocalization (IntPtr bundle, /* CFStringRef */ IntPtr resourceName, /* CFStringRef */ IntPtr resourceType, /* CFStringRef */ IntPtr subDirName,
		                                                                            /* CFStringRef */ IntPtr localizationName);
		
		public NSUrl GetResourceUrl (string resourceName, string resourceType, string subDirName, string localizationName)
		{
			if (String.IsNullOrEmpty (resourceName))
				throw new ArgumentException (nameof (resourceName));

			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));
			
			if (String.IsNullOrEmpty (localizationName))
				throw new ArgumentException (nameof (localizationName));

			using (CFString cfResourceName = new CFString (resourceName),
			                cfResourceType = new CFString (resourceType),
					cfSubDir = new CFString (subDirName ?? string.Empty),
					cfLocalization = new CFString (localizationName)) {
				var urlHandle = CFBundleCopyResourceURLForLocalization (Handle, cfResourceName.Handle, cfResourceType.Handle,
											String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfSubDir.Handle, cfLocalization.Handle);
				return Runtime.GetNSObject<NSUrl> (urlHandle, true);
			}
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyResourceURLsOfTypeForLocalization (IntPtr bundle, /* CFStringRef */ IntPtr resourceType, /* CFStringRef */ IntPtr subDirName,
		                                                                                  /* CFStringRef */ IntPtr localizationName);
		
		public NSUrl[] GetResourceUrls (string resourceType, string subDirName, string localizationName)
		{
			if (String.IsNullOrEmpty (resourceType))
				throw new ArgumentException (nameof (resourceType));
			
			if (String.IsNullOrEmpty (localizationName))
				throw new ArgumentException (nameof (localizationName));
			
			using (CFString cfType = new CFString (resourceType),
			                cfDirName = new CFString (subDirName ?? string.Empty),
					cfLocalization = new CFString (localizationName))
			using (var cfArray = new CFArray (CFBundleCopyResourceURLsOfTypeForLocalization (Handle, cfType.Handle,
													 String.IsNullOrEmpty (subDirName) ? IntPtr.Zero : cfDirName.Handle,
													 cfLocalization.Handle), true)) {
				var urls = new NSUrl [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index++) {
					urls [index] = Runtime.GetNSObject<NSUrl> (cfArray.GetValue (index), true);
				}
				return urls;
			}
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFString */ IntPtr CFBundleCopyLocalizedString (IntPtr bundle, /* CFStringRef */ IntPtr key, /* CFStringRef */ IntPtr value, /* CFStringRef */ IntPtr tableName);
		
		public string? GetLocalizedString (string key, string defaultValue, string tableName)
		{
			if (String.IsNullOrEmpty (key))
				throw new ArgumentException (nameof (key));

			if (String.IsNullOrEmpty (tableName))
				throw new ArgumentException (nameof (tableName));

			// we do allow null and simply use an empty string to avoid the extra check
			if (defaultValue is null)
				defaultValue = string.Empty;

			using (CFString cfKey = new CFString (key),
					cfValue = new CFString (defaultValue),
					cfTable = new CFString (tableName)) {
				return CFString.FromHandle (CFBundleCopyLocalizedString (Handle, cfKey.Handle, cfValue.Handle, cfTable.Handle), releaseHandle: true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyLocalizationsForPreferences (/* CFArrayRef */ IntPtr locArray, /* CFArrayRef */ IntPtr prefArray);

		public static string?[] GetLocalizationsForPreferences (string[] locArray, string[] prefArray)
		{
			if (locArray is null)
				throw new ArgumentNullException (nameof (locArray));
			if (prefArray is null)
				throw new ArgumentNullException (nameof (prefArray));

			var cfLocal = new CFString [locArray.Length];
			for (int index = 0; index < locArray.Length; index++) {
				cfLocal [index] = new CFString (locArray [index]);
			}
			
			var cfPref = new CFString [prefArray.Length];
			for (int index = 0; index < prefArray.Length; index++) {
				cfPref [index] = new CFString (prefArray [index]);
			}
			
			using (CFArray cfLocalArray = CFArray.FromNativeObjects (cfLocal),
				       cfPrefArray = CFArray.FromNativeObjects (cfPref))
			using (var cfArray = new CFArray (CFBundleCopyLocalizationsForPreferences (cfLocalArray.Handle, cfPrefArray.Handle), true)) {
				var cultureInfo = new string? [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index ++) {
					cultureInfo [index] = CFString.FromHandle (cfArray.GetValue (index));
				}
				return cultureInfo;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyLocalizationsForURL (/* CFUrlRef */ IntPtr url);
		
		public static string?[] GetLocalizations (NSUrl bundle)
		{
			if (bundle is null)
				throw new ArgumentNullException (nameof (bundle));
			using (var cfArray = new CFArray (CFBundleCopyLocalizationsForURL (bundle.Handle), true)) {
				var cultureInfo = new string? [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index++) {
					cultureInfo [index] = CFString.FromHandle (cfArray.GetValue (index));
				}
				return cultureInfo;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyPreferredLocalizationsFromArray (/* CFArrayRef */ IntPtr locArray);
		
		public static string?[] GetPreferredLocalizations (string[] locArray)
		{
			if (locArray is null)
				throw new ArgumentNullException (nameof (locArray));

			var cfString = new CFString [locArray.Length];
			for (int index = 0; index < locArray.Length; index++) {
				cfString [index] = new CFString (locArray [index]);
			}
			using (var cfLocArray = CFArray.FromNativeObjects (cfString))
			using (var cfArray = new CFArray (CFBundleCopyPreferredLocalizationsFromArray (cfLocArray.Handle), true)) {
				var cultureInfo = new string? [cfArray.Count];
				for (int index = 0; index < cfArray.Count; index++) {
					cultureInfo [index] = CFString.FromHandle (cfArray.GetValue (index));
				}
				return cultureInfo;
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFUrlRef */ IntPtr CFBundleCopyBundleURL (IntPtr bundle);
		
		public NSUrl Url {
			get { 
				return Runtime.GetNSObject<NSUrl> (CFBundleCopyBundleURL (Handle), true);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFString */ IntPtr CFBundleGetDevelopmentRegion (IntPtr bundle );
		
		public string? DevelopmentRegion {
			get { return CFString.FromHandle (CFBundleGetDevelopmentRegion (Handle)); }
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFString */ IntPtr CFBundleGetIdentifier (IntPtr bundle);
		
		public string? Identifier {
			get { return CFString.FromHandle (CFBundleGetIdentifier (Handle)); }
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFDictionary */ IntPtr CFBundleGetInfoDictionary (IntPtr bundle ); 
		
		public NSDictionary InfoDictionary {
			get {
				// follows the Get rule, we need to retain
				return Runtime.GetNSObject<NSDictionary> (CFBundleGetInfoDictionary (Handle));
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* NSDictionary */ IntPtr CFBundleGetLocalInfoDictionary (IntPtr bundle );	
		
		public NSDictionary LocalInfoDictionary {
			get {
				// follows the Get rule, we need to retain
				return Runtime.GetNSObject<NSDictionary> (CFBundleGetLocalInfoDictionary (Handle));
			}
		}

		// We do not bind CFDictionaryRef CFBundleCopyInfoDictionaryInDirectory because we will use CFBundleCopyInfoDictionaryForURL. As per the apple documentation
		// For a directory URL, this is equivalent to CFBundleCopyInfoDictionaryInDirectory. For a plain file URL representing an unbundled application, this function
		// will attempt to read an information dictionary either from the (__TEXT, __info_plist) section of the file (for a Mach-O file) or from a plst resource. 

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* NSDictionary */ IntPtr CFBundleCopyInfoDictionaryForURL (/* CFUrlRef */ IntPtr url);
		
		public static NSDictionary GetInfoDictionary (NSUrl url)
		{
			if (url is null)
				throw new ArgumentNullException (nameof (url));
			// follow the create rule, no need to retain
			return Runtime.GetNSObject<NSDictionary> (CFBundleCopyInfoDictionaryForURL (url.Handle));
		}
		
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static void CFBundleGetPackageInfo (IntPtr bundle, out uint packageType, out uint packageCreator);

		public PackageInfo Info {
			get {
				uint type = 0;
				uint creator = 0;
				
				CFBundleGetPackageInfo (Handle, out type, out creator);
				var creatorStr = Runtime.ToFourCCString (creator);
				switch (type) {
				case 1095782476: // ""APPL
					return new PackageInfo (CFBundle.PackageType.Application, creatorStr);
				case 1179473739: // "FMWK"
					return new PackageInfo (CFBundle.PackageType.Framework, creatorStr);
				case 1112425548: // "BNDL" so that we know we did not forget about this value
				default:
					return new PackageInfo (CFBundle.PackageType.Bundle, creatorStr);
				}
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFArray */ IntPtr CFBundleCopyExecutableArchitectures (IntPtr bundle);

		public CFBundle.Architecture[] Architectures {
			get {
				using (var cfArray = new CFArray(CFBundleCopyExecutableArchitectures (Handle), true)) {
					var archs = new CFBundle.Architecture [cfArray.Count];
					for (int index = 0; index < cfArray.Count; index++) {
						int value = 0;
						if (CFDictionary.CFNumberGetValue (cfArray.GetValue (index), /* kCFNumberSInt32Type */ 3, out value)) {
							archs [index] = (CFBundle.Architecture) value;
						} 
					}
					return archs;
				}
			}
		}

#if MONOMAC
#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundleIsExecutableLoadable (IntPtr bundle);

#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[UnsupportedOSPlatform ("ios"), UnsupportedOSPlatform ("tvos"), SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		public static bool IsExecutableLoadable (CFBundle bundle)
		{
			if (bundle is null)
				throw new ArgumentNullException (nameof (bundle));

			return CFBundleIsExecutableLoadable (bundle.GetCheckedHandle ());
		}

#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundleIsExecutableLoadableForURL (IntPtr bundle);

#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[UnsupportedOSPlatform ("ios"), UnsupportedOSPlatform ("tvos"), SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		public static bool IsExecutableLoadable (NSUrl url)
		{
			if (url is null)
				throw new ArgumentNullException (nameof (url));

			return CFBundleIsExecutableLoadableForURL (url.Handle);
		}

#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.CoreFoundationLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		extern static bool CFBundleIsArchitectureLoadable (/*cpu_type_t => integer_t => int*/ Architecture architecture);

#if !NET
		[Introduced (PlatformName.MacOSX, 11, 0)]
		[NoMacCatalyst]
#else
		[UnsupportedOSPlatform ("ios"), UnsupportedOSPlatform ("tvos"), SupportedOSPlatform ("macos11.0"), UnsupportedOSPlatform ("maccatalyst15.0")]
#endif
		public static bool IsArchitectureLoadable (Architecture architecture) => CFBundleIsArchitectureLoadable (architecture);

#endif
	}
}
