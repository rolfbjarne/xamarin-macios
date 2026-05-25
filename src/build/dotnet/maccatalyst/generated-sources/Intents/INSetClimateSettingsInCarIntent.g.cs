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
namespace Intents {
	/// <summary>An <see cref="T:Intents.INIntent" /> indicating the user wishes to control the climate.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Intents/INSetClimateSettingsInCarIntent">Apple documentation for <c>INSetClimateSettingsInCarIntent</c></related>
	[Register("INSetClimateSettingsInCarIntent", true)]
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class INSetClimateSettingsInCarIntent : INIntent {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INSetClimateSettingsInCarIntent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="INSetClimateSettingsInCarIntent" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public INSetClimateSettingsInCarIntent () : base (NSObjectFlag.Empty)
		{
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
		public INSetClimateSettingsInCarIntent (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected INSetClimateSettingsInCarIntent (NSObjectFlag t) : base (t)
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
		protected internal INSetClimateSettingsInCarIntent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:")]
		[ObsoletedOSPlatform ("ios12.0", "Use the overload that takes 'INSpeakableString carName'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'INSpeakableString carName'.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected INSetClimateSettingsInCarIntent (NSNumber? enableFan, NSNumber? enableAirConditioner, NSNumber? enableClimateControl, NSNumber? enableAutoMode, INCarAirCirculationMode airCirculationMode, NSNumber? fanSpeedIndex, NSNumber? fanSpeedPercentage, INRelativeSetting relativeFanSpeedSetting, NSMeasurement<NSUnitTemperature>? temperature, INRelativeSetting relativeTemperatureSetting, INCarSeat climateZone)
			: base (NSObjectFlag.Empty)
		{
			var enableFan__handle__ = enableFan.GetHandle ();
			var enableAirConditioner__handle__ = enableAirConditioner.GetHandle ();
			var enableClimateControl__handle__ = enableClimateControl.GetHandle ();
			var enableAutoMode__handle__ = enableAutoMode.GetHandle ();
			var fanSpeedIndex__handle__ = fanSpeedIndex.GetHandle ();
			var fanSpeedPercentage__handle__ = fanSpeedPercentage.GetHandle ();
			var temperature__handle__ = temperature.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:"), enableFan__handle__, enableAirConditioner__handle__, enableClimateControl__handle__, enableAutoMode__handle__, (IntPtr) (long) airCirculationMode, fanSpeedIndex__handle__, fanSpeedPercentage__handle__, (IntPtr) (long) relativeFanSpeedSetting, temperature__handle__, (IntPtr) (long) relativeTemperatureSetting, (IntPtr) (long) climateZone), "initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:"), enableFan__handle__, enableAirConditioner__handle__, enableClimateControl__handle__, enableAutoMode__handle__, (IntPtr) (long) airCirculationMode, fanSpeedIndex__handle__, fanSpeedPercentage__handle__, (IntPtr) (long) relativeFanSpeedSetting, temperature__handle__, (IntPtr) (long) relativeTemperatureSetting, (IntPtr) (long) climateZone), "initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (enableFan);
			GC.KeepAlive (enableAirConditioner);
			GC.KeepAlive (enableClimateControl);
			GC.KeepAlive (enableAutoMode);
			GC.KeepAlive (fanSpeedIndex);
			GC.KeepAlive (fanSpeedPercentage);
			GC.KeepAlive (temperature);
		}
		[Export ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:carName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSetClimateSettingsInCarIntent ([BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? enableFan, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? enableAirConditioner, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? enableClimateControl, [BindAs (typeof (bool?), OriginalType = typeof (NSNumber))] bool? enableAutoMode, INCarAirCirculationMode airCirculationMode, [BindAs (typeof (int?), OriginalType = typeof (NSNumber))] int? fanSpeedIndex, [BindAs (typeof (double?), OriginalType = typeof (NSNumber))] double? fanSpeedPercentage, INRelativeSetting relativeFanSpeedSetting, NSMeasurement<NSUnitTemperature>? temperature, INRelativeSetting relativeTemperatureSetting, INCarSeat climateZone, INSpeakableString? carName)
			: base (NSObjectFlag.Empty)
		{
			var temperature__handle__ = temperature.GetHandle ();
			var carName__handle__ = carName.GetHandle ();
			using var nsb_enableFan = enableFan is null ? null : new NSNumber (enableFan.Value);
			using var nsb_enableAirConditioner = enableAirConditioner is null ? null : new NSNumber (enableAirConditioner.Value);
			using var nsb_enableClimateControl = enableClimateControl is null ? null : new NSNumber (enableClimateControl.Value);
			using var nsb_enableAutoMode = enableAutoMode is null ? null : new NSNumber (enableAutoMode.Value);
			using var nsb_fanSpeedIndex = fanSpeedIndex is null ? null : new NSNumber (fanSpeedIndex.Value);
			using var nsb_fanSpeedPercentage = fanSpeedPercentage is null ? null : new NSNumber (fanSpeedPercentage.Value);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:carName:"), nsb_enableFan.GetHandle (), nsb_enableAirConditioner.GetHandle (), nsb_enableClimateControl.GetHandle (), nsb_enableAutoMode.GetHandle (), (IntPtr) (long) airCirculationMode, nsb_fanSpeedIndex.GetHandle (), nsb_fanSpeedPercentage.GetHandle (), (IntPtr) (long) relativeFanSpeedSetting, temperature__handle__, (IntPtr) (long) relativeTemperatureSetting, (IntPtr) (long) climateZone, carName__handle__), "initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:carName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_IntPtr_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:carName:"), nsb_enableFan.GetHandle (), nsb_enableAirConditioner.GetHandle (), nsb_enableClimateControl.GetHandle (), nsb_enableAutoMode.GetHandle (), (IntPtr) (long) airCirculationMode, nsb_fanSpeedIndex.GetHandle (), nsb_fanSpeedPercentage.GetHandle (), (IntPtr) (long) relativeFanSpeedSetting, temperature__handle__, (IntPtr) (long) relativeTemperatureSetting, (IntPtr) (long) climateZone, carName__handle__), "initWithEnableFan:enableAirConditioner:enableClimateControl:enableAutoMode:airCirculationMode:fanSpeedIndex:fanSpeedPercentage:relativeFanSpeedSetting:temperature:relativeTemperatureSetting:climateZone:carName:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (temperature);
			GC.KeepAlive (carName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INCarAirCirculationMode AirCirculationMode {
			[Export ("airCirculationMode", ArgumentSemantic.Assign)]
			get {
				INCarAirCirculationMode ret;
				if (IsDirectBinding) {
					ret = (Intents.INCarAirCirculationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("airCirculationMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INCarAirCirculationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("airCirculationMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios15.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("ios")]
		public virtual INSpeakableString? CarName {
			[Export ("carName", ArgumentSemantic.Copy)]
			get {
				INSpeakableString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INSpeakableString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("carName")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INSpeakableString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("carName")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INCarSeat ClimateZone {
			[Export ("climateZone", ArgumentSemantic.Assign)]
			get {
				INCarSeat ret;
				if (IsDirectBinding) {
					ret = (Intents.INCarSeat) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("climateZone"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INCarSeat) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("climateZone"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? EnableAirConditioner {
			[Export ("enableAirConditioner", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("enableAirConditioner")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enableAirConditioner")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? EnableAutoMode {
			[Export ("enableAutoMode", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("enableAutoMode")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enableAutoMode")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? EnableClimateControl {
			[Export ("enableClimateControl", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("enableClimateControl")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enableClimateControl")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (bool?), OriginalType = typeof (NSNumber))]
		public virtual bool? EnableFan {
			[Export ("enableFan", ArgumentSemantic.Copy)]
			get {
				bool? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("enableFan")), false)?.BoolValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enableFan")), false)?.BoolValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (int?), OriginalType = typeof (NSNumber))]
		public virtual int? FanSpeedIndex {
			[Export ("fanSpeedIndex", ArgumentSemantic.Copy)]
			get {
				int? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fanSpeedIndex")), false)?.Int32Value;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fanSpeedIndex")), false)?.Int32Value;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (double?), OriginalType = typeof (NSNumber))]
		public virtual double? FanSpeedPercentage {
			[Export ("fanSpeedPercentage", ArgumentSemantic.Copy)]
			get {
				double? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fanSpeedPercentage")), false)?.DoubleValue;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fanSpeedPercentage")), false)?.DoubleValue;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INRelativeSetting RelativeFanSpeedSetting {
			[Export ("relativeFanSpeedSetting", ArgumentSemantic.Assign)]
			get {
				INRelativeSetting ret;
				if (IsDirectBinding) {
					ret = (Intents.INRelativeSetting) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("relativeFanSpeedSetting"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INRelativeSetting) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("relativeFanSpeedSetting"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INRelativeSetting RelativeTemperatureSetting {
			[Export ("relativeTemperatureSetting", ArgumentSemantic.Assign)]
			get {
				INRelativeSetting ret;
				if (IsDirectBinding) {
					ret = (Intents.INRelativeSetting) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("relativeTemperatureSetting"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INRelativeSetting) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("relativeTemperatureSetting"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMeasurement<NSUnitTemperature>? Temperature {
			[Export ("temperature", ArgumentSemantic.Copy)]
			get {
				NSMeasurement<NSUnitTemperature>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMeasurement<NSUnitTemperature>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("temperature")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMeasurement<NSUnitTemperature>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("temperature")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class INSetClimateSettingsInCarIntent */
}
