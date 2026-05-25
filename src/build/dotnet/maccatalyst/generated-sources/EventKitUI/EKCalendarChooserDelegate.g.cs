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
namespace EventKitUI {
	#pragma warning disable CS1573
	/// <summary>A delegate object that provides the application developer fine-grained control over events relating to the lifecycle of a <see cref="T:EventKitUI.EKCalendarChooser" /> object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKCalendarChooserDelegateProtocolRef/index.html">Apple documentation for <c>EKCalendarChooserDelegate</c></related>
	[Protocol (Name = "EKCalendarChooserDelegate", WrapperType = typeof (EKCalendarChooserDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionChanged", Selector = "calendarChooserSelectionDidChange:", ParameterType = new Type [] { typeof (EventKitUI.EKCalendarChooser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "calendarChooserDidFinish:", ParameterType = new Type [] { typeof (EventKitUI.EKCalendarChooser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Cancelled", Selector = "calendarChooserDidCancel:", ParameterType = new Type [] { typeof (EventKitUI.EKCalendarChooser) }, ParameterByRef = new bool [] { false })]
	public partial interface IEKCalendarChooserDelegate : INativeObject, IDisposable
	{
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("calendarChooserSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionChanged (EKCalendarChooser calendarChooser)
		{
			_SelectionChanged (this, calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionChanged (IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserSelectionDidChange:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("calendarChooserDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (EKCalendarChooser calendarChooser)
		{
			_Finished (this, calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserDidFinish:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("calendarChooserDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancelled (EKCalendarChooser calendarChooser)
		{
			_Cancelled (this, calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Cancelled (IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserDidCancel:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
		[DynamicDependencyAttribute ("Cancelled(EventKitUI.EKCalendarChooser)")]
		[DynamicDependencyAttribute ("Finished(EventKitUI.EKCalendarChooser)")]
		[DynamicDependencyAttribute ("SelectionChanged(EventKitUI.EKCalendarChooser)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EKCalendarChooserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IEKCalendarChooserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IEKCalendarChooserDelegate" /> interface to support all the methods from the EKCalendarChooserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IEKCalendarChooserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original EKCalendarChooserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class EKCalendarChooserDelegate_Extensions {
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionChanged (this IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserSelectionDidChange:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserDidFinish:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Cancelled (this IEKCalendarChooserDelegate This, EKCalendarChooser calendarChooser)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var calendarChooser__handle__ = calendarChooser!.GetNonNullHandle (nameof (calendarChooser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("calendarChooserDidCancel:"), calendarChooser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (calendarChooser);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class EKCalendarChooserDelegateWrapper : BaseWrapper, IEKCalendarChooserDelegate {
		public EKCalendarChooserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EKCalendarChooserDelegateWrapper))]
		static EKCalendarChooserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace EventKitUI {
	/// <summary>A delegate object that provides the application developer fine-grained control over events relating to the lifecycle of a <see cref="T:EventKitUI.EKCalendarChooser" /> object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKCalendarChooserDelegateProtocolRef/index.html">Apple documentation for <c>EKCalendarChooserDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__EventKitUI_EKCalendarChooserDelegate", false)]
	[Model]
	public unsafe partial class EKCalendarChooserDelegate : NSObject, IEKCalendarChooserDelegate {
		/// <summary>Creates a new <see cref="EKCalendarChooserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EKCalendarChooserDelegate () : base (NSObjectFlag.Empty)
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
		protected EKCalendarChooserDelegate (NSObjectFlag t) : base (t)
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
		protected internal EKCalendarChooserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("calendarChooserDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancelled (EKCalendarChooser calendarChooser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("calendarChooserDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (EKCalendarChooser calendarChooser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="calendarChooser">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("calendarChooserSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionChanged (EKCalendarChooser calendarChooser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class EKCalendarChooserDelegate */
}
