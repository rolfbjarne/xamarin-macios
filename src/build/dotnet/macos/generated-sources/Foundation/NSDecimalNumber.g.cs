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
	[Register("NSDecimalNumber", true)]
	public unsafe partial class NSDecimalNumber : NSNumber, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_X = "compare:";
		static readonly NativeHandle selCompare_XHandle = Selector.GetHandle ("compare:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByAdding_X = "decimalNumberByAdding:";
		static readonly NativeHandle selDecimalNumberByAdding_XHandle = Selector.GetHandle ("decimalNumberByAdding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByAdding_WithBehavior_X = "decimalNumberByAdding:withBehavior:";
		static readonly NativeHandle selDecimalNumberByAdding_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberByAdding:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByDividingBy_X = "decimalNumberByDividingBy:";
		static readonly NativeHandle selDecimalNumberByDividingBy_XHandle = Selector.GetHandle ("decimalNumberByDividingBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByDividingBy_WithBehavior_X = "decimalNumberByDividingBy:withBehavior:";
		static readonly NativeHandle selDecimalNumberByDividingBy_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberByDividingBy:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByMultiplyingBy_X = "decimalNumberByMultiplyingBy:";
		static readonly NativeHandle selDecimalNumberByMultiplyingBy_XHandle = Selector.GetHandle ("decimalNumberByMultiplyingBy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByMultiplyingBy_WithBehavior_X = "decimalNumberByMultiplyingBy:withBehavior:";
		static readonly NativeHandle selDecimalNumberByMultiplyingBy_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberByMultiplyingBy:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByMultiplyingByPowerOf10_X = "decimalNumberByMultiplyingByPowerOf10:";
		static readonly NativeHandle selDecimalNumberByMultiplyingByPowerOf10_XHandle = Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_X = "decimalNumberByMultiplyingByPowerOf10:withBehavior:";
		static readonly NativeHandle selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberByMultiplyingByPowerOf10:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByRaisingToPower_X = "decimalNumberByRaisingToPower:";
		static readonly NativeHandle selDecimalNumberByRaisingToPower_XHandle = Selector.GetHandle ("decimalNumberByRaisingToPower:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByRaisingToPower_WithBehavior_X = "decimalNumberByRaisingToPower:withBehavior:";
		static readonly NativeHandle selDecimalNumberByRaisingToPower_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberByRaisingToPower:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberByRoundingAccordingToBehavior_X = "decimalNumberByRoundingAccordingToBehavior:";
		static readonly NativeHandle selDecimalNumberByRoundingAccordingToBehavior_XHandle = Selector.GetHandle ("decimalNumberByRoundingAccordingToBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberBySubtracting_X = "decimalNumberBySubtracting:";
		static readonly NativeHandle selDecimalNumberBySubtracting_XHandle = Selector.GetHandle ("decimalNumberBySubtracting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalNumberBySubtracting_WithBehavior_X = "decimalNumberBySubtracting:withBehavior:";
		static readonly NativeHandle selDecimalNumberBySubtracting_WithBehavior_XHandle = Selector.GetHandle ("decimalNumberBySubtracting:withBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalValueX = "decimalValue";
		static readonly NativeHandle selDecimalValueXHandle = Selector.GetHandle ("decimalValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultBehaviorX = "defaultBehavior";
		static readonly NativeHandle selDefaultBehaviorXHandle = Selector.GetHandle ("defaultBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionWithLocale_X = "descriptionWithLocale:";
		static readonly NativeHandle selDescriptionWithLocale_XHandle = Selector.GetHandle ("descriptionWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleValueX = "doubleValue";
		static readonly NativeHandle selDoubleValueXHandle = Selector.GetHandle ("doubleValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDecimal_X = "initWithDecimal:";
		static readonly NativeHandle selInitWithDecimal_XHandle = Selector.GetHandle ("initWithDecimal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMantissa_Exponent_IsNegative_X = "initWithMantissa:exponent:isNegative:";
		static readonly NativeHandle selInitWithMantissa_Exponent_IsNegative_XHandle = Selector.GetHandle ("initWithMantissa:exponent:isNegative:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_X = "initWithString:";
		static readonly NativeHandle selInitWithString_XHandle = Selector.GetHandle ("initWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithString_Locale_X = "initWithString:locale:";
		static readonly NativeHandle selInitWithString_Locale_XHandle = Selector.GetHandle ("initWithString:locale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumDecimalNumberX = "maximumDecimalNumber";
		static readonly NativeHandle selMaximumDecimalNumberXHandle = Selector.GetHandle ("maximumDecimalNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumDecimalNumberX = "minimumDecimalNumber";
		static readonly NativeHandle selMinimumDecimalNumberXHandle = Selector.GetHandle ("minimumDecimalNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotANumberX = "notANumber";
		static readonly NativeHandle selNotANumberXHandle = Selector.GetHandle ("notANumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOneX = "one";
		static readonly NativeHandle selOneXHandle = Selector.GetHandle ("one");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultBehavior_X = "setDefaultBehavior:";
		static readonly NativeHandle selSetDefaultBehavior_XHandle = Selector.GetHandle ("setDefaultBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZeroX = "zero";
		static readonly NativeHandle selZeroXHandle = Selector.GetHandle ("zero");
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
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_short_bool (this.Handle, selInitWithMantissa_Exponent_IsNegative_XHandle, mantissa, exponent, isNegative ? (byte) 1 : (byte) 0), "initWithMantissa:exponent:isNegative:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Int64_short_bool (&__objc_super__, selInitWithMantissa_Exponent_IsNegative_XHandle, mantissa, exponent, isNegative ? (byte) 1 : (byte) 0), "initWithMantissa:exponent:isNegative:");
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSDecimal (this.Handle, selInitWithDecimal_XHandle, dec), "initWithDecimal:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSDecimal (&__objc_super__, selInitWithDecimal_XHandle, dec), "initWithDecimal:");
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithString_XHandle, nsnumberValue), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithString_XHandle, nsnumberValue), "initWithString:");
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithString_Locale_XHandle, nsnumberValue, locale__handle__), "initWithString:locale:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithString_Locale_XHandle, nsnumberValue, locale__handle__), "initWithString:locale:");
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDecimalNumberByAdding_XHandle, d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDecimalNumberByAdding_XHandle, d__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDecimalNumberByAdding_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDecimalNumberByAdding_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
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
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selCompare_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompare_XHandle, other__handle__);
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
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDescriptionWithLocale_XHandle, locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDescriptionWithLocale_XHandle, locale__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDecimalNumberByDividingBy_XHandle, d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDecimalNumberByDividingBy_XHandle, d__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDecimalNumberByDividingBy_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDecimalNumberByDividingBy_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
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
		[Export ("decimalNumberByMultiplyingBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Multiply (NSDecimalNumber d)
		{
			var d__handle__ = d!.GetNonNullHandle (nameof (d));
			NSDecimalNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDecimalNumberByMultiplyingBy_XHandle, d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDecimalNumberByMultiplyingBy_XHandle, d__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDecimalNumberByMultiplyingBy_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDecimalNumberByMultiplyingBy_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short (this.Handle, selDecimalNumberByMultiplyingByPowerOf10_XHandle, power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_short (&__objc_super__, selDecimalNumberByMultiplyingByPowerOf10_XHandle, power), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short_NativeHandle (this.Handle, selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_XHandle, power, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_short_NativeHandle (&__objc_super__, selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_XHandle, power, Behavior__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selDecimalNumberByRaisingToPower_XHandle, power), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selDecimalNumberByRaisingToPower_XHandle, power), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selDecimalNumberByRaisingToPower_WithBehavior_XHandle, power, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selDecimalNumberByRaisingToPower_WithBehavior_XHandle, power, Behavior__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDecimalNumberByRoundingAccordingToBehavior_XHandle, behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDecimalNumberByRoundingAccordingToBehavior_XHandle, behavior__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDecimalNumberBySubtracting_XHandle, d__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDecimalNumberBySubtracting_XHandle, d__handle__), false)!;
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDecimalNumberBySubtracting_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDecimalNumberBySubtracting_WithBehavior_XHandle, d__handle__, Behavior__handle__), false)!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultBehaviorXHandle), false)!;
				return ret!;
			}
			[Export ("setDefaultBehavior:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetDefaultBehavior_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override double DoubleValue {
			[Export ("doubleValue")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDoubleValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDoubleValueXHandle);
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMaximumDecimalNumberXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber MinValue {
			[Export ("minimumDecimalNumber", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMinimumDecimalNumberXHandle), false)!;
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
						ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSend (this.Handle, selDecimalValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSend_stret (this.Handle, selDecimalValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSendSuper (&__objc_super__, selDecimalValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSDecimal_objc_msgSendSuper_stret (&__objc_super__, selDecimalValueXHandle);
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
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNotANumberXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber One {
			[Export ("one", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOneXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber Zero {
			[Export ("zero", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selZeroXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSDecimalNumber */
}
