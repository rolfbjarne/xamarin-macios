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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLConnectionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSURLConnectionDelegate", WrapperType = typeof (NSUrlConnectionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanAuthenticateAgainstProtectionSpace", Selector = "connection:canAuthenticateAgainstProtectionSpace:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlProtectionSpace) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "connection:didReceiveAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledAuthenticationChallenge", Selector = "connection:didCancelAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectionShouldUseCredentialStorage", Selector = "connectionShouldUseCredentialStorage:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrlConnection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "connection:didFailWithError:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequestForAuthenticationChallenge", Selector = "connection:willSendRequestForAuthenticationChallenge:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlAuthenticationChallenge) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSUrlConnectionDelegate : INativeObject, IDisposable
	{
		/// <param name="connection">To be added.</param><param name="protectionSpace">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'WillSendRequestForAuthenticationChallenge' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:canAuthenticateAgainstProtectionSpace:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAuthenticateAgainstProtectionSpace (NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
		{
			return _CanAuthenticateAgainstProtectionSpace (this, connection, protectionSpace);
		}
		/// <param name="connection">To be added.</param><param name="protectionSpace">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'WillSendRequestForAuthenticationChallenge' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanAuthenticateAgainstProtectionSpace (INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var protectionSpace__handle__ = protectionSpace!.GetNonNullHandle (nameof (protectionSpace));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:canAuthenticateAgainstProtectionSpace:"), connection__handle__, protectionSpace__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (protectionSpace);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didReceiveAuthenticationChallenge:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			_ReceivedAuthenticationChallenge (this, connection, challenge);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedAuthenticationChallenge (INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didCancelAuthenticationChallenge:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			_CanceledAuthenticationChallenge (this, connection, challenge);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CanceledAuthenticationChallenge (INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didCancelAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connectionShouldUseCredentialStorage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConnectionShouldUseCredentialStorage (NSUrlConnection connection)
		{
			return _ConnectionShouldUseCredentialStorage (this, connection);
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ConnectionShouldUseCredentialStorage (INSUrlConnectionDelegate This, NSUrlConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("connectionShouldUseCredentialStorage:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (NSUrlConnection connection, NSError error)
		{
			_FailedWithError (this, connection, error);
		}
		/// <param name="connection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedWithError (INSUrlConnectionDelegate This, NSUrlConnection connection, NSError error)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didFailWithError:"), connection__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (error);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:willSendRequestForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSendRequestForAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			_WillSendRequestForAuthenticationChallenge (this, connection, challenge);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSendRequestForAuthenticationChallenge (INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willSendRequestForAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
		[DynamicDependencyAttribute ("CanAuthenticateAgainstProtectionSpace(Foundation.NSUrlConnection,Foundation.NSUrlProtectionSpace)")]
		[DynamicDependencyAttribute ("CanceledAuthenticationChallenge(Foundation.NSUrlConnection,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("ConnectionShouldUseCredentialStorage(Foundation.NSUrlConnection)")]
		[DynamicDependencyAttribute ("FailedWithError(Foundation.NSUrlConnection,Foundation.NSError)")]
		[DynamicDependencyAttribute ("ReceivedAuthenticationChallenge(Foundation.NSUrlConnection,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute ("WillSendRequestForAuthenticationChallenge(Foundation.NSUrlConnection,Foundation.NSUrlAuthenticationChallenge)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlConnectionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlConnectionDelegate" /> interface to support all the methods from the NSURLConnectionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlConnectionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLConnectionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlConnectionDelegate_Extensions {
		/// <param name="connection">To be added.</param><param name="protectionSpace">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'WillSendRequestForAuthenticationChallenge' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanAuthenticateAgainstProtectionSpace (this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var protectionSpace__handle__ = protectionSpace!.GetNonNullHandle (nameof (protectionSpace));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:canAuthenticateAgainstProtectionSpace:"), connection__handle__, protectionSpace__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (protectionSpace);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedAuthenticationChallenge (this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CanceledAuthenticationChallenge (this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didCancelAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ConnectionShouldUseCredentialStorage (this INSUrlConnectionDelegate This, NSUrlConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("connectionShouldUseCredentialStorage:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedWithError (this INSUrlConnectionDelegate This, NSUrlConnection connection, NSError error)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didFailWithError:"), connection__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (error);
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSendRequestForAuthenticationChallenge (this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willSendRequestForAuthenticationChallenge:"), connection__handle__, challenge__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (challenge);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlConnectionDelegateWrapper : BaseWrapper, INSUrlConnectionDelegate {
		public NSUrlConnectionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDelegateWrapper))]
		static NSUrlConnectionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlConnectionDelegate" /> (for the protocol <c>NSURLConnectionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlConnectionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__Foundation_NSUrlConnectionDelegate", false)]
	[Model]
	public unsafe partial class NSUrlConnectionDelegate : NSObject, INSUrlConnectionDelegate {
		/// <summary>Creates a new <see cref="NSUrlConnectionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlConnectionDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlConnectionDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlConnectionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="connection">To be added.</param><param name="protectionSpace">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'WillSendRequestForAuthenticationChallenge' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:canAuthenticateAgainstProtectionSpace:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAuthenticateAgainstProtectionSpace (NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didCancelAuthenticationChallenge:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CanceledAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connectionShouldUseCredentialStorage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConnectionShouldUseCredentialStorage (NSUrlConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (NSUrlConnection connection, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didReceiveAuthenticationChallenge:")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:willSendRequestForAuthenticationChallenge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSendRequestForAuthenticationChallenge (NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlConnectionDelegate */
}
