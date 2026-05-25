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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionLayoutEnvironment</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSCollectionLayoutEnvironment", WrapperType = typeof (NSCollectionLayoutEnvironmentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Container", Selector = "container", PropertyType = typeof (INSCollectionLayoutContainer), GetterSelector = "container", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSCollectionLayoutEnvironment : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Container")]
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
			global::AppKit.NSApplication.EnsureUIThread ();
			INSCollectionLayoutContainer ret;
			ret =  Runtime.GetINativeObject<INSCollectionLayoutContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("container")), false)!;
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
				global::AppKit.NSApplication.EnsureUIThread ();
				INSCollectionLayoutContainer ret;
				ret =  Runtime.GetINativeObject<INSCollectionLayoutContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("container")), false)!;
				return ret;
			}
		}
	}
}
