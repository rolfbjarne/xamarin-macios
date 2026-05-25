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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSTextSelectionDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSTextSelectionDataSource", WrapperType = typeof (NSTextSelectionDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateSubstrings", Selector = "enumerateSubstringsFromLocation:options:usingBlock:", ParameterType = new Type [] { typeof (INSTextLocation), typeof (NSStringEnumerationOptions), typeof (NSTextSelectionDataSourceEnumerateSubstringsDelegate) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTextRange", Selector = "textRangeForSelectionGranularity:enclosingLocation:", ReturnType = typeof (NSTextRange), ParameterType = new Type [] { typeof (NSTextSelectionGranularity), typeof (INSTextLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetLocation", Selector = "locationFromLocation:withOffset:", ReturnType = typeof (INSTextLocation), ParameterType = new Type [] { typeof (INSTextLocation), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOffsetFromLocation", Selector = "offsetFromLocation:toLocation:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (INSTextLocation), typeof (INSTextLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBaseWritingDirection", Selector = "baseWritingDirectionAtLocation:", ReturnType = typeof (NSTextSelectionNavigationWritingDirection), ParameterType = new Type [] { typeof (INSTextLocation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateCaretOffsets", Selector = "enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:", ParameterType = new Type [] { typeof (INSTextLocation), typeof (NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetLineFragmentRange", Selector = "lineFragmentRangeForPoint:inContainerAtLocation:", ReturnType = typeof (NSTextRange), ParameterType = new Type [] { typeof (CGPoint), typeof (INSTextLocation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EnumerateContainerBoundaries", Selector = "enumerateContainerBoundariesFromLocation:reverse:usingBlock:", ParameterType = new Type [] { typeof (INSTextLocation), typeof (bool), typeof (NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextLayoutOrientation", Selector = "textLayoutOrientationAtLocation:", ReturnType = typeof (NSTextSelectionNavigationLayoutOrientation), ParameterType = new Type [] { typeof (INSTextLocation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DocumentRange", Selector = "documentRange", PropertyType = typeof (NSTextRange), GetterSelector = "documentRange", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface INSTextSelectionDataSource : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("enumerateSubstringsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateSubstrings (INSTextLocation location, NSStringEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate))]NSTextSelectionDataSourceEnumerateSubstringsDelegate handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EnumerateSubstrings (INSTextSelectionDataSource This, INSTextLocation location, NSStringEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate))]NSTextSelectionDataSourceEnumerateSubstringsDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateSubstringsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("enumerateSubstringsFromLocation:options:usingBlock:"), location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
		}
		[global::Foundation.RequiredMember]
		[Export ("textRangeForSelectionGranularity:enclosingLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetTextRange (NSTextSelectionGranularity selectionGranularity, INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextRange? _GetTextRange (INSTextSelectionDataSource This, NSTextSelectionGranularity selectionGranularity, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("textRangeForSelectionGranularity:enclosingLocation:"), (IntPtr) (long) selectionGranularity, location__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("locationFromLocation:withOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation? GetLocation (INSTextLocation location, nint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSTextLocation? _GetLocation (INSTextSelectionDataSource This, INSTextLocation location, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("locationFromLocation:withOffset:"), location__handle__, offset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("offsetFromLocation:toLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromLocation (INSTextLocation from, INSTextLocation to)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetOffsetFromLocation (INSTextSelectionDataSource This, INSTextLocation from, INSTextLocation to)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var to__handle__ = to!.GetNonNullHandle (nameof (to));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("offsetFromLocation:toLocation:"), from__handle__, to__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (from);
			GC.KeepAlive (to);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("baseWritingDirectionAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationWritingDirection GetBaseWritingDirection (INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextSelectionNavigationWritingDirection _GetBaseWritingDirection (INSTextSelectionDataSource This, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationWritingDirection ret;
			ret = (NSTextSelectionNavigationWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("baseWritingDirectionAtLocation:"), location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateCaretOffsets (INSTextLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate))]NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EnumerateCaretOffsets (INSTextSelectionDataSource This, INSTextLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate))]NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:"), location__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
		}
		[global::Foundation.RequiredMember]
		[Export ("lineFragmentRangeForPoint:inContainerAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetLineFragmentRange (CGPoint point, INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextRange? _GetLineFragmentRange (INSTextSelectionDataSource This, CGPoint point, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("lineFragmentRangeForPoint:inContainerAtLocation:"), point, location__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateContainerBoundaries (INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate))]NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate handler)
		{
			_EnumerateContainerBoundaries (this, location, reverse, handler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EnumerateContainerBoundaries (INSTextSelectionDataSource This, INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate))]NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:"), location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
		}
		[global::Foundation.OptionalMember]
		[Export ("textLayoutOrientationAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationLayoutOrientation GetTextLayoutOrientation (INSTextLocation location)
		{
			return _GetTextLayoutOrientation (this, location);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextSelectionNavigationLayoutOrientation _GetTextLayoutOrientation (INSTextSelectionDataSource This, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationLayoutOrientation ret;
			ret = (NSTextSelectionNavigationLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutOrientationAtLocation:"), location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[DynamicDependencyAttribute ("DocumentRange")]
		[DynamicDependencyAttribute ("EnumerateCaretOffsets(UIKit.INSTextLocation,UIKit.NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate)")]
		[DynamicDependencyAttribute ("EnumerateContainerBoundaries(UIKit.INSTextLocation,System.Boolean,UIKit.NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate)")]
		[DynamicDependencyAttribute ("EnumerateSubstrings(UIKit.INSTextLocation,Foundation.NSStringEnumerationOptions,UIKit.NSTextSelectionDataSourceEnumerateSubstringsDelegate)")]
		[DynamicDependencyAttribute ("GetBaseWritingDirection(UIKit.INSTextLocation)")]
		[DynamicDependencyAttribute ("GetLineFragmentRange(CoreGraphics.CGPoint,UIKit.INSTextLocation)")]
		[DynamicDependencyAttribute ("GetLocation(UIKit.INSTextLocation,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetOffsetFromLocation(UIKit.INSTextLocation,UIKit.INSTextLocation)")]
		[DynamicDependencyAttribute ("GetTextLayoutOrientation(UIKit.INSTextLocation)")]
		[DynamicDependencyAttribute ("GetTextRange(UIKit.NSTextSelectionGranularity,UIKit.INSTextLocation)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextSelectionDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextSelectionDataSource ()
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
		internal static NSTextRange _GetDocumentRange (INSTextSelectionDataSource This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSTextRange ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("documentRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextSelectionDataSource" /> interface to support all the methods from the NSTextSelectionDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextSelectionDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextSelectionDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextSelectionDataSource_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EnumerateContainerBoundaries (this INSTextSelectionDataSource This, INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate))]NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:"), location__handle__, reverse ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextSelectionNavigationLayoutOrientation GetTextLayoutOrientation (this INSTextSelectionDataSource This, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationLayoutOrientation ret;
			ret = (NSTextSelectionNavigationLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutOrientationAtLocation:"), location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextSelectionDataSourceWrapper : BaseWrapper, INSTextSelectionDataSource {
		public NSTextSelectionDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextSelectionDataSourceWrapper))]
		static NSTextSelectionDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("enumerateSubstringsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EnumerateSubstrings (INSTextLocation location, NSStringEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate))]NSTextSelectionDataSourceEnumerateSubstringsDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateSubstringsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enumerateSubstringsFromLocation:options:usingBlock:"), location__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_handler);
			GC.KeepAlive (location);
		}
		[Export ("textRangeForSelectionGranularity:enclosingLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextRange? GetTextRange (NSTextSelectionGranularity selectionGranularity, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("textRangeForSelectionGranularity:enclosingLocation:"), (IntPtr) (long) selectionGranularity, location__handle__), false)!;
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("locationFromLocation:withOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTextLocation? GetLocation (INSTextLocation location, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			INSTextLocation? ret;
			ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("locationFromLocation:withOffset:"), location__handle__, offset), false)!;
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("offsetFromLocation:toLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetOffsetFromLocation (INSTextLocation from, INSTextLocation to)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var to__handle__ = to!.GetNonNullHandle (nameof (to));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("offsetFromLocation:toLocation:"), from__handle__, to__handle__);
			GC.KeepAlive (from);
			GC.KeepAlive (to);
			return ret!;
		}
		[Export ("baseWritingDirectionAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextSelectionNavigationWritingDirection GetBaseWritingDirection (INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextSelectionNavigationWritingDirection ret;
			ret = (NSTextSelectionNavigationWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("baseWritingDirectionAtLocation:"), location__handle__);
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EnumerateCaretOffsets (INSTextLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate))]NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:"), location__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (location);
		}
		[Export ("lineFragmentRangeForPoint:inContainerAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextRange? GetLineFragmentRange (CGPoint point, INSTextLocation location)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSTextRange? ret;
			ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("lineFragmentRangeForPoint:inContainerAtLocation:"), point, location__handle__), false)!;
			GC.KeepAlive (location);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextRange DocumentRange {
			[Export ("documentRange", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextRange ret;
				ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("documentRange")), false)!;
				return ret;
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextSelectionDataSource" /> (for the protocol <c>NSTextSelectionDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextSelectionDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_NSTextSelectionDataSource", false)]
	[Model]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class NSTextSelectionDataSource : NSObject, INSTextSelectionDataSource {
		/// <summary>Creates a new <see cref="NSTextSelectionDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSTextSelectionDataSource () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSTextSelectionDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSTextSelectionDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("enumerateCaretOffsetsInLineFragmentAtLocation:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateCaretOffsets (INSTextLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateCaretOffsetsDelegate))]NSTextSelectionDataSourceEnumerateCaretOffsetsDelegate handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("enumerateContainerBoundariesFromLocation:reverse:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateContainerBoundaries (INSTextLocation location, bool reverse, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateContainerBoundariesDelegate))]NSTextSelectionDataSourceEnumerateContainerBoundariesDelegate handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("enumerateSubstringsFromLocation:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateSubstrings (INSTextLocation location, NSStringEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextSelectionDataSourceEnumerateSubstringsDelegate))]NSTextSelectionDataSourceEnumerateSubstringsDelegate handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("baseWritingDirectionAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationWritingDirection GetBaseWritingDirection (INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("lineFragmentRangeForPoint:inContainerAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetLineFragmentRange (CGPoint point, INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("locationFromLocation:withOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation? GetLocation (INSTextLocation location, nint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("offsetFromLocation:toLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromLocation (INSTextLocation from, INSTextLocation to)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textLayoutOrientationAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextSelectionNavigationLayoutOrientation GetTextLayoutOrientation (INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textRangeForSelectionGranularity:enclosingLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange? GetTextRange (NSTextSelectionGranularity selectionGranularity, INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange DocumentRange {
			[Export ("documentRange", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSTextSelectionDataSource */
}
