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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameKit {
	#pragma warning disable CS1573
	/// <summary>A delegate object that allows the application developer fine-grained response to life-cycle events relating to <see cref="T:GameKit.GKChallenge" />s, such as receiving or completing a challenge.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GKChallengeEventHandlerDelegate_Ref/index.html">Apple documentation for <c>GKChallengeEventHandlerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[ObsoletedOSPlatform ("macos10.10", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "GKChallengeEventHandlerDelegate", WrapperType = typeof (GKChallengeEventHandlerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerSelectedChallenge", Selector = "localPlayerDidSelectChallenge:", ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForLocallyReceivedChallenge", Selector = "shouldShowBannerForLocallyReceivedChallenge:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerReceivedChallenge", Selector = "localPlayerDidReceiveChallenge:", ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForLocallyCompletedChallenge", Selector = "shouldShowBannerForLocallyCompletedChallenge:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerCompletedChallenge", Selector = "localPlayerDidCompleteChallenge:", ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForRemotelyCompletedChallenge", Selector = "shouldShowBannerForRemotelyCompletedChallenge:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemotePlayerCompletedChallenge", Selector = "remotePlayerDidCompleteChallenge:", ParameterType = new Type [] { typeof (GameKit.GKChallenge) }, ParameterByRef = new bool [] { false })]
	public partial interface IGKChallengeEventHandlerDelegate : INativeObject, IDisposable
	{
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("localPlayerDidSelectChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerSelectedChallenge (GKChallenge challenge)
		{
			_LocalPlayerSelectedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocalPlayerSelectedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidSelectChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldShowBannerForLocallyReceivedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForLocallyReceivedChallenge (GKChallenge challenge)
		{
			return _ShouldShowBannerForLocallyReceivedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowBannerForLocallyReceivedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForLocallyReceivedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("localPlayerDidReceiveChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerReceivedChallenge (GKChallenge challenge)
		{
			_LocalPlayerReceivedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocalPlayerReceivedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidReceiveChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldShowBannerForLocallyCompletedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForLocallyCompletedChallenge (GKChallenge challenge)
		{
			return _ShouldShowBannerForLocallyCompletedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowBannerForLocallyCompletedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForLocallyCompletedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("localPlayerDidCompleteChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerCompletedChallenge (GKChallenge challenge)
		{
			_LocalPlayerCompletedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LocalPlayerCompletedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidCompleteChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldShowBannerForRemotelyCompletedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForRemotelyCompletedChallenge (GKChallenge challenge)
		{
			return _ShouldShowBannerForRemotelyCompletedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowBannerForRemotelyCompletedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForRemotelyCompletedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("remotePlayerDidCompleteChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemotePlayerCompletedChallenge (GKChallenge challenge)
		{
			_RemotePlayerCompletedChallenge (this, challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemotePlayerCompletedChallenge (IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("remotePlayerDidCompleteChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		[DynamicDependencyAttribute ("LocalPlayerCompletedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("LocalPlayerReceivedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("LocalPlayerSelectedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("RemotePlayerCompletedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("ShouldShowBannerForLocallyCompletedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("ShouldShowBannerForLocallyReceivedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute ("ShouldShowBannerForRemotelyCompletedChallenge(GameKit.GKChallenge)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKChallengeEventHandlerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKChallengeEventHandlerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKChallengeEventHandlerDelegate" /> interface to support all the methods from the GKChallengeEventHandlerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKChallengeEventHandlerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKChallengeEventHandlerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKChallengeEventHandlerDelegate_Extensions {
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocalPlayerSelectedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidSelectChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowBannerForLocallyReceivedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForLocallyReceivedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocalPlayerReceivedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidReceiveChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowBannerForLocallyCompletedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForLocallyCompletedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LocalPlayerCompletedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localPlayerDidCompleteChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowBannerForRemotelyCompletedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldShowBannerForRemotelyCompletedChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
			return ret != 0;
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemotePlayerCompletedChallenge (this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("remotePlayerDidCompleteChallenge:"), challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (challenge);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKChallengeEventHandlerDelegateWrapper : BaseWrapper, IGKChallengeEventHandlerDelegate {
		public GKChallengeEventHandlerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKChallengeEventHandlerDelegateWrapper))]
		static GKChallengeEventHandlerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameKit {
	/// <summary>A delegate object that allows the application developer fine-grained response to life-cycle events relating to <see cref="T:GameKit.GKChallenge" />s, such as receiving or completing a challenge.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GLkit/Reference/GKChallengeEventHandlerDelegate_Ref/index.html">Apple documentation for <c>GKChallengeEventHandlerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__GameKit_GKChallengeEventHandlerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[ObsoletedOSPlatform ("macos10.10", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class GKChallengeEventHandlerDelegate : NSObject, IGKChallengeEventHandlerDelegate {
		/// <summary>Creates a new <see cref="GKChallengeEventHandlerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKChallengeEventHandlerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected GKChallengeEventHandlerDelegate (NSObjectFlag t) : base (t)
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
		protected internal GKChallengeEventHandlerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("localPlayerDidCompleteChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerCompletedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("localPlayerDidReceiveChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerReceivedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("localPlayerDidSelectChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalPlayerSelectedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("remotePlayerDidCompleteChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemotePlayerCompletedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldShowBannerForLocallyCompletedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForLocallyCompletedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldShowBannerForLocallyReceivedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForLocallyReceivedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="challenge">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldShowBannerForRemotelyCompletedChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowBannerForRemotelyCompletedChallenge (GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKChallengeEventHandlerDelegate */
}
