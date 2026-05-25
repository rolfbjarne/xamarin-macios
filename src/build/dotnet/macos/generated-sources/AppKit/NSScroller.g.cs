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
	[Register("NSScroller", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSScroller : NSControl {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArrowsPositionX = "arrowsPosition";
		static readonly NativeHandle selArrowsPositionXHandle = Selector.GetHandle ("arrowsPosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckSpaceForPartsX = "checkSpaceForParts";
		static readonly NativeHandle selCheckSpaceForPartsXHandle = Selector.GetHandle ("checkSpaceForParts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlSizeX = "controlSize";
		static readonly NativeHandle selControlSizeXHandle = Selector.GetHandle ("controlSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlTintX = "controlTint";
		static readonly NativeHandle selControlTintXHandle = Selector.GetHandle ("controlTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawArrow_Highlight_X = "drawArrow:highlight:";
		static readonly NativeHandle selDrawArrow_Highlight_XHandle = Selector.GetHandle ("drawArrow:highlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawKnobX = "drawKnob";
		static readonly NativeHandle selDrawKnobXHandle = Selector.GetHandle ("drawKnob");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawKnobSlotInRect_Highlight_X = "drawKnobSlotInRect:highlight:";
		static readonly NativeHandle selDrawKnobSlotInRect_Highlight_XHandle = Selector.GetHandle ("drawKnobSlotInRect:highlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPartsX = "drawParts";
		static readonly NativeHandle selDrawPartsXHandle = Selector.GetHandle ("drawParts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlight_X = "highlight:";
		static readonly NativeHandle selHighlight_XHandle = Selector.GetHandle ("highlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHitPartX = "hitPart";
		static readonly NativeHandle selHitPartXHandle = Selector.GetHandle ("hitPart");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCompatibleWithOverlayScrollersX = "isCompatibleWithOverlayScrollers";
		static readonly NativeHandle selIsCompatibleWithOverlayScrollersXHandle = Selector.GetHandle ("isCompatibleWithOverlayScrollers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKnobProportionX = "knobProportion";
		static readonly NativeHandle selKnobProportionXHandle = Selector.GetHandle ("knobProportion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKnobStyleX = "knobStyle";
		static readonly NativeHandle selKnobStyleXHandle = Selector.GetHandle ("knobStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredScrollerStyleX = "preferredScrollerStyle";
		static readonly NativeHandle selPreferredScrollerStyleXHandle = Selector.GetHandle ("preferredScrollerStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectForPart_X = "rectForPart:";
		static readonly NativeHandle selRectForPart_XHandle = Selector.GetHandle ("rectForPart:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollerStyleX = "scrollerStyle";
		static readonly NativeHandle selScrollerStyleXHandle = Selector.GetHandle ("scrollerStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollerWidthX = "scrollerWidth";
		static readonly NativeHandle selScrollerWidthXHandle = Selector.GetHandle ("scrollerWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollerWidthForControlSize_X = "scrollerWidthForControlSize:";
		static readonly NativeHandle selScrollerWidthForControlSize_XHandle = Selector.GetHandle ("scrollerWidthForControlSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollerWidthForControlSize_ScrollerStyle_X = "scrollerWidthForControlSize:scrollerStyle:";
		static readonly NativeHandle selScrollerWidthForControlSize_ScrollerStyle_XHandle = Selector.GetHandle ("scrollerWidthForControlSize:scrollerStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetArrowsPosition_X = "setArrowsPosition:";
		static readonly NativeHandle selSetArrowsPosition_XHandle = Selector.GetHandle ("setArrowsPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlSize_X = "setControlSize:";
		static readonly NativeHandle selSetControlSize_XHandle = Selector.GetHandle ("setControlSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlTint_X = "setControlTint:";
		static readonly NativeHandle selSetControlTint_XHandle = Selector.GetHandle ("setControlTint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKnobProportion_X = "setKnobProportion:";
		static readonly NativeHandle selSetKnobProportion_XHandle = Selector.GetHandle ("setKnobProportion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetKnobStyle_X = "setKnobStyle:";
		static readonly NativeHandle selSetKnobStyle_XHandle = Selector.GetHandle ("setKnobStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollerStyle_X = "setScrollerStyle:";
		static readonly NativeHandle selSetScrollerStyle_XHandle = Selector.GetHandle ("setScrollerStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTestPart_X = "testPart:";
		static readonly NativeHandle selTestPart_XHandle = Selector.GetHandle ("testPart:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackKnob_X = "trackKnob:";
		static readonly NativeHandle selTrackKnob_XHandle = Selector.GetHandle ("trackKnob:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackScrollButtons_X = "trackScrollButtons:";
		static readonly NativeHandle selTrackScrollButtons_XHandle = Selector.GetHandle ("trackScrollButtons:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsablePartsX = "usableParts";
		static readonly NativeHandle selUsablePartsXHandle = Selector.GetHandle ("usableParts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSScroller");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSScroller" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSScroller () : base (NSObjectFlag.Empty)
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
		public NSScroller (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSScroller (NSObjectFlag t) : base (t)
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
		protected internal NSScroller (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSScroller (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("checkSpaceForParts")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckSpaceForParts ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCheckSpaceForPartsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCheckSpaceForPartsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawArrow:highlight:")]
		[ObsoletedOSPlatform ("macos10.7", "Scrollers don't have arrows anymore.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawArrow (NSScrollerArrow whichArrow, bool highlight)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, selDrawArrow_Highlight_XHandle, (UIntPtr) (ulong) whichArrow, highlight ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selDrawArrow_Highlight_XHandle, (UIntPtr) (ulong) whichArrow, highlight ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawKnob")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawKnob ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrawKnobXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDrawKnobXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawKnobSlotInRect:highlight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawKnobSlot (CGRect slotRect, bool highlight)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, selDrawKnobSlotInRect_Highlight_XHandle, slotRect, highlight ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_bool (&__objc_super__, selDrawKnobSlotInRect_Highlight_XHandle, slotRect, highlight ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawParts")]
		[ObsoletedOSPlatform ("macos10.7", "Not used.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawParts ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrawPartsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDrawPartsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollerWidthForControlSize:scrollerStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetScrollerWidth (NSControlSize forControlSize, NSScrollerStyle scrollerStyle)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr_IntPtr (class_ptr, selScrollerWidthForControlSize_ScrollerStyle_XHandle, (UIntPtr) (ulong) forControlSize, (IntPtr) (long) scrollerStyle);
			return ret;
		}
		[Export ("highlight:")]
		[ObsoletedOSPlatform ("macos10.14", "No effect since 10.7.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Highlight (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selHighlight_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selHighlight_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("rectForPart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectForPart (NSScrollerPart partCode)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr (this.Handle, selRectForPart_XHandle, (UIntPtr) (ulong) partCode);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr (this.Handle, selRectForPart_XHandle, (UIntPtr) (ulong) partCode);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr (&__objc_super__, selRectForPart_XHandle, (UIntPtr) (ulong) partCode);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, selRectForPart_XHandle, (UIntPtr) (ulong) partCode);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("scrollerWidthForControlSize:")]
		[ObsoletedOSPlatform ("macos10.7", "Use GetScrollerWidth instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat ScrollerWidthForControlSize (NSControlSize controlSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (class_ptr, selScrollerWidthForControlSize_XHandle, (UIntPtr) (ulong) controlSize);
			return ret;
		}
		[Export ("testPart:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSScrollerPart TestPart (CGPoint thePoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSScrollerPart ret;
			if (IsDirectBinding) {
				ret = (NSScrollerPart) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, selTestPart_XHandle, thePoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSScrollerPart) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selTestPart_XHandle, thePoint);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("trackKnob:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TrackKnob (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTrackKnob_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTrackKnob_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("trackScrollButtons:")]
		[ObsoletedOSPlatform ("macos10.14", "No effect since 10.7.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TrackScrollButtons (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTrackScrollButtons_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTrackScrollButtons_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "No effect since 10.7.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSScrollArrowPosition ArrowsPosition {
			[Export ("arrowsPosition")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSScrollArrowPosition ret;
				if (IsDirectBinding) {
					ret = (NSScrollArrowPosition) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selArrowsPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSScrollArrowPosition) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selArrowsPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setArrowsPosition:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetArrowsPosition_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetArrowsPosition_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CompatibleWithOverlayScrollers {
			[Export ("isCompatibleWithOverlayScrollers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsCompatibleWithOverlayScrollersXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSControlSize ControlSize {
			[Export ("controlSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSControlSize ret;
				if (IsDirectBinding) {
					ret = (NSControlSize) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSControlSize) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlSize_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlSize_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "No effect since 10.7.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSControlTint ControlTint {
			[Export ("controlTint")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSControlTint ret;
				if (IsDirectBinding) {
					ret = (NSControlTint) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlTintXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSControlTint) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlTintXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlTint:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlTint_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlTint_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSScrollerPart HitPart {
			[Export ("hitPart")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSScrollerPart ret;
				if (IsDirectBinding) {
					ret = (NSScrollerPart) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selHitPartXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSScrollerPart) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selHitPartXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat KnobProportion {
			[Export ("knobProportion")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selKnobProportionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selKnobProportionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKnobProportion:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetKnobProportion_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetKnobProportion_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSScrollerKnobStyle KnobStyle {
			[Export ("knobStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSScrollerKnobStyle ret;
				if (IsDirectBinding) {
					ret = (NSScrollerKnobStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKnobStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSScrollerKnobStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selKnobStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKnobStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKnobStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetKnobStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSScrollerStyle PreferredScrollerStyle {
			[Export ("preferredScrollerStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSScrollerStyle ret;
				ret = (NSScrollerStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPreferredScrollerStyleXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSScrollerStyle ScrollerStyle {
			[Export ("scrollerStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSScrollerStyle ret;
				if (IsDirectBinding) {
					ret = (NSScrollerStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScrollerStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSScrollerStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selScrollerStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setScrollerStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScrollerStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetScrollerStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.7", "Use GetScrollerWidth instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static nfloat ScrollerWidth {
			[Export ("scrollerWidth")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selScrollerWidthXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUsableScrollerParts UsableParts {
			[Export ("usableParts")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUsableScrollerParts ret;
				if (IsDirectBinding) {
					ret = (NSUsableScrollerParts) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUsablePartsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUsableScrollerParts) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUsablePartsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredStyleChangedNotification;
		/// <summary>Notification constant for PreferredStyleChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObservePreferredStyleChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObservePreferredStyleChanged(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSScroller.Notifications.ObservePreferredStyleChanged ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSScroller.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSScroller.Notifications.ObservePreferredStyleChanged (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSScroller.PreferredStyleChangedNotification, (notification) => { Console.WriteLine ("Received the notification PreferredStyleChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification PreferredStyleChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSScroller.PreferredStyleChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSPreferredScrollerStyleDidChangeNotification",  "AppKit")]
		[Advice ("Use NSScroller.Notifications.ObservePreferredStyleChanged helper method instead.")]
		public static NSString PreferredStyleChangedNotification {
			get {
				if (_PreferredStyleChangedNotification is null)
					_PreferredStyleChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPreferredScrollerStyleDidChangeNotification")!;
				return _PreferredStyleChangedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSScroller" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSScroller.PreferredStyleChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSScroller.PreferredStyleChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSScroller.Notifications.ObservePreferredStyleChanged ((notification) => {
			///   Console.WriteLine ("Observed PreferredStyleChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePreferredStyleChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PreferredStyleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSScroller.PreferredStyleChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSScroller.PreferredStyleChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSScroller.Notifications.ObservePreferredStyleChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed PreferredStyleChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObservePreferredStyleChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (PreferredStyleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSScroller */
}
