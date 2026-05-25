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
namespace TouchController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TCControlLayout</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios26.0")]
	[Protocol (Name = "TCControlLayout", WrapperType = typeof (TCControlLayoutWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Anchor", Selector = "anchor", PropertyType = typeof (TouchController.TCControlLayoutAnchor), GetterSelector = "anchor", SetterSelector = "setAnchor:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AnchorCoordinateSystem", Selector = "anchorCoordinateSystem", PropertyType = typeof (TouchController.TCControlLayoutAnchorCoordinateSystem), GetterSelector = "anchorCoordinateSystem", SetterSelector = "setAnchorCoordinateSystem:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Offset", Selector = "offset", PropertyType = typeof (CGPoint), GetterSelector = "offset", SetterSelector = "setOffset:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ZIndex", Selector = "zIndex", PropertyType = typeof (IntPtr), GetterSelector = "zIndex", SetterSelector = "setZIndex:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof (CGSize), GetterSelector = "size", SetterSelector = "setSize:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Position", Selector = "position", PropertyType = typeof (CGPoint), GetterSelector = "position", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface ITCControlLayout : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Anchor")]
		[DynamicDependencyAttribute ("AnchorCoordinateSystem")]
		[DynamicDependencyAttribute ("Offset")]
		[DynamicDependencyAttribute ("Position")]
		[DynamicDependencyAttribute ("Size")]
		[DynamicDependencyAttribute ("ZIndex")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TCControlLayoutWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITCControlLayout ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TCControlLayoutAnchor Anchor {
			[Export ("anchor", ArgumentSemantic.Assign)]
			get {
				return _GetAnchor (this);
			}
			[Export ("setAnchor:", ArgumentSemantic.Assign)]
			set {
				_SetAnchor (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TCControlLayoutAnchor _GetAnchor (ITCControlLayout This)
		{
			TCControlLayoutAnchor ret;
			ret = (TouchController.TCControlLayoutAnchor) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("anchor"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAnchor (ITCControlLayout This, TCControlLayoutAnchor value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAnchor:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TCControlLayoutAnchorCoordinateSystem AnchorCoordinateSystem {
			[Export ("anchorCoordinateSystem", ArgumentSemantic.Assign)]
			get {
				return _GetAnchorCoordinateSystem (this);
			}
			[Export ("setAnchorCoordinateSystem:", ArgumentSemantic.Assign)]
			set {
				_SetAnchorCoordinateSystem (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TCControlLayoutAnchorCoordinateSystem _GetAnchorCoordinateSystem (ITCControlLayout This)
		{
			TCControlLayoutAnchorCoordinateSystem ret;
			ret = (TouchController.TCControlLayoutAnchorCoordinateSystem) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("anchorCoordinateSystem"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAnchorCoordinateSystem (ITCControlLayout This, TCControlLayoutAnchorCoordinateSystem value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAnchorCoordinateSystem:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint Offset {
			[Export ("offset", ArgumentSemantic.Assign)]
			get {
				return _GetOffset (this);
			}
			[Export ("setOffset:", ArgumentSemantic.Assign)]
			set {
				_SetOffset (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetOffset (ITCControlLayout This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("offset"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOffset (ITCControlLayout This, CGPoint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setOffset:"), value);
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
		internal static nint _GetZIndex (ITCControlLayout This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("zIndex"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetZIndex (ITCControlLayout This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setZIndex:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize Size {
			[Export ("size", ArgumentSemantic.Assign)]
			get {
				return _GetSize (this);
			}
			[Export ("setSize:", ArgumentSemantic.Assign)]
			set {
				_SetSize (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetSize (ITCControlLayout This)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("size"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSize (ITCControlLayout This, CGSize value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("setSize:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint Position {
			[Export ("position", ArgumentSemantic.Assign)]
			get {
				return _GetPosition (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetPosition (ITCControlLayout This)
		{
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("position"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TCControlLayoutWrapper : BaseWrapper, ITCControlLayout {
		public TCControlLayoutWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TCControlLayoutWrapper))]
		static TCControlLayoutWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TCControlLayoutAnchor Anchor {
			[Export ("anchor", ArgumentSemantic.Assign)]
			get {
				TCControlLayoutAnchor ret;
				ret = (TouchController.TCControlLayoutAnchor) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchor"));
				return ret!;
			}
			[Export ("setAnchor:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchor:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TCControlLayoutAnchorCoordinateSystem AnchorCoordinateSystem {
			[Export ("anchorCoordinateSystem", ArgumentSemantic.Assign)]
			get {
				TCControlLayoutAnchorCoordinateSystem ret;
				ret = (TouchController.TCControlLayoutAnchorCoordinateSystem) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchorCoordinateSystem"));
				return ret!;
			}
			[Export ("setAnchorCoordinateSystem:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchorCoordinateSystem:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint Offset {
			[Export ("offset", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("offset"));
				return ret;
			}
			[Export ("setOffset:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setOffset:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint ZIndex {
			[Export ("zIndex")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("zIndex"));
				return ret;
			}
			[Export ("setZIndex:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setZIndex:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize Size {
			[Export ("size", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
				return ret;
			}
			[Export ("setSize:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setSize:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint Position {
			[Export ("position", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				return ret;
			}
		}
	}
}
