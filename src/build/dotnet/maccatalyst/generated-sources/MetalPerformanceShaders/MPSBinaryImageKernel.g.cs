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
	/// <summary>A image kernel that combines two textures into one texture result.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MetalPerformanceShaders/Reference/MPSBinaryImageKernel_ClassReference/index.html">Apple documentation for <c>MPSBinaryImageKernel</c></related>
	[Register("MPSBinaryImageKernel", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSBinaryImageKernel : MPSKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSBinaryImageKernel");
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
		public MPSBinaryImageKernel (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPSBinaryImageKernel (NSObjectFlag t) : base (t)
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
		protected internal MPSBinaryImageKernel (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="aDecoder">The unarchiver object.</param><param name="device">To be added.</param><summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary><remarks><para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization).   This is part of the <see cref="T:Foundation.NSCoding" />  protocol.</para><para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="T:Foundation.NSCoder" /> and decorate it with the [Export("initWithCoder:"] attribute declaration.</para><para>The state of this object can also be serialized by using the companion method, EncodeTo.</para></remarks>
		[Export ("initWithCoder:device:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSBinaryImageKernel (NSCoder aDecoder, global::Metal.IMTLDevice device)
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
		/// <param name="device">To be added.</param><summary>Creates a new MPSBinaryImageKernel for the specified metal device.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSBinaryImageKernel (global::Metal.IMTLDevice device)
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
		/// <param name="commandBuffer">To be added.</param><param name="primaryTexture">To be added.</param><param name="inPlaceSecondaryTexture">To be added.</param><param name="copyAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Attempts to apply the kernel to <paramref name="inPlaceSecondaryTexture" />, using <paramref name="copyAllocator" /> to allocate and write to a new texture if in-place application fails.</summary><returns><see langword="true" /> if in-place application succeeds. Otherwise, returns <see langword="false" />.</returns><remarks>If <see langword="false" /> is returned and a non-null copy allocator was supplied, <paramref name="inPlaceSecondaryTexture" /> will point to the newly allocated texture.</remarks>
		[Export ("encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture primaryTexture, out NSObject inPlaceSecondaryTexture, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSCopyAllocator))]MPSCopyAllocator? copyAllocator)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryTexture__handle__ = primaryTexture!.GetNonNullHandle (nameof (primaryTexture));
			NativeHandle inPlaceSecondaryTextureValue = IntPtr.Zero;
			using var block_copyAllocator = Trampolines.SDMPSCopyAllocator.CreateNullableBlock (copyAllocator);
			BlockLiteral *block_ptr_copyAllocator = null;
			if (copyAllocator is not null)
				block_ptr_copyAllocator = &block_copyAllocator;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:"), commandBuffer__handle__, primaryTexture__handle__, &inPlaceSecondaryTextureValue, (IntPtr) block_ptr_copyAllocator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primaryTexture:inPlaceSecondaryTexture:fallbackCopyAllocator:"), commandBuffer__handle__, primaryTexture__handle__, &inPlaceSecondaryTextureValue, (IntPtr) block_ptr_copyAllocator);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryTexture);
			inPlaceSecondaryTexture = Runtime.GetNSObject<NSObject> (inPlaceSecondaryTextureValue)!;
			return ret != 0;
		}
		/// <param name="commandBuffer">To be added.</param><param name="inPlacePrimaryTexture">To be added.</param><param name="secondaryTexture">To be added.</param><param name="copyAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Attempts to apply the kernel to <paramref name="inPlacePrimaryTexture" />, using <paramref name="copyAllocator" /> to allocate and write to a new texture if in-place application fails.</summary><returns><see langword="true" /> if in-place application succeeds. Otherwise, returns <see langword="false" />.</returns><remarks>If <see langword="false" /> is returned and a non-null copy allocator was supplied, <paramref name="inPlacePrimaryTexture" /> will point to the newly allocated texture.</remarks>
		[Export ("encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, out NSObject inPlacePrimaryTexture, global::Metal.IMTLTexture secondaryTexture, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSCopyAllocator))]MPSCopyAllocator? copyAllocator)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var secondaryTexture__handle__ = secondaryTexture!.GetNonNullHandle (nameof (secondaryTexture));
			NativeHandle inPlacePrimaryTextureValue = IntPtr.Zero;
			using var block_copyAllocator = Trampolines.SDMPSCopyAllocator.CreateNullableBlock (copyAllocator);
			BlockLiteral *block_ptr_copyAllocator = null;
			if (copyAllocator is not null)
				block_ptr_copyAllocator = &block_copyAllocator;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:"), commandBuffer__handle__, &inPlacePrimaryTextureValue, secondaryTexture__handle__, (IntPtr) block_ptr_copyAllocator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:inPlacePrimaryTexture:secondaryTexture:fallbackCopyAllocator:"), commandBuffer__handle__, &inPlacePrimaryTextureValue, secondaryTexture__handle__, (IntPtr) block_ptr_copyAllocator);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (secondaryTexture);
			inPlacePrimaryTexture = Runtime.GetNSObject<NSObject> (inPlacePrimaryTextureValue)!;
			return ret != 0;
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryTexture">To be added.</param><param name="secondaryTexture">To be added.</param><param name="destinationTexture">To be added.</param><summary>Encodes the kernel to <paramref name="commandBuffer" />, which will overwrite <paramref name="destinationTexture" /> with the result of applying the kernel to <paramref name="primaryTexture" /> and <paramref name="secondaryTexture" />.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeToCommandBuffer (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture primaryTexture, global::Metal.IMTLTexture secondaryTexture, global::Metal.IMTLTexture destinationTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var primaryTexture__handle__ = primaryTexture!.GetNonNullHandle (nameof (primaryTexture));
			var secondaryTexture__handle__ = secondaryTexture!.GetNonNullHandle (nameof (secondaryTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:"), commandBuffer__handle__, primaryTexture__handle__, secondaryTexture__handle__, destinationTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeToCommandBuffer:primaryTexture:secondaryTexture:destinationTexture:"), commandBuffer__handle__, primaryTexture__handle__, secondaryTexture__handle__, destinationTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (primaryTexture);
			GC.KeepAlive (secondaryTexture);
			GC.KeepAlive (destinationTexture);
		}
		/// <param name="commandBuffer">To be added.</param><param name="primaryImage">To be added.</param><param name="secondaryImage">To be added.</param><param name="destinationImage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeToCommandBuffer:primaryImage:secondaryImage:destinationImage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		/// <param name="destinationSize">To be added.</param><summary>Calculates and returns the area of the primary source texture that will be read for the specified <paramref name="destinationSize" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("primarySourceRegionForDestinationSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSRegion PrimarySourceRegionForDestinationSize (global::Metal.MTLSize destinationSize)
		{
			MPSRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSend_MTLSize (this.Handle, Selector.GetHandle ("primarySourceRegionForDestinationSize:"), destinationSize);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSend_stret_MTLSize (this.Handle, Selector.GetHandle ("primarySourceRegionForDestinationSize:"), destinationSize);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSendSuper_MTLSize (&__objc_super__, Selector.GetHandle ("primarySourceRegionForDestinationSize:"), destinationSize);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize (&__objc_super__, Selector.GetHandle ("primarySourceRegionForDestinationSize:"), destinationSize);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="destinationSize">To be added.</param><summary>Calculates and returns the area of the secondary source texture that will be read for the specified <paramref name="destinationSize" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("secondarySourceRegionForDestinationSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSRegion SecondarySourceRegionForDestinationSize (global::Metal.MTLSize destinationSize)
		{
			MPSRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSend_MTLSize (this.Handle, Selector.GetHandle ("secondarySourceRegionForDestinationSize:"), destinationSize);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSend_stret_MTLSize (this.Handle, Selector.GetHandle ("secondarySourceRegionForDestinationSize:"), destinationSize);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSendSuper_MTLSize (&__objc_super__, Selector.GetHandle ("secondarySourceRegionForDestinationSize:"), destinationSize);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSRegion_objc_msgSendSuper_stret_MTLSize (&__objc_super__, Selector.GetHandle ("secondarySourceRegionForDestinationSize:"), destinationSize);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <summary>The region of the destination in which to write data.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the behavior to use when the shader encounters the edge of the primary image.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the location of the destination clipping rectangle in the primary texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the behavior to use when the shader encounters the edge of the secondary image.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets the location of the destination clipping rectangle in the secondary texture.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
	} /* class MPSBinaryImageKernel */
}
