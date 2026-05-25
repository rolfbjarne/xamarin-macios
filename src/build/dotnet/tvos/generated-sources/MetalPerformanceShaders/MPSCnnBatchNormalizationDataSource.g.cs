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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MPSCNNBatchNormalizationDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSCNNBatchNormalizationDataSource", WrapperType = typeof (MPSCnnBatchNormalizationDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Purge", Selector = "purge")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithCommandBuffer:batchNormalizationState:", ReturnType = typeof (MetalPerformanceShaders.MPSCnnNormalizationGammaAndBetaState), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSCnnBatchNormalizationState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateMeanAndVariance", Selector = "updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:", ReturnType = typeof (MetalPerformanceShaders.MPSCnnNormalizationMeanAndVarianceState), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSCnnBatchNormalizationState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithBatchNormalizationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSCnnBatchNormalizationState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateMeanAndVariance", Selector = "updateMeanAndVarianceWithBatchNormalizationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSCnnBatchNormalizationState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeWithCoder:", ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof (MetalPerformanceShaders.IMPSCnnBatchNormalizationDataSource), ParameterType = new Type [] { typeof (NSZone), typeof (IMTLDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfFeatureChannels", Selector = "numberOfFeatureChannels", PropertyType = typeof (UIntPtr), GetterSelector = "numberOfFeatureChannels", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Gamma", Selector = "gamma", PropertyType = typeof (IntPtr), GetterSelector = "gamma", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof (IntPtr), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Mean", Selector = "mean", PropertyType = typeof (IntPtr), GetterSelector = "mean", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Variance", Selector = "variance", PropertyType = typeof (IntPtr), GetterSelector = "variance", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Load", Selector = "load", PropertyType = typeof (bool), GetterSelector = "load", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Epsilon", Selector = "epsilon", PropertyType = typeof (float), GetterSelector = "epsilon", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SupportsSecureCoding", Selector = "supportsSecureCoding", PropertyType = typeof (bool), GetterSelector = "supportsSecureCoding", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMPSCnnBatchNormalizationDataSource : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		/// <param name="decoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (NSCoder decoder) where T: NSObject, IMPSCnnBatchNormalizationDataSource
		{
			var decoder__handle__ = decoder!.GetNonNullHandle (nameof (decoder));
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (__handle__, Selector.GetHandle ("initWithCoder:"), decoder__handle__);
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			GC.KeepAlive (decoder);
			return ret;
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
		internal static void _Purge (IMPSCnnBatchNormalizationDataSource This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("purge"));
			GC.KeepAlive (This);
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			return _UpdateGammaAndBeta (this, commandBuffer, batchNormalizationState);
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnNormalizationGammaAndBetaState? _UpdateGammaAndBeta (IMPSCnnBatchNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			MPSCnnNormalizationGammaAndBetaState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:"), commandBuffer__handle__, batchNormalizationState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationState);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationMeanAndVarianceState? UpdateMeanAndVariance (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			return _UpdateMeanAndVariance (this, commandBuffer, batchNormalizationState);
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnNormalizationMeanAndVarianceState? _UpdateMeanAndVariance (IMPSCnnBatchNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			MPSCnnNormalizationMeanAndVarianceState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationMeanAndVarianceState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:"), commandBuffer__handle__, batchNormalizationState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationState);
			return ret!;
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithBatchNormalizationState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateGammaAndBeta (MPSCnnBatchNormalizationState batchNormalizationState)
		{
			return _UpdateGammaAndBeta (this, batchNormalizationState);
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UpdateGammaAndBeta (IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithBatchNormalizationState:"), batchNormalizationState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (batchNormalizationState);
			return ret != 0;
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateMeanAndVarianceWithBatchNormalizationState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateMeanAndVariance (MPSCnnBatchNormalizationState batchNormalizationState)
		{
			return _UpdateMeanAndVariance (this, batchNormalizationState);
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UpdateMeanAndVariance (IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateMeanAndVarianceWithBatchNormalizationState:"), batchNormalizationState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (batchNormalizationState);
			return ret != 0;
		}
		/// <param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (NSCoder coder)
		{
			_Encode (this, coder);
		}
		/// <param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Encode (IMPSCnnBatchNormalizationDataSource This, NSCoder coder)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
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
		public virtual IMPSCnnBatchNormalizationDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
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
		internal static IMPSCnnBatchNormalizationDataSource _Copy (IMPSCnnBatchNormalizationDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnBatchNormalizationDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[DynamicDependencyAttribute ("Beta")]
		[DynamicDependencyAttribute ("Copy(Foundation.NSZone,Metal.IMTLDevice)")]
		[DynamicDependencyAttribute ("Encode(Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("Epsilon")]
		[DynamicDependencyAttribute ("Gamma")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Load")]
		[DynamicDependencyAttribute ("Mean")]
		[DynamicDependencyAttribute ("NumberOfFeatureChannels")]
		[DynamicDependencyAttribute ("Purge()")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSCnnBatchNormalizationState)")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(MetalPerformanceShaders.MPSCnnBatchNormalizationState)")]
		[DynamicDependencyAttribute ("UpdateMeanAndVariance(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSCnnBatchNormalizationState)")]
		[DynamicDependencyAttribute ("UpdateMeanAndVariance(MetalPerformanceShaders.MPSCnnBatchNormalizationState)")]
		[DynamicDependencyAttribute ("Variance")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnBatchNormalizationDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSCnnBatchNormalizationDataSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				return _GetNumberOfFeatureChannels (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetNumberOfFeatureChannels (IMPSCnnBatchNormalizationDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Gamma {
			[Export ("gamma")]
			get {
				return _GetGamma (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetGamma (IMPSCnnBatchNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("gamma"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Beta {
			[Export ("beta")]
			get {
				return _GetBeta (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetBeta (IMPSCnnBatchNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("beta"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Mean {
			[Export ("mean")]
			get {
				return _GetMean (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMean (IMPSCnnBatchNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mean"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Variance {
			[Export ("variance")]
			get {
				return _GetVariance (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetVariance (IMPSCnnBatchNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("variance"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Load {
			[Export ("load")]
			get {
				return _GetLoad (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetLoad (IMPSCnnBatchNormalizationDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("load"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMPSCnnBatchNormalizationDataSource This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				return _GetEpsilon (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetEpsilon (IMPSCnnBatchNormalizationDataSource This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("epsilon"));
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsSecureCoding<T> () where T: NSObject, IMPSCnnBatchNormalizationDataSource
		{
			var class_ptr = Class.GetHandle (typeof (T));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("supportsSecureCoding"));
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSCnnBatchNormalizationDataSource" /> interface to support all the methods from the MPSCNNBatchNormalizationDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSCnnBatchNormalizationDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSCNNBatchNormalizationDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSCnnBatchNormalizationDataSource_Extensions {
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (this IMPSCnnBatchNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			MPSCnnNormalizationGammaAndBetaState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:"), commandBuffer__handle__, batchNormalizationState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationState);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnNormalizationMeanAndVarianceState? UpdateMeanAndVariance (this IMPSCnnBatchNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			MPSCnnNormalizationMeanAndVarianceState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationMeanAndVarianceState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:"), commandBuffer__handle__, batchNormalizationState__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (batchNormalizationState);
			return ret!;
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UpdateGammaAndBeta (this IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithBatchNormalizationState:"), batchNormalizationState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (batchNormalizationState);
			return ret != 0;
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UpdateMeanAndVariance (this IMPSCnnBatchNormalizationDataSource This, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			var batchNormalizationState__handle__ = batchNormalizationState!.GetNonNullHandle (nameof (batchNormalizationState));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateMeanAndVarianceWithBatchNormalizationState:"), batchNormalizationState__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (batchNormalizationState);
			return ret != 0;
		}
		/// <param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this IMPSCnnBatchNormalizationDataSource This, NSCoder coder)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMPSCnnBatchNormalizationDataSource Copy (this IMPSCnnBatchNormalizationDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnBatchNormalizationDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnBatchNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetEpsilon (this IMPSCnnBatchNormalizationDataSource This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("epsilon"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSCnnBatchNormalizationDataSourceWrapper : BaseWrapper, IMPSCnnBatchNormalizationDataSource {
		public MPSCnnBatchNormalizationDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnBatchNormalizationDataSourceWrapper))]
		static MPSCnnBatchNormalizationDataSourceWrapper ()
		{
			GC.KeepAlive (null);
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
		public nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Gamma {
			[Export ("gamma")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gamma"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Beta {
			[Export ("beta")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("beta"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Mean {
			[Export ("mean")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mean"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Variance {
			[Export ("variance")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("variance"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Load {
			[Export ("load")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("load"));
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IMPSCnnBatchNormalizationDataSource" /> (for the protocol <c>MPSCNNBatchNormalizationDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IMPSCnnBatchNormalizationDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__MetalPerformanceShaders_MPSCnnBatchNormalizationDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MPSCnnBatchNormalizationDataSource : NSObject, IMPSCnnBatchNormalizationDataSource, INSCopying {
		/// <summary>Creates a new <see cref="MPSCnnBatchNormalizationDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPSCnnBatchNormalizationDataSource () : base (NSObjectFlag.Empty)
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
		protected MPSCnnBatchNormalizationDataSource (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnBatchNormalizationDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="decoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnBatchNormalizationDataSource (NSCoder decoder)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="zone">To be added.</param><param name="device">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnBatchNormalizationDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
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
		/// <param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (NSCoder coder)
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
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateGammaAndBetaWithCommandBuffer:batchNormalizationState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateGammaAndBetaWithBatchNormalizationState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateGammaAndBeta (MPSCnnBatchNormalizationState batchNormalizationState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="commandBuffer">To be added.</param><param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateMeanAndVarianceWithCommandBuffer:batchNormalizationState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationMeanAndVarianceState? UpdateMeanAndVariance (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnBatchNormalizationState batchNormalizationState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="batchNormalizationState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateMeanAndVarianceWithBatchNormalizationState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateMeanAndVariance (MPSCnnBatchNormalizationState batchNormalizationState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Beta {
			[Export ("beta")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Gamma {
			[Export ("gamma")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load {
			[Export ("load")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Mean {
			[Export ("mean")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsSecureCoding {
			[Export ("supportsSecureCoding")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Variance {
			[Export ("variance")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class MPSCnnBatchNormalizationDataSource */
}
