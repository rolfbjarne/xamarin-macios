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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionLayoutEnvironment</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSCollectionLayoutEnvironment", WrapperType = typeof (NSCollectionLayoutEnvironmentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Container", Selector = "container", PropertyType = typeof (INSCollectionLayoutContainer), GetterSelector = "container", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TraitCollection", Selector = "traitCollection", PropertyType = typeof (UITraitCollection), GetterSelector = "traitCollection", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSCollectionLayoutEnvironment : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Container")]
		[DynamicDependencyAttribute ("TraitCollection")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutEnvironmentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionLayoutEnvironment ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual INSCollectionLayoutContainer Container {
			[Export ("container")]
			get {
				return _GetContainer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSCollectionLayoutContainer _GetContainer (INSCollectionLayoutEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			INSCollectionLayoutContainer ret;
			ret =  Runtime.GetINativeObject<INSCollectionLayoutContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("container")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[global::Foundation.RequiredMember]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			get {
				return _GetTraitCollection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitCollection _GetTraitCollection (INSCollectionLayoutEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("traitCollection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionLayoutEnvironmentWrapper : BaseWrapper, INSCollectionLayoutEnvironment {
		public NSCollectionLayoutEnvironmentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutEnvironmentWrapper))]
		static NSCollectionLayoutEnvironmentWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSCollectionLayoutContainer Container {
			[Export ("container")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				INSCollectionLayoutContainer ret;
				ret =  Runtime.GetINativeObject<INSCollectionLayoutContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("container")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		public UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection ret;
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitCollection")), false)!;
				return ret;
			}
		}
	}
}
