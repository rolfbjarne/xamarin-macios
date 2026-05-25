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
namespace VideoSubscriberAccount {
	#pragma warning disable CS1573
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmanagerdelegate">Apple documentation for <c>VSAccountManagerDelegate</c></related>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "VSAccountManagerDelegate", WrapperType = typeof (VSAccountManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAuthenticateAccountProvider", Selector = "accountManager:shouldAuthenticateAccountProviderWithIdentifier:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (VideoSubscriberAccount.VSAccountManager), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IVSAccountManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="accountManager">To be added.</param><param name="accountProviderIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accountManager:shouldAuthenticateAccountProviderWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAuthenticateAccountProvider (VSAccountManager accountManager, string accountProviderIdentifier)
		{
			return _ShouldAuthenticateAccountProvider (this, accountManager, accountProviderIdentifier);
		}
		/// <param name="accountManager">To be added.</param><param name="accountProviderIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAuthenticateAccountProvider (IVSAccountManagerDelegate This, VSAccountManager accountManager, string accountProviderIdentifier)
		{
			var accountManager__handle__ = accountManager!.GetNonNullHandle (nameof (accountManager));
			if (accountProviderIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountProviderIdentifier));
			var nsaccountProviderIdentifier = CFString.CreateNative (accountProviderIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountManager:shouldAuthenticateAccountProviderWithIdentifier:"), accountManager__handle__, nsaccountProviderIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (accountManager);
			CFString.ReleaseNative (nsaccountProviderIdentifier);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldAuthenticateAccountProvider(VideoSubscriberAccount.VSAccountManager,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VSAccountManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVSAccountManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IVSAccountManagerDelegate" /> interface to support all the methods from the VSAccountManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IVSAccountManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original VSAccountManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class VSAccountManagerDelegate_Extensions {
		/// <param name="accountManager">To be added.</param><param name="accountProviderIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAuthenticateAccountProvider (this IVSAccountManagerDelegate This, VSAccountManager accountManager, string accountProviderIdentifier)
		{
			var accountManager__handle__ = accountManager!.GetNonNullHandle (nameof (accountManager));
			if (accountProviderIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountProviderIdentifier));
			var nsaccountProviderIdentifier = CFString.CreateNative (accountProviderIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("accountManager:shouldAuthenticateAccountProviderWithIdentifier:"), accountManager__handle__, nsaccountProviderIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (accountManager);
			CFString.ReleaseNative (nsaccountProviderIdentifier);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VSAccountManagerDelegateWrapper : BaseWrapper, IVSAccountManagerDelegate {
		public VSAccountManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VSAccountManagerDelegateWrapper))]
		static VSAccountManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace VideoSubscriberAccount {
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmanagerdelegate">Apple documentation for <c>VSAccountManagerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__VideoSubscriberAccount_VSAccountManagerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class VSAccountManagerDelegate : NSObject, IVSAccountManagerDelegate {
		/// <summary>Creates a new <see cref="VSAccountManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public VSAccountManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected VSAccountManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal VSAccountManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="accountManager">To be added.</param><param name="accountProviderIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accountManager:shouldAuthenticateAccountProviderWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAuthenticateAccountProvider (VSAccountManager accountManager, string accountProviderIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class VSAccountManagerDelegate */
}
