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
	[Register("NSExpression", true)]
	public unsafe partial class NSExpression : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowEvaluationX = "allowEvaluation";
		static readonly NativeHandle selAllowEvaluationXHandle = Selector.GetHandle ("allowEvaluation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArgumentsX = "arguments";
		static readonly NativeHandle selArgumentsXHandle = Selector.GetHandle ("arguments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionX = "collection";
		static readonly NativeHandle selCollectionXHandle = Selector.GetHandle ("collection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstantValueX = "constantValue";
		static readonly NativeHandle selConstantValueXHandle = Selector.GetHandle ("constantValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionBlockX = "expressionBlock";
		static readonly NativeHandle selExpressionBlockXHandle = Selector.GetHandle ("expressionBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForAggregate_X = "expressionForAggregate:";
		static readonly NativeHandle selExpressionForAggregate_XHandle = Selector.GetHandle ("expressionForAggregate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForAnyKeyX = "expressionForAnyKey";
		static readonly NativeHandle selExpressionForAnyKeyXHandle = Selector.GetHandle ("expressionForAnyKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForBlock_Arguments_X = "expressionForBlock:arguments:";
		static readonly NativeHandle selExpressionForBlock_Arguments_XHandle = Selector.GetHandle ("expressionForBlock:arguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForConditional_TrueExpression_FalseExpression_X = "expressionForConditional:trueExpression:falseExpression:";
		static readonly NativeHandle selExpressionForConditional_TrueExpression_FalseExpression_XHandle = Selector.GetHandle ("expressionForConditional:trueExpression:falseExpression:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForConstantValue_X = "expressionForConstantValue:";
		static readonly NativeHandle selExpressionForConstantValue_XHandle = Selector.GetHandle ("expressionForConstantValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForEvaluatedObjectX = "expressionForEvaluatedObject";
		static readonly NativeHandle selExpressionForEvaluatedObjectXHandle = Selector.GetHandle ("expressionForEvaluatedObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForFunction_Arguments_X = "expressionForFunction:arguments:";
		static readonly NativeHandle selExpressionForFunction_Arguments_XHandle = Selector.GetHandle ("expressionForFunction:arguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForFunction_SelectorName_Arguments_X = "expressionForFunction:selectorName:arguments:";
		static readonly NativeHandle selExpressionForFunction_SelectorName_Arguments_XHandle = Selector.GetHandle ("expressionForFunction:selectorName:arguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForIntersectSet_With_X = "expressionForIntersectSet:with:";
		static readonly NativeHandle selExpressionForIntersectSet_With_XHandle = Selector.GetHandle ("expressionForIntersectSet:with:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForKeyPath_X = "expressionForKeyPath:";
		static readonly NativeHandle selExpressionForKeyPath_XHandle = Selector.GetHandle ("expressionForKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForMinusSet_With_X = "expressionForMinusSet:with:";
		static readonly NativeHandle selExpressionForMinusSet_With_XHandle = Selector.GetHandle ("expressionForMinusSet:with:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForSubquery_UsingIteratorVariable_Predicate_X = "expressionForSubquery:usingIteratorVariable:predicate:";
		static readonly NativeHandle selExpressionForSubquery_UsingIteratorVariable_Predicate_XHandle = Selector.GetHandle ("expressionForSubquery:usingIteratorVariable:predicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForUnionSet_With_X = "expressionForUnionSet:with:";
		static readonly NativeHandle selExpressionForUnionSet_With_XHandle = Selector.GetHandle ("expressionForUnionSet:with:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionForVariable_X = "expressionForVariable:";
		static readonly NativeHandle selExpressionForVariable_XHandle = Selector.GetHandle ("expressionForVariable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionTypeX = "expressionType";
		static readonly NativeHandle selExpressionTypeXHandle = Selector.GetHandle ("expressionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionValueWithObject_Context_X = "expressionValueWithObject:context:";
		static readonly NativeHandle selExpressionValueWithObject_Context_XHandle = Selector.GetHandle ("expressionValueWithObject:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionWithFormat_X = "expressionWithFormat:";
		static readonly NativeHandle selExpressionWithFormat_XHandle = Selector.GetHandle ("expressionWithFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpressionWithFormat_ArgumentArray_X = "expressionWithFormat:argumentArray:";
		static readonly NativeHandle selExpressionWithFormat_ArgumentArray_XHandle = Selector.GetHandle ("expressionWithFormat:argumentArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFalseExpressionX = "falseExpression";
		static readonly NativeHandle selFalseExpressionXHandle = Selector.GetHandle ("falseExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFunctionX = "function";
		static readonly NativeHandle selFunctionXHandle = Selector.GetHandle ("function");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithExpressionType_X = "initWithExpressionType:";
		static readonly NativeHandle selInitWithExpressionType_XHandle = Selector.GetHandle ("initWithExpressionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyPathX = "keyPath";
		static readonly NativeHandle selKeyPathXHandle = Selector.GetHandle ("keyPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftExpressionX = "leftExpression";
		static readonly NativeHandle selLeftExpressionXHandle = Selector.GetHandle ("leftExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOperandX = "operand";
		static readonly NativeHandle selOperandXHandle = Selector.GetHandle ("operand");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateX = "predicate";
		static readonly NativeHandle selPredicateXHandle = Selector.GetHandle ("predicate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightExpressionX = "rightExpression";
		static readonly NativeHandle selRightExpressionXHandle = Selector.GetHandle ("rightExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrueExpressionX = "trueExpression";
		static readonly NativeHandle selTrueExpressionXHandle = Selector.GetHandle ("trueExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVariableX = "variable";
		static readonly NativeHandle selVariableXHandle = Selector.GetHandle ("variable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSExpression");
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
		public NSExpression (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSExpression (NSObjectFlag t) : base (t)
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
		protected internal NSExpression (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithExpressionType:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSExpression (NSExpressionType type)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selInitWithExpressionType_XHandle, (UIntPtr) (ulong) type), "initWithExpressionType:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selInitWithExpressionType_XHandle, (UIntPtr) (ulong) type), "initWithExpressionType:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("allowEvaluation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AllowEvaluation ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAllowEvaluationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAllowEvaluationXHandle);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("expressionValueWithObject:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? EvaluateWith (NSObject? obj, NSMutableDictionary? context)
		{
			var obj__handle__ = obj.GetHandle ();
			var context__handle__ = context.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selExpressionValueWithObject_Context_XHandle, obj__handle__, context__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selExpressionValueWithObject_Context_XHandle, obj__handle__, context__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("expressionForAggregate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromAggregate (NSExpression[] subexpressions)
		{
			if (subexpressions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subexpressions));
			using var nsa_subexpressions = NSArray.FromNSObjects (subexpressions);
			NSExpression ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExpressionForAggregate_XHandle, nsa_subexpressions.Handle), false)!;
			return ret;
		}
		[Export ("expressionForAnyKey")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromAnyKey ()
		{
			NSExpression ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExpressionForAnyKeyXHandle), false)!;
			return ret;
		}
		[Export ("expressionForConditional:trueExpression:falseExpression:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromConditional (NSPredicate predicate, NSExpression trueExpression, NSExpression falseExpression)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			var trueExpression__handle__ = trueExpression!.GetNonNullHandle (nameof (trueExpression));
			var falseExpression__handle__ = falseExpression!.GetNonNullHandle (nameof (falseExpression));
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selExpressionForConditional_TrueExpression_FalseExpression_XHandle, predicate__handle__, trueExpression__handle__, falseExpression__handle__), false)!;
			GC.KeepAlive (predicate);
			GC.KeepAlive (trueExpression);
			GC.KeepAlive (falseExpression);
			return ret!;
		}
		[Export ("expressionForConstantValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromConstant (NSObject? obj)
		{
			var obj__handle__ = obj.GetHandle ();
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExpressionForConstantValue_XHandle, obj__handle__), false)!;
			GC.KeepAlive (obj);
			return ret!;
		}
		[Export ("expressionWithFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromFormat (string expressionFormat)
		{
			if (expressionFormat is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (expressionFormat));
			var nsexpressionFormat = CFString.CreateNative (expressionFormat);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExpressionWithFormat_XHandle, nsexpressionFormat), false)!;
			CFString.ReleaseNative (nsexpressionFormat);
			return ret!;
		}
		[Export ("expressionWithFormat:argumentArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromFormat (string format, NSObject[] parameters)
		{
			if (format is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (format));
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			var nsformat = CFString.CreateNative (format);
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionWithFormat_ArgumentArray_XHandle, nsformat, nsa_parameters.Handle), false)!;
			CFString.ReleaseNative (nsformat);
			return ret!;
		}
		[Export ("expressionForFunction:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromFunction (string name, NSExpression[] parameters)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			var nsname = CFString.CreateNative (name);
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionForFunction_Arguments_XHandle, nsname, nsa_parameters.Handle), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expressionForFunction:selectorName:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromFunction (NSExpression target, string name, NSExpression[] parameters)
		{
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			var nsname = CFString.CreateNative (name);
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selExpressionForFunction_SelectorName_Arguments_XHandle, target__handle__, nsname, nsa_parameters.Handle), false)!;
			GC.KeepAlive (target);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expressionForBlock:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSExpression FromFunction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSExpressionCallbackHandler))]NSExpressionCallbackHandler target, NSExpression[] parameters)
		{
			if (target is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (target));
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			using var block_target = Trampolines.SDNSExpressionCallbackHandler.CreateBlock (target);
			BlockLiteral *block_ptr_target = &block_target;
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			NSExpression ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionForBlock_Arguments_XHandle, (IntPtr) block_ptr_target, nsa_parameters.Handle), false)!;
			return ret;
		}
		[Export ("expressionForIntersectSet:with:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromIntersectSet (NSExpression left, NSExpression right)
		{
			var left__handle__ = left!.GetNonNullHandle (nameof (left));
			var right__handle__ = right!.GetNonNullHandle (nameof (right));
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionForIntersectSet_With_XHandle, left__handle__, right__handle__), false)!;
			GC.KeepAlive (left);
			GC.KeepAlive (right);
			return ret!;
		}
		[Export ("expressionForKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromKeyPath (string keyPath)
		{
			if (keyPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyPath));
			var nskeyPath = CFString.CreateNative (keyPath);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExpressionForKeyPath_XHandle, nskeyPath), false)!;
			CFString.ReleaseNative (nskeyPath);
			return ret!;
		}
		[Export ("expressionForMinusSet:with:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromMinusSet (NSExpression left, NSExpression right)
		{
			var left__handle__ = left!.GetNonNullHandle (nameof (left));
			var right__handle__ = right!.GetNonNullHandle (nameof (right));
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionForMinusSet_With_XHandle, left__handle__, right__handle__), false)!;
			GC.KeepAlive (left);
			GC.KeepAlive (right);
			return ret!;
		}
		[Export ("expressionForSubquery:usingIteratorVariable:predicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromSubquery (NSExpression expression, string variable, NSObject predicate)
		{
			var expression__handle__ = expression!.GetNonNullHandle (nameof (expression));
			if (variable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (variable));
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			var nsvariable = CFString.CreateNative (variable);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selExpressionForSubquery_UsingIteratorVariable_Predicate_XHandle, expression__handle__, nsvariable, predicate__handle__), false)!;
			GC.KeepAlive (expression);
			GC.KeepAlive (predicate);
			CFString.ReleaseNative (nsvariable);
			return ret!;
		}
		[Export ("expressionForUnionSet:with:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromUnionSet (NSExpression left, NSExpression right)
		{
			var left__handle__ = left!.GetNonNullHandle (nameof (left));
			var right__handle__ = right!.GetNonNullHandle (nameof (right));
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selExpressionForUnionSet_With_XHandle, left__handle__, right__handle__), false)!;
			GC.KeepAlive (left);
			GC.KeepAlive (right);
			return ret!;
		}
		[Export ("expressionForVariable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression FromVariable (string string1)
		{
			if (string1 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (string1));
			var nsstring1 = CFString.CreateNative (string1);
			NSExpression? ret;
			ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selExpressionForVariable_XHandle, nsstring1), false)!;
			CFString.ReleaseNative (nsstring1);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSExpression ExpressionForEvaluatedObject {
			[Export ("expressionForEvaluatedObject")]
			get {
				NSExpression? ret;
				ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExpressionForEvaluatedObjectXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpressionType ExpressionType {
			[Export ("expressionType")]
			get {
				NSExpressionType ret;
				if (IsDirectBinding) {
					ret = (NSExpressionType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selExpressionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSExpressionType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selExpressionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSExpression[] _Arguments {
			get {
				NSExpression[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selArgumentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selArgumentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NSExpressionCallbackHandler _Block {
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExpressionBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExpressionBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDNSExpressionCallbackHandler.Create (ret)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSObject _Collection {
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollectionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollectionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSObject _ConstantValue {
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConstantValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConstantValueXHandle), false)!;
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
		internal NSExpression _FalseExpression {
			get {
				NSExpression? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFalseExpressionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFalseExpressionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal string _Function {
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFunctionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFunctionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal string _KeyPath {
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSExpression _LeftExpression {
			get {
				NSExpression? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftExpressionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftExpressionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSExpression _Operand {
			get {
				NSExpression? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOperandXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOperandXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSPredicate _Predicate {
			get {
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPredicateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPredicateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSExpression _RightExpression {
			get {
				NSExpression? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightExpressionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightExpressionXHandle), false)!;
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
		internal NSExpression _TrueExpression {
			get {
				NSExpression? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTrueExpressionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTrueExpressionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal string _Variable {
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVariableXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVariableXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSExpression */
}
