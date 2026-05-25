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
	[Register("NSNumber", true)]
	public unsafe partial class NSNumber : NSValue, global::CloudKit.ICKRecordValue, global::CoreData.INSFetchRequestResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoolValueX = "boolValue";
		static readonly NativeHandle selBoolValueXHandle = Selector.GetHandle ("boolValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharValueX = "charValue";
		static readonly NativeHandle selCharValueXHandle = Selector.GetHandle ("charValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_X = "compare:";
		static readonly NativeHandle selCompare_XHandle = Selector.GetHandle ("compare:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalValueX = "decimalValue";
		static readonly NativeHandle selDecimalValueXHandle = Selector.GetHandle ("decimalValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionWithLocale_X = "descriptionWithLocale:";
		static readonly NativeHandle selDescriptionWithLocale_XHandle = Selector.GetHandle ("descriptionWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleValueX = "doubleValue";
		static readonly NativeHandle selDoubleValueXHandle = Selector.GetHandle ("doubleValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatValueX = "floatValue";
		static readonly NativeHandle selFloatValueXHandle = Selector.GetHandle ("floatValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBool_X = "initWithBool:";
		static readonly NativeHandle selInitWithBool_XHandle = Selector.GetHandle ("initWithBool:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithChar_X = "initWithChar:";
		static readonly NativeHandle selInitWithChar_XHandle = Selector.GetHandle ("initWithChar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDouble_X = "initWithDouble:";
		static readonly NativeHandle selInitWithDouble_XHandle = Selector.GetHandle ("initWithDouble:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFloat_X = "initWithFloat:";
		static readonly NativeHandle selInitWithFloat_XHandle = Selector.GetHandle ("initWithFloat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInt_X = "initWithInt:";
		static readonly NativeHandle selInitWithInt_XHandle = Selector.GetHandle ("initWithInt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInteger_X = "initWithInteger:";
		static readonly NativeHandle selInitWithInteger_XHandle = Selector.GetHandle ("initWithInteger:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLongLong_X = "initWithLongLong:";
		static readonly NativeHandle selInitWithLongLong_XHandle = Selector.GetHandle ("initWithLongLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithShort_X = "initWithShort:";
		static readonly NativeHandle selInitWithShort_XHandle = Selector.GetHandle ("initWithShort:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUnsignedChar_X = "initWithUnsignedChar:";
		static readonly NativeHandle selInitWithUnsignedChar_XHandle = Selector.GetHandle ("initWithUnsignedChar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUnsignedInt_X = "initWithUnsignedInt:";
		static readonly NativeHandle selInitWithUnsignedInt_XHandle = Selector.GetHandle ("initWithUnsignedInt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUnsignedInteger_X = "initWithUnsignedInteger:";
		static readonly NativeHandle selInitWithUnsignedInteger_XHandle = Selector.GetHandle ("initWithUnsignedInteger:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUnsignedLongLong_X = "initWithUnsignedLongLong:";
		static readonly NativeHandle selInitWithUnsignedLongLong_XHandle = Selector.GetHandle ("initWithUnsignedLongLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUnsignedShort_X = "initWithUnsignedShort:";
		static readonly NativeHandle selInitWithUnsignedShort_XHandle = Selector.GetHandle ("initWithUnsignedShort:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntValueX = "intValue";
		static readonly NativeHandle selIntValueXHandle = Selector.GetHandle ("intValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntegerValueX = "integerValue";
		static readonly NativeHandle selIntegerValueXHandle = Selector.GetHandle ("integerValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToNumber_X = "isEqualToNumber:";
		static readonly NativeHandle selIsEqualToNumber_XHandle = Selector.GetHandle ("isEqualToNumber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLongLongValueX = "longLongValue";
		static readonly NativeHandle selLongLongValueXHandle = Selector.GetHandle ("longLongValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLongValueX = "longValue";
		static readonly NativeHandle selLongValueXHandle = Selector.GetHandle ("longValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithBool_X = "numberWithBool:";
		static readonly NativeHandle selNumberWithBool_XHandle = Selector.GetHandle ("numberWithBool:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithChar_X = "numberWithChar:";
		static readonly NativeHandle selNumberWithChar_XHandle = Selector.GetHandle ("numberWithChar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithDouble_X = "numberWithDouble:";
		static readonly NativeHandle selNumberWithDouble_XHandle = Selector.GetHandle ("numberWithDouble:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithFloat_X = "numberWithFloat:";
		static readonly NativeHandle selNumberWithFloat_XHandle = Selector.GetHandle ("numberWithFloat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithInt_X = "numberWithInt:";
		static readonly NativeHandle selNumberWithInt_XHandle = Selector.GetHandle ("numberWithInt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithInteger_X = "numberWithInteger:";
		static readonly NativeHandle selNumberWithInteger_XHandle = Selector.GetHandle ("numberWithInteger:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithLong_X = "numberWithLong:";
		static readonly NativeHandle selNumberWithLong_XHandle = Selector.GetHandle ("numberWithLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithLongLong_X = "numberWithLongLong:";
		static readonly NativeHandle selNumberWithLongLong_XHandle = Selector.GetHandle ("numberWithLongLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithShort_X = "numberWithShort:";
		static readonly NativeHandle selNumberWithShort_XHandle = Selector.GetHandle ("numberWithShort:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedChar_X = "numberWithUnsignedChar:";
		static readonly NativeHandle selNumberWithUnsignedChar_XHandle = Selector.GetHandle ("numberWithUnsignedChar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedInt_X = "numberWithUnsignedInt:";
		static readonly NativeHandle selNumberWithUnsignedInt_XHandle = Selector.GetHandle ("numberWithUnsignedInt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedInteger_X = "numberWithUnsignedInteger:";
		static readonly NativeHandle selNumberWithUnsignedInteger_XHandle = Selector.GetHandle ("numberWithUnsignedInteger:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedLong_X = "numberWithUnsignedLong:";
		static readonly NativeHandle selNumberWithUnsignedLong_XHandle = Selector.GetHandle ("numberWithUnsignedLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedLongLong_X = "numberWithUnsignedLongLong:";
		static readonly NativeHandle selNumberWithUnsignedLongLong_XHandle = Selector.GetHandle ("numberWithUnsignedLongLong:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberWithUnsignedShort_X = "numberWithUnsignedShort:";
		static readonly NativeHandle selNumberWithUnsignedShort_XHandle = Selector.GetHandle ("numberWithUnsignedShort:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortValueX = "shortValue";
		static readonly NativeHandle selShortValueXHandle = Selector.GetHandle ("shortValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringValueX = "stringValue";
		static readonly NativeHandle selStringValueXHandle = Selector.GetHandle ("stringValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedCharValueX = "unsignedCharValue";
		static readonly NativeHandle selUnsignedCharValueXHandle = Selector.GetHandle ("unsignedCharValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedIntValueX = "unsignedIntValue";
		static readonly NativeHandle selUnsignedIntValueXHandle = Selector.GetHandle ("unsignedIntValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedIntegerValueX = "unsignedIntegerValue";
		static readonly NativeHandle selUnsignedIntegerValueXHandle = Selector.GetHandle ("unsignedIntegerValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedLongLongValueX = "unsignedLongLongValue";
		static readonly NativeHandle selUnsignedLongLongValueXHandle = Selector.GetHandle ("unsignedLongLongValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedLongValueX = "unsignedLongValue";
		static readonly NativeHandle selUnsignedLongValueXHandle = Selector.GetHandle ("unsignedLongValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsignedShortValueX = "unsignedShortValue";
		static readonly NativeHandle selUnsignedShortValueXHandle = Selector.GetHandle ("unsignedShortValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSNumber");
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
		public NSNumber (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSNumber (NSObjectFlag t) : base (t)
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
		protected internal NSNumber (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithChar:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (sbyte value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SByte (this.Handle, selInitWithChar_XHandle, value), "initWithChar:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_SByte (&__objc_super__, selInitWithChar_XHandle, value), "initWithChar:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithUnsignedChar:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (byte value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_byte (this.Handle, selInitWithUnsignedChar_XHandle, value), "initWithUnsignedChar:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_byte (&__objc_super__, selInitWithUnsignedChar_XHandle, value), "initWithUnsignedChar:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithShort:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (short value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short (this.Handle, selInitWithShort_XHandle, value), "initWithShort:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_short (&__objc_super__, selInitWithShort_XHandle, value), "initWithShort:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithUnsignedShort:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (ushort value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt16 (this.Handle, selInitWithUnsignedShort_XHandle, value), "initWithUnsignedShort:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt16 (&__objc_super__, selInitWithUnsignedShort_XHandle, value), "initWithUnsignedShort:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithInt:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (int value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selInitWithInt_XHandle, value), "initWithInt:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selInitWithInt_XHandle, value), "initWithInt:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithUnsignedInt:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (uint value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, selInitWithUnsignedInt_XHandle, value), "initWithUnsignedInt:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, selInitWithUnsignedInt_XHandle, value), "initWithUnsignedInt:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithLongLong:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (long value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (this.Handle, selInitWithLongLong_XHandle, value), "initWithLongLong:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Int64 (&__objc_super__, selInitWithLongLong_XHandle, value), "initWithLongLong:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithUnsignedLongLong:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (ulong value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64 (this.Handle, selInitWithUnsignedLongLong_XHandle, value), "initWithUnsignedLongLong:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt64 (&__objc_super__, selInitWithUnsignedLongLong_XHandle, value), "initWithUnsignedLongLong:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithFloat:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (float value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (this.Handle, selInitWithFloat_XHandle, value), "initWithFloat:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_float (&__objc_super__, selInitWithFloat_XHandle, value), "initWithFloat:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithDouble:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (double value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (this.Handle, selInitWithDouble_XHandle, value), "initWithDouble:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double (&__objc_super__, selInitWithDouble_XHandle, value), "initWithDouble:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithBool:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (bool value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selInitWithBool_XHandle, value ? (byte) 1 : (byte) 0), "initWithBool:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selInitWithBool_XHandle, value ? (byte) 1 : (byte) 0), "initWithBool:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithInteger:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (nint value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selInitWithInteger_XHandle, value), "initWithInteger:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selInitWithInteger_XHandle, value), "initWithInteger:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithUnsignedInteger:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber (nuint value)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selInitWithUnsignedInteger_XHandle, value), "initWithUnsignedInteger:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selInitWithUnsignedInteger_XHandle, value), "initWithUnsignedInteger:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Compare (NSNumber otherNumber)
		{
			var otherNumber__handle__ = otherNumber!.GetNonNullHandle (nameof (otherNumber));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selCompare_XHandle, otherNumber__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompare_XHandle, otherNumber__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherNumber);
			return ret!;
		}
		[Export ("descriptionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DescriptionWithLocale (NSLocale locale)
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
		[Export ("numberWithBool:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromBoolean (bool value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selNumberWithBool_XHandle, value ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("numberWithUnsignedChar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromByte (byte value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_byte (class_ptr, selNumberWithUnsignedChar_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithDouble:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromDouble (double value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selNumberWithDouble_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithFloat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromFloat (float value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selNumberWithFloat_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithShort:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromInt16 (short value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_short (class_ptr, selNumberWithShort_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithInt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromInt32 (int value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (class_ptr, selNumberWithInt_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithLongLong:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromInt64 (long value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64 (class_ptr, selNumberWithLongLong_XHandle, value), false)!;
			return ret;
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberWithLong:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromLong (nint value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selNumberWithLong_XHandle, value), false)!;
			return ret;
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberWithInteger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromNInt (nint value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selNumberWithInteger_XHandle, value), false)!;
			return ret;
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberWithUnsignedInteger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromNUInt (nuint value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selNumberWithUnsignedInteger_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithChar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromSByte (sbyte value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SByte (class_ptr, selNumberWithChar_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithUnsignedShort:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromUInt16 (ushort value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt16 (class_ptr, selNumberWithUnsignedShort_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithUnsignedInt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromUInt32 (uint value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selNumberWithUnsignedInt_XHandle, value), false)!;
			return ret;
		}
		[Export ("numberWithUnsignedLongLong:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromUInt64 (ulong value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64 (class_ptr, selNumberWithUnsignedLongLong_XHandle, value), false)!;
			return ret;
		}
		/// <param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberWithUnsignedLong:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber FromUnsignedLong (nuint value)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selNumberWithUnsignedLong_XHandle, value), false)!;
			return ret;
		}
		[Export ("isEqualToNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualTo (nint number)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToNumber_XHandle, number);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsEqualToNumber_XHandle, number);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BoolValue {
			[Export ("boolValue")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBoolValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBoolValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte ByteValue {
			[Export ("unsignedCharValue")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.byte_objc_msgSend (this.Handle, selUnsignedCharValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.byte_objc_msgSendSuper (&__objc_super__, selUnsignedCharValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DoubleValue {
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
		public virtual float FloatValue {
			[Export ("floatValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFloatValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFloatValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short Int16Value {
			[Export ("shortValue")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selShortValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selShortValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Int32Value {
			[Export ("intValue")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selIntValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selIntValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long Int64Value {
			[Export ("longLongValue")]
			get {
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selLongLongValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selLongLongValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LongValue {
			[Export ("longValue")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLongValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLongValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NIntValue {
			[Export ("integerValue")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIntegerValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIntegerValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
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
		public virtual nuint NUIntValue {
			[Export ("unsignedIntegerValue")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUnsignedIntegerValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUnsignedIntegerValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual sbyte SByteValue {
			[Export ("charValue")]
			get {
				sbyte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SByte_objc_msgSend (this.Handle, selCharValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SByte_objc_msgSendSuper (&__objc_super__, selCharValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringValue {
			[Export ("stringValue")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort UInt16Value {
			[Export ("unsignedShortValue")]
			get {
				ushort ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selUnsignedShortValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (&__objc_super__, selUnsignedShortValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint UInt32Value {
			[Export ("unsignedIntValue")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUnsignedIntValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selUnsignedIntValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong UInt64Value {
			[Export ("unsignedLongLongValue")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selUnsignedLongLongValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selUnsignedLongLongValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint UnsignedLongValue {
			[Export ("unsignedLongValue")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selUnsignedLongValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selUnsignedLongValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSNumber */
}
