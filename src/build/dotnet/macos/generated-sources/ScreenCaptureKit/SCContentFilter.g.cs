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
namespace ScreenCaptureKit {
	[Register("SCContentFilter", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	public unsafe partial class SCContentFilter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentRectX = "contentRect";
		static readonly NativeHandle selContentRectXHandle = Selector.GetHandle ("contentRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludeMenuBarX = "includeMenuBar";
		static readonly NativeHandle selIncludeMenuBarXHandle = Selector.GetHandle ("includeMenuBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludedApplicationsX = "includedApplications";
		static readonly NativeHandle selIncludedApplicationsXHandle = Selector.GetHandle ("includedApplications");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludedDisplaysX = "includedDisplays";
		static readonly NativeHandle selIncludedDisplaysXHandle = Selector.GetHandle ("includedDisplays");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIncludedWindowsX = "includedWindows";
		static readonly NativeHandle selIncludedWindowsXHandle = Selector.GetHandle ("includedWindows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDesktopIndependentWindow_X = "initWithDesktopIndependentWindow:";
		static readonly NativeHandle selInitWithDesktopIndependentWindow_XHandle = Selector.GetHandle ("initWithDesktopIndependentWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDisplay_ExcludingApplications_ExceptingWindows_X = "initWithDisplay:excludingApplications:exceptingWindows:";
		static readonly NativeHandle selInitWithDisplay_ExcludingApplications_ExceptingWindows_XHandle = Selector.GetHandle ("initWithDisplay:excludingApplications:exceptingWindows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDisplay_ExcludingWindows_X = "initWithDisplay:excludingWindows:";
		static readonly NativeHandle selInitWithDisplay_ExcludingWindows_XHandle = Selector.GetHandle ("initWithDisplay:excludingWindows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDisplay_IncludingApplications_ExceptingWindows_X = "initWithDisplay:includingApplications:exceptingWindows:";
		static readonly NativeHandle selInitWithDisplay_IncludingApplications_ExceptingWindows_XHandle = Selector.GetHandle ("initWithDisplay:includingApplications:exceptingWindows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDisplay_IncludingWindows_X = "initWithDisplay:includingWindows:";
		static readonly NativeHandle selInitWithDisplay_IncludingWindows_XHandle = Selector.GetHandle ("initWithDisplay:includingWindows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointPixelScaleX = "pointPixelScale";
		static readonly NativeHandle selPointPixelScaleXHandle = Selector.GetHandle ("pointPixelScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIncludeMenuBar_X = "setIncludeMenuBar:";
		static readonly NativeHandle selSetIncludeMenuBar_XHandle = Selector.GetHandle ("setIncludeMenuBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStreamTypeX = "streamType";
		static readonly NativeHandle selStreamTypeXHandle = Selector.GetHandle ("streamType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleX = "style";
		static readonly NativeHandle selStyleXHandle = Selector.GetHandle ("style");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCContentFilter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected SCContentFilter (NSObjectFlag t) : base (t)
		{
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
		protected internal SCContentFilter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDesktopIndependentWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCContentFilter (SCWindow window)
			: base (NSObjectFlag.Empty)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDesktopIndependentWindow_XHandle, window__handle__), "initWithDesktopIndependentWindow:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDesktopIndependentWindow_XHandle, window__handle__), "initWithDesktopIndependentWindow:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
		}
		[Export ("initWithDisplay:excludingApplications:exceptingWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithDisplayExcludingApplications (SCDisplay display, SCRunningApplication[] excludingApplications, SCWindow[] exceptingWindows)
		{
			var display__handle__ = display!.GetNonNullHandle (nameof (display));
			if (excludingApplications is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (excludingApplications));
			if (exceptingWindows is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (exceptingWindows));
			using var nsa_excludingApplications = NSArray.FromNSObjects (excludingApplications);
			using var nsa_exceptingWindows = NSArray.FromNSObjects (exceptingWindows);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithDisplay_ExcludingApplications_ExceptingWindows_XHandle, display__handle__, nsa_excludingApplications.Handle, nsa_exceptingWindows.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithDisplay_ExcludingApplications_ExceptingWindows_XHandle, display__handle__, nsa_excludingApplications.Handle, nsa_exceptingWindows.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (display);
			return ret!;
		}
		[Export ("initWithDisplay:excludingWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithDisplayExcludingWindows (SCDisplay display, SCWindow[] excludedWindows)
		{
			var display__handle__ = display!.GetNonNullHandle (nameof (display));
			if (excludedWindows is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (excludedWindows));
			using var nsa_excludedWindows = NSArray.FromNSObjects (excludedWindows);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDisplay_ExcludingWindows_XHandle, display__handle__, nsa_excludedWindows.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDisplay_ExcludingWindows_XHandle, display__handle__, nsa_excludedWindows.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (display);
			return ret!;
		}
		[Export ("initWithDisplay:includingApplications:exceptingWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithDisplayIncludingApplications (SCDisplay display, SCRunningApplication[] includingApplications, SCWindow[] exceptingWindows)
		{
			var display__handle__ = display!.GetNonNullHandle (nameof (display));
			if (includingApplications is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (includingApplications));
			if (exceptingWindows is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (exceptingWindows));
			using var nsa_includingApplications = NSArray.FromNSObjects (includingApplications);
			using var nsa_exceptingWindows = NSArray.FromNSObjects (exceptingWindows);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithDisplay_IncludingApplications_ExceptingWindows_XHandle, display__handle__, nsa_includingApplications.Handle, nsa_exceptingWindows.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithDisplay_IncludingApplications_ExceptingWindows_XHandle, display__handle__, nsa_includingApplications.Handle, nsa_exceptingWindows.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (display);
			return ret!;
		}
		[Export ("initWithDisplay:includingWindows:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithDisplayIncludingWindows (SCDisplay display, SCWindow[] includedWindows)
		{
			var display__handle__ = display!.GetNonNullHandle (nameof (display));
			if (includedWindows is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (includedWindows));
			using var nsa_includedWindows = NSArray.FromNSObjects (includedWindows);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDisplay_IncludingWindows_XHandle, display__handle__, nsa_includedWindows.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDisplay_IncludingWindows_XHandle, display__handle__, nsa_includedWindows.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (display);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public virtual CGRect ContentRect {
			[Export ("contentRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selContentRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selContentRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selContentRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selContentRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.2")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public virtual bool IncludeMenuBar {
			[Export ("includeMenuBar")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIncludeMenuBarXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIncludeMenuBarXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIncludeMenuBar:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIncludeMenuBar_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIncludeMenuBar_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual SCRunningApplication[] IncludedApplications {
			[Export ("includedApplications")]
			get {
				SCRunningApplication[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCRunningApplication>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIncludedApplicationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCRunningApplication>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIncludedApplicationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual SCDisplay[] IncludedDisplays {
			[Export ("includedDisplays")]
			get {
				SCDisplay[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCDisplay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIncludedDisplaysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCDisplay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIncludedDisplaysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual SCWindow[] IncludedWindows {
			[Export ("includedWindows")]
			get {
				SCWindow[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCWindow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIncludedWindowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCWindow>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIncludedWindowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public virtual float PointPixelScale {
			[Export ("pointPixelScale")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPointPixelScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPointPixelScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.2", "Use 'Style' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual SCStreamType StreamType {
			[Export ("streamType")]
			get {
				SCStreamType ret;
				if (IsDirectBinding) {
					ret = (ScreenCaptureKit.SCStreamType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStreamTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ScreenCaptureKit.SCStreamType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStreamTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public virtual SCShareableContentStyle Style {
			[Export ("style")]
			get {
				SCShareableContentStyle ret;
				if (IsDirectBinding) {
					ret = (ScreenCaptureKit.SCShareableContentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ScreenCaptureKit.SCShareableContentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SCContentFilter */
}
