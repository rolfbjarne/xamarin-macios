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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>A delegate object that allows the application developer to respond to events in a <see cref="T:AVFoundation.AVCaptureFileOutput" /> object.</summary><remarks><para>As with many AV Foundation methods, starting, stop, and pause commands are asynchronous, and it is only here, in the delegate object, that one can rely on the state of the underlying capture.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureFileOutputRecordingDelegate_Protocol/index.html">Apple documentation for <c>AVCaptureFileOutputRecordingDelegate</c></related>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVCaptureFileOutputRecordingDelegate", WrapperType = typeof (AVCaptureFileOutputRecordingDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartRecording", Selector = "captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type [] { typeof (AVCaptureFileOutput), typeof (NSUrl), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartRecording", Selector = "captureOutput:didStartRecordingToOutputFileAtURL:startPTS:fromConnections:", ParameterType = new Type [] { typeof (AVCaptureFileOutput), typeof (NSUrl), typeof (CMTime), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedRecording", Selector = "captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:", ParameterType = new Type [] { typeof (AVCaptureFileOutput), typeof (NSUrl), typeof (NSObject[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseRecording", Selector = "captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type [] { typeof (AVCaptureFileOutput), typeof (NSUrl), typeof (AVCaptureConnection[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResumeRecording", Selector = "captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:", ParameterType = new Type [] { typeof (AVCaptureFileOutput), typeof (NSUrl), typeof (AVCaptureConnection[]) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVCaptureFileOutputRecordingDelegate : INativeObject, IDisposable
	{
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
		{
			_DidStartRecording (this, captureOutput, outputFileUrl, connections);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartRecording (IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didStartRecordingToOutputFileAtURL:startPTS:fromConnections:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime startPts, NSObject[] connections)
		{
			_DidStartRecording (this, captureOutput, outputFileUrl, startPts, connections);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartRecording (IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime startPts, NSObject[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didStartRecordingToOutputFileAtURL:startPTS:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, startPts, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedRecording (IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			var error__handle__ = error.GetHandle ();
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (error);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			_DidPauseRecording (this, captureOutput, outputFileUrl, connections);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPauseRecording (IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResumeRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			_DidResumeRecording (this, captureOutput, outputFileUrl, connections);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResumeRecording (IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		[DynamicDependencyAttribute ("DidPauseRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,AVFoundation.AVCaptureConnection[])")]
		[DynamicDependencyAttribute ("DidResumeRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,AVFoundation.AVCaptureConnection[])")]
		[DynamicDependencyAttribute ("DidStartRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,CoreMedia.CMTime,Foundation.NSObject[])")]
		[DynamicDependencyAttribute ("DidStartRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,Foundation.NSObject[])")]
		[DynamicDependencyAttribute ("FinishedRecording(AVFoundation.AVCaptureFileOutput,Foundation.NSUrl,Foundation.NSObject[],Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureFileOutputRecordingDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCaptureFileOutputRecordingDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCaptureFileOutputRecordingDelegate" /> interface to support all the methods from the AVCaptureFileOutputRecordingDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCaptureFileOutputRecordingDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCaptureFileOutputRecordingDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCaptureFileOutputRecordingDelegate_Extensions {
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartRecording (this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStartRecording (this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime startPts, NSObject[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didStartRecordingToOutputFileAtURL:startPTS:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, startPts, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPauseRecording (this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidResumeRecording (this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCaptureFileOutputRecordingDelegateWrapper : BaseWrapper, IAVCaptureFileOutputRecordingDelegate {
		public AVCaptureFileOutputRecordingDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureFileOutputRecordingDelegateWrapper))]
		static AVCaptureFileOutputRecordingDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishedRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			if (connections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (connections));
			var error__handle__ = error.GetHandle ();
			using var nsa_connections = NSArray.FromNSObjects (connections);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:"), captureOutput__handle__, outputFileUrl__handle__, nsa_connections.Handle, error__handle__);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (error);
		}
	}
}
namespace AVFoundation {
	/// <summary>A delegate object that allows the application developer to respond to events in a <see cref="T:AVFoundation.AVCaptureFileOutput" /> object.</summary><remarks><para>As with many AV Foundation methods, starting, stop, and pause commands are asynchronous, and it is only here, in the delegate object, that one can rely on the state of the underlying capture.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVCaptureFileOutputRecordingDelegate_Protocol/index.html">Apple documentation for <c>AVCaptureFileOutputRecordingDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVCaptureFileOutputRecordingDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class AVCaptureFileOutputRecordingDelegate : NSObject, IAVCaptureFileOutputRecordingDelegate {
		/// <summary>Creates a new <see cref="AVCaptureFileOutputRecordingDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVCaptureFileOutputRecordingDelegate () : base (NSObjectFlag.Empty)
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
		protected AVCaptureFileOutputRecordingDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureFileOutputRecordingDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResumeRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("captureOutput:didStartRecordingToOutputFileAtURL:startPTS:fromConnections:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime startPts, NSObject[] connections)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="connections">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedRecording (AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCaptureFileOutputRecordingDelegate */
}
