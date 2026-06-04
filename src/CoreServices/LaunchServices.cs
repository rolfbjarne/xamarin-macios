//
// LaunchServices.cs
//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//
// NOTE: intentionally passing IntPtr.Zero to all
// 'out NSError' APIs since errors return NULL anyway,
// and the NSError objects are specified to be a
// constant error object (from the docs).
// 
// In other words, A NULL return value implies
// ApplicationNotFoundso we just drop the
// 'out NSError' parameter to make the API nicer.
//
// NOTE: only bound APIs not deprecated in 10.11
//
// NOTE: KEEP IN SYNC WITH TESTS!

#nullable enable

#if MONOMAC

using CoreFoundation;

namespace CoreServices {
	/// <summary>Specifies roles an application can assume for a document.</summary>
	[Flags]
	public enum LSRoles/*Mask*/ : uint /* always 32-bit uint */
	{
		/// <summary>No role.</summary>
		None = 1,
		/// <summary>The application can view the document.</summary>
		Viewer = 2,
		/// <summary>The application can edit the document.</summary>
		Editor = 4,
		/// <summary>The application can execute the document.</summary>
		Shell = 8,
		/// <summary>All roles.</summary>
		All = 0xffffffff,
	}

	/// <summary>Specifies acceptance flags for Launch Services.</summary>
	[Flags]
	public enum LSAcceptanceFlags : uint /* always 32-bit uint */
	{
		/// <summary>Default acceptance behavior.</summary>
		Default = 1,
		/// <summary>Allow login UI to be presented.</summary>
		AllowLoginUI = 2,
	}

	/// <summary>Specifies Launch Services result codes.</summary>
	public enum LSResult {
		/// <summary>The operation succeeded.</summary>
		Success = 0,
		[SupportedOSPlatform ("macos13.0")]
		MalformedLocErr = -10400,
		/// <summary>The application is in the trash.</summary>
		AppInTrash = -10660,
		/// <summary>The executable has an incorrect format.</summary>
		ExecutableIncorrectFormat = -10661,
		/// <summary>The attribute was not found.</summary>
		AttributeNotFound = -10662,
		/// <summary>The attribute is not settable.</summary>
		AttributeNotSettable = -10663,
		/// <summary>The application version is incompatible.</summary>
		IncompatibleApplicationVersion = -10664,
		/// <summary>No Rosetta environment is available.</summary>
		NoRosettaEnvironment = -10665,
		/// <summary>An unknown error occurred.</summary>
		Unknown = -10810,
		/// <summary>The item is not an application.</summary>
		NotAnApplication = -10811,
		/// <summary>Launch Services has not been initialized.</summary>
		NotInitialized = -10812,
		/// <summary>The data is unavailable.</summary>
		DataUnavailable = -10813,
		/// <summary>The application was not found.</summary>
		ApplicationNotFound = -10814,
		/// <summary>The type is unknown.</summary>
		UnknownType = -10815,
		/// <summary>The data is too old.</summary>
		DataTooOld = -10816,
		/// <summary>A data error occurred.</summary>
		Data = -10817,
		/// <summary>A launch is already in progress.</summary>
		LaunchInProgress = -10818,
		/// <summary>The application is not registered.</summary>
		NotRegistered = -10819,
		/// <summary>The application does not claim the type.</summary>
		AppDoesNotClaimType = -10820,
		/// <summary>The application does not support the URL scheme.</summary>
		AppDoesNotSupportSchemeWarning = -10821,
		/// <summary>A server communication error occurred.</summary>
		ServerCommunication = -10822,
		/// <summary>Cannot set the information.</summary>
		CannotSetInfo = -10823,
		/// <summary>No registration information is available.</summary>
		NoRegistrationInfo = -10824,
		/// <summary>The system version is incompatible.</summary>
		IncompatibleSystemVersion = -10825,
		/// <summary>No launch permission.</summary>
		NoLaunchPermission = -10826,
		/// <summary>No executable found.</summary>
		NoExecutable = -10827,
		/// <summary>No Classic environment is available.</summary>
		NoClassicEnvironment = -10828,
		/// <summary>Multiple sessions are not supported.</summary>
		MultipleSessionsNotSupported = -10829,
	}

