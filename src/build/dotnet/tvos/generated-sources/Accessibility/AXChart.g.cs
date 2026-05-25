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
namespace Accessibility {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AXChart</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AXChart", WrapperType = typeof (AXChartWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChartDescriptor", Selector = "accessibilityChartDescriptor", PropertyType = typeof (Accessibility.AXChartDescriptor), GetterSelector = "accessibilityChartDescriptor", SetterSelector = "setAccessibilityChartDescriptor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IAXChart : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AccessibilityChartDescriptor")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXChartWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAXChart ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual AXChartDescriptor? AccessibilityChartDescriptor {
			[Export ("accessibilityChartDescriptor", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityChartDescriptor (this);
			}
			[Export ("setAccessibilityChartDescriptor:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityChartDescriptor (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AXChartDescriptor _GetAccessibilityChartDescriptor (IAXChart This)
		{
			AXChartDescriptor ret;
			ret =  Runtime.GetNSObject<AXChartDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityChartDescriptor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityChartDescriptor (IAXChart This, AXChartDescriptor? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityChartDescriptor:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AXChartWrapper : BaseWrapper, IAXChart {
		public AXChartWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXChartWrapper))]
		static AXChartWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXChartDescriptor? AccessibilityChartDescriptor {
			[Export ("accessibilityChartDescriptor", ArgumentSemantic.Retain)]
			get {
				AXChartDescriptor ret;
				ret =  Runtime.GetNSObject<AXChartDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityChartDescriptor")), false)!;
				return ret;
			}
			[Export ("setAccessibilityChartDescriptor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityChartDescriptor:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
