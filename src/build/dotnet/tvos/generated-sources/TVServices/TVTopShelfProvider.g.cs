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
namespace TVServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVTopShelfProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "TVTopShelfProvider", WrapperType = typeof (TVTopShelfProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TopShelfStyle", Selector = "topShelfStyle", PropertyType = typeof (TVServices.TVTopShelfContentStyle), GetterSelector = "topShelfStyle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TopShelfItems", Selector = "topShelfItems", PropertyType = typeof (TVServices.TVContentItem[]), GetterSelector = "topShelfItems", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ITVTopShelfProvider : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("TopShelfItems")]
		[DynamicDependencyAttribute ("TopShelfStyle")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVTopShelfProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVTopShelfProvider ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TVTopShelfContentStyle TopShelfStyle {
			[Export ("topShelfStyle")]
			get {
				return _GetTopShelfStyle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TVTopShelfContentStyle _GetTopShelfStyle (ITVTopShelfProvider This)
		{
			TVTopShelfContentStyle ret;
			ret = (TVServices.TVTopShelfContentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("topShelfStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TVContentItem[] TopShelfItems {
			[Export ("topShelfItems")]
			get {
				return _GetTopShelfItems (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TVContentItem[] _GetTopShelfItems (ITVTopShelfProvider This)
		{
			TVContentItem[] ret;
			ret = CFArray.ArrayFromHandle<TVContentItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("topShelfItems")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVTopShelfProviderWrapper : BaseWrapper, ITVTopShelfProvider {
		public TVTopShelfProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVTopShelfProviderWrapper))]
		static TVTopShelfProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TVTopShelfContentStyle TopShelfStyle {
			[Export ("topShelfStyle")]
			get {
				TVTopShelfContentStyle ret;
				ret = (TVServices.TVTopShelfContentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("topShelfStyle"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TVContentItem[] TopShelfItems {
			[Export ("topShelfItems")]
			get {
				TVContentItem[] ret;
				ret = CFArray.ArrayFromHandle<TVContentItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topShelfItems")), false)!;
				return ret;
			}
		}
	}
}
