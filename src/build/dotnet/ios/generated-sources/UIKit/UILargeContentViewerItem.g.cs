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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UILargeContentViewerItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UILargeContentViewerItem", WrapperType = typeof (UILargeContentViewerItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShowsLargeContentViewer", Selector = "showsLargeContentViewer", PropertyType = typeof (bool), GetterSelector = "showsLargeContentViewer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LargeContentTitle", Selector = "largeContentTitle", PropertyType = typeof (string), GetterSelector = "largeContentTitle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LargeContentImage", Selector = "largeContentImage", PropertyType = typeof (UIImage), GetterSelector = "largeContentImage", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ScalesLargeContentImage", Selector = "scalesLargeContentImage", PropertyType = typeof (bool), GetterSelector = "scalesLargeContentImage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LargeContentImageInsets", Selector = "largeContentImageInsets", PropertyType = typeof (UIEdgeInsets), GetterSelector = "largeContentImageInsets", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IUILargeContentViewerItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("LargeContentImage")]
		[DynamicDependencyAttribute ("LargeContentImageInsets")]
		[DynamicDependencyAttribute ("LargeContentTitle")]
		[DynamicDependencyAttribute ("ScalesLargeContentImage")]
		[DynamicDependencyAttribute ("ShowsLargeContentViewer")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILargeContentViewerItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUILargeContentViewerItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ShowsLargeContentViewer {
			[Export ("showsLargeContentViewer")]
			get {
				return _GetShowsLargeContentViewer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetShowsLargeContentViewer (IUILargeContentViewerItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showsLargeContentViewer"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? LargeContentTitle {
			[Export ("largeContentTitle")]
			get {
				return _GetLargeContentTitle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLargeContentTitle (IUILargeContentViewerItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("largeContentTitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIImage? LargeContentImage {
			[Export ("largeContentImage", ArgumentSemantic.Retain)]
			get {
				return _GetLargeContentImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage _GetLargeContentImage (IUILargeContentViewerItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("largeContentImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ScalesLargeContentImage {
			[Export ("scalesLargeContentImage")]
			get {
				return _GetScalesLargeContentImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetScalesLargeContentImage (IUILargeContentViewerItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("scalesLargeContentImage"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIEdgeInsets LargeContentImageInsets {
			[Export ("largeContentImageInsets", ArgumentSemantic.Assign)]
			get {
				return _GetLargeContentImageInsets (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIEdgeInsets _GetLargeContentImageInsets (IUILargeContentViewerItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (This.Handle, Selector.GetHandle ("largeContentImageInsets"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (This.Handle, Selector.GetHandle ("largeContentImageInsets"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UILargeContentViewerItemWrapper : BaseWrapper, IUILargeContentViewerItem {
		public UILargeContentViewerItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILargeContentViewerItemWrapper))]
		static UILargeContentViewerItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShowsLargeContentViewer {
			[Export ("showsLargeContentViewer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsLargeContentViewer"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? LargeContentTitle {
			[Export ("largeContentTitle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("largeContentTitle")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIImage? LargeContentImage {
			[Export ("largeContentImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("largeContentImage")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ScalesLargeContentImage {
			[Export ("scalesLargeContentImage")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("scalesLargeContentImage"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIEdgeInsets LargeContentImageInsets {
			[Export ("largeContentImageInsets", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("largeContentImageInsets"));
				} else {
					ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("largeContentImageInsets"));
				}
				return ret!;
			}
		}
	}
}
