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
	/// <summary>Allows accessibility hint and label to be set in a picker view.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPickerViewAccessibilityDelegate_Protocol/index.html">Apple documentation for <c>UIPickerViewAccessibilityDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPickerViewAccessibilityDelegate", WrapperType = typeof (UIPickerViewAccessibilityDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLabel", Selector = "pickerView:accessibilityLabelForComponent:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityHint", Selector = "pickerView:accessibilityHintForComponent:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedLabel", Selector = "pickerView:accessibilityAttributedLabelForComponent:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedHint", Selector = "pickerView:accessibilityAttributedHintForComponent:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityUserInputLabels", Selector = "pickerView:accessibilityUserInputLabelsForComponent:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedUserInputLabels", Selector = "pickerView:accessibilityAttributedUserInputLabelsForComponent:", ReturnType = typeof (NSAttributedString[]), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIPickerViewAccessibilityDelegate : INativeObject, IDisposable, 
		UIKit.IUIPickerViewDelegate
	{
		/// <param name="pickerView">To be added.</param><param name="acessibilityLabelForComponent">To be added.</param><summary>Returns the accessibility label for a component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityLabelForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityLabel (UIPickerView pickerView, nint acessibilityLabelForComponent)
		{
			return _GetAccessibilityLabel (this, pickerView, acessibilityLabelForComponent);
		}
		/// <param name="pickerView">To be added.</param><param name="acessibilityLabelForComponent">To be added.</param><summary>Returns the accessibility label for a component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityLabel (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint acessibilityLabelForComponent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityLabelForComponent:"), pickerView__handle__, acessibilityLabelForComponent), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>Gets a hint that describes the result of an action on <c>this</c> <see cref="T:UIKit.UIPickerViewAccessibilityDelegate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityHintForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityHint (UIPickerView pickerView, nint component)
		{
			return _GetAccessibilityHint (this, pickerView, component);
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>Gets a hint that describes the result of an action on <c>this</c> <see cref="T:UIKit.UIPickerViewAccessibilityDelegate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityHint (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityHintForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityAttributedLabelForComponent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedLabel (UIPickerView pickerView, nint component)
		{
			return _GetAccessibilityAttributedLabel (this, pickerView, component);
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedLabel (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedLabelForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityAttributedHintForComponent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedHint (UIPickerView pickerView, nint component)
		{
			return _GetAccessibilityAttributedHint (this, pickerView, component);
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedHint (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedHintForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityUserInputLabelsForComponent:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetAccessibilityUserInputLabels (UIPickerView pickerView, nint component)
		{
			return _GetAccessibilityUserInputLabels (this, pickerView, component);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetAccessibilityUserInputLabels (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityUserInputLabelsForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pickerView:accessibilityAttributedUserInputLabelsForComponent:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString[] GetAccessibilityAttributedUserInputLabels (UIPickerView pickerView, nint component)
		{
			return _GetAccessibilityAttributedUserInputLabels (this, pickerView, component);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString[] _GetAccessibilityAttributedUserInputLabels (IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString[]? ret;
			ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedUserInputLabelsForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAccessibilityAttributedHint(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityAttributedLabel(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityAttributedUserInputLabels(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityHint(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityLabel(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityUserInputLabels(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewAccessibilityDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPickerViewAccessibilityDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPickerViewAccessibilityDelegate" /> interface to support all the methods from the UIPickerViewAccessibilityDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPickerViewAccessibilityDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPickerViewAccessibilityDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPickerViewAccessibilityDelegate_Extensions {
		/// <param name="pickerView">To be added.</param><param name="acessibilityLabelForComponent">To be added.</param><summary>Returns the accessibility label for a component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetAccessibilityLabel (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint acessibilityLabelForComponent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityLabelForComponent:"), pickerView__handle__, acessibilityLabelForComponent), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>Gets a hint that describes the result of an action on <c>this</c> <see cref="T:UIKit.UIPickerViewAccessibilityDelegate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetAccessibilityHint (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityHintForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString? GetAccessibilityAttributedLabel (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedLabelForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString? GetAccessibilityAttributedHint (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedHintForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetAccessibilityUserInputLabels (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityUserInputLabelsForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString[] GetAccessibilityAttributedUserInputLabels (this IUIPickerViewAccessibilityDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString[]? ret;
			ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:accessibilityAttributedUserInputLabelsForComponent:"), pickerView__handle__, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPickerViewAccessibilityDelegateWrapper : BaseWrapper, IUIPickerViewAccessibilityDelegate {
		public UIPickerViewAccessibilityDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewAccessibilityDelegateWrapper))]
		static UIPickerViewAccessibilityDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Allows accessibility hint and label to be set in a picker view.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPickerViewAccessibilityDelegate_Protocol/index.html">Apple documentation for <c>UIPickerViewAccessibilityDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPickerViewAccessibilityDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPickerViewAccessibilityDelegate : UIPickerViewDelegate, IUIPickerViewAccessibilityDelegate {
		/// <summary>Creates a new <see cref="UIPickerViewAccessibilityDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPickerViewAccessibilityDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPickerViewAccessibilityDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPickerViewAccessibilityDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:accessibilityAttributedHintForComponent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedHint (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:accessibilityAttributedLabelForComponent:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedLabel (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pickerView:accessibilityAttributedUserInputLabelsForComponent:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString[] GetAccessibilityAttributedUserInputLabels (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>Gets a hint that describes the result of an action on <c>this</c> <see cref="T:UIKit.UIPickerViewAccessibilityDelegate" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:accessibilityHintForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityHint (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="acessibilityLabelForComponent">To be added.</param><summary>Returns the accessibility label for a component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:accessibilityLabelForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityLabel (UIPickerView pickerView, nint acessibilityLabelForComponent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pickerView:accessibilityUserInputLabelsForComponent:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetAccessibilityUserInputLabels (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPickerViewAccessibilityDelegate */
}
