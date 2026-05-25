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
	[Register("NSFontManager", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFontManager : NSObject, INSMenuItemValidation {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionX = "action";
		static readonly NativeHandle selActionXHandle = Selector.GetHandle ("action");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddCollection_Options_X = "addCollection:options:";
		static readonly NativeHandle selAddCollection_Options_XHandle = Selector.GetHandle ("addCollection:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddFontDescriptors_ToCollection_X = "addFontDescriptors:toCollection:";
		static readonly NativeHandle selAddFontDescriptors_ToCollection_XHandle = Selector.GetHandle ("addFontDescriptors:toCollection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddFontTrait_X = "addFontTrait:";
		static readonly NativeHandle selAddFontTrait_XHandle = Selector.GetHandle ("addFontTrait:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableFontFamiliesX = "availableFontFamilies";
		static readonly NativeHandle selAvailableFontFamiliesXHandle = Selector.GetHandle ("availableFontFamilies");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableFontNamesMatchingFontDescriptor_X = "availableFontNamesMatchingFontDescriptor:";
		static readonly NativeHandle selAvailableFontNamesMatchingFontDescriptor_XHandle = Selector.GetHandle ("availableFontNamesMatchingFontDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableFontNamesWithTraits_X = "availableFontNamesWithTraits:";
		static readonly NativeHandle selAvailableFontNamesWithTraits_XHandle = Selector.GetHandle ("availableFontNamesWithTraits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableFontsX = "availableFonts";
		static readonly NativeHandle selAvailableFontsXHandle = Selector.GetHandle ("availableFonts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableMembersOfFontFamily_X = "availableMembersOfFontFamily:";
		static readonly NativeHandle selAvailableMembersOfFontFamily_XHandle = Selector.GetHandle ("availableMembersOfFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionNamesX = "collectionNames";
		static readonly NativeHandle selCollectionNamesXHandle = Selector.GetHandle ("collectionNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertAttributes_X = "convertAttributes:";
		static readonly NativeHandle selConvertAttributes_XHandle = Selector.GetHandle ("convertAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_X = "convertFont:";
		static readonly NativeHandle selConvertFont_XHandle = Selector.GetHandle ("convertFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_ToFace_X = "convertFont:toFace:";
		static readonly NativeHandle selConvertFont_ToFace_XHandle = Selector.GetHandle ("convertFont:toFace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_ToFamily_X = "convertFont:toFamily:";
		static readonly NativeHandle selConvertFont_ToFamily_XHandle = Selector.GetHandle ("convertFont:toFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_ToHaveTrait_X = "convertFont:toHaveTrait:";
		static readonly NativeHandle selConvertFont_ToHaveTrait_XHandle = Selector.GetHandle ("convertFont:toHaveTrait:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_ToNotHaveTrait_X = "convertFont:toNotHaveTrait:";
		static readonly NativeHandle selConvertFont_ToNotHaveTrait_XHandle = Selector.GetHandle ("convertFont:toNotHaveTrait:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFont_ToSize_X = "convertFont:toSize:";
		static readonly NativeHandle selConvertFont_ToSize_XHandle = Selector.GetHandle ("convertFont:toSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertFontTraits_X = "convertFontTraits:";
		static readonly NativeHandle selConvertFontTraits_XHandle = Selector.GetHandle ("convertFontTraits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertWeight_OfFont_X = "convertWeight:ofFont:";
		static readonly NativeHandle selConvertWeight_OfFont_XHandle = Selector.GetHandle ("convertWeight:ofFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentFontActionX = "currentFontAction";
		static readonly NativeHandle selCurrentFontActionXHandle = Selector.GetHandle ("currentFontAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorsInCollection_X = "fontDescriptorsInCollection:";
		static readonly NativeHandle selFontDescriptorsInCollection_XHandle = Selector.GetHandle ("fontDescriptorsInCollection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontMenu_X = "fontMenu:";
		static readonly NativeHandle selFontMenu_XHandle = Selector.GetHandle ("fontMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontNamed_HasTraits_X = "fontNamed:hasTraits:";
		static readonly NativeHandle selFontNamed_HasTraits_XHandle = Selector.GetHandle ("fontNamed:hasTraits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontPanel_X = "fontPanel:";
		static readonly NativeHandle selFontPanel_XHandle = Selector.GetHandle ("fontPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontWithFamily_Traits_Weight_Size_X = "fontWithFamily:traits:weight:size:";
		static readonly NativeHandle selFontWithFamily_Traits_Weight_Size_XHandle = Selector.GetHandle ("fontWithFamily:traits:weight:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMultipleX = "isMultiple";
		static readonly NativeHandle selIsMultipleXHandle = Selector.GetHandle ("isMultiple");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedNameForFamily_Face_X = "localizedNameForFamily:face:";
		static readonly NativeHandle selLocalizedNameForFamily_Face_XHandle = Selector.GetHandle ("localizedNameForFamily:face:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModifyFont_X = "modifyFont:";
		static readonly NativeHandle selModifyFont_XHandle = Selector.GetHandle ("modifyFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModifyFontViaPanel_X = "modifyFontViaPanel:";
		static readonly NativeHandle selModifyFontViaPanel_XHandle = Selector.GetHandle ("modifyFontViaPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontFontPanel_X = "orderFrontFontPanel:";
		static readonly NativeHandle selOrderFrontFontPanel_XHandle = Selector.GetHandle ("orderFrontFontPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontStylesPanel_X = "orderFrontStylesPanel:";
		static readonly NativeHandle selOrderFrontStylesPanel_XHandle = Selector.GetHandle ("orderFrontStylesPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCollection_X = "removeCollection:";
		static readonly NativeHandle selRemoveCollection_XHandle = Selector.GetHandle ("removeCollection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFontDescriptor_FromCollection_X = "removeFontDescriptor:fromCollection:";
		static readonly NativeHandle selRemoveFontDescriptor_FromCollection_XHandle = Selector.GetHandle ("removeFontDescriptor:fromCollection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFontTrait_X = "removeFontTrait:";
		static readonly NativeHandle selRemoveFontTrait_XHandle = Selector.GetHandle ("removeFontTrait:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedFontX = "selectedFont";
		static readonly NativeHandle selSelectedFontXHandle = Selector.GetHandle ("selectedFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendActionX = "sendAction";
		static readonly NativeHandle selSendActionXHandle = Selector.GetHandle ("sendAction");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAction_X = "setAction:";
		static readonly NativeHandle selSetAction_XHandle = Selector.GetHandle ("setAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFontManagerFactory_X = "setFontManagerFactory:";
		static readonly NativeHandle selSetFontManagerFactory_XHandle = Selector.GetHandle ("setFontManagerFactory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFontMenu_X = "setFontMenu:";
		static readonly NativeHandle selSetFontMenu_XHandle = Selector.GetHandle ("setFontMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFontPanelFactory_X = "setFontPanelFactory:";
		static readonly NativeHandle selSetFontPanelFactory_XHandle = Selector.GetHandle ("setFontPanelFactory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedAttributes_IsMultiple_X = "setSelectedAttributes:isMultiple:";
		static readonly NativeHandle selSetSelectedAttributes_IsMultiple_XHandle = Selector.GetHandle ("setSelectedAttributes:isMultiple:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedFont_IsMultiple_X = "setSelectedFont:isMultiple:";
		static readonly NativeHandle selSetSelectedFont_IsMultiple_XHandle = Selector.GetHandle ("setSelectedFont:isMultiple:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTarget_X = "setTarget:";
		static readonly NativeHandle selSetTarget_XHandle = Selector.GetHandle ("setTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedFontManagerX = "sharedFontManager";
		static readonly NativeHandle selSharedFontManagerXHandle = Selector.GetHandle ("sharedFontManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetX = "target";
		static readonly NativeHandle selTargetXHandle = Selector.GetHandle ("target");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTraitsOfFont_X = "traitsOfFont:";
		static readonly NativeHandle selTraitsOfFont_XHandle = Selector.GetHandle ("traitsOfFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateMenuItem_X = "validateMenuItem:";
		static readonly NativeHandle selValidateMenuItem_XHandle = Selector.GetHandle ("validateMenuItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeightOfFont_X = "weightOfFont:";
		static readonly NativeHandle selWeightOfFont_XHandle = Selector.GetHandle ("weightOfFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFontManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFontManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFontManager () : base (NSObjectFlag.Empty)
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
		protected NSFontManager (NSObjectFlag t) : base (t)
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
		protected internal NSFontManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addCollection:options:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSFontCollection.ShowFontCollection (NSFontCollection, string, NSFontCollectionVisibility, out NSError)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddCollection (string collectionName, NSFontCollectionOptions collectionOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (collectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collectionName));
			var nscollectionName = CFString.CreateNative (collectionName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (this.Handle, selAddCollection_Options_XHandle, nscollectionName, (IntPtr) (long) collectionOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selAddCollection_Options_XHandle, nscollectionName, (IntPtr) (long) collectionOptions);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscollectionName);
			return ret != 0;
		}
		[Export ("addFontDescriptors:toCollection:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSMutableFontCollection.AddQueryForDescriptors' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddFontDescriptors (NSFontDescriptor[] descriptors, string collectionName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (descriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptors));
			if (collectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collectionName));
			using var nsa_descriptors = NSArray.FromNSObjects (descriptors);
			var nscollectionName = CFString.CreateNative (collectionName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddFontDescriptors_ToCollection_XHandle, nsa_descriptors.Handle, nscollectionName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddFontDescriptors_ToCollection_XHandle, nsa_descriptors.Handle, nscollectionName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscollectionName);
		}
		[Export ("addFontTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddFontTrait (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddFontTrait_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddFontTrait_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("availableFontNamesMatchingFontDescriptor:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSFontDescriptor.MatchingFontDescriptors' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableFontNamesMatchingFontDescriptor (NSFontDescriptor descriptor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAvailableFontNamesMatchingFontDescriptor_XHandle, descriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAvailableFontNamesMatchingFontDescriptor_XHandle, descriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("availableFontNamesWithTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableFontNamesWithTraits (NSFontTraitMask someTraits)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selAvailableFontNamesWithTraits_XHandle, (UIntPtr) (ulong) someTraits), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selAvailableFontNamesWithTraits_XHandle, (UIntPtr) (ulong) someTraits), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("availableMembersOfFontFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray[] AvailableMembersOfFontFamily (string fam)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fam is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fam));
			var nsfam = CFString.CreateNative (fam);
			NSArray[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSArray>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAvailableMembersOfFontFamily_XHandle, nsfam), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSArray>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAvailableMembersOfFontFamily_XHandle, nsfam), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfam);
			return ret!;
		}
		[Export ("convertAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ConvertAttributes (NSDictionary attributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selConvertAttributes_XHandle, attributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selConvertAttributes_XHandle, attributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("convertFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFont (NSFont fontObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selConvertFont_XHandle, fontObj__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selConvertFont_XHandle, fontObj__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[Export ("convertFont:toSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFont (NSFont fontObj, nfloat size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, selConvertFont_ToSize_XHandle, fontObj__handle__, size), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, selConvertFont_ToSize_XHandle, fontObj__handle__, size), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[Export ("convertFont:toFace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFont (NSFont fontObj, string typeface)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			if (typeface is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeface));
			var nstypeface = CFString.CreateNative (typeface);
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConvertFont_ToFace_XHandle, fontObj__handle__, nstypeface), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConvertFont_ToFace_XHandle, fontObj__handle__, nstypeface), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			CFString.ReleaseNative (nstypeface);
			return ret!;
		}
		[Export ("convertFont:toHaveTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFont (NSFont fontObj, NSFontTraitMask trait)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selConvertFont_ToHaveTrait_XHandle, fontObj__handle__, (UIntPtr) (ulong) trait), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selConvertFont_ToHaveTrait_XHandle, fontObj__handle__, (UIntPtr) (ulong) trait), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[Export ("convertFont:toFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFontToFamily (NSFont fontObj, string family)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var nsfamily = CFString.CreateNative (family);
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selConvertFont_ToFamily_XHandle, fontObj__handle__, nsfamily), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selConvertFont_ToFamily_XHandle, fontObj__handle__, nsfamily), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			CFString.ReleaseNative (nsfamily);
			return ret!;
		}
		[Export ("convertFont:toNotHaveTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertFontToNotHaveTrait (NSFont fontObj, NSFontTraitMask trait)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selConvertFont_ToNotHaveTrait_XHandle, fontObj__handle__, (UIntPtr) (ulong) trait), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selConvertFont_ToNotHaveTrait_XHandle, fontObj__handle__, (UIntPtr) (ulong) trait), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[Export ("convertFontTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontTraitMask ConvertFontTraits (NSFontTraitMask traits)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontTraitMask ret;
			if (IsDirectBinding) {
				ret = (NSFontTraitMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selConvertFontTraits_XHandle, (UIntPtr) (ulong) traits);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSFontTraitMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selConvertFontTraits_XHandle, (UIntPtr) (ulong) traits);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("convertWeight:ofFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont ConvertWeight (bool increaseWeight, NSFont fontObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_NativeHandle (this.Handle, selConvertWeight_OfFont_XHandle, increaseWeight ? (byte) 1 : (byte) 0, fontObj__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selConvertWeight_OfFont_XHandle, increaseWeight ? (byte) 1 : (byte) 0, fontObj__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[Export ("fontDescriptorsInCollection:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSFontCollection.GetMatchingDescriptors ()' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray FontDescriptorsInCollection (string collectionNames)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (collectionNames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collectionNames));
			var nscollectionNames = CFString.CreateNative (collectionNames);
			NSArray? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorsInCollection_XHandle, nscollectionNames), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorsInCollection_XHandle, nscollectionNames), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscollectionNames);
			return ret!;
		}
		[Export ("fontMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu FontMenu (bool create)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSMenu ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selFontMenu_XHandle, create ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selFontMenu_XHandle, create ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fontNamed:hasTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FontNamedHasTraits (string fName, NSFontTraitMask someTraits)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fName));
			var nsfName = CFString.CreateNative (fName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selFontNamed_HasTraits_XHandle, nsfName, (UIntPtr) (ulong) someTraits);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selFontNamed_HasTraits_XHandle, nsfName, (UIntPtr) (ulong) someTraits);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfName);
			return ret != 0;
		}
		[Export ("fontPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontPanel FontPanel (bool create)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontPanel ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selFontPanel_XHandle, create ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selFontPanel_XHandle, create ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fontWithFamily:traits:weight:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont FontWithFamily (string family, NSFontTraitMask traits, nint weight, nfloat size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var nsfamily = CFString.CreateNative (family);
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_nfloat (this.Handle, selFontWithFamily_Traits_Weight_Size_XHandle, nsfamily, (UIntPtr) (ulong) traits, weight, size), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr_nfloat (&__objc_super__, selFontWithFamily_Traits_Weight_Size_XHandle, nsfamily, (UIntPtr) (ulong) traits, weight, size), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfamily);
			return ret!;
		}
		[Export ("localizedNameForFamily:face:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedNameForFamily (string family, string faceKey)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			if (faceKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (faceKey));
			var nsfamily = CFString.CreateNative (family);
			var nsfaceKey = CFString.CreateNative (faceKey);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLocalizedNameForFamily_Face_XHandle, nsfamily, nsfaceKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLocalizedNameForFamily_Face_XHandle, nsfamily, nsfaceKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfamily);
			CFString.ReleaseNative (nsfaceKey);
			return ret!;
		}
		[Export ("modifyFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModifyFont (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selModifyFont_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selModifyFont_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("modifyFontViaPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModifyFontViaPanel (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selModifyFontViaPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selModifyFontViaPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontFontPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontFontPanel (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontFontPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontFontPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontStylesPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontStylesPanel (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontStylesPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontStylesPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("removeCollection:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'HideFontCollection (string, NSFontCollectionVisibility, out NSError)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveCollection (string collectionName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (collectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collectionName));
			var nscollectionName = CFString.CreateNative (collectionName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRemoveCollection_XHandle, nscollectionName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCollection_XHandle, nscollectionName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscollectionName);
			return ret != 0;
		}
		[Export ("removeFontDescriptor:fromCollection:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSMutableFontCollection.RemoveQueryForDescriptors' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFontDescriptor (NSFontDescriptor descriptor, string collection)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (collection is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collection));
			var nscollection = CFString.CreateNative (collection);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveFontDescriptor_FromCollection_XHandle, descriptor__handle__, nscollection);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveFontDescriptor_FromCollection_XHandle, descriptor__handle__, nscollection);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nscollection);
		}
		[Export ("removeFontTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFontTrait (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveFontTrait_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveFontTrait_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("setFontManagerFactory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFontManagerFactory (Class factoryId)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var factoryId__handle__ = factoryId!.GetNonNullHandle (nameof (factoryId));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetFontManagerFactory_XHandle, factoryId.Handle);
			GC.KeepAlive (factoryId);
		}
		[Export ("setFontMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFontMenu (NSMenu newMenu)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newMenu__handle__ = newMenu!.GetNonNullHandle (nameof (newMenu));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFontMenu_XHandle, newMenu__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFontMenu_XHandle, newMenu__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newMenu);
		}
		[Export ("setFontPanelFactory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFontPanelFactory (Class factoryId)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var factoryId__handle__ = factoryId!.GetNonNullHandle (nameof (factoryId));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetFontPanelFactory_XHandle, factoryId.Handle);
			GC.KeepAlive (factoryId);
		}
		[Export ("setSelectedAttributes:isMultiple:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedAttributes (NSDictionary attributes, bool isMultiple)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetSelectedAttributes_IsMultiple_XHandle, attributes__handle__, isMultiple ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetSelectedAttributes_IsMultiple_XHandle, attributes__handle__, isMultiple ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
		}
		[Export ("setSelectedFont:isMultiple:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedFont (NSFont fontObj, bool isMultiple)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selSetSelectedFont_IsMultiple_XHandle, fontObj__handle__, isMultiple ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selSetSelectedFont_IsMultiple_XHandle, fontObj__handle__, isMultiple ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
		}
		[Export ("traitsOfFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontTraitMask TraitsOfFont (NSFont fontObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			NSFontTraitMask ret;
			if (IsDirectBinding) {
				ret = (NSFontTraitMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selTraitsOfFont_XHandle, fontObj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSFontTraitMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selTraitsOfFont_XHandle, fontObj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateMenuItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateMenuItem (NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateMenuItem_XHandle, menuItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateMenuItem_XHandle, menuItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
		[Export ("weightOfFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint WeightOfFont (NSFont fontObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontObj__handle__ = fontObj!.GetNonNullHandle (nameof (fontObj));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selWeightOfFont_XHandle, fontObj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selWeightOfFont_XHandle, fontObj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fontObj);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? Action {
			[Export ("action")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAction:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAction_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAction_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableFontFamilies {
			[Export ("availableFontFamilies")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableFontFamiliesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableFontFamiliesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableFonts {
			[Export ("availableFonts")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAvailableFontsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAvailableFontsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11", "Use 'NSFontCollection.AllFontCollectionNames' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string[] CollectionNames {
			[Export ("collectionNames")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollectionNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollectionNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CurrentFontAction {
			[Export ("currentFontAction")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentFontActionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCurrentFontActionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMultiple {
			[Export ("isMultiple")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMultipleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsMultipleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont SelectedFont {
			[Export ("selectedFont")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFont? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedFontXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedFontXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SendAction {
			[Export ("sendAction")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSendActionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSendActionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontManager SharedFontManager {
			[Export ("sharedFontManager")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFontManager? ret;
				ret =  Runtime.GetNSObject<NSFontManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedFontManagerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Target_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Target {
			[Export ("target", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTargetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTargetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTarget_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTarget_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Target_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Target_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSFontManager */
}
