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
	/// <summary>A file containing audio data.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiofile">Apple documentation for <c>AVAudioFile</c></related>
	[Register("AVAudioFile", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioFile : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseX = "close";
		static readonly NativeHandle selCloseXHandle = Selector.GetHandle ("close");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileFormatX = "fileFormat";
		static readonly NativeHandle selFileFormatXHandle = Selector.GetHandle ("fileFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFramePositionX = "framePosition";
		static readonly NativeHandle selFramePositionXHandle = Selector.GetHandle ("framePosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForReading_CommonFormat_Interleaved_Error_X = "initForReading:commonFormat:interleaved:error:";
		static readonly NativeHandle selInitForReading_CommonFormat_Interleaved_Error_XHandle = Selector.GetHandle ("initForReading:commonFormat:interleaved:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForReading_Error_X = "initForReading:error:";
		static readonly NativeHandle selInitForReading_Error_XHandle = Selector.GetHandle ("initForReading:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForWriting_Settings_CommonFormat_Interleaved_Error_X = "initForWriting:settings:commonFormat:interleaved:error:";
		static readonly NativeHandle selInitForWriting_Settings_CommonFormat_Interleaved_Error_XHandle = Selector.GetHandle ("initForWriting:settings:commonFormat:interleaved:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForWriting_Settings_Error_X = "initForWriting:settings:error:";
		static readonly NativeHandle selInitForWriting_Settings_Error_XHandle = Selector.GetHandle ("initForWriting:settings:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOpenX = "isOpen";
		static readonly NativeHandle selIsOpenXHandle = Selector.GetHandle ("isOpen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLengthX = "length";
		static readonly NativeHandle selLengthXHandle = Selector.GetHandle ("length");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessingFormatX = "processingFormat";
		static readonly NativeHandle selProcessingFormatXHandle = Selector.GetHandle ("processingFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadIntoBuffer_Error_X = "readIntoBuffer:error:";
		static readonly NativeHandle selReadIntoBuffer_Error_XHandle = Selector.GetHandle ("readIntoBuffer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadIntoBuffer_FrameCount_Error_X = "readIntoBuffer:frameCount:error:";
		static readonly NativeHandle selReadIntoBuffer_FrameCount_Error_XHandle = Selector.GetHandle ("readIntoBuffer:frameCount:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFramePosition_X = "setFramePosition:";
		static readonly NativeHandle selSetFramePosition_XHandle = Selector.GetHandle ("setFramePosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUrlX = "url";
		static readonly NativeHandle selUrlXHandle = Selector.GetHandle ("url");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteFromBuffer_Error_X = "writeFromBuffer:error:";
		static readonly NativeHandle selWriteFromBuffer_Error_XHandle = Selector.GetHandle ("writeFromBuffer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioFile");
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
		protected AVAudioFile (NSObjectFlag t) : base (t)
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
		protected internal AVAudioFile (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[ObsoletedOSPlatform ("ios26.0", "Use any of the other constructors instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use any of the other constructors instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use any of the other constructors instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use any of the other constructors instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudioFile ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="fileUrl">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initForReading:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVAudioFile (NSUrl fileUrl, out NSError outError)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			NativeHandle outErrorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitForReading_Error_XHandle, fileUrl__handle__, &outErrorValue), "initForReading:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitForReading_Error_XHandle, fileUrl__handle__, &outErrorValue), "initForReading:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		/// <param name="fileUrl">To be added.</param><param name="format">To be added.</param><param name="interleaved">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initForReading:commonFormat:interleaved:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVAudioFile (NSUrl fileUrl, AVAudioCommonFormat format, bool interleaved, out NSError outError)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			NativeHandle outErrorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_bool_ref_NativeHandle (this.Handle, selInitForReading_CommonFormat_Interleaved_Error_XHandle, fileUrl__handle__, (UIntPtr) (ulong) format, interleaved ? (byte) 1 : (byte) 0, &outErrorValue), "initForReading:commonFormat:interleaved:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_bool_ref_NativeHandle (&__objc_super__, selInitForReading_CommonFormat_Interleaved_Error_XHandle, fileUrl__handle__, (UIntPtr) (ulong) format, interleaved ? (byte) 1 : (byte) 0, &outErrorValue), "initForReading:commonFormat:interleaved:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		[Export ("initForWriting:settings:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe AVAudioFile (NSUrl fileUrl, NSDictionary settings, out NSError outError)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var settings__handle__ = settings!.GetNonNullHandle (nameof (settings));
			NativeHandle outErrorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selInitForWriting_Settings_Error_XHandle, fileUrl__handle__, settings__handle__, &outErrorValue), "initForWriting:settings:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selInitForWriting_Settings_Error_XHandle, fileUrl__handle__, settings__handle__, &outErrorValue), "initForWriting:settings:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (settings);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		/// <param name="fileUrl">To be added.</param><param name="settings">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVAudioFile (NSUrl fileUrl, AudioSettings settings, out NSError outError)
			: this (fileUrl, settings.GetDictionary ()!, out outError)
		{
		}
		[Export ("initForWriting:settings:commonFormat:interleaved:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe AVAudioFile (NSUrl fileUrl, NSDictionary settings, AVAudioCommonFormat format, bool interleaved, out NSError outError)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var settings__handle__ = settings!.GetNonNullHandle (nameof (settings));
			NativeHandle outErrorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_bool_ref_NativeHandle (this.Handle, selInitForWriting_Settings_CommonFormat_Interleaved_Error_XHandle, fileUrl__handle__, settings__handle__, (UIntPtr) (ulong) format, interleaved ? (byte) 1 : (byte) 0, &outErrorValue), "initForWriting:settings:commonFormat:interleaved:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_bool_ref_NativeHandle (&__objc_super__, selInitForWriting_Settings_CommonFormat_Interleaved_Error_XHandle, fileUrl__handle__, settings__handle__, (UIntPtr) (ulong) format, interleaved ? (byte) 1 : (byte) 0, &outErrorValue), "initForWriting:settings:commonFormat:interleaved:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (settings);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		/// <param name="fileUrl">To be added.</param><param name="settings">To be added.</param><param name="format">To be added.</param><param name="interleaved">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVAudioFile (NSUrl fileUrl, AudioSettings settings, AVAudioCommonFormat format, bool interleaved, out NSError outError)
			: this (fileUrl, settings.GetDictionary ()!, format, interleaved, out outError)
		{
		}
		[Export ("close")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Close ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCloseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="buffer">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readIntoBuffer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReadIntoBuffer (AVAudioPcmBuffer buffer, out NSError outError)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selReadIntoBuffer_Error_XHandle, buffer__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selReadIntoBuffer_Error_XHandle, buffer__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="buffer">To be added.</param><param name="frames">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readIntoBuffer:frameCount:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ReadIntoBuffer (AVAudioPcmBuffer buffer, uint frames, out NSError outError)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UInt32_ref_NativeHandle (this.Handle, selReadIntoBuffer_FrameCount_Error_XHandle, buffer__handle__, frames, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_UInt32_ref_NativeHandle (&__objc_super__, selReadIntoBuffer_FrameCount_Error_XHandle, buffer__handle__, frames, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="buffer">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeFromBuffer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteFromBuffer (AVAudioPcmBuffer buffer, out NSError outError)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selWriteFromBuffer_Error_XHandle, buffer__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selWriteFromBuffer_Error_XHandle, buffer__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (buffer);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <summary>The <see cref="T:AVFoundation.AVAudioFormat" /> of the file.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioFormat FileFormat {
			[Export ("fileFormat")]
			get {
				AVAudioFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The offset within the file of the next read or write operation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long FramePosition {
			[Export ("framePosition")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selFramePositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selFramePositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFramePosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, selSetFramePosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, selSetFramePosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool IsOpen {
			[Export ("isOpen")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOpenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOpenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long Length {
			[Export ("length")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The processing <see cref="T:AVFoundation.AVAudioFormat" /> of the file.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioFormat ProcessingFormat {
			[Export ("processingFormat")]
			get {
				AVAudioFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProcessingFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProcessingFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Url {
			[Export ("url")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUrlXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUrlXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVAudioFile */
}
