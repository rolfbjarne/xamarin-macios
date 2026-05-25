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
	/// <summary>Base class for models that provide data to a UIPickerView object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/iPhone/Reference/UIPickerViewDataSource_Protocol/index.html">Apple documentation for <c>UIPickerViewDataSource</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPickerViewDataSource", WrapperType = typeof (UIPickerViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetComponentCount", Selector = "numberOfComponentsInPickerView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UIPickerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetRowsInComponent", Selector = "pickerView:numberOfRowsInComponent:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UIPickerView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIPickerViewDataSource : INativeObject, IDisposable
	{
		/// <param name="pickerView">To be added.</param><summary>Returns the number of components.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("numberOfComponentsInPickerView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetComponentCount (UIPickerView pickerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><summary>Returns the number of components.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetComponentCount (IUIPickerViewDataSource This, UIPickerView pickerView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfComponentsInPickerView:"), pickerView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The number of rows in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pickerView:numberOfRowsInComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The number of rows in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetRowsInComponent (IUIPickerViewDataSource This, UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pickerView:numberOfRowsInComponent:"), pickerView__handle__, component);
			GC.KeepAlive (This);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetComponentCount(UIKit.UIPickerView)")]
		[DynamicDependencyAttribute ("GetRowsInComponent(UIKit.UIPickerView,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPickerViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPickerViewDataSourceWrapper : BaseWrapper, IUIPickerViewDataSource {
		public UIPickerViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPickerViewDataSourceWrapper))]
		static UIPickerViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="pickerView">To be added.</param><summary>Returns the number of components.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfComponentsInPickerView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetComponentCount (UIPickerView pickerView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfComponentsInPickerView:"), pickerView__handle__);
			GC.KeepAlive (pickerView);
			return ret!;
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The number of rows in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:numberOfRowsInComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pickerView__handle__ = pickerView!.GetNonNullHandle (nameof (pickerView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("pickerView:numberOfRowsInComponent:"), pickerView__handle__, component);
			GC.KeepAlive (pickerView);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Base class for models that provide data to a UIPickerView object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/iPhone/Reference/UIPickerViewDataSource_Protocol/index.html">Apple documentation for <c>UIPickerViewDataSource</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPickerViewDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UIPickerViewDataSource : NSObject, IUIPickerViewDataSource {
		/// <summary>Creates a new <see cref="UIPickerViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIPickerViewDataSource () : base (NSObjectFlag.Empty)
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
		protected UIPickerViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal UIPickerViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pickerView">To be added.</param><summary>Returns the number of components.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfComponentsInPickerView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetComponentCount (UIPickerView pickerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pickerView">To be added.</param><param name="component">To be added.</param><summary>The number of rows in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pickerView:numberOfRowsInComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPickerViewDataSource */
}
