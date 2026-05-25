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
	#pragma warning disable CS1573
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLLightProbeIrradianceDataSource">Apple documentation for <c>MDLLightProbeIrradianceDataSource</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLLightProbeIrradianceDataSource", WrapperType = typeof (MDLLightProbeIrradianceDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSphericalHarmonicsCoefficients", Selector = "sphericalHarmonicsCoefficientsAtPosition:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (System.Numerics.Vector3) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BoundingBox", Selector = "boundingBox", PropertyType = typeof (MDLAxisAlignedBoundingBox), GetterSelector = "boundingBox", SetterSelector = "setBoundingBox:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SphericalHarmonicsLevel", Selector = "sphericalHarmonicsLevel", PropertyType = typeof (UIntPtr), GetterSelector = "sphericalHarmonicsLevel", SetterSelector = "setSphericalHarmonicsLevel:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMDLLightProbeIrradianceDataSource : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("sphericalHarmonicsCoefficientsAtPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetSphericalHarmonicsCoefficients (global::System.Numerics.Vector3 position)
		{
			return _GetSphericalHarmonicsCoefficients (this, position);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetSphericalHarmonicsCoefficients (IMDLLightProbeIrradianceDataSource This, global::System.Numerics.Vector3 position)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector3 (This.Handle, Selector.GetHandle ("sphericalHarmonicsCoefficientsAtPosition:"), position), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("BoundingBox")]
		[DynamicDependencyAttribute ("GetSphericalHarmonicsCoefficients(System.Numerics.Vector3)")]
		[DynamicDependencyAttribute ("SphericalHarmonicsLevel")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLLightProbeIrradianceDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLLightProbeIrradianceDataSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MDLAxisAlignedBoundingBox BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.Assign)]
			get {
				return _GetBoundingBox (this);
			}
			[Export ("setBoundingBox:", ArgumentSemantic.Assign)]
			set {
				_SetBoundingBox (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLAxisAlignedBoundingBox _GetBoundingBox (IMDLLightProbeIrradianceDataSource This)
		{
			MDLAxisAlignedBoundingBox ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MDLAxisAlignedBoundingBox_objc_msgSend (This.Handle, Selector.GetHandle ("boundingBox"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MDLAxisAlignedBoundingBox_objc_msgSend_stret (This.Handle, Selector.GetHandle ("boundingBox"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBoundingBox (IMDLLightProbeIrradianceDataSource This, MDLAxisAlignedBoundingBox value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_MDLAxisAlignedBoundingBox (This.Handle, Selector.GetHandle ("setBoundingBox:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nuint SphericalHarmonicsLevel {
			[Export ("sphericalHarmonicsLevel")]
			get {
				return _GetSphericalHarmonicsLevel (this);
			}
			[Export ("setSphericalHarmonicsLevel:")]
			set {
				_SetSphericalHarmonicsLevel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetSphericalHarmonicsLevel (IMDLLightProbeIrradianceDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sphericalHarmonicsLevel"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSphericalHarmonicsLevel (IMDLLightProbeIrradianceDataSource This, nuint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setSphericalHarmonicsLevel:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMDLLightProbeIrradianceDataSource" /> interface to support all the methods from the MDLLightProbeIrradianceDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMDLLightProbeIrradianceDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MDLLightProbeIrradianceDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MDLLightProbeIrradianceDataSource_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetSphericalHarmonicsCoefficients (this IMDLLightProbeIrradianceDataSource This, global::System.Numerics.Vector3 position)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector3 (This.Handle, Selector.GetHandle ("sphericalHarmonicsCoefficientsAtPosition:"), position), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetSphericalHarmonicsLevel (this IMDLLightProbeIrradianceDataSource This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sphericalHarmonicsLevel"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSphericalHarmonicsLevel (this IMDLLightProbeIrradianceDataSource This, nuint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setSphericalHarmonicsLevel:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLLightProbeIrradianceDataSourceWrapper : BaseWrapper, IMDLLightProbeIrradianceDataSource {
		public MDLLightProbeIrradianceDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLLightProbeIrradianceDataSourceWrapper))]
		static MDLLightProbeIrradianceDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLAxisAlignedBoundingBox BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.Assign)]
			get {
				MDLAxisAlignedBoundingBox ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MDLAxisAlignedBoundingBox_objc_msgSend (this.Handle, Selector.GetHandle ("boundingBox"));
				} else {
					ret = global::ObjCRuntime.Messaging.MDLAxisAlignedBoundingBox_objc_msgSend_stret (this.Handle, Selector.GetHandle ("boundingBox"));
				}
				return ret!;
			}
			[Export ("setBoundingBox:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MDLAxisAlignedBoundingBox (this.Handle, Selector.GetHandle ("setBoundingBox:"), value);
			}
		}
	}
}
namespace ModelIO {
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/ModelIO/MDLLightProbeIrradianceDataSource">Apple documentation for <c>MDLLightProbeIrradianceDataSource</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__ModelIO_MDLLightProbeIrradianceDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MDLLightProbeIrradianceDataSource : NSObject, IMDLLightProbeIrradianceDataSource {
		/// <summary>Creates a new <see cref="MDLLightProbeIrradianceDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MDLLightProbeIrradianceDataSource () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected MDLLightProbeIrradianceDataSource (NSObjectFlag t) : base (t)
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
		protected internal MDLLightProbeIrradianceDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("sphericalHarmonicsCoefficientsAtPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetSphericalHarmonicsCoefficients (global::System.Numerics.Vector3 position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAxisAlignedBoundingBox BoundingBox {
			[Export ("boundingBox", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setBoundingBox:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SphericalHarmonicsLevel {
			[Export ("sphericalHarmonicsLevel")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSphericalHarmonicsLevel:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class MDLLightProbeIrradianceDataSource */
}
