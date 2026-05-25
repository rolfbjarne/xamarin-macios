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
namespace Accessibility {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AXCustomContentProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AXCustomContentProvider", WrapperType = typeof (AXCustomContentProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomContent", Selector = "accessibilityCustomContent", PropertyType = typeof (Accessibility.AXCustomContent[]), GetterSelector = "accessibilityCustomContent", SetterSelector = "setAccessibilityCustomContent:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomContentHandler", Selector = "accessibilityCustomContentBlock", PropertyType = typeof (global::System.Func<global::Accessibility.AXCustomContent[]>), GetterSelector = "accessibilityCustomContentBlock", SetterSelector = "setAccessibilityCustomContentBlock:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDFuncArity1V0))]
	public partial interface IAXCustomContentProvider : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AccessibilityCustomContent")]
		[DynamicDependencyAttribute ("AccessibilityCustomContentHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXCustomContentProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAXCustomContentProvider ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual AXCustomContent[]? AccessibilityCustomContent {
			[Export ("accessibilityCustomContent", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityCustomContent (this);
			}
			[Export ("setAccessibilityCustomContent:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityCustomContent (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AXCustomContent[] _GetAccessibilityCustomContent (IAXCustomContentProvider This)
		{
			AXCustomContent[] ret;
			ret = CFArray.ArrayFromHandle<AXCustomContent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomContent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCustomContent (IAXCustomContentProvider This, AXCustomContent[]? value)
		{
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomContent:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.OptionalMember]
		public unsafe virtual global::System.Func<AXCustomContent[]>? AccessibilityCustomContentHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDFuncArity1V0))]
			[Export ("accessibilityCustomContentBlock", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityCustomContentHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0))]
			[Export ("setAccessibilityCustomContentBlock:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityCustomContentHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDFuncArity1V0))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Func<AXCustomContent[]> _GetAccessibilityCustomContentHandler (IAXCustomContentProvider This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomContentBlock"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDFuncArity1V0.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetAccessibilityCustomContentHandler (IAXCustomContentProvider This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0))]global::System.Func<AXCustomContent[]>? value)
		{
			using var block_value = Trampolines.SDFuncArity1V0.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomContentBlock:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAXCustomContentProvider" /> interface to support all the methods from the AXCustomContentProvider protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAXCustomContentProvider" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AXCustomContentProvider protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AXCustomContentProvider_Extensions {
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDFuncArity1V0))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static global::System.Func<AXCustomContent[]> GetAccessibilityCustomContentHandler (this IAXCustomContentProvider This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomContentBlock"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDFuncArity1V0.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetAccessibilityCustomContentHandler (this IAXCustomContentProvider This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0))]global::System.Func<AXCustomContent[]>? value)
		{
			using var block_value = Trampolines.SDFuncArity1V0.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomContentBlock:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AXCustomContentProviderWrapper : BaseWrapper, IAXCustomContentProvider {
		public AXCustomContentProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXCustomContentProviderWrapper))]
		static AXCustomContentProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXCustomContent[]? AccessibilityCustomContent {
			[Export ("accessibilityCustomContent", ArgumentSemantic.Copy)]
			get {
				AXCustomContent[] ret;
				ret = CFArray.ArrayFromHandle<AXCustomContent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCustomContent")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCustomContent:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCustomContent:"), nsa_value.GetHandle ());
			}
		}
	}
}
