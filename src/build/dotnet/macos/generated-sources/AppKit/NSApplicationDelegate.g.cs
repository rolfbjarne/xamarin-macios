//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSApplicationDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSApplicationDelegate", WrapperType = typeof (NSApplicationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldTerminate", Selector = "applicationShouldTerminate:", ReturnType = typeof (NSApplicationTerminateReply), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFile", Selector = "application:openFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFiles", Selector = "application:openFiles:", ParameterType = new Type [] { typeof (NSApplication), typeof (String[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenTempFile", Selector = "application:openTempFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldOpenUntitledFile", Selector = "applicationShouldOpenUntitledFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationOpenUntitledFile", Selector = "applicationOpenUntitledFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFileWithoutUI", Selector = "application:openFileWithoutUI:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintFile", Selector = "application:printFile:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintFiles", Selector = "application:printFiles:withSettings:showPrintPanels:", ReturnType = typeof (NSApplicationPrintReply), ParameterType = new Type [] { typeof (NSApplication), typeof (String[]), typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldTerminateAfterLastWindowClosed", Selector = "applicationShouldTerminateAfterLastWindowClosed:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldHandleReopen", Selector = "applicationShouldHandleReopen:hasVisibleWindows:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationDockMenu", Selector = "applicationDockMenu:", ReturnType = typeof (NSMenu), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentError", Selector = "application:willPresentError:", ReturnType = typeof (NSError), ParameterType = new Type [] { typeof (NSApplication), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillFinishLaunching", Selector = "applicationWillFinishLaunching:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLaunching", Selector = "applicationDidFinishLaunching:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHide", Selector = "applicationWillHide:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHide", Selector = "applicationDidHide:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUnhide", Selector = "applicationWillUnhide:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnhide", Selector = "applicationDidUnhide:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBecomeActive", Selector = "applicationWillBecomeActive:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeActive", Selector = "applicationDidBecomeActive:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResignActive", Selector = "applicationWillResignActive:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResignActive", Selector = "applicationDidResignActive:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUpdate", Selector = "applicationWillUpdate:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "applicationDidUpdate:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTerminate", Selector = "applicationWillTerminate:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScreenParametersChanged", Selector = "applicationDidChangeScreenParameters:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegisteredForRemoteNotifications", Selector = "application:didRegisterForRemoteNotificationsWithDeviceToken:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToRegisterForRemoteNotifications", Selector = "application:didFailToRegisterForRemoteNotificationsWithError:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedRemoteNotification", Selector = "application:didReceiveRemoteNotification:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEncodeRestorableState", Selector = "application:willEncodeRestorableState:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodedRestorableState", Selector = "application:didDecodeRestorableState:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillContinueUserActivity", Selector = "application:willContinueUserActivityWithType:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContinueUserActivity", Selector = "application:continueUserActivity:restorationHandler:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (NSUserActivity), typeof (ContinueUserActivityRestorationHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDContinueUserActivityRestorationHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToContinueUserActivity", Selector = "application:didFailToContinueUserActivityWithType:error:", ParameterType = new Type [] { typeof (NSApplication), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedUserActivity", Selector = "application:didUpdateUserActivity:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSUserActivity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidAcceptCloudKitShare", Selector = "application:userDidAcceptCloudKitShareWithMetadata:", ParameterType = new Type [] { typeof (NSApplication), typeof (CKShareMetadata) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenUrls", Selector = "application:openURLs:", ParameterType = new Type [] { typeof (NSApplication), typeof (NSUrl[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandlesKey", Selector = "application:delegateHandlesKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsSecureRestorableState", Selector = "applicationSupportsSecureRestorableState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHandler", Selector = "application:handlerForIntent:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSApplication), typeof (Intents.INIntent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAutomaticallyLocalizeKeyEquivalents", Selector = "applicationShouldAutomaticallyLocalizeKeyEquivalents:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProtectedDataWillBecomeUnavailable", Selector = "applicationProtectedDataWillBecomeUnavailable:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProtectedDataDidBecomeAvailable", Selector = "applicationProtectedDataDidBecomeAvailable:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	public partial interface INSApplicationDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSApplicationTerminateReply ApplicationShouldTerminate (NSApplication sender)
		{
			return _ApplicationShouldTerminate (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSApplicationTerminateReply _ApplicationShouldTerminate (INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSApplicationTerminateReply ret;
			ret = (NSApplicationTerminateReply) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldTerminate:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (NSApplication sender, string filename)
		{
			return _OpenFile (this, sender, filename);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _OpenFile (INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filenames">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openFiles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenFiles (NSApplication sender, string[] filenames)
		{
			_OpenFiles (this, sender, filenames);
		}
		/// <param name="sender">To be added.</param><param name="filenames">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenFiles (INSApplicationDelegate This, NSApplication sender, string[] filenames)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filenames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filenames));
			using var nsa_filenames = NSArray.FromStrings (filenames);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFiles:"), sender__handle__, nsa_filenames.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openTempFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenTempFile (NSApplication sender, string filename)
		{
			return _OpenTempFile (this, sender, filename);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _OpenTempFile (INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openTempFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldOpenUntitledFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldOpenUntitledFile (NSApplication sender)
		{
			return _ApplicationShouldOpenUntitledFile (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ApplicationShouldOpenUntitledFile (INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldOpenUntitledFile:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationOpenUntitledFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationOpenUntitledFile (NSApplication sender)
		{
			return _ApplicationOpenUntitledFile (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ApplicationOpenUntitledFile (INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationOpenUntitledFile:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openFileWithoutUI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFileWithoutUI (NSObject sender, string filename)
		{
			return _OpenFileWithoutUI (this, sender, filename);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _OpenFileWithoutUI (INSApplicationDelegate This, NSObject sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFileWithoutUI:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:printFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrintFile (NSApplication sender, string filename)
		{
			return _PrintFile (this, sender, filename);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _PrintFile (INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:printFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="fileNames">To be added.</param><param name="printSettings">To be added.</param><param name="showPrintPanels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:printFiles:withSettings:showPrintPanels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSApplicationPrintReply PrintFiles (NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
		{
			return _PrintFiles (this, application, fileNames, printSettings, showPrintPanels);
		}
		/// <param name="application">To be added.</param><param name="fileNames">To be added.</param><param name="printSettings">To be added.</param><param name="showPrintPanels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSApplicationPrintReply _PrintFiles (INSApplicationDelegate This, NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (fileNames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileNames));
			var printSettings__handle__ = printSettings!.GetNonNullHandle (nameof (printSettings));
			using var nsa_fileNames = NSArray.FromStrings (fileNames);
			NSApplicationPrintReply ret;
			ret = (NSApplicationPrintReply) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("application:printFiles:withSettings:showPrintPanels:"), application__handle__, nsa_fileNames.Handle, printSettings__handle__, showPrintPanels ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (printSettings);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldTerminateAfterLastWindowClosed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return _ApplicationShouldTerminateAfterLastWindowClosed (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ApplicationShouldTerminateAfterLastWindowClosed (INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldTerminateAfterLastWindowClosed:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="hasVisibleWindows">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldHandleReopen:hasVisibleWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldHandleReopen (NSApplication sender, bool hasVisibleWindows)
		{
			return _ApplicationShouldHandleReopen (this, sender, hasVisibleWindows);
		}
		/// <param name="sender">To be added.</param><param name="hasVisibleWindows">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ApplicationShouldHandleReopen (INSApplicationDelegate This, NSApplication sender, bool hasVisibleWindows)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("applicationShouldHandleReopen:hasVisibleWindows:"), sender__handle__, hasVisibleWindows ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDockMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu ApplicationDockMenu (NSApplication sender)
		{
			return _ApplicationDockMenu (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSMenu _ApplicationDockMenu (INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDockMenu:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willPresentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError WillPresentError (NSApplication application, NSError error)
		{
			return _WillPresentError (this, application, error);
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSError _WillPresentError (INSApplicationDelegate This, NSApplication application, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willPresentError:"), application__handle__, error__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillFinishLaunching (NSNotification notification)
		{
			_WillFinishLaunching (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillFinishLaunching (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillFinishLaunching:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLaunching (NSNotification notification)
		{
			_DidFinishLaunching (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishLaunching (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidFinishLaunching:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillHide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHide (NSNotification notification)
		{
			_WillHide (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillHide (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillHide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidHide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHide (NSNotification notification)
		{
			_DidHide (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidHide (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidHide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillUnhide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUnhide (NSNotification notification)
		{
			_WillUnhide (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUnhide (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillUnhide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidUnhide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnhide (NSNotification notification)
		{
			_DidUnhide (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnhide (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidUnhide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBecomeActive (NSNotification notification)
		{
			_WillBecomeActive (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBecomeActive (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillBecomeActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (NSNotification notification)
		{
			_DidBecomeActive (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeActive (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidBecomeActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (NSNotification notification)
		{
			_WillResignActive (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillResignActive (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillResignActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResignActive (NSNotification notification)
		{
			_DidResignActive (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResignActive (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidResignActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdate (NSNotification notification)
		{
			_WillUpdate (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillUpdate (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillUpdate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (NSNotification notification)
		{
			_DidUpdate (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidUpdate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate (NSNotification notification)
		{
			_WillTerminate (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTerminate (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillTerminate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidChangeScreenParameters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScreenParametersChanged (NSNotification notification)
		{
			_ScreenParametersChanged (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScreenParametersChanged (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidChangeScreenParameters:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="application">To be added.</param><param name="deviceToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisteredForRemoteNotifications (NSApplication application, NSData deviceToken)
		{
			_RegisteredForRemoteNotifications (this, application, deviceToken);
		}
		/// <param name="application">To be added.</param><param name="deviceToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegisteredForRemoteNotifications (INSApplicationDelegate This, NSApplication application, NSData deviceToken)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didRegisterForRemoteNotificationsWithDeviceToken:"), application__handle__, deviceToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (deviceToken);
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didFailToRegisterForRemoteNotificationsWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToRegisterForRemoteNotifications (NSApplication application, NSError error)
		{
			_FailedToRegisterForRemoteNotifications (this, application, error);
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToRegisterForRemoteNotifications (INSApplicationDelegate This, NSApplication application, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToRegisterForRemoteNotificationsWithError:"), application__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didReceiveRemoteNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedRemoteNotification (NSApplication application, NSDictionary userInfo)
		{
			_ReceivedRemoteNotification (this, application, userInfo);
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedRemoteNotification (INSApplicationDelegate This, NSApplication application, NSDictionary userInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:"), application__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="app">To be added.</param><param name="encoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willEncodeRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (NSApplication app, NSCoder encoder)
		{
			_WillEncodeRestorableState (this, app, encoder);
		}
		/// <param name="app">To be added.</param><param name="encoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEncodeRestorableState (INSApplicationDelegate This, NSApplication app, NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willEncodeRestorableState:"), app__handle__, encoder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (encoder);
		}
		/// <param name="app">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didDecodeRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodedRestorableState (NSApplication app, NSCoder state)
		{
			_DecodedRestorableState (this, app, state);
		}
		/// <param name="app">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecodedRestorableState (INSApplicationDelegate This, NSApplication app, NSCoder state)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDecodeRestorableState:"), app__handle__, state__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (state);
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willContinueUserActivityWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillContinueUserActivity (NSApplication application, string userActivityType)
		{
			return _WillContinueUserActivity (this, application, userActivityType);
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillContinueUserActivity (INSApplicationDelegate This, NSApplication application, string userActivityType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willContinueUserActivityWithType:"), application__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nsuserActivityType);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><param name="restorationHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:continueUserActivity:restorationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ContinueUserActivity (NSApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDContinueUserActivityRestorationHandler))]ContinueUserActivityRestorationHandler restorationHandler)
		{
			return _ContinueUserActivity (this, application, userActivity, restorationHandler);
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><param name="restorationHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _ContinueUserActivity (INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDContinueUserActivityRestorationHandler))]ContinueUserActivityRestorationHandler restorationHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (restorationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restorationHandler));
			using var block_restorationHandler = Trampolines.SDContinueUserActivityRestorationHandler.CreateBlock (restorationHandler);
			BlockLiteral *block_ptr_restorationHandler = &block_restorationHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:continueUserActivity:restorationHandler:"), application__handle__, userActivity__handle__, (IntPtr) block_ptr_restorationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didFailToContinueUserActivityWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToContinueUserActivity (NSApplication application, string userActivityType, NSError error)
		{
			_FailedToContinueUserActivity (this, application, userActivityType, error);
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToContinueUserActivity (INSApplicationDelegate This, NSApplication application, string userActivityType, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToContinueUserActivityWithType:error:"), application__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didUpdateUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedUserActivity (NSApplication application, NSUserActivity userActivity)
		{
			_UpdatedUserActivity (this, application, userActivity);
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedUserActivity (INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didUpdateUserActivity:"), application__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
		}
		/// <param name="application">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:userDidAcceptCloudKitShareWithMetadata:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (NSApplication application, global::CloudKit.CKShareMetadata metadata)
		{
			_UserDidAcceptCloudKitShare (this, application, metadata);
		}
		/// <param name="application">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserDidAcceptCloudKitShare (INSApplicationDelegate This, NSApplication application, global::CloudKit.CKShareMetadata metadata)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:userDidAcceptCloudKitShareWithMetadata:"), application__handle__, metadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (metadata);
		}
		/// <param name="application">To be added.</param><param name="urls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openURLs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrls (NSApplication application, NSUrl[] urls)
		{
			_OpenUrls (this, application, urls);
		}
		/// <param name="application">To be added.</param><param name="urls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenUrls (INSApplicationDelegate This, NSApplication application, NSUrl[] urls)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openURLs:"), application__handle__, nsa_urls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="sender">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:delegateHandlesKey:")]
		[ObsoletedOSPlatform ("macos11.0", "Now optional on NSApplicationDelegate.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandlesKey (NSApplication sender, string key)
		{
			return _HandlesKey (this, sender, key);
		}
		/// <param name="sender">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos11.0", "Now optional on NSApplicationDelegate.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HandlesKey (INSApplicationDelegate This, NSApplication sender, string key)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:delegateHandlesKey:"), sender__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationSupportsSecureRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsSecureRestorableState (NSApplication application)
		{
			return _SupportsSecureRestorableState (this, application);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsSecureRestorableState (INSApplicationDelegate This, NSApplication application)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationSupportsSecureRestorableState:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("application:handlerForIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandler (NSApplication application, global::Intents.INIntent intent)
		{
			return _GetHandler (this, application, intent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetHandler (INSApplicationDelegate This, NSApplication application, global::Intents.INIntent intent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handlerForIntent:"), application__handle__, intent__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (intent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldAutomaticallyLocalizeKeyEquivalents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyLocalizeKeyEquivalents (NSApplication application)
		{
			return _ShouldAutomaticallyLocalizeKeyEquivalents (this, application);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAutomaticallyLocalizeKeyEquivalents (INSApplicationDelegate This, NSApplication application)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldAutomaticallyLocalizeKeyEquivalents:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationProtectedDataWillBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataWillBecomeUnavailable (NSNotification notification)
		{
			_ProtectedDataWillBecomeUnavailable (this, notification);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProtectedDataWillBecomeUnavailable (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataWillBecomeUnavailable:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationProtectedDataDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataDidBecomeAvailable (NSNotification notification)
		{
			_ProtectedDataDidBecomeAvailable (this, notification);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProtectedDataDidBecomeAvailable (INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataDidBecomeAvailable:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[DynamicDependencyAttribute ("ApplicationDockMenu(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("ApplicationOpenUntitledFile(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("ApplicationShouldHandleReopen(AppKit.NSApplication,System.Boolean)")]
		[DynamicDependencyAttribute ("ApplicationShouldOpenUntitledFile(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("ApplicationShouldTerminate(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("ApplicationShouldTerminateAfterLastWindowClosed(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("ContinueUserActivity(AppKit.NSApplication,Foundation.NSUserActivity,AppKit.ContinueUserActivityRestorationHandler)")]
		[DynamicDependencyAttribute ("DecodedRestorableState(AppKit.NSApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("DidBecomeActive(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidFinishLaunching(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidHide(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidResignActive(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidUnhide(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidUpdate(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("FailedToContinueUserActivity(AppKit.NSApplication,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FailedToRegisterForRemoteNotifications(AppKit.NSApplication,Foundation.NSError)")]
		[DynamicDependencyAttribute ("GetHandler(AppKit.NSApplication,Intents.INIntent)")]
		[DynamicDependencyAttribute ("HandlesKey(AppKit.NSApplication,System.String)")]
		[DynamicDependencyAttribute ("OpenFile(AppKit.NSApplication,System.String)")]
		[DynamicDependencyAttribute ("OpenFiles(AppKit.NSApplication,System.String[])")]
		[DynamicDependencyAttribute ("OpenFileWithoutUI(Foundation.NSObject,System.String)")]
		[DynamicDependencyAttribute ("OpenTempFile(AppKit.NSApplication,System.String)")]
		[DynamicDependencyAttribute ("OpenUrls(AppKit.NSApplication,Foundation.NSUrl[])")]
		[DynamicDependencyAttribute ("PrintFile(AppKit.NSApplication,System.String)")]
		[DynamicDependencyAttribute ("PrintFiles(AppKit.NSApplication,System.String[],Foundation.NSDictionary,System.Boolean)")]
		[DynamicDependencyAttribute ("ProtectedDataDidBecomeAvailable(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ProtectedDataWillBecomeUnavailable(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ReceivedRemoteNotification(AppKit.NSApplication,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("RegisteredForRemoteNotifications(AppKit.NSApplication,Foundation.NSData)")]
		[DynamicDependencyAttribute ("ScreenParametersChanged(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ShouldAutomaticallyLocalizeKeyEquivalents(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("SupportsSecureRestorableState(AppKit.NSApplication)")]
		[DynamicDependencyAttribute ("UpdatedUserActivity(AppKit.NSApplication,Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("UserDidAcceptCloudKitShare(AppKit.NSApplication,CloudKit.CKShareMetadata)")]
		[DynamicDependencyAttribute ("WillBecomeActive(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillContinueUserActivity(AppKit.NSApplication,System.String)")]
		[DynamicDependencyAttribute ("WillEncodeRestorableState(AppKit.NSApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("WillFinishLaunching(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillHide(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillPresentError(AppKit.NSApplication,Foundation.NSError)")]
		[DynamicDependencyAttribute ("WillResignActive(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillTerminate(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillUnhide(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("WillUpdate(Foundation.NSNotification)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSApplicationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSApplicationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSApplicationDelegate" /> interface to support all the methods from the NSApplicationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSApplicationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSApplicationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSApplicationDelegate_Extensions {
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSApplicationTerminateReply ApplicationShouldTerminate (this INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSApplicationTerminateReply ret;
			ret = (NSApplicationTerminateReply) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldTerminate:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OpenFile (this INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filenames">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenFiles (this INSApplicationDelegate This, NSApplication sender, string[] filenames)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filenames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filenames));
			using var nsa_filenames = NSArray.FromStrings (filenames);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFiles:"), sender__handle__, nsa_filenames.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OpenTempFile (this INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openTempFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ApplicationShouldOpenUntitledFile (this INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldOpenUntitledFile:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ApplicationOpenUntitledFile (this INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationOpenUntitledFile:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OpenFileWithoutUI (this INSApplicationDelegate This, NSObject sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openFileWithoutUI:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PrintFile (this INSApplicationDelegate This, NSApplication sender, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:printFile:"), sender__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="fileNames">To be added.</param><param name="printSettings">To be added.</param><param name="showPrintPanels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSApplicationPrintReply PrintFiles (this INSApplicationDelegate This, NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (fileNames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileNames));
			var printSettings__handle__ = printSettings!.GetNonNullHandle (nameof (printSettings));
			using var nsa_fileNames = NSArray.FromStrings (fileNames);
			NSApplicationPrintReply ret;
			ret = (NSApplicationPrintReply) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("application:printFiles:withSettings:showPrintPanels:"), application__handle__, nsa_fileNames.Handle, printSettings__handle__, showPrintPanels ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (printSettings);
			return ret!;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ApplicationShouldTerminateAfterLastWindowClosed (this INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldTerminateAfterLastWindowClosed:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><param name="hasVisibleWindows">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ApplicationShouldHandleReopen (this INSApplicationDelegate This, NSApplication sender, bool hasVisibleWindows)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("applicationShouldHandleReopen:hasVisibleWindows:"), sender__handle__, hasVisibleWindows ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMenu ApplicationDockMenu (this INSApplicationDelegate This, NSApplication sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDockMenu:"), sender__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError WillPresentError (this INSApplicationDelegate This, NSApplication application, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willPresentError:"), application__handle__, error__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillFinishLaunching (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillFinishLaunching:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishLaunching (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidFinishLaunching:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHide (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillHide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHide (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidHide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUnhide (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillUnhide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnhide (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidUnhide:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBecomeActive (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillBecomeActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeActive (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidBecomeActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillResignActive (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillResignActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidResignActive (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidResignActive:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillUpdate (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillUpdate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidUpdate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTerminate (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillTerminate:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScreenParametersChanged (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidChangeScreenParameters:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="application">To be added.</param><param name="deviceToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisteredForRemoteNotifications (this INSApplicationDelegate This, NSApplication application, NSData deviceToken)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didRegisterForRemoteNotificationsWithDeviceToken:"), application__handle__, deviceToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (deviceToken);
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToRegisterForRemoteNotifications (this INSApplicationDelegate This, NSApplication application, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToRegisterForRemoteNotificationsWithError:"), application__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedRemoteNotification (this INSApplicationDelegate This, NSApplication application, NSDictionary userInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:"), application__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="app">To be added.</param><param name="encoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEncodeRestorableState (this INSApplicationDelegate This, NSApplication app, NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willEncodeRestorableState:"), app__handle__, encoder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (encoder);
		}
		/// <param name="app">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecodedRestorableState (this INSApplicationDelegate This, NSApplication app, NSCoder state)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDecodeRestorableState:"), app__handle__, state__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (state);
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillContinueUserActivity (this INSApplicationDelegate This, NSApplication application, string userActivityType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willContinueUserActivityWithType:"), application__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nsuserActivityType);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><param name="restorationHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ContinueUserActivity (this INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDContinueUserActivityRestorationHandler))]ContinueUserActivityRestorationHandler restorationHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (restorationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restorationHandler));
			using var block_restorationHandler = Trampolines.SDContinueUserActivityRestorationHandler.CreateBlock (restorationHandler);
			BlockLiteral *block_ptr_restorationHandler = &block_restorationHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:continueUserActivity:restorationHandler:"), application__handle__, userActivity__handle__, (IntPtr) block_ptr_restorationHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToContinueUserActivity (this INSApplicationDelegate This, NSApplication application, string userActivityType, NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToContinueUserActivityWithType:error:"), application__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedUserActivity (this INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didUpdateUserActivity:"), application__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
		}
		/// <param name="application">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserDidAcceptCloudKitShare (this INSApplicationDelegate This, NSApplication application, global::CloudKit.CKShareMetadata metadata)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:userDidAcceptCloudKitShareWithMetadata:"), application__handle__, metadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (metadata);
		}
		/// <param name="application">To be added.</param><param name="urls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenUrls (this INSApplicationDelegate This, NSApplication application, NSUrl[] urls)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (urls is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (urls));
			using var nsa_urls = NSArray.FromNSObjects (urls);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openURLs:"), application__handle__, nsa_urls.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="sender">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos11.0", "Now optional on NSApplicationDelegate.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandlesKey (this INSApplicationDelegate This, NSApplication sender, string key)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:delegateHandlesKey:"), sender__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsSecureRestorableState (this INSApplicationDelegate This, NSApplication application)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationSupportsSecureRestorableState:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetHandler (this INSApplicationDelegate This, NSApplication application, global::Intents.INIntent intent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handlerForIntent:"), application__handle__, intent__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (intent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAutomaticallyLocalizeKeyEquivalents (this INSApplicationDelegate This, NSApplication application)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldAutomaticallyLocalizeKeyEquivalents:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProtectedDataWillBecomeUnavailable (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataWillBecomeUnavailable:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProtectedDataDidBecomeAvailable (this INSApplicationDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataDidBecomeAvailable:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSApplicationDelegateWrapper : BaseWrapper, INSApplicationDelegate {
		public NSApplicationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSApplicationDelegateWrapper))]
		static NSApplicationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSApplicationDelegate" /> (for the protocol <c>NSApplicationDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSApplicationDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSApplicationDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSApplicationDelegate : NSObject, INSApplicationDelegate {
		/// <summary>Creates a new <see cref="NSApplicationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSApplicationDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSApplicationDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSApplicationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationDockMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu ApplicationDockMenu (NSApplication sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationOpenUntitledFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationOpenUntitledFile (NSApplication sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="hasVisibleWindows">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationShouldHandleReopen:hasVisibleWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldHandleReopen (NSApplication sender, bool hasVisibleWindows)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationShouldOpenUntitledFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldOpenUntitledFile (NSApplication sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationShouldTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSApplicationTerminateReply ApplicationShouldTerminate (NSApplication sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applicationShouldTerminateAfterLastWindowClosed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><param name="restorationHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:continueUserActivity:restorationHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ContinueUserActivity (NSApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDContinueUserActivityRestorationHandler))]ContinueUserActivityRestorationHandler restorationHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didDecodeRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodedRestorableState (NSApplication app, NSCoder state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLaunching (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidHide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHide (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResignActive (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidUnhide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnhide (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToContinueUserActivityWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToContinueUserActivity (NSApplication application, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToRegisterForRemoteNotificationsWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToRegisterForRemoteNotifications (NSApplication application, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:handlerForIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandler (NSApplication application, global::Intents.INIntent intent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:delegateHandlesKey:")]
		[ObsoletedOSPlatform ("macos11.0", "Now optional on NSApplicationDelegate.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandlesKey (NSApplication sender, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFile (NSApplication sender, string filename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openFileWithoutUI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenFileWithoutUI (NSObject sender, string filename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="filenames">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:openFiles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenFiles (NSApplication sender, string[] filenames)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openTempFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenTempFile (NSApplication sender, string filename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="urls">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:openURLs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrls (NSApplication application, NSUrl[] urls)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:printFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrintFile (NSApplication sender, string filename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="fileNames">To be added.</param><param name="printSettings">To be added.</param><param name="showPrintPanels">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:printFiles:withSettings:showPrintPanels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSApplicationPrintReply PrintFiles (NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationProtectedDataDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataDidBecomeAvailable (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationProtectedDataWillBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataWillBecomeUnavailable (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveRemoteNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedRemoteNotification (NSApplication application, NSDictionary userInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="deviceToken">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisteredForRemoteNotifications (NSApplication application, NSData deviceToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidChangeScreenParameters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScreenParametersChanged (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationShouldAutomaticallyLocalizeKeyEquivalents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyLocalizeKeyEquivalents (NSApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationSupportsSecureRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsSecureRestorableState (NSApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didUpdateUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedUserActivity (NSApplication application, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:userDidAcceptCloudKitShareWithMetadata:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (NSApplication application, global::CloudKit.CKShareMetadata metadata)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBecomeActive (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willContinueUserActivityWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillContinueUserActivity (NSApplication application, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="encoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:willEncodeRestorableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (NSApplication app, NSCoder encoder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillFinishLaunching (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillHide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHide (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willPresentError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError WillPresentError (NSApplication application, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillUnhide:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUnhide (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillUpdate (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSApplicationDelegate */
}
