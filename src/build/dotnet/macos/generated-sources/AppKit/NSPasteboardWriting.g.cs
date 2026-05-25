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
	/// <summary>This interface represents the Objective-C protocol <c>NSPasteboardWriting</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSPasteboardWriting", WrapperType = typeof (NSPasteboardWritingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetWritableTypesForPasteboard", Selector = "writableTypesForPasteboard:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSPasteboard) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritingOptionsForType", Selector = "writingOptionsForType:pasteboard:", ReturnType = typeof (NSPasteboardWritingOptions), ParameterType = new Type [] { typeof (string), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPasteboardPropertyListForType", Selector = "pasteboardPropertyListForType:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface INSPasteboardWriting : INativeObject, IDisposable
	{
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("writableTypesForPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritableTypesForPasteboard (NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetWritableTypesForPasteboard (INSPasteboardWriting This, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("writableTypesForPasteboard:"), pasteboard__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("writingOptionsForType:pasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPasteboardWritingOptions GetWritingOptionsForType (string type, NSPasteboard pasteboard)
		{
			return _GetWritingOptionsForType (this, type, pasteboard);
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPasteboardWritingOptions _GetWritingOptionsForType (INSPasteboardWriting This, string type, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardWritingOptions ret;
			ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingOptionsForType:pasteboard:"), nstype, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pasteboardPropertyListForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPasteboardPropertyListForType (string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetPasteboardPropertyListForType (INSPasteboardWriting This, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pasteboardPropertyListForType:"), nstype), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPasteboardPropertyListForType(System.String)")]
		[DynamicDependencyAttribute ("GetWritableTypesForPasteboard(AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute ("GetWritingOptionsForType(System.String,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardWritingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPasteboardWriting ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSPasteboardWriting" /> interface to support all the methods from the NSPasteboardWriting protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSPasteboardWriting" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSPasteboardWriting protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSPasteboardWriting_Extensions {
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboardWritingOptions GetWritingOptionsForType (this INSPasteboardWriting This, string type, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardWritingOptions ret;
			ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingOptionsForType:pasteboard:"), nstype, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPasteboardWritingWrapper : BaseWrapper, INSPasteboardWriting {
		public NSPasteboardWritingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardWritingWrapper))]
		static NSPasteboardWritingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writableTypesForPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string[] GetWritableTypesForPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("writableTypesForPasteboard:"), pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pasteboardPropertyListForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject GetPasteboardPropertyListForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pasteboardPropertyListForType:"), nstype), false)!;
			CFString.ReleaseNative (nstype);
			return ret!;
		}
	}
}
