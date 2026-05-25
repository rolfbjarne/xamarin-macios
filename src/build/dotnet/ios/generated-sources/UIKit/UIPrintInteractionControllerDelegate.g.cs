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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>The delegate for the <see cref="T:UIKit.UIPrintInteractionController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPrintInteractionControllerDelegate_Protocol/index.html">Apple documentation for <c>UIPrintInteractionControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPrintInteractionControllerDelegate", WrapperType = typeof (UIPrintInteractionControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "printInteractionControllerParentViewController:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChoosePaper", Selector = "printInteractionController:choosePaper:", ReturnType = typeof (UIPrintPaper), ParameterType = new Type [] { typeof (UIPrintInteractionController), typeof (UIPrintPaper[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentPrinterOptions", Selector = "printInteractionControllerWillPresentPrinterOptions:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresentPrinterOptions", Selector = "printInteractionControllerDidPresentPrinterOptions:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissPrinterOptions", Selector = "printInteractionControllerWillDismissPrinterOptions:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissPrinterOptions", Selector = "printInteractionControllerDidDismissPrinterOptions:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartJob", Selector = "printInteractionControllerWillStartJob:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishJob", Selector = "printInteractionControllerDidFinishJob:", ParameterType = new Type [] { typeof (UIPrintInteractionController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CutLengthForPaper", Selector = "printInteractionController:cutLengthForPaper:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UIPrintInteractionController), typeof (UIPrintPaper) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChooseCutterBehavior", Selector = "printInteractionController:chooseCutterBehavior:", ReturnType = typeof (UIPrinterCutterBehavior), ParameterType = new Type [] { typeof (UIPrintInteractionController), typeof (NSNumber[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIPrintInteractionControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="printInteractionController">To be added.</param><summary>Returns the parent UIViewController for managing the printing-options view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewController (UIPrintInteractionController printInteractionController)
		{
			return _GetViewController (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Returns the parent UIViewController for managing the printing-options view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController _GetViewController (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerParentViewController:"), printInteractionController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><param name="paperList">To be added.</param><summary>Retrieves an object holding the paper size and printing area to use for a printing job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionController:choosePaper:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintPaper ChoosePaper (UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList)
		{
			return _ChoosePaper (this, printInteractionController, paperList);
		}
		/// <param name="printInteractionController">To be added.</param><param name="paperList">To be added.</param><summary>Retrieves an object holding the paper size and printing area to use for a printing job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPrintPaper _ChoosePaper (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			if (paperList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paperList));
			using var nsa_paperList = NSArray.FromNSObjects (paperList);
			UIPrintPaper? ret;
			ret =  Runtime.GetNSObject<UIPrintPaper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:choosePaper:"), printInteractionController__handle__, nsa_paperList.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options interface is about to be displayed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerWillPresentPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			_WillPresentPrinterOptions (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options interface is about to be displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentPrinterOptions (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillPresentPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface has been presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerDidPresentPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			_DidPresentPrinterOptions (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface has been presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPresentPrinterOptions (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidPresentPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface will be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerWillDismissPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			_WillDismissPrinterOptions (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface will be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissPrinterOptions (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillDismissPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printer user interface has been dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerDidDismissPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			_DidDismissPrinterOptions (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printer user interface has been dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissPrinterOptions (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidDismissPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job is about to begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerWillStartJob:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartJob (UIPrintInteractionController printInteractionController)
		{
			_WillStartJob (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartJob (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillStartJob:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job has ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionControllerDidFinishJob:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishJob (UIPrintInteractionController printInteractionController)
		{
			_DidFinishJob (this, printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishJob (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidFinishJob:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><param name="paper">To be added.</param><summary>The length to use when cutting the page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionController:cutLengthForPaper:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CutLengthForPaper (UIPrintInteractionController printInteractionController, UIPrintPaper paper)
		{
			return _CutLengthForPaper (this, printInteractionController, paper);
		}
		/// <param name="printInteractionController">To be added.</param><param name="paper">To be added.</param><summary>The length to use when cutting the page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _CutLengthForPaper (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, UIPrintPaper paper)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			var paper__handle__ = paper!.GetNonNullHandle (nameof (paper));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:cutLengthForPaper:"), printInteractionController__handle__, paper__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			GC.KeepAlive (paper);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><param name="availableBehaviors">To be added.</param><summary>Gets the <see cref="T:UIKit.UIPrinterCutterBehavior" /> for the print job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("printInteractionController:chooseCutterBehavior:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrinterCutterBehavior ChooseCutterBehavior (UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors)
		{
			return _ChooseCutterBehavior (this, printInteractionController, availableBehaviors);
		}
		/// <param name="printInteractionController">To be added.</param><param name="availableBehaviors">To be added.</param><summary>Gets the <see cref="T:UIKit.UIPrinterCutterBehavior" /> for the print job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPrinterCutterBehavior _ChooseCutterBehavior (IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			if (availableBehaviors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableBehaviors));
			using var nsa_availableBehaviors = NSArray.FromNSObjects (availableBehaviors);
			UIPrinterCutterBehavior ret;
			ret = (UIPrinterCutterBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:chooseCutterBehavior:"), printInteractionController__handle__, nsa_availableBehaviors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
		[DynamicDependencyAttribute ("ChooseCutterBehavior(UIKit.UIPrintInteractionController,Foundation.NSNumber[])")]
		[DynamicDependencyAttribute ("ChoosePaper(UIKit.UIPrintInteractionController,UIKit.UIPrintPaper[])")]
		[DynamicDependencyAttribute ("CutLengthForPaper(UIKit.UIPrintInteractionController,UIKit.UIPrintPaper)")]
		[DynamicDependencyAttribute ("DidDismissPrinterOptions(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("DidFinishJob(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("DidPresentPrinterOptions(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("GetViewController(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("WillDismissPrinterOptions(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("WillPresentPrinterOptions(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute ("WillStartJob(UIKit.UIPrintInteractionController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPrintInteractionControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPrintInteractionControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPrintInteractionControllerDelegate" /> interface to support all the methods from the UIPrintInteractionControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPrintInteractionControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPrintInteractionControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPrintInteractionControllerDelegate_Extensions {
		/// <param name="printInteractionController">To be added.</param><summary>Returns the parent UIViewController for managing the printing-options view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController GetViewController (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerParentViewController:"), printInteractionController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><param name="paperList">To be added.</param><summary>Retrieves an object holding the paper size and printing area to use for a printing job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPrintPaper ChoosePaper (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			if (paperList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paperList));
			using var nsa_paperList = NSArray.FromNSObjects (paperList);
			UIPrintPaper? ret;
			ret =  Runtime.GetNSObject<UIPrintPaper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:choosePaper:"), printInteractionController__handle__, nsa_paperList.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options interface is about to be displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentPrinterOptions (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillPresentPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface has been presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresentPrinterOptions (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidPresentPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface will be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissPrinterOptions (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillDismissPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printer user interface has been dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissPrinterOptions (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidDismissPrinterOptions:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartJob (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerWillStartJob:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job has ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishJob (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionControllerDidFinishJob:"), printInteractionController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
		}
		/// <param name="printInteractionController">To be added.</param><param name="paper">To be added.</param><summary>The length to use when cutting the page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat CutLengthForPaper (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, UIPrintPaper paper)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			var paper__handle__ = paper!.GetNonNullHandle (nameof (paper));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:cutLengthForPaper:"), printInteractionController__handle__, paper__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			GC.KeepAlive (paper);
			return ret!;
		}
		/// <param name="printInteractionController">To be added.</param><param name="availableBehaviors">To be added.</param><summary>Gets the <see cref="T:UIKit.UIPrinterCutterBehavior" /> for the print job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPrinterCutterBehavior ChooseCutterBehavior (this IUIPrintInteractionControllerDelegate This, UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var printInteractionController__handle__ = printInteractionController!.GetNonNullHandle (nameof (printInteractionController));
			if (availableBehaviors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableBehaviors));
			using var nsa_availableBehaviors = NSArray.FromNSObjects (availableBehaviors);
			UIPrinterCutterBehavior ret;
			ret = (UIPrinterCutterBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("printInteractionController:chooseCutterBehavior:"), printInteractionController__handle__, nsa_availableBehaviors.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (printInteractionController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPrintInteractionControllerDelegateWrapper : BaseWrapper, IUIPrintInteractionControllerDelegate {
		public UIPrintInteractionControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPrintInteractionControllerDelegateWrapper))]
		static UIPrintInteractionControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>The delegate for the <see cref="T:UIKit.UIPrintInteractionController" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPrintInteractionControllerDelegate_Protocol/index.html">Apple documentation for <c>UIPrintInteractionControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIPrintInteractionControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPrintInteractionControllerDelegate : NSObject, IUIPrintInteractionControllerDelegate {
		/// <summary>Creates a new <see cref="UIPrintInteractionControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPrintInteractionControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected UIPrintInteractionControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal UIPrintInteractionControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="printInteractionController">To be added.</param><param name="availableBehaviors">To be added.</param><summary>Gets the <see cref="T:UIKit.UIPrinterCutterBehavior" /> for the print job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printInteractionController:chooseCutterBehavior:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrinterCutterBehavior ChooseCutterBehavior (UIPrintInteractionController printInteractionController, NSNumber[] availableBehaviors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><param name="paperList">To be added.</param><summary>Retrieves an object holding the paper size and printing area to use for a printing job.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printInteractionController:choosePaper:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPrintPaper ChoosePaper (UIPrintInteractionController printInteractionController, UIPrintPaper[] paperList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><param name="paper">To be added.</param><summary>The length to use when cutting the page.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printInteractionController:cutLengthForPaper:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CutLengthForPaper (UIPrintInteractionController printInteractionController, UIPrintPaper paper)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printer user interface has been dismissed.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerDidDismissPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job has ended.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerDidFinishJob:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishJob (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface has been presented.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerDidPresentPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Returns the parent UIViewController for managing the printing-options view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("printInteractionControllerParentViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController GetViewController (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options user interface will be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerWillDismissPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the printing-options interface is about to be displayed.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerWillPresentPrinterOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentPrinterOptions (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="printInteractionController">To be added.</param><summary>Indicates that the print job is about to begin.</summary><remarks>To be added.</remarks>
		[Export ("printInteractionControllerWillStartJob:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartJob (UIPrintInteractionController printInteractionController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPrintInteractionControllerDelegate */
}
