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
namespace HealthKit {
	/// <summary>A correlation between two pieces of health data (for instance, blood pressure).</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKCorrelation_Class/index.html">Apple documentation for <c>HKCorrelation</c></related>
	[Register("HKCorrelation", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKCorrelation : HKSample, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrelationTypeX = "correlationType";
		static readonly NativeHandle selCorrelationTypeXHandle = Selector.GetHandle ("correlationType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrelationWithType_StartDate_EndDate_Objects_X = "correlationWithType:startDate:endDate:objects:";
		static readonly NativeHandle selCorrelationWithType_StartDate_EndDate_Objects_XHandle = Selector.GetHandle ("correlationWithType:startDate:endDate:objects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrelationWithType_StartDate_EndDate_Objects_Device_Metadata_X = "correlationWithType:startDate:endDate:objects:device:metadata:";
		static readonly NativeHandle selCorrelationWithType_StartDate_EndDate_Objects_Device_Metadata_XHandle = Selector.GetHandle ("correlationWithType:startDate:endDate:objects:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrelationWithType_StartDate_EndDate_Objects_Metadata_X = "correlationWithType:startDate:endDate:objects:metadata:";
		static readonly NativeHandle selCorrelationWithType_StartDate_EndDate_Objects_Metadata_XHandle = Selector.GetHandle ("correlationWithType:startDate:endDate:objects:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectsX = "objects";
		static readonly NativeHandle selObjectsXHandle = Selector.GetHandle ("objects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectsForType_X = "objectsForType:";
		static readonly NativeHandle selObjectsForType_XHandle = Selector.GetHandle ("objectsForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKCorrelation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public HKCorrelation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKCorrelation (NSObjectFlag t) : base (t)
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
		protected internal HKCorrelation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("correlationWithType:startDate:endDate:objects:metadata:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCorrelation Create (HKCorrelationType correlationType, NSDate startDate, NSDate endDate, NSSet objects, NSDictionary? metadata)
		{
			var correlationType__handle__ = correlationType!.GetNonNullHandle (nameof (correlationType));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var metadata__handle__ = metadata.GetHandle ();
			HKCorrelation? ret;
			ret =  Runtime.GetNSObject<HKCorrelation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCorrelationWithType_StartDate_EndDate_Objects_Metadata_XHandle, correlationType__handle__, startDate__handle__, endDate__handle__, objects__handle__, metadata__handle__), false)!;
			GC.KeepAlive (correlationType);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (objects);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="correlationType">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="objects">To be added.</param><param name="metadata">To be added.</param><summary>Creates a correlation between <paramref name="objects" /> for the supplied date range.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCorrelation Create (HKCorrelationType correlationType, NSDate startDate, NSDate endDate, NSSet objects, HKMetadata metadata)
		{
			return Create (correlationType, startDate, endDate, objects, metadata.GetDictionary ());
		}
		[Export ("correlationWithType:startDate:endDate:objects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCorrelation Create (HKCorrelationType correlationType, NSDate startDate, NSDate endDate, NSSet objects)
		{
			var correlationType__handle__ = correlationType!.GetNonNullHandle (nameof (correlationType));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			HKCorrelation? ret;
			ret =  Runtime.GetNSObject<HKCorrelation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCorrelationWithType_StartDate_EndDate_Objects_XHandle, correlationType__handle__, startDate__handle__, endDate__handle__, objects__handle__), false)!;
			GC.KeepAlive (correlationType);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (objects);
			return ret!;
		}
		[Export ("correlationWithType:startDate:endDate:objects:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCorrelation Create (HKCorrelationType correlationType, NSDate startDate, NSDate endDate, NSSet<HKSample> objects, HKDevice? device, NSDictionary<NSString, NSObject>? metadata)
		{
			var correlationType__handle__ = correlationType!.GetNonNullHandle (nameof (correlationType));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			HKCorrelation? ret;
			ret =  Runtime.GetNSObject<HKCorrelation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCorrelationWithType_StartDate_EndDate_Objects_Device_Metadata_XHandle, correlationType__handle__, startDate__handle__, endDate__handle__, objects__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (correlationType);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (objects);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
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
		[Export ("objectsForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetObjects (HKObjectType objectType)
		{
			var objectType__handle__ = objectType!.GetNonNullHandle (nameof (objectType));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectsForType_XHandle, objectType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectsForType_XHandle, objectType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectType);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKCorrelationType CorrelationType {
			[Export ("correlationType")]
			get {
				HKCorrelationType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKCorrelationType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCorrelationTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKCorrelationType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCorrelationTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet Objects {
			[Export ("objects")]
			get {
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class HKCorrelation */
}