	/// <summary>Provides access to macOS Launch Services functionality.</summary>
	[SupportedOSPlatform ("macos")]
	public static class LaunchServices {
		#region Locating an Application

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyDefaultApplicationURLForURL (IntPtr inUrl, LSRoles inRole, /*out*/ IntPtr outError);

		/// <param name="url">The URL to query.</param>
		/// <param name="roles">The application roles.</param>
		/// <summary>Gets the default application URL for the specified URL.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static NSUrl? GetDefaultApplicationUrlForUrl (NSUrl url, LSRoles roles = LSRoles.All)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			var result = Runtime.GetNSObject<NSUrl> (
				LSCopyDefaultApplicationURLForURL (url.Handle, roles, IntPtr.Zero)
			);
			GC.KeepAlive (url);
			return result;
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyDefaultApplicationURLForContentType (IntPtr inContentType, LSRoles inRole, /*out*/ IntPtr outError);

		/// <param name="contentType">The content type identifier.</param>
		/// <param name="roles">The application roles.</param>
		/// <summary>Gets the default application URL for the specified content type.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static NSUrl? GetDefaultApplicationUrlForContentType (string contentType, LSRoles roles = LSRoles.All)
		{
			if (contentType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentType));

			var contentTypeHandle = CFString.CreateNative (contentType);
			try {
				return Runtime.GetNSObject<NSUrl> (
					LSCopyDefaultApplicationURLForContentType (contentTypeHandle, roles, IntPtr.Zero)
				);
			} finally {
				CFString.ReleaseNative (contentTypeHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyApplicationURLsForURL (IntPtr inUrl, LSRoles inRole);

		/// <param name="url">The URL to query.</param>
		/// <param name="roles">The application roles.</param>
		/// <summary>Gets application URLs that can handle the specified URL.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static NSUrl [] GetApplicationUrlsForUrl (NSUrl url, LSRoles roles = LSRoles.All)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			var result = NSArray.NonNullArrayFromHandleDropNullElements<NSUrl> (
				LSCopyApplicationURLsForURL (url.Handle, roles),
				releaseHandle: true
			);
			GC.KeepAlive (url);
			return result;
		}

		[DllImport (Constants.CoreServicesLibrary)]
		unsafe static extern LSResult LSCanURLAcceptURL (IntPtr inItemUrl, IntPtr inTargetUrl,
			LSRoles inRole, LSAcceptanceFlags inFlags, byte* outAcceptsItem);

