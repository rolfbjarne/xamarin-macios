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
	/// <summary>This interface represents the Objective-C protocol <c>NSNetServiceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSNetServiceDelegate", WrapperType = typeof (NSNetServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPublish", Selector = "netServiceWillPublish:", ParameterType = new Type [] { typeof (NSNetService) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Published", Selector = "netServiceDidPublish:", ParameterType = new Type [] { typeof (NSNetService) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PublishFailure", Selector = "netService:didNotPublish:", ParameterType = new Type [] { typeof (NSNetService), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResolve", Selector = "netServiceWillResolve:", ParameterType = new Type [] { typeof (NSNetService) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddressResolved", Selector = "netServiceDidResolveAddress:", ParameterType = new Type [] { typeof (NSNetService) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveFailure", Selector = "netService:didNotResolve:", ParameterType = new Type [] { typeof (NSNetService), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Stopped", Selector = "netServiceDidStop:", ParameterType = new Type [] { typeof (NSNetService) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedTxtRecordData", Selector = "netService:didUpdateTXTRecordData:", ParameterType = new Type [] { typeof (NSNetService), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAcceptConnection", Selector = "netService:didAcceptConnectionWithInputStream:outputStream:", ParameterType = new Type [] { typeof (NSNetService), typeof (NSInputStream), typeof (NSOutputStream) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSNetServiceDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceWillPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPublish (NSNetService sender)
		{
			_WillPublish (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPublish (INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceWillPublish:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceDidPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Published (NSNetService sender)
		{
			_Published (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Published (INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidPublish:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netService:didNotPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PublishFailure (NSNetService sender, NSDictionary errors)
		{
			_PublishFailure (this, sender, errors);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PublishFailure (INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didNotPublish:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceWillResolve:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResolve (NSNetService sender)
		{
			_WillResolve (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillResolve (INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceWillResolve:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceDidResolveAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddressResolved (NSNetService sender)
		{
			_AddressResolved (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddressResolved (INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidResolveAddress:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netService:didNotResolve:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResolveFailure (NSNetService sender, NSDictionary errors)
		{
			_ResolveFailure (this, sender, errors);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResolveFailure (INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didNotResolve:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netServiceDidStop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (NSNetService sender)
		{
			_Stopped (this, sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Stopped (INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidStop:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netService:didUpdateTXTRecordData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedTxtRecordData (NSNetService sender, NSData data)
		{
			_UpdatedTxtRecordData (this, sender, data);
		}
		/// <param name="sender">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdatedTxtRecordData (INSNetServiceDelegate This, NSNetService sender, NSData data)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didUpdateTXTRecordData:"), sender__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (data);
		}
		/// <param name="sender">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("netService:didAcceptConnectionWithInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAcceptConnection (NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
		{
			_DidAcceptConnection (this, sender, inputStream, outputStream);
		}
		/// <param name="sender">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAcceptConnection (INSNetServiceDelegate This, NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didAcceptConnectionWithInputStream:outputStream:"), sender__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
		[DynamicDependencyAttribute ("AddressResolved(Foundation.NSNetService)")]
		[DynamicDependencyAttribute ("DidAcceptConnection(Foundation.NSNetService,Foundation.NSInputStream,Foundation.NSOutputStream)")]
		[DynamicDependencyAttribute ("Published(Foundation.NSNetService)")]
		[DynamicDependencyAttribute ("PublishFailure(Foundation.NSNetService,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("ResolveFailure(Foundation.NSNetService,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("Stopped(Foundation.NSNetService)")]
		[DynamicDependencyAttribute ("UpdatedTxtRecordData(Foundation.NSNetService,Foundation.NSData)")]
		[DynamicDependencyAttribute ("WillPublish(Foundation.NSNetService)")]
		[DynamicDependencyAttribute ("WillResolve(Foundation.NSNetService)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSNetServiceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSNetServiceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSNetServiceDelegate" /> interface to support all the methods from the NSNetServiceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSNetServiceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSNetServiceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSNetServiceDelegate_Extensions {
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPublish (this INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceWillPublish:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Published (this INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidPublish:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PublishFailure (this INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didNotPublish:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillResolve (this INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceWillResolve:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddressResolved (this INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidResolveAddress:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResolveFailure (this INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var errors__handle__ = errors!.GetNonNullHandle (nameof (errors));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didNotResolve:"), sender__handle__, errors__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (errors);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Stopped (this INSNetServiceDelegate This, NSNetService sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("netServiceDidStop:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdatedTxtRecordData (this INSNetServiceDelegate This, NSNetService sender, NSData data)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didUpdateTXTRecordData:"), sender__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (data);
		}
		/// <param name="sender">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAcceptConnection (this INSNetServiceDelegate This, NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("netService:didAcceptConnectionWithInputStream:outputStream:"), sender__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSNetServiceDelegateWrapper : BaseWrapper, INSNetServiceDelegate {
		public NSNetServiceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSNetServiceDelegateWrapper))]
		static NSNetServiceDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSNetServiceDelegate" /> (for the protocol <c>NSNetServiceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSNetServiceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSNetServiceDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSNetServiceDelegate : NSObject, INSNetServiceDelegate {
		/// <summary>Creates a new <see cref="NSNetServiceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSNetServiceDelegate () : base (NSObjectFlag.Empty)
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
		protected NSNetServiceDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSNetServiceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceDidResolveAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddressResolved (NSNetService sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netService:didAcceptConnectionWithInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAcceptConnection (NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netService:didNotPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PublishFailure (NSNetService sender, NSDictionary errors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceDidPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Published (NSNetService sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="errors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netService:didNotResolve:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResolveFailure (NSNetService sender, NSDictionary errors)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceDidStop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (NSNetService sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netService:didUpdateTXTRecordData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdatedTxtRecordData (NSNetService sender, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceWillPublish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPublish (NSNetService sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("netServiceWillResolve:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResolve (NSNetService sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSNetServiceDelegate */
}
