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
	/// <summary>This interface represents the Objective-C protocol <c>NSPasteboardReading</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSPasteboardReading", WrapperType = typeof (NSPasteboardReadingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetReadableTypesForPasteboard", Selector = "readableTypesForPasteboard:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSPasteboard) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetReadingOptionsForType", Selector = "readingOptionsForType:pasteboard:", ReturnType = typeof (NSPasteboardReadingOptions), ParameterType = new Type [] { typeof (string), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSPasteboardReading : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (NSObject propertyList, NSString type) where T: NSObject, INSPasteboardReading
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var propertyList__handle__ = propertyList!.GetNonNullHandle (nameof (propertyList));
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (__handle__, Selector.GetHandle ("initWithPasteboardPropertyList:ofType:"), propertyList__handle__, type__handle__);
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			GC.KeepAlive (propertyList);
			GC.KeepAlive (type);
			return ret;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("readableTypesForPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypesForPasteboard<T> (NSPasteboard pasteboard) where T: NSObject, INSPasteboardReading
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var class_ptr = Class.GetHandle (typeof (T));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("readableTypesForPasteboard:"), pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("readingOptionsForType:pasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboardReadingOptions GetReadingOptionsForType<T> (string type, NSPasteboard pasteboard) where T: NSObject, INSPasteboardReading
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var class_ptr = Class.GetHandle (typeof (T));
			var nstype = CFString.CreateNative (type);
			NSPasteboardReadingOptions ret;
			ret = (NSPasteboardReadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("readingOptionsForType:pasteboard:"), nstype, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardReadingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPasteboardReading ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPasteboardReadingWrapper : BaseWrapper, INSPasteboardReading {
		public NSPasteboardReadingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPasteboardReadingWrapper))]
		static NSPasteboardReadingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
