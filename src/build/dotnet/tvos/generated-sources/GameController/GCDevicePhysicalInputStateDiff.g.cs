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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCDevicePhysicalInputStateDiff</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCDevicePhysicalInputStateDiff", WrapperType = typeof (GCDevicePhysicalInputStateDiffWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetChange", Selector = "changeForElement:", ReturnType = typeof (GameController.GCDevicePhysicalInputElementChange), ParameterType = new Type [] { typeof (GameController.IGCPhysicalInputElement) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ChangedElements", Selector = "changedElements", PropertyType = typeof (global::Foundation.NSEnumerator<global::GameController.IGCPhysicalInputElement>), GetterSelector = "changedElements", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IGCDevicePhysicalInputStateDiff : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("changeForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCDevicePhysicalInputElementChange GetChange (IGCPhysicalInputElement element)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static GCDevicePhysicalInputElementChange _GetChange (IGCDevicePhysicalInputStateDiff This, IGCPhysicalInputElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			GCDevicePhysicalInputElementChange ret;
			ret = (GameController.GCDevicePhysicalInputElementChange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("changeForElement:"), element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		[DynamicDependencyAttribute ("ChangedElements")]
		[DynamicDependencyAttribute ("GetChange(GameController.IGCPhysicalInputElement)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputStateDiffWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCDevicePhysicalInputStateDiff ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSEnumerator<IGCPhysicalInputElement>? ChangedElements {
			[Export ("changedElements")]
			get {
				return _GetChangedElements (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSEnumerator<IGCPhysicalInputElement> _GetChangedElements (IGCDevicePhysicalInputStateDiff This)
		{
			NSEnumerator<IGCPhysicalInputElement> ret;
			ret =  Runtime.GetNSObject<NSEnumerator<IGCPhysicalInputElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("changedElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCDevicePhysicalInputStateDiffWrapper : BaseWrapper, IGCDevicePhysicalInputStateDiff {
		public GCDevicePhysicalInputStateDiffWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputStateDiffWrapper))]
		static GCDevicePhysicalInputStateDiffWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("changeForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GCDevicePhysicalInputElementChange GetChange (IGCPhysicalInputElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			GCDevicePhysicalInputElementChange ret;
			ret = (GameController.GCDevicePhysicalInputElementChange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("changeForElement:"), element__handle__);
			GC.KeepAlive (element);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSEnumerator<IGCPhysicalInputElement>? ChangedElements {
			[Export ("changedElements")]
			get {
				NSEnumerator<IGCPhysicalInputElement> ret;
				ret =  Runtime.GetNSObject<NSEnumerator<IGCPhysicalInputElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("changedElements")), false)!;
				return ret;
			}
		}
	}
}
