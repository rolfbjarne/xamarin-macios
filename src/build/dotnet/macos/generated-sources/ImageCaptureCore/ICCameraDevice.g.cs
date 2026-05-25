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
namespace ImageCaptureCore {
	[Register("ICCameraDevice", true)]
	public unsafe partial class ICCameraDevice : ICDevice {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatteryLevelX = "batteryLevel";
		static readonly NativeHandle selBatteryLevelXHandle = Selector.GetHandle ("batteryLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatteryLevelAvailableX = "batteryLevelAvailable";
		static readonly NativeHandle selBatteryLevelAvailableXHandle = Selector.GetHandle ("batteryLevelAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelDeleteX = "cancelDelete";
		static readonly NativeHandle selCancelDeleteXHandle = Selector.GetHandle ("cancelDelete");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelDownloadX = "cancelDownload";
		static readonly NativeHandle selCancelDownloadXHandle = Selector.GetHandle ("cancelDownload");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentCatalogPercentCompletedX = "contentCatalogPercentCompleted";
		static readonly NativeHandle selContentCatalogPercentCompletedXHandle = Selector.GetHandle ("contentCatalogPercentCompleted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsX = "contents";
		static readonly NativeHandle selContentsXHandle = Selector.GetHandle ("contents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilesOfType_X = "filesOfType:";
		static readonly NativeHandle selFilesOfType_XHandle = Selector.GetHandle ("filesOfType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessRestrictedAppleDeviceX = "isAccessRestrictedAppleDevice";
		static readonly NativeHandle selIsAccessRestrictedAppleDeviceXHandle = Selector.GetHandle ("isAccessRestrictedAppleDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMediaFilesX = "mediaFiles";
		static readonly NativeHandle selMediaFilesXHandle = Selector.GetHandle ("mediaFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMountPointX = "mountPoint";
		static readonly NativeHandle selMountPointXHandle = Selector.GetHandle ("mountPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestDeleteFiles_X = "requestDeleteFiles:";
		static readonly NativeHandle selRequestDeleteFiles_XHandle = Selector.GetHandle ("requestDeleteFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestDisableTetheringX = "requestDisableTethering";
		static readonly NativeHandle selRequestDisableTetheringXHandle = Selector.GetHandle ("requestDisableTethering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_X = "requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:";
		static readonly NativeHandle selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_XHandle = Selector.GetHandle ("requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestEnableTetheringX = "requestEnableTethering";
		static readonly NativeHandle selRequestEnableTetheringXHandle = Selector.GetHandle ("requestEnableTethering");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_X = "requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:";
		static readonly NativeHandle selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_XHandle = Selector.GetHandle ("requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_X = "requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:";
		static readonly NativeHandle selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_XHandle = Selector.GetHandle ("requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestSyncClockX = "requestSyncClock";
		static readonly NativeHandle selRequestSyncClockXHandle = Selector.GetHandle ("requestSyncClock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestTakePictureX = "requestTakePicture";
		static readonly NativeHandle selRequestTakePictureXHandle = Selector.GetHandle ("requestTakePicture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_X = "requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:";
		static readonly NativeHandle selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_XHandle = Selector.GetHandle ("requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTetheredCaptureEnabledX = "tetheredCaptureEnabled";
		static readonly NativeHandle selTetheredCaptureEnabledXHandle = Selector.GetHandle ("tetheredCaptureEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeOffsetX = "timeOffset";
		static readonly NativeHandle selTimeOffsetXHandle = Selector.GetHandle ("timeOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ICCameraDevice");
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
		protected ICCameraDevice (NSObjectFlag t) : base (t)
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
		protected internal ICCameraDevice (NativeHandle handle) : base (handle)
		{
		}

		[Export ("cancelDelete")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelDelete ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelDeleteXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelDeleteXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cancelDownload")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelDownload ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelDownloadXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelDownloadXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("filesOfType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetFiles (string fileUTType)
		{
			if (fileUTType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileUTType));
			var nsfileUTType = CFString.CreateNative (fileUTType);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFilesOfType_XHandle, nsfileUTType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFilesOfType_XHandle, nsfileUTType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileUTType);
			return ret!;
		}
		[Export ("requestDeleteFiles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestDeleteFiles (ICCameraItem[] files)
		{
			if (files is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (files));
			using var nsa_files = NSArray.FromNSObjects (files);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestDeleteFiles_XHandle, nsa_files.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestDeleteFiles_XHandle, nsa_files.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestDisableTethering")]
		[ObsoletedOSPlatform ("macos14.0", "Third party cameras that support the standard take picture command will have the capability enabled by default. This call will have no effect.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestDisableTethering ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestDisableTetheringXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestDisableTetheringXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestDownloadFile (ICCameraFile file, NSDictionary<NSString, NSObject> options, IICCameraDeviceDownloadDelegate downloadDelegate, Selector didDownloadSelector, nint contextInfo)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var downloadDelegate__handle__ = downloadDelegate!.GetNonNullHandle (nameof (downloadDelegate));
			var didDownloadSelector__handle__ = didDownloadSelector!.GetNonNullHandle (nameof (didDownloadSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_XHandle, file__handle__, options__handle__, downloadDelegate__handle__, didDownloadSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_XHandle, file__handle__, options__handle__, downloadDelegate__handle__, didDownloadSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (options);
			GC.KeepAlive (downloadDelegate);
			GC.KeepAlive (didDownloadSelector);
		}
		[Export ("requestEnableTethering")]
		[ObsoletedOSPlatform ("macos14.0", "Third party cameras that support the standard take picture command will have the capability enabled by default. This call will have no effect.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestEnableTethering ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestEnableTetheringXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestEnableTetheringXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestReadDataFromFile (ICCameraFile file, long offset, long length, NSObject readDelegate, Selector didReadDataSelector, nint contextInfo)
		{
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var readDelegate__handle__ = readDelegate!.GetNonNullHandle (nameof (readDelegate));
			var didReadDataSelector__handle__ = didReadDataSelector!.GetNonNullHandle (nameof (didReadDataSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64_NativeHandle_NativeHandle_IntPtr (this.Handle, selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_XHandle, file__handle__, offset, length, readDelegate__handle__, didReadDataSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Int64_Int64_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_XHandle, file__handle__, offset, length, readDelegate__handle__, didReadDataSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (file);
			GC.KeepAlive (readDelegate);
			GC.KeepAlive (didReadDataSelector);
		}
		[Export ("requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestSendPtpCommand (NSData command, NSData outData, NSObject sendCommandDelegate, Selector didSendCommandSelector, nint contextInfo)
		{
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			var outData__handle__ = outData!.GetNonNullHandle (nameof (outData));
			var sendCommandDelegate__handle__ = sendCommandDelegate!.GetNonNullHandle (nameof (sendCommandDelegate));
			var didSendCommandSelector__handle__ = didSendCommandSelector!.GetNonNullHandle (nameof (didSendCommandSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_XHandle, command__handle__, outData__handle__, sendCommandDelegate__handle__, didSendCommandSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_XHandle, command__handle__, outData__handle__, sendCommandDelegate__handle__, didSendCommandSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (command);
			GC.KeepAlive (outData);
			GC.KeepAlive (sendCommandDelegate);
			GC.KeepAlive (didSendCommandSelector);
		}
		[Export ("requestSyncClock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestSyncClock ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestSyncClockXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestSyncClockXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestTakePicture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestTakePicture ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestTakePictureXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRequestTakePictureXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:")]
		[ObsoletedOSPlatform ("macos14.0", "Sandbox restrictions prohibit writing directly to device hardware.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestUploadFile (NSUrl fileUrl, NSDictionary<NSString, NSObject> options, NSObject uploadDelegate, Selector didUploadSelector, nint contextInfo)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var uploadDelegate__handle__ = uploadDelegate!.GetNonNullHandle (nameof (uploadDelegate));
			var didUploadSelector__handle__ = didUploadSelector!.GetNonNullHandle (nameof (didUploadSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_XHandle, fileUrl__handle__, options__handle__, uploadDelegate__handle__, didUploadSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_XHandle, fileUrl__handle__, options__handle__, uploadDelegate__handle__, didUploadSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (options);
			GC.KeepAlive (uploadDelegate);
			GC.KeepAlive (didUploadSelector);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint BatteryLevel {
			[Export ("batteryLevel")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selBatteryLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selBatteryLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BatteryLevelAvailable {
			[Export ("batteryLevelAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBatteryLevelAvailableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBatteryLevelAvailableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ContentCatalogPercentCompleted {
			[Export ("contentCatalogPercentCompleted")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selContentCatalogPercentCompletedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selContentCatalogPercentCompletedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ICCameraItem[]? Contents {
			[Export ("contents")]
			get {
				ICCameraItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ICCameraItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ICCameraItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAccessRestrictedAppleDevice {
			[Export ("isAccessRestrictedAppleDevice")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessRestrictedAppleDeviceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessRestrictedAppleDeviceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ICCameraItem[]? MediaFiles {
			[Export ("mediaFiles")]
			get {
				ICCameraItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ICCameraItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMediaFilesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ICCameraItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMediaFilesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MountPoint {
			[Export ("mountPoint")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMountPointXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMountPointXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TetheredCaptureEnabled {
			[Export ("tetheredCaptureEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTetheredCaptureEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTetheredCaptureEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeOffset {
			[Export ("timeOffset")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class ICCameraDevice */
}
