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
namespace VideoToolbox {
	[Register("VTTemporalNoiseFilterParameters", true)]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe partial class VTTemporalNoiseFilterParameters : NSObject, IVTFrameProcessorParameters {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationFrameX = "destinationFrame";
		static readonly NativeHandle selDestinationFrameXHandle = Selector.GetHandle ("destinationFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationFramesX = "destinationFrames";
		static readonly NativeHandle selDestinationFramesXHandle = Selector.GetHandle ("destinationFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterStrengthX = "filterStrength";
		static readonly NativeHandle selFilterStrengthXHandle = Selector.GetHandle ("filterStrength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasDiscontinuityX = "hasDiscontinuity";
		static readonly NativeHandle selHasDiscontinuityXHandle = Selector.GetHandle ("hasDiscontinuity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSourceFrame_NextFrames_PreviousFrames_DestinationFrame_FilterStrength_HasDiscontinuity_X = "initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:";
		static readonly NativeHandle selInitWithSourceFrame_NextFrames_PreviousFrames_DestinationFrame_FilterStrength_HasDiscontinuity_XHandle = Selector.GetHandle ("initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextFramesX = "nextFrames";
		static readonly NativeHandle selNextFramesXHandle = Selector.GetHandle ("nextFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousFramesX = "previousFrames";
		static readonly NativeHandle selPreviousFramesXHandle = Selector.GetHandle ("previousFrames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFilterStrength_X = "setFilterStrength:";
		static readonly NativeHandle selSetFilterStrength_XHandle = Selector.GetHandle ("setFilterStrength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasDiscontinuity_X = "setHasDiscontinuity:";
		static readonly NativeHandle selSetHasDiscontinuity_XHandle = Selector.GetHandle ("setHasDiscontinuity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFrameX = "sourceFrame";
		static readonly NativeHandle selSourceFrameXHandle = Selector.GetHandle ("sourceFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VTTemporalNoiseFilterParameters");
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
		protected VTTemporalNoiseFilterParameters (NSObjectFlag t) : base (t)
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
		protected internal VTTemporalNoiseFilterParameters (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VTTemporalNoiseFilterParameters (VTFrameProcessorFrame sourceFrame, VTFrameProcessorFrame[] nextFrames, VTFrameProcessorFrame[] previousFrames, VTFrameProcessorFrame destinationFrame, float filterStrength, byte hasDiscontinuity)
			: base (NSObjectFlag.Empty)
		{
			var sourceFrame__handle__ = sourceFrame!.GetNonNullHandle (nameof (sourceFrame));
			if (nextFrames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nextFrames));
			if (previousFrames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previousFrames));
			var destinationFrame__handle__ = destinationFrame!.GetNonNullHandle (nameof (destinationFrame));
			using var nsa_nextFrames = NSArray.FromNSObjects (nextFrames);
			using var nsa_previousFrames = NSArray.FromNSObjects (previousFrames);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_byte (this.Handle, selInitWithSourceFrame_NextFrames_PreviousFrames_DestinationFrame_FilterStrength_HasDiscontinuity_XHandle, sourceFrame__handle__, nsa_nextFrames.Handle, nsa_previousFrames.Handle, destinationFrame__handle__, filterStrength, hasDiscontinuity), "initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_float_byte (&__objc_super__, selInitWithSourceFrame_NextFrames_PreviousFrames_DestinationFrame_FilterStrength_HasDiscontinuity_XHandle, sourceFrame__handle__, nsa_nextFrames.Handle, nsa_previousFrames.Handle, destinationFrame__handle__, filterStrength, hasDiscontinuity), "initWithSourceFrame:nextFrames:previousFrames:destinationFrame:filterStrength:hasDiscontinuity:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceFrame);
			GC.KeepAlive (destinationFrame);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual VTFrameProcessorFrame DestinationFrame {
			[Export ("destinationFrame")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				VTFrameProcessorFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationFrameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationFrameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual VTFrameProcessorFrame[] DestinationFrames {
			[Export ("destinationFrames")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				VTFrameProcessorFrame[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationFramesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationFramesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FilterStrength {
			[Export ("filterStrength")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFilterStrengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFilterStrengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFilterStrength:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFilterStrength_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFilterStrength_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDiscontinuity {
			[Export ("hasDiscontinuity")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDiscontinuityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasDiscontinuityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasDiscontinuity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasDiscontinuity_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasDiscontinuity_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VTFrameProcessorFrame[] NextFrames {
			[Export ("nextFrames")]
			get {
				VTFrameProcessorFrame[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextFramesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextFramesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VTFrameProcessorFrame[] PreviousFrames {
			[Export ("previousFrames")]
			get {
				VTFrameProcessorFrame[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviousFramesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviousFramesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual VTFrameProcessorFrame SourceFrame {
			[Export ("sourceFrame")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				VTFrameProcessorFrame? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceFrameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceFrameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class VTTemporalNoiseFilterParameters */
}
