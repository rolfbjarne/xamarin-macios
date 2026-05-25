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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionLayoutVisibleItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSCollectionLayoutVisibleItem", WrapperType = typeof (NSCollectionLayoutVisibleItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Alpha", Selector = "alpha", PropertyType = typeof (NFloat), GetterSelector = "alpha", SetterSelector = "setAlpha:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ZIndex", Selector = "zIndex", PropertyType = typeof (IntPtr), GetterSelector = "zIndex", SetterSelector = "setZIndex:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Hidden", Selector = "hidden", PropertyType = typeof (bool), GetterSelector = "isHidden", SetterSelector = "setHidden:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Center", Selector = "center", PropertyType = typeof (CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Bounds", Selector = "bounds", PropertyType = typeof (CGRect), GetterSelector = "bounds", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IndexPath", Selector = "indexPath", PropertyType = typeof (NSIndexPath), GetterSelector = "indexPath", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Frame", Selector = "frame", PropertyType = typeof (CGRect), GetterSelector = "frame", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepresentedElementCategory", Selector = "representedElementCategory", PropertyType = typeof (NSCollectionElementCategory), GetterSelector = "representedElementCategory", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepresentedElementKind", Selector = "representedElementKind", PropertyType = typeof (string), GetterSelector = "representedElementKind", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSCollectionLayoutVisibleItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Alpha")]
		[DynamicDependencyAttribute ("Bounds")]
		[DynamicDependencyAttribute ("Center")]
		[DynamicDependencyAttribute ("Frame")]
		[DynamicDependencyAttribute ("Hidden")]
		[DynamicDependencyAttribute ("IndexPath")]
		[DynamicDependencyAttribute ("Name")]
		[DynamicDependencyAttribute ("RepresentedElementCategory")]
		[DynamicDependencyAttribute ("RepresentedElementKind")]
		[DynamicDependencyAttribute ("ZIndex")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutVisibleItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionLayoutVisibleItem ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat Alpha {
			[Export ("alpha")]
			get {
				return _GetAlpha (this);
			}
			[Export ("setAlpha:")]
			set {
				_SetAlpha (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetAlpha (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("alpha"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAlpha (INSCollectionLayoutVisibleItem This, nfloat value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setAlpha:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint ZIndex {
			[Export ("zIndex")]
			get {
				return _GetZIndex (this);
			}
			[Export ("setZIndex:")]
			set {
				_SetZIndex (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetZIndex (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("zIndex"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetZIndex (INSCollectionLayoutVisibleItem This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setZIndex:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				return _GetHidden (this);
			}
			[Export ("setHidden:")]
			set {
				_SetHidden (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHidden (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isHidden"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetHidden (INSCollectionLayoutVisibleItem This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual CGPoint Center {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				return _GetCenter (this);
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				_SetCenter (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetCenter (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("center"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenter (INSCollectionLayoutVisibleItem This, CGPoint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setCenter:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				return _GetBounds (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetBounds (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Name {
			[Export ("name")]
			get {
				return _GetName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetName (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("name")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSIndexPath IndexPath {
			[Export ("indexPath")]
			get {
				return _GetIndexPath (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetIndexPath (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSIndexPath ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("indexPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				return _GetFrame (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrame (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("frame"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("frame"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSCollectionElementCategory RepresentedElementCategory {
			[Export ("representedElementCategory")]
			get {
				return _GetRepresentedElementCategory (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCollectionElementCategory _GetRepresentedElementCategory (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCollectionElementCategory ret;
			ret = (NSCollectionElementCategory) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("representedElementCategory"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? RepresentedElementKind {
			[Export ("representedElementKind")]
			get {
				return _GetRepresentedElementKind (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetRepresentedElementKind (INSCollectionLayoutVisibleItem This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("representedElementKind")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionLayoutVisibleItemWrapper : BaseWrapper, INSCollectionLayoutVisibleItem {
		public NSCollectionLayoutVisibleItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionLayoutVisibleItemWrapper))]
		static NSCollectionLayoutVisibleItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat Alpha {
			[Export ("alpha")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				return ret;
			}
			[Export ("setAlpha:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint ZIndex {
			[Export ("zIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("zIndex"));
				return ret;
			}
			[Export ("setZIndex:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setZIndex:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Hidden {
			[Export ("isHidden")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public CGPoint Center {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("center"));
				return ret;
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setCenter:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public CGRect Bounds {
			[Export ("bounds")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Name {
			[Export ("name")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath IndexPath {
			[Export ("indexPath")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSIndexPath ret;
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("indexPath")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect Frame {
			[Export ("frame")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("frame"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCollectionElementCategory RepresentedElementCategory {
			[Export ("representedElementCategory")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionElementCategory ret;
				ret = (NSCollectionElementCategory) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("representedElementCategory"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? RepresentedElementKind {
			[Export ("representedElementKind")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("representedElementKind")), false)!;
				return ret;
			}
		}
	}
}
