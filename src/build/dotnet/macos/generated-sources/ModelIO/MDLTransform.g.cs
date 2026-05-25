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
	/// <summary>Represents static and animated coordinate transformations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLTransform_Class/index.html">Apple documentation for <c>MDLTransform</c></related>
	[Register("MDLTransform", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLTransform : NSObject, IMDLComponent, IMDLTransformComponent, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlobalTransformWithObject_AtTime_X = "globalTransformWithObject:atTime:";
		static readonly NativeHandle selGlobalTransformWithObject_AtTime_XHandle = Selector.GetHandle ("globalTransformWithObject:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMatrix_X = "initWithMatrix:";
		static readonly NativeHandle selInitWithMatrix_XHandle = Selector.GetHandle ("initWithMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMatrix_ResetsTransform_X = "initWithMatrix:resetsTransform:";
		static readonly NativeHandle selInitWithMatrix_ResetsTransform_XHandle = Selector.GetHandle ("initWithMatrix:resetsTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTransformComponent_X = "initWithTransformComponent:";
		static readonly NativeHandle selInitWithTransformComponent_XHandle = Selector.GetHandle ("initWithTransformComponent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTransformComponent_ResetsTransform_X = "initWithTransformComponent:resetsTransform:";
		static readonly NativeHandle selInitWithTransformComponent_ResetsTransform_XHandle = Selector.GetHandle ("initWithTransformComponent:resetsTransform:");
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
		const string selRotationX = "rotation";
		static readonly NativeHandle selRotationXHandle = Selector.GetHandle ("rotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotationAtTime_X = "rotationAtTime:";
		static readonly NativeHandle selRotationAtTime_XHandle = Selector.GetHandle ("rotationAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotationMatrixAtTime_X = "rotationMatrixAtTime:";
		static readonly NativeHandle selRotationMatrixAtTime_XHandle = Selector.GetHandle ("rotationMatrixAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleX = "scale";
		static readonly NativeHandle selScaleXHandle = Selector.GetHandle ("scale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScaleAtTime_X = "scaleAtTime:";
		static readonly NativeHandle selScaleAtTime_XHandle = Selector.GetHandle ("scaleAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIdentityX = "setIdentity";
		static readonly NativeHandle selSetIdentityXHandle = Selector.GetHandle ("setIdentity");
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
		const string selSetMatrix_ForTime_X = "setMatrix:forTime:";
		static readonly NativeHandle selSetMatrix_ForTime_XHandle = Selector.GetHandle ("setMatrix:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResetsTransform_X = "setResetsTransform:";
		static readonly NativeHandle selSetResetsTransform_XHandle = Selector.GetHandle ("setResetsTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRotation_X = "setRotation:";
		static readonly NativeHandle selSetRotation_XHandle = Selector.GetHandle ("setRotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRotation_ForTime_X = "setRotation:forTime:";
		static readonly NativeHandle selSetRotation_ForTime_XHandle = Selector.GetHandle ("setRotation:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScale_X = "setScale:";
		static readonly NativeHandle selSetScale_XHandle = Selector.GetHandle ("setScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScale_ForTime_X = "setScale:forTime:";
		static readonly NativeHandle selSetScale_ForTime_XHandle = Selector.GetHandle ("setScale:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShear_X = "setShear:";
		static readonly NativeHandle selSetShear_XHandle = Selector.GetHandle ("setShear:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShear_ForTime_X = "setShear:forTime:";
		static readonly NativeHandle selSetShear_ForTime_XHandle = Selector.GetHandle ("setShear:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTranslation_X = "setTranslation:";
		static readonly NativeHandle selSetTranslation_XHandle = Selector.GetHandle ("setTranslation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTranslation_ForTime_X = "setTranslation:forTime:";
		static readonly NativeHandle selSetTranslation_ForTime_XHandle = Selector.GetHandle ("setTranslation:forTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShearX = "shear";
		static readonly NativeHandle selShearXHandle = Selector.GetHandle ("shear");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShearAtTime_X = "shearAtTime:";
		static readonly NativeHandle selShearAtTime_XHandle = Selector.GetHandle ("shearAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTranslationX = "translation";
		static readonly NativeHandle selTranslationXHandle = Selector.GetHandle ("translation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTranslationAtTime_X = "translationAtTime:";
		static readonly NativeHandle selTranslationAtTime_XHandle = Selector.GetHandle ("translationAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLTransform");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLTransform" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLTransform () : base (NSObjectFlag.Empty)
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
		protected MDLTransform (NSObjectFlag t) : base (t)
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
		protected internal MDLTransform (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="component">To be added.</param><summary>Creates a new MDLTransform from the specified transform component.</summary><remarks>To be added.</remarks>
		[Export ("initWithTransformComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTransform (IMDLTransformComponent component)
			: base (NSObjectFlag.Empty)
		{
			var component__handle__ = component!.GetNonNullHandle (nameof (component));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithTransformComponent_XHandle, component__handle__), "initWithTransformComponent:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithTransformComponent_XHandle, component__handle__), "initWithTransformComponent:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (component);
		}
		/// <param name="component">To be added.</param><param name="resetsTransform">To be added.</param><summary>Creates a new transform that represents the specified transform <paramref name="component" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithTransformComponent:resetsTransform:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTransform (IMDLTransformComponent component, bool resetsTransform)
			: base (NSObjectFlag.Empty)
		{
			var component__handle__ = component!.GetNonNullHandle (nameof (component));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selInitWithTransformComponent_ResetsTransform_XHandle, component__handle__, resetsTransform ? (byte) 1 : (byte) 0), "initWithTransformComponent:resetsTransform:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selInitWithTransformComponent_ResetsTransform_XHandle, component__handle__, resetsTransform ? (byte) 1 : (byte) 0), "initWithTransformComponent:resetsTransform:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (component);
		}
		/// <param name="matrix">To be added.</param><summary>Creates a new MDLTransform from the specified matrix.</summary><remarks>To be added.</remarks>
		[Export ("initWithMatrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTransform (NMatrix4 matrix)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NMatrix4 (this.Handle, selInitWithMatrix_XHandle, matrix), "initWithMatrix:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NMatrix4 (&__objc_super__, selInitWithMatrix_XHandle, matrix), "initWithMatrix:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="matrix">To be added.</param><param name="resetsTransform">To be added.</param><summary>Creates a new MDLTransform from the specified matrix.</summary><remarks>To be added.</remarks>
		[Export ("initWithMatrix:resetsTransform:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLTransform (NMatrix4 matrix, bool resetsTransform)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NMatrix4_bool (this.Handle, selInitWithMatrix_ResetsTransform_XHandle, matrix, resetsTransform ? (byte) 1 : (byte) 0), "initWithMatrix:resetsTransform:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NMatrix4_bool (&__objc_super__, selInitWithMatrix_ResetsTransform_XHandle, matrix, resetsTransform ? (byte) 1 : (byte) 0), "initWithMatrix:resetsTransform:");
					GC.KeepAlive (this);
				}
			}
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
		/// <param name="atTime">To be added.</param><summary>Returns the rotation of the transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotationAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 GetRotation (double atTime)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_Double (this.Handle, selRotationAtTime_XHandle, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double (&__objc_super__, selRotationAtTime_XHandle, atTime);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="atTime">To be added.</param><summary>Returns the rotation of the transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotationMatrixAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetRotationMatrix (double atTime)
		{
			NMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (this.Handle, selRotationMatrixAtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (this.Handle, selRotationMatrixAtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_Double (&__objc_super__, selRotationMatrixAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double (&__objc_super__, selRotationMatrixAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>Returns the scale of the transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 GetScale (double atTime)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_Double (this.Handle, selScaleAtTime_XHandle, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double (&__objc_super__, selScaleAtTime_XHandle, atTime);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="atTime">To be added.</param><summary>Returns the shear of the transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shearAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 GetShear (double atTime)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_Double (this.Handle, selShearAtTime_XHandle, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double (&__objc_super__, selShearAtTime_XHandle, atTime);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="atTime">To be added.</param><summary>Returns the translation of the transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("translationAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 GetTranslation (double atTime)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_Double (this.Handle, selTranslationAtTime_XHandle, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double (&__objc_super__, selTranslationAtTime_XHandle, atTime);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Makes the transform identical to the identity transform.</summary><remarks>To be added.</remarks>
		[Export ("setIdentity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIdentity ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetIdentityXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetIdentityXHandle);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("setMatrix:forTime:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMatrix (NMatrix4 matrix, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double (this.Handle, selSetMatrix_ForTime_XHandle, matrix, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4_Double (&__objc_super__, selSetMatrix_ForTime_XHandle, matrix, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setRotation:forTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRotation (global::System.Numerics.Vector3 rotation, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double (this.Handle, selSetRotation_ForTime_XHandle, rotation, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double (&__objc_super__, selSetRotation_ForTime_XHandle, rotation, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setScale:forTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScale (global::System.Numerics.Vector3 scale, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double (this.Handle, selSetScale_ForTime_XHandle, scale, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double (&__objc_super__, selSetScale_ForTime_XHandle, scale, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setShear:forTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetShear (global::System.Numerics.Vector3 scale, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double (this.Handle, selSetShear_ForTime_XHandle, scale, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double (&__objc_super__, selSetShear_ForTime_XHandle, scale, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setTranslation:forTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTranslation (global::System.Numerics.Vector3 translation, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double (this.Handle, selSetTranslation_ForTime_XHandle, translation, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double (&__objc_super__, selSetTranslation_ForTime_XHandle, translation, time);
					GC.KeepAlive (this);
				}
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
		/// <summary>Gets or sets the rotation aspect of the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Rotation {
			[Export ("rotation", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetRotation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetRotation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the componentwise scale factors of the transform.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Scale {
			[Export ("scale", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScale:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the shear of the transform.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Shear {
			[Export ("shear", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selShearXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selShearXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShear:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetShear_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetShear_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the translation of the transform.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Translation {
			[Export ("translation", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selTranslationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selTranslationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTranslation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetTranslation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetTranslation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MDLTransform */
}
