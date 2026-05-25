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
	/// <summary>This interface represents the Objective-C protocol <c>UINavigationItemRenameDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UINavigationItemRenameDelegate", WrapperType = typeof (UINavigationItemRenameDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidEndRenaming", Selector = "navigationItem:didEndRenamingWithTitle:", ParameterType = new Type [] { typeof (UINavigationItem), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeginRenaming", Selector = "navigationItemShouldBeginRenaming:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UINavigationItem) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginRenaming", Selector = "navigationItem:willBeginRenamingWithSuggestedTitle:selectedRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UINavigationItem), typeof (string), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEndRenaming", Selector = "navigationItem:shouldEndRenamingWithTitle:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UINavigationItem), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUINavigationItemRenameDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("navigationItem:didEndRenamingWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndRenaming (UINavigationItem navigationItem, string title)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndRenaming (IUINavigationItemRenameDelegate This, UINavigationItem navigationItem, string title)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationItem:didEndRenamingWithTitle:"), navigationItem__handle__, nstitle);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
		}
		[global::Foundation.OptionalMember]
		[Export ("navigationItemShouldBeginRenaming:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginRenaming (UINavigationItem navigationItem)
		{
			return _ShouldBeginRenaming (this, navigationItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeginRenaming (IUINavigationItemRenameDelegate This, UINavigationItem navigationItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationItemShouldBeginRenaming:"), navigationItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("navigationItem:willBeginRenamingWithSuggestedTitle:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string WillBeginRenaming (UINavigationItem navigationItem, string title, NSRange selectedRange)
		{
			return _WillBeginRenaming (this, navigationItem, title, selectedRange);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _WillBeginRenaming (IUINavigationItemRenameDelegate This, UINavigationItem navigationItem, string title, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("navigationItem:willBeginRenamingWithSuggestedTitle:selectedRange:"), navigationItem__handle__, nstitle, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("navigationItem:shouldEndRenamingWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndRenaming (UINavigationItem navigationItem, string title)
		{
			return _ShouldEndRenaming (this, navigationItem, title);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEndRenaming (IUINavigationItemRenameDelegate This, UINavigationItem navigationItem, string title)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationItem:shouldEndRenamingWithTitle:"), navigationItem__handle__, nstitle);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidEndRenaming(UIKit.UINavigationItem,System.String)")]
		[DynamicDependencyAttribute ("ShouldBeginRenaming(UIKit.UINavigationItem)")]
		[DynamicDependencyAttribute ("ShouldEndRenaming(UIKit.UINavigationItem,System.String)")]
		[DynamicDependencyAttribute ("WillBeginRenaming(UIKit.UINavigationItem,System.String,Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationItemRenameDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUINavigationItemRenameDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUINavigationItemRenameDelegate" /> interface to support all the methods from the UINavigationItemRenameDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUINavigationItemRenameDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UINavigationItemRenameDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UINavigationItemRenameDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeginRenaming (this IUINavigationItemRenameDelegate This, UINavigationItem navigationItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationItemShouldBeginRenaming:"), navigationItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string WillBeginRenaming (this IUINavigationItemRenameDelegate This, UINavigationItem navigationItem, string title, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("navigationItem:willBeginRenamingWithSuggestedTitle:selectedRange:"), navigationItem__handle__, nstitle, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEndRenaming (this IUINavigationItemRenameDelegate This, UINavigationItem navigationItem, string title)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationItem:shouldEndRenamingWithTitle:"), navigationItem__handle__, nstitle);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UINavigationItemRenameDelegateWrapper : BaseWrapper, IUINavigationItemRenameDelegate {
		public UINavigationItemRenameDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationItemRenameDelegateWrapper))]
		static UINavigationItemRenameDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("navigationItem:didEndRenamingWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidEndRenaming (UINavigationItem navigationItem, string title)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationItem__handle__ = navigationItem!.GetNonNullHandle (nameof (navigationItem));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("navigationItem:didEndRenamingWithTitle:"), navigationItem__handle__, nstitle);
			GC.KeepAlive (navigationItem);
			CFString.ReleaseNative (nstitle);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUINavigationItemRenameDelegate" /> (for the protocol <c>UINavigationItemRenameDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUINavigationItemRenameDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UINavigationItemRenameDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe abstract partial class UINavigationItemRenameDelegate : NSObject, IUINavigationItemRenameDelegate {
		/// <summary>Creates a new <see cref="UINavigationItemRenameDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UINavigationItemRenameDelegate () : base (NSObjectFlag.Empty)
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
		protected UINavigationItemRenameDelegate (NSObjectFlag t) : base (t)
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
		protected internal UINavigationItemRenameDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("navigationItem:didEndRenamingWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndRenaming (UINavigationItem navigationItem, string title)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("navigationItemShouldBeginRenaming:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginRenaming (UINavigationItem navigationItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("navigationItem:shouldEndRenamingWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndRenaming (UINavigationItem navigationItem, string title)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("navigationItem:willBeginRenamingWithSuggestedTitle:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string WillBeginRenaming (UINavigationItem navigationItem, string title, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UINavigationItemRenameDelegate */
}
