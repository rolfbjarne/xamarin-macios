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
namespace ContactsUI {
	#pragma warning disable CS1573
	/// <summary>Delegate object that provides methods relating to viewing or editing a contact with a <see cref="T:ContactsUI.CNContactViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ContactsUI/Reference/CNContactViewControllerDelegate_Protocol/index.html">Apple documentation for <c>CNContactViewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CNContactViewControllerDelegate", WrapperType = typeof (CNContactViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPerformDefaultAction", Selector = "contactViewController:shouldPerformDefaultActionForContactProperty:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ContactsUI.CNContactViewController), typeof (CNContactProperty) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidComplete", Selector = "contactViewController:didCompleteWithContact:", ParameterType = new Type [] { typeof (ContactsUI.CNContactViewController), typeof (CNContact) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICNContactViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="viewController">To be added.</param><param name="property">To be added.</param><summary>Return <see langword="true" /> if the default action for the property should be triggered when it is selected by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactViewController:shouldPerformDefaultActionForContactProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPerformDefaultAction (CNContactViewController viewController, global::Contacts.CNContactProperty property)
		{
			return _ShouldPerformDefaultAction (this, viewController, property);
		}
		/// <param name="viewController">To be added.</param><param name="property">To be added.</param><summary>Return <see langword="true" /> if the default action for the property should be triggered when it is selected by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPerformDefaultAction (ICNContactViewControllerDelegate This, CNContactViewController viewController, global::Contacts.CNContactProperty property)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var property__handle__ = property!.GetNonNullHandle (nameof (property));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactViewController:shouldPerformDefaultActionForContactProperty:"), viewController__handle__, property__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (property);
			return ret != 0;
		}
		/// <param name="viewController">To be added.</param><param name="contact"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called after the view is presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactViewController:didCompleteWithContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidComplete (CNContactViewController viewController, global::Contacts.CNContact? contact)
		{
			_DidComplete (this, viewController, contact);
		}
		/// <param name="viewController">To be added.</param><param name="contact"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called after the view is presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidComplete (ICNContactViewControllerDelegate This, CNContactViewController viewController, global::Contacts.CNContact? contact)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var contact__handle__ = contact.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactViewController:didCompleteWithContact:"), viewController__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (contact);
		}
		[DynamicDependencyAttribute ("DidComplete(ContactsUI.CNContactViewController,Contacts.CNContact)")]
		[DynamicDependencyAttribute ("ShouldPerformDefaultAction(ContactsUI.CNContactViewController,Contacts.CNContactProperty)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNContactViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICNContactViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICNContactViewControllerDelegate" /> interface to support all the methods from the CNContactViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICNContactViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CNContactViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CNContactViewControllerDelegate_Extensions {
		/// <param name="viewController">To be added.</param><param name="property">To be added.</param><summary>Return <see langword="true" /> if the default action for the property should be triggered when it is selected by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPerformDefaultAction (this ICNContactViewControllerDelegate This, CNContactViewController viewController, global::Contacts.CNContactProperty property)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var property__handle__ = property!.GetNonNullHandle (nameof (property));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactViewController:shouldPerformDefaultActionForContactProperty:"), viewController__handle__, property__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (property);
			return ret != 0;
		}
		/// <param name="viewController">To be added.</param><param name="contact"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called after the view is presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidComplete (this ICNContactViewControllerDelegate This, CNContactViewController viewController, global::Contacts.CNContact? contact)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var contact__handle__ = contact.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactViewController:didCompleteWithContact:"), viewController__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (contact);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CNContactViewControllerDelegateWrapper : BaseWrapper, ICNContactViewControllerDelegate {
		public CNContactViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNContactViewControllerDelegateWrapper))]
		static CNContactViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ContactsUI {
	/// <summary>Delegate object that provides methods relating to viewing or editing a contact with a <see cref="T:ContactsUI.CNContactViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ContactsUI/Reference/CNContactViewControllerDelegate_Protocol/index.html">Apple documentation for <c>CNContactViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__ContactsUI_CNContactViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class CNContactViewControllerDelegate : NSObject, ICNContactViewControllerDelegate {
		/// <summary>Creates a new <see cref="CNContactViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CNContactViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected CNContactViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CNContactViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="viewController">To be added.</param><param name="contact"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called after the view is presented.</summary><remarks>To be added.</remarks>
		[Export ("contactViewController:didCompleteWithContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidComplete (CNContactViewController viewController, global::Contacts.CNContact? contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="property">To be added.</param><summary>Return <see langword="true" /> if the default action for the property should be triggered when it is selected by the user.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contactViewController:shouldPerformDefaultActionForContactProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPerformDefaultAction (CNContactViewController viewController, global::Contacts.CNContactProperty property)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CNContactViewControllerDelegate */
}
