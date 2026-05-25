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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ContactsUI {
	#pragma warning disable CS1573
	/// <summary>Delegate object that provides methods relating to picking a contact from a <see cref="T:ContactsUI.CNContactPickerViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ContactsUI/Reference/CNContactPickerDelegate_Protocol/index.html">Apple documentation for <c>CNContactPickerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CNContactPickerDelegate", WrapperType = typeof (CNContactPickerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContactPickerDidCancel", Selector = "contactPickerDidCancel:", ParameterType = new Type [] { typeof (ContactsUI.CNContactPickerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectContact", Selector = "contactPicker:didSelectContact:", ParameterType = new Type [] { typeof (ContactsUI.CNContactPickerViewController), typeof (CNContact) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectContactProperty", Selector = "contactPicker:didSelectContactProperty:", ParameterType = new Type [] { typeof (ContactsUI.CNContactPickerViewController), typeof (CNContactProperty) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectContacts", Selector = "contactPicker:didSelectContacts:", ParameterType = new Type [] { typeof (ContactsUI.CNContactPickerViewController), typeof (CNContact[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectContactProperties", Selector = "contactPicker:didSelectContactProperties:", ParameterType = new Type [] { typeof (ContactsUI.CNContactPickerViewController), typeof (CNContactProperty[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICNContactPickerDelegate : INativeObject, IDisposable
	{
		/// <param name="picker">To be added.</param><summary>Called after the user selects the "Cancel" button.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactPickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContactPickerDidCancel (CNContactPickerViewController picker)
		{
			_ContactPickerDidCancel (this, picker);
		}
		/// <param name="picker">To be added.</param><summary>Called after the user selects the "Cancel" button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContactPickerDidCancel (ICNContactPickerDelegate This, CNContactPickerViewController picker)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contactPickerDidCancel:"), picker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		/// <param name="picker">To be added.</param><param name="contact">To be added.</param><summary>Called after the user selects the <paramref name="contact" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactPicker:didSelectContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContact (CNContactPickerViewController picker, global::Contacts.CNContact contact)
		{
			_DidSelectContact (this, picker, contact);
		}
		/// <param name="picker">To be added.</param><param name="contact">To be added.</param><summary>Called after the user selects the <paramref name="contact" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectContact (ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContact contact)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContact:"), picker__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (contact);
		}
		/// <param name="picker">To be added.</param><param name="contactProperty">To be added.</param><summary>Called after the user selects a property of the contact.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactPicker:didSelectContactProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContactProperty (CNContactPickerViewController picker, global::Contacts.CNContactProperty contactProperty)
		{
			_DidSelectContactProperty (this, picker, contactProperty);
		}
		/// <param name="picker">To be added.</param><param name="contactProperty">To be added.</param><summary>Called after the user selects a property of the contact.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectContactProperty (ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContactProperty contactProperty)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var contactProperty__handle__ = contactProperty!.GetNonNullHandle (nameof (contactProperty));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContactProperty:"), picker__handle__, contactProperty__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (contactProperty);
		}
		/// <param name="picker">To be added.</param><param name="contacts">To be added.</param><summary>Called after the user selects multiple contacts. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactPicker:didSelectContacts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContacts (CNContactPickerViewController picker, global::Contacts.CNContact[] contacts)
		{
			_DidSelectContacts (this, picker, contacts);
		}
		/// <param name="picker">To be added.</param><param name="contacts">To be added.</param><summary>Called after the user selects multiple contacts. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectContacts (ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContact[] contacts)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			if (contacts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contacts));
			using var nsa_contacts = NSArray.FromNSObjects (contacts);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContacts:"), picker__handle__, nsa_contacts.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		/// <param name="picker">To be added.</param><param name="contactProperties">To be added.</param><summary>Called after the user selects multiple properties. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contactPicker:didSelectContactProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContactProperties (CNContactPickerViewController picker, global::Contacts.CNContactProperty[] contactProperties)
		{
			_DidSelectContactProperties (this, picker, contactProperties);
		}
		/// <param name="picker">To be added.</param><param name="contactProperties">To be added.</param><summary>Called after the user selects multiple properties. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectContactProperties (ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContactProperty[] contactProperties)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			if (contactProperties is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contactProperties));
			using var nsa_contactProperties = NSArray.FromNSObjects (contactProperties);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContactProperties:"), picker__handle__, nsa_contactProperties.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		[DynamicDependencyAttribute ("ContactPickerDidCancel(ContactsUI.CNContactPickerViewController)")]
		[DynamicDependencyAttribute ("DidSelectContact(ContactsUI.CNContactPickerViewController,Contacts.CNContact)")]
		[DynamicDependencyAttribute ("DidSelectContactProperties(ContactsUI.CNContactPickerViewController,Contacts.CNContactProperty[])")]
		[DynamicDependencyAttribute ("DidSelectContactProperty(ContactsUI.CNContactPickerViewController,Contacts.CNContactProperty)")]
		[DynamicDependencyAttribute ("DidSelectContacts(ContactsUI.CNContactPickerViewController,Contacts.CNContact[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNContactPickerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICNContactPickerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICNContactPickerDelegate" /> interface to support all the methods from the CNContactPickerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICNContactPickerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CNContactPickerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CNContactPickerDelegate_Extensions {
		/// <param name="picker">To be added.</param><summary>Called after the user selects the "Cancel" button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContactPickerDidCancel (this ICNContactPickerDelegate This, CNContactPickerViewController picker)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contactPickerDidCancel:"), picker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		/// <param name="picker">To be added.</param><param name="contact">To be added.</param><summary>Called after the user selects the <paramref name="contact" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectContact (this ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContact contact)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContact:"), picker__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (contact);
		}
		/// <param name="picker">To be added.</param><param name="contactProperty">To be added.</param><summary>Called after the user selects a property of the contact.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectContactProperty (this ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContactProperty contactProperty)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			var contactProperty__handle__ = contactProperty!.GetNonNullHandle (nameof (contactProperty));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContactProperty:"), picker__handle__, contactProperty__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
			GC.KeepAlive (contactProperty);
		}
		/// <param name="picker">To be added.</param><param name="contacts">To be added.</param><summary>Called after the user selects multiple contacts. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectContacts (this ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContact[] contacts)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			if (contacts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contacts));
			using var nsa_contacts = NSArray.FromNSObjects (contacts);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContacts:"), picker__handle__, nsa_contacts.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
		/// <param name="picker">To be added.</param><param name="contactProperties">To be added.</param><summary>Called after the user selects multiple properties. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectContactProperties (this ICNContactPickerDelegate This, CNContactPickerViewController picker, global::Contacts.CNContactProperty[] contactProperties)
		{
			var picker__handle__ = picker!.GetNonNullHandle (nameof (picker));
			if (contactProperties is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contactProperties));
			using var nsa_contactProperties = NSArray.FromNSObjects (contactProperties);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contactPicker:didSelectContactProperties:"), picker__handle__, nsa_contactProperties.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (picker);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CNContactPickerDelegateWrapper : BaseWrapper, ICNContactPickerDelegate {
		public CNContactPickerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNContactPickerDelegateWrapper))]
		static CNContactPickerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ContactsUI {
	/// <summary>Delegate object that provides methods relating to picking a contact from a <see cref="T:ContactsUI.CNContactPickerViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ContactsUI/Reference/CNContactPickerDelegate_Protocol/index.html">Apple documentation for <c>CNContactPickerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__ContactsUI_CNContactPickerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class CNContactPickerDelegate : NSObject, ICNContactPickerDelegate {
		/// <summary>Creates a new <see cref="CNContactPickerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CNContactPickerDelegate () : base (NSObjectFlag.Empty)
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
		protected CNContactPickerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CNContactPickerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="picker">To be added.</param><summary>Called after the user selects the "Cancel" button.</summary><remarks>To be added.</remarks>
		[Export ("contactPickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContactPickerDidCancel (CNContactPickerViewController picker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="picker">To be added.</param><param name="contact">To be added.</param><summary>Called after the user selects the <paramref name="contact" />.</summary><remarks>To be added.</remarks>
		[Export ("contactPicker:didSelectContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContact (CNContactPickerViewController picker, global::Contacts.CNContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="picker">To be added.</param><param name="contactProperties">To be added.</param><summary>Called after the user selects multiple properties. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[Export ("contactPicker:didSelectContactProperties:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContactProperties (CNContactPickerViewController picker, global::Contacts.CNContactProperty[] contactProperties)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="picker">To be added.</param><param name="contactProperty">To be added.</param><summary>Called after the user selects a property of the contact.</summary><remarks>To be added.</remarks>
		[Export ("contactPicker:didSelectContactProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContactProperty (CNContactPickerViewController picker, global::Contacts.CNContactProperty contactProperty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="picker">To be added.</param><param name="contacts">To be added.</param><summary>Called after the user selects multiple contacts. Devs must override this method to configure the <see cref="T:ContactsUI.CNContactPickerViewController" /> for multiple selection.</summary><remarks>To be added.</remarks>
		[Export ("contactPicker:didSelectContacts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectContacts (CNContactPickerViewController picker, global::Contacts.CNContact[] contacts)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CNContactPickerDelegate */
}
