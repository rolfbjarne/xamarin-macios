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
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibilityElementLoading</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibilityElementLoading", WrapperType = typeof (NSAccessibilityElementLoadingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityElement", Selector = "accessibilityElementWithToken:", ReturnType = typeof (NSAccessibilityElement), ParameterType = new Type [] { typeof (INSSecureCoding) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeInTargetElement", Selector = "accessibilityRangeInTargetElementWithToken:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (INSSecureCoding) }, ParameterByRef = new bool [] { false })]
	public partial interface INSAccessibilityElementLoading : INativeObject, IDisposable
	{
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityElementWithToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAccessibilityElement? GetAccessibilityElement (INSSecureCoding token)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityElement? _GetAccessibilityElement (INSAccessibilityElementLoading This, INSSecureCoding token)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSAccessibilityElement? ret;
			ret =  Runtime.GetNSObject<NSAccessibilityElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityElementWithToken:"), token__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (token);
			return ret!;
		}
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityRangeInTargetElementWithToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRangeInTargetElement (INSSecureCoding token)
		{
			return _GetAccessibilityRangeInTargetElement (this, token);
		}
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRangeInTargetElement (INSAccessibilityElementLoading This, INSSecureCoding token)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityRangeInTargetElementWithToken:"), token__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (token);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAccessibilityElement(Foundation.INSSecureCoding)")]
		[DynamicDependencyAttribute ("GetAccessibilityRangeInTargetElement(Foundation.INSSecureCoding)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityElementLoadingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibilityElementLoading ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSAccessibilityElementLoading" /> interface to support all the methods from the NSAccessibilityElementLoading protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSAccessibilityElementLoading" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSAccessibilityElementLoading protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSAccessibilityElementLoading_Extensions {
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRange GetAccessibilityRangeInTargetElement (this INSAccessibilityElementLoading This, INSSecureCoding token)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityRangeInTargetElementWithToken:"), token__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (token);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityElementLoadingWrapper : BaseWrapper, INSAccessibilityElementLoading {
		public NSAccessibilityElementLoadingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityElementLoadingWrapper))]
		static NSAccessibilityElementLoadingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="token">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityElementWithToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityElement? GetAccessibilityElement (INSSecureCoding token)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSAccessibilityElement? ret;
			ret =  Runtime.GetNSObject<NSAccessibilityElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityElementWithToken:"), token__handle__), false)!;
			GC.KeepAlive (token);
			return ret!;
		}
	}
}
