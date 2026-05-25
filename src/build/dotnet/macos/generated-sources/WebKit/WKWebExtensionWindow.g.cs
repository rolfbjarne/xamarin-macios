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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>WKWebExtensionWindow</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[SupportedOSPlatform ("ios18.4")]
	[SupportedOSPlatform ("maccatalyst18.4")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "WKWebExtensionWindow", WrapperType = typeof (WKWebExtensionWindowWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTabs", Selector = "tabsForWebExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionTab[]), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ActiveTab", Selector = "activeTabForWebExtensionContext:", ReturnType = typeof (WebKit.IWKWebExtensionTab), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWindowType", Selector = "windowTypeForWebExtensionContext:", ReturnType = typeof (WebKit.WKWebExtensionWindowType), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWindowState", Selector = "windowStateForWebExtensionContext:", ReturnType = typeof (WebKit.WKWebExtensionWindowState), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetWindowState", Selector = "setWindowState:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionWindowState), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionWindowCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsPrivate", Selector = "isPrivateForWebExtensionContext:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetScreenFrame", Selector = "screenFrameForWebExtensionContext:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFrame", Selector = "frameForWebExtensionContext:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetFrame", Selector = "setFrame:forWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (CGRect), typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionWindowCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Focus", Selector = "focusForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionWindowCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Close", Selector = "closeForWebExtensionContext:completionHandler:", ParameterType = new Type [] { typeof (WebKit.WKWebExtensionContext), typeof (WebKit.WKWebExtensionWindowCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback) })]
	public partial interface IWKWebExtensionWindow : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("tabsForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionTab[] GetTabs (WKWebExtensionContext context)
		{
			return _GetTabs (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionTab[] _GetTabs (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			IWKWebExtensionTab[]? ret;
			ret = CFArray.ArrayFromHandle<IWKWebExtensionTab>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("tabsForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("activeTabForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IWKWebExtensionTab? ActiveTab (WKWebExtensionContext context)
		{
			return _ActiveTab (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IWKWebExtensionTab? _ActiveTab (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			IWKWebExtensionTab? ret;
			ret =  Runtime.GetINativeObject<IWKWebExtensionTab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activeTabForWebExtensionContext:"), context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("windowTypeForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionWindowType GetWindowType (WKWebExtensionContext context)
		{
			return _GetWindowType (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WKWebExtensionWindowType _GetWindowType (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			WKWebExtensionWindowType ret;
			ret = (WebKit.WKWebExtensionWindowType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("windowTypeForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("windowStateForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WKWebExtensionWindowState GetWindowState (WKWebExtensionContext context)
		{
			return _GetWindowState (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static WKWebExtensionWindowState _GetWindowState (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			WKWebExtensionWindowState ret;
			ret = (WebKit.WKWebExtensionWindowState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("windowStateForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("setWindowState:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetWindowState (WKWebExtensionWindowState state, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			_SetWindowState (this, state, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetWindowStateAsync (WKWebExtensionWindowState state, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetWindowState(state, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetWindowState (IWKWebExtensionWindow This, WKWebExtensionWindowState state, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionWindowCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setWindowState:forWebExtensionContext:completionHandler:"), (IntPtr) (long) state, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("isPrivateForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPrivate (WKWebExtensionContext context)
		{
			return _IsPrivate (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsPrivate (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isPrivateForWebExtensionContext:"), context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("screenFrameForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetScreenFrame (WKWebExtensionContext context)
		{
			return _GetScreenFrame (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetScreenFrame (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("screenFrameForWebExtensionContext:"), context__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("screenFrameForWebExtensionContext:"), context__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("frameForWebExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrame (WKWebExtensionContext context)
		{
			return _GetFrame (this, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrame (IWKWebExtensionWindow This, WKWebExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("frameForWebExtensionContext:"), context__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("frameForWebExtensionContext:"), context__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("setFrame:forWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetFrame (CGRect frame, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			_SetFrame (this, frame, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetFrameAsync (CGRect frame, WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetFrame(frame, context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetFrame (IWKWebExtensionWindow This, CGRect frame, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionWindowCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setFrame:forWebExtensionContext:completionHandler:"), frame, context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("focusForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Focus (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			_Focus (this, context, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task FocusAsync (WKWebExtensionContext context)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Focus(context, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Focus (IWKWebExtensionWindow This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionWindowCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("focusForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("closeForWebExtensionContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Close (WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
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
		internal unsafe static void _Close (IWKWebExtensionWindow This, WKWebExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWKWebExtensionWindowCallback))]WKWebExtensionWindowCallback completionHandler)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDWKWebExtensionWindowCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("closeForWebExtensionContext:completionHandler:"), context__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
		[DynamicDependencyAttribute ("ActiveTab(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("Close(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionWindowCallback)")]
		[DynamicDependencyAttribute ("Focus(WebKit.WKWebExtensionContext,WebKit.WKWebExtensionWindowCallback)")]
		[DynamicDependencyAttribute ("GetFrame(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetScreenFrame(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetTabs(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetWindowState(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("GetWindowType(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("IsPrivate(WebKit.WKWebExtensionContext)")]
		[DynamicDependencyAttribute ("SetFrame(CoreGraphics.CGRect,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionWindowCallback)")]
		[DynamicDependencyAttribute ("SetWindowState(WebKit.WKWebExtensionWindowState,WebKit.WKWebExtensionContext,WebKit.WKWebExtensionWindowCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionWindowWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWKWebExtensionWindow ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WKWebExtensionWindowWrapper : BaseWrapper, IWKWebExtensionWindow {
		public WKWebExtensionWindowWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WKWebExtensionWindowWrapper))]
		static WKWebExtensionWindowWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
