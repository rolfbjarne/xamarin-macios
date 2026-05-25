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
namespace AVFoundation {
	[Register("AVAsynchronousVideoCompositionRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAsynchronousVideoCompositionRequest : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachSpatialVideoConfiguration_ToPixelBuffer_X = "attachSpatialVideoConfiguration:toPixelBuffer:";
		static readonly NativeHandle selAttachSpatialVideoConfiguration_ToPixelBuffer_XHandle = Selector.GetHandle ("attachSpatialVideoConfiguration:toPixelBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositionTimeX = "compositionTime";
		static readonly NativeHandle selCompositionTimeXHandle = Selector.GetHandle ("compositionTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishCancelledRequestX = "finishCancelledRequest";
		static readonly NativeHandle selFinishCancelledRequestXHandle = Selector.GetHandle ("finishCancelledRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishWithComposedTaggedBufferGroup_X = "finishWithComposedTaggedBufferGroup:";
		static readonly NativeHandle selFinishWithComposedTaggedBufferGroup_XHandle = Selector.GetHandle ("finishWithComposedTaggedBufferGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishWithComposedVideoFrame_X = "finishWithComposedVideoFrame:";
		static readonly NativeHandle selFinishWithComposedVideoFrame_XHandle = Selector.GetHandle ("finishWithComposedVideoFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishWithError_X = "finishWithError:";
		static readonly NativeHandle selFinishWithError_XHandle = Selector.GetHandle ("finishWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderContextX = "renderContext";
		static readonly NativeHandle selRenderContextXHandle = Selector.GetHandle ("renderContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceFrameByTrackID_X = "sourceFrameByTrackID:";
		static readonly NativeHandle selSourceFrameByTrackID_XHandle = Selector.GetHandle ("sourceFrameByTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceSampleBufferByTrackID_X = "sourceSampleBufferByTrackID:";
		static readonly NativeHandle selSourceSampleBufferByTrackID_XHandle = Selector.GetHandle ("sourceSampleBufferByTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceSampleDataTrackIDsX = "sourceSampleDataTrackIDs";
		static readonly NativeHandle selSourceSampleDataTrackIDsXHandle = Selector.GetHandle ("sourceSampleDataTrackIDs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceTaggedBufferGroupByTrackID_X = "sourceTaggedBufferGroupByTrackID:";
		static readonly NativeHandle selSourceTaggedBufferGroupByTrackID_XHandle = Selector.GetHandle ("sourceTaggedBufferGroupByTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceTimedMetadataByTrackID_X = "sourceTimedMetadataByTrackID:";
		static readonly NativeHandle selSourceTimedMetadataByTrackID_XHandle = Selector.GetHandle ("sourceTimedMetadataByTrackID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceTrackIDsX = "sourceTrackIDs";
		static readonly NativeHandle selSourceTrackIDsXHandle = Selector.GetHandle ("sourceTrackIDs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCompositionInstructionX = "videoCompositionInstruction";
		static readonly NativeHandle selVideoCompositionInstructionXHandle = Selector.GetHandle ("videoCompositionInstruction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAsynchronousVideoCompositionRequest");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVAsynchronousVideoCompositionRequest" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAsynchronousVideoCompositionRequest () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected AVAsynchronousVideoCompositionRequest (NSObjectFlag t) : base (t)
		{
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
		protected internal AVAsynchronousVideoCompositionRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("attachSpatialVideoConfiguration:toPixelBuffer:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AttachSpatialVideoConfiguration (AVSpatialVideoConfiguration? spatialVideoConfiguration, global::CoreVideo.CVPixelBuffer pixelBuffer)
		{
			var spatialVideoConfiguration__handle__ = spatialVideoConfiguration.GetHandle ();
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAttachSpatialVideoConfiguration_ToPixelBuffer_XHandle, spatialVideoConfiguration__handle__, pixelBuffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAttachSpatialVideoConfiguration_ToPixelBuffer_XHandle, spatialVideoConfiguration__handle__, pixelBuffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (spatialVideoConfiguration);
			GC.KeepAlive (pixelBuffer);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("finishCancelledRequest")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishCancelledRequest ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishCancelledRequestXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinishCancelledRequestXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finishWithComposedTaggedBufferGroup:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishWithComposedTaggedBufferGroup (global::CoreMedia.CMTaggedBufferGroup taggedBufferGroup)
		{
			var taggedBufferGroup__handle__ = taggedBufferGroup!.GetNonNullHandle (nameof (taggedBufferGroup));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishWithComposedTaggedBufferGroup_XHandle, taggedBufferGroup.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishWithComposedTaggedBufferGroup_XHandle, taggedBufferGroup.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (taggedBufferGroup);
		}
		[Export ("finishWithComposedVideoFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishWithComposedVideoFrame (global::CoreVideo.CVPixelBuffer composedVideoFrame)
		{
			var composedVideoFrame__handle__ = composedVideoFrame!.GetNonNullHandle (nameof (composedVideoFrame));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishWithComposedVideoFrame_XHandle, composedVideoFrame__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishWithComposedVideoFrame_XHandle, composedVideoFrame__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (composedVideoFrame);
		}
		[Export ("finishWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishWithError_XHandle, error__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishWithError_XHandle, error__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (error);
		}
		[Export ("sourceSampleBufferByTrackID:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMSampleBuffer? GetSourceSampleBuffer (int trackId)
		{
			global::CoreMedia.CMSampleBuffer ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreMedia.CMSampleBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selSourceSampleBufferByTrackID_XHandle, trackId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreMedia.CMSampleBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selSourceSampleBufferByTrackID_XHandle, trackId), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceTaggedBufferGroupByTrackID:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTaggedBufferGroup? GetSourceTaggedBufferGroup (int trackId)
		{
			global::CoreMedia.CMTaggedBufferGroup ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreMedia.CMTaggedBufferGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selSourceTaggedBufferGroupByTrackID_XHandle, trackId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreMedia.CMTaggedBufferGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selSourceTaggedBufferGroupByTrackID_XHandle, trackId), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceTimedMetadataByTrackID:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVTimedMetadataGroup? GetSourceTimedMetadata (int trackId)
		{
			AVTimedMetadataGroup ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVTimedMetadataGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selSourceTimedMetadataByTrackID_XHandle, trackId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVTimedMetadataGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selSourceTimedMetadataByTrackID_XHandle, trackId), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceFrameByTrackID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreVideo.CVPixelBuffer? SourceFrameByTrackID (int trackID)
		{
			global::CoreVideo.CVPixelBuffer ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selSourceFrameByTrackID_XHandle, trackID), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selSourceFrameByTrackID_XHandle, trackID), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime CompositionTime {
			[Export ("compositionTime", ArgumentSemantic.Copy)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selCompositionTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selCompositionTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selCompositionTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selCompositionTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVVideoCompositionRenderContext RenderContext {
			[Export ("renderContext", ArgumentSemantic.Copy)]
			get {
				AVVideoCompositionRenderContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVVideoCompositionRenderContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRenderContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVVideoCompositionRenderContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRenderContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] SourceSampleDataTrackIds {
			[Export ("sourceSampleDataTrackIDs")]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceSampleDataTrackIDsXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceSampleDataTrackIDsXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] SourceTrackIDs {
			[Export ("sourceTrackIDs")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceTrackIDsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceTrackIDsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVVideoCompositionInstruction VideoCompositionInstruction {
			[Export ("videoCompositionInstruction", ArgumentSemantic.Copy)]
			get {
				AVVideoCompositionInstruction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVVideoCompositionInstruction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoCompositionInstructionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVVideoCompositionInstruction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoCompositionInstructionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVAsynchronousVideoCompositionRequest */
}
