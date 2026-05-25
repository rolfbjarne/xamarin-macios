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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIUserActivityRestoring</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIUserActivityRestoring", WrapperType = typeof (UIUserActivityRestoringWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RestoreUserActivityState", Selector = "restoreUserActivityState:", ParameterType = new Type [] { typeof (NSUserActivity) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIUserActivityRestoring : INativeObject, IDisposable
	{
		/// <param name="activity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("restoreUserActivityState:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreUserActivityState (NSUserActivity activity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RestoreUserActivityState (IUIUserActivityRestoring This, NSUserActivity activity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activity__handle__ = activity!.GetNonNullHandle (nameof (activity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("restoreUserActivityState:"), activity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (activity);
		}
		[DynamicDependencyAttribute ("RestoreUserActivityState(Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIUserActivityRestoringWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIUserActivityRestoring ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIUserActivityRestoringWrapper : BaseWrapper, IUIUserActivityRestoring {
		public UIUserActivityRestoringWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIUserActivityRestoringWrapper))]
		static UIUserActivityRestoringWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="activity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("restoreUserActivityState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RestoreUserActivityState (NSUserActivity activity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activity__handle__ = activity!.GetNonNullHandle (nameof (activity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("restoreUserActivityState:"), activity__handle__);
			GC.KeepAlive (activity);
		}
	}
}
