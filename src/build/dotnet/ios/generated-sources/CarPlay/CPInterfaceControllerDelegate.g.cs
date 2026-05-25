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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>Default implementation of <see cref="T:CarPlay.ICPInterfaceControllerDelegate" />, the delegate object for <see cref="T:CarPlay.CPInterfaceController" /> objects.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CPInterfaceControllerDelegate", WrapperType = typeof (CPInterfaceControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TemplateWillAppear", Selector = "templateWillAppear:animated:", ParameterType = new Type [] { typeof (CarPlay.CPTemplate), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TemplateDidAppear", Selector = "templateDidAppear:animated:", ParameterType = new Type [] { typeof (CarPlay.CPTemplate), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TemplateWillDisappear", Selector = "templateWillDisappear:animated:", ParameterType = new Type [] { typeof (CarPlay.CPTemplate), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TemplateDidDisappear", Selector = "templateDidDisappear:animated:", ParameterType = new Type [] { typeof (CarPlay.CPTemplate), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICPInterfaceControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="aTemplate">The template that will appear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to appear.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("templateWillAppear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateWillAppear (CPTemplate aTemplate, bool animated)
		{
			_TemplateWillAppear (this, aTemplate, animated);
		}
		/// <param name="aTemplate">The template that will appear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to appear.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TemplateWillAppear (ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateWillAppear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that appeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template appears.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("templateDidAppear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateDidAppear (CPTemplate aTemplate, bool animated)
		{
			_TemplateDidAppear (this, aTemplate, animated);
		}
		/// <param name="aTemplate">The template that appeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template appears.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TemplateDidAppear (ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateDidAppear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that will disappear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to disappear.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("templateWillDisappear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateWillDisappear (CPTemplate aTemplate, bool animated)
		{
			_TemplateWillDisappear (this, aTemplate, animated);
		}
		/// <param name="aTemplate">The template that will disappear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to disappear.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TemplateWillDisappear (ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateWillDisappear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that disappeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template disappears.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("templateDidDisappear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateDidDisappear (CPTemplate aTemplate, bool animated)
		{
			_TemplateDidDisappear (this, aTemplate, animated);
		}
		/// <param name="aTemplate">The template that disappeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template disappears.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TemplateDidDisappear (ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateDidDisappear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		[DynamicDependencyAttribute ("TemplateDidAppear(CarPlay.CPTemplate,System.Boolean)")]
		[DynamicDependencyAttribute ("TemplateDidDisappear(CarPlay.CPTemplate,System.Boolean)")]
		[DynamicDependencyAttribute ("TemplateWillAppear(CarPlay.CPTemplate,System.Boolean)")]
		[DynamicDependencyAttribute ("TemplateWillDisappear(CarPlay.CPTemplate,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPInterfaceControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPInterfaceControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPInterfaceControllerDelegate" /> interface to support all the methods from the CPInterfaceControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPInterfaceControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPInterfaceControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPInterfaceControllerDelegate_Extensions {
		/// <param name="aTemplate">The template that will appear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to appear.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TemplateWillAppear (this ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateWillAppear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that appeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template appears.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TemplateDidAppear (this ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateDidAppear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that will disappear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to disappear.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TemplateWillDisappear (this ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateWillDisappear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
		/// <param name="aTemplate">The template that disappeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template disappears.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TemplateDidDisappear (this ICPInterfaceControllerDelegate This, CPTemplate aTemplate, bool animated)
		{
			var aTemplate__handle__ = aTemplate!.GetNonNullHandle (nameof (aTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("templateDidDisappear:animated:"), aTemplate__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (aTemplate);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPInterfaceControllerDelegateWrapper : BaseWrapper, ICPInterfaceControllerDelegate {
		public CPInterfaceControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPInterfaceControllerDelegateWrapper))]
		static CPInterfaceControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CarPlay {
	/// <summary>Default implementation of <see cref="T:CarPlay.ICPInterfaceControllerDelegate" />, the delegate object for <see cref="T:CarPlay.CPInterfaceController" /> objects.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPInterfaceControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class CPInterfaceControllerDelegate : NSObject, ICPInterfaceControllerDelegate {
		/// <summary>Creates a new <see cref="CPInterfaceControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CPInterfaceControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected CPInterfaceControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPInterfaceControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="aTemplate">The template that appeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template appears.</summary><remarks>To be added.</remarks>
		[Export ("templateDidAppear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateDidAppear (CPTemplate aTemplate, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aTemplate">The template that disappeared.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template disappears.</summary><remarks>To be added.</remarks>
		[Export ("templateDidDisappear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateDidDisappear (CPTemplate aTemplate, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aTemplate">The template that will appear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to appear.</summary><remarks>To be added.</remarks>
		[Export ("templateWillAppear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateWillAppear (CPTemplate aTemplate, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aTemplate">The template that will disappear.</param><param name="animated"><see langword="true" /> if the transition is automated. Otherwise, <see langword="false" />.</param><summary>Method that is called when a template is about to disappear.</summary><remarks>To be added.</remarks>
		[Export ("templateWillDisappear:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TemplateWillDisappear (CPTemplate aTemplate, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPInterfaceControllerDelegate */
}
