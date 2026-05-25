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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionLayoutContainer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSCollectionLayoutContainer", WrapperType = typeof (NSCollectionLayoutContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentSize", Selector = "contentSize", PropertyType = typeof (CGSize), GetterSelector = "contentSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "EffectiveContentSize", Selector = "effectiveContentSize", PropertyType = typeof (CGSize), GetterSelector = "effectiveContentSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentInsets", Selector = "contentInsets", PropertyType = typeof (NSDirectionalEdgeInsets), GetterSelector = "contentInsets", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "EffectiveContentInsets", Selector = "effectiveContentInsets", PropertyType = typeof (NSDirectionalEdgeInsets), GetterSelector = "effectiveContentInsets", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSCollectionLayoutContainer : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ContentInsets")]
		[DynamicDependencyAttribute ("ContentSize")]
		[DynamicDependencyAttribute ("EffectiveContentInsets")]
		[DynamicDependencyAttribute ("EffectiveContentSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionLayoutContainer ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize ContentSize {
			[Export ("contentSize")]
			get {
				return _GetContentSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetContentSize (INSCollectionLayoutContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("contentSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize EffectiveContentSize {
			[Export ("effectiveContentSize")]
			get {
				return _GetEffectiveContentSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetEffectiveContentSize (INSCollectionLayoutContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("effectiveContentSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDirectionalEdgeInsets ContentInsets {
			[Export ("contentInsets")]
			get {
				return _GetContentInsets (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDirectionalEdgeInsets _GetContentInsets (INSCollectionLayoutContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDirectionalEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (This.Handle, Selector.GetHandle ("contentInsets"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (This.Handle, Selector.GetHandle ("contentInsets"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDirectionalEdgeInsets EffectiveContentInsets {
			[Export ("effectiveContentInsets")]
			get {
				return _GetEffectiveContentInsets (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDirectionalEdgeInsets _GetEffectiveContentInsets (INSCollectionLayoutContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDirectionalEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (This.Handle, Selector.GetHandle ("effectiveContentInsets"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (This.Handle, Selector.GetHandle ("effectiveContentInsets"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionLayoutContainerWrapper : BaseWrapper, INSCollectionLayoutContainer {
		public NSCollectionLayoutContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutContainerWrapper))]
		static NSCollectionLayoutContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize ContentSize {
			[Export ("contentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("contentSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize EffectiveContentSize {
			[Export ("effectiveContentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("effectiveContentSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDirectionalEdgeInsets ContentInsets {
			[Export ("contentInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDirectionalEdgeInsets ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("contentInsets"));
				} else {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("contentInsets"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDirectionalEdgeInsets EffectiveContentInsets {
			[Export ("effectiveContentInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDirectionalEdgeInsets ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("effectiveContentInsets"));
				} else {
					ret = global::ObjCRuntime.Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("effectiveContentInsets"));
				}
				return ret!;
			}
		}
	}
}
