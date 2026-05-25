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
namespace CoreImage {
	/// <summary>A vector for use with Core Image objects such as <see cref="T:CoreImage.CIFilter" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/QuartzCoreFramework/Classes/CIVector_Class/index.html">Apple documentation for <c>CIVector</c></related>
	[Register("CIVector", true)]
	public unsafe partial class CIVector : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIVector");
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
		public CIVector (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CIVector (NSObjectFlag t) : base (t)
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
		protected internal CIVector (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="p">To be added.</param><summary>Creates a new CIVector for the specified point.</summary><remarks>To be added.</remarks>
		[Export ("initWithCGPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (CGPoint p)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("initWithCGPoint:"), p), "initWithCGPoint:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("initWithCGPoint:"), p), "initWithCGPoint:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="r">To be added.</param><summary>Creates a new CIVector and fills it with the X, Y, height, and width values.</summary><remarks>To be added.</remarks>
		[Export ("initWithCGRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (CGRect r)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithCGRect:"), r), "initWithCGRect:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithCGRect:"), r), "initWithCGRect:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="r">To be added.</param><summary>Creates a new CIVector by flattening the six values in an affine transform into the first six positions in the new CIVector.</summary><remarks>To be added.</remarks>
		[Export ("initWithCGAffineTransform:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (CGAffineTransform r)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("initWithCGAffineTransform:"), r), "initWithCGAffineTransform:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGAffineTransform (&__objc_super__, Selector.GetHandle ("initWithCGAffineTransform:"), r), "initWithCGAffineTransform:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="x">To be added.</param><summary>Creates a new one-dimensional vector.</summary><remarks>To be added.</remarks>
		[Export ("initWithX:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (nfloat x)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("initWithX:"), x), "initWithX:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("initWithX:"), x), "initWithX:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><summary>Creates a new CIVector with the specified X and Y coordinates.</summary><remarks>To be added.</remarks>
		[Export ("initWithX:Y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (nfloat x, nfloat y)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithX:Y:"), x, y), "initWithX:Y:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat (&__objc_super__, Selector.GetHandle ("initWithX:Y:"), x, y), "initWithX:Y:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><param name="z">To be added.</param><summary>Creates a new CIVector with the specified X, Y and Z coordinates.</summary><remarks>To be added.</remarks>
		[Export ("initWithX:Y:Z:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (nfloat x, nfloat y, nfloat z)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithX:Y:Z:"), x, y, z), "initWithX:Y:Z:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat (&__objc_super__, Selector.GetHandle ("initWithX:Y:Z:"), x, y, z), "initWithX:Y:Z:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><param name="z">To be added.</param><param name="w">To be added.</param><summary>Creates a new CIVector with the specified X, Y, Z, and W coordinates.</summary><remarks>To be added.</remarks>
		[Export ("initWithX:Y:Z:W:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (nfloat x, nfloat y, nfloat z, nfloat w)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithX:Y:Z:W:"), x, y, z, w), "initWithX:Y:Z:W:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat (&__objc_super__, Selector.GetHandle ("initWithX:Y:Z:W:"), x, y, z, w), "initWithX:Y:Z:W:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="representation">To be added.</param><summary>Creates a new CIVector from the specified string representation.</summary><remarks>To be added.</remarks>
		[Export ("initWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIVector (string representation)
			: base (NSObjectFlag.Empty)
		{
			if (representation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (representation));
			var nsrepresentation = CFString.CreateNative (representation);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithString:"), nsrepresentation), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithString:"), nsrepresentation), "initWithString:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsrepresentation);
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
		/// <param name="x">To be added.</param><summary>Creates a vector with the specified <paramref name="x" /> value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithX:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (nfloat x)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("vectorWithX:"), x), false)!;
			return ret;
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><summary>Creates a vector with the specified <paramref name="x" /> and <paramref name="y" /> values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithX:Y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (nfloat x, nfloat y)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (class_ptr, Selector.GetHandle ("vectorWithX:Y:"), x, y), false)!;
			return ret;
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><param name="z">To be added.</param><summary>Creates a vector with the specified <paramref name="x" />, <paramref name="y" />, and <paramref name="z" /> values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithX:Y:Z:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (nfloat x, nfloat y, nfloat z)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat (class_ptr, Selector.GetHandle ("vectorWithX:Y:Z:"), x, y, z), false)!;
			return ret;
		}
		/// <param name="x">To be added.</param><param name="y">To be added.</param><param name="z">To be added.</param><param name="w">To be added.</param><summary>Creates a vector with the specified <paramref name="x" />, <paramref name="y" />, and <paramref name="z" />, and <paramref name="w" /> values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithX:Y:Z:W:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (nfloat x, nfloat y, nfloat z, nfloat w)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, Selector.GetHandle ("vectorWithX:Y:Z:W:"), x, y, z, w), false)!;
			return ret;
		}
		/// <param name="point">To be added.</param><summary>Creates a <see cref="T:CoreGraphics.CGAffineTransform" /> that represents a directed distance from the origin to <paramref name="point" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithCGPoint:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (CGPoint point)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (class_ptr, Selector.GetHandle ("vectorWithCGPoint:"), point), false)!;
			return ret;
		}
		/// <param name="point">To be added.</param><summary>Creates a <see cref="T:CoreGraphics.CGAffineTransform" /> that stores the X-coordinate, Y-coordinate, height, and width in the <see cref="P:CoreImage.CIVector.X" />, <see cref="P:CoreImage.CIVector.Y" />. <see cref="P:CoreImage.CIVector.Z" />, and <see cref="P:CoreImage.CIVector.W" /> properties, respectively.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithCGRect:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (CGRect point)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, Selector.GetHandle ("vectorWithCGRect:"), point), false)!;
			return ret;
		}
		/// <param name="affineTransform">To be added.</param><summary>Creates a vector from a <see cref="T:CoreGraphics.CGAffineTransform" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithCGAffineTransform:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector Create (CGAffineTransform affineTransform)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform (class_ptr, Selector.GetHandle ("vectorWithCGAffineTransform:"), affineTransform), false)!;
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
		/// <param name="representation">To be added.</param><summary>Creates a vector from a string, such as "[1.0, 2.0, 3.0]".</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vectorWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIVector FromString (string representation)
		{
			if (representation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (representation));
			var nsrepresentation = CFString.CreateNative (representation);
			CIVector? ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("vectorWithString:"), nsrepresentation), false)!;
			CFString.ReleaseNative (nsrepresentation);
			return ret!;
		}
		[Export ("stringRepresentation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual string StringRepresentation ()
		{
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringRepresentation")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringRepresentation")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("valueAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nfloat ValueAtIndex (nint index)
		{
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("valueAtIndex:"), index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("valueAtIndex:"), index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("vectorWithValues:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CIVector _FromValues (nint values, nint count)
		{
			CIVector ret;
			ret =  Runtime.GetNSObject<CIVector> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("vectorWithValues:count:"), values, count), false)!;
			return ret;
		}
		/// <summary>Gets the affine transform that is represented by the first 6 elements of this <see cref="T:CoreImage.CIVector" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGAffineTransform AffineTransform {
			[Export ("CGAffineTransformValue")]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("CGAffineTransformValue"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("CGAffineTransformValue"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("CGAffineTransformValue"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("CGAffineTransformValue"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of items in this <see cref="T:CoreImage.CIVector" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Count {
			[Export ("count")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("count"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the point that is represented by (<see cref="P:CoreImage.CIVector.X" />,<see cref="P:CoreImage.CIVector.Y" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGPoint Point {
			[Export ("CGPointValue")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("CGPointValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("CGPointValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets a rectangle whose X-coordinate, Y-coordinate, height, and width are given by the <see cref="P:CoreImage.CIVector.X" />, <see cref="P:CoreImage.CIVector.Y" />. <see cref="P:CoreImage.CIVector.Z" />, and <see cref="P:CoreImage.CIVector.W" /> properties, respectively. .</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGRect Rectangle {
			[Export ("CGRectValue")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("CGRectValue"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("CGRectValue"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("CGRectValue"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("CGRectValue"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the fourth value in the vector.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat W {
			[Export ("W")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("W"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("W"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the first value in the vector.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat X {
			[Export ("X")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("X"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("X"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the second value in the vector.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Y {
			[Export ("Y")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("Y"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("Y"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the third value in the vector.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Z {
			[Export ("Z")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("Z"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("Z"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class CIVector */
}
