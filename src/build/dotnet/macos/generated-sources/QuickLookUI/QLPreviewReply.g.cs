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
namespace QuickLookUI {
	[Register("QLPreviewReply", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class QLPreviewReply : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentsX = "attachments";
		static readonly NativeHandle selAttachmentsXHandle = Selector.GetHandle ("attachments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForPDFWithPageSize_DocumentCreationBlock_X = "initForPDFWithPageSize:documentCreationBlock:";
		static readonly NativeHandle selInitForPDFWithPageSize_DocumentCreationBlock_XHandle = Selector.GetHandle ("initForPDFWithPageSize:documentCreationBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContextSize_IsBitmap_DrawingBlock_X = "initWithContextSize:isBitmap:drawingBlock:";
		static readonly NativeHandle selInitWithContextSize_IsBitmap_DrawingBlock_XHandle = Selector.GetHandle ("initWithContextSize:isBitmap:drawingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDataOfContentType_ContentSize_DataCreationBlock_X = "initWithDataOfContentType:contentSize:dataCreationBlock:";
		static readonly NativeHandle selInitWithDataOfContentType_ContentSize_DataCreationBlock_XHandle = Selector.GetHandle ("initWithDataOfContentType:contentSize:dataCreationBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFileURL_X = "initWithFileURL:";
		static readonly NativeHandle selInitWithFileURL_XHandle = Selector.GetHandle ("initWithFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttachments_X = "setAttachments:";
		static readonly NativeHandle selSetAttachments_XHandle = Selector.GetHandle ("setAttachments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStringEncoding_X = "setStringEncoding:";
		static readonly NativeHandle selSetStringEncoding_XHandle = Selector.GetHandle ("setStringEncoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringEncodingX = "stringEncoding";
		static readonly NativeHandle selStringEncodingXHandle = Selector.GetHandle ("stringEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("QLPreviewReply");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="QLPreviewReply" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QLPreviewReply () : base (NSObjectFlag.Empty)
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
		protected QLPreviewReply (NSObjectFlag t) : base (t)
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
		protected internal QLPreviewReply (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithContextSize:isBitmap:drawingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe QLPreviewReply (CGSize contextSize, bool isBitmap, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDQLPreviewReplyDrawingHandler))]QLPreviewReplyDrawingHandler drawingHandler)
			: base (NSObjectFlag.Empty)
		{
			if (drawingHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (drawingHandler));
			using var block_drawingHandler = Trampolines.SDQLPreviewReplyDrawingHandler.CreateBlock (drawingHandler);
			BlockLiteral *block_ptr_drawingHandler = &block_drawingHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_bool_NativeHandle (this.Handle, selInitWithContextSize_IsBitmap_DrawingBlock_XHandle, contextSize, isBitmap ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_drawingHandler), "initWithContextSize:isBitmap:drawingBlock:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize_bool_NativeHandle (&__objc_super__, selInitWithContextSize_IsBitmap_DrawingBlock_XHandle, contextSize, isBitmap ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_drawingHandler), "initWithContextSize:isBitmap:drawingBlock:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public QLPreviewReply (NSUrl fileUrl)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithFileURL_XHandle, fileUrl__handle__), "initWithFileURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithFileURL_XHandle, fileUrl__handle__), "initWithFileURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
		}
		[Export ("initWithDataOfContentType:contentSize:dataCreationBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe QLPreviewReply (global::UniformTypeIdentifiers.UTType contentType, CGSize contentSize, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDQLPreviewReplyDataCreationHandler))]QLPreviewReplyDataCreationHandler dataCreationHandler)
			: base (NSObjectFlag.Empty)
		{
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (dataCreationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataCreationHandler));
			using var block_dataCreationHandler = Trampolines.SDQLPreviewReplyDataCreationHandler.CreateBlock (dataCreationHandler);
			BlockLiteral *block_ptr_dataCreationHandler = &block_dataCreationHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGSize_NativeHandle (this.Handle, selInitWithDataOfContentType_ContentSize_DataCreationBlock_XHandle, contentType__handle__, contentSize, (IntPtr) block_ptr_dataCreationHandler), "initWithDataOfContentType:contentSize:dataCreationBlock:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGSize_NativeHandle (&__objc_super__, selInitWithDataOfContentType_ContentSize_DataCreationBlock_XHandle, contentType__handle__, contentSize, (IntPtr) block_ptr_dataCreationHandler), "initWithDataOfContentType:contentSize:dataCreationBlock:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
		}
		[Export ("initForPDFWithPageSize:documentCreationBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe QLPreviewReply (CGSize defaultPageSize, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDQLPreviewReplyUIDocumentCreationHandler))]QLPreviewReplyUIDocumentCreationHandler documentCreationHandler)
			: base (NSObjectFlag.Empty)
		{
			if (documentCreationHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (documentCreationHandler));
			using var block_documentCreationHandler = Trampolines.SDQLPreviewReplyUIDocumentCreationHandler.CreateBlock (documentCreationHandler);
			BlockLiteral *block_ptr_documentCreationHandler = &block_documentCreationHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_NativeHandle (this.Handle, selInitForPDFWithPageSize_DocumentCreationBlock_XHandle, defaultPageSize, (IntPtr) block_ptr_documentCreationHandler), "initForPDFWithPageSize:documentCreationBlock:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize_NativeHandle (&__objc_super__, selInitForPDFWithPageSize_DocumentCreationBlock_XHandle, defaultPageSize, (IntPtr) block_ptr_documentCreationHandler), "initForPDFWithPageSize:documentCreationBlock:");
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, QLPreviewReplyAttachment> Attachments {
			[Export ("attachments", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, QLPreviewReplyAttachment>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, QLPreviewReplyAttachment>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttachmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, QLPreviewReplyAttachment>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttachmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttachments:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttachments_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttachments_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSStringEncoding StringEncoding {
			[Export ("stringEncoding")]
			get {
				NSStringEncoding ret;
				if (IsDirectBinding) {
					ret = (NSStringEncoding) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStringEncodingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSStringEncoding) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStringEncodingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStringEncoding:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetStringEncoding_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetStringEncoding_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class QLPreviewReply */
}
