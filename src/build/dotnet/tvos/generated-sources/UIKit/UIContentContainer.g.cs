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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIContentContainer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIContentContainer", WrapperType = typeof (UIContentContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreferredContentSizeDidChangeForChildContentContainer", Selector = "preferredContentSizeDidChangeForChildContentContainer:", ParameterType = new Type [] { typeof (IUIContentContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SystemLayoutFittingSizeDidChangeForChildContentContainer", Selector = "systemLayoutFittingSizeDidChangeForChildContentContainer:", ParameterType = new Type [] { typeof (IUIContentContainer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSizeForChildContentContainer", Selector = "sizeForChildContentContainer:withParentContainerSize:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (IUIContentContainer), typeof (CGSize) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ViewWillTransitionToSize", Selector = "viewWillTransitionToSize:withTransitionCoordinator:", ParameterType = new Type [] { typeof (CGSize), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillTransitionToTraitCollection", Selector = "willTransitionToTraitCollection:withTransitionCoordinator:", ParameterType = new Type [] { typeof (UITraitCollection), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreferredContentSize", Selector = "preferredContentSize", PropertyType = typeof (CGSize), GetterSelector = "preferredContentSize", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIContentContainer : INativeObject, IDisposable
	{
		/// <param name="container">The child .</param><summary>Notifies this controller that the preferred size for content for a specified child container has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PreferredContentSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="container">The child .</param><summary>Notifies this controller that the preferred size for content for a specified child container has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PreferredContentSizeDidChangeForChildContentContainer (IUIContentContainer This, IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredContentSizeDidChangeForChildContentContainer:"), container__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (container);
		}
		/// <param name="container">The child .</param><summary>Notifies this container that auto layout resized a specified child container.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("systemLayoutFittingSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SystemLayoutFittingSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="container">The child .</param><summary>Notifies this container that auto layout resized a specified child container.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SystemLayoutFittingSizeDidChangeForChildContentContainer (IUIContentContainer This, IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("systemLayoutFittingSizeDidChangeForChildContentContainer:"), container__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (container);
		}
		/// <param name="contentContainer">The child container whose size is being request.</param><param name="parentContainerSize">The  of the .</param><summary>Gets the size of the content of the specified child <see cref="T:UIKit.IUIContentContainer" /> by using the size of the parent container.</summary><returns>The <see cref="T:CoreGraphics.CGSize" /> of the content of the <paramref name="contentContainer" />.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("sizeForChildContentContainer:withParentContainerSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSizeForChildContentContainer (IUIContentContainer contentContainer, CGSize parentContainerSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contentContainer">The child container whose size is being request.</param><param name="parentContainerSize">The  of the .</param><summary>Gets the size of the content of the specified child <see cref="T:UIKit.IUIContentContainer" /> by using the size of the parent container.</summary><returns>The <see cref="T:CoreGraphics.CGSize" /> of the content of the <paramref name="contentContainer" />.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetSizeForChildContentContainer (IUIContentContainer This, IUIContentContainer contentContainer, CGSize parentContainerSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var contentContainer__handle__ = contentContainer!.GetNonNullHandle (nameof (contentContainer));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("sizeForChildContentContainer:withParentContainerSize:"), contentContainer__handle__, parentContainerSize);
			GC.KeepAlive (This);
			GC.KeepAlive (contentContainer);
			return ret!;
		}
		/// <param name="toSize">To be added.</param><param name="coordinator">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillTransitionToSize (CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="toSize">To be added.</param><param name="coordinator">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ViewWillTransitionToSize (IUIContentContainer This, CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (This.Handle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), toSize, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
		}
		/// <param name="traitCollection">The new trait collection.</param><param name="coordinator">The  coordinating the transition.This parameter can be .</param><summary>Notifies <c>this</c> that its trait collection will change to <paramref name="traitCollection" />, as coordinated by <paramref name="coordinator" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransitionToTraitCollection (UITraitCollection traitCollection, IUIViewControllerTransitionCoordinator? coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="traitCollection">The new trait collection.</param><param name="coordinator">The  coordinating the transition.This parameter can be .</param><summary>Notifies <c>this</c> that its trait collection will change to <paramref name="traitCollection" />, as coordinated by <paramref name="coordinator" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTransitionToTraitCollection (IUIContentContainer This, UITraitCollection traitCollection, IUIViewControllerTransitionCoordinator? coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var traitCollection__handle__ = traitCollection!.GetNonNullHandle (nameof (traitCollection));
			var coordinator__handle__ = coordinator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willTransitionToTraitCollection:withTransitionCoordinator:"), traitCollection__handle__, coordinator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (traitCollection);
			GC.KeepAlive (coordinator);
		}
		[DynamicDependencyAttribute ("GetSizeForChildContentContainer(UIKit.IUIContentContainer,CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("PreferredContentSize")]
		[DynamicDependencyAttribute ("PreferredContentSizeDidChangeForChildContentContainer(UIKit.IUIContentContainer)")]
		[DynamicDependencyAttribute ("SystemLayoutFittingSizeDidChangeForChildContentContainer(UIKit.IUIContentContainer)")]
		[DynamicDependencyAttribute ("ViewWillTransitionToSize(CoreGraphics.CGSize,UIKit.IUIViewControllerTransitionCoordinator)")]
		[DynamicDependencyAttribute ("WillTransitionToTraitCollection(UIKit.UITraitCollection,UIKit.IUIViewControllerTransitionCoordinator)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIContentContainer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the preferred size for the content of the container.</summary><value>The preferred <see cref="T:CoreGraphics.CGSize" /> of the contents of <c>this</c> <see cref="T:UIKit.IUIContentContainer" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGSize PreferredContentSize {
			[Export ("preferredContentSize")]
			get {
				return _GetPreferredContentSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetPreferredContentSize (IUIContentContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("preferredContentSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIContentContainerWrapper : BaseWrapper, IUIContentContainer {
		public UIContentContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentContainerWrapper))]
		static UIContentContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="container">The child .</param><summary>Notifies this controller that the preferred size for content for a specified child container has changed.</summary><remarks>To be added.</remarks>
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PreferredContentSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("preferredContentSizeDidChangeForChildContentContainer:"), container__handle__);
			GC.KeepAlive (container);
		}
		/// <param name="container">The child .</param><summary>Notifies this container that auto layout resized a specified child container.</summary><remarks>To be added.</remarks>
		[Export ("systemLayoutFittingSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SystemLayoutFittingSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("systemLayoutFittingSizeDidChangeForChildContentContainer:"), container__handle__);
			GC.KeepAlive (container);
		}
		/// <param name="contentContainer">The child container whose size is being request.</param><param name="parentContainerSize">The  of the .</param><summary>Gets the size of the content of the specified child <see cref="T:UIKit.IUIContentContainer" /> by using the size of the parent container.</summary><returns>The <see cref="T:CoreGraphics.CGSize" /> of the content of the <paramref name="contentContainer" />.</returns><remarks>To be added.</remarks>
		[Export ("sizeForChildContentContainer:withParentContainerSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize GetSizeForChildContentContainer (IUIContentContainer contentContainer, CGSize parentContainerSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var contentContainer__handle__ = contentContainer!.GetNonNullHandle (nameof (contentContainer));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_CGSize (this.Handle, Selector.GetHandle ("sizeForChildContentContainer:withParentContainerSize:"), contentContainer__handle__, parentContainerSize);
			GC.KeepAlive (contentContainer);
			return ret!;
		}
		/// <param name="toSize">To be added.</param><param name="coordinator">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ViewWillTransitionToSize (CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (this.Handle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), toSize, coordinator__handle__);
			GC.KeepAlive (coordinator);
		}
		/// <param name="traitCollection">The new trait collection.</param><param name="coordinator">The  coordinating the transition.This parameter can be .</param><summary>Notifies <c>this</c> that its trait collection will change to <paramref name="traitCollection" />, as coordinated by <paramref name="coordinator" />.</summary><remarks>To be added.</remarks>
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillTransitionToTraitCollection (UITraitCollection traitCollection, IUIViewControllerTransitionCoordinator? coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var traitCollection__handle__ = traitCollection!.GetNonNullHandle (nameof (traitCollection));
			var coordinator__handle__ = coordinator.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("willTransitionToTraitCollection:withTransitionCoordinator:"), traitCollection__handle__, coordinator__handle__);
			GC.KeepAlive (traitCollection);
			GC.KeepAlive (coordinator);
		}
		/// <summary>Gets the preferred size for the content of the container.</summary><value>The preferred <see cref="T:CoreGraphics.CGSize" /> of the contents of <c>this</c> <see cref="T:UIKit.IUIContentContainer" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize PreferredContentSize {
			[Export ("preferredContentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSize"));
				return ret;
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIContentContainer" /> (for the protocol <c>UIContentContainer</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIContentContainer" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIContentContainer", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIContentContainer : NSObject, IUIContentContainer {
		/// <summary>Creates a new <see cref="UIContentContainer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIContentContainer () : base (NSObjectFlag.Empty)
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
		protected UIContentContainer (NSObjectFlag t) : base (t)
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
		protected internal UIContentContainer (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="contentContainer">The child container whose size is being request.</param><param name="parentContainerSize">The  of the .</param><summary>Gets the size of the content of the specified child <see cref="T:UIKit.IUIContentContainer" /> by using the size of the parent container.</summary><returns>The <see cref="T:CoreGraphics.CGSize" /> of the content of the <paramref name="contentContainer" />.</returns><remarks>To be added.</remarks>
		[Export ("sizeForChildContentContainer:withParentContainerSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSizeForChildContentContainer (IUIContentContainer contentContainer, CGSize parentContainerSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="container">The child .</param><summary>Notifies this controller that the preferred size for content for a specified child container has changed.</summary><remarks>To be added.</remarks>
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PreferredContentSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="container">The child .</param><summary>Notifies this container that auto layout resized a specified child container.</summary><remarks>To be added.</remarks>
		[Export ("systemLayoutFittingSizeDidChangeForChildContentContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SystemLayoutFittingSizeDidChangeForChildContentContainer (IUIContentContainer container)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="toSize">To be added.</param><param name="coordinator">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillTransitionToSize (CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="traitCollection">The new trait collection.</param><param name="coordinator">The  coordinating the transition.This parameter can be .</param><summary>Notifies <c>this</c> that its trait collection will change to <paramref name="traitCollection" />, as coordinated by <paramref name="coordinator" />.</summary><remarks>To be added.</remarks>
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransitionToTraitCollection (UITraitCollection traitCollection, IUIViewControllerTransitionCoordinator? coordinator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the preferred size for the content of the container.</summary><value>The preferred <see cref="T:CoreGraphics.CGSize" /> of the contents of <c>this</c> <see cref="T:UIKit.IUIContentContainer" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize PreferredContentSize {
			[Export ("preferredContentSize")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIContentContainer */
}
