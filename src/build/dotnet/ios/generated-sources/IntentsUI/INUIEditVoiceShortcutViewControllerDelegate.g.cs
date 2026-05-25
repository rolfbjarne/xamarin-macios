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
namespace IntentsUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>INUIEditVoiceShortcutViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "INUIEditVoiceShortcutViewControllerDelegate", WrapperType = typeof (INUIEditVoiceShortcutViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "editVoiceShortcutViewController:didUpdateVoiceShortcut:error:", ParameterType = new Type [] { typeof (IntentsUI.INUIEditVoiceShortcutViewController), typeof (Intents.INVoiceShortcut), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDelete", Selector = "editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:", ParameterType = new Type [] { typeof (IntentsUI.INUIEditVoiceShortcutViewController), typeof (NSUuid) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "editVoiceShortcutViewControllerDidCancel:", ParameterType = new Type [] { typeof (IntentsUI.INUIEditVoiceShortcutViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IINUIEditVoiceShortcutViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="voiceShortcut">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (INUIEditVoiceShortcutViewController controller, global::Intents.INVoiceShortcut? voiceShortcut, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="voiceShortcut">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (IINUIEditVoiceShortcutViewControllerDelegate This, INUIEditVoiceShortcutViewController controller, global::Intents.INVoiceShortcut? voiceShortcut, NSError? error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var voiceShortcut__handle__ = voiceShortcut.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:"), controller__handle__, voiceShortcut__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (voiceShortcut);
			GC.KeepAlive (error);
		}
		/// <param name="controller">To be added.</param><param name="deletedVoiceShortcutIdentifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDelete (INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="deletedVoiceShortcutIdentifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDelete (IINUIEditVoiceShortcutViewControllerDelegate This, INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var deletedVoiceShortcutIdentifier__handle__ = deletedVoiceShortcutIdentifier!.GetNonNullHandle (nameof (deletedVoiceShortcutIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:"), controller__handle__, deletedVoiceShortcutIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (deletedVoiceShortcutIdentifier);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("editVoiceShortcutViewControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (INUIEditVoiceShortcutViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancel (IINUIEditVoiceShortcutViewControllerDelegate This, INUIEditVoiceShortcutViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("editVoiceShortcutViewControllerDidCancel:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		[DynamicDependencyAttribute ("DidCancel(IntentsUI.INUIEditVoiceShortcutViewController)")]
		[DynamicDependencyAttribute ("DidDelete(IntentsUI.INUIEditVoiceShortcutViewController,Foundation.NSUuid)")]
		[DynamicDependencyAttribute ("DidUpdate(IntentsUI.INUIEditVoiceShortcutViewController,Intents.INVoiceShortcut,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIEditVoiceShortcutViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINUIEditVoiceShortcutViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INUIEditVoiceShortcutViewControllerDelegateWrapper : BaseWrapper, IINUIEditVoiceShortcutViewControllerDelegate {
		public INUIEditVoiceShortcutViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIEditVoiceShortcutViewControllerDelegateWrapper))]
		static INUIEditVoiceShortcutViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="controller">To be added.</param><param name="voiceShortcut">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdate (INUIEditVoiceShortcutViewController controller, global::Intents.INVoiceShortcut? voiceShortcut, NSError? error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var voiceShortcut__handle__ = voiceShortcut.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:"), controller__handle__, voiceShortcut__handle__, error__handle__);
			GC.KeepAlive (controller);
			GC.KeepAlive (voiceShortcut);
			GC.KeepAlive (error);
		}
		/// <param name="controller">To be added.</param><param name="deletedVoiceShortcutIdentifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDelete (INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var deletedVoiceShortcutIdentifier__handle__ = deletedVoiceShortcutIdentifier!.GetNonNullHandle (nameof (deletedVoiceShortcutIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:"), controller__handle__, deletedVoiceShortcutIdentifier__handle__);
			GC.KeepAlive (controller);
			GC.KeepAlive (deletedVoiceShortcutIdentifier);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCancel (INUIEditVoiceShortcutViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("editVoiceShortcutViewControllerDidCancel:"), controller__handle__);
			GC.KeepAlive (controller);
		}
	}
}
namespace IntentsUI {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IINUIEditVoiceShortcutViewControllerDelegate" /> (for the protocol <c>INUIEditVoiceShortcutViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IINUIEditVoiceShortcutViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__IntentsUI_INUIEditVoiceShortcutViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class INUIEditVoiceShortcutViewControllerDelegate : NSObject, IINUIEditVoiceShortcutViewControllerDelegate {
		/// <summary>Creates a new <see cref="INUIEditVoiceShortcutViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected INUIEditVoiceShortcutViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected INUIEditVoiceShortcutViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal INUIEditVoiceShortcutViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewControllerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (INUIEditVoiceShortcutViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="deletedVoiceShortcutIdentifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDelete (INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="voiceShortcut">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (INUIEditVoiceShortcutViewController controller, global::Intents.INVoiceShortcut? voiceShortcut, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class INUIEditVoiceShortcutViewControllerDelegate */
}
