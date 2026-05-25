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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>Functions that define a volume in 3D space.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNBoundingVolume_Protocol/index.html">Apple documentation for <c>SCNBoundingVolume</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNBoundingVolume", WrapperType = typeof (SCNBoundingVolumeWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBoundingBox", Selector = "getBoundingBoxMin:max:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SCNVector3), typeof (SCNVector3) }, ParameterByRef = new bool [] { true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBoundingBox", Selector = "setBoundingBoxMin:max:", ParameterType = new Type [] { typeof (SCNVector3), typeof (SCNVector3) }, ParameterByRef = new bool [] { true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBoundingSphere", Selector = "getBoundingSphereCenter:radius:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SCNVector3), typeof (NFloat) }, ParameterByRef = new bool [] { true, true })]
	public partial interface ISCNBoundingVolume : INativeObject, IDisposable
	{
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("getBoundingBoxMin:max:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _GetBoundingBox (ISCNBoundingVolume This, ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (This.Handle, Selector.GetHandle ("getBoundingBoxMin:max:"), min__pointer, max__pointer);
			GC.KeepAlive (This);
			return ret != 0;
			}
			}
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBoundingBoxMin:max:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetBoundingBox (ISCNBoundingVolume This, ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			global::ObjCRuntime.Messaging.void_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (This.Handle, Selector.GetHandle ("setBoundingBoxMin:max:"), min__pointer, max__pointer);
			GC.KeepAlive (This);
			}
			}
		}
		/// <param name="center">To be added.</param><param name="radius">To be added.</param><summary>Returns <see langword="true" />, and fills <paramref name="center" /> and <paramref name="radius" /> with the bounding sphere data, if the geometry object has volume. Otherwise, returns <see langword="false" /> and the parameters are undefined.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("getBoundingSphereCenter:radius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingSphere (ref SCNVector3 center, ref nfloat radius)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="center">To be added.</param><param name="radius">To be added.</param><summary>Returns <see langword="true" />, and fills <paramref name="center" /> and <paramref name="radius" /> with the bounding sphere data, if the geometry object has volume. Otherwise, returns <see langword="false" /> and the parameters are undefined.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _GetBoundingSphere (ISCNBoundingVolume This, ref SCNVector3 center, ref nfloat radius)
		{
			fixed (SCNVector3* center__pointer = &center) {
			fixed (nfloat* radius__pointer = &radius) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_NFloat (This.Handle, Selector.GetHandle ("getBoundingSphereCenter:radius:"), center__pointer, radius__pointer);
			GC.KeepAlive (This);
			return ret != 0;
			}
			}
		}
		[DynamicDependencyAttribute ("GetBoundingBox(SceneKit.SCNVector3@,SceneKit.SCNVector3@)")]
		[DynamicDependencyAttribute ("GetBoundingSphere(SceneKit.SCNVector3@,System.Runtime.InteropServices.NFloat@)")]
		[DynamicDependencyAttribute ("SetBoundingBox(SceneKit.SCNVector3@,SceneKit.SCNVector3@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNBoundingVolumeWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNBoundingVolume ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNBoundingVolumeWrapper : BaseWrapper, ISCNBoundingVolume {
		public SCNBoundingVolumeWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNBoundingVolumeWrapper))]
		static SCNBoundingVolumeWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingBoxMin:max:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool GetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (this.Handle, Selector.GetHandle ("getBoundingBoxMin:max:"), min__pointer, max__pointer);
			return ret != 0;
			}
			}
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBoundingBoxMin:max:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			global::ObjCRuntime.Messaging.void_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (this.Handle, Selector.GetHandle ("setBoundingBoxMin:max:"), min__pointer, max__pointer);
			}
			}
		}
		/// <param name="center">To be added.</param><param name="radius">To be added.</param><summary>Returns <see langword="true" />, and fills <paramref name="center" /> and <paramref name="radius" /> with the bounding sphere data, if the geometry object has volume. Otherwise, returns <see langword="false" /> and the parameters are undefined.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingSphereCenter:radius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool GetBoundingSphere (ref SCNVector3 center, ref nfloat radius)
		{
			fixed (SCNVector3* center__pointer = &center) {
			fixed (nfloat* radius__pointer = &radius) {
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_NFloat (this.Handle, Selector.GetHandle ("getBoundingSphereCenter:radius:"), center__pointer, radius__pointer);
			return ret != 0;
			}
			}
		}
	}
}
namespace SceneKit {
	/// <summary>Functions that define a volume in 3D space.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNBoundingVolume_Protocol/index.html">Apple documentation for <c>SCNBoundingVolume</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__SceneKit_SCNBoundingVolume", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class SCNBoundingVolume : NSObject, ISCNBoundingVolume {
		/// <summary>Creates a new <see cref="SCNBoundingVolume" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCNBoundingVolume () : base (NSObjectFlag.Empty)
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
		protected SCNBoundingVolume (NSObjectFlag t) : base (t)
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
		protected internal SCNBoundingVolume (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingBoxMin:max:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="center">To be added.</param><param name="radius">To be added.</param><summary>Returns <see langword="true" />, and fills <paramref name="center" /> and <paramref name="radius" /> with the bounding sphere data, if the geometry object has volume. Otherwise, returns <see langword="false" /> and the parameters are undefined.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingSphereCenter:radius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingSphere (ref SCNVector3 center, ref nfloat radius)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBoundingBoxMin:max:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNBoundingVolume */
}
