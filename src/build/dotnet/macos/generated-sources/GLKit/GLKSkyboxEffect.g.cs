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
namespace GLKit {
	/// <summary>A skybox effect.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GLKSkyboxEffect_ClassRef/index.html">Apple documentation for <c>GLKSkyboxEffect</c></related>
	[Register("GLKSkyboxEffect", true)]
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GLKSkyboxEffect : NSObject, IGLKNamedEffect {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenterX = "center";
		static readonly NativeHandle selCenterXHandle = Selector.GetHandle ("center");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawX = "draw";
		static readonly NativeHandle selDrawXHandle = Selector.GetHandle ("draw");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareToDrawX = "prepareToDraw";
		static readonly NativeHandle selPrepareToDrawXHandle = Selector.GetHandle ("prepareToDraw");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenter_X = "setCenter:";
		static readonly NativeHandle selSetCenter_XHandle = Selector.GetHandle ("setCenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXSize_X = "setXSize:";
		static readonly NativeHandle selSetXSize_XHandle = Selector.GetHandle ("setXSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetYSize_X = "setYSize:";
		static readonly NativeHandle selSetYSize_XHandle = Selector.GetHandle ("setYSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZSize_X = "setZSize:";
		static readonly NativeHandle selSetZSize_XHandle = Selector.GetHandle ("setZSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureCubeMapX = "textureCubeMap";
		static readonly NativeHandle selTextureCubeMapXHandle = Selector.GetHandle ("textureCubeMap");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformX = "transform";
		static readonly NativeHandle selTransformXHandle = Selector.GetHandle ("transform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXSizeX = "xSize";
		static readonly NativeHandle selXSizeXHandle = Selector.GetHandle ("xSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYSizeX = "ySize";
		static readonly NativeHandle selYSizeXHandle = Selector.GetHandle ("ySize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZSizeX = "zSize";
		static readonly NativeHandle selZSizeXHandle = Selector.GetHandle ("zSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GLKSkyboxEffect");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GLKSkyboxEffect" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GLKSkyboxEffect () : base (NSObjectFlag.Empty)
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
		protected GLKSkyboxEffect (NSObjectFlag t) : base (t)
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
		protected internal GLKSkyboxEffect (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draw")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrawXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDrawXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareToDraw")]
		[ObsoletedOSPlatform ("ios12.2", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("tvos12.2", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'Metal' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareToDraw ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareToDrawXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPrepareToDrawXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Center {
			[Export ("center", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSend (this.Handle, selCenterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSendSuper (&__objc_super__, selCenterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCenter:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Vector3 (this.Handle, selSetCenter_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetCenter_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLabel:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GLKEffectPropertyTexture TextureCubeMap {
			[Export ("textureCubeMap")]
			get {
				GLKEffectPropertyTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GLKEffectPropertyTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextureCubeMapXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GLKEffectPropertyTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextureCubeMapXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GLKEffectPropertyTransform Transform {
			[Export ("transform")]
			get {
				GLKEffectPropertyTransform? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GLKEffectPropertyTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTransformXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GLKEffectPropertyTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTransformXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float XSize {
			[Export ("xSize")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selXSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selXSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setXSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetXSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetXSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float YSize {
			[Export ("ySize")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selYSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selYSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setYSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetYSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetYSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ZSize {
			[Export ("zSize")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selZSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selZSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetZSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetZSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class GLKSkyboxEffect */
}
