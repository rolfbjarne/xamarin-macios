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
	/// <summary>Interface describing how kernels should pad their inputs.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSNNPadding", WrapperType = typeof (MPSNNPaddingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLabel", Selector = "label", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDestinationImageDescriptor", Selector = "destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:", ReturnType = typeof (MetalPerformanceShaders.MPSImageDescriptor), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSImage[]), typeof (MetalPerformanceShaders.MPSState[]), typeof (MetalPerformanceShaders.MPSKernel), typeof (MetalPerformanceShaders.MPSImageDescriptor) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInverse", Selector = "inverse", ReturnType = typeof (MetalPerformanceShaders.IMPSNNPadding))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PaddingMethod", Selector = "paddingMethod", PropertyType = typeof (MetalPerformanceShaders.MPSNNPaddingMethod), GetterSelector = "paddingMethod", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMPSNNPadding : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSSecureCoding
	{
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("label")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetLabel ()
		{
			return _GetLabel (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMPSNNPadding This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><param name="kernel">To be added.</param><param name="inDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageDescriptor GetDestinationImageDescriptor (MPSImage[] sourceImages, MPSState[]? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
		{
			return _GetDestinationImageDescriptor (this, sourceImages, sourceStates, kernel, inDescriptor);
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><param name="kernel">To be added.</param><param name="inDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSImageDescriptor _GetDestinationImageDescriptor (IMPSNNPadding This, MPSImage[] sourceImages, MPSState[]? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			var inDescriptor__handle__ = inDescriptor!.GetNonNullHandle (nameof (inDescriptor));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSImageDescriptor? ret;
			ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:"), nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), kernel__handle__, inDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (kernel);
			GC.KeepAlive (inDescriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("inverse")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNNPadding? GetInverse ()
		{
			return _GetInverse (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMPSNNPadding? _GetInverse (IMPSNNPadding This)
		{
			IMPSNNPadding ret;
			ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inverse")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetDestinationImageDescriptor(MetalPerformanceShaders.MPSImage[],MetalPerformanceShaders.MPSState[],MetalPerformanceShaders.MPSKernel,MetalPerformanceShaders.MPSImageDescriptor)")]
		[DynamicDependencyAttribute ("GetInverse()")]
		[DynamicDependencyAttribute ("GetLabel()")]
		[DynamicDependencyAttribute ("PaddingMethod")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNNPaddingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSNNPadding ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MPSNNPaddingMethod PaddingMethod {
			[Export ("paddingMethod")]
			get {
				return _GetPaddingMethod (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSNNPaddingMethod _GetPaddingMethod (IMPSNNPadding This)
		{
			MPSNNPaddingMethod ret;
			ret = (MetalPerformanceShaders.MPSNNPaddingMethod) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("paddingMethod"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSNNPadding" /> interface to support all the methods from the MPSNNPadding protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSNNPadding" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSNNPadding protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSNNPadding_Extensions {
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetLabel (this IMPSNNPadding This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><param name="kernel">To be added.</param><param name="inDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSImageDescriptor GetDestinationImageDescriptor (this IMPSNNPadding This, MPSImage[] sourceImages, MPSState[]? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
		{
			if (sourceImages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceImages));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			var inDescriptor__handle__ = inDescriptor!.GetNonNullHandle (nameof (inDescriptor));
			using var nsa_sourceImages = NSArray.FromNSObjects (sourceImages);
			using var nsa_sourceStates = sourceStates is null ? null : NSArray.FromNSObjects (sourceStates);
			MPSImageDescriptor? ret;
			ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:"), nsa_sourceImages.Handle, nsa_sourceStates.GetHandle (), kernel__handle__, inDescriptor__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (kernel);
			GC.KeepAlive (inDescriptor);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMPSNNPadding? GetInverse (this IMPSNNPadding This)
		{
			IMPSNNPadding ret;
			ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inverse")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSNNPaddingWrapper : BaseWrapper, IMPSNNPadding {
		public MPSNNPaddingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNNPaddingWrapper))]
		static MPSNNPaddingWrapper ()
		{
			GC.KeepAlive (null);
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNPaddingMethod PaddingMethod {
			[Export ("paddingMethod")]
			get {
				MPSNNPaddingMethod ret;
				ret = (MetalPerformanceShaders.MPSNNPaddingMethod) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paddingMethod"));
				return ret!;
			}
		}
	}
}
