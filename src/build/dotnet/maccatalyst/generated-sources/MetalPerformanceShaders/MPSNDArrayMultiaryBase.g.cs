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
namespace MetalPerformanceShaders {
	[Register("MPSNDArrayMultiaryBase", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class MPSNDArrayMultiaryBase : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNDArrayMultiaryBase");
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
		public MPSNDArrayMultiaryBase (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSNDArrayMultiaryBase (NSObjectFlag t) : base (t)
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
		protected internal MPSNDArrayMultiaryBase (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:sourceCount:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNDArrayMultiaryBase (global::Metal.IMTLDevice device, nuint count)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("initWithDevice:sourceCount:"), device__handle__, count), "initWithDevice:sourceCount:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("initWithDevice:sourceCount:"), device__handle__, count), "initWithDevice:sourceCount:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNDArrayMultiaryBase (NSCoder aDecoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:device:"), aDecoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:device:"), aDecoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDecoder);
			GC.KeepAlive (device);
		}
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSMatrixNeuron Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			MPSMatrixNeuron? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSMatrixNeuron> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSMatrixNeuron> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder coder)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		[Export ("destinationArrayDescriptorForSourceArrays:sourceState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArrayDescriptor GetDestinationArray (MPSNDArray[] sources, MPSState? state)
		{
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			var state__handle__ = state.GetHandle ();
			using var nsa_sources = NSArray.FromNSObjects (sources);
			MPSNDArrayDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNDArrayDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("destinationArrayDescriptorForSourceArrays:sourceState:"), nsa_sources.Handle, state__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNDArrayDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("destinationArrayDescriptorForSourceArrays:sourceState:"), nsa_sources.Handle, state__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (state);
			return ret!;
		}
		[Export ("dilationRatesForSourceIndex:")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArraySizes GetDilationRates (nuint sourceIndex)
		{
			MPSNDArraySizes ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("dilationRatesForSourceIndex:"), sourceIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret_UIntPtr (this.Handle, Selector.GetHandle ("dilationRatesForSourceIndex:"), sourceIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("dilationRatesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, Selector.GetHandle ("dilationRatesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("edgeModeAtSourceIndex:")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode GetEdgeMode (nuint sourceIndex)
		{
			MPSImageEdgeMode ret;
			if (IsDirectBinding) {
				ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("edgeModeAtSourceIndex:"), sourceIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (MetalPerformanceShaders.MPSImageEdgeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("edgeModeAtSourceIndex:"), sourceIndex);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("kernelSizesForSourceIndex:")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArraySizes GetKernelSizes (nuint sourceIndex)
		{
			MPSNDArraySizes ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("kernelSizesForSourceIndex:"), sourceIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSend_stret_UIntPtr (this.Handle, Selector.GetHandle ("kernelSizesForSourceIndex:"), sourceIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("kernelSizesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArraySizes_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, Selector.GetHandle ("kernelSizesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("offsetsAtSourceIndex:")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArrayOffsets GetOffsets (nuint sourceIndex)
		{
			MPSNDArrayOffsets ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("offsetsAtSourceIndex:"), sourceIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret_UIntPtr (this.Handle, Selector.GetHandle ("offsetsAtSourceIndex:"), sourceIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("offsetsAtSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, Selector.GetHandle ("offsetsAtSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("resultStateForSourceArrays:sourceStates:destinationArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetResultState (MPSNDArray[] sourceArrays, MPSState[]? sourceStates, MPSNDArray destinationArray)
		{
			if (sourceArrays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceArrays));
			var destinationArray__handle__ = destinationArray!.GetNonNullHandle (nameof (destinationArray));
			using var nsa_sourceArrays = NSArray.FromNSObjects (sourceArrays);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resultStateForSourceArrays:sourceStates:destinationArray:"), nsa_sourceArrays.Handle, nsa_sourceStates.GetHandle (), destinationArray__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("resultStateForSourceArrays:sourceStates:destinationArray:"), nsa_sourceArrays.Handle, nsa_sourceStates.GetHandle (), destinationArray__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (destinationArray);
			return ret!;
		}
		[Export ("stridesForSourceIndex:")]
		[ObsoletedOSPlatform ("ios14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use derived filter properties instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use derived filter properties instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArrayOffsets GetStrides (nuint sourceIndex)
		{
			MPSNDArrayOffsets ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("stridesForSourceIndex:"), sourceIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSend_stret_UIntPtr (this.Handle, Selector.GetHandle ("stridesForSourceIndex:"), sourceIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("stridesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSNDArrayOffsets_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, Selector.GetHandle ("stridesForSourceIndex:"), sourceIndex);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNDArrayAllocator DestinationArrayAllocator {
			[Export ("destinationArrayAllocator", ArgumentSemantic.Retain)]
			get {
				IMPSNDArrayAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSNDArrayAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("destinationArrayAllocator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSNDArrayAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("destinationArrayAllocator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDestinationArrayAllocator:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDestinationArrayAllocator:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDestinationArrayAllocator:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class MPSNDArrayMultiaryBase */
}
