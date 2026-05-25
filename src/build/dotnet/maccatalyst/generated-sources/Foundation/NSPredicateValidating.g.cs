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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>Provides custom validation logic for <see cref="T:Foundation.NSPredicate" /> and <see cref="T:Foundation.NSExpression" /> objects before they are evaluated.</summary><remarks><para>Implement this protocol to control which predicates and expressions are considered safe for evaluation. Each visitor method is called during
	/// validation, allowing the implementation to inspect and approve or reject individual components of a predicate tree.</para></remarks>
	[SupportedOSPlatform ("ios26.4")]
	[SupportedOSPlatform ("tvos26.4")]
	[SupportedOSPlatform ("macos26.4")]
	[SupportedOSPlatform ("maccatalyst26.4")]
	[Protocol (Name = "NSPredicateValidating", WrapperType = typeof (NSPredicateValidatingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisitPredicate", Selector = "visitPredicate:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPredicate), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisitExpression", Selector = "visitExpression:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSExpression), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisitOperatorType", Selector = "visitOperatorType:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSPredicateOperatorType), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisitExpressionKeyPath", Selector = "visitExpressionKeyPath:scope:key:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSExpression), typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	public partial interface INSPredicateValidating : INativeObject, IDisposable
	{
		/// <summary>Validates whether the specified predicate is allowed to be evaluated.</summary><param name="predicate">The <see cref="T:Foundation.NSPredicate" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the predicate was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the predicate is valid and allowed; otherwise, <see langword="false" />.</returns>
		[global::Foundation.OptionalMember]
		[Export ("visitPredicate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitPredicate (NSPredicate predicate, out NSError? error)
		{
			return _VisitPredicate (this, predicate, out error);
		}
		/// <summary>Validates whether the specified predicate is allowed to be evaluated.</summary><param name="predicate">The <see cref="T:Foundation.NSPredicate" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the predicate was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the predicate is valid and allowed; otherwise, <see langword="false" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _VisitPredicate (INSPredicateValidating This, NSPredicate predicate, out NSError? error)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("visitPredicate:error:"), predicate__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (predicate);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>Validates whether the specified expression is allowed to be evaluated.</summary><param name="expression">The <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[global::Foundation.OptionalMember]
		[Export ("visitExpression:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitExpression (NSExpression expression, out NSError? error)
		{
			return _VisitExpression (this, expression, out error);
		}
		/// <summary>Validates whether the specified expression is allowed to be evaluated.</summary><param name="expression">The <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _VisitExpression (INSPredicateValidating This, NSExpression expression, out NSError? error)
		{
			var expression__handle__ = expression!.GetNonNullHandle (nameof (expression));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("visitExpression:error:"), expression__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (expression);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>Validates whether the specified comparison operator type is allowed to be used in a predicate.</summary><param name="operatorType">The <see cref="T:Foundation.NSPredicateOperatorType" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the operator type was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the operator type is valid and allowed; otherwise, <see langword="false" />.</returns>
		[global::Foundation.OptionalMember]
		[Export ("visitOperatorType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitOperatorType (NSPredicateOperatorType operatorType, out NSError? error)
		{
			return _VisitOperatorType (this, operatorType, out error);
		}
		/// <summary>Validates whether the specified comparison operator type is allowed to be used in a predicate.</summary><param name="operatorType">The <see cref="T:Foundation.NSPredicateOperatorType" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the operator type was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the operator type is valid and allowed; otherwise, <see langword="false" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _VisitOperatorType (INSPredicateValidating This, NSPredicateOperatorType operatorType, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_ref_NativeHandle (This.Handle, Selector.GetHandle ("visitOperatorType:error:"), (UIntPtr) (ulong) operatorType, &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <summary>Validates whether the specified key path expression is allowed to be evaluated.</summary><param name="expression">The key path <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="scope">The scope component of the key path, or <see langword="null" /> if no scope is specified.</param><param name="key">The key component of the key path, or <see langword="null" /> if no key is specified.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the key path expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the key path expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[global::Foundation.OptionalMember]
		[Export ("visitExpressionKeyPath:scope:key:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitExpressionKeyPath (NSExpression expression, string? scope, string? key, out NSError? error)
		{
			return _VisitExpressionKeyPath (this, expression, scope, key, out error);
		}
		/// <summary>Validates whether the specified key path expression is allowed to be evaluated.</summary><param name="expression">The key path <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="scope">The scope component of the key path, or <see langword="null" /> if no scope is specified.</param><param name="key">The key component of the key path, or <see langword="null" /> if no key is specified.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the key path expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the key path expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _VisitExpressionKeyPath (INSPredicateValidating This, NSExpression expression, string? scope, string? key, out NSError? error)
		{
			var expression__handle__ = expression!.GetNonNullHandle (nameof (expression));
			NativeHandle errorValue = IntPtr.Zero;
			var nsscope = CFString.CreateNative (scope);
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("visitExpressionKeyPath:scope:key:error:"), expression__handle__, nsscope, nskey, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (expression);
			CFString.ReleaseNative (nsscope);
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("VisitExpression(Foundation.NSExpression,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("VisitExpressionKeyPath(Foundation.NSExpression,System.String,System.String,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("VisitOperatorType(Foundation.NSPredicateOperatorType,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("VisitPredicate(Foundation.NSPredicate,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPredicateValidatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSPredicateValidating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSPredicateValidatingWrapper : BaseWrapper, INSPredicateValidating {
		public NSPredicateValidatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSPredicateValidatingWrapper))]
		static NSPredicateValidatingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>Provides custom validation logic for <see cref="T:Foundation.NSPredicate" /> and <see cref="T:Foundation.NSExpression" /> objects before they are evaluated.</summary><remarks><para>Implement this protocol to control which predicates and expressions are considered safe for evaluation. Each visitor method is called during
	/// validation, allowing the implementation to inspect and approve or reject individual components of a predicate tree.</para></remarks>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Foundation_NSPredicateValidating", false)]
	[Model]
	[SupportedOSPlatform ("ios26.4")]
	[SupportedOSPlatform ("tvos26.4")]
	[SupportedOSPlatform ("macos26.4")]
	[SupportedOSPlatform ("maccatalyst26.4")]
	public unsafe partial class NSPredicateValidating : NSObject, INSPredicateValidating {
		/// <summary>Creates a new <see cref="NSPredicateValidating" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPredicateValidating () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
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
		protected NSPredicateValidating (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal NSPredicateValidating (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Validates whether the specified expression is allowed to be evaluated.</summary><param name="expression">The <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[Export ("visitExpression:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitExpression (NSExpression expression, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Validates whether the specified key path expression is allowed to be evaluated.</summary><param name="expression">The key path <see cref="T:Foundation.NSExpression" /> to validate.</param><param name="scope">The scope component of the key path, or <see langword="null" /> if no scope is specified.</param><param name="key">The key component of the key path, or <see langword="null" /> if no key is specified.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the key path expression was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the key path expression is valid and allowed; otherwise, <see langword="false" />.</returns>
		[Export ("visitExpressionKeyPath:scope:key:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitExpressionKeyPath (NSExpression expression, string? scope, string? key, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Validates whether the specified comparison operator type is allowed to be used in a predicate.</summary><param name="operatorType">The <see cref="T:Foundation.NSPredicateOperatorType" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the operator type was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the operator type is valid and allowed; otherwise, <see langword="false" />.</returns>
		[Export ("visitOperatorType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitOperatorType (NSPredicateOperatorType operatorType, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Validates whether the specified predicate is allowed to be evaluated.</summary><param name="predicate">The <see cref="T:Foundation.NSPredicate" /> to validate.</param><param name="error">When this method returns <see langword="false" />, contains an <see cref="T:Foundation.NSError" /> describing why the predicate was rejected; otherwise, <see langword="null" />.</param><returns><see langword="true" /> if the predicate is valid and allowed; otherwise, <see langword="false" />.</returns>
		[Export ("visitPredicate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool VisitPredicate (NSPredicate predicate, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSPredicateValidating */
}
