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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NetworkExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NWTCPConnectionAuthenticationDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NWTCPConnectionAuthenticationDelegate", WrapperType = typeof (NWTcpConnectionAuthenticationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProvideIdentity", Selector = "shouldProvideIdentityForConnection:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NWTcpConnection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProvideIdentity", Selector = "provideIdentityForConnection:completionHandler:", ParameterType = new Type [] { typeof (NWTcpConnection), typeof (global::System.Action<global::Security.SecIdentity, NSArray>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V86) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEvaluateTrust", Selector = "shouldEvaluateTrustForConnection:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NWTcpConnection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EvaluateTrust", Selector = "evaluateTrustForConnection:peerCertificateChain:completionHandler:", ParameterType = new Type [] { typeof (NWTcpConnection), typeof (NSArray), typeof (global::System.Action<global::Security.SecTrust>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V65) })]
	public partial interface INWTcpConnectionAuthenticationDelegate : INativeObject, IDisposable
	{
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should provide identity information.</summary><returns><see langword="true" /> to indicate that the delegate will provide identity information.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldProvideIdentityForConnection:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideIdentity (NWTcpConnection connection)
		{
			return _ShouldProvideIdentity (this, connection);
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should provide identity information.</summary><returns><see langword="true" /> to indicate that the delegate will provide identity information.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProvideIdentity (INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldProvideIdentityForConnection:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="completion">To be added.</param><summary>Method that is called to provide an identity and an optional certificate.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("provideIdentityForConnection:completionHandler:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProvideIdentity (NWTcpConnection connection, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V86))]global::System.Action<global::Security.SecIdentity, NSArray> completion)
		{
			_ProvideIdentity (this, connection, completion);
		}
		/// <param name="connection">To be added.</param><param name="completion">To be added.</param><summary>Method that is called to provide an identity and an optional certificate.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ProvideIdentity (INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V86))]global::System.Action<global::Security.SecIdentity, NSArray> completion)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V86.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provideIdentityForConnection:completionHandler:"), connection__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should evaluate trust.</summary><returns><see langword="true" /> to indicate that the delegate will evaluate trust.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldEvaluateTrustForConnection:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEvaluateTrust (NWTcpConnection connection)
		{
			return _ShouldEvaluateTrust (this, connection);
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should evaluate trust.</summary><returns><see langword="true" /> to indicate that the delegate will evaluate trust.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEvaluateTrust (INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldEvaluateTrustForConnection:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="peerCertificateChain">To be added.</param><param name="completion">To be added.</param><summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("evaluateTrustForConnection:peerCertificateChain:completionHandler:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateTrust (NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V65))]global::System.Action<global::Security.SecTrust> completion)
		{
			_EvaluateTrust (this, connection, peerCertificateChain, completion);
		}
		/// <param name="connection">To be added.</param>
		/// <param name="peerCertificateChain">To be added.</param>
		/// <summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous EvaluateTrust operation.  The value of the TResult parameter is of type System.Action&lt;Security.SecTrust&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The EvaluateTrustAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::Security.SecTrust> EvaluateTrustAsync (NWTcpConnection connection, NSArray peerCertificateChain)
		{
			var tcs = new TaskCompletionSource<global::Security.SecTrust> ();
			EvaluateTrust(connection, peerCertificateChain, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="connection">To be added.</param><param name="peerCertificateChain">To be added.</param><param name="completion">To be added.</param><summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _EvaluateTrust (INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V65))]global::System.Action<global::Security.SecTrust> completion)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var peerCertificateChain__handle__ = peerCertificateChain!.GetNonNullHandle (nameof (peerCertificateChain));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V65.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("evaluateTrustForConnection:peerCertificateChain:completionHandler:"), connection__handle__, peerCertificateChain__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (peerCertificateChain);
		}
		[DynamicDependencyAttribute ("EvaluateTrust(NetworkExtension.NWTcpConnection,Foundation.NSArray,System.Action{Security.SecTrust})")]
		[DynamicDependencyAttribute ("ProvideIdentity(NetworkExtension.NWTcpConnection,System.Action{Security.SecIdentity,Foundation.NSArray})")]
		[DynamicDependencyAttribute ("ShouldEvaluateTrust(NetworkExtension.NWTcpConnection)")]
		[DynamicDependencyAttribute ("ShouldProvideIdentity(NetworkExtension.NWTcpConnection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NWTcpConnectionAuthenticationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INWTcpConnectionAuthenticationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INWTcpConnectionAuthenticationDelegate" /> interface to support all the methods from the NWTCPConnectionAuthenticationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INWTcpConnectionAuthenticationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NWTCPConnectionAuthenticationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NWTcpConnectionAuthenticationDelegate_Extensions {
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should provide identity information.</summary><returns><see langword="true" /> to indicate that the delegate will provide identity information.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProvideIdentity (this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldProvideIdentityForConnection:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="completion">To be added.</param><summary>Method that is called to provide an identity and an optional certificate.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ProvideIdentity (this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V86))]global::System.Action<global::Security.SecIdentity, NSArray> completion)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V86.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("provideIdentityForConnection:completionHandler:"), connection__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should evaluate trust.</summary><returns><see langword="true" /> to indicate that the delegate will evaluate trust.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEvaluateTrust (this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("shouldEvaluateTrustForConnection:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="peerCertificateChain">To be added.</param><param name="completion">To be added.</param><summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EvaluateTrust (this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V65))]global::System.Action<global::Security.SecTrust> completion)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var peerCertificateChain__handle__ = peerCertificateChain!.GetNonNullHandle (nameof (peerCertificateChain));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V65.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("evaluateTrustForConnection:peerCertificateChain:completionHandler:"), connection__handle__, peerCertificateChain__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (peerCertificateChain);
		}
		/// <param name="connection">To be added.</param>
		/// <param name="peerCertificateChain">To be added.</param>
		/// <summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous EvaluateTrust operation.  The value of the TResult parameter is of type System.Action&lt;Security.SecTrust&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The EvaluateTrustAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<global::Security.SecTrust> EvaluateTrustAsync (this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, NSArray peerCertificateChain)
		{
			var tcs = new TaskCompletionSource<global::Security.SecTrust> ();
			This.EvaluateTrust(connection, peerCertificateChain, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NWTcpConnectionAuthenticationDelegateWrapper : BaseWrapper, INWTcpConnectionAuthenticationDelegate {
		public NWTcpConnectionAuthenticationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NWTcpConnectionAuthenticationDelegateWrapper))]
		static NWTcpConnectionAuthenticationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace NetworkExtension {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INWTcpConnectionAuthenticationDelegate" /> (for the protocol <c>NWTCPConnectionAuthenticationDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INWTcpConnectionAuthenticationDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__NetworkExtension_NWTcpConnectionAuthenticationDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions' instead.")]
	[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NWTcpConnectionAuthenticationDelegate : NSObject, INWTcpConnectionAuthenticationDelegate {
		/// <summary>Creates a new <see cref="NWTcpConnectionAuthenticationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NWTcpConnectionAuthenticationDelegate () : base (NSObjectFlag.Empty)
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
		protected NWTcpConnectionAuthenticationDelegate (NSObjectFlag t) : base (t)
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
		protected internal NWTcpConnectionAuthenticationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="connection">To be added.</param><param name="peerCertificateChain">To be added.</param><param name="completion">To be added.</param><summary>When implemented by the developer, overrides the default trust evaluation and runs a completion handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[Export ("evaluateTrustForConnection:peerCertificateChain:completionHandler:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateTrust (NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V65))]global::System.Action<global::Security.SecTrust> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="completion">To be added.</param><summary>Method that is called to provide an identity and an optional certificate.</summary><remarks>To be added.</remarks>
		[Export ("provideIdentityForConnection:completionHandler:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProvideIdentity (NWTcpConnection connection, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V86))]global::System.Action<global::Security.SecIdentity, NSArray> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should evaluate trust.</summary><returns><see langword="true" /> to indicate that the delegate will evaluate trust.</returns><remarks>To be added.</remarks>
		[Export ("shouldEvaluateTrustForConnection:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetVerifyBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEvaluateTrust (NWTcpConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><summary>Method that is called to inform the delegate that it should provide identity information.</summary><returns><see langword="true" /> to indicate that the delegate will provide identity information.</returns><remarks>To be added.</remarks>
		[Export ("shouldProvideIdentityForConnection:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'Security.SecProtocolOptions.SetChallengeBlock' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProvideIdentity (NWTcpConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NWTcpConnectionAuthenticationDelegate */
}
