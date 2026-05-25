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
	[Register("NSCursor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCursor : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIBeamCursorX = "IBeamCursor";
		static readonly NativeHandle selIBeamCursorXHandle = Selector.GetHandle ("IBeamCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIBeamCursorForVerticalLayoutX = "IBeamCursorForVerticalLayout";
		static readonly NativeHandle selIBeamCursorForVerticalLayoutXHandle = Selector.GetHandle ("IBeamCursorForVerticalLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArrowCursorX = "arrowCursor";
		static readonly NativeHandle selArrowCursorXHandle = Selector.GetHandle ("arrowCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClosedHandCursorX = "closedHandCursor";
		static readonly NativeHandle selClosedHandCursorXHandle = Selector.GetHandle ("closedHandCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnResizeCursorX = "columnResizeCursor";
		static readonly NativeHandle selColumnResizeCursorXHandle = Selector.GetHandle ("columnResizeCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnResizeCursorInDirections_X = "columnResizeCursorInDirections:";
		static readonly NativeHandle selColumnResizeCursorInDirections_XHandle = Selector.GetHandle ("columnResizeCursorInDirections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextualMenuCursorX = "contextualMenuCursor";
		static readonly NativeHandle selContextualMenuCursorXHandle = Selector.GetHandle ("contextualMenuCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCrosshairCursorX = "crosshairCursor";
		static readonly NativeHandle selCrosshairCursorXHandle = Selector.GetHandle ("crosshairCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentCursorX = "currentCursor";
		static readonly NativeHandle selCurrentCursorXHandle = Selector.GetHandle ("currentCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentSystemCursorX = "currentSystemCursor";
		static readonly NativeHandle selCurrentSystemCursorXHandle = Selector.GetHandle ("currentSystemCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisappearingItemCursorX = "disappearingItemCursor";
		static readonly NativeHandle selDisappearingItemCursorXHandle = Selector.GetHandle ("disappearingItemCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragCopyCursorX = "dragCopyCursor";
		static readonly NativeHandle selDragCopyCursorXHandle = Selector.GetHandle ("dragCopyCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragLinkCursorX = "dragLinkCursor";
		static readonly NativeHandle selDragLinkCursorXHandle = Selector.GetHandle ("dragLinkCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameResizeCursorFromPosition_InDirections_X = "frameResizeCursorFromPosition:inDirections:";
		static readonly NativeHandle selFrameResizeCursorFromPosition_InDirections_XHandle = Selector.GetHandle ("frameResizeCursorFromPosition:inDirections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHideX = "hide";
		static readonly NativeHandle selHideXHandle = Selector.GetHandle ("hide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHotSpotX = "hotSpot";
		static readonly NativeHandle selHotSpotXHandle = Selector.GetHandle ("hotSpot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageX = "image";
		static readonly NativeHandle selImageXHandle = Selector.GetHandle ("image");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_X = "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:";
		static readonly NativeHandle selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_XHandle = Selector.GetHandle ("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithImage_HotSpot_X = "initWithImage:hotSpot:";
		static readonly NativeHandle selInitWithImage_HotSpot_XHandle = Selector.GetHandle ("initWithImage:hotSpot:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSetOnMouseEnteredX = "isSetOnMouseEntered";
		static readonly NativeHandle selIsSetOnMouseEnteredXHandle = Selector.GetHandle ("isSetOnMouseEntered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSetOnMouseExitedX = "isSetOnMouseExited";
		static readonly NativeHandle selIsSetOnMouseExitedXHandle = Selector.GetHandle ("isSetOnMouseExited");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseEntered_X = "mouseEntered:";
		static readonly NativeHandle selMouseEntered_XHandle = Selector.GetHandle ("mouseEntered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseExited_X = "mouseExited:";
		static readonly NativeHandle selMouseExited_XHandle = Selector.GetHandle ("mouseExited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenHandCursorX = "openHandCursor";
		static readonly NativeHandle selOpenHandCursorXHandle = Selector.GetHandle ("openHandCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOperationNotAllowedCursorX = "operationNotAllowedCursor";
		static readonly NativeHandle selOperationNotAllowedCursorXHandle = Selector.GetHandle ("operationNotAllowedCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointingHandCursorX = "pointingHandCursor";
		static readonly NativeHandle selPointingHandCursorXHandle = Selector.GetHandle ("pointingHandCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopX = "pop";
		static readonly NativeHandle selPopXHandle = Selector.GetHandle ("pop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPushX = "push";
		static readonly NativeHandle selPushXHandle = Selector.GetHandle ("push");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeDownCursorX = "resizeDownCursor";
		static readonly NativeHandle selResizeDownCursorXHandle = Selector.GetHandle ("resizeDownCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeLeftCursorX = "resizeLeftCursor";
		static readonly NativeHandle selResizeLeftCursorXHandle = Selector.GetHandle ("resizeLeftCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeLeftRightCursorX = "resizeLeftRightCursor";
		static readonly NativeHandle selResizeLeftRightCursorXHandle = Selector.GetHandle ("resizeLeftRightCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeRightCursorX = "resizeRightCursor";
		static readonly NativeHandle selResizeRightCursorXHandle = Selector.GetHandle ("resizeRightCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeUpCursorX = "resizeUpCursor";
		static readonly NativeHandle selResizeUpCursorXHandle = Selector.GetHandle ("resizeUpCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeUpDownCursorX = "resizeUpDownCursor";
		static readonly NativeHandle selResizeUpDownCursorXHandle = Selector.GetHandle ("resizeUpDownCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowResizeCursorX = "rowResizeCursor";
		static readonly NativeHandle selRowResizeCursorXHandle = Selector.GetHandle ("rowResizeCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowResizeCursorInDirections_X = "rowResizeCursorInDirections:";
		static readonly NativeHandle selRowResizeCursorInDirections_XHandle = Selector.GetHandle ("rowResizeCursorInDirections:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetX = "set";
		static readonly NativeHandle selSetXHandle = Selector.GetHandle ("set");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHiddenUntilMouseMoves_X = "setHiddenUntilMouseMoves:";
		static readonly NativeHandle selSetHiddenUntilMouseMoves_XHandle = Selector.GetHandle ("setHiddenUntilMouseMoves:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOnMouseEntered_X = "setOnMouseEntered:";
		static readonly NativeHandle selSetOnMouseEntered_XHandle = Selector.GetHandle ("setOnMouseEntered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOnMouseExited_X = "setOnMouseExited:";
		static readonly NativeHandle selSetOnMouseExited_XHandle = Selector.GetHandle ("setOnMouseExited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnhideX = "unhide";
		static readonly NativeHandle selUnhideXHandle = Selector.GetHandle ("unhide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomInCursorX = "zoomInCursor";
		static readonly NativeHandle selZoomInCursorXHandle = Selector.GetHandle ("zoomInCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoomOutCursorX = "zoomOutCursor";
		static readonly NativeHandle selZoomOutCursorXHandle = Selector.GetHandle ("zoomOutCursor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCursor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSCursor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCursor () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSCursor (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected NSCursor (NSObjectFlag t) : base (t)
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
		protected internal NSCursor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithImage:hotSpot:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCursor (NSImage newImage, CGPoint aPoint)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newImage__handle__ = newImage!.GetNonNullHandle (nameof (newImage));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (this.Handle, selInitWithImage_HotSpot_XHandle, newImage__handle__, aPoint), "initWithImage:hotSpot:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selInitWithImage_HotSpot_XHandle, newImage__handle__, aPoint), "initWithImage:hotSpot:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newImage);
		}
		[Export ("initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.12", "Color hints are ignored. Use NSCursor (NSImage newImage, CGPoint aPoint) instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCursor (NSImage newImage, NSColor fg, NSColor bg, CGPoint hotSpot)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newImage__handle__ = newImage!.GetNonNullHandle (nameof (newImage));
			var fg__handle__ = fg!.GetNonNullHandle (nameof (fg));
			var bg__handle__ = bg!.GetNonNullHandle (nameof (bg));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (this.Handle, selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_XHandle, newImage__handle__, fg__handle__, bg__handle__, hotSpot), "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_CGPoint (&__objc_super__, selInitWithImage_ForegroundColorHint_BackgroundColorHint_HotSpot_XHandle, newImage__handle__, fg__handle__, bg__handle__, hotSpot), "initWithImage:foregroundColorHint:backgroundColorHint:hotSpot:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newImage);
			GC.KeepAlive (fg);
			GC.KeepAlive (bg);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("columnResizeCursorInDirections:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor GetColumnResizeCursor (NSHorizontalDirections directions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCursor ret;
			ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selColumnResizeCursorInDirections_XHandle, (UIntPtr) (ulong) directions), false)!;
			return ret;
		}
		[Export ("frameResizeCursorFromPosition:inDirections:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor GetFrameResizeCursor (NSCursorFrameResizePosition position, NSCursorFrameResizeDirections directions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCursor ret;
			ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (class_ptr, selFrameResizeCursorFromPosition_InDirections_XHandle, (UIntPtr) (ulong) position, (UIntPtr) (ulong) directions), false)!;
			return ret;
		}
		[Export ("rowResizeCursorInDirections:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor GetRowResizeCursor (NSVerticalDirections directions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCursor ret;
			ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selRowResizeCursorInDirections_XHandle, (UIntPtr) (ulong) directions), false)!;
			return ret;
		}
		[Export ("hide")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Hide ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selHideXHandle);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isSetOnMouseEntered")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSetOnMouseEntered ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSetOnMouseEnteredXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSetOnMouseEnteredXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isSetOnMouseExited")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSetOnMouseExited ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSetOnMouseExitedXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSetOnMouseExitedXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("mouseEntered:")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseEntered (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseEntered_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseEntered_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("mouseExited:")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MouseExited (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMouseExited_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMouseExited_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("pop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pop ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPopXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPopXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("push")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Push ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPushXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPushXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("set")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Set ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setHiddenUntilMouseMoves:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetHiddenUntilMouseMoves (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetHiddenUntilMouseMoves_XHandle, flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setOnMouseEntered:")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOnMouseEntered (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOnMouseEntered_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetOnMouseEntered_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setOnMouseExited:")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Do not use; this API does not exist on this platform.")]
		[ObsoletedOSPlatform ("macos10.13")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOnMouseExited (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOnMouseExited_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetOnMouseExited_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unhide")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Unhide ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selUnhideXHandle);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ArrowCursor {
			[Export ("arrowCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selArrowCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ClosedHandCursor {
			[Export ("closedHandCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selClosedHandCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSCursor ColumnResizeCursor {
			[Export ("columnResizeCursor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selColumnResizeCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ContextualMenuCursor {
			[Export ("contextualMenuCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selContextualMenuCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor CrosshairCursor {
			[Export ("crosshairCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCrosshairCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor CurrentCursor {
			[Export ("currentCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "If using ScreenCaptureKit to capture the screen, use the 'SCStreamConfiguration.ShowsCursor' to control whether or not to include the cursor in the capture. Use 'NSCursor.CurrentCursor' to get the current cursor for this application.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "If using ScreenCaptureKit to capture the screen, use the 'SCStreamConfiguration.ShowsCursor' to control whether or not to include the cursor in the capture. Use 'NSCursor.CurrentCursor' to get the current cursor for this application.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSCursor? CurrentSystemCursor {
			[Export ("currentSystemCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentSystemCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor DisappearingItemCursor {
			[Export ("disappearingItemCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDisappearingItemCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor DragCopyCursor {
			[Export ("dragCopyCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDragCopyCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor DragLinkCursor {
			[Export ("dragLinkCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDragLinkCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint HotSpot {
			[Export ("hotSpot")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selHotSpotXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selHotSpotXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor IBeamCursor {
			[Export ("IBeamCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selIBeamCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor IBeamCursorForVerticalLayout {
			[Export ("IBeamCursorForVerticalLayout")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selIBeamCursorForVerticalLayoutXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage Image {
			[Export ("image")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor OpenHandCursor {
			[Export ("openHandCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOpenHandCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor OperationNotAllowedCursor {
			[Export ("operationNotAllowedCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOperationNotAllowedCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor PointingHandCursor {
			[Export ("pointingHandCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPointingHandCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeDownCursor {
			[Export ("resizeDownCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeDownCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeLeftCursor {
			[Export ("resizeLeftCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeLeftCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeLeftRightCursor {
			[Export ("resizeLeftRightCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeLeftRightCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeRightCursor {
			[Export ("resizeRightCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeRightCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeUpCursor {
			[Export ("resizeUpCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeUpCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCursor ResizeUpDownCursor {
			[Export ("resizeUpDownCursor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selResizeUpDownCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSCursor RowResizeCursor {
			[Export ("rowResizeCursor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRowResizeCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSCursor ZoomInCursor {
			[Export ("zoomInCursor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZoomInCursorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSCursor ZoomOutCursor {
			[Export ("zoomOutCursor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCursor? ret;
				ret =  Runtime.GetNSObject<NSCursor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZoomOutCursorXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSCursor */
}
