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
	[Register("NSValue", true)]
	public unsafe partial class NSValue : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCATransform3DValueX = "CATransform3DValue";
		static readonly NativeHandle selCATransform3DValueXHandle = Selector.GetHandle ("CATransform3DValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCMTimeMappingValueX = "CMTimeMappingValue";
		static readonly NativeHandle selCMTimeMappingValueXHandle = Selector.GetHandle ("CMTimeMappingValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCMTimeRangeValueX = "CMTimeRangeValue";
		static readonly NativeHandle selCMTimeRangeValueXHandle = Selector.GetHandle ("CMTimeRangeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCMTimeValueX = "CMTimeValue";
		static readonly NativeHandle selCMTimeValueXHandle = Selector.GetHandle ("CMTimeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCMVideoDimensionsValueX = "CMVideoDimensionsValue";
		static readonly NativeHandle selCMVideoDimensionsValueXHandle = Selector.GetHandle ("CMVideoDimensionsValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGCPoint2ValueX = "GCPoint2Value";
		static readonly NativeHandle selGCPoint2ValueXHandle = Selector.GetHandle ("GCPoint2Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMKCoordinateSpanValueX = "MKCoordinateSpanValue";
		static readonly NativeHandle selMKCoordinateSpanValueXHandle = Selector.GetHandle ("MKCoordinateSpanValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMKCoordinateValueX = "MKCoordinateValue";
		static readonly NativeHandle selMKCoordinateValueXHandle = Selector.GetHandle ("MKCoordinateValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSCNMatrix4ValueX = "SCNMatrix4Value";
		static readonly NativeHandle selSCNMatrix4ValueXHandle = Selector.GetHandle ("SCNMatrix4Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSCNVector3ValueX = "SCNVector3Value";
		static readonly NativeHandle selSCNVector3ValueXHandle = Selector.GetHandle ("SCNVector3Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSCNVector4ValueX = "SCNVector4Value";
		static readonly NativeHandle selSCNVector4ValueXHandle = Selector.GetHandle ("SCNVector4Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetValue_X = "getValue:";
		static readonly NativeHandle selGetValue_XHandle = Selector.GetHandle ("getValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetValue_Size_X = "getValue:size:";
		static readonly NativeHandle selGetValue_Size_XHandle = Selector.GetHandle ("getValue:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToValue_X = "isEqualToValue:";
		static readonly NativeHandle selIsEqualToValue_XHandle = Selector.GetHandle ("isEqualToValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNonretainedObjectValueX = "nonretainedObjectValue";
		static readonly NativeHandle selNonretainedObjectValueXHandle = Selector.GetHandle ("nonretainedObjectValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjCTypeX = "objCType";
		static readonly NativeHandle selObjCTypeXHandle = Selector.GetHandle ("objCType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointValueX = "pointValue";
		static readonly NativeHandle selPointValueXHandle = Selector.GetHandle ("pointValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointerValueX = "pointerValue";
		static readonly NativeHandle selPointerValueXHandle = Selector.GetHandle ("pointerValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeValueX = "rangeValue";
		static readonly NativeHandle selRangeValueXHandle = Selector.GetHandle ("rangeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectValueX = "rectValue";
		static readonly NativeHandle selRectValueXHandle = Selector.GetHandle ("rectValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeValueX = "sizeValue";
		static readonly NativeHandle selSizeValueXHandle = Selector.GetHandle ("sizeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithBytes_ObjCType_X = "valueWithBytes:objCType:";
		static readonly NativeHandle selValueWithBytes_ObjCType_XHandle = Selector.GetHandle ("valueWithBytes:objCType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithCATransform3D_X = "valueWithCATransform3D:";
		static readonly NativeHandle selValueWithCATransform3D_XHandle = Selector.GetHandle ("valueWithCATransform3D:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithCMTime_X = "valueWithCMTime:";
		static readonly NativeHandle selValueWithCMTime_XHandle = Selector.GetHandle ("valueWithCMTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithCMTimeMapping_X = "valueWithCMTimeMapping:";
		static readonly NativeHandle selValueWithCMTimeMapping_XHandle = Selector.GetHandle ("valueWithCMTimeMapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithCMTimeRange_X = "valueWithCMTimeRange:";
		static readonly NativeHandle selValueWithCMTimeRange_XHandle = Selector.GetHandle ("valueWithCMTimeRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithCMVideoDimensions_X = "valueWithCMVideoDimensions:";
		static readonly NativeHandle selValueWithCMVideoDimensions_XHandle = Selector.GetHandle ("valueWithCMVideoDimensions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithGCPoint2_X = "valueWithGCPoint2:";
		static readonly NativeHandle selValueWithGCPoint2_XHandle = Selector.GetHandle ("valueWithGCPoint2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithMKCoordinate_X = "valueWithMKCoordinate:";
		static readonly NativeHandle selValueWithMKCoordinate_XHandle = Selector.GetHandle ("valueWithMKCoordinate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithMKCoordinateSpan_X = "valueWithMKCoordinateSpan:";
		static readonly NativeHandle selValueWithMKCoordinateSpan_XHandle = Selector.GetHandle ("valueWithMKCoordinateSpan:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNonretainedObject_X = "valueWithNonretainedObject:";
		static readonly NativeHandle selValueWithNonretainedObject_XHandle = Selector.GetHandle ("valueWithNonretainedObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithPoint_X = "valueWithPoint:";
		static readonly NativeHandle selValueWithPoint_XHandle = Selector.GetHandle ("valueWithPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithPointer_X = "valueWithPointer:";
		static readonly NativeHandle selValueWithPointer_XHandle = Selector.GetHandle ("valueWithPointer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithRange_X = "valueWithRange:";
		static readonly NativeHandle selValueWithRange_XHandle = Selector.GetHandle ("valueWithRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithRect_X = "valueWithRect:";
		static readonly NativeHandle selValueWithRect_XHandle = Selector.GetHandle ("valueWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithSCNMatrix4_X = "valueWithSCNMatrix4:";
		static readonly NativeHandle selValueWithSCNMatrix4_XHandle = Selector.GetHandle ("valueWithSCNMatrix4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithSCNVector3_X = "valueWithSCNVector3:";
		static readonly NativeHandle selValueWithSCNVector3_XHandle = Selector.GetHandle ("valueWithSCNVector3:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithSCNVector4_X = "valueWithSCNVector4:";
		static readonly NativeHandle selValueWithSCNVector4_XHandle = Selector.GetHandle ("valueWithSCNVector4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithSize_X = "valueWithSize:";
		static readonly NativeHandle selValueWithSize_XHandle = Selector.GetHandle ("valueWithSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSValue");
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
		public NSValue (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSValue (NSObjectFlag t) : base (t)
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
		protected internal NSValue (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
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
		[Export ("valueWithBytes:objCType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSValue Create (nint bytes, nint objCType)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, selValueWithBytes_ObjCType_XHandle, bytes, objCType), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		/// <param name="transform">To be added.</param><summary>Creates an NSValue that wraps a CATransform3D object.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithCATransform3D:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCATransform3D (global::CoreAnimation.CATransform3D transform)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CATransform3D (class_ptr, selValueWithCATransform3D_XHandle, transform), false)!;
			return ret;
		}
		[Export ("valueWithPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCGPoint (CGPoint point)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (class_ptr, selValueWithPoint_XHandle, point), false)!;
			return ret;
		}
		[Export ("valueWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCGRect (CGRect rect)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selValueWithRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("valueWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCGSize (CGSize size)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (class_ptr, selValueWithSize_XHandle, size), false)!;
			return ret;
		}
		/// <param name="time">To be added.</param><summary>Creates an NSValue that wraps a CMTime object..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithCMTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCMTime (global::CoreMedia.CMTime time)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTime (class_ptr, selValueWithCMTime_XHandle, time), false)!;
			return ret;
		}
		/// <param name="timeMapping">To be added.</param><summary>Creates an NSValue that wraps a CMTimeMapping object.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithCMTimeMapping:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCMTimeMapping (global::CoreMedia.CMTimeMapping timeMapping)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeMapping (class_ptr, selValueWithCMTimeMapping_XHandle, timeMapping), false)!;
			return ret;
		}
		/// <param name="timeRange">To be added.</param><summary>Creates an NSValue that wraps a CMTimeRange object.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithCMTimeRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCMTimeRange (global::CoreMedia.CMTimeRange timeRange)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMTimeRange (class_ptr, selValueWithCMTimeRange_XHandle, timeRange), false)!;
			return ret;
		}
		[Export ("valueWithCMVideoDimensions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromCMVideoDimensions (global::CoreMedia.CMVideoDimensions value)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CMVideoDimensions (class_ptr, selValueWithCMVideoDimensions_XHandle, value), false)!;
			return ret;
		}
		[Export ("valueWithGCPoint2:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.3")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromGCPoint2 (global::GameController.GCPoint2 point)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_GCPoint2 (class_ptr, selValueWithGCPoint2_XHandle, point), false)!;
			return ret;
		}
		/// <param name="coordinate">To be added.</param><summary>Creates an NSValue that stores a CLLocationCoordinate2D.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithMKCoordinate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromMKCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CLLocationCoordinate2D (class_ptr, selValueWithMKCoordinate_XHandle, coordinate), false)!;
			return ret;
		}
		/// <param name="coordinateSpan">To be added.</param><summary>Creates an NSValue that stores an MKCoordinateSpan.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithMKCoordinateSpan:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromMKCoordinateSpan (global::MapKit.MKCoordinateSpan coordinateSpan)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_MKCoordinateSpan (class_ptr, selValueWithMKCoordinateSpan_XHandle, coordinateSpan), false)!;
			return ret;
		}
		[Export ("valueWithRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromRange (NSRange range)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (class_ptr, selValueWithRange_XHandle, range), false)!;
			return ret;
		}
		/// <param name="matrix">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithSCNMatrix4:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromSCNMatrix4 (global::SceneKit.SCNMatrix4 matrix)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNMatrix4 (class_ptr, selValueWithSCNMatrix4_XHandle, matrix), false)!;
			return ret;
		}
		/// <param name="vector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithSCNVector3:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromVector (global::SceneKit.SCNVector3 vector)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector3 (class_ptr, selValueWithSCNVector3_XHandle, vector), false)!;
			return ret;
		}
		/// <param name="vector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueWithSCNVector4:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue FromVector (global::SceneKit.SCNVector4 vector)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector4 (class_ptr, selValueWithSCNVector4_XHandle, vector), false)!;
			return ret;
		}
		[Export ("isEqualToValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualTo (NSValue value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualToValue_XHandle, value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualToValue_XHandle, value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret != 0;
		}
		[Export ("objCType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint ObjCTypePtr ()
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjCTypeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selObjCTypeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getValue:")]
		[ObsoletedOSPlatform ("macos10.13", "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StoreValueAtAddress (nint value)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetValue_XHandle, value);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selGetValue_XHandle, value);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getValue:size:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StoreValueAtAddress (nint value, nuint size)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetValue_Size_XHandle, value, size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetValue_Size_XHandle, value, size);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("valueWithNonretainedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueFromNonretainedObject (NSObject anObject)
		{
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			NSValue? ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueWithNonretainedObject_XHandle, anObject__handle__), false)!;
			GC.KeepAlive (anObject);
			return ret!;
		}
		[Export ("valueWithPointer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue ValueFromPointer (nint pointer)
		{
			NSValue ret;
			ret =  Runtime.GetNSObject<NSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selValueWithPointer_XHandle, pointer), false)!;
			return ret;
		}
		/// <summary>Returns the CATransform3D value wrapped by this NSValue object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CATransform3D CATransform3DValue {
			[Export ("CATransform3DValue")]
			get {
				global::CoreAnimation.CATransform3D ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend (this.Handle, selCATransform3DValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend_stret (this.Handle, selCATransform3DValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper (&__objc_super__, selCATransform3DValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper_stret (&__objc_super__, selCATransform3DValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGPoint CGPointValue {
			[Export ("pointValue")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selPointValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selPointValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGRect CGRectValue {
			[Export ("rectValue")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selRectValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selRectValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selRectValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selRectValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGSize CGSizeValue {
			[Export ("sizeValue")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selSizeValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selSizeValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Returns the CMTimeMapping value wrapped by this NSValue object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreMedia.CMTimeMapping CMTimeMappingValue {
			[Export ("CMTimeMappingValue")]
			get {
				global::CoreMedia.CMTimeMapping ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTimeMapping_objc_msgSend (this.Handle, selCMTimeMappingValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTimeMapping_objc_msgSend_stret (this.Handle, selCMTimeMappingValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeMapping_objc_msgSendSuper (&__objc_super__, selCMTimeMappingValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeMapping_objc_msgSendSuper_stret (&__objc_super__, selCMTimeMappingValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the CMTimeRange value wrapped by this NSValue object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreMedia.CMTimeRange CMTimeRangeValue {
			[Export ("CMTimeRangeValue")]
			get {
				global::CoreMedia.CMTimeRange ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend (this.Handle, selCMTimeRangeValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSend_stret (this.Handle, selCMTimeRangeValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper (&__objc_super__, selCMTimeRangeValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTimeRange_objc_msgSendSuper_stret (&__objc_super__, selCMTimeRangeValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the CMTime value wrapped by this NSValue object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreMedia.CMTime CMTimeValue {
			[Export ("CMTimeValue")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selCMTimeValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selCMTimeValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selCMTimeValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selCMTimeValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual global::CoreMedia.CMVideoDimensions CMVideoDimensionsValue {
			[Export ("CMVideoDimensionsValue")]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, selCMVideoDimensionsValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSendSuper (&__objc_super__, selCMVideoDimensionsValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The MKCoordinateSpan stored in this NSValue.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::MapKit.MKCoordinateSpan CoordinateSpanValue {
			[Export ("MKCoordinateSpanValue")]
			get {
				global::MapKit.MKCoordinateSpan ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.MKCoordinateSpan_objc_msgSend (this.Handle, selMKCoordinateSpanValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateSpan_objc_msgSendSuper (&__objc_super__, selMKCoordinateSpanValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The CLLocationCoordinate2D stored in this NSValue.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::CoreLocation.CLLocationCoordinate2D CoordinateValue {
			[Export ("MKCoordinateValue")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, selMKCoordinateValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (&__objc_super__, selMKCoordinateValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.3")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual global::GameController.GCPoint2 GCPoint2Value {
			[Export ("GCPoint2Value")]
			get {
				global::GameController.GCPoint2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.GCPoint2_objc_msgSend (this.Handle, selGCPoint2ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.GCPoint2_objc_msgSendSuper (&__objc_super__, selGCPoint2ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject NonretainedObjectValue {
			[Export ("nonretainedObjectValue")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNonretainedObjectValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNonretainedObjectValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PointerValue {
			[Export ("pointerValue")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPointerValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPointerValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeValue {
			[Export ("rangeValue")]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::SceneKit.SCNMatrix4 SCNMatrix4Value {
			[Export ("SCNMatrix4Value")]
			get {
				global::SceneKit.SCNMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend (this.Handle, selSCNMatrix4ValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret (this.Handle, selSCNMatrix4ValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper (&__objc_super__, selSCNMatrix4ValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret (&__objc_super__, selSCNMatrix4ValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::SceneKit.SCNVector3 Vector3Value {
			[Export ("SCNVector3Value")]
			get {
				global::SceneKit.SCNVector3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, selSCNVector3ValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_stret (this.Handle, selSCNVector3ValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, selSCNVector3ValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_stret (&__objc_super__, selSCNVector3ValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::SceneKit.SCNVector4 Vector4Value {
			[Export ("SCNVector4Value")]
			get {
				global::SceneKit.SCNVector4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSend (this.Handle, selSCNVector4ValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSend_stret (this.Handle, selSCNVector4ValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSendSuper (&__objc_super__, selSCNVector4ValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSendSuper_stret (&__objc_super__, selSCNVector4ValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
	} /* class NSValue */
}
