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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIEditMenuInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UIEditMenuInteractionDelegate", WrapperType = typeof (UIEditMenuInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "editMenuInteraction:menuForConfiguration:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UIEditMenuInteraction), typeof (UIEditMenuConfiguration), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTargetRect", Selector = "editMenuInteraction:targetRectForConfiguration:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIEditMenuInteraction), typeof (UIEditMenuConfiguration) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentMenu", Selector = "editMenuInteraction:willPresentMenuForConfiguration:animator:", ParameterType = new Type [] { typeof (UIEditMenuInteraction), typeof (UIEditMenuConfiguration), typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissMenu", Selector = "editMenuInteraction:willDismissMenuForConfiguration:animator:", ParameterType = new Type [] { typeof (UIEditMenuInteraction), typeof (UIEditMenuConfiguration), typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIEditMenuInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("editMenuInteraction:menuForConfiguration:suggestedActions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, UIMenuElement[] suggestedActions)
		{
			return _GetMenu (this, interaction, configuration, suggestedActions);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetMenu (IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:menuForConfiguration:suggestedActions:"), interaction__handle__, configuration__handle__, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("editMenuInteraction:targetRectForConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetTargetRect (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration)
		{
			return _GetTargetRect (this, interaction, configuration);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetTargetRect (IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:targetRectForConfiguration:"), interaction__handle__, configuration__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:targetRectForConfiguration:"), interaction__handle__, configuration__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("editMenuInteraction:willPresentMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			_WillPresentMenu (this, interaction, configuration, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentMenu (IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:willPresentMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("editMenuInteraction:willDismissMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			_WillDismissMenu (this, interaction, configuration, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissMenu (IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:willDismissMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[DynamicDependencyAttribute ("GetMenu(UIKit.UIEditMenuInteraction,UIKit.UIEditMenuConfiguration,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("GetTargetRect(UIKit.UIEditMenuInteraction,UIKit.UIEditMenuConfiguration)")]
		[DynamicDependencyAttribute ("WillDismissMenu(UIKit.UIEditMenuInteraction,UIKit.UIEditMenuConfiguration,UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPresentMenu(UIKit.UIEditMenuInteraction,UIKit.UIEditMenuConfiguration,UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIEditMenuInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIEditMenuInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIEditMenuInteractionDelegate" /> interface to support all the methods from the UIEditMenuInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIEditMenuInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIEditMenuInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIEditMenuInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetMenu (this IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:menuForConfiguration:suggestedActions:"), interaction__handle__, configuration__handle__, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetTargetRect (this IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:targetRectForConfiguration:"), interaction__handle__, configuration__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:targetRectForConfiguration:"), interaction__handle__, configuration__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentMenu (this IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:willPresentMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissMenu (this IUIEditMenuInteractionDelegate This, UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuInteraction:willDismissMenuForConfiguration:animator:"), interaction__handle__, configuration__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIEditMenuInteractionDelegateWrapper : BaseWrapper, IUIEditMenuInteractionDelegate {
		public UIEditMenuInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIEditMenuInteractionDelegateWrapper))]
		static UIEditMenuInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIEditMenuInteractionDelegate" /> (for the protocol <c>UIEditMenuInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIEditMenuInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIEditMenuInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class UIEditMenuInteractionDelegate : NSObject, IUIEditMenuInteractionDelegate {
		/// <summary>Creates a new <see cref="UIEditMenuInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIEditMenuInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIEditMenuInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIEditMenuInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("editMenuInteraction:menuForConfiguration:suggestedActions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, UIMenuElement[] suggestedActions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("editMenuInteraction:targetRectForConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetTargetRect (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("editMenuInteraction:willDismissMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("editMenuInteraction:willPresentMenuForConfiguration:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentMenu (UIEditMenuInteraction interaction, UIEditMenuConfiguration configuration, IUIEditMenuInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIEditMenuInteractionDelegate */
}
