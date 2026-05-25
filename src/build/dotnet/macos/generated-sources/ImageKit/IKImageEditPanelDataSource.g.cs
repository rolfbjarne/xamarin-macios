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
namespace ImageKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>IKImageEditPanelDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "IKImageEditPanelDataSource", WrapperType = typeof (IKImageEditPanelDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetImageAndProperties", Selector = "setImage:imageProperties:", ParameterType = new Type [] { typeof (CGImage), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetThumbnail", Selector = "thumbnailWithMaximumSize:", ReturnType = typeof (CGImage), ParameterType = new Type [] { typeof (CGSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof (CGImage), GetterSelector = "image", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageProperties", Selector = "imageProperties", PropertyType = typeof (NSDictionary), GetterSelector = "imageProperties", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasAdjustMode", Selector = "hasAdjustMode", PropertyType = typeof (bool), GetterSelector = "hasAdjustMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasEffectsMode", Selector = "hasEffectsMode", PropertyType = typeof (bool), GetterSelector = "hasEffectsMode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasDetailsMode", Selector = "hasDetailsMode", PropertyType = typeof (bool), GetterSelector = "hasDetailsMode", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IIKImageEditPanelDataSource : INativeObject, IDisposable
	{
		/// <param name="image">To be added.</param><param name="metaData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setImage:imageProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageAndProperties (CGImage image, NSDictionary metaData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="metaData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImageAndProperties (IIKImageEditPanelDataSource This, CGImage image, NSDictionary metaData)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var metaData__handle__ = metaData!.GetNonNullHandle (nameof (metaData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setImage:imageProperties:"), image.Handle, metaData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (metaData);
		}
		/// <param name="maximumSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("thumbnailWithMaximumSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage GetThumbnail (CGSize maximumSize)
		{
			return _GetThumbnail (this, maximumSize);
		}
		/// <param name="maximumSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGImage _GetThumbnail (IIKImageEditPanelDataSource This, CGSize maximumSize)
		{
			CGImage ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("thumbnailWithMaximumSize:"), maximumSize), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetThumbnail(CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("HasAdjustMode")]
		[DynamicDependencyAttribute ("HasDetailsMode")]
		[DynamicDependencyAttribute ("HasEffectsMode")]
		[DynamicDependencyAttribute ("Image")]
		[DynamicDependencyAttribute ("ImageProperties")]
		[DynamicDependencyAttribute ("SetImageAndProperties(CoreGraphics.CGImage,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageEditPanelDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IIKImageEditPanelDataSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGImage Image {
			[Export ("image")]
			get {
				return _GetImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGImage _GetImage (IIKImageEditPanelDataSource This)
		{
			CGImage ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("image")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSDictionary ImageProperties {
			[Export ("imageProperties")]
			get {
				return _GetImageProperties (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetImageProperties (IIKImageEditPanelDataSource This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageProperties")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool HasAdjustMode {
			[Export ("hasAdjustMode")]
			get {
				return _GetHasAdjustMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasAdjustMode (IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasAdjustMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool HasEffectsMode {
			[Export ("hasEffectsMode")]
			get {
				return _GetHasEffectsMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasEffectsMode (IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasEffectsMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool HasDetailsMode {
			[Export ("hasDetailsMode")]
			get {
				return _GetHasDetailsMode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasDetailsMode (IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasDetailsMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IIKImageEditPanelDataSource" /> interface to support all the methods from the IKImageEditPanelDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IIKImageEditPanelDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original IKImageEditPanelDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class IKImageEditPanelDataSource_Extensions {
		/// <param name="maximumSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGImage GetThumbnail (this IIKImageEditPanelDataSource This, CGSize maximumSize)
		{
			CGImage ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("thumbnailWithMaximumSize:"), maximumSize), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetImageProperties (this IIKImageEditPanelDataSource This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageProperties")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasAdjustMode (this IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasAdjustMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasEffectsMode (this IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasEffectsMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasDetailsMode (this IIKImageEditPanelDataSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasDetailsMode"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class IKImageEditPanelDataSourceWrapper : BaseWrapper, IIKImageEditPanelDataSource {
		public IKImageEditPanelDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageEditPanelDataSourceWrapper))]
		static IKImageEditPanelDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="image">To be added.</param><param name="metaData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setImage:imageProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetImageAndProperties (CGImage image, NSDictionary metaData)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var metaData__handle__ = metaData!.GetNonNullHandle (nameof (metaData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setImage:imageProperties:"), image.Handle, metaData__handle__);
			GC.KeepAlive (image);
			GC.KeepAlive (metaData);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGImage Image {
			[Export ("image")]
			get {
				CGImage ret;
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				return ret;
			}
		}
	}
}
namespace ImageKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IIKImageEditPanelDataSource" /> (for the protocol <c>IKImageEditPanelDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IIKImageEditPanelDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageKit_IKImageEditPanelDataSource", false)]
	[Model]
	public unsafe abstract partial class IKImageEditPanelDataSource : NSObject, IIKImageEditPanelDataSource {
		/// <summary>Creates a new <see cref="IKImageEditPanelDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected IKImageEditPanelDataSource () : base (NSObjectFlag.Empty)
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
		protected IKImageEditPanelDataSource (NSObjectFlag t) : base (t)
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
		protected internal IKImageEditPanelDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="maximumSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("thumbnailWithMaximumSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage GetThumbnail (CGSize maximumSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="metaData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setImage:imageProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageAndProperties (CGImage image, NSDictionary metaData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAdjustMode {
			[Export ("hasAdjustMode")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDetailsMode {
			[Export ("hasDetailsMode")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasEffectsMode {
			[Export ("hasEffectsMode")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGImage Image {
			[Export ("image")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ImageProperties {
			[Export ("imageProperties")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class IKImageEditPanelDataSource */
}
