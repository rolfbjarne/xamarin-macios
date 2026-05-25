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
	/// <summary>Abstract implementation of <see cref="T:CarPlay.ICPSessionConfigurationDelegate" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CPSessionConfigurationDelegate", WrapperType = typeof (CPSessionConfigurationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LimitedUserInterfacesChanged", Selector = "sessionConfiguration:limitedUserInterfacesChanged:", ParameterType = new Type [] { typeof (CarPlay.CPSessionConfiguration), typeof (CarPlay.CPLimitableUserInterface) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentStyleChanged", Selector = "sessionConfiguration:contentStyleChanged:", ParameterType = new Type [] { typeof (CarPlay.CPSessionConfiguration), typeof (CarPlay.CPContentStyle) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICPSessionConfigurationDelegate : INativeObject, IDisposable
	{
		/// <param name="sessionConfiguration">To be added.</param><param name="limitedUserInterfaces">To be added.</param><summary>Called when the system changes keyboards or modifies list limits.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sessionConfiguration:limitedUserInterfacesChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LimitedUserInterfacesChanged (CPSessionConfiguration sessionConfiguration, CPLimitableUserInterface limitedUserInterfaces)
		{
			_LimitedUserInterfacesChanged (this, sessionConfiguration, limitedUserInterfaces);
		}
		/// <param name="sessionConfiguration">To be added.</param><param name="limitedUserInterfaces">To be added.</param><summary>Called when the system changes keyboards or modifies list limits.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LimitedUserInterfacesChanged (ICPSessionConfigurationDelegate This, CPSessionConfiguration sessionConfiguration, CPLimitableUserInterface limitedUserInterfaces)
		{
			var sessionConfiguration__handle__ = sessionConfiguration!.GetNonNullHandle (nameof (sessionConfiguration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("sessionConfiguration:limitedUserInterfacesChanged:"), sessionConfiguration__handle__, (UIntPtr) (ulong) limitedUserInterfaces);
			GC.KeepAlive (This);
			GC.KeepAlive (sessionConfiguration);
		}
		[global::Foundation.OptionalMember]
		[Export ("sessionConfiguration:contentStyleChanged:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentStyleChanged (CPSessionConfiguration sessionConfiguration, CPContentStyle contentStyle)
		{
			_ContentStyleChanged (this, sessionConfiguration, contentStyle);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContentStyleChanged (ICPSessionConfigurationDelegate This, CPSessionConfiguration sessionConfiguration, CPContentStyle contentStyle)
		{
			var sessionConfiguration__handle__ = sessionConfiguration!.GetNonNullHandle (nameof (sessionConfiguration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("sessionConfiguration:contentStyleChanged:"), sessionConfiguration__handle__, (UIntPtr) (ulong) contentStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (sessionConfiguration);
		}
		[DynamicDependencyAttribute ("ContentStyleChanged(CarPlay.CPSessionConfiguration,CarPlay.CPContentStyle)")]
		[DynamicDependencyAttribute ("LimitedUserInterfacesChanged(CarPlay.CPSessionConfiguration,CarPlay.CPLimitableUserInterface)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSessionConfigurationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPSessionConfigurationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPSessionConfigurationDelegate" /> interface to support all the methods from the CPSessionConfigurationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPSessionConfigurationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPSessionConfigurationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPSessionConfigurationDelegate_Extensions {
		/// <param name="sessionConfiguration">To be added.</param><param name="limitedUserInterfaces">To be added.</param><summary>Called when the system changes keyboards or modifies list limits.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LimitedUserInterfacesChanged (this ICPSessionConfigurationDelegate This, CPSessionConfiguration sessionConfiguration, CPLimitableUserInterface limitedUserInterfaces)
		{
			var sessionConfiguration__handle__ = sessionConfiguration!.GetNonNullHandle (nameof (sessionConfiguration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("sessionConfiguration:limitedUserInterfacesChanged:"), sessionConfiguration__handle__, (UIntPtr) (ulong) limitedUserInterfaces);
			GC.KeepAlive (This);
			GC.KeepAlive (sessionConfiguration);
		}
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContentStyleChanged (this ICPSessionConfigurationDelegate This, CPSessionConfiguration sessionConfiguration, CPContentStyle contentStyle)
		{
			var sessionConfiguration__handle__ = sessionConfiguration!.GetNonNullHandle (nameof (sessionConfiguration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("sessionConfiguration:contentStyleChanged:"), sessionConfiguration__handle__, (UIntPtr) (ulong) contentStyle);
			GC.KeepAlive (This);
			GC.KeepAlive (sessionConfiguration);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPSessionConfigurationDelegateWrapper : BaseWrapper, ICPSessionConfigurationDelegate {
		public CPSessionConfigurationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSessionConfigurationDelegateWrapper))]
		static CPSessionConfigurationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CarPlay {
	/// <summary>Abstract implementation of <see cref="T:CarPlay.ICPSessionConfigurationDelegate" />.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPSessionConfigurationDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class CPSessionConfigurationDelegate : NSObject, ICPSessionConfigurationDelegate {
		/// <summary>Creates a new <see cref="CPSessionConfigurationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CPSessionConfigurationDelegate () : base (NSObjectFlag.Empty)
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
		protected CPSessionConfigurationDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPSessionConfigurationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("sessionConfiguration:contentStyleChanged:")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContentStyleChanged (CPSessionConfiguration sessionConfiguration, CPContentStyle contentStyle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sessionConfiguration">To be added.</param><param name="limitedUserInterfaces">To be added.</param><summary>Called when the system changes keyboards or modifies list limits.</summary><remarks>To be added.</remarks>
		[Export ("sessionConfiguration:limitedUserInterfacesChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LimitedUserInterfacesChanged (CPSessionConfiguration sessionConfiguration, CPLimitableUserInterface limitedUserInterfaces)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPSessionConfigurationDelegate */
}
