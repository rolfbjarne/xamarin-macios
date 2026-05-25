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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[Register("UIScrollView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIScrollView : UIView, IUIFocusItemContainer, IUIFocusItemScrollableContainer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIScrollView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIScrollView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIScrollView () : base (NSObjectFlag.Empty)
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
		public UIScrollView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UIScrollView (NSObjectFlag t) : base (t)
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
		protected internal UIScrollView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIScrollView (CGRect frame)
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
		[Export ("adjustedContentInsetDidChange")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void AdjustedContentInsetDidChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adjustedContentInsetDidChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("adjustedContentInsetDidChange"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("flashScrollIndicators")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlashScrollIndicators ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("flashScrollIndicators"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("flashScrollIndicators"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="rect">The rectangle whose focus items to get.</param><summary>Returns a list of all the child focus items within the specified rectangle.</summary><returns>The list of all the child focus items within the specified rectangle.</returns><remarks>To be added.</remarks>
		[Export ("focusItemsInRect:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual IUIFocusItem[] GetFocusItems (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIFocusItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<IUIFocusItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("focusItemsInRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("scrollRectToVisible:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRectToVisible (CGRect rect, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("scrollRectToVisible:animated:"), rect, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_bool (&__objc_super__, Selector.GetHandle ("scrollRectToVisible:animated:"), rect, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setContentOffset:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentOffset (CGPoint contentOffset, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_bool (this.Handle, Selector.GetHandle ("setContentOffset:animated:"), contentOffset, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_bool (&__objc_super__, Selector.GetHandle ("setContentOffset:animated:"), contentOffset, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="scale">The amount to scale the .</param><param name="animated">To be added.</param><summary>Sets the scale of the <see cref="T:UIKit.UIScrollView" /> object's contents. (See <see cref="P:UIKit.UIScrollView.ZoomScale" />)</summary><remarks>To be added.</remarks>
		[Export ("setZoomScale:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetZoomScale (nfloat scale, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_bool (this.Handle, Selector.GetHandle ("setZoomScale:animated:"), scale, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_bool (&__objc_super__, Selector.GetHandle ("setZoomScale:animated:"), scale, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopScrollingAndZooming")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopScrollingAndZooming ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopScrollingAndZooming"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stopScrollingAndZooming"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("touchesShouldBegin:withEvent:inContentView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TouchesShouldBegin (NSSet touches, UIEvent withEvent, UIView inContentView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var touches__handle__ = touches!.GetNonNullHandle (nameof (touches));
			var withEvent__handle__ = withEvent!.GetNonNullHandle (nameof (withEvent));
			var inContentView__handle__ = inContentView!.GetNonNullHandle (nameof (inContentView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("touchesShouldBegin:withEvent:inContentView:"), touches__handle__, withEvent__handle__, inContentView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("touchesShouldBegin:withEvent:inContentView:"), touches__handle__, withEvent__handle__, inContentView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touches);
			GC.KeepAlive (withEvent);
			GC.KeepAlive (inContentView);
			return ret != 0;
		}
		[Export ("touchesShouldCancelInContentView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TouchesShouldCancelInContentView (UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("touchesShouldCancelInContentView:"), view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("touchesShouldCancelInContentView:"), view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret != 0;
		}
		[Export ("withScrollIndicatorsShownForContentOffsetChanges:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WithScrollIndicatorsShown ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action forContentOffsetChanges)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (forContentOffsetChanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forContentOffsetChanges));
			using var block_forContentOffsetChanges = Trampolines.SDAction.CreateBlock (forContentOffsetChanges);
			BlockLiteral *block_ptr_forContentOffsetChanges = &block_forContentOffsetChanges;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("withScrollIndicatorsShownForContentOffsetChanges:"), (IntPtr) block_ptr_forContentOffsetChanges);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("withScrollIndicatorsShownForContentOffsetChanges:"), (IntPtr) block_ptr_forContentOffsetChanges);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("zoomToRect:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomToRect (CGRect rect, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("zoomToRect:animated:"), rect, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_bool (&__objc_super__, Selector.GetHandle ("zoomToRect:animated:"), rect, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIEdgeInsets AdjustedContentInset {
			[Export ("adjustedContentInset")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("adjustedContentInset"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("adjustedContentInset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("adjustedContentInset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("adjustedContentInset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AlwaysBounceHorizontal {
			[Export ("alwaysBounceHorizontal")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("alwaysBounceHorizontal"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alwaysBounceHorizontal"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAlwaysBounceHorizontal:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAlwaysBounceHorizontal:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAlwaysBounceHorizontal:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AlwaysBounceVertical {
			[Export ("alwaysBounceVertical")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("alwaysBounceVertical"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alwaysBounceVertical"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAlwaysBounceVertical:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAlwaysBounceVertical:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAlwaysBounceVertical:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AutomaticallyAdjustsScrollIndicatorInsets {
			[Export ("automaticallyAdjustsScrollIndicatorInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyAdjustsScrollIndicatorInsets"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("automaticallyAdjustsScrollIndicatorInsets"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticallyAdjustsScrollIndicatorInsets:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutomaticallyAdjustsScrollIndicatorInsets:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutomaticallyAdjustsScrollIndicatorInsets:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIScrollEdgeEffect BottomEdgeEffect {
			[Export ("bottomEdgeEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollEdgeEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bottomEdgeEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bottomEdgeEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Bounces {
			[Export ("bounces")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bounces"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bounces"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBounces:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBounces:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setBounces:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool BouncesHorizontally {
			[Export ("bouncesHorizontally")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bouncesHorizontally"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bouncesHorizontally"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBouncesHorizontally:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBouncesHorizontally:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setBouncesHorizontally:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool BouncesVertically {
			[Export ("bouncesVertically")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bouncesVertically"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bouncesVertically"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBouncesVertically:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBouncesVertically:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setBouncesVertically:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BouncesZoom {
			[Export ("bouncesZoom")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bouncesZoom"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bouncesZoom"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBouncesZoom:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBouncesZoom:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setBouncesZoom:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanCancelContentTouches {
			[Export ("canCancelContentTouches")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canCancelContentTouches"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canCancelContentTouches"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanCancelContentTouches:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCanCancelContentTouches:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setCanCancelContentTouches:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual CGPoint ContentAlignmentPoint {
			[Export ("contentAlignmentPoint", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("contentAlignmentPoint"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentAlignmentPoint"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentAlignmentPoint:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setContentAlignmentPoint:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setContentAlignmentPoint:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets ContentInset {
			[Export ("contentInset")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("contentInset"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("contentInset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentInset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("contentInset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setContentInset:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setContentInset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setContentInset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIScrollViewContentInsetAdjustmentBehavior ContentInsetAdjustmentBehavior {
			[Export ("contentInsetAdjustmentBehavior", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollViewContentInsetAdjustmentBehavior ret;
				if (IsDirectBinding) {
					ret = (UIScrollViewContentInsetAdjustmentBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentInsetAdjustmentBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIScrollViewContentInsetAdjustmentBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentInsetAdjustmentBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentInsetAdjustmentBehavior:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentInsetAdjustmentBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setContentInsetAdjustmentBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide ContentLayoutGuide {
			[Export ("contentLayoutGuide", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentLayoutGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentLayoutGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ContentOffset {
			[Export ("contentOffset")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("contentOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentOffset:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setContentOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setContentOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ContentSize {
			[Export ("contentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("contentSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentSize:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setContentSize:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("setContentSize:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the coordinate space implementation.</summary><value>The coordinate space implementation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUICoordinateSpace CoordinateSpace {
			[Export ("coordinateSpace")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUICoordinateSpace? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("coordinateSpace")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUICoordinateSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("coordinateSpace")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>If this property returns <see langword="true" />, then scrolling is still occurring in the scroll view but the user is not dragging their finger.</summary><value></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Decelerating {
			[Export ("isDecelerating")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDecelerating"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isDecelerating"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat DecelerationRate {
			[Export ("decelerationRate")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("decelerationRate"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("decelerationRate"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDecelerationRate:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDecelerationRate:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setDecelerationRate:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DelaysContentTouches {
			[Export ("delaysContentTouches")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("delaysContentTouches"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delaysContentTouches"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDelaysContentTouches:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDelaysContentTouches:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setDelaysContentTouches:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the UIKit.IUIScrollViewDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUIScrollViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIScrollViewDelegate Delegate {
			get {
				return (WeakDelegate as IUIScrollViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>If <see langword="true" />, and the user begins scrolling in one axis (i.e. horizontally) then the scroll view disables scrolling in the other axis (i.e. vertically).</summary><value></value><remarks>If this property is <see langword="false" />, then scrolling is permitted both horizontally and vertically.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DirectionalLockEnabled {
			[Export ("isDirectionalLockEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDirectionalLockEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isDirectionalLockEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDirectionalLockEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDirectionalLockEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setDirectionalLockEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos11.0", "Configuring the 'PanGestureRecognizer' for indirect scrolling automatically supports directional presses now, so this property is no longer useful.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIGestureRecognizer DirectionalPressGestureRecognizer {
			[Export ("directionalPressGestureRecognizer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIGestureRecognizer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("directionalPressGestureRecognizer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("directionalPressGestureRecognizer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns <see langword="true" /> if the content has begun scrolling. Read-only.</summary><value></value><remarks>This property can not be depended upon to be updated immediately after the scrolling has started.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Dragging {
			[Export ("isDragging")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDragging"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isDragging"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UILayoutGuide FrameLayoutGuide {
			[Export ("frameLayoutGuide", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILayoutGuide? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("frameLayoutGuide")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UILayoutGuide> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("frameLayoutGuide")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIEdgeInsets HorizontalScrollIndicatorInsets {
			[Export ("horizontalScrollIndicatorInsets", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("horizontalScrollIndicatorInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("horizontalScrollIndicatorInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("horizontalScrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("horizontalScrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setHorizontalScrollIndicatorInsets:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setHorizontalScrollIndicatorInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setHorizontalScrollIndicatorInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIScrollViewIndexDisplayMode IndexDisplayMode {
			[Export ("indexDisplayMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollViewIndexDisplayMode ret;
				if (IsDirectBinding) {
					ret = (UIScrollViewIndexDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("indexDisplayMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIScrollViewIndexDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("indexDisplayMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setIndexDisplayMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIndexDisplayMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setIndexDisplayMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIScrollViewIndicatorStyle IndicatorStyle {
			[Export ("indicatorStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollViewIndicatorStyle ret;
				if (IsDirectBinding) {
					ret = (UIScrollViewIndicatorStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("indicatorStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIScrollViewIndicatorStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("indicatorStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setIndicatorStyle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIndicatorStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setIndicatorStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIScrollViewKeyboardDismissMode KeyboardDismissMode {
			[Export ("keyboardDismissMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollViewKeyboardDismissMode ret;
				if (IsDirectBinding) {
					ret = (UIScrollViewKeyboardDismissMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keyboardDismissMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIScrollViewKeyboardDismissMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyboardDismissMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyboardDismissMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyboardDismissMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setKeyboardDismissMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIScrollEdgeEffect LeftEdgeEffect {
			[Export ("leftEdgeEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollEdgeEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leftEdgeEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leftEdgeEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MaximumZoomScale {
			[Export ("maximumZoomScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumZoomScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("maximumZoomScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumZoomScale:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumZoomScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMaximumZoomScale:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumZoomScale {
			[Export ("minimumZoomScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumZoomScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumZoomScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumZoomScale:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumZoomScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumZoomScale:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPanGestureRecognizer PanGestureRecognizer {
			[Export ("panGestureRecognizer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPanGestureRecognizer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPanGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("panGestureRecognizer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPanGestureRecognizer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("panGestureRecognizer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIScrollEdgeEffect RightEdgeEffect {
			[Export ("rightEdgeEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollEdgeEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rightEdgeEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rightEdgeEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool ScrollAnimating {
			[Export ("isScrollAnimating")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollAnimating"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isScrollAnimating"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>If set to <see langword="true" /> then scrolling is enabled.</summary><value></value><remarks>If <see langword="false" />, then touch events will not be processed by the scroll view. They continue to be forwarded up the responder chain.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isScrollEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setScrollEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setScrollEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets ScrollIndicatorInsets {
			[Export ("scrollIndicatorInsets")]
			[ObsoletedOSPlatform ("ios13.0", "Use 'VerticalScrollIndicatorInsets' or 'HorizontalScrollIndicatorInsets' instead.")]
			[ObsoletedOSPlatform ("tvos13.0", "Use 'VerticalScrollIndicatorInsets' or 'HorizontalScrollIndicatorInsets' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'VerticalScrollIndicatorInsets' or 'HorizontalScrollIndicatorInsets' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("scrollIndicatorInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("scrollIndicatorInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("scrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("scrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setScrollIndicatorInsets:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setScrollIndicatorInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setScrollIndicatorInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsHorizontalScrollIndicator {
			[Export ("showsHorizontalScrollIndicator")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsHorizontalScrollIndicator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsHorizontalScrollIndicator"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsHorizontalScrollIndicator:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsHorizontalScrollIndicator:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsHorizontalScrollIndicator:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsVerticalScrollIndicator {
			[Export ("showsVerticalScrollIndicator")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsVerticalScrollIndicator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsVerticalScrollIndicator"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsVerticalScrollIndicator:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsVerticalScrollIndicator:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsVerticalScrollIndicator:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIScrollEdgeEffect TopEdgeEffect {
			[Export ("topEdgeEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIScrollEdgeEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topEdgeEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIScrollEdgeEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("topEdgeEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns <see langword="true" /> if the user has touched the content and scrolling is about to begin.</summary><value><see langword="true" /> while tracking is active, otherwise <see langword="false" />.
		/// </value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Tracking {
			[Export ("isTracking")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTracking"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTracking"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool TransfersHorizontalScrollingToParent {
			[Export ("transfersHorizontalScrollingToParent")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("transfersHorizontalScrollingToParent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transfersHorizontalScrollingToParent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTransfersHorizontalScrollingToParent:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTransfersHorizontalScrollingToParent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setTransfersHorizontalScrollingToParent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool TransfersVerticalScrollingToParent {
			[Export ("transfersVerticalScrollingToParent")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("transfersVerticalScrollingToParent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transfersVerticalScrollingToParent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTransfersVerticalScrollingToParent:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTransfersVerticalScrollingToParent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setTransfersVerticalScrollingToParent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIEdgeInsets VerticalScrollIndicatorInsets {
			[Export ("verticalScrollIndicatorInsets", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("verticalScrollIndicatorInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("verticalScrollIndicatorInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("verticalScrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("verticalScrollIndicatorInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setVerticalScrollIndicatorInsets:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setVerticalScrollIndicatorInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setVerticalScrollIndicatorInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the visible size of the scrollview container.</summary><value>The visible size of the scrollview container.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CGSize VisibleSize {
			[Export ("visibleSize")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("visibleSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("visibleSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public virtual bool ZoomAnimating {
			[Export ("isZoomAnimating")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomAnimating"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isZoomAnimating"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Returns <see langword="true" /> if the scroll view is bouncing back to the zoom scaling limits specified by<see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />. Read-only.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ZoomBouncing {
			[Export ("isZoomBouncing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomBouncing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isZoomBouncing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ZoomScale {
			[Export ("zoomScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("zoomScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("zoomScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZoomScale:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setZoomScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setZoomScale:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Returns <see langword="true" /> if the content view is zooming in or out. Read-only.</summary><value></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Zooming {
			[Export ("isZooming")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZooming"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isZooming"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Represents the value associated with the constant UIScrollViewDecelerationRateFast</summary><value></value><remarks></remarks>
		[Field ("UIScrollViewDecelerationRateFast",  "UIKit")]
		public static nfloat DecelerationRateFast {
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIScrollViewDecelerationRateFast");
			}
		}
		/// <summary>Represents the value associated with the constant UIScrollViewDecelerationRateNormal</summary><value></value><remarks></remarks>
		[Field ("UIScrollViewDecelerationRateNormal",  "UIKit")]
		public static nfloat DecelerationRateNormal {
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UIScrollViewDecelerationRateNormal");
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_UIScrollViewDelegate); }
		}
		internal virtual _UIScrollViewDelegate CreateInternalEventDelegateType ()
		{
			return (_UIScrollViewDelegate)(new _UIScrollViewDelegate());
		}
		internal _UIScrollViewDelegate EnsureUIScrollViewDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UIScrollViewDelegate;
			if (del is null){
				del = (_UIScrollViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUIScrollViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UIScrollViewDelegate : NSObject, IUIScrollViewDelegate { 
			public _UIScrollViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIScrollViewDelegate))]
			static _UIScrollViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? decelerationEnded;
			[Export ("scrollViewDidEndDecelerating:")]
			public void DecelerationEnded (UIScrollView scrollView)
			{
				var handler = decelerationEnded;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? decelerationStarted;
			[Export ("scrollViewWillBeginDecelerating:")]
			public void DecelerationStarted (UIScrollView scrollView)
			{
				var handler = decelerationStarted;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? didChangeAdjustedContentInset;
			[Export ("scrollViewDidChangeAdjustedContentInset:")]
			public void DidChangeAdjustedContentInset (UIScrollView scrollView)
			{
				var handler = didChangeAdjustedContentInset;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? didZoom;
			[Export ("scrollViewDidZoom:")]
			public void DidZoom (UIScrollView scrollView)
			{
				var handler = didZoom;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler<DraggingEventArgs>? draggingEnded;
			[Export ("scrollViewDidEndDragging:willDecelerate:")]
			public void DraggingEnded (UIScrollView scrollView, bool willDecelerate)
			{
				var handler = draggingEnded;
				if (handler is not null){
					var args = new DraggingEventArgs (willDecelerate);
					handler (scrollView, args);
				}
			}
			internal EventHandler? draggingStarted;
			[Export ("scrollViewWillBeginDragging:")]
			public void DraggingStarted (UIScrollView scrollView)
			{
				var handler = draggingStarted;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? scrollAnimationEnded;
			[Export ("scrollViewDidEndScrollingAnimation:")]
			public void ScrollAnimationEnded (UIScrollView scrollView)
			{
				var handler = scrollAnimationEnded;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? scrolled;
			[Export ("scrollViewDidScroll:")]
			public void Scrolled (UIScrollView scrollView)
			{
				var handler = scrolled;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal EventHandler? scrolledToTop;
			[Export ("scrollViewDidScrollToTop:")]
			public void ScrolledToTop (UIScrollView scrollView)
			{
				var handler = scrolledToTop;
				if (handler is not null){
					handler (scrollView, EventArgs.Empty);
				}
			}
			internal UIScrollViewCondition? shouldScrollToTop;
			[Export ("scrollViewShouldScrollToTop:")]
			public bool ShouldScrollToTop (UIScrollView scrollView)
			{
				var handler = shouldScrollToTop;
				if (handler is not null)
					return handler (scrollView);
				return true!;
			}
			internal UIScrollViewGetZoomView? viewForZoomingInScrollView;
			[Export ("viewForZoomingInScrollView:")]
			public UIView ViewForZoomingInScrollView (UIScrollView scrollView)
			{
				var handler = viewForZoomingInScrollView;
				if (handler is not null)
					return handler (scrollView);
				return null!;
			}
			internal EventHandler<WillEndDraggingEventArgs>? willEndDragging;
			[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
			public void WillEndDragging (UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
			{
				var handler = willEndDragging;
				if (handler is not null){
					var args = new WillEndDraggingEventArgs (velocity, targetContentOffset);
					handler (scrollView, args);
					targetContentOffset = args.TargetContentOffset;
				}
			}
			internal EventHandler<ZoomingEndedEventArgs>? zoomingEnded;
			[Export ("scrollViewDidEndZooming:withView:atScale:")]
			public void ZoomingEnded (UIScrollView scrollView, UIView withView, NFloat atScale)
			{
				var handler = zoomingEnded;
				if (handler is not null){
					var args = new ZoomingEndedEventArgs (withView, atScale);
					handler (scrollView, args);
				}
			}
			internal EventHandler<UIScrollViewZoomingEventArgs>? zoomingStarted;
			[Export ("scrollViewWillBeginZooming:withView:")]
			public void ZoomingStarted (UIScrollView scrollView, UIView view)
			{
				var handler = zoomingStarted;
				if (handler is not null){
					var args = new UIScrollViewZoomingEventArgs (view);
					handler (scrollView, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DraggingStarted" />
		/// <altmember cref="UIKit.UIScrollView.DraggingEnded" />
		/// <altmember cref="UIKit.UIScrollView.WillEndDragging" />
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationStarted" />
		public event EventHandler DecelerationEnded {
			add { EnsureUIScrollViewDelegate ()!.decelerationEnded += value; }
			remove { EnsureUIScrollViewDelegate ()!.decelerationEnded -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DraggingStarted" />
		/// <altmember cref="UIKit.UIScrollView.DraggingEnded" />
		/// <altmember cref="UIKit.UIScrollView.WillEndDragging" />
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationEnded" />
		public event EventHandler DecelerationStarted {
			add { EnsureUIScrollViewDelegate ()!.decelerationStarted += value; }
			remove { EnsureUIScrollViewDelegate ()!.decelerationStarted -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidChangeAdjustedContentInset {
			add { EnsureUIScrollViewDelegate ()!.didChangeAdjustedContentInset += value; }
			remove { EnsureUIScrollViewDelegate ()!.didChangeAdjustedContentInset -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.ZoomingEnded" />
		/// <altmember cref="UIKit.UIScrollView.ZoomingStarted" />
		public event EventHandler DidZoom {
			add { EnsureUIScrollViewDelegate ()!.didZoom += value; }
			remove { EnsureUIScrollViewDelegate ()!.didZoom -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DraggingStarted" />
		/// <altmember cref="UIKit.UIScrollView.WillEndDragging" />
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationStarted" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationEnded" />
		public event EventHandler<DraggingEventArgs> DraggingEnded {
			add { EnsureUIScrollViewDelegate ()!.draggingEnded += value; }
			remove { EnsureUIScrollViewDelegate ()!.draggingEnded -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DraggingEnded" />
		/// <altmember cref="UIKit.UIScrollView.WillEndDragging" />
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationStarted" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationEnded" />
		public event EventHandler DraggingStarted {
			add { EnsureUIScrollViewDelegate ()!.draggingStarted += value; }
			remove { EnsureUIScrollViewDelegate ()!.draggingStarted -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DidZoom" />
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		public event EventHandler ScrollAnimationEnded {
			add { EnsureUIScrollViewDelegate ()!.scrollAnimationEnded += value; }
			remove { EnsureUIScrollViewDelegate ()!.scrollAnimationEnded -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.DraggingStarted" />
		/// <altmember cref="UIKit.UIScrollView.DraggingEnded" />
		/// <altmember cref="UIKit.UIScrollView.WillEndDragging" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationStarted" />
		/// <altmember cref="UIKit.UIScrollView.DecelerationEnded" />
		public event EventHandler Scrolled {
			add { EnsureUIScrollViewDelegate ()!.scrolled += value; }
			remove { EnsureUIScrollViewDelegate ()!.scrolled -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.Scrolled" />
		public event EventHandler ScrolledToTop {
			add { EnsureUIScrollViewDelegate ()!.scrolledToTop += value; }
			remove { EnsureUIScrollViewDelegate ()!.scrolledToTop -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UIScrollViewCondition? ShouldScrollToTop {
			get { return EnsureUIScrollViewDelegate ()!.shouldScrollToTop; }
			set { EnsureUIScrollViewDelegate ()!.shouldScrollToTop = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>The default value is <see langword="null" /></value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollViewGetZoomView" />
		/// <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/FrogScroller">iOS Standard Controls</related>
		/// <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/ZoomingPdfViewer/">Zooming Pdf Viewer</related>
		public UIScrollViewGetZoomView? ViewForZoomingInScrollView {
			get { return EnsureUIScrollViewDelegate ()!.viewForZoomingInScrollView; }
			set { EnsureUIScrollViewDelegate ()!.viewForZoomingInScrollView = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.WillEndDraggingEventArgs" />
		/// <altmember cref="UIKit.UIScrollView.ContentOffset" />
		public event EventHandler<WillEndDraggingEventArgs> WillEndDragging {
			add { EnsureUIScrollViewDelegate ()!.willEndDragging += value; }
			remove { EnsureUIScrollViewDelegate ()!.willEndDragging -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.ZoomingStarted" />
		/// <altmember cref="CoreAnimation.CALayer.DrawInContext" />
		/// <altmember cref="UIKit.UIScrollView.DidZoom" />
		public event EventHandler<ZoomingEndedEventArgs> ZoomingEnded {
			add { EnsureUIScrollViewDelegate ()!.zoomingEnded += value; }
			remove { EnsureUIScrollViewDelegate ()!.zoomingEnded -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		/// <altmember cref="UIKit.UIScrollView.ZoomingEnded" />
		/// <altmember cref="UIKit.UIScrollView.DidZoom" />
		public event EventHandler<UIScrollViewZoomingEventArgs> ZoomingStarted {
			add { EnsureUIScrollViewDelegate ()!.zoomingStarted += value; }
			remove { EnsureUIScrollViewDelegate ()!.zoomingStarted -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UIScrollView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UIScrollView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UIScrollView.Appearance" /> property or by calling <see cref="global::UIKit.UIScrollView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UIScrollViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal UIScrollViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UIScrollView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIScrollView" />, they should use the <see cref="global::UIKit.UIScrollView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UIScrollViewAppearance Appearance {
			get { return new UIScrollViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIScrollView.UIScrollViewAppearance" /> for the subclass of <see cref="global::UIKit.UIScrollView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIScrollView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIScrollView.Appearance" /> property, or the <see cref="global::UIKit.UIScrollView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UIScrollView.GetAppearance<MyUIScrollViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance GetAppearance<T> () where T: UIScrollView {
			return new UIScrollViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UIScrollView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIScrollView" />, they should use the <see cref="global::UIKit.UIScrollView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UIScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIScrollView.UIScrollViewAppearance" /> for <see cref="global::UIKit.UIScrollView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIScrollView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIScrollView" />, they should use the <see cref="global::UIKit.UIScrollView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance GetAppearance (UITraitCollection traits) {
			return new UIScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIScrollView.UIScrollViewAppearance" /> for <see cref="global::UIKit.UIScrollView" />.</summary>
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
		///var myTheme = UIScrollView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIScrollView" />, they should use the <see cref="global::UIKit.UIScrollView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UIScrollViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIScrollView.UIScrollViewAppearance" /> for the subclass of <see cref="global::UIKit.UIScrollView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIScrollView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIScrollView.Appearance" /> property, or the <see cref="global::UIKit.UIScrollView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIScrollView.GetAppearance<MyUIScrollViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance GetAppearance<T> (UITraitCollection traits) where T: UIScrollView {
			return new UIScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIScrollView.UIScrollViewAppearance" /> for the subclass of <see cref="global::UIKit.UIScrollView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIScrollView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIScrollView.Appearance" /> property, or the <see cref="global::UIKit.UIScrollView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIScrollView.GetAppearance<MyUIScrollViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIScrollViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UIScrollView{
			return new UIScrollViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class UIScrollView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class DraggingEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="DraggingEventArgs" /> with the specified event data.</summary>
		/// <param name="willDecelerate">The value for the <see cref="Decelerate" /> property.</param>
		public DraggingEventArgs (bool willDecelerate)
		{
			this.Decelerate = willDecelerate;
		}
		public bool Decelerate { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UIScrollViewZoomingEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UIScrollViewZoomingEventArgs" /> with the specified event data.</summary>
		/// <param name="view">The value for the <see cref="View" /> property.</param>
		public UIScrollViewZoomingEventArgs (UIView view)
		{
			this.View = view;
		}
		public UIView View { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class WillEndDraggingEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="WillEndDraggingEventArgs" /> with the specified event data.</summary>
		/// <param name="velocity">The value for the <see cref="Velocity" /> property.</param>
		/// <param name="targetContentOffset">The value for the <see cref="TargetContentOffset" /> property.</param>
		public WillEndDraggingEventArgs (CGPoint velocity, CGPoint targetContentOffset)
		{
			this.TargetContentOffset = targetContentOffset;
			this.Velocity = velocity;
		}
		public CGPoint TargetContentOffset { get; set; }
		public CGPoint Velocity { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class ZoomingEndedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="ZoomingEndedEventArgs" /> with the specified event data.</summary>
		/// <param name="withView">The value for the <see cref="WithView" /> property.</param>
		/// <param name="atScale">The value for the <see cref="AtScale" /> property.</param>
		public ZoomingEndedEventArgs (UIView withView, NFloat atScale)
		{
			this.AtScale = atScale;
			this.WithView = withView;
		}
		public NFloat AtScale { get; set; }
		public UIView WithView { get; set; }
	}
}
