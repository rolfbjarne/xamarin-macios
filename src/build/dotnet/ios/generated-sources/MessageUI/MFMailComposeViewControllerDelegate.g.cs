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
namespace MessageUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MFMailComposeViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "MFMailComposeViewControllerDelegate", WrapperType = typeof (MFMailComposeViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "mailComposeController:didFinishWithResult:error:", ParameterType = new Type [] { typeof (MessageUI.MFMailComposeViewController), typeof (MessageUI.MFMailComposeResult), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IMFMailComposeViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mailComposeController:didFinishWithResult:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			_Finished (this, controller, result, error);
		}
		/// <param name="controller">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (IMFMailComposeViewControllerDelegate This, MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("mailComposeController:didFinishWithResult:error:"), controller__handle__, (IntPtr) (long) result, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("Finished(MessageUI.MFMailComposeViewController,MessageUI.MFMailComposeResult,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MFMailComposeViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMFMailComposeViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMFMailComposeViewControllerDelegate" /> interface to support all the methods from the MFMailComposeViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMFMailComposeViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MFMailComposeViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MFMailComposeViewControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this IMFMailComposeViewControllerDelegate This, MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("mailComposeController:didFinishWithResult:error:"), controller__handle__, (IntPtr) (long) result, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MFMailComposeViewControllerDelegateWrapper : BaseWrapper, IMFMailComposeViewControllerDelegate {
		public MFMailComposeViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MFMailComposeViewControllerDelegateWrapper))]
		static MFMailComposeViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace MessageUI {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IMFMailComposeViewControllerDelegate" /> (for the protocol <c>MFMailComposeViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IMFMailComposeViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__MessageUI_MFMailComposeViewControllerDelegate", false)]
	[Model]
	public unsafe partial class MFMailComposeViewControllerDelegate : NSObject, IMFMailComposeViewControllerDelegate {
		/// <summary>Creates a new <see cref="MFMailComposeViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MFMailComposeViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected MFMailComposeViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal MFMailComposeViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="result">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("mailComposeController:didFinishWithResult:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MFMailComposeViewControllerDelegate */
}
