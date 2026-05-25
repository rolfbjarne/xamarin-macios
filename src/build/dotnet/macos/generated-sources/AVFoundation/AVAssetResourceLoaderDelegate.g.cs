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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVAssetResourceLoaderDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVAssetResourceLoaderDelegate", WrapperType = typeof (AVAssetResourceLoaderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldWaitForLoadingOfRequestedResource", Selector = "resourceLoader:shouldWaitForLoadingOfRequestedResource:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVAssetResourceLoader), typeof (AVAssetResourceLoadingRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelLoadingRequest", Selector = "resourceLoader:didCancelLoadingRequest:", ParameterType = new Type [] { typeof (AVAssetResourceLoader), typeof (AVAssetResourceLoadingRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldWaitForResponseToAuthenticationChallenge", Selector = "resourceLoader:shouldWaitForResponseToAuthenticationChallenge:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVAssetResourceLoader), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelAuthenticationChallenge", Selector = "resourceLoader:didCancelAuthenticationChallenge:", ParameterType = new Type [] { typeof (AVAssetResourceLoader), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldWaitForRenewalOfRequestedResource", Selector = "resourceLoader:shouldWaitForRenewalOfRequestedResource:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVAssetResourceLoader), typeof (AVAssetResourceRenewalRequest) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVAssetResourceLoaderDelegate : INativeObject, IDisposable
	{
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resourceLoader:shouldWaitForLoadingOfRequestedResource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForLoadingOfRequestedResource (AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			return _ShouldWaitForLoadingOfRequestedResource (this, resourceLoader, loadingRequest);
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldWaitForLoadingOfRequestedResource (IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var loadingRequest__handle__ = loadingRequest!.GetNonNullHandle (nameof (loadingRequest));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForLoadingOfRequestedResource:"), resourceLoader__handle__, loadingRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (loadingRequest);
			return ret != 0;
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resourceLoader:didCancelLoadingRequest:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelLoadingRequest (AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			_DidCancelLoadingRequest (this, resourceLoader, loadingRequest);
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancelLoadingRequest (IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var loadingRequest__handle__ = loadingRequest!.GetNonNullHandle (nameof (loadingRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:didCancelLoadingRequest:"), resourceLoader__handle__, loadingRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (loadingRequest);
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForResponseToAuthenticationChallenge (AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			return _ShouldWaitForResponseToAuthenticationChallenge (this, resourceLoader, authenticationChallenge);
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldWaitForResponseToAuthenticationChallenge (IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var authenticationChallenge__handle__ = authenticationChallenge!.GetNonNullHandle (nameof (authenticationChallenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:"), resourceLoader__handle__, authenticationChallenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (authenticationChallenge);
			return ret != 0;
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resourceLoader:didCancelAuthenticationChallenge:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelAuthenticationChallenge (AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			_DidCancelAuthenticationChallenge (this, resourceLoader, authenticationChallenge);
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCancelAuthenticationChallenge (IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var authenticationChallenge__handle__ = authenticationChallenge!.GetNonNullHandle (nameof (authenticationChallenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:didCancelAuthenticationChallenge:"), resourceLoader__handle__, authenticationChallenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (authenticationChallenge);
		}
		/// <param name="resourceLoader">To be added.</param><param name="renewalRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resourceLoader:shouldWaitForRenewalOfRequestedResource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForRenewalOfRequestedResource (AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
		{
			return _ShouldWaitForRenewalOfRequestedResource (this, resourceLoader, renewalRequest);
		}
		/// <param name="resourceLoader">To be added.</param><param name="renewalRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldWaitForRenewalOfRequestedResource (IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var renewalRequest__handle__ = renewalRequest!.GetNonNullHandle (nameof (renewalRequest));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForRenewalOfRequestedResource:"), resourceLoader__handle__, renewalRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (renewalRequest);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidCancelAuthenticationChallenge(AVFoundation.AVAssetResourceLoader,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("DidCancelLoadingRequest(AVFoundation.AVAssetResourceLoader,AVFoundation.AVAssetResourceLoadingRequest)")]
		[DynamicDependencyAttribute ("ShouldWaitForLoadingOfRequestedResource(AVFoundation.AVAssetResourceLoader,AVFoundation.AVAssetResourceLoadingRequest)")]
		[DynamicDependencyAttribute ("ShouldWaitForRenewalOfRequestedResource(AVFoundation.AVAssetResourceLoader,AVFoundation.AVAssetResourceRenewalRequest)")]
		[DynamicDependencyAttribute ("ShouldWaitForResponseToAuthenticationChallenge(AVFoundation.AVAssetResourceLoader,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetResourceLoaderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAssetResourceLoaderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAssetResourceLoaderDelegate" /> interface to support all the methods from the AVAssetResourceLoaderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAssetResourceLoaderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAssetResourceLoaderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAssetResourceLoaderDelegate_Extensions {
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldWaitForLoadingOfRequestedResource (this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var loadingRequest__handle__ = loadingRequest!.GetNonNullHandle (nameof (loadingRequest));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForLoadingOfRequestedResource:"), resourceLoader__handle__, loadingRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (loadingRequest);
			return ret != 0;
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelLoadingRequest (this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var loadingRequest__handle__ = loadingRequest!.GetNonNullHandle (nameof (loadingRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:didCancelLoadingRequest:"), resourceLoader__handle__, loadingRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (loadingRequest);
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldWaitForResponseToAuthenticationChallenge (this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var authenticationChallenge__handle__ = authenticationChallenge!.GetNonNullHandle (nameof (authenticationChallenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:"), resourceLoader__handle__, authenticationChallenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (authenticationChallenge);
			return ret != 0;
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelAuthenticationChallenge (this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var authenticationChallenge__handle__ = authenticationChallenge!.GetNonNullHandle (nameof (authenticationChallenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:didCancelAuthenticationChallenge:"), resourceLoader__handle__, authenticationChallenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (authenticationChallenge);
		}
		/// <param name="resourceLoader">To be added.</param><param name="renewalRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldWaitForRenewalOfRequestedResource (this IAVAssetResourceLoaderDelegate This, AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
		{
			var resourceLoader__handle__ = resourceLoader!.GetNonNullHandle (nameof (resourceLoader));
			var renewalRequest__handle__ = renewalRequest!.GetNonNullHandle (nameof (renewalRequest));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resourceLoader:shouldWaitForRenewalOfRequestedResource:"), resourceLoader__handle__, renewalRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (resourceLoader);
			GC.KeepAlive (renewalRequest);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAssetResourceLoaderDelegateWrapper : BaseWrapper, IAVAssetResourceLoaderDelegate {
		public AVAssetResourceLoaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetResourceLoaderDelegateWrapper))]
		static AVAssetResourceLoaderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVAssetResourceLoaderDelegate" /> (for the protocol <c>AVAssetResourceLoaderDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVAssetResourceLoaderDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AVFoundation_AVAssetResourceLoaderDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAssetResourceLoaderDelegate : NSObject, IAVAssetResourceLoaderDelegate {
		/// <summary>Creates a new <see cref="AVAssetResourceLoaderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAssetResourceLoaderDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected AVAssetResourceLoaderDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVAssetResourceLoaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resourceLoader:didCancelAuthenticationChallenge:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelAuthenticationChallenge (AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resourceLoader:didCancelLoadingRequest:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelLoadingRequest (AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="resourceLoader">To be added.</param><param name="loadingRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resourceLoader:shouldWaitForLoadingOfRequestedResource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForLoadingOfRequestedResource (AVAssetResourceLoader resourceLoader, AVAssetResourceLoadingRequest loadingRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="resourceLoader">To be added.</param><param name="renewalRequest">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resourceLoader:shouldWaitForRenewalOfRequestedResource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForRenewalOfRequestedResource (AVAssetResourceLoader resourceLoader, AVAssetResourceRenewalRequest renewalRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="resourceLoader">To be added.</param><param name="authenticationChallenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resourceLoader:shouldWaitForResponseToAuthenticationChallenge:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldWaitForResponseToAuthenticationChallenge (AVAssetResourceLoader resourceLoader, NSUrlAuthenticationChallenge authenticationChallenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAssetResourceLoaderDelegate */
}
