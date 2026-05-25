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
	/// <summary>This interface represents the Objective-C protocol <c>UIScrollViewAccessibilityDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIScrollViewAccessibilityDelegate", WrapperType = typeof (UIScrollViewAccessibilityDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityScrollStatus", Selector = "accessibilityScrollStatusForScrollView:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedScrollStatus", Selector = "accessibilityAttributedScrollStatusForScrollView:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (UIScrollView) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIScrollViewAccessibilityDelegate : INativeObject, IDisposable, 
		UIKit.IUIScrollViewDelegate
	{
		/// <param name="scrollView">To be added.</param><summary>Gets a string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityScrollStatusForScrollView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityScrollStatus (UIScrollView scrollView)
		{
			return _GetAccessibilityScrollStatus (this, scrollView);
		}
		/// <param name="scrollView">To be added.</param><summary>Gets a string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityScrollStatus (IUIScrollViewAccessibilityDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityScrollStatusForScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
		/// <param name="scrollView">The scrollview for which to get the attributed status.</param><summary>Gets an attributed string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityAttributedScrollStatusForScrollView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedScrollStatus (UIScrollView scrollView)
		{
			return _GetAccessibilityAttributedScrollStatus (this, scrollView);
		}
		/// <param name="scrollView">The scrollview for which to get the attributed status.</param><summary>Gets an attributed string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedScrollStatus (IUIScrollViewAccessibilityDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityAttributedScrollStatusForScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAccessibilityAttributedScrollStatus(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute ("GetAccessibilityScrollStatus(UIKit.UIScrollView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIScrollViewAccessibilityDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIScrollViewAccessibilityDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIScrollViewAccessibilityDelegate" /> interface to support all the methods from the UIScrollViewAccessibilityDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIScrollViewAccessibilityDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIScrollViewAccessibilityDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIScrollViewAccessibilityDelegate_Extensions {
		/// <param name="scrollView">To be added.</param><summary>Gets a string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetAccessibilityScrollStatus (this IUIScrollViewAccessibilityDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityScrollStatusForScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
		/// <param name="scrollView">The scrollview for which to get the attributed status.</param><summary>Gets an attributed string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString? GetAccessibilityAttributedScrollStatus (this IUIScrollViewAccessibilityDelegate This, UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityAttributedScrollStatusForScrollView:"), scrollView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scrollView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIScrollViewAccessibilityDelegateWrapper : BaseWrapper, IUIScrollViewAccessibilityDelegate {
		public UIScrollViewAccessibilityDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIScrollViewAccessibilityDelegateWrapper))]
		static UIScrollViewAccessibilityDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIScrollViewAccessibilityDelegate" /> (for the protocol <c>UIScrollViewAccessibilityDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIScrollViewAccessibilityDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIScrollViewAccessibilityDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIScrollViewAccessibilityDelegate : UIScrollViewDelegate, IUIScrollViewAccessibilityDelegate {
		/// <summary>Creates a new <see cref="UIScrollViewAccessibilityDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIScrollViewAccessibilityDelegate () : base (NSObjectFlag.Empty)
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
		protected UIScrollViewAccessibilityDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIScrollViewAccessibilityDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="scrollView">The scrollview for which to get the attributed status.</param><summary>Gets an attributed string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityAttributedScrollStatusForScrollView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedScrollStatus (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="scrollView">To be added.</param><summary>Gets a string that represents the current relative progress through a document or collection of documents. (For example, "Volume 34 of 51.")</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityScrollStatusForScrollView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityScrollStatus (UIScrollView scrollView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIScrollViewAccessibilityDelegate */
}
