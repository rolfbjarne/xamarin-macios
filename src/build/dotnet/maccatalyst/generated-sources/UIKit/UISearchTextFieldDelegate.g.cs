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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UISearchTextFieldDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UISearchTextFieldDelegate", WrapperType = typeof (UISearchTextFieldDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemProvider", Selector = "searchTextField:itemProviderForCopyingToken:", ReturnType = typeof (NSItemProvider), ParameterType = new Type [] { typeof (UISearchTextField), typeof (UISearchToken) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectSuggestion", Selector = "searchTextField:didSelectSuggestion:", ParameterType = new Type [] { typeof (UISearchTextField), typeof (IUISearchSuggestion) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISearchTextFieldDelegate : INativeObject, IDisposable, 
		UIKit.IUITextFieldDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("searchTextField:itemProviderForCopyingToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProvider GetItemProvider (UISearchTextField searchTextField, UISearchToken token)
		{
			return _GetItemProvider (this, searchTextField, token);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProvider _GetItemProvider (IUISearchTextFieldDelegate This, UISearchTextField searchTextField, UISearchToken token)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchTextField__handle__ = searchTextField!.GetNonNullHandle (nameof (searchTextField));
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSItemProvider? ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTextField:itemProviderForCopyingToken:"), searchTextField__handle__, token__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchTextField);
			GC.KeepAlive (token);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("searchTextField:didSelectSuggestion:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectSuggestion (UISearchTextField searchTextField, IUISearchSuggestion suggestion)
		{
			_DidSelectSuggestion (this, searchTextField, suggestion);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectSuggestion (IUISearchTextFieldDelegate This, UISearchTextField searchTextField, IUISearchSuggestion suggestion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchTextField__handle__ = searchTextField!.GetNonNullHandle (nameof (searchTextField));
			var suggestion__handle__ = suggestion!.GetNonNullHandle (nameof (suggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTextField:didSelectSuggestion:"), searchTextField__handle__, suggestion__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTextField);
			GC.KeepAlive (suggestion);
		}
		[DynamicDependencyAttribute ("DidSelectSuggestion(UIKit.UISearchTextField,UIKit.IUISearchSuggestion)")]
		[DynamicDependencyAttribute ("GetItemProvider(UIKit.UISearchTextField,UIKit.UISearchToken)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchTextFieldDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchTextFieldDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchTextFieldDelegate" /> interface to support all the methods from the UISearchTextFieldDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchTextFieldDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchTextFieldDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchTextFieldDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSItemProvider GetItemProvider (this IUISearchTextFieldDelegate This, UISearchTextField searchTextField, UISearchToken token)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchTextField__handle__ = searchTextField!.GetNonNullHandle (nameof (searchTextField));
			var token__handle__ = token!.GetNonNullHandle (nameof (token));
			NSItemProvider? ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTextField:itemProviderForCopyingToken:"), searchTextField__handle__, token__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchTextField);
			GC.KeepAlive (token);
			return ret!;
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectSuggestion (this IUISearchTextFieldDelegate This, UISearchTextField searchTextField, IUISearchSuggestion suggestion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchTextField__handle__ = searchTextField!.GetNonNullHandle (nameof (searchTextField));
			var suggestion__handle__ = suggestion!.GetNonNullHandle (nameof (suggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTextField:didSelectSuggestion:"), searchTextField__handle__, suggestion__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTextField);
			GC.KeepAlive (suggestion);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchTextFieldDelegateWrapper : BaseWrapper, IUISearchTextFieldDelegate {
		public UISearchTextFieldDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchTextFieldDelegateWrapper))]
		static UISearchTextFieldDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISearchTextFieldDelegate" /> (for the protocol <c>UISearchTextFieldDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISearchTextFieldDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UISearchTextFieldDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UISearchTextFieldDelegate : NSObject, IUISearchTextFieldDelegate, IUITextFieldDelegate {
		/// <summary>Creates a new <see cref="UISearchTextFieldDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISearchTextFieldDelegate () : base (NSObjectFlag.Empty)
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
		protected UISearchTextFieldDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISearchTextFieldDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textFieldDidChangeSelection:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("searchTextField:didSelectSuggestion:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectSuggestion (UISearchTextField searchTextField, IUISearchSuggestion suggestion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">The text field for which editing ended.</param><summary>Indicates that editing has ended in the specified text field.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidEndEditing:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">The text field for which editing ended.</param><param name="reason">The reason that editing ended.</param><summary>Indicates that editing has ended in the specified text field for the specified reason.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidEndEditing:reason:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (UITextField textField, UITextFieldDidEndEditingReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Indicates that editing has begun on the specified text field.</summary><remarks>To be added.</remarks>
		[Export ("textFieldDidBeginEditing:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:editMenuForCharactersInRange:suggestedActions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSRange range, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:editMenuForCharactersInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextField textField, NSValue[] ranges, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("searchTextField:itemProviderForCopyingToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProvider GetItemProvider (UISearchTextField searchTextField, UISearchToken token)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should begin in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldBeginEditing:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><param name="range">To be added.</param><param name="replacementString">To be added.</param><summary>Whether the specified text should be changed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSRange range, string replacementString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:shouldChangeCharactersInRanges:replacementString:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeCharacters (UITextField textField, NSValue[] ranges, string replacementString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether the specified text field's current contents should be removed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldClear:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldClear (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether editing should stop in the specified text field.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldEndEditing:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textField">To be added.</param><summary>Whether the text field should process the pressing of the return button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textFieldShouldReturn:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReturn (UITextField textField)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (UITextField textField, IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textField:willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (UITextField textField, IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISearchTextFieldDelegate */
}
