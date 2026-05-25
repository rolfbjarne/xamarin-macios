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
namespace UIKit {
	/// <summary>Provides access to the system image and video capturing and selection facilities.</summary><remarks><para>
	/// The <see cref="T:UIKit.UIImagePickerController" /> is used both for taking images and movies and for selecting previously saved images and movies. The appearance and behavior of the <see cref="T:UIKit.UIImagePickerController" /> is determined by the <see cref="P:UIKit.UIImagePickerController.SourceType" /> property. 
	/// </para><para>Before using the <see cref="T:UIKit.UIImagePickerController" /> the application developer should verify the capabilities of the application user's device by checking:</para><list type="bullet"><item><term>Sources via the <see cref="M:UIKit.UIImagePickerController.IsSourceTypeAvailable(UIKit.UIImagePickerControllerSourceType)" /> method;</term></item><item><term>Cameras and flash via the <see cref="M:UIKit.UIImagePickerController.IsCameraDeviceAvailable(UIKit.UIImagePickerControllerCameraDevice)" /> and <see cref="M:UIKit.UIImagePickerController.IsFlashAvailableForCameraDevice(UIKit.UIImagePickerControllerCameraDevice)" /> methods; and</term></item><item><term>Media types via the <see cref="M:UIKit.UIImagePickerController.AvailableMediaTypes(UIKit.UIImagePickerControllerSourceType)" /> method.</term></item></list></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIImagePickerController_Class/index.html">Apple documentation for <c>UIImagePickerController</c></related>
	[Register("UIImagePickerController", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIImagePickerController : UINavigationController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIImagePickerController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIImagePickerController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIImagePickerController () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UIImagePickerController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected UIImagePickerController (NSObjectFlag t) : base (t)
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
		protected internal UIImagePickerController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("availableCaptureModesForCameraDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[]? AvailableCaptureModesForCameraDevice (UIImagePickerControllerCameraDevice cameraDevice)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("availableCaptureModesForCameraDevice:"), (IntPtr) (long) cameraDevice), false)!;
			return ret;
		}
		[Export ("availableMediaTypesForSourceType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[]? AvailableMediaTypes (UIImagePickerControllerSourceType sourceType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("availableMediaTypesForSourceType:"), (IntPtr) (long) sourceType), false)!;
			return ret;
		}
		[Export ("isCameraDeviceAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCameraDeviceAvailable (UIImagePickerControllerCameraDevice cameraDevice)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isCameraDeviceAvailable:"), (IntPtr) (long) cameraDevice);
			return ret != 0;
		}
		[Export ("isFlashAvailableForCameraDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsFlashAvailableForCameraDevice (UIImagePickerControllerCameraDevice cameraDevice)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isFlashAvailableForCameraDevice:"), (IntPtr) (long) cameraDevice);
			return ret != 0;
		}
		[Export ("isSourceTypeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSourceTypeAvailable (UIImagePickerControllerSourceType sourceType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isSourceTypeAvailable:"), (IntPtr) (long) sourceType);
			return ret != 0;
		}
		[Export ("startVideoCapture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartVideoCapture ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("startVideoCapture"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("startVideoCapture"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("stopVideoCapture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopVideoCapture ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopVideoCapture"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stopVideoCapture"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("takePicture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakePicture ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("takePicture"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("takePicture"));
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEditing {
			[Export ("allowsEditing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsEditing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsEditing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEditing:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsEditing:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsEditing:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImagePickerControllerCameraCaptureMode CameraCaptureMode {
			[Export ("cameraCaptureMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerCameraCaptureMode ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerCameraCaptureMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraCaptureMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerCameraCaptureMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraCaptureMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraCaptureMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraCaptureMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setCameraCaptureMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImagePickerControllerCameraDevice CameraDevice {
			[Export ("cameraDevice")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerCameraDevice ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerCameraDevice) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraDevice"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerCameraDevice) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraDevice"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraDevice:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraDevice:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setCameraDevice:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImagePickerControllerCameraFlashMode CameraFlashMode {
			[Export ("cameraFlashMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerCameraFlashMode ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerCameraFlashMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraFlashMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerCameraFlashMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraFlashMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraFlashMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraFlashMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setCameraFlashMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView CameraOverlayView {
			[Export ("cameraOverlayView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cameraOverlayView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraOverlayView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraOverlayView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCameraOverlayView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCameraOverlayView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform CameraViewTransform {
			[Export ("cameraViewTransform")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("cameraViewTransform"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("cameraViewTransform"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraViewTransform"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("cameraViewTransform"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setCameraViewTransform:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("setCameraViewTransform:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (&__objc_super__, Selector.GetHandle ("setCameraViewTransform:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual UIImagePickerControllerImageUrlExportPreset ImageExportPreset {
			[Export ("imageExportPreset", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerImageUrlExportPreset ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerImageUrlExportPreset) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageExportPreset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerImageUrlExportPreset) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageExportPreset"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImageExportPreset:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImageExportPreset:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setImageExportPreset:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] MediaTypes {
			[Export ("mediaTypes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaTypes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mediaTypes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMediaTypes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMediaTypes:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMediaTypes:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsCameraControls {
			[Export ("showsCameraControls")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsCameraControls"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsCameraControls"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsCameraControls:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsCameraControls:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsCameraControls:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImagePickerControllerSourceType SourceType {
			[Export ("sourceType")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerSourceType ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerSourceType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sourceType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerSourceType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sourceType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSourceType:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSourceType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSourceType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual string VideoExportPreset {
			[Export ("videoExportPreset")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("videoExportPreset")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoExportPreset")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVideoExportPreset:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setVideoExportPreset:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setVideoExportPreset:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double VideoMaximumDuration {
			[Export ("videoMaximumDuration")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("videoMaximumDuration"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoMaximumDuration"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVideoMaximumDuration:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setVideoMaximumDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setVideoMaximumDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImagePickerControllerQualityType VideoQuality {
			[Export ("videoQuality")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImagePickerControllerQualityType ret;
				if (IsDirectBinding) {
					ret = (UIImagePickerControllerQualityType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoQuality"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImagePickerControllerQualityType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("videoQuality"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVideoQuality:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVideoQuality:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setVideoQuality:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CropRect;
		/// <summary>Key for the editing information dictionary; indicates the cropped rectangle applied to the original image.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerCropRect",  "UIKit")]
		public static NSString CropRect {
			get {
				if (_CropRect is null)
					_CropRect = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerCropRect")!;
				return _CropRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EditedImage;
		/// <summary>Key for the editing information dictionary; indicates the image edited by the user.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerEditedImage",  "UIKit")]
		public static NSString EditedImage {
			get {
				if (_EditedImage is null)
					_EditedImage = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerEditedImage")!;
				return _EditedImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageUrl;
		/// <summary>Represents the value that is associated with the constant UIImagePickerControllerImageURL.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerImageURL",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString ImageUrl {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_ImageUrl is null)
					_ImageUrl = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerImageURL")!;
				return _ImageUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LivePhoto;
		/// <summary>Static <see cref="T:Foundation.NSString" /> used as a key indicating live photos.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerLivePhoto",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString LivePhoto {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_LivePhoto is null)
					_LivePhoto = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerLivePhoto")!;
				return _LivePhoto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaMetadata;
		/// <summary>Represents the value associated with the constant UIImagePickerControllerMediaMetadata</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerMediaMetadata",  "UIKit")]
		public static NSString MediaMetadata {
			get {
				if (_MediaMetadata is null)
					_MediaMetadata = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerMediaMetadata")!;
				return _MediaMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaType;
		/// <summary>A string indicating the type of media being picked.</summary><value>An array that indicates the media types that are to be accessed by the media picker controller.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerMediaType",  "UIKit")]
		public static NSString MediaType {
			get {
				if (_MediaType is null)
					_MediaType = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerMediaType")!;
				return _MediaType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaURL;
		/// <summary>The filesystem URL for a movie.</summary><value>String that indicates the URL that is to be accessed by the media picker controller.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerMediaURL",  "UIKit")]
		public static NSString MediaURL {
			get {
				if (_MediaURL is null)
					_MediaURL = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerMediaURL")!;
				return _MediaURL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginalImage;
		/// <summary>Key for the editing information dictionary; indicates the original, uncropped image selected by the user.</summary><value>String key for the editing information dictionary.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerOriginalImage",  "UIKit")]
		public static NSString OriginalImage {
			get {
				if (_OriginalImage is null)
					_OriginalImage = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerOriginalImage")!;
				return _OriginalImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PHAsset;
		/// <summary>Represents the value that is associated with the constant UIImagePickerControllerPHAsset.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerPHAsset",  "UIKit")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString PHAsset {
			[ObsoletedOSPlatform ("ios14.0", "Use 'PHPicker' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'PHPicker' instead.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_PHAsset is null)
					_PHAsset = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerPHAsset")!;
				return _PHAsset;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceUrl;
		/// <summary>Represents the value associated with the constant UIImagePickerControllerReferenceURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIImagePickerControllerReferenceURL",  "UIKit")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'UIImagePickerController.PHAsset' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIImagePickerController.PHAsset' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ReferenceUrl {
			[ObsoletedOSPlatform ("ios11.0", "Use 'UIImagePickerController.PHAsset' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIImagePickerController.PHAsset' instead.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ReferenceUrl is null)
					_ReferenceUrl = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIImagePickerControllerReferenceURL")!;
				return _ReferenceUrl;
			}
		}
		//
		// Events and properties from the delegate
		//
		_UIImagePickerControllerDelegate EnsureUIImagePickerControllerDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _UIImagePickerControllerDelegate))){
				del = new _UIImagePickerControllerDelegate ();
				Delegate = del;
			}
			return (_UIImagePickerControllerDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _UIImagePickerControllerDelegate : UIImagePickerControllerDelegate { 
			public _UIImagePickerControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIImagePickerControllerDelegate))]
			static _UIImagePickerControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? canceled;
			public override void Canceled (UIImagePickerController picker)
			{
				var handler = canceled;
				if (handler is not null){
					handler (picker, EventArgs.Empty);
				}
			}
			internal EventHandler<UIImagePickerMediaPickedEventArgs>? finishedPickingMedia;
			public override void FinishedPickingMedia (UIImagePickerController picker, NSDictionary info)
			{
				var handler = finishedPickingMedia;
				if (handler is not null){
					var args = new UIImagePickerMediaPickedEventArgs (info);
					handler (picker, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler Canceled {
			add { EnsureUIImagePickerControllerDelegate ()!.canceled += value; }
			remove { EnsureUIImagePickerControllerDelegate ()!.canceled -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the Delegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<UIImagePickerMediaPickedEventArgs> FinishedPickingMedia {
			add { EnsureUIImagePickerControllerDelegate ()!.finishedPickingMedia += value; }
			remove { EnsureUIImagePickerControllerDelegate ()!.finishedPickingMedia -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class UIImagePickerController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UIImagePickerMediaPickedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UIImagePickerMediaPickedEventArgs" /> with the specified event data.</summary>
		/// <param name="info">The value for the <see cref="Info" /> property.</param>
		public UIImagePickerMediaPickedEventArgs (NSDictionary info)
		{
			this.Info = info;
		}
		public NSDictionary Info { get; set; }
	}
}
