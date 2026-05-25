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
namespace MediaPlayer {
	#pragma warning disable CS1573
	/// <summary>A delegate object for the <see cref="T:MediaPlayer.MPMediaPickerController" /> class. Application developers can use this deelegate to respond to events relating to media-item selection.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPickerControllerDelegate_ProtocolReference/index.html">Apple documentation for <c>MPMediaPickerControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MPMediaPickerControllerDelegate", WrapperType = typeof (MPMediaPickerControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MediaItemsPicked", Selector = "mediaPicker:didPickMediaItems:", ParameterType = new Type [] { typeof (MPMediaPickerController), typeof (MPMediaItemCollection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MediaPickerDidCancel", Selector = "mediaPickerDidCancel:", ParameterType = new Type [] { typeof (MPMediaPickerController) }, ParameterByRef = new bool [] { false })]
	public partial interface IMPMediaPickerControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="mediaItemCollection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mediaPicker:didPickMediaItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MediaItemsPicked (MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection)
		{
			_MediaItemsPicked (this, sender, mediaItemCollection);
		}
		/// <param name="sender">To be added.</param><param name="mediaItemCollection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MediaItemsPicked (IMPMediaPickerControllerDelegate This, MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var mediaItemCollection__handle__ = mediaItemCollection!.GetNonNullHandle (nameof (mediaItemCollection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mediaPicker:didPickMediaItems:"), sender__handle__, mediaItemCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (mediaItemCollection);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mediaPickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MediaPickerDidCancel (MPMediaPickerController sender)
		{
			_MediaPickerDidCancel (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MediaPickerDidCancel (IMPMediaPickerControllerDelegate This, MPMediaPickerController sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mediaPickerDidCancel:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[DynamicDependencyAttribute ("MediaItemsPicked(MediaPlayer.MPMediaPickerController,MediaPlayer.MPMediaItemCollection)")]
		[DynamicDependencyAttribute ("MediaPickerDidCancel(MediaPlayer.MPMediaPickerController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPMediaPickerControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPMediaPickerControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPMediaPickerControllerDelegate" /> interface to support all the methods from the MPMediaPickerControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPMediaPickerControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPMediaPickerControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPMediaPickerControllerDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="mediaItemCollection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaItemsPicked (this IMPMediaPickerControllerDelegate This, MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var mediaItemCollection__handle__ = mediaItemCollection!.GetNonNullHandle (nameof (mediaItemCollection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("mediaPicker:didPickMediaItems:"), sender__handle__, mediaItemCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (mediaItemCollection);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MediaPickerDidCancel (this IMPMediaPickerControllerDelegate This, MPMediaPickerController sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("mediaPickerDidCancel:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPMediaPickerControllerDelegateWrapper : BaseWrapper, IMPMediaPickerControllerDelegate {
		public MPMediaPickerControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPMediaPickerControllerDelegateWrapper))]
		static MPMediaPickerControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace MediaPlayer {
	/// <summary>A delegate object for the <see cref="T:MediaPlayer.MPMediaPickerController" /> class. Application developers can use this deelegate to respond to events relating to media-item selection.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPMediaPickerControllerDelegate_ProtocolReference/index.html">Apple documentation for <c>MPMediaPickerControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__MediaPlayer_MPMediaPickerControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class MPMediaPickerControllerDelegate : NSObject, IMPMediaPickerControllerDelegate {
		/// <summary>Creates a new <see cref="MPMediaPickerControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPMediaPickerControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected MPMediaPickerControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal MPMediaPickerControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="mediaItemCollection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("mediaPicker:didPickMediaItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MediaItemsPicked (MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("mediaPickerDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MediaPickerDidCancel (MPMediaPickerController sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MPMediaPickerControllerDelegate */
}
