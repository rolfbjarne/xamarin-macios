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
namespace ModelIO {
	[Register("MDLTransformStack", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLTransformStack : NSObject, IMDLComponent, IMDLTransformComponent, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddMatrixOp_Inverse_X = "addMatrixOp:inverse:";
		static readonly NativeHandle selAddMatrixOp_Inverse_XHandle = Selector.GetHandle ("addMatrixOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOrientOp_Inverse_X = "addOrientOp:inverse:";
		static readonly NativeHandle selAddOrientOp_Inverse_XHandle = Selector.GetHandle ("addOrientOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRotateOp_Order_Inverse_X = "addRotateOp:order:inverse:";
		static readonly NativeHandle selAddRotateOp_Order_Inverse_XHandle = Selector.GetHandle ("addRotateOp:order:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRotateXOp_Inverse_X = "addRotateXOp:inverse:";
		static readonly NativeHandle selAddRotateXOp_Inverse_XHandle = Selector.GetHandle ("addRotateXOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRotateYOp_Inverse_X = "addRotateYOp:inverse:";
		static readonly NativeHandle selAddRotateYOp_Inverse_XHandle = Selector.GetHandle ("addRotateYOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddRotateZOp_Inverse_X = "addRotateZOp:inverse:";
		static readonly NativeHandle selAddRotateZOp_Inverse_XHandle = Selector.GetHandle ("addRotateZOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddScaleOp_Inverse_X = "addScaleOp:inverse:";
		static readonly NativeHandle selAddScaleOp_Inverse_XHandle = Selector.GetHandle ("addScaleOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTranslateOp_Inverse_X = "addTranslateOp:inverse:";
		static readonly NativeHandle selAddTranslateOp_Inverse_XHandle = Selector.GetHandle ("addTranslateOp:inverse:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimatedValueWithName_X = "animatedValueWithName:";
		static readonly NativeHandle selAnimatedValueWithName_XHandle = Selector.GetHandle ("animatedValueWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDouble4x4AtTime_X = "double4x4AtTime:";
		static readonly NativeHandle selDouble4x4AtTime_XHandle = Selector.GetHandle ("double4x4AtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloat4x4AtTime_X = "float4x4AtTime:";
		static readonly NativeHandle selFloat4x4AtTime_XHandle = Selector.GetHandle ("float4x4AtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlobalTransformWithObject_AtTime_X = "globalTransformWithObject:atTime:";
		static readonly NativeHandle selGlobalTransformWithObject_AtTime_XHandle = Selector.GetHandle ("globalTransformWithObject:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyTimesX = "keyTimes";
		static readonly NativeHandle selKeyTimesXHandle = Selector.GetHandle ("keyTimes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalTransformAtTime_X = "localTransformAtTime:";
		static readonly NativeHandle selLocalTransformAtTime_XHandle = Selector.GetHandle ("localTransformAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixX = "matrix";
		static readonly NativeHandle selMatrixXHandle = Selector.GetHandle ("matrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumTimeX = "maximumTime";
		static readonly NativeHandle selMaximumTimeXHandle = Selector.GetHandle ("maximumTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumTimeX = "minimumTime";
		static readonly NativeHandle selMinimumTimeXHandle = Selector.GetHandle ("minimumTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetsTransformX = "resetsTransform";
		static readonly NativeHandle selResetsTransformXHandle = Selector.GetHandle ("resetsTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalTransform_X = "setLocalTransform:";
		static readonly NativeHandle selSetLocalTransform_XHandle = Selector.GetHandle ("setLocalTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalTransform_ForTime_X = "setLocalTransform:forTime:";
		static readonly NativeHandle selSetLocalTransform_ForTime_XHandle = Selector.GetHandle ("setLocalTransform:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatrix_X = "setMatrix:";
		static readonly NativeHandle selSetMatrix_XHandle = Selector.GetHandle ("setMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResetsTransform_X = "setResetsTransform:";
		static readonly NativeHandle selSetResetsTransform_XHandle = Selector.GetHandle ("setResetsTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformOpsX = "transformOps";
		static readonly NativeHandle selTransformOpsXHandle = Selector.GetHandle ("transformOps");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLTransformStack");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLTransformStack" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLTransformStack () : base (NSObjectFlag.Empty)
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
		protected MDLTransformStack (NSObjectFlag t) : base (t)
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
		protected internal MDLTransformStack (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addMatrixOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformMatrixOp AddMatrixOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformMatrixOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformMatrixOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddMatrixOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformMatrixOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddMatrixOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		[Export ("addOrientOp:inverse:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformOrientOp AddOrientOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformOrientOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformOrientOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddOrientOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformOrientOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddOrientOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="order">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addRotateOp:order:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformRotateOp AddRotateOp (string animatedValueName, MDLTransformOpRotationOrder order, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformRotateOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformRotateOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, selAddRotateOp_Order_Inverse_XHandle, nsanimatedValueName, (UIntPtr) (ulong) order, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformRotateOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_bool (&__objc_super__, selAddRotateOp_Order_Inverse_XHandle, nsanimatedValueName, (UIntPtr) (ulong) order, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addRotateXOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformRotateXOp AddRotateXOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformRotateXOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformRotateXOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddRotateXOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformRotateXOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddRotateXOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addRotateYOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformRotateYOp AddRotateYOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformRotateYOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformRotateYOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddRotateYOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformRotateYOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddRotateYOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addRotateZOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformRotateZOp AddRotateZOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformRotateZOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformRotateZOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddRotateZOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformRotateZOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddRotateZOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addScaleOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformScaleOp AddScaleOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformScaleOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformScaleOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddScaleOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformScaleOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddScaleOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="animatedValueName">To be added.</param><param name="inverse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("addTranslateOp:inverse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLTransformTranslateOp AddTranslateOp (string animatedValueName, bool inverse)
		{
			if (animatedValueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (animatedValueName));
			var nsanimatedValueName = CFString.CreateNative (animatedValueName);
			MDLTransformTranslateOp? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLTransformTranslateOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selAddTranslateOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLTransformTranslateOp> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selAddTranslateOp_Inverse_XHandle, nsanimatedValueName, inverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsanimatedValueName);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		/// <summary>Creates and returns a global transform for the specified object at the specified time.</summary><param name="obj">The object that represents the spatial transform.</param><param name="atTime">The time at which to apply the transform.</param>
		[Export ("globalTransformWithObject:atTime:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NMatrix4 CreateGlobalTransform (MDLObject obj, double atTime)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_NativeHandle_Double (class_ptr, selGlobalTransformWithObject_AtTime_XHandle, obj__handle__, atTime);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_NativeHandle_Double (class_ptr, selGlobalTransformWithObject_AtTime_XHandle, obj__handle__, atTime);
			}
			GC.KeepAlive (obj);
			return ret!;
		}
		/// <param name="name">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animatedValueWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAnimatedValue GetAnimatedValue (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			MDLAnimatedValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLAnimatedValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAnimatedValueWithName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLAnimatedValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimatedValueWithName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="atTime">The time for which to retrieve the local transform.</param><summary>Gets the local transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localTransformAtTime:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetLocalTransform (double atTime)
		{
			NMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (this.Handle, selLocalTransformAtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (this.Handle, selLocalTransformAtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_Double (&__objc_super__, selLocalTransformAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double (&__objc_super__, selLocalTransformAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("float4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetNMatrix4 (double atTime)
		{
			NMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (this.Handle, selFloat4x4AtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (this.Handle, selFloat4x4AtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_Double (&__objc_super__, selFloat4x4AtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double (&__objc_super__, selFloat4x4AtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("double4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4d GetNMatrix4d (double atTime)
		{
			NMatrix4d ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_Double (this.Handle, selDouble4x4AtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double (this.Handle, selDouble4x4AtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_Double (&__objc_super__, selDouble4x4AtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret_Double (&__objc_super__, selDouble4x4AtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[Export ("setLocalTransform:forTime:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocalTransform (NMatrix4 transform, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double (this.Handle, selSetLocalTransform_ForTime_XHandle, transform, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4_Double (&__objc_super__, selSetLocalTransform_ForTime_XHandle, transform, time);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[Export ("setLocalTransform:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocalTransform (NMatrix4 transform)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, selSetLocalTransform_XHandle, transform);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4 (&__objc_super__, selSetLocalTransform_XHandle, transform);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Count {
			[Export ("count")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSNumber[] KeyTimes {
			[Export ("keyTimes", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyTimesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyTimesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the matrix of the transform at the earliest specified time.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NMatrix4 Matrix {
			[Export ("matrix", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, selMatrixXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, selMatrixXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper (&__objc_super__, selMatrixXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret (&__objc_super__, selMatrixXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setMatrix:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, selSetMatrix_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4 (&__objc_super__, selSetMatrix_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the last specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual double MaximumTime {
			[Export ("maximumTime")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selMaximumTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selMaximumTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the first specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual double MinimumTime {
			[Export ("minimumTime")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selMinimumTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selMinimumTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Inserts the specified transform at the specified time.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ResetsTransform {
			[Export ("resetsTransform")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResetsTransformXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selResetsTransformXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResetsTransform:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResetsTransform_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResetsTransform_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLTransformOp[] TransformOps {
			[Export ("transformOps", ArgumentSemantic.Copy)]
			get {
				IMDLTransformOp[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMDLTransformOp>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTransformOpsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMDLTransformOp>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTransformOpsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MDLTransformStack */
}
