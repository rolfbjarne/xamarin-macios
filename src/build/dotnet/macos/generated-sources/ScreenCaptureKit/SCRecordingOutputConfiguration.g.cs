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
namespace ScreenCaptureKit {
	[Register("SCRecordingOutputConfiguration", true)]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	public unsafe partial class SCRecordingOutputConfiguration : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableOutputFileTypesX = "availableOutputFileTypes";
		static readonly NativeHandle selAvailableOutputFileTypesXHandle = Selector.GetHandle ("availableOutputFileTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableVideoCodecTypesX = "availableVideoCodecTypes";
		static readonly NativeHandle selAvailableVideoCodecTypesXHandle = Selector.GetHandle ("availableVideoCodecTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFileTypeX = "outputFileType";
		static readonly NativeHandle selOutputFileTypeXHandle = Selector.GetHandle ("outputFileType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputURLX = "outputURL";
		static readonly NativeHandle selOutputURLXHandle = Selector.GetHandle ("outputURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputFileType_X = "setOutputFileType:";
		static readonly NativeHandle selSetOutputFileType_XHandle = Selector.GetHandle ("setOutputFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputURL_X = "setOutputURL:";
		static readonly NativeHandle selSetOutputURL_XHandle = Selector.GetHandle ("setOutputURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVideoCodecType_X = "setVideoCodecType:";
		static readonly NativeHandle selSetVideoCodecType_XHandle = Selector.GetHandle ("setVideoCodecType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVideoCodecTypeX = "videoCodecType";
		static readonly NativeHandle selVideoCodecTypeXHandle = Selector.GetHandle ("videoCodecType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCRecordingOutputConfiguration");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCRecordingOutputConfiguration" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCRecordingOutputConfiguration () : base (NSObjectFlag.Empty)
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
		protected SCRecordingOutputConfiguration (NSObjectFlag t) : base (t)
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
		protected internal SCRecordingOutputConfiguration (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (global::AVFoundation.AVFileTypes[]), OriginalType = typeof (NSString[]))]
		public virtual global::AVFoundation.AVFileTypes[] AvailableOutputFileTypes {
			[Export ("availableOutputFileTypes")]
			get {
				global::AVFoundation.AVFileTypes[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVFileTypes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableOutputFileTypesXHandle), global::AVFoundation.AVFileTypesExtensions.GetValue , false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVFileTypes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableOutputFileTypesXHandle), global::AVFoundation.AVFileTypesExtensions.GetValue , false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (global::AVFoundation.AVVideoCodecType[]), OriginalType = typeof (NSString[]))]
		public virtual global::AVFoundation.AVVideoCodecType[] AvailableVideoCodecTypes {
			[Export ("availableVideoCodecTypes")]
			get {
				global::AVFoundation.AVVideoCodecType[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVVideoCodecType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableVideoCodecTypesXHandle), global::AVFoundation.AVVideoCodecTypeExtensions.GetValue , false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVVideoCodecType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableVideoCodecTypesXHandle), global::AVFoundation.AVVideoCodecTypeExtensions.GetValue , false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (global::AVFoundation.AVFileTypes), OriginalType = typeof (NSString))]
		public virtual global::AVFoundation.AVFileTypes OutputFileType {
			[Export ("outputFileType", ArgumentSemantic.Copy)]
			get {
				global::AVFoundation.AVFileTypes ret;
				if (IsDirectBinding) {
					ret = global::AVFoundation.AVFileTypesExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputFileTypeXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::AVFoundation.AVFileTypesExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputFileTypeXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputFileType:", ArgumentSemantic.Copy)]
			set {
				using var nsb_OutputFileType = global::AVFoundation.AVFileTypesExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputFileType_XHandle, nsb_OutputFileType.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputFileType_XHandle, nsb_OutputFileType.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl OutputUrl {
			[Export ("outputURL", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputURL:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutputURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutputURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (global::AVFoundation.AVVideoCodecType), OriginalType = typeof (NSString))]
		public virtual global::AVFoundation.AVVideoCodecType VideoCodecType {
			[Export ("videoCodecType", ArgumentSemantic.Copy)]
			get {
				global::AVFoundation.AVVideoCodecType ret;
				if (IsDirectBinding) {
					ret = global::AVFoundation.AVVideoCodecTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVideoCodecTypeXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::AVFoundation.AVVideoCodecTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVideoCodecTypeXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoCodecType:", ArgumentSemantic.Copy)]
			set {
				using var nsb_VideoCodecType = global::AVFoundation.AVVideoCodecTypeExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVideoCodecType_XHandle, nsb_VideoCodecType.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVideoCodecType_XHandle, nsb_VideoCodecType.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SCRecordingOutputConfiguration */
}
