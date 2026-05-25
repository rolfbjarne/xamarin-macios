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
namespace VideoToolbox {
	[Register("VTMotionBlurConfiguration", true)]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("macos15.4")]
	public unsafe partial class VTMotionBlurConfiguration : NSObject, IVTFrameProcessorConfiguration {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRevisionX = "defaultRevision";
		static readonly NativeHandle selDefaultRevisionXHandle = Selector.GetHandle ("defaultRevision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationPixelBufferAttributesX = "destinationPixelBufferAttributes";
		static readonly NativeHandle selDestinationPixelBufferAttributesXHandle = Selector.GetHandle ("destinationPixelBufferAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameHeightX = "frameHeight";
		static readonly NativeHandle selFrameHeightXHandle = Selector.GetHandle ("frameHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameSupportedPixelFormatsX = "frameSupportedPixelFormats";
		static readonly NativeHandle selFrameSupportedPixelFormatsXHandle = Selector.GetHandle ("frameSupportedPixelFormats");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameWidthX = "frameWidth";
		static readonly NativeHandle selFrameWidthXHandle = Selector.GetHandle ("frameWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrameWidth_FrameHeight_UsePrecomputedFlow_QualityPrioritization_Revision_X = "initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:";
		static readonly NativeHandle selInitWithFrameWidth_FrameHeight_UsePrecomputedFlow_QualityPrioritization_Revision_XHandle = Selector.GetHandle ("initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSupportedX = "isSupported";
		static readonly NativeHandle selIsSupportedXHandle = Selector.GetHandle ("isSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumDimensionsX = "maximumDimensions";
		static readonly NativeHandle selMaximumDimensionsXHandle = Selector.GetHandle ("maximumDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumDimensionsX = "minimumDimensions";
		static readonly NativeHandle selMinimumDimensionsXHandle = Selector.GetHandle ("minimumDimensions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextFrameCountX = "nextFrameCount";
		static readonly NativeHandle selNextFrameCountXHandle = Selector.GetHandle ("nextFrameCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousFrameCountX = "previousFrameCount";
		static readonly NativeHandle selPreviousFrameCountXHandle = Selector.GetHandle ("previousFrameCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessorSupportedX = "processorSupported";
		static readonly NativeHandle selProcessorSupportedXHandle = Selector.GetHandle ("processorSupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQualityPrioritizationX = "qualityPrioritization";
		static readonly NativeHandle selQualityPrioritizationXHandle = Selector.GetHandle ("qualityPrioritization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevisionX = "revision";
		static readonly NativeHandle selRevisionXHandle = Selector.GetHandle ("revision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourcePixelBufferAttributesX = "sourcePixelBufferAttributes";
		static readonly NativeHandle selSourcePixelBufferAttributesXHandle = Selector.GetHandle ("sourcePixelBufferAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedRevisionsX = "supportedRevisions";
		static readonly NativeHandle selSupportedRevisionsXHandle = Selector.GetHandle ("supportedRevisions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsePrecomputedFlowX = "usePrecomputedFlow";
		static readonly NativeHandle selUsePrecomputedFlowXHandle = Selector.GetHandle ("usePrecomputedFlow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VTMotionBlurConfiguration");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected VTMotionBlurConfiguration (NSObjectFlag t) : base (t)
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
		protected internal VTMotionBlurConfiguration (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VTMotionBlurConfiguration (nint frameWidth, nint frameHeight, bool usePrecomputedFlow, VTMotionBlurConfigurationQualityPrioritization qualityPrioritization, VTMotionBlurConfigurationRevision revision)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_IntPtr (this.Handle, selInitWithFrameWidth_FrameHeight_UsePrecomputedFlow_QualityPrioritization_Revision_XHandle, frameWidth, frameHeight, usePrecomputedFlow ? (byte) 1 : (byte) 0, (IntPtr) (long) qualityPrioritization, (IntPtr) (long) revision), "initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_bool_IntPtr_IntPtr (&__objc_super__, selInitWithFrameWidth_FrameHeight_UsePrecomputedFlow_QualityPrioritization_Revision_XHandle, frameWidth, frameHeight, usePrecomputedFlow ? (byte) 1 : (byte) 0, (IntPtr) (long) qualityPrioritization, (IntPtr) (long) revision), "initWithFrameWidth:frameHeight:usePrecomputedFlow:qualityPrioritization:revision:");
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VTMotionBlurConfigurationRevision DefaultRevision {
			[Export ("defaultRevision")]
			get {
				VTMotionBlurConfigurationRevision ret;
				ret = (VideoToolbox.VTMotionBlurConfigurationRevision) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDefaultRevisionXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::CoreVideo.CVPixelBufferAttributes DestinationPixelBufferAttributes {
			get {
				var src = WeakDestinationPixelBufferAttributes is not null ? new NSMutableDictionary (WeakDestinationPixelBufferAttributes) : null;
				return src is null ? null! : new global::CoreVideo.CVPixelBufferAttributes(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint FrameHeight {
			[Export ("frameHeight")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFrameHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFrameHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual global::CoreVideo.CVPixelFormatType[] FrameSupportedPixelFormats {
			get {
				return Array.ConvertAll (this.WeakFrameSupportedPixelFormats, (v) => (CVPixelFormatType) v.UInt32Value);;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint FrameWidth {
			[Export ("frameWidth")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFrameWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFrameWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static global::CoreMedia.CMVideoDimensions MaximumDimensions {
			[Export ("maximumDimensions")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (class_ptr, selMaximumDimensionsXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static global::CoreMedia.CMVideoDimensions MinimumDimensions {
			[Export ("minimumDimensions")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (class_ptr, selMinimumDimensionsXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nint NextFrameCount {
			[Export ("nextFrameCount")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNextFrameCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNextFrameCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nint PreviousFrameCount {
			[Export ("previousFrameCount")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreviousFrameCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPreviousFrameCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'Supported' instead.")]
		[SupportedOSPlatform ("macos15.4")]
		public static bool ProcessorSupported {
			[Export ("processorSupported")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'Supported' instead.")]
			[SupportedOSPlatform ("macos15.4")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selProcessorSupportedXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VTMotionBlurConfigurationQualityPrioritization QualityPrioritization {
			[Export ("qualityPrioritization")]
			get {
				VTMotionBlurConfigurationQualityPrioritization ret;
				if (IsDirectBinding) {
					ret = (VideoToolbox.VTMotionBlurConfigurationQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selQualityPrioritizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (VideoToolbox.VTMotionBlurConfigurationQualityPrioritization) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selQualityPrioritizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VTMotionBlurConfigurationRevision Revision {
			[Export ("revision")]
			get {
				VTMotionBlurConfigurationRevision ret;
				if (IsDirectBinding) {
					ret = (VideoToolbox.VTMotionBlurConfigurationRevision) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRevisionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (VideoToolbox.VTMotionBlurConfigurationRevision) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRevisionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::CoreVideo.CVPixelBufferAttributes SourcePixelBufferAttributes {
			get {
				var src = WeakSourcePixelBufferAttributes is not null ? new NSMutableDictionary (WeakSourcePixelBufferAttributes) : null;
				return src is null ? null! : new global::CoreVideo.CVPixelBufferAttributes(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static bool Supported {
			[Export ("isSupported")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsSupportedXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::System.Collections.Generic.HashSet<VTMotionBlurConfigurationRevision> SupportedRevisions {
			get {
				return (WeakSupportedRevisions.ToInt64EnumHashSet<VTMotionBlurConfigurationRevision> () as global::System.Collections.Generic.HashSet<VTMotionBlurConfigurationRevision>)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsePrecomputedFlow {
			[Export ("usePrecomputedFlow")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsePrecomputedFlowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsePrecomputedFlowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual NSDictionary WeakDestinationPixelBufferAttributes {
			[Export ("destinationPixelBufferAttributes")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDestinationPixelBufferAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDestinationPixelBufferAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual NSNumber[] WeakFrameSupportedPixelFormats {
			[Export ("frameSupportedPixelFormats")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrameSupportedPixelFormatsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrameSupportedPixelFormatsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual NSDictionary WeakSourcePixelBufferAttributes {
			[Export ("sourcePixelBufferAttributes")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("macos15.4")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourcePixelBufferAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourcePixelBufferAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet WeakSupportedRevisions {
			[Export ("supportedRevisions")]
			get {
				NSIndexSet? ret;
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSupportedRevisionsXHandle), false)!;
				return ret!;
			}
		}
	} /* class VTMotionBlurConfiguration */
}
