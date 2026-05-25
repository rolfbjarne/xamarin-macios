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
	[Register("HKAudiogramSensitivityPoint", true)]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class HKAudiogramSensitivityPoint : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrequencyX = "frequency";
		static readonly NativeHandle selFrequencyXHandle = Selector.GetHandle ("frequency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftEarSensitivityX = "leftEarSensitivity";
		static readonly NativeHandle selLeftEarSensitivityXHandle = Selector.GetHandle ("leftEarSensitivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightEarSensitivityX = "rightEarSensitivity";
		static readonly NativeHandle selRightEarSensitivityXHandle = Selector.GetHandle ("rightEarSensitivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensitivityPointWithFrequency_LeftEarSensitivity_RightEarSensitivity_Error_X = "sensitivityPointWithFrequency:leftEarSensitivity:rightEarSensitivity:error:";
		static readonly NativeHandle selSensitivityPointWithFrequency_LeftEarSensitivity_RightEarSensitivity_Error_XHandle = Selector.GetHandle ("sensitivityPointWithFrequency:leftEarSensitivity:rightEarSensitivity:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensitivityPointWithFrequency_Tests_Error_X = "sensitivityPointWithFrequency:tests:error:";
		static readonly NativeHandle selSensitivityPointWithFrequency_Tests_Error_XHandle = Selector.GetHandle ("sensitivityPointWithFrequency:tests:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTestsX = "tests";
		static readonly NativeHandle selTestsXHandle = Selector.GetHandle ("tests");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKAudiogramSensitivityPoint");
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
		public HKAudiogramSensitivityPoint (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKAudiogramSensitivityPoint (NSObjectFlag t) : base (t)
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
		protected internal HKAudiogramSensitivityPoint (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("sensitivityPointWithFrequency:leftEarSensitivity:rightEarSensitivity:error:")]
		[ObsoletedOSPlatform ("ios18.1", "Use the 'HKAudiogramSensitivityTest' overload instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.1", "Use the 'HKAudiogramSensitivityTest' overload instead.")]
		[ObsoletedOSPlatform ("macos15.1", "Use the 'HKAudiogramSensitivityTest' overload instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static HKAudiogramSensitivityPoint? GetSensitivityPoint (HKQuantity frequency, HKQuantity? leftEarSensitivity, HKQuantity? rightEarSensitivity, out NSError? error)
		{
			var frequency__handle__ = frequency!.GetNonNullHandle (nameof (frequency));
			var leftEarSensitivity__handle__ = leftEarSensitivity.GetHandle ();
			var rightEarSensitivity__handle__ = rightEarSensitivity.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			HKAudiogramSensitivityPoint? ret;
			ret =  Runtime.GetNSObject<HKAudiogramSensitivityPoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selSensitivityPointWithFrequency_LeftEarSensitivity_RightEarSensitivity_Error_XHandle, frequency__handle__, leftEarSensitivity__handle__, rightEarSensitivity__handle__, &errorValue), false)!;
			GC.KeepAlive (frequency);
			GC.KeepAlive (leftEarSensitivity);
			GC.KeepAlive (rightEarSensitivity);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("sensitivityPointWithFrequency:tests:error:")]
		[SupportedOSPlatform ("maccatalyst18.1")]
		[SupportedOSPlatform ("macos15.1")]
		[SupportedOSPlatform ("ios18.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static HKAudiogramSensitivityPoint? GetSensitivityPoint (HKQuantity frequency, HKAudiogramSensitivityTest[] tests, out NSError? error)
		{
			var frequency__handle__ = frequency!.GetNonNullHandle (nameof (frequency));
			if (tests is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tests));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_tests = NSArray.FromNSObjects (tests);
			HKAudiogramSensitivityPoint? ret;
			ret =  Runtime.GetNSObject<HKAudiogramSensitivityPoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selSensitivityPointWithFrequency_Tests_Error_XHandle, frequency__handle__, nsa_tests.Handle, &errorValue), false)!;
			GC.KeepAlive (frequency);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity Frequency {
			[Export ("frequency", ArgumentSemantic.Copy)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFrequencyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFrequencyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios18.1")]
		[ObsoletedOSPlatform ("maccatalyst18.1")]
		[ObsoletedOSPlatform ("macos15.1")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual HKQuantity? LeftEarSensitivity {
			[Export ("leftEarSensitivity", ArgumentSemantic.Copy)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftEarSensitivityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftEarSensitivityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios18.1")]
		[ObsoletedOSPlatform ("maccatalyst18.1")]
		[ObsoletedOSPlatform ("macos15.1")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual HKQuantity? RightEarSensitivity {
			[Export ("rightEarSensitivity", ArgumentSemantic.Copy)]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightEarSensitivityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightEarSensitivityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst18.1")]
		[SupportedOSPlatform ("macos15.1")]
		[SupportedOSPlatform ("ios18.1")]
		public virtual HKAudiogramSensitivityTest[] Tests {
			[Export ("tests", ArgumentSemantic.Copy)]
			get {
				HKAudiogramSensitivityTest[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<HKAudiogramSensitivityTest>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTestsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<HKAudiogramSensitivityTest>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTestsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class HKAudiogramSensitivityPoint */
}
