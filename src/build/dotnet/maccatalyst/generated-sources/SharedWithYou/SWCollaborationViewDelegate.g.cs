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
namespace SharedWithYou {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SWCollaborationViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "SWCollaborationViewDelegate", WrapperType = typeof (SWCollaborationViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentPopover", Selector = "collaborationViewShouldPresentPopover:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SharedWithYou.SWCollaborationView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentPopover", Selector = "collaborationViewWillPresentPopover:", ParameterType = new Type [] { typeof (SharedWithYou.SWCollaborationView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissPopover", Selector = "collaborationViewDidDismissPopover:", ParameterType = new Type [] { typeof (SharedWithYou.SWCollaborationView) }, ParameterByRef = new bool [] { false })]
	public partial interface ISWCollaborationViewDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("collaborationViewShouldPresentPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentPopover (SWCollaborationView collaborationView)
		{
			return _ShouldPresentPopover (this, collaborationView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldPresentPopover (ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewShouldPresentPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("collaborationViewWillPresentPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentPopover (SWCollaborationView collaborationView)
		{
			_WillPresentPopover (this, collaborationView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentPopover (ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewWillPresentPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
		}
		[global::Foundation.OptionalMember]
		[Export ("collaborationViewDidDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPopover (SWCollaborationView collaborationView)
		{
			_DidDismissPopover (this, collaborationView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissPopover (ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewDidDismissPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
		}
		[DynamicDependencyAttribute ("DidDismissPopover(SharedWithYou.SWCollaborationView)")]
		[DynamicDependencyAttribute ("ShouldPresentPopover(SharedWithYou.SWCollaborationView)")]
		[DynamicDependencyAttribute ("WillPresentPopover(SharedWithYou.SWCollaborationView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SWCollaborationViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISWCollaborationViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISWCollaborationViewDelegate" /> interface to support all the methods from the SWCollaborationViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISWCollaborationViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SWCollaborationViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SWCollaborationViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPresentPopover (this ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewShouldPresentPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentPopover (this ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewWillPresentPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissPopover (this ISWCollaborationViewDelegate This, SWCollaborationView collaborationView)
		{
			var collaborationView__handle__ = collaborationView!.GetNonNullHandle (nameof (collaborationView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("collaborationViewDidDismissPopover:"), collaborationView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collaborationView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SWCollaborationViewDelegateWrapper : BaseWrapper, ISWCollaborationViewDelegate {
		public SWCollaborationViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SWCollaborationViewDelegateWrapper))]
		static SWCollaborationViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SharedWithYou {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISWCollaborationViewDelegate" /> (for the protocol <c>SWCollaborationViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISWCollaborationViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__SharedWithYou_SWCollaborationViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class SWCollaborationViewDelegate : NSObject, ISWCollaborationViewDelegate {
		/// <summary>Creates a new <see cref="SWCollaborationViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWCollaborationViewDelegate () : base (NSObjectFlag.Empty)
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
		protected SWCollaborationViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal SWCollaborationViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collaborationViewDidDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPopover (SWCollaborationView collaborationView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collaborationViewShouldPresentPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPresentPopover (SWCollaborationView collaborationView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collaborationViewWillPresentPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentPopover (SWCollaborationView collaborationView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SWCollaborationViewDelegate */
}
