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
namespace Accessibility {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AXBrailleMapRenderer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.2")]
	[SupportedOSPlatform ("macos12.1")]
	[SupportedOSPlatform ("ios15.2")]
	[SupportedOSPlatform ("maccatalyst15.2")]
	[Protocol (Name = "AXBrailleMapRenderer", WrapperType = typeof (AXBrailleMapRendererWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityBrailleMapRenderRegion", Selector = "accessibilityBrailleMapRenderRegion", PropertyType = typeof (CGRect), GetterSelector = "accessibilityBrailleMapRenderRegion", SetterSelector = "setAccessibilityBrailleMapRenderRegion:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityBrailleMapRenderer", Selector = "accessibilityBrailleMapRenderer", PropertyType = typeof (global::System.Action<global::Accessibility.AXBrailleMap>), GetterSelector = "accessibilityBrailleMapRenderer", SetterSelector = "setAccessibilityBrailleMapRenderer:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V13) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity1V13))]
	public partial interface IAXBrailleMapRenderer : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AccessibilityBrailleMapRenderer")]
		[DynamicDependencyAttribute ("AccessibilityBrailleMapRenderRegion")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXBrailleMapRendererWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAXBrailleMapRenderer ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual CGRect AccessibilityBrailleMapRenderRegion {
			[Export ("accessibilityBrailleMapRenderRegion", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityBrailleMapRenderRegion (this);
			}
			[Export ("setAccessibilityBrailleMapRenderRegion:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityBrailleMapRenderRegion (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityBrailleMapRenderRegion (IAXBrailleMapRenderer This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderRegion"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderRegion"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityBrailleMapRenderRegion (IAXBrailleMapRenderer This, CGRect value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("setAccessibilityBrailleMapRenderRegion:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public unsafe virtual global::System.Action<AXBrailleMap> AccessibilityBrailleMapRenderer {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V13))]
			[Export ("accessibilityBrailleMapRenderer", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityBrailleMapRenderer (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]
			[Export ("setAccessibilityBrailleMapRenderer:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityBrailleMapRenderer (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V13))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<AXBrailleMap> _GetAccessibilityBrailleMapRenderer (IAXBrailleMapRenderer This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderer"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity1V13.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetAccessibilityBrailleMapRenderer (IAXBrailleMapRenderer This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<AXBrailleMap> value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var block_value = Trampolines.SDActionArity1V13.CreateBlock (value);
			BlockLiteral *block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityBrailleMapRenderer:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAXBrailleMapRenderer" /> interface to support all the methods from the AXBrailleMapRenderer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAXBrailleMapRenderer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AXBrailleMapRenderer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AXBrailleMapRenderer_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetAccessibilityBrailleMapRenderRegion (this IAXBrailleMapRenderer This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderRegion"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderRegion"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityBrailleMapRenderRegion (this IAXBrailleMapRenderer This, CGRect value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("setAccessibilityBrailleMapRenderRegion:"), value);
			GC.KeepAlive (This);
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V13))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static global::System.Action<AXBrailleMap> GetAccessibilityBrailleMapRenderer (this IAXBrailleMapRenderer This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityBrailleMapRenderer"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity1V13.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetAccessibilityBrailleMapRenderer (this IAXBrailleMapRenderer This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<AXBrailleMap> value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var block_value = Trampolines.SDActionArity1V13.CreateBlock (value);
			BlockLiteral *block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityBrailleMapRenderer:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AXBrailleMapRendererWrapper : BaseWrapper, IAXBrailleMapRenderer {
		public AXBrailleMapRendererWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXBrailleMapRendererWrapper))]
		static AXBrailleMapRendererWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
