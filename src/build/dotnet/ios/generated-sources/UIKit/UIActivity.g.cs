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
	/// <summary>Abstract base class of activities to which the <see cref="T:UIKit.UIActivityViewController" /> can send data.</summary><remarks><para>The <see cref="T:UIKit.UIActivityViewController" /> can be used to send data to services such as social networks, email, SMS, etc. The operating system provides a number of these, such as <see cref="P:UIKit.UIActivityType.PostToFacebook" />, <see cref="P:UIKit.UIActivityType.Mail" />, and <see cref="P:UIKit.UIActivityType.Message" />. </para><para>You can create a new service by subclassing <see cref="T:UIKit.UIActivity" /> and, optionally, <see cref="T:UIKit.UIActivityItemProvider" />. This service will only be available to your own application; there is no way to make for non-Apple developers to make a <see cref="T:UIKit.UIActivity" /> that is available across apps.</para><para>
	/// 	When subclassing, you should override the 
	/// 	<see cref="P:UIKit.UIActivity.Image" />, 
	/// 	<see cref="P:UIKit.UIActivity.Title" />, 
	/// 	<see cref="P:UIKit.UIActivity.Type" />, 
	/// 	<see cref="M:UIKit.UIActivity.Prepare(Foundation.NSObject[])" /> and 
	/// 	<see cref="M:UIKit.UIActivity.CanPerform(Foundation.NSObject[])" />.
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //
	/// // Share an image 
	/// //
	/// var imageToShare = UIImage.FromFile ("demo.png");
	/// var activityItems = new NSObject[] { imageToShare };
	/// var controller = new UIActivityViewController (activityItems, null);
	/// this.PresentViewController(controller, true, null)
	/// 
	/// // 
	/// // Now share the image, but explicitly exclude posting as a message
	/// //
	/// controller = new UIActivityViewController (activityItems, null) {
	/// ExcludedActivityTypes = new NSString[] {
	/// UIActivityType.PostToWeibo,
	/// UIActivityType.Message
	/// }
	/// };
	/// this.PresentViewController(controller, true, null)
	/// 
	/// 	]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIActivity_Class/index.html">Apple documentation for <c>UIActivity</c></related>
	[Register("UIActivity", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIActivity : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIActivity");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIActivity" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIActivity () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected UIActivity (NSObjectFlag t) : base (t)
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
		protected internal UIActivity (NativeHandle handle) : base (handle)
		{
		}

		[Export ("canPerformWithActivityItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerform (NSObject[] activityItems)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (activityItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityItems));
			using var nsa_activityItems = NSArray.FromNSObjects (activityItems);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canPerformWithActivityItems:"), nsa_activityItems.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canPerformWithActivityItems:"), nsa_activityItems.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("activityDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (bool completed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("activityDidFinish:"), completed ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("activityDidFinish:"), completed ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("performActivity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Perform ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("performActivity"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("performActivity"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareWithActivityItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Prepare (NSObject[] activityItems)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (activityItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityItems));
			using var nsa_activityItems = NSArray.FromNSObjects (activityItems);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareWithActivityItems:"), nsa_activityItems.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareWithActivityItems:"), nsa_activityItems.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIActivityCategory Category {
			[Export ("activityCategory")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIActivityCategory ret;
				ret = (UIActivityCategory) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("activityCategory"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage Image {
			[Export ("activityImage")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activityImage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activityImage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("activityTitle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activityTitle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activityTitle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? Type {
			[Export ("activityType")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activityType")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activityType")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController ViewController {
			[Export ("activityViewController")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activityViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activityViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class UIActivity */
}
