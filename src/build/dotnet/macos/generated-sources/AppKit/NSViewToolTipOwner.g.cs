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
	/// <summary>This interface represents the Objective-C protocol <c>NSViewToolTipOwner</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSViewToolTipOwner", WrapperType = typeof (NSViewToolTipOwnerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetStringForToolTip", Selector = "view:stringForToolTip:point:userData:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSView), typeof (IntPtr), typeof (CGPoint), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSViewToolTipOwner : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("view:stringForToolTip:point:userData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetStringForToolTip (NSView view, nint tag, CGPoint point, nint data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetStringForToolTip (INSViewToolTipOwner This, NSView view, nint tag, CGPoint point, nint data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_CGPoint_IntPtr (This.Handle, Selector.GetHandle ("view:stringForToolTip:point:userData:"), view__handle__, tag, point, data), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetStringForToolTip(AppKit.NSView,System.IntPtr,CoreGraphics.CGPoint,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSViewToolTipOwnerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSViewToolTipOwner ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSViewToolTipOwnerWrapper : BaseWrapper, INSViewToolTipOwner {
		public NSViewToolTipOwnerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSViewToolTipOwnerWrapper))]
		static NSViewToolTipOwnerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("view:stringForToolTip:point:userData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetStringForToolTip (NSView view, nint tag, CGPoint point, nint data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("view:stringForToolTip:point:userData:"), view__handle__, tag, point, data), false)!;
			GC.KeepAlive (view);
			return ret!;
		}
	}
}
