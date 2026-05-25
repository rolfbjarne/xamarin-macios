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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Callbacks for the UIVideoEditorController.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIVideoEditorControllerDelegate_ProtocolReference/index.html">Apple documentation for <c>UIVideoEditorControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIVideoEditorControllerDelegate", WrapperType = typeof (UIVideoEditorControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VideoSaved", Selector = "videoEditorController:didSaveEditedVideoToPath:", ParameterType = new Type [] { typeof (UIVideoEditorController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "videoEditorController:didFailWithError:", ParameterType = new Type [] { typeof (UIVideoEditorController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserCancelled", Selector = "videoEditorControllerDidCancel:", ParameterType = new Type [] { typeof (UIVideoEditorController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIVideoEditorControllerDelegate : INativeObject, IDisposable, 
		UIKit.IUINavigationControllerDelegate
	{
		/// <param name="editor">To be added.</param><param name="editedVideoPath">To be added.</param><summary>Called after the movie was successfully saved.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoEditorController:didSaveEditedVideoToPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void VideoSaved (UIVideoEditorController editor, string editedVideoPath)
		{
			_VideoSaved (this, editor, editedVideoPath);
		}
		/// <param name="editor">To be added.</param><param name="editedVideoPath">To be added.</param><summary>Called after the movie was successfully saved.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _VideoSaved (IUIVideoEditorControllerDelegate This, UIVideoEditorController editor, string editedVideoPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			if (editedVideoPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editedVideoPath));
			var nseditedVideoPath = CFString.CreateNative (editedVideoPath);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorController:didSaveEditedVideoToPath:"), editor__handle__, nseditedVideoPath);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			CFString.ReleaseNative (nseditedVideoPath);
		}
		/// <param name="editor">To be added.</param><param name="error">To be added.</param><summary>Called when the UIVideoEditorController failed to load or save a movie.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoEditorController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (UIVideoEditorController editor, NSError error)
		{
			_Failed (this, editor, error);
		}
		/// <param name="editor">To be added.</param><param name="error">To be added.</param><summary>Called when the UIVideoEditorController failed to load or save a movie.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Failed (IUIVideoEditorControllerDelegate This, UIVideoEditorController editor, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorController:didFailWithError:"), editor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (error);
		}
		/// <param name="editor">To be added.</param><summary>Indicates that the app user cancelled the movie editing.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoEditorControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserCancelled (UIVideoEditorController editor)
		{
			_UserCancelled (this, editor);
		}
		/// <param name="editor">To be added.</param><summary>Indicates that the app user cancelled the movie editing.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserCancelled (IUIVideoEditorControllerDelegate This, UIVideoEditorController editor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorControllerDidCancel:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
		[DynamicDependencyAttribute ("Failed(UIKit.UIVideoEditorController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("UserCancelled(UIKit.UIVideoEditorController)")]
		[DynamicDependencyAttribute ("VideoSaved(UIKit.UIVideoEditorController,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIVideoEditorControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIVideoEditorControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIVideoEditorControllerDelegate" /> interface to support all the methods from the UIVideoEditorControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIVideoEditorControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIVideoEditorControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIVideoEditorControllerDelegate_Extensions {
		/// <param name="editor">To be added.</param><param name="editedVideoPath">To be added.</param><summary>Called after the movie was successfully saved.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void VideoSaved (this IUIVideoEditorControllerDelegate This, UIVideoEditorController editor, string editedVideoPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			if (editedVideoPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (editedVideoPath));
			var nseditedVideoPath = CFString.CreateNative (editedVideoPath);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorController:didSaveEditedVideoToPath:"), editor__handle__, nseditedVideoPath);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			CFString.ReleaseNative (nseditedVideoPath);
		}
		/// <param name="editor">To be added.</param><param name="error">To be added.</param><summary>Called when the UIVideoEditorController failed to load or save a movie.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Failed (this IUIVideoEditorControllerDelegate This, UIVideoEditorController editor, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorController:didFailWithError:"), editor__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (error);
		}
		/// <param name="editor">To be added.</param><summary>Indicates that the app user cancelled the movie editing.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserCancelled (this IUIVideoEditorControllerDelegate This, UIVideoEditorController editor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("videoEditorControllerDidCancel:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIVideoEditorControllerDelegateWrapper : BaseWrapper, IUIVideoEditorControllerDelegate {
		public UIVideoEditorControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIVideoEditorControllerDelegateWrapper))]
		static UIVideoEditorControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Callbacks for the UIVideoEditorController.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIVideoEditorControllerDelegate_ProtocolReference/index.html">Apple documentation for <c>UIVideoEditorControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIVideoEditorControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIVideoEditorControllerDelegate : UINavigationControllerDelegate, IUIVideoEditorControllerDelegate {
		/// <summary>Creates a new <see cref="UIVideoEditorControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIVideoEditorControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected UIVideoEditorControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIVideoEditorControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="editor">To be added.</param><param name="error">To be added.</param><summary>Called when the UIVideoEditorController failed to load or save a movie.</summary><remarks>To be added.</remarks>
		[Export ("videoEditorController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (UIVideoEditorController editor, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><summary>Indicates that the app user cancelled the movie editing.</summary><remarks>To be added.</remarks>
		[Export ("videoEditorControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserCancelled (UIVideoEditorController editor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="editedVideoPath">To be added.</param><summary>Called after the movie was successfully saved.</summary><remarks>To be added.</remarks>
		[Export ("videoEditorController:didSaveEditedVideoToPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void VideoSaved (UIVideoEditorController editor, string editedVideoPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIVideoEditorControllerDelegate */
}
