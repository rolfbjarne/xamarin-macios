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
	/// <summary>This interface represents the Objective-C protocol <c>MPSCNNGroupNormalizationDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MPSCNNGroupNormalizationDataSource", WrapperType = typeof (MPSCnnGroupNormalizationDataSourceWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithCommandBuffer:groupNormalizationStateBatch:", ReturnType = typeof (MetalPerformanceShaders.MPSCnnNormalizationGammaAndBetaState), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSCnnGroupNormalizationGradientState[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGammaAndBeta", Selector = "updateGammaAndBetaWithGroupNormalizationStateBatch:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MetalPerformanceShaders.MPSCnnGroupNormalizationGradientState[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Encode", Selector = "encodeWithCoder:", ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:device:", ReturnType = typeof (MetalPerformanceShaders.IMPSCnnGroupNormalizationDataSource), ParameterType = new Type [] { typeof (NSZone), typeof (IMTLDevice) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Gamma", Selector = "gamma", PropertyType = typeof (IntPtr), GetterSelector = "gamma", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof (IntPtr), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfFeatureChannels", Selector = "numberOfFeatureChannels", PropertyType = typeof (UIntPtr), GetterSelector = "numberOfFeatureChannels", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfGroups", Selector = "numberOfGroups", PropertyType = typeof (UIntPtr), GetterSelector = "numberOfGroups", SetterSelector = "setNumberOfGroups:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Epsilon", Selector = "epsilon", PropertyType = typeof (float), GetterSelector = "epsilon", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SupportsSecureCoding", Selector = "supportsSecureCoding", PropertyType = typeof (bool), GetterSelector = "supportsSecureCoding", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMPSCnnGroupNormalizationDataSource : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (NSCoder aDecoder) where T: NSObject, IMPSCnnGroupNormalizationDataSource
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (__handle__, Selector.GetHandle ("initWithCoder:"), aDecoder__handle__);
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			GC.KeepAlive (aDecoder);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithCommandBuffer:groupNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSCnnNormalizationGammaAndBetaState? UpdateGammaAndBeta (global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnGroupNormalizationGradientState[] groupNormalizationStateBatch)
		{
			return _UpdateGammaAndBeta (this, commandBuffer, groupNormalizationStateBatch);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSCnnNormalizationGammaAndBetaState? _UpdateGammaAndBeta (IMPSCnnGroupNormalizationDataSource This, global::Metal.IMTLCommandBuffer commandBuffer, MPSCnnGroupNormalizationGradientState[] groupNormalizationStateBatch)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (groupNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groupNormalizationStateBatch));
			using var nsa_groupNormalizationStateBatch = NSArray.FromNSObjects (groupNormalizationStateBatch);
			MPSCnnNormalizationGammaAndBetaState? ret;
			ret =  Runtime.GetNSObject<MPSCnnNormalizationGammaAndBetaState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithCommandBuffer:groupNormalizationStateBatch:"), commandBuffer__handle__, nsa_groupNormalizationStateBatch.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("updateGammaAndBetaWithGroupNormalizationStateBatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateGammaAndBeta (MPSCnnGroupNormalizationGradientState[] groupNormalizationStateBatch)
		{
			return _UpdateGammaAndBeta (this, groupNormalizationStateBatch);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _UpdateGammaAndBeta (IMPSCnnGroupNormalizationDataSource This, MPSCnnGroupNormalizationGradientState[] groupNormalizationStateBatch)
		{
			if (groupNormalizationStateBatch is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (groupNormalizationStateBatch));
			using var nsa_groupNormalizationStateBatch = NSArray.FromNSObjects (groupNormalizationStateBatch);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateGammaAndBetaWithGroupNormalizationStateBatch:"), nsa_groupNormalizationStateBatch.Handle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (NSCoder aCoder)
		{
			_Encode (this, aCoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Encode (IMPSCnnGroupNormalizationDataSource This, NSCoder aCoder)
		{
			var aCoder__handle__ = aCoder!.GetNonNullHandle (nameof (aCoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeWithCoder:"), aCoder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aCoder);
		}
		[global::Foundation.OptionalMember]
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSCnnGroupNormalizationDataSource Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			return _Copy (this, zone, device);
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMPSCnnGroupNormalizationDataSource _Copy (IMPSCnnGroupNormalizationDataSource This, NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			IMPSCnnGroupNormalizationDataSource? ret;
			ret =  Runtime.GetINativeObject<IMPSCnnGroupNormalizationDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
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
		[DynamicDependencyAttribute ("NumberOfFeatureChannels")]
		[DynamicDependencyAttribute ("NumberOfGroups")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSCnnGroupNormalizationGradientState[])")]
		[DynamicDependencyAttribute ("UpdateGammaAndBeta(MetalPerformanceShaders.MPSCnnGroupNormalizationGradientState[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnGroupNormalizationDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSCnnGroupNormalizationDataSource ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Gamma {
			[Export ("gamma")]
			get {
				return _GetGamma (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetGamma (IMPSCnnGroupNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("gamma"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Beta {
			[Export ("beta")]
			get {
				return _GetBeta (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetBeta (IMPSCnnGroupNormalizationDataSource This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("beta"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				return _GetNumberOfFeatureChannels (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetNumberOfFeatureChannels (IMPSCnnGroupNormalizationDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint NumberOfGroups {
			[Export ("numberOfGroups")]
			get {
				return _GetNumberOfGroups (this);
			}
			[Export ("setNumberOfGroups:")]
			set {
				_SetNumberOfGroups (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetNumberOfGroups (IMPSCnnGroupNormalizationDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("numberOfGroups"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNumberOfGroups (IMPSCnnGroupNormalizationDataSource This, nuint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setNumberOfGroups:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMPSCnnGroupNormalizationDataSource This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual float Epsilon {
			[Export ("epsilon")]
			get {
				return _GetEpsilon (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetEpsilon (IMPSCnnGroupNormalizationDataSource This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("epsilon"));
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsSecureCoding<T> () where T: NSObject, IMPSCnnGroupNormalizationDataSource
		{
			var class_ptr = Class.GetHandle (typeof (T));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("supportsSecureCoding"));
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSCnnGroupNormalizationDataSourceWrapper : BaseWrapper, IMPSCnnGroupNormalizationDataSource {
		public MPSCnnGroupNormalizationDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSCnnGroupNormalizationDataSourceWrapper))]
		static MPSCnnGroupNormalizationDataSourceWrapper ()
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Gamma {
			[Export ("gamma")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gamma"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Beta {
			[Export ("beta")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("beta"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint NumberOfFeatureChannels {
			[Export ("numberOfFeatureChannels")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfFeatureChannels"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint NumberOfGroups {
			[Export ("numberOfGroups")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfGroups"));
				return ret;
			}
			[Export ("setNumberOfGroups:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setNumberOfGroups:"), value);
			}
		}
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
