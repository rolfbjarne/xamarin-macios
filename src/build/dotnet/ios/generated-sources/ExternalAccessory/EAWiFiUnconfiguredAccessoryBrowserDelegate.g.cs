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
namespace ExternalAccessory {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser" />, providing events related to scanning, connecting, and configuring compatible accessories.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAWiFiUnconfiguredAccessoryBrowserDelegate_Protocol/index.html">Apple documentation for <c>EAWiFiUnconfiguredAccessoryBrowserDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "EAWiFiUnconfiguredAccessoryBrowserDelegate", WrapperType = typeof (EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdateState", Selector = "accessoryBrowser:didUpdateState:", ParameterType = new Type [] { typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser), typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFindUnconfiguredAccessories", Selector = "accessoryBrowser:didFindUnconfiguredAccessories:", ParameterType = new Type [] { typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveUnconfiguredAccessories", Selector = "accessoryBrowser:didRemoveUnconfiguredAccessories:", ParameterType = new Type [] { typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser), typeof (NSSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishConfiguringAccessory", Selector = "accessoryBrowser:didFinishConfiguringAccessory:withStatus:", ParameterType = new Type [] { typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser), typeof (ExternalAccessory.EAWiFiUnconfiguredAccessory), typeof (ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IEAWiFiUnconfiguredAccessoryBrowserDelegate : INativeObject, IDisposable
	{
		/// <param name="browser">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessoryBrowser:didUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateState (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessoryBrowserState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateState (IEAWiFiUnconfiguredAccessoryBrowserDelegate This, EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessoryBrowserState state)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("accessoryBrowser:didUpdateState:"), browser__handle__, (IntPtr) (long) state);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessoryBrowser:didFindUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFindUnconfiguredAccessories (IEAWiFiUnconfiguredAccessoryBrowserDelegate This, EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessories__handle__ = accessories!.GetNonNullHandle (nameof (accessories));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessoryBrowser:didFindUnconfiguredAccessories:"), browser__handle__, accessories__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessories);
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessoryBrowser:didRemoveUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveUnconfiguredAccessories (IEAWiFiUnconfiguredAccessoryBrowserDelegate This, EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessories__handle__ = accessories!.GetNonNullHandle (nameof (accessories));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accessoryBrowser:didRemoveUnconfiguredAccessories:"), browser__handle__, accessories__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessories);
		}
		/// <param name="browser">To be added.</param><param name="accessory">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishConfiguringAccessory (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessory accessory, EAWiFiUnconfiguredAccessoryConfigurationStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="accessory">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishConfiguringAccessory (IEAWiFiUnconfiguredAccessoryBrowserDelegate This, EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessory accessory, EAWiFiUnconfiguredAccessoryConfigurationStatus status)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:"), browser__handle__, accessory__handle__, (IntPtr) (long) status);
			GC.KeepAlive (This);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessory);
		}
		[DynamicDependencyAttribute ("DidFindUnconfiguredAccessories(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("DidFinishConfiguringAccessory(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser,ExternalAccessory.EAWiFiUnconfiguredAccessory,ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus)")]
		[DynamicDependencyAttribute ("DidRemoveUnconfiguredAccessories(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser,Foundation.NSSet)")]
		[DynamicDependencyAttribute ("DidUpdateState(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser,ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IEAWiFiUnconfiguredAccessoryBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper : BaseWrapper, IEAWiFiUnconfiguredAccessoryBrowserDelegate {
		public EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper))]
		static EAWiFiUnconfiguredAccessoryBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="browser">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdateState (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessoryBrowserState state)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("accessoryBrowser:didUpdateState:"), browser__handle__, (IntPtr) (long) state);
			GC.KeepAlive (browser);
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didFindUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFindUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessories__handle__ = accessories!.GetNonNullHandle (nameof (accessories));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("accessoryBrowser:didFindUnconfiguredAccessories:"), browser__handle__, accessories__handle__);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessories);
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didRemoveUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRemoveUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessories__handle__ = accessories!.GetNonNullHandle (nameof (accessories));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("accessoryBrowser:didRemoveUnconfiguredAccessories:"), browser__handle__, accessories__handle__);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessories);
		}
		/// <param name="browser">To be added.</param><param name="accessory">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinishConfiguringAccessory (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessory accessory, EAWiFiUnconfiguredAccessoryConfigurationStatus status)
		{
			var browser__handle__ = browser!.GetNonNullHandle (nameof (browser));
			var accessory__handle__ = accessory!.GetNonNullHandle (nameof (accessory));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:"), browser__handle__, accessory__handle__, (IntPtr) (long) status);
			GC.KeepAlive (browser);
			GC.KeepAlive (accessory);
		}
	}
}
namespace ExternalAccessory {
	/// <summary>Delegate object for <see cref="T:ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser" />, providing events related to scanning, connecting, and configuring compatible accessories.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAWiFiUnconfiguredAccessoryBrowserDelegate_Protocol/index.html">Apple documentation for <c>EAWiFiUnconfiguredAccessoryBrowserDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__ExternalAccessory_EAWiFiUnconfiguredAccessoryBrowserDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class EAWiFiUnconfiguredAccessoryBrowserDelegate : NSObject, IEAWiFiUnconfiguredAccessoryBrowserDelegate {
		/// <summary>Creates a new <see cref="EAWiFiUnconfiguredAccessoryBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected EAWiFiUnconfiguredAccessoryBrowserDelegate () : base (NSObjectFlag.Empty)
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
		protected EAWiFiUnconfiguredAccessoryBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal EAWiFiUnconfiguredAccessoryBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didFindUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="accessory">To be added.</param><param name="status">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishConfiguringAccessory (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessory accessory, EAWiFiUnconfiguredAccessoryConfigurationStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="accessories">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didRemoveUnconfiguredAccessories:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="browser">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("accessoryBrowser:didUpdateState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateState (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessoryBrowserState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class EAWiFiUnconfiguredAccessoryBrowserDelegate */
}
