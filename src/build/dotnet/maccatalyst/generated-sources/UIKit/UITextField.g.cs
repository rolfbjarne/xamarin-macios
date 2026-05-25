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
	[Register("UITextField", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITextField : UIControl, IUIContentSizeCategoryAdjusting, IUIKeyInput, IUILetterformAwareAdjusting, IUIPasteConfigurationSupporting, IUITextDraggable, IUITextDroppable, IUITextInput, IUITextInputTraits, IUITextPasteConfigurationSupporting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UITextField");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UITextField" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextField () : base (NSObjectFlag.Empty)
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
		public UITextField (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UITextField (NSObjectFlag t) : base (t)
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
		protected internal UITextField (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextField (CGRect frame)
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
		/// <param name="point">To be added.</param><summary>Begins displaying the floating cursor at the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[Export ("beginFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginFloatingCursor (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("borderRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect BorderRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("borderRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("borderRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("borderRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("borderRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="itemProviders">The ittem providers to check.</param><summary>Returns <see langword="true" /> if the responder can paste from the specified item providers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canPasteItemProviders:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual bool CanPaste (NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("clearButtonRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ClearButtonRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("clearButtonRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("clearButtonRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("clearButtonRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("clearButtonRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="first">First text position.</param><param name="second">Second text position.</param><summary>Gets a comparison of one position to another.</summary><returns>An indication as to whether two text positions are identical or if one is prior to the other.</returns><remarks>To be added.</remarks>
		[Export ("comparePosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult ComparePosition (UITextPosition first, UITextPosition second)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var first__handle__ = first!.GetNonNullHandle (nameof (first));
			var second__handle__ = second!.GetNonNullHandle (nameof (second));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (first);
			GC.KeepAlive (second);
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("deleteBackward")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteBackward ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deleteBackward"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("deleteBackward"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>The recognition of dictation failed.</summary><remarks>To be added.</remarks>
		[Export ("dictationRecognitionFailed")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecognitionFailed ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dictationRecognitionFailed"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dictationRecognitionFailed"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>The recording of dictation ended.</summary><remarks>To be added.</remarks>
		[Export ("dictationRecordingDidEnd")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecordingDidEnd ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dictationRecordingDidEnd"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dictationRecordingDidEnd"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didDismissWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissWritingTools ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didDismissWritingTools"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didDismissWritingTools"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawPlaceholderInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawPlaceholder (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("drawPlaceholderInRect:"), rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("drawPlaceholderInRect:"), rect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawTextInRect:")]
		[ObsoletedOSPlatform ("ios15.0", "No longer used.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "No longer used.")]
		[ObsoletedOSPlatform ("tvos15.0", "No longer used.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawText (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("drawTextInRect:"), rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("drawTextInRect:"), rect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("editingRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect EditingRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("editingRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("editingRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("editingRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("editingRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <summary>Ends display of the floating cursor.</summary><remarks>To be added.</remarks>
		[Export ("endFloatingCursor")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndFloatingCursor ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endFloatingCursor"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("endFloatingCursor"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("attributedTextInRange:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedText (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSAttributedString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="forPosition">A positioning object that indicates a specified location.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets the base writing direction for a text position.</summary><returns>A text-range object that represents the distance from position to the farthest extent in a given direction.</returns><remarks>To be added.</remarks>
		[Export ("baseWritingDirectionForPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWritingDirection GetBaseWritingDirection (UITextPosition forPosition, UITextStorageDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			NSWritingDirection ret;
			if (IsDirectBinding) {
				ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="position">A positioning object that indicates a specified location.</param><summary>A rectangle used for drawing a caret at a given insertion point.</summary><returns>A rectangle defining an area for drawing a caret.</returns><remarks>To be added.</remarks>
		[Export ("caretRectForPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCaretRectForPosition (UITextPosition? position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (position);
			return ret!;
		}
		[Export ("caretTransformForPosition:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetCaretTransform (UITextPosition forPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			CGAffineTransform ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="range">To be added.</param><summary>Calculates and returns the offset into <paramref name="range" /> of the character that is in <paramref name="position" /> in the document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterOffsetOfPosition:withinRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetCharacterOffsetOfPosition (UITextPosition position, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (position);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="byExtendingPosition">A text positioning object identifying a location in a document.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets a character range within the limits of a defined direction.</summary><returns>Gets a range from a given text position to the ultimate extent in a defined direction.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeByExtendingPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRange (UITextPosition byExtendingPosition, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var byExtendingPosition__handle__ = byExtendingPosition!.GetNonNullHandle (nameof (byExtendingPosition));
			UITextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (byExtendingPosition);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the character or a range of characters in a document that exists at a given point.</summary><returns>Gets the point in a view where the document text is being drawn.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeAtPoint:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRangeAtPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the closest position in a document that exists to a given point.</summary><returns>The closest position to the point. </returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">To be added.</param><param name="withinRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:withinRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point, UITextRange withinRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (withinRange);
			return ret!;
		}
		[Export ("editMenuForTextRange:suggestedActions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextRange textRange, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="range">	
		/// A UITextRange object indicating the range of a document's text.</param><summary>Gets the first rectangle enclosing a specified range of document text.</summary><returns>The first rectangle enclosing a specified range.</returns><remarks>To be added.</remarks>
		[Export ("firstRectForRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFirstRectForRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("firstRectForRange:"), range__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("firstRectForRange:"), range__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="placeholder">To be added.</param><summary>Returns the rectangle in which to display the animated dictation result placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("frameForDictationResultPlaceholder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForDictationResultPlaceholder (NSObject placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets the number of visible characters between two defined text positions.</summary><returns>The number of visible characters between the two specified text positions.</returns><remarks>To be added.</remarks>
		[Export ("offsetFromPosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromPosition (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from the initial position.</summary><returns>The specified character offset.</returns><remarks>To be added.</remarks>
		[Export ("positionFromPosition:offset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position</param><param name="inDirection">A constant indicating either backward or forward direction for storage.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from an initial position.</summary><returns>The specified character offset.</returns><remarks>This can be either a positive or negative value.</remarks>
		[Export ("positionFromPosition:inDirection:offset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, UITextLayoutDirection inDirection, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="withinRange">To be added.</param><param name="atCharacterOffset">To be added.</param><summary>Calculates and returns the absolute position in the document that is <paramref name="atCharacterOffset" /> characters into <paramref name="withinRange" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("positionWithinRange:atCharacterOffset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextRange withinRange, nint atCharacterOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><param name="direction">A constant indicating direction for storage.</param><summary>Gets a position within a specified range.</summary><returns>A position within a specified range.</returns><remarks>To be added.</remarks>
		[Export ("positionWithinRange:farthestInDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPositionWithinRange (UITextRange range, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets an array of selection rects that corresponds to a text range.</summary><returns>An array of selection rects.</returns><remarks>To be added.</remarks>
		[Export ("selectionRectsForRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextSelectionRect[] GetSelectionRects (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextSelectionRect[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets a specified text range.</summary><returns>Defined text range.</returns><remarks>To be added.</remarks>
		[Export ("textRangeFromPosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetTextRange (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			UITextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="atPosition">To be added.</param><param name="inDirection">To be added.</param><summary>Returns a dictionary of style properties for text at the <paramref name="atPosition" /> position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textStylingAtPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetTextStyling (UITextPosition atPosition, UITextStorageDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var atPosition__handle__ = atPosition!.GetNonNullHandle (nameof (atPosition));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (atPosition);
			return ret!;
		}
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, UITextRange replacementRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var replacementRange__handle__ = replacementRange!.GetNonNullHandle (nameof (replacementRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (replacementRange);
		}
		[Export ("insertAttributedText:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAttributedText (NSAttributedString text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertAttributedText:"), text__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertAttributedText:"), text__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (text);
		}
		/// <param name="dictationResult">To be added.</param><summary>Inserts a dictation result at the current position.</summary><remarks>To be added.</remarks>
		[Export ("insertDictationResult:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDictationResult (NSArray dictationResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dictationResult__handle__ = dictationResult!.GetNonNullHandle (nameof (dictationResult));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dictationResult);
		}
		/// <summary>Returns the placeholder object to use before dictation results are finished being generated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("insertDictationResultPlaceholder")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject InsertDictationResultPlaceholder ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertText:alternatives:style:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (string text, string[] alternatives, UITextAlternativeStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (alternatives is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternatives));
			var nstext = CFString.CreateNative (text);
			using var nsa_alternatives = NSArray.FromStrings (alternatives);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
		}
		/// <param name="text">To be added.</param><summary>Inserts text at the cursor.</summary><remarks>To be added.</remarks>
		[Export ("insertText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertText:"), nstext);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertText:"), nstext);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
		}
		[Export ("insertTextPlaceholderWithSize:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPlaceholder InsertTextPlaceholder (CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPlaceholder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("leftViewRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect LeftViewRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("leftViewRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("leftViewRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("leftViewRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("leftViewRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="itemProviders">The item providers for the items to paste.</param><summary>Performs the paste.</summary><remarks>To be added.</remarks>
		[Export ("pasteItemProviders:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void Paste (NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("placeholderRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect PlaceholderRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("placeholderRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("placeholderRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("placeholderRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("placeholderRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="placeholder">To be added.</param><param name="willInsertResult">To be added.</param><summary>The <paramref name="placeholder" /> is no longer needed.</summary><remarks>To be added.</remarks>
		[Export ("removeDictationResultPlaceholder:willInsertResult:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDictationResultPlaceholder (NSObject placeholder, bool willInsertResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (placeholder);
		}
		[Export ("removeTextPlaceholder:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextPlaceholder (UITextPlaceholder textPlaceholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPlaceholder__handle__ = textPlaceholder!.GetNonNullHandle (nameof (textPlaceholder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textPlaceholder);
		}
		[Export ("replaceRange:withAttributedText:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceRange (UITextRange range, NSAttributedString attributedText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var attributedText__handle__ = attributedText!.GetNonNullHandle (nameof (attributedText));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			GC.KeepAlive (attributedText);
		}
		/// <param name="range">The range of text to be replaced.</param><param name="text">A string defining text replacement within a "range".</param><summary>Replaces document text within a specified range.</summary><remarks>To be added.</remarks>
		[Export ("replaceRange:withText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceText (UITextRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			CFString.ReleaseNative (nstext);
		}
		[Export ("rightViewRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RightViewRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("rightViewRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("rightViewRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("rightViewRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("rightViewRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("setAttributedMarkedText:selectedRange:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributedMarkedText (NSAttributedString? markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var markedText__handle__ = markedText.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markedText);
		}
		/// <param name="writingDirection">Constant indicating layout direction.</param><param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Sets a base direction for writing in the specified range of text.</summary><remarks>To be added.</remarks>
		[Export ("setBaseWritingDirection:forRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBaseWritingDirectionforRange (NSWritingDirection writingDirection, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		/// <param name="markedText">Text that is to be marked.</param><param name="selectedRange">An NSRange object indicating the range of a document's text.</param><summary>Sets the marked text and marks it as the current selection.</summary><remarks>To be added.</remarks>
		[Export ("setMarkedText:selectedRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (string markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (markedText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markedText));
			var nsmarkedText = CFString.CreateNative (markedText);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmarkedText);
		}
		/// <param name="inRange">To be added.</param><param name="replacementText">To be added.</param><summary>Asks whether the text in <paramref name="inRange" /> should be replaced with <paramref name="replacementText" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldChangeTextInRange:replacementText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (UITextRange inRange, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var inRange__handle__ = inRange!.GetNonNullHandle (nameof (inRange));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inRange);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets all the text that is specified within a certain range.</summary><returns>Document substring falling within a certain specified range.</returns><remarks>To be added.</remarks>
		[Export ("textInRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TextInRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		[Export ("textRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect TextRect (CGRect forBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("textRectForBounds:"), forBounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("textRectForBounds:"), forBounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("textRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("textRectForBounds:"), forBounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <summary>Unmarks all currently marked text within a document</summary><remarks>Subsequent to this method being called, the value of "MarkedTextRange" is set to <see langword="null" />.</remarks>
		[Export ("unmarkText")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unmarkText"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unmarkText"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="point">To be added.</param><summary>Moves the floating curor to the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[Export ("updateFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFloatingCursor (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animator);
		}
		[Export ("willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animator);
		}
		[Export ("willPresentWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentWritingTools ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willPresentWritingTools"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("willPresentWritingTools"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AdjustsFontForContentSizeCategory {
			[Export ("adjustsFontForContentSizeCategory")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("adjustsFontForContentSizeCategory"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("adjustsFontForContentSizeCategory"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAdjustsFontForContentSizeCategory:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdjustsFontForContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAdjustsFontForContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AdjustsFontSizeToFitWidth {
			[Export ("adjustsFontSizeToFitWidth")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("adjustsFontSizeToFitWidth"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("adjustsFontSizeToFitWidth"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAdjustsFontSizeToFitWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdjustsFontSizeToFitWidth:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAdjustsFontSizeToFitWidth:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual UIWritingToolsResultOptions AllowedWritingToolsResultOptions {
			[Export ("allowedWritingToolsResultOptions", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWritingToolsResultOptions ret;
				if (IsDirectBinding) {
					ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowedWritingToolsResultOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAllowedWritingToolsResultOptions:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEditingTextAttributes {
			[Export ("allowsEditingTextAttributes")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsEditingTextAttributes"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsEditingTextAttributes"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEditingTextAttributes:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsEditingTextAttributes:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsEditingTextAttributes:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool AllowsNumberPadPopover {
			[Export ("allowsNumberPadPopover")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsNumberPadPopover"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsNumberPadPopover"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsNumberPadPopover:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? AttributedPlaceholder {
			[Export ("attributedPlaceholder", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributedPlaceholder")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributedPlaceholder")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedPlaceholder:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttributedPlaceholder:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAttributedPlaceholder:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? AttributedText {
			[Export ("attributedText", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributedText")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributedText")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedText:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttributedText:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAttributedText:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocapitalizationType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextAutocapitalizationType AutocapitalizationType {
			[Export ("autocapitalizationType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAutocapitalizationType ret;
				if (IsDirectBinding) {
					ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("autocapitalizationType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autocapitalizationType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutocapitalizationType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocorrectionType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextAutocorrectionType AutocorrectionType {
			[Export ("autocorrectionType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAutocorrectionType ret;
				if (IsDirectBinding) {
					ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("autocorrectionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autocorrectionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutocorrectionType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? Background {
			[Export ("background", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("background")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("background")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackground:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBackground:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setBackground:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the beginning of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextPosition BeginningOfDocument {
			[Export ("beginningOfDocument")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("beginningOfDocument")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("beginningOfDocument")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextBorderStyle BorderStyle {
			[Export ("borderStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextBorderStyle ret;
				if (IsDirectBinding) {
					ret = (UITextBorderStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("borderStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextBorderStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("borderStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBorderStyle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBorderStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setBorderStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextFieldViewMode ClearButtonMode {
			[Export ("clearButtonMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextFieldViewMode ret;
				if (IsDirectBinding) {
					ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clearButtonMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearButtonMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setClearButtonMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setClearButtonMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setClearButtonMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsOnBeginEditing {
			[Export ("clearsOnBeginEditing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsOnBeginEditing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsOnBeginEditing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsOnBeginEditing:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsOnBeginEditing:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsOnBeginEditing:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsOnInsertion {
			[Export ("clearsOnInsertion")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsOnInsertion"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsOnInsertion"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsOnInsertion:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsOnInsertion:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsOnInsertion:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the UIKit.IUITextFieldDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUITextFieldDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUITextFieldDelegate Delegate {
			get {
				return (WeakDelegate as IUITextFieldDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? DisabledBackground {
			[Export ("disabledBackground", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("disabledBackground")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("disabledBackground")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisabledBackground:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDisabledBackground:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDisabledBackground:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool Editable {
			[Export ("isEditable")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEditable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the return key is automatically enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool EnablesReturnKeyAutomatically {
			[Export ("enablesReturnKeyAutomatically")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enablesReturnKeyAutomatically"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enablesReturnKeyAutomatically"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnablesReturnKeyAutomatically:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the end of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextPosition EndOfDocument {
			[Export ("endOfDocument")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("endOfDocument")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("endOfDocument")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFont? Font {
			[Export ("font", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIFont? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("font")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("font")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFont:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFont:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setFont:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets a value that tells whether the key input has text in it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool HasText {
			[Export ("hasText")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasText"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasText"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextInlinePredictionType InlinePredictionType {
			[Export ("inlinePredictionType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextInlinePredictionType ret;
				if (IsDirectBinding) {
					ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inlinePredictionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inlinePredictionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInlinePredictionType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? InputAccessoryView {
			[Export ("inputAccessoryView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputAccessoryView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputAccessoryView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputAccessoryView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputAccessoryView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputAccessoryView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The input delegate object for this <see cref="T:UIKit.UITextField" />.</summary><value>The default value is a system-provided <see cref="T:UIKit.UITextInputDelegate" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IUITextInputDelegate InputDelegate {
			get {
				return (WeakInputDelegate as IUITextInputDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakInputDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? InputView {
			[Export ("inputView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject InteractionState {
			[Export ("interactionState", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interactionState")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interactionState")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractionState:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInteractionState:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInteractionState:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>A value that indicates if the user is editing the text in the view. Read-only.</summary><value></value><remarks><see langword="true" /> if the text is being edited, otherwise <see langword="false" />.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEditing {
			[Export ("isEditing")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditing"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEditing"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardAppearance" /> used by the <see cref="T:UIKit.IUITextInput" /></summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.UIKeyboardAppearance KeyboardAppearance {
			[Export ("keyboardAppearance")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIKeyboardAppearance ret;
				if (IsDirectBinding) {
					ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keyboardAppearance"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyboardAppearance"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyboardAppearance:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIKeyboardType KeyboardType {
			[Export ("keyboardType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIKeyboardType ret;
				if (IsDirectBinding) {
					ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keyboardType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyboardType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyboardType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? LeftView {
			[Export ("leftView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leftView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leftView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLeftView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLeftView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setLeftView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextFieldViewMode LeftViewMode {
			[Export ("leftViewMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextFieldViewMode ret;
				if (IsDirectBinding) {
					ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leftViewMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLeftViewMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setLeftViewMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The currently marked range of text in a given document.</summary><value>If there is no text marked, the value is <see langword="null" />; all else  is provisionally inserted requiring user confirmation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextRange MarkedTextRange {
			[Export ("markedTextRange")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("markedTextRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Attribute dictionary describing how text should be drawn.</summary><value>Strings indicating style definition.</value><remarks>This is marked to indicate the necessity for unique visual treatment in display.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSDictionary? MarkedTextStyle {
			[Export ("markedTextStyle", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextStyle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("markedTextStyle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMarkedTextStyle:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public virtual UITextMathExpressionCompletionType MathExpressionCompletionType {
			[Export ("mathExpressionCompletionType")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextMathExpressionCompletionType ret;
				if (IsDirectBinding) {
					ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mathExpressionCompletionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMathExpressionCompletionType:")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumFontSize {
			[Export ("minimumFontSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("minimumFontSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumFontSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumFontSize:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMinimumFontSize:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setMinimumFontSize:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The password entry rules.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextInputPasswordRules? PasswordRules {
			[Export ("passwordRules", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextInputPasswordRules? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("passwordRules")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("passwordRules")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPasswordRules:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasswordRules:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasswordRules:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UIPasteConfiguration" /> supported by <see langword="this" /> object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIPasteConfiguration? PasteConfiguration {
			[Export ("pasteConfiguration", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPasteConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pasteConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPasteConfiguration:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PasteDelegate_var;
		/// <summary>Gets the delegate for handling text pasting and text drops.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextPasteDelegate? PasteDelegate {
			[Export ("pasteDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextPasteDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pasteDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PasteDelegate_var = ret;
				return ret!;
			}
			[Export ("setPasteDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_PasteDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Placeholder {
			[Export ("placeholder", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("placeholder")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("placeholder")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPlaceholder:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlaceholder:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPlaceholder:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>The form of the return key for the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIReturnKeyType ReturnKeyType {
			[Export ("returnKeyType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIReturnKeyType ret;
				if (IsDirectBinding) {
					ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("returnKeyType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("returnKeyType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReturnKeyType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? RightView {
			[Export ("rightView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rightView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rightView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRightView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRightView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRightView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextFieldViewMode RightViewMode {
			[Export ("rightViewMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextFieldViewMode ret;
				if (IsDirectBinding) {
					ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextFieldViewMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rightViewMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRightViewMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setRightViewMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the entered text should be hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SecureTextEntry {
			[Export ("isSecureTextEntry")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSecureTextEntry"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSecureTextEntry"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSecureTextEntry:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The range of a document's selected text.</summary><value>If there is no current specified selection, then it is set to <see langword="null" />.</value><remarks>If the specified range has length, it specifies currently selected text; if zero length, it specifies only the caret at the insertion point.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedTextRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedTextRange:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>A value that controls whether the cursor is displayed at the start of the last line or end of the second-to-last line of a multiline selection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextStorageDirection SelectionAffinity {
			[Export ("selectionAffinity")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextStorageDirection ret;
				if (IsDirectBinding) {
					ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionAffinity"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectionAffinity"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionAffinity:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UILetterformAwareSizingRule SizingRule {
			[Export ("sizingRule", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILetterformAwareSizingRule ret;
				if (IsDirectBinding) {
					ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sizingRule"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sizingRule"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSizingRule:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart dashes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartDashesType SmartDashesType {
			[Export ("smartDashesType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartDashesType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartDashesType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartDashesType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartDashesType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart insert style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartInsertDeleteType SmartInsertDeleteType {
			[Export ("smartInsertDeleteType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartInsertDeleteType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartInsertDeleteType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartInsertDeleteType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartInsertDeleteType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart quotes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartQuotesType SmartQuotesType {
			[Export ("smartQuotesType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartQuotesType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartQuotesType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartQuotesType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartQuotesType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that tells whether spell-checking is on, off, or if spell-checking will be enabled only when auto-complete is enabled (default).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextSpellCheckingType SpellCheckingType {
			[Export ("spellCheckingType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSpellCheckingType ret;
				if (IsDirectBinding) {
					ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("spellCheckingType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("spellCheckingType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSpellCheckingType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSupportsAdaptiveImageGlyph:")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Text {
			[Export ("text", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("text")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("text")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setText:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setText:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setText:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextAlignment TextAlignment {
			[Export ("textAlignment")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAlignment ret;
				if (IsDirectBinding) {
					ret = UITextAlignmentExtensions.ToManaged ((nint) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment")));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = UITextAlignmentExtensions.ToManaged ((nint) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textAlignment")));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextAlignment:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextAlignment:"), (IntPtr) UITextAlignmentExtensions.ToNative (value));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTextAlignment:"), (IntPtr) UITextAlignmentExtensions.ToNative (value));
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? TextColor {
			[Export ("textColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextColor:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The semantic of the expected input, which allows the system to, for example, provide custom keyboards.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString TextContentType {
			[Export ("textContentType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textContentType")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textContentType")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextContentType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextContentType:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextContentType:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets a Boolean value that tells whether a drag session is active for the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool TextDragActive {
			[Export ("isTextDragActive")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextDragActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTextDragActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextDragDelegate_var;
		/// <summary>Gets or sets a delegate for managing drag source behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextDragDelegate? TextDragDelegate {
			[Export ("textDragDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextDragDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextDragDelegate_var = ret;
				return ret!;
			}
			[Export ("setTextDragDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextDragDelegate_var = value;
			}
		}
		/// <summary>Gets the drag interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIDragInteraction? TextDragInteraction {
			[Export ("textDragInteraction")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a value that controls how formatting is displayed in dragged text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextDragOptions TextDragOptions {
			[Export ("textDragOptions", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextDragOptions ret;
				if (IsDirectBinding) {
					ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textDragOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextDragOptions:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets a Boolean value that tells whether there is an active text drop session on the view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool TextDropActive {
			[Export ("isTextDropActive")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextDropActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTextDropActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextDropDelegate_var;
		/// <summary>Gets or sets a delegate for managing text drop behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextDropDelegate? TextDropDelegate {
			[Export ("textDropDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextDropDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextDropDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDropDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextDropDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDropDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextDropDelegate_var = ret;
				return ret!;
			}
			[Export ("setTextDropDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextDropDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextDropDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextDropDelegate_var = value;
			}
		}
		/// <summary>Gets the drop interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIDropInteraction? TextDropInteraction {
			[Export ("textDropInteraction")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDropInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIDropInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDropInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIDropInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDropInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the input view that provides the coordinate system for geometric operations within the text input.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIView TextInputView {
			[Export ("textInputView")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textInputView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textInputView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>This property provides information on the tokenizer that would be used to break up the text into units such as characters, words, lines, and paragraphs.</summary><value></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IUITextInputTokenizer Tokenizer {
			get {
				return (WeakTokenizer as IUITextInputTokenizer)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? TypingAttributes {
			[Export ("typingAttributes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typingAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("typingAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypingAttributes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public virtual CGRect UnobscuredContentRect {
			[Export ("unobscuredContentRect")]
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unobscuredContentRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("unobscuredContentRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? WeakDefaultTextAttributes {
			[Export ("defaultTextAttributes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("defaultTextAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("defaultTextAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultTextAttributes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDefaultTextAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDefaultTextAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
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
		object? __mt_WeakInputDelegate_var;
		/// <summary>Indicates a weak input delegate.</summary><value>Automatically assigned at runtime.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject? WeakInputDelegate {
			[Export ("inputDelegate", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakInputDelegate_var = ret;
				return ret!;
			}
			[Export ("setInputDelegate:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakInputDelegate_var = value;
			}
		}
		/// <summary>Indicates a weak tokenizer.</summary><value>Standard units of granularity including characters, words, lines, and paragraphs.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject WeakTokenizer {
			[Export ("tokenizer")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tokenizer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tokenizer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual UIWritingToolsBehavior WritingToolsBehavior {
			[Export ("writingToolsBehavior")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWritingToolsBehavior ret;
				if (IsDirectBinding) {
					ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("writingToolsBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("writingToolsBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setWritingToolsBehavior:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentInputModeDidChangeNotification;
		/// <summary>Notification constant for CurrentInputModeDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCurrentInputModeDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCurrentInputModeDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = UITextField.Notifications.ObserveCurrentInputModeDidChange ((sender, args) => {
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
		/// void Callback (object sender, UITextField.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextField.Notifications.ObserveCurrentInputModeDidChange (Callback);
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
		///     UITextField.CurrentInputModeDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification CurrentInputModeDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification CurrentInputModeDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextField.CurrentInputModeDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextInputCurrentInputModeDidChangeNotification",  "UIKit")]
		[Advice ("Use UITextField.Notifications.ObserveCurrentInputModeDidChange helper method instead.")]
		public static NSString CurrentInputModeDidChangeNotification {
			get {
				if (_CurrentInputModeDidChangeNotification is null)
					_CurrentInputModeDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputCurrentInputModeDidChangeNotification")!;
				return _CurrentInputModeDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidEndEditingReasonKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextFieldDidEndEditingReasonKey",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DidEndEditingReasonKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DidEndEditingReasonKey is null)
					_DidEndEditingReasonKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextFieldDidEndEditingReasonKey")!;
				return _DidEndEditingReasonKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextBackgroundColorKey;
		/// <summary>Developers should not use this deprecated property. Developers should use 'NSAttributedString.BackgroundColorAttributeName'.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextBackgroundColorKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextBackgroundColorKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextBackgroundColorKey is null)
					_TextBackgroundColorKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextBackgroundColorKey")!;
				return _TextBackgroundColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextColorKey;
		/// <summary>The property holds the key that should be used to retrieve the value of the text color from a <see cref="T:Foundation.NSDictionary" />.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextColorKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextColorKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextColorKey is null)
					_TextColorKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextColorKey")!;
				return _TextColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextDidBeginEditingNotification;
		/// <summary>Notification constant for TextDidBeginEditing</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextDidBeginEditing(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextDidBeginEditing(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = UITextField.Notifications.ObserveTextDidBeginEditing ((sender, args) => {
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
		/// void Callback (object sender, UITextField.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextField.Notifications.ObserveTextDidBeginEditing (Callback);
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
		///     UITextField.TextDidBeginEditingNotification, (notification) => { Console.WriteLine ("Received the notification TextDidBeginEditing", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextDidBeginEditing", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextField.TextDidBeginEditingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextFieldTextDidBeginEditingNotification",  "UIKit")]
		[Advice ("Use UITextField.Notifications.ObserveTextDidBeginEditing helper method instead.")]
		public static NSString TextDidBeginEditingNotification {
			get {
				if (_TextDidBeginEditingNotification is null)
					_TextDidBeginEditingNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextFieldTextDidBeginEditingNotification")!;
				return _TextDidBeginEditingNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextDidEndEditingNotification;
		/// <summary>Notification constant for TextDidEndEditing</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextDidEndEditing(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextDidEndEditing(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = UITextField.Notifications.ObserveTextDidEndEditing ((sender, args) => {
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
		/// void Callback (object sender, UITextField.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextField.Notifications.ObserveTextDidEndEditing (Callback);
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
		///     UITextField.TextDidEndEditingNotification, (notification) => { Console.WriteLine ("Received the notification TextDidEndEditing", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextDidEndEditing", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextField.TextDidEndEditingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextFieldTextDidEndEditingNotification",  "UIKit")]
		[Advice ("Use UITextField.Notifications.ObserveTextDidEndEditing helper method instead.")]
		public static NSString TextDidEndEditingNotification {
			get {
				if (_TextDidEndEditingNotification is null)
					_TextDidEndEditingNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextFieldTextDidEndEditingNotification")!;
				return _TextDidEndEditingNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextFieldTextDidChangeNotification;
		/// <summary>Notification constant for TextFieldTextDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextFieldTextDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextFieldTextDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = UITextField.Notifications.ObserveTextFieldTextDidChange ((sender, args) => {
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
		/// void Callback (object sender, UITextField.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextField.Notifications.ObserveTextFieldTextDidChange (Callback);
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
		///     UITextField.TextFieldTextDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification TextFieldTextDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextFieldTextDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextField.TextFieldTextDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextFieldTextDidChangeNotification",  "UIKit")]
		[Advice ("Use UITextField.Notifications.ObserveTextFieldTextDidChange helper method instead.")]
		public static NSString TextFieldTextDidChangeNotification {
			get {
				if (_TextFieldTextDidChangeNotification is null)
					_TextFieldTextDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextFieldTextDidChangeNotification")!;
				return _TextFieldTextDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextFontKey;
		/// <summary>The property holds the key that should be used to retrieve the value of the font for the text from a <see cref="T:Foundation.NSDictionary" />.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextFontKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.FontAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.FontAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextFontKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.FontAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.FontAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextFontKey is null)
					_TextFontKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextFontKey")!;
				return _TextFontKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PasteDelegate_var = null;
				__mt_TextDragDelegate_var = null;
				__mt_TextDropDelegate_var = null;
				__mt_WeakDelegate_var = null;
				__mt_WeakInputDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UITextField" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UITextField" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UITextField.Appearance" /> property or by calling <see cref="global::UIKit.UITextField.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UITextFieldAppearance : global::UIKit.UIControl.UIControlAppearance {
			protected internal UITextFieldAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UITextField" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextField" />, they should use the <see cref="global::UIKit.UITextField.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UITextFieldAppearance Appearance {
			get { return new UITextFieldAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextField.UITextFieldAppearance" /> for the subclass of <see cref="global::UIKit.UITextField" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextField" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextField.Appearance" /> property, or the <see cref="global::UIKit.UITextField.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UITextField.GetAppearance<MyUITextFieldSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance GetAppearance<T> () where T: UITextField {
			return new UITextFieldAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UITextField" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextField" />, they should use the <see cref="global::UIKit.UITextField.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UITextFieldAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextField.UITextFieldAppearance" /> for <see cref="global::UIKit.UITextField" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextField.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextField" />, they should use the <see cref="global::UIKit.UITextField.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance GetAppearance (UITraitCollection traits) {
			return new UITextFieldAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextField.UITextFieldAppearance" /> for <see cref="global::UIKit.UITextField" />.</summary>
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
		///var myTheme = UITextField.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextField" />, they should use the <see cref="global::UIKit.UITextField.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UITextFieldAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextField.UITextFieldAppearance" /> for the subclass of <see cref="global::UIKit.UITextField" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextField" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextField.Appearance" /> property, or the <see cref="global::UIKit.UITextField.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextField.GetAppearance<MyUITextFieldSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance GetAppearance<T> (UITraitCollection traits) where T: UITextField {
			return new UITextFieldAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextField.UITextFieldAppearance" /> for the subclass of <see cref="global::UIKit.UITextField" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextField" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextField.Appearance" /> property, or the <see cref="global::UIKit.UITextField.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextField.GetAppearance<MyUITextFieldSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextFieldAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UITextField{
			return new UITextFieldAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UITextField" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.CurrentInputModeDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.CurrentInputModeDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextField.Notifications.ObserveCurrentInputModeDidChange ((notification) => {
			///   Console.WriteLine ("Observed CurrentInputModeDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentInputModeDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentInputModeDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.CurrentInputModeDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.CurrentInputModeDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextField.Notifications.ObserveCurrentInputModeDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CurrentInputModeDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentInputModeDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentInputModeDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextDidBeginEditingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextDidBeginEditingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextField.Notifications.ObserveTextDidBeginEditing ((notification) => {
			///   Console.WriteLine ("Observed TextDidBeginEditingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidBeginEditing (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidBeginEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextDidBeginEditingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextDidBeginEditingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextField.Notifications.ObserveTextDidBeginEditing (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextDidBeginEditingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidBeginEditing (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidBeginEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextDidEndEditingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextDidEndEditingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextField.Notifications.ObserveTextDidEndEditing ((notification) => {
			///   Console.WriteLine ("Observed TextDidEndEditingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidEndEditing (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidEndEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextDidEndEditingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextDidEndEditingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextField.Notifications.ObserveTextDidEndEditing (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextDidEndEditingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidEndEditing (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidEndEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextFieldTextDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextFieldTextDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextField.Notifications.ObserveTextFieldTextDidChange ((notification) => {
			///   Console.WriteLine ("Observed TextFieldTextDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextFieldTextDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextFieldTextDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextField.TextFieldTextDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextField.TextFieldTextDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextField.Notifications.ObserveTextFieldTextDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextFieldTextDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextFieldTextDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextFieldTextDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UITextField */
}
