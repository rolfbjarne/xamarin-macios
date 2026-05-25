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
	[Register("NSPasteboard", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPasteboard : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessBehaviorX = "accessBehavior";
		static readonly NativeHandle selAccessBehaviorXHandle = Selector.GetHandle ("accessBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTypes_Owner_X = "addTypes:owner:";
		static readonly NativeHandle selAddTypes_Owner_XHandle = Selector.GetHandle ("addTypes:owner:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableTypeFromArray_X = "availableTypeFromArray:";
		static readonly NativeHandle selAvailableTypeFromArray_XHandle = Selector.GetHandle ("availableTypeFromArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanReadItemWithDataConformingToTypes_X = "canReadItemWithDataConformingToTypes:";
		static readonly NativeHandle selCanReadItemWithDataConformingToTypes_XHandle = Selector.GetHandle ("canReadItemWithDataConformingToTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanReadObjectForClasses_Options_X = "canReadObjectForClasses:options:";
		static readonly NativeHandle selCanReadObjectForClasses_Options_XHandle = Selector.GetHandle ("canReadObjectForClasses:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeCountX = "changeCount";
		static readonly NativeHandle selChangeCountXHandle = Selector.GetHandle ("changeCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearContentsX = "clearContents";
		static readonly NativeHandle selClearContentsXHandle = Selector.GetHandle ("clearContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataForType_X = "dataForType:";
		static readonly NativeHandle selDataForType_XHandle = Selector.GetHandle ("dataForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeclareTypes_Owner_X = "declareTypes:owner:";
		static readonly NativeHandle selDeclareTypes_Owner_XHandle = Selector.GetHandle ("declareTypes:owner:");
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
		const string selGeneralPasteboardX = "generalPasteboard";
		static readonly NativeHandle selGeneralPasteboardXHandle = Selector.GetHandle ("generalPasteboard");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfPasteboardItem_X = "indexOfPasteboardItem:";
		static readonly NativeHandle selIndexOfPasteboardItem_XHandle = Selector.GetHandle ("indexOfPasteboardItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardItemsX = "pasteboardItems";
		static readonly NativeHandle selPasteboardItemsXHandle = Selector.GetHandle ("pasteboardItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardWithName_X = "pasteboardWithName:";
		static readonly NativeHandle selPasteboardWithName_XHandle = Selector.GetHandle ("pasteboardWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardWithUniqueNameX = "pasteboardWithUniqueName";
		static readonly NativeHandle selPasteboardWithUniqueNameXHandle = Selector.GetHandle ("pasteboardWithUniqueName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForNewContentsWithOptions_X = "prepareForNewContentsWithOptions:";
		static readonly NativeHandle selPrepareForNewContentsWithOptions_XHandle = Selector.GetHandle ("prepareForNewContentsWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyListForType_X = "propertyListForType:";
		static readonly NativeHandle selPropertyListForType_XHandle = Selector.GetHandle ("propertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadObjectsForClasses_Options_X = "readObjectsForClasses:options:";
		static readonly NativeHandle selReadObjectsForClasses_Options_XHandle = Selector.GetHandle ("readObjectsForClasses:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseGloballyX = "releaseGlobally";
		static readonly NativeHandle selReleaseGloballyXHandle = Selector.GetHandle ("releaseGlobally");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetData_ForType_X = "setData:forType:";
		static readonly NativeHandle selSetData_ForType_XHandle = Selector.GetHandle ("setData:forType:");
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
		const string selWriteObjects_X = "writeObjects:";
		static readonly NativeHandle selWriteObjects_XHandle = Selector.GetHandle ("writeObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPasteboard");
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
		protected NSPasteboard (NSObjectFlag t) : base (t)
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
		protected internal NSPasteboard (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addTypes:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint AddTypes (string[] newTypes, NSObject? newOwner)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newTypes));
			var newOwner__handle__ = newOwner.GetHandle ();
			using var nsa_newTypes = NSArray.FromStrings (newTypes);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddTypes_Owner_XHandle, nsa_newTypes.Handle, newOwner__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddTypes_Owner_XHandle, nsa_newTypes.Handle, newOwner__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newOwner);
			return ret!;
		}
		[Export ("canReadItemWithDataConformingToTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanReadItemWithDataConformingToTypes (string[] utiTypes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (utiTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (utiTypes));
			using var nsa_utiTypes = NSArray.FromStrings (utiTypes);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanReadItemWithDataConformingToTypes_XHandle, nsa_utiTypes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanReadItemWithDataConformingToTypes_XHandle, nsa_utiTypes.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("canReadObjectForClasses:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanReadObjectForClasses (Class[] classArray, NSDictionary? options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (classArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (classArray));
			var options__handle__ = options.GetHandle ();
			using var nsa_classArray = NSArray.FromNSObjects (classArray);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCanReadObjectForClasses_Options_XHandle, nsa_classArray.Handle, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCanReadObjectForClasses_Options_XHandle, nsa_classArray.Handle, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret != 0;
		}
		[Export ("clearContents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ClearContents ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClearContentsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selClearContentsXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("pasteboardWithUniqueName")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboard CreateWithUniqueName ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSPasteboard ret;
			ret =  Runtime.GetNSObject<NSPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPasteboardWithUniqueNameXHandle), false)!;
			return ret;
		}
		[Export ("declareTypes:owner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint DeclareTypes (string[] newTypes, NSObject? newOwner)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newTypes));
			var newOwner__handle__ = newOwner.GetHandle ();
			using var nsa_newTypes = NSArray.FromStrings (newTypes);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeclareTypes_Owner_XHandle, nsa_newTypes.Handle, newOwner__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeclareTypes_Owner_XHandle, nsa_newTypes.Handle, newOwner__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newOwner);
			return ret!;
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
		[Export ("pasteboardWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboard FromName (string name)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSPasteboard? ret;
			ret =  Runtime.GetNSObject<NSPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPasteboardWithName_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
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
		public virtual NSData GetDataForType (string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsdataType = CFString.CreateNative (dataType);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDataForType_XHandle, nsdataType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDataForType_XHandle, nsdataType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdataType);
			return ret!;
		}
		[Export ("propertyListForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPropertyListForType (string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsdataType = CFString.CreateNative (dataType);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPropertyListForType_XHandle, nsdataType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPropertyListForType_XHandle, nsdataType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdataType);
			return ret!;
		}
		[Export ("stringForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetStringForType (string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsdataType = CFString.CreateNative (dataType);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringForType_XHandle, nsdataType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringForType_XHandle, nsdataType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdataType);
			return ret!;
		}
		[Export ("indexOfPasteboardItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndexOf (NSPasteboardItem pasteboardItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboardItem__handle__ = pasteboardItem!.GetNonNullHandle (nameof (pasteboardItem));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfPasteboardItem_XHandle, pasteboardItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfPasteboardItem_XHandle, pasteboardItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboardItem);
			return ret!;
		}
		[Export ("prepareForNewContentsWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PrepareForNewContents (NSPasteboardContentsOptions options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, selPrepareForNewContentsWithOptions_XHandle, (UIntPtr) (ulong) options);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selPrepareForNewContentsWithOptions_XHandle, (UIntPtr) (ulong) options);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("readObjectsForClasses:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] ReadObjectsForClasses (Class[] classArray, NSDictionary? options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (classArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (classArray));
			var options__handle__ = options.GetHandle ();
			using var nsa_classArray = NSArray.FromNSObjects (classArray);
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReadObjectsForClasses_Options_XHandle, nsa_classArray.Handle, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReadObjectsForClasses_Options_XHandle, nsa_classArray.Handle, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("releaseGlobally")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseGlobally ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReleaseGloballyXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selReleaseGloballyXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setData:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetDataForType (NSData data, string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsdataType = CFString.CreateNative (dataType);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetData_ForType_XHandle, data__handle__, nsdataType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetData_ForType_XHandle, data__handle__, nsdataType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsdataType);
			return ret != 0;
		}
		[Export ("setPropertyList:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetPropertyListForType (NSObject plist, string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var plist__handle__ = plist!.GetNonNullHandle (nameof (plist));
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsdataType = CFString.CreateNative (dataType);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetPropertyList_ForType_XHandle, plist__handle__, nsdataType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetPropertyList_ForType_XHandle, plist__handle__, nsdataType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (plist);
			CFString.ReleaseNative (nsdataType);
			return ret != 0;
		}
		[Export ("setString:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetStringForType (string str, string dataType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			if (dataType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataType));
			var nsstr = CFString.CreateNative (str);
			var nsdataType = CFString.CreateNative (dataType);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetString_ForType_XHandle, nsstr, nsdataType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetString_ForType_XHandle, nsstr, nsdataType);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
			CFString.ReleaseNative (nsdataType);
			return ret != 0;
		}
		[Export ("writeObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual bool WriteObjects (nint objects)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selWriteObjects_XHandle, objects);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selWriteObjects_XHandle, objects);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSPasteboardAccessBehavior AccessBehavior {
			[Export ("accessBehavior", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPasteboardAccessBehavior ret;
				if (IsDirectBinding) {
					ret = (NSPasteboardAccessBehavior) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAccessBehaviorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPasteboardAccessBehavior) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAccessBehaviorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ChangeCount {
			[Export ("changeCount")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChangeCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selChangeCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboard GeneralPasteboard {
			[Export ("generalPasteboard")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPasteboard? ret;
				ret =  Runtime.GetNSObject<NSPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGeneralPasteboardXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPasteboardItem[] PasteboardItems {
			[Export ("pasteboardItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPasteboardItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSPasteboardItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPasteboardItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSPasteboardItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPasteboardItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSColorType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSColorPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeColor' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSColorType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeColor' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSColorType is null)
					_NSColorType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSColorPboardType")!;
				return _NSColorType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSDragPasteboardName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDragPboard",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameDrag' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSDragPasteboardName {
			[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameDrag' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSDragPasteboardName is null)
					_NSDragPasteboardName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSDragPboard")!;
				return _NSDragPasteboardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFileContentsType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSFileContentsPboardType",  "AppKit")]
		public static NSString NSFileContentsType {
			get {
				if (_NSFileContentsType is null)
					_NSFileContentsType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFileContentsPboardType")!;
				return _NSFileContentsType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFilenamesType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFilenamesPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Create multiple items with 'NSPasteboardTypeFileUrl' or 'MobileCoreServices.UTType.FileURL' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSFilenamesType {
			[ObsoletedOSPlatform ("macos10.14", "Create multiple items with 'NSPasteboardTypeFileUrl' or 'MobileCoreServices.UTType.FileURL' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSFilenamesType is null)
					_NSFilenamesType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFilenamesPboardType")!;
				return _NSFilenamesType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFilesPromiseType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFilesPromisePboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'com.apple.pasteboard.promised-file-url' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSFilesPromiseType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'com.apple.pasteboard.promised-file-url' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSFilesPromiseType is null)
					_NSFilesPromiseType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFilesPromisePboardType")!;
				return _NSFilesPromiseType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFindPasteboardName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFindPboard",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameFind' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSFindPasteboardName {
			[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameFind' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSFindPasteboardName is null)
					_NSFindPasteboardName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFindPboard")!;
				return _NSFindPasteboardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFontPasteboardName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontPboard",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameFont' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSFontPasteboardName {
			[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameFont' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSFontPasteboardName is null)
					_NSFontPasteboardName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontPboard")!;
				return _NSFontPasteboardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSFontType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeFont' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSFontType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeFont' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSFontType is null)
					_NSFontType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontPboardType")!;
				return _NSFontType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSGeneralPasteboardName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSGeneralPboard",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameGeneral' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSGeneralPasteboardName {
			[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameGeneral' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSGeneralPasteboardName is null)
					_NSGeneralPasteboardName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSGeneralPboard")!;
				return _NSGeneralPasteboardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSHtmlType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSHTMLPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeHTML' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSHtmlType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeHTML' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSHtmlType is null)
					_NSHtmlType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSHTMLPboardType")!;
				return _NSHtmlType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSMultipleTextSelectionType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSMultipleTextSelectionPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeMultipleTextSelection' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSMultipleTextSelectionType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeMultipleTextSelection' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSMultipleTextSelectionType is null)
					_NSMultipleTextSelectionType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSMultipleTextSelectionPboardType")!;
				return _NSMultipleTextSelectionType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardNameDrag;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardName' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardNameDrag",  "AppKit")]
		public static NSString NSPasteboardNameDrag {
			get {
				if (_NSPasteboardNameDrag is null)
					_NSPasteboardNameDrag = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardNameDrag")!;
				return _NSPasteboardNameDrag;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardNameFind;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardName' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardNameFind",  "AppKit")]
		public static NSString NSPasteboardNameFind {
			get {
				if (_NSPasteboardNameFind is null)
					_NSPasteboardNameFind = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardNameFind")!;
				return _NSPasteboardNameFind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardNameFont;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardName' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardNameFont",  "AppKit")]
		public static NSString NSPasteboardNameFont {
			get {
				if (_NSPasteboardNameFont is null)
					_NSPasteboardNameFont = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardNameFont")!;
				return _NSPasteboardNameFont;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardNameGeneral;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardName' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardNameGeneral",  "AppKit")]
		public static NSString NSPasteboardNameGeneral {
			get {
				if (_NSPasteboardNameGeneral is null)
					_NSPasteboardNameGeneral = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardNameGeneral")!;
				return _NSPasteboardNameGeneral;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardNameRuler;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardName' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardNameRuler",  "AppKit")]
		public static NSString NSPasteboardNameRuler {
			get {
				if (_NSPasteboardNameRuler is null)
					_NSPasteboardNameRuler = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardNameRuler")!;
				return _NSPasteboardNameRuler;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeColor;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeColor",  "AppKit")]
		public static NSString NSPasteboardTypeColor {
			get {
				if (_NSPasteboardTypeColor is null)
					_NSPasteboardTypeColor = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeColor")!;
				return _NSPasteboardTypeColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeFileUrl;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeFileURL",  "AppKit")]
		public static NSString NSPasteboardTypeFileUrl {
			get {
				if (_NSPasteboardTypeFileUrl is null)
					_NSPasteboardTypeFileUrl = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeFileURL")!;
				return _NSPasteboardTypeFileUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeFindPanelSearchOptions;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSPasteboardTypeFindPanelSearchOptions",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTextFinderOptions' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSPasteboardTypeFindPanelSearchOptions {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTextFinderOptions' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSPasteboardTypeFindPanelSearchOptions is null)
					_NSPasteboardTypeFindPanelSearchOptions = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeFindPanelSearchOptions")!;
				return _NSPasteboardTypeFindPanelSearchOptions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeFont;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeFont",  "AppKit")]
		public static NSString NSPasteboardTypeFont {
			get {
				if (_NSPasteboardTypeFont is null)
					_NSPasteboardTypeFont = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeFont")!;
				return _NSPasteboardTypeFont;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeHTML;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeHTML",  "AppKit")]
		public static NSString NSPasteboardTypeHTML {
			get {
				if (_NSPasteboardTypeHTML is null)
					_NSPasteboardTypeHTML = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeHTML")!;
				return _NSPasteboardTypeHTML;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeMultipleTextSelection;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeMultipleTextSelection",  "AppKit")]
		public static NSString NSPasteboardTypeMultipleTextSelection {
			get {
				if (_NSPasteboardTypeMultipleTextSelection is null)
					_NSPasteboardTypeMultipleTextSelection = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeMultipleTextSelection")!;
				return _NSPasteboardTypeMultipleTextSelection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypePDF;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypePDF",  "AppKit")]
		public static NSString NSPasteboardTypePDF {
			get {
				if (_NSPasteboardTypePDF is null)
					_NSPasteboardTypePDF = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypePDF")!;
				return _NSPasteboardTypePDF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypePNG;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypePNG",  "AppKit")]
		public static NSString NSPasteboardTypePNG {
			get {
				if (_NSPasteboardTypePNG is null)
					_NSPasteboardTypePNG = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypePNG")!;
				return _NSPasteboardTypePNG;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeRTF;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeRTF",  "AppKit")]
		public static NSString NSPasteboardTypeRTF {
			get {
				if (_NSPasteboardTypeRTF is null)
					_NSPasteboardTypeRTF = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeRTF")!;
				return _NSPasteboardTypeRTF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeRTFD;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeRTFD",  "AppKit")]
		public static NSString NSPasteboardTypeRTFD {
			get {
				if (_NSPasteboardTypeRTFD is null)
					_NSPasteboardTypeRTFD = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeRTFD")!;
				return _NSPasteboardTypeRTFD;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeRuler;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeRuler",  "AppKit")]
		public static NSString NSPasteboardTypeRuler {
			get {
				if (_NSPasteboardTypeRuler is null)
					_NSPasteboardTypeRuler = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeRuler")!;
				return _NSPasteboardTypeRuler;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeSound;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeSound",  "AppKit")]
		public static NSString NSPasteboardTypeSound {
			get {
				if (_NSPasteboardTypeSound is null)
					_NSPasteboardTypeSound = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeSound")!;
				return _NSPasteboardTypeSound;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeString;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeString",  "AppKit")]
		public static NSString NSPasteboardTypeString {
			get {
				if (_NSPasteboardTypeString is null)
					_NSPasteboardTypeString = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeString")!;
				return _NSPasteboardTypeString;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeTIFF;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeTIFF",  "AppKit")]
		public static NSString NSPasteboardTypeTIFF {
			get {
				if (_NSPasteboardTypeTIFF is null)
					_NSPasteboardTypeTIFF = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeTIFF")!;
				return _NSPasteboardTypeTIFF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeTabularText;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeTabularText",  "AppKit")]
		public static NSString NSPasteboardTypeTabularText {
			get {
				if (_NSPasteboardTypeTabularText is null)
					_NSPasteboardTypeTabularText = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeTabularText")!;
				return _NSPasteboardTypeTabularText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPasteboardTypeUrl;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeURL",  "AppKit")]
		public static NSString NSPasteboardTypeUrl {
			get {
				if (_NSPasteboardTypeUrl is null)
					_NSPasteboardTypeUrl = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeURL")!;
				return _NSPasteboardTypeUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPdfType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSPDFPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypePDF' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSPdfType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypePDF' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSPdfType is null)
					_NSPdfType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPDFPboardType")!;
				return _NSPdfType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPictType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSPICTPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.6", "Do not use, the PICT format was discontinued a long time ago.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSPictType {
			[ObsoletedOSPlatform ("macos10.6", "Do not use, the PICT format was discontinued a long time ago.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSPictType is null)
					_NSPictType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPICTPboardType")!;
				return _NSPictType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSPostScriptType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSPostScriptPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'com.adobe.encapsulated-postscript' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSPostScriptType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'com.adobe.encapsulated-postscript' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSPostScriptType is null)
					_NSPostScriptType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPostScriptPboardType")!;
				return _NSPostScriptType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSRtfType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSRTFPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRTF' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSRtfType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRTF' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSRtfType is null)
					_NSRtfType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSRTFPboardType")!;
				return _NSRtfType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSRtfdType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSRTFDPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRTFD' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSRtfdType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRTFD' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSRtfdType is null)
					_NSRtfdType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSRTFDPboardType")!;
				return _NSRtfdType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSRulerPasteboardName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSRulerPboard",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameRuler' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSRulerPasteboardName {
			[ObsoletedOSPlatform ("macos10.13", "Use 'NSPasteboardNameRuler' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSRulerPasteboardName is null)
					_NSRulerPasteboardName = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSRulerPboard")!;
				return _NSRulerPasteboardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSRulerType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSRulerPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRuler' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSRulerType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeRuler' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSRulerType is null)
					_NSRulerType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSRulerPboardType")!;
				return _NSRulerType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSStringType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStringPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeString' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSStringType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeString' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSStringType is null)
					_NSStringType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSStringPboardType")!;
				return _NSStringType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSTabularTextType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTabularTextPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTabularText' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSTabularTextType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTabularText' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSTabularTextType is null)
					_NSTabularTextType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTabularTextPboardType")!;
				return _NSTabularTextType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSTiffType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTIFFPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTIFF' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSTiffType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeTIFF' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSTiffType is null)
					_NSTiffType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTIFFPboardType")!;
				return _NSTiffType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSUrlType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSURLPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeUrl' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSUrlType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'NSPasteboardTypeUrl' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSUrlType is null)
					_NSUrlType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSURLPboardType")!;
				return _NSUrlType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSVCardType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSVCardPboardType",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'MobileCoreServices.UTType.VCard' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NSVCardType {
			[ObsoletedOSPlatform ("macos10.14", "Use 'MobileCoreServices.UTType.VCard' instead.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NSVCardType is null)
					_NSVCardType = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSVCardPboardType")!;
				return _NSVCardType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PasteboardTypeTextFinderOptions;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Use the 'NSPasteboardType' enum instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("NSPasteboardTypeTextFinderOptions",  "AppKit")]
		public static NSString PasteboardTypeTextFinderOptions {
			get {
				if (_PasteboardTypeTextFinderOptions is null)
					_PasteboardTypeTextFinderOptions = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSPasteboardTypeTextFinderOptions")!;
				return _PasteboardTypeTextFinderOptions;
			}
		}
	} /* class NSPasteboard */
}
