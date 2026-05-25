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
	/// <summary>This interface represents the Objective-C protocol <c>NSToolbarItemValidation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSToolbarItemValidation", WrapperType = typeof (NSToolbarItemValidationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateToolbarItem", Selector = "validateToolbarItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSToolbarItem) }, ParameterByRef = new bool [] { false })]
	public partial interface INSToolbarItemValidation : INativeObject, IDisposable
	{
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("validateToolbarItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateToolbarItem (NSToolbarItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ValidateToolbarItem (INSToolbarItemValidation This, NSToolbarItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validateToolbarItem:"), item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ValidateToolbarItem(AppKit.NSToolbarItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSToolbarItemValidationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSToolbarItemValidation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSToolbarItemValidationWrapper : BaseWrapper, INSToolbarItemValidation {
		public NSToolbarItemValidationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSToolbarItemValidationWrapper))]
		static NSToolbarItemValidationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateToolbarItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ValidateToolbarItem (NSToolbarItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("validateToolbarItem:"), item__handle__);
			GC.KeepAlive (item);
			return ret != 0;
		}
	}
}
