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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSNetServiceBrowserDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSNetServiceBrowserDelegate", WrapperType = typeof (NSNetServiceBrowserDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchStarted", Selector = "netServiceBrowserWillSearch:", ParameterType = new Type [] { typeof (NSNetServiceBrowser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchStopped", Selector = "netServiceBrowserDidStopSearch:", ParameterType = new Type [] { typeof (NSNetServiceBrowser) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotSearched", Selector = "netServiceBrowser:didNotSearch:", ParameterType = new Type [] { typeof (NSNetServiceBrowser), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FoundDomain", Selector = "netServiceBrowser:didFindDomain:moreComing:", ParameterType = new Type [] { typeof (NSNetServiceBrowser), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FoundService", Selector = "netServiceBrowser:didFindService:moreComing:", ParameterType = new Type [] { typeof (NSNetServiceBrowser), typeof (NSNetService), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DomainRemoved", Selector = "netServiceBrowser:didRemoveDomain:moreComing:", ParameterType = new Type [] { typeof (NSNetServiceBrowser), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ServiceRemoved", Selector = "netServiceBrowser:didRemoveService:moreComing:", ParameterType = new Type [] { typeof (NSNetServiceBrowser), typeof (NSNetService), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSNetServiceBrowserDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowserWillSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchStarted (NSNetServiceBrowser sender)
		{
			_SearchStarted (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SearchStarted (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowserWillSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowserDidStopSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchStopped (NSNetServiceBrowser sender)
		{
			_SearchStopped (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SearchStopped (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowserDidStopSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowser:didNotSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotSearched (NSNetServiceBrowser sender, NSDictionary errors)
		{
			_NotSearched (this, sender, errors);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NotSearched (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowser:didNotSearch:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowser:didFindDomain:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundDomain (NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			_FoundDomain (this, sender, domain, moreComing);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FoundDomain (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			var nsdomain = CFString.CreateNative (domain);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didFindDomain:moreComing:"), sender__handle__, nsdomain, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsdomain);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowser:didFindService:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundService (NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			_FoundService (this, sender, service, moreComing);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FoundService (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didFindService:moreComing:"), sender__handle__, service__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (service);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowser:didRemoveDomain:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DomainRemoved (NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			_DomainRemoved (this, sender, domain, moreComing);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DomainRemoved (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			var nsdomain = CFString.CreateNative (domain);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didRemoveDomain:moreComing:"), sender__handle__, nsdomain, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsdomain);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceBrowser:didRemoveService:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ServiceRemoved (NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			_ServiceRemoved (this, sender, service, moreComing);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ServiceRemoved (INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didRemoveService:moreComing:"), sender__handle__, service__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (service);
		}
		[DynamicDependencyAttribute ("DomainRemoved(Foundation.NSNetServiceBrowser,System.String,System.Boolean)")]
		[DynamicDependencyAttribute ("FoundDomain(Foundation.NSNetServiceBrowser,System.String,System.Boolean)")]
		[DynamicDependencyAttribute ("FoundService(Foundation.NSNetServiceBrowser,Foundation.NSNetService,System.Boolean)")]
		[DynamicDependencyAttribute ("NotSearched(Foundation.NSNetServiceBrowser,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("SearchStarted(Foundation.NSNetServiceBrowser)")]
		[DynamicDependencyAttribute ("SearchStopped(Foundation.NSNetServiceBrowser)")]
		[DynamicDependencyAttribute ("ServiceRemoved(Foundation.NSNetServiceBrowser,Foundation.NSNetService,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSNetServiceBrowserDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSNetServiceBrowserDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSNetServiceBrowserDelegate" /> interface to support all the methods from the NSNetServiceBrowserDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSNetServiceBrowserDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSNetServiceBrowserDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSNetServiceBrowserDelegate_Extensions {
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SearchStarted (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowserWillSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SearchStopped (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowserDidStopSearch:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotSearched (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netServiceBrowser:didNotSearch:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FoundDomain (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			var nsdomain = CFString.CreateNative (domain);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didFindDomain:moreComing:"), sender__handle__, nsdomain, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsdomain);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FoundService (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didFindService:moreComing:"), sender__handle__, service__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (service);
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DomainRemoved (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			var nsdomain = CFString.CreateNative (domain);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didRemoveDomain:moreComing:"), sender__handle__, nsdomain, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsdomain);
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ServiceRemoved (this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("netServiceBrowser:didRemoveService:moreComing:"), sender__handle__, service__handle__, moreComing ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (service);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSNetServiceBrowserDelegateWrapper : BaseWrapper, INSNetServiceBrowserDelegate {
		public NSNetServiceBrowserDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSNetServiceBrowserDelegateWrapper))]
		static NSNetServiceBrowserDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSNetServiceBrowserDelegate" /> (for the protocol <c>NSNetServiceBrowserDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSNetServiceBrowserDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSNetServiceBrowserDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSNetServiceBrowserDelegate : NSObject, INSNetServiceBrowserDelegate {
		/// <summary>Creates a new <see cref="NSNetServiceBrowserDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSNetServiceBrowserDelegate () : base (NSObjectFlag.Empty)
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
		protected NSNetServiceBrowserDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSNetServiceBrowserDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowser:didRemoveDomain:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DomainRemoved (NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="domain">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowser:didFindDomain:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundDomain (NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowser:didFindService:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundService (NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowser:didNotSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotSearched (NSNetServiceBrowser sender, NSDictionary errors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowserWillSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchStarted (NSNetServiceBrowser sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowserDidStopSearch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchStopped (NSNetServiceBrowser sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="service">To be added.</param><param name="moreComing">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceBrowser:didRemoveService:moreComing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ServiceRemoved (NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSNetServiceBrowserDelegate */
}
