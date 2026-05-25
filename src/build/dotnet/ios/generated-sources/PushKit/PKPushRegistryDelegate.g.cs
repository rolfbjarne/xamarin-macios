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
namespace PushKit {
	#pragma warning disable CS1573
	/// <summary>Completion handler for registering a push operation.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PushKit/Reference/PKPushRegistryDelegate_Protocol/index.html">Apple documentation for <c>PKPushRegistryDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PKPushRegistryDelegate", WrapperType = typeof (PKPushRegistryDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdatePushCredentials", Selector = "pushRegistry:didUpdatePushCredentials:forType:", ParameterType = new Type [] { typeof (PushKit.PKPushRegistry), typeof (PushKit.PKPushCredentials), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveIncomingPush", Selector = "pushRegistry:didReceiveIncomingPushWithPayload:forType:", ParameterType = new Type [] { typeof (PushKit.PKPushRegistry), typeof (PushKit.PKPushPayload), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveIncomingPush", Selector = "pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:", ParameterType = new Type [] { typeof (PushKit.PKPushRegistry), typeof (PushKit.PKPushPayload), typeof (string), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveIncomingVoIPPush", Selector = "pushRegistry:didReceiveIncomingVoIPPushWithPayload:metadata:withCompletionHandler:", ParameterType = new Type [] { typeof (PushKit.PKPushRegistry), typeof (PushKit.PKPushPayload), typeof (PushKit.PKVoIPPushMetadata), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidInvalidatePushToken", Selector = "pushRegistry:didInvalidatePushTokenForType:", ParameterType = new Type [] { typeof (PushKit.PKPushRegistry), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IPKPushRegistryDelegate : INativeObject, IDisposable
	{
		/// <param name="registry">To be added.</param><param name="credentials">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("pushRegistry:didUpdatePushCredentials:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePushCredentials (PKPushRegistry registry, PKPushCredentials credentials, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="registry">To be added.</param><param name="credentials">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdatePushCredentials (IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushCredentials credentials, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var credentials__handle__ = credentials!.GetNonNullHandle (nameof (credentials));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didUpdatePushCredentials:forType:"), registry__handle__, credentials__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (credentials);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pushRegistry:didReceiveIncomingPushWithPayload:forType:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveIncomingPush (PKPushRegistry registry, PKPushPayload payload, string type)
		{
			_DidReceiveIncomingPush (this, registry, payload, type);
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveIncomingPush (IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingPushWithPayload:forType:"), registry__handle__, payload__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveIncomingPush (PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			_DidReceiveIncomingPush (this, registry, payload, type, completion);
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveIncomingPush (IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nstype = CFString.CreateNative (type);
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:"), registry__handle__, payload__handle__, nstype, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			CFString.ReleaseNative (nstype);
		}
		/// <summary>Tells the delegate that a VoIP push notification arrived with metadata.</summary><param name="registry">The push registry that received the notification.</param><param name="payload">The push payload for the notification.</param><param name="metadata">The metadata associated with the VoIP push notification.</param><param name="completion">The completion handler to call when you finish processing the notification.</param>
		[global::Foundation.OptionalMember]
		[Export ("pushRegistry:didReceiveIncomingVoIPPushWithPayload:metadata:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveIncomingVoIPPush (PKPushRegistry registry, PKPushPayload payload, PKVoIPPushMetadata metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			_DidReceiveIncomingVoIPPush (this, registry, payload, metadata, completion);
		}
		/// <summary>Tells the delegate that a VoIP push notification arrived with metadata.</summary><param name="registry">The push registry that received the notification.</param><param name="payload">The push payload for the notification.</param><param name="metadata">The metadata associated with the VoIP push notification.</param><param name="completion">The completion handler to call when you finish processing the notification.</param>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveIncomingVoIPPush (IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, PKVoIPPushMetadata metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingVoIPPushWithPayload:metadata:withCompletionHandler:"), registry__handle__, payload__handle__, metadata__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			GC.KeepAlive (metadata);
		}
		/// <param name="registry">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pushRegistry:didInvalidatePushTokenForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidatePushToken (PKPushRegistry registry, string type)
		{
			_DidInvalidatePushToken (this, registry, type);
		}
		/// <param name="registry">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidInvalidatePushToken (IPKPushRegistryDelegate This, PKPushRegistry registry, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didInvalidatePushTokenForType:"), registry__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			CFString.ReleaseNative (nstype);
		}
		[DynamicDependencyAttribute ("DidInvalidatePushToken(PushKit.PKPushRegistry,System.String)")]
		[DynamicDependencyAttribute ("DidReceiveIncomingPush(PushKit.PKPushRegistry,PushKit.PKPushPayload,System.String,System.Action)")]
		[DynamicDependencyAttribute ("DidReceiveIncomingPush(PushKit.PKPushRegistry,PushKit.PKPushPayload,System.String)")]
		[DynamicDependencyAttribute ("DidReceiveIncomingVoIPPush(PushKit.PKPushRegistry,PushKit.PKPushPayload,PushKit.PKVoIPPushMetadata,System.Action)")]
		[DynamicDependencyAttribute ("DidUpdatePushCredentials(PushKit.PKPushRegistry,PushKit.PKPushCredentials,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPushRegistryDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKPushRegistryDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPKPushRegistryDelegate" /> interface to support all the methods from the PKPushRegistryDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPKPushRegistryDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PKPushRegistryDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PKPushRegistryDelegate_Extensions {
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveIncomingPush (this IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingPushWithPayload:forType:"), registry__handle__, payload__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveIncomingPush (this IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nstype = CFString.CreateNative (type);
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:"), registry__handle__, payload__handle__, nstype, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			CFString.ReleaseNative (nstype);
		}
		/// <summary>Tells the delegate that a VoIP push notification arrived with metadata.</summary><param name="registry">The push registry that received the notification.</param><param name="payload">The push payload for the notification.</param><param name="metadata">The metadata associated with the VoIP push notification.</param><param name="completion">The completion handler to call when you finish processing the notification.</param>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveIncomingVoIPPush (this IPKPushRegistryDelegate This, PKPushRegistry registry, PKPushPayload payload, PKVoIPPushMetadata metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			var metadata__handle__ = metadata!.GetNonNullHandle (nameof (metadata));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didReceiveIncomingVoIPPushWithPayload:metadata:withCompletionHandler:"), registry__handle__, payload__handle__, metadata__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			GC.KeepAlive (payload);
			GC.KeepAlive (metadata);
		}
		/// <param name="registry">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidInvalidatePushToken (this IPKPushRegistryDelegate This, PKPushRegistry registry, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushRegistry:didInvalidatePushTokenForType:"), registry__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (registry);
			CFString.ReleaseNative (nstype);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKPushRegistryDelegateWrapper : BaseWrapper, IPKPushRegistryDelegate {
		public PKPushRegistryDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKPushRegistryDelegateWrapper))]
		static PKPushRegistryDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="registry">To be added.</param><param name="credentials">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushRegistry:didUpdatePushCredentials:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidUpdatePushCredentials (PKPushRegistry registry, PKPushCredentials credentials, string type)
		{
			var registry__handle__ = registry!.GetNonNullHandle (nameof (registry));
			var credentials__handle__ = credentials!.GetNonNullHandle (nameof (credentials));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pushRegistry:didUpdatePushCredentials:forType:"), registry__handle__, credentials__handle__, nstype);
			GC.KeepAlive (registry);
			GC.KeepAlive (credentials);
			CFString.ReleaseNative (nstype);
		}
	}
}
namespace PushKit {
	/// <summary>Completion handler for registering a push operation.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PushKit/Reference/PKPushRegistryDelegate_Protocol/index.html">Apple documentation for <c>PKPushRegistryDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__PushKit_PKPushRegistryDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class PKPushRegistryDelegate : NSObject, IPKPushRegistryDelegate {
		/// <summary>Creates a new <see cref="PKPushRegistryDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKPushRegistryDelegate () : base (NSObjectFlag.Empty)
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
		protected PKPushRegistryDelegate (NSObjectFlag t) : base (t)
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
		protected internal PKPushRegistryDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="registry">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushRegistry:didInvalidatePushTokenForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidatePushToken (PKPushRegistry registry, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.</summary><remarks>To be added.</remarks>
		[Export ("pushRegistry:didReceiveIncomingPushWithPayload:forType:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios11.0", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'DidReceiveIncomingPushWithPayload' overload accepting an 'Action' argument instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveIncomingPush (PKPushRegistry registry, PKPushPayload payload, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="registry">To be added.</param><param name="payload">To be added.</param><param name="type">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveIncomingPush (PKPushRegistry registry, PKPushPayload payload, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Tells the delegate that a VoIP push notification arrived with metadata.</summary><param name="registry">The push registry that received the notification.</param><param name="payload">The push payload for the notification.</param><param name="metadata">The metadata associated with the VoIP push notification.</param><param name="completion">The completion handler to call when you finish processing the notification.</param>
		[Export ("pushRegistry:didReceiveIncomingVoIPPushWithPayload:metadata:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveIncomingVoIPPush (PKPushRegistry registry, PKPushPayload payload, PKVoIPPushMetadata metadata, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="registry">To be added.</param><param name="credentials">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushRegistry:didUpdatePushCredentials:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePushCredentials (PKPushRegistry registry, PKPushCredentials credentials, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKPushRegistryDelegate */
}
