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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextElementProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSTextElementProvider", WrapperType = typeof (NSTextElementProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateTextElements", Selector = "enumerateTextElementsFromLocation:options:usingBlock:", ReturnType = typeof (INSTextLocation), ParameterType = new Type [] { typeof (INSTextLocation), typeof (NSTextContentManagerEnumerationOptions), typeof (global::System.Func<global::AppKit.NSTextElement, bool>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceContents", Selector = "replaceContentsInRange:withTextElements:", ParameterType = new Type [] { typeof (NSTextRange), typeof (NSTextElement[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Synchronize", Selector = "synchronizeToBackingStore:", ParameterType = new Type [] { typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLocation", Selector = "locationFromLocation:withOffset:", ReturnType = typeof (INSTextLocation), ParameterType = new Type [] { typeof (INSTextLocation), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOffset", Selector = "offsetFromLocation:toLocation:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (INSTextLocation), typeof (INSTextLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdjustedRange", Selector = "adjustedRangeFromRange:forEditingTextSelection:", ReturnType = typeof (NSTextRange), ParameterType = new Type [] { typeof (NSTextRange), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DocumentRange", Selector = "documentRange", PropertyType = typeof (NSTextRange), GetterSelector = "documentRange", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface INSTextElementProvider : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("enumerateTextElementsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual INSTextLocation? EnumerateTextElements (INSTextLocation? textLocation, NSTextContentManagerEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<NSTextElement, bool> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static INSTextLocation? _EnumerateTextElements (INSTextElementProvider This, INSTextLocation? textLocation, NSTextContentManagerEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<NSTextElement, bool> handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLocation__handle__ = textLocation.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDFuncArity2V2.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("enumerateTextElementsFromLocation:options:usingBlock:"), textLocation__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textLocation);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceContentsInRange:withTextElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceContents (NSTextRange range, NSTextElement[]? textElements)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceContents (INSTextElementProvider This, NSTextRange range, NSTextElement[]? textElements)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			using var nsa_textElements = textElements is null ? null : NSArray.FromNSObjects (textElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceContentsInRange:withTextElements:"), range__handle__, nsa_textElements.GetHandle ());
			GC.KeepAlive (This);
			GC.KeepAlive (range);
		}
		[global::Foundation.RequiredMember]
		[Export ("synchronizeToBackingStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Synchronize ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Synchronize (INSTextElementProvider This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("synchronizeToBackingStore:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("locationFromLocation:withOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation? GetLocation (INSTextLocation location, nint offset)
		{
			return _GetLocation (this, location, offset);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSTextLocation? _GetLocation (INSTextElementProvider This, INSTextLocation location, nint offset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("locationFromLocation:withOffset:"), location__handle__, offset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("offsetFromLocation:toLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffset (INSTextLocation from, INSTextLocation to)
		{
			return _GetOffset (this, from, to);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetOffset (INSTextElementProvider This, INSTextLocation from, INSTextLocation to)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var to__handle__ = to!.GetNonNullHandle (nameof (to));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("offsetFromLocation:toLocation:"), from__handle__, to__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (from);
			GC.KeepAlive (to);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("adjustedRangeFromRange:forEditingTextSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? AdjustedRange (NSTextRange textRange, bool forEditingTextSelection)
		{
			return _AdjustedRange (this, textRange, forEditingTextSelection);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextRange? _AdjustedRange (INSTextElementProvider This, NSTextRange textRange, bool forEditingTextSelection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("adjustedRangeFromRange:forEditingTextSelection:"), textRange__handle__, forEditingTextSelection ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textRange);
			return ret!;
		}
		[DynamicDependencyAttribute ("AdjustedRange(AppKit.NSTextRange,System.Boolean)")]
		[DynamicDependencyAttribute ("DocumentRange")]
		[DynamicDependencyAttribute ("EnumerateTextElements(AppKit.INSTextLocation,AppKit.NSTextContentManagerEnumerationOptions,System.Func{AppKit.NSTextElement,System.Boolean})")]
		[DynamicDependencyAttribute ("GetLocation(AppKit.INSTextLocation,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetOffset(AppKit.INSTextLocation,AppKit.INSTextLocation)")]
		[DynamicDependencyAttribute ("ReplaceContents(AppKit.NSTextRange,AppKit.NSTextElement[])")]
		[DynamicDependencyAttribute ("Synchronize(System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextElementProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextElementProvider ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSTextRange DocumentRange {
			[Export ("documentRange", ArgumentSemantic.Retain)]
			get {
				return _GetDocumentRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextRange _GetDocumentRange (INSTextElementProvider This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextRange ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("documentRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextElementProvider" /> interface to support all the methods from the NSTextElementProvider protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextElementProvider" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextElementProvider protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextElementProvider_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSTextLocation? GetLocation (this INSTextElementProvider This, INSTextLocation location, nint offset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("locationFromLocation:withOffset:"), location__handle__, offset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetOffset (this INSTextElementProvider This, INSTextLocation from, INSTextLocation to)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var to__handle__ = to!.GetNonNullHandle (nameof (to));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("offsetFromLocation:toLocation:"), from__handle__, to__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (from);
			GC.KeepAlive (to);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextRange? AdjustedRange (this INSTextElementProvider This, NSTextRange textRange, bool forEditingTextSelection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("adjustedRangeFromRange:forEditingTextSelection:"), textRange__handle__, forEditingTextSelection ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textRange);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextElementProviderWrapper : BaseWrapper, INSTextElementProvider {
		public NSTextElementProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextElementProviderWrapper))]
		static NSTextElementProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("enumerateTextElementsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe INSTextLocation? EnumerateTextElements (INSTextLocation? textLocation, NSTextContentManagerEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<NSTextElement, bool> handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLocation__handle__ = textLocation.GetHandle ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDFuncArity2V2.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enumerateTextElementsFromLocation:options:usingBlock:"), textLocation__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler), false)!;
			GC.KeepAlive (textLocation);
			return ret!;
		}
		[Export ("replaceContentsInRange:withTextElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceContents (NSTextRange range, NSTextElement[]? textElements)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			using var nsa_textElements = textElements is null ? null : NSArray.FromNSObjects (textElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceContentsInRange:withTextElements:"), range__handle__, nsa_textElements.GetHandle ());
			GC.KeepAlive (range);
		}
		[Export ("synchronizeToBackingStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Synchronize ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("synchronizeToBackingStore:"), (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextRange DocumentRange {
			[Export ("documentRange", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextRange ret;
				ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("documentRange")), false)!;
				return ret;
			}
		}
	}
}
