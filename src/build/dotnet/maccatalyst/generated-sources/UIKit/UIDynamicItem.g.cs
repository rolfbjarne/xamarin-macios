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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIDynamicItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIDynamicItem", WrapperType = typeof (UIDynamicItemWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Center", Selector = "center", PropertyType = typeof (CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Bounds", Selector = "bounds", PropertyType = typeof (CGRect), GetterSelector = "bounds", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Transform", Selector = "transform", PropertyType = typeof (CGAffineTransform), GetterSelector = "transform", SetterSelector = "setTransform:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CollisionBoundsType", Selector = "collisionBoundsType", PropertyType = typeof (UIDynamicItemCollisionBoundsType), GetterSelector = "collisionBoundsType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CollisionBoundingPath", Selector = "collisionBoundingPath", PropertyType = typeof (UIBezierPath), GetterSelector = "collisionBoundingPath", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIDynamicItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Bounds")]
		[DynamicDependencyAttribute ("Center")]
		[DynamicDependencyAttribute ("CollisionBoundingPath")]
		[DynamicDependencyAttribute ("CollisionBoundsType")]
		[DynamicDependencyAttribute ("Transform")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDynamicItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDynamicItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The center of the dynamic item.</summary><value>The center point.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint Center {
			[Export ("center")]
			get {
				return _GetCenter (this);
			}
			[Export ("setCenter:")]
			set {
				_SetCenter (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetCenter (IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("center"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCenter (IUIDynamicItem This, CGPoint value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setCenter:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Called in an instance where the dynamic animator requires the bounds of a dynamic item be returned.</summary><value>Dynamic item bounds.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				return _GetBounds (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetBounds (IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>The rotation of the dynamic item.</summary><value>Item rotation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGAffineTransform Transform {
			[Export ("transform")]
			get {
				return _GetTransform (this);
			}
			[Export ("setTransform:")]
			set {
				_SetTransform (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGAffineTransform _GetTransform (IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (This.Handle, Selector.GetHandle ("transform"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (This.Handle, Selector.GetHandle ("transform"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTransform (IUIDynamicItem This, CGAffineTransform value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (This.Handle, Selector.GetHandle ("setTransform:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Returns a value that tells how collision bounds are specified.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIDynamicItemCollisionBoundsType CollisionBoundsType {
			[Export ("collisionBoundsType")]
			get {
				return _GetCollisionBoundsType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDynamicItemCollisionBoundsType _GetCollisionBoundsType (IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDynamicItemCollisionBoundsType ret;
			ret = (UIDynamicItemCollisionBoundsType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("collisionBoundsType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the closed path that is used for collision detection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIBezierPath CollisionBoundingPath {
			[Export ("collisionBoundingPath")]
			get {
				return _GetCollisionBoundingPath (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIBezierPath _GetCollisionBoundingPath (IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIBezierPath ret;
			ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("collisionBoundingPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIDynamicItem" /> interface to support all the methods from the UIDynamicItem protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIDynamicItem" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIDynamicItem protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIDynamicItem_Extensions {
		/// <summary>Returns a value that tells how collision bounds are specified.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIDynamicItemCollisionBoundsType GetCollisionBoundsType (this IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDynamicItemCollisionBoundsType ret;
			ret = (UIDynamicItemCollisionBoundsType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("collisionBoundsType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the closed path that is used for collision detection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIBezierPath GetCollisionBoundingPath (this IUIDynamicItem This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIBezierPath ret;
			ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("collisionBoundingPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDynamicItemWrapper : BaseWrapper, IUIDynamicItem {
		public UIDynamicItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDynamicItemWrapper))]
		static UIDynamicItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The center of the dynamic item.</summary><value>The center point.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint Center {
			[Export ("center")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("center"));
				return ret;
			}
			[Export ("setCenter:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setCenter:"), value);
			}
		}
		/// <summary>Called in an instance where the dynamic animator requires the bounds of a dynamic item be returned.</summary><value>Dynamic item bounds.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect Bounds {
			[Export ("bounds")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
				}
				return ret!;
			}
		}
		/// <summary>The rotation of the dynamic item.</summary><value>Item rotation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGAffineTransform Transform {
			[Export ("transform")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGAffineTransform ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("transform"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("transform"));
				}
				return ret!;
			}
			[Export ("setTransform:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("setTransform:"), value);
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIDynamicItem" /> (for the protocol <c>UIDynamicItem</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIDynamicItem" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIDynamicItem", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIDynamicItem : NSObject, IUIDynamicItem {
		/// <summary>Creates a new <see cref="UIDynamicItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIDynamicItem () : base (NSObjectFlag.Empty)
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
		protected UIDynamicItem (NSObjectFlag t) : base (t)
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
		protected internal UIDynamicItem (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Called in an instance where the dynamic animator requires the bounds of a dynamic item be returned.</summary><value>Dynamic item bounds.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>The center of the dynamic item.</summary><value>The center point.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint Center {
			[Export ("center")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setCenter:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns the closed path that is used for collision detection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIBezierPath CollisionBoundingPath {
			[Export ("collisionBoundingPath")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns a value that tells how collision bounds are specified.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIDynamicItemCollisionBoundsType CollisionBoundsType {
			[Export ("collisionBoundsType")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>The rotation of the dynamic item.</summary><value>Item rotation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform Transform {
			[Export ("transform")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setTransform:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIDynamicItem */
}
