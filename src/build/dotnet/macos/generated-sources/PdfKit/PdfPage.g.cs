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
	/// <summary>Class for working with and rendering PDF pages.</summary>
	[Register("PDFPage", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PdfPage : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnnotation_X = "addAnnotation:";
		static readonly NativeHandle selAddAnnotation_XHandle = Selector.GetHandle ("addAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationAtPoint_X = "annotationAtPoint:";
		static readonly NativeHandle selAnnotationAtPoint_XHandle = Selector.GetHandle ("annotationAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnnotationsX = "annotations";
		static readonly NativeHandle selAnnotationsXHandle = Selector.GetHandle ("annotations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringX = "attributedString";
		static readonly NativeHandle selAttributedStringXHandle = Selector.GetHandle ("attributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsForBox_X = "boundsForBox:";
		static readonly NativeHandle selBoundsForBox_XHandle = Selector.GetHandle ("boundsForBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterBoundsAtIndex_X = "characterBoundsAtIndex:";
		static readonly NativeHandle selCharacterBoundsAtIndex_XHandle = Selector.GetHandle ("characterBoundsAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterIndexAtPoint_X = "characterIndexAtPoint:";
		static readonly NativeHandle selCharacterIndexAtPoint_XHandle = Selector.GetHandle ("characterIndexAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataRepresentationX = "dataRepresentation";
		static readonly NativeHandle selDataRepresentationXHandle = Selector.GetHandle ("dataRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysAnnotationsX = "displaysAnnotations";
		static readonly NativeHandle selDisplaysAnnotationsXHandle = Selector.GetHandle ("displaysAnnotations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentX = "document";
		static readonly NativeHandle selDocumentXHandle = Selector.GetHandle ("document");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithBox_X = "drawWithBox:";
		static readonly NativeHandle selDrawWithBox_XHandle = Selector.GetHandle ("drawWithBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithBox_ToContext_X = "drawWithBox:toContext:";
		static readonly NativeHandle selDrawWithBox_ToContext_XHandle = Selector.GetHandle ("drawWithBox:toContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithImage_X = "initWithImage:";
		static readonly NativeHandle selInitWithImage_XHandle = Selector.GetHandle ("initWithImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithImage_Options_X = "initWithImage:options:";
		static readonly NativeHandle selInitWithImage_Options_XHandle = Selector.GetHandle ("initWithImage:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfCharactersX = "numberOfCharacters";
		static readonly NativeHandle selNumberOfCharactersXHandle = Selector.GetHandle ("numberOfCharacters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageRefX = "pageRef";
		static readonly NativeHandle selPageRefXHandle = Selector.GetHandle ("pageRef");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnnotation_X = "removeAnnotation:";
		static readonly NativeHandle selRemoveAnnotation_XHandle = Selector.GetHandle ("removeAnnotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotationX = "rotation";
		static readonly NativeHandle selRotationXHandle = Selector.GetHandle ("rotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionForLineAtPoint_X = "selectionForLineAtPoint:";
		static readonly NativeHandle selSelectionForLineAtPoint_XHandle = Selector.GetHandle ("selectionForLineAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionForRange_X = "selectionForRange:";
		static readonly NativeHandle selSelectionForRange_XHandle = Selector.GetHandle ("selectionForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionForRect_X = "selectionForRect:";
		static readonly NativeHandle selSelectionForRect_XHandle = Selector.GetHandle ("selectionForRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionForWordAtPoint_X = "selectionForWordAtPoint:";
		static readonly NativeHandle selSelectionForWordAtPoint_XHandle = Selector.GetHandle ("selectionForWordAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionFromPoint_ToPoint_X = "selectionFromPoint:toPoint:";
		static readonly NativeHandle selSelectionFromPoint_ToPoint_XHandle = Selector.GetHandle ("selectionFromPoint:toPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBounds_ForBox_X = "setBounds:forBox:";
		static readonly NativeHandle selSetBounds_ForBox_XHandle = Selector.GetHandle ("setBounds:forBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysAnnotations_X = "setDisplaysAnnotations:";
		static readonly NativeHandle selSetDisplaysAnnotations_XHandle = Selector.GetHandle ("setDisplaysAnnotations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRotation_X = "setRotation:";
		static readonly NativeHandle selSetRotation_XHandle = Selector.GetHandle ("setRotation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringX = "string";
		static readonly NativeHandle selStringXHandle = Selector.GetHandle ("string");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThumbnailOfSize_ForBox_X = "thumbnailOfSize:forBox:";
		static readonly NativeHandle selThumbnailOfSize_ForBox_XHandle = Selector.GetHandle ("thumbnailOfSize:forBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformContext_ForBox_X = "transformContext:forBox:";
		static readonly NativeHandle selTransformContext_ForBox_XHandle = Selector.GetHandle ("transformContext:forBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformContextForBox_X = "transformContextForBox:";
		static readonly NativeHandle selTransformContextForBox_XHandle = Selector.GetHandle ("transformContextForBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformForBox_X = "transformForBox:";
		static readonly NativeHandle selTransformForBox_XHandle = Selector.GetHandle ("transformForBox:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PDFPage");
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
		protected PdfPage (NSObjectFlag t) : base (t)
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
		protected internal PdfPage (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Creates a new PDF page object with default values.</summary><remarks />
		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfPage ()
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
		/// <param name="image">To be added.</param><summary>Creates a new PDF page object from the specified <paramref name="image" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfPage (global::AppKit.NSImage image)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithImage_XHandle, image__handle__), "initWithImage:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithImage_XHandle, image__handle__), "initWithImage:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("initWithImage:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfPage (global::AppKit.NSImage image, NSDictionary options)
			: base (NSObjectFlag.Empty)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithImage_Options_XHandle, image__handle__, options__handle__), "initWithImage:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithImage_Options_XHandle, image__handle__, options__handle__), "initWithImage:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (options);
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PdfPage (global::AppKit.NSImage image, PdfPageImageInitializationOption options)
			: this (image, options.GetDictionary ()!)
		{
		}
		/// <param name="annotation">The annotation to add.</param><summary>Adds the specified annotation to the PDF page.</summary><remarks>To be added.</remarks>
		[Export ("addAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (PdfAnnotation annotation)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddAnnotation_XHandle, annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddAnnotation_XHandle, annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
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
		/// <param name="box">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithBox:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (PdfDisplayBox box)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDrawWithBox_XHandle, (IntPtr) (long) box);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selDrawWithBox_XHandle, (IntPtr) (long) box);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="box">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithBox:toContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (PdfDisplayBox box, CGContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selDrawWithBox_ToContext_XHandle, (IntPtr) (long) box, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selDrawWithBox_ToContext_XHandle, (IntPtr) (long) box, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		/// <param name="point">The point for which to attempt to get an annotation.</param><summary>Returns the annotation for the specified point on the page, or <see langword="null" /> if the point is not annotated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("annotationAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfAnnotation? GetAnnotation (CGPoint point)
		{
			PdfAnnotation ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfAnnotation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selAnnotationAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfAnnotation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selAnnotationAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="box">The box for which to get the bounding rectangle.</param><summary>Returns a rectangle that describes the bounds for the specified display box.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundsForBox:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundsForBox (PdfDisplayBox box)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selBoundsForBox_XHandle, (IntPtr) (long) box);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selBoundsForBox_XHandle, (IntPtr) (long) box);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selBoundsForBox_XHandle, (IntPtr) (long) box);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selBoundsForBox_XHandle, (IntPtr) (long) box);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="index">The index of the character for which to get its bounding box.</param><summary>Returns a rectangle that describes the bounds for the character at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterBoundsAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCharacterBounds (nint index)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_IntPtr (this.Handle, selCharacterBoundsAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_IntPtr (this.Handle, selCharacterBoundsAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_IntPtr (&__objc_super__, selCharacterBoundsAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selCharacterBoundsAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="point">The point over a character for which to get its bounding box.</param><summary>Returns the index of the character at the specified point.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterIndexAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetCharacterIndex (CGPoint point)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, selCharacterIndexAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selCharacterIndexAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="rect">The rectangle, in user coordinates, for which to get the selection.</param><summary>Returns the text in the specified rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionForRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (CGRect rect)
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selSelectionForRect_XHandle, rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selSelectionForRect_XHandle, rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="startPoint">The first point of the selection rectangle.</param><param name="endPoint">The final point of the selection rectangle.</param><summary>Returns the text in the rectangle that is specified by the user-coordinate-space start and end points.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionFromPoint:toPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (CGPoint startPoint, CGPoint endPoint)
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_CGPoint (this.Handle, selSelectionFromPoint_ToPoint_XHandle, startPoint, endPoint), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, selSelectionFromPoint_ToPoint_XHandle, startPoint, endPoint), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="range">The text range to select.</param><summary>Returns a selection for the specified range.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? GetSelection (NSRange range)
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selSelectionForRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selSelectionForRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Get a thumbnail for this page of the specified <paramref name="size" />.</summary><param name="size">The size of the returned thumbnail.</param><param name="box">The box type where the thumbnail will be rendered.</param>
		[Export ("thumbnailOfSize:forBox:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage GetThumbnail (CGSize size, PdfDisplayBox box)
		{
			global::AppKit.NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_IntPtr (this.Handle, selThumbnailOfSize_ForBox_XHandle, size, (IntPtr) (long) box), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize_IntPtr (&__objc_super__, selThumbnailOfSize_ForBox_XHandle, size, (IntPtr) (long) box), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="box">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("transformForBox:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetTransform (PdfDisplayBox box)
		{
			CGAffineTransform ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_IntPtr (this.Handle, selTransformForBox_XHandle, (IntPtr) (long) box);
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_IntPtr (this.Handle, selTransformForBox_XHandle, (IntPtr) (long) box);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_IntPtr (&__objc_super__, selTransformForBox_XHandle, (IntPtr) (long) box);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret_IntPtr (&__objc_super__, selTransformForBox_XHandle, (IntPtr) (long) box);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="annotation">The annotation to remove.</param><summary>Removes the specified annotation.</summary><remarks>To be added.</remarks>
		[Export ("removeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotation (PdfAnnotation annotation)
		{
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAnnotation_XHandle, annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAnnotation_XHandle, annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
		}
		/// <param name="point">A point on the line to select.</param><summary>Returns the line of text that is under the specified point.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionForLineAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? SelectLine (CGPoint point)
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selSelectionForLineAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selSelectionForLineAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">A point on the word to select.</param><summary>Returns the word that is under the specified point.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("selectionForWordAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfSelection? SelectWord (CGPoint point)
		{
			PdfSelection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selSelectionForWordAtPoint_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PdfSelection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selSelectionForWordAtPoint_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="bounds">The bounds to set.</param><param name="box">The box for which to set the bounds.</param><summary>Sets the bounds for the specified box, creating a box if none exists.</summary><remarks>To be added.</remarks>
		[Export ("setBounds:forBox:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBoundsForBox (CGRect bounds, PdfDisplayBox box)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_IntPtr (this.Handle, selSetBounds_ForBox_XHandle, bounds, (IntPtr) (long) box);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_IntPtr (&__objc_super__, selSetBounds_ForBox_XHandle, bounds, (IntPtr) (long) box);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="context">To be added.</param><param name="box">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("transformContext:forBox:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransformContext (CGContext context, PdfDisplayBox box)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selTransformContext_ForBox_XHandle, context.Handle, (IntPtr) (long) box);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selTransformContext_ForBox_XHandle, context.Handle, (IntPtr) (long) box);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		/// <param name="box">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("transformContextForBox:")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("macos10.12")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransformContext (PdfDisplayBox box)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTransformContextForBox_XHandle, (IntPtr) (long) box);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selTransformContextForBox_XHandle, (IntPtr) (long) box);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Gets an array that contains all the annotations on the PDF page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfAnnotation[] Annotations {
			[Export ("annotations")]
			get {
				PdfAnnotation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PdfAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnnotationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PdfAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnnotationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the text contents of the PDF page as an annotate string.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? AttributedString {
			[Export ("attributedString")]
			get {
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of characters in the text content of the PDF page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CharacterCount {
			[Export ("numberOfCharacters")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfCharactersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfCharactersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the PDF page data as an NSData object.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? DataRepresentation {
			[Export ("dataRepresentation")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataRepresentationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataRepresentationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether annotations are displayed.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysAnnotations {
			[Export ("displaysAnnotations")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysAnnotationsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysAnnotationsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysAnnotations:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysAnnotations_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysAnnotations_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the PDF document object that contains the PDF page.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PdfDocument? Document {
			[Export ("document")]
			get {
				PdfDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PdfDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PdfDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the page label.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the Core Graphics PDFPage object for this PDF page.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPDFPage? Page {
			[Export ("pageRef")]
			get {
				CGPDFPage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGPDFPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPageRefXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGPDFPage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPageRefXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the rotation, in degrees, for displaying the page.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Rotation {
			[Export ("rotation")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRotation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetRotation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the text content of the page.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
	} /* class PdfPage */
}
