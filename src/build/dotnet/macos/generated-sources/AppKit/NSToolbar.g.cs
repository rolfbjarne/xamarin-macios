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
	[Register("NSToolbar", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSToolbar : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDisplayModeCustomizationX = "allowsDisplayModeCustomization";
		static readonly NativeHandle selAllowsDisplayModeCustomizationXHandle = Selector.GetHandle ("allowsDisplayModeCustomization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsExtensionItemsX = "allowsExtensionItems";
		static readonly NativeHandle selAllowsExtensionItemsXHandle = Selector.GetHandle ("allowsExtensionItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsUserCustomizationX = "allowsUserCustomization";
		static readonly NativeHandle selAllowsUserCustomizationXHandle = Selector.GetHandle ("allowsUserCustomization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavesConfigurationX = "autosavesConfiguration";
		static readonly NativeHandle selAutosavesConfigurationXHandle = Selector.GetHandle ("autosavesConfiguration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenteredItemIdentifierX = "centeredItemIdentifier";
		static readonly NativeHandle selCenteredItemIdentifierXHandle = Selector.GetHandle ("centeredItemIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenteredItemIdentifiersX = "centeredItemIdentifiers";
		static readonly NativeHandle selCenteredItemIdentifiersXHandle = Selector.GetHandle ("centeredItemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfigurationDictionaryX = "configurationDictionary";
		static readonly NativeHandle selConfigurationDictionaryXHandle = Selector.GetHandle ("configurationDictionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomizationPaletteIsRunningX = "customizationPaletteIsRunning";
		static readonly NativeHandle selCustomizationPaletteIsRunningXHandle = Selector.GetHandle ("customizationPaletteIsRunning");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayModeX = "displayMode";
		static readonly NativeHandle selDisplayModeXHandle = Selector.GetHandle ("displayMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithIdentifier_X = "initWithIdentifier:";
		static readonly NativeHandle selInitWithIdentifier_XHandle = Selector.GetHandle ("initWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemWithItemIdentifier_AtIndex_X = "insertItemWithItemIdentifier:atIndex:";
		static readonly NativeHandle selInsertItemWithItemIdentifier_AtIndex_XHandle = Selector.GetHandle ("insertItemWithItemIdentifier:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVisibleX = "isVisible";
		static readonly NativeHandle selIsVisibleXHandle = Selector.GetHandle ("isVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemIdentifiersX = "itemIdentifiers";
		static readonly NativeHandle selItemIdentifiersXHandle = Selector.GetHandle ("itemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemsX = "items";
		static readonly NativeHandle selItemsXHandle = Selector.GetHandle ("items");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemAtIndex_X = "removeItemAtIndex:";
		static readonly NativeHandle selRemoveItemAtIndex_XHandle = Selector.GetHandle ("removeItemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveItemWithItemIdentifier_X = "removeItemWithItemIdentifier:";
		static readonly NativeHandle selRemoveItemWithItemIdentifier_XHandle = Selector.GetHandle ("removeItemWithItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunCustomizationPalette_X = "runCustomizationPalette:";
		static readonly NativeHandle selRunCustomizationPalette_XHandle = Selector.GetHandle ("runCustomizationPalette:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedItemIdentifierX = "selectedItemIdentifier";
		static readonly NativeHandle selSelectedItemIdentifierXHandle = Selector.GetHandle ("selectedItemIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsDisplayModeCustomization_X = "setAllowsDisplayModeCustomization:";
		static readonly NativeHandle selSetAllowsDisplayModeCustomization_XHandle = Selector.GetHandle ("setAllowsDisplayModeCustomization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsExtensionItems_X = "setAllowsExtensionItems:";
		static readonly NativeHandle selSetAllowsExtensionItems_XHandle = Selector.GetHandle ("setAllowsExtensionItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsUserCustomization_X = "setAllowsUserCustomization:";
		static readonly NativeHandle selSetAllowsUserCustomization_XHandle = Selector.GetHandle ("setAllowsUserCustomization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosavesConfiguration_X = "setAutosavesConfiguration:";
		static readonly NativeHandle selSetAutosavesConfiguration_XHandle = Selector.GetHandle ("setAutosavesConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenteredItemIdentifier_X = "setCenteredItemIdentifier:";
		static readonly NativeHandle selSetCenteredItemIdentifier_XHandle = Selector.GetHandle ("setCenteredItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCenteredItemIdentifiers_X = "setCenteredItemIdentifiers:";
		static readonly NativeHandle selSetCenteredItemIdentifiers_XHandle = Selector.GetHandle ("setCenteredItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConfigurationFromDictionary_X = "setConfigurationFromDictionary:";
		static readonly NativeHandle selSetConfigurationFromDictionary_XHandle = Selector.GetHandle ("setConfigurationFromDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplayMode_X = "setDisplayMode:";
		static readonly NativeHandle selSetDisplayMode_XHandle = Selector.GetHandle ("setDisplayMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetItemIdentifiers_X = "setItemIdentifiers:";
		static readonly NativeHandle selSetItemIdentifiers_XHandle = Selector.GetHandle ("setItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedItemIdentifier_X = "setSelectedItemIdentifier:";
		static readonly NativeHandle selSetSelectedItemIdentifier_XHandle = Selector.GetHandle ("setSelectedItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsBaselineSeparator_X = "setShowsBaselineSeparator:";
		static readonly NativeHandle selSetShowsBaselineSeparator_XHandle = Selector.GetHandle ("setShowsBaselineSeparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSizeMode_X = "setSizeMode:";
		static readonly NativeHandle selSetSizeMode_XHandle = Selector.GetHandle ("setSizeMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVisible_X = "setVisible:";
		static readonly NativeHandle selSetVisible_XHandle = Selector.GetHandle ("setVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsBaselineSeparatorX = "showsBaselineSeparator";
		static readonly NativeHandle selShowsBaselineSeparatorXHandle = Selector.GetHandle ("showsBaselineSeparator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeModeX = "sizeMode";
		static readonly NativeHandle selSizeModeXHandle = Selector.GetHandle ("sizeMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateVisibleItemsX = "validateVisibleItems";
		static readonly NativeHandle selValidateVisibleItemsXHandle = Selector.GetHandle ("validateVisibleItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleItemsX = "visibleItems";
		static readonly NativeHandle selVisibleItemsXHandle = Selector.GetHandle ("visibleItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSToolbar");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSToolbar (NSObjectFlag t) : base (t)
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
		protected internal NSToolbar (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSToolbar ()
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithIdentifier:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSToolbar (string identifier)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithIdentifier_XHandle, nsidentifier), "initWithIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithIdentifier_XHandle, nsidentifier), "initWithIdentifier:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="itemIdentifier">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertItemWithItemIdentifier:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItem (string itemIdentifier, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertItemWithItemIdentifier_AtIndex_XHandle, nsitemIdentifier, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertItemWithItemIdentifier_AtIndex_XHandle, nsitemIdentifier, index);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsitemIdentifier);
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
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
		[Export ("removeItemWithItemIdentifier:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItem (string itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveItemWithItemIdentifier_XHandle, nsitemIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveItemWithItemIdentifier_XHandle, nsitemIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[Export ("runCustomizationPalette:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunCustomizationPalette (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRunCustomizationPalette_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunCustomizationPalette_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("setConfigurationFromDictionary:")]
		[ObsoletedOSPlatform ("macos15.0", "Use the 'ItemIdentifiers' and 'DisplayMode' properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use the 'ItemIdentifiers' and 'DisplayMode' properties instead.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetConfigurationFromDictionary (NSDictionary configDict)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var configDict__handle__ = configDict!.GetNonNullHandle (nameof (configDict));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConfigurationFromDictionary_XHandle, configDict__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConfigurationFromDictionary_XHandle, configDict__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (configDict);
		}
		[Export ("validateVisibleItems")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ValidateVisibleItems ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selValidateVisibleItemsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selValidateVisibleItemsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool AllowsDisplayModeCustomization {
			[Export ("allowsDisplayModeCustomization")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDisplayModeCustomizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDisplayModeCustomizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsDisplayModeCustomization:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsDisplayModeCustomization_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsDisplayModeCustomization_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AllowsExtensionItems {
			[Export ("allowsExtensionItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsExtensionItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsExtensionItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsExtensionItems:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsExtensionItems_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsExtensionItems_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsUserCustomization {
			[Export ("allowsUserCustomization")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsUserCustomizationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsUserCustomizationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsUserCustomization:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsUserCustomization_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsUserCustomization_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutosavesConfiguration {
			[Export ("autosavesConfiguration")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosavesConfigurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosavesConfigurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutosavesConfiguration:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutosavesConfiguration_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutosavesConfiguration_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.0", "'CenteredItemIdentifiers' should be used instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "'CenteredItemIdentifiers' should be used instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? CenteredItemIdentifier {
			[Export ("centeredItemIdentifier")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCenteredItemIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCenteredItemIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCenteredItemIdentifier:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCenteredItemIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCenteredItemIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual NSSet<NSString> CenteredItemIdentifiers {
			[Export ("centeredItemIdentifiers", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSet<NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCenteredItemIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCenteredItemIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCenteredItemIdentifiers:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCenteredItemIdentifiers_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCenteredItemIdentifiers_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "Use the 'ItemIdentifiers' and 'DisplayMode' properties instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use the 'ItemIdentifiers' and 'DisplayMode' properties instead.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSDictionary ConfigurationDictionary {
			[Export ("configurationDictionary")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConfigurationDictionaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConfigurationDictionaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSToolbarDelegate Delegate {
			get {
				return (WeakDelegate as INSToolbarDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSToolbarDisplayMode DisplayMode {
			[Export ("displayMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSToolbarDisplayMode ret;
				if (IsDirectBinding) {
					ret = (NSToolbarDisplayMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDisplayModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSToolbarDisplayMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDisplayModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDisplayMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDisplayMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCustomizationPaletteRunning {
			[Export ("customizationPaletteIsRunning")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCustomizationPaletteIsRunningXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCustomizationPaletteIsRunningXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual string[] ItemIdentifiers {
			[Export ("itemIdentifiers", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setItemIdentifiers:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetItemIdentifiers_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetItemIdentifiers_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSToolbarItem[] Items {
			[Export ("items")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSToolbarItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSToolbarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSToolbarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SelectedItemIdentifier {
			[Export ("selectedItemIdentifier")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedItemIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedItemIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedItemIdentifier:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectedItemIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectedItemIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos15.0", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsBaselineSeparator {
			[Export ("showsBaselineSeparator")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsBaselineSeparatorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsBaselineSeparatorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsBaselineSeparator:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsBaselineSeparator_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsBaselineSeparator_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSToolbarSizeMode SizeMode {
			[Export ("sizeMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSToolbarSizeMode ret;
				if (IsDirectBinding) {
					ret = (NSToolbarSizeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSizeModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSToolbarSizeMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSizeModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSizeMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSizeMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSizeMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Visible {
			[Export ("isVisible")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setVisible:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVisible_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetVisible_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSToolbarItem[]? VisibleItems {
			[Export ("visibleItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSToolbarItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSToolbarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVisibleItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSToolbarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVisibleItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarCloudSharingItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarCloudSharingItemIdentifier",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSToolbarCloudSharingItemIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSToolbarCloudSharingItemIdentifier is null)
					_NSToolbarCloudSharingItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarCloudSharingItemIdentifier")!;
				return _NSToolbarCloudSharingItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarCustomizeToolbarItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarCustomizeToolbarItemIdentifier",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos11.0", "Ignored by system.")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSToolbarCustomizeToolbarItemIdentifier {
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos11.0", "Ignored by system.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSToolbarCustomizeToolbarItemIdentifier is null)
					_NSToolbarCustomizeToolbarItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarCustomizeToolbarItemIdentifier")!;
				return _NSToolbarCustomizeToolbarItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarDidRemoveItemNotification;
		/// <summary>Notification posted after a toolbar removes an item.</summary><remarks>The notification payload can be accessed using <see cref="T:AppKit.NSToolbarItemEventArgs" />.</remarks>
		[Field ("NSToolbarDidRemoveItemNotification",  "AppKit")]
		[Advice ("Use NSToolbar.Notifications.ObserveNSToolbarDidRemoveItem helper method instead.")]
		public static NSString NSToolbarDidRemoveItemNotification {
			get {
				if (_NSToolbarDidRemoveItemNotification is null)
					_NSToolbarDidRemoveItemNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarDidRemoveItemNotification")!;
				return _NSToolbarDidRemoveItemNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarFlexibleSpaceItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarFlexibleSpaceItemIdentifier",  "AppKit")]
		public static NSString NSToolbarFlexibleSpaceItemIdentifier {
			get {
				if (_NSToolbarFlexibleSpaceItemIdentifier is null)
					_NSToolbarFlexibleSpaceItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarFlexibleSpaceItemIdentifier")!;
				return _NSToolbarFlexibleSpaceItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarInspectorTrackingSeparatorItemIdentifier;
		/// <summary>Represents the value associated with the constant 'NSToolbarInspectorTrackingSeparatorItemIdentifier'.</summary>
		[Field ("NSToolbarInspectorTrackingSeparatorItemIdentifier",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString NSToolbarInspectorTrackingSeparatorItemIdentifier {
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_NSToolbarInspectorTrackingSeparatorItemIdentifier is null)
					_NSToolbarInspectorTrackingSeparatorItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarInspectorTrackingSeparatorItemIdentifier")!;
				return _NSToolbarInspectorTrackingSeparatorItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarItemKey;
		/// <summary>Represents the value associated with the constant 'NSToolbarItemKey'.</summary>
		[Field ("NSToolbarItemKey",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		public static NSString NSToolbarItemKey {
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("macos13.0")]
			get {
				if (_NSToolbarItemKey is null)
					_NSToolbarItemKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarItemKey")!;
				return _NSToolbarItemKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarNewIndexKey;
		/// <summary>Represents the value associated with the constant 'NSToolbarNewIndexKey'.</summary>
		[Field ("NSToolbarNewIndexKey",  "AppKit")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString NSToolbarNewIndexKey {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_NSToolbarNewIndexKey is null)
					_NSToolbarNewIndexKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarNewIndexKey")!;
				return _NSToolbarNewIndexKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarPrintItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarPrintItemIdentifier",  "AppKit")]
		public static NSString NSToolbarPrintItemIdentifier {
			get {
				if (_NSToolbarPrintItemIdentifier is null)
					_NSToolbarPrintItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarPrintItemIdentifier")!;
				return _NSToolbarPrintItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarSeparatorItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarSeparatorItemIdentifier",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos11.0", "Ignored by system.")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSToolbarSeparatorItemIdentifier {
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos11.0", "Ignored by system.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSToolbarSeparatorItemIdentifier is null)
					_NSToolbarSeparatorItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarSeparatorItemIdentifier")!;
				return _NSToolbarSeparatorItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarShowColorsItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarShowColorsItemIdentifier",  "AppKit")]
		public static NSString NSToolbarShowColorsItemIdentifier {
			get {
				if (_NSToolbarShowColorsItemIdentifier is null)
					_NSToolbarShowColorsItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarShowColorsItemIdentifier")!;
				return _NSToolbarShowColorsItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarShowFontsItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarShowFontsItemIdentifier",  "AppKit")]
		public static NSString NSToolbarShowFontsItemIdentifier {
			get {
				if (_NSToolbarShowFontsItemIdentifier is null)
					_NSToolbarShowFontsItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarShowFontsItemIdentifier")!;
				return _NSToolbarShowFontsItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarSidebarTrackingSeparatorItemIdentifier;
		/// <summary>Represents the value associated with the constant 'NSToolbarSidebarTrackingSeparatorItemIdentifier'.</summary>
		[Field ("NSToolbarSidebarTrackingSeparatorItemIdentifier",  "AppKit")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSToolbarSidebarTrackingSeparatorItemIdentifier {
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSToolbarSidebarTrackingSeparatorItemIdentifier is null)
					_NSToolbarSidebarTrackingSeparatorItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarSidebarTrackingSeparatorItemIdentifier")!;
				return _NSToolbarSidebarTrackingSeparatorItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarSpaceItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarSpaceItemIdentifier",  "AppKit")]
		public static NSString NSToolbarSpaceItemIdentifier {
			get {
				if (_NSToolbarSpaceItemIdentifier is null)
					_NSToolbarSpaceItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarSpaceItemIdentifier")!;
				return _NSToolbarSpaceItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarToggleInspectorItemIdentifier;
		/// <summary>Represents the value associated with the constant 'NSToolbarToggleInspectorItemIdentifier'.</summary>
		[Field ("NSToolbarToggleInspectorItemIdentifier",  "AppKit")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString NSToolbarToggleInspectorItemIdentifier {
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_NSToolbarToggleInspectorItemIdentifier is null)
					_NSToolbarToggleInspectorItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarToggleInspectorItemIdentifier")!;
				return _NSToolbarToggleInspectorItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarToggleSidebarItemIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSToolbarToggleSidebarItemIdentifier",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSToolbarToggleSidebarItemIdentifier {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSToolbarToggleSidebarItemIdentifier is null)
					_NSToolbarToggleSidebarItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarToggleSidebarItemIdentifier")!;
				return _NSToolbarToggleSidebarItemIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarWillAddItemNotification;
		/// <summary>Notification posted when a toolbar is about to add an item.</summary><remarks>The notification payload can be accessed using <see cref="T:AppKit.NSToolbarItemEventArgs" />.</remarks>
		[Field ("NSToolbarWillAddItemNotification",  "AppKit")]
		[Advice ("Use NSToolbar.Notifications.ObserveNSToolbarWillAddItem helper method instead.")]
		public static NSString NSToolbarWillAddItemNotification {
			get {
				if (_NSToolbarWillAddItemNotification is null)
					_NSToolbarWillAddItemNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarWillAddItemNotification")!;
				return _NSToolbarWillAddItemNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSToolbarWritingToolsItemIdentifier;
		/// <summary>Represents the value associated with the constant 'NSToolbarWritingToolsItemIdentifier'.</summary>
		[Field ("NSToolbarWritingToolsItemIdentifier",  "AppKit")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public static NSString NSToolbarWritingToolsItemIdentifier {
			[SupportedOSPlatform ("macos15.2")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			get {
				if (_NSToolbarWritingToolsItemIdentifier is null)
					_NSToolbarWritingToolsItemIdentifier = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSToolbarWritingToolsItemIdentifier")!;
				return _NSToolbarWritingToolsItemIdentifier;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSToolbarDelegate); }
		}
		internal virtual _NSToolbarDelegate CreateInternalEventDelegateType ()
		{
			return (_NSToolbarDelegate)(new _NSToolbarDelegate());
		}
		internal _NSToolbarDelegate EnsureNSToolbarDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSToolbarDelegate;
			if (del is null){
				del = (_NSToolbarDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSToolbarDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSToolbarDelegate : NSObject, INSToolbarDelegate { 
			public _NSToolbarDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSToolbarDelegate))]
			static _NSToolbarDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal NSToolbarIdentifiers? allowedItemIdentifiers;
			[Export ("toolbarAllowedItemIdentifiers:")]
			public String[] AllowedItemIdentifiers (NSToolbar toolbar)
			{
				var handler = allowedItemIdentifiers;
				if (handler is not null)
					return handler (toolbar);
				return null!;
			}
			internal NSToolbarIdentifiers? defaultItemIdentifiers;
			[Export ("toolbarDefaultItemIdentifiers:")]
			public String[] DefaultItemIdentifiers (NSToolbar toolbar)
			{
				var handler = defaultItemIdentifiers;
				if (handler is not null)
					return handler (toolbar);
				return null!;
			}
			internal EventHandler? didRemoveItem;
			[Export ("toolbarDidRemoveItem:")]
			public void DidRemoveItem (NSNotification notification)
			{
				var handler = didRemoveItem;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal NSToolbarCanInsert? getItemCanBeInsertedAt;
			[Export ("toolbar:itemIdentifier:canBeInsertedAtIndex:")]
			public bool GetItemCanBeInsertedAt (NSToolbar toolbar, string itemIdentifier, IntPtr index)
			{
				var handler = getItemCanBeInsertedAt;
				if (handler is not null)
					return handler (toolbar, itemIdentifier, index);
				return true!;
			}
			internal NSToolbarImmovableItemIdentifiers? getToolbarImmovableItemIdentifiers;
			[Export ("toolbarImmovableItemIdentifiers:")]
			public global::Foundation.NSSet<NSString> GetToolbarImmovableItemIdentifiers (NSToolbar toolbar)
			{
				var handler = getToolbarImmovableItemIdentifiers;
				if (handler is not null)
					return handler (toolbar);
				return null!;
			}
			internal NSToolbarIdentifiers? selectableItemIdentifiers;
			[Export ("toolbarSelectableItemIdentifiers:")]
			public String[] SelectableItemIdentifiers (NSToolbar toolbar)
			{
				var handler = selectableItemIdentifiers;
				if (handler is not null)
					return handler (toolbar);
				return null!;
			}
			internal EventHandler? willAddItem;
			[Export ("toolbarWillAddItem:")]
			public void WillAddItem (NSNotification notification)
			{
				var handler = willAddItem;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal NSToolbarWillInsert? willInsertItem;
			[Export ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
			public NSToolbarItem? WillInsertItem (NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
			{
				var handler = willInsertItem;
				if (handler is not null)
					return handler (toolbar, itemIdentifier, willBeInserted);
				return null!;
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSToolbarIdentifiers? AllowedItemIdentifiers {
			get { return EnsureNSToolbarDelegate ()!.allowedItemIdentifiers; }
			set { EnsureNSToolbarDelegate ()!.allowedItemIdentifiers = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSToolbarIdentifiers? DefaultItemIdentifiers {
			get { return EnsureNSToolbarDelegate ()!.defaultItemIdentifiers; }
			set { EnsureNSToolbarDelegate ()!.defaultItemIdentifiers = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler DidRemoveItem {
			add { EnsureNSToolbarDelegate ()!.didRemoveItem += value; }
			remove { EnsureNSToolbarDelegate ()!.didRemoveItem -= value; }
		}
		public NSToolbarCanInsert? GetItemCanBeInsertedAt {
			get { return EnsureNSToolbarDelegate ()!.getItemCanBeInsertedAt; }
			set { EnsureNSToolbarDelegate ()!.getItemCanBeInsertedAt = value; }
		}
		public NSToolbarImmovableItemIdentifiers? GetToolbarImmovableItemIdentifiers {
			get { return EnsureNSToolbarDelegate ()!.getToolbarImmovableItemIdentifiers; }
			set { EnsureNSToolbarDelegate ()!.getToolbarImmovableItemIdentifiers = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSToolbarIdentifiers? SelectableItemIdentifiers {
			get { return EnsureNSToolbarDelegate ()!.selectableItemIdentifiers; }
			set { EnsureNSToolbarDelegate ()!.selectableItemIdentifiers = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler WillAddItem {
			add { EnsureNSToolbarDelegate ()!.willAddItem += value; }
			remove { EnsureNSToolbarDelegate ()!.willAddItem -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSToolbarWillInsert? WillInsertItem {
			get { return EnsureNSToolbarDelegate ()!.willInsertItem; }
			set { EnsureNSToolbarDelegate ()!.willInsertItem = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSToolbar" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSToolbar.NSToolbarDidRemoveItemNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSToolbar.NSToolbarDidRemoveItemNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSToolbar.Notifications.ObserveNSToolbarDidRemoveItem ((notification) => {
			///   Console.WriteLine ("Observed NSToolbarDidRemoveItemNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNSToolbarDidRemoveItem (EventHandler<AppKit.NSToolbarItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NSToolbarDidRemoveItemNotification, notification => handler (null, new AppKit.NSToolbarItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSToolbar.NSToolbarDidRemoveItemNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSToolbar.NSToolbarDidRemoveItemNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSToolbar.Notifications.ObserveNSToolbarDidRemoveItem (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NSToolbarDidRemoveItemNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNSToolbarDidRemoveItem (NSObject objectToObserve, EventHandler<AppKit.NSToolbarItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NSToolbarDidRemoveItemNotification, notification => handler (null, new AppKit.NSToolbarItemEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSToolbar.NSToolbarWillAddItemNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSToolbar.NSToolbarWillAddItemNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSToolbar.Notifications.ObserveNSToolbarWillAddItem ((notification) => {
			///   Console.WriteLine ("Observed NSToolbarWillAddItemNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNSToolbarWillAddItem (EventHandler<AppKit.NSToolbarItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NSToolbarWillAddItemNotification, notification => handler (null, new AppKit.NSToolbarItemEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSToolbar.NSToolbarWillAddItemNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSToolbar.NSToolbarWillAddItemNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSToolbar.Notifications.ObserveNSToolbarWillAddItem (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed NSToolbarWillAddItemNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveNSToolbarWillAddItem (NSObject objectToObserve, EventHandler<AppKit.NSToolbarItemEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (NSToolbarWillAddItemNotification, notification => handler (null, new AppKit.NSToolbarItemEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSToolbar */
}
