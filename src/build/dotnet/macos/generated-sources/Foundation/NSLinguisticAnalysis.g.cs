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
namespace Foundation {
	public unsafe static partial class NSLinguisticAnalysis  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_X = "enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:";
		static readonly NativeHandle selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_XHandle = Selector.GetHandle ("enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_X = "linguisticTagsInRange:scheme:options:orthography:tokenRanges:";
		static readonly NativeHandle selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_XHandle = Selector.GetHandle ("linguisticTagsInRange:scheme:options:orthography:tokenRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><param name="scheme">To be added.</param><param name="options">To be added.</param><param name="orthography">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EnumerateLinguisticTags (this NSString This, NSRange range, NSString scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSEnumerateLinguisticTagsEnumerator))]NSEnumerateLinguisticTagsEnumerator handler)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			var orthography__handle__ = orthography.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSEnumerateLinguisticTagsEnumerator.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_XHandle, range, scheme__handle__, (UIntPtr) (ulong) options, orthography__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (scheme);
			GC.KeepAlive (orthography);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><param name="scheme">To be added.</param><param name="options">To be added.</param><param name="orthography">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EnumerateLinguisticTags (this NSString This, NSRange range, NSLinguisticTagScheme scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, NSEnumerateLinguisticTagsEnumerator handler)
		{
			EnumerateLinguisticTags (This, range, scheme.GetConstant ()!, options, orthography, handler);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><param name="scheme">To be added.</param><param name="options">To be added.</param><param name="orthography">To be added.</param><param name="tokenRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("linguisticTagsInRange:scheme:options:orthography:tokenRanges:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (NSLinguisticTag[]), OriginalType = typeof (NSString[]))]
		public unsafe static NSLinguisticTag[] GetLinguisticTags (this NSString This, NSRange range, NSString scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
		{
			var scheme__handle__ = scheme!.GetNonNullHandle (nameof (scheme));
			var orthography__handle__ = orthography.GetHandle ();
			NativeHandle tokenRangesValue = IntPtr.Zero;
			NSLinguisticTag[] ret;
			ret = NSArray.ArrayFromHandleFunc <NSLinguisticTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (This.Handle, selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_XHandle, range, scheme__handle__, (UIntPtr) (ulong) options, orthography__handle__, &tokenRangesValue), NSLinguisticTagExtensions.GetValue , false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scheme);
			GC.KeepAlive (orthography);
			tokenRanges = CFArray.ArrayFromHandle<NSValue> (tokenRangesValue)!;
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="range">To be added.</param><param name="scheme">To be added.</param><param name="options">To be added.</param><param name="orthography">To be added.</param><param name="tokenRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSLinguisticTag[] GetLinguisticTags (this NSString This, NSRange range, NSLinguisticTagScheme scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
		{
			return GetLinguisticTags (This, range, scheme.GetConstant ()!, options, orthography, out tokenRanges);
		}
	} /* class NSLinguisticAnalysis */
}
