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
	[Register("UITableViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITableViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UITableViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UITableViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITableViewController () : base (NSObjectFlag.Empty)
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
		public UITableViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UITableViewController (NSObjectFlag t) : base (t)
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
		protected internal UITableViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITableViewController (string? nibName, NSBundle? bundle)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var bundle__handle__ = bundle.GetHandle ();
			var nsnibName = CFString.CreateNative (nibName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsnibName);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("initWithStyle:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITableViewController (UITableViewStyle withStyle)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithStyle:"), (IntPtr) (long) withStyle), "initWithStyle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithStyle:"), (IntPtr) (long) withStyle), "initWithStyle:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="tableView">The table view containing the row/cell accessory that has been tapped.</param><param name="indexPath">The location of the row in the table view.</param><summary>Indicates that the user has tapped the accessory/disclosure button at the specified indexPath.</summary><remarks>To be added.</remarks>
		[Export ("tableView:accessoryButtonTappedForRowWithIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:accessoryButtonTappedForRowWithIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:accessoryButtonTappedForRowWithIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  should be editable.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canEditRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:canEditRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:canEditRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Whether the row at the specified <paramref name="indexPath" /> may receive focus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canFocusRowAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:canFocusRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:canFocusRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  can be moved to another location in the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canMoveRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:canMoveRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:canMoveRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row.</param><param name="sender">Object that initially triggere the Copy or Paste.</param><summary>Whether the cell at the specified indexPath can perform the specified Copy or Paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:canPerformAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:canPerformAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("tableView:canPerformPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:canPerformPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:canPerformPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> being displayed.</param><param name="cell">The <see cref="T:UIKit.UITableViewCell" /> that has just been removed.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> specifying the <paramref name="cell" />.</param><summary>Indicates that the cell has just been removed.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndDisplayingCell:forRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didEndDisplayingCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didEndDisplayingCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view requesting insertion or deletion.</param><param name="editingStyle">Cell editing style requested for the row at <paramref name="indexPath" />, such as <see cref="F:UIKit.UITableViewCellEditingStyle.Insert" /> or <see cref="F:UIKit.UITableViewCellEditingStyle.Delete" />.</param><param name="indexPath">Location of the row.</param><summary>Commits the insertion or deletion of the specified row.</summary><remarks>To be added.</remarks>
		[Export ("tableView:commitEditingStyle:forRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("tableView:commitEditingStyle:forRowAtIndexPath:"), tableView__handle__, (IntPtr) (long) editingStyle, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:commitEditingStyle:forRowAtIndexPath:"), tableView__handle__, (IntPtr) (long) editingStyle, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row to be moved.</param><param name="sourceIndexPath">The original location of the row being moved.</param><param name="proposedIndexPath">The location in the table view where the row has been dropped. The location can be altered by this method.</param><summary>Used to change a cell move destination, for example, to prevent dropping a cell in a certain position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath CustomizeMoveTarget (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:"), tableView__handle__, sourceIndexPath__handle__, proposedIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:"), tableView__handle__, sourceIndexPath__handle__, proposedIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		[Export ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row.</param><summary>Indicates that editing of the cell at the specified indexPath has finished.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndEditing (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didEndEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didEndEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		[Export ("tableViewDidEndMultipleSelectionInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndMultipleSelectionInteraction (UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("tableViewDidEndMultipleSelectionInteraction:"), tableView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("tableViewDidEndMultipleSelectionInteraction:"), tableView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
		}
		/// <param name="tableView">To be added.</param><param name="context">A <see cref="T:UIKit.UITableViewFocusUpdateContext" /> object containing metadata.</param><param name="coordinator">A <see cref="T:UIKit.UIFocusAnimationCoordinator" /> object containing metadata.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UITableViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UITableViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="tableView" />.</para></remarks>
		[Export ("tableView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didUpdateFocusInContext:withAnimationCoordinator:"), tableView__handle__, context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didUpdateFocusInContext:withAnimationCoordinator:"), tableView__handle__, context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>Returns an array of row actions to display after the user swipes the row in the <paramref name="tableView" /> table view that is identified by <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:editActionsForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetTrailingSwipeActionsConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewRowAction[] EditActionsForRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewRowAction[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UITableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:editActionsForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UITableViewRowAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:editActionsForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view that is going to be editable.</param><param name="indexPath">Location of the row.</param><summary>The UITableViewCellEditingStyle for the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:editingStyleForRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCellEditingStyle EditingStyleForRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCellEditingStyle ret;
			if (IsDirectBinding) {
				ret = (UITableViewCellEditingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:editingStyleForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (UITableViewCellEditingStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:editingStyleForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="indexPath">To be added.</param><summary>An estimate of the height for the specified indexPath. Implementations should perform minimal calculation, as it is called repeatedly.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeight (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:estimatedHeightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:estimatedHeightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForFooterInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForFooter (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:estimatedHeightForFooterInSection:"), tableView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:estimatedHeightForFooterInSection:"), tableView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><param name="section">To be added.</param><summary>The estimated height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:estimatedHeightForHeaderInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat EstimatedHeightForHeader (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:estimatedHeightForHeaderInSection:"), tableView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:estimatedHeightForHeaderInSection:"), tableView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table to which the footer view belongs.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">The index of the section to which the <paramref name="footerView" /> belonged.</param><summary>Called when a section footer view is removed from the table (for instance, due to scrolling).</summary><remarks>Application developers should use this method rather than trying to monitor the <paramref name="footerView" />'s visibility directly.</remarks>
		[Export ("tableView:didEndDisplayingFooterView:forSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FooterViewDisplayingEnded (UITableView tableView, UIView footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView!.GetNonNullHandle (nameof (footerView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:didEndDisplayingFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:didEndDisplayingFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">Table view requesting the cell.</param><param name="indexPath">Location of the row where the cell will be displayed.</param><summary>Returns a cell that can be inserted at <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:cellForRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("tableView:contextMenuConfigurationForRowAtIndexPath:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UITableView tableView, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIContextMenuConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("tableView:contextMenuConfigurationForRowAtIndexPath:point:"), tableView__handle__, indexPath__handle__, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("tableView:contextMenuConfigurationForRowAtIndexPath:point:"), tableView__handle__, indexPath__handle__, point), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a footer display.</param><summary>Called to determine the height of the footer for the section specified by <paramref name="section" />.</summary><returns>The height of the footer (in points) as a <see langword="float" />.</returns><remarks><para>This method allows section footers to have different heights. This method is not called if the table is <see cref="F:UIKit.UITableViewStyle.Plain" /> style.</para></remarks>
		[Export ("tableView:heightForFooterInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForFooter (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:heightForFooterInSection:"), tableView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:heightForFooterInSection:"), tableView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="section">Index of the section requiring a header display.</param><summary>The height of the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:heightForHeaderInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:heightForHeaderInSection:"), tableView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:heightForHeaderInSection:"), tableView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view.</param><param name="indexPath">Location of the row.</param><summary>The height of the cell at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:heightForRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:heightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:heightForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">To be added.</param><summary>The index path of the table's preferred focus view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexPathForPreferredFocusedViewInTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInTableView:"), tableView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathForPreferredFocusedViewInTableView:"), tableView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the leading edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetLeadingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:leadingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("tableView:previewForDismissingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:previewForDismissingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:previewForDismissingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[Export ("tableView:previewForHighlightingContextMenuWithConfiguration:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingContextMenu (UITableView tableView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:previewForHighlightingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:previewForHighlightingContextMenuWithConfiguration:"), tableView__handle__, configuration__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[Export ("tableView:selectionFollowsFocusForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetSelectionFollowsFocusForRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:selectionFollowsFocusForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:selectionFollowsFocusForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">The table view for which to get the configuration.</param><param name="indexPath">The index path to the row for which to get the configuration.</param><summary>Returns the swipe action configuration for swipes that begin from the trailing edge.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISwipeActionsConfiguration? GetTrailingSwipeActionsConfiguration (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UISwipeActionsConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UISwipeActionsConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:trailingSwipeActionsConfigurationForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the footer will be added.</param><summary>Returns a view object to display at the end of the given section.</summary><returns>A view to be displayed at the end of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForFooter(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para><para>[UITableViewDelegate]</para></remarks>
		[Export ("tableView:viewForFooterInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForFooter (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:viewForFooterInSection:"), tableView__handle__, section), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:viewForFooterInSection:"), tableView__handle__, section), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Section index where the header will be added.</param><summary>Returns a view object to display at the start of the given section.</summary><returns>A view to be displayed at the start of the given <paramref name="section" />.</returns><remarks><para>Can either be a <see cref="T:UIKit.UILabel" />, <see cref="T:UIKit.UIImageView" /> or a custom view. This method requires <see cref="M:UIKit.UITableViewSource.GetHeightForHeader(UIKit.UITableView,System.IntPtr)" /> to be implemented as well.</para></remarks>
		[Export ("tableView:viewForHeaderInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView GetViewForHeader (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			UIView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:viewForHeaderInSection:"), tableView__handle__, section), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:viewForHeaderInSection:"), tableView__handle__, section), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> to which the <paramref name="headerView" /> belongs.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> being removed.</param><param name="section">An index indicating the section to which the <paramref name="headerView" /> belongs.</param><summary>Called when a section header is removed from a table (for instance, due to scrolling).</summary><remarks>To be added.</remarks>
		[Export ("tableView:didEndDisplayingHeaderView:forSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HeaderViewDisplayingEnded (UITableView tableView, UIView headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView!.GetNonNullHandle (nameof (headerView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:didEndDisplayingHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:didEndDisplayingHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>The indentation level for the cell at the specified indexPath.</summary><returns></returns><remarks><para>Note that custom <see cref="T:UIKit.UITableViewCell" />'s do not respect IndentationLevel automatically. Application developers must override <see cref="M:UIKit.UIView.LayoutSubviews" />.</para></remarks>
		[Export ("tableView:indentationLevelForRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndentationLevel (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:indentationLevelForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:indentationLevelForRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row being moved.</param><param name="sourceIndexPath">Location of the row to be moved.</param><param name="destinationIndexPath">New location of the row.</param><summary>Called when a row has been moved so that the data source can 'implement' the changed row position that has been performed in the user interface. This ensures the data is kept in-sync with what is being displayed.</summary><remarks>To be added.</remarks>
		[Export ("tableView:moveRowAtIndexPath:toIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:moveRowAtIndexPath:toIndexPath:"), tableView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:moveRowAtIndexPath:toIndexPath:"), tableView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
		/// <param name="tableView">Table view displaying the sections.</param><summary>Returns the number of sections that are required to display the data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInTableView:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfSectionsInTableView:"), tableView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("numberOfSectionsInTableView:"), tableView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="action">A selector identifying the Copy or Paste method (ie. <see cref="UIKit.UIResponder.Copy(Foundation.NSObject)" /> or <see cref="UIKit.UIResponder.Paste(Foundation.NSObject)" />).</param><param name="indexPath">Location of the row where the copy or paste operation was selected.</param><param name="sender">Object that triggered the copy or paste operation.</param><summary>Performs the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[Export ("tableView:performAction:forRowAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:performAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:performAction:forRowAtIndexPath:withSender:"), tableView__handle__, action.Handle, indexPath__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		[Export ("tableView:performPrimaryActionForRowAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryAction (UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:performPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:performPrimaryActionForRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become de-selected.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didDeselectRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowDeselected (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">Location of the row being highlighted.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didHighlightRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowHighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row that has become selected.</param><summary>Indicates that the call at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didSelectRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> containing the row.</param><param name="rowIndexPath">The row being unhighlighted.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[Export ("tableView:didUnhighlightRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowUnhighlighted (UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:didUnhighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:didUnhighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
		}
		/// <param name="tableView">To be added.</param><param name="section">Index of the section containing the rows.</param><summary>The number of rows in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:numberOfRowsInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		/// <param name="tableView">Table view containing the section.</param><param name="title">The title that's displayed in the table view's index.</param><param name="atIndex">The index of the title in the array returned from the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" />.</param><summary>Returns the index of the section with the given <paramref name="tableView" /> and <paramref name="atIndex" />.</summary><returns>The index of the section in the table view.</returns><remarks><para>This method is only required for table views that have an index: they must have the <see cref="F:UIKit.UITableViewStyle.Plain" /> style and implement the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" /> property.</para><para>The index for a table view may contain fewer items than the number of actual sections in the table. This method is passed the text and index of an item in the index, and should return the position of the corresponding section. </para></remarks>
		[Export ("tableView:sectionForSectionIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SectionFor (UITableView tableView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:sectionForSectionIndexTitle:atIndex:"), tableView__handle__, nstitle, atIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:sectionForSectionIndexTitle:atIndex:"), tableView__handle__, nstitle, atIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="tableView">Table view that is displaying the index.</param><summary>Returns an array of titles to be displayed as an index on the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sectionIndexTitlesForTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? SectionIndexTitles (UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sectionIndexTitlesForTableView:"), tableView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("sectionIndexTitlesForTableView:"), tableView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		[Export ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginMultipleSelectionInteraction (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> in which the row is located.</param><param name="rowIndexPath">The location of the row being highlighted.</param><summary>Whether the cell at the specified indexPath should be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldHighlightRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightRow (UITableView tableView, NSIndexPath rowIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowIndexPath__handle__ = rowIndexPath!.GetNonNullHandle (nameof (rowIndexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldHighlightRowAtIndexPath:"), tableView__handle__, rowIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowIndexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view that contains the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the cell at the specified indexPath should be indented while it is being edited.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldIndentWhileEditing (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldIndentWhileEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldIndentWhileEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="rowAtindexPath">Location of the row that the user is selecting.</param><summary>Whether the cell at the specified rowAtIndexPath should show an action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldShowMenuForRowAtIndexPath:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowMenu (UITableView tableView, NSIndexPath rowAtindexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var rowAtindexPath__handle__ = rowAtindexPath!.GetNonNullHandle (nameof (rowAtindexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldShowMenuForRowAtIndexPath:"), tableView__handle__, rowAtindexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldShowMenuForRowAtIndexPath:"), tableView__handle__, rowAtindexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (rowAtindexPath);
			return ret != 0;
		}
		/// <param name="tableView">The table view to query.</param><param name="indexPath">The index path to the row to query.</param><param name="context">The spring loading context to query.</param><summary>Method that is called to indicate whether the identified row should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldSpringLoadRowAtIndexPath:withContext:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSpringLoadRow (UITableView tableView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldSpringLoadRowAtIndexPath:withContext:"), tableView__handle__, indexPath__handle__, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldSpringLoadRowAtIndexPath:withContext:"), tableView__handle__, indexPath__handle__, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="tableView">To be added.</param><param name="context">To be added.</param><summary>TCalled prior to the <paramref name="tableView" /> either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UITableView tableView, UITableViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:shouldUpdateFocusInContext:"), tableView__handle__, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:shouldUpdateFocusInContext:"), tableView__handle__, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="tableView">Table view being edited.</param><param name="indexPath">Location of the row that may be deleted.</param><summary>When overridden, changes the default title of the delete confirmation button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForDeleteConfirmation (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the footer.</param><summary>Called to populate the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForFooterInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForFooter (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:titleForFooterInSection:"), tableView__handle__, section), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:titleForFooterInSection:"), tableView__handle__, section), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the header.</param><summary>Called to populate the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForHeaderInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForHeader (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:titleForHeaderInSection:"), tableView__handle__, section), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:titleForHeaderInSection:"), tableView__handle__, section), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view about to be edited.</param><param name="indexPath">Location of the row that has been swiped.</param><summary>Indicates that the cell at the specified indexPath is about to be edited.</summary><remarks>To be added.</remarks>
		[Export ("tableView:willBeginEditingRowAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginEditing (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willBeginEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willBeginEditingRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">The table involved.</param><param name="indexPath">The index path of the row about to be de-selected.</param><summary>Indicates that the cell at the specified indexPath is about to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:willDeselectRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillDeselectRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willDeselectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="cell">Cell view that is going to be used to draw the row.</param><param name="indexPath">Location of the row.</param><summary>Indicates that the cell at the specified indexPath is about to be shown.</summary><remarks>To be added.</remarks>
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willDisplayCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willDisplayCell:forRowAtIndexPath:"), tableView__handle__, cell__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		[Export ("tableView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willDisplayContextMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willDisplayContextMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="footerView">The <see cref="T:UIKit.UIView" /> that will be used as the footer view.</param><param name="section">The table section to which the footer view belongs.</param><summary>Called prior to the display of a footer view for a section.</summary><remarks></remarks>
		[Export ("tableView:willDisplayFooterView:forSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayFooterView (UITableView tableView, UIView? footerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var footerView__handle__ = footerView.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:willDisplayFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:willDisplayFooterView:forSection:"), tableView__handle__, footerView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (footerView);
		}
		/// <param name="tableView">The <see cref="T:UIKit.UITableView" /> involved.</param><param name="headerView">The <see cref="T:UIKit.UIView" /> that will be used as the header view.</param><param name="section">The table section to which the header view belongs.</param><summary>Called prior to the display of a header view for a section.</summary><remarks></remarks>
		[Export ("tableView:willDisplayHeaderView:forSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayHeaderView (UITableView tableView, UIView? headerView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var headerView__handle__ = headerView.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:willDisplayHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("tableView:willDisplayHeaderView:forSection:"), tableView__handle__, headerView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (headerView);
		}
		[Export ("tableView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willEndContextMenuInteractionWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willEndContextMenuInteractionWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[Export ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UITableView tableView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willPerformPreviewActionForMenuWithConfiguration:animator:"), tableView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row about to be selected.</param><summary>Indicates the the cell at the specified indexPath is about to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:willSelectRowAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? WillSelectRow (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:willSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("tableView:willSelectRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsSelectionOnViewWillAppear {
			[Export ("clearsSelectionOnViewWillAppear")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsSelectionOnViewWillAppear"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsSelectionOnViewWillAppear"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsSelectionOnViewWillAppear:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsSelectionOnViewWillAppear:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsSelectionOnViewWillAppear:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIRefreshControl? RefreshControl {
			[Export ("refreshControl", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIRefreshControl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIRefreshControl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("refreshControl")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIRefreshControl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("refreshControl")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRefreshControl:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRefreshControl:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRefreshControl:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableView TableView {
			[Export ("tableView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITableView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tableView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tableView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTableView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTableView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTableView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class UITableViewController */
}
