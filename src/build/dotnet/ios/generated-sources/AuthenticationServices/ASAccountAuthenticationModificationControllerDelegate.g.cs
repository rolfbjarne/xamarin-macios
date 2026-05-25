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
namespace AuthenticationServices {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>ASAccountAuthenticationModificationControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "ASAccountAuthenticationModificationControllerDelegate", WrapperType = typeof (ASAccountAuthenticationModificationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSuccessfullyCompleteRequest", Selector = "accountAuthenticationModificationController:didSuccessfullyCompleteRequest:withUserInfo:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAccountAuthenticationModificationController), typeof (AuthenticationServices.ASAccountAuthenticationModificationRequest), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailRequest", Selector = "accountAuthenticationModificationController:didFailRequest:withError:", ParameterType = new Type [] { typeof (AuthenticationServices.ASAccountAuthenticationModificationController), typeof (AuthenticationServices.ASAccountAuthenticationModificationRequest), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IASAccountAuthenticationModificationControllerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("accountAuthenticationModificationController:didSuccessfullyCompleteRequest:withUserInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSuccessfullyCompleteRequest (ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSDictionary? userInfo)
		{
			_DidSuccessfullyCompleteRequest (this, controller, request, userInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSuccessfullyCompleteRequest (IASAccountAuthenticationModificationControllerDelegate This, ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSDictionary? userInfo)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var userInfo__handle__ = userInfo.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountAuthenticationModificationController:didSuccessfullyCompleteRequest:withUserInfo:"), controller__handle__, request__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (request);
			GC.KeepAlive (userInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("accountAuthenticationModificationController:didFailRequest:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailRequest (ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSError error)
		{
			_DidFailRequest (this, controller, request, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailRequest (IASAccountAuthenticationModificationControllerDelegate This, ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSError error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountAuthenticationModificationController:didFailRequest:withError:"), controller__handle__, request__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (request);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidFailRequest(AuthenticationServices.ASAccountAuthenticationModificationController,AuthenticationServices.ASAccountAuthenticationModificationRequest,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidSuccessfullyCompleteRequest(AuthenticationServices.ASAccountAuthenticationModificationController,AuthenticationServices.ASAccountAuthenticationModificationRequest,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAccountAuthenticationModificationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IASAccountAuthenticationModificationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IASAccountAuthenticationModificationControllerDelegate" /> interface to support all the methods from the ASAccountAuthenticationModificationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IASAccountAuthenticationModificationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original ASAccountAuthenticationModificationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class ASAccountAuthenticationModificationControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSuccessfullyCompleteRequest (this IASAccountAuthenticationModificationControllerDelegate This, ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSDictionary? userInfo)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var userInfo__handle__ = userInfo.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountAuthenticationModificationController:didSuccessfullyCompleteRequest:withUserInfo:"), controller__handle__, request__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (request);
			GC.KeepAlive (userInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailRequest (this IASAccountAuthenticationModificationControllerDelegate This, ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSError error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountAuthenticationModificationController:didFailRequest:withError:"), controller__handle__, request__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (request);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ASAccountAuthenticationModificationControllerDelegateWrapper : BaseWrapper, IASAccountAuthenticationModificationControllerDelegate {
		public ASAccountAuthenticationModificationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ASAccountAuthenticationModificationControllerDelegateWrapper))]
		static ASAccountAuthenticationModificationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AuthenticationServices {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IASAccountAuthenticationModificationControllerDelegate" /> (for the protocol <c>ASAccountAuthenticationModificationControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IASAccountAuthenticationModificationControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AuthenticationServices_ASAccountAuthenticationModificationControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios14.0")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	public unsafe partial class ASAccountAuthenticationModificationControllerDelegate : NSObject, IASAccountAuthenticationModificationControllerDelegate {
		/// <summary>Creates a new <see cref="ASAccountAuthenticationModificationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ASAccountAuthenticationModificationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected ASAccountAuthenticationModificationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal ASAccountAuthenticationModificationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("accountAuthenticationModificationController:didFailRequest:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailRequest (ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("accountAuthenticationModificationController:didSuccessfullyCompleteRequest:withUserInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSuccessfullyCompleteRequest (ASAccountAuthenticationModificationController controller, ASAccountAuthenticationModificationRequest request, NSDictionary? userInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ASAccountAuthenticationModificationControllerDelegate */
}
