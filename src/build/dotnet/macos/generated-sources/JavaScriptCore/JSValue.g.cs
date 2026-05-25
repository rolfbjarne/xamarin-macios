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
namespace JavaScriptCore {
	/// <summary>Holds a JavaScript value and provides type-testing and conversion functions.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/JavaScriptCore/JSValue">Apple documentation for <c>JSValue</c></related>
	[Register("JSValue", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class JSValue : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJSValueRefX = "JSValueRef";
		static readonly NativeHandle selJSValueRefXHandle = Selector.GetHandle ("JSValueRef");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCallWithArguments_X = "callWithArguments:";
		static readonly NativeHandle selCallWithArguments_XHandle = Selector.GetHandle ("callWithArguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareDouble_X = "compareDouble:";
		static readonly NativeHandle selCompareDouble_XHandle = Selector.GetHandle ("compareDouble:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareInt64_X = "compareInt64:";
		static readonly NativeHandle selCompareInt64_XHandle = Selector.GetHandle ("compareInt64:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareJSValue_X = "compareJSValue:";
		static readonly NativeHandle selCompareJSValue_XHandle = Selector.GetHandle ("compareJSValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareUInt64_X = "compareUInt64:";
		static readonly NativeHandle selCompareUInt64_XHandle = Selector.GetHandle ("compareUInt64:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstructWithArguments_X = "constructWithArguments:";
		static readonly NativeHandle selConstructWithArguments_XHandle = Selector.GetHandle ("constructWithArguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefineProperty_Descriptor_X = "defineProperty:descriptor:";
		static readonly NativeHandle selDefineProperty_Descriptor_XHandle = Selector.GetHandle ("defineProperty:descriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteProperty_X = "deleteProperty:";
		static readonly NativeHandle selDeleteProperty_XHandle = Selector.GetHandle ("deleteProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasProperty_X = "hasProperty:";
		static readonly NativeHandle selHasProperty_XHandle = Selector.GetHandle ("hasProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvokeMethod_WithArguments_X = "invokeMethod:withArguments:";
		static readonly NativeHandle selInvokeMethod_WithArguments_XHandle = Selector.GetHandle ("invokeMethod:withArguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsArrayX = "isArray";
		static readonly NativeHandle selIsArrayXHandle = Selector.GetHandle ("isArray");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBigIntX = "isBigInt";
		static readonly NativeHandle selIsBigIntXHandle = Selector.GetHandle ("isBigInt");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBooleanX = "isBoolean";
		static readonly NativeHandle selIsBooleanXHandle = Selector.GetHandle ("isBoolean");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDateX = "isDate";
		static readonly NativeHandle selIsDateXHandle = Selector.GetHandle ("isDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToObject_X = "isEqualToObject:";
		static readonly NativeHandle selIsEqualToObject_XHandle = Selector.GetHandle ("isEqualToObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualWithTypeCoercionToObject_X = "isEqualWithTypeCoercionToObject:";
		static readonly NativeHandle selIsEqualWithTypeCoercionToObject_XHandle = Selector.GetHandle ("isEqualWithTypeCoercionToObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInstanceOf_X = "isInstanceOf:";
		static readonly NativeHandle selIsInstanceOf_XHandle = Selector.GetHandle ("isInstanceOf:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNullX = "isNull";
		static readonly NativeHandle selIsNullXHandle = Selector.GetHandle ("isNull");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNumberX = "isNumber";
		static readonly NativeHandle selIsNumberXHandle = Selector.GetHandle ("isNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsObjectX = "isObject";
		static readonly NativeHandle selIsObjectXHandle = Selector.GetHandle ("isObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsStringX = "isString";
		static readonly NativeHandle selIsStringXHandle = Selector.GetHandle ("isString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSymbolX = "isSymbol";
		static readonly NativeHandle selIsSymbolXHandle = Selector.GetHandle ("isSymbol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUndefinedX = "isUndefined";
		static readonly NativeHandle selIsUndefinedXHandle = Selector.GetHandle ("isUndefined");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndexedSubscript_X = "objectAtIndexedSubscript:";
		static readonly NativeHandle selObjectAtIndexedSubscript_XHandle = Selector.GetHandle ("objectAtIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_AtIndexedSubscript_X = "setObject:atIndexedSubscript:";
		static readonly NativeHandle selSetObject_AtIndexedSubscript_XHandle = Selector.GetHandle ("setObject:atIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKeyedSubscript_X = "setObject:forKeyedSubscript:";
		static readonly NativeHandle selSetObject_ForKeyedSubscript_XHandle = Selector.GetHandle ("setObject:forKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_AtIndex_X = "setValue:atIndex:";
		static readonly NativeHandle selSetValue_AtIndex_XHandle = Selector.GetHandle ("setValue:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForProperty_X = "setValue:forProperty:";
		static readonly NativeHandle selSetValue_ForProperty_XHandle = Selector.GetHandle ("setValue:forProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToArrayX = "toArray";
		static readonly NativeHandle selToArrayXHandle = Selector.GetHandle ("toArray");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToBoolX = "toBool";
		static readonly NativeHandle selToBoolXHandle = Selector.GetHandle ("toBool");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToDateX = "toDate";
		static readonly NativeHandle selToDateXHandle = Selector.GetHandle ("toDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToDictionaryX = "toDictionary";
		static readonly NativeHandle selToDictionaryXHandle = Selector.GetHandle ("toDictionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToDoubleX = "toDouble";
		static readonly NativeHandle selToDoubleXHandle = Selector.GetHandle ("toDouble");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToInt32X = "toInt32";
		static readonly NativeHandle selToInt32XHandle = Selector.GetHandle ("toInt32");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToInt64X = "toInt64";
		static readonly NativeHandle selToInt64XHandle = Selector.GetHandle ("toInt64");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToNumberX = "toNumber";
		static readonly NativeHandle selToNumberXHandle = Selector.GetHandle ("toNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToObjectX = "toObject";
		static readonly NativeHandle selToObjectXHandle = Selector.GetHandle ("toObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToObjectOfClass_X = "toObjectOfClass:";
		static readonly NativeHandle selToObjectOfClass_XHandle = Selector.GetHandle ("toObjectOfClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToPointX = "toPoint";
		static readonly NativeHandle selToPointXHandle = Selector.GetHandle ("toPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToRangeX = "toRange";
		static readonly NativeHandle selToRangeXHandle = Selector.GetHandle ("toRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToRectX = "toRect";
		static readonly NativeHandle selToRectXHandle = Selector.GetHandle ("toRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToSizeX = "toSize";
		static readonly NativeHandle selToSizeXHandle = Selector.GetHandle ("toSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToStringX = "toString";
		static readonly NativeHandle selToStringXHandle = Selector.GetHandle ("toString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToUInt32X = "toUInt32";
		static readonly NativeHandle selToUInt32XHandle = Selector.GetHandle ("toUInt32");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToUInt64X = "toUInt64";
		static readonly NativeHandle selToUInt64XHandle = Selector.GetHandle ("toUInt64");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueAtIndex_X = "valueAtIndex:";
		static readonly NativeHandle selValueAtIndex_XHandle = Selector.GetHandle ("valueAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForProperty_X = "valueForProperty:";
		static readonly NativeHandle selValueForProperty_XHandle = Selector.GetHandle ("valueForProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithBool_InContext_X = "valueWithBool:inContext:";
		static readonly NativeHandle selValueWithBool_InContext_XHandle = Selector.GetHandle ("valueWithBool:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithDouble_InContext_X = "valueWithDouble:inContext:";
		static readonly NativeHandle selValueWithDouble_InContext_XHandle = Selector.GetHandle ("valueWithDouble:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithInt32_InContext_X = "valueWithInt32:inContext:";
		static readonly NativeHandle selValueWithInt32_InContext_XHandle = Selector.GetHandle ("valueWithInt32:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithJSValueRef_InContext_X = "valueWithJSValueRef:inContext:";
		static readonly NativeHandle selValueWithJSValueRef_InContext_XHandle = Selector.GetHandle ("valueWithJSValueRef:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewArrayInContext_X = "valueWithNewArrayInContext:";
		static readonly NativeHandle selValueWithNewArrayInContext_XHandle = Selector.GetHandle ("valueWithNewArrayInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewBigIntFromDouble_InContext_X = "valueWithNewBigIntFromDouble:inContext:";
		static readonly NativeHandle selValueWithNewBigIntFromDouble_InContext_XHandle = Selector.GetHandle ("valueWithNewBigIntFromDouble:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewBigIntFromInt64_InContext_X = "valueWithNewBigIntFromInt64:inContext:";
		static readonly NativeHandle selValueWithNewBigIntFromInt64_InContext_XHandle = Selector.GetHandle ("valueWithNewBigIntFromInt64:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewBigIntFromString_InContext_X = "valueWithNewBigIntFromString:inContext:";
		static readonly NativeHandle selValueWithNewBigIntFromString_InContext_XHandle = Selector.GetHandle ("valueWithNewBigIntFromString:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewBigIntFromUInt64_InContext_X = "valueWithNewBigIntFromUInt64:inContext:";
		static readonly NativeHandle selValueWithNewBigIntFromUInt64_InContext_XHandle = Selector.GetHandle ("valueWithNewBigIntFromUInt64:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewErrorFromMessage_InContext_X = "valueWithNewErrorFromMessage:inContext:";
		static readonly NativeHandle selValueWithNewErrorFromMessage_InContext_XHandle = Selector.GetHandle ("valueWithNewErrorFromMessage:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewObjectInContext_X = "valueWithNewObjectInContext:";
		static readonly NativeHandle selValueWithNewObjectInContext_XHandle = Selector.GetHandle ("valueWithNewObjectInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewPromiseInContext_FromExecutor_X = "valueWithNewPromiseInContext:fromExecutor:";
		static readonly NativeHandle selValueWithNewPromiseInContext_FromExecutor_XHandle = Selector.GetHandle ("valueWithNewPromiseInContext:fromExecutor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewPromiseRejectedWithReason_InContext_X = "valueWithNewPromiseRejectedWithReason:inContext:";
		static readonly NativeHandle selValueWithNewPromiseRejectedWithReason_InContext_XHandle = Selector.GetHandle ("valueWithNewPromiseRejectedWithReason:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewPromiseResolvedWithResult_InContext_X = "valueWithNewPromiseResolvedWithResult:inContext:";
		static readonly NativeHandle selValueWithNewPromiseResolvedWithResult_InContext_XHandle = Selector.GetHandle ("valueWithNewPromiseResolvedWithResult:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewRegularExpressionFromPattern_Flags_InContext_X = "valueWithNewRegularExpressionFromPattern:flags:inContext:";
		static readonly NativeHandle selValueWithNewRegularExpressionFromPattern_Flags_InContext_XHandle = Selector.GetHandle ("valueWithNewRegularExpressionFromPattern:flags:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNewSymbolFromDescription_InContext_X = "valueWithNewSymbolFromDescription:inContext:";
		static readonly NativeHandle selValueWithNewSymbolFromDescription_InContext_XHandle = Selector.GetHandle ("valueWithNewSymbolFromDescription:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithNullInContext_X = "valueWithNullInContext:";
		static readonly NativeHandle selValueWithNullInContext_XHandle = Selector.GetHandle ("valueWithNullInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithObject_InContext_X = "valueWithObject:inContext:";
		static readonly NativeHandle selValueWithObject_InContext_XHandle = Selector.GetHandle ("valueWithObject:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithPoint_InContext_X = "valueWithPoint:inContext:";
		static readonly NativeHandle selValueWithPoint_InContext_XHandle = Selector.GetHandle ("valueWithPoint:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithRange_InContext_X = "valueWithRange:inContext:";
		static readonly NativeHandle selValueWithRange_InContext_XHandle = Selector.GetHandle ("valueWithRange:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithRect_InContext_X = "valueWithRect:inContext:";
		static readonly NativeHandle selValueWithRect_InContext_XHandle = Selector.GetHandle ("valueWithRect:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithSize_InContext_X = "valueWithSize:inContext:";
		static readonly NativeHandle selValueWithSize_InContext_XHandle = Selector.GetHandle ("valueWithSize:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithUInt32_InContext_X = "valueWithUInt32:inContext:";
		static readonly NativeHandle selValueWithUInt32_InContext_XHandle = Selector.GetHandle ("valueWithUInt32:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueWithUndefinedInContext_X = "valueWithUndefinedInContext:";
		static readonly NativeHandle selValueWithUndefinedInContext_XHandle = Selector.GetHandle ("valueWithUndefinedInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("JSValue");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected JSValue (NSObjectFlag t) : base (t)
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
		protected internal JSValue (NativeHandle handle) : base (handle)
		{
		}

		[Export ("callWithArguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue Call (params JSValue[] arguments)
		{
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCallWithArguments_XHandle, nsa_arguments.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCallWithArguments_XHandle, nsa_arguments.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("compareJSValue:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSRelationCondition Compare (JSValue other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			JSRelationCondition ret;
			if (IsDirectBinding) {
				ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSend_NativeHandle (this.Handle, selCompareJSValue_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompareJSValue_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret!;
		}
		[Export ("compareInt64:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSRelationCondition Compare (long other)
		{
			JSRelationCondition ret;
			if (IsDirectBinding) {
				ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSend_Int64 (this.Handle, selCompareInt64_XHandle, other);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_Int64 (&__objc_super__, selCompareInt64_XHandle, other);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("compareUInt64:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSRelationCondition Compare (ulong other)
		{
			JSRelationCondition ret;
			if (IsDirectBinding) {
				ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSend_UInt64 (this.Handle, selCompareUInt64_XHandle, other);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UInt64 (&__objc_super__, selCompareUInt64_XHandle, other);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("compareDouble:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSRelationCondition Compare (double other)
		{
			JSRelationCondition ret;
			if (IsDirectBinding) {
				ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSend_Double (this.Handle, selCompareDouble_XHandle, other);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (JSRelationCondition) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_Double (&__objc_super__, selCompareDouble_XHandle, other);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("constructWithArguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue Construct (params JSValue[] arguments)
		{
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selConstructWithArguments_XHandle, nsa_arguments.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selConstructWithArguments_XHandle, nsa_arguments.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("valueWithNewArrayInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateArray (JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueWithNewArrayInContext_XHandle, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewErrorFromMessage:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateError (string message, JSContext context)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var nsmessage = CFString.CreateNative (message);
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewErrorFromMessage_InContext_XHandle, nsmessage, context__handle__), false)!;
			GC.KeepAlive (context);
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		[Export ("valueWithNewBigIntFromString:inContext:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue? CreateNewBigInt (string @string, JSContext context)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var nsstring = CFString.CreateNative (@string);
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewBigIntFromString_InContext_XHandle, nsstring, context__handle__), false)!;
			GC.KeepAlive (context);
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[Export ("valueWithNewBigIntFromInt64:inContext:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue? CreateNewBigInt (long int64, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Int64_NativeHandle (class_ptr, selValueWithNewBigIntFromInt64_InContext_XHandle, int64, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewBigIntFromUInt64:inContext:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue? CreateNewBigInt (ulong uint64, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_NativeHandle (class_ptr, selValueWithNewBigIntFromUInt64_InContext_XHandle, uint64, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewBigIntFromDouble:inContext:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue? CreateNewBigInt (double uint64, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle (class_ptr, selValueWithNewBigIntFromDouble_InContext_XHandle, uint64, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewObjectInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateObject (JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueWithNewObjectInContext_XHandle, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewPromiseInContext:fromExecutor:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static JSValue CreatePromise (JSContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDJSPromiseCreationExecutor))]JSPromiseCreationExecutor callback)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDJSPromiseCreationExecutor.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewPromiseInContext_FromExecutor_XHandle, context__handle__, (IntPtr) block_ptr_callback), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewRegularExpressionFromPattern:flags:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateRegularExpression (string pattern, string flags, JSContext context)
		{
			if (pattern is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pattern));
			if (flags is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (flags));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var nspattern = CFString.CreateNative (pattern);
			var nsflags = CFString.CreateNative (flags);
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selValueWithNewRegularExpressionFromPattern_Flags_InContext_XHandle, nspattern, nsflags, context__handle__), false)!;
			GC.KeepAlive (context);
			CFString.ReleaseNative (nspattern);
			CFString.ReleaseNative (nsflags);
			return ret!;
		}
		[Export ("valueWithNewPromiseRejectedWithReason:inContext:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateRejectedPromise (NSObject reason, JSContext context)
		{
			var reason__handle__ = reason!.GetNonNullHandle (nameof (reason));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewPromiseRejectedWithReason_InContext_XHandle, reason__handle__, context__handle__), false)!;
			GC.KeepAlive (reason);
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewPromiseResolvedWithResult:inContext:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateResolvedPromise (NSObject result, JSContext context)
		{
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewPromiseResolvedWithResult_InContext_XHandle, result__handle__, context__handle__), false)!;
			GC.KeepAlive (result);
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithNewSymbolFromDescription:inContext:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue CreateSymbol (string description, JSContext context)
		{
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var nsdescription = CFString.CreateNative (description);
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithNewSymbolFromDescription_InContext_XHandle, nsdescription, context__handle__), false)!;
			GC.KeepAlive (context);
			CFString.ReleaseNative (nsdescription);
			return ret!;
		}
		[Export ("defineProperty:descriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DefineProperty (string property, NSObject descriptor)
		{
			if (property is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (property));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsproperty = CFString.CreateNative (property);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDefineProperty_Descriptor_XHandle, nsproperty, descriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDefineProperty_Descriptor_XHandle, nsproperty, descriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsproperty);
		}
		[Export ("deleteProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeleteProperty (string property)
		{
			if (property is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (property));
			var nsproperty = CFString.CreateNative (property);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selDeleteProperty_XHandle, nsproperty);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteProperty_XHandle, nsproperty);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsproperty);
			return ret != 0;
		}
		[Export ("valueWithObject:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (NSObject value, JSContext context)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selValueWithObject_InContext_XHandle, value__handle__, context__handle__), false)!;
			GC.KeepAlive (value);
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithBool:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (bool value, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_NativeHandle (class_ptr, selValueWithBool_InContext_XHandle, value ? (byte) 1 : (byte) 0, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithDouble:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (double value, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle (class_ptr, selValueWithDouble_InContext_XHandle, value, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithInt32:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (int ivalue, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_NativeHandle (class_ptr, selValueWithInt32_InContext_XHandle, ivalue, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithUInt32:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (uint value, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_NativeHandle (class_ptr, selValueWithUInt32_InContext_XHandle, value, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithPoint:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (CGPoint point, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (class_ptr, selValueWithPoint_InContext_XHandle, point, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithRange:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (NSRange range, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selValueWithRange_InContext_XHandle, range, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithRect:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (CGRect rect, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (class_ptr, selValueWithRect_InContext_XHandle, rect, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithSize:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue From (CGSize size, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_NativeHandle (class_ptr, selValueWithSize_InContext_XHandle, size, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueWithJSValueRef:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue FromJSJSValueRef (nint nativeJsValueRefvalue, JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selValueWithJSValueRef_InContext_XHandle, nativeJsValueRefvalue, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("valueForProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue GetProperty (string property)
		{
			if (property is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (property));
			var nsproperty = CFString.CreateNative (property);
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForProperty_XHandle, nsproperty), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForProperty_XHandle, nsproperty), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsproperty);
			return ret!;
		}
		/// <param name="index">To be added.</param><summary>Returns the value at the specified <paramref name="index" />, or <c>undefined</c> if none exists.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue GetValueAt (nuint index)
		{
			JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selValueAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selValueAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hasProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasProperty (string property)
		{
			if (property is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (property));
			var nsproperty = CFString.CreateNative (property);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasProperty_XHandle, nsproperty);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasProperty_XHandle, nsproperty);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsproperty);
			return ret != 0;
		}
		[Export ("invokeMethod:withArguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSValue Invoke (string method, params JSValue[] arguments)
		{
			if (method is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (method));
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			var nsmethod = CFString.CreateNative (method);
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInvokeMethod_WithArguments_XHandle, nsmethod, nsa_arguments.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInvokeMethod_WithArguments_XHandle, nsmethod, nsa_arguments.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmethod);
			return ret!;
		}
		[Export ("isEqualToObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualTo (NSObject value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualToObject_XHandle, value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualToObject_XHandle, value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret != 0;
		}
		[Export ("isEqualWithTypeCoercionToObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualWithTypeCoercionTo (NSObject value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualWithTypeCoercionToObject_XHandle, value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualWithTypeCoercionToObject_XHandle, value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret != 0;
		}
		[Export ("isInstanceOf:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInstanceOf (NSObject value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsInstanceOf_XHandle, value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsInstanceOf_XHandle, value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret != 0;
		}
		[Export ("valueWithNullInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue Null (JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueWithNullInContext_XHandle, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("setValue:forProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProperty (NSObject value, string property)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (property is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (property));
			var nsproperty = CFString.CreateNative (property);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForProperty_XHandle, value__handle__, nsproperty);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForProperty_XHandle, value__handle__, nsproperty);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nsproperty);
		}
		/// <param name="value">To be added.</param><param name="index">To be added.</param><summary>Sets the item at the specified index to the specified value.</summary><remarks>To be added.</remarks>
		[Export ("setValue:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (JSValue value, nuint index)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selSetValue_AtIndex_XHandle, value__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selSetValue_AtIndex_XHandle, value__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
		}
		[Export ("toArray")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray ToArray ()
		{
			NSArray ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToArrayXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToArrayXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toBool")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ToBool ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selToBoolXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selToBoolXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("toDate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate ToDate ()
		{
			NSDate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToDateXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToDateXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toDictionary")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ToDictionary ()
		{
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToDictionaryXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToDictionaryXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toDouble")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ToDouble ()
		{
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selToDoubleXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selToDoubleXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toInt32")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ToInt32 ()
		{
			int ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selToInt32XHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selToInt32XHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toInt64")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long ToInt64 ()
		{
			long ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selToInt64XHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selToInt64XHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toNumber")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber ToNumber ()
		{
			NSNumber ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToNumberXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToNumberXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toObject")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ToObject ()
		{
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToObjectXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToObjectXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toObjectOfClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ToObject (Class ofExpectedClass)
		{
			var ofExpectedClass__handle__ = ofExpectedClass!.GetNonNullHandle (nameof (ofExpectedClass));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToObjectOfClass_XHandle, ofExpectedClass.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToObjectOfClass_XHandle, ofExpectedClass.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ofExpectedClass);
			return ret!;
		}
		[Export ("toPoint")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ToPoint ()
		{
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selToPointXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selToPointXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange ToRange ()
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selToRangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selToRangeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toRect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ToRect ()
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selToRectXHandle);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selToRectXHandle);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selToRectXHandle);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selToRectXHandle);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("toSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ToSize ()
		{
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selToSizeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selToSizeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toUInt32")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint ToUInt32 ()
		{
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selToUInt32XHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selToUInt32XHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toUInt64")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong ToUInt64 ()
		{
			ulong ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selToUInt64XHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selToUInt64XHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("valueWithUndefinedInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static JSValue Undefined (JSContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			JSValue? ret;
			ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueWithUndefinedInContext_XHandle, context__handle__), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual JSValue _ObjectAtIndexedSubscript (nuint index)
		{
			JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selObjectAtIndexedSubscript_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selObjectAtIndexedSubscript_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual JSValue _ObjectForKeyedSubscript (NSObject key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			JSValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<JSValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetObject (JSValue obj, NSObject key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetObject_ForKeyedSubscript_XHandle, obj__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetObject_ForKeyedSubscript_XHandle, obj__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (key);
		}
		[Export ("setObject:atIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetObject (JSValue obj, nuint index)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selSetObject_AtIndexedSubscript_XHandle, obj__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selSetObject_AtIndexedSubscript_XHandle, obj__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("toString")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual string _ToString ()
		{
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToStringXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToStringXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual JSContext Context {
			[Export ("context", ArgumentSemantic.Retain)]
			get {
				JSContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<JSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContextXHandle), false)!;
						GC.KeepAlive (this);
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
		public virtual bool IsArray {
			[Export ("isArray")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsArrayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsArrayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		public virtual bool IsBigInt {
			[Export ("isBigInt")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBigIntXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBigIntXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBoolean {
			[Export ("isBoolean")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBooleanXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBooleanXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool IsDate {
			[Export ("isDate")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNull {
			[Export ("isNull")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNullXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsNullXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNumber {
			[Export ("isNumber")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsObject {
			[Export ("isObject")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsObjectXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsObjectXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsString {
			[Export ("isString")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStringXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsStringXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IsSymbol {
			[Export ("isSymbol")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSymbolXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSymbolXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUndefined {
			[Export ("isUndefined")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUndefinedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUndefinedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint JSValueRefPtr {
			[Export ("JSValueRef")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selJSValueRefXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selJSValueRefXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class JSValue */
}
