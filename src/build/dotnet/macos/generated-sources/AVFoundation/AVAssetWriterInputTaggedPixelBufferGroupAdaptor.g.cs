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
	[Register("AVAssetWriterInputTaggedPixelBufferGroupAdaptor", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class AVAssetWriterInputTaggedPixelBufferGroupAdaptor : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendTaggedPixelBufferGroup_WithPresentationTime_X = "appendTaggedPixelBufferGroup:withPresentationTime:";
		static readonly NativeHandle selAppendTaggedPixelBufferGroup_WithPresentationTime_XHandle = Selector.GetHandle ("appendTaggedPixelBufferGroup:withPresentationTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWriterInputX = "assetWriterInput";
		static readonly NativeHandle selAssetWriterInputXHandle = Selector.GetHandle ("assetWriterInput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_X = "assetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:";
		static readonly NativeHandle selAssetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_XHandle = Selector.GetHandle ("assetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAssetWriterInput_SourcePixelBufferAttributes_X = "initWithAssetWriterInput:sourcePixelBufferAttributes:";
		static readonly NativeHandle selInitWithAssetWriterInput_SourcePixelBufferAttributes_XHandle = Selector.GetHandle ("initWithAssetWriterInput:sourcePixelBufferAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelBufferPoolX = "pixelBufferPool";
		static readonly NativeHandle selPixelBufferPoolXHandle = Selector.GetHandle ("pixelBufferPool");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourcePixelBufferAttributesX = "sourcePixelBufferAttributes";
		static readonly NativeHandle selSourcePixelBufferAttributesXHandle = Selector.GetHandle ("sourcePixelBufferAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetWriterInputTaggedPixelBufferGroupAdaptor");
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
		protected AVAssetWriterInputTaggedPixelBufferGroupAdaptor (NSObjectFlag t) : base (t)
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
		protected internal AVAssetWriterInputTaggedPixelBufferGroupAdaptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithAssetWriterInput:sourcePixelBufferAttributes:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetWriterInputTaggedPixelBufferGroupAdaptor (AVAssetWriterInput input, NSDictionary<NSString, NSObject>? sourcePixelBufferAttributes)
			: base (NSObjectFlag.Empty)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var sourcePixelBufferAttributes__handle__ = sourcePixelBufferAttributes.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithAssetWriterInput_SourcePixelBufferAttributes_XHandle, input__handle__, sourcePixelBufferAttributes__handle__), "initWithAssetWriterInput:sourcePixelBufferAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithAssetWriterInput_SourcePixelBufferAttributes_XHandle, input__handle__, sourcePixelBufferAttributes__handle__), "initWithAssetWriterInput:sourcePixelBufferAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (input);
			GC.KeepAlive (sourcePixelBufferAttributes);
		}
		[Export ("appendTaggedPixelBufferGroup:withPresentationTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Append (global::CoreMedia.CMTaggedBufferGroup taggedPixelBufferGroup, global::CoreMedia.CMTime presentationTime)
		{
			var taggedPixelBufferGroup__handle__ = taggedPixelBufferGroup!.GetNonNullHandle (nameof (taggedPixelBufferGroup));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CMTime (this.Handle, selAppendTaggedPixelBufferGroup_WithPresentationTime_XHandle, taggedPixelBufferGroup.Handle, presentationTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CMTime (&__objc_super__, selAppendTaggedPixelBufferGroup_WithPresentationTime_XHandle, taggedPixelBufferGroup.Handle, presentationTime);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (taggedPixelBufferGroup);
			return ret != 0;
		}
		[Export ("assetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetWriterInputTaggedPixelBufferGroupAdaptor Create (AVAssetWriterInput input, NSDictionary<NSString, NSObject>? sourcePixelBufferAttributes)
		{
			var input__handle__ = input!.GetNonNullHandle (nameof (input));
			var sourcePixelBufferAttributes__handle__ = sourcePixelBufferAttributes.GetHandle ();
			AVAssetWriterInputTaggedPixelBufferGroupAdaptor? ret;
			ret =  Runtime.GetNSObject<AVAssetWriterInputTaggedPixelBufferGroupAdaptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAssetWriterInputTaggedPixelBufferGroupAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_XHandle, input__handle__, sourcePixelBufferAttributes__handle__), false)!;
			GC.KeepAlive (input);
			GC.KeepAlive (sourcePixelBufferAttributes);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetWriterInput AssetWriterInput {
			[Export ("assetWriterInput")]
			get {
				AVAssetWriterInput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetWriterInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetWriterInputXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetWriterInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetWriterInputXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreVideo.CVPixelBufferPool? PixelBufferPool {
			[Export ("pixelBufferPool")]
			get {
				global::CoreVideo.CVPixelBufferPool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreVideo.CVPixelBufferPool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPixelBufferPoolXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreVideo.CVPixelBufferPool> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPixelBufferPoolXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? SourcePixelBufferAttributes {
			[Export ("sourcePixelBufferAttributes")]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourcePixelBufferAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourcePixelBufferAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVAssetWriterInputTaggedPixelBufferGroupAdaptor */
}
