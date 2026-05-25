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
	/// <summary>This interface represents the Objective-C protocol <c>TCControl</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios26.0")]
	[Protocol (Name = "TCControl", WrapperType = typeof (TCControlWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleTouchBegan", Selector = "handleTouchBeganAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleTouchMoved", Selector = "handleTouchMovedAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleTouchEnded", Selector = "handleTouchEndedAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (TouchController.TCControlLabel), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColliderShape", Selector = "colliderShape", PropertyType = typeof (TouchController.TCColliderShape), GetterSelector = "colliderShape", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Pressed", Selector = "pressed", PropertyType = typeof (bool), GetterSelector = "isPressed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Enabled", Selector = "enabled", PropertyType = typeof (bool), GetterSelector = "isEnabled", SetterSelector = "setEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HighlightDuration", Selector = "highlightDuration", PropertyType = typeof (double), GetterSelector = "highlightDuration", SetterSelector = "setHighlightDuration:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ITCControl : INativeObject, IDisposable, 
		TouchController.ITCControlLayout
	{
		[global::Foundation.RequiredMember]
		[Export ("handleTouchBeganAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTouchBegan (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleTouchBegan (ITCControl This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("handleTouchBeganAtPoint:"), point);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("handleTouchMovedAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTouchMoved (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleTouchMoved (ITCControl This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("handleTouchMovedAtPoint:"), point);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("handleTouchEndedAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTouchEnded (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleTouchEnded (ITCControl This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("handleTouchEndedAtPoint:"), point);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ColliderShape")]
		[DynamicDependencyAttribute ("Enabled")]
		[DynamicDependencyAttribute ("HandleTouchBegan(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("HandleTouchEnded(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("HandleTouchMoved(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("HighlightDuration")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Pressed")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TCControlWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITCControl ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TCControlLabel Label {
			[Export ("label", ArgumentSemantic.Retain)]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TCControlLabel _GetLabel (ITCControl This)
		{
			TCControlLabel ret;
			ret =  Runtime.GetNSObject<TCControlLabel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TCColliderShape ColliderShape {
			[Export ("colliderShape", ArgumentSemantic.Assign)]
			get {
				return _GetColliderShape (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TCColliderShape _GetColliderShape (ITCControl This)
		{
			TCColliderShape ret;
			ret = (TouchController.TCColliderShape) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("colliderShape"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Pressed {
			[Export ("isPressed")]
			get {
				return _GetPressed (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetPressed (ITCControl This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPressed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				return _GetEnabled (this);
			}
			[Export ("setEnabled:")]
			set {
				_SetEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEnabled (ITCControl This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetEnabled (ITCControl This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual double HighlightDuration {
			[Export ("highlightDuration")]
			get {
				return _GetHighlightDuration (this);
			}
			[Export ("setHighlightDuration:")]
			set {
				_SetHighlightDuration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetHighlightDuration (ITCControl This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("highlightDuration"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetHighlightDuration (ITCControl This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setHighlightDuration:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TCControlWrapper : BaseWrapper, ITCControl {
		public TCControlWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TCControlWrapper))]
		static TCControlWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleTouchBeganAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleTouchBegan (CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("handleTouchBeganAtPoint:"), point);
		}
		[Export ("handleTouchMovedAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleTouchMoved (CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("handleTouchMovedAtPoint:"), point);
		}
		[Export ("handleTouchEndedAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleTouchEnded (CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("handleTouchEndedAtPoint:"), point);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TCControlLabel Label {
			[Export ("label", ArgumentSemantic.Retain)]
			get {
				TCControlLabel ret;
				ret =  Runtime.GetNSObject<TCControlLabel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TCColliderShape ColliderShape {
			[Export ("colliderShape", ArgumentSemantic.Assign)]
			get {
				TCColliderShape ret;
				ret = (TouchController.TCColliderShape) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colliderShape"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Pressed {
			[Export ("isPressed")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPressed"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public TCControlLayoutAnchor Anchor {
			[Export ("anchor", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				TCControlLayoutAnchor ret;
				ret = (TouchController.TCControlLayoutAnchor) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchor"));
				return ret!;
			}
			[Export ("setAnchor:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchor:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public TCControlLayoutAnchorCoordinateSystem AnchorCoordinateSystem {
			[Export ("anchorCoordinateSystem", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				TCControlLayoutAnchorCoordinateSystem ret;
				ret = (TouchController.TCControlLayoutAnchorCoordinateSystem) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("anchorCoordinateSystem"));
				return ret!;
			}
			[Export ("setAnchorCoordinateSystem:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAnchorCoordinateSystem:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public CGPoint Offset {
			[Export ("offset", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("offset"));
				return ret;
			}
			[Export ("setOffset:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setOffset:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public nint ZIndex {
			[Export ("zIndex")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("zIndex"));
				return ret;
			}
			[Export ("setZIndex:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setZIndex:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public CGSize Size {
			[Export ("size", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
				return ret;
			}
			[Export ("setSize:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setSize:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios26.0")]
		public CGPoint Position {
			[Export ("position", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				return ret;
			}
		}
	}
}
