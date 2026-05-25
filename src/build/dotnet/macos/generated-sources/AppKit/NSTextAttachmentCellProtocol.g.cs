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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextAttachmentCell</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextAttachmentCell", WrapperType = typeof (NSTextAttachmentCellProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawWithFrame", Selector = "drawWithFrame:inView:", ParameterType = new Type [] { typeof (CGRect), typeof (NSView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WantsToTrackMouse", Selector = "wantsToTrackMouse", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawWithFrame", Selector = "drawWithFrame:inView:characterIndex:", ParameterType = new Type [] { typeof (CGRect), typeof (NSView), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawWithFrame", Selector = "drawWithFrame:inView:characterIndex:layoutManager:", ParameterType = new Type [] { typeof (CGRect), typeof (NSView), typeof (UIntPtr), typeof (NSLayoutManager) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Highlight", Selector = "highlight:withFrame:inView:", ParameterType = new Type [] { typeof (bool), typeof (CGRect), typeof (NSView) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TrackMouse", Selector = "trackMouse:inRect:ofView:untilMouseUp:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSEvent), typeof (CGRect), typeof (NSView), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WantsToTrackMouse", Selector = "wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSEvent), typeof (CGRect), typeof (NSView), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TrackMouse", Selector = "trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSEvent), typeof (CGRect), typeof (NSView), typeof (UIntPtr), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CellFrameForTextContainer", Selector = "cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSTextContainer), typeof (CGRect), typeof (CGPoint), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CellSize", Selector = "cellSize", PropertyType = typeof (CGSize), GetterSelector = "cellSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CellBaselineOffset", Selector = "cellBaselineOffset", PropertyType = typeof (CGPoint), GetterSelector = "cellBaselineOffset", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Attachment", Selector = "attachment", PropertyType = typeof (NSTextAttachment), GetterSelector = "attachment", SetterSelector = "setAttachment:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextAttachmentCellProtocol : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("drawWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawWithFrame (INSTextAttachmentCellProtocol This, CGRect cellFrame, NSView? controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("drawWithFrame:inView:"), cellFrame, controlView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controlView);
		}
		[global::Foundation.RequiredMember]
		[Export ("wantsToTrackMouse")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WantsToTrackMouse ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WantsToTrackMouse (INSTextAttachmentCellProtocol This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("wantsToTrackMouse"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("drawWithFrame:inView:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawWithFrame (INSTextAttachmentCellProtocol This, CGRect cellFrame, NSView? controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("drawWithFrame:inView:characterIndex:"), cellFrame, controlView__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (controlView);
		}
		[global::Foundation.RequiredMember]
		[Export ("drawWithFrame:inView:characterIndex:layoutManager:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex, NSLayoutManager layoutManager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DrawWithFrame (INSTextAttachmentCellProtocol This, CGRect cellFrame, NSView? controlView, nuint charIndex, NSLayoutManager layoutManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("drawWithFrame:inView:characterIndex:layoutManager:"), cellFrame, controlView__handle__, charIndex, layoutManager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controlView);
			GC.KeepAlive (layoutManager);
		}
		[global::Foundation.RequiredMember]
		[Export ("highlight:withFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Highlight (bool highlight, CGRect cellFrame, NSView controlView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Highlight (INSTextAttachmentCellProtocol This, bool highlight, CGRect cellFrame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("highlight:withFrame:inView:"), highlight ? (byte) 1 : (byte) 0, cellFrame, controlView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controlView);
		}
		[global::Foundation.RequiredMember]
		[Export ("trackMouse:inRect:ofView:untilMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _TrackMouse (INSTextAttachmentCellProtocol This, NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_bool (This.Handle, Selector.GetHandle ("trackMouse:inRect:ofView:untilMouseUp:"), theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WantsToTrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WantsToTrackMouse (INSTextAttachmentCellProtocol This, NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:"), theEvent__handle__, cellFrame, controlView__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex, bool untilMouseUp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _TrackMouse (INSTextAttachmentCellProtocol This, NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr_bool (This.Handle, Selector.GetHandle ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:"), theEvent__handle__, cellFrame, controlView__handle__, charIndex, untilMouseUp ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect CellFrameForTextContainer (NSTextContainer textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _CellFrameForTextContainer (INSTextAttachmentCellProtocol This, NSTextContainer textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, lineFrag, position, charIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, lineFrag, position, charIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[DynamicDependencyAttribute ("Attachment")]
		[DynamicDependencyAttribute ("CellBaselineOffset")]
		[DynamicDependencyAttribute ("CellFrameForTextContainer(AppKit.NSTextContainer,CoreGraphics.CGRect,CoreGraphics.CGPoint,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CellSize")]
		[DynamicDependencyAttribute ("DrawWithFrame(CoreGraphics.CGRect,AppKit.NSView,System.UIntPtr,AppKit.NSLayoutManager)")]
		[DynamicDependencyAttribute ("DrawWithFrame(CoreGraphics.CGRect,AppKit.NSView,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DrawWithFrame(CoreGraphics.CGRect,AppKit.NSView)")]
		[DynamicDependencyAttribute ("Highlight(System.Boolean,CoreGraphics.CGRect,AppKit.NSView)")]
		[DynamicDependencyAttribute ("TrackMouse(AppKit.NSEvent,CoreGraphics.CGRect,AppKit.NSView,System.Boolean)")]
		[DynamicDependencyAttribute ("TrackMouse(AppKit.NSEvent,CoreGraphics.CGRect,AppKit.NSView,System.UIntPtr,System.Boolean)")]
		[DynamicDependencyAttribute ("WantsToTrackMouse()")]
		[DynamicDependencyAttribute ("WantsToTrackMouse(AppKit.NSEvent,CoreGraphics.CGRect,AppKit.NSView,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentCellProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextAttachmentCellProtocol ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize CellSize {
			[Export ("cellSize")]
			get {
				return _GetCellSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetCellSize (INSTextAttachmentCellProtocol This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("cellSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint CellBaselineOffset {
			[Export ("cellBaselineOffset")]
			get {
				return _GetCellBaselineOffset (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetCellBaselineOffset (INSTextAttachmentCellProtocol This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("cellBaselineOffset"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSTextAttachment? Attachment {
			[Export ("attachment")]
			get {
				return _GetAttachment (this);
			}
			[Export ("setAttachment:")]
			set {
				_SetAttachment (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextAttachment _GetAttachment (INSTextAttachmentCellProtocol This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextAttachment ret;
			ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("attachment")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttachment (INSTextAttachmentCellProtocol This, NSTextAttachment? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAttachment:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextAttachmentCellProtocolWrapper : BaseWrapper, INSTextAttachmentCellProtocol {
		public NSTextAttachmentCellProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentCellProtocolWrapper))]
		static NSTextAttachmentCellProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("drawWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawWithFrame (CGRect cellFrame, NSView? controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("drawWithFrame:inView:"), cellFrame, controlView__handle__);
			GC.KeepAlive (controlView);
		}
		[Export ("wantsToTrackMouse")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool WantsToTrackMouse ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsToTrackMouse"));
			return ret != 0;
		}
		[Export ("drawWithFrame:inView:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("drawWithFrame:inView:characterIndex:"), cellFrame, controlView__handle__, charIndex);
			GC.KeepAlive (controlView);
		}
		[Export ("drawWithFrame:inView:characterIndex:layoutManager:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawWithFrame (CGRect cellFrame, NSView? controlView, nuint charIndex, NSLayoutManager layoutManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView.GetHandle ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("drawWithFrame:inView:characterIndex:layoutManager:"), cellFrame, controlView__handle__, charIndex, layoutManager__handle__);
			GC.KeepAlive (controlView);
			GC.KeepAlive (layoutManager);
		}
		[Export ("highlight:withFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Highlight (bool highlight, CGRect cellFrame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("highlight:withFrame:inView:"), highlight ? (byte) 1 : (byte) 0, cellFrame, controlView__handle__);
			GC.KeepAlive (controlView);
		}
		[Export ("trackMouse:inRect:ofView:untilMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_bool (this.Handle, Selector.GetHandle ("trackMouse:inRect:ofView:untilMouseUp:"), theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[Export ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool WantsToTrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:"), theEvent__handle__, cellFrame, controlView__handle__, charIndex);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[Export ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:"), theEvent__handle__, cellFrame, controlView__handle__, charIndex, untilMouseUp ? (byte) 1 : (byte) 0);
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[Export ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect CellFrameForTextContainer (NSTextContainer textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, Selector.GetHandle ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, lineFrag, position, charIndex);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, Selector.GetHandle ("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, lineFrag, position, charIndex);
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize CellSize {
			[Export ("cellSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("cellSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint CellBaselineOffset {
			[Export ("cellBaselineOffset")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("cellBaselineOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextAttachment? Attachment {
			[Export ("attachment")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAttachment ret;
				ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attachment")), false)!;
				return ret;
			}
			[Export ("setAttachment:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttachment:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
