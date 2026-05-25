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
namespace ReplayKit {
	#pragma warning disable CS1573
	/// <summary>The view controller protocol for previewing and editing a ReplayKit recording.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPPreviewViewControllerDelegate_Ref/index.html">Apple documentation for <c>RPPreviewViewControllerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "RPPreviewViewControllerDelegate", WrapperType = typeof (RPPreviewViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "previewControllerDidFinish:", ParameterType = new Type [] { typeof (ReplayKit.RPPreviewViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "previewController:didFinishWithActivityTypes:", ParameterType = new Type [] { typeof (ReplayKit.RPPreviewViewController), typeof (global::Foundation.NSSet<NSString>) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IRPPreviewViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="previewController">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPPreviewViewController previewController)
		{
			_DidFinish (this, previewController);
		}
		/// <param name="previewController">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IRPPreviewViewControllerDelegate This, RPPreviewViewController previewController)
		{
			var previewController__handle__ = previewController!.GetNonNullHandle (nameof (previewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerDidFinish:"), previewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewController);
		}
		/// <param name="previewController">To be added.</param><param name="activityTypes">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewController:didFinishWithActivityTypes:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPPreviewViewController previewController, NSSet<NSString> activityTypes)
		{
			_DidFinish (this, previewController, activityTypes);
		}
		/// <param name="previewController">To be added.</param><param name="activityTypes">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinish (IRPPreviewViewControllerDelegate This, RPPreviewViewController previewController, NSSet<NSString> activityTypes)
		{
			var previewController__handle__ = previewController!.GetNonNullHandle (nameof (previewController));
			var activityTypes__handle__ = activityTypes!.GetNonNullHandle (nameof (activityTypes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didFinishWithActivityTypes:"), previewController__handle__, activityTypes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewController);
			GC.KeepAlive (activityTypes);
		}
		[DynamicDependencyAttribute ("DidFinish(ReplayKit.RPPreviewViewController,Foundation.NSSet{Foundation.NSString})")]
		[DynamicDependencyAttribute ("DidFinish(ReplayKit.RPPreviewViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPPreviewViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IRPPreviewViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IRPPreviewViewControllerDelegate" /> interface to support all the methods from the RPPreviewViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IRPPreviewViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original RPPreviewViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class RPPreviewViewControllerDelegate_Extensions {
		/// <param name="previewController">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IRPPreviewViewControllerDelegate This, RPPreviewViewController previewController)
		{
			var previewController__handle__ = previewController!.GetNonNullHandle (nameof (previewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewControllerDidFinish:"), previewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewController);
		}
		/// <param name="previewController">To be added.</param><param name="activityTypes">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinish (this IRPPreviewViewControllerDelegate This, RPPreviewViewController previewController, NSSet<NSString> activityTypes)
		{
			var previewController__handle__ = previewController!.GetNonNullHandle (nameof (previewController));
			var activityTypes__handle__ = activityTypes!.GetNonNullHandle (nameof (activityTypes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("previewController:didFinishWithActivityTypes:"), previewController__handle__, activityTypes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewController);
			GC.KeepAlive (activityTypes);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class RPPreviewViewControllerDelegateWrapper : BaseWrapper, IRPPreviewViewControllerDelegate {
		public RPPreviewViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (RPPreviewViewControllerDelegateWrapper))]
		static RPPreviewViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace ReplayKit {
	/// <summary>The view controller protocol for previewing and editing a ReplayKit recording.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ReplayKit/Reference/RPPreviewViewControllerDelegate_Ref/index.html">Apple documentation for <c>RPPreviewViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__ReplayKit_RPPreviewViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class RPPreviewViewControllerDelegate : NSObject, IRPPreviewViewControllerDelegate {
		/// <summary>Creates a new <see cref="RPPreviewViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RPPreviewViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected RPPreviewViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal RPPreviewViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="previewController">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("previewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPPreviewViewController previewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewController">To be added.</param><param name="activityTypes">To be added.</param><summary>Method that is called when the previewer is ready to be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("previewController:didFinishWithActivityTypes:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinish (RPPreviewViewController previewController, NSSet<NSString> activityTypes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class RPPreviewViewControllerDelegate */
}
