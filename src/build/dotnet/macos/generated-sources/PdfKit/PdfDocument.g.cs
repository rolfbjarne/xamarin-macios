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
namespace PdfKit {
	/// <summary>Class for working with PDF documents.</summary>
	[Register("PDFDocument", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PdfDocument : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessPermissionsX = "accessPermissions";
		static readonly NativeHandle selAccessPermissionsXHandle = Selector.GetHandle ("accessPermissions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCommentingX = "allowsCommenting";
		static readonly NativeHandle selAllowsCommentingXHandle = Selector.GetHandle ("allowsCommenting");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsContentAccessibilityX = "allowsContentAccessibility";
		static readonly NativeHandle selAllowsContentAccessibilityXHandle = Selector.GetHandle ("allowsContentAccessibility");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCopyingX = "allowsCopying";
		static readonly NativeHandle selAllowsCopyingXHandle = Selector.GetHandle ("allowsCopying");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDocumentAssemblyX = "allowsDocumentAssembly";
		static readonly NativeHandle selAllowsDocumentAssemblyXHandle = Selector.GetHandle ("allowsDocumentAssembly");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDocumentChangesX = "allowsDocumentChanges";
		static readonly NativeHandle selAllowsDocumentChangesXHandle = Selector.GetHandle ("allowsDocumentChanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsFormFieldEntryX = "allowsFormFieldEntry";
		static readonly NativeHandle selAllowsFormFieldEntryXHandle = Selector.GetHandle ("allowsFormFieldEntry");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsPrintingX = "allowsPrinting";
		static readonly NativeHandle selAllowsPrintingXHandle = Selector.GetHandle ("allowsPrinting");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginFindString_WithOptions_X = "beginFindString:withOptions:";
		static readonly NativeHandle selBeginFindString_WithOptions_XHandle = Selector.GetHandle ("beginFindString:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginFindStrings_WithOptions_X = "beginFindStrings:withOptions:";
		static readonly NativeHandle selBeginFindStrings_WithOptions_XHandle = Selector.GetHandle ("beginFindStrings:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelFindStringX = "cancelFindString";
		static readonly NativeHandle selCancelFindStringXHandle = Selector.GetHandle ("cancelFindString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataRepresentationX = "dataRepresentation";
		static readonly NativeHandle selDataRepresentationXHandle = Selector.GetHandle ("dataRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataRepresentationWithOptions_X = "dataRepresentationWithOptions:";
		static readonly NativeHandle selDataRepresentationWithOptions_XHandle = Selector.GetHandle ("dataRepresentationWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentAttributesX = "documentAttributes";
		static readonly NativeHandle selDocumentAttributesXHandle = Selector.GetHandle ("documentAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentRefX = "documentRef";
		static readonly NativeHandle selDocumentRefXHandle = Selector.GetHandle ("documentRef");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentURLX = "documentURL";
		static readonly NativeHandle selDocumentURLXHandle = Selector.GetHandle ("documentURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangePageAtIndex_WithPageAtIndex_X = "exchangePageAtIndex:withPageAtIndex:";
		static readonly NativeHandle selExchangePageAtIndex_WithPageAtIndex_XHandle = Selector.GetHandle ("exchangePageAtIndex:withPageAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindString_FromSelection_WithOptions_X = "findString:fromSelection:withOptions:";
		static readonly NativeHandle selFindString_FromSelection_WithOptions_XHandle = Selector.GetHandle ("findString:fromSelection:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindString_WithOptions_X = "findString:withOptions:";
		static readonly NativeHandle selFindString_WithOptions_XHandle = Selector.GetHandle ("findString:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexForPage_X = "indexForPage:";
		static readonly NativeHandle selIndexForPage_XHandle = Selector.GetHandle ("indexForPage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_X = "initWithData:";
		static readonly NativeHandle selInitWithData_XHandle = Selector.GetHandle ("initWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_X = "initWithURL:";
		static readonly NativeHandle selInitWithURL_XHandle = Selector.GetHandle ("initWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertPage_AtIndex_X = "insertPage:atIndex:";
		static readonly NativeHandle selInsertPage_AtIndex_XHandle = Selector.GetHandle ("insertPage:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEncryptedX = "isEncrypted";
		static readonly NativeHandle selIsEncryptedXHandle = Selector.GetHandle ("isEncrypted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFindingX = "isFinding";
		static readonly NativeHandle selIsFindingXHandle = Selector.GetHandle ("isFinding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLockedX = "isLocked";
		static readonly NativeHandle selIsLockedXHandle = Selector.GetHandle ("isLocked");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMajorVersionX = "majorVersion";
		static readonly NativeHandle selMajorVersionXHandle = Selector.GetHandle ("majorVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinorVersionX = "minorVersion";
		static readonly NativeHandle selMinorVersionXHandle = Selector.GetHandle ("minorVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutlineItemForSelection_X = "outlineItemForSelection:";
		static readonly NativeHandle selOutlineItemForSelection_XHandle = Selector.GetHandle ("outlineItemForSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutlineRootX = "outlineRoot";
		static readonly NativeHandle selOutlineRootXHandle = Selector.GetHandle ("outlineRoot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageAtIndex_X = "pageAtIndex:";
		static readonly NativeHandle selPageAtIndex_XHandle = Selector.GetHandle ("pageAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageClassX = "pageClass";
		static readonly NativeHandle selPageClassXHandle = Selector.GetHandle ("pageClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageCountX = "pageCount";
		static readonly NativeHandle selPageCountXHandle = Selector.GetHandle ("pageCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermissionsStatusX = "permissionsStatus";
		static readonly NativeHandle selPermissionsStatusXHandle = Selector.GetHandle ("permissionsStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintOperationForPrintInfo_ScalingMode_AutoRotate_X = "printOperationForPrintInfo:scalingMode:autoRotate:";
		static readonly NativeHandle selPrintOperationForPrintInfo_ScalingMode_AutoRotate_XHandle = Selector.GetHandle ("printOperationForPrintInfo:scalingMode:autoRotate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovePageAtIndex_X = "removePageAtIndex:";
		static readonly NativeHandle selRemovePageAtIndex_XHandle = Selector.GetHandle ("removePageAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionForEntireDocumentX = "selectionForEntireDocument";
		static readonly NativeHandle selSelectionForEntireDocumentXHandle = Selector.GetHandle ("selectionForEntireDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_X = "selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:";
		static readonly NativeHandle selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_XHandle = Selector.GetHandle ("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionFromPage_AtPoint_ToPage_AtPoint_X = "selectionFromPage:atPoint:toPage:atPoint:";
		static readonly NativeHandle selSelectionFromPage_AtPoint_ToPage_AtPoint_XHandle = Selector.GetHandle ("selectionFromPage:atPoint:toPage:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionFromPage_AtPoint_ToPage_AtPoint_WithGranularity_X = "selectionFromPage:atPoint:toPage:atPoint:withGranularity:";
		static readonly NativeHandle selSelectionFromPage_AtPoint_ToPage_AtPoint_WithGranularity_XHandle = Selector.GetHandle ("selectionFromPage:atPoint:toPage:atPoint:withGranularity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDocumentAttributes_X = "setDocumentAttributes:";
		static readonly NativeHandle selSetDocumentAttributes_XHandle = Selector.GetHandle ("setDocumentAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutlineRoot_X = "setOutlineRoot:";
		static readonly NativeHandle selSetOutlineRoot_XHandle = Selector.GetHandle ("setOutlineRoot:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringX = "string";
		static readonly NativeHandle selStringXHandle = Selector.GetHandle ("string");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnlockWithPassword_X = "unlockWithPassword:";
		static readonly NativeHandle selUnlockWithPassword_XHandle = Selector.GetHandle ("unlockWithPassword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToFile_X = "writeToFile:";
		static readonly NativeHandle selWriteToFile_XHandle = Selector.GetHandle ("writeToFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToFile_WithOptions_X = "writeToFile:withOptions:";
		static readonly NativeHandle selWriteToFile_WithOptions_XHandle = Selector.GetHandle ("writeToFile:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_X = "writeToURL:";
		static readonly NativeHandle selWriteToURL_XHandle = Selector.GetHandle ("writeToURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_WithOptions_X = "writeToURL:withOptions:";
		static readonly NativeHandle selWriteToURL_WithOptions_XHandle = Selector.GetHandle ("writeToURL:withOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PDFDocument");
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
		protected PdfDocument (NSObjectFlag t) : base (t)
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
		protected internal PdfDocument (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Creates a new PDF document object with default values.</summary><remarks />
		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfDocument ()
			: base (NSObjectFlag.Empty)
		{
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
		/// <param name="url">To be added.</param><summary>Creates a new PDF document object from the data at the specified URL.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfDocument (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithURL_XHandle, url__handle__), "initWithURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithURL_XHandle, url__handle__), "initWithURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="data">To be added.</param><summary>Creates a new PDF document object with the specified data.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfDocument (NSData data)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithData_XHandle, data__handle__), "initWithData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithData_XHandle, data__handle__), "initWithData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		/// <summary>Cancels an in-progress find operation.</summary><remarks>To be added.</remarks>
		[Export ("cancelFindString")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelFind ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelFindStringXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelFindStringXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
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
		/// <param name="indexA">The index of the first page to exchange.</param><param name="indexB">The index of the second page to exchange.</param><summary>Swaps the page at <paramref name="indexA" /> with the one at <paramref name="indexB" />.</summary><remarks>To be added.</remarks>
		[Export ("exchangePageAtIndex:withPageAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangePages (nint indexA, nint indexB)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selExchangePageAtIndex_WithPageAtIndex_XHandle, indexA, indexB);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selExchangePageAtIndex_WithPageAtIndex_XHandle, indexA, indexB);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="text">The text to find.</param><param name="compareOptions">Comparison options to control text matching.</param><summary>Searches for the specified text with the specified comparison options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("findString:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection[] Find (string text, NSStringCompareOptions compareOptions)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			PdfSelection[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selFindString_WithOptions_XHandle, nstext, (UIntPtr) (ulong) compareOptions), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<PdfSelection>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selFindString_WithOptions_XHandle, nstext, (UIntPtr) (ulong) compareOptions), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
			return ret!;
		}
		/// <param name="text">The text to find.</param><param name="selection">The selection to search.</param><param name="compareOptions">Comparison options to control text matching.</param><summary>Searches for the specified text in a selection with the specified comparison options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("findString:fromSelection:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? Find (string text, PdfSelection? selection, NSStringCompareOptions compareOptions)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var selection__handle__ = selection.GetHandle ();
			var nstext = CFString.CreateNative (text);
			PdfSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selFindString_FromSelection_WithOptions_XHandle, nstext, selection__handle__, (UIntPtr) (ulong) compareOptions), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selFindString_FromSelection_WithOptions_XHandle, nstext, selection__handle__, (UIntPtr) (ulong) compareOptions), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selection);
			CFString.ReleaseNative (nstext);
			return ret!;
		}
		/// <param name="text">The text to find.</param><param name="compareOptions">Comparison options to control text matching.</param><summary>Asynchronously searches for the specified text with the specified comparison options.</summary><remarks>To be added.</remarks>
		[Export ("beginFindString:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindAsync (string text, NSStringCompareOptions compareOptions)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selBeginFindString_WithOptions_XHandle, nstext, (UIntPtr) (ulong) compareOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selBeginFindString_WithOptions_XHandle, nstext, (UIntPtr) (ulong) compareOptions);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
		}
		/// <param name="text">The text to find.</param><param name="compareOptions">Comparison options to control text matching.</param><summary>Asynchronously searches for the specified text with the specified comparison options.</summary><remarks>To be added.</remarks>
		[Export ("beginFindStrings:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FindAsync (string[] text, NSStringCompareOptions compareOptions)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			using var nsa_text = NSArray.FromStrings (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selBeginFindStrings_WithOptions_XHandle, nsa_text.Handle, (UIntPtr) (ulong) compareOptions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selBeginFindStrings_WithOptions_XHandle, nsa_text.Handle, (UIntPtr) (ulong) compareOptions);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Returns an NSData object that contains the PDF data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataRepresentation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetDataRepresentation ()
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataRepresentationXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataRepresentationXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="options">Options to specify how the data are returned.</param><summary>Returns an NSData object that contains the PDF data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataRepresentationWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetDataRepresentation (NSDictionary options)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDataRepresentationWithOptions_XHandle, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDataRepresentationWithOptions_XHandle, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <summary>Returns a dictionary of the document's attributes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfDocumentAttributes GetDocumentAttributes ()
		{
			return new PdfDocumentAttributes (DocumentAttributes);
		}
		/// <param name="index">The index of the page to get.</param><summary>Returns the page at the specified zero-based index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfPage? GetPage (nint index)
		{
			PdfPage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selPageAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selPageAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="page">The page for which to return its index.</param><summary>Returns the zero-based index for the specified page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPageIndex (PdfPage page)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexForPage_XHandle, page__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexForPage_XHandle, page__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
			return ret!;
		}
		/// <param name="printInfo">To be added.</param><param name="scaleMode">To be added.</param><param name="doRotate">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printOperationForPrintInfo:scalingMode:autoRotate:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSPrintOperation? GetPrintOperation (global::AppKit.NSPrintInfo? printInfo, PdfPrintScalingMode scaleMode, bool doRotate)
		{
			var printInfo__handle__ = printInfo.GetHandle ();
			global::AppKit.NSPrintOperation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool (this.Handle, selPrintOperationForPrintInfo_ScalingMode_AutoRotate_XHandle, printInfo__handle__, (IntPtr) (long) scaleMode, doRotate ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_bool (&__objc_super__, selPrintOperationForPrintInfo_ScalingMode_AutoRotate_XHandle, printInfo__handle__, (IntPtr) (long) scaleMode, doRotate ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printInfo);
			return ret!;
		}
		/// <param name="startPage">The page at the start of the selection.</param><param name="startPoint">The point on the page at the start of the selection.</param><param name="endPage">The page at the end of the selection.</param><param name="endPoint">The point on the page at the end of the selection.</param><summary>Returns a selection for the region that is described by the specified parameters.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionFromPage:atPoint:toPage:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (PdfPage startPage, CGPoint startPoint, PdfPage endPage, CGPoint endPoint)
		{
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			var endPage__handle__ = endPage!.GetNonNullHandle (nameof (endPage));
			PdfSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint_NativeHandle_CGPoint (this.Handle, selSelectionFromPage_AtPoint_ToPage_AtPoint_XHandle, startPage__handle__, startPoint, endPage__handle__, endPoint), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint_NativeHandle_CGPoint (&__objc_super__, selSelectionFromPage_AtPoint_ToPage_AtPoint_XHandle, startPage__handle__, startPoint, endPage__handle__, endPoint), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startPage);
			GC.KeepAlive (endPage);
			return ret!;
		}
		/// <param name="startPage">The page at the start of the selection.</param><param name="startCharIndex">The character index on the start page for the start of the selection.</param><param name="endPage">The page at the end of the selection.</param><param name="endCharIndex">The character index on the end page for the end of the selection.</param><summary>Returns a selection for the region that is described by the specified parameters.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (PdfPage startPage, nint startCharIndex, PdfPage endPage, nint endCharIndex)
		{
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			var endPage__handle__ = endPage!.GetNonNullHandle (nameof (endPage));
			PdfSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_IntPtr (this.Handle, selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_XHandle, startPage__handle__, startCharIndex, endPage__handle__, endCharIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_IntPtr (&__objc_super__, selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_XHandle, startPage__handle__, startCharIndex, endPage__handle__, endCharIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startPage);
			GC.KeepAlive (endPage);
			return ret!;
		}
		[Export ("selectionFromPage:atPoint:toPage:atPoint:withGranularity:")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (PdfPage startPage, CGPoint startPoint, PdfPage endPage, CGPoint endPoint, PdfSelectionGranularity granularity)
		{
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			var endPage__handle__ = endPage!.GetNonNullHandle (nameof (endPage));
			PdfSelection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint_NativeHandle_CGPoint_UIntPtr (this.Handle, selSelectionFromPage_AtPoint_ToPage_AtPoint_WithGranularity_XHandle, startPage__handle__, startPoint, endPage__handle__, endPoint, (UIntPtr) (ulong) granularity), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint_NativeHandle_CGPoint_UIntPtr (&__objc_super__, selSelectionFromPage_AtPoint_ToPage_AtPoint_WithGranularity_XHandle, startPage__handle__, startPoint, endPage__handle__, endPoint, (UIntPtr) (ulong) granularity), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startPage);
			GC.KeepAlive (endPage);
			return ret!;
		}
		/// <param name="page">The page to insert.</param><param name="index">The index at which to insert the page.</param><summary>Inserts the provided <paramref name="page" /> at the specified <paramref name="index" />.</summary><remarks>To be added.</remarks>
		[Export ("insertPage:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertPage (PdfPage page, nint index)
		{
			var page__handle__ = page!.GetNonNullHandle (nameof (page));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertPage_AtIndex_XHandle, page__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertPage_AtIndex_XHandle, page__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (page);
		}
		/// <param name="selection">The selection for which to return the containing outline item.</param><summary>Returns the outline item that represents the section where a selection resides.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("outlineItemForSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfOutline? OutlineItem (PdfSelection selection)
		{
			var selection__handle__ = selection!.GetNonNullHandle (nameof (selection));
			PdfOutline? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfOutline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selOutlineItemForSelection_XHandle, selection__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfOutline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selOutlineItemForSelection_XHandle, selection__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selection);
			return ret!;
		}
		/// <param name="index">The index of the page to remove.</param><summary>Removes the page at the specified <paramref name="index" />.</summary><remarks>To be added.</remarks>
		[Export ("removePageAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemovePage (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemovePageAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemovePageAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Returns a selection that contains the entire document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionForEntireDocument")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? SelectEntireDocument ()
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectionForEntireDocumentXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectionForEntireDocumentXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="attributes">The attributes to set.</param><summary>Assigns the document attributes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDocumentAttributes (PdfDocumentAttributes? attributes)
		{
			DocumentAttributes = attributes?.GetDictionary ();
		}
		/// <param name="password">The password to use to unlock the document.</param><summary>Attempts to unlock the document with the specified <paramref name="password" />, returning <see langword="true" /> on success.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unlockWithPassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Unlock (string password)
		{
			if (password is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (password));
			var nspassword = CFString.CreateNative (password);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selUnlockWithPassword_XHandle, nspassword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnlockWithPassword_XHandle, nspassword);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspassword);
			return ret != 0;
		}
		/// <param name="path">The path to which to write.</param><summary>Writes the document to the specified path.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Write (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selWriteToFile_XHandle, nspath);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selWriteToFile_XHandle, nspath);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		/// <param name="path">The path to which to write.</param><param name="options">The write options.</param><summary>Writes the document to the specified path with the specified options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToFile:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Write (string path, NSDictionary? options)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var options__handle__ = options.GetHandle ();
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteToFile_WithOptions_XHandle, nspath, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteToFile_WithOptions_XHandle, nspath, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		/// <param name="path">The path to which to write.</param><param name="options">The write options.</param><summary>Writes the document to the specified path with the specified options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Write (string path, PdfDocumentWriteOptions options)
		{
			return Write (path, options.GetDictionary ()!);
		}
		/// <param name="url">The URL to which to write.</param><summary>Writes the document to the specified URL.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Write (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selWriteToURL_XHandle, url__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selWriteToURL_XHandle, url__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="url">The URL to which to write.</param><param name="options">The write options.</param><summary>Writes the document to the specified URL with the specified options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:withOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Write (NSUrl url, NSDictionary? options)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteToURL_WithOptions_XHandle, url__handle__, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteToURL_WithOptions_XHandle, url__handle__, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret != 0;
		}
		/// <param name="url">The URL to which to write.</param><param name="options">The write options.</param><summary>Writes the document to the specified URL with the specified options.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Write (NSUrl url, PdfDocumentWriteOptions options)
		{
			return Write (url, options.GetDictionary ()!);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual PdfAccessPermissions AccessPermissions {
			[Export ("accessPermissions")]
			get {
				PdfAccessPermissions ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfAccessPermissions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAccessPermissionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfAccessPermissions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAccessPermissionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows comments.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool AllowsCommenting {
			[Export ("allowsCommenting")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCommentingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCommentingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows content accessibility.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool AllowsContentAccessibility {
			[Export ("allowsContentAccessibility")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsContentAccessibilityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsContentAccessibilityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows copying.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsCopying {
			[Export ("allowsCopying")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCopyingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCopyingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows document assembly.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool AllowsDocumentAssembly {
			[Export ("allowsDocumentAssembly")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDocumentAssemblyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDocumentAssemblyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows changes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool AllowsDocumentChanges {
			[Export ("allowsDocumentChanges")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDocumentChangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDocumentChangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows form field entry.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public virtual bool AllowsFormFieldEntry {
			[Export ("allowsFormFieldEntry")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsFormFieldEntryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsFormFieldEntryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document allows printing.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsPrinting {
			[Export ("allowsPrinting")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsPrintingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsPrintingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>An instance of the PdfKit.IPdfDocumentDelegate model class which acts as the class delegate.</summary><value>The instance of the PdfKit.IPdfDocumentDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IPdfDocumentDelegate Delegate {
			get {
				return (WeakDelegate as IPdfDocumentDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Gets a Core Graphics PDF object for this PdfKit PDF object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPDFDocument? Document {
			[Export ("documentRef")]
			get {
				CGPDFDocument ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGPDFDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentRefXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGPDFDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentRefXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the attribute dictionary.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Use the strongly typed '[Get|Set]DocumentAttributes' instead.")]
		public virtual NSDictionary? DocumentAttributes {
			[Export ("documentAttributes", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDocumentAttributes:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDocumentAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDocumentAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the URL of the PDF document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? DocumentUrl {
			[Export ("documentURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document is encrypted.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEncrypted {
			[Export ("isEncrypted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEncryptedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEncryptedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document is currently searching for text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFinding {
			[Export ("isFinding")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFindingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFindingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the document is locked.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLocked {
			[Export ("isLocked")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLockedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLockedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets the major version number of the document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MajorVersion {
			[Export ("majorVersion")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMajorVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMajorVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the minor version of the document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MinorVersion {
			[Export ("minorVersion")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMinorVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMinorVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the root outline object.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfOutline? OutlineRoot {
			[Export ("outlineRoot")]
			get {
				PdfOutline? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfOutline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutlineRootXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfOutline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutlineRootXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutlineRoot:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOutlineRoot_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOutlineRoot_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the class (Objective-C type) of pages in the document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class PageClass {
			[Export ("pageClass")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPageClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPageClassXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the number of pages in the document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PageCount {
			[Export ("pageCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPageCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the .NET type of page objects in this document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::System.Type PageType {
			get {
				return (Class.Lookup (PageClass) as global::System.Type)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDocumentPermissions PermissionsStatus {
			[Export ("permissionsStatus")]
			get {
				PdfDocumentPermissions ret;
				if (IsDirectBinding) {
					ret = (PdfKit.PdfDocumentPermissions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPermissionsStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PdfKit.PdfDocumentPermissions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPermissionsStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a linefeed-separated, page-oriented string that contains the entire textual content of the PDF document.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Text {
			[Export ("string")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
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
		static NSString? _DidBeginFindNotification;
		/// <summary>Notification constant for DidBeginFind</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidBeginFind(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidBeginFind(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidBeginFind ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidBeginFind (Callback);
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
		///     PdfDocument.DidBeginFindNotification, (notification) => { Console.WriteLine ("Received the notification DidBeginFind", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidBeginFind", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidBeginFindNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidBeginFindNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidBeginFind helper method instead.")]
		public static NSString DidBeginFindNotification {
			get {
				if (_DidBeginFindNotification is null)
					_DidBeginFindNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidBeginFindNotification")!;
				return _DidBeginFindNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidBeginPageFindNotification;
		/// <summary>Notification constant for DidBeginPageFind</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidBeginPageFind(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidBeginPageFind(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidBeginPageFind ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidBeginPageFind (Callback);
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
		///     PdfDocument.DidBeginPageFindNotification, (notification) => { Console.WriteLine ("Received the notification DidBeginPageFind", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidBeginPageFind", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidBeginPageFindNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidBeginPageFindNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidBeginPageFind helper method instead.")]
		public static NSString DidBeginPageFindNotification {
			get {
				if (_DidBeginPageFindNotification is null)
					_DidBeginPageFindNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidBeginPageFindNotification")!;
				return _DidBeginPageFindNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidBeginPageWriteNotification;
		/// <summary>Notification constant for DidBeginPageWrite</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidBeginPageWrite(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidBeginPageWrite(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidBeginPageWrite ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidBeginPageWrite (Callback);
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
		///     PdfDocument.DidBeginPageWriteNotification, (notification) => { Console.WriteLine ("Received the notification DidBeginPageWrite", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidBeginPageWrite", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidBeginPageWriteNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidBeginPageWriteNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidBeginPageWrite helper method instead.")]
		public static NSString DidBeginPageWriteNotification {
			get {
				if (_DidBeginPageWriteNotification is null)
					_DidBeginPageWriteNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidBeginPageWriteNotification")!;
				return _DidBeginPageWriteNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidBeginWriteNotification;
		/// <summary>Notification constant for DidBeginWrite</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidBeginWrite(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidBeginWrite(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidBeginWrite ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidBeginWrite (Callback);
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
		///     PdfDocument.DidBeginWriteNotification, (notification) => { Console.WriteLine ("Received the notification DidBeginWrite", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidBeginWrite", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidBeginWriteNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidBeginWriteNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidBeginWrite helper method instead.")]
		public static NSString DidBeginWriteNotification {
			get {
				if (_DidBeginWriteNotification is null)
					_DidBeginWriteNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidBeginWriteNotification")!;
				return _DidBeginWriteNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidEndFindNotification;
		/// <summary>Notification constant for DidEndFind</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidEndFind(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidEndFind(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidEndFind ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidEndFind (Callback);
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
		///     PdfDocument.DidEndFindNotification, (notification) => { Console.WriteLine ("Received the notification DidEndFind", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidEndFind", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidEndFindNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidEndFindNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidEndFind helper method instead.")]
		public static NSString DidEndFindNotification {
			get {
				if (_DidEndFindNotification is null)
					_DidEndFindNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidEndFindNotification")!;
				return _DidEndFindNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidEndPageFindNotification;
		/// <summary>Notification constant for DidEndPageFind</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidEndPageFind(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidEndPageFind(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidEndPageFind ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidEndPageFind (Callback);
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
		///     PdfDocument.DidEndPageFindNotification, (notification) => { Console.WriteLine ("Received the notification DidEndPageFind", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidEndPageFind", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidEndPageFindNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidEndPageFindNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidEndPageFind helper method instead.")]
		public static NSString DidEndPageFindNotification {
			get {
				if (_DidEndPageFindNotification is null)
					_DidEndPageFindNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidEndPageFindNotification")!;
				return _DidEndPageFindNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidEndPageWriteNotification;
		/// <summary>Notification constant for DidEndPageWrite</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidEndPageWrite(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidEndPageWrite(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidEndPageWrite ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidEndPageWrite (Callback);
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
		///     PdfDocument.DidEndPageWriteNotification, (notification) => { Console.WriteLine ("Received the notification DidEndPageWrite", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidEndPageWrite", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidEndPageWriteNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidEndPageWriteNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidEndPageWrite helper method instead.")]
		public static NSString DidEndPageWriteNotification {
			get {
				if (_DidEndPageWriteNotification is null)
					_DidEndPageWriteNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidEndPageWriteNotification")!;
				return _DidEndPageWriteNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidEndWriteNotification;
		/// <summary>Notification constant for DidEndWrite</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidEndWrite(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidEndWrite(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidEndWrite ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidEndWrite (Callback);
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
		///     PdfDocument.DidEndWriteNotification, (notification) => { Console.WriteLine ("Received the notification DidEndWrite", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidEndWrite", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidEndWriteNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidEndWriteNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidEndWrite helper method instead.")]
		public static NSString DidEndWriteNotification {
			get {
				if (_DidEndWriteNotification is null)
					_DidEndWriteNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidEndWriteNotification")!;
				return _DidEndWriteNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidFindMatchNotification;
		/// <summary>Notification constant for DidFindMatch</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidFindMatch(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidFindMatch(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidFindMatch ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidFindMatch (Callback);
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
		///     PdfDocument.DidFindMatchNotification, (notification) => { Console.WriteLine ("Received the notification DidFindMatch", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidFindMatch", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidFindMatchNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidFindMatchNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidFindMatch helper method instead.")]
		public static NSString DidFindMatchNotification {
			get {
				if (_DidFindMatchNotification is null)
					_DidFindMatchNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidFindMatchNotification")!;
				return _DidFindMatchNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidUnlockNotification;
		/// <summary>Notification constant for DidUnlock</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidUnlock(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidUnlock(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = PdfDocument.Notifications.ObserveDidUnlock ((sender, args) => {
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
		/// void Callback (object sender, PdfDocument.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PdfDocument.Notifications.ObserveDidUnlock (Callback);
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
		///     PdfDocument.DidUnlockNotification, (notification) => { Console.WriteLine ("Received the notification DidUnlock", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidUnlock", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PdfDocument.DidUnlockNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PDFDocumentDidUnlockNotification",  "Quartz")]
		[Advice ("Use PdfDocument.Notifications.ObserveDidUnlock helper method instead.")]
		public static NSString DidUnlockNotification {
			get {
				if (_DidUnlockNotification is null)
					_DidUnlockNotification = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentDidUnlockNotification")!;
				return _DidUnlockNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FoundSelectionKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentFoundSelectionKey'.</summary>
		[Field ("PDFDocumentFoundSelectionKey",  "PdfKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString FoundSelectionKey {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_FoundSelectionKey is null)
					_FoundSelectionKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentFoundSelectionKey")!;
				return _FoundSelectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageIndexKey;
		/// <summary>Represents the value associated with the constant 'PDFDocumentPageIndexKey'.</summary>
		[Field ("PDFDocumentPageIndexKey",  "PdfKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		public static NSString PageIndexKey {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos18.2")]
			get {
				if (_PageIndexKey is null)
					_PageIndexKey = Dlfcn.GetStringConstant (Libraries.PdfKit.Handle, "PDFDocumentPageIndexKey")!;
				return _PageIndexKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_PdfDocumentDelegate); }
		}
		internal virtual _PdfDocumentDelegate CreateInternalEventDelegateType ()
		{
			return (_PdfDocumentDelegate)(new _PdfDocumentDelegate());
		}
		internal _PdfDocumentDelegate EnsurePdfDocumentDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _PdfDocumentDelegate;
			if (del is null){
				del = (_PdfDocumentDelegate)CreateInternalEventDelegateType ();
				Delegate = (IPdfDocumentDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _PdfDocumentDelegate : NSObject, IPdfDocumentDelegate { 
			public _PdfDocumentDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_PdfDocumentDelegate))]
			static _PdfDocumentDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? didBeginDocumentFind;
			[Export ("documentDidBeginDocumentFind:")]
			public void DidBeginDocumentFind (NSNotification notification)
			{
				var handler = didBeginDocumentFind;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? didMatchString;
			[Export ("didMatchString:")]
			public void DidMatchString (PdfKit.PdfSelection sender)
			{
				var handler = didMatchString;
				if (handler is not null){
					handler (sender, EventArgs.Empty);
				}
			}
			internal EventHandler? didUnlock;
			[Export ("documentDidUnlock:")]
			public void DidUnlock (NSNotification notification)
			{
				var handler = didUnlock;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? findFinished;
			[Export ("documentDidEndDocumentFind:")]
			public void FindFinished (NSNotification notification)
			{
				var handler = findFinished;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal ClassForAnnotationClassDelegate? getClassForAnnotationClass;
			[Export ("classForAnnotationClass:")]
			public Class GetClassForAnnotationClass (Class sender)
			{
				var handler = getClassForAnnotationClass;
				if (handler is not null)
					return handler (sender);
				return null!;
			}
			internal ClassForAnnotationTypeDelegate? getClassForAnnotationType;
			[Export ("classForAnnotationType:")]
			public Class GetClassForAnnotationType (string annotationType)
			{
				var handler = getClassForAnnotationType;
				if (handler is not null)
					return handler (annotationType);
				return null!;
			}
			internal EventHandler? matchFound;
			[Export ("documentDidFindMatch:")]
			public void MatchFound (NSNotification notification)
			{
				var handler = matchFound;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? pageFindFinished;
			[Export ("documentDidEndPageFind:")]
			public void PageFindFinished (NSNotification notification)
			{
				var handler = pageFindFinished;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? pageFindStarted;
			[Export ("documentDidBeginPageFind:")]
			public void PageFindStarted (NSNotification notification)
			{
				var handler = pageFindStarted;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidBeginDocumentFind {
			add { EnsurePdfDocumentDelegate ()!.didBeginDocumentFind += value; }
			remove { EnsurePdfDocumentDelegate ()!.didBeginDocumentFind -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidMatchString {
			add { EnsurePdfDocumentDelegate ()!.didMatchString += value; }
			remove { EnsurePdfDocumentDelegate ()!.didMatchString -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidUnlock {
			add { EnsurePdfDocumentDelegate ()!.didUnlock += value; }
			remove { EnsurePdfDocumentDelegate ()!.didUnlock -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler FindFinished {
			add { EnsurePdfDocumentDelegate ()!.findFinished += value; }
			remove { EnsurePdfDocumentDelegate ()!.findFinished -= value; }
		}
		public ClassForAnnotationClassDelegate? GetClassForAnnotationClass {
			get { return EnsurePdfDocumentDelegate ()!.getClassForAnnotationClass; }
			set { EnsurePdfDocumentDelegate ()!.getClassForAnnotationClass = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public ClassForAnnotationTypeDelegate? GetClassForAnnotationType {
			get { return EnsurePdfDocumentDelegate ()!.getClassForAnnotationType; }
			set { EnsurePdfDocumentDelegate ()!.getClassForAnnotationType = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler MatchFound {
			add { EnsurePdfDocumentDelegate ()!.matchFound += value; }
			remove { EnsurePdfDocumentDelegate ()!.matchFound -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler PageFindFinished {
			add { EnsurePdfDocumentDelegate ()!.pageFindFinished += value; }
			remove { EnsurePdfDocumentDelegate ()!.pageFindFinished -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler PageFindStarted {
			add { EnsurePdfDocumentDelegate ()!.pageFindStarted += value; }
			remove { EnsurePdfDocumentDelegate ()!.pageFindStarted -= value; }
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
		/// <summary>Notifications posted by the <see cref="global::PdfKit.PdfDocument" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginFindNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginFindNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidBeginFind ((notification) => {
			///   Console.WriteLine ("Observed DidBeginFindNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginFind (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginFindNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginFindNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidBeginFind (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidBeginFindNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginFind (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginPageFindNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginPageFindNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidBeginPageFind ((notification) => {
			///   Console.WriteLine ("Observed DidBeginPageFindNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginPageFind (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginPageFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginPageFindNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginPageFindNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidBeginPageFind (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidBeginPageFindNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginPageFind (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginPageFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginPageWriteNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginPageWriteNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidBeginPageWrite ((notification) => {
			///   Console.WriteLine ("Observed DidBeginPageWriteNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginPageWrite (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginPageWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginPageWriteNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginPageWriteNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidBeginPageWrite (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidBeginPageWriteNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginPageWrite (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginPageWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginWriteNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginWriteNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidBeginWrite ((notification) => {
			///   Console.WriteLine ("Observed DidBeginWriteNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginWrite (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidBeginWriteNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidBeginWriteNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidBeginWrite (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidBeginWriteNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidBeginWrite (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidBeginWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndFindNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndFindNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidEndFind ((notification) => {
			///   Console.WriteLine ("Observed DidEndFindNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndFind (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndFindNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndFindNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidEndFind (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidEndFindNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndFind (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndPageFindNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndPageFindNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidEndPageFind ((notification) => {
			///   Console.WriteLine ("Observed DidEndPageFindNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndPageFind (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndPageFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndPageFindNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndPageFindNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidEndPageFind (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidEndPageFindNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndPageFind (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndPageFindNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndPageWriteNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndPageWriteNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidEndPageWrite ((notification) => {
			///   Console.WriteLine ("Observed DidEndPageWriteNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndPageWrite (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndPageWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndPageWriteNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndPageWriteNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidEndPageWrite (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidEndPageWriteNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndPageWrite (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndPageWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndWriteNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndWriteNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidEndWrite ((notification) => {
			///   Console.WriteLine ("Observed DidEndWriteNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndWrite (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidEndWriteNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidEndWriteNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidEndWrite (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidEndWriteNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidEndWrite (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidEndWriteNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidFindMatchNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidFindMatchNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidFindMatch ((notification) => {
			///   Console.WriteLine ("Observed DidFindMatchNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidFindMatch (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFindMatchNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidFindMatchNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidFindMatchNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidFindMatch (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidFindMatchNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidFindMatch (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidFindMatchNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidUnlockNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidUnlockNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PdfDocument.Notifications.ObserveDidUnlock ((notification) => {
			///   Console.WriteLine ("Observed DidUnlockNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnlock (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidUnlockNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PdfKit.PdfDocument.DidUnlockNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PdfKit.PdfDocument.DidUnlockNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PdfDocument.Notifications.ObserveDidUnlock (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidUnlockNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidUnlock (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidUnlockNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class PdfDocument */
}
