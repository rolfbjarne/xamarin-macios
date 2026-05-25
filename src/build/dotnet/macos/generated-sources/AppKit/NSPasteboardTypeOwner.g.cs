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
	/// <summary>This interface represents the Objective-C protocol <c>NSPasteboardTypeOwner</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSPasteboardTypeOwner", WrapperType = typeof (NSPasteboardTypeOwnerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideData", Selector = "pasteboard:provideDataForType:", ParameterType = new Type [] { typeof (NSPasteboard), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardChangedOwner", Selector = "pasteboardChangedOwner:", ParameterType = new Type [] { typeof (NSPasteboard) }, ParameterByRef = new bool [] { false })]
	public partial interface INSPasteboardTypeOwner : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pasteboard:provideDataForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProvideData (NSPasteboard sender, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProvideData (INSPasteboardTypeOwner This, NSPasteboard sender, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pasteboard:provideDataForType:"), sender__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pasteboardChangedOwner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteboardChangedOwner (NSPasteboard sender)
		{
			_PasteboardChangedOwner (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PasteboardChangedOwner (INSPasteboardTypeOwner This, NSPasteboard sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteboardChangedOwner:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[DynamicDependencyAttribute ("PasteboardChangedOwner(AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("ProvideData(AppKit.NSPasteboard,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardTypeOwnerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPasteboardTypeOwner ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSPasteboardTypeOwner" /> interface to support all the methods from the NSPasteboardTypeOwner protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSPasteboardTypeOwner" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSPasteboardTypeOwner protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSPasteboardTypeOwner_Extensions {
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PasteboardChangedOwner (this INSPasteboardTypeOwner This, NSPasteboard sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteboardChangedOwner:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPasteboardTypeOwnerWrapper : BaseWrapper, INSPasteboardTypeOwner {
		public NSPasteboardTypeOwnerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardTypeOwnerWrapper))]
		static NSPasteboardTypeOwnerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="sender">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pasteboard:provideDataForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ProvideData (NSPasteboard sender, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pasteboard:provideDataForType:"), sender__handle__, nstype);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstype);
		}
	}
}
