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
namespace BrowserEngineKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BETextSelectionDirectionNavigation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BETextSelectionDirectionNavigation", WrapperType = typeof (BETextSelectionDirectionNavigationWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MoveInLayoutDirection", Selector = "moveInLayoutDirection:", ParameterType = new Type [] { typeof (UITextLayoutDirection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendInLayoutDirection", Selector = "extendInLayoutDirection:", ParameterType = new Type [] { typeof (UITextLayoutDirection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MoveInStorageDirection", Selector = "moveInStorageDirection:byGranularity:", ParameterType = new Type [] { typeof (UITextStorageDirection), typeof (UITextGranularity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendInStorageDirection", Selector = "extendInStorageDirection:byGranularity:", ParameterType = new Type [] { typeof (UITextStorageDirection), typeof (UITextGranularity) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IBETextSelectionDirectionNavigation : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("moveInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MoveInLayoutDirection (IBETextSelectionDirectionNavigation This, global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("moveInLayoutDirection:"), (IntPtr) (long) direction);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExtendInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExtendInLayoutDirection (IBETextSelectionDirectionNavigation This, global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("extendInLayoutDirection:"), (IntPtr) (long) direction);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("moveInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MoveInStorageDirection (IBETextSelectionDirectionNavigation This, global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("moveInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExtendInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ExtendInStorageDirection (IBETextSelectionDirectionNavigation This, global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("extendInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ExtendInLayoutDirection(UIKit.UITextLayoutDirection)")]
		[DynamicDependencyAttribute ("ExtendInStorageDirection(UIKit.UITextStorageDirection,UIKit.UITextGranularity)")]
		[DynamicDependencyAttribute ("MoveInLayoutDirection(UIKit.UITextLayoutDirection)")]
		[DynamicDependencyAttribute ("MoveInStorageDirection(UIKit.UITextStorageDirection,UIKit.UITextGranularity)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextSelectionDirectionNavigationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBETextSelectionDirectionNavigation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BETextSelectionDirectionNavigationWrapper : BaseWrapper, IBETextSelectionDirectionNavigation {
		public BETextSelectionDirectionNavigationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextSelectionDirectionNavigationWrapper))]
		static BETextSelectionDirectionNavigationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("moveInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MoveInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("moveInLayoutDirection:"), (IntPtr) (long) direction);
		}
		[Export ("extendInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExtendInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("extendInLayoutDirection:"), (IntPtr) (long) direction);
		}
		[Export ("moveInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MoveInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("moveInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
		}
		[Export ("extendInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExtendInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("extendInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
		}
	}
}
