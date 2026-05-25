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
	/// <summary>This interface represents the Objective-C protocol <c>UITextInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UITextInteractionDelegate", WrapperType = typeof (UITextInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBegin", Selector = "interactionShouldBegin:atPoint:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextInteraction), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBegin", Selector = "interactionWillBegin:", ParameterType = new Type [] { typeof (UITextInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnd", Selector = "interactionDidEnd:", ParameterType = new Type [] { typeof (UITextInteraction) }, ParameterByRef = new bool [] { false })]
	public partial interface IUITextInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("interactionShouldBegin:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UITextInteraction interaction, CGPoint point)
		{
			return _ShouldBegin (this, interaction, point);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBegin (IUITextInteractionDelegate This, UITextInteraction interaction, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("interactionShouldBegin:atPoint:"), interaction__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("interactionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBegin (UITextInteraction interaction)
		{
			_WillBegin (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBegin (IUITextInteractionDelegate This, UITextInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionWillBegin:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("interactionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (UITextInteraction interaction)
		{
			_DidEnd (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnd (IUITextInteractionDelegate This, UITextInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionDidEnd:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[DynamicDependencyAttribute ("DidEnd(UIKit.UITextInteraction)")]
		[DynamicDependencyAttribute ("ShouldBegin(UIKit.UITextInteraction,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("WillBegin(UIKit.UITextInteraction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextInteractionDelegate" /> interface to support all the methods from the UITextInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBegin (this IUITextInteractionDelegate This, UITextInteraction interaction, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("interactionShouldBegin:atPoint:"), interaction__handle__, point);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBegin (this IUITextInteractionDelegate This, UITextInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionWillBegin:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnd (this IUITextInteractionDelegate This, UITextInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionDidEnd:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextInteractionDelegateWrapper : BaseWrapper, IUITextInteractionDelegate {
		public UITextInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInteractionDelegateWrapper))]
		static UITextInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITextInteractionDelegate" /> (for the protocol <c>UITextInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITextInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITextInteractionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios13.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UITextInteractionDelegate : NSObject, IUITextInteractionDelegate {
		/// <summary>Creates a new <see cref="UITextInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("interactionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (UITextInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interactionShouldBegin:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBegin (UITextInteraction interaction, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interactionWillBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBegin (UITextInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextInteractionDelegate */
}
