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
	/// <summary>This interface represents the Objective-C protocol <c>NSServicesMenuRequestor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSServicesMenuRequestor", WrapperType = typeof (NSServicesMenuRequestorWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteSelectionToPasteboard", Selector = "writeSelectionToPasteboard:types:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPasteboard), typeof (String[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadSelectionFromPasteboard", Selector = "readSelectionFromPasteboard:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPasteboard) }, ParameterByRef = new bool [] { false })]
	public partial interface INSServicesMenuRequestor : INativeObject, IDisposable
	{
		/// <param name="pboard">To be added.</param><param name="types">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("writeSelectionToPasteboard:types:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteSelectionToPasteboard (NSPasteboard pboard, string[] types)
		{
			return _WriteSelectionToPasteboard (this, pboard, types);
		}
		/// <param name="pboard">To be added.</param><param name="types">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteSelectionToPasteboard (INSServicesMenuRequestor This, NSPasteboard pboard, string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writeSelectionToPasteboard:types:"), pboard__handle__, nsa_types.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("readSelectionFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReadSelectionFromPasteboard (NSPasteboard pboard)
		{
			return _ReadSelectionFromPasteboard (this, pboard);
		}
		/// <param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ReadSelectionFromPasteboard (INSServicesMenuRequestor This, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("readSelectionFromPasteboard:"), pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ReadSelectionFromPasteboard(AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("WriteSelectionToPasteboard(AppKit.NSPasteboard,System.String[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSServicesMenuRequestorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSServicesMenuRequestor ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSServicesMenuRequestor" /> interface to support all the methods from the NSServicesMenuRequestor protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSServicesMenuRequestor" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSServicesMenuRequestor protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSServicesMenuRequestor_Extensions {
		/// <param name="pboard">To be added.</param><param name="types">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteSelectionToPasteboard (this INSServicesMenuRequestor This, NSPasteboard pboard, string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writeSelectionToPasteboard:types:"), pboard__handle__, nsa_types.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		/// <param name="pboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ReadSelectionFromPasteboard (this INSServicesMenuRequestor This, NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("readSelectionFromPasteboard:"), pboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pboard);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSServicesMenuRequestorWrapper : BaseWrapper, INSServicesMenuRequestor {
		public NSServicesMenuRequestorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSServicesMenuRequestorWrapper))]
		static NSServicesMenuRequestorWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
