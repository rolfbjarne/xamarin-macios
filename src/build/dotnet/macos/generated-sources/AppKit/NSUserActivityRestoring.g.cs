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
	/// <summary>This interface represents the Objective-C protocol <c>NSUserActivityRestoring</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSUserActivityRestoring", WrapperType = typeof (NSUserActivityRestoringWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RestoreUserActivityState", Selector = "restoreUserActivityState:", ParameterType = new Type [] { typeof (NSUserActivity) }, ParameterByRef = new bool [] { false })]
	public partial interface INSUserActivityRestoring : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("restoreUserActivityState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreUserActivityState (NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RestoreUserActivityState (INSUserActivityRestoring This, NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("restoreUserActivityState:"), userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
		}
		[DynamicDependencyAttribute ("RestoreUserActivityState(Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserActivityRestoringWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUserActivityRestoring ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUserActivityRestoringWrapper : BaseWrapper, INSUserActivityRestoring {
		public NSUserActivityRestoringWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserActivityRestoringWrapper))]
		static NSUserActivityRestoringWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("restoreUserActivityState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RestoreUserActivityState (NSUserActivity userActivity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("restoreUserActivityState:"), userActivity__handle__);
			GC.KeepAlive (userActivity);
		}
	}
}
