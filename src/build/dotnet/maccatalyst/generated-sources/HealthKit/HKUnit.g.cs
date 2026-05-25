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
namespace HealthKit {
	/// <summary>Definitions and utility methods for manipulating measurements of mass, length, volume, and energy.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKUnit_Class/index.html">Apple documentation for <c>HKUnit</c></related>
	[Register("HKUnit", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKUnit : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKUnit");
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
		public HKUnit (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected HKUnit (NSObjectFlag t) : base (t)
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
		protected internal HKUnit (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("jouleUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateJouleUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("jouleUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("literUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateLiterUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("literUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("luxUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateLux (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("luxUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("meterUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMeterUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("meterUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("moleUnitWithMetricPrefix:molarMass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMoleUnit (HKMetricPrefix prefix, double gramsPerMole)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_Double (class_ptr, Selector.GetHandle ("moleUnitWithMetricPrefix:molarMass:"), (IntPtr) (long) prefix, gramsPerMole), false)!;
			return ret;
		}
		[Export ("moleUnitWithMolarMass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateMoleUnit (double gramsPerMole)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("moleUnitWithMolarMass:"), gramsPerMole), false)!;
			return ret;
		}
		[Export ("pascalUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreatePascalUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("pascalUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("radianAngleUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateRadianAngle (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("radianAngleUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("secondUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateSecondUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("secondUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("siemenUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateSiemenUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("siemenUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("wattUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CreateWatt (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("wattUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
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
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("unitFromEnergyFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromEnergyFormatterUnit (NSEnergyFormatterUnit energyFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("unitFromEnergyFormatterUnit:"), (IntPtr) (long) energyFormatterUnit), false)!;
			return ret;
		}
		[Export ("gramUnitWithMetricPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromGramUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("gramUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("unitFromLengthFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromLengthFormatterUnit (NSLengthFormatterUnit lengthFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("unitFromLengthFormatterUnit:"), (IntPtr) (long) lengthFormatterUnit), false)!;
			return ret;
		}
		[Export ("unitFromMassFormatterUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromMassFormatterUnit (NSMassFormatterUnit massFormatterUnit)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("unitFromMassFormatterUnit:"), (IntPtr) (long) massFormatterUnit), false)!;
			return ret;
		}
		[Export ("unitFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FromString (string aString)
		{
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			HKUnit? ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("unitFromString:"), nsaString), false)!;
			CFString.ReleaseNative (nsaString);
			return ret!;
		}
		[Export ("energyFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEnergyFormatterUnit GetEnergyFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSEnergyFormatterUnit ret;
			ret = (NSEnergyFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("energyFormatterUnitFromUnit:"), unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("hertzUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit GetHertzUnit (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("hertzUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("lengthFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLengthFormatterUnit GetLengthFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSLengthFormatterUnit ret;
			ret = (NSLengthFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("lengthFormatterUnitFromUnit:"), unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("massFormatterUnitFromUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMassFormatterUnit GetMassFormatterUnit (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			NSMassFormatterUnit ret;
			ret = (NSMassFormatterUnit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("massFormatterUnitFromUnit:"), unit__handle__);
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("voltUnitWithMetricPrefix:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit GetVolt (HKMetricPrefix prefix)
		{
			HKUnit ret;
			ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("voltUnitWithMetricPrefix:"), (IntPtr) (long) prefix), false)!;
			return ret;
		}
		[Export ("reciprocalUnit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit ReciprocalUnit ()
		{
			HKUnit ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reciprocalUnit")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reciprocalUnit")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("unitDividedByUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitDividedBy (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			HKUnit? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unitDividedByUnit:"), unit__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unitDividedByUnit:"), unit__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unit);
			return ret!;
		}
		[Export ("unitMultipliedByUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitMultipliedBy (HKUnit unit)
		{
			var unit__handle__ = unit!.GetNonNullHandle (nameof (unit));
			HKUnit? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unitMultipliedByUnit:"), unit__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unitMultipliedByUnit:"), unit__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (unit);
			return ret!;
		}
		/// <param name="power">To be added.</param><summary>Returns a unit that is the result of raising <see langword="this" /> unit by <paramref name="power" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unitRaisedToPower:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKUnit UnitRaisedToPower (nint power)
		{
			HKUnit ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unitRaisedToPower:"), power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("unitRaisedToPower:"), power), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit AppleEffortScoreUnit {
			[Export ("appleEffortScoreUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("appleEffortScoreUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Atmosphere {
			[Export ("atmosphereUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("atmosphereUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SmallCalorie' or 'LargeCalorie' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SmallCalorie' or 'LargeCalorie' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static HKUnit Calorie {
			[Export ("calorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("calorieUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit CentimeterOfWater {
			[Export ("centimeterOfWaterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("centimeterOfWaterUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Count {
			[Export ("countUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("countUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit CupImperialUnit {
			[Export ("cupImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cupImperialUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit CupUSUnit {
			[Export ("cupUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cupUSUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Day {
			[Export ("dayUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("dayUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit DecibelAWeightedSoundPressureLevelUnit {
			[Export ("decibelAWeightedSoundPressureLevelUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("decibelAWeightedSoundPressureLevelUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit DecibelHearingLevelUnit {
			[Export ("decibelHearingLevelUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("decibelHearingLevelUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit DegreeAngle {
			[Export ("degreeAngleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("degreeAngleUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit DegreeCelsius {
			[Export ("degreeCelsiusUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("degreeCelsiusUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit DegreeFahrenheit {
			[Export ("degreeFahrenheitUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("degreeFahrenheitUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Diopter {
			[Export ("diopterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("diopterUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FluidOunceImperialUnit {
			[Export ("fluidOunceImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("fluidOunceImperialUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit FluidOunceUSUnit {
			[Export ("fluidOunceUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("fluidOunceUSUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Foot {
			[Export ("footUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("footUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Gram {
			[Export ("gramUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("gramUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit HertzUnit {
			[Export ("hertzUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("hertzUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Hour {
			[Export ("hourUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("hourUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Inch {
			[Export ("inchUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("inchUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit InchesOfMercury {
			[Export ("inchesOfMercuryUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("inchesOfMercuryUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit InternationalUnit {
			[Export ("internationalUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("internationalUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNull {
			[Export ("isNull")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isNull"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isNull"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Joule {
			[Export ("jouleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("jouleUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Kelvin {
			[Export ("kelvinUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("kelvinUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Kilocalorie {
			[Export ("kilocalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("kilocalorieUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit LargeCalorie {
			[Export ("largeCalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("largeCalorieUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Liter {
			[Export ("literUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("literUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Lux {
			[Export ("luxUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("luxUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Meter {
			[Export ("meterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("meterUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Mile {
			[Export ("mileUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("mileUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit MillimeterOfMercury {
			[Export ("millimeterOfMercuryUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("millimeterOfMercuryUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Minute {
			[Export ("minuteUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("minuteUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Ounce {
			[Export ("ounceUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("ounceUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Pascal {
			[Export ("pascalUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pascalUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Percent {
			[Export ("percentUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("percentUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit PintImperialUnit {
			[Export ("pintImperialUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pintImperialUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit PintUSUnit {
			[Export ("pintUSUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pintUSUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Pound {
			[Export ("poundUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("poundUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit PrismDiopter {
			[Export ("prismDiopterUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("prismDiopterUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit RadianAngle {
			[Export ("radianAngleUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("radianAngleUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Second {
			[Export ("secondUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("secondUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Siemen {
			[Export ("siemenUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("siemenUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit SmallCalorie {
			[Export ("smallCalorieUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("smallCalorieUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static HKUnit Stone {
			[Export ("stoneUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("stoneUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UnitString {
			[Export ("unitString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("unitString")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unitString")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit Volt {
			[Export ("voltUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("voltUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static HKUnit Watt {
			[Export ("wattUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("wattUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public static HKUnit Yard {
			[Export ("yardUnit")]
			get {
				HKUnit? ret;
				ret =  Runtime.GetNSObject<HKUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("yardUnit")), false)!;
				return ret!;
			}
		}
	} /* class HKUnit */
}
