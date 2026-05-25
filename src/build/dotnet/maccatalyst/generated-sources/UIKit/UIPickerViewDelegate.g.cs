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
	/// <summary>Class that receives event notifications from the UIPickerView.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPickerViewDelegate_Protocol/index.html">Apple documentation for <c>UIPickerViewDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPickerViewDelegate", WrapperType = typeof (UIPickerViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRowHeight", Selector = "pickerView:rowHeightForComponent:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetComponentWidth", Selector = "pickerView:widthForComponent:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTitle", Selector = "pickerView:titleForRow:forComponent:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "pickerView:viewForRow:forComponent:reusingView:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr), typeof (IntPtr), typeof (UIView) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Selected", Selector = "pickerView:didSelectRow:inComponent:", ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAttributedTitle", Selector = "pickerView:attributedTitleForRow:forComponent:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIPickerViewDelegate : INativeObject, IDisposable
	{
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The height of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:rowHeightForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (UIPickerView pickerView, nint component)
		{
			return _GetRowHeight (this, pickerView, component);
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The height of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetRowHeight (IUIPickerViewDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:rowHeightForComponent:"), pickerView__handle__, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The width of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:widthForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetComponentWidth (UIPickerView pickerView, nint component)
		{
			return _GetComponentWidth (this, pickerView, component);
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The width of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetComponentWidth (IUIPickerViewDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:widthForComponent:"), pickerView__handle__, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>The title of the specified component in the specified row.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:titleForRow:forComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			return _GetTitle (this, pickerView, row, component);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>The title of the specified component in the specified row.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetTitle (IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:titleForRow:forComponent:"), pickerView__handle__, row, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><param name="view">A <see cref="T:UIKit.UIView" /> previously used to display this row. This argument may be <see langword="null" />.</param><summary>The <see cref="T:UIKit.UIView" /> of the specified <paramref name="component" /> in <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:viewForRow:forComponent:reusingView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetView (UIPickerView pickerView, nint row, nint component, UIView? view)
		{
			return _GetView (this, pickerView, row, component, view);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><param name="view">A <see cref="T:UIKit.UIView" /> previously used to display this row. This argument may be <see langword="null" />.</param><summary>The <see cref="T:UIKit.UIView" /> of the specified <paramref name="component" /> in <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetView (IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			var view__handle__ = view.GetHandle ();
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("pickerView:viewForRow:forComponent:reusingView:"), pickerView__handle__, row, component, view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Indicates that the user has selected a row in the component.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:didSelectRow:inComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Selected (UIPickerView pickerView, nint row, nint component)
		{
			_Selected (this, pickerView, row, component);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Indicates that the user has selected a row in the component.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Selected (IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:didSelectRow:inComponent:"), pickerView__handle__, row, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Returns an attributed string that represents the title for the specified row of the specified component of <paramref name="pickerView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pickerView:attributedTitleForRow:forComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedTitle (UIPickerView pickerView, nint row, nint component)
		{
			return _GetAttributedTitle (this, pickerView, row, component);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Returns an attributed string that represents the title for the specified row of the specified component of <paramref name="pickerView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _GetAttributedTitle (IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:attributedTitleForRow:forComponent:"), pickerView__handle__, row, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAttributedTitle(UIKit.UIPickerView,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetComponentWidth(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetRowHeight(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetTitle(UIKit.UIPickerView,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetView(UIKit.UIPickerView,System.IntPtr,System.IntPtr,UIKit.UIView)")]
		[DynamicDependencyAttribute ("Selected(UIKit.UIPickerView,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPickerViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPickerViewDelegate" /> interface to support all the methods from the UIPickerViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPickerViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPickerViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPickerViewDelegate_Extensions {
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The height of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetRowHeight (this IUIPickerViewDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:rowHeightForComponent:"), pickerView__handle__, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The width of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetComponentWidth (this IUIPickerViewDelegate This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:widthForComponent:"), pickerView__handle__, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>The title of the specified component in the specified row.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetTitle (this IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:titleForRow:forComponent:"), pickerView__handle__, row, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><param name="view">A <see cref="T:UIKit.UIView" /> previously used to display this row. This argument may be <see langword="null" />.</param><summary>The <see cref="T:UIKit.UIView" /> of the specified <paramref name="component" /> in <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView GetView (this IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component, UIView? view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			var view__handle__ = view.GetHandle ();
			UIView? ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("pickerView:viewForRow:forComponent:reusingView:"), pickerView__handle__, row, component, view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Indicates that the user has selected a row in the component.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Selected (this IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:didSelectRow:inComponent:"), pickerView__handle__, row, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Returns an attributed string that represents the title for the specified row of the specified component of <paramref name="pickerView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString GetAttributedTitle (this IUIPickerViewDelegate This, UIPickerView pickerView, nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pickerView:attributedTitleForRow:forComponent:"), pickerView__handle__, row, component), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPickerViewDelegateWrapper : BaseWrapper, IUIPickerViewDelegate {
		public UIPickerViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewDelegateWrapper))]
		static UIPickerViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Class that receives event notifications from the UIPickerView.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPickerViewDelegate_Protocol/index.html">Apple documentation for <c>UIPickerViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPickerViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPickerViewDelegate : NSObject, IUIPickerViewDelegate {
		/// <summary>Creates a new <see cref="UIPickerViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPickerViewDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPickerViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPickerViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Returns an attributed string that represents the title for the specified row of the specified component of <paramref name="pickerView" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:attributedTitleForRow:forComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedTitle (UIPickerView pickerView, nint row, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The width of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:widthForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetComponentWidth (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The height of the component at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:rowHeightForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetRowHeight (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>The title of the specified component in the specified row.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:titleForRow:forComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><param name="view">A <see cref="T:UIKit.UIView" /> previously used to display this row. This argument may be <see langword="null" />.</param><summary>The <see cref="T:UIKit.UIView" /> of the specified <paramref name="component" /> in <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:viewForRow:forComponent:reusingView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetView (UIPickerView pickerView, nint row, nint component, UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="row">To be added.</param><param name="component">To be added.</param><summary>Indicates that the user has selected a row in the component.</summary><remarks>To be added.</remarks>
		[Export ("pickerView:didSelectRow:inComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Selected (UIPickerView pickerView, nint row, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPickerViewDelegate */
}
