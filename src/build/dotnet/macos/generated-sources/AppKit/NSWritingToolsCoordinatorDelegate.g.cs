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
	/// <summary>This interface represents the Objective-C protocol <c>NSWritingToolsCoordinatorDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[SupportedOSPlatform ("macos15.2")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSWritingToolsCoordinatorDelegate", WrapperType = typeof (NSWritingToolsCoordinatorDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsContexts", Selector = "writingToolsCoordinator:requestsContextsForScope:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSWritingToolsCoordinatorContextScope), typeof (NSWritingToolsCoordinatorDelegateRequestsContextsCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsContextsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRange", Selector = "writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSAttributedString), typeof (NSWritingToolsCoordinatorTextReplacementReason), typeof (NSWritingToolsCoordinatorAnimationParameters), typeof (NSWritingToolsCoordinatorDelegateReplaceRangeCallback) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateReplaceRangeCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectRanges", Selector = "writingToolsCoordinator:selectRanges:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSValue[]), typeof (NSWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsRange", Selector = "writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (CGPoint), typeof (NSWritingToolsCoordinatorDelegateRequestsRangeCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsRangeCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsBoundingBezierPaths", Selector = "writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsUnderlinePaths", Selector = "writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrepareForTextAnimation", Selector = "writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsPreviewForTextAnimation", Selector = "writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsPreview", Selector = "writingToolsCoordinator:requestsPreviewForRect:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (CGRect), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsPreviewCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishTextAnimation", Selector = "writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsSingleContainerSubranges", Selector = "writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsDecorationContainerView", Selector = "writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSRange), typeof (NSWritingToolsCoordinatorContext), typeof (NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeToState", Selector = "writingToolsCoordinator:willChangeToState:completion:", ParameterType = new Type [] { typeof (NSWritingToolsCoordinator), typeof (NSWritingToolsCoordinatorState), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface INSWritingToolsCoordinatorDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsContexts (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsContextsCallback))]NSWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsContexts (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsContextsCallback))]NSWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsContextsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsContextsForScope:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) scope, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceRange (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, NSAttributedString replacementText, NSWritingToolsCoordinatorTextReplacementReason reason, NSWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateReplaceRangeCallback))]NSWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReplaceRange (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, NSAttributedString replacementText, NSWritingToolsCoordinatorTextReplacementReason reason, NSWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateReplaceRangeCallback))]NSWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var replacementText__handle__ = replacementText!.GetNonNullHandle (nameof (replacementText));
			var animationParameters__handle__ = animationParameters.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateReplaceRangeCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:"), writingToolsCoordinator__handle__, range, context__handle__, replacementText__handle__, (IntPtr) (long) reason, animationParameters__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
			GC.KeepAlive (replacementText);
			GC.KeepAlive (animationParameters);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:selectRanges:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectRanges (NSWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectRanges (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:selectRanges:inContext:completion:"), writingToolsCoordinator__handle__, nsa_ranges.Handle, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:")]
		[ObsoletedOSPlatform ("macos15.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsRange (NSWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsRangeCallback))]NSWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			_RequestsRange (this, writingToolsCoordinator, point, completion);
		}
		[ObsoletedOSPlatform ("macos15.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsRange (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsRangeCallback))]NSWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsRangeCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:"), writingToolsCoordinator__handle__, point, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsBoundingBezierPaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsBoundingBezierPaths (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsUnderlinePaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsUnderlinePaths (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PrepareForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PrepareForTextAnimation (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsPreviewForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsPreviewForTextAnimation (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsPreviewForRect:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsPreview (NSWritingToolsCoordinator writingToolsCoordinator, CGRect rect, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsPreview (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, CGRect rect, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForRect:inContext:completion:"), writingToolsCoordinator__handle__, rect, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FinishTextAnimation (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsSingleContainerSubranges (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			_RequestsSingleContainerSubranges (this, writingToolsCoordinator, range, context, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsSingleContainerSubranges (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsDecorationContainerView (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			_RequestsDecorationContainerView (this, writingToolsCoordinator, range, context, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsDecorationContainerView (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:willChangeToState:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillChangeToState (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			_WillChangeToState (this, writingToolsCoordinator, newState, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillChangeToState (INSWritingToolsCoordinatorDelegate This, NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:willChangeToState:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) newState, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[DynamicDependencyAttribute ("FinishTextAnimation(AppKit.NSWritingToolsCoordinator,AppKit.NSWritingToolsCoordinatorTextAnimation,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("PrepareForTextAnimation(AppKit.NSWritingToolsCoordinator,AppKit.NSWritingToolsCoordinatorTextAnimation,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("ReplaceRange(AppKit.NSWritingToolsCoordinator,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,Foundation.NSAttributedString,AppKit.NSWritingToolsCoordinatorTextReplacementReason,AppKit.NSWritingToolsCoordinatorAnimationParameters,AppKit.NSWritingToolsCoordinatorDelegateReplaceRangeCallback)")]
		[DynamicDependencyAttribute ("RequestsBoundingBezierPaths(AppKit.NSWritingToolsCoordinator,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback)")]
		[DynamicDependencyAttribute ("RequestsContexts(AppKit.NSWritingToolsCoordinator,AppKit.NSWritingToolsCoordinatorContextScope,AppKit.NSWritingToolsCoordinatorDelegateRequestsContextsCallback)")]
		[DynamicDependencyAttribute ("RequestsDecorationContainerView(AppKit.NSWritingToolsCoordinator,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback)")]
		[DynamicDependencyAttribute ("RequestsPreview(AppKit.NSWritingToolsCoordinator,CoreGraphics.CGRect,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsPreviewCallback)")]
		[DynamicDependencyAttribute ("RequestsPreviewForTextAnimation(AppKit.NSWritingToolsCoordinator,AppKit.NSWritingToolsCoordinatorTextAnimation,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback)")]
		[DynamicDependencyAttribute ("RequestsRange(AppKit.NSWritingToolsCoordinator,CoreGraphics.CGPoint,AppKit.NSWritingToolsCoordinatorDelegateRequestsRangeCallback)")]
		[DynamicDependencyAttribute ("RequestsSingleContainerSubranges(AppKit.NSWritingToolsCoordinator,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback)")]
		[DynamicDependencyAttribute ("RequestsUnderlinePaths(AppKit.NSWritingToolsCoordinator,Foundation.NSRange,AppKit.NSWritingToolsCoordinatorContext,AppKit.NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback)")]
		[DynamicDependencyAttribute ("SelectRanges(AppKit.NSWritingToolsCoordinator,Foundation.NSValue[],AppKit.NSWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("WillChangeToState(AppKit.NSWritingToolsCoordinator,AppKit.NSWritingToolsCoordinatorState,System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSWritingToolsCoordinatorDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSWritingToolsCoordinatorDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSWritingToolsCoordinatorDelegateWrapper : BaseWrapper, INSWritingToolsCoordinatorDelegate {
		public NSWritingToolsCoordinatorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSWritingToolsCoordinatorDelegateWrapper))]
		static NSWritingToolsCoordinatorDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsContexts (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsContextsCallback))]NSWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsContextsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsContextsForScope:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) scope, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReplaceRange (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, NSAttributedString replacementText, NSWritingToolsCoordinatorTextReplacementReason reason, NSWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateReplaceRangeCallback))]NSWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var replacementText__handle__ = replacementText!.GetNonNullHandle (nameof (replacementText));
			var animationParameters__handle__ = animationParameters.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateReplaceRangeCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:"), writingToolsCoordinator__handle__, range, context__handle__, replacementText__handle__, (IntPtr) (long) reason, animationParameters__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
			GC.KeepAlive (replacementText);
			GC.KeepAlive (animationParameters);
		}
		[Export ("writingToolsCoordinator:selectRanges:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectRanges (NSWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:selectRanges:inContext:completion:"), writingToolsCoordinator__handle__, nsa_ranges.Handle, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsBoundingBezierPaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsUnderlinePaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PrepareForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsPreviewForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:requestsPreviewForRect:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsPreview (NSWritingToolsCoordinator writingToolsCoordinator, CGRect rect, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewCallback completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForRect:inContext:completion:"), writingToolsCoordinator__handle__, rect, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSWritingToolsCoordinatorDelegate" /> (for the protocol <c>NSWritingToolsCoordinatorDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSWritingToolsCoordinatorDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSWritingToolsCoordinatorDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[SupportedOSPlatform ("macos15.2")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe abstract partial class NSWritingToolsCoordinatorDelegate : NSObject, INSWritingToolsCoordinatorDelegate {
		/// <summary>Creates a new <see cref="NSWritingToolsCoordinatorDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSWritingToolsCoordinatorDelegate () : base (NSObjectFlag.Empty)
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
		protected NSWritingToolsCoordinatorDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSWritingToolsCoordinatorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PrepareForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceRange (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, NSAttributedString replacementText, NSWritingToolsCoordinatorTextReplacementReason reason, NSWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateReplaceRangeCallback))]NSWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsBoundingBezierPaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]NSWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsContexts (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsContextsCallback))]NSWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsDecorationContainerView (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]NSWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsPreviewForRect:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsPreview (NSWritingToolsCoordinator writingToolsCoordinator, CGRect rect, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsPreviewForTextAnimation (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]NSWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:")]
		[ObsoletedOSPlatform ("macos15.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsRange (NSWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsRangeCallback))]NSWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsSingleContainerSubranges (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]NSWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsUnderlinePaths (NSWritingToolsCoordinator writingToolsCoordinator, NSRange range, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]NSWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:selectRanges:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectRanges (NSWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, NSWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:willChangeToState:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillChangeToState (NSWritingToolsCoordinator writingToolsCoordinator, NSWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSWritingToolsCoordinatorDelegate */
}
