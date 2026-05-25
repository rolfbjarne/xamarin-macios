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
	[Register("NSPrintOperation", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPrintOperation : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEPSOperationWithView_InsideRect_ToData_X = "EPSOperationWithView:insideRect:toData:";
		static readonly NativeHandle selEPSOperationWithView_InsideRect_ToData_XHandle = Selector.GetHandle ("EPSOperationWithView:insideRect:toData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEPSOperationWithView_InsideRect_ToData_PrintInfo_X = "EPSOperationWithView:insideRect:toData:printInfo:";
		static readonly NativeHandle selEPSOperationWithView_InsideRect_ToData_PrintInfo_XHandle = Selector.GetHandle ("EPSOperationWithView:insideRect:toData:printInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEPSOperationWithView_InsideRect_ToPath_PrintInfo_X = "EPSOperationWithView:insideRect:toPath:printInfo:";
		static readonly NativeHandle selEPSOperationWithView_InsideRect_ToPath_PrintInfo_XHandle = Selector.GetHandle ("EPSOperationWithView:insideRect:toPath:printInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPDFOperationWithView_InsideRect_ToData_X = "PDFOperationWithView:insideRect:toData:";
		static readonly NativeHandle selPDFOperationWithView_InsideRect_ToData_XHandle = Selector.GetHandle ("PDFOperationWithView:insideRect:toData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPDFOperationWithView_InsideRect_ToData_PrintInfo_X = "PDFOperationWithView:insideRect:toData:printInfo:";
		static readonly NativeHandle selPDFOperationWithView_InsideRect_ToData_PrintInfo_XHandle = Selector.GetHandle ("PDFOperationWithView:insideRect:toData:printInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPDFOperationWithView_InsideRect_ToPath_PrintInfo_X = "PDFOperationWithView:insideRect:toPath:printInfo:";
		static readonly NativeHandle selPDFOperationWithView_InsideRect_ToPath_PrintInfo_XHandle = Selector.GetHandle ("PDFOperationWithView:insideRect:toPath:printInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanSpawnSeparateThreadX = "canSpawnSeparateThread";
		static readonly NativeHandle selCanSpawnSeparateThreadXHandle = Selector.GetHandle ("canSpawnSeparateThread");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCleanUpOperationX = "cleanUpOperation";
		static readonly NativeHandle selCleanUpOperationXHandle = Selector.GetHandle ("cleanUpOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateContextX = "createContext";
		static readonly NativeHandle selCreateContextXHandle = Selector.GetHandle ("createContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentOperationX = "currentOperation";
		static readonly NativeHandle selCurrentOperationXHandle = Selector.GetHandle ("currentOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPageX = "currentPage";
		static readonly NativeHandle selCurrentPageXHandle = Selector.GetHandle ("currentPage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeliverResultX = "deliverResult";
		static readonly NativeHandle selDeliverResultXHandle = Selector.GetHandle ("deliverResult");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestroyContextX = "destroyContext";
		static readonly NativeHandle selDestroyContextXHandle = Selector.GetHandle ("destroyContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCopyingOperationX = "isCopyingOperation";
		static readonly NativeHandle selIsCopyingOperationXHandle = Selector.GetHandle ("isCopyingOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJobTitleX = "jobTitle";
		static readonly NativeHandle selJobTitleXHandle = Selector.GetHandle ("jobTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageOrderX = "pageOrder";
		static readonly NativeHandle selPageOrderXHandle = Selector.GetHandle ("pageOrder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPageRangeX = "pageRange";
		static readonly NativeHandle selPageRangeXHandle = Selector.GetHandle ("pageRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredRenderingQualityX = "preferredRenderingQuality";
		static readonly NativeHandle selPreferredRenderingQualityXHandle = Selector.GetHandle ("preferredRenderingQuality");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintInfoX = "printInfo";
		static readonly NativeHandle selPrintInfoXHandle = Selector.GetHandle ("printInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintOperationWithView_X = "printOperationWithView:";
		static readonly NativeHandle selPrintOperationWithView_XHandle = Selector.GetHandle ("printOperationWithView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintOperationWithView_PrintInfo_X = "printOperationWithView:printInfo:";
		static readonly NativeHandle selPrintOperationWithView_PrintInfo_XHandle = Selector.GetHandle ("printOperationWithView:printInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintPanelX = "printPanel";
		static readonly NativeHandle selPrintPanelXHandle = Selector.GetHandle ("printPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunOperationX = "runOperation";
		static readonly NativeHandle selRunOperationXHandle = Selector.GetHandle ("runOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_X = "runOperationModalForWindow:delegate:didRunSelector:contextInfo:";
		static readonly NativeHandle selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_XHandle = Selector.GetHandle ("runOperationModalForWindow:delegate:didRunSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanSpawnSeparateThread_X = "setCanSpawnSeparateThread:";
		static readonly NativeHandle selSetCanSpawnSeparateThread_XHandle = Selector.GetHandle ("setCanSpawnSeparateThread:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentOperation_X = "setCurrentOperation:";
		static readonly NativeHandle selSetCurrentOperation_XHandle = Selector.GetHandle ("setCurrentOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJobTitle_X = "setJobTitle:";
		static readonly NativeHandle selSetJobTitle_XHandle = Selector.GetHandle ("setJobTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPageOrder_X = "setPageOrder:";
		static readonly NativeHandle selSetPageOrder_XHandle = Selector.GetHandle ("setPageOrder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrintInfo_X = "setPrintInfo:";
		static readonly NativeHandle selSetPrintInfo_XHandle = Selector.GetHandle ("setPrintInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrintPanel_X = "setPrintPanel:";
		static readonly NativeHandle selSetPrintPanel_XHandle = Selector.GetHandle ("setPrintPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsPrintPanel_X = "setShowsPrintPanel:";
		static readonly NativeHandle selSetShowsPrintPanel_XHandle = Selector.GetHandle ("setShowsPrintPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsProgressPanel_X = "setShowsProgressPanel:";
		static readonly NativeHandle selSetShowsProgressPanel_XHandle = Selector.GetHandle ("setShowsProgressPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsPrintPanelX = "showsPrintPanel";
		static readonly NativeHandle selShowsPrintPanelXHandle = Selector.GetHandle ("showsPrintPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsProgressPanelX = "showsProgressPanel";
		static readonly NativeHandle selShowsProgressPanelXHandle = Selector.GetHandle ("showsProgressPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewX = "view";
		static readonly NativeHandle selViewXHandle = Selector.GetHandle ("view");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPrintOperation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSPrintOperation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPrintOperation () : base (NSObjectFlag.Empty)
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
		protected NSPrintOperation (NSObjectFlag t) : base (t)
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
		protected internal NSPrintOperation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("cleanUpOperation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CleanUpOperation ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCleanUpOperationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCleanUpOperationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("createContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGraphicsContext CreateContext ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGraphicsContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreateContextXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreateContextXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("deliverResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeliverResult ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDeliverResultXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDeliverResultXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("destroyContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyContext ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDestroyContextXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDestroyContextXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("EPSOperationWithView:insideRect:toData:printInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation EpsFromView (NSView view, CGRect rect, NSMutableData data, NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (class_ptr, selEPSOperationWithView_InsideRect_ToData_PrintInfo_XHandle, view__handle__, rect, data__handle__, printInfo__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (data);
			GC.KeepAlive (printInfo);
			return ret!;
		}
		[Export ("EPSOperationWithView:insideRect:toPath:printInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation EpsFromView (NSView view, CGRect rect, string path, NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			var nspath = CFString.CreateNative (path);
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (class_ptr, selEPSOperationWithView_InsideRect_ToPath_PrintInfo_XHandle, view__handle__, rect, nspath, printInfo__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (printInfo);
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("EPSOperationWithView:insideRect:toData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation EpsFromView (NSView view, CGRect rect, NSMutableData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle (class_ptr, selEPSOperationWithView_InsideRect_ToData_XHandle, view__handle__, rect, data__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("printOperationWithView:printInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation FromView (NSView view, NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPrintOperationWithView_PrintInfo_XHandle, view__handle__, printInfo__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (printInfo);
			return ret!;
		}
		[Export ("printOperationWithView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation FromView (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selPrintOperationWithView_XHandle, view__handle__), false)!;
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("PDFOperationWithView:insideRect:toData:printInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation PdfFromView (NSView view, CGRect rect, NSMutableData data, NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (class_ptr, selPDFOperationWithView_InsideRect_ToData_PrintInfo_XHandle, view__handle__, rect, data__handle__, printInfo__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (data);
			GC.KeepAlive (printInfo);
			return ret!;
		}
		[Export ("PDFOperationWithView:insideRect:toPath:printInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation PdfFromView (NSView view, CGRect rect, string path, NSPrintInfo printInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var printInfo__handle__ = printInfo!.GetNonNullHandle (nameof (printInfo));
			var nspath = CFString.CreateNative (path);
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle_NativeHandle (class_ptr, selPDFOperationWithView_InsideRect_ToPath_PrintInfo_XHandle, view__handle__, rect, nspath, printInfo__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (printInfo);
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("PDFOperationWithView:insideRect:toData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation PdfFromView (NSView view, CGRect rect, NSMutableData data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSPrintOperation? ret;
			ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle (class_ptr, selPDFOperationWithView_InsideRect_ToData_XHandle, view__handle__, rect, data__handle__), false)!;
			GC.KeepAlive (view);
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("runOperation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RunOperation ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRunOperationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRunOperationXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("runOperationModalForWindow:delegate:didRunSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunOperationModal (NSWindow docWindow, NSObject del, Selector didRunSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var docWindow__handle__ = docWindow!.GetNonNullHandle (nameof (docWindow));
			var del__handle__ = del!.GetNonNullHandle (nameof (del));
			var didRunSelector__handle__ = didRunSelector!.GetNonNullHandle (nameof (didRunSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_XHandle, docWindow__handle__, del__handle__, didRunSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRunOperationModalForWindow_Delegate_DidRunSelector_ContextInfo_XHandle, docWindow__handle__, del__handle__, didRunSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (docWindow);
			GC.KeepAlive (del);
			GC.KeepAlive (didRunSelector);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanSpawnSeparateThread {
			[Export ("canSpawnSeparateThread")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanSpawnSeparateThreadXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanSpawnSeparateThreadXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanSpawnSeparateThread:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanSpawnSeparateThread_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanSpawnSeparateThread_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGraphicsContext Context {
			[Export ("context")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGraphicsContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPrintOperation CurrentOperation {
			[Export ("currentOperation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintOperation? ret;
				ret =  Runtime.GetNSObject<NSPrintOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentOperationXHandle), false)!;
				return ret!;
			}
			[Export ("setCurrentOperation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetCurrentOperation_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CurrentPage {
			[Export ("currentPage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentPageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCurrentPageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCopyingOperation {
			[Export ("isCopyingOperation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCopyingOperationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCopyingOperationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string JobTitle {
			[Export ("jobTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selJobTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selJobTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setJobTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetJobTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetJobTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintingPageOrder PageOrder {
			[Export ("pageOrder")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintingPageOrder ret;
				if (IsDirectBinding) {
					ret = (NSPrintingPageOrder) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPageOrderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPrintingPageOrder) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPageOrderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPageOrder:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPageOrder_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPageOrder_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange PageRange {
			[Export ("pageRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selPageRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selPageRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintRenderingQuality PreferredRenderingQuality {
			[Export ("preferredRenderingQuality")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintRenderingQuality ret;
				if (IsDirectBinding) {
					ret = (NSPrintRenderingQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreferredRenderingQualityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPrintRenderingQuality) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPreferredRenderingQualityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintInfo PrintInfo {
			[Export ("printInfo", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintInfo? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrintInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrintInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintInfo:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrintInfo_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrintInfo_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPrintPanel PrintPanel {
			[Export ("printPanel", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPrintPanel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPrintPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrintPanelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPrintPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrintPanelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintPanel:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrintPanel_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrintPanel_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsPrintPanel {
			[Export ("showsPrintPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsPrintPanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsPrintPanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPrintPanel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsPrintPanel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsPrintPanel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsProgressPanel {
			[Export ("showsProgressPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsProgressPanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsProgressPanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsProgressPanel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsProgressPanel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsProgressPanel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView View {
			[Export ("view")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSPrintOperation */
}
