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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace PencilKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKToolPickerObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "PKToolPickerObserver", WrapperType = typeof (PKToolPickerObserverWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectedToolDidChange", Selector = "toolPickerSelectedToolDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKToolPicker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsRulerActiveDidChange", Selector = "toolPickerIsRulerActiveDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKToolPicker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisibilityDidChange", Selector = "toolPickerVisibilityDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKToolPicker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FramesObscuredDidChange", Selector = "toolPickerFramesObscuredDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKToolPicker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectedToolItemDidChange", Selector = "toolPickerSelectedToolItemDidChange:", ParameterType = new Type [] { typeof (PencilKit.PKToolPicker) }, ParameterByRef = new bool [] { false })]
	public partial interface IPKToolPickerObserver : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("toolPickerSelectedToolDidChange:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedToolDidChange (PKToolPicker toolPicker)
		{
			_SelectedToolDidChange (this, toolPicker);
		}
		[ObsoletedOSPlatform ("ios18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectedToolDidChange (IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerSelectedToolDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[global::Foundation.OptionalMember]
		[Export ("toolPickerIsRulerActiveDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IsRulerActiveDidChange (PKToolPicker toolPicker)
		{
			_IsRulerActiveDidChange (this, toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _IsRulerActiveDidChange (IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerIsRulerActiveDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[global::Foundation.OptionalMember]
		[Export ("toolPickerVisibilityDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void VisibilityDidChange (PKToolPicker toolPicker)
		{
			_VisibilityDidChange (this, toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _VisibilityDidChange (IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerVisibilityDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[global::Foundation.OptionalMember]
		[Export ("toolPickerFramesObscuredDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FramesObscuredDidChange (PKToolPicker toolPicker)
		{
			_FramesObscuredDidChange (this, toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FramesObscuredDidChange (IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerFramesObscuredDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[global::Foundation.OptionalMember]
		[Export ("toolPickerSelectedToolItemDidChange:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedToolItemDidChange (PKToolPicker toolPicker)
		{
			_SelectedToolItemDidChange (this, toolPicker);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectedToolItemDidChange (IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerSelectedToolItemDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[DynamicDependencyAttribute ("FramesObscuredDidChange(PencilKit.PKToolPicker)")]
		[DynamicDependencyAttribute ("IsRulerActiveDidChange(PencilKit.PKToolPicker)")]
		[DynamicDependencyAttribute ("SelectedToolDidChange(PencilKit.PKToolPicker)")]
		[DynamicDependencyAttribute ("SelectedToolItemDidChange(PencilKit.PKToolPicker)")]
		[DynamicDependencyAttribute ("VisibilityDidChange(PencilKit.PKToolPicker)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKToolPickerObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKToolPickerObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKToolPickerObserver" /> interface to support all the methods from the PKToolPickerObserver protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKToolPickerObserver" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKToolPickerObserver protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKToolPickerObserver_Extensions {
		[ObsoletedOSPlatform ("ios18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'SelectedToolItemDidChange' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectedToolDidChange (this IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerSelectedToolDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IsRulerActiveDidChange (this IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerIsRulerActiveDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void VisibilityDidChange (this IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerVisibilityDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FramesObscuredDidChange (this IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerFramesObscuredDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectedToolItemDidChange (this IPKToolPickerObserver This, PKToolPicker toolPicker)
		{
			var toolPicker__handle__ = toolPicker!.GetNonNullHandle (nameof (toolPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("toolPickerSelectedToolItemDidChange:"), toolPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (toolPicker);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKToolPickerObserverWrapper : BaseWrapper, IPKToolPickerObserver {
		public PKToolPickerObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKToolPickerObserverWrapper))]
		static PKToolPickerObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
