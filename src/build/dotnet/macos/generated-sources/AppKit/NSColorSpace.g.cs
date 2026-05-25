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
namespace AppKit {
	[Register("NSColorSpace", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSColorSpace : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGColorSpaceX = "CGColorSpace";
		static readonly NativeHandle selCGColorSpaceXHandle = Selector.GetHandle ("CGColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selICCProfileDataX = "ICCProfileData";
		static readonly NativeHandle selICCProfileDataXHandle = Selector.GetHandle ("ICCProfileData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdobeRGB1998ColorSpaceX = "adobeRGB1998ColorSpace";
		static readonly NativeHandle selAdobeRGB1998ColorSpaceXHandle = Selector.GetHandle ("adobeRGB1998ColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableColorSpacesWithModel_X = "availableColorSpacesWithModel:";
		static readonly NativeHandle selAvailableColorSpacesWithModel_XHandle = Selector.GetHandle ("availableColorSpacesWithModel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceModelX = "colorSpaceModel";
		static readonly NativeHandle selColorSpaceModelXHandle = Selector.GetHandle ("colorSpaceModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSyncProfileX = "colorSyncProfile";
		static readonly NativeHandle selColorSyncProfileXHandle = Selector.GetHandle ("colorSyncProfile");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceCMYKColorSpaceX = "deviceCMYKColorSpace";
		static readonly NativeHandle selDeviceCMYKColorSpaceXHandle = Selector.GetHandle ("deviceCMYKColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceGrayColorSpaceX = "deviceGrayColorSpace";
		static readonly NativeHandle selDeviceGrayColorSpaceXHandle = Selector.GetHandle ("deviceGrayColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceRGBColorSpaceX = "deviceRGBColorSpace";
		static readonly NativeHandle selDeviceRGBColorSpaceXHandle = Selector.GetHandle ("deviceRGBColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayP3ColorSpaceX = "displayP3ColorSpace";
		static readonly NativeHandle selDisplayP3ColorSpaceXHandle = Selector.GetHandle ("displayP3ColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedGenericGamma22GrayColorSpaceX = "extendedGenericGamma22GrayColorSpace";
		static readonly NativeHandle selExtendedGenericGamma22GrayColorSpaceXHandle = Selector.GetHandle ("extendedGenericGamma22GrayColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedSRGBColorSpaceX = "extendedSRGBColorSpace";
		static readonly NativeHandle selExtendedSRGBColorSpaceXHandle = Selector.GetHandle ("extendedSRGBColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenericCMYKColorSpaceX = "genericCMYKColorSpace";
		static readonly NativeHandle selGenericCMYKColorSpaceXHandle = Selector.GetHandle ("genericCMYKColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenericGamma22GrayColorSpaceX = "genericGamma22GrayColorSpace";
		static readonly NativeHandle selGenericGamma22GrayColorSpaceXHandle = Selector.GetHandle ("genericGamma22GrayColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenericGrayColorSpaceX = "genericGrayColorSpace";
		static readonly NativeHandle selGenericGrayColorSpaceXHandle = Selector.GetHandle ("genericGrayColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenericRGBColorSpaceX = "genericRGBColorSpace";
		static readonly NativeHandle selGenericRGBColorSpaceXHandle = Selector.GetHandle ("genericRGBColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCGColorSpace_X = "initWithCGColorSpace:";
		static readonly NativeHandle selInitWithCGColorSpace_XHandle = Selector.GetHandle ("initWithCGColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithICCProfileData_X = "initWithICCProfileData:";
		static readonly NativeHandle selInitWithICCProfileData_XHandle = Selector.GetHandle ("initWithICCProfileData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameX = "localizedName";
		static readonly NativeHandle selLocalizedNameXHandle = Selector.GetHandle ("localizedName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColorComponentsX = "numberOfColorComponents";
		static readonly NativeHandle selNumberOfColorComponentsXHandle = Selector.GetHandle ("numberOfColorComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSRGBColorSpaceX = "sRGBColorSpace";
		static readonly NativeHandle selSRGBColorSpaceXHandle = Selector.GetHandle ("sRGBColorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSColorSpace");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSColorSpace" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSColorSpace () : base (NSObjectFlag.Empty)
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
		public NSColorSpace (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSColorSpace (NSObjectFlag t) : base (t)
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
		protected internal NSColorSpace (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithICCProfileData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSColorSpace (NSData iccData)
			: base (NSObjectFlag.Empty)
		{
			var iccData__handle__ = iccData!.GetNonNullHandle (nameof (iccData));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithICCProfileData_XHandle, iccData__handle__), "initWithICCProfileData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithICCProfileData_XHandle, iccData__handle__), "initWithICCProfileData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (iccData);
		}
		[Export ("initWithCGColorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSColorSpace (CGColorSpace cgColorSpace)
			: base (NSObjectFlag.Empty)
		{
			var cgColorSpace__handle__ = cgColorSpace!.GetNonNullHandle (nameof (cgColorSpace));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCGColorSpace_XHandle, cgColorSpace.Handle), "initWithCGColorSpace:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCGColorSpace_XHandle, cgColorSpace.Handle), "initWithCGColorSpace:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cgColorSpace);
		}
		[Export ("availableColorSpacesWithModel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace[] AvailableColorSpacesWithModel (NSColorSpaceModel model)
		{
			NSColorSpace[] ret;
			ret = CFArray.ArrayFromHandle<NSColorSpace>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selAvailableColorSpacesWithModel_XHandle, (IntPtr) (long) model), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace AdobeRGB1998ColorSpace {
			[Export ("adobeRGB1998ColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAdobeRGB1998ColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColorComponents {
			[Export ("numberOfColorComponents")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfColorComponentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfColorComponentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColorSpace ColorSpace {
			[Export ("CGColorSpace")]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGColorSpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGColorSpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColorSpaceModel ColorSpaceModel {
			[Export ("colorSpaceModel")]
			get {
				NSColorSpaceModel ret;
				if (IsDirectBinding) {
					ret = (NSColorSpaceModel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorSpaceModelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSColorSpaceModel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColorSpaceModelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColorSyncProfile {
			[Export ("colorSyncProfile")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorSyncProfileXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColorSyncProfileXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace DeviceCMYKColorSpace {
			[Export ("deviceCMYKColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDeviceCMYKColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace DeviceGrayColorSpace {
			[Export ("deviceGrayColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDeviceGrayColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace DeviceRGBColorSpace {
			[Export ("deviceRGBColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDeviceRGBColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace DisplayP3ColorSpace {
			[Export ("displayP3ColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDisplayP3ColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace ExtendedGenericGamma22GrayColorSpace {
			[Export ("extendedGenericGamma22GrayColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExtendedGenericGamma22GrayColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace ExtendedSRgbColorSpace {
			[Export ("extendedSRGBColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExtendedSRGBColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace GenericCMYKColorSpace {
			[Export ("genericCMYKColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGenericCMYKColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace GenericGamma22GrayColorSpace {
			[Export ("genericGamma22GrayColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGenericGamma22GrayColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace GenericGrayColorSpace {
			[Export ("genericGrayColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGenericGrayColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace GenericRGBColorSpace {
			[Export ("genericRGBColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGenericRGBColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData ICCProfileData {
			[Export ("ICCProfileData")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selICCProfileDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selICCProfileDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedName {
			[Export ("localizedName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColorSpace SRGBColorSpace {
			[Export ("sRGBColorSpace")]
			get {
				NSColorSpace? ret;
				ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSRGBColorSpaceXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalibratedBlack;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCalibratedBlackColorSpace",  "AppKit")]
		public static NSString CalibratedBlack {
			get {
				if (_CalibratedBlack is null)
					_CalibratedBlack = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCalibratedBlackColorSpace")!;
				return _CalibratedBlack;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalibratedRGB;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCalibratedRGBColorSpace",  "AppKit")]
		public static NSString CalibratedRGB {
			get {
				if (_CalibratedRGB is null)
					_CalibratedRGB = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCalibratedRGBColorSpace")!;
				return _CalibratedRGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalibratedWhite;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCalibratedWhiteColorSpace",  "AppKit")]
		public static NSString CalibratedWhite {
			get {
				if (_CalibratedWhite is null)
					_CalibratedWhite = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCalibratedWhiteColorSpace")!;
				return _CalibratedWhite;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Custom;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSCustomColorSpace",  "AppKit")]
		public static NSString Custom {
			get {
				if (_Custom is null)
					_Custom = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSCustomColorSpace")!;
				return _Custom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceBlack;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDeviceBlackColorSpace",  "AppKit")]
		public static NSString DeviceBlack {
			get {
				if (_DeviceBlack is null)
					_DeviceBlack = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDeviceBlackColorSpace")!;
				return _DeviceBlack;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceCMYK;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDeviceCMYKColorSpace",  "AppKit")]
		public static NSString DeviceCMYK {
			get {
				if (_DeviceCMYK is null)
					_DeviceCMYK = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDeviceCMYKColorSpace")!;
				return _DeviceCMYK;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceRGB;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDeviceRGBColorSpace",  "AppKit")]
		public static NSString DeviceRGB {
			get {
				if (_DeviceRGB is null)
					_DeviceRGB = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDeviceRGBColorSpace")!;
				return _DeviceRGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeviceWhite;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDeviceWhiteColorSpace",  "AppKit")]
		public static NSString DeviceWhite {
			get {
				if (_DeviceWhite is null)
					_DeviceWhite = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDeviceWhiteColorSpace")!;
				return _DeviceWhite;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Named;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSNamedColorSpace",  "AppKit")]
		public static NSString Named {
			get {
				if (_Named is null)
					_Named = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSNamedColorSpace")!;
				return _Named;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Pattern;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSPatternColorSpace",  "AppKit")]
		public static NSString Pattern {
			get {
				if (_Pattern is null)
					_Pattern = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPatternColorSpace")!;
				return _Pattern;
			}
		}
	} /* class NSColorSpace */
}
