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
	/// <summary>This interface represents the Objective-C protocol <c>NSDraggingInfo</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSDraggingInfo", WrapperType = typeof (NSDraggingInfoWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SlideDraggedImageTo", Selector = "slideDraggedImageTo:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PromisedFilesDroppedAtDestination", Selector = "namesOfPromisedFilesDroppedAtDestination:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateDraggingItems", Selector = "enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:", ParameterType = new Type [] { typeof (NSDraggingItemEnumerationOptions), typeof (NSView), typeof (IntPtr), typeof (NSDictionary), typeof (NSDraggingEnumerator) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSDraggingEnumerator) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetSpringLoading", Selector = "resetSpringLoading")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingDestinationWindow", Selector = "draggingDestinationWindow", PropertyType = typeof (NSWindow), GetterSelector = "draggingDestinationWindow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingSourceOperationMask", Selector = "draggingSourceOperationMask", PropertyType = typeof (NSDragOperation), GetterSelector = "draggingSourceOperationMask", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingLocation", Selector = "draggingLocation", PropertyType = typeof (CGPoint), GetterSelector = "draggingLocation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggedImageLocation", Selector = "draggedImageLocation", PropertyType = typeof (CGPoint), GetterSelector = "draggedImageLocation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggedImage", Selector = "draggedImage", PropertyType = typeof (NSImage), GetterSelector = "draggedImage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingPasteboard", Selector = "draggingPasteboard", PropertyType = typeof (NSPasteboard), GetterSelector = "draggingPasteboard", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingSource", Selector = "draggingSource", PropertyType = typeof (NSObject), GetterSelector = "draggingSource", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingSequenceNumber", Selector = "draggingSequenceNumber", PropertyType = typeof (IntPtr), GetterSelector = "draggingSequenceNumber", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AnimatesToDestination", Selector = "animatesToDestination", PropertyType = typeof (bool), GetterSelector = "animatesToDestination", SetterSelector = "setAnimatesToDestination:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NumberOfValidItemsForDrop", Selector = "numberOfValidItemsForDrop", PropertyType = typeof (IntPtr), GetterSelector = "numberOfValidItemsForDrop", SetterSelector = "setNumberOfValidItemsForDrop:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DraggingFormation", Selector = "draggingFormation", PropertyType = typeof (NSDraggingFormation), GetterSelector = "draggingFormation", SetterSelector = "setDraggingFormation:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpringLoadingHighlight", Selector = "springLoadingHighlight", PropertyType = typeof (NSSpringLoadingHighlight), GetterSelector = "springLoadingHighlight", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSDraggingInfo : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("slideDraggedImageTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SlideDraggedImageTo (CGPoint screenPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SlideDraggedImageTo (INSDraggingInfo This, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("slideDraggedImageTo:"), screenPoint);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _PromisedFilesDroppedAtDestination (INSDraggingInfo This, NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:"), dropDestination__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, nint classArray, NSDictionary searchOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDraggingEnumerator))]NSDraggingEnumerator enumerator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EnumerateDraggingItems (INSDraggingInfo This, NSDraggingItemEnumerationOptions enumOpts, NSView view, nint classArray, NSDictionary searchOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDraggingEnumerator))]NSDraggingEnumerator enumerator)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var searchOptions__handle__ = searchOptions!.GetNonNullHandle (nameof (searchOptions));
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			using var block_enumerator = Trampolines.SDNSDraggingEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:"), (UIntPtr) (ulong) enumOpts, view__handle__, classArray, searchOptions__handle__, (IntPtr) block_ptr_enumerator);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (searchOptions);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetSpringLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetSpringLoading ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResetSpringLoading (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetSpringLoading"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AnimatesToDestination")]
		[DynamicDependencyAttribute ("DraggedImage")]
		[DynamicDependencyAttribute ("DraggedImageLocation")]
		[DynamicDependencyAttribute ("DraggingDestinationWindow")]
		[DynamicDependencyAttribute ("DraggingFormation")]
		[DynamicDependencyAttribute ("DraggingLocation")]
		[DynamicDependencyAttribute ("DraggingPasteboard")]
		[DynamicDependencyAttribute ("DraggingSequenceNumber")]
		[DynamicDependencyAttribute ("DraggingSource")]
		[DynamicDependencyAttribute ("DraggingSourceOperationMask")]
		[DynamicDependencyAttribute ("EnumerateDraggingItems(AppKit.NSDraggingItemEnumerationOptions,AppKit.NSView,System.IntPtr,Foundation.NSDictionary,AppKit.NSDraggingEnumerator)")]
		[DynamicDependencyAttribute ("NumberOfValidItemsForDrop")]
		[DynamicDependencyAttribute ("PromisedFilesDroppedAtDestination(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ResetSpringLoading()")]
		[DynamicDependencyAttribute ("SlideDraggedImageTo(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("SpringLoadingHighlight")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingInfoWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSDraggingInfo ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSWindow DraggingDestinationWindow {
			[Export ("draggingDestinationWindow")]
			get {
				return _GetDraggingDestinationWindow (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWindow _GetDraggingDestinationWindow (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWindow ret;
			ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("draggingDestinationWindow")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDragOperation DraggingSourceOperationMask {
			[Export ("draggingSourceOperationMask")]
			get {
				return _GetDraggingSourceOperationMask (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _GetDraggingSourceOperationMask (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("draggingSourceOperationMask"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint DraggingLocation {
			[Export ("draggingLocation")]
			get {
				return _GetDraggingLocation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetDraggingLocation (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("draggingLocation"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint DraggedImageLocation {
			[Export ("draggedImageLocation")]
			get {
				return _GetDraggedImageLocation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetDraggedImageLocation (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("draggedImageLocation"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSDraggingItem' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual NSImage DraggedImage {
			[Export ("draggedImage")]
			get {
				return _GetDraggedImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSImage _GetDraggedImage (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSImage ret;
			ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("draggedImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSPasteboard DraggingPasteboard {
			[Export ("draggingPasteboard")]
			get {
				return _GetDraggingPasteboard (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPasteboard _GetDraggingPasteboard (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSPasteboard ret;
			ret =  Runtime.GetNSObject<NSPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("draggingPasteboard")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject DraggingSource {
			[Export ("draggingSource")]
			get {
				return _GetDraggingSource (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetDraggingSource (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("draggingSource")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint DraggingSequenceNumber {
			[Export ("draggingSequenceNumber")]
			get {
				return _GetDraggingSequenceNumber (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetDraggingSequenceNumber (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("draggingSequenceNumber"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AnimatesToDestination {
			[Export ("animatesToDestination")]
			get {
				return _GetAnimatesToDestination (this);
			}
			[Export ("setAnimatesToDestination:")]
			set {
				_SetAnimatesToDestination (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAnimatesToDestination (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("animatesToDestination"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAnimatesToDestination (INSDraggingInfo This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAnimatesToDestination:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint NumberOfValidItemsForDrop {
			[Export ("numberOfValidItemsForDrop")]
			get {
				return _GetNumberOfValidItemsForDrop (this);
			}
			[Export ("setNumberOfValidItemsForDrop:")]
			set {
				_SetNumberOfValidItemsForDrop (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNumberOfValidItemsForDrop (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("numberOfValidItemsForDrop"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetNumberOfValidItemsForDrop (INSDraggingInfo This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNumberOfValidItemsForDrop:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDraggingFormation DraggingFormation {
			[Export ("draggingFormation")]
			get {
				return _GetDraggingFormation (this);
			}
			[Export ("setDraggingFormation:")]
			set {
				_SetDraggingFormation (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDraggingFormation _GetDraggingFormation (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDraggingFormation ret;
			ret = (NSDraggingFormation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("draggingFormation"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDraggingFormation (INSDraggingInfo This, NSDraggingFormation value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDraggingFormation:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSSpringLoadingHighlight SpringLoadingHighlight {
			[Export ("springLoadingHighlight")]
			get {
				return _GetSpringLoadingHighlight (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSpringLoadingHighlight _GetSpringLoadingHighlight (INSDraggingInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSSpringLoadingHighlight ret;
			ret = (NSSpringLoadingHighlight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("springLoadingHighlight"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSDraggingInfoWrapper : BaseWrapper, INSDraggingInfo {
		public NSDraggingInfoWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingInfoWrapper))]
		static NSDraggingInfoWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("slideDraggedImageTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SlideDraggedImageTo (CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("slideDraggedImageTo:"), screenPoint);
		}
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string[] PromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:"), dropDestination__handle__), false)!;
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		[Export ("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void EnumerateDraggingItems (NSDraggingItemEnumerationOptions enumOpts, NSView view, nint classArray, NSDictionary searchOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDraggingEnumerator))]NSDraggingEnumerator enumerator)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var searchOptions__handle__ = searchOptions!.GetNonNullHandle (nameof (searchOptions));
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			using var block_enumerator = Trampolines.SDNSDraggingEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:"), (UIntPtr) (ulong) enumOpts, view__handle__, classArray, searchOptions__handle__, (IntPtr) block_ptr_enumerator);
			GC.KeepAlive (view);
			GC.KeepAlive (searchOptions);
		}
		[Export ("resetSpringLoading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ResetSpringLoading ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetSpringLoading"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSWindow DraggingDestinationWindow {
			[Export ("draggingDestinationWindow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWindow ret;
				ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("draggingDestinationWindow")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDragOperation DraggingSourceOperationMask {
			[Export ("draggingSourceOperationMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDragOperation ret;
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("draggingSourceOperationMask"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint DraggingLocation {
			[Export ("draggingLocation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("draggingLocation"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint DraggedImageLocation {
			[Export ("draggedImageLocation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("draggedImageLocation"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSDraggingItem' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSImage DraggedImage {
			[Export ("draggedImage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImage ret;
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("draggedImage")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSPasteboard DraggingPasteboard {
			[Export ("draggingPasteboard")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPasteboard ret;
				ret =  Runtime.GetNSObject<NSPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("draggingPasteboard")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject DraggingSource {
			[Export ("draggingSource")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("draggingSource")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint DraggingSequenceNumber {
			[Export ("draggingSequenceNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("draggingSequenceNumber"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AnimatesToDestination {
			[Export ("animatesToDestination")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("animatesToDestination"));
				return ret != 0;
			}
			[Export ("setAnimatesToDestination:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnimatesToDestination:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint NumberOfValidItemsForDrop {
			[Export ("numberOfValidItemsForDrop")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfValidItemsForDrop"));
				return ret;
			}
			[Export ("setNumberOfValidItemsForDrop:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNumberOfValidItemsForDrop:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDraggingFormation DraggingFormation {
			[Export ("draggingFormation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDraggingFormation ret;
				ret = (NSDraggingFormation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("draggingFormation"));
				return ret!;
			}
			[Export ("setDraggingFormation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDraggingFormation:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSpringLoadingHighlight SpringLoadingHighlight {
			[Export ("springLoadingHighlight")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSpringLoadingHighlight ret;
				ret = (NSSpringLoadingHighlight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("springLoadingHighlight"));
				return ret!;
			}
		}
	}
}
