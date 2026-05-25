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
	/// <summary>A <see cref="T:HealthKit.HKSample" /> that has a magnitude (see <see cref="P:HealthKit.HKQuantitySample.Quantity" />).</summary><remarks><para>The following examples show how you can create a HKQuantitySample, one using standard C#, and another using named parameters to make their use more obvious:</para><para /><example><code lang="csharp lang-csharp"><![CDATA[var bodyTemperature = HKQuantityType.Create (HKQuantityTypeIdentifier.BodyTemperature);
	/// var temp = HKQuantity.FromQuantity (HKUnit.DegreeFahrenheit, 99);
	/// var sample = HKQuantitySample.FromType (bodyTemperature, temp, NSDate.Now, NSDate.Now, new HKMetadata () {
	/// 	BodyTemperatureSensorLocation = HKBodyTemperatureSensorLocation.Mouth
	/// });
	/// 
	/// var sample2 = HKQuantitySample.FromType (
	/// quantityType: HKQuantityType.Create (HKQuantityTypeIdentifier.BodyTemperature),
	/// quantity: HKQuantity.FromQuantity (HKUnit.DegreeFahrenheit, 99),
	/// startDate: NSDate.Now, 
	/// endDate: NSDate.Now, 
	/// metadata: new HKMetadata () {
	/// 	BodyTemperatureSensorLocation = HKBodyTemperatureSensorLocation.Mouth
	/// }
	/// );]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKQuantitySample_Class/index.html">Apple documentation for <c>HKQuantitySample</c></related>
	[Register("HKQuantitySample", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKQuantitySample : HKSample {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantityX = "quantity";
		static readonly NativeHandle selQuantityXHandle = Selector.GetHandle ("quantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantitySampleWithType_Quantity_StartDate_EndDate_X = "quantitySampleWithType:quantity:startDate:endDate:";
		static readonly NativeHandle selQuantitySampleWithType_Quantity_StartDate_EndDate_XHandle = Selector.GetHandle ("quantitySampleWithType:quantity:startDate:endDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantitySampleWithType_Quantity_StartDate_EndDate_Device_Metadata_X = "quantitySampleWithType:quantity:startDate:endDate:device:metadata:";
		static readonly NativeHandle selQuantitySampleWithType_Quantity_StartDate_EndDate_Device_Metadata_XHandle = Selector.GetHandle ("quantitySampleWithType:quantity:startDate:endDate:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantitySampleWithType_Quantity_StartDate_EndDate_Metadata_X = "quantitySampleWithType:quantity:startDate:endDate:metadata:";
		static readonly NativeHandle selQuantitySampleWithType_Quantity_StartDate_EndDate_Metadata_XHandle = Selector.GetHandle ("quantitySampleWithType:quantity:startDate:endDate:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantityTypeX = "quantityType";
		static readonly NativeHandle selQuantityTypeXHandle = Selector.GetHandle ("quantityType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKQuantitySample");
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
		public HKQuantitySample (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKQuantitySample (NSObjectFlag t) : base (t)
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
		protected internal HKQuantitySample (NativeHandle handle) : base (handle)
		{
		}

		[Export ("quantitySampleWithType:quantity:startDate:endDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKQuantitySample FromType (HKQuantityType quantityType, HKQuantity quantity, NSDate startDate, NSDate endDate)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			HKQuantitySample? ret;
			ret =  Runtime.GetNSObject<HKQuantitySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selQuantitySampleWithType_Quantity_StartDate_EndDate_XHandle, quantityType__handle__, quantity__handle__, startDate__handle__, endDate__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (quantity);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("quantitySampleWithType:quantity:startDate:endDate:metadata:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKQuantitySample FromType (HKQuantityType quantityType, HKQuantity quantity, NSDate startDate, NSDate endDate, NSDictionary? metadata)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var metadata__handle__ = metadata.GetHandle ();
			HKQuantitySample? ret;
			ret =  Runtime.GetNSObject<HKQuantitySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selQuantitySampleWithType_Quantity_StartDate_EndDate_Metadata_XHandle, quantityType__handle__, quantity__handle__, startDate__handle__, endDate__handle__, metadata__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (quantity);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="quantityType">To be added.</param><param name="quantity">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="metadata">To be added.</param><summary>Creates a new HKQuantitySample, using a stronglty typed HKMetadata for the metadata.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKQuantitySample FromType (HKQuantityType quantityType, HKQuantity quantity, NSDate startDate, NSDate endDate, HKMetadata metadata)
		{
			return FromType (quantityType, quantity, startDate, endDate, metadata.GetDictionary ());
		}
		[Export ("quantitySampleWithType:quantity:startDate:endDate:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKQuantitySample FromType (HKQuantityType quantityType, HKQuantity quantity, NSDate startDate, NSDate endDate, HKDevice? device, NSDictionary<NSString, NSObject>? metadata)
		{
			var quantityType__handle__ = quantityType!.GetNonNullHandle (nameof (quantityType));
			var quantity__handle__ = quantity!.GetNonNullHandle (nameof (quantity));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			HKQuantitySample? ret;
			ret =  Runtime.GetNSObject<HKQuantitySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selQuantitySampleWithType_Quantity_StartDate_EndDate_Device_Metadata_XHandle, quantityType__handle__, quantity__handle__, startDate__handle__, endDate__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (quantityType);
			GC.KeepAlive (quantity);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual nint Count {
			[Export ("count")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity Quantity {
			[Export ("quantity", ArgumentSemantic.Retain)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQuantityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQuantityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantityType QuantityType {
			[Export ("quantityType", ArgumentSemantic.Retain)]
			get {
				HKQuantityType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantityType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQuantityTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantityType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQuantityTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class HKQuantitySample */
}
