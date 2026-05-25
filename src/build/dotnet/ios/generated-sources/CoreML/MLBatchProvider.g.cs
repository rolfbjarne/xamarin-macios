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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreML {
	#pragma warning disable CS1573
	/// <summary>Interface defining the protocol for providing data in batches to the model.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MLBatchProvider", WrapperType = typeof (MLBatchProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFeatures", Selector = "featuresAtIndex:", ReturnType = typeof (IMLFeatureProvider), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Count", Selector = "count", PropertyType = typeof (IntPtr), GetterSelector = "count", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMLBatchProvider : INativeObject, IDisposable
	{
		/// <param name="index">To be added.</param><summary>Gets the <see cref="T:CoreML.IMLFeatureProvider" /> at <paramref name="index" /> for the current batch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("featuresAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMLFeatureProvider GetFeatures (nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="index">To be added.</param><summary>Gets the <see cref="T:CoreML.IMLFeatureProvider" /> at <paramref name="index" /> for the current batch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMLFeatureProvider _GetFeatures (IMLBatchProvider This, nint index)
		{
			IMLFeatureProvider ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("featuresAtIndex:"), index), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("Count")]
		[DynamicDependencyAttribute ("GetFeatures(System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLBatchProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMLBatchProvider ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The number of <see cref="T:CoreML.IMLFeatureProvider" /> objects in the current batch.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Count {
			[Export ("count")]
			get {
				return _GetCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetCount (IMLBatchProvider This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("count"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MLBatchProviderWrapper : BaseWrapper, IMLBatchProvider {
		public MLBatchProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLBatchProviderWrapper))]
		static MLBatchProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="index">To be added.</param><summary>Gets the <see cref="T:CoreML.IMLFeatureProvider" /> at <paramref name="index" /> for the current batch.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("featuresAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMLFeatureProvider GetFeatures (nint index)
		{
			IMLFeatureProvider ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("featuresAtIndex:"), index), false)!;
			return ret;
		}
		/// <summary>The number of <see cref="T:CoreML.IMLFeatureProvider" /> objects in the current batch.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Count {
			[Export ("count")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
				return ret;
			}
		}
	}
}
