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
	/// <summary>This interface represents the Objective-C protocol <c>UIWritingToolsCoordinatorDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[SupportedOSPlatform ("ios18.2")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "UIWritingToolsCoordinatorDelegate", WrapperType = typeof (UIWritingToolsCoordinatorDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsContexts", Selector = "writingToolsCoordinator:requestsContextsForScope:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (UIWritingToolsCoordinatorContextScope), typeof (UIWritingToolsCoordinatorDelegateRequestsContextsCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsContextsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRange", Selector = "writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (NSAttributedString), typeof (UIWritingToolsCoordinatorTextReplacementReason), typeof (UIWritingToolsCoordinatorAnimationParameters), typeof (UIWritingToolsCoordinatorDelegateReplaceRangeCallback) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateReplaceRangeCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectRanges", Selector = "writingToolsCoordinator:selectRanges:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSValue[]), typeof (UIWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsRange", Selector = "writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (CGPoint), typeof (UIWritingToolsCoordinatorDelegateRequestsRangeCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsRangeCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsBoundingBezierPaths", Selector = "writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsUnderlinePaths", Selector = "writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrepareForTextAnimation", Selector = "writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (UIWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestsPreviewForTextAnimation", Selector = "writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (UIWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishTextAnimation", Selector = "writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (UIWritingToolsCoordinatorTextAnimation), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsSingleContainerSubranges", Selector = "writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestsDecorationContainerView", Selector = "writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (NSRange), typeof (UIWritingToolsCoordinatorContext), typeof (UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeToState", Selector = "writingToolsCoordinator:willChangeToState:completion:", ParameterType = new Type [] { typeof (UIWritingToolsCoordinator), typeof (UIWritingToolsCoordinatorState), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IUIWritingToolsCoordinatorDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsContexts (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsContextsCallback))]UIWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsContexts (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsContextsCallback))]UIWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsContextsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsContextsForScope:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) scope, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceRange (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, NSAttributedString replacementText, UIWritingToolsCoordinatorTextReplacementReason reason, UIWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateReplaceRangeCallback))]UIWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReplaceRange (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, NSAttributedString replacementText, UIWritingToolsCoordinatorTextReplacementReason reason, UIWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateReplaceRangeCallback))]UIWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var replacementText__handle__ = replacementText!.GetNonNullHandle (nameof (replacementText));
			var animationParameters__handle__ = animationParameters.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateReplaceRangeCallback.CreateBlock (completion);
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
		public unsafe virtual void SelectRanges (UIWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectRanges (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("ios18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsRange (UIWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsRangeCallback))]UIWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			_RequestsRange (this, writingToolsCoordinator, point, completion);
		}
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("ios18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsRange (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsRangeCallback))]UIWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsRangeCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:"), writingToolsCoordinator__handle__, point, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsBoundingBezierPaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsBoundingBezierPaths (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsUnderlinePaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsUnderlinePaths (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PrepareForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PrepareForTextAnimation (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public unsafe virtual void RequestsPreviewForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsPreviewForTextAnimation (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.RequiredMember]
		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FinishTextAnimation (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public unsafe virtual void RequestsSingleContainerSubranges (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			_RequestsSingleContainerSubranges (this, writingToolsCoordinator, range, context, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsSingleContainerSubranges (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsDecorationContainerView (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			_RequestsDecorationContainerView (this, writingToolsCoordinator, range, context, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestsDecorationContainerView (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[global::Foundation.OptionalMember]
		[Export ("writingToolsCoordinator:willChangeToState:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillChangeToState (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			_WillChangeToState (this, writingToolsCoordinator, newState, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillChangeToState (IUIWritingToolsCoordinatorDelegate This, UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("writingToolsCoordinator:willChangeToState:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) newState, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[DynamicDependencyAttribute ("FinishTextAnimation(UIKit.UIWritingToolsCoordinator,UIKit.UIWritingToolsCoordinatorTextAnimation,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("PrepareForTextAnimation(UIKit.UIWritingToolsCoordinator,UIKit.UIWritingToolsCoordinatorTextAnimation,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("ReplaceRange(UIKit.UIWritingToolsCoordinator,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,Foundation.NSAttributedString,UIKit.UIWritingToolsCoordinatorTextReplacementReason,UIKit.UIWritingToolsCoordinatorAnimationParameters,UIKit.UIWritingToolsCoordinatorDelegateReplaceRangeCallback)")]
		[DynamicDependencyAttribute ("RequestsBoundingBezierPaths(UIKit.UIWritingToolsCoordinator,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,UIKit.UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback)")]
		[DynamicDependencyAttribute ("RequestsContexts(UIKit.UIWritingToolsCoordinator,UIKit.UIWritingToolsCoordinatorContextScope,UIKit.UIWritingToolsCoordinatorDelegateRequestsContextsCallback)")]
		[DynamicDependencyAttribute ("RequestsDecorationContainerView(UIKit.UIWritingToolsCoordinator,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,UIKit.UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback)")]
		[DynamicDependencyAttribute ("RequestsPreviewForTextAnimation(UIKit.UIWritingToolsCoordinator,UIKit.UIWritingToolsCoordinatorTextAnimation,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,UIKit.UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback)")]
		[DynamicDependencyAttribute ("RequestsRange(UIKit.UIWritingToolsCoordinator,CoreGraphics.CGPoint,UIKit.UIWritingToolsCoordinatorDelegateRequestsRangeCallback)")]
		[DynamicDependencyAttribute ("RequestsSingleContainerSubranges(UIKit.UIWritingToolsCoordinator,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,UIKit.UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback)")]
		[DynamicDependencyAttribute ("RequestsUnderlinePaths(UIKit.UIWritingToolsCoordinator,Foundation.NSRange,UIKit.UIWritingToolsCoordinatorContext,UIKit.UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback)")]
		[DynamicDependencyAttribute ("SelectRanges(UIKit.UIWritingToolsCoordinator,Foundation.NSValue[],UIKit.UIWritingToolsCoordinatorContext,System.Action)")]
		[DynamicDependencyAttribute ("WillChangeToState(UIKit.UIWritingToolsCoordinator,UIKit.UIWritingToolsCoordinatorState,System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIWritingToolsCoordinatorDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIWritingToolsCoordinatorDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIWritingToolsCoordinatorDelegateWrapper : BaseWrapper, IUIWritingToolsCoordinatorDelegate {
		public UIWritingToolsCoordinatorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIWritingToolsCoordinatorDelegateWrapper))]
		static UIWritingToolsCoordinatorDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsContexts (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsContextsCallback))]UIWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsContextsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsContextsForScope:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) scope, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
		}
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReplaceRange (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, NSAttributedString replacementText, UIWritingToolsCoordinatorTextReplacementReason reason, UIWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateReplaceRangeCallback))]UIWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var replacementText__handle__ = replacementText!.GetNonNullHandle (nameof (replacementText));
			var animationParameters__handle__ = animationParameters.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateReplaceRangeCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:"), writingToolsCoordinator__handle__, range, context__handle__, replacementText__handle__, (IntPtr) (long) reason, animationParameters__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
			GC.KeepAlive (replacementText);
			GC.KeepAlive (animationParameters);
		}
		[Export ("writingToolsCoordinator:selectRanges:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectRanges (UIWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public unsafe void RequestsBoundingBezierPaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestsUnderlinePaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:"), writingToolsCoordinator__handle__, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PrepareForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public unsafe void RequestsPreviewForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var writingToolsCoordinator__handle__ = writingToolsCoordinator!.GetNonNullHandle (nameof (writingToolsCoordinator));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:"), writingToolsCoordinator__handle__, (IntPtr) (long) textAnimation, range, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (writingToolsCoordinator);
			GC.KeepAlive (context);
		}
		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIWritingToolsCoordinatorDelegate" /> (for the protocol <c>UIWritingToolsCoordinatorDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIWritingToolsCoordinatorDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIWritingToolsCoordinatorDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[SupportedOSPlatform ("ios18.2")]
	[UnsupportedOSPlatform ("macos")]
	public unsafe abstract partial class UIWritingToolsCoordinatorDelegate : NSObject, IUIWritingToolsCoordinatorDelegate {
		/// <summary>Creates a new <see cref="UIWritingToolsCoordinatorDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIWritingToolsCoordinatorDelegate () : base (NSObjectFlag.Empty)
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
		protected UIWritingToolsCoordinatorDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIWritingToolsCoordinatorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("writingToolsCoordinator:finishTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:prepareForTextAnimation:forRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PrepareForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:replaceRange:inContext:proposedText:reason:animationParameters:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceRange (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, NSAttributedString replacementText, UIWritingToolsCoordinatorTextReplacementReason reason, UIWritingToolsCoordinatorAnimationParameters? animationParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateReplaceRangeCallback))]UIWritingToolsCoordinatorDelegateReplaceRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsBoundingBezierPathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsBoundingBezierPaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback))]UIWritingToolsCoordinatorDelegateRequestsBoundingBezierPathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsContextsForScope:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsContexts (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorContextScope scope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsContextsCallback))]UIWritingToolsCoordinatorDelegateRequestsContextsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsDecorationContainerViewForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsDecorationContainerView (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback))]UIWritingToolsCoordinatorDelegateRequestsDecorationContainerViewCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsPreviewForTextAnimation:ofRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsPreviewForTextAnimation (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorTextAnimation textAnimation, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback))]UIWritingToolsCoordinatorDelegateRequestsPreviewForTextAnimationCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsRangeInContextWithIdentifierForPoint:completion:")]
		[ObsoletedOSPlatform ("maccatalyst18.4", "Not called anymore.")]
		[ObsoletedOSPlatform ("ios18.4", "Not called anymore.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsRange (UIWritingToolsCoordinator writingToolsCoordinator, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsRangeCallback))]UIWritingToolsCoordinatorDelegateRequestsRangeCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsSingleContainerSubrangesOfRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsSingleContainerSubranges (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback))]UIWritingToolsCoordinatorDelegateRequestsSingleContainerSubrangesCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:requestsUnderlinePathsForRange:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestsUnderlinePaths (UIWritingToolsCoordinator writingToolsCoordinator, NSRange range, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback))]UIWritingToolsCoordinatorDelegateRequestsUnderlinePathsCallback completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:selectRanges:inContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectRanges (UIWritingToolsCoordinator writingToolsCoordinator, NSValue[] ranges, UIWritingToolsCoordinatorContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("writingToolsCoordinator:willChangeToState:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillChangeToState (UIWritingToolsCoordinator writingToolsCoordinator, UIWritingToolsCoordinatorState newState, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIWritingToolsCoordinatorDelegate */
}
