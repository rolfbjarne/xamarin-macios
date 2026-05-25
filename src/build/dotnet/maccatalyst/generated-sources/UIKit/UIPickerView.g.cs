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
	/// <summary>A <see cref="T:UIKit.UIView" /> that displays a spinning wheel control used to select data.</summary><remarks><format type="text/html"><h2>Customizing Appearance</h2></format><para>The appearance of the <see cref="T:UIKit.UIPickerView" /> can be customized by using the <see cref="UIKit.UIPickerView.UIPickerViewAppearance" /> class or by overriding the <see cref="UIKit.UIPickerViewModel.GetView(UIKit.UIPickerView,System.IntPtr,System.IntPtr,UIKit.UIView)" /> and <see cref="UIKit.UIPickerViewModel.GetRowHeight(UIKit.UIPickerView,System.IntPtr)" /> methods in the <see cref="T:UIKit.UIPickerViewModel" />, as shown in the "Standard Controls" sample ("Picker With Custom Appearance").</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPickerView_Class/index.html">Apple documentation for <c>UIPickerView</c></related>
	[Register("UIPickerView", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPickerView : UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIPickerView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIPickerView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPickerView () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UIPickerView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected UIPickerView (NSObjectFlag t) : base (t)
		{
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
		protected internal UIPickerView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIPickerView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("tableView:cellForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCell? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITableViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITableViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("reloadAllComponents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadAllComponents ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadAllComponents"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reloadAllComponents"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="component">To be added.</param><summary>Reloads the data relating to the specified component.</summary><remarks>To be added.</remarks>
		[Export ("reloadComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadComponent (nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("reloadComponent:"), component);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("reloadComponent:"), component);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="component">To be added.</param><summary>The SizeF for rows in the component. Typically, the size required to display the largest string or view used as a row in the component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rowSizeForComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize RowSizeForComponent (nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rowSizeForComponent:"), component);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("rowSizeForComponent:"), component);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="component">To be added.</param><summary>The number of rows in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfRowsInComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInComponent (nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("numberOfRowsInComponent:"), component);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("numberOfRowsInComponent:"), component);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>Developers should use <see cref="M:UIKit.UIPickerView.RowsInComponent(System.IntPtr)" /> rather than this method.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:numberOfRowsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInSection (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="row">To be added.</param><param name="component">To be added.</param><param name="animated">To be added.</param><summary>Selects the r<paramref name="row" /> element in <paramref name="component" />.</summary><remarks>To be added.</remarks>
		[Export ("selectRow:inComponent:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Select (nint row, nint component, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("selectRow:inComponent:animated:"), row, component, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("selectRow:inComponent:animated:"), row, component, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="component">To be added.</param><summary>The selected row in the specified component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectedRowInComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedRowInComponent (nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("selectedRowInComponent:"), component);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("selectedRowInComponent:"), component);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="row">To be added.</param><param name="component">To be added.</param><summary>The UIView for the specified row and component.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForRow:forComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewFor (nint row, nint component)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("viewForRow:forComponent:"), row, component), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("viewForRow:forComponent:"), row, component), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The UIPickerViewDataSource that provides elements to this UIPickerView.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIPickerViewDataSource? DataSource {
			get {
				return (WeakDataSource as IUIPickerViewDataSource)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDataSource = rvalue;
			}
		}
		/// <summary>An instance of the UIKit.IUIPickerViewDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUIPickerViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIPickerViewDelegate Delegate {
			get {
				return (WeakDelegate as IUIPickerViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfComponents {
			[Export ("numberOfComponents")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfComponents"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfComponents"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice (@"This property is a no-op since 7.0.")]
		public virtual bool ShowSelectionIndicator {
			[Export ("showsSelectionIndicator")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsSelectionIndicator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsSelectionIndicator"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsSelectionIndicator:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsSelectionIndicator:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsSelectionIndicator:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDataSource {
			[Export ("dataSource", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataSource")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDataSource_var = ret;
				return ret!;
			}
			[Export ("setDataSource:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDataSource:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDataSource:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDataSource_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UIPickerView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UIPickerView.Appearance" /> property or by calling <see cref="global::UIKit.UIPickerView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UIPickerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal UIPickerViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UIPickerView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIPickerView" />, they should use the <see cref="global::UIKit.UIPickerView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UIPickerViewAppearance Appearance {
			get { return new UIPickerViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIPickerView.UIPickerViewAppearance" /> for the subclass of <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIPickerView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIPickerView.Appearance" /> property, or the <see cref="global::UIKit.UIPickerView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UIPickerView.GetAppearance<MyUIPickerViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance GetAppearance<T> () where T: UIPickerView {
			return new UIPickerViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UIPickerView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIPickerView" />, they should use the <see cref="global::UIKit.UIPickerView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UIPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIPickerView.UIPickerViewAppearance" /> for <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIPickerView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIPickerView" />, they should use the <see cref="global::UIKit.UIPickerView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance GetAppearance (UITraitCollection traits) {
			return new UIPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIPickerView.UIPickerViewAppearance" /> for <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIPickerView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIPickerView" />, they should use the <see cref="global::UIKit.UIPickerView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UIPickerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIPickerView.UIPickerViewAppearance" /> for the subclass of <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIPickerView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIPickerView.Appearance" /> property, or the <see cref="global::UIKit.UIPickerView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIPickerView.GetAppearance<MyUIPickerViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: UIPickerView {
			return new UIPickerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIPickerView.UIPickerViewAppearance" /> for the subclass of <see cref="global::UIKit.UIPickerView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIPickerView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIPickerView.Appearance" /> property, or the <see cref="global::UIKit.UIPickerView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIPickerView.GetAppearance<MyUIPickerViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIPickerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UIPickerView{
			return new UIPickerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class UIPickerView */
}
