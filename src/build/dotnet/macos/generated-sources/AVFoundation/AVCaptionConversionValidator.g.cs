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
	[Register("AVCaptionConversionValidator", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios18.0")]
	public unsafe partial class AVCaptionConversionValidator : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptionConversionValidatorWithCaptions_TimeRange_ConversionSettings_X = "captionConversionValidatorWithCaptions:timeRange:conversionSettings:";
		static readonly NativeHandle selCaptionConversionValidatorWithCaptions_TimeRange_ConversionSettings_XHandle = Selector.GetHandle ("captionConversionValidatorWithCaptions:timeRange:conversionSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptionsX = "captions";
		static readonly NativeHandle selCaptionsXHandle = Selector.GetHandle ("captions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCaptions_TimeRange_ConversionSettings_X = "initWithCaptions:timeRange:conversionSettings:";
		static readonly NativeHandle selInitWithCaptions_TimeRange_ConversionSettings_XHandle = Selector.GetHandle ("initWithCaptions:timeRange:conversionSettings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopValidatingX = "stopValidating";
		static readonly NativeHandle selStopValidatingXHandle = Selector.GetHandle ("stopValidating");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeRangeX = "timeRange";
		static readonly NativeHandle selTimeRangeXHandle = Selector.GetHandle ("timeRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateCaptionConversionWithWarningHandler_X = "validateCaptionConversionWithWarningHandler:";
		static readonly NativeHandle selValidateCaptionConversionWithWarningHandler_XHandle = Selector.GetHandle ("validateCaptionConversionWithWarningHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWarningsX = "warnings";
		static readonly NativeHandle selWarningsXHandle = Selector.GetHandle ("warnings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptionConversionValidator");
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
		protected AVCaptionConversionValidator (NSObjectFlag t) : base (t)
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
		protected internal AVCaptionConversionValidator (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCaptions:timeRange:conversionSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptionConversionValidator (AVCaption[] captions, global::CoreMedia.CMTimeRange timeRange, NSDictionary<NSString, NSObject> conversionSettings)
			: base (NSObjectFlag.Empty)
		{
			if (captions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (captions));
			var conversionSettings__handle__ = conversionSettings!.GetNonNullHandle (nameof (conversionSettings));
			using var nsa_captions = NSArray.FromNSObjects (captions);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CMTimeRange_NativeHandle (this.Handle, selInitWithCaptions_TimeRange_ConversionSettings_XHandle, nsa_captions.Handle, timeRange, conversionSettings__handle__), "initWithCaptions:timeRange:conversionSettings:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CMTimeRange_NativeHandle (&__objc_super__, selInitWithCaptions_TimeRange_ConversionSettings_XHandle, nsa_captions.Handle, timeRange, conversionSettings__handle__), "initWithCaptions:timeRange:conversionSettings:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (conversionSettings);
		}
		[Export ("captionConversionValidatorWithCaptions:timeRange:conversionSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVCaptionConversionValidator Create (AVCaption[] captions, global::CoreMedia.CMTimeRange timeRange, NSDictionary<NSString, NSObject> conversionSettings)
		{
			if (captions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (captions));
			var conversionSettings__handle__ = conversionSettings!.GetNonNullHandle (nameof (conversionSettings));
			using var nsa_captions = NSArray.FromNSObjects (captions);
			AVCaptionConversionValidator? ret;
			ret =  Runtime.GetNSObject<AVCaptionConversionValidator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CMTimeRange_NativeHandle (class_ptr, selCaptionConversionValidatorWithCaptions_TimeRange_ConversionSettings_XHandle, nsa_captions.Handle, timeRange, conversionSettings__handle__), false)!;
			GC.KeepAlive (conversionSettings);
			return ret!;
		}
		[Export ("stopValidating")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopValidating ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopValidatingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopValidatingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("validateCaptionConversionWithWarningHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateCaptionConversion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<AVCaptionConversionWarning> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V6.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selValidateCaptionConversionWithWarningHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateCaptionConversionWithWarningHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaption[] Captions {
			[Export ("captions")]
			get {
				AVCaption[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaption>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCaptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaption>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCaptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptionConversionValidatorStatus Status {
			[Export ("status")]
			get {
				AVCaptionConversionValidatorStatus ret;
				if (IsDirectBinding) {
					ret = (AVCaptionConversionValidatorStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AVCaptionConversionValidatorStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTimeRange TimeRange {
			[Export ("timeRange")]
			get {
				global::CoreMedia.CMTimeRange ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend (this.Handle, selTimeRangeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret (this.Handle, selTimeRangeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper (&__objc_super__, selTimeRangeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_stret (&__objc_super__, selTimeRangeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptionConversionWarning[] Warnings {
			[Export ("warnings")]
			get {
				AVCaptionConversionWarning[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AVCaptionConversionWarning>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWarningsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AVCaptionConversionWarning>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWarningsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVCaptionConversionValidator */
}
