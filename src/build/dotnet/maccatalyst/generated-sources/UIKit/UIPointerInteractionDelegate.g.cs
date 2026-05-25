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
	/// <summary>This interface represents the Objective-C protocol <c>UIPointerInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIPointerInteractionDelegate", WrapperType = typeof (UIPointerInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRegionForRequest", Selector = "pointerInteraction:regionForRequest:defaultRegion:", ReturnType = typeof (UIPointerRegion), ParameterType = new Type [] { typeof (UIPointerInteraction), typeof (UIPointerRegionRequest), typeof (UIPointerRegion) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStyleForRegion", Selector = "pointerInteraction:styleForRegion:", ReturnType = typeof (UIPointerStyle), ParameterType = new Type [] { typeof (UIPointerInteraction), typeof (UIPointerRegion) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterRegion", Selector = "pointerInteraction:willEnterRegion:animator:", ParameterType = new Type [] { typeof (UIPointerInteraction), typeof (UIPointerRegion), typeof (IUIPointerInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExitRegion", Selector = "pointerInteraction:willExitRegion:animator:", ParameterType = new Type [] { typeof (UIPointerInteraction), typeof (UIPointerRegion), typeof (IUIPointerInteractionAnimating) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIPointerInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("pointerInteraction:regionForRequest:defaultRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPointerRegion? GetRegionForRequest (UIPointerInteraction interaction, UIPointerRegionRequest request, UIPointerRegion defaultRegion)
		{
			return _GetRegionForRequest (this, interaction, request, defaultRegion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPointerRegion? _GetRegionForRequest (IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegionRequest request, UIPointerRegion defaultRegion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var defaultRegion__handle__ = defaultRegion!.GetNonNullHandle (nameof (defaultRegion));
			UIPointerRegion? ret;
			ret =  Runtime.GetNSObject<UIPointerRegion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:regionForRequest:defaultRegion:"), interaction__handle__, request__handle__, defaultRegion__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (request);
			GC.KeepAlive (defaultRegion);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pointerInteraction:styleForRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPointerStyle? GetStyleForRegion (UIPointerInteraction interaction, UIPointerRegion region)
		{
			return _GetStyleForRegion (this, interaction, region);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPointerStyle? _GetStyleForRegion (IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			UIPointerStyle? ret;
			ret =  Runtime.GetNSObject<UIPointerStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:styleForRegion:"), interaction__handle__, region__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pointerInteraction:willEnterRegion:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterRegion (UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			_WillEnterRegion (this, interaction, region, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEnterRegion (IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:willEnterRegion:animator:"), interaction__handle__, region__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("pointerInteraction:willExitRegion:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitRegion (UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			_WillExitRegion (this, interaction, region, animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillExitRegion (IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:willExitRegion:animator:"), interaction__handle__, region__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			GC.KeepAlive (animator);
		}
		[DynamicDependencyAttribute ("GetRegionForRequest(UIKit.UIPointerInteraction,UIKit.UIPointerRegionRequest,UIKit.UIPointerRegion)")]
		[DynamicDependencyAttribute ("GetStyleForRegion(UIKit.UIPointerInteraction,UIKit.UIPointerRegion)")]
		[DynamicDependencyAttribute ("WillEnterRegion(UIKit.UIPointerInteraction,UIKit.UIPointerRegion,UIKit.IUIPointerInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillExitRegion(UIKit.UIPointerInteraction,UIKit.UIPointerRegion,UIKit.IUIPointerInteractionAnimating)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPointerInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPointerInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPointerInteractionDelegate" /> interface to support all the methods from the UIPointerInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPointerInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPointerInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPointerInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPointerRegion? GetRegionForRequest (this IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegionRequest request, UIPointerRegion defaultRegion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var defaultRegion__handle__ = defaultRegion!.GetNonNullHandle (nameof (defaultRegion));
			UIPointerRegion? ret;
			ret =  Runtime.GetNSObject<UIPointerRegion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:regionForRequest:defaultRegion:"), interaction__handle__, request__handle__, defaultRegion__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (request);
			GC.KeepAlive (defaultRegion);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPointerStyle? GetStyleForRegion (this IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			UIPointerStyle? ret;
			ret =  Runtime.GetNSObject<UIPointerStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:styleForRegion:"), interaction__handle__, region__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEnterRegion (this IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:willEnterRegion:animator:"), interaction__handle__, region__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			GC.KeepAlive (animator);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillExitRegion (this IUIPointerInteractionDelegate This, UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var region__handle__ = region!.GetNonNullHandle (nameof (region));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pointerInteraction:willExitRegion:animator:"), interaction__handle__, region__handle__, animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (region);
			GC.KeepAlive (animator);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPointerInteractionDelegateWrapper : BaseWrapper, IUIPointerInteractionDelegate {
		public UIPointerInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPointerInteractionDelegateWrapper))]
		static UIPointerInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPointerInteractionDelegate" /> (for the protocol <c>UIPointerInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPointerInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPointerInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UIPointerInteractionDelegate : NSObject, IUIPointerInteractionDelegate {
		/// <summary>Creates a new <see cref="UIPointerInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPointerInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPointerInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPointerInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("pointerInteraction:regionForRequest:defaultRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPointerRegion? GetRegionForRequest (UIPointerInteraction interaction, UIPointerRegionRequest request, UIPointerRegion defaultRegion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pointerInteraction:styleForRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPointerStyle? GetStyleForRegion (UIPointerInteraction interaction, UIPointerRegion region)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pointerInteraction:willEnterRegion:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterRegion (UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pointerInteraction:willExitRegion:animator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExitRegion (UIPointerInteraction interaction, UIPointerRegion region, IUIPointerInteractionAnimating animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPointerInteractionDelegate */
}
