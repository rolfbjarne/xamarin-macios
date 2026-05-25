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
namespace AudioUnit {
	/// <summary>Defines the interface of a host to an audio unit.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AUAudioUnit_AUAudioInputOutputUnit  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AUAudioUnit");
		/// <summary>Returns a Boolean value that tells whether the audio unit can perform output operations.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("canPerformOutput")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanPerformOutput (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canPerformOutput"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether the audio unit can perform input operations.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("canPerformInput")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCanPerformInput (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canPerformInput"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets the input handler for this IO unit</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAUInputHandler))]
		[Export ("inputHandler")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUInputHandler? GetInputHandler (this AUAudioUnit This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputHandler"));
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
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("outputProvider"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDAURenderPullInputBlock.Create (ret)!;
		}
		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isInputEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInputEnabled (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInputEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Returns a Boolean value that tells whether input is currently enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isOutputEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsOutputEnabled (this AUAudioUnit This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isOutputEnabled"));
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
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("running"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>Sets a Boolean value that controls whether input is enabled on the audio unit.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setInputEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetInputEnabled (this AUAudioUnit This, bool enabled)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setInputEnabled:"), enabled ? (byte) 1 : (byte) 0);
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputHandler:"), (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>Sets a Boolean value that controls whether output is enabled on the audio unit..</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setOutputEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetOutputEnabled (this AUAudioUnit This, bool enabled)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOutputEnabled:"), enabled ? (byte) 1 : (byte) 0);
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
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setOutputProvider:"), (IntPtr) block_ptr_provider);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="outError"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Starts the audio unit's hardware.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startHardwareAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartHardware (this AUAudioUnit This, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("startHardwareAndReturnError:"), &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <summary>Stops the audio unit's hardware.</summary><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("stopHardware")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopHardware (this AUAudioUnit This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stopHardware"));
			GC.KeepAlive (This);
		}
	} /* class AUAudioUnit_AUAudioInputOutputUnit */
}
