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
namespace AudioUnit {
	/// <summary>Defines the interface of a host to an audio unit.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AUAudioUnit_AUAudioInputOutputUnit  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformInputX = "canPerformInput";
		static readonly NativeHandle selCanPerformInputXHandle = Selector.GetHandle ("canPerformInput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformOutputX = "canPerformOutput";
		static readonly NativeHandle selCanPerformOutputXHandle = Selector.GetHandle ("canPerformOutput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceIDX = "deviceID";
		static readonly NativeHandle selDeviceIDXHandle = Selector.GetHandle ("deviceID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceInputLatencyX = "deviceInputLatency";
		static readonly NativeHandle selDeviceInputLatencyXHandle = Selector.GetHandle ("deviceInputLatency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceOutputLatencyX = "deviceOutputLatency";
		static readonly NativeHandle selDeviceOutputLatencyXHandle = Selector.GetHandle ("deviceOutputLatency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputHandlerX = "inputHandler";
		static readonly NativeHandle selInputHandlerXHandle = Selector.GetHandle ("inputHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInputEnabledX = "isInputEnabled";
		static readonly NativeHandle selIsInputEnabledXHandle = Selector.GetHandle ("isInputEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOutputEnabledX = "isOutputEnabled";
		static readonly NativeHandle selIsOutputEnabledXHandle = Selector.GetHandle ("isOutputEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputProviderX = "outputProvider";
		static readonly NativeHandle selOutputProviderXHandle = Selector.GetHandle ("outputProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunningX = "running";
		static readonly NativeHandle selRunningXHandle = Selector.GetHandle ("running");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDeviceID_Error_X = "setDeviceID:error:";
		static readonly NativeHandle selSetDeviceID_Error_XHandle = Selector.GetHandle ("setDeviceID:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputEnabled_X = "setInputEnabled:";
		static readonly NativeHandle selSetInputEnabled_XHandle = Selector.GetHandle ("setInputEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInputHandler_X = "setInputHandler:";
		static readonly NativeHandle selSetInputHandler_XHandle = Selector.GetHandle ("setInputHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputEnabled_X = "setOutputEnabled:";
		static readonly NativeHandle selSetOutputEnabled_XHandle = Selector.GetHandle ("setOutputEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputProvider_X = "setOutputProvider:";
		static readonly NativeHandle selSetOutputProvider_XHandle = Selector.GetHandle ("setOutputProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartHardwareAndReturnError_X = "startHardwareAndReturnError:";
		static readonly NativeHandle selStartHardwareAndReturnError_XHandle = Selector.GetHandle ("startHardwareAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopHardwareX = "stopHardware";
		static readonly NativeHandle selStopHardwareXHandle = Selector.GetHandle ("stopHardware");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AUAudioUnit");
		/// <summary>Returns a Boolean value that tells whether the audio unit can perform output operations.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("canPerformOutput")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformOutput (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selCanPerformOutputXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether the audio unit can perform input operations.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("canPerformInput")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCanPerformInput (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selCanPerformInputXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("deviceID")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static uint GetDeviceId (this AUAudioUnit This)
		{
			uint ret;
			ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (This.Handle, selDeviceIDXHandle);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("deviceInputLatency")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetDeviceInputLatency (this AUAudioUnit This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, selDeviceInputLatencyXHandle);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("deviceOutputLatency")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetDeviceOutputLatency (this AUAudioUnit This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, selDeviceOutputLatencyXHandle);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the input handler for this IO unit</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAUInputHandler))]
		[Export ("inputHandler")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUInputHandler? GetInputHandler (this AUAudioUnit This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selInputHandlerXHandle);
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDAUInputHandler.Create (ret)!;
		}
		/// <summary>Gets the output provider for this IO unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAURenderPullInputBlock))]
		[Export ("outputProvider")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AURenderPullInputBlock? GetOutputProvider (this AUAudioUnit This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selOutputProviderXHandle);
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDAURenderPullInputBlock.Create (ret)!;
		}
		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isInputEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInputEnabled (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsInputEnabledXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isOutputEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsOutputEnabled (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsOutputEnabledXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("running")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRunning (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selRunningXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="deviceID">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setDeviceID:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool SetDeviceId (this AUAudioUnit This, uint deviceID, out NSError outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt32_ref_NativeHandle (This.Handle, selSetDeviceID_Error_XHandle, deviceID, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>Sets a Boolean value that controls whether input is enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setInputEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetInputEnabled (this AUAudioUnit This, bool enabled)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool (This.Handle, selSetInputEnabled_XHandle, enabled ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="handler">The handler to set.</param><summary>Sets the input handler to the specified value.</summary><remarks>To be added.</remarks>
		[Export ("setInputHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetInputHandler (this AUAudioUnit This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAUInputHandler))]AUInputHandler? handler)
		{
			using var block_handler = Trampolines.SDAUInputHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetInputHandler_XHandle, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>Sets a Boolean value that controls whether output is enabled on the audio unit..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setOutputEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetOutputEnabled (this AUAudioUnit This, bool enabled)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool (This.Handle, selSetOutputEnabled_XHandle, enabled ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="provider">The provider to set.</param><summary>Sets the output provider to the specified value.</summary><remarks>To be added.</remarks>
		[Export ("setOutputProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetOutputProvider (this AUAudioUnit This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAURenderPullInputBlock))]AURenderPullInputBlock? provider)
		{
			using var block_provider = Trampolines.SDAURenderPullInputBlock.CreateNullableBlock (provider);
			BlockLiteral *block_ptr_provider = null;
			if (provider is not null)
				block_ptr_provider = &block_provider;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetOutputProvider_XHandle, (IntPtr) block_ptr_provider);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="outError"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Starts the audio unit's hardware.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startHardwareAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartHardware (this AUAudioUnit This, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, selStartHardwareAndReturnError_XHandle, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <summary>Stops the audio unit's hardware.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("stopHardware")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopHardware (this AUAudioUnit This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selStopHardwareXHandle);
			GC.KeepAlive (This);
		}
	} /* class AUAudioUnit_AUAudioInputOutputUnit */
}
