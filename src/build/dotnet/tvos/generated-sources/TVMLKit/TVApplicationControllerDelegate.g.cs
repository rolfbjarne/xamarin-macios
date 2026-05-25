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
namespace TVMLKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVApplicationControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "TVApplicationControllerDelegate", WrapperType = typeof (TVApplicationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EvaluateAppJavaScript", Selector = "appController:evaluateAppJavaScriptInContext:", ParameterType = new Type [] { typeof (TVMLKit.TVApplicationController), typeof (JavaScriptCore.JSContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLaunching", Selector = "appController:didFinishLaunchingWithOptions:", ParameterType = new Type [] { typeof (TVMLKit.TVApplicationController), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "appController:didFailWithError:", ParameterType = new Type [] { typeof (TVMLKit.TVApplicationController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStop", Selector = "appController:didStopWithOptions:", ParameterType = new Type [] { typeof (TVMLKit.TVApplicationController), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPlayer", Selector = "playerForAppController:", ReturnType = typeof (TVMLKit.TVPlayer), ParameterType = new Type [] { typeof (TVMLKit.TVApplicationController) }, ParameterByRef = new bool [] { false })]
	public partial interface ITVApplicationControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("appController:evaluateAppJavaScriptInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EvaluateAppJavaScript (TVApplicationController appController, global::JavaScriptCore.JSContext jsContext)
		{
			_EvaluateAppJavaScript (this, appController, jsContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EvaluateAppJavaScript (ITVApplicationControllerDelegate This, TVApplicationController appController, global::JavaScriptCore.JSContext jsContext)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var jsContext__handle__ = jsContext!.GetNonNullHandle (nameof (jsContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:evaluateAppJavaScriptInContext:"), appController__handle__, jsContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (jsContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("appController:didFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLaunching (TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			_DidFinishLaunching (this, appController, options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishLaunching (ITVApplicationControllerDelegate This, TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var options__handle__ = options.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didFinishLaunchingWithOptions:"), appController__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (options);
		}
		[global::Foundation.OptionalMember]
		[Export ("appController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (TVApplicationController appController, NSError error)
		{
			_DidFail (this, appController, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFail (ITVApplicationControllerDelegate This, TVApplicationController appController, NSError error)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didFailWithError:"), appController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("appController:didStopWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStop (TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			_DidStop (this, appController, options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStop (ITVApplicationControllerDelegate This, TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var options__handle__ = options.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didStopWithOptions:"), appController__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (options);
		}
		[global::Foundation.OptionalMember]
		[Export ("playerForAppController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TVPlayer? GetPlayer (TVApplicationController appController)
		{
			return _GetPlayer (this, appController);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TVPlayer? _GetPlayer (ITVApplicationControllerDelegate This, TVApplicationController appController)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			TVPlayer? ret;
			ret =  Runtime.GetNSObject<TVPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerForAppController:"), appController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidFail(TVMLKit.TVApplicationController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishLaunching(TVMLKit.TVApplicationController,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidStop(TVMLKit.TVApplicationController,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("EvaluateAppJavaScript(TVMLKit.TVApplicationController,JavaScriptCore.JSContext)")]
		[DynamicDependencyAttribute ("GetPlayer(TVMLKit.TVApplicationController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVApplicationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVApplicationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITVApplicationControllerDelegate" /> interface to support all the methods from the TVApplicationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVApplicationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVApplicationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVApplicationControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EvaluateAppJavaScript (this ITVApplicationControllerDelegate This, TVApplicationController appController, global::JavaScriptCore.JSContext jsContext)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var jsContext__handle__ = jsContext!.GetNonNullHandle (nameof (jsContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:evaluateAppJavaScriptInContext:"), appController__handle__, jsContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (jsContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishLaunching (this ITVApplicationControllerDelegate This, TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var options__handle__ = options.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didFinishLaunchingWithOptions:"), appController__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFail (this ITVApplicationControllerDelegate This, TVApplicationController appController, NSError error)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didFailWithError:"), appController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStop (this ITVApplicationControllerDelegate This, TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			var options__handle__ = options.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appController:didStopWithOptions:"), appController__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			GC.KeepAlive (options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static TVPlayer? GetPlayer (this ITVApplicationControllerDelegate This, TVApplicationController appController)
		{
			var appController__handle__ = appController!.GetNonNullHandle (nameof (appController));
			TVPlayer? ret;
			ret =  Runtime.GetNSObject<TVPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("playerForAppController:"), appController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (appController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVApplicationControllerDelegateWrapper : BaseWrapper, ITVApplicationControllerDelegate {
		public TVApplicationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVApplicationControllerDelegateWrapper))]
		static TVApplicationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace TVMLKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ITVApplicationControllerDelegate" /> (for the protocol <c>TVApplicationControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ITVApplicationControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__TVMLKit_TVApplicationControllerDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class TVApplicationControllerDelegate : NSObject, ITVApplicationControllerDelegate {
		/// <summary>Creates a new <see cref="TVApplicationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVApplicationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected TVApplicationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVApplicationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("appController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFail (TVApplicationController appController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appController:didFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLaunching (TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appController:didStopWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStop (TVApplicationController appController, NSDictionary<NSString, NSObject>? options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appController:evaluateAppJavaScriptInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EvaluateAppJavaScript (TVApplicationController appController, global::JavaScriptCore.JSContext jsContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("playerForAppController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TVPlayer? GetPlayer (TVApplicationController appController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVApplicationControllerDelegate */
}
