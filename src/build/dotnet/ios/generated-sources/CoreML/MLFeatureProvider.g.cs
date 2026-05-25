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
	/// <summary>An interface that defines input or output features and allows access to their values.</summary><remarks><para>CoreML does not directly read and write system-native data. Rather it uses this class to map strings to values for the inputs and outputs of the <see cref="T:CoreML.MLModel" /> object.</para><para>The following example shows a <see cref="T:CoreML.IMLFeatureProvider" /> that provides 3 inputs variables, all of type <see langword="double" />:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public class MarsHabitatPricerInput : NSObject, IMLFeatureProvider
	/// {
	/// 	public double SolarPanels { get; set; }
	/// 	public double Greenhouses { get; set; }
	/// 	public double Size { get; set; }
	/// 
	/// 	public NSSet<NSString> FeatureNames => new NSSet<NSString>(new NSString("solarPanels"), new NSString("greenhouses"), new NSString("size"));
	/// 
	/// 	public MLFeatureValue GetFeatureValue(string featureName)
	/// 	{
	/// 		switch (featureName)
	/// 		{
	/// 			case "solarPanels":
	/// 				return MLFeatureValue.Create(SolarPanels);
	/// 			case "greenhouses":
	/// 				return MLFeatureValue.Create(Greenhouses);
	/// 			case "size":
	/// 				return MLFeatureValue.Create(Size);
	/// 			default:
	/// 				return MLFeatureValue.Create(0);
	/// 		}
	/// 	}
	/// }
	/// ]]></code></example></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MLFeatureProvider", WrapperType = typeof (MLFeatureProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFeatureValue", Selector = "featureValueForName:", ReturnType = typeof (MLFeatureValue), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FeatureNames", Selector = "featureNames", PropertyType = typeof (global::Foundation.NSSet<NSString>), GetterSelector = "featureNames", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMLFeatureProvider : INativeObject, IDisposable
	{
		/// <param name="featureName">The feature whose value will be returned.</param><summary>Retrieves the value of the <paramref name="featureName" />.</summary><returns>The value of the <paramref name="featureName" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("featureValueForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MLFeatureValue? GetFeatureValue (string featureName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="featureName">The feature whose value will be returned.</param><summary>Retrieves the value of the <paramref name="featureName" />.</summary><returns>The value of the <paramref name="featureName" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MLFeatureValue? _GetFeatureValue (IMLFeatureProvider This, string featureName)
		{
			if (featureName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (featureName));
			var nsfeatureName = CFString.CreateNative (featureName);
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("featureValueForName:"), nsfeatureName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfeatureName);
			return ret!;
		}
		[DynamicDependencyAttribute ("FeatureNames")]
		[DynamicDependencyAttribute ("GetFeatureValue(System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLFeatureProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMLFeatureProvider ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The names of the feature, as defined by the <see cref="T:CoreML.MLModel" />.</summary><value>The <see cref="T:Foundation.NSSet" /> of feature names.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSSet<NSString> FeatureNames {
			[Export ("featureNames")]
			get {
				return _GetFeatureNames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSet<NSString> _GetFeatureNames (IMLFeatureProvider This)
		{
			NSSet<NSString> ret;
			ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("featureNames")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MLFeatureProviderWrapper : BaseWrapper, IMLFeatureProvider {
		public MLFeatureProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLFeatureProviderWrapper))]
		static MLFeatureProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="featureName">The feature whose value will be returned.</param><summary>Retrieves the value of the <paramref name="featureName" />.</summary><returns>The value of the <paramref name="featureName" />.</returns><remarks>To be added.</remarks>
		[Export ("featureValueForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MLFeatureValue? GetFeatureValue (string featureName)
		{
			if (featureName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (featureName));
			var nsfeatureName = CFString.CreateNative (featureName);
			MLFeatureValue? ret;
			ret =  Runtime.GetNSObject<MLFeatureValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("featureValueForName:"), nsfeatureName), false)!;
			CFString.ReleaseNative (nsfeatureName);
			return ret!;
		}
		/// <summary>The names of the feature, as defined by the <see cref="T:CoreML.MLModel" />.</summary><value>The <see cref="T:Foundation.NSSet" /> of feature names.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSet<NSString> FeatureNames {
			[Export ("featureNames")]
			get {
				NSSet<NSString> ret;
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("featureNames")), false)!;
				return ret;
			}
		}
	}
}
