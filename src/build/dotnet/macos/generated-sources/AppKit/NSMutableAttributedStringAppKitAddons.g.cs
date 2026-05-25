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
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSMutableAttributedStringAppKitAddons  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyFontTraits_Range_X = "applyFontTraits:range:";
		static readonly NativeHandle selApplyFontTraits_Range_XHandle = Selector.GetHandle ("applyFontTraits:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFixAttachmentAttributeInRange_X = "fixAttachmentAttributeInRange:";
		static readonly NativeHandle selFixAttachmentAttributeInRange_XHandle = Selector.GetHandle ("fixAttachmentAttributeInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFixFontAttributeInRange_X = "fixFontAttributeInRange:";
		static readonly NativeHandle selFixFontAttributeInRange_XHandle = Selector.GetHandle ("fixFontAttributeInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFixParagraphStyleAttributeInRange_X = "fixParagraphStyleAttributeInRange:";
		static readonly NativeHandle selFixParagraphStyleAttributeInRange_XHandle = Selector.GetHandle ("fixParagraphStyleAttributeInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromData_Options_DocumentAttributes_X = "readFromData:options:documentAttributes:";
		static readonly NativeHandle selReadFromData_Options_DocumentAttributes_XHandle = Selector.GetHandle ("readFromData:options:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromData_Options_DocumentAttributes_Error_X = "readFromData:options:documentAttributes:error:";
		static readonly NativeHandle selReadFromData_Options_DocumentAttributes_Error_XHandle = Selector.GetHandle ("readFromData:options:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromURL_Options_DocumentAttributes_X = "readFromURL:options:documentAttributes:";
		static readonly NativeHandle selReadFromURL_Options_DocumentAttributes_XHandle = Selector.GetHandle ("readFromURL:options:documentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadFromURL_Options_DocumentAttributes_Error_X = "readFromURL:options:documentAttributes:error:";
		static readonly NativeHandle selReadFromURL_Options_DocumentAttributes_Error_XHandle = Selector.GetHandle ("readFromURL:options:documentAttributes:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlignment_Range_X = "setAlignment:range:";
		static readonly NativeHandle selSetAlignment_Range_XHandle = Selector.GetHandle ("setAlignment:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseWritingDirection_Range_X = "setBaseWritingDirection:range:";
		static readonly NativeHandle selSetBaseWritingDirection_Range_XHandle = Selector.GetHandle ("setBaseWritingDirection:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubscriptRange_X = "subscriptRange:";
		static readonly NativeHandle selSubscriptRange_XHandle = Selector.GetHandle ("subscriptRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuperscriptRange_X = "superscriptRange:";
		static readonly NativeHandle selSuperscriptRange_XHandle = Selector.GetHandle ("superscriptRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnscriptRange_X = "unscriptRange:";
		static readonly NativeHandle selUnscriptRange_XHandle = Selector.GetHandle ("unscriptRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateAttachmentsFromPath_X = "updateAttachmentsFromPath:";
		static readonly NativeHandle selUpdateAttachmentsFromPath_XHandle = Selector.GetHandle ("updateAttachmentsFromPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableAttributedString");
		/// <param name="This">The instance on which this method operates.</param><param name="traitMask">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applyFontTraits:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ApplyFontTraits (this NSMutableAttributedString This, NSFontTraitMask traitMask, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (This.Handle, selApplyFontTraits_Range_XHandle, (UIntPtr) (ulong) traitMask, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("fixAttachmentAttributeInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FixAttachmentAttributeInRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selFixAttachmentAttributeInRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("fixFontAttributeInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FixFontAttributeInRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selFixFontAttributeInRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("fixParagraphStyleAttributeInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FixParagraphStyleAttributeInRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selFixParagraphStyleAttributeInRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="data">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readFromData:options:documentAttributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromData (this NSMutableAttributedString This, NSData data, NSDictionary options, out NSDictionary returnOptions, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle returnOptionsValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (This.Handle, selReadFromData_Options_DocumentAttributes_Error_XHandle, data__handle__, options__handle__, &returnOptionsValue, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			returnOptions = Runtime.GetNSObject<NSDictionary> (returnOptionsValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="data">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromData (this NSMutableAttributedString This, NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions, out NSError error)
		{
			return This.ReadFromData (data, options.GetDictionary ()!, out returnOptions, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="data">To be added.</param><param name="options">To be added.</param><param name="dict">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readFromData:options:documentAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromData (this NSMutableAttributedString This, NSData data, NSDictionary options, out NSDictionary dict)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle dictValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, selReadFromData_Options_DocumentAttributes_XHandle, data__handle__, options__handle__, &dictValue);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			dict = Runtime.GetNSObject<NSDictionary> (dictValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="data">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromData (this NSMutableAttributedString This, NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions)
		{
			return This.ReadFromData (data, options.GetDictionary ()!, out returnOptions);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="url">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readFromURL:options:documentAttributes:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromURL (this NSMutableAttributedString This, NSUrl url, NSDictionary options, out NSDictionary returnOptions, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle returnOptionsValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (This.Handle, selReadFromURL_Options_DocumentAttributes_Error_XHandle, url__handle__, options__handle__, &returnOptionsValue, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			returnOptions = Runtime.GetNSObject<NSDictionary> (returnOptionsValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="url">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromURL (this NSMutableAttributedString This, NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions, out NSError error)
		{
			return This.ReadFromURL (url, options.GetDictionary ()!, out returnOptions, out error);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="url">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readFromURL:options:documentAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromURL (this NSMutableAttributedString This, NSUrl url, NSDictionary options, out NSDictionary returnOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle returnOptionsValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, selReadFromURL_Options_DocumentAttributes_XHandle, url__handle__, options__handle__, &returnOptionsValue);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			returnOptions = Runtime.GetNSObject<NSDictionary> (returnOptionsValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="url">To be added.</param><param name="options">To be added.</param><param name="returnOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ReadFromURL (this NSMutableAttributedString This, NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions)
		{
			return This.ReadFromURL (url, options.GetDictionary ()!, out returnOptions);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="alignment">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAlignment:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAlignment (this NSMutableAttributedString This, NSTextAlignment alignment, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (This.Handle, selSetAlignment_Range_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (alignment), range);
			GC.KeepAlive (This);
		}
		[Export ("setBaseWritingDirection:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBaseWritingDirection (this NSMutableAttributedString This, NSWritingDirection writingDirection, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (This.Handle, selSetBaseWritingDirection_Range_XHandle, (IntPtr) (long) writingDirection, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("subscriptRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SubscriptRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selSubscriptRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("superscriptRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SuperscriptRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selSuperscriptRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unscriptRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnscriptRange (this NSMutableAttributedString This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, selUnscriptRange_XHandle, range);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("updateAttachmentsFromPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateAttachmentsFromPath (this NSMutableAttributedString This, string path)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selUpdateAttachmentsFromPath_XHandle, nspath);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nspath);
		}
	} /* class NSMutableAttributedStringAppKitAddons */
}
