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
	/// <summary>Base class for classes that provide weights and bias terms to convolution filters.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSCNNConvolutionDataSource", WrapperType = typeof (MPSCnnConvolutionDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Load", Selector = "load", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Purge", Selector = "purge")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRangesForUInt8Kernel", Selector = "rangesForUInt8Kernel", ReturnType = typeof (IntPtr))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLookupTableForUInt8Kernel", Selector = "lookupTableForUInt8Kernel", ReturnType = typeof (IntPtr))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWeightsQuantizationType", Selector = "weightsQuantizationType", ReturnType = typeof (MetalPerformanceShaders.MPSCnnWeightsQuantizationType))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateWithCommandBuffer:gradientState:sourceState:", ReturnType = typeof (MetalPerformanceShaders.MPSCnnConvolutionWeightsAndBiasesState), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSCnnConvolutionGradientState), typeof (MetalPerformanceShaders.MPSCnnConvolutionWeightsAndBiasesState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateWithGradientState:sourceState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSCnnConvolutionGradientState), typeof (MetalPerformanceShaders.MPSCnnConvolutionWeightsAndBiasesState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof (MetalPerformanceShaders.IMPSCnnConvolutionDataSource), ParameterType = new Type [] { typeof (NSZone), typeof (IMTLDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DataType", Selector = "dataType", PropertyType = typeof (MetalPerformanceShaders.MPSDataType), GetterSelector = "dataType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Descriptor", Selector = "descriptor", PropertyType = typeof (MetalPerformanceShaders.MPSCnnConvolutionDescriptor), GetterSelector = "descriptor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Weights", Selector = "weights", PropertyType = typeof (IntPtr), GetterSelector = "weights", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BiasTerms", Selector = "biasTerms", PropertyType = typeof (IntPtr), GetterSelector = "biasTerms", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeightsLayout", Selector = "weightsLayout", PropertyType = typeof (MetalPerformanceShaders.MPSCnnConvolutionWeightsLayout), GetterSelector = "weightsLayout", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "KernelWeightsDataType", Selector = "kernelWeightsDataType", PropertyType = typeof (MetalPerformanceShaders.MPSDataType), GetterSelector = "kernelWeightsDataType", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMPSCnnConvolutionDataSource : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		[global::Foundation.RequiredMember]
		[Export ("load")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _Load (IMPSCnnConvolutionDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("load"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("purge")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Purge ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Purge (IMPSCnnConvolutionDataSource This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("purge"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("rangesForUInt8Kernel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRangesForUInt8Kernel ()
		{
			return _GetRangesForUInt8Kernel (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetRangesForUInt8Kernel (IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("rangesForUInt8Kernel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("lookupTableForUInt8Kernel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetLookupTableForUInt8Kernel ()
		{
			return _GetLookupTableForUInt8Kernel (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetLookupTableForUInt8Kernel (IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("lookupTableForUInt8Kernel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("weightsQuantizationType")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnWeightsQuantizationType GetWeightsQuantizationType ()
		{
			return _GetWeightsQuantizationType (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnWeightsQuantizationType _GetWeightsQuantizationType (IMPSCnnConvolutionDataSource This)
		{
			MPSCnnWeightsQuantizationType ret;
			ret = (MPSCnnWeightsQuantizationType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("weightsQuantizationType"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="commandBuffer">To be added.</param><param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateWithCommandBuffer:gradientState:sourceState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionWeightsAndBiasesState? Update (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			return _Update (this, commandBuffer, gradientState, sourceState);
		}
		/// <param name="commandBuffer">To be added.</param><param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnConvolutionWeightsAndBiasesState? _Update (IMPSCnnConvolutionDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var gradientState__handle__ = gradientState!.GetNonNullHandle (nameof (gradientState));
			var sourceState__handle__ = sourceState!.GetNonNullHandle (nameof (sourceState));
			MPSCnnConvolutionWeightsAndBiasesState? ret;
			ret =  Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateWithCommandBuffer:gradientState:sourceState:"), commandBuffer__handle__, gradientState__handle__, sourceState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (gradientState);
			GC.KeepAlive (sourceState);
			return ret!;
		}
		/// <param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateWithGradientState:sourceState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Update (MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			return _Update (this, gradientState, sourceState);
		}
		/// <param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _Update (IMPSCnnConvolutionDataSource This, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			var gradientState__handle__ = gradientState!.GetNonNullHandle (nameof (gradientState));
			var sourceState__handle__ = sourceState!.GetNonNullHandle (nameof (sourceState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateWithGradientState:sourceState:"), gradientState__handle__, sourceState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gradientState);
			GC.KeepAlive (sourceState);
			return ret != 0;
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			return _Copy (this, zone, device);
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMPSCnnConvolutionDataSource _Copy (IMPSCnnConvolutionDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnConvolutionDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[DynamicDependencyAttribute ("BiasTerms")]
		[DynamicDependencyAttribute ("Copy(Foundation.NSZone,Metal.IMTLDevice)")]
		[DynamicDependencyAttribute ("DataType")]
		[DynamicDependencyAttribute ("Descriptor")]
		[DynamicDependencyAttribute ("GetLookupTableForUInt8Kernel()")]
		[DynamicDependencyAttribute ("GetRangesForUInt8Kernel()")]
		[DynamicDependencyAttribute ("GetWeightsQuantizationType()")]
		[DynamicDependencyAttribute ("KernelWeightsDataType")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Load()")]
		[DynamicDependencyAttribute ("Purge()")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSCnnConvolutionGradientState,MetalPerformanceShaders.MPSCnnConvolutionWeightsAndBiasesState)")]
		[DynamicDependencyAttribute ("Update(MetalPerformanceShaders.MPSCnnConvolutionGradientState,MetalPerformanceShaders.MPSCnnConvolutionWeightsAndBiasesState)")]
		[DynamicDependencyAttribute ("Weights")]
		[DynamicDependencyAttribute ("WeightsLayout")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnConvolutionDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSCnnConvolutionDataSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MPSDataType DataType {
			[Export ("dataType")]
			get {
				return _GetDataType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSDataType _GetDataType (IMPSCnnConvolutionDataSource This)
		{
			MPSDataType ret;
			ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("dataType"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MPSCnnConvolutionDescriptor Descriptor {
			[Export ("descriptor")]
			get {
				return _GetDescriptor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnConvolutionDescriptor _GetDescriptor (IMPSCnnConvolutionDataSource This)
		{
			MPSCnnConvolutionDescriptor ret;
			ret =  Runtime.GetNSObject<MPSCnnConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("descriptor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Weights {
			[Export ("weights")]
			get {
				return _GetWeights (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetWeights (IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("weights"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint BiasTerms {
			[Export ("biasTerms")]
			get {
				return _GetBiasTerms (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetBiasTerms (IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("biasTerms"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMPSCnnConvolutionDataSource This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual MPSCnnConvolutionWeightsLayout WeightsLayout {
			[Export ("weightsLayout")]
			get {
				return _GetWeightsLayout (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnConvolutionWeightsLayout _GetWeightsLayout (IMPSCnnConvolutionDataSource This)
		{
			MPSCnnConvolutionWeightsLayout ret;
			ret = (MPSCnnConvolutionWeightsLayout) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("weightsLayout"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual MPSDataType KernelWeightsDataType {
			[Export ("kernelWeightsDataType")]
			get {
				return _GetKernelWeightsDataType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSDataType _GetKernelWeightsDataType (IMPSCnnConvolutionDataSource This)
		{
			MPSDataType ret;
			ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("kernelWeightsDataType"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSCnnConvolutionDataSource" /> interface to support all the methods from the MPSCNNConvolutionDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSCnnConvolutionDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSCNNConvolutionDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSCnnConvolutionDataSource_Extensions {
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetRangesForUInt8Kernel (this IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("rangesForUInt8Kernel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetLookupTableForUInt8Kernel (this IMPSCnnConvolutionDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("lookupTableForUInt8Kernel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnWeightsQuantizationType GetWeightsQuantizationType (this IMPSCnnConvolutionDataSource This)
		{
			MPSCnnWeightsQuantizationType ret;
			ret = (MPSCnnWeightsQuantizationType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("weightsQuantizationType"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="commandBuffer">To be added.</param><param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnConvolutionWeightsAndBiasesState? Update (this IMPSCnnConvolutionDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var gradientState__handle__ = gradientState!.GetNonNullHandle (nameof (gradientState));
			var sourceState__handle__ = sourceState!.GetNonNullHandle (nameof (sourceState));
			MPSCnnConvolutionWeightsAndBiasesState? ret;
			ret =  Runtime.GetNSObject<MPSCnnConvolutionWeightsAndBiasesState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateWithCommandBuffer:gradientState:sourceState:"), commandBuffer__handle__, gradientState__handle__, sourceState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (gradientState);
			GC.KeepAlive (sourceState);
			return ret!;
		}
		/// <param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Update (this IMPSCnnConvolutionDataSource This, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			var gradientState__handle__ = gradientState!.GetNonNullHandle (nameof (gradientState));
			var sourceState__handle__ = sourceState!.GetNonNullHandle (nameof (sourceState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateWithGradientState:sourceState:"), gradientState__handle__, sourceState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gradientState);
			GC.KeepAlive (sourceState);
			return ret != 0;
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMPSCnnConvolutionDataSource Copy (this IMPSCnnConvolutionDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnConvolutionDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnConvolutionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnConvolutionWeightsLayout GetWeightsLayout (this IMPSCnnConvolutionDataSource This)
		{
			MPSCnnConvolutionWeightsLayout ret;
			ret = (MPSCnnConvolutionWeightsLayout) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("weightsLayout"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSDataType GetKernelWeightsDataType (this IMPSCnnConvolutionDataSource This)
		{
			MPSDataType ret;
			ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("kernelWeightsDataType"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSCnnConvolutionDataSourceWrapper : BaseWrapper, IMPSCnnConvolutionDataSource {
		public MPSCnnConvolutionDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnConvolutionDataSourceWrapper))]
		static MPSCnnConvolutionDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("load")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Load ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("load"));
			return ret != 0;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("purge")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Purge ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("purge"));
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSDataType DataType {
			[Export ("dataType")]
			get {
				MPSDataType ret;
				ret = (MPSDataType) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("dataType"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnConvolutionDescriptor Descriptor {
			[Export ("descriptor")]
			get {
				MPSCnnConvolutionDescriptor ret;
				ret =  Runtime.GetNSObject<MPSCnnConvolutionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("descriptor")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Weights {
			[Export ("weights")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("weights"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint BiasTerms {
			[Export ("biasTerms")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("biasTerms"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
	}
}
namespace MetalPerformanceShaders {
	/// <summary>Base class for classes that provide weights and bias terms to convolution filters.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__MetalPerformanceShaders_MPSCnnConvolutionDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MPSCnnConvolutionDataSource : NSObject, IMPSCnnConvolutionDataSource, INSCopying {
		/// <summary>Creates a new <see cref="MPSCnnConvolutionDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPSCnnConvolutionDataSource () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected MPSCnnConvolutionDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal MPSCnnConvolutionDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnConvolutionDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("lookupTableForUInt8Kernel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetLookupTableForUInt8Kernel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangesForUInt8Kernel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRangesForUInt8Kernel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("weightsQuantizationType")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnWeightsQuantizationType GetWeightsQuantizationType ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("load")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("purge")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Purge ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="commandBuffer">To be added.</param><param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateWithCommandBuffer:gradientState:sourceState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionWeightsAndBiasesState? Update (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gradientState">To be added.</param><param name="sourceState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateWithGradientState:sourceState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Update (MPSCnnConvolutionGradientState gradientState, MPSCnnConvolutionWeightsAndBiasesState sourceState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BiasTerms {
			[Export ("biasTerms")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSDataType DataType {
			[Export ("dataType")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnConvolutionDescriptor Descriptor {
			[Export ("descriptor")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		public virtual MPSDataType KernelWeightsDataType {
			[Export ("kernelWeightsDataType")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Weights {
			[Export ("weights")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		public virtual MPSCnnConvolutionWeightsLayout WeightsLayout {
			[Export ("weightsLayout")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class MPSCnnConvolutionDataSource */
}
