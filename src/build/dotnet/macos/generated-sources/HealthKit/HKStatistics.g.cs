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
	/// <summary>Provides basic statistical operations on health information.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HealthKit/Reference/HKStatistics_Class/index.html">Apple documentation for <c>HKStatistics</c></related>
	[Register("HKStatistics", true)]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class HKStatistics : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAverageQuantityX = "averageQuantity";
		static readonly NativeHandle selAverageQuantityXHandle = Selector.GetHandle ("averageQuantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAverageQuantityForSource_X = "averageQuantityForSource:";
		static readonly NativeHandle selAverageQuantityForSource_XHandle = Selector.GetHandle ("averageQuantityForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationForSource_X = "durationForSource:";
		static readonly NativeHandle selDurationForSource_XHandle = Selector.GetHandle ("durationForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndDateX = "endDate";
		static readonly NativeHandle selEndDateXHandle = Selector.GetHandle ("endDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumQuantityX = "maximumQuantity";
		static readonly NativeHandle selMaximumQuantityXHandle = Selector.GetHandle ("maximumQuantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumQuantityForSource_X = "maximumQuantityForSource:";
		static readonly NativeHandle selMaximumQuantityForSource_XHandle = Selector.GetHandle ("maximumQuantityForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumQuantityX = "minimumQuantity";
		static readonly NativeHandle selMinimumQuantityXHandle = Selector.GetHandle ("minimumQuantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumQuantityForSource_X = "minimumQuantityForSource:";
		static readonly NativeHandle selMinimumQuantityForSource_XHandle = Selector.GetHandle ("minimumQuantityForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMostRecentQuantityX = "mostRecentQuantity";
		static readonly NativeHandle selMostRecentQuantityXHandle = Selector.GetHandle ("mostRecentQuantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMostRecentQuantityDateIntervalX = "mostRecentQuantityDateInterval";
		static readonly NativeHandle selMostRecentQuantityDateIntervalXHandle = Selector.GetHandle ("mostRecentQuantityDateInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMostRecentQuantityDateIntervalForSource_X = "mostRecentQuantityDateIntervalForSource:";
		static readonly NativeHandle selMostRecentQuantityDateIntervalForSource_XHandle = Selector.GetHandle ("mostRecentQuantityDateIntervalForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMostRecentQuantityForSource_X = "mostRecentQuantityForSource:";
		static readonly NativeHandle selMostRecentQuantityForSource_XHandle = Selector.GetHandle ("mostRecentQuantityForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuantityTypeX = "quantityType";
		static readonly NativeHandle selQuantityTypeXHandle = Selector.GetHandle ("quantityType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourcesX = "sources";
		static readonly NativeHandle selSourcesXHandle = Selector.GetHandle ("sources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSumQuantityX = "sumQuantity";
		static readonly NativeHandle selSumQuantityXHandle = Selector.GetHandle ("sumQuantity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSumQuantityForSource_X = "sumQuantityForSource:";
		static readonly NativeHandle selSumQuantityForSource_XHandle = Selector.GetHandle ("sumQuantityForSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("HKStatistics");
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
		public HKStatistics (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected HKStatistics (NSObjectFlag t) : base (t)
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
		protected internal HKStatistics (NativeHandle handle) : base (handle)
		{
		}

		[Export ("averageQuantityForSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? AverageQuantity (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAverageQuantityForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAverageQuantityForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("averageQuantity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? AverageQuantity ()
		{
			HKQuantity ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAverageQuantityXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAverageQuantityXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
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
		[Export ("durationForSource:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? GetDuration (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDurationForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDurationForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("mostRecentQuantityForSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? GetMostRecentQuantity (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMostRecentQuantityForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMostRecentQuantityForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("mostRecentQuantityDateIntervalForSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDateInterval? GetMostRecentQuantityDateInterval (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			NSDateInterval? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateInterval> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMostRecentQuantityDateIntervalForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateInterval> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMostRecentQuantityDateIntervalForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("maximumQuantityForSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? MaximumQuantity (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMaximumQuantityForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMaximumQuantityForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("maximumQuantity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? MaximumQuantity ()
		{
			HKQuantity ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMaximumQuantityXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMaximumQuantityXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("minimumQuantityForSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? MinimumQuantity (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMinimumQuantityForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMinimumQuantityForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("minimumQuantity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? MinimumQuantity ()
		{
			HKQuantity ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMinimumQuantityXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMinimumQuantityXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sumQuantityForSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? SumQuantity (HKSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			HKQuantity? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSumQuantityForSource_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSumQuantityForSource_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("sumQuantity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKQuantity? SumQuantity ()
		{
			HKQuantity ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSumQuantityXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSumQuantityXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual HKQuantity? Duration {
			[Export ("duration")]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate EndDate {
			[Export ("endDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEndDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEndDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual HKQuantity? MostRecentQuantity {
			[Export ("mostRecentQuantity")]
			get {
				HKQuantity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMostRecentQuantityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<HKQuantity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMostRecentQuantityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		public virtual NSDateInterval? MostRecentQuantityDateInterval {
			[Export ("mostRecentQuantityDateInterval")]
			get {
				NSDateInterval? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDateInterval> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMostRecentQuantityDateIntervalXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDateInterval> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMostRecentQuantityDateIntervalXHandle), false)!;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual HKSource[]? Sources {
			[Export ("sources")]
			get {
				HKSource[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<HKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourcesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<HKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourcesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate StartDate {
			[Export ("startDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class HKStatistics */
}
