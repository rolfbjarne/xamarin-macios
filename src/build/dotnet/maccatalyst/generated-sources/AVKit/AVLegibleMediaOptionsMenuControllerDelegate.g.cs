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
namespace AVKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVLegibleMediaOptionsMenuControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos26.4")]
	[SupportedOSPlatform ("ios26.4")]
	[SupportedOSPlatform ("maccatalyst26.4")]
	[Protocol (Name = "AVLegibleMediaOptionsMenuControllerDelegate", WrapperType = typeof (AVLegibleMediaOptionsMenuControllerDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeMenuState", Selector = "legibleMenuController:didChangeMenuState:", ParameterType = new Type [] { typeof (AVKit.AVLegibleMediaOptionsMenuController), typeof (AVKit.AVLegibleMediaOptionsMenuState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestCaptionPreviewForProfileId", Selector = "legibleMenuController:didRequestCaptionPreviewForProfileID:", ParameterType = new Type [] { typeof (AVKit.AVLegibleMediaOptionsMenuController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestStoppingSubtitleCaptionPreview", Selector = "legibleMenuControllerDidRequestStoppingSubtitleCaptionPreview:", ParameterType = new Type [] { typeof (AVKit.AVLegibleMediaOptionsMenuController) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVLegibleMediaOptionsMenuControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("legibleMenuController:didChangeMenuState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeMenuState (AVLegibleMediaOptionsMenuController menuController, AVLegibleMediaOptionsMenuState state)
		{
			_DidChangeMenuState (this, menuController, state);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeMenuState (IAVLegibleMediaOptionsMenuControllerDelegate This, AVLegibleMediaOptionsMenuController menuController, AVLegibleMediaOptionsMenuState state)
		{
			var menuController__handle__ = menuController!.GetNonNullHandle (nameof (menuController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_AVLegibleMediaOptionsMenuState (This.Handle, Selector.GetHandle ("legibleMenuController:didChangeMenuState:"), menuController__handle__, state);
			GC.KeepAlive (This);
			GC.KeepAlive (menuController);
		}
		[global::Foundation.OptionalMember]
		[Export ("legibleMenuController:didRequestCaptionPreviewForProfileID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestCaptionPreviewForProfileId (AVLegibleMediaOptionsMenuController menuController, string profileId)
		{
			_DidRequestCaptionPreviewForProfileId (this, menuController, profileId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRequestCaptionPreviewForProfileId (IAVLegibleMediaOptionsMenuControllerDelegate This, AVLegibleMediaOptionsMenuController menuController, string profileId)
		{
			var menuController__handle__ = menuController!.GetNonNullHandle (nameof (menuController));
			if (profileId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (profileId));
			var nsprofileId = CFString.CreateNative (profileId);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("legibleMenuController:didRequestCaptionPreviewForProfileID:"), menuController__handle__, nsprofileId);
			GC.KeepAlive (This);
			GC.KeepAlive (menuController);
			CFString.ReleaseNative (nsprofileId);
		}
		[global::Foundation.OptionalMember]
		[Export ("legibleMenuControllerDidRequestStoppingSubtitleCaptionPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestStoppingSubtitleCaptionPreview (AVLegibleMediaOptionsMenuController menuController)
		{
			_DidRequestStoppingSubtitleCaptionPreview (this, menuController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRequestStoppingSubtitleCaptionPreview (IAVLegibleMediaOptionsMenuControllerDelegate This, AVLegibleMediaOptionsMenuController menuController)
		{
			var menuController__handle__ = menuController!.GetNonNullHandle (nameof (menuController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("legibleMenuControllerDidRequestStoppingSubtitleCaptionPreview:"), menuController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (menuController);
		}
		[DynamicDependencyAttribute ("DidChangeMenuState(AVKit.AVLegibleMediaOptionsMenuController,AVKit.AVLegibleMediaOptionsMenuState)")]
		[DynamicDependencyAttribute ("DidRequestCaptionPreviewForProfileId(AVKit.AVLegibleMediaOptionsMenuController,System.String)")]
		[DynamicDependencyAttribute ("DidRequestStoppingSubtitleCaptionPreview(AVKit.AVLegibleMediaOptionsMenuController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVLegibleMediaOptionsMenuControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVLegibleMediaOptionsMenuControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVLegibleMediaOptionsMenuControllerDelegateWrapper : BaseWrapper, IAVLegibleMediaOptionsMenuControllerDelegate {
		public AVLegibleMediaOptionsMenuControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVLegibleMediaOptionsMenuControllerDelegateWrapper))]
		static AVLegibleMediaOptionsMenuControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVLegibleMediaOptionsMenuControllerDelegate" /> (for the protocol <c>AVLegibleMediaOptionsMenuControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVLegibleMediaOptionsMenuControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVKit_AVLegibleMediaOptionsMenuControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos26.4")]
	[SupportedOSPlatform ("ios26.4")]
	[SupportedOSPlatform ("maccatalyst26.4")]
	public unsafe partial class AVLegibleMediaOptionsMenuControllerDelegate : NSObject, IAVLegibleMediaOptionsMenuControllerDelegate {
		/// <summary>Creates a new <see cref="AVLegibleMediaOptionsMenuControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVLegibleMediaOptionsMenuControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected AVLegibleMediaOptionsMenuControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVLegibleMediaOptionsMenuControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("legibleMenuController:didChangeMenuState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeMenuState (AVLegibleMediaOptionsMenuController menuController, AVLegibleMediaOptionsMenuState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("legibleMenuController:didRequestCaptionPreviewForProfileID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestCaptionPreviewForProfileId (AVLegibleMediaOptionsMenuController menuController, string profileId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("legibleMenuControllerDidRequestStoppingSubtitleCaptionPreview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestStoppingSubtitleCaptionPreview (AVLegibleMediaOptionsMenuController menuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVLegibleMediaOptionsMenuControllerDelegate */
}
