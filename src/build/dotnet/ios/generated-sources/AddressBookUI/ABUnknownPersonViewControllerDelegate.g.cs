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
	/// <summary>A delegate object that allows the application developer have fine-grained control of events in the life-cycle of a <see cref="T:AddressBookUI.ABUnknownPersonViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AddressBookUI/Reference/ABUnknownPersonViewControllerDelegate_Protocol/index.html">Apple documentation for <c>ABUnknownPersonViewControllerDelegate</c></related>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "ABUnknownPersonViewControllerDelegate", WrapperType = typeof (ABUnknownPersonViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidResolveToPerson", Selector = "unknownPersonViewController:didResolveToPerson:", ParameterType = new Type [] { typeof (AddressBookUI.ABUnknownPersonViewController), typeof (ABPerson) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPerformDefaultActionForPerson", Selector = "unknownPersonViewController:shouldPerformDefaultActionForPerson:property:identifier:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AddressBookUI.ABUnknownPersonViewController), typeof (ABPerson), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IABUnknownPersonViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="unknownPersonView">To be added.</param><param name="person">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("unknownPersonViewController:didResolveToPerson:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResolveToPerson (ABUnknownPersonViewController unknownPersonView, global::AddressBook.ABPerson? person)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="unknownPersonView">To be added.</param><param name="person">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResolveToPerson (IABUnknownPersonViewControllerDelegate This, ABUnknownPersonViewController unknownPersonView, global::AddressBook.ABPerson? person)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var unknownPersonView__handle__ = unknownPersonView!.GetNonNullHandle (nameof (unknownPersonView));
			var person__handle__ = person.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unknownPersonViewController:didResolveToPerson:"), unknownPersonView__handle__, person__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unknownPersonView);
			GC.KeepAlive (person);
		}
		/// <param name="personViewController">To be added.</param><param name="person">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unknownPersonViewController:shouldPerformDefaultActionForPerson:property:identifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPerformDefaultActionForPerson (ABUnknownPersonViewController personViewController, global::AddressBook.ABPerson person, int propertyId, int identifier)
		{
			return _ShouldPerformDefaultActionForPerson (this, personViewController, person, propertyId, identifier);
		}
		/// <param name="personViewController">To be added.</param><param name="person">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPerformDefaultActionForPerson (IABUnknownPersonViewControllerDelegate This, ABUnknownPersonViewController personViewController, global::AddressBook.ABPerson person, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var personViewController__handle__ = personViewController!.GetNonNullHandle (nameof (personViewController));
			var person__handle__ = person!.GetNonNullHandle (nameof (person));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("unknownPersonViewController:shouldPerformDefaultActionForPerson:property:identifier:"), personViewController__handle__, person.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (personViewController);
			GC.KeepAlive (person);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidResolveToPerson(AddressBookUI.ABUnknownPersonViewController,AddressBook.ABPerson)")]
		[DynamicDependencyAttribute ("ShouldPerformDefaultActionForPerson(AddressBookUI.ABUnknownPersonViewController,AddressBook.ABPerson,System.Int32,System.Int32)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ABUnknownPersonViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IABUnknownPersonViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IABUnknownPersonViewControllerDelegate" /> interface to support all the methods from the ABUnknownPersonViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IABUnknownPersonViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ABUnknownPersonViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ABUnknownPersonViewControllerDelegate_Extensions {
		/// <param name="personViewController">To be added.</param><param name="person">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPerformDefaultActionForPerson (this IABUnknownPersonViewControllerDelegate This, ABUnknownPersonViewController personViewController, global::AddressBook.ABPerson person, int propertyId, int identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var personViewController__handle__ = personViewController!.GetNonNullHandle (nameof (personViewController));
			var person__handle__ = person!.GetNonNullHandle (nameof (person));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_int (This.Handle, Selector.GetHandle ("unknownPersonViewController:shouldPerformDefaultActionForPerson:property:identifier:"), personViewController__handle__, person.Handle, propertyId, identifier);
			GC.KeepAlive (This);
			GC.KeepAlive (personViewController);
			GC.KeepAlive (person);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ABUnknownPersonViewControllerDelegateWrapper : BaseWrapper, IABUnknownPersonViewControllerDelegate {
		public ABUnknownPersonViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ABUnknownPersonViewControllerDelegateWrapper))]
		static ABUnknownPersonViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="unknownPersonView">To be added.</param><param name="person">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unknownPersonViewController:didResolveToPerson:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidResolveToPerson (ABUnknownPersonViewController unknownPersonView, global::AddressBook.ABPerson? person)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var unknownPersonView__handle__ = unknownPersonView!.GetNonNullHandle (nameof (unknownPersonView));
			var person__handle__ = person.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("unknownPersonViewController:didResolveToPerson:"), unknownPersonView__handle__, person__handle__);
			GC.KeepAlive (unknownPersonView);
			GC.KeepAlive (person);
		}
	}
}
namespace AddressBookUI {
	/// <summary>A delegate object that allows the application developer have fine-grained control of events in the life-cycle of a <see cref="T:AddressBookUI.ABUnknownPersonViewController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AddressBookUI/Reference/ABUnknownPersonViewControllerDelegate_Protocol/index.html">Apple documentation for <c>ABUnknownPersonViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__AddressBookUI_ABUnknownPersonViewControllerDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class ABUnknownPersonViewControllerDelegate : NSObject, IABUnknownPersonViewControllerDelegate {
		/// <summary>Creates a new <see cref="ABUnknownPersonViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ABUnknownPersonViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected ABUnknownPersonViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal ABUnknownPersonViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="unknownPersonView">To be added.</param><param name="person">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unknownPersonViewController:didResolveToPerson:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResolveToPerson (ABUnknownPersonViewController unknownPersonView, global::AddressBook.ABPerson? person)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="personViewController">To be added.</param><param name="person">To be added.</param><param name="propertyId">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unknownPersonViewController:shouldPerformDefaultActionForPerson:property:identifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPerformDefaultActionForPerson (ABUnknownPersonViewController personViewController, global::AddressBook.ABPerson person, int propertyId, int identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ABUnknownPersonViewControllerDelegate */
}
