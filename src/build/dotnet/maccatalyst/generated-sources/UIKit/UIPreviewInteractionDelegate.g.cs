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
	/// <summary>Delegate object for <see cref="T:UIKit.UIPreviewInteraction" /> objects, providing methods that are called during a 3D touch interaction.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/UIKit/UIPreviewInteractionDelegate">Apple documentation for <c>UIPreviewInteractionDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPreviewInteractionDelegate", WrapperType = typeof (UIPreviewInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdatePreviewTransition", Selector = "previewInteraction:didUpdatePreviewTransition:ended:", ParameterType = new Type [] { typeof (UIPreviewInteraction), typeof (NFloat), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCancel", Selector = "previewInteractionDidCancel:", ParameterType = new Type [] { typeof (UIPreviewInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBegin", Selector = "previewInteractionShouldBegin:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIPreviewInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateCommit", Selector = "previewInteraction:didUpdateCommitTransition:ended:", ParameterType = new Type [] { typeof (UIPreviewInteraction), typeof (NFloat), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIPreviewInteractionDelegate : INativeObject, IDisposable
	{
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("previewInteraction:didUpdatePreviewTransition:ended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePreviewTransition (UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdatePreviewTransition (IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_bool (This.Handle, Selector.GetHandle ("previewInteraction:didUpdatePreviewTransition:ended:"), previewInteraction__handle__, transitionProgress, ended ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("previewInteractionDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (UIPreviewInteraction previewInteraction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancel (IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewInteractionDidCancel:"), previewInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewInteractionShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UIPreviewInteraction previewInteraction)
		{
			return _ShouldBegin (this, previewInteraction);
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBegin (IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewInteractionShouldBegin:"), previewInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
			return ret != 0;
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>The system calls this method repeatedly during the commit phase of a preview interaction.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("previewInteraction:didUpdateCommitTransition:ended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateCommit (UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			_DidUpdateCommit (this, previewInteraction, transitionProgress, ended);
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>The system calls this method repeatedly during the commit phase of a preview interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateCommit (IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_bool (This.Handle, Selector.GetHandle ("previewInteraction:didUpdateCommitTransition:ended:"), previewInteraction__handle__, transitionProgress, ended ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
		}
		[DynamicDependencyAttribute ("DidCancel(UIKit.UIPreviewInteraction)")]
		[DynamicDependencyAttribute ("DidUpdateCommit(UIKit.UIPreviewInteraction,System.Runtime.InteropServices.NFloat,System.Boolean)")]
		[DynamicDependencyAttribute ("DidUpdatePreviewTransition(UIKit.UIPreviewInteraction,System.Runtime.InteropServices.NFloat,System.Boolean)")]
		[DynamicDependencyAttribute ("ShouldBegin(UIKit.UIPreviewInteraction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPreviewInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPreviewInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPreviewInteractionDelegate" /> interface to support all the methods from the UIPreviewInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPreviewInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPreviewInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPreviewInteractionDelegate_Extensions {
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBegin (this IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("previewInteractionShouldBegin:"), previewInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
			return ret != 0;
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>The system calls this method repeatedly during the commit phase of a preview interaction.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateCommit (this IUIPreviewInteractionDelegate This, UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_bool (This.Handle, Selector.GetHandle ("previewInteraction:didUpdateCommitTransition:ended:"), previewInteraction__handle__, transitionProgress, ended ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (previewInteraction);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPreviewInteractionDelegateWrapper : BaseWrapper, IUIPreviewInteractionDelegate {
		public UIPreviewInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPreviewInteractionDelegateWrapper))]
		static UIPreviewInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewInteraction:didUpdatePreviewTransition:ended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdatePreviewTransition (UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat_bool (this.Handle, Selector.GetHandle ("previewInteraction:didUpdatePreviewTransition:ended:"), previewInteraction__handle__, transitionProgress, ended ? (byte) 1 : (byte) 0);
			GC.KeepAlive (previewInteraction);
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewInteractionDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCancel (UIPreviewInteraction previewInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previewInteraction__handle__ = previewInteraction!.GetNonNullHandle (nameof (previewInteraction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("previewInteractionDidCancel:"), previewInteraction__handle__);
			GC.KeepAlive (previewInteraction);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for <see cref="T:UIKit.UIPreviewInteraction" /> objects, providing methods that are called during a 3D touch interaction.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/UIKit/UIPreviewInteractionDelegate">Apple documentation for <c>UIPreviewInteractionDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPreviewInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UIPreviewInteractionDelegate : NSObject, IUIPreviewInteractionDelegate {
		/// <summary>Creates a new <see cref="UIPreviewInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIPreviewInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPreviewInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPreviewInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewInteractionDidCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancel (UIPreviewInteraction previewInteraction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>The system calls this method repeatedly during the commit phase of a preview interaction.</summary><remarks>To be added.</remarks>
		[Export ("previewInteraction:didUpdateCommitTransition:ended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateCommit (UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewInteraction">To be added.</param><param name="transitionProgress">To be added.</param><param name="ended">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("previewInteraction:didUpdatePreviewTransition:ended:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePreviewTransition (UIPreviewInteraction previewInteraction, nfloat transitionProgress, bool ended)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previewInteraction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewInteractionShouldBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UIPreviewInteraction previewInteraction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPreviewInteractionDelegate */
}
