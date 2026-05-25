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
namespace GameplayKit {
	/// <summary>A <see cref="T:GameplayKit.GKBehavior" /> that combines other <see cref="T:GameplayKit.GKBehavior" /> objects.</summary>
	[Register("GKCompositeBehavior", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKCompositeBehavior : GKBehavior {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBehaviorCountX = "behaviorCount";
		static readonly NativeHandle selBehaviorCountXHandle = Selector.GetHandle ("behaviorCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBehaviorWithBehaviors_X = "behaviorWithBehaviors:";
		static readonly NativeHandle selBehaviorWithBehaviors_XHandle = Selector.GetHandle ("behaviorWithBehaviors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBehaviorWithBehaviors_AndWeights_X = "behaviorWithBehaviors:andWeights:";
		static readonly NativeHandle selBehaviorWithBehaviors_AndWeights_XHandle = Selector.GetHandle ("behaviorWithBehaviors:andWeights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndexedSubscript_X = "objectAtIndexedSubscript:";
		static readonly NativeHandle selObjectAtIndexedSubscript_XHandle = Selector.GetHandle ("objectAtIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllBehaviorsX = "removeAllBehaviors";
		static readonly NativeHandle selRemoveAllBehaviorsXHandle = Selector.GetHandle ("removeAllBehaviors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveBehavior_X = "removeBehavior:";
		static readonly NativeHandle selRemoveBehavior_XHandle = Selector.GetHandle ("removeBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKeyedSubscript_X = "setObject:forKeyedSubscript:";
		static readonly NativeHandle selSetObject_ForKeyedSubscript_XHandle = Selector.GetHandle ("setObject:forKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWeight_ForBehavior_X = "setWeight:forBehavior:";
		static readonly NativeHandle selSetWeight_ForBehavior_XHandle = Selector.GetHandle ("setWeight:forBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeightForBehavior_X = "weightForBehavior:";
		static readonly NativeHandle selWeightForBehavior_XHandle = Selector.GetHandle ("weightForBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKCompositeBehavior");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKCompositeBehavior" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKCompositeBehavior () : base (NSObjectFlag.Empty)
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
		protected GKCompositeBehavior (NSObjectFlag t) : base (t)
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
		protected internal GKCompositeBehavior (NativeHandle handle) : base (handle)
		{
		}

		[Export ("behaviorWithBehaviors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKCompositeBehavior FromBehaviors (GKBehavior[] behaviors)
		{
			if (behaviors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (behaviors));
			using var nsa_behaviors = NSArray.FromNSObjects (behaviors);
			GKCompositeBehavior ret;
			ret =  Runtime.GetNSObject<GKCompositeBehavior> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBehaviorWithBehaviors_XHandle, nsa_behaviors.Handle), false)!;
			return ret;
		}
		[Export ("behaviorWithBehaviors:andWeights:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKCompositeBehavior FromBehaviors (GKBehavior[] behaviors, NSNumber[] weights)
		{
			if (behaviors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (behaviors));
			if (weights is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (weights));
			using var nsa_behaviors = NSArray.FromNSObjects (behaviors);
			using var nsa_weights = NSArray.FromNSObjects (weights);
			GKCompositeBehavior ret;
			ret =  Runtime.GetNSObject<GKCompositeBehavior> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selBehaviorWithBehaviors_AndWeights_XHandle, nsa_behaviors.Handle, nsa_weights.Handle), false)!;
			return ret;
		}
		[Export ("weightForBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetWeight (GKBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, selWeightForBehavior_XHandle, behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, selWeightForBehavior_XHandle, behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
			return ret!;
		}
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual GKBehavior ObjectAtIndexedSubscript (nuint index)
		{
			GKBehavior ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GKBehavior> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selObjectAtIndexedSubscript_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GKBehavior> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selObjectAtIndexedSubscript_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSNumber ObjectForKeyedSubscript (GKBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			NSNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, behavior__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, behavior__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
			return ret!;
		}
		[Export ("removeAllBehaviors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllBehaviors ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllBehaviorsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllBehaviorsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveBehavior (GKBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveBehavior_XHandle, behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveBehavior_XHandle, behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
		}
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void SetObject (NSNumber weight, GKBehavior behavior)
		{
			var weight__handle__ = weight!.GetNonNullHandle (nameof (weight));
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetObject_ForKeyedSubscript_XHandle, weight__handle__, behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetObject_ForKeyedSubscript_XHandle, weight__handle__, behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (weight);
			GC.KeepAlive (behavior);
		}
		[Export ("setWeight:forBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWeight (float weight, GKBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_NativeHandle (this.Handle, selSetWeight_ForBehavior_XHandle, weight, behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_NativeHandle (&__objc_super__, selSetWeight_ForBehavior_XHandle, weight, behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BehaviorCount {
			[Export ("behaviorCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBehaviorCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBehaviorCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class GKCompositeBehavior */
}
