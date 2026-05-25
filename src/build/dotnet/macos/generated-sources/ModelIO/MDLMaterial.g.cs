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
	/// <summary>Defines how a surface should appear when rendered.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMaterial_Class/index.html">Apple documentation for <c>MDLMaterial</c></related>
	[Register("MDLMaterial", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLMaterial : NSObject, IMDLNamed {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseMaterialX = "baseMaterial";
		static readonly NativeHandle selBaseMaterialXHandle = Selector.GetHandle ("baseMaterial");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_ScatteringFunction_X = "initWithName:scatteringFunction:";
		static readonly NativeHandle selInitWithName_ScatteringFunction_XHandle = Selector.GetHandle ("initWithName:scatteringFunction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTexturesUsingResolver_X = "loadTexturesUsingResolver:";
		static readonly NativeHandle selLoadTexturesUsingResolver_XHandle = Selector.GetHandle ("loadTexturesUsingResolver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaterialFaceX = "materialFace";
		static readonly NativeHandle selMaterialFaceXHandle = Selector.GetHandle ("materialFace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaterialWithSCNMaterial_X = "materialWithSCNMaterial:";
		static readonly NativeHandle selMaterialWithSCNMaterial_XHandle = Selector.GetHandle ("materialWithSCNMaterial:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndexedSubscript_X = "objectAtIndexedSubscript:";
		static readonly NativeHandle selObjectAtIndexedSubscript_XHandle = Selector.GetHandle ("objectAtIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertiesWithSemantic_X = "propertiesWithSemantic:";
		static readonly NativeHandle selPropertiesWithSemantic_XHandle = Selector.GetHandle ("propertiesWithSemantic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyNamed_X = "propertyNamed:";
		static readonly NativeHandle selPropertyNamed_XHandle = Selector.GetHandle ("propertyNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyWithSemantic_X = "propertyWithSemantic:";
		static readonly NativeHandle selPropertyWithSemantic_XHandle = Selector.GetHandle ("propertyWithSemantic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllPropertiesX = "removeAllProperties";
		static readonly NativeHandle selRemoveAllPropertiesXHandle = Selector.GetHandle ("removeAllProperties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveProperty_X = "removeProperty:";
		static readonly NativeHandle selRemoveProperty_XHandle = Selector.GetHandle ("removeProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolveTexturesWithResolver_X = "resolveTexturesWithResolver:";
		static readonly NativeHandle selResolveTexturesWithResolver_XHandle = Selector.GetHandle ("resolveTexturesWithResolver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScatteringFunctionX = "scatteringFunction";
		static readonly NativeHandle selScatteringFunctionXHandle = Selector.GetHandle ("scatteringFunction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseMaterial_X = "setBaseMaterial:";
		static readonly NativeHandle selSetBaseMaterial_XHandle = Selector.GetHandle ("setBaseMaterial:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaterialFace_X = "setMaterialFace:";
		static readonly NativeHandle selSetMaterialFace_XHandle = Selector.GetHandle ("setMaterialFace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProperty_X = "setProperty:";
		static readonly NativeHandle selSetProperty_XHandle = Selector.GetHandle ("setProperty:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLMaterial");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLMaterial" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLMaterial () : base (NSObjectFlag.Empty)
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
		protected MDLMaterial (NSObjectFlag t) : base (t)
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
		protected internal MDLMaterial (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="name">To be added.</param><param name="scatteringFunction">To be added.</param><summary>Creates a new named material with the specified scattering function.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:scatteringFunction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMaterial (string name, MDLScatteringFunction scatteringFunction)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var scatteringFunction__handle__ = scatteringFunction!.GetNonNullHandle (nameof (scatteringFunction));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithName_ScatteringFunction_XHandle, nsname, scatteringFunction__handle__), "initWithName:scatteringFunction:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_ScatteringFunction_XHandle, nsname, scatteringFunction__handle__), "initWithName:scatteringFunction:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scatteringFunction);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="material">To be added.</param><summary>Creates a new MDLMaterial from the specified SCNMaterial.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("materialWithSCNMaterial:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMaterial FromSceneMaterial (global::SceneKit.SCNMaterial material)
		{
			var material__handle__ = material!.GetNonNullHandle (nameof (material));
			MDLMaterial? ret;
			ret =  Runtime.GetNSObject<MDLMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selMaterialWithSCNMaterial_XHandle, material__handle__), false)!;
			GC.KeepAlive (material);
			return ret!;
		}
		/// <param name="semantic">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("propertiesWithSemantic:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty[] GetProperties (MDLMaterialSemantic semantic)
		{
			MDLMaterialProperty[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MDLMaterialProperty>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selPropertiesWithSemantic_XHandle, (UIntPtr) (ulong) semantic), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MDLMaterialProperty>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selPropertiesWithSemantic_XHandle, (UIntPtr) (ulong) semantic), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="name">To be added.</param><summary>Returns the property with the specifed name, if it exists. Otherwise, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("propertyNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty? GetProperty (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			MDLMaterialProperty? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPropertyNamed_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPropertyNamed_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="semantic">To be added.</param><summary>Returns the property value for the specifed semantic, if it exists. Otherwise, returns <see langword="null" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("propertyWithSemantic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterialProperty? GetProperty (MDLMaterialSemantic semantic)
		{
			MDLMaterialProperty ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selPropertyWithSemantic_XHandle, (UIntPtr) (ulong) semantic), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selPropertyWithSemantic_XHandle, (UIntPtr) (ulong) semantic), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="resolver"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("loadTexturesUsingResolver:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadTextures (IMDLAssetResolver resolver)
		{
			var resolver__handle__ = resolver!.GetNonNullHandle (nameof (resolver));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadTexturesUsingResolver_XHandle, resolver__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadTexturesUsingResolver_XHandle, resolver__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resolver);
		}
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual MDLMaterialProperty? ObjectAtIndexedSubscript (nuint idx)
		{
			MDLMaterialProperty ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selObjectAtIndexedSubscript_XHandle, idx), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selObjectAtIndexedSubscript_XHandle, idx), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual MDLMaterialProperty? ObjectForKeyedSubscript (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			MDLMaterialProperty? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMaterialProperty> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <summary>Removes all properties from the material.</summary><remarks>To be added.</remarks>
		[Export ("removeAllProperties")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllProperties ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllPropertiesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllPropertiesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="property">To be added.</param><summary>Removes <paramref name="property" /> from the material.</summary><remarks>To be added.</remarks>
		[Export ("removeProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProperty (MDLMaterialProperty property)
		{
			var property__handle__ = property!.GetNonNullHandle (nameof (property));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveProperty_XHandle, property__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveProperty_XHandle, property__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (property);
		}
		/// <param name="resolver"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resolveTexturesWithResolver:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResolveTextures (IMDLAssetResolver resolver)
		{
			var resolver__handle__ = resolver!.GetNonNullHandle (nameof (resolver));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selResolveTexturesWithResolver_XHandle, resolver__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selResolveTexturesWithResolver_XHandle, resolver__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resolver);
		}
		/// <param name="property">To be added.</param><summary>Updates or adds the specified property.</summary><remarks>To be added.</remarks>
		[Export ("setProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProperty (MDLMaterialProperty property)
		{
			var property__handle__ = property!.GetNonNullHandle (nameof (property));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProperty_XHandle, property__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProperty_XHandle, property__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (property);
		}
		/// <summary>Gets or sets a material from which to derive the properties of this amterial.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>Uninitialized properties on this object are filled in with their correspoding values from the base material.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterial? BaseMaterial {
			[Export ("baseMaterial", ArgumentSemantic.Retain)]
			get {
				MDLMaterial? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBaseMaterialXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBaseMaterialXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBaseMaterial:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBaseMaterial_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBaseMaterial_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the number of properties that belong to this material.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets or sets a value that determines whether the material is a back, front, or double-sided face.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MDLMaterialFace MaterialFace {
			[Export ("materialFace", ArgumentSemantic.Assign)]
			get {
				MDLMaterialFace ret;
				if (IsDirectBinding) {
					ret = (MDLMaterialFace) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaterialFaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MDLMaterialFace) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaterialFaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaterialFace:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaterialFace_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaterialFace_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the descriptive name of the named object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Name {
			[Export ("name")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Gets the scattering function for the material.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLScatteringFunction ScatteringFunction {
			[Export ("scatteringFunction", ArgumentSemantic.Retain)]
			get {
				MDLScatteringFunction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLScatteringFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selScatteringFunctionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLScatteringFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selScatteringFunctionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MDLMaterial */
}
