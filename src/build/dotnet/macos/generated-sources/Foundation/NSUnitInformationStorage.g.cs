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
	[Register("NSUnitInformationStorage", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSUnitInformationStorage : NSDimension, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitsX = "bits";
		static readonly NativeHandle selBitsXHandle = Selector.GetHandle ("bits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBytesX = "bytes";
		static readonly NativeHandle selBytesXHandle = Selector.GetHandle ("bytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExabitsX = "exabits";
		static readonly NativeHandle selExabitsXHandle = Selector.GetHandle ("exabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExabytesX = "exabytes";
		static readonly NativeHandle selExabytesXHandle = Selector.GetHandle ("exabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExbibitsX = "exbibits";
		static readonly NativeHandle selExbibitsXHandle = Selector.GetHandle ("exbibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExbibytesX = "exbibytes";
		static readonly NativeHandle selExbibytesXHandle = Selector.GetHandle ("exbibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGibibitsX = "gibibits";
		static readonly NativeHandle selGibibitsXHandle = Selector.GetHandle ("gibibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGibibytesX = "gibibytes";
		static readonly NativeHandle selGibibytesXHandle = Selector.GetHandle ("gibibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGigabitsX = "gigabits";
		static readonly NativeHandle selGigabitsXHandle = Selector.GetHandle ("gigabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGigabytesX = "gigabytes";
		static readonly NativeHandle selGigabytesXHandle = Selector.GetHandle ("gigabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSymbol_X = "initWithSymbol:";
		static readonly NativeHandle selInitWithSymbol_XHandle = Selector.GetHandle ("initWithSymbol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSymbol_Converter_X = "initWithSymbol:converter:";
		static readonly NativeHandle selInitWithSymbol_Converter_XHandle = Selector.GetHandle ("initWithSymbol:converter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKibibitsX = "kibibits";
		static readonly NativeHandle selKibibitsXHandle = Selector.GetHandle ("kibibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKibibytesX = "kibibytes";
		static readonly NativeHandle selKibibytesXHandle = Selector.GetHandle ("kibibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKilobitsX = "kilobits";
		static readonly NativeHandle selKilobitsXHandle = Selector.GetHandle ("kilobits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKilobytesX = "kilobytes";
		static readonly NativeHandle selKilobytesXHandle = Selector.GetHandle ("kilobytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMebibitsX = "mebibits";
		static readonly NativeHandle selMebibitsXHandle = Selector.GetHandle ("mebibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMebibytesX = "mebibytes";
		static readonly NativeHandle selMebibytesXHandle = Selector.GetHandle ("mebibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMegabitsX = "megabits";
		static readonly NativeHandle selMegabitsXHandle = Selector.GetHandle ("megabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMegabytesX = "megabytes";
		static readonly NativeHandle selMegabytesXHandle = Selector.GetHandle ("megabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNibblesX = "nibbles";
		static readonly NativeHandle selNibblesXHandle = Selector.GetHandle ("nibbles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPebibitsX = "pebibits";
		static readonly NativeHandle selPebibitsXHandle = Selector.GetHandle ("pebibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPebibytesX = "pebibytes";
		static readonly NativeHandle selPebibytesXHandle = Selector.GetHandle ("pebibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPetabitsX = "petabits";
		static readonly NativeHandle selPetabitsXHandle = Selector.GetHandle ("petabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPetabytesX = "petabytes";
		static readonly NativeHandle selPetabytesXHandle = Selector.GetHandle ("petabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTebibitsX = "tebibits";
		static readonly NativeHandle selTebibitsXHandle = Selector.GetHandle ("tebibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTebibytesX = "tebibytes";
		static readonly NativeHandle selTebibytesXHandle = Selector.GetHandle ("tebibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTerabitsX = "terabits";
		static readonly NativeHandle selTerabitsXHandle = Selector.GetHandle ("terabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTerabytesX = "terabytes";
		static readonly NativeHandle selTerabytesXHandle = Selector.GetHandle ("terabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYobibitsX = "yobibits";
		static readonly NativeHandle selYobibitsXHandle = Selector.GetHandle ("yobibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYobibytesX = "yobibytes";
		static readonly NativeHandle selYobibytesXHandle = Selector.GetHandle ("yobibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYottabitsX = "yottabits";
		static readonly NativeHandle selYottabitsXHandle = Selector.GetHandle ("yottabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYottabytesX = "yottabytes";
		static readonly NativeHandle selYottabytesXHandle = Selector.GetHandle ("yottabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZebibitsX = "zebibits";
		static readonly NativeHandle selZebibitsXHandle = Selector.GetHandle ("zebibits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZebibytesX = "zebibytes";
		static readonly NativeHandle selZebibytesXHandle = Selector.GetHandle ("zebibytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZettabitsX = "zettabits";
		static readonly NativeHandle selZettabitsXHandle = Selector.GetHandle ("zettabits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZettabytesX = "zettabytes";
		static readonly NativeHandle selZettabytesXHandle = Selector.GetHandle ("zettabytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUnitInformationStorage");
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
		public NSUnitInformationStorage (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSUnitInformationStorage (NSObjectFlag t) : base (t)
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
		protected internal NSUnitInformationStorage (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSymbol:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUnitInformationStorage (string symbol)
			: base (NSObjectFlag.Empty)
		{
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var nssymbol = CFString.CreateNative (symbol);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithSymbol_XHandle, nssymbol), "initWithSymbol:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSymbol_XHandle, nssymbol), "initWithSymbol:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssymbol);
		}
		[Export ("initWithSymbol:converter:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUnitInformationStorage (string symbol, NSUnitConverter converter)
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
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
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
		public static NSUnitInformationStorage Bits {
			[Export ("bits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Bytes {
			[Export ("bytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Exabits {
			[Export ("exabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Exabytes {
			[Export ("exabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Exbibits {
			[Export ("exbibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExbibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Exbibytes {
			[Export ("exbibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExbibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Gibibits {
			[Export ("gibibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGibibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Gibibytes {
			[Export ("gibibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGibibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Gigabits {
			[Export ("gigabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGigabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Gigabytes {
			[Export ("gigabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGigabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Kibibits {
			[Export ("kibibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKibibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Kibibytes {
			[Export ("kibibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKibibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Kilobits {
			[Export ("kilobits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKilobitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Kilobytes {
			[Export ("kilobytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKilobytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Mebibits {
			[Export ("mebibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMebibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Mebibytes {
			[Export ("mebibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMebibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Megabits {
			[Export ("megabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMegabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Megabytes {
			[Export ("megabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMegabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Nibbles {
			[Export ("nibbles", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNibblesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Pebibits {
			[Export ("pebibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPebibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Pebibytes {
			[Export ("pebibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPebibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Petabits {
			[Export ("petabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPetabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Petabytes {
			[Export ("petabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPetabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Tebibits {
			[Export ("tebibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTebibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Tebibytes {
			[Export ("tebibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTebibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Terabits {
			[Export ("terabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTerabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Terabytes {
			[Export ("terabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTerabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Yobibits {
			[Export ("yobibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYobibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Yobibytes {
			[Export ("yobibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYobibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Yottabits {
			[Export ("yottabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYottabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Yottabytes {
			[Export ("yottabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYottabytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Zebibits {
			[Export ("zebibits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZebibitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Zebibytes {
			[Export ("zebibytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZebibytesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Zettabits {
			[Export ("zettabits", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZettabitsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUnitInformationStorage Zettabytes {
			[Export ("zettabytes", ArgumentSemantic.Copy)]
			get {
				NSUnitInformationStorage? ret;
				ret =  Runtime.GetNSObject<NSUnitInformationStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZettabytesXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSUnitInformationStorage */
}
