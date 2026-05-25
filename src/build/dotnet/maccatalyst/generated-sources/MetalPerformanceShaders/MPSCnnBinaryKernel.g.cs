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
	/// <summary>A <see cref="T:MetalPerformanceShaders.MPSKernel" /> that has binary weights.</summary>
	[Register("MPSCNNBinaryKernel", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSCnnBinaryKernel : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSCNNBinaryKernel");
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
		public MPSCnnBinaryKernel (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSCnnBinaryKernel (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnBinaryKernel (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBinaryKernel (global::Metal.IMTLDevice device)
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
		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBinaryKernel (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		/// <param name="commandBuffer">To be added.</param><param name="primaryImages">To be added.</param><param name="secondaryImages">To be added.</param><param name="destinationImages">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, NSArray<MPSImage> destinationImages)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImages__handle__ = primaryImages!.GetNonNullHandle (nameof (primaryImages));
			var secondaryImages__handle__ = secondaryImages!.GetNonNullHandle (nameof (secondaryImages));
			var destinationImages__handle__ = destinationImages!.GetNonNullHandle (nameof (destinationImages));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:"), commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, destinationImages__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationImages:"), commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, destinationImages__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImages);
			GC.KeepAlive (secondaryImages);
			GC.KeepAlive (destinationImages);
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImages">To be added.</param><param name="secondaryImages">To be added.</param><param name="outState">To be added.</param><param name="isTemporary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSArray<MPSImage> EncodeBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImages, NSArray<MPSImage> secondaryImages, out MPSState[]? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImages__handle__ = primaryImages!.GetNonNullHandle (nameof (primaryImages));
			var secondaryImages__handle__ = secondaryImages!.GetNonNullHandle (nameof (secondaryImages));
			NativeHandle outStateValue = IntPtr.Zero;
			NSArray<MPSImage>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:"), commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("encodeBatchToCommandBuffer:primaryImages:secondaryImages:destinationStates:destinationStateIsTemporary:"), commandBuffer__handle__, primaryImages__handle__, secondaryImages__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImages);
			GC.KeepAlive (secondaryImages);
			outState = CFArray.ArrayFromHandle<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="outState">To be added.</param><param name="isTemporary">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSImage EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, out MPSState? outState, bool isTemporary)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			NativeHandle outStateValue = IntPtr.Zero;
			MPSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationState:destinationStateIsTemporary:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, &outStateValue, isTemporary ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			outState = Runtime.GetNSObject<MetalPerformanceShaders.MPSState> (outStateValue)!;
			return ret!;
		}
		[Export ("batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetBatchEncodingStorageSize (MPSImage[] primaryImage, MPSImage[] secondaryImage, NSArray<MPSState>[]? sourceStates, MPSImage[]? destinationImage)
		{
			if (primaryImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (primaryImage));
			if (secondaryImage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (secondaryImage));
			using var nsa_primaryImage = NSArray.FromNSObjects (primaryImage);
			using var nsa_secondaryImage = NSArray.FromNSObjects (secondaryImage);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			using var nsa_destinationImage = destinationImage is null ? null : NSArray.FromNSObjects (destinationImage);
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), nsa_primaryImage.Handle, nsa_secondaryImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("batchEncodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), nsa_primaryImage.Handle, nsa_secondaryImage.Handle, nsa_sourceStates.GetHandle (), nsa_destinationImage.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationImageDescriptorForSourceImages:sourceStates:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageDescriptor GetDestinationImageDescriptor (NSArray<MPSImage> sourceImages, NSArray<MPSState>? sourceStates)
		{
			var sourceImages__handle__ = sourceImages!.GetNonNullHandle (nameof (sourceImages));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			MPSImageDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:"), sourceImages__handle__, sourceStates__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:"), sourceImages__handle__, sourceStates__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImages);
			GC.KeepAlive (sourceStates);
			return ret!;
		}
		[Export ("encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetEncodingStorageSize (MPSImage primaryImage, MPSImage secondaryImage, MPSState[]? sourceStates, MPSImage? destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage.GetHandle ();
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodingStorageSizeForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetResultState (MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("resultStateForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSState>? GetResultStateBatch (NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSState>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("resultStateBatchForPrimaryImage:secondaryImage:sourceStates:destinationImage:"), primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSState? GetTemporaryResultState (global::Metal.IMTLCommandBuffer commandBuffer, MPSImage primaryImage, MPSImage secondaryImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			MPSState? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("temporaryResultStateForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, sourceStates__handle__, destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="sourceStates">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSState>? GetTemporaryResultStateBatch (global::Metal.IMTLCommandBuffer commandBuffer, NSArray<MPSImage> primaryImage, NSArray<MPSImage> secondaryImage, NSArray<MPSState>[]? sourceStates, NSArray<MPSImage> destinationImage)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryImage__handle__ = primaryImage!.GetNonNullHandle (nameof (primaryImage));
			var secondaryImage__handle__ = secondaryImage!.GetNonNullHandle (nameof (secondaryImage));
			var destinationImage__handle__ = destinationImage!.GetNonNullHandle (nameof (destinationImage));
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			NSArray<MPSState>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray<MPSState>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("temporaryResultStateBatchForCommandBuffer:primaryImage:secondaryImage:sourceStates:destinationImage:"), commandBuffer__handle__, primaryImage__handle__, secondaryImage__handle__, nsa_sourceStates.GetHandle (), destinationImage__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryImage);
			GC.KeepAlive (secondaryImage);
			GC.KeepAlive (destinationImage);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AppendBatchBarrier {
			[Export ("appendBatchBarrier")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("appendBatchBarrier"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("appendBatchBarrier"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.MTLRegion ClipRect {
			[Export ("clipRect", ArgumentSemantic.Assign)]
			get {
				global::Metal.MTLRegion ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSend (this.Handle, Selector.GetHandle ("clipRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSend_stret (this.Handle, Selector.GetHandle ("clipRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clipRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLRegion_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("clipRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setClipRect:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLRegion (this.Handle, Selector.GetHandle ("setClipRect:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLRegion (&__objc_super__, Selector.GetHandle ("setClipRect:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint DestinationFeatureChannelOffset {
			[Export ("destinationFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("destinationFeatureChannelOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("destinationFeatureChannelOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDestinationFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDestinationFeatureChannelOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setDestinationFeatureChannelOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSImageAllocator DestinationImageAllocator {
			[Export ("destinationImageAllocator", ArgumentSemantic.Retain)]
			get {
				IMPSImageAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("destinationImageAllocator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSImageAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("destinationImageAllocator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDestinationImageAllocator:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDestinationImageAllocator:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDestinationImageAllocator:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBackwards {
			[Export ("isBackwards")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBackwards"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isBackwards"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool IsResultStateReusedAcrossBatch {
			[Export ("isResultStateReusedAcrossBatch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isResultStateReusedAcrossBatch"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isResultStateReusedAcrossBatch"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool IsStateModified {
			[Export ("isStateModified")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isStateModified"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isStateModified"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNNPadding Padding {
			[Export ("padding", ArgumentSemantic.Retain)]
			get {
				IMPSNNPadding? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("padding")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("padding")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPadding:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPadding:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPadding:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryDilationRateX {
			[Export ("primaryDilationRateX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryDilationRateX"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryDilationRateX"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryDilationRateY {
			[Export ("primaryDilationRateY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryDilationRateY"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryDilationRateY"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode PrimaryEdgeMode {
			[Export ("primaryEdgeMode", ArgumentSemantic.Assign)]
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
			[Export ("setPrimaryEdgeMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPrimaryEdgeMode:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setPrimaryEdgeMode:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryKernelHeight {
			[Export ("primaryKernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryKernelHeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryKernelHeight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryKernelWidth {
			[Export ("primaryKernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryKernelWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryKernelWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSOffset PrimaryOffset {
			[Export ("primaryOffset", ArgumentSemantic.Assign)]
			get {
				MPSOffset ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend (this.Handle, Selector.GetHandle ("primaryOffset"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_stret (this.Handle, Selector.GetHandle ("primaryOffset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryOffset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("primaryOffset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setPrimaryOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MPSOffset (this.Handle, Selector.GetHandle ("setPrimaryOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MPSOffset (&__objc_super__, Selector.GetHandle ("setPrimaryOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimarySourceFeatureChannelMaxCount {
			[Export ("primarySourceFeatureChannelMaxCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primarySourceFeatureChannelMaxCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primarySourceFeatureChannelMaxCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimarySourceFeatureChannelMaxCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPrimarySourceFeatureChannelMaxCount:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setPrimarySourceFeatureChannelMaxCount:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimarySourceFeatureChannelOffset {
			[Export ("primarySourceFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primarySourceFeatureChannelOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primarySourceFeatureChannelOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimarySourceFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPrimarySourceFeatureChannelOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setPrimarySourceFeatureChannelOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryStrideInPixelsX {
			[Export ("primaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryStrideInPixelsX"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryStrideInPixelsX"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPrimaryStrideInPixelsX:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setPrimaryStrideInPixelsX:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint PrimaryStrideInPixelsY {
			[Export ("primaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("primaryStrideInPixelsY"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryStrideInPixelsY"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrimaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPrimaryStrideInPixelsY:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setPrimaryStrideInPixelsY:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryDilationRateX {
			[Export ("secondaryDilationRateX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryDilationRateX"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryDilationRateX"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryDilationRateY {
			[Export ("secondaryDilationRateY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryDilationRateY"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryDilationRateY"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageEdgeMode SecondaryEdgeMode {
			[Export ("secondaryEdgeMode", ArgumentSemantic.Assign)]
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
			[Export ("setSecondaryEdgeMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setSecondaryEdgeMode:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setSecondaryEdgeMode:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryKernelHeight {
			[Export ("secondaryKernelHeight")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryKernelHeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryKernelHeight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryKernelWidth {
			[Export ("secondaryKernelWidth")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryKernelWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryKernelWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSOffset SecondaryOffset {
			[Export ("secondaryOffset", ArgumentSemantic.Assign)]
			get {
				MPSOffset ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryOffset"));
					} else {
						ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSend_stret (this.Handle, Selector.GetHandle ("secondaryOffset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryOffset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MPSOffset_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("secondaryOffset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSecondaryOffset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MPSOffset (this.Handle, Selector.GetHandle ("setSecondaryOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MPSOffset (&__objc_super__, Selector.GetHandle ("setSecondaryOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondarySourceFeatureChannelMaxCount {
			[Export ("secondarySourceFeatureChannelMaxCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondarySourceFeatureChannelMaxCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondarySourceFeatureChannelMaxCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondarySourceFeatureChannelMaxCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setSecondarySourceFeatureChannelMaxCount:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setSecondarySourceFeatureChannelMaxCount:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondarySourceFeatureChannelOffset {
			[Export ("secondarySourceFeatureChannelOffset")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondarySourceFeatureChannelOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondarySourceFeatureChannelOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondarySourceFeatureChannelOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setSecondarySourceFeatureChannelOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setSecondarySourceFeatureChannelOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryStrideInPixelsX {
			[Export ("secondaryStrideInPixelsX")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryStrideInPixelsX"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryStrideInPixelsX"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsX:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setSecondaryStrideInPixelsX:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setSecondaryStrideInPixelsX:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint SecondaryStrideInPixelsY {
			[Export ("secondaryStrideInPixelsY")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondaryStrideInPixelsY"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondaryStrideInPixelsY"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSecondaryStrideInPixelsY:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setSecondaryStrideInPixelsY:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setSecondaryStrideInPixelsY:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSCnnBinaryKernel */
}
