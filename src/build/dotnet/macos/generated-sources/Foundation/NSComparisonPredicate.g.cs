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
	[Register("NSComparisonPredicate", true)]
	public unsafe partial class NSComparisonPredicate : NSPredicate, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComparisonPredicateModifierX = "comparisonPredicateModifier";
		static readonly NativeHandle selComparisonPredicateModifierXHandle = Selector.GetHandle ("comparisonPredicateModifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomSelectorX = "customSelector";
		static readonly NativeHandle selCustomSelectorXHandle = Selector.GetHandle ("customSelector");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeftExpression_RightExpression_CustomSelector_X = "initWithLeftExpression:rightExpression:customSelector:";
		static readonly NativeHandle selInitWithLeftExpression_RightExpression_CustomSelector_XHandle = Selector.GetHandle ("initWithLeftExpression:rightExpression:customSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeftExpression_RightExpression_Modifier_Type_Options_X = "initWithLeftExpression:rightExpression:modifier:type:options:";
		static readonly NativeHandle selInitWithLeftExpression_RightExpression_Modifier_Type_Options_XHandle = Selector.GetHandle ("initWithLeftExpression:rightExpression:modifier:type:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftExpressionX = "leftExpression";
		static readonly NativeHandle selLeftExpressionXHandle = Selector.GetHandle ("leftExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionsX = "options";
		static readonly NativeHandle selOptionsXHandle = Selector.GetHandle ("options");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateOperatorTypeX = "predicateOperatorType";
		static readonly NativeHandle selPredicateOperatorTypeXHandle = Selector.GetHandle ("predicateOperatorType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateWithLeftExpression_RightExpression_CustomSelector_X = "predicateWithLeftExpression:rightExpression:customSelector:";
		static readonly NativeHandle selPredicateWithLeftExpression_RightExpression_CustomSelector_XHandle = Selector.GetHandle ("predicateWithLeftExpression:rightExpression:customSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_X = "predicateWithLeftExpression:rightExpression:modifier:type:options:";
		static readonly NativeHandle selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_XHandle = Selector.GetHandle ("predicateWithLeftExpression:rightExpression:modifier:type:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightExpressionX = "rightExpression";
		static readonly NativeHandle selRightExpressionXHandle = Selector.GetHandle ("rightExpression");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSComparisonPredicate");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSComparisonPredicate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSComparisonPredicate () : base (NSObjectFlag.Empty)
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
		public NSComparisonPredicate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSComparisonPredicate (NSObjectFlag t) : base (t)
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
		protected internal NSComparisonPredicate (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithLeftExpression:rightExpression:modifier:type:options:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSComparisonPredicate (NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier comparisonModifier, NSPredicateOperatorType operatorType, NSComparisonPredicateOptions comparisonOptions)
			: base (NSObjectFlag.Empty)
		{
			var leftExpression__handle__ = leftExpression!.GetNonNullHandle (nameof (leftExpression));
			var rightExpression__handle__ = rightExpression!.GetNonNullHandle (nameof (rightExpression));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr (this.Handle, selInitWithLeftExpression_RightExpression_Modifier_Type_Options_XHandle, leftExpression__handle__, rightExpression__handle__, (UIntPtr) (ulong) comparisonModifier, (UIntPtr) (ulong) operatorType, (UIntPtr) (ulong) comparisonOptions), "initWithLeftExpression:rightExpression:modifier:type:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr (&__objc_super__, selInitWithLeftExpression_RightExpression_Modifier_Type_Options_XHandle, leftExpression__handle__, rightExpression__handle__, (UIntPtr) (ulong) comparisonModifier, (UIntPtr) (ulong) operatorType, (UIntPtr) (ulong) comparisonOptions), "initWithLeftExpression:rightExpression:modifier:type:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leftExpression);
			GC.KeepAlive (rightExpression);
		}
		[Export ("initWithLeftExpression:rightExpression:customSelector:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSComparisonPredicate (NSExpression leftExpression, NSExpression rightExpression, Selector selector)
			: base (NSObjectFlag.Empty)
		{
			var leftExpression__handle__ = leftExpression!.GetNonNullHandle (nameof (leftExpression));
			var rightExpression__handle__ = rightExpression!.GetNonNullHandle (nameof (rightExpression));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithLeftExpression_RightExpression_CustomSelector_XHandle, leftExpression__handle__, rightExpression__handle__, selector.Handle), "initWithLeftExpression:rightExpression:customSelector:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithLeftExpression_RightExpression_CustomSelector_XHandle, leftExpression__handle__, rightExpression__handle__, selector.Handle), "initWithLeftExpression:rightExpression:customSelector:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leftExpression);
			GC.KeepAlive (rightExpression);
			GC.KeepAlive (selector);
		}
		[Export ("predicateWithLeftExpression:rightExpression:modifier:type:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSComparisonPredicate Create (NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier comparisonModifier, NSPredicateOperatorType operatorType, NSComparisonPredicateOptions comparisonOptions)
		{
			var leftExpression__handle__ = leftExpression!.GetNonNullHandle (nameof (leftExpression));
			var rightExpression__handle__ = rightExpression!.GetNonNullHandle (nameof (rightExpression));
			NSComparisonPredicate? ret;
			ret =  Runtime.GetNSObject<NSComparisonPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_UIntPtr (class_ptr, selPredicateWithLeftExpression_RightExpression_Modifier_Type_Options_XHandle, leftExpression__handle__, rightExpression__handle__, (UIntPtr) (ulong) comparisonModifier, (UIntPtr) (ulong) operatorType, (UIntPtr) (ulong) comparisonOptions), false)!;
			GC.KeepAlive (leftExpression);
			GC.KeepAlive (rightExpression);
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
		[Export ("predicateWithLeftExpression:rightExpression:customSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSComparisonPredicate FromSelector (NSExpression leftExpression, NSExpression rightExpression, Selector selector)
		{
			var leftExpression__handle__ = leftExpression!.GetNonNullHandle (nameof (leftExpression));
			var rightExpression__handle__ = rightExpression!.GetNonNullHandle (nameof (rightExpression));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			NSComparisonPredicate? ret;
			ret =  Runtime.GetNSObject<NSComparisonPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPredicateWithLeftExpression_RightExpression_CustomSelector_XHandle, leftExpression__handle__, rightExpression__handle__, selector.Handle), false)!;
			GC.KeepAlive (leftExpression);
			GC.KeepAlive (rightExpression);
			GC.KeepAlive (selector);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonPredicateModifier ComparisonPredicateModifier {
			[Export ("comparisonPredicateModifier")]
			get {
				NSComparisonPredicateModifier ret;
				if (IsDirectBinding) {
					ret = (NSComparisonPredicateModifier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selComparisonPredicateModifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSComparisonPredicateModifier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selComparisonPredicateModifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? CustomSelector {
			[Export ("customSelector")]
			get {
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCustomSelectorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCustomSelectorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression LeftExpression {
			[Export ("leftExpression")]
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
		public virtual NSComparisonPredicateOptions Options {
			[Export ("options")]
			get {
				NSComparisonPredicateOptions ret;
				if (IsDirectBinding) {
					ret = (NSComparisonPredicateOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSComparisonPredicateOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicateOperatorType PredicateOperatorType {
			[Export ("predicateOperatorType")]
			get {
				NSPredicateOperatorType ret;
				if (IsDirectBinding) {
					ret = (NSPredicateOperatorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPredicateOperatorTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPredicateOperatorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPredicateOperatorTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression RightExpression {
			[Export ("rightExpression")]
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
	} /* class NSComparisonPredicate */
}
