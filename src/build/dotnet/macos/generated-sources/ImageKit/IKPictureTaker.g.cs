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
namespace ImageKit {
	[Register("IKPictureTaker", true)]
	public unsafe partial class IKPictureTaker : global::AppKit.NSPanel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_X = "beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_X = "beginPictureTakerWithDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginPictureTakerWithDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputImageX = "inputImage";
		static readonly NativeHandle selInputImageXHandle = Selector.GetHandle ("inputImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMirroringX = "mirroring";
		static readonly NativeHandle selMirroringXHandle = Selector.GetHandle ("mirroring");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputImageX = "outputImage";
		static readonly NativeHandle selOutputImageXHandle = Selector.GetHandle ("outputImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPictureTakerX = "pictureTaker";
		static readonly NativeHandle selPictureTakerXHandle = Selector.GetHandle ("pictureTaker");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_X = "popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalX = "runModal";
		static readonly NativeHandle selRunModalXHandle = Selector.GetHandle ("runModal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputImage_X = "setInputImage:";
		static readonly NativeHandle selSetInputImage_XHandle = Selector.GetHandle ("setInputImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMirroring_X = "setMirroring:";
		static readonly NativeHandle selSetMirroring_XHandle = Selector.GetHandle ("setMirroring:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("IKPictureTaker");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="IKPictureTaker" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKPictureTaker () : base (NSObjectFlag.Empty)
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
		public IKPictureTaker (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected IKPictureTaker (NSObjectFlag t) : base (t)
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
		protected internal IKPictureTaker (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="aDelegate">To be added.</param><param name="didEndSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginPictureTakerWithDelegate:didEndSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginPictureTaker (NSObject aDelegate, Selector didEndSelector, nint contextInfo)
		{
			var aDelegate__handle__ = aDelegate!.GetNonNullHandle (nameof (aDelegate));
			var didEndSelector__handle__ = didEndSelector!.GetNonNullHandle (nameof (didEndSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_XHandle, aDelegate__handle__, didEndSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginPictureTakerWithDelegate_DidEndSelector_ContextInfo_XHandle, aDelegate__handle__, didEndSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDelegate);
			GC.KeepAlive (didEndSelector);
		}
		/// <param name="aWindow">To be added.</param><param name="aDelegate">To be added.</param><param name="didEndSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginPictureTakerSheetForWindow:withDelegate:didEndSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginPictureTakerSheet (global::AppKit.NSWindow aWindow, NSObject aDelegate, Selector didEndSelector, nint contextInfo)
		{
			var aWindow__handle__ = aWindow!.GetNonNullHandle (nameof (aWindow));
			var aDelegate__handle__ = aDelegate!.GetNonNullHandle (nameof (aDelegate));
			var didEndSelector__handle__ = didEndSelector!.GetNonNullHandle (nameof (didEndSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_XHandle, aWindow__handle__, aDelegate__handle__, didEndSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginPictureTakerSheetForWindow_WithDelegate_DidEndSelector_ContextInfo_XHandle, aWindow__handle__, aDelegate__handle__, didEndSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aWindow);
			GC.KeepAlive (aDelegate);
			GC.KeepAlive (didEndSelector);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outputImage")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage GetOutputImage ()
		{
			global::AppKit.NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputImageXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputImageXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="aView">To be added.</param><param name="aDelegate">To be added.</param><param name="didEndSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popUpRecentsMenuForView:withDelegate:didEndSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopUpRecentsMenu (global::AppKit.NSView aView, NSObject aDelegate, Selector didEndSelector, nint contextInfo)
		{
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			var aDelegate__handle__ = aDelegate!.GetNonNullHandle (nameof (aDelegate));
			var didEndSelector__handle__ = didEndSelector!.GetNonNullHandle (nameof (didEndSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_XHandle, aView__handle__, aDelegate__handle__, didEndSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selPopUpRecentsMenuForView_WithDelegate_DidEndSelector_ContextInfo_XHandle, aView__handle__, aDelegate__handle__, didEndSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
			GC.KeepAlive (aDelegate);
			GC.KeepAlive (didEndSelector);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("runModal")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModal ()
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRunModalXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRunModalXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage InputImage {
			[Export ("inputImage")]
			get {
				global::AppKit.NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputImage:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInputImage_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInputImage_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Mirroring {
			[Export ("mirroring")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMirroringXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMirroringXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMirroring:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMirroring_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMirroring_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IKPictureTaker SharedPictureTaker {
			[Export ("pictureTaker")]
			get {
				IKPictureTaker? ret;
				ret =  Runtime.GetNSObject<IKPictureTaker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPictureTakerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsEditingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerAllowsEditingKey",  "ImageKit")]
		public static NSString AllowsEditingKey {
			get {
				if (_AllowsEditingKey is null)
					_AllowsEditingKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerAllowsEditingKey")!;
				return _AllowsEditingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsFileChoosingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerAllowsFileChoosingKey",  "ImageKit")]
		public static NSString AllowsFileChoosingKey {
			get {
				if (_AllowsFileChoosingKey is null)
					_AllowsFileChoosingKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerAllowsFileChoosingKey")!;
				return _AllowsFileChoosingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowsVideoCaptureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerAllowsVideoCaptureKey",  "ImageKit")]
		public static NSString AllowsVideoCaptureKey {
			get {
				if (_AllowsVideoCaptureKey is null)
					_AllowsVideoCaptureKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerAllowsVideoCaptureKey")!;
				return _AllowsVideoCaptureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CropAreaSizeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerCropAreaSizeKey",  "ImageKit")]
		public static NSString CropAreaSizeKey {
			get {
				if (_CropAreaSizeKey is null)
					_CropAreaSizeKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerCropAreaSizeKey")!;
				return _CropAreaSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageTransformsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerImageTransformsKey",  "ImageKit")]
		public static NSString ImageTransformsKey {
			get {
				if (_ImageTransformsKey is null)
					_ImageTransformsKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerImageTransformsKey")!;
				return _ImageTransformsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InformationalTextKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerInformationalTextKey",  "ImageKit")]
		public static NSString InformationalTextKey {
			get {
				if (_InformationalTextKey is null)
					_InformationalTextKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerInformationalTextKey")!;
				return _InformationalTextKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputImageMaxSizeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerOutputImageMaxSizeKey",  "ImageKit")]
		public static NSString OutputImageMaxSizeKey {
			get {
				if (_OutputImageMaxSizeKey is null)
					_OutputImageMaxSizeKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerOutputImageMaxSizeKey")!;
				return _OutputImageMaxSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemainOpenAfterValidateKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerRemainOpenAfterValidateKey",  "ImageKit")]
		public static NSString RemainOpenAfterValidateKey {
			get {
				if (_RemainOpenAfterValidateKey is null)
					_RemainOpenAfterValidateKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerRemainOpenAfterValidateKey")!;
				return _RemainOpenAfterValidateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowAddressBookPictureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerShowAddressBookPictureKey",  "ImageKit")]
		public static NSString ShowAddressBookPictureKey {
			get {
				if (_ShowAddressBookPictureKey is null)
					_ShowAddressBookPictureKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerShowAddressBookPictureKey")!;
				return _ShowAddressBookPictureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowEffectsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerShowEffectsKey",  "ImageKit")]
		public static NSString ShowEffectsKey {
			get {
				if (_ShowEffectsKey is null)
					_ShowEffectsKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerShowEffectsKey")!;
				return _ShowEffectsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowEmptyPictureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerShowEmptyPictureKey",  "ImageKit")]
		public static NSString ShowEmptyPictureKey {
			get {
				if (_ShowEmptyPictureKey is null)
					_ShowEmptyPictureKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerShowEmptyPictureKey")!;
				return _ShowEmptyPictureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowRecentPictureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerShowRecentPictureKey",  "ImageKit")]
		public static NSString ShowRecentPictureKey {
			get {
				if (_ShowRecentPictureKey is null)
					_ShowRecentPictureKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerShowRecentPictureKey")!;
				return _ShowRecentPictureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UpdateRecentPictureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKPictureTakerUpdateRecentPictureKey",  "ImageKit")]
		public static NSString UpdateRecentPictureKey {
			get {
				if (_UpdateRecentPictureKey is null)
					_UpdateRecentPictureKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKPictureTakerUpdateRecentPictureKey")!;
				return _UpdateRecentPictureKey;
			}
		}
	} /* class IKPictureTaker */
}
