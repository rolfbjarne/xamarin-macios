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
	/// <summary>Represents a bidirectional reflectance distribution function to use when rendering a <see cref="T:ModelIO.MDLMaterialTextureWrapMode" />.</summary><remarks>The properties on this object, except for <see cref="P:ModelIO.MDLPhysicallyPlausibleScatteringFunction.Version" /> have valid values only in the range [0.0, 1.0].</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLPhysicallyPlausibleScatteringFunction_Class/index.html">Apple documentation for <c>MDLPhysicallyPlausibleScatteringFunction</c></related>
	[Register("MDLPhysicallyPlausibleScatteringFunction", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLPhysicallyPlausibleScatteringFunction : MDLScatteringFunction {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnisotropicX = "anisotropic";
		static readonly NativeHandle selAnisotropicXHandle = Selector.GetHandle ("anisotropic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnisotropicRotationX = "anisotropicRotation";
		static readonly NativeHandle selAnisotropicRotationXHandle = Selector.GetHandle ("anisotropicRotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearcoatX = "clearcoat";
		static readonly NativeHandle selClearcoatXHandle = Selector.GetHandle ("clearcoat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearcoatGlossX = "clearcoatGloss";
		static readonly NativeHandle selClearcoatGlossXHandle = Selector.GetHandle ("clearcoatGloss");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetallicX = "metallic";
		static readonly NativeHandle selMetallicXHandle = Selector.GetHandle ("metallic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRoughnessX = "roughness";
		static readonly NativeHandle selRoughnessXHandle = Selector.GetHandle ("roughness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSheenX = "sheen";
		static readonly NativeHandle selSheenXHandle = Selector.GetHandle ("sheen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSheenTintX = "sheenTint";
		static readonly NativeHandle selSheenTintXHandle = Selector.GetHandle ("sheenTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpecularAmountX = "specularAmount";
		static readonly NativeHandle selSpecularAmountXHandle = Selector.GetHandle ("specularAmount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpecularTintX = "specularTint";
		static readonly NativeHandle selSpecularTintXHandle = Selector.GetHandle ("specularTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubsurfaceX = "subsurface";
		static readonly NativeHandle selSubsurfaceXHandle = Selector.GetHandle ("subsurface");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVersionX = "version";
		static readonly NativeHandle selVersionXHandle = Selector.GetHandle ("version");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLPhysicallyPlausibleScatteringFunction");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLPhysicallyPlausibleScatteringFunction" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLPhysicallyPlausibleScatteringFunction () : base (NSObjectFlag.Empty)
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
		protected MDLPhysicallyPlausibleScatteringFunction (NSObjectFlag t) : base (t)
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
		protected internal MDLPhysicallyPlausibleScatteringFunction (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Gets the degree to which reflection varies as a function of the angle from the tangential vector. The default is <c>0.0</c>, which indicates isotropic reflection.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Anisotropic {
			[Export ("anisotropic", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnisotropicXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnisotropicXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the angular deviation from which anisotropic effects are calculated, relative to the tangential basis. The default is <c>0.0</c>, which indicates no deviation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty AnisotropicRotation {
			[Export ("anisotropicRotation", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnisotropicRotationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnisotropicRotationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the intensity of secondary highlights. The default is <c>0.0</c>, which indicates no specular highlights.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Clearcoat {
			[Export ("clearcoat", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClearcoatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClearcoatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the sharpness of secondary highlights. The default is <c>0.0</c>, which indicates blurry specular highlights.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty ClearcoatGloss {
			[Export ("clearcoatGloss", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClearcoatGlossXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClearcoatGlossXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the degree to which the surface appears metallic. The default is <c>0.0</c>, which indicates a nonmetallic surface.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Metallic {
			[Export ("metallic", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMetallicXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMetallicXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the surface roughness. The default is <c>0.9</c>, which indicates a matte surface.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Roughness {
			[Export ("roughness", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRoughnessXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRoughnessXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the degree of added low-angle reflection. The default is <c>0.05</c>, which indicates a highlight that is just detectable.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Sheen {
			[Export ("sheen", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSheenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSheenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the degree to which low-angle reflections are tinted by the surface color. The default is <c>0.0</c>, which indicates that low-angle reflections are identical to the incident light color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty SheenTint {
			[Export ("sheenTint", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSheenTintXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSheenTintXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the relative strength of specular highlights. The default is <c>0.0</c>, which indicates no specular highlights are visible.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty SpecularAmount {
			[Export ("specularAmount", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpecularAmountXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpecularAmountXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the degree to which specular reflections are tinted by the surface color. The default is <c>0.0</c>, which indicates that specular reflections are identical to the incident light color.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty SpecularTint {
			[Export ("specularTint", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpecularTintXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpecularTintXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the degree to which light is scattered immediately beneath the surface. The default is <c>0.0</c>, which indicates very strong scattering.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty Subsurface {
			[Export ("subsurface", ArgumentSemantic.Retain)]
			get {
				MDLMaterialProperty? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubsurfaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubsurfaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the scattering function version.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Version {
			[Export ("version")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MDLPhysicallyPlausibleScatteringFunction */
}
