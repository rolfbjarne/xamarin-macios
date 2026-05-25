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
namespace PushToTalk {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PTChannelManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "PTChannelManagerDelegate", WrapperType = typeof (PTChannelManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidJoinChannel", Selector = "channelManager:didJoinChannelWithUUID:reason:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (PushToTalk.PTChannelJoinReason) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLeaveChannel", Selector = "channelManager:didLeaveChannelWithUUID:reason:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (PushToTalk.PTChannelLeaveReason) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidBeginTransmitting", Selector = "channelManager:channelUUID:didBeginTransmittingFromSource:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (PushToTalk.PTChannelTransmitRequestSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidEndTransmitting", Selector = "channelManager:channelUUID:didEndTransmittingFromSource:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (PushToTalk.PTChannelTransmitRequestSource) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedEphemeralPushToken", Selector = "channelManager:receivedEphemeralPushToken:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IncomingPushResult", Selector = "incomingPushResultForChannelManager:channelUUID:pushPayload:", ReturnType = typeof (PushToTalk.PTPushResult), ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidActivateAudioSession", Selector = "channelManager:didActivateAudioSession:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (AVAudioSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDeactivateAudioSession", Selector = "channelManager:didDeactivateAudioSession:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (AVAudioSession) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToJoinChannel", Selector = "channelManager:failedToJoinChannelWithUUID:error:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToLeaveChannel", Selector = "channelManager:failedToLeaveChannelWithUUID:error:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToBeginTransmittingInChannel", Selector = "channelManager:failedToBeginTransmittingInChannelWithUUID:error:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToStopTransmittingInChannel", Selector = "channelManager:failedToStopTransmittingInChannelWithUUID:error:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IncomingServiceUpdatePush", Selector = "incomingServiceUpdatePushForChannelManager:channelUUID:pushPayload:isHighPriority:remainingHighPriorityBudget:withCompletionHandler:", ParameterType = new Type [] { typeof (PushToTalk.PTChannelManager), typeof (NSUuid), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (bool), typeof (IntPtr), typeof (Action) }, ParameterByRef = new bool [] { false, false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IPTChannelManagerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("channelManager:didJoinChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidJoinChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelJoinReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidJoinChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, PTChannelJoinReason reason)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("channelManager:didJoinChannelWithUUID:reason:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:didLeaveChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLeaveChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelLeaveReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidLeaveChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, PTChannelLeaveReason reason)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("channelManager:didLeaveChannelWithUUID:reason:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:channelUUID:didBeginTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginTransmitting (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("channelManager:channelUUID:didBeginTransmittingFromSource:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) source);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:channelUUID:didEndTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndTransmitting (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("channelManager:channelUUID:didEndTransmittingFromSource:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) source);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:receivedEphemeralPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedEphemeralPushToken (PTChannelManager channelManager, NSData pushToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedEphemeralPushToken (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSData pushToken)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var pushToken__handle__ = pushToken!.GetNonNullHandle (nameof (pushToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:receivedEphemeralPushToken:"), channelManager__handle__, pushToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (pushToken);
		}
		[global::Foundation.RequiredMember]
		[Export ("incomingPushResultForChannelManager:channelUUID:pushPayload:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PTPushResult IncomingPushResult (PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PTPushResult _IncomingPushResult (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var pushPayload__handle__ = pushPayload!.GetNonNullHandle (nameof (pushPayload));
			PTPushResult? ret;
			ret =  Runtime.GetNSObject<PTPushResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("incomingPushResultForChannelManager:channelUUID:pushPayload:"), channelManager__handle__, channelUuid__handle__, pushPayload__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (pushPayload);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:didActivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidActivateAudioSession (IPTChannelManagerDelegate This, PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:didActivateAudioSession:"), channelManager__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (audioSession);
		}
		[global::Foundation.RequiredMember]
		[Export ("channelManager:didDeactivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDeactivateAudioSession (IPTChannelManagerDelegate This, PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:didDeactivateAudioSession:"), channelManager__handle__, audioSession__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (audioSession);
		}
		[global::Foundation.OptionalMember]
		[Export ("channelManager:failedToJoinChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToJoinChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			_FailedToJoinChannel (this, channelManager, channelUuid, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToJoinChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToJoinChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("channelManager:failedToLeaveChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToLeaveChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			_FailedToLeaveChannel (this, channelManager, channelUuid, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToLeaveChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToLeaveChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("channelManager:failedToBeginTransmittingInChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToBeginTransmittingInChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			_FailedToBeginTransmittingInChannel (this, channelManager, channelUuid, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToBeginTransmittingInChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToBeginTransmittingInChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("channelManager:failedToStopTransmittingInChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStopTransmittingInChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			_FailedToStopTransmittingInChannel (this, channelManager, channelUuid, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToStopTransmittingInChannel (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToStopTransmittingInChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("incomingServiceUpdatePushForChannelManager:channelUUID:pushPayload:isHighPriority:remainingHighPriorityBudget:withCompletionHandler:")]
		[SupportedOSPlatform ("ios17.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IncomingServiceUpdatePush (PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload, bool isHighPriority, nint remainingHighPriorityBudget, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			_IncomingServiceUpdatePush (this, channelManager, channelUuid, pushPayload, isHighPriority, remainingHighPriorityBudget, completion);
		}
		[SupportedOSPlatform ("ios17.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _IncomingServiceUpdatePush (IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload, bool isHighPriority, nint remainingHighPriorityBudget, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var pushPayload__handle__ = pushPayload!.GetNonNullHandle (nameof (pushPayload));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("incomingServiceUpdatePushForChannelManager:channelUUID:pushPayload:isHighPriority:remainingHighPriorityBudget:withCompletionHandler:"), channelManager__handle__, channelUuid__handle__, pushPayload__handle__, isHighPriority ? (byte) 1 : (byte) 0, remainingHighPriorityBudget, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (pushPayload);
		}
		[DynamicDependencyAttribute ("DidActivateAudioSession(PushToTalk.PTChannelManager,AVFoundation.AVAudioSession)")]
		[DynamicDependencyAttribute ("DidBeginTransmitting(PushToTalk.PTChannelManager,Foundation.NSUuid,PushToTalk.PTChannelTransmitRequestSource)")]
		[DynamicDependencyAttribute ("DidDeactivateAudioSession(PushToTalk.PTChannelManager,AVFoundation.AVAudioSession)")]
		[DynamicDependencyAttribute ("DidEndTransmitting(PushToTalk.PTChannelManager,Foundation.NSUuid,PushToTalk.PTChannelTransmitRequestSource)")]
		[DynamicDependencyAttribute ("DidJoinChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,PushToTalk.PTChannelJoinReason)")]
		[DynamicDependencyAttribute ("DidLeaveChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,PushToTalk.PTChannelLeaveReason)")]
		[DynamicDependencyAttribute ("FailedToBeginTransmittingInChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FailedToJoinChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FailedToLeaveChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FailedToStopTransmittingInChannel(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSError)")]
		[DynamicDependencyAttribute ("IncomingPushResult(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("IncomingServiceUpdatePush(PushToTalk.PTChannelManager,Foundation.NSUuid,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},System.Boolean,System.IntPtr,System.Action)")]
		[DynamicDependencyAttribute ("ReceivedEphemeralPushToken(PushToTalk.PTChannelManager,Foundation.NSData)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PTChannelManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPTChannelManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPTChannelManagerDelegate" /> interface to support all the methods from the PTChannelManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPTChannelManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PTChannelManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PTChannelManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToJoinChannel (this IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToJoinChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToLeaveChannel (this IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToLeaveChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToBeginTransmittingInChannel (this IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToBeginTransmittingInChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToStopTransmittingInChannel (this IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("channelManager:failedToStopTransmittingInChannelWithUUID:error:"), channelManager__handle__, channelUuid__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (error);
		}
		[SupportedOSPlatform ("ios17.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void IncomingServiceUpdatePush (this IPTChannelManagerDelegate This, PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload, bool isHighPriority, nint remainingHighPriorityBudget, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var pushPayload__handle__ = pushPayload!.GetNonNullHandle (nameof (pushPayload));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("incomingServiceUpdatePushForChannelManager:channelUUID:pushPayload:isHighPriority:remainingHighPriorityBudget:withCompletionHandler:"), channelManager__handle__, channelUuid__handle__, pushPayload__handle__, isHighPriority ? (byte) 1 : (byte) 0, remainingHighPriorityBudget, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (pushPayload);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PTChannelManagerDelegateWrapper : BaseWrapper, IPTChannelManagerDelegate {
		public PTChannelManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PTChannelManagerDelegateWrapper))]
		static PTChannelManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("channelManager:didJoinChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidJoinChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelJoinReason reason)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("channelManager:didJoinChannelWithUUID:reason:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[Export ("channelManager:didLeaveChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLeaveChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelLeaveReason reason)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("channelManager:didLeaveChannelWithUUID:reason:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[Export ("channelManager:channelUUID:didBeginTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidBeginTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("channelManager:channelUUID:didBeginTransmittingFromSource:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) source);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[Export ("channelManager:channelUUID:didEndTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidEndTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("channelManager:channelUUID:didEndTransmittingFromSource:"), channelManager__handle__, channelUuid__handle__, (IntPtr) (long) source);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
		}
		[Export ("channelManager:receivedEphemeralPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedEphemeralPushToken (PTChannelManager channelManager, NSData pushToken)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var pushToken__handle__ = pushToken!.GetNonNullHandle (nameof (pushToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("channelManager:receivedEphemeralPushToken:"), channelManager__handle__, pushToken__handle__);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (pushToken);
		}
		[Export ("incomingPushResultForChannelManager:channelUUID:pushPayload:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PTPushResult IncomingPushResult (PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var channelUuid__handle__ = channelUuid!.GetNonNullHandle (nameof (channelUuid));
			var pushPayload__handle__ = pushPayload!.GetNonNullHandle (nameof (pushPayload));
			PTPushResult? ret;
			ret =  Runtime.GetNSObject<PTPushResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("incomingPushResultForChannelManager:channelUUID:pushPayload:"), channelManager__handle__, channelUuid__handle__, pushPayload__handle__), false)!;
			GC.KeepAlive (channelManager);
			GC.KeepAlive (channelUuid);
			GC.KeepAlive (pushPayload);
			return ret!;
		}
		[Export ("channelManager:didActivateAudioSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidActivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("channelManager:didActivateAudioSession:"), channelManager__handle__, audioSession__handle__);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (audioSession);
		}
		[Export ("channelManager:didDeactivateAudioSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDeactivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			var channelManager__handle__ = channelManager!.GetNonNullHandle (nameof (channelManager));
			var audioSession__handle__ = audioSession!.GetNonNullHandle (nameof (audioSession));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("channelManager:didDeactivateAudioSession:"), channelManager__handle__, audioSession__handle__);
			GC.KeepAlive (channelManager);
			GC.KeepAlive (audioSession);
		}
	}
}
namespace PushToTalk {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IPTChannelManagerDelegate" /> (for the protocol <c>PTChannelManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IPTChannelManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__PushToTalk_PTChannelManagerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class PTChannelManagerDelegate : NSObject, IPTChannelManagerDelegate {
		/// <summary>Creates a new <see cref="PTChannelManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PTChannelManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected PTChannelManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal PTChannelManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("channelManager:didActivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:channelUUID:didBeginTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:didDeactivateAudioSession:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivateAudioSession (PTChannelManager channelManager, global::AVFoundation.AVAudioSession audioSession)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:channelUUID:didEndTransmittingFromSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndTransmitting (PTChannelManager channelManager, NSUuid channelUuid, PTChannelTransmitRequestSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:didJoinChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidJoinChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelJoinReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:didLeaveChannelWithUUID:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLeaveChannel (PTChannelManager channelManager, NSUuid channelUuid, PTChannelLeaveReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:failedToBeginTransmittingInChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToBeginTransmittingInChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:failedToJoinChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToJoinChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:failedToLeaveChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToLeaveChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:failedToStopTransmittingInChannelWithUUID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToStopTransmittingInChannel (PTChannelManager channelManager, NSUuid channelUuid, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("incomingPushResultForChannelManager:channelUUID:pushPayload:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PTPushResult IncomingPushResult (PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("incomingServiceUpdatePushForChannelManager:channelUUID:pushPayload:isHighPriority:remainingHighPriorityBudget:withCompletionHandler:")]
		[SupportedOSPlatform ("ios17.2")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IncomingServiceUpdatePush (PTChannelManager channelManager, NSUuid channelUuid, NSDictionary<NSString, NSObject> pushPayload, bool isHighPriority, nint remainingHighPriorityBudget, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("channelManager:receivedEphemeralPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedEphemeralPushToken (PTChannelManager channelManager, NSData pushToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PTChannelManagerDelegate */
}
