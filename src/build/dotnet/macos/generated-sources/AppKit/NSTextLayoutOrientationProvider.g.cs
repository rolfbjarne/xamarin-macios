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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextLayoutOrientationProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextLayoutOrientationProvider", WrapperType = typeof (NSTextLayoutOrientationProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LayoutOrientation", Selector = "layoutOrientation", PropertyType = typeof (NSTextLayoutOrientation), GetterSelector = "layoutOrientation", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextLayoutOrientationProvider : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("LayoutOrientation")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLayoutOrientationProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextLayoutOrientationProvider ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSTextLayoutOrientation LayoutOrientation {
			[Export ("layoutOrientation")]
			get {
				return _GetLayoutOrientation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextLayoutOrientation _GetLayoutOrientation (INSTextLayoutOrientationProvider This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextLayoutOrientation ret;
			ret = (NSTextLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("layoutOrientation"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextLayoutOrientationProviderWrapper : BaseWrapper, INSTextLayoutOrientationProvider {
		public NSTextLayoutOrientationProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLayoutOrientationProviderWrapper))]
		static NSTextLayoutOrientationProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextLayoutOrientation LayoutOrientation {
			[Export ("layoutOrientation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutOrientation ret;
				ret = (NSTextLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layoutOrientation"));
				return ret!;
			}
		}
	}
}
