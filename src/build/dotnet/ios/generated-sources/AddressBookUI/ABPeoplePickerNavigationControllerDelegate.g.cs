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
namespace AddressBookUI {
	#pragma warning disable CS1573
	/// <summary>A delegate object that allows the application developer to have fine-grained control of events in the life-cycle of a <see cref="T:AddressBookUI.ABPeoplePickerNavigationController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AddressBookUI/Reference/ABPeoplePickerNavigationControllerDelegate_Protocol/index.html">Apple documentation for <c>ABPeoplePickerNavigationControllerDelegate</c></related>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "ABPeoplePickerNavigationControllerDelegate", WrapperType = typeof (ABPeoplePickerNavigationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinue", Selector = "peoplePickerNavigationController:shouldContinueAfterSelectingPerson:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AddressBookUI.ABPeoplePickerNavigationController), typeof (ABPerson) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinue", Selector = "peoplePickerNavigationController:shouldContinueAfterSelectingPerson:property:identifier:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AddressBookUI.ABPeoplePickerNavigationController), typeof (ABPerson), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Cancelled", Selector = "peoplePickerNavigationControllerDidCancel:", ParameterType = new Type [] { typeof (AddressBookUI.ABPeoplePickerNavigationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPerson", Selector = "peoplePickerNavigationController:didSelectPerson:", ParameterType = new Type [] { typeof (AddressBookUI.ABPeoplePickerNavigationController), typeof (ABPerson) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectPerson", Selector = "peoplePickerNavigationController:didSelectPerson:property:identifier:", ParameterType = new Type [] { typeof (AddressBookUI.ABPeoplePickerNavigationController), typeof (ABPerson), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IABPeoplePickerNavigationControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinue (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			return _ShouldContinue (this, peoplePicker, selectedPerson);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinue (IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:"), peoplePicker__handle__, selectedPerson.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
			return ret != 0;
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:property:identifier:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfProperty').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinue (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			return _ShouldContinue (this, peoplePicker, selectedPerson, propertyId, identifier);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfProperty').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinue (IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:property:identifier:"), peoplePicker__handle__, selectedPerson.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
			return ret != 0;
		}
		/// <param name="peoplePicker">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peoplePickerNavigationControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancelled (ABPeoplePickerNavigationController peoplePicker)
		{
			_Cancelled (this, peoplePicker);
		}
		/// <param name="peoplePicker">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Cancelled (IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationControllerDidCancel:"), peoplePicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peoplePickerNavigationController:didSelectPerson:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPerson (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			_DidSelectPerson (this, peoplePicker, selectedPerson);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectPerson (IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:didSelectPerson:"), peoplePicker__handle__, selectedPerson.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("peoplePickerNavigationController:didSelectPerson:property:identifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPerson (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			_DidSelectPerson (this, peoplePicker, selectedPerson, propertyId, identifier);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectPerson (IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:didSelectPerson:property:identifier:"), peoplePicker__handle__, selectedPerson.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
		}
		[DynamicDependencyAttribute ("Cancelled(AddressBookUI.ABPeoplePickerNavigationController)")]
		[DynamicDependencyAttribute ("DidSelectPerson(AddressBookUI.ABPeoplePickerNavigationController,AddressBook.ABPerson,System.Int32,System.Int32)")]
		[DynamicDependencyAttribute ("DidSelectPerson(AddressBookUI.ABPeoplePickerNavigationController,AddressBook.ABPerson)")]
		[DynamicDependencyAttribute ("ShouldContinue(AddressBookUI.ABPeoplePickerNavigationController,AddressBook.ABPerson,System.Int32,System.Int32)")]
		[DynamicDependencyAttribute ("ShouldContinue(AddressBookUI.ABPeoplePickerNavigationController,AddressBook.ABPerson)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ABPeoplePickerNavigationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IABPeoplePickerNavigationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IABPeoplePickerNavigationControllerDelegate" /> interface to support all the methods from the ABPeoplePickerNavigationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IABPeoplePickerNavigationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ABPeoplePickerNavigationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ABPeoplePickerNavigationControllerDelegate_Extensions {
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinue (this IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:"), peoplePicker__handle__, selectedPerson.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
			return ret != 0;
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfProperty').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinue (this IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:property:identifier:"), peoplePicker__handle__, selectedPerson.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
			return ret != 0;
		}
		/// <param name="peoplePicker">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Cancelled (this IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationControllerDidCancel:"), peoplePicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectPerson (this IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:didSelectPerson:"), peoplePicker__handle__, selectedPerson.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectPerson (this IABPeoplePickerNavigationControllerDelegate This, ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var peoplePicker__handle__ = peoplePicker!.GetNonNullHandle (nameof (peoplePicker));
			var selectedPerson__handle__ = selectedPerson!.GetNonNullHandle (nameof (selectedPerson));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("peoplePickerNavigationController:didSelectPerson:property:identifier:"), peoplePicker__handle__, selectedPerson.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (peoplePicker);
			GC.KeepAlive (selectedPerson);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ABPeoplePickerNavigationControllerDelegateWrapper : BaseWrapper, IABPeoplePickerNavigationControllerDelegate {
		public ABPeoplePickerNavigationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ABPeoplePickerNavigationControllerDelegateWrapper))]
		static ABPeoplePickerNavigationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AddressBookUI {
	/// <summary>A delegate object that allows the application developer to have fine-grained control of events in the life-cycle of a <see cref="T:AddressBookUI.ABPeoplePickerNavigationController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AddressBookUI/Reference/ABPeoplePickerNavigationControllerDelegate_Protocol/index.html">Apple documentation for <c>ABPeoplePickerNavigationControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__AddressBookUI_ABPeoplePickerNavigationControllerDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class ABPeoplePickerNavigationControllerDelegate : NSObject, IABPeoplePickerNavigationControllerDelegate {
		/// <summary>Creates a new <see cref="ABPeoplePickerNavigationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABPeoplePickerNavigationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected ABPeoplePickerNavigationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal ABPeoplePickerNavigationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="peoplePicker">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peoplePickerNavigationControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancelled (ABPeoplePickerNavigationController peoplePicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peoplePickerNavigationController:didSelectPerson:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPerson (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("peoplePickerNavigationController:didSelectPerson:property:identifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPerson (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfPerson').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinue (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="peoplePicker">To be added.</param><param name="selectedPerson">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("peoplePickerNavigationController:shouldContinueAfterSelectingPerson:property:identifier:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidSelectPerson' instead (or 'ABPeoplePickerNavigationController.PredicateForSelectionOfProperty').")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinue (ABPeoplePickerNavigationController peoplePicker, global::AddressBook.ABPerson selectedPerson, int propertyId, int identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ABPeoplePickerNavigationControllerDelegate */
}
