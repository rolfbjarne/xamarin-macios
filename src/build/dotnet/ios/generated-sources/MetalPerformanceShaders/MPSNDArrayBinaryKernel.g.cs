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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShaders {
	[Register("MPSNDArrayBinaryKernel", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSNDArrayBinaryKernel : MPSNDArrayMultiaryKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNDArrayBinaryKernel");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public MPSNDArrayBinaryKernel (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected MPSNDArrayBinaryKernel (NSObjectFlag t) : base (t)
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
		protected internal MPSNDArrayBinaryKernel (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNDArrayBinaryKernel (global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDevice:"), device__handle__), "initWithDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDevice:"), device__handle__), "initWithDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNDArrayBinaryKernel (NSCoder coder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:device:"), coder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:device:"), coder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
			GC.KeepAlive (device);
		}
		[Export ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArray Encode (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArray primarySourceArray, MPSNDArray secondarySourceArray)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var primarySourceArray__handle__ = primarySourceArray!.GetNonNullHandle (nameof (primarySourceArray));
			var secondarySourceArray__handle__ = secondarySourceArray!.GetNonNullHandle (nameof (secondarySourceArray));
			MPSNDArray? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (primarySourceArray);
			GC.KeepAlive (secondarySourceArray);
			return ret!;
		}
		[Export ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:destinationArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArray primarySourceArray, MPSNDArray secondarySourceArray, MPSNDArray destination)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var primarySourceArray__handle__ = primarySourceArray!.GetNonNullHandle (nameof (primarySourceArray));
			var secondarySourceArray__handle__ = secondarySourceArray!.GetNonNullHandle (nameof (secondarySourceArray));
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:destinationArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, destination__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:destinationArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, destination__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (primarySourceArray);
			GC.KeepAlive (secondarySourceArray);
			GC.KeepAlive (destination);
		}
		[Export ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:outputStateIsTemporary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSNDArray Encode (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArray primarySourceArray, MPSNDArray secondarySourceArray, out MPSState? outGradientState, bool outputStateIsTemporary)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var primarySourceArray__handle__ = primarySourceArray!.GetNonNullHandle (nameof (primarySourceArray));
			var secondarySourceArray__handle__ = secondarySourceArray!.GetNonNullHandle (nameof (secondarySourceArray));
			NativeHandle outGradientStateValue = IntPtr.Zero;
			MPSNDArray? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:outputStateIsTemporary:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, &outGradientStateValue, outputStateIsTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:outputStateIsTemporary:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, &outGradientStateValue, outputStateIsTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (primarySourceArray);
			GC.KeepAlive (secondarySourceArray);
			outGradientState = Runtime.GetNSObject<MetalPerformanceShaders.MPSState> (outGradientStateValue)!;
			return ret!;
		}
		[Export ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:destinationArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArray primarySourceArray, MPSNDArray secondarySourceArray, MPSState? outGradientState, MPSNDArray destination)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var primarySourceArray__handle__ = primarySourceArray!.GetNonNullHandle (nameof (primarySourceArray));
			var secondarySourceArray__handle__ = secondarySourceArray!.GetNonNullHandle (nameof (secondarySourceArray));
			var outGradientState__handle__ = outGradientState.GetHandle ();
			var destination__handle__ = destination!.GetNonNullHandle (nameof (destination));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:destinationArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, outGradientState__handle__, destination__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primarySourceArray:secondarySourceArray:resultState:destinationArray:"), cmdBuf__handle__, primarySourceArray__handle__, secondarySourceArray__handle__, outGradientState__handle__, destination__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (primarySourceArray);
			GC.KeepAlive (secondarySourceArray);
			GC.KeepAlive (outGradientState);
			GC.KeepAlive (destination);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArraySizes PrimaryDilationRates {
			[Export ("primaryDilationRates")]
			get {
				MPSNDArraySizes ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend (this.Handle, Selector.GetHandle ("primaryDilationRates"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret (this.Handle, Selector.GetHandle ("primaryDilationRates"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryDilationRates"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("primaryDilationRates"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSImageEdgeMode PrimaryEdgeMode {
			[Export ("primaryEdgeMode")]
			get {
				MPSImageEdgeMode ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryEdgeMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryEdgeMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArraySizes PrimaryKernelSizes {
			[Export ("primaryKernelSizes")]
			get {
				MPSNDArraySizes ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend (this.Handle, Selector.GetHandle ("primaryKernelSizes"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret (this.Handle, Selector.GetHandle ("primaryKernelSizes"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryKernelSizes"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("primaryKernelSizes"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArrayOffsets PrimaryOffsets {
			[Export ("primaryOffsets")]
			get {
				MPSNDArrayOffsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend (this.Handle, Selector.GetHandle ("primaryOffsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("primaryOffsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryOffsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("primaryOffsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArrayOffsets PrimaryStrides {
			[Export ("primaryStrides")]
			get {
				MPSNDArrayOffsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend (this.Handle, Selector.GetHandle ("primaryStrides"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("primaryStrides"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryStrides"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("primaryStrides"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArraySizes SecondaryDilationRates {
			[Export ("secondaryDilationRates")]
			get {
				MPSNDArraySizes ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryDilationRates"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret (this.Handle, Selector.GetHandle ("secondaryDilationRates"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryDilationRates"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("secondaryDilationRates"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSImageEdgeMode SecondaryEdgeMode {
			[Export ("secondaryEdgeMode")]
			get {
				MPSImageEdgeMode ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryEdgeMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryEdgeMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArraySizes SecondaryKernelSizes {
			[Export ("secondaryKernelSizes")]
			get {
				MPSNDArraySizes ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryKernelSizes"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret (this.Handle, Selector.GetHandle ("secondaryKernelSizes"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryKernelSizes"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("secondaryKernelSizes"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArrayOffsets SecondaryOffsets {
			[Export ("secondaryOffsets")]
			get {
				MPSNDArrayOffsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryOffsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("secondaryOffsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryOffsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("secondaryOffsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual MPSNDArrayOffsets SecondaryStrides {
			[Export ("secondaryStrides")]
			get {
				MPSNDArrayOffsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryStrides"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("secondaryStrides"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryStrides"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("secondaryStrides"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
	} /* class MPSNDArrayBinaryKernel */
}
