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
namespace Foundation {
	[Register("NSUnitVolume", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUnitVolume : NSDimension, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUnitVolume");
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
		public NSUnitVolume (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSUnitVolume (NSObjectFlag t) : base (t)
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
		protected internal NSUnitVolume (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSymbol:converter:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUnitVolume (string symbol, NSUnitConverter converter)
			: base (NSObjectFlag.Empty)
		{
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var converter__handle__ = converter!.GetNonNullHandle (nameof (converter));
			var nssymbol = CFString.CreateNative (symbol);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithSymbol:converter:"), nssymbol, converter__handle__), "initWithSymbol:converter:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithSymbol:converter:"), nssymbol, converter__handle__), "initWithSymbol:converter:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (converter);
			CFString.ReleaseNative (nssymbol);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume AcreFeet {
			[Export ("acreFeet", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("acreFeet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static NSDimension BaseUnit {
			[Export ("baseUnit")]
			get {
				NSDimension? ret;
				ret =  Runtime.GetNSObject<NSDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("baseUnit")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Bushels {
			[Export ("bushels", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bushels")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Centiliters {
			[Export ("centiliters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("centiliters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicCentimeters {
			[Export ("cubicCentimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicCentimeters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicDecimeters {
			[Export ("cubicDecimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicDecimeters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicFeet {
			[Export ("cubicFeet", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicFeet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicInches {
			[Export ("cubicInches", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicInches")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicKilometers {
			[Export ("cubicKilometers", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicKilometers")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicMeters {
			[Export ("cubicMeters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicMeters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicMiles {
			[Export ("cubicMiles", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicMiles")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicMillimeters {
			[Export ("cubicMillimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicMillimeters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume CubicYards {
			[Export ("cubicYards", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cubicYards")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Cups {
			[Export ("cups", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cups")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Deciliters {
			[Export ("deciliters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("deciliters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume FluidOunces {
			[Export ("fluidOunces", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("fluidOunces")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Gallons {
			[Export ("gallons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("gallons")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialFluidOunces {
			[Export ("imperialFluidOunces", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialFluidOunces")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialGallons {
			[Export ("imperialGallons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialGallons")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialPints {
			[Export ("imperialPints", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialPints")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialQuarts {
			[Export ("imperialQuarts", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialQuarts")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialTablespoons {
			[Export ("imperialTablespoons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialTablespoons")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume ImperialTeaspoons {
			[Export ("imperialTeaspoons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("imperialTeaspoons")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Kiloliters {
			[Export ("kiloliters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("kiloliters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Liters {
			[Export ("liters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("liters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Megaliters {
			[Export ("megaliters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("megaliters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume MetricCups {
			[Export ("metricCups", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("metricCups")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Milliliters {
			[Export ("milliliters", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("milliliters")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Pints {
			[Export ("pints", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pints")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Quarts {
			[Export ("quarts", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("quarts")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Tablespoons {
			[Export ("tablespoons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("tablespoons")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitVolume Teaspoons {
			[Export ("teaspoons", ArgumentSemantic.Copy)]
			get {
				NSUnitVolume? ret;
				ret =  Runtime.GetNSObject<NSUnitVolume> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("teaspoons")), false)!;
				return ret!;
			}
		}
	} /* class NSUnitVolume */
}
