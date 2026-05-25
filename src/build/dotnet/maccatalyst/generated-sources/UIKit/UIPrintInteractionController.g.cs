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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
namespace UIKit {
	/// <summary>Main driver for the printing process on iOS.</summary><remarks><para>
	/// 	The UIPrintInteractionController provides access to the
	/// 	printing framework on iOS.  To print on iOS, you configure the
	/// 	<see cref="P:UIKit.UIPrintInteractionController.SharedPrintController" /> 
	/// 	singleton by specifying your print task, optionally hook up to
	/// 	events and then you invoke the <see cref="M:UIKit.UIPrintInteractionController.Present(System.Boolean,UIKit.UIPrintInteractionCompletionHandler)" />
	/// 	method to allow the user to select a printer and to print.
	/// 
	/// </para><para> This class offers a number of mechanisms for printing, you
	/// can print using one of these configuration, based on your needs
	/// </para><list type="bullet"><item><term><para>Ready to print PDF file.  You can print it by
	/// 	  assigning to the <see cref="P:UIKit.UIPrintInteractionController.PrintingItem" />
	/// 	  property the NSUrl pointing to the file or the NSData that
	/// 	  contains the PDF in memory.</para></term></item><item><term><para>Ready to print image.  You can print it by assigning
	/// 	  to the <see cref="P:UIKit.UIPrintInteractionController.PrintingItem" />
	/// 	  property the UIImage or a photo ALAsset (the ALAsset with an
	/// 	  AssetType of ALAssetType.Photo).
	/// 	  </para></term></item><item><term><para>Ready to print collection of images and PDF files.  You can print it by assigning
	/// 	  the mix of elements to the  <see cref="P:UIKit.UIPrintInteractionController.PrintingItems" />
	/// 	  property an array of objects containing NSUrl, UIImage, NSData or ALAsset values.   
	/// 	  </para></term></item><item><term><para> To layout information using using one of the built-in
	/// 	    print formatters you would assign your print formatter to
	/// 	    the <see cref="P:UIKit.UIPrintInteractionController.PrintFormatter" />
	/// 	    property.  The built-in print formatters include the <see cref="T:UIKit.UISimpleTextPrintFormatter" />
	/// 	    which can be used for simple rending text across multiple
	/// 	    pages and has control for font, color, alignment and line
	/// 	    breaking modes; For more advanced text printing you can
	/// 	    use the <see cref="T:UIKit.UIMarkupTextPrintFormatter" />; For
	/// 	    printing UIViews, you use the <see cref="T:UIKit.UIViewPrintFormatter" /> which has
	/// 	    a bulit-in ability to print the contents of a UIWebView,
	/// 	    UITextView and MKMapView objects.
	/// 	  </para></term></item><item><term><para> For more advanced uses, where you might want to
	/// 	    control the actual rendering of the page, you must
	/// 	    implement a subclass of <see cref="T:UIKit.UIPrintPageRenderer" /> and assign
	/// 	    the instance of your renderer to the <see cref="P:UIKit.UIPrintInteractionController.PrintPageRenderer" />
	/// 	    property.</para></term></item></list><example><code lang="csharp lang-csharp"><![CDATA[
	/// 	//
	/// 	// Print a PDF file, simple API
	/// 	//
	/// NSUrl url = NSUrl.FromFilename ("SomeFile.pdf");           
	/// 	var printInfo = UIPrintInfo.PrintInfo;
	/// 
	/// printInfo.OutputType = UIPrintInfoOutputType.General;
	/// printInfo.JobName = "Test: PDF Print";
	/// 
	/// var printer = UIPrintInteractionController.SharedPrintController;
	/// 
	/// printer.PrintInfo = printInfo;
	/// printer.PrintingItem = url;
	/// printer.ShowsPageRange = true;
	/// 
	/// printer.Present (true, (handler, completed, err) =&gt; {
	/// if (!completed &amp; err != null){
	/// Console.WriteLine ("error");
	/// }
	/// });
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPrintInteractionController_Class/index.html">Apple documentation for <c>UIPrintInteractionController</c></related>
	[Register("UIPrintInteractionController", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPrintInteractionController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIPrintInteractionController");
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
		protected UIPrintInteractionController (NSObjectFlag t) : base (t)
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
		protected internal UIPrintInteractionController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("canPrintData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPrint (NSData data)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("canPrintData:"), data__handle__);
			GC.KeepAlive (data);
			return ret != 0;
		}
		[Export ("canPrintURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPrint (NSUrl url)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("canPrintURL:"), url__handle__);
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("dismissAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dismiss (bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("dismissAnimated:"), animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("dismissAnimated:"), animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("presentAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Present (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIPrintInteractionCompletionHandler))]UIPrintInteractionCompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completion = Trampolines.SDUIPrintInteractionCompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("presentAnimated:completionHandler:"), animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("presentAnimated:completionHandler:"), animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="animated"> to animate the sheet display,  to display immediately.</param>
		/// <summary>Presents an iPhone printing user interface.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Present operation.   The value of the TResult parameter is of type <c>Action&lt;UIKit.UIPrintInteractionResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentAsync (bool animated)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			Present(animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			});
			return tcs.Task;
		}
		/// <param name="animated">
		///           <see langword="true" /> to animate the sheet display, <see langword="false" /> to display immediately.</param>
		/// <param name="result">The result of the present operation.</param>
		/// <summary>Presents an iPhone printing user interface asynchronously.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous Present operation.   The value of the TResult parameter is of type <see cref="UIKit.UIPrintInteractionResult" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentAsync (bool animated, out bool result)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			result = Present(animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			})!;
			return tcs.Task;
		}
		[Export ("presentFromBarButtonItem:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PresentFromBarButtonItem (UIBarButtonItem item, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIPrintInteractionCompletionHandler))]UIPrintInteractionCompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			using var block_completion = Trampolines.SDUIPrintInteractionCompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("presentFromBarButtonItem:animated:completionHandler:"), item__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("presentFromBarButtonItem:animated:completionHandler:"), item__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="item">The bar button item that you need to tap for printing.</param>
		/// <param name="animated">Set  to animate the printing popover view from the specified item, or  to display immediately.</param>
		/// <summary>Presents an iPad printing user interface in a popover view that can be animated from a soecified bar-button item.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous PresentFromBarButtonItem operation.   The value of the TResult parameter is of type <c>Action&lt;UIKit.UIPrintInteractionResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentFromBarButtonItemAsync (UIBarButtonItem item, bool animated)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			PresentFromBarButtonItem(item, animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			});
			return tcs.Task;
		}
		/// <param name="item">The bar button item that the user has tapped for printing.</param>
		/// <param name="animated">
		///           <see langword="true" /> to animate the printing popover view from the specified item, <see langword="false" /> to display immediately.</param>
		/// <param name="result">The result of the present operation.</param>
		/// <summary>Asynchronously presents the iPad printing user interface in a popover view that can be animated from a bar-button item.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous PresentFromBarButtonItem operation.   The value of the TResult parameter is of type <c>Action&lt;UIKit.UIPrintInteractionResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentFromBarButtonItemAsync (UIBarButtonItem item, bool animated, out bool result)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			result = PresentFromBarButtonItem(item, animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			})!;
			return tcs.Task;
		}
		[Export ("presentFromRect:inView:animated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PresentFromRectInView (CGRect rect, UIView view, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIPrintInteractionCompletionHandler))]UIPrintInteractionCompletionHandler? completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			using var block_completion = Trampolines.SDUIPrintInteractionCompletionHandler.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("presentFromRect:inView:animated:completionHandler:"), rect, view__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("presentFromRect:inView:animated:completionHandler:"), rect, view__handle__, animated ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret != 0;
		}
		/// <param name="rect">A rectangle that defines an area from which a printing popover view is animated.</param>
		/// <param name="view">The view that provides the coordinate system for the specified rect.</param>
		/// <param name="animated"> to animate the printing popover view from the specified item,  to display immediately.</param>
		/// <summary>Presents an iPad printing user interface in a particular popover view that can be animated from any specified area in a view.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous PresentFromRectInView operation.   The value of the TResult parameter is of type UIKit.UIPrintInteractionResult.  The return values of the asynch methods , , and .</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentFromRectInViewAsync (CGRect rect, UIView view, bool animated)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			PresentFromRectInView(rect, view, animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			});
			return tcs.Task;
		}
		/// <param name="rect">A rectangle that defines an area from which a printing popover view is animated.</param>
		/// <param name="view">The view that provides the coordinate system for the specified rect.</param>
		/// <param name="animated">
		///           <see langword="true" /> to animate the printing popover view from the specified item, <see langword="false" /> to display immediately.</param>
		/// <param name="result">The result of the present operation.</param>
		/// <summary>Asynchronously presents the iPad printing user interface in a popover view that can be animated from any area in a view.</summary>
		/// <returns>When  printing options are already displayed, the printing-options popover view is hidden. You need to call the method again to display the options.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionResult> PresentFromRectInViewAsync (CGRect rect, UIView view, bool animated, out bool result)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionResult> ();
			result = PresentFromRectInView(rect, view, animated, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionResult (printInteractionController_!, completed_!));
			})!;
			return tcs.Task;
		}
		[Export ("printToPrinter:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PrintToPrinter (UIPrinter printer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIPrintInteractionCompletionHandler))]UIPrintInteractionCompletionHandler completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printer__handle__ = printer!.GetNonNullHandle (nameof (printer));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDUIPrintInteractionCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("printToPrinter:completionHandler:"), printer__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("printToPrinter:completionHandler:"), printer__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (printer);
			return ret != 0;
		}
		/// <param name="printer">Specified printer.</param>
		/// <summary>Prints directly to a specified printer.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous PrintToPrinter operation.   The value of the TResult parameter is of type <c>Action&lt;UIKit.UIPrintInteractionCompletionResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The PrintToPrinterAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionCompletionResult> PrintToPrinterAsync (UIPrinter printer)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionCompletionResult> ();
			PrintToPrinter(printer, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionCompletionResult (printInteractionController_!, completed_!));
			});
			return tcs.Task;
		}
		/// <param name="printer">Specified printer.</param>
		/// <param name="result">Whether the operation succeeded or failed.</param>
		/// <summary>Asynchronously prints directly to a specified printer, returning a task that provides the result.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<UIPrintInteractionCompletionResult> PrintToPrinterAsync (UIPrinter printer, out bool result)
		{
			var tcs = new TaskCompletionSource<UIPrintInteractionCompletionResult> ();
			result = PrintToPrinter(printer, (printInteractionController_, completed_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new UIPrintInteractionCompletionResult (printInteractionController_!, completed_!));
			})!;
			return tcs.Task;
		}
		/// <summary>An instance of the UIKit.IUIPrintInteractionControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUIPrintInteractionControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIPrintInteractionControllerDelegate Delegate {
			get {
				return (WeakDelegate as IUIPrintInteractionControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintFormatter PrintFormatter {
			[Export ("printFormatter", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPrintFormatter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPrintFormatter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printFormatter")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPrintFormatter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printFormatter")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintFormatter:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrintFormatter:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrintFormatter:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintInfo PrintInfo {
			[Export ("printInfo", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPrintInfo? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printInfo")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPrintInfo> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printInfo")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintInfo:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrintInfo:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrintInfo:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintPageRenderer PrintPageRenderer {
			[Export ("printPageRenderer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPrintPageRenderer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPrintPageRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printPageRenderer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPrintPageRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printPageRenderer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintPageRenderer:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrintPageRenderer:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrintPageRenderer:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintPaper PrintPaper {
			[Export ("printPaper")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPrintPaper? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPrintPaper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printPaper")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPrintPaper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printPaper")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet PrintableUTIs {
			[Export ("printableUTIs")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSSet? ret;
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("printableUTIs")), false)!;
				return ret!;
			}
		}
		/// <summary>Whether printing is available.</summary><value><see langword="true" />  if the device supports printing, otherwise <see langword="false" /> . The application can show or hide any print button based upon this value.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PrintingAvailable {
			[Export ("isPrintingAvailable")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isPrintingAvailable"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PrintingItem {
			[Export ("printingItem", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printingItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printingItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintingItem:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrintingItem:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrintingItem:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] PrintingItems {
			[Export ("printingItems", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("printingItems")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("printingItems")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrintingItems:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrintingItems:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrintingItems:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPrintInteractionController SharedPrintController {
			[Export ("sharedPrintController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPrintInteractionController? ret;
				ret =  Runtime.GetNSObject<UIPrintInteractionController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedPrintController")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsNumberOfCopies {
			[Export ("showsNumberOfCopies")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsNumberOfCopies"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsNumberOfCopies"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsNumberOfCopies:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsNumberOfCopies:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsNumberOfCopies:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Page range is now always shown.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Page range is now always shown.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsPageRange {
			[Export ("showsPageRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsPageRange"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsPageRange"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPageRange:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsPageRange:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsPageRange:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual bool ShowsPaperOrientation {
			[Export ("showsPaperOrientation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsPaperOrientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsPaperOrientation"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPaperOrientation:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsPaperOrientation:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsPaperOrientation:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual bool ShowsPaperSelectionForLoadedPapers {
			[Export ("showsPaperSelectionForLoadedPapers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsPaperSelectionForLoadedPapers"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsPaperSelectionForLoadedPapers"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPaperSelectionForLoadedPapers:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsPaperSelectionForLoadedPapers:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsPaperSelectionForLoadedPapers:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_UIPrintInteractionControllerDelegate); }
		}
		internal virtual _UIPrintInteractionControllerDelegate CreateInternalEventDelegateType ()
		{
			return (_UIPrintInteractionControllerDelegate)(new _UIPrintInteractionControllerDelegate());
		}
		internal _UIPrintInteractionControllerDelegate EnsureUIPrintInteractionControllerDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UIPrintInteractionControllerDelegate;
			if (del is null){
				del = (_UIPrintInteractionControllerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUIPrintInteractionControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UIPrintInteractionControllerDelegate : NSObject, IUIPrintInteractionControllerDelegate { 
			public _UIPrintInteractionControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIPrintInteractionControllerDelegate))]
			static _UIPrintInteractionControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal UIPrintInteractionCutterBehavior? chooseCutterBehavior;
			[Export ("printInteractionController:chooseCutterBehavior:")]
			public UIPrinterCutterBehavior ChooseCutterBehavior (UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors)
			{
				var handler = chooseCutterBehavior;
				if (handler is not null)
					return handler (printInteractionController, availableBehaviors);
				return UIPrinterCutterBehavior.NoCut!;
			}
			internal UIPrintInteractionPaperList? choosePaper;
			[Export ("printInteractionController:choosePaper:")]
			public UIPrintPaper ChoosePaper (UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList)
			{
				var handler = choosePaper;
				if (handler is not null)
					return handler (printInteractionController, paperList);
				return null!;
			}
			internal Func<UIPrintInteractionController,UIPrintPaper,nfloat>? cutLengthForPaper;
			[Export ("printInteractionController:cutLengthForPaper:")]
			public NFloat CutLengthForPaper (UIPrintInteractionController printInteractionController, UIPrintPaper paper)
			{
				var handler = cutLengthForPaper;
				if (handler is not null)
					return handler (printInteractionController, paper);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal EventHandler? didDismissPrinterOptions;
			[Export ("printInteractionControllerDidDismissPrinterOptions:")]
			public void DidDismissPrinterOptions (UIPrintInteractionController printInteractionController)
			{
				var handler = didDismissPrinterOptions;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			internal EventHandler? didFinishJob;
			[Export ("printInteractionControllerDidFinishJob:")]
			public void DidFinishJob (UIPrintInteractionController printInteractionController)
			{
				var handler = didFinishJob;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			internal EventHandler? didPresentPrinterOptions;
			[Export ("printInteractionControllerDidPresentPrinterOptions:")]
			public void DidPresentPrinterOptions (UIPrintInteractionController printInteractionController)
			{
				var handler = didPresentPrinterOptions;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			internal UIPrintInteraction? getViewController;
			[Export ("printInteractionControllerParentViewController:")]
			public UIViewController GetViewController (UIPrintInteractionController printInteractionController)
			{
				var handler = getViewController;
				if (handler is not null)
					return handler (printInteractionController);
				return null!;
			}
			internal EventHandler? willDismissPrinterOptions;
			[Export ("printInteractionControllerWillDismissPrinterOptions:")]
			public void WillDismissPrinterOptions (UIPrintInteractionController printInteractionController)
			{
				var handler = willDismissPrinterOptions;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			internal EventHandler? willPresentPrinterOptions;
			[Export ("printInteractionControllerWillPresentPrinterOptions:")]
			public void WillPresentPrinterOptions (UIPrintInteractionController printInteractionController)
			{
				var handler = willPresentPrinterOptions;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			internal EventHandler? willStartJob;
			[Export ("printInteractionControllerWillStartJob:")]
			public void WillStartJob (UIPrintInteractionController printInteractionController)
			{
				var handler = willStartJob;
				if (handler is not null){
					handler (printInteractionController, EventArgs.Empty);
				}
			}
			public override bool RespondsToSelector (Selector? sel)
			{
				if (sel is null)
					return false;
				NativeHandle selHandle = sel.Handle;
				if (selHandle.Equals (Selector.GetHandle ("printInteractionController:cutLengthForPaper:")))
					return cutLengthForPaper is not null;
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("respondsToSelector:"), selHandle) != 0;
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UIPrintInteractionCutterBehavior? ChooseCutterBehavior {
			get { return EnsureUIPrintInteractionControllerDelegate ()!.chooseCutterBehavior; }
			set { EnsureUIPrintInteractionControllerDelegate ()!.chooseCutterBehavior = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UIPrintInteractionPaperList? ChoosePaper {
			get { return EnsureUIPrintInteractionControllerDelegate ()!.choosePaper; }
			set { EnsureUIPrintInteractionControllerDelegate ()!.choosePaper = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public Func<UIPrintInteractionController,UIPrintPaper,nfloat>? CutLengthForPaper {
			get { return EnsureUIPrintInteractionControllerDelegate ()!.cutLengthForPaper; }
			set { EnsureUIPrintInteractionControllerDelegate ()!.cutLengthForPaper = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidDismissPrinterOptions {
			add { EnsureUIPrintInteractionControllerDelegate ()!.didDismissPrinterOptions += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.didDismissPrinterOptions -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidFinishJob {
			add { EnsureUIPrintInteractionControllerDelegate ()!.didFinishJob += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.didFinishJob -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidPresentPrinterOptions {
			add { EnsureUIPrintInteractionControllerDelegate ()!.didPresentPrinterOptions += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.didPresentPrinterOptions -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>An instance of the UIPrintInteractionController class or <see langword="null" /> if the object cannot be created.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UIPrintInteraction? GetViewController {
			get { return EnsureUIPrintInteractionControllerDelegate ()!.getViewController; }
			set { EnsureUIPrintInteractionControllerDelegate ()!.getViewController = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillDismissPrinterOptions {
			add { EnsureUIPrintInteractionControllerDelegate ()!.willDismissPrinterOptions += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.willDismissPrinterOptions -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillPresentPrinterOptions {
			add { EnsureUIPrintInteractionControllerDelegate ()!.willPresentPrinterOptions += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.willPresentPrinterOptions -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartJob {
			add { EnsureUIPrintInteractionControllerDelegate ()!.willStartJob += value; }
			remove { EnsureUIPrintInteractionControllerDelegate ()!.willStartJob -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class UIPrintInteractionController */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class UIPrintInteractionCompletionResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public UIPrintInteractionController PrintInteractionController { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool Completed { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="printInteractionController">Result value from an asynchronous operation.</param>
		/// <param name="completed">Result value from an asynchronous operation.</param>
		public UIPrintInteractionCompletionResult (UIPrintInteractionController printInteractionController, bool completed) {
			this.PrintInteractionController = printInteractionController;
			this.Completed = completed;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class UIPrintInteractionResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public UIPrintInteractionController PrintInteractionController { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool Completed { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="printInteractionController">Result value from an asynchronous operation.</param>
		/// <param name="completed">Result value from an asynchronous operation.</param>
		public UIPrintInteractionResult (UIPrintInteractionController printInteractionController, bool completed) {
			this.PrintInteractionController = printInteractionController;
			this.Completed = completed;
			Initialize ();
		}
	}
}
