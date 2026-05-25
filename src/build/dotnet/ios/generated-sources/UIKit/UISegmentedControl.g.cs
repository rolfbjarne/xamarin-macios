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
	[Register("UISegmentedControl", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UISegmentedControl : UIControl, IUISpringLoadedInteractionSupporting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UISegmentedControl");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UISegmentedControl" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISegmentedControl () : base (NSObjectFlag.Empty)
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
		public UISegmentedControl (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UISegmentedControl (NSObjectFlag t) : base (t)
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
		protected internal UISegmentedControl (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithItems:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISegmentedControl (NSArray items)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var items__handle__ = items!.GetNonNullHandle (nameof (items));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithItems:"), items__handle__), "initWithItems:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithItems:"), items__handle__), "initWithItems:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (items);
		}
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISegmentedControl (CGRect frame)
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
		[Export ("initWithFrame:actions:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISegmentedControl (CGRect frame, UIAction[] actions)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("initWithFrame:actions:"), frame, nsa_actions.Handle), "initWithFrame:actions:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithFrame:actions:"), frame, nsa_actions.Handle), "initWithFrame:actions:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="leftCenterRightOrAlone">To be added.</param><param name="barMetrics">To be added.</param><summary>The positioning offset for the specified UISegmentedControlSegment and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contentPositionAdjustmentForSegmentType:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIOffset ContentPositionAdjustment (UISegmentedControlSegment leftCenterRightOrAlone, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIOffset ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("contentPositionAdjustmentForSegmentType:barMetrics:"), (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("contentPositionAdjustmentForSegmentType:barMetrics:"), (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("actionForSegmentAtIndex:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIAction? GetAction (nuint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIAction ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("actionForSegmentAtIndex:"), segment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("actionForSegmentAtIndex:"), segment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image used for the specified UIControlState and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backgroundImageForState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetBackgroundImage (UIControlState state, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="segment">The index of the segment to retrieve the content offset for.</param><summary>The offset used for drawing content in a specified segment.</summary><returns>The content offset.</returns><remarks>The content offset is used for both text and image drawing within a segment.</remarks>
		[Export ("contentOffsetForSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetContentOffset (nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("contentOffsetForSegmentAtIndex:"), segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("contentOffsetForSegmentAtIndex:"), segment);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="leftState">To be added.</param><param name="rightState">To be added.</param><param name="barMetrics">To be added.</param><summary>The divider image for the specified UIControlStates and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? GetDividerImage (UIControlState leftState, UIControlState rightState, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState, (IntPtr) (long) barMetrics), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState, (IntPtr) (long) barMetrics), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("segmentIndexForActionIdentifier:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetSegmentIndex (string actionIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (actionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionIdentifier));
			var nsactionIdentifier = CFString.CreateNative (actionIdentifier);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("segmentIndexForActionIdentifier:"), nsactionIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("segmentIndexForActionIdentifier:"), nsactionIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsactionIdentifier);
			return ret!;
		}
		/// <param name="state">The state that you want to retrieve the rendering text attributes from.</param><summary>Returns the current rendering text attributes for the requested state.</summary><returns></returns><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UISegmentedControl.Appearance" /> property and the <see cref="UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIStringAttributes GetTitleTextAttributes (UIControlState state)
		{
			return new UIStringAttributes (GetWeakTitleTextAttributes (state));
		}
		[Export ("titleTextAttributesForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? GetWeakTitleTextAttributes (UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("titleTextAttributesForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("titleTextAttributesForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="segment">The segment to return the image for.</param><summary>Retrieves the image used in a particular segment</summary><returns>The image for the specified segment.</returns><remarks>The segment indices start at 0. If a segment index is specified beyond the upper range of segments in the control, the image of the segment at the upper range will be returned.</remarks>
		[Export ("imageForSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage ImageAt (nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("imageForSegmentAtIndex:"), segment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("imageForSegmentAtIndex:"), segment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertSegmentWithAction:atIndex:animated:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSegment (UIAction action, nuint segment, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, Selector.GetHandle ("insertSegmentWithAction:atIndex:animated:"), action__handle__, segment, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_bool (&__objc_super__, Selector.GetHandle ("insertSegmentWithAction:atIndex:animated:"), action__handle__, segment, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="title">To be added.</param><param name="pos">To be added.</param><param name="animated">To be added.</param><summary>Inserts a segment named <paramref name="title" /> at <paramref name="pos" />, optionally animating the insert.</summary><remarks>To be added.</remarks>
		[Export ("insertSegmentWithTitle:atIndex:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSegment (string title, nint pos, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_bool (this.Handle, Selector.GetHandle ("insertSegmentWithTitle:atIndex:animated:"), nstitle, pos, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_bool (&__objc_super__, Selector.GetHandle ("insertSegmentWithTitle:atIndex:animated:"), nstitle, pos, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		/// <param name="image">To be added.</param><param name="pos">To be added.</param><param name="animated">To be added.</param><summary>Inserts a segment with <paramref name="image" /> as its content at <paramref name="pos" />, optionally animating the insert.</summary><remarks>To be added.</remarks>
		[Export ("insertSegmentWithImage:atIndex:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSegment (UIImage image, nint pos, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_bool (this.Handle, Selector.GetHandle ("insertSegmentWithImage:atIndex:animated:"), image__handle__, pos, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_bool (&__objc_super__, Selector.GetHandle ("insertSegmentWithImage:atIndex:animated:"), image__handle__, pos, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="segment">The index of the segment.</param><summary>Returns if a particular segment is enabled.</summary><returns>Returns true if the segment is enabled.</returns><remarks>Segments are enabled by default.</remarks>
		[Export ("isEnabledForSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEnabled (nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEnabledForSegmentAtIndex:"), segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("isEnabledForSegmentAtIndex:"), segment);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("removeAllSegments")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllSegments ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllSegments"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllSegments"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="segment">To be added.</param><param name="animated">To be added.</param><summary>Removes the segment at the index <paramref name="segment" />.</summary><remarks>To be added.</remarks>
		[Export ("removeSegmentAtIndex:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSegmentAtIndex (nint segment, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("removeSegmentAtIndex:animated:"), segment, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (&__objc_super__, Selector.GetHandle ("removeSegmentAtIndex:animated:"), segment, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="segment">The index of the segment.</param><summary>Returns the with of a particular segment.</summary><returns>The segment width.</returns><remarks>If the value is 0.0, the segmented control will automatically sizes the segment.</remarks>
		[Export ("widthForSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SegmentWidth (nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("widthForSegmentAtIndex:"), segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("widthForSegmentAtIndex:"), segment);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setAction:forSegmentAtIndex:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAction (UIAction action, nuint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setAction:forSegmentAtIndex:"), action__handle__, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setAction:forSegmentAtIndex:"), action__handle__, segment);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the background image used for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setBackgroundImage:forState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var backgroundImage__handle__ = backgroundImage.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (backgroundImage);
		}
		/// <param name="offset">The content offset.</param><param name="segment">The segment index.</param><summary>Sets the content offset for a specified segment.</summary><remarks>The content offset is used when drawing both text and images in the segment.</remarks>
		[Export ("setContentOffset:forSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentOffset (CGSize offset, nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_IntPtr (this.Handle, Selector.GetHandle ("setContentOffset:forSegmentAtIndex:"), offset, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize_IntPtr (&__objc_super__, Selector.GetHandle ("setContentOffset:forSegmentAtIndex:"), offset, segment);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="adjustment">To be added.</param><param name="leftCenterRightOrAlone">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the position adjustment for the specified UISegmentedControlSegment and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setContentPositionAdjustment:forSegmentType:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentPositionAdjustment (UIOffset adjustment, UISegmentedControlSegment leftCenterRightOrAlone, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setContentPositionAdjustment:forSegmentType:barMetrics:"), adjustment, (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setContentPositionAdjustment:forSegmentType:barMetrics:"), adjustment, (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="dividerImage">To be added.</param><param name="leftSegmentState">To be added.</param><param name="rightSegmentState">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the divider image used for the specified UIControlStates and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDividerImage (UIImage? dividerImage, UIControlState leftSegmentState, UIControlState rightSegmentState, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dividerImage__handle__ = dividerImage.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:"), dividerImage__handle__, (UIntPtr) (ulong) leftSegmentState, (UIntPtr) (ulong) rightSegmentState, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:"), dividerImage__handle__, (UIntPtr) (ulong) leftSegmentState, (UIntPtr) (ulong) rightSegmentState, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dividerImage);
		}
		/// <param name="enabled">Boolean indicating if a segment is should be enabled.</param><param name="segment">The index of the segment.</param><summary>Enables or disables a given segment.</summary><remarks>To be added.</remarks>
		[Export ("setEnabled:forSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEnabled (bool enabled, nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("setEnabled:forSegmentAtIndex:"), enabled ? (byte) 1 : (byte) 0, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (&__objc_super__, Selector.GetHandle ("setEnabled:forSegmentAtIndex:"), enabled ? (byte) 1 : (byte) 0, segment);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="image">The image to set.</param><param name="segment">The segment index.</param><summary>Set an image for a particular segment.</summary><remarks>To be added.</remarks>
		[Export ("setImage:forSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImage (UIImage image, nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setImage:forSegmentAtIndex:"), image__handle__, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setImage:forSegmentAtIndex:"), image__handle__, segment);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="title">The title to set.</param><param name="segment">The segment index.</param><summary>Set a title for a particular segment.</summary><remarks>To be added.</remarks>
		[Export ("setTitle:forSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitle (string title, nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setTitle:forSegmentAtIndex:"), nstitle, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setTitle:forSegmentAtIndex:"), nstitle, segment);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstitle);
		}
		/// <param name="attributes">rendering attributes for the text.</param><param name="state">The state to alter</param><summary>Sets the rendering text attributes for a specific state in the control.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UISegmentedControl.Appearance" /> property and the <see cref="UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTitleTextAttributes (UIStringAttributes? attributes, UIControlState state)
		{
			SetTitleTextAttributes (attributes?.GetDictionary (), state);
		}
		[Export ("setTitleTextAttributes:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitleTextAttributes (NSDictionary? attributes, UIControlState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTitleTextAttributes:forState:"), attributes__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setTitleTextAttributes:forState:"), attributes__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
		}
		/// <param name="width">The segment width to set..</param><param name="segment">The segment index..</param><summary>Sets the width for a particular segment.</summary><remarks>The default value of 0.0 will cause the segment to be automatically sized.</remarks>
		[Export ("setWidth:forSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWidth (nfloat width, nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, Selector.GetHandle ("setWidth:forSegmentAtIndex:"), width, segment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, Selector.GetHandle ("setWidth:forSegmentAtIndex:"), width, segment);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="segment">The segment index to return the title for.</param><summary>Allows the title for a particular segment to be retrieved.</summary><returns>The title for a given segment</returns><remarks>Returns null if a title has not been set.</remarks>
		[Export ("titleForSegmentAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleAt (nint segment)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("titleForSegmentAtIndex:"), segment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("titleForSegmentAtIndex:"), segment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApportionsSegmentWidthsByContent {
			[Export ("apportionsSegmentWidthsByContent")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("apportionsSegmentWidthsByContent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("apportionsSegmentWidthsByContent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setApportionsSegmentWidthsByContent:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setApportionsSegmentWidthsByContent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setApportionsSegmentWidthsByContent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "The 'SegmentedControlStyle' property no longer has any effect.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "The 'SegmentedControlStyle' property no longer has any effect.")]
		[SupportedOSPlatform ("ios")]
		public virtual UISegmentedControlStyle ControlStyle {
			[Export ("segmentedControlStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISegmentedControlStyle ret;
				if (IsDirectBinding) {
					ret = (UISegmentedControlStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("segmentedControlStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISegmentedControlStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("segmentedControlStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSegmentedControlStyle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSegmentedControlStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSegmentedControlStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Determines if segments show the selected state.</summary><value></value><remarks>Default is false, which means the segments will show their selected state.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Momentary {
			[Export ("isMomentary")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMomentary"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMomentary"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMomentary:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMomentary:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setMomentary:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSegments {
			[Export ("numberOfSegments")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfSegments"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfSegments"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedSegment {
			[Export ("selectedSegmentIndex")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedSegmentIndex"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedSegmentIndex"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedSegmentIndex:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedSegmentIndex:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectedSegmentIndex:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIColor? SelectedSegmentTintColor {
			[Export ("selectedSegmentTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedSegmentTintColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedSegmentTintColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedSegmentTintColor:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedSegmentTintColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedSegmentTintColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the object participates in spring-loaded interactions.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SpringLoaded {
			[Export ("isSpringLoaded")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSpringLoaded"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSpringLoaded"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSpringLoaded:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UISegmentedControl" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UISegmentedControl" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UISegmentedControl.Appearance" /> property or by calling <see cref="global::UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UISegmentedControlAppearance : global::UIKit.UIControl.UIControlAppearance {
			protected internal UISegmentedControlAppearance (IntPtr handle) : base (handle) {}
			/// <param name="leftCenterRightOrAlone">To be added.</param><param name="barMetrics">To be added.</param><summary>The positioning offset for the specified UISegmentedControlSegment and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("contentPositionAdjustmentForSegmentType:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIOffset ContentPositionAdjustment (UISegmentedControlSegment leftCenterRightOrAlone, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIOffset ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("contentPositionAdjustmentForSegmentType:barMetrics:"), (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("contentPositionAdjustmentForSegmentType:barMetrics:"), (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image used for the specified UIControlState and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backgroundImageForState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetBackgroundImage (UIControlState state, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="leftState">To be added.</param><param name="rightState">To be added.</param><param name="barMetrics">To be added.</param><summary>The divider image for the specified UIControlStates and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage? GetDividerImage (UIControlState leftState, UIControlState rightState, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState, (IntPtr) (long) barMetrics), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("dividerImageForLeftSegmentState:rightSegmentState:barMetrics:"), (UIntPtr) (ulong) leftState, (UIntPtr) (ulong) rightState, (IntPtr) (long) barMetrics), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">The state that you want to retrieve the rendering text attributes from.</param><summary>Returns the current rendering text attributes for the requested state.</summary><returns></returns><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UISegmentedControl.Appearance" /> property and the <see cref="UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public UIStringAttributes GetTitleTextAttributes (UIControlState state)
			{
				return new UIStringAttributes (GetWeakTitleTextAttributes (state));
			}
			[Export ("titleTextAttributesForState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual NSDictionary? GetWeakTitleTextAttributes (UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("titleTextAttributesForState:"), (UIntPtr) (ulong) state), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("titleTextAttributesForState:"), (UIntPtr) (ulong) state), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			public virtual UIColor? SelectedSegmentTintColor {
				[Export ("selectedSegmentTintColor", ArgumentSemantic.Retain)]
				get {
					global::UIKit.UIApplication.EnsureUIThread ();
					UIColor? ret;
					if (IsDirectBinding) {
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedSegmentTintColor")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedSegmentTintColor")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
				[Export ("setSelectedSegmentTintColor:", ArgumentSemantic.Retain)]
				set {
					global::UIKit.UIApplication.EnsureUIThread ();
					var value__handle__ = value.GetHandle ();
					if (IsDirectBinding) {
						global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedSegmentTintColor:"), value__handle__);
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedSegmentTintColor:"), value__handle__);
							GC.KeepAlive (this);
						}
					}
					GC.KeepAlive (value);
				}
			}
			/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the background image used for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setBackgroundImage:forState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var backgroundImage__handle__ = backgroundImage.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (backgroundImage);
			}
			/// <param name="adjustment">To be added.</param><param name="leftCenterRightOrAlone">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the position adjustment for the specified UISegmentedControlSegment and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setContentPositionAdjustment:forSegmentType:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetContentPositionAdjustment (UIOffset adjustment, UISegmentedControlSegment leftCenterRightOrAlone, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setContentPositionAdjustment:forSegmentType:barMetrics:"), adjustment, (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setContentPositionAdjustment:forSegmentType:barMetrics:"), adjustment, (IntPtr) (long) leftCenterRightOrAlone, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
			}
			/// <param name="dividerImage">To be added.</param><param name="leftSegmentState">To be added.</param><param name="rightSegmentState">To be added.</param><param name="barMetrics">To be added.</param><summary>Sets the divider image used for the specified UIControlStates and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetDividerImage (UIImage? dividerImage, UIControlState leftSegmentState, UIControlState rightSegmentState, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var dividerImage__handle__ = dividerImage.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:"), dividerImage__handle__, (UIntPtr) (ulong) leftSegmentState, (UIntPtr) (ulong) rightSegmentState, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setDividerImage:forLeftSegmentState:rightSegmentState:barMetrics:"), dividerImage__handle__, (UIntPtr) (ulong) leftSegmentState, (UIntPtr) (ulong) rightSegmentState, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (dividerImage);
			}
			/// <param name="attributes">rendering attributes for the text.</param><param name="state">The state to alter</param><summary>Sets the rendering text attributes for a specific state in the control.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UISegmentedControl.Appearance" /> property and the <see cref="UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public void SetTitleTextAttributes (UIStringAttributes? attributes, UIControlState state)
			{
				SetTitleTextAttributes (attributes?.GetDictionary (), state);
			}
			[Export ("setTitleTextAttributes:forState:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetTitleTextAttributes (NSDictionary? attributes, UIControlState state)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var attributes__handle__ = attributes.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setTitleTextAttributes:forState:"), attributes__handle__, (UIntPtr) (ulong) state);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setTitleTextAttributes:forState:"), attributes__handle__, (UIntPtr) (ulong) state);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (attributes);
			}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UISegmentedControl" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UISegmentedControl" />, they should use the <see cref="global::UIKit.UISegmentedControl.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance Appearance {
			get { return new UISegmentedControlAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UISegmentedControl.UISegmentedControlAppearance" /> for the subclass of <see cref="global::UIKit.UISegmentedControl" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UISegmentedControl" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UISegmentedControl.Appearance" /> property, or the <see cref="global::UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UISegmentedControl.GetAppearance<MyUISegmentedControlSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance GetAppearance<T> () where T: UISegmentedControl {
			return new UISegmentedControlAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UISegmentedControl" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UISegmentedControl" />, they should use the <see cref="global::UIKit.UISegmentedControl.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UISegmentedControlAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UISegmentedControl.UISegmentedControlAppearance" /> for <see cref="global::UIKit.UISegmentedControl" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UISegmentedControl.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UISegmentedControl" />, they should use the <see cref="global::UIKit.UISegmentedControl.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance GetAppearance (UITraitCollection traits) {
			return new UISegmentedControlAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UISegmentedControl.UISegmentedControlAppearance" /> for <see cref="global::UIKit.UISegmentedControl" />.</summary>
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
		///var myTheme = UISegmentedControl.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UISegmentedControl" />, they should use the <see cref="global::UIKit.UISegmentedControl.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UISegmentedControlAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UISegmentedControl.UISegmentedControlAppearance" /> for the subclass of <see cref="global::UIKit.UISegmentedControl" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UISegmentedControl" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UISegmentedControl.Appearance" /> property, or the <see cref="global::UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UISegmentedControl.GetAppearance<MyUISegmentedControlSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance GetAppearance<T> (UITraitCollection traits) where T: UISegmentedControl {
			return new UISegmentedControlAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UISegmentedControl.UISegmentedControlAppearance" /> for the subclass of <see cref="global::UIKit.UISegmentedControl" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UISegmentedControl" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UISegmentedControl.Appearance" /> property, or the <see cref="global::UIKit.UISegmentedControl.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UISegmentedControl.GetAppearance<MyUISegmentedControlSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UISegmentedControlAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UISegmentedControl{
			return new UISegmentedControlAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class UISegmentedControl */
}
