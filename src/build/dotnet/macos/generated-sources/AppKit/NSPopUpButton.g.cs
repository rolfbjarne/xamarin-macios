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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	[Register("NSPopUpButton", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPopUpButton : NSButton {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddItemWithTitle_X = "addItemWithTitle:";
		static readonly NativeHandle selAddItemWithTitle_XHandle = Selector.GetHandle ("addItemWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddItemsWithTitles_X = "addItemsWithTitles:";
		static readonly NativeHandle selAddItemsWithTitles_XHandle = Selector.GetHandle ("addItemsWithTitles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAltersStateOfSelectedItemX = "altersStateOfSelectedItem";
		static readonly NativeHandle selAltersStateOfSelectedItemXHandle = Selector.GetHandle ("altersStateOfSelectedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoenablesItemsX = "autoenablesItems";
		static readonly NativeHandle selAutoenablesItemsXHandle = Selector.GetHandle ("autoenablesItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItem_X = "indexOfItem:";
		static readonly NativeHandle selIndexOfItem_XHandle = Selector.GetHandle ("indexOfItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemWithRepresentedObject_X = "indexOfItemWithRepresentedObject:";
		static readonly NativeHandle selIndexOfItemWithRepresentedObject_XHandle = Selector.GetHandle ("indexOfItemWithRepresentedObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemWithTag_X = "indexOfItemWithTag:";
		static readonly NativeHandle selIndexOfItemWithTag_XHandle = Selector.GetHandle ("indexOfItemWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemWithTarget_AndAction_X = "indexOfItemWithTarget:andAction:";
		static readonly NativeHandle selIndexOfItemWithTarget_AndAction_XHandle = Selector.GetHandle ("indexOfItemWithTarget:andAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemWithTitle_X = "indexOfItemWithTitle:";
		static readonly NativeHandle selIndexOfItemWithTitle_XHandle = Selector.GetHandle ("indexOfItemWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfSelectedItemX = "indexOfSelectedItem";
		static readonly NativeHandle selIndexOfSelectedItemXHandle = Selector.GetHandle ("indexOfSelectedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_PullsDown_X = "initWithFrame:pullsDown:";
		static readonly NativeHandle selInitWithFrame_PullsDown_XHandle = Selector.GetHandle ("initWithFrame:pullsDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemWithTitle_AtIndex_X = "insertItemWithTitle:atIndex:";
		static readonly NativeHandle selInsertItemWithTitle_AtIndex_XHandle = Selector.GetHandle ("insertItemWithTitle:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemArrayX = "itemArray";
		static readonly NativeHandle selItemArrayXHandle = Selector.GetHandle ("itemArray");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtIndex_X = "itemAtIndex:";
		static readonly NativeHandle selItemAtIndex_XHandle = Selector.GetHandle ("itemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemTitleAtIndex_X = "itemTitleAtIndex:";
		static readonly NativeHandle selItemTitleAtIndex_XHandle = Selector.GetHandle ("itemTitleAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemTitlesX = "itemTitles";
		static readonly NativeHandle selItemTitlesXHandle = Selector.GetHandle ("itemTitles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemWithTitle_X = "itemWithTitle:";
		static readonly NativeHandle selItemWithTitle_XHandle = Selector.GetHandle ("itemWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastItemX = "lastItem";
		static readonly NativeHandle selLastItemXHandle = Selector.GetHandle ("lastItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuX = "menu";
		static readonly NativeHandle selMenuXHandle = Selector.GetHandle ("menu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsX = "numberOfItems";
		static readonly NativeHandle selNumberOfItemsXHandle = Selector.GetHandle ("numberOfItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPopUpButtonWithMenu_Target_Action_X = "popUpButtonWithMenu:target:action:";
		static readonly NativeHandle selPopUpButtonWithMenu_Target_Action_XHandle = Selector.GetHandle ("popUpButtonWithMenu:target:action:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredEdgeX = "preferredEdge";
		static readonly NativeHandle selPreferredEdgeXHandle = Selector.GetHandle ("preferredEdge");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPullDownButtonWithImage_Menu_X = "pullDownButtonWithImage:menu:";
		static readonly NativeHandle selPullDownButtonWithImage_Menu_XHandle = Selector.GetHandle ("pullDownButtonWithImage:menu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPullDownButtonWithTitle_Image_Menu_X = "pullDownButtonWithTitle:image:menu:";
		static readonly NativeHandle selPullDownButtonWithTitle_Image_Menu_XHandle = Selector.GetHandle ("pullDownButtonWithTitle:image:menu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPullDownButtonWithTitle_Menu_X = "pullDownButtonWithTitle:menu:";
		static readonly NativeHandle selPullDownButtonWithTitle_Menu_XHandle = Selector.GetHandle ("pullDownButtonWithTitle:menu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPullsDownX = "pullsDown";
		static readonly NativeHandle selPullsDownXHandle = Selector.GetHandle ("pullsDown");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllItemsX = "removeAllItems";
		static readonly NativeHandle selRemoveAllItemsXHandle = Selector.GetHandle ("removeAllItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemAtIndex_X = "removeItemAtIndex:";
		static readonly NativeHandle selRemoveItemAtIndex_XHandle = Selector.GetHandle ("removeItemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemWithTitle_X = "removeItemWithTitle:";
		static readonly NativeHandle selRemoveItemWithTitle_XHandle = Selector.GetHandle ("removeItemWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectItem_X = "selectItem:";
		static readonly NativeHandle selSelectItem_XHandle = Selector.GetHandle ("selectItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectItemAtIndex_X = "selectItemAtIndex:";
		static readonly NativeHandle selSelectItemAtIndex_XHandle = Selector.GetHandle ("selectItemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectItemWithTag_X = "selectItemWithTag:";
		static readonly NativeHandle selSelectItemWithTag_XHandle = Selector.GetHandle ("selectItemWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectItemWithTitle_X = "selectItemWithTitle:";
		static readonly NativeHandle selSelectItemWithTitle_XHandle = Selector.GetHandle ("selectItemWithTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedItemX = "selectedItem";
		static readonly NativeHandle selSelectedItemXHandle = Selector.GetHandle ("selectedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedTagX = "selectedTag";
		static readonly NativeHandle selSelectedTagXHandle = Selector.GetHandle ("selectedTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAltersStateOfSelectedItem_X = "setAltersStateOfSelectedItem:";
		static readonly NativeHandle selSetAltersStateOfSelectedItem_XHandle = Selector.GetHandle ("setAltersStateOfSelectedItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoenablesItems_X = "setAutoenablesItems:";
		static readonly NativeHandle selSetAutoenablesItems_XHandle = Selector.GetHandle ("setAutoenablesItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMenu_X = "setMenu:";
		static readonly NativeHandle selSetMenu_XHandle = Selector.GetHandle ("setMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredEdge_X = "setPreferredEdge:";
		static readonly NativeHandle selSetPreferredEdge_XHandle = Selector.GetHandle ("setPreferredEdge:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPullsDown_X = "setPullsDown:";
		static readonly NativeHandle selSetPullsDown_XHandle = Selector.GetHandle ("setPullsDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesItemFromMenu_X = "setUsesItemFromMenu:";
		static readonly NativeHandle selSetUsesItemFromMenu_XHandle = Selector.GetHandle ("setUsesItemFromMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeTitleAndSelectedItemX = "synchronizeTitleAndSelectedItem";
		static readonly NativeHandle selSynchronizeTitleAndSelectedItemXHandle = Selector.GetHandle ("synchronizeTitleAndSelectedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleOfSelectedItemX = "titleOfSelectedItem";
		static readonly NativeHandle selTitleOfSelectedItemXHandle = Selector.GetHandle ("titleOfSelectedItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesItemFromMenuX = "usesItemFromMenu";
		static readonly NativeHandle selUsesItemFromMenuXHandle = Selector.GetHandle ("usesItemFromMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPopUpButton");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSPopUpButton" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPopUpButton () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		public NSPopUpButton (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected NSPopUpButton (NSObjectFlag t) : base (t)
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
		protected internal NSPopUpButton (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:pullsDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSPopUpButton (CGRect buttonFrame, bool pullsDown)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_bool (this.Handle, selInitWithFrame_PullsDown_XHandle, buttonFrame, pullsDown ? (byte) 1 : (byte) 0), "initWithFrame:pullsDown:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_bool (&__objc_super__, selInitWithFrame_PullsDown_XHandle, buttonFrame, pullsDown ? (byte) 1 : (byte) 0), "initWithFrame:pullsDown:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addItemWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddItem (string title)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddItemWithTitle_XHandle, nstitle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddItemWithTitle_XHandle, nstitle);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		[Export ("addItemsWithTitles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddItems (string[] itemTitles)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (itemTitles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemTitles));
			using var nsa_itemTitles = NSArray.FromStrings (itemTitles);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddItemsWithTitles_XHandle, nsa_itemTitles.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddItemsWithTitles_XHandle, nsa_itemTitles.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("popUpButtonWithMenu:target:action:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPopUpButton CreatePopUpButton (NSMenu menu, NSObject? target, Selector? selector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var target__handle__ = target.GetHandle ();
			var selector__handle__ = selector.GetHandle ();
			NSPopUpButton? ret;
			ret =  Runtime.GetNSObject<NSPopUpButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPopUpButtonWithMenu_Target_Action_XHandle, menu__handle__, target__handle__, selector__handle__), false)!;
			GC.KeepAlive (menu);
			GC.KeepAlive (target);
			GC.KeepAlive (selector);
			return ret!;
		}
		[Export ("pullDownButtonWithTitle:menu:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPopUpButton CreatePullDownButton (string title, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var nstitle = CFString.CreateNative (title);
			NSPopUpButton? ret;
			ret =  Runtime.GetNSObject<NSPopUpButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPullDownButtonWithTitle_Menu_XHandle, nstitle, menu__handle__), false)!;
			GC.KeepAlive (menu);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("pullDownButtonWithImage:menu:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPopUpButton CreatePullDownButton (NSImage image, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			NSPopUpButton? ret;
			ret =  Runtime.GetNSObject<NSPopUpButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPullDownButtonWithImage_Menu_XHandle, image__handle__, menu__handle__), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (menu);
			return ret!;
		}
		[Export ("pullDownButtonWithTitle:image:menu:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPopUpButton CreatePullDownButton (string title, NSImage image, NSMenu menu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var nstitle = CFString.CreateNative (title);
			NSPopUpButton? ret;
			ret =  Runtime.GetNSObject<NSPopUpButton> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPullDownButtonWithTitle_Image_Menu_XHandle, nstitle, image__handle__, menu__handle__), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (menu);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("indexOfItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfItem (NSMenuItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret!;
		}
		[Export ("indexOfItemWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfItem (string title)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfItemWithTitle_XHandle, nstitle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfItemWithTitle_XHandle, nstitle);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("indexOfItemWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfItem (nint tag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selIndexOfItemWithTag_XHandle, tag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selIndexOfItemWithTag_XHandle, tag);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("indexOfItemWithRepresentedObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfItem (NSObject obj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfItemWithRepresentedObject_XHandle, obj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfItemWithRepresentedObject_XHandle, obj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			return ret!;
		}
		[Export ("indexOfItemWithTarget:andAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfItem (NSObject target, Selector actionSelector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var actionSelector__handle__ = actionSelector!.GetNonNullHandle (nameof (actionSelector));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIndexOfItemWithTarget_AndAction_XHandle, target__handle__, actionSelector.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIndexOfItemWithTarget_AndAction_XHandle, target__handle__, actionSelector.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (actionSelector);
			return ret!;
		}
		[Export ("insertItemWithTitle:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItem (string title, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertItemWithTitle_AtIndex_XHandle, nstitle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertItemWithTitle_AtIndex_XHandle, nstitle, index);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		[Export ("itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenuItem ItemAtIndex (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSMenuItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selItemAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selItemAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("itemTitleAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ItemTitle (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selItemTitleAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selItemTitleAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("itemTitles")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ItemTitles ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemTitlesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemTitlesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("itemWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenuItem ItemWithTitle (string title)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			NSMenuItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selItemWithTitle_XHandle, nstitle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemWithTitle_XHandle, nstitle), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[Export ("itemArray")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenuItem[] Items ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSMenuItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemArrayXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSMenuItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemArrayXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeAllItems")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllItems ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllItemsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllItemsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeItemWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItem (string title)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveItemWithTitle_XHandle, nstitle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveItemWithTitle_XHandle, nstitle);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		[Export ("removeItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItem (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveItemAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveItemAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("selectItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectItem (NSMenuItem? item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("selectItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectItem (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSelectItemAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSelectItemAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("selectItemWithTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectItem (string title)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSelectItemWithTitle_XHandle, nstitle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSelectItemWithTitle_XHandle, nstitle);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		[Export ("selectItemWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectItemWithTag (nint tag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSelectItemWithTag_XHandle, tag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selSelectItemWithTag_XHandle, tag);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("setTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitle (string aString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsaString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsaString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
		}
		[Export ("synchronizeTitleAndSelectedItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SynchronizeTitleAndSelectedItem ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSynchronizeTitleAndSelectedItemXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSynchronizeTitleAndSelectedItemXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool AltersStateOfSelectedItem {
			[Export ("altersStateOfSelectedItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAltersStateOfSelectedItemXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAltersStateOfSelectedItemXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAltersStateOfSelectedItem:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAltersStateOfSelectedItem_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAltersStateOfSelectedItem_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoEnablesItems {
			[Export ("autoenablesItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoenablesItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoenablesItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoenablesItems:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoenablesItems_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoenablesItems_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOfSelectedItem {
			[Export ("indexOfSelectedItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndexOfSelectedItemXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIndexOfSelectedItemXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ItemCount {
			[Export ("numberOfItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenuItem LastItem {
			[Export ("lastItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenuItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu? Menu {
			[Export ("menu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenu? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMenu:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMenu_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMenu_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRectEdge PreferredEdge {
			[Export ("preferredEdge")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRectEdge ret;
				if (IsDirectBinding) {
					ret = (NSRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPreferredEdgeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSRectEdge) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPreferredEdgeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredEdge:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPreferredEdge_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPreferredEdge_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PullsDown {
			[Export ("pullsDown")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPullsDownXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPullsDownXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPullsDown:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPullsDown_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPullsDown_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenuItem SelectedItem {
			[Export ("selectedItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenuItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenuItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedTag {
			[Export ("selectedTag")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTagXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectedTagXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TitleOfSelectedItem {
			[Export ("titleOfSelectedItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleOfSelectedItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleOfSelectedItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool UsesItemFromMenu {
			[Export ("usesItemFromMenu")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesItemFromMenuXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesItemFromMenuXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesItemFromMenu:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesItemFromMenu_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesItemFromMenu_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillPopUpNotification;
		/// <summary>Notification constant for WillPopUp</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillPopUp(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillPopUp(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSPopUpButton.Notifications.ObserveWillPopUp ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSPopUpButton.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSPopUpButton.Notifications.ObserveWillPopUp (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSPopUpButton.WillPopUpNotification, (notification) => { Console.WriteLine ("Received the notification WillPopUp", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillPopUp", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSPopUpButton.WillPopUpNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSPopUpButtonWillPopUpNotification",  "AppKit")]
		[Advice ("Use NSPopUpButton.Notifications.ObserveWillPopUp helper method instead.")]
		public static NSString WillPopUpNotification {
			get {
				if (_WillPopUpNotification is null)
					_WillPopUpNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPopUpButtonWillPopUpNotification")!;
				return _WillPopUpNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSPopUpButton" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSPopUpButton.WillPopUpNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSPopUpButton.WillPopUpNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSPopUpButton.Notifications.ObserveWillPopUp ((notification) => {
			///   Console.WriteLine ("Observed WillPopUpNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPopUp (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillPopUpNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSPopUpButton.WillPopUpNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSPopUpButton.WillPopUpNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSPopUpButton.Notifications.ObserveWillPopUp (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillPopUpNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillPopUp (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillPopUpNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSPopUpButton */
}
