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
	/// <summary>This interface represents the Objective-C protocol <c>UICollisionBehaviorDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollisionBehaviorDelegate", WrapperType = typeof (UICollisionBehaviorDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeganContact", Selector = "collisionBehavior:beganContactForItem:withItem:atPoint:", ParameterType = new Type [] { typeof (UICollisionBehavior), typeof (IUIDynamicItem), typeof (IUIDynamicItem), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndedContact", Selector = "collisionBehavior:endedContactForItem:withItem:", ParameterType = new Type [] { typeof (UICollisionBehavior), typeof (IUIDynamicItem), typeof (IUIDynamicItem) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeganBoundaryContact", Selector = "collisionBehavior:beganContactForItem:withBoundaryIdentifier:atPoint:", ParameterType = new Type [] { typeof (UICollisionBehavior), typeof (IUIDynamicItem), typeof (NSObject), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndedBoundaryContact", Selector = "collisionBehavior:endedContactForItem:withBoundaryIdentifier:", ParameterType = new Type [] { typeof (UICollisionBehavior), typeof (IUIDynamicItem), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUICollisionBehaviorDelegate : INativeObject, IDisposable
	{
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><param name="atPoint">To be added.</param><summary>Indicates that contact between dynamic items has begun.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collisionBehavior:beganContactForItem:withItem:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeganContact (UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem, CGPoint atPoint)
		{
			_BeganContact (this, behavior, firstItem, secondItem, atPoint);
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><param name="atPoint">To be added.</param><summary>Indicates that contact between dynamic items has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeganContact (IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem, CGPoint atPoint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var firstItem__handle__ = firstItem!.GetNonNullHandle (nameof (firstItem));
			var secondItem__handle__ = secondItem!.GetNonNullHandle (nameof (secondItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collisionBehavior:beganContactForItem:withItem:atPoint:"), behavior__handle__, firstItem__handle__, secondItem__handle__, atPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (firstItem);
			GC.KeepAlive (secondItem);
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><summary>Indicates that the two dynamic items have stopped contacting each other.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collisionBehavior:endedContactForItem:withItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndedContact (UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem)
		{
			_EndedContact (this, behavior, firstItem, secondItem);
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><summary>Indicates that the two dynamic items have stopped contacting each other.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndedContact (IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var firstItem__handle__ = firstItem!.GetNonNullHandle (nameof (firstItem));
			var secondItem__handle__ = secondItem!.GetNonNullHandle (nameof (secondItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collisionBehavior:endedContactForItem:withItem:"), behavior__handle__, firstItem__handle__, secondItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (firstItem);
			GC.KeepAlive (secondItem);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="atPoint">To be added.</param><summary>Indicates that boundary contact has begun between the dynamicItem and the boundaryIdentifier.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collisionBehavior:beganContactForItem:withBoundaryIdentifier:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeganBoundaryContact (UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier, CGPoint atPoint)
		{
			_BeganBoundaryContact (this, behavior, dynamicItem, boundaryIdentifier, atPoint);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="atPoint">To be added.</param><summary>Indicates that boundary contact has begun between the dynamicItem and the boundaryIdentifier.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeganBoundaryContact (IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier, CGPoint atPoint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var dynamicItem__handle__ = dynamicItem!.GetNonNullHandle (nameof (dynamicItem));
			var boundaryIdentifier__handle__ = boundaryIdentifier.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collisionBehavior:beganContactForItem:withBoundaryIdentifier:atPoint:"), behavior__handle__, dynamicItem__handle__, boundaryIdentifier__handle__, atPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (dynamicItem);
			GC.KeepAlive (boundaryIdentifier);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the dynamicItem has stopped contacting the boundary.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collisionBehavior:endedContactForItem:withBoundaryIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndedBoundaryContact (UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier)
		{
			_EndedBoundaryContact (this, behavior, dynamicItem, boundaryIdentifier);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the dynamicItem has stopped contacting the boundary.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndedBoundaryContact (IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var dynamicItem__handle__ = dynamicItem!.GetNonNullHandle (nameof (dynamicItem));
			var boundaryIdentifier__handle__ = boundaryIdentifier.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collisionBehavior:endedContactForItem:withBoundaryIdentifier:"), behavior__handle__, dynamicItem__handle__, boundaryIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (dynamicItem);
			GC.KeepAlive (boundaryIdentifier);
		}
		[DynamicDependencyAttribute ("BeganBoundaryContact(UIKit.UICollisionBehavior,UIKit.IUIDynamicItem,Foundation.NSObject,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("BeganContact(UIKit.UICollisionBehavior,UIKit.IUIDynamicItem,UIKit.IUIDynamicItem,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("EndedBoundaryContact(UIKit.UICollisionBehavior,UIKit.IUIDynamicItem,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("EndedContact(UIKit.UICollisionBehavior,UIKit.IUIDynamicItem,UIKit.IUIDynamicItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollisionBehaviorDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollisionBehaviorDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollisionBehaviorDelegate" /> interface to support all the methods from the UICollisionBehaviorDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollisionBehaviorDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollisionBehaviorDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollisionBehaviorDelegate_Extensions {
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><param name="atPoint">To be added.</param><summary>Indicates that contact between dynamic items has begun.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeganContact (this IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem, CGPoint atPoint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var firstItem__handle__ = firstItem!.GetNonNullHandle (nameof (firstItem));
			var secondItem__handle__ = secondItem!.GetNonNullHandle (nameof (secondItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collisionBehavior:beganContactForItem:withItem:atPoint:"), behavior__handle__, firstItem__handle__, secondItem__handle__, atPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (firstItem);
			GC.KeepAlive (secondItem);
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><summary>Indicates that the two dynamic items have stopped contacting each other.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndedContact (this IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var firstItem__handle__ = firstItem!.GetNonNullHandle (nameof (firstItem));
			var secondItem__handle__ = secondItem!.GetNonNullHandle (nameof (secondItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collisionBehavior:endedContactForItem:withItem:"), behavior__handle__, firstItem__handle__, secondItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (firstItem);
			GC.KeepAlive (secondItem);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="atPoint">To be added.</param><summary>Indicates that boundary contact has begun between the dynamicItem and the boundaryIdentifier.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeganBoundaryContact (this IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier, CGPoint atPoint)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var dynamicItem__handle__ = dynamicItem!.GetNonNullHandle (nameof (dynamicItem));
			var boundaryIdentifier__handle__ = boundaryIdentifier.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("collisionBehavior:beganContactForItem:withBoundaryIdentifier:atPoint:"), behavior__handle__, dynamicItem__handle__, boundaryIdentifier__handle__, atPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (dynamicItem);
			GC.KeepAlive (boundaryIdentifier);
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the dynamicItem has stopped contacting the boundary.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndedBoundaryContact (this IUICollisionBehaviorDelegate This, UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			var dynamicItem__handle__ = dynamicItem!.GetNonNullHandle (nameof (dynamicItem));
			var boundaryIdentifier__handle__ = boundaryIdentifier.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collisionBehavior:endedContactForItem:withBoundaryIdentifier:"), behavior__handle__, dynamicItem__handle__, boundaryIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (behavior);
			GC.KeepAlive (dynamicItem);
			GC.KeepAlive (boundaryIdentifier);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollisionBehaviorDelegateWrapper : BaseWrapper, IUICollisionBehaviorDelegate {
		public UICollisionBehaviorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollisionBehaviorDelegateWrapper))]
		static UICollisionBehaviorDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUICollisionBehaviorDelegate" /> (for the protocol <c>UICollisionBehaviorDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUICollisionBehaviorDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UICollisionBehaviorDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollisionBehaviorDelegate : NSObject, IUICollisionBehaviorDelegate {
		/// <summary>Creates a new <see cref="UICollisionBehaviorDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollisionBehaviorDelegate () : base (NSObjectFlag.Empty)
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
		protected UICollisionBehaviorDelegate (NSObjectFlag t) : base (t)
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
		protected internal UICollisionBehaviorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="atPoint">To be added.</param><summary>Indicates that boundary contact has begun between the dynamicItem and the boundaryIdentifier.</summary><remarks>To be added.</remarks>
		[Export ("collisionBehavior:beganContactForItem:withBoundaryIdentifier:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeganBoundaryContact (UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier, CGPoint atPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><param name="atPoint">To be added.</param><summary>Indicates that contact between dynamic items has begun.</summary><remarks>To be added.</remarks>
		[Export ("collisionBehavior:beganContactForItem:withItem:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeganContact (UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem, CGPoint atPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="behavior">To be added.</param><param name="dynamicItem">To be added.</param><param name="boundaryIdentifier">The identifier of the boundary collided with. If <see langword="null" />, the collision was with the reference boundary.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the dynamicItem has stopped contacting the boundary.</summary><remarks>To be added.</remarks>
		[Export ("collisionBehavior:endedContactForItem:withBoundaryIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndedBoundaryContact (UICollisionBehavior behavior, IUIDynamicItem dynamicItem, NSObject? boundaryIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="behavior">To be added.</param><param name="firstItem">To be added.</param><param name="secondItem">To be added.</param><summary>Indicates that the two dynamic items have stopped contacting each other.</summary><remarks>To be added.</remarks>
		[Export ("collisionBehavior:endedContactForItem:withItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndedContact (UICollisionBehavior behavior, IUIDynamicItem firstItem, IUIDynamicItem secondItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollisionBehaviorDelegate */
}
