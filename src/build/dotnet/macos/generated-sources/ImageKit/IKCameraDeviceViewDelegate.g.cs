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
	/// <summary>This interface represents the Objective-C protocol <c>IKCameraDeviceViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "IKCameraDeviceViewDelegate", WrapperType = typeof (IKCameraDeviceViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "cameraDeviceViewSelectionDidChange:", ParameterType = new Type [] { typeof (ImageKit.IKCameraDeviceView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDownloadFile", Selector = "cameraDeviceView:didDownloadFile:location:fileData:error:", ParameterType = new Type [] { typeof (ImageKit.IKCameraDeviceView), typeof (ImageCaptureCore.ICCameraFile), typeof (NSUrl), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "cameraDeviceView:didEncounterError:", ParameterType = new Type [] { typeof (ImageKit.IKCameraDeviceView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IIKCameraDeviceViewDelegate : INativeObject, IDisposable
	{
		/// <param name="cameraDeviceView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraDeviceViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IKCameraDeviceView cameraDeviceView)
		{
			_SelectionDidChange (this, cameraDeviceView);
		}
		/// <param name="cameraDeviceView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceViewSelectionDidChange:"), cameraDeviceView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraDeviceView:didDownloadFile:location:fileData:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDownloadFile (IKCameraDeviceView cameraDeviceView, global::ImageCaptureCore.ICCameraFile file, NSUrl url, NSData data, NSError error)
		{
			_DidDownloadFile (this, cameraDeviceView, file, url, data, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDownloadFile (IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, global::ImageCaptureCore.ICCameraFile file, NSUrl url, NSData data, NSError error)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceView:didDownloadFile:location:fileData:error:"), cameraDeviceView__handle__, file__handle__, url__handle__, data__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
			GC.KeepAlive (file);
			GC.KeepAlive (url);
			GC.KeepAlive (data);
			GC.KeepAlive (error);
		}
		/// <param name="cameraDeviceView">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cameraDeviceView:didEncounterError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (IKCameraDeviceView cameraDeviceView, NSError error)
		{
			_DidEncounterError (this, cameraDeviceView, error);
		}
		/// <param name="cameraDeviceView">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEncounterError (IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, NSError error)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceView:didEncounterError:"), cameraDeviceView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidDownloadFile(ImageKit.IKCameraDeviceView,ImageCaptureCore.ICCameraFile,Foundation.NSUrl,Foundation.NSData,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidEncounterError(ImageKit.IKCameraDeviceView,Foundation.NSError)")]
		[DynamicDependencyAttribute ("SelectionDidChange(ImageKit.IKCameraDeviceView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKCameraDeviceViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IIKCameraDeviceViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IIKCameraDeviceViewDelegate" /> interface to support all the methods from the IKCameraDeviceViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IIKCameraDeviceViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original IKCameraDeviceViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class IKCameraDeviceViewDelegate_Extensions {
		/// <param name="cameraDeviceView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionDidChange (this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceViewSelectionDidChange:"), cameraDeviceView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDownloadFile (this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, global::ImageCaptureCore.ICCameraFile file, NSUrl url, NSData data, NSError error)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			var file__handle__ = file!.GetNonNullHandle (nameof (file));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceView:didDownloadFile:location:fileData:error:"), cameraDeviceView__handle__, file__handle__, url__handle__, data__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
			GC.KeepAlive (file);
			GC.KeepAlive (url);
			GC.KeepAlive (data);
			GC.KeepAlive (error);
		}
		/// <param name="cameraDeviceView">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEncounterError (this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, NSError error)
		{
			var cameraDeviceView__handle__ = cameraDeviceView!.GetNonNullHandle (nameof (cameraDeviceView));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraDeviceView:didEncounterError:"), cameraDeviceView__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cameraDeviceView);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class IKCameraDeviceViewDelegateWrapper : BaseWrapper, IIKCameraDeviceViewDelegate {
		public IKCameraDeviceViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKCameraDeviceViewDelegateWrapper))]
		static IKCameraDeviceViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ImageKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IIKCameraDeviceViewDelegate" /> (for the protocol <c>IKCameraDeviceViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IIKCameraDeviceViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__ImageKit_IKCameraDeviceViewDelegate", false)]
	[Model]
	public unsafe partial class IKCameraDeviceViewDelegate : NSObject, IIKCameraDeviceViewDelegate {
		/// <summary>Creates a new <see cref="IKCameraDeviceViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKCameraDeviceViewDelegate () : base (NSObjectFlag.Empty)
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
		protected IKCameraDeviceViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal IKCameraDeviceViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("cameraDeviceView:didDownloadFile:location:fileData:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDownloadFile (IKCameraDeviceView cameraDeviceView, global::ImageCaptureCore.ICCameraFile file, NSUrl url, NSData data, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cameraDeviceView">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cameraDeviceView:didEncounterError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (IKCameraDeviceView cameraDeviceView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cameraDeviceView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cameraDeviceViewSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IKCameraDeviceView cameraDeviceView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class IKCameraDeviceViewDelegate */
}
