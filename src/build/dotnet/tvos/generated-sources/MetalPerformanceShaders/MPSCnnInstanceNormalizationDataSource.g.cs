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
	/// <summary>This interface represents the Objective-C protocol <c>MPSCNNInstanceNormalizationDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSCNNInstanceNormalizationDataSource", WrapperType = typeof (MPSCnnInstanceNormalizationDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:", ReturnType = typeof (MetalPerformanceShaders.MPSCnnNormalizationGammaAndBetaState), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSCnnInstanceNormalizationGradientState[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithInstanceNormalizationStateBatch:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSCnnInstanceNormalizationGradientState[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEpsilon", Selector = "epsilon", ReturnType = typeof (float))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeWithCoder:", ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof (MetalPerformanceShaders.IMPSCnnInstanceNormalizationDataSource), ParameterType = new Type [] { typeof (NSZone), typeof (IMTLDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Load", Selector = "load", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Purge", Selector = "purge")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Gamma", Selector = "gamma", PropertyType = typeof (IntPtr), GetterSelector = "gamma", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof (IntPtr), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfFeatureChannels", Selector = "numberOfFeatureChannels", PropertyType = typeof (UIntPtr), GetterSelector = "numberOfFeatureChannels", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMPSCnnInstanceNormalizationDataSource : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		/// <param name="decoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (NSCoder decoder) where T: NSObject, IMPSCnnInstanceNormalizationDataSource
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
		/// <param name="commandBuffer">To be added.</param><param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			return _UpdateGammaAndBeta (this, commandBuffer, instanceNormalizationStateBatch);
		}
		/// <param name="commandBuffer">To be added.</param><param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnNormalizationGammaAndBetaState? _UpdateGammaAndBeta (IMPSCnnInstanceNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (instanceNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceNormalizationStateBatch));
			using var nsa_instanceNormalizationStateBatch = NSArray.FromNSObjects (instanceNormalizationStateBatch);
			MPSCnnNormalizationGammaAndBetaState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:"), commandBuffer__handle__, nsa_instanceNormalizationStateBatch.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithInstanceNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateGammaAndBeta (MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			return _UpdateGammaAndBeta (this, instanceNormalizationStateBatch);
		}
		/// <param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UpdateGammaAndBeta (IMPSCnnInstanceNormalizationDataSource This, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			if (instanceNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceNormalizationStateBatch));
			using var nsa_instanceNormalizationStateBatch = NSArray.FromNSObjects (instanceNormalizationStateBatch);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithInstanceNormalizationStateBatch:"), nsa_instanceNormalizationStateBatch.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("epsilon")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetEpsilon ()
		{
			return _GetEpsilon (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetEpsilon (IMPSCnnInstanceNormalizationDataSource This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("epsilon"));
			GC.KeepAlive (This);
			return ret;
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
		internal static void _Encode (IMPSCnnInstanceNormalizationDataSource This, NSCoder coder)
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
		public virtual IMPSCnnInstanceNormalizationDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
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
		internal static IMPSCnnInstanceNormalizationDataSource _Copy (IMPSCnnInstanceNormalizationDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnInstanceNormalizationDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnInstanceNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("load")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load ()
		{
			return _Load (this);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _Load (IMPSCnnInstanceNormalizationDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("load"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("purge")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Purge ()
		{
			_Purge (this);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Purge (IMPSCnnInstanceNormalizationDataSource This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("purge"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Beta")]
		[DynamicDependencyAttribute ("Copy(Foundation.NSZone,Metal.IMTLDevice)")]
		[DynamicDependencyAttribute ("Encode(Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("Gamma")]
		[DynamicDependencyAttribute ("GetEpsilon()")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Load()")]
		[DynamicDependencyAttribute ("NumberOfFeatureChannels")]
		[DynamicDependencyAttribute ("Purge()")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSCnnInstanceNormalizationGradientState[])")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(MetalPerformanceShaders.MPSCnnInstanceNormalizationGradientState[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnInstanceNormalizationDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSCnnInstanceNormalizationDataSource ()
		{
			GC.KeepAlive (null);
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
		internal static nint _GetGamma (IMPSCnnInstanceNormalizationDataSource This)
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
		internal static nint _GetBeta (IMPSCnnInstanceNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("beta"));
			GC.KeepAlive (This);
			return ret;
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
		internal static nuint _GetNumberOfFeatureChannels (IMPSCnnInstanceNormalizationDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMPSCnnInstanceNormalizationDataSource This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSCnnInstanceNormalizationDataSource" /> interface to support all the methods from the MPSCNNInstanceNormalizationDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSCnnInstanceNormalizationDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSCNNInstanceNormalizationDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSCnnInstanceNormalizationDataSource_Extensions {
		/// <param name="commandBuffer">To be added.</param><param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (this IMPSCnnInstanceNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (instanceNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceNormalizationStateBatch));
			using var nsa_instanceNormalizationStateBatch = NSArray.FromNSObjects (instanceNormalizationStateBatch);
			MPSCnnNormalizationGammaAndBetaState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:"), commandBuffer__handle__, nsa_instanceNormalizationStateBatch.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UpdateGammaAndBeta (this IMPSCnnInstanceNormalizationDataSource This, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			if (instanceNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceNormalizationStateBatch));
			using var nsa_instanceNormalizationStateBatch = NSArray.FromNSObjects (instanceNormalizationStateBatch);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithInstanceNormalizationStateBatch:"), nsa_instanceNormalizationStateBatch.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetEpsilon (this IMPSCnnInstanceNormalizationDataSource This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("epsilon"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="coder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Encode (this IMPSCnnInstanceNormalizationDataSource This, NSCoder coder)
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
		public static IMPSCnnInstanceNormalizationDataSource Copy (this IMPSCnnInstanceNormalizationDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnInstanceNormalizationDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnInstanceNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Load (this IMPSCnnInstanceNormalizationDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("load"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Purge (this IMPSCnnInstanceNormalizationDataSource This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("purge"));
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSCnnInstanceNormalizationDataSourceWrapper : BaseWrapper, IMPSCnnInstanceNormalizationDataSource {
		public MPSCnnInstanceNormalizationDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnInstanceNormalizationDataSourceWrapper))]
		static MPSCnnInstanceNormalizationDataSourceWrapper ()
		{
			GC.KeepAlive (null);
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
		public string Label {
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
	///   <para>This is a class that implements the interface <see cref="IMPSCnnInstanceNormalizationDataSource" /> (for the protocol <c>MPSCNNInstanceNormalizationDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IMPSCnnInstanceNormalizationDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__MetalPerformanceShaders_MPSCnnInstanceNormalizationDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MPSCnnInstanceNormalizationDataSource : NSObject, IMPSCnnInstanceNormalizationDataSource, INSCopying {
		/// <summary>Creates a new <see cref="MPSCnnInstanceNormalizationDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPSCnnInstanceNormalizationDataSource () : base (NSObjectFlag.Empty)
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
		protected MPSCnnInstanceNormalizationDataSource (NSObjectFlag t) : base (t)
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
		protected internal MPSCnnInstanceNormalizationDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="decoder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSCnnInstanceNormalizationDataSource (NSCoder decoder)
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
		public virtual IMPSCnnInstanceNormalizationDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
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
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("epsilon")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetEpsilon ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("load")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("purge")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Purge ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="commandBuffer">To be added.</param><param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateGammaAndBetaWithCommandBuffer:instanceNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="instanceNormalizationStateBatch">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("updateGammaAndBetaWithInstanceNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateGammaAndBeta (MPSCnnInstanceNormalizationGradientState[] instanceNormalizationStateBatch)
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
		public virtual nint Gamma {
			[Export ("gamma")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Label {
			[Export ("label")]
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
	} /* class MPSCnnInstanceNormalizationDataSource */
}
