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
namespace ModelIO {
	/// <summary>Class that generates a texture that consists of random color or direction noise.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLNoiseTexture_Class/index.html">Apple documentation for <c>MDLNoiseTexture</c></related>
	[Register("MDLNoiseTexture", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLNoiseTexture : MDLTexture {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_X = "initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:";
		static readonly NativeHandle selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_XHandle = Selector.GetHandle ("initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_X = "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:";
		static readonly NativeHandle selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_XHandle = Selector.GetHandle ("initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_X = "initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:";
		static readonly NativeHandle selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_XHandle = Selector.GetHandle ("initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_X = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";
		static readonly NativeHandle selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle = Selector.GetHandle ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLNoiseTexture");
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
		protected MDLNoiseTexture (NSObjectFlag t) : base (t)
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
		protected internal MDLNoiseTexture (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="pixelData"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="topLeftOrigin">To be added.</param><param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dimensions">To be added.</param><param name="rowStride">To be added.</param><param name="channelCount">To be added.</param><param name="channelEncoding">To be added.</param><param name="isCube">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLNoiseTexture (NSData? pixelData, bool topLeftOrigin, string? name, NVector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
			: base (NSObjectFlag.Empty)
		{
			var pixelData__handle__ = pixelData.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle_NVector2i_IntPtr_UIntPtr_IntPtr_bool (this.Handle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle, pixelData__handle__, topLeftOrigin ? (byte) 1 : (byte) 0, nsname, dimensions, rowStride, channelCount, (IntPtr) (long) channelEncoding, isCube ? (byte) 1 : (byte) 0), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle_NVector2i_IntPtr_UIntPtr_IntPtr_bool (&__objc_super__, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_XHandle, pixelData__handle__, topLeftOrigin ? (byte) 1 : (byte) 0, nsname, dimensions, rowStride, channelCount, (IntPtr) (long) channelEncoding, isCube ? (byte) 1 : (byte) 0), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelData);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="smoothness">To be added.</param><param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="textureDimensions">To be added.</param><param name="channelCount">To be added.</param><param name="channelEncoding">To be added.</param><param name="grayscale">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLNoiseTexture (float smoothness, string? name, NVector2i textureDimensions, int channelCount, MDLTextureChannelEncoding channelEncoding, bool grayscale)
			: base (NSObjectFlag.Empty)
		{
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_float_NativeHandle_NVector2i_int_IntPtr_bool (this.Handle, selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_XHandle, smoothness, nsname, textureDimensions, channelCount, (IntPtr) (long) channelEncoding, grayscale ? (byte) 1 : (byte) 0), "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_float_NativeHandle_NVector2i_int_IntPtr_bool (&__objc_super__, selInitScalarNoiseWithSmoothness_Name_TextureDimensions_ChannelCount_ChannelEncoding_Grayscale_XHandle, smoothness, nsname, textureDimensions, channelCount, (IntPtr) (long) channelEncoding, grayscale ? (byte) 1 : (byte) 0), "initScalarNoiseWithSmoothness:name:textureDimensions:channelCount:channelEncoding:grayscale:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initCellularNoiseWithFrequency:name:textureDimensions:channelEncoding:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitCellularNoiseWithFrequency (float frequency, string? name, NVector2i textureDimensions, MDLTextureChannelEncoding channelEncoding)
		{
			var nsname = CFString.CreateNative (name);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_float_NativeHandle_NVector2i_IntPtr (this.Handle, selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_XHandle, frequency, nsname, textureDimensions, (IntPtr) (long) channelEncoding);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_NativeHandle_NVector2i_IntPtr (&__objc_super__, selInitCellularNoiseWithFrequency_Name_TextureDimensions_ChannelEncoding_XHandle, frequency, nsname, textureDimensions, (IntPtr) (long) channelEncoding);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("initVectorNoiseWithSmoothness:name:textureDimensions:channelEncoding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitVectorNoiseWithSmoothness (float smoothness, string? name, NVector2i textureDimensions, MDLTextureChannelEncoding channelEncoding)
		{
			var nsname = CFString.CreateNative (name);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_float_NativeHandle_NVector2i_IntPtr (this.Handle, selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_XHandle, smoothness, nsname, textureDimensions, (IntPtr) (long) channelEncoding);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_NativeHandle_NVector2i_IntPtr (&__objc_super__, selInitVectorNoiseWithSmoothness_Name_TextureDimensions_ChannelEncoding_XHandle, smoothness, nsname, textureDimensions, (IntPtr) (long) channelEncoding);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MDLNoiseTexture */
}
