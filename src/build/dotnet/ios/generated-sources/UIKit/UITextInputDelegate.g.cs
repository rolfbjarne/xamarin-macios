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
	/// <summary>A delegate representing input events in a <see cref="T:UIKit.UITextField" /> or <see cref="T:UIKit.UITextView" />.</summary><remarks>To be added.</remarks><related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/SimpleTextInput/">SimpleTextInput</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITextInputDelegate_Protocol/index.html">Apple documentation for <c>UITextInputDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextInputDelegate", WrapperType = typeof (UITextInputDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectionWillChange", Selector = "selectionWillChange:", ParameterType = new Type [] { typeof (IUITextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "selectionDidChange:", ParameterType = new Type [] { typeof (IUITextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TextWillChange", Selector = "textWillChange:", ParameterType = new Type [] { typeof (IUITextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TextDidChange", Selector = "textDidChange:", ParameterType = new Type [] { typeof (IUITextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConversationContextDidChange", Selector = "conversationContext:didChange:", ParameterType = new Type [] { typeof (UIConversationContext), typeof (IUITextInput) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITextInputDelegate : INativeObject, IDisposable
	{
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("selectionWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionWillChange (IUITextInput uiTextInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionWillChange (IUITextInputDelegate This, IUITextInput uiTextInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTextInput__handle__ = uiTextInput!.GetNonNullHandle (nameof (uiTextInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionWillChange:"), uiTextInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (uiTextInput);
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("selectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IUITextInput uiTextInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (IUITextInputDelegate This, IUITextInput uiTextInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTextInput__handle__ = uiTextInput!.GetNonNullHandle (nameof (uiTextInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionDidChange:"), uiTextInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (uiTextInput);
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("textWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextWillChange (IUITextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextWillChange (IUITextInputDelegate This, IUITextInput textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textWillChange:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextDidChange (IUITextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextDidChange (IUITextInputDelegate This, IUITextInput textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textDidChange:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[global::Foundation.RequiredMember]
		[Export ("conversationContext:didChange:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConversationContextDidChange (UIConversationContext? context, IUITextInput? textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConversationContextDidChange (IUITextInputDelegate This, UIConversationContext? context, IUITextInput? textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			var textInput__handle__ = textInput.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("conversationContext:didChange:"), context__handle__, textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
			GC.KeepAlive (textInput);
		}
		[DynamicDependencyAttribute ("ConversationContextDidChange(UIKit.UIConversationContext,UIKit.IUITextInput)")]
		[DynamicDependencyAttribute ("SelectionDidChange(UIKit.IUITextInput)")]
		[DynamicDependencyAttribute ("SelectionWillChange(UIKit.IUITextInput)")]
		[DynamicDependencyAttribute ("TextDidChange(UIKit.IUITextInput)")]
		[DynamicDependencyAttribute ("TextWillChange(UIKit.IUITextInput)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextInputDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextInputDelegateWrapper : BaseWrapper, IUITextInputDelegate {
		public UITextInputDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputDelegateWrapper))]
		static UITextInputDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("selectionWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectionWillChange (IUITextInput uiTextInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTextInput__handle__ = uiTextInput!.GetNonNullHandle (nameof (uiTextInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionWillChange:"), uiTextInput__handle__);
			GC.KeepAlive (uiTextInput);
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> changed.</summary><remarks>To be added.</remarks>
		[Export ("selectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectionDidChange (IUITextInput uiTextInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var uiTextInput__handle__ = uiTextInput!.GetNonNullHandle (nameof (uiTextInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionDidChange:"), uiTextInput__handle__);
			GC.KeepAlive (uiTextInput);
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("textWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TextWillChange (IUITextInput textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textWillChange:"), textInput__handle__);
			GC.KeepAlive (textInput);
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> changed.</summary><remarks>To be added.</remarks>
		[Export ("textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TextDidChange (IUITextInput textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textDidChange:"), textInput__handle__);
			GC.KeepAlive (textInput);
		}
		[Export ("conversationContext:didChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConversationContextDidChange (UIConversationContext? context, IUITextInput? textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			var textInput__handle__ = textInput.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("conversationContext:didChange:"), context__handle__, textInput__handle__);
			GC.KeepAlive (context);
			GC.KeepAlive (textInput);
		}
	}
}
namespace UIKit {
	/// <summary>A delegate representing input events in a <see cref="T:UIKit.UITextField" /> or <see cref="T:UIKit.UITextView" />.</summary><remarks>To be added.</remarks><related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/SimpleTextInput/">SimpleTextInput</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UITextInputDelegate_Protocol/index.html">Apple documentation for <c>UITextInputDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UITextInputDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UITextInputDelegate : NSObject, IUITextInputDelegate {
		/// <summary>Creates a new <see cref="UITextInputDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITextInputDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextInputDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextInputDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("conversationContext:didChange:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConversationContextDidChange (UIConversationContext? context, IUITextInput? textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> changed.</summary><remarks>To be added.</remarks>
		[Export ("selectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IUITextInput uiTextInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="uiTextInput">To be added.</param><summary>The selection in <paramref name="uiTextInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("selectionWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionWillChange (IUITextInput uiTextInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> changed.</summary><remarks>To be added.</remarks>
		[Export ("textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextDidChange (IUITextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textInput">To be added.</param><summary>The text in <paramref name="textInput" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("textWillChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextWillChange (IUITextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextInputDelegate */
}
