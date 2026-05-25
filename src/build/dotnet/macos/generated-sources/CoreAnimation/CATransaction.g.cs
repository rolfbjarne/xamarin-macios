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
namespace CoreAnimation {
	/// <summary>Framework to synchronize multiple transformation operations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATransaction_class/index.html">Apple documentation for <c>CATransaction</c></related>
	[Register("CATransaction", true)]
	public unsafe partial class CATransaction : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationDurationX = "animationDuration";
		static readonly NativeHandle selAnimationDurationXHandle = Selector.GetHandle ("animationDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationTimingFunctionX = "animationTimingFunction";
		static readonly NativeHandle selAnimationTimingFunctionXHandle = Selector.GetHandle ("animationTimingFunction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginX = "begin";
		static readonly NativeHandle selBeginXHandle = Selector.GetHandle ("begin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitX = "commit";
		static readonly NativeHandle selCommitXHandle = Selector.GetHandle ("commit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletionBlockX = "completionBlock";
		static readonly NativeHandle selCompletionBlockXHandle = Selector.GetHandle ("completionBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisableActionsX = "disableActions";
		static readonly NativeHandle selDisableActionsXHandle = Selector.GetHandle ("disableActions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlushX = "flush";
		static readonly NativeHandle selFlushXHandle = Selector.GetHandle ("flush");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLockX = "lock";
		static readonly NativeHandle selLockXHandle = Selector.GetHandle ("lock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimationDuration_X = "setAnimationDuration:";
		static readonly NativeHandle selSetAnimationDuration_XHandle = Selector.GetHandle ("setAnimationDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimationTimingFunction_X = "setAnimationTimingFunction:";
		static readonly NativeHandle selSetAnimationTimingFunction_XHandle = Selector.GetHandle ("setAnimationTimingFunction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompletionBlock_X = "setCompletionBlock:";
		static readonly NativeHandle selSetCompletionBlock_XHandle = Selector.GetHandle ("setCompletionBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisableActions_X = "setDisableActions:";
		static readonly NativeHandle selSetDisableActions_XHandle = Selector.GetHandle ("setDisableActions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForKey_X = "setValue:forKey:";
		static readonly NativeHandle selSetValue_ForKey_XHandle = Selector.GetHandle ("setValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockX = "unlock";
		static readonly NativeHandle selUnlockXHandle = Selector.GetHandle ("unlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKey_X = "valueForKey:";
		static readonly NativeHandle selValueForKey_XHandle = Selector.GetHandle ("valueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CATransaction");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CATransaction" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CATransaction () : base (NSObjectFlag.Empty)
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
		protected CATransaction (NSObjectFlag t) : base (t)
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
		protected internal CATransaction (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("begin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Begin ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selBeginXHandle);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("commit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Commit ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selCommitXHandle);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("flush")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Flush ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selFlushXHandle);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("lock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Lock ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selLockXHandle);
		}
		/// <param name="anObject"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetValueForKey (NSObject? anObject, NSString key)
		{
			var anObject__handle__ = anObject.GetHandle ();
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSetValue_ForKey_XHandle, anObject__handle__, key__handle__);
			GC.KeepAlive (anObject);
			GC.KeepAlive (key);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unlock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Unlock ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selUnlockXHandle);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? ValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selValueForKey_XHandle, key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double AnimationDuration {
			[Export ("animationDuration")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (class_ptr, selAnimationDurationXHandle);
				return ret;
			}
			[Export ("setAnimationDuration:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (class_ptr, selSetAnimationDuration_XHandle, value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CAMediaTimingFunction? AnimationTimingFunction {
			[Export ("animationTimingFunction")]
			get {
				CAMediaTimingFunction? ret;
				ret =  Runtime.GetNSObject<CAMediaTimingFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAnimationTimingFunctionXHandle), false)!;
				return ret!;
			}
			[Export ("setAnimationTimingFunction:")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetAnimationTimingFunction_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static global::System.Action? CompletionBlock {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAction))]
			[Export ("completionBlock")]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCompletionBlockXHandle);
				return global::ObjCRuntime.Trampolines.NIDAction.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]
			[Export ("setCompletionBlock:")]
			set {
				using var block_value = Trampolines.SDAction.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetCompletionBlock_XHandle, (IntPtr) block_ptr_value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DisableActions {
			[Export ("disableActions")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selDisableActionsXHandle);
				return ret != 0;
			}
			[Export ("setDisableActions:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetDisableActions_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationDurationKey;
		/// <summary>Represents the value associated with the constant kCATransactionAnimationDuration</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransactionAnimationDuration",  "CoreAnimation")]
		public static NSString AnimationDurationKey {
			get {
				if (_AnimationDurationKey is null)
					_AnimationDurationKey = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransactionAnimationDuration")!;
				return _AnimationDurationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompletionBlockKey;
		/// <summary>Represents the value associated with the constant kCATransactionCompletionBlock</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransactionCompletionBlock",  "CoreAnimation")]
		public static NSString CompletionBlockKey {
			get {
				if (_CompletionBlockKey is null)
					_CompletionBlockKey = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransactionCompletionBlock")!;
				return _CompletionBlockKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisableActionsKey;
		/// <summary>Represents the value associated with the constant kCATransactionDisableActions</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransactionDisableActions",  "CoreAnimation")]
		public static NSString DisableActionsKey {
			get {
				if (_DisableActionsKey is null)
					_DisableActionsKey = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransactionDisableActions")!;
				return _DisableActionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimingFunctionKey;
		/// <summary>Represents the value associated with the constant kCATransactionAnimationTimingFunction</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransactionAnimationTimingFunction",  "CoreAnimation")]
		public static NSString TimingFunctionKey {
			get {
				if (_TimingFunctionKey is null)
					_TimingFunctionKey = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransactionAnimationTimingFunction")!;
				return _TimingFunctionKey;
			}
		}
	} /* class CATransaction */
}
