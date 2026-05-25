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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	/// <summary>A Core Image color, including both color values and a reference to a color space.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIColor_Class/index.html">Apple documentation for <c>CIColor</c></related>
	[Register("CIColor", true)]
	public unsafe partial class CIColor : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIColor");
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
		public CIColor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CIColor (NSObjectFlag t) : base (t)
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
		protected internal CIColor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="c">To be added.</param><summary>Creates a new CIColor with the specified color.</summary><remarks>To be added.</remarks>
		[Export ("initWithCGColor:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (CGColor c)
			: base (NSObjectFlag.Empty)
		{
			var c__handle__ = c!.GetNonNullHandle (nameof (c));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCGColor:"), c.Handle), "initWithCGColor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCGColor:"), c.Handle), "initWithCGColor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (c);
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><summary>Creates a new CIColor from the specified color components.</summary><remarks>To be added.</remarks>
		[Export ("initWithRed:green:blue:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (nfloat red, nfloat green, nfloat blue)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithRed:green:blue:"), red, green, blue), "initWithRed:green:blue:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat (&__objc_super__, Selector.GetHandle ("initWithRed:green:blue:"), red, green, blue), "initWithRed:green:blue:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="colorSpace">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithRed:green:blue:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (nfloat red, nfloat green, nfloat blue, CGColorSpace colorSpace)
			: base (NSObjectFlag.Empty)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("initWithRed:green:blue:colorSpace:"), red, green, blue, colorSpace.Handle), "initWithRed:green:blue:colorSpace:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRed:green:blue:colorSpace:"), red, green, blue, colorSpace.Handle), "initWithRed:green:blue:colorSpace:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><summary>Creates a new CIColor from the specified color components.</summary><remarks>To be added.</remarks>
		[Export ("initWithRed:green:blue:alpha:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (nfloat red, nfloat green, nfloat blue, nfloat alpha)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithRed:green:blue:alpha:"), red, green, blue, alpha), "initWithRed:green:blue:alpha:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat (&__objc_super__, Selector.GetHandle ("initWithRed:green:blue:alpha:"), red, green, blue, alpha), "initWithRed:green:blue:alpha:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><param name="colorSpace">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithRed:green:blue:alpha:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (nfloat red, nfloat green, nfloat blue, nfloat alpha, CGColorSpace colorSpace)
			: base (NSObjectFlag.Empty)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("initWithRed:green:blue:alpha:colorSpace:"), red, green, blue, alpha, colorSpace.Handle), "initWithRed:green:blue:alpha:colorSpace:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRed:green:blue:alpha:colorSpace:"), red, green, blue, alpha, colorSpace.Handle), "initWithRed:green:blue:alpha:colorSpace:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
		}
		/// <param name="color">To be added.</param><summary>Creates a new CIColor with the specified color.</summary><remarks>To be added.</remarks>
		[Export ("initWithColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIColor (global::UIKit.UIColor color)
			: base (NSObjectFlag.Empty)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithColor:"), color__handle__), "initWithColor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithColor:"), color__handle__), "initWithColor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
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
		/// <param name="c">To be added.</param><summary>Creates a <see cref="T:CoreImage.CIColor" /> from a <see cref="T:CoreGraphics.CGColor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithCGColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor FromCGColor (CGColor c)
		{
			var c__handle__ = c!.GetNonNullHandle (nameof (c));
			CIColor? ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("colorWithCGColor:"), c.Handle), false)!;
			GC.KeepAlive (c);
			return ret!;
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><summary>Creates a <see cref="T:CoreImage.CIColor" /> from the supplied <paramref name="red" />, <paramref name="green" />, and <paramref name="blue" /> values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithRed:green:blue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor FromRgb (nfloat red, nfloat green, nfloat blue)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat (class_ptr, Selector.GetHandle ("colorWithRed:green:blue:"), red, green, blue), false)!;
			return ret;
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="colorSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithRed:green:blue:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor? FromRgb (nfloat red, nfloat green, nfloat blue, CGColorSpace colorSpace)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			CIColor? ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_NativeHandle (class_ptr, Selector.GetHandle ("colorWithRed:green:blue:colorSpace:"), red, green, blue, colorSpace.Handle), false)!;
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><summary>Creates a <see cref="T:CoreImage.CIColor" /> from the supplied <paramref name="red" />, <paramref name="green" />, <paramref name="blue" />, and <paramref name="alpha" /> values.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor FromRgba (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			CIColor ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, Selector.GetHandle ("colorWithRed:green:blue:alpha:"), red, green, blue, alpha), false)!;
			return ret;
		}
		/// <param name="red">To be added.</param><param name="green">To be added.</param><param name="blue">To be added.</param><param name="alpha">To be added.</param><param name="colorSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithRed:green:blue:alpha:colorSpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor? FromRgba (nfloat red, nfloat green, nfloat blue, nfloat alpha, CGColorSpace colorSpace)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			CIColor? ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat_NativeHandle (class_ptr, Selector.GetHandle ("colorWithRed:green:blue:alpha:colorSpace:"), red, green, blue, alpha, colorSpace.Handle), false)!;
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="representation">To be added.</param><summary>Creates a <see cref="T:CoreImage.CIColor" /> from a string of the format "R G B A".</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIColor FromString (string representation)
		{
			if (representation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (representation));
			var nsrepresentation = CFString.CreateNative (representation);
			CIColor? ret;
			ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("colorWithString:"), nsrepresentation), false)!;
			CFString.ReleaseNative (nsrepresentation);
			return ret!;
		}
		[Export ("components")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint GetComponents ()
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("components"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("components"));
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Returns a string representation of the color, in the format "R G B [A]".</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stringRepresentation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringRepresentation ()
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
		/// <summary>Gets the alpha channel value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Alpha {
			[Export ("alpha")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alpha"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alpha"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> with RGBA values of [0.0, 0.0, 0.0, 1.0].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor BlackColor {
			[Export ("blackColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("blackColor")), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the blue channel value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Blue {
			[Export ("blue")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("blue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("blue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose RGBA values are [0, 0, 1, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor BlueColor {
			[Export ("blueColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("blueColor")), false)!;
				return ret!;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose values are [0, 0, 0, 0].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor ClearColor {
			[Export ("clearColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("clearColor")), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the color space for the color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColorSpace ColorSpace {
			[Export ("colorSpace")]
			get {
				CGColorSpace ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colorSpace")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("colorSpace")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose RGBA values are [0, 1, 1, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor CyanColor {
			[Export ("cyanColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("cyanColor")), false)!;
				return ret!;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose RGBA values are (0.5, 0.5, 0.5, 1.0).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor GrayColor {
			[Export ("grayColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("grayColor")), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the green channel value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Green {
			[Export ("green")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("green"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("green"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose RGBA values are [0, 1, 0, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor GreenColor {
			[Export ("greenColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("greenColor")), false)!;
				return ret!;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> whose RGBA values are [1, 0, 1, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor MagentaColor {
			[Export ("magentaColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("magentaColor")), false)!;
				return ret!;
			}
		}
		/// <summary>Gets the number of components. This is also the number of components that are returned in the <see cref="CoreImage.CIColor.Components" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfComponents {
			[Export ("numberOfComponents")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfComponents"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfComponents"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the red channel value.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Red {
			[Export ("red")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("red"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("red"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> object whose RGBA values are [1, 0, 0, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor RedColor {
			[Export ("redColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("redColor")), false)!;
				return ret!;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> object whose RGBA values are [1, 1, 1, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor WhiteColor {
			[Export ("whiteColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("whiteColor")), false)!;
				return ret!;
			}
		}
		/// <summary>A <see cref="T:CoreImage.CIColor" /> objects whose RGBA values are [1, 1, 0, 1].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static CIColor YellowColor {
			[Export ("yellowColor", ArgumentSemantic.Retain)]
			get {
				CIColor? ret;
				ret =  Runtime.GetNSObject<CIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("yellowColor")), false)!;
				return ret!;
			}
		}
	} /* class CIColor */
}
