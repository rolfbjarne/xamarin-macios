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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:UIKit.UIDocumentMenuViewController" /> objects. Provides methods called when a document is picked or when the picking has been cancelled.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentMenuDelegate_Protocol/index.html">Apple documentation for <c>UIDocumentMenuDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'UIDocumentPickerViewController' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIDocumentPickerViewController' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIDocumentMenuDelegate", WrapperType = typeof (UIDocumentMenuDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidPickDocumentPicker", Selector = "documentMenu:didPickDocumentPicker:", ParameterType = new Type [] { typeof (UIDocumentMenuViewController), typeof (UIDocumentPickerViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "documentMenuWasCancelled:", ParameterType = new Type [] { typeof (UIDocumentMenuViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIDocumentMenuDelegate : INativeObject, IDisposable
	{
		/// <param name="documentMenu">To be added.</param><param name="documentPicker">To be added.</param><summary>The user chose a document.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("documentMenu:didPickDocumentPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentPicker (UIDocumentMenuViewController documentMenu, UIDocumentPickerViewController documentPicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="documentMenu">To be added.</param><param name="documentPicker">To be added.</param><summary>The user chose a document.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPickDocumentPicker (IUIDocumentMenuDelegate This, UIDocumentMenuViewController documentMenu, UIDocumentPickerViewController documentPicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var documentMenu__handle__ = documentMenu!.GetNonNullHandle (nameof (documentMenu));
			var documentPicker__handle__ = documentPicker!.GetNonNullHandle (nameof (documentPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("documentMenu:didPickDocumentPicker:"), documentMenu__handle__, documentPicker__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentMenu);
			GC.KeepAlive (documentPicker);
		}
		/// <param name="documentMenu">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentMenuWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (UIDocumentMenuViewController documentMenu)
		{
			_WasCancelled (this, documentMenu);
		}
		/// <param name="documentMenu">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (IUIDocumentMenuDelegate This, UIDocumentMenuViewController documentMenu)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var documentMenu__handle__ = documentMenu!.GetNonNullHandle (nameof (documentMenu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentMenuWasCancelled:"), documentMenu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentMenu);
		}
		[DynamicDependencyAttribute ("DidPickDocumentPicker(UIKit.UIDocumentMenuViewController,UIKit.UIDocumentPickerViewController)")]
		[DynamicDependencyAttribute ("WasCancelled(UIKit.UIDocumentMenuViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentMenuDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDocumentMenuDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDocumentMenuDelegate" /> interface to support all the methods from the UIDocumentMenuDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDocumentMenuDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDocumentMenuDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDocumentMenuDelegate_Extensions {
		/// <param name="documentMenu">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WasCancelled (this IUIDocumentMenuDelegate This, UIDocumentMenuViewController documentMenu)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var documentMenu__handle__ = documentMenu!.GetNonNullHandle (nameof (documentMenu));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("documentMenuWasCancelled:"), documentMenu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (documentMenu);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDocumentMenuDelegateWrapper : BaseWrapper, IUIDocumentMenuDelegate {
		public UIDocumentMenuDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDocumentMenuDelegateWrapper))]
		static UIDocumentMenuDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="documentMenu">To be added.</param><param name="documentPicker">To be added.</param><summary>The user chose a document.</summary><remarks>To be added.</remarks>
		[Export ("documentMenu:didPickDocumentPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidPickDocumentPicker (UIDocumentMenuViewController documentMenu, UIDocumentPickerViewController documentPicker)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var documentMenu__handle__ = documentMenu!.GetNonNullHandle (nameof (documentMenu));
			var documentPicker__handle__ = documentPicker!.GetNonNullHandle (nameof (documentPicker));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("documentMenu:didPickDocumentPicker:"), documentMenu__handle__, documentPicker__handle__);
			GC.KeepAlive (documentMenu);
			GC.KeepAlive (documentPicker);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for <see cref="T:UIKit.UIDocumentMenuViewController" /> objects. Provides methods called when a document is picked or when the picking has been cancelled.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDocumentMenuDelegate_Protocol/index.html">Apple documentation for <c>UIDocumentMenuDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIDocumentMenuDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'UIDocumentPickerViewController' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIDocumentPickerViewController' instead.")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UIDocumentMenuDelegate : NSObject, IUIDocumentMenuDelegate {
		/// <summary>Creates a new <see cref="UIDocumentMenuDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIDocumentMenuDelegate () : base (NSObjectFlag.Empty)
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
		protected UIDocumentMenuDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIDocumentMenuDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="documentMenu">To be added.</param><param name="documentPicker">To be added.</param><summary>The user chose a document.</summary><remarks>To be added.</remarks>
		[Export ("documentMenu:didPickDocumentPicker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPickDocumentPicker (UIDocumentMenuViewController documentMenu, UIDocumentPickerViewController documentPicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="documentMenu">To be added.</param><summary>The user dismissed the picker.</summary><remarks>To be added.</remarks>
		[Export ("documentMenuWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (UIDocumentMenuViewController documentMenu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIDocumentMenuDelegate */
}
