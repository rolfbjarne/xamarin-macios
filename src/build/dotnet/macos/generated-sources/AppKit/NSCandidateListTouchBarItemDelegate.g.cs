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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSCandidateListTouchBarItemDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCandidateListTouchBarItemDelegate", WrapperType = typeof (NSCandidateListTouchBarItemDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginSelectingCandidate", Selector = "candidateListTouchBarItem:beginSelectingCandidateAtIndex:", ParameterType = new Type [] { typeof (NSCandidateListTouchBarItem), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeSelectionFromCandidate", Selector = "candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:", ParameterType = new Type [] { typeof (NSCandidateListTouchBarItem), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndSelectingCandidate", Selector = "candidateListTouchBarItem:endSelectingCandidateAtIndex:", ParameterType = new Type [] { typeof (NSCandidateListTouchBarItem), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedCandidateListVisibility", Selector = "candidateListTouchBarItem:changedCandidateListVisibility:", ParameterType = new Type [] { typeof (NSCandidateListTouchBarItem), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSCandidateListTouchBarItemDelegate : INativeObject, IDisposable
	{
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			_BeginSelectingCandidate (this, anItem, index);
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginSelectingCandidate (INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:"), anItem__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="previousIndex">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeSelectionFromCandidate (NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
		{
			_ChangeSelectionFromCandidate (this, anItem, previousIndex, index);
		}
		/// <param name="anItem">To be added.</param><param name="previousIndex">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangeSelectionFromCandidate (INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:"), anItem__handle__, previousIndex, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("candidateListTouchBarItem:endSelectingCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			_EndSelectingCandidate (this, anItem, index);
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndSelectingCandidate (INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:endSelectingCandidateAtIndex:"), anItem__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="isVisible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("candidateListTouchBarItem:changedCandidateListVisibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedCandidateListVisibility (NSCandidateListTouchBarItem anItem, bool isVisible)
		{
			_ChangedCandidateListVisibility (this, anItem, isVisible);
		}
		/// <param name="anItem">To be added.</param><param name="isVisible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangedCandidateListVisibility (INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, bool isVisible)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:changedCandidateListVisibility:"), anItem__handle__, isVisible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		[DynamicDependencyAttribute ("BeginSelectingCandidate(AppKit.NSCandidateListTouchBarItem,System.IntPtr)")]
		[DynamicDependencyAttribute ("ChangedCandidateListVisibility(AppKit.NSCandidateListTouchBarItem,System.Boolean)")]
		[DynamicDependencyAttribute ("ChangeSelectionFromCandidate(AppKit.NSCandidateListTouchBarItem,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("EndSelectingCandidate(AppKit.NSCandidateListTouchBarItem,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCandidateListTouchBarItemDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCandidateListTouchBarItemDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCandidateListTouchBarItemDelegate" /> interface to support all the methods from the NSCandidateListTouchBarItemDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCandidateListTouchBarItemDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCandidateListTouchBarItemDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCandidateListTouchBarItemDelegate_Extensions {
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginSelectingCandidate (this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:"), anItem__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="previousIndex">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeSelectionFromCandidate (this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:"), anItem__handle__, previousIndex, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndSelectingCandidate (this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:endSelectingCandidateAtIndex:"), anItem__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="isVisible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangedCandidateListVisibility (this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, bool isVisible)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("candidateListTouchBarItem:changedCandidateListVisibility:"), anItem__handle__, isVisible ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (anItem);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCandidateListTouchBarItemDelegateWrapper : BaseWrapper, INSCandidateListTouchBarItemDelegate {
		public NSCandidateListTouchBarItemDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCandidateListTouchBarItemDelegateWrapper))]
		static NSCandidateListTouchBarItemDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCandidateListTouchBarItemDelegate" /> (for the protocol <c>NSCandidateListTouchBarItemDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCandidateListTouchBarItemDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCandidateListTouchBarItemDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCandidateListTouchBarItemDelegate : NSObject, INSCandidateListTouchBarItemDelegate {
		/// <summary>Creates a new <see cref="NSCandidateListTouchBarItemDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCandidateListTouchBarItemDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSCandidateListTouchBarItemDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSCandidateListTouchBarItemDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="anItem">To be added.</param><param name="previousIndex">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeSelectionFromCandidate (NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="anItem">To be added.</param><param name="isVisible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:changedCandidateListVisibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedCandidateListVisibility (NSCandidateListTouchBarItem anItem, bool isVisible)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:endSelectingCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSCandidateListTouchBarItemDelegate */
}
