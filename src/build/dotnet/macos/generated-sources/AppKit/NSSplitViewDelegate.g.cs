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
	/// <summary>This interface represents the Objective-C protocol <c>NSSplitViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSSplitViewDelegate", WrapperType = typeof (NSSplitViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanCollapse", Selector = "splitView:canCollapseSubview:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSplitView), typeof (NSView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCollapseForDoubleClick", Selector = "splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSplitView), typeof (NSView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMinCoordinateOfSubview", Selector = "splitView:constrainMinCoordinate:ofSubviewAt:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSSplitView), typeof (NFloat), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMaxCoordinateOfSubview", Selector = "splitView:constrainMaxCoordinate:ofSubviewAt:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSSplitView), typeof (NFloat), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConstrainSplitPosition", Selector = "splitView:constrainSplitPosition:ofSubviewAt:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSSplitView), typeof (NFloat), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Resize", Selector = "splitView:resizeSubviewsWithOldSize:", ParameterType = new Type [] { typeof (NSSplitView), typeof (CGSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAdjustSize", Selector = "splitView:shouldAdjustSizeOfSubview:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSplitView), typeof (NSView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHideDivider", Selector = "splitView:shouldHideDividerAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSplitView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEffectiveRect", Selector = "splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSSplitView), typeof (CGRect), typeof (CGRect), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdditionalEffectiveRect", Selector = "splitView:additionalEffectiveRectOfDividerAtIndex:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSSplitView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SplitViewWillResizeSubviews", Selector = "splitViewWillResizeSubviews:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResizeSubviews", Selector = "splitViewDidResizeSubviews:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	public partial interface INSSplitViewDelegate : INativeObject, IDisposable
	{
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:canCollapseSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanCollapse (NSSplitView splitView, NSView subview)
		{
			return _CanCollapse (this, splitView, subview);
		}
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanCollapse (INSSplitViewDelegate This, NSSplitView splitView, NSView subview)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitView:canCollapseSubview:"), splitView__handle__, subview__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><param name="doubleClickAtDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
		[ObsoletedOSPlatform ("macos10.15", "This delegate method is never called.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCollapseForDoubleClick (NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
		{
			return _ShouldCollapseForDoubleClick (this, splitView, subview, doubleClickAtDividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><param name="doubleClickAtDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "This delegate method is never called.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldCollapseForDoubleClick (INSSplitViewDelegate This, NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:"), splitView__handle__, subview__handle__, doubleClickAtDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="proposedMinimumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:constrainMinCoordinate:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMinCoordinateOfSubview (NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
		{
			return _SetMinCoordinateOfSubview (this, splitView, proposedMinimumPosition, subviewDividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="proposedMinimumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _SetMinCoordinateOfSubview (INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainMinCoordinate:ofSubviewAt:"), splitView__handle__, proposedMinimumPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="proposedMaximumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:constrainMaxCoordinate:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMaxCoordinateOfSubview (NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
		{
			return _SetMaxCoordinateOfSubview (this, splitView, proposedMaximumPosition, subviewDividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="proposedMaximumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _SetMaxCoordinateOfSubview (INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainMaxCoordinate:ofSubviewAt:"), splitView__handle__, proposedMaximumPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="proposedPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:constrainSplitPosition:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ConstrainSplitPosition (NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
		{
			return _ConstrainSplitPosition (this, splitView, proposedPosition, subviewDividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="proposedPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _ConstrainSplitPosition (INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainSplitPosition:ofSubviewAt:"), splitView__handle__, proposedPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:resizeSubviewsWithOldSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resize (NSSplitView splitView, CGSize oldSize)
		{
			_Resize (this, splitView, oldSize);
		}
		/// <param name="splitView">To be added.</param><param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Resize (INSSplitViewDelegate This, NSSplitView splitView, CGSize oldSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("splitView:resizeSubviewsWithOldSize:"), splitView__handle__, oldSize);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
		}
		/// <param name="splitView">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:shouldAdjustSizeOfSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAdjustSize (NSSplitView splitView, NSView view)
		{
			return _ShouldAdjustSize (this, splitView, view);
		}
		/// <param name="splitView">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAdjustSize (INSSplitViewDelegate This, NSSplitView splitView, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitView:shouldAdjustSizeOfSubview:"), splitView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (view);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:shouldHideDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideDivider (NSSplitView splitView, nint dividerIndex)
		{
			return _ShouldHideDivider (this, splitView, dividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldHideDivider (INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:shouldHideDividerAtIndex:"), splitView__handle__, dividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="proposedEffectiveRect">To be added.</param><param name="drawnRect">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetEffectiveRect (NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
		{
			return _GetEffectiveRect (this, splitView, proposedEffectiveRect, drawnRect, dividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="proposedEffectiveRect">To be added.</param><param name="drawnRect">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetEffectiveRect (INSSplitViewDelegate This, NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGRect_IntPtr (This.Handle, Selector.GetHandle ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:"), splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGRect_IntPtr (This.Handle, Selector.GetHandle ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:"), splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitView:additionalEffectiveRectOfDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAdditionalEffectiveRect (NSSplitView splitView, nint dividerIndex)
		{
			return _GetAdditionalEffectiveRect (this, splitView, dividerIndex);
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAdditionalEffectiveRect (INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:additionalEffectiveRectOfDividerAtIndex:"), splitView__handle__, dividerIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:additionalEffectiveRectOfDividerAtIndex:"), splitView__handle__, dividerIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewWillResizeSubviews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SplitViewWillResizeSubviews (NSNotification notification)
		{
			_SplitViewWillResizeSubviews (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SplitViewWillResizeSubviews (INSSplitViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewWillResizeSubviews:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("splitViewDidResizeSubviews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResizeSubviews (NSNotification notification)
		{
			_DidResizeSubviews (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResizeSubviews (INSSplitViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewDidResizeSubviews:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[DynamicDependencyAttribute ("CanCollapse(AppKit.NSSplitView,AppKit.NSView)")]
		[DynamicDependencyAttribute ("ConstrainSplitPosition(AppKit.NSSplitView,System.Runtime.InteropServices.NFloat,System.IntPtr)")]
		[DynamicDependencyAttribute ("DidResizeSubviews(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("GetAdditionalEffectiveRect(AppKit.NSSplitView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetEffectiveRect(AppKit.NSSplitView,CoreGraphics.CGRect,CoreGraphics.CGRect,System.IntPtr)")]
		[DynamicDependencyAttribute ("Resize(AppKit.NSSplitView,CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("SetMaxCoordinateOfSubview(AppKit.NSSplitView,System.Runtime.InteropServices.NFloat,System.IntPtr)")]
		[DynamicDependencyAttribute ("SetMinCoordinateOfSubview(AppKit.NSSplitView,System.Runtime.InteropServices.NFloat,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldAdjustSize(AppKit.NSSplitView,AppKit.NSView)")]
		[DynamicDependencyAttribute ("ShouldCollapseForDoubleClick(AppKit.NSSplitView,AppKit.NSView,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldHideDivider(AppKit.NSSplitView,System.IntPtr)")]
		[DynamicDependencyAttribute ("SplitViewWillResizeSubviews(Foundation.NSNotification)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSplitViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSSplitViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSSplitViewDelegate" /> interface to support all the methods from the NSSplitViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSSplitViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSSplitViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSSplitViewDelegate_Extensions {
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanCollapse (this INSSplitViewDelegate This, NSSplitView splitView, NSView subview)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitView:canCollapseSubview:"), splitView__handle__, subview__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><param name="doubleClickAtDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.15", "This delegate method is never called.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldCollapseForDoubleClick (this INSSplitViewDelegate This, NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:"), splitView__handle__, subview__handle__, doubleClickAtDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="proposedMinimumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SetMinCoordinateOfSubview (this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainMinCoordinate:ofSubviewAt:"), splitView__handle__, proposedMinimumPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="proposedMaximumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SetMaxCoordinateOfSubview (this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainMaxCoordinate:ofSubviewAt:"), splitView__handle__, proposedMaximumPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="proposedPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat ConstrainSplitPosition (this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (This.Handle, Selector.GetHandle ("splitView:constrainSplitPosition:ofSubviewAt:"), splitView__handle__, proposedPosition, subviewDividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Resize (this INSSplitViewDelegate This, NSSplitView splitView, CGSize oldSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("splitView:resizeSubviewsWithOldSize:"), splitView__handle__, oldSize);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
		}
		/// <param name="splitView">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAdjustSize (this INSSplitViewDelegate This, NSSplitView splitView, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("splitView:shouldAdjustSizeOfSubview:"), splitView__handle__, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			GC.KeepAlive (view);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldHideDivider (this INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:shouldHideDividerAtIndex:"), splitView__handle__, dividerIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (splitView);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="proposedEffectiveRect">To be added.</param><param name="drawnRect">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetEffectiveRect (this INSSplitViewDelegate This, NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGRect_IntPtr (This.Handle, Selector.GetHandle ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:"), splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGRect_IntPtr (This.Handle, Selector.GetHandle ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:"), splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetAdditionalEffectiveRect (this INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:additionalEffectiveRectOfDividerAtIndex:"), splitView__handle__, dividerIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("splitView:additionalEffectiveRectOfDividerAtIndex:"), splitView__handle__, dividerIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SplitViewWillResizeSubviews (this INSSplitViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewWillResizeSubviews:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidResizeSubviews (this INSSplitViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("splitViewDidResizeSubviews:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSSplitViewDelegateWrapper : BaseWrapper, INSSplitViewDelegate {
		public NSSplitViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSplitViewDelegateWrapper))]
		static NSSplitViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSSplitViewDelegate" /> (for the protocol <c>NSSplitViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSSplitViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSSplitViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSplitViewDelegate : NSObject, INSSplitViewDelegate {
		/// <summary>Creates a new <see cref="NSSplitViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSplitViewDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSSplitViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSSplitViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:canCollapseSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanCollapse (NSSplitView splitView, NSView subview)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="proposedPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainSplitPosition:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ConstrainSplitPosition (NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitViewDidResizeSubviews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResizeSubviews (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:additionalEffectiveRectOfDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAdditionalEffectiveRect (NSSplitView splitView, nint dividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="proposedEffectiveRect">To be added.</param><param name="drawnRect">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetEffectiveRect (NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitView:resizeSubviewsWithOldSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resize (NSSplitView splitView, CGSize oldSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="proposedMaximumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainMaxCoordinate:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMaxCoordinateOfSubview (NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="proposedMinimumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainMinCoordinate:ofSubviewAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMinCoordinateOfSubview (NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:shouldAdjustSizeOfSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAdjustSize (NSSplitView splitView, NSView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="subview">To be added.</param><param name="doubleClickAtDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
		[ObsoletedOSPlatform ("macos10.15", "This delegate method is never called.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCollapseForDoubleClick (NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="splitView">To be added.</param><param name="dividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:shouldHideDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideDivider (NSSplitView splitView, nint dividerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitViewWillResizeSubviews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SplitViewWillResizeSubviews (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSSplitViewDelegate */
}
