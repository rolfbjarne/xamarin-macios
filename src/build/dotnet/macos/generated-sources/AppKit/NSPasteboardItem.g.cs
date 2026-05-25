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
	[Register("NSPasteboardItem", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPasteboardItem : NSObject, INSPasteboardReading, INSPasteboardWriting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableTypeFromArray_X = "availableTypeFromArray:";
		static readonly NativeHandle selAvailableTypeFromArray_XHandle = Selector.GetHandle ("availableTypeFromArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollaborationMetadataX = "collaborationMetadata";
		static readonly NativeHandle selCollaborationMetadataXHandle = Selector.GetHandle ("collaborationMetadata");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataForType_X = "dataForType:";
		static readonly NativeHandle selDataForType_XHandle = Selector.GetHandle ("dataForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetectMetadataForTypes_CompletionHandler_X = "detectMetadataForTypes:completionHandler:";
		static readonly NativeHandle selDetectMetadataForTypes_CompletionHandler_XHandle = Selector.GetHandle ("detectMetadataForTypes:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetectPatternsForPatterns_CompletionHandler_X = "detectPatternsForPatterns:completionHandler:";
		static readonly NativeHandle selDetectPatternsForPatterns_CompletionHandler_XHandle = Selector.GetHandle ("detectPatternsForPatterns:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetectValuesForPatterns_CompletionHandler_X = "detectValuesForPatterns:completionHandler:";
		static readonly NativeHandle selDetectValuesForPatterns_CompletionHandler_XHandle = Selector.GetHandle ("detectValuesForPatterns:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPasteboardPropertyList_OfType_X = "initWithPasteboardPropertyList:ofType:";
		static readonly NativeHandle selInitWithPasteboardPropertyList_OfType_XHandle = Selector.GetHandle ("initWithPasteboardPropertyList:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardPropertyListForType_X = "pasteboardPropertyListForType:";
		static readonly NativeHandle selPasteboardPropertyListForType_XHandle = Selector.GetHandle ("pasteboardPropertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyListForType_X = "propertyListForType:";
		static readonly NativeHandle selPropertyListForType_XHandle = Selector.GetHandle ("propertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesForPasteboard_X = "readableTypesForPasteboard:";
		static readonly NativeHandle selReadableTypesForPasteboard_XHandle = Selector.GetHandle ("readableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadingOptionsForType_Pasteboard_X = "readingOptionsForType:pasteboard:";
		static readonly NativeHandle selReadingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("readingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCollaborationMetadata_X = "setCollaborationMetadata:";
		static readonly NativeHandle selSetCollaborationMetadata_XHandle = Selector.GetHandle ("setCollaborationMetadata:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetData_ForType_X = "setData:forType:";
		static readonly NativeHandle selSetData_ForType_XHandle = Selector.GetHandle ("setData:forType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataProvider_ForTypes_X = "setDataProvider:forTypes:";
		static readonly NativeHandle selSetDataProvider_ForTypes_XHandle = Selector.GetHandle ("setDataProvider:forTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPropertyList_ForType_X = "setPropertyList:forType:";
		static readonly NativeHandle selSetPropertyList_ForType_XHandle = Selector.GetHandle ("setPropertyList:forType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetString_ForType_X = "setString:forType:";
		static readonly NativeHandle selSetString_ForType_XHandle = Selector.GetHandle ("setString:forType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringForType_X = "stringForType:";
		static readonly NativeHandle selStringForType_XHandle = Selector.GetHandle ("stringForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypesX = "types";
		static readonly NativeHandle selTypesXHandle = Selector.GetHandle ("types");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForPasteboard_X = "writableTypesForPasteboard:";
		static readonly NativeHandle selWritableTypesForPasteboard_XHandle = Selector.GetHandle ("writableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingOptionsForType_Pasteboard_X = "writingOptionsForType:pasteboard:";
		static readonly NativeHandle selWritingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("writingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPasteboardItem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSPasteboardItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPasteboardItem () : base (NSObjectFlag.Empty)
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
		protected NSPasteboardItem (NSObjectFlag t) : base (t)
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
		protected internal NSPasteboardItem (NativeHandle handle) : base (handle)
		{
		}

		[Export ("detectMetadataForTypes:completionHandler:")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectMetadata (NSSet<NSString> types, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSPasteboardDetectMetadataHandler))]NSPasteboardDetectMetadataHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var types__handle__ = types!.GetNonNullHandle (nameof (types));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSPasteboardDetectMetadataHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDetectMetadataForTypes_CompletionHandler_XHandle, types__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDetectMetadataForTypes_CompletionHandler_XHandle, types__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (types);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectMetadata (global::System.Collections.Generic.HashSet<NSPasteboardMetadataType> types, NSPasteboardDetectMetadataHandler completionHandler)
		{
			DetectMetadata (NSSet<NSString>.Create (types, (v) => NSPasteboardMetadataTypeExtensions.GetConstant (v)!), completionHandler);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectMetadata (global::System.Collections.Generic.HashSet<NSPasteboardMetadataType> types, NSPasteboardDetectMetadataCompletionHandler completionHandler)
		{
			DetectMetadata (NSSet<NSString>.Create (types, (v) => NSPasteboardMetadataTypeExtensions.GetConstant (v)!), new NSPasteboardDetectMetadataHandler ((detectedMetadata, error) => completionHandler (detectedMetadata?.ToDictionary<NSPasteboardMetadataType, UniformTypeIdentifiers.UTType> ((k, v) => (NSPasteboardMetadataTypeExtensions.GetValue (k), (UniformTypeIdentifiers.UTType) v)), error)));
		}
		[Export ("detectPatternsForPatterns:completionHandler:")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectPatterns (NSSet<NSString> patterns, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSPasteboardDetectPatternsHandler))]NSPasteboardDetectPatternsHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSPasteboardDetectPatternsHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDetectPatternsForPatterns_CompletionHandler_XHandle, patterns__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDetectPatternsForPatterns_CompletionHandler_XHandle, patterns__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectPatterns (global::System.Collections.Generic.HashSet<NSPasteboardDetectionPattern> patterns, NSPasteboardDetectPatternsHandler completionHandler)
		{
			DetectPatterns (NSSet<NSString>.Create (patterns, (v) => NSPasteboardDetectionPatternExtensions.GetConstant (v)!), completionHandler);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectPatterns (global::System.Collections.Generic.HashSet<NSPasteboardDetectionPattern> patterns, NSPasteboardDetectPatternsCompletionHandler completionHandler)
		{
			DetectPatterns (NSSet<NSString>.Create (patterns, (v) => NSPasteboardDetectionPatternExtensions.GetConstant (v)!), new NSPasteboardDetectPatternsHandler ((detectedPatterns, error) => completionHandler (detectedPatterns?.ToHashSet<NSPasteboardDetectionPattern> ((k) => NSPasteboardDetectionPatternExtensions.GetValue (k)), error)));
		}
		[Export ("detectValuesForPatterns:completionHandler:")]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectValues (NSSet<NSString> patterns, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSPasteboardDetectValuesHandler))]NSPasteboardDetectValuesHandler completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSPasteboardDetectValuesHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDetectValuesForPatterns_CompletionHandler_XHandle, patterns__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDetectValuesForPatterns_CompletionHandler_XHandle, patterns__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectValues (global::System.Collections.Generic.HashSet<NSPasteboardDetectionPattern> patterns, NSPasteboardDetectValuesHandler completionHandler)
		{
			DetectValues (NSSet<NSString>.Create (patterns, (v) => NSPasteboardDetectionPatternExtensions.GetConstant (v)!), completionHandler);
		}
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DetectValues (global::System.Collections.Generic.HashSet<NSPasteboardDetectionPattern> patterns, NSPasteboardDetectValuesCompletionHandler completionHandler)
		{
			DetectValues (NSSet<NSString>.Create (patterns, (v) => NSPasteboardDetectionPatternExtensions.GetConstant (v)!), new NSPasteboardDetectValuesHandler ((detectedValues, error) => completionHandler (detectedValues?.ToDictionary<NSPasteboardDetectionPattern, DataDetection.DDMatch[]> ((k, v) => (NSPasteboardDetectionPatternExtensions.GetValue (k), ((NSArray) v).NonNullToArrayDropNullElements<DataDetection.DDMatch> ())), error)));
		}
		[Export ("availableTypeFromArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetAvailableTypeFromArray (string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAvailableTypeFromArray_XHandle, nsa_types.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAvailableTypeFromArray_XHandle, nsa_types.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("dataForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetDataForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDataForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDataForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pasteboardPropertyListForType:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPasteboardPropertyListForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPasteboardPropertyListForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteboardPropertyListForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("propertyListForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPropertyListForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPropertyListForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPropertyListForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypesForPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selReadableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboardReadingOptions GetReadingOptionsForType (string type, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardReadingOptions ret;
			ret = (NSPasteboardReadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selReadingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("stringForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetStringForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritableTypesForPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPasteboardWritingOptions GetWritingOptionsForType (string type, NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardWritingOptions ret;
			if (IsDirectBinding) {
				ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("setData:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetDataForType (NSData data, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetData_ForType_XHandle, data__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetData_ForType_XHandle, data__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("setDataProvider:forTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetDataProviderForTypes (INSPasteboardItemDataProvider dataProvider, string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dataProvider__handle__ = dataProvider!.GetNonNullHandle (nameof (dataProvider));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDataProvider_ForTypes_XHandle, dataProvider__handle__, nsa_types.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDataProvider_ForTypes_XHandle, dataProvider__handle__, nsa_types.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dataProvider);
			return ret != 0;
		}
		[Export ("setPropertyList:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetPropertyListForType (NSObject propertyList, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var propertyList__handle__ = propertyList!.GetNonNullHandle (nameof (propertyList));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetPropertyList_ForType_XHandle, propertyList__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetPropertyList_ForType_XHandle, propertyList__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (propertyList);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("setString:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetStringForType (string str, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nsstr = CFString.CreateNative (str);
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetString_ForType_XHandle, nsstr, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetString_ForType_XHandle, nsstr, nstype);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::SharedWithYouCore.SWCollaborationMetadata? CollaborationMetadata {
			[Export ("collaborationMetadata", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::SharedWithYouCore.SWCollaborationMetadata? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::SharedWithYouCore.SWCollaborationMetadata> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollaborationMetadataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::SharedWithYouCore.SWCollaborationMetadata> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollaborationMetadataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCollaborationMetadata:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCollaborationMetadata_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCollaborationMetadata_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Types {
			[Export ("types")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSPasteboardItem */
}
