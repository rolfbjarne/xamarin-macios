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
	/// <summary>A <see cref="T:UIKit.UIControl" /> that displays values that may be increased or decreased by pressing plus or minus buttons.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIStepper_Class/index.html">Apple documentation for <c>UIStepper</c></related>
	[Register("UIStepper", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIStepper : UIControl {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIStepper");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIStepper" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIStepper () : base (NSObjectFlag.Empty)
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
		public UIStepper (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected UIStepper (NSObjectFlag t) : base (t)
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
		protected internal UIStepper (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIStepper (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="state">To be added.</param><summary>The UIImage used as the backgroundimage for the UIStepper for the specified <paramref name="state" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backgroundImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage BackgroundImage (UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><summary>The image used for the stepper for the specified <paramref name="state" />..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("decrementImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetDecrementImage (UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("decrementImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("decrementImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="leftState">To be added.</param><param name="rightState">To be added.</param><summary>The UIImage used as the divider image for the specified pair of UIControlStates.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dividerImageForLeftSegmentState:rightSegmentState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetDividerImage (UIControlState leftState, UIControlState rightState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><summary>The UIImage used for the incrementer for the specified <paramref name="state" />..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("incrementImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetIncrementImage (UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("incrementImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("incrementImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the background image used for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
		[Export ("setBackgroundImage:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (UIImage? image, UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the decrement image for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
		[Export ("setDecrementImage:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDecrementImage (UIImage? image, UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setDecrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setDecrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="leftState">To be added.</param><param name="rightState">To be added.</param><summary>Sets the divider image used for the specified pair of UIControlStates.</summary><remarks>To be added.</remarks>
		[Export ("setDividerImage:forLeftSegmentState:rightSegmentState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDividerImage (UIImage? image, UIControlState leftState, UIControlState rightState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:"), image__handle__, (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:"), image__handle__, (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the increment image for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
		[Export ("setIncrementImage:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIncrementImage (UIImage? image, UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setIncrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setIncrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoRepeat {
			[Export ("autorepeat")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autorepeat"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autorepeat"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutorepeat:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutorepeat:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutorepeat:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The continuous vs. noncontinuous state of this UIStepper.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Continuous {
			[Export ("isContinuous")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isContinuous"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isContinuous"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setContinuous:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setContinuous:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setContinuous:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MaximumValue {
			[Export ("maximumValue")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("maximumValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumValue:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setMaximumValue:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setMaximumValue:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MinimumValue {
			[Export ("minimumValue")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("minimumValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumValue:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setMinimumValue:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setMinimumValue:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double StepValue {
			[Export ("stepValue")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("stepValue"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stepValue"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStepValue:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setStepValue:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setStepValue:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Value {
			[Export ("value")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("value"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setValue:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setValue:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setValue:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Wraps {
			[Export ("wraps")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wraps"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("wraps"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWraps:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWraps:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setWraps:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UIStepper" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UIStepper" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UIStepper.Appearance" /> property or by calling <see cref="global::UIKit.UIStepper.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UIStepperAppearance : global::UIKit.UIControl.UIControlAppearance {
			protected internal UIStepperAppearance (IntPtr handle) : base (handle) {}
			/// <param name="state">To be added.</param><summary>The UIImage used as the backgroundimage for the UIStepper for the specified <paramref name="state" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backgroundImageForState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage BackgroundImage (UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:"), (UIntPtr) (ulong) state), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:"), (UIntPtr) (ulong) state), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">To be added.</param><summary>The image used for the stepper for the specified <paramref name="state" />..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("decrementImageForState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetDecrementImage (UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("decrementImageForState:"), (UIntPtr) (ulong) state), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("decrementImageForState:"), (UIntPtr) (ulong) state), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="leftState">To be added.</param><param name="rightState">To be added.</param><summary>The UIImage used as the divider image for the specified pair of UIControlStates.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("dividerImageForLeftSegmentState:rightSegmentState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetDividerImage (UIControlState leftState, UIControlState rightState)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">To be added.</param><summary>The UIImage used for the incrementer for the specified <paramref name="state" />..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("incrementImageForState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetIncrementImage (UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("incrementImageForState:"), (UIntPtr) (ulong) state), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("incrementImageForState:"), (UIntPtr) (ulong) state), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the background image used for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
			[Export ("setBackgroundImage:forState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackgroundImage (UIImage? image, UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var image__handle__ = image.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (image);
			}
			/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the decrement image for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
			[Export ("setDecrementImage:forState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetDecrementImage (UIImage? image, UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var image__handle__ = image.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setDecrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setDecrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (image);
			}
			/// <param name="image">To be added.</param><param name="leftState">To be added.</param><param name="rightState">To be added.</param><summary>Sets the divider image used for the specified pair of UIControlStates.</summary><remarks>To be added.</remarks>
			[Export ("setDividerImage:forLeftSegmentState:rightSegmentState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetDividerImage (UIImage? image, UIControlState leftState, UIControlState rightState)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var image__handle__ = image.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:"), image__handle__, (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:"), image__handle__, (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (image);
			}
			/// <param name="image">To be added.</param><param name="state">To be added.</param><summary>Sets the increment image for the specified <paramref name="state" />..</summary><remarks>To be added.</remarks>
			[Export ("setIncrementImage:forState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetIncrementImage (UIImage? image, UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var image__handle__ = image.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setIncrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setIncrementImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (image);
			}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UIStepper" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIStepper" />, they should use the <see cref="global::UIKit.UIStepper.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UIStepperAppearance Appearance {
			get { return new UIStepperAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIStepper.UIStepperAppearance" /> for the subclass of <see cref="global::UIKit.UIStepper" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIStepper" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIStepper.Appearance" /> property, or the <see cref="global::UIKit.UIStepper.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UIStepper.GetAppearance<MyUIStepperSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance GetAppearance<T> () where T: UIStepper {
			return new UIStepperAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UIStepper" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIStepper" />, they should use the <see cref="global::UIKit.UIStepper.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UIStepperAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIStepper.UIStepperAppearance" /> for <see cref="global::UIKit.UIStepper" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIStepper.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIStepper" />, they should use the <see cref="global::UIKit.UIStepper.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance GetAppearance (UITraitCollection traits) {
			return new UIStepperAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIStepper.UIStepperAppearance" /> for <see cref="global::UIKit.UIStepper" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIStepper.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIStepper" />, they should use the <see cref="global::UIKit.UIStepper.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UIStepperAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIStepper.UIStepperAppearance" /> for the subclass of <see cref="global::UIKit.UIStepper" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIStepper" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIStepper.Appearance" /> property, or the <see cref="global::UIKit.UIStepper.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIStepper.GetAppearance<MyUIStepperSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance GetAppearance<T> (UITraitCollection traits) where T: UIStepper {
			return new UIStepperAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIStepper.UIStepperAppearance" /> for the subclass of <see cref="global::UIKit.UIStepper" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIStepper" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIStepper.Appearance" /> property, or the <see cref="global::UIKit.UIStepper.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIStepper.GetAppearance<MyUIStepperSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIStepperAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UIStepper{
			return new UIStepperAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class UIStepper */
}
