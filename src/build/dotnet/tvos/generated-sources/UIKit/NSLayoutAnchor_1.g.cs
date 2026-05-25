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
	/// <typeparam name="AnchorType">Whether the generating anchor is an <see cref="T:UIKit.NSLayoutXAxisAnchor" />, an <see cref="T:UIKit.NSLayoutYAxisAnchor" />, or an <see cref="T:UIKit.NSLayoutDimension" />.</typeparam><summary>Generates <see cref="T:UIKit.NSLayoutConstraint" /> objects based on the value of the <see cref="T:UIKit.NSLayoutConstraint" /> associated with <c>this</c>.</summary><remarks><para>The <see cref="T:UIKit.NSLayoutAnchor`1" /> class, introduced in iOS 9, allows layout constraints to be specified in code, in a fluent manner. For example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// blueView = new ContentView(UIColor.Blue);
	/// view.AddSubview(blueView);
	/// 
	/// blueView.TranslatesAutoresizingMaskIntoConstraints = false;
	/// var blueConstraints = new []
	/// { 
	/// blueView.LeadingAnchor.ConstraintEqualTo(greenView.LeadingAnchor),
	/// blueView.TrailingAnchor.ConstraintEqualTo(greenView.TrailingAnchor),
	/// blueView.TopAnchor.ConstraintEqualTo(greenView.BottomAnchor, 10.0f),
	/// blueView.HeightAnchor.ConstraintEqualTo(greenView.HeightAnchor),
	/// blueView.WidthAnchor.ConstraintEqualTo(greenView.WidthAnchor)
	/// };
	/// 
	/// NSLayoutConstraint.ActivateConstraints(blueConstraints);
	/// 
	/// ]]></code></example><para>In this example, the newly-created <c>blueView</c><see cref="T:UIKit.UIView" /> has its height, width, leading, and trailing anchors defined as equal to that of a previously-defined <c>greenView</c> while its <see cref="P:UIKit.UIView.TopAnchor" /> is set to be 10 logical pixels below the <c>greenView</c>'s <see cref="P:UIKit.UIView.BottomAnchor" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AppKit/Reference/NSLayoutAnchor_ClassReference/index.html">Apple documentation for <c>NSLayoutAnchor</c></related>
	[Register("NSLayoutAnchor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSLayoutAnchor<AnchorType> : NSObject, INSCoding, INSCopying 
			where AnchorType : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutAnchor");
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
		public NSLayoutAnchor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSLayoutAnchor (NSObjectFlag t) : base (t)
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
		protected internal NSLayoutAnchor (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is equal to that of the constraint of the <paramref name="anchor" />.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be copied.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view.</para></remarks>
		[Export ("constraintEqualToAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintEqualTo (NSLayoutAnchor<AnchorType> anchor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("constraintEqualToAnchor:"), anchor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("constraintEqualToAnchor:"), anchor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is equal to that of the constraint of the <paramref name="anchor" /> plus <paramref name="constant" /> pixels.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be used.</param><param name="constant">The number of logical pixels to add to the value of <paramref name="anchor" />.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view.</para></remarks>
		[Export ("constraintEqualToAnchor:constant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintEqualTo (NSLayoutAnchor<AnchorType> anchor, nfloat constant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is at least equal to that of the constraint of the <paramref name="anchor" />.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be used.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view.</para></remarks>
		[Export ("constraintGreaterThanOrEqualToAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualTo (NSLayoutAnchor<AnchorType> anchor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("constraintGreaterThanOrEqualToAnchor:"), anchor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("constraintGreaterThanOrEqualToAnchor:"), anchor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is at least equal to that of the constraint of the <paramref name="anchor" /> plus <paramref name="constant" /> pixels.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be used.</param><param name="constant">The number of logical pixels to add to the value of <paramref name="anchor" />.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view.</para></remarks>
		[Export ("constraintGreaterThanOrEqualToAnchor:constant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualTo (NSLayoutAnchor<AnchorType> anchor, nfloat constant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintGreaterThanOrEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintGreaterThanOrEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is at most equal to that of the constraint of the <paramref name="anchor" />.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be used.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view /&gt;.</para></remarks>
		[Export ("constraintLessThanOrEqualToAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintLessThanOrEqualTo (NSLayoutAnchor<AnchorType> anchor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("constraintLessThanOrEqualToAnchor:"), anchor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("constraintLessThanOrEqualToAnchor:"), anchor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <summary>Creates a <see cref="T:UIKit.NSLayoutConstraint" /> whose value is at most equal to that of the constraint of the <paramref name="anchor" /> plus <paramref name="constant" /> pixels.</summary><param name="anchor">The <see cref="T:UIKit.NSLayoutAnchor`1" /> whose constraint value should be used.</param><param name="constant">The number of logical pixels to add to the value of <paramref name="anchor" />.</param><returns>A new <see cref="T:UIKit.NSLayoutConstraint" />.</returns><remarks><para>As with other methods of this class, this method returns a new <see cref="T:UIKit.NSLayoutConstraint" /> but does not add and activate it to the current view.</para></remarks>
		[Export ("constraintLessThanOrEqualToAnchor:constant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutConstraint ConstraintLessThanOrEqualTo (NSLayoutAnchor<AnchorType> anchor, nfloat constant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var anchor__handle__ = anchor!.GetNonNullHandle (nameof (anchor));
			NSLayoutConstraint? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("constraintLessThanOrEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("constraintLessThanOrEqualToAnchor:constant:"), anchor__handle__, constant), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anchor);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
	} /* class NSLayoutAnchor */
}
