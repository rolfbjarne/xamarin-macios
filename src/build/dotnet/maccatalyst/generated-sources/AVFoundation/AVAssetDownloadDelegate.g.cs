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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Delegate that handles events that can be encountered while downloading an asset.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVAssetDownloadDelegate">Apple documentation for <c>AVAssetDownloadDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVAssetDownloadDelegate", WrapperType = typeof (AVAssetDownloadDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadTimeRange", Selector = "URLSession:assetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (CMTimeRange), typeof (NSValue[]), typeof (CMTimeRange) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResolveMediaSelection", Selector = "URLSession:assetDownloadTask:didResolveMediaSelection:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (AVMediaSelection) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishDownloadingToUrl", Selector = "URLSession:assetDownloadTask:didFinishDownloadingToURL:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDownloadToUrl", Selector = "URLSession:aggregateAssetDownloadTask:willDownloadToURL:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAggregateAssetDownloadTask), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteForMediaSelection", Selector = "URLSession:aggregateAssetDownloadTask:didCompleteForMediaSelection:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAggregateAssetDownloadTask), typeof (AVMediaSelection) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadTimeRange", Selector = "URLSession:aggregateAssetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:forMediaSelection:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAggregateAssetDownloadTask), typeof (CMTimeRange), typeof (NSValue[]), typeof (CMTimeRange), typeof (AVMediaSelection) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDownloadVariants", Selector = "URLSession:assetDownloadTask:willDownloadVariants:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (AVAssetVariant[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WilllDownloadToUrl", Selector = "URLSession:assetDownloadTask:willDownloadToURL:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMetricEvent", Selector = "URLSession:assetDownloadTask:didReceiveMetricEvent:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (AVAssetDownloadTask), typeof (AVMetricEvent) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVAssetDownloadDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionTaskDelegate
	{
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadTimeRange (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad)
		{
			_DidLoadTimeRange (this, session, assetDownloadTask, timeRange, loadedTimeRanges, timeRangeExpectedToLoad);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadTimeRange (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			if (loadedTimeRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadedTimeRanges));
			using var nsa_loadedTimeRanges = NSArray.FromNSObjects (loadedTimeRanges);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTimeRange_NativeHandle_CMTimeRange (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:"), session__handle__, assetDownloadTask__handle__, timeRange, nsa_loadedTimeRanges.Handle, timeRangeExpectedToLoad);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="resolvedMediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:didResolveMediaSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResolveMediaSelection (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMediaSelection resolvedMediaSelection)
		{
			_DidResolveMediaSelection (this, session, assetDownloadTask, resolvedMediaSelection);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="resolvedMediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResolveMediaSelection (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMediaSelection resolvedMediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var resolvedMediaSelection__handle__ = resolvedMediaSelection!.GetNonNullHandle (nameof (resolvedMediaSelection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didResolveMediaSelection:"), session__handle__, assetDownloadTask__handle__, resolvedMediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (resolvedMediaSelection);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:didFinishDownloadingToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDownloadingToUrl (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			_DidFinishDownloadingToUrl (this, session, assetDownloadTask, location);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishDownloadingToUrl (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didFinishDownloadingToURL:"), session__handle__, assetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (location);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:aggregateAssetDownloadTask:willDownloadToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDownloadToUrl (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, NSUrl location)
		{
			_WillDownloadToUrl (this, session, aggregateAssetDownloadTask, location);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDownloadToUrl (IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:willDownloadToURL:"), session__handle__, aggregateAssetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (location);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:aggregateAssetDownloadTask:didCompleteForMediaSelection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteForMediaSelection (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, AVMediaSelection mediaSelection)
		{
			_DidCompleteForMediaSelection (this, session, aggregateAssetDownloadTask, mediaSelection);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteForMediaSelection (IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, AVMediaSelection mediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			var mediaSelection__handle__ = mediaSelection!.GetNonNullHandle (nameof (mediaSelection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:didCompleteForMediaSelection:"), session__handle__, aggregateAssetDownloadTask__handle__, mediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (mediaSelection);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:aggregateAssetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:forMediaSelection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadTimeRange (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad, AVMediaSelection mediaSelection)
		{
			_DidLoadTimeRange (this, session, aggregateAssetDownloadTask, timeRange, loadedTimeRanges, timeRangeExpectedToLoad, mediaSelection);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLoadTimeRange (IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad, AVMediaSelection mediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			if (loadedTimeRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadedTimeRanges));
			var mediaSelection__handle__ = mediaSelection!.GetNonNullHandle (nameof (mediaSelection));
			using var nsa_loadedTimeRanges = NSArray.FromNSObjects (loadedTimeRanges);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTimeRange_NativeHandle_CMTimeRange_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:forMediaSelection:"), session__handle__, aggregateAssetDownloadTask__handle__, timeRange, nsa_loadedTimeRanges.Handle, timeRangeExpectedToLoad, mediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (mediaSelection);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:willDownloadVariants:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDownloadVariants (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVAssetVariant[] variants)
		{
			_WillDownloadVariants (this, session, assetDownloadTask, variants);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDownloadVariants (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVAssetVariant[] variants)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			if (variants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (variants));
			using var nsa_variants = NSArray.FromNSObjects (variants);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:willDownloadVariants:"), session__handle__, assetDownloadTask__handle__, nsa_variants.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:willDownloadToURL:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WilllDownloadToUrl (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			_WilllDownloadToUrl (this, session, assetDownloadTask, location);
		}
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WilllDownloadToUrl (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:willDownloadToURL:"), session__handle__, assetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (location);
		}
		[global::Foundation.OptionalMember]
		[Export ("URLSession:assetDownloadTask:didReceiveMetricEvent:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMetricEvent (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMetricEvent metricEvent)
		{
			_DidReceiveMetricEvent (this, session, assetDownloadTask, metricEvent);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMetricEvent (IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMetricEvent metricEvent)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var metricEvent__handle__ = metricEvent!.GetNonNullHandle (nameof (metricEvent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didReceiveMetricEvent:"), session__handle__, assetDownloadTask__handle__, metricEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (metricEvent);
		}
		[DynamicDependencyAttribute ("DidCompleteForMediaSelection(Foundation.NSUrlSession,AVFoundation.AVAggregateAssetDownloadTask,AVFoundation.AVMediaSelection)")]
		[DynamicDependencyAttribute ("DidFinishDownloadingToUrl(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidLoadTimeRange(Foundation.NSUrlSession,AVFoundation.AVAggregateAssetDownloadTask,CoreMedia.CMTimeRange,Foundation.NSValue[],CoreMedia.CMTimeRange,AVFoundation.AVMediaSelection)")]
		[DynamicDependencyAttribute ("DidLoadTimeRange(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,CoreMedia.CMTimeRange,Foundation.NSValue[],CoreMedia.CMTimeRange)")]
		[DynamicDependencyAttribute ("DidReceiveMetricEvent(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,AVFoundation.AVMetricEvent)")]
		[DynamicDependencyAttribute ("DidResolveMediaSelection(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,AVFoundation.AVMediaSelection)")]
		[DynamicDependencyAttribute ("WillDownloadToUrl(Foundation.NSUrlSession,AVFoundation.AVAggregateAssetDownloadTask,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("WillDownloadVariants(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,AVFoundation.AVAssetVariant[])")]
		[DynamicDependencyAttribute ("WilllDownloadToUrl(Foundation.NSUrlSession,AVFoundation.AVAssetDownloadTask,Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAssetDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAssetDownloadDelegate" /> interface to support all the methods from the AVAssetDownloadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAssetDownloadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAssetDownloadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAssetDownloadDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadTimeRange (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			if (loadedTimeRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadedTimeRanges));
			using var nsa_loadedTimeRanges = NSArray.FromNSObjects (loadedTimeRanges);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTimeRange_NativeHandle_CMTimeRange (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:"), session__handle__, assetDownloadTask__handle__, timeRange, nsa_loadedTimeRanges.Handle, timeRangeExpectedToLoad);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="resolvedMediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidResolveMediaSelection (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMediaSelection resolvedMediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var resolvedMediaSelection__handle__ = resolvedMediaSelection!.GetNonNullHandle (nameof (resolvedMediaSelection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didResolveMediaSelection:"), session__handle__, assetDownloadTask__handle__, resolvedMediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (resolvedMediaSelection);
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishDownloadingToUrl (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didFinishDownloadingToURL:"), session__handle__, assetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (location);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDownloadToUrl (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:willDownloadToURL:"), session__handle__, aggregateAssetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (location);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteForMediaSelection (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, AVMediaSelection mediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			var mediaSelection__handle__ = mediaSelection!.GetNonNullHandle (nameof (mediaSelection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:didCompleteForMediaSelection:"), session__handle__, aggregateAssetDownloadTask__handle__, mediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (mediaSelection);
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidLoadTimeRange (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad, AVMediaSelection mediaSelection)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var aggregateAssetDownloadTask__handle__ = aggregateAssetDownloadTask!.GetNonNullHandle (nameof (aggregateAssetDownloadTask));
			if (loadedTimeRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (loadedTimeRanges));
			var mediaSelection__handle__ = mediaSelection!.GetNonNullHandle (nameof (mediaSelection));
			using var nsa_loadedTimeRanges = NSArray.FromNSObjects (loadedTimeRanges);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTimeRange_NativeHandle_CMTimeRange_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:aggregateAssetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:forMediaSelection:"), session__handle__, aggregateAssetDownloadTask__handle__, timeRange, nsa_loadedTimeRanges.Handle, timeRangeExpectedToLoad, mediaSelection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (aggregateAssetDownloadTask);
			GC.KeepAlive (mediaSelection);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDownloadVariants (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVAssetVariant[] variants)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			if (variants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (variants));
			using var nsa_variants = NSArray.FromNSObjects (variants);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:willDownloadVariants:"), session__handle__, assetDownloadTask__handle__, nsa_variants.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
		}
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WilllDownloadToUrl (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:willDownloadToURL:"), session__handle__, assetDownloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (location);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveMetricEvent (this IAVAssetDownloadDelegate This, NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMetricEvent metricEvent)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var assetDownloadTask__handle__ = assetDownloadTask!.GetNonNullHandle (nameof (assetDownloadTask));
			var metricEvent__handle__ = metricEvent!.GetNonNullHandle (nameof (metricEvent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:assetDownloadTask:didReceiveMetricEvent:"), session__handle__, assetDownloadTask__handle__, metricEvent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (assetDownloadTask);
			GC.KeepAlive (metricEvent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAssetDownloadDelegateWrapper : BaseWrapper, IAVAssetDownloadDelegate {
		public AVAssetDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetDownloadDelegateWrapper))]
		static AVAssetDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate that handles events that can be encountered while downloading an asset.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVAssetDownloadDelegate">Apple documentation for <c>AVAssetDownloadDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVAssetDownloadDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVAssetDownloadDelegate : NSObject, IAVAssetDownloadDelegate, INSUrlSessionTaskDelegate {
		/// <summary>Creates a new <see cref="AVAssetDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAssetDownloadDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected AVAssetDownloadDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVAssetDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:aggregateAssetDownloadTask:didCompleteForMediaSelection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteForMediaSelection (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, AVMediaSelection mediaSelection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didCompleteWithError:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteWithError (NSUrlSession session, NSUrlSessionTask task, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:didCreateTask:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCreateTask (NSUrlSession session, NSUrlSessionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="metrics">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didFinishCollectingMetrics:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishCollectingMetrics (NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:assetDownloadTask:didFinishDownloadingToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDownloadingToUrl (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:assetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadTimeRange (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="timeRange">To be added.</param><param name="loadedTimeRanges">To be added.</param><param name="timeRangeExpectedToLoad">To be added.</param><param name="mediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:aggregateAssetDownloadTask:didLoadTimeRange:totalTimeRangesLoaded:timeRangeExpectedToLoad:forMediaSelection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadTimeRange (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, global::CoreMedia.CMTimeRange timeRange, NSValue[] loadedTimeRanges, global::CoreMedia.CMTimeRange timeRangeExpectedToLoad, AVMediaSelection mediaSelection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="challenge">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didReceiveChallenge:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:task:didReceiveInformationalResponse:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveInformationalResponse (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:assetDownloadTask:didReceiveMetricEvent:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMetricEvent (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMetricEvent metricEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="assetDownloadTask">To be added.</param><param name="resolvedMediaSelection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:assetDownloadTask:didResolveMediaSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResolveMediaSelection (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVMediaSelection resolvedMediaSelection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="bytesSent">To be added.</param><param name="totalBytesSent">To be added.</param><param name="totalBytesExpectedToSend">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSendBodyData (NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:needNewBodyStream:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSInputStream> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:task:needNewBodyStreamFromOffset:completionHandler:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void NeedNewBodyStream (NSUrlSession session, NSUrlSessionTask task, long offset, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSInputStream> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:taskIsWaitingForConnectivity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TaskIsWaitingForConnectivity (NSUrlSession session, NSUrlSessionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="request">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:willBeginDelayedRequest:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillBeginDelayedRequest (NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V8))]global::System.Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="aggregateAssetDownloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:aggregateAssetDownloadTask:willDownloadToURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDownloadToUrl (NSUrlSession session, AVAggregateAssetDownloadTask aggregateAssetDownloadTask, NSUrl location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:assetDownloadTask:willDownloadVariants:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDownloadVariants (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, AVAssetVariant[] variants)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="task">To be added.</param><param name="response">To be added.</param><param name="newRequest">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPerformHttpRedirection (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSUrlRequest> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("URLSession:assetDownloadTask:willDownloadToURL:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WilllDownloadToUrl (NSUrlSession session, AVAssetDownloadTask assetDownloadTask, NSUrl location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAssetDownloadDelegate */
}
