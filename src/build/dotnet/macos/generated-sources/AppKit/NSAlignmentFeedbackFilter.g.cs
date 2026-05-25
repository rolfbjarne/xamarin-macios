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
	[Register("NSAlignmentFeedbackFilter", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSAlignmentFeedbackFilter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_X = "alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:";
		static readonly NativeHandle selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_XHandle = Selector.GetHandle ("alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_X = "alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:";
		static readonly NativeHandle selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_XHandle = Selector.GetHandle ("alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_X = "alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:";
		static readonly NativeHandle selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_XHandle = Selector.GetHandle ("alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputEventMaskX = "inputEventMask";
		static readonly NativeHandle selInputEventMaskXHandle = Selector.GetHandle ("inputEventMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformFeedback_PerformanceTime_X = "performFeedback:performanceTime:";
		static readonly NativeHandle selPerformFeedback_PerformanceTime_XHandle = Selector.GetHandle ("performFeedback:performanceTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateWithEvent_X = "updateWithEvent:";
		static readonly NativeHandle selUpdateWithEvent_XHandle = Selector.GetHandle ("updateWithEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateWithPanRecognizer_X = "updateWithPanRecognizer:";
		static readonly NativeHandle selUpdateWithPanRecognizer_XHandle = Selector.GetHandle ("updateWithPanRecognizer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAlignmentFeedbackFilter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSAlignmentFeedbackFilter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSAlignmentFeedbackFilter () : base (NSObjectFlag.Empty)
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
		protected NSAlignmentFeedbackFilter (NSObjectFlag t) : base (t)
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
		protected internal NSAlignmentFeedbackFilter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("alignmentFeedbackTokenForHorizontalMovementInView:previousX:alignedX:defaultX:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSAlignmentFeedbackToken? GetTokenForHorizontalMovement (NSView? view, nfloat previousX, nfloat alignedX, nfloat defaultX)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			INSAlignmentFeedbackToken? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_nfloat_nfloat (this.Handle, selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_XHandle, view__handle__, previousX, alignedX, defaultX), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat_nfloat_nfloat (&__objc_super__, selAlignmentFeedbackTokenForHorizontalMovementInView_PreviousX_AlignedX_DefaultX_XHandle, view__handle__, previousX, alignedX, defaultX), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("alignmentFeedbackTokenForMovementInView:previousPoint:alignedPoint:defaultPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSAlignmentFeedbackToken? GetTokenForMovement (NSView? view, CGPoint previousPoint, CGPoint alignedPoint, CGPoint defaultPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			INSAlignmentFeedbackToken? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint_CGPoint_CGPoint (this.Handle, selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_XHandle, view__handle__, previousPoint, alignedPoint, defaultPoint), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint_CGPoint_CGPoint (&__objc_super__, selAlignmentFeedbackTokenForMovementInView_PreviousPoint_AlignedPoint_DefaultPoint_XHandle, view__handle__, previousPoint, alignedPoint, defaultPoint), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("alignmentFeedbackTokenForVerticalMovementInView:previousY:alignedY:defaultY:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSAlignmentFeedbackToken? GetTokenForVerticalMovement (NSView? view, nfloat previousY, nfloat alignedY, nfloat defaultY)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			INSAlignmentFeedbackToken? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_nfloat_nfloat (this.Handle, selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_XHandle, view__handle__, previousY, alignedY, defaultY), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<INSAlignmentFeedbackToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat_nfloat_nfloat (&__objc_super__, selAlignmentFeedbackTokenForVerticalMovementInView_PreviousY_AlignedY_DefaultY_XHandle, view__handle__, previousY, alignedY, defaultY), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("performFeedback:performanceTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformFeedback (INSAlignmentFeedbackToken[] tokens, NSHapticFeedbackPerformanceTime performanceTime)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (tokens is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tokens));
			using var nsa_tokens = NSArray.FromNSObjects (tokens);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selPerformFeedback_PerformanceTime_XHandle, nsa_tokens.Handle, (UIntPtr) (ulong) performanceTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selPerformFeedback_PerformanceTime_XHandle, nsa_tokens.Handle, (UIntPtr) (ulong) performanceTime);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateWithEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateWithEvent_XHandle, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateWithEvent_XHandle, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
		}
		[Export ("updateWithPanRecognizer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (NSPanGestureRecognizer panRecognizer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panRecognizer__handle__ = panRecognizer!.GetNonNullHandle (nameof (panRecognizer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateWithPanRecognizer_XHandle, panRecognizer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateWithPanRecognizer_XHandle, panRecognizer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (panRecognizer);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEventMask InputEventMask {
			[Export ("inputEventMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventMask ret;
				ret = (NSEventMask) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (class_ptr, selInputEventMaskXHandle);
				return ret;
			}
		}
	} /* class NSAlignmentFeedbackFilter */
}
