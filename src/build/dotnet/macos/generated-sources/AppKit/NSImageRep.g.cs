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
	[Register("NSImageRep", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSImageRep : NSObject, INSCoding, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGImageForProposedRect_Context_Hints_X = "CGImageForProposedRect:context:hints:";
		static readonly NativeHandle selCGImageForProposedRect_Context_Hints_XHandle = Selector.GetHandle ("CGImageForProposedRect:context:hints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitsPerSampleX = "bitsPerSample";
		static readonly NativeHandle selBitsPerSampleXHandle = Selector.GetHandle ("bitsPerSample");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanInitWithData_X = "canInitWithData:";
		static readonly NativeHandle selCanInitWithData_XHandle = Selector.GetHandle ("canInitWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanInitWithPasteboard_X = "canInitWithPasteboard:";
		static readonly NativeHandle selCanInitWithPasteboard_XHandle = Selector.GetHandle ("canInitWithPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceNameX = "colorSpaceName";
		static readonly NativeHandle selColorSpaceNameXHandle = Selector.GetHandle ("colorSpaceName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawX = "draw";
		static readonly NativeHandle selDrawXHandle = Selector.GetHandle ("draw");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_X = "drawAtPoint:";
		static readonly NativeHandle selDrawAtPoint_XHandle = Selector.GetHandle ("drawAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_X = "drawInRect:";
		static readonly NativeHandle selDrawInRect_XHandle = Selector.GetHandle ("drawInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_X = "drawInRect:fromRect:operation:fraction:respectFlipped:hints:";
		static readonly NativeHandle selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_XHandle = Selector.GetHandle ("drawInRect:fromRect:operation:fraction:respectFlipped:hints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAlphaX = "hasAlpha";
		static readonly NativeHandle selHasAlphaXHandle = Selector.GetHandle ("hasAlpha");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageFileTypesX = "imageFileTypes";
		static readonly NativeHandle selImageFileTypesXHandle = Selector.GetHandle ("imageFileTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImagePasteboardTypesX = "imagePasteboardTypes";
		static readonly NativeHandle selImagePasteboardTypesXHandle = Selector.GetHandle ("imagePasteboardTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepClassForData_X = "imageRepClassForData:";
		static readonly NativeHandle selImageRepClassForData_XHandle = Selector.GetHandle ("imageRepClassForData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepClassForFileType_X = "imageRepClassForFileType:";
		static readonly NativeHandle selImageRepClassForFileType_XHandle = Selector.GetHandle ("imageRepClassForFileType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepClassForPasteboardType_X = "imageRepClassForPasteboardType:";
		static readonly NativeHandle selImageRepClassForPasteboardType_XHandle = Selector.GetHandle ("imageRepClassForPasteboardType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepClassForType_X = "imageRepClassForType:";
		static readonly NativeHandle selImageRepClassForType_XHandle = Selector.GetHandle ("imageRepClassForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepWithContentsOfFile_X = "imageRepWithContentsOfFile:";
		static readonly NativeHandle selImageRepWithContentsOfFile_XHandle = Selector.GetHandle ("imageRepWithContentsOfFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepWithContentsOfURL_X = "imageRepWithContentsOfURL:";
		static readonly NativeHandle selImageRepWithContentsOfURL_XHandle = Selector.GetHandle ("imageRepWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepWithPasteboard_X = "imageRepWithPasteboard:";
		static readonly NativeHandle selImageRepWithPasteboard_XHandle = Selector.GetHandle ("imageRepWithPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepsWithContentsOfFile_X = "imageRepsWithContentsOfFile:";
		static readonly NativeHandle selImageRepsWithContentsOfFile_XHandle = Selector.GetHandle ("imageRepsWithContentsOfFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepsWithContentsOfURL_X = "imageRepsWithContentsOfURL:";
		static readonly NativeHandle selImageRepsWithContentsOfURL_XHandle = Selector.GetHandle ("imageRepsWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRepsWithPasteboard_X = "imageRepsWithPasteboard:";
		static readonly NativeHandle selImageRepsWithPasteboard_XHandle = Selector.GetHandle ("imageRepsWithPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageTypesX = "imageTypes";
		static readonly NativeHandle selImageTypesXHandle = Selector.GetHandle ("imageTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageUnfilteredFileTypesX = "imageUnfilteredFileTypes";
		static readonly NativeHandle selImageUnfilteredFileTypesXHandle = Selector.GetHandle ("imageUnfilteredFileTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageUnfilteredPasteboardTypesX = "imageUnfilteredPasteboardTypes";
		static readonly NativeHandle selImageUnfilteredPasteboardTypesXHandle = Selector.GetHandle ("imageUnfilteredPasteboardTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageUnfilteredTypesX = "imageUnfilteredTypes";
		static readonly NativeHandle selImageUnfilteredTypesXHandle = Selector.GetHandle ("imageUnfilteredTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOpaqueX = "isOpaque";
		static readonly NativeHandle selIsOpaqueXHandle = Selector.GetHandle ("isOpaque");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutDirectionX = "layoutDirection";
		static readonly NativeHandle selLayoutDirectionXHandle = Selector.GetHandle ("layoutDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelsHighX = "pixelsHigh";
		static readonly NativeHandle selPixelsHighXHandle = Selector.GetHandle ("pixelsHigh");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelsWideX = "pixelsWide";
		static readonly NativeHandle selPixelsWideXHandle = Selector.GetHandle ("pixelsWide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterImageRepClass_X = "registerImageRepClass:";
		static readonly NativeHandle selRegisterImageRepClass_XHandle = Selector.GetHandle ("registerImageRepClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisteredImageRepClassesX = "registeredImageRepClasses";
		static readonly NativeHandle selRegisteredImageRepClassesXHandle = Selector.GetHandle ("registeredImageRepClasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlpha_X = "setAlpha:";
		static readonly NativeHandle selSetAlpha_XHandle = Selector.GetHandle ("setAlpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBitsPerSample_X = "setBitsPerSample:";
		static readonly NativeHandle selSetBitsPerSample_XHandle = Selector.GetHandle ("setBitsPerSample:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorSpaceName_X = "setColorSpaceName:";
		static readonly NativeHandle selSetColorSpaceName_XHandle = Selector.GetHandle ("setColorSpaceName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutDirection_X = "setLayoutDirection:";
		static readonly NativeHandle selSetLayoutDirection_XHandle = Selector.GetHandle ("setLayoutDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOpaque_X = "setOpaque:";
		static readonly NativeHandle selSetOpaque_XHandle = Selector.GetHandle ("setOpaque:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPixelsHigh_X = "setPixelsHigh:";
		static readonly NativeHandle selSetPixelsHigh_XHandle = Selector.GetHandle ("setPixelsHigh:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPixelsWide_X = "setPixelsWide:";
		static readonly NativeHandle selSetPixelsWide_XHandle = Selector.GetHandle ("setPixelsWide:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSize_X = "setSize:";
		static readonly NativeHandle selSetSize_XHandle = Selector.GetHandle ("setSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeX = "size";
		static readonly NativeHandle selSizeXHandle = Selector.GetHandle ("size");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnregisterImageRepClass_X = "unregisterImageRepClass:";
		static readonly NativeHandle selUnregisterImageRepClass_XHandle = Selector.GetHandle ("unregisterImageRepClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSImageRep");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSImageRep" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSImageRep () : base (NSObjectFlag.Empty)
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
		public NSImageRep (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSImageRep (NSObjectFlag t) : base (t)
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
		protected internal NSImageRep (NativeHandle handle) : base (handle)
		{
		}

		[Export ("CGImageForProposedRect:context:hints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGImage AsCGImage (ref CGRect proposedDestRect, NSGraphicsContext? context, NSDictionary? hints)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			var hints__handle__ = hints.GetHandle ();
			fixed (CGRect* proposedDestRect__pointer = &proposedDestRect) {
			CGImage? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_CGRect_NativeHandle_NativeHandle (this.Handle, selCGImageForProposedRect_Context_Hints_XHandle, proposedDestRect__pointer, context__handle__, hints__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_CGRect_NativeHandle_NativeHandle (&__objc_super__, selCGImageForProposedRect_Context_Hints_XHandle, proposedDestRect__pointer, context__handle__, hints__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			GC.KeepAlive (hints);
			return ret!;
			}
		}
		[Export ("canInitWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanInitWithData (NSData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanInitWithData_XHandle, data__handle__);
			GC.KeepAlive (data);
			return ret != 0;
		}
		[Export ("canInitWithPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanInitWithPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanInitWithPasteboard_XHandle, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("draw")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Draw ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDrawXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDrawXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("drawAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawAtPoint (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, selDrawAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint (&__objc_super__, selDrawAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawInRect (CGRect rect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect (this.Handle, selDrawInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect (&__objc_super__, selDrawInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("drawInRect:fromRect:operation:fraction:respectFlipped:hints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawInRect (CGRect dstSpacePortionRect, CGRect srcSpacePortionRect, NSCompositingOperation op, nfloat requestedAlpha, bool respectContextIsFlipped, NSDictionary? hints)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var hints__handle__ = hints.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect_CGRect_UIntPtr_nfloat_bool_NativeHandle (this.Handle, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_XHandle, dstSpacePortionRect, srcSpacePortionRect, (UIntPtr) (ulong) op, requestedAlpha, respectContextIsFlipped ? (byte) 1 : (byte) 0, hints__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect_CGRect_UIntPtr_nfloat_bool_NativeHandle (&__objc_super__, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_XHandle, dstSpacePortionRect, srcSpacePortionRect, (UIntPtr) (ulong) op, requestedAlpha, respectContextIsFlipped ? (byte) 1 : (byte) 0, hints__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hints);
			return ret != 0;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("registeredImageRepClasses")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class[] GetRegisteredImageRepClasses ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			Class[] ret;
			ret = CFArray.ArrayFromHandle<Class>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRegisteredImageRepClassesXHandle), false)!;
			return ret;
		}
		[Export ("imageRepClassForData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class ImageRepClassForData (NSData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepClassForData_XHandle, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("imageRepClassForFileType:")]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class ImageRepClassForFileType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepClassForFileType_XHandle, nstype), false)!;
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("imageRepClassForPasteboardType:")]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class ImageRepClassForPasteboardType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepClassForPasteboardType_XHandle, nstype), false)!;
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("imageRepClassForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class ImageRepClassForType (string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepClassForType_XHandle, nstype), false)!;
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("imageRepWithContentsOfFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep ImageRepFromFile (string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			NSImageRep? ret;
			ret =  Runtime.GetNSObject<NSImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepWithContentsOfFile_XHandle, nsfilename), false)!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[Export ("imageRepWithPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep ImageRepFromPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			NSImageRep? ret;
			ret =  Runtime.GetNSObject<NSImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepWithPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		[Export ("imageRepWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep ImageRepFromUrl (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSImageRep? ret;
			ret =  Runtime.GetNSObject<NSImageRep> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepWithContentsOfURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("imageRepsWithContentsOfFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep[] ImageRepsFromFile (string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			NSImageRep[]? ret;
			ret = CFArray.ArrayFromHandle<NSImageRep>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepsWithContentsOfFile_XHandle, nsfilename), false)!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[Export ("imageRepsWithPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep[] ImageRepsFromPasteboard (NSPasteboard pasteboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			NSImageRep[]? ret;
			ret = CFArray.ArrayFromHandle<NSImageRep>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepsWithPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		[Export ("imageRepsWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSImageRep[] ImageRepsFromUrl (NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSImageRep[]? ret;
			ret = CFArray.ArrayFromHandle<NSImageRep>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selImageRepsWithContentsOfURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("registerImageRepClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterImageRepClass (Class imageRepClass)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var imageRepClass__handle__ = imageRepClass!.GetNonNullHandle (nameof (imageRepClass));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRegisterImageRepClass_XHandle, imageRepClass.Handle);
			GC.KeepAlive (imageRepClass);
		}
		/// <param name="alpha">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAlpha (bool alpha)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAlpha_XHandle, alpha ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAlpha_XHandle, alpha ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unregisterImageRepClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnregisterImageRepClass (Class imageRepClass)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var imageRepClass__handle__ = imageRepClass!.GetNonNullHandle (nameof (imageRepClass));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selUnregisterImageRepClass_XHandle, imageRepClass.Handle);
			GC.KeepAlive (imageRepClass);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BitsPerSample {
			[Export ("bitsPerSample")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBitsPerSampleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBitsPerSampleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBitsPerSample:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBitsPerSample_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBitsPerSample_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'Type' and 'NSColorType' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string ColorSpaceName {
			[Export ("colorSpaceName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorSpaceNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorSpaceNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorSpaceName:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColorSpaceName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColorSpaceName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAlpha {
			[Export ("hasAlpha")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAlphaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAlphaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static string[] ImageFileTypes {
			[Export ("imageFileTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImageFileTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static string[] ImagePasteboardTypes {
			[Export ("imagePasteboardTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImagePasteboardTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ImageTypes {
			[Export ("imageTypes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImageTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static string[] ImageUnfilteredFileTypes {
			[Export ("imageUnfilteredFileTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImageUnfilteredFileTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static string[] ImageUnfilteredPasteboardTypes {
			[Export ("imageUnfilteredPasteboardTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImageUnfilteredPasteboardTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ImageUnfilteredTypes {
			[Export ("imageUnfilteredTypes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selImageUnfilteredTypesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImageLayoutDirection LayoutDirection {
			[Export ("layoutDirection", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImageLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (NSImageLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLayoutDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSImageLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLayoutDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLayoutDirection:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLayoutDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetLayoutDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Opaque {
			[Export ("isOpaque")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOpaqueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOpaqueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setOpaque:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOpaque_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetOpaque_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PixelsHigh {
			[Export ("pixelsHigh")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPixelsHighXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPixelsHighXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPixelsHigh:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPixelsHigh_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPixelsHigh_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PixelsWide {
			[Export ("pixelsWide")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPixelsWideXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPixelsWideXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPixelsWide:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPixelsWide_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPixelsWide_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize Size {
			[Export ("size")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegistryDidChangeNotification;
		/// <summary>Notification constant for RegistryDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRegistryDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRegistryDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSImageRep.Notifications.ObserveRegistryDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSImageRep.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSImageRep.Notifications.ObserveRegistryDidChange (Callback);
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
		///     NSImageRep.RegistryDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification RegistryDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RegistryDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSImageRep.RegistryDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSImageRepRegistryDidChangeNotification",  "AppKit")]
		[Advice ("Use NSImageRep.Notifications.ObserveRegistryDidChange helper method instead.")]
		public static NSString RegistryDidChangeNotification {
			get {
				if (_RegistryDidChangeNotification is null)
					_RegistryDidChangeNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSImageRepRegistryDidChangeNotification")!;
				return _RegistryDidChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSImageRep" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSImageRep.RegistryDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSImageRep.RegistryDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSImageRep.Notifications.ObserveRegistryDidChange ((notification) => {
			///   Console.WriteLine ("Observed RegistryDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRegistryDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RegistryDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSImageRep.RegistryDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSImageRep.RegistryDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSImageRep.Notifications.ObserveRegistryDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RegistryDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRegistryDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RegistryDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSImageRep */
}
