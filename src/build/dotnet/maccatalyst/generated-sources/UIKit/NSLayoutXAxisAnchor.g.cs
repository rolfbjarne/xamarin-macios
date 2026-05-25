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
	/// <summary>An <see cref="T:UIKit.NSLayoutAnchor`1" /> whose methods create horizontal <see cref="T:UIKit.NSLayoutConstraint" /> objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AppKit/Reference/NSLayoutXAxisAnchor/index.html">Apple documentation for <c>NSLayoutXAxisAnchor</c></related>
	[Register("NSLayoutXAxisAnchor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSLayoutXAxisAnchor : NSLayoutAnchor<NSLayoutXAxisAnchor> {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutXAxisAnchor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSLayoutXAxisAnchor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSLayoutXAxisAnchor (NSObjectFlag t) : base (t)
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
		protected internal NSLayoutXAxisAnchor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="anchor">The reference anchor.</param><param name="multiplier">The multiplier for the spacing.</param><summary>Returns a constraint for the distance from the current anchor to the specified <paramref name="anchor" />, scaled by the specified <paramref name="multiplier" /> over system spacing.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("constraintEqualToSystemSpacingAfterAnchor:multiplier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintEqualToSystemSpacingAfterAnchor (NSLayoutXAxisAnchor anchor, nfloat multiplier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="anchor">The reference anchor.</param><param name="multiplier">The multiplier for the spacing.</param><summary>Returns a constraint for at least the distance from the current anchor to the specified <paramref name="anchor" />, scaled by the specified <paramref name="multiplier" /> over system spacing.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("constraintGreaterThanOrEqualToSystemSpacingAfterAnchor:multiplier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToSystemSpacingAfterAnchor (NSLayoutXAxisAnchor anchor, nfloat multiplier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintGreaterThanOrEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintGreaterThanOrEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="anchor">The reference anchor.</param><param name="multiplier">The multiplier for the spacing.</param><summary>Returns a constraint for at most the distance from the current anchor to the specified <paramref name="anchor" />, scaled by the specified <paramref name="multiplier" /> over system spacing.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("constraintLessThanOrEqualToSystemSpacingAfterAnchor:multiplier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintLessThanOrEqualToSystemSpacingAfterAnchor (NSLayoutXAxisAnchor anchor, nfloat multiplier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintLessThanOrEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintLessThanOrEqualToSystemSpacingAfterAnchor:multiplier:"), anchor__handle__, multiplier), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="otherAnchor">To be added.</param><summary>Returns a layout dimension for the distance between the current anchor and <paramref name="otherAnchor" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("anchorWithOffsetToAnchor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutDimension CreateAnchorWithOffset (NSLayoutXAxisAnchor otherAnchor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var otherAnchor__handle__ = otherAnchor!.GetNonNullHandle (nameof (otherAnchor));
			NSLayoutDimension? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("anchorWithOffsetToAnchor:"), otherAnchor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("anchorWithOffsetToAnchor:"), otherAnchor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherAnchor);
			return ret!;
		}
	} /* class NSLayoutXAxisAnchor */
}
