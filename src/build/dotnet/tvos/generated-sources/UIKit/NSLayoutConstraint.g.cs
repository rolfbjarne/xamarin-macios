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
	/// <summary>A relationship between two layout attributes used in a constraint-based layout.</summary><remarks><para>An <see cref="T:UIKit.NSLayoutConstraint" /> specifies the relationship between two layout attributes (<see cref="P:UIKit.NSLayoutConstraint.FirstAttribute" /> and <see cref="P:UIKit.NSLayoutConstraint.SecondAttribute" />, both of which are of type <see cref="T:UIKit.NSLayoutAttribute" />) in a constraint-based layout.</para><para>The relationship consists of:</para><list type="bullet"><item><term>A <see cref="T:UIKit.NSLayoutRelation" /> (e.g., <see cref="F:UIKit.NSLayoutRelation.GreaterThanOrEqual" />)</term></item><item><term>A floating point <see cref="P:UIKit.NSLayoutConstraint.Multiplier" /></term></item><item><term>A single-precision floating point <see cref="P:UIKit.NSLayoutConstraint.Constant" /></term></item><item><term>A floating point <see cref="P:UIKit.NSLayoutConstraint.Priority" />. Constraints with higher priorities are satisfied before constraints with lower priorities.</term></item></list><para>The constraint engine will set the value of the <see cref="P:UIKit.NSLayoutConstraint.FirstAttribute" /> such that it satisfies the constraint <c>FirstAttribute &lt;Relation&gt; &lt;Constant&gt; + &lt;Multiplier&gt; * &lt;SecondAttribute&gt;</c>.  For instance, in the following code from the "Media Notes" sample, <c>tconstraint2</c> is a constraint that specifies that the top of the <c>toolbar</c> is going to be equal to the top of the <c>View</c> plus the value of the <c>toolbarVerticalOffset</c>, while <c>tconstraint1</c> specifies that the width of the <c>toolbar</c> will be equal to the width of the <c>View</c>. Both of these constraints have a <see cref="P:UIKit.NSLayoutConstraint.Priority" /> of <c>1.0</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var tconstraint2 = NSLayoutConstraint.Create (toolbar, NSLayoutAttribute.Top, NSLayoutRelation.Equal,
	/// View, NSLayoutAttribute.Top, 1.0f, toolbarVerticalOffset);
	/// toolbarTopConstraint = tconstraint2;
	/// var tconstraint1 = NSLayoutConstraint.Create (toolbar, NSLayoutAttribute.Width, NSLayoutRelation.Equal,
	/// View, NSLayoutAttribute.Width, 1.0f, 0.0f);
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AppKit/Reference/NSLayoutConstraint_Class/index.html">Apple documentation for <c>NSLayoutConstraint</c></related>
	[Register("NSLayoutConstraint", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSLayoutConstraint : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutConstraint");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSLayoutConstraint" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSLayoutConstraint () : base (NSObjectFlag.Empty)
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
		protected NSLayoutConstraint (NSObjectFlag t) : base (t)
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
		protected internal NSLayoutConstraint (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="constraints">Constraints to activate.</param><summary>Activates all of the constraints passed.</summary><remarks><para>This method has the same effect as setting the <see cref="P:UIKit.NSLayoutConstraint.Active" /> property to <see langword="true" />.</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var blueView = new ContentView(UIColor.Blue);
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
		/// ]]></code></example><para><img href="~/xml/UIKit/_images/UIKit.NSLayoutAnchor.png" alt="Screenshot showing the resulting layout" /></para></remarks>
		[Export ("activateConstraints:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ActivateConstraints (NSLayoutConstraint[] constraints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (constraints is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (constraints));
			using var nsa_constraints = NSArray.FromNSObjects (constraints);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("activateConstraints:"), nsa_constraints.Handle);
		}
		/// <param name="view1">First view in the constraint.</param><param name="attribute1">Attribute for the first view.</param><param name="relation">Relationships between the <paramref name="view1" /> and the <paramref name="view2" />.</param><param name="view2"><para>Second view in the constraint.</para><para>This parameter can be <see langword="null" />.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="attribute2">Attribute for the second view.</param><param name="multiplier">Multiplier applied to the second attribute.</param><param name="constant">Constants to add.</param><summary>Factory method for creating a constraint.</summary><returns>New constraint with the specified parameters.</returns><remarks><para>Creates a constraint relationship between the <paramref name="view1" /> and the <paramref name="view2" /> that satisfies the following linear equation:</para><para></para><para><paramref name="attribute1" /> = <paramref name="multiplier" /> x <paramref name="attribute2" /> + <paramref name="constant" /></para></remarks>
		[Export ("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLayoutConstraint Create (INativeObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation, INativeObject? view2, NSLayoutAttribute attribute2, nfloat multiplier, nfloat constant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var view1__handle__ = view1!.GetNonNullHandle (nameof (view1));
			var view2__handle__ = view2.GetHandle ();
			NSLayoutConstraint? ret;
			ret =  Runtime.GetNSObject<NSLayoutConstraint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle_IntPtr_nfloat_nfloat (class_ptr, Selector.GetHandle ("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:"), view1__handle__, (IntPtr) (long) attribute1, (IntPtr) (long) relation, view2__handle__, (IntPtr) (long) attribute2, multiplier, constant), false)!;
			GC.KeepAlive (view1);
			GC.KeepAlive (view2);
			return ret!;
		}
		/// <summary>Deactivates all of the constraints passed.</summary><param name="constraints">Constraints to deactivate.</param><remarks>This method has the same effect as setting the <see cref="P:UIKit.NSLayoutConstraint.Active" /> property to <see langword="false" />.</remarks>
		[Export ("deactivateConstraints:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeactivateConstraints (NSLayoutConstraint[] constraints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (constraints is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (constraints));
			using var nsa_constraints = NSArray.FromNSObjects (constraints);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("deactivateConstraints:"), nsa_constraints.Handle);
		}
		/// <param name="format">Visual format to use to create the constraints.</param><param name="formatOptions">options.</param><param name="metrics"><para>Dictionary containing mapping names to numbers, where each name is associated with the given metric.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="views">Dictionary containing mappings of names to UIViews.</param><summary>Factory method for creating a constraint using Visual Format Language.</summary><returns>An array of layout constraints that are suitable to be added to a <see cref="T:UIKit.UIView" /> using <see cref="M:UIKit.UIView.AddConstraints(UIKit.NSLayoutConstraint[])" /> method.</returns><remarks><para>It is easier to use the <see cref="NSLayoutConstraint.FromVisualFormat(System.String,NSLayoutFormatOptions,System.Object[])" /> overload as it combines support for both metrics and views in a single call.</para></remarks>
		[Export ("constraintsWithVisualFormat:options:metrics:views:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLayoutConstraint[] FromVisualFormat (string format, NSLayoutFormatOptions formatOptions, NSDictionary? metrics, NSDictionary views)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (format is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (format));
			var metrics__handle__ = metrics.GetHandle ();
			var views__handle__ = views!.GetNonNullHandle (nameof (views));
			var nsformat = CFString.CreateNative (format);
			NSLayoutConstraint[]? ret;
			ret = CFArray.ArrayFromHandle<NSLayoutConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("constraintsWithVisualFormat:options:metrics:views:"), nsformat, (UIntPtr) (ulong) formatOptions, metrics__handle__, views__handle__), false)!;
			GC.KeepAlive (metrics);
			GC.KeepAlive (views);
			CFString.ReleaseNative (nsformat);
			return ret!;
		}
		[Export ("firstAnchor")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _FirstAnchor ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstAnchor"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstAnchor"));
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("secondAnchor")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _SecondAnchor ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondAnchor"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondAnchor"));
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Controls whether the constraint is active.  Active constraints are used as part of the auto-layout process, those that are not are ignored.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool Active {
			[Export ("isActive")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setActive:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setActive:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setActive:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Indicates the constant float applied to the constraint.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Constant {
			[Export ("constant")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("constant"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("constant"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setConstant:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setConstant:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setConstant:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The attribute of the first item participating in the constraint.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutAttribute FirstAttribute {
			[Export ("firstAttribute")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutAttribute ret;
				if (IsDirectBinding) {
					ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstAttribute"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstAttribute"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_FirstItem_var;
		/// <summary>The first item participating in the constraint.</summary><value><para /><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? FirstItem {
			[Export ("firstItem", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("firstItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_FirstItem_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Identifier {
			[Export ("identifier")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIdentifier:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Applied to the second attribute participating in the constraint.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Multiplier {
			[Export ("multiplier")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("multiplier"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("multiplier"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The priority of the constraint. Must be in range [0, UILayoutPriority.Required].</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Priority {
			[Export ("priority")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("priority"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("priority"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPriority:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPriority:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setPriority:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The NSRelation that holds between the two items in the constraint.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutRelation Relation {
			[Export ("relation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutRelation ret;
				if (IsDirectBinding) {
					ret = (NSLayoutRelation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("relation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLayoutRelation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("relation"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The attribute of the second item participating in the constraint.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutAttribute SecondAttribute {
			[Export ("secondAttribute")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutAttribute ret;
				if (IsDirectBinding) {
					ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secondAttribute"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondAttribute"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_SecondItem_var;
		/// <summary>The second item participating in the constraint.</summary><value><para /></value><remarks><para /></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? SecondItem {
			[Export ("secondItem", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("secondItem")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("secondItem")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_SecondItem_var = ret;
				return ret!;
			}
		}
		/// <summary>Whether the constraint should be archived by its owning UIView.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeArchived {
			[Export ("shouldBeArchived")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldBeArchived"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldBeArchived"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldBeArchived:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldBeArchived:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShouldBeArchived:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FirstItem_var = null;
				__mt_SecondItem_var = null;
			}
		}
	} /* class NSLayoutConstraint */
}
