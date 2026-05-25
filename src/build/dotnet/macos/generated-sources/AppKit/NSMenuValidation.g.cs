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
	/// <summary>This interface represents the Objective-C protocol <c>NSMenuValidation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSMenuValidation", WrapperType = typeof (NSMenuValidationWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateMenuItem", Selector = "validateMenuItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSMenuItem) }, ParameterByRef = new bool [] { false })]
	public partial interface INSMenuValidation : INativeObject, IDisposable
	{
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("validateMenuItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateMenuItem (NSMenuItem menuItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ValidateMenuItem (INSMenuValidation This, NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validateMenuItem:"), menuItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ValidateMenuItem(AppKit.NSMenuItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMenuValidationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSMenuValidation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSMenuValidationWrapper : BaseWrapper, INSMenuValidation {
		public NSMenuValidationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMenuValidationWrapper))]
		static NSMenuValidationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateMenuItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ValidateMenuItem (NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("validateMenuItem:"), menuItem__handle__);
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
	}
}