		// NOTE: intentionally inverting the status results (return bool, with an out
		// LSResult vs return LSResult with an out bool) to make the API nicer to use
		/// <param name="itemUrl">The itemUrl.</param>
		/// <param name="targetUrl">The targetUrl.</param>
		/// <param name="roles">The application roles.</param>
		/// <param name="acceptanceFlags">The acceptance flags.</param>
		/// <param name="result">The result.</param>
		/// <summary>Determines whether a URL can accept another URL.</summary>
		public static bool CanUrlAcceptUrl (NSUrl itemUrl, NSUrl targetUrl,
			LSRoles roles, LSAcceptanceFlags acceptanceFlags, out LSResult result)
		{
			if (itemUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemUrl));
			if (targetUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetUrl));

			byte acceptsItem;
			unsafe {
				result = LSCanURLAcceptURL (itemUrl.Handle, targetUrl.Handle, roles, acceptanceFlags, &acceptsItem);
				GC.KeepAlive (itemUrl);
				GC.KeepAlive (targetUrl);
			}
			return acceptsItem != 0;
		}

		/// <param name="itemUrl">The itemUrl.</param>
		/// <param name="targetUrl">The targetUrl.</param>
		/// <param name="roles">The application roles.</param>
		/// <param name="acceptanceFlags">The acceptance flags.</param>
		/// <summary>Determines whether a URL can accept another URL.</summary>
		public static bool CanUrlAcceptUrl (NSUrl itemUrl, NSUrl targetUrl,
			LSRoles roles = LSRoles.All, LSAcceptanceFlags acceptanceFlags = LSAcceptanceFlags.Default)
		{
			LSResult result;
			return CanUrlAcceptUrl (itemUrl, targetUrl, roles, acceptanceFlags, out result);
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyApplicationURLsForBundleIdentifier (IntPtr inBundleIdentifier, /*out*/ IntPtr outError);

		/// <param name="bundleIdentifier">The bundleIdentifier.</param>
		///         <summary>Gets application URLs for the specified bundle identifier.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static NSUrl [] GetApplicationUrlsForBundleIdentifier (string bundleIdentifier)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));

			var bundleIdentifierHandle = CFString.CreateNative (bundleIdentifier);
			try {
				return NSArray.NonNullArrayFromHandleDropNullElements<NSUrl> (
					LSCopyApplicationURLsForBundleIdentifier (bundleIdentifierHandle, IntPtr.Zero),
					releaseHandle: true
				);
			} finally {
				CFString.ReleaseNative (bundleIdentifierHandle);
			}
		}

		#endregion

		#region Opening Items

		[DllImport (Constants.CoreServicesLibrary)]
		unsafe static extern LSResult LSOpenCFURLRef (IntPtr inUrl, void** outLaunchedUrl);

		/// <param name="url">The URL to query.</param>
		///         <summary>Opens the specified URL.</summary>
		public unsafe static LSResult Open (NSUrl url)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			LSResult result = LSOpenCFURLRef (url.Handle, (void**) 0);
			GC.KeepAlive (url);
			return result;
		}

		/// <param name="url">The URL to query.</param>
		/// <param name="launchedUrl">The launchedUrl.</param>
		///         <summary>Opens the specified URL and returns the launched application URL.</summary>
		public unsafe static LSResult Open (NSUrl url, out NSUrl? launchedUrl)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			void* launchedUrlHandle;
			var result = LSOpenCFURLRef (url.Handle, &launchedUrlHandle);
			GC.KeepAlive (url);
			launchedUrl = Runtime.GetNSObject<NSUrl> (new IntPtr (launchedUrlHandle));
			return result;
		}

		#endregion

		#region Registering an Application

		[DllImport (Constants.CoreServicesLibrary)]
		static extern LSResult LSRegisterURL (IntPtr inUrl, byte inUpdate);

		/// <param name="url">The URL to query.</param>
		/// <param name="update">The update.</param>
		///         <summary>Registers the application at the specified URL.</summary>
		public static LSResult Register (NSUrl url, bool update)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));

			LSResult result = LSRegisterURL (url.Handle, (byte) (update ? 1 : 0));
			GC.KeepAlive (url);
			return result;
		}

		#endregion

		#region Working with Role Handlers

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyAllRoleHandlersForContentType (IntPtr inContentType, LSRoles inRole);

		/// <param name="contentType">The content type identifier.</param>
		/// <param name="roles">The application roles.</param>
		///         <summary>Gets all role handlers for the specified content type.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static string? []? GetAllRoleHandlersForContentType (string contentType, LSRoles roles = LSRoles.All)
		{
			if (contentType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentType));

			var contentTypeHandle = CFString.CreateNative (contentType);
			try {
				return CFArray.StringArrayFromHandle (
					LSCopyAllRoleHandlersForContentType (contentTypeHandle, roles)
				);
			} finally {
				CFString.ReleaseNative (contentTypeHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyDefaultRoleHandlerForContentType (IntPtr inContentType, LSRoles inRole);

		/// <param name="contentType">The content type identifier.</param>
		/// <param name="roles">The application roles.</param>
		///         <summary>Gets the default role handler for the specified content type.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static string? GetDefaultRoleHandlerForContentType (string contentType, LSRoles roles = LSRoles.All)
		{
			if (contentType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentType));

			var contentTypeHandle = CFString.CreateNative (contentType);
			try {
				return Runtime.GetNSObject<NSString> (
					LSCopyDefaultRoleHandlerForContentType (contentTypeHandle, roles)
				);
			} finally {
				CFString.ReleaseNative (contentTypeHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern LSResult LSSetDefaultRoleHandlerForContentType (IntPtr inContentType,
			LSRoles inRole, IntPtr inHandlerBundleID);

		/// <param name="contentType">The content type identifier.</param>
		/// <param name="handlerBundleId">The handlerBundleId.</param>
		/// <param name="roles">The application roles.</param>
		///         <summary>Sets the default role handler for the specified content type.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		// NOTE: intentionally swapped handlerBundleId and roles parameters for a nicer API
		public static LSResult SetDefaultRoleHandlerForContentType (string contentType, string handlerBundleId,
			LSRoles roles = LSRoles.All)
		{
			if (contentType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentType));
			if (handlerBundleId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handlerBundleId));

			var contentTypeHandle = CFString.CreateNative (contentType);
			var handlerBundleIdHandle = CFString.CreateNative (handlerBundleId);
			try {
				return LSSetDefaultRoleHandlerForContentType (
					contentTypeHandle,
					roles,
					handlerBundleIdHandle
				);
			} finally {
				CFString.ReleaseNative (contentTypeHandle);
				CFString.ReleaseNative (handlerBundleIdHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.15")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyAllHandlersForURLScheme (IntPtr inUrlScheme);

		/// <param name="urlScheme">The urlScheme.</param>
		///         <summary>Gets all handlers for the specified URL scheme.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'GetApplicationUrlsForUrl' instead.")]
		public static string? []? GetAllHandlersForUrlScheme (string urlScheme)
		{
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));

			var urlSchemeHandle = CFString.CreateNative (urlScheme);
			try {
				return CFArray.StringArrayFromHandle (
					LSCopyAllHandlersForURLScheme (urlSchemeHandle)
				);
			} finally {
				CFString.ReleaseNative (urlSchemeHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.15")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern IntPtr LSCopyDefaultHandlerForURLScheme (IntPtr inUrlScheme);

		/// <param name="urlScheme">The urlScheme.</param>
		///         <summary>Gets the default handler for the specified URL scheme.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'GetDefaultApplicationUrlForUrl' instead.")]
		public static string? GetDefaultHandlerForUrlScheme (string urlScheme)
		{
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));

			var urlSchemeHandle = CFString.CreateNative (urlScheme);
			try {
				return Runtime.GetNSObject<NSString> (
					LSCopyDefaultHandlerForURLScheme (urlSchemeHandle)
				);
			} finally {
				CFString.ReleaseNative (urlSchemeHandle);
			}
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		[DllImport (Constants.CoreServicesLibrary)]
		static extern LSResult LSSetDefaultHandlerForURLScheme (IntPtr inUrlScheme, IntPtr inHandlerBundleId);

		/// <param name="urlScheme">The urlScheme.</param>
		/// <param name="handlerBundleId">The handlerBundleId.</param>
		///         <summary>Sets the default handler for the specified URL scheme.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0")]
		public static LSResult SetDefaultHandlerForUrlScheme (string urlScheme, string handlerBundleId)
		{
			if (urlScheme is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urlScheme));
			if (handlerBundleId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handlerBundleId));

			var urlSchemeHandle = CFString.CreateNative (urlScheme);
			var handlerBundleIdHandle = CFString.CreateNative (handlerBundleId);
			try {
				return LSSetDefaultHandlerForURLScheme (
					urlSchemeHandle,
					handlerBundleIdHandle
				);
			} finally {
				CFString.ReleaseNative (urlSchemeHandle);
				CFString.ReleaseNative (handlerBundleIdHandle);
			}
		}

		#endregion
	}
}

#endif // MONOMAC
