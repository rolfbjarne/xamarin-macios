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
	/// <summary>An <see cref="T:HealthKit.HKSample" /> whose value is one of an enumerated type.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKCategorySample_Class/index.html">Apple documentation for <c>HKCategorySample</c></related>
	[Register("HKCategorySample", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKCategorySample : HKSample {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategorySampleWithType_Value_StartDate_EndDate_X = "categorySampleWithType:value:startDate:endDate:";
		static readonly NativeHandle selCategorySampleWithType_Value_StartDate_EndDate_XHandle = Selector.GetHandle ("categorySampleWithType:value:startDate:endDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategorySampleWithType_Value_StartDate_EndDate_Device_Metadata_X = "categorySampleWithType:value:startDate:endDate:device:metadata:";
		static readonly NativeHandle selCategorySampleWithType_Value_StartDate_EndDate_Device_Metadata_XHandle = Selector.GetHandle ("categorySampleWithType:value:startDate:endDate:device:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategorySampleWithType_Value_StartDate_EndDate_Metadata_X = "categorySampleWithType:value:startDate:endDate:metadata:";
		static readonly NativeHandle selCategorySampleWithType_Value_StartDate_EndDate_Metadata_XHandle = Selector.GetHandle ("categorySampleWithType:value:startDate:endDate:metadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoryTypeX = "categoryType";
		static readonly NativeHandle selCategoryTypeXHandle = Selector.GetHandle ("categoryType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueX = "value";
		static readonly NativeHandle selValueXHandle = Selector.GetHandle ("value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKCategorySample");
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
		public HKCategorySample (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKCategorySample (NSObjectFlag t) : base (t)
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
		protected internal HKCategorySample (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="type">To be added.</param><param name="value">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="metadata"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("categorySampleWithType:value:startDate:endDate:metadata:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCategorySample FromType (HKCategoryType type, nint value, NSDate startDate, NSDate endDate, NSDictionary? metadata)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var metadata__handle__ = metadata.GetHandle ();
			HKCategorySample? ret;
			ret =  Runtime.GetNSObject<HKCategorySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCategorySampleWithType_Value_StartDate_EndDate_Metadata_XHandle, type__handle__, value, startDate__handle__, endDate__handle__, metadata__handle__), false)!;
			GC.KeepAlive (type);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (metadata);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="value">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="metadata">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCategorySample FromType (HKCategoryType type, nint value, NSDate startDate, NSDate endDate, HKMetadata metadata)
		{
			return FromType (type, value, startDate, endDate, metadata.GetDictionary ());
		}
		/// <param name="type">To be added.</param><param name="value">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("categorySampleWithType:value:startDate:endDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCategorySample FromType (HKCategoryType type, nint value, NSDate startDate, NSDate endDate)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			HKCategorySample? ret;
			ret =  Runtime.GetNSObject<HKCategorySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (class_ptr, selCategorySampleWithType_Value_StartDate_EndDate_XHandle, type__handle__, value, startDate__handle__, endDate__handle__), false)!;
			GC.KeepAlive (type);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="value">To be added.</param><param name="startDate">To be added.</param><param name="endDate">To be added.</param><param name="device"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="metadata"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates and returns a new <see cref="T:HealthKit.HKCategorySample" /> of the specified type, with the specified values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("categorySampleWithType:value:startDate:endDate:device:metadata:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKCategorySample FromType (HKCategoryType type, nint value, NSDate startDate, NSDate endDate, HKDevice? device, NSDictionary<NSString, NSObject>? metadata)
		{
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			var device__handle__ = device.GetHandle ();
			var metadata__handle__ = metadata.GetHandle ();
			HKCategorySample? ret;
			ret =  Runtime.GetNSObject<HKCategorySample> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCategorySampleWithType_Value_StartDate_EndDate_Device_Metadata_XHandle, type__handle__, value, startDate__handle__, endDate__handle__, device__handle__, metadata__handle__), false)!;
			GC.KeepAlive (type);
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			GC.KeepAlive (device);
			GC.KeepAlive (metadata);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKCategoryType CategoryType {
			[Export ("categoryType")]
			get {
				HKCategoryType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKCategoryType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCategoryTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKCategoryType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCategoryTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Value {
			[Export ("value")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class HKCategorySample */
}
