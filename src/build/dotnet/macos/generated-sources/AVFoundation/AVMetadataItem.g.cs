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
namespace AVFoundation {
	[Register("AVMetadataItem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVMetadataItem : NSObject, INSCopying, INSMutableCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommonKeyX = "commonKey";
		static readonly NativeHandle selCommonKeyXHandle = Selector.GetHandle ("commonKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataTypeX = "dataType";
		static readonly NativeHandle selDataTypeXHandle = Selector.GetHandle ("dataType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataValueX = "dataValue";
		static readonly NativeHandle selDataValueXHandle = Selector.GetHandle ("dataValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateValueX = "dateValue";
		static readonly NativeHandle selDateValueXHandle = Selector.GetHandle ("dateValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtendedLanguageTagX = "extendedLanguageTag";
		static readonly NativeHandle selExtendedLanguageTagXHandle = Selector.GetHandle ("extendedLanguageTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtraAttributesX = "extraAttributes";
		static readonly NativeHandle selExtraAttributesXHandle = Selector.GetHandle ("extraAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierForKey_KeySpace_X = "identifierForKey:keySpace:";
		static readonly NativeHandle selIdentifierForKey_KeySpace_XHandle = Selector.GetHandle ("identifierForKey:keySpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyX = "key";
		static readonly NativeHandle selKeyXHandle = Selector.GetHandle ("key");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyForIdentifier_X = "keyForIdentifier:";
		static readonly NativeHandle selKeyForIdentifier_XHandle = Selector.GetHandle ("keyForIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeySpaceX = "keySpace";
		static readonly NativeHandle selKeySpaceXHandle = Selector.GetHandle ("keySpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeySpaceForIdentifier_X = "keySpaceForIdentifier:";
		static readonly NativeHandle selKeySpaceForIdentifier_XHandle = Selector.GetHandle ("keySpaceForIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadValuesAsynchronouslyForKeys_CompletionHandler_X = "loadValuesAsynchronouslyForKeys:completionHandler:";
		static readonly NativeHandle selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle = Selector.GetHandle ("loadValuesAsynchronouslyForKeys:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocaleX = "locale";
		static readonly NativeHandle selLocaleXHandle = Selector.GetHandle ("locale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_X = "metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:";
		static readonly NativeHandle selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_XHandle = Selector.GetHandle ("metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_X = "metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:";
		static readonly NativeHandle selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_XHandle = Selector.GetHandle ("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemsFromArray_FilteredByIdentifier_X = "metadataItemsFromArray:filteredByIdentifier:";
		static readonly NativeHandle selMetadataItemsFromArray_FilteredByIdentifier_XHandle = Selector.GetHandle ("metadataItemsFromArray:filteredByIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemsFromArray_FilteredByMetadataItemFilter_X = "metadataItemsFromArray:filteredByMetadataItemFilter:";
		static readonly NativeHandle selMetadataItemsFromArray_FilteredByMetadataItemFilter_XHandle = Selector.GetHandle ("metadataItemsFromArray:filteredByMetadataItemFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemsFromArray_WithKey_KeySpace_X = "metadataItemsFromArray:withKey:keySpace:";
		static readonly NativeHandle selMetadataItemsFromArray_WithKey_KeySpace_XHandle = Selector.GetHandle ("metadataItemsFromArray:withKey:keySpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataItemsFromArray_WithLocale_X = "metadataItemsFromArray:withLocale:";
		static readonly NativeHandle selMetadataItemsFromArray_WithLocale_XHandle = Selector.GetHandle ("metadataItemsFromArray:withLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberValueX = "numberValue";
		static readonly NativeHandle selNumberValueXHandle = Selector.GetHandle ("numberValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusOfValueForKey_Error_X = "statusOfValueForKey:error:";
		static readonly NativeHandle selStatusOfValueForKey_Error_XHandle = Selector.GetHandle ("statusOfValueForKey:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringValueX = "stringValue";
		static readonly NativeHandle selStringValueXHandle = Selector.GetHandle ("stringValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeX = "time";
		static readonly NativeHandle selTimeXHandle = Selector.GetHandle ("time");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueX = "value";
		static readonly NativeHandle selValueXHandle = Selector.GetHandle ("value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVMetadataItem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVMetadataItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVMetadataItem () : base (NSObjectFlag.Empty)
		{
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
		protected AVMetadataItem (NSObjectFlag t) : base (t)
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
		protected internal AVMetadataItem (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMetadataItem[] FilterFromPreferredLanguages (AVMetadataItem[] metadataItems, string[] preferredLanguages)
		{
			if (metadataItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataItems));
			if (preferredLanguages is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (preferredLanguages));
			using var nsa_metadataItems = NSArray.FromNSObjects (metadataItems);
			using var nsa_preferredLanguages = NSArray.FromStrings (preferredLanguages);
			AVMetadataItem[] ret;
			ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_XHandle, nsa_metadataItems.Handle, nsa_preferredLanguages.Handle), false)!;
			return ret;
		}
		[Export ("metadataItemsFromArray:filteredByIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMetadataItem[] FilterWithIdentifier (AVMetadataItem[] metadataItems, NSString metadataIdentifer)
		{
			if (metadataItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataItems));
			var metadataIdentifer__handle__ = metadataIdentifer!.GetNonNullHandle (nameof (metadataIdentifer));
			using var nsa_metadataItems = NSArray.FromNSObjects (metadataItems);
			AVMetadataItem[]? ret;
			ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMetadataItemsFromArray_FilteredByIdentifier_XHandle, nsa_metadataItems.Handle, metadataIdentifer__handle__), false)!;
			GC.KeepAlive (metadataIdentifer);
			return ret!;
		}
		[Export ("metadataItemsFromArray:filteredByMetadataItemFilter:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMetadataItem[] FilterWithItemFilter (AVMetadataItem[] metadataItems, AVMetadataItemFilter metadataItemFilter)
		{
			if (metadataItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataItems));
			var metadataItemFilter__handle__ = metadataItemFilter!.GetNonNullHandle (nameof (metadataItemFilter));
			using var nsa_metadataItems = NSArray.FromNSObjects (metadataItems);
			AVMetadataItem[]? ret;
			ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMetadataItemsFromArray_FilteredByMetadataItemFilter_XHandle, nsa_metadataItems.Handle, metadataItemFilter__handle__), false)!;
			GC.KeepAlive (metadataItemFilter);
			return ret!;
		}
		[Export ("metadataItemsFromArray:withKey:keySpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMetadataItem[] FilterWithKey (AVMetadataItem[] metadataItems, NSObject? key, string? keySpace)
		{
			if (metadataItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (metadataItems));
			var key__handle__ = key.GetHandle ();
			using var nsa_metadataItems = NSArray.FromNSObjects (metadataItems);
			var nskeySpace = CFString.CreateNative (keySpace);
			AVMetadataItem[]? ret;
			ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selMetadataItemsFromArray_WithKey_KeySpace_XHandle, nsa_metadataItems.Handle, key__handle__, nskeySpace), false)!;
			GC.KeepAlive (key);
			CFString.ReleaseNative (nskeySpace);
			return ret!;
		}
		[Export ("metadataItemsFromArray:withLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVMetadataItem[] FilterWithLocale (AVMetadataItem[] arrayToFilter, NSLocale locale)
		{
			if (arrayToFilter is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arrayToFilter));
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			using var nsa_arrayToFilter = NSArray.FromNSObjects (arrayToFilter);
			AVMetadataItem[]? ret;
			ret = CFArray.ArrayFromHandle<AVMetadataItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMetadataItemsFromArray_WithLocale_XHandle, nsa_arrayToFilter.Handle, locale__handle__), false)!;
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("keyForIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetKeyForIdentifier (NSString identifier)
		{
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selKeyForIdentifier_XHandle, identifier__handle__), false)!;
			GC.KeepAlive (identifier);
			return ret!;
		}
		[Export ("keySpaceForIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString? GetKeySpaceForIdentifier (NSString identifier)
		{
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selKeySpaceForIdentifier_XHandle, identifier__handle__), false)!;
			GC.KeepAlive (identifier);
			return ret!;
		}
		[Export ("identifierForKey:keySpace:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString? GetMetadataIdentifier (NSObject key, NSString keySpace)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			var keySpace__handle__ = keySpace!.GetNonNullHandle (nameof (keySpace));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selIdentifierForKey_KeySpace_XHandle, key__handle__, keySpace__handle__), false)!;
			GC.KeepAlive (key);
			GC.KeepAlive (keySpace);
			return ret!;
		}
		[Export ("metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVMetadataItem GetMetadataItem (AVMetadataItem metadataItem, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V7))]global::System.Action<AVMetadataItemValueRequest> handler)
		{
			var metadataItem__handle__ = metadataItem!.GetNonNullHandle (nameof (metadataItem));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V7.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			AVMetadataItem? ret;
			ret =  Runtime.GetNSObject<AVMetadataItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_XHandle, metadataItem__handle__, (IntPtr) block_ptr_handler), false)!;
			GC.KeepAlive (metadataItem);
			return ret!;
		}
		[Export ("loadValuesAsynchronouslyForKeys:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadValuesAsynchronously (string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromStrings (keys);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle, nsa_keys.Handle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadValuesAsynchronouslyForKeys_CompletionHandler_XHandle, nsa_keys.Handle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="keys">To be added.</param>
		/// <summary>Asynchronously loads the specific keys if they are not loaded already and runs a handler after the operation completes.</summary>
		/// <returns>A task that represents the asynchronous LoadValuesAsynchronously operation</returns>
		/// <remarks>
		///           <para copied="true">The LoadValuesTaskAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task LoadValuesTaskAsync (string[] keys)
		{
			var tcs = new TaskCompletionSource<bool> ();
			LoadValuesAsynchronously(keys, () => {
				tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("statusOfValueForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVKeyValueStatus StatusOfValueForKeyerror (string key, out NSError error)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			AVKeyValueStatus ret;
			if (IsDirectBinding) {
				ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selStatusOfValueForKey_Error_XHandle, nskey, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selStatusOfValueForKey_Error_XHandle, nskey, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CommonKey {
			[Export ("commonKey", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCommonKeyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCommonKeyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString? DataType {
			[Export ("dataType")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? DataValue {
			[Export ("dataValue")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? DateValue {
			[Export ("dateValue")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDateValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDateValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime Duration {
			[Export ("duration")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selDurationXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selDurationXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selDurationXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? ExtendedLanguageTag {
			[Export ("extendedLanguageTag")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtendedLanguageTagXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtendedLanguageTagXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? ExtraAttributes {
			[Export ("extraAttributes", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtraAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtraAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Key {
			[Export ("key", ArgumentSemantic.Copy)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? KeySpace {
			[Export ("keySpace", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeySpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeySpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLocale? Locale {
			[Export ("locale", ArgumentSemantic.Copy)]
			get {
				NSLocale? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocaleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocaleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString? MetadataIdentifier {
			[Export ("identifier")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? NumberValue {
			[Export ("numberValue")]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNumberValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNumberValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSDate? StartDate {
			[Export ("startDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? StringValue {
			[Export ("stringValue")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMTime Time {
			[Export ("time")]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend (this.Handle, selTimeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSend_stret (this.Handle, selTimeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper (&__objc_super__, selTimeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CMTime_objc_msgSendSuper_stret (&__objc_super__, selTimeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Value {
			[Export ("value", ArgumentSemantic.Copy)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
	} /* class AVMetadataItem */
}
