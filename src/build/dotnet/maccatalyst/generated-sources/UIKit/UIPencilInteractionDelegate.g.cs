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
	/// <summary>This interface represents the Objective-C protocol <c>UIPencilInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPencilInteractionDelegate", WrapperType = typeof (UIPencilInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTap", Selector = "pencilInteractionDidTap:", ParameterType = new Type [] { typeof (UIPencilInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveTap", Selector = "pencilInteraction:didReceiveTap:", ParameterType = new Type [] { typeof (UIPencilInteraction), typeof (UIPencilInteractionTap) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveSqueeze", Selector = "pencilInteraction:didReceiveSqueeze:", ParameterType = new Type [] { typeof (UIPencilInteraction), typeof (UIPencilInteractionSqueeze) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIPencilInteractionDelegate : INativeObject, IDisposable
	{
		/// <param name="interaction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pencilInteractionDidTap:")]
		[ObsoletedOSPlatform ("ios17.5", "Use 'DidReceiveTap' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.5", "Use 'DidReceiveTap' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTap (UIPencilInteraction interaction)
		{
			_DidTap (this, interaction);
		}
		/// <param name="interaction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios17.5", "Use 'DidReceiveTap' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.5", "Use 'DidReceiveTap' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidTap (IUIPencilInteractionDelegate This, UIPencilInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteractionDidTap:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("pencilInteraction:didReceiveTap:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveTap (UIPencilInteraction interaction, UIPencilInteractionTap tap)
		{
			_DidReceiveTap (this, interaction, tap);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveTap (IUIPencilInteractionDelegate This, UIPencilInteraction interaction, UIPencilInteractionTap tap)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var tap__handle__ = tap!.GetNonNullHandle (nameof (tap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteraction:didReceiveTap:"), interaction__handle__, tap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (tap);
		}
		[global::Foundation.OptionalMember]
		[Export ("pencilInteraction:didReceiveSqueeze:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveSqueeze (UIPencilInteraction interaction, UIPencilInteractionSqueeze squeeze)
		{
			_DidReceiveSqueeze (this, interaction, squeeze);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveSqueeze (IUIPencilInteractionDelegate This, UIPencilInteraction interaction, UIPencilInteractionSqueeze squeeze)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var squeeze__handle__ = squeeze!.GetNonNullHandle (nameof (squeeze));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteraction:didReceiveSqueeze:"), interaction__handle__, squeeze__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (squeeze);
		}
		[DynamicDependencyAttribute ("DidReceiveSqueeze(UIKit.UIPencilInteraction,UIKit.UIPencilInteractionSqueeze)")]
		[DynamicDependencyAttribute ("DidReceiveTap(UIKit.UIPencilInteraction,UIKit.UIPencilInteractionTap)")]
		[DynamicDependencyAttribute ("DidTap(UIKit.UIPencilInteraction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPencilInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPencilInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPencilInteractionDelegate" /> interface to support all the methods from the UIPencilInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPencilInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPencilInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPencilInteractionDelegate_Extensions {
		/// <param name="interaction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios17.5", "Use 'DidReceiveTap' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.5", "Use 'DidReceiveTap' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidTap (this IUIPencilInteractionDelegate This, UIPencilInteraction interaction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteractionDidTap:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveTap (this IUIPencilInteractionDelegate This, UIPencilInteraction interaction, UIPencilInteractionTap tap)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var tap__handle__ = tap!.GetNonNullHandle (nameof (tap));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteraction:didReceiveTap:"), interaction__handle__, tap__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (tap);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveSqueeze (this IUIPencilInteractionDelegate This, UIPencilInteraction interaction, UIPencilInteractionSqueeze squeeze)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var squeeze__handle__ = squeeze!.GetNonNullHandle (nameof (squeeze));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pencilInteraction:didReceiveSqueeze:"), interaction__handle__, squeeze__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (squeeze);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPencilInteractionDelegateWrapper : BaseWrapper, IUIPencilInteractionDelegate {
		public UIPencilInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPencilInteractionDelegateWrapper))]
		static UIPencilInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPencilInteractionDelegate" /> (for the protocol <c>UIPencilInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPencilInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPencilInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPencilInteractionDelegate : NSObject, IUIPencilInteractionDelegate {
		/// <summary>Creates a new <see cref="UIPencilInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPencilInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPencilInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPencilInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("pencilInteraction:didReceiveSqueeze:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveSqueeze (UIPencilInteraction interaction, UIPencilInteractionSqueeze squeeze)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pencilInteraction:didReceiveTap:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("maccatalyst17.5")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveTap (UIPencilInteraction interaction, UIPencilInteractionTap tap)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interaction">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pencilInteractionDidTap:")]
		[ObsoletedOSPlatform ("ios17.5", "Use 'DidReceiveTap' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.5", "Use 'DidReceiveTap' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTap (UIPencilInteraction interaction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPencilInteractionDelegate */
}
