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
	#pragma warning disable CS1573
	/// <summary>Interface defining image resampling methods.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSImageTransformProvider", WrapperType = typeof (MPSImageTransformProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTransform", Selector = "transformForSourceImage:handle:", ReturnType = typeof (MetalPerformanceShaders.MPSScaleTransform), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSImage), typeof (MetalPerformanceShaders.IMPSHandle) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMPSImageTransformProvider : INativeObject, IDisposable, 
		Foundation.INSCoding
	{
		/// <param name="image">To be added.</param><param name="handle">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("transformForSourceImage:handle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSScaleTransform GetTransform (MPSImage image, IMPSHandle? handle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="handle">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSScaleTransform _GetTransform (IMPSImageTransformProvider This, MPSImage image, IMPSHandle? handle)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var handle__handle__ = handle.GetHandle ();
			MPSScaleTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MPSScaleTransform_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("transformForSourceImage:handle:"), image__handle__, handle__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MPSScaleTransform_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("transformForSourceImage:handle:"), image__handle__, handle__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (image);
			GC.KeepAlive (handle);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetTransform(MetalPerformanceShaders.MPSImage,MetalPerformanceShaders.IMPSHandle)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSImageTransformProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSImageTransformProvider ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSImageTransformProviderWrapper : BaseWrapper, IMPSImageTransformProvider {
		public MPSImageTransformProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSImageTransformProviderWrapper))]
		static MPSImageTransformProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="image">To be added.</param><param name="handle">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("transformForSourceImage:handle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSScaleTransform GetTransform (MPSImage image, IMPSHandle? handle)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var handle__handle__ = handle.GetHandle ();
			MPSScaleTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MPSScaleTransform_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("transformForSourceImage:handle:"), image__handle__, handle__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.MPSScaleTransform_objc_msgSend_stret_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("transformForSourceImage:handle:"), image__handle__, handle__handle__);
			}
			GC.KeepAlive (image);
			GC.KeepAlive (handle);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			GC.KeepAlive (encoder);
		}
	}
}
