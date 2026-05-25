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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CPTemplateApplicationSceneDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[Protocol (Name = "CPTemplateApplicationSceneDelegate", WrapperType = typeof (CPTemplateApplicationSceneDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnect", Selector = "templateApplicationScene:didConnectInterfaceController:toWindow:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPInterfaceController), typeof (CarPlay.CPWindow) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnect", Selector = "templateApplicationScene:didDisconnectInterfaceController:fromWindow:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPInterfaceController), typeof (CarPlay.CPWindow) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelect", Selector = "templateApplicationScene:didSelectNavigationAlert:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPNavigationAlert) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelect", Selector = "templateApplicationScene:didSelectManeuver:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPManeuver) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnect", Selector = "templateApplicationScene:didConnectInterfaceController:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPInterfaceController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnect", Selector = "templateApplicationScene:didDisconnectInterfaceController:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationScene), typeof (CarPlay.CPInterfaceController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentStyleDidChange", Selector = "contentStyleDidChange:", ParameterType = new Type [] { typeof (UIUserInterfaceStyle) }, ParameterByRef = new bool [] { false })]
	public partial interface ICPTemplateApplicationSceneDelegate : INativeObject, IDisposable, 
		UIKit.IUISceneDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didConnectInterfaceController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			_DidConnect (this, templateApplicationScene, interfaceController, window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didConnectInterfaceController:toWindow:"), templateApplicationScene__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didDisconnectInterfaceController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			_DidDisconnect (this, templateApplicationScene, interfaceController, window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didDisconnectInterfaceController:fromWindow:"), templateApplicationScene__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didSelectNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (CPTemplateApplicationScene templateApplicationScene, CPNavigationAlert navigationAlert)
		{
			_DidSelect (this, templateApplicationScene, navigationAlert);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPNavigationAlert navigationAlert)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didSelectNavigationAlert:"), templateApplicationScene__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (navigationAlert);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didSelectManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (CPTemplateApplicationScene templateApplicationScene, CPManeuver maneuver)
		{
			_DidSelect (this, templateApplicationScene, maneuver);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPManeuver maneuver)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didSelectManeuver:"), templateApplicationScene__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (maneuver);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didConnectInterfaceController:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			_DidConnect (this, templateApplicationScene, interfaceController);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didConnectInterfaceController:"), templateApplicationScene__handle__, interfaceController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationScene:didDisconnectInterfaceController:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			_DidDisconnect (this, templateApplicationScene, interfaceController);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnect (ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didDisconnectInterfaceController:"), templateApplicationScene__handle__, interfaceController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
		}
		[global::Foundation.OptionalMember]
		[Export ("contentStyleDidChange:")]
		[SupportedOSPlatform ("ios15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentStyleDidChange (global::UIKit.UIUserInterfaceStyle contentStyle)
		{
			_ContentStyleDidChange (this, contentStyle);
		}
		[SupportedOSPlatform ("ios15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContentStyleDidChange (ICPTemplateApplicationSceneDelegate This, global::UIKit.UIUserInterfaceStyle contentStyle)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("contentStyleDidChange:"), (IntPtr) (long) contentStyle);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ContentStyleDidChange(UIKit.UIUserInterfaceStyle)")]
		[DynamicDependencyAttribute ("DidConnect(CarPlay.CPTemplateApplicationScene,CarPlay.CPInterfaceController,CarPlay.CPWindow)")]
		[DynamicDependencyAttribute ("DidConnect(CarPlay.CPTemplateApplicationScene,CarPlay.CPInterfaceController)")]
		[DynamicDependencyAttribute ("DidDisconnect(CarPlay.CPTemplateApplicationScene,CarPlay.CPInterfaceController,CarPlay.CPWindow)")]
		[DynamicDependencyAttribute ("DidDisconnect(CarPlay.CPTemplateApplicationScene,CarPlay.CPInterfaceController)")]
		[DynamicDependencyAttribute ("DidSelect(CarPlay.CPTemplateApplicationScene,CarPlay.CPManeuver)")]
		[DynamicDependencyAttribute ("DidSelect(CarPlay.CPTemplateApplicationScene,CarPlay.CPNavigationAlert)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPTemplateApplicationSceneDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPTemplateApplicationSceneDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPTemplateApplicationSceneDelegate" /> interface to support all the methods from the CPTemplateApplicationSceneDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPTemplateApplicationSceneDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPTemplateApplicationSceneDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPTemplateApplicationSceneDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidConnect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didConnectInterfaceController:toWindow:"), templateApplicationScene__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didDisconnectInterfaceController:fromWindow:"), templateApplicationScene__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPNavigationAlert navigationAlert)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didSelectNavigationAlert:"), templateApplicationScene__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (navigationAlert);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPManeuver maneuver)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didSelectManeuver:"), templateApplicationScene__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (maneuver);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidConnect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didConnectInterfaceController:"), templateApplicationScene__handle__, interfaceController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnect (this ICPTemplateApplicationSceneDelegate This, CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			var templateApplicationScene__handle__ = templateApplicationScene!.GetNonNullHandle (nameof (templateApplicationScene));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationScene:didDisconnectInterfaceController:"), templateApplicationScene__handle__, interfaceController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationScene);
			GC.KeepAlive (interfaceController);
		}
		[SupportedOSPlatform ("ios15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContentStyleDidChange (this ICPTemplateApplicationSceneDelegate This, global::UIKit.UIUserInterfaceStyle contentStyle)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("contentStyleDidChange:"), (IntPtr) (long) contentStyle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPTemplateApplicationSceneDelegateWrapper : BaseWrapper, ICPTemplateApplicationSceneDelegate {
		public CPTemplateApplicationSceneDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPTemplateApplicationSceneDelegateWrapper))]
		static CPTemplateApplicationSceneDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CarPlay {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICPTemplateApplicationSceneDelegate" /> (for the protocol <c>CPTemplateApplicationSceneDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICPTemplateApplicationSceneDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPTemplateApplicationSceneDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	public unsafe partial class CPTemplateApplicationSceneDelegate : NSObject, ICPTemplateApplicationSceneDelegate, global::UIKit.IUISceneDelegate {
		/// <summary>Creates a new <see cref="CPTemplateApplicationSceneDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CPTemplateApplicationSceneDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected CPTemplateApplicationSceneDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPTemplateApplicationSceneDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("contentStyleDidChange:")]
		[SupportedOSPlatform ("ios15.4")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentStyleDidChange (global::UIKit.UIUserInterfaceStyle contentStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:continueUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueUserActivity (global::UIKit.UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidBecomeActive:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didConnectInterfaceController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didConnectInterfaceController:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didDisconnectInterfaceController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didDisconnectInterfaceController:")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CPTemplateApplicationScene templateApplicationScene, CPInterfaceController interfaceController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidDisconnect:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidEnterBackground:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didFailToContinueUserActivityWithType:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (global::UIKit.UIScene scene, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didSelectNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (CPTemplateApplicationScene templateApplicationScene, CPNavigationAlert navigationAlert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationScene:didSelectManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelect (CPTemplateApplicationScene templateApplicationScene, CPManeuver maneuver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didUpdateUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserActivity (global::UIKit.UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("stateRestorationActivityForScene:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity? GetStateRestorationActivity (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:openURLContexts:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrlContexts (global::UIKit.UIScene scene, NSSet<global::UIKit.UIOpenUrlContext> urlContexts)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:restoreInteractionStateWithUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreInteractionState (global::UIKit.UIScene scene, NSUserActivity stateRestorationActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willConnectToSession:options:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillConnect (global::UIKit.UIScene scene, global::UIKit.UISceneSession session, global::UIKit.UISceneConnectionOptions connectionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willContinueUserActivityWithType:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillContinueUserActivity (global::UIKit.UIScene scene, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillEnterForeground:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillResignActive:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPTemplateApplicationSceneDelegate */
}
