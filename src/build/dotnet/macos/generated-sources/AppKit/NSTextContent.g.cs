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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextContent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextContent", WrapperType = typeof (NSTextContentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetContentType", Selector = "contentType", ReturnType = typeof (NSString))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetContentType", Selector = "setContentType:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	public partial interface INSTextContent : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("contentType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetContentType ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetContentType (INSTextContent This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("setContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentType (NSString contentType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetContentType (INSTextContent This, NSString contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setContentType:"), contentType__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentType);
		}
		[DynamicDependencyAttribute ("GetContentType()")]
		[DynamicDependencyAttribute ("SetContentType(Foundation.NSString)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextContentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextContent ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextContentWrapper : BaseWrapper, INSTextContent {
		public NSTextContentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextContentWrapper))]
		static NSTextContentWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("contentType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString GetContentType ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentType")), false)!;
			return ret;
		}
		[Export ("setContentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetContentType (NSString contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContentType:"), contentType__handle__);
			GC.KeepAlive (contentType);
		}
	}
}
