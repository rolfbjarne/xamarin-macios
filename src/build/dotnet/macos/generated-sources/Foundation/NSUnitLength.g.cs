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
namespace Foundation {
	[Register("NSUnitLength", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUnitLength : NSDimension, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAstronomicalUnitsX = "astronomicalUnits";
		static readonly NativeHandle selAstronomicalUnitsXHandle = Selector.GetHandle ("astronomicalUnits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseUnitX = "baseUnit";
		static readonly NativeHandle selBaseUnitXHandle = Selector.GetHandle ("baseUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCentimetersX = "centimeters";
		static readonly NativeHandle selCentimetersXHandle = Selector.GetHandle ("centimeters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecametersX = "decameters";
		static readonly NativeHandle selDecametersXHandle = Selector.GetHandle ("decameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimetersX = "decimeters";
		static readonly NativeHandle selDecimetersXHandle = Selector.GetHandle ("decimeters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFathomsX = "fathoms";
		static readonly NativeHandle selFathomsXHandle = Selector.GetHandle ("fathoms");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFeetX = "feet";
		static readonly NativeHandle selFeetXHandle = Selector.GetHandle ("feet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFurlongsX = "furlongs";
		static readonly NativeHandle selFurlongsXHandle = Selector.GetHandle ("furlongs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHectometersX = "hectometers";
		static readonly NativeHandle selHectometersXHandle = Selector.GetHandle ("hectometers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInchesX = "inches";
		static readonly NativeHandle selInchesXHandle = Selector.GetHandle ("inches");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSymbol_Converter_X = "initWithSymbol:converter:";
		static readonly NativeHandle selInitWithSymbol_Converter_XHandle = Selector.GetHandle ("initWithSymbol:converter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKilometersX = "kilometers";
		static readonly NativeHandle selKilometersXHandle = Selector.GetHandle ("kilometers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLightyearsX = "lightyears";
		static readonly NativeHandle selLightyearsXHandle = Selector.GetHandle ("lightyears");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMegametersX = "megameters";
		static readonly NativeHandle selMegametersXHandle = Selector.GetHandle ("megameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetersX = "meters";
		static readonly NativeHandle selMetersXHandle = Selector.GetHandle ("meters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMicrometersX = "micrometers";
		static readonly NativeHandle selMicrometersXHandle = Selector.GetHandle ("micrometers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMilesX = "miles";
		static readonly NativeHandle selMilesXHandle = Selector.GetHandle ("miles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMillimetersX = "millimeters";
		static readonly NativeHandle selMillimetersXHandle = Selector.GetHandle ("millimeters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNanometersX = "nanometers";
		static readonly NativeHandle selNanometersXHandle = Selector.GetHandle ("nanometers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNauticalMilesX = "nauticalMiles";
		static readonly NativeHandle selNauticalMilesXHandle = Selector.GetHandle ("nauticalMiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParsecsX = "parsecs";
		static readonly NativeHandle selParsecsXHandle = Selector.GetHandle ("parsecs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPicometersX = "picometers";
		static readonly NativeHandle selPicometersXHandle = Selector.GetHandle ("picometers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScandinavianMilesX = "scandinavianMiles";
		static readonly NativeHandle selScandinavianMilesXHandle = Selector.GetHandle ("scandinavianMiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYardsX = "yards";
		static readonly NativeHandle selYardsXHandle = Selector.GetHandle ("yards");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUnitLength");
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
		public NSUnitLength (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSUnitLength (NSObjectFlag t) : base (t)
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
		protected internal NSUnitLength (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSymbol:converter:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUnitLength (string symbol, NSUnitConverter converter)
			: base (NSObjectFlag.Empty)
		{
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var converter__handle__ = converter!.GetNonNullHandle (nameof (converter));
			var nssymbol = CFString.CreateNative (symbol);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithSymbol_Converter_XHandle, nssymbol, converter__handle__), "initWithSymbol:converter:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithSymbol_Converter_XHandle, nssymbol, converter__handle__), "initWithSymbol:converter:");
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
		public static NSUnitLength AstronomicalUnits {
			[Export ("astronomicalUnits", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAstronomicalUnitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static NSDimension BaseUnit {
			[Export ("baseUnit")]
			get {
				NSDimension? ret;
				ret =  Runtime.GetNSObject<NSDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBaseUnitXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Centimeters {
			[Export ("centimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCentimetersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Decameters {
			[Export ("decameters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecametersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Decimeters {
			[Export ("decimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecimetersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Fathoms {
			[Export ("fathoms", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFathomsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Feet {
			[Export ("feet", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFeetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Furlongs {
			[Export ("furlongs", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFurlongsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Hectometers {
			[Export ("hectometers", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHectometersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Inches {
			[Export ("inches", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInchesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Kilometers {
			[Export ("kilometers", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKilometersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Lightyears {
			[Export ("lightyears", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLightyearsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Megameters {
			[Export ("megameters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMegametersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Meters {
			[Export ("meters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMetersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Micrometers {
			[Export ("micrometers", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMicrometersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Miles {
			[Export ("miles", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMilesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Millimeters {
			[Export ("millimeters", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMillimetersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Nanometers {
			[Export ("nanometers", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNanometersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength NauticalMiles {
			[Export ("nauticalMiles", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNauticalMilesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Parsecs {
			[Export ("parsecs", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selParsecsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Picometers {
			[Export ("picometers", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPicometersXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength ScandinavianMiles {
			[Export ("scandinavianMiles", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScandinavianMilesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitLength Yards {
			[Export ("yards", ArgumentSemantic.Copy)]
			get {
				NSUnitLength? ret;
				ret =  Runtime.GetNSObject<NSUnitLength> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYardsXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSUnitLength */
}
