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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>WKWebExtensionTab</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "WKWebExtensionTab", WrapperType = typeof (WKWebExtensionTabWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWindow", Selector = "windowForWebExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionWindow), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexInWindow", Selector = "indexInWindowForWebExtensionContext:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetParentTab", Selector = "parentTabForWebExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionTab), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetParentTab", Selector = "setParentTab:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.IWKWebExtensionTab), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWebView", Selector = "webViewForWebExtensionContext:", ReturnType = typeof (WebKit.WKWebView), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTitle", Selector = "titleForWebExtensionContext:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsPinned", Selector = "isPinnedForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPinned", Selector = "setPinned:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsReaderModeAvailable", Selector = "isReaderModeAvailableForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsReaderModeActive", Selector = "isReaderModeActiveForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetReaderModeActive", Selector = "setReaderModeActive:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsPlayingAudio", Selector = "isPlayingAudioForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsMuted", Selector = "isMutedForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMuted", Selector = "setMuted:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSize", Selector = "sizeForWebExtensionContext:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetZoomFactor", Selector = "zoomFactorForWebExtensionContext:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetZoomFactor", Selector = "setZoomFactor:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (double), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUrl", Selector = "urlForWebExtensionContext:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPendingUrl", Selector = "pendingURLForWebExtensionContext:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsLoadingComplete", Selector = "isLoadingCompleteForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DetectWebpageLocale", Selector = "detectWebpageLocaleForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabDetectLocaleCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDetectLocaleCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TakeSnapshot", Selector = "takeSnapshotUsingConfiguration:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKSnapshotConfiguration), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabTakeSnapshotCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabTakeSnapshotCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadUrl", Selector = "loadURL:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (NSUrl), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReloadFromOrigin", Selector = "reloadFromOrigin:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GoBack", Selector = "goBackForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GoForward", Selector = "goForwardForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Activate", Selector = "activateForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsSelected", Selector = "isSelectedForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSelected", Selector = "setSelected:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Duplicate", Selector = "duplicateUsingConfiguration:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionTabConfiguration), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabDuplicateCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDuplicateCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Close", Selector = "closeForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionTabCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGrantPermissionsOnUserGesture", Selector = "shouldGrantPermissionsOnUserGestureForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBypassPermissions", Selector = "shouldBypassPermissionsForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	public partial interface IWKWebExtensionTab : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("windowForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionWindow? GetWindow (WKWebExtensionContext context)
		{
			return _GetWindow (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionWindow? _GetWindow (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			IWKWebExtensionWindow? ret;
			ret =  Runtime.GetINativeObject<IWKWebExtensionWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("windowForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("indexInWindowForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetIndexInWindow (WKWebExtensionContext context)
		{
			return _GetIndexInWindow (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetIndexInWindow (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexInWindowForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("parentTabForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionTab? GetParentTab (WKWebExtensionContext context)
		{
			return _GetParentTab (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionTab? _GetParentTab (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			IWKWebExtensionTab? ret;
			ret =  Runtime.GetINativeObject<IWKWebExtensionTab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("parentTabForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("setParentTab:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetParentTab (IWKWebExtensionTab? parentTab, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetParentTab (this, parentTab, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetParentTabAsync (IWKWebExtensionTab? parentTab, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetParentTab(parentTab, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetParentTab (IWKWebExtensionTab This, IWKWebExtensionTab? parentTab, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var parentTab__handle__ = parentTab.GetHandle ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setParentTab:forWebExtensionContext:completionHandler:"), parentTab__handle__, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (parentTab);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("webViewForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebView? GetWebView (WKWebExtensionContext context)
		{
			return _GetWebView (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WKWebView? _GetWebView (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			WKWebView? ret;
			ret =  Runtime.GetNSObject<WKWebView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("webViewForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("titleForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetTitle (WKWebExtensionContext context)
		{
			return _GetTitle (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetTitle (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("titleForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("isPinnedForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPinned (WKWebExtensionContext context)
		{
			return _IsPinned (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsPinned (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isPinnedForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("setPinned:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetPinned (bool pinned, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetPinned (this, pinned, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetPinnedAsync (bool pinned, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetPinned(pinned, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetPinned (IWKWebExtensionTab This, bool pinned, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setPinned:forWebExtensionContext:completionHandler:"), pinned ? (byte) 1 : (byte) 0, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("isReaderModeAvailableForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsReaderModeAvailable (WKWebExtensionContext context)
		{
			return _IsReaderModeAvailable (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsReaderModeAvailable (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isReaderModeAvailableForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("isReaderModeActiveForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsReaderModeActive (WKWebExtensionContext context)
		{
			return _IsReaderModeActive (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsReaderModeActive (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isReaderModeActiveForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("setReaderModeActive:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetReaderModeActive (bool active, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetReaderModeActive (this, active, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetReaderModeActiveAsync (bool active, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetReaderModeActive(active, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetReaderModeActive (IWKWebExtensionTab This, bool active, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setReaderModeActive:forWebExtensionContext:completionHandler:"), active ? (byte) 1 : (byte) 0, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("isPlayingAudioForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPlayingAudio (WKWebExtensionContext context)
		{
			return _IsPlayingAudio (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsPlayingAudio (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isPlayingAudioForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("isMutedForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMuted (WKWebExtensionContext context)
		{
			return _IsMuted (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsMuted (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isMutedForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("setMuted:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetMuted (bool muted, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetMuted (this, muted, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetMutedAsync (bool muted, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetMuted(muted, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetMuted (IWKWebExtensionTab This, bool muted, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setMuted:forWebExtensionContext:completionHandler:"), muted ? (byte) 1 : (byte) 0, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("sizeForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSize (WKWebExtensionContext context)
		{
			return _GetSize (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetSize (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sizeForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("zoomFactorForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetZoomFactor (WKWebExtensionContext context)
		{
			return _GetZoomFactor (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetZoomFactor (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("zoomFactorForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("setZoomFactor:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetZoomFactor (double zoomFactor, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetZoomFactor (this, zoomFactor, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetZoomFactorAsync (double zoomFactor, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetZoomFactor(zoomFactor, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetZoomFactor (IWKWebExtensionTab This, double zoomFactor, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setZoomFactor:forWebExtensionContext:completionHandler:"), zoomFactor, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("urlForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrl (WKWebExtensionContext context)
		{
			return _GetUrl (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl? _GetUrl (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("urlForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pendingURLForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetPendingUrl (WKWebExtensionContext context)
		{
			return _GetPendingUrl (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl? _GetPendingUrl (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pendingURLForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("isLoadingCompleteForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLoadingComplete (WKWebExtensionContext context)
		{
			return _IsLoadingComplete (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsLoadingComplete (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isLoadingCompleteForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("detectWebpageLocaleForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectWebpageLocale (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDetectLocaleCallback))]WKWebExtensionTabDetectLocaleCallback completionHandler)
		{
			_DetectWebpageLocale (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSLocale> DetectWebpageLocaleAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<NSLocale> ();
			DetectWebpageLocale(context, (locale_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (locale_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DetectWebpageLocale (IWKWebExtensionTab This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDetectLocaleCallback))]WKWebExtensionTabDetectLocaleCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabDetectLocaleCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("detectWebpageLocaleForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("takeSnapshotUsingConfiguration:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TakeSnapshot (WKSnapshotConfiguration configuration, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabTakeSnapshotCallback))]WKWebExtensionTabTakeSnapshotCallback completionHandler)
		{
			_TakeSnapshot (this, configuration, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::UIKit.UIImage> TakeSnapshotAsync (WKSnapshotConfiguration configuration, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<global::UIKit.UIImage> ();
			TakeSnapshot(configuration, context, (webpageImage_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (webpageImage_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _TakeSnapshot (IWKWebExtensionTab This, WKSnapshotConfiguration configuration, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabTakeSnapshotCallback))]WKWebExtensionTabTakeSnapshotCallback completionHandler)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabTakeSnapshotCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("takeSnapshotUsingConfiguration:forWebExtensionContext:completionHandler:"), configuration__handle__, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (configuration);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("loadURL:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadUrl (NSUrl url, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_LoadUrl (this, url, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task LoadUrlAsync (NSUrl url, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			LoadUrl(url, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadUrl (IWKWebExtensionTab This, NSUrl url, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadURL:forWebExtensionContext:completionHandler:"), url__handle__, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("reloadFromOrigin:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReloadFromOrigin (bool fromOrigin, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_ReloadFromOrigin (this, fromOrigin, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReloadFromOriginAsync (bool fromOrigin, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReloadFromOrigin(fromOrigin, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReloadFromOrigin (IWKWebExtensionTab This, bool fromOrigin, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("reloadFromOrigin:forWebExtensionContext:completionHandler:"), fromOrigin ? (byte) 1 : (byte) 0, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("goBackForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GoBack (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_GoBack (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task GoBackAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			GoBack(context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GoBack (IWKWebExtensionTab This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("goBackForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("goForwardForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GoForward (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_GoForward (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task GoForwardAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			GoForward(context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GoForward (IWKWebExtensionTab This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("goForwardForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("activateForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Activate (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_Activate (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ActivateAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Activate(context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Activate (IWKWebExtensionTab This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activateForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("isSelectedForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSelected (WKWebExtensionContext context)
		{
			return _IsSelected (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsSelected (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isSelectedForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("setSelected:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetSelected (bool selected, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_SetSelected (this, selected, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetSelectedAsync (bool selected, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetSelected(selected, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetSelected (IWKWebExtensionTab This, bool selected, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setSelected:forWebExtensionContext:completionHandler:"), selected ? (byte) 1 : (byte) 0, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("duplicateUsingConfiguration:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Duplicate (WKWebExtensionTabConfiguration configuration, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDuplicateCallback))]WKWebExtensionTabDuplicateCallback completionHandler)
		{
			_Duplicate (this, configuration, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IWKWebExtensionTab> DuplicateAsync (WKWebExtensionTabConfiguration configuration, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<IWKWebExtensionTab> ();
			Duplicate(configuration, context, (duplicatedTab_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (duplicatedTab_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Duplicate (IWKWebExtensionTab This, WKWebExtensionTabConfiguration configuration, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabDuplicateCallback))]WKWebExtensionTabDuplicateCallback completionHandler)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabDuplicateCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("duplicateUsingConfiguration:forWebExtensionContext:completionHandler:"), configuration__handle__, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (configuration);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("closeForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Close (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			_Close (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task CloseAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Close(context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Close (IWKWebExtensionTab This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionTabCallback))]WKWebExtensionTabCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionTabCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("closeForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("shouldGrantPermissionsOnUserGestureForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldGrantPermissionsOnUserGesture (WKWebExtensionContext context)
		{
			return _ShouldGrantPermissionsOnUserGesture (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldGrantPermissionsOnUserGesture (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldGrantPermissionsOnUserGestureForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("shouldBypassPermissionsForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBypassPermissions (WKWebExtensionContext context)
		{
			return _ShouldBypassPermissions (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBypassPermissions (IWKWebExtensionTab This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldBypassPermissionsForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Activate(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("Close(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("DetectWebpageLocale(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabDetectLocaleCallback)")]
		[DynamicDependencyAttribute ("Duplicate(WebKit.WKWebExtensionTabConfiguration,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabDuplicateCallback)")]
		[DynamicDependencyAttribute ("GetIndexInWindow(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetParentTab(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetPendingUrl(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetSize(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetTitle(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetUrl(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetWebView(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetWindow(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetZoomFactor(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GoBack(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("GoForward(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("IsLoadingComplete(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsMuted(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsPinned(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsPlayingAudio(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsReaderModeActive(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsReaderModeAvailable(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsSelected(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("LoadUrl(Foundation.NSUrl,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("ReloadFromOrigin(System.Boolean,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetMuted(System.Boolean,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetParentTab(WebKit.IWKWebExtensionTab,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetPinned(System.Boolean,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetReaderModeActive(System.Boolean,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetSelected(System.Boolean,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("SetZoomFactor(System.Double,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabCallback)")]
		[DynamicDependencyAttribute ("ShouldBypassPermissions(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("ShouldGrantPermissionsOnUserGesture(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("TakeSnapshot(WebKit.WKSnapshotConfiguration,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionTabTakeSnapshotCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionTabWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKWebExtensionTab ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKWebExtensionTabWrapper : BaseWrapper, IWKWebExtensionTab {
		public WKWebExtensionTabWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionTabWrapper))]
		static WKWebExtensionTabWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
