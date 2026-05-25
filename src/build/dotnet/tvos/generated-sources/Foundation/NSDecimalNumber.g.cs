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
namespace Foundation {
	[Register("NSDecimalNumber", true)]
	public unsafe partial class NSDecimalNumber : NSNumber, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDecimalNumber");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDecimalNumber" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDecimalNumber () : base (NSObjectFlag.Empty)
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
		public NSDecimalNumber (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSDecimalNumber (NSObjectFlag t) : base (t)
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
		protected internal NSDecimalNumber (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithMantissa:exponent:isNegative:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDecimalNumber (long mantissa, short exponent, bool isNegative)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_short_bool (this.Handle, Selector.GetHandle ("initWithMantissa:exponent:isNegative:"), mantissa, exponent, isNegative ? (byte) 1 : (byte) 0), "initWithMantissa:exponent:isNegative:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Int64_short_bool (&__objc_super__, Selector.GetHandle ("initWithMantissa:exponent:isNegative:"), mantissa, exponent, isNegative ? (byte) 1 : (byte) 0), "initWithMantissa:exponent:isNegative:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithDecimal:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDecimalNumber (NSDecimal dec)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSDecimal (this.Handle, Selector.GetHandle ("initWithDecimal:"), dec), "initWithDecimal:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSDecimal (&__objc_super__, Selector.GetHandle ("initWithDecimal:"), dec), "initWithDecimal:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDecimalNumber (string numberValue)
			: base (NSObjectFlag.Empty)
		{
			if (numberValue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (numberValue));
			var nsnumberValue = CFString.CreateNative (numberValue);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithString:"), nsnumberValue), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithString:"), nsnumberValue), "initWithString:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnumberValue);
		}
		[Export ("initWithString:locale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDecimalNumber (string numberValue, NSObject locale)
			: base (NSObjectFlag.Empty)
		{
			if (numberValue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (numberValue));
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			var nsnumberValue = CFString.CreateNative (numberValue);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithString:locale:"), nsnumberValue, locale__handle__), "initWithString:locale:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithString:locale:"), nsnumberValue, locale__handle__), "initWithString:locale:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			CFString.ReleaseNative (nsnumberValue);
		}
		[Export ("decimalNumberByAdding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Add (NSDecimalNumber d)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByAdding:"), d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByAdding:"), d__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			return ret!;
		}
		[Export ("decimalNumberByAdding:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Add (NSDecimalNumber d, NSObject Behavior)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			var Behavior__handle__ = Behavior!.GetNonNullHandle (nameof (Behavior));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByAdding:withBehavior:"), d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByAdding:withBehavior:"), d__handle__, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			GC.KeepAlive (Behavior);
			return ret!;
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nint Compare (NSNumber other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("compare:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("compare:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret!;
		}
		[Export ("descriptionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override string DescriptionWithLocale (NSLocale locale)
		{
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("descriptionWithLocale:"), locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("descriptionWithLocale:"), locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("decimalNumberByDividingBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Divide (NSDecimalNumber d)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByDividingBy:"), d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByDividingBy:"), d__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			return ret!;
		}
		[Export ("decimalNumberByDividingBy:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Divide (NSDecimalNumber d, NSObject Behavior)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			var Behavior__handle__ = Behavior!.GetNonNullHandle (nameof (Behavior));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByDividingBy:withBehavior:"), d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByDividingBy:withBehavior:"), d__handle__, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			GC.KeepAlive (Behavior);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		[Export ("decimalNumberByMultiplyingBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Multiply (NSDecimalNumber d)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByMultiplyingBy:"), d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByMultiplyingBy:"), d__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			return ret!;
		}
		[Export ("decimalNumberByMultiplyingBy:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Multiply (NSDecimalNumber d, NSObject Behavior)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			var Behavior__handle__ = Behavior!.GetNonNullHandle (nameof (Behavior));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByMultiplyingBy:withBehavior:"), d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByMultiplyingBy:withBehavior:"), d__handle__, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			GC.KeepAlive (Behavior);
			return ret!;
		}
		[Export ("decimalNumberByMultiplyingByPowerOf10:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber MultiplyPowerOf10 (short power)
		{
			NSDecimalNumber ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short (this.Handle, Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:"), power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_short (&__objc_super__, Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:"), power), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("decimalNumberByMultiplyingByPowerOf10:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber MultiplyPowerOf10 (short power, NSObject? Behavior)
		{
			var Behavior__handle__ = Behavior.GetHandle ();
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:withBehavior:"), power, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_short_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:withBehavior:"), power, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (Behavior);
			return ret!;
		}
		/// <param name="power">To be added.</param><summary>Raises this number to the specified power.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("decimalNumberByRaisingToPower:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber RaiseTo (nuint power)
		{
			NSDecimalNumber ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("decimalNumberByRaisingToPower:"), power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("decimalNumberByRaisingToPower:"), power), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="power">To be added.</param><param name="Behavior">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("decimalNumberByRaisingToPower:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber RaiseTo (nuint power, NSObject? Behavior)
		{
			var Behavior__handle__ = Behavior.GetHandle ();
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByRaisingToPower:withBehavior:"), power, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByRaisingToPower:withBehavior:"), power, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (Behavior);
			return ret!;
		}
		[Export ("decimalNumberByRoundingAccordingToBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Rounding (NSObject behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberByRoundingAccordingToBehavior:"), behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberByRoundingAccordingToBehavior:"), behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
			return ret!;
		}
		[Export ("decimalNumberBySubtracting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Subtract (NSDecimalNumber d)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberBySubtracting:"), d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberBySubtracting:"), d__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			return ret!;
		}
		[Export ("decimalNumberBySubtracting:withBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Subtract (NSDecimalNumber d, NSObject Behavior)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			var Behavior__handle__ = Behavior!.GetNonNullHandle (nameof (Behavior));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decimalNumberBySubtracting:withBehavior:"), d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("decimalNumberBySubtracting:withBehavior:"), d__handle__, Behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (d);
			GC.KeepAlive (Behavior);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject DefaultBehavior {
			[Export ("defaultBehavior", ArgumentSemantic.Retain)]
			get {
				NSObject? ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("defaultBehavior")), false)!;
				return ret!;
			}
			[Export ("setDefaultBehavior:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setDefaultBehavior:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override double DoubleValue {
			[Export ("doubleValue")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("doubleValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("doubleValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber MaxValue {
			[Export ("maximumDecimalNumber", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("maximumDecimalNumber")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber MinValue {
			[Export ("minimumDecimalNumber", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("minimumDecimalNumber")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimal NSDecimalValue {
			[Export ("decimalValue")]
			get {
				NSDecimal ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSend (this.Handle, Selector.GetHandle ("decimalValue"));
					} else {
						ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSend_stret (this.Handle, Selector.GetHandle ("decimalValue"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("decimalValue"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("decimalValue"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber NaN {
			[Export ("notANumber", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("notANumber")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber One {
			[Export ("one", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("one")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber Zero {
			[Export ("zero", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("zero")), false)!;
				return ret!;
			}
		}
	} /* class NSDecimalNumber */
}
