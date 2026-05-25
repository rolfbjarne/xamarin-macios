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
namespace CoreAudioKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class AUAudioUnitViewControllerExtensions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectViewConfiguration_X = "selectViewConfiguration:";
		static readonly NativeHandle selSelectViewConfiguration_XHandle = Selector.GetHandle ("selectViewConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedViewConfigurations_X = "supportedViewConfigurations:";
		static readonly NativeHandle selSupportedViewConfigurations_XHandle = Selector.GetHandle ("supportedViewConfigurations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AUAudioUnit");
		/// <param name="This">The instance on which this method operates.</param><param name="availableViewConfigurations">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("supportedViewConfigurations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet GetSupportedViewConfigurations (this global::AudioUnit.AUAudioUnit This, AUAudioUnitViewConfiguration[] availableViewConfigurations)
		{
			if (availableViewConfigurations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableViewConfigurations));
			using var nsa_availableViewConfigurations = NSArray.FromNSObjects (availableViewConfigurations);
			NSIndexSet ret;
			ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, selSupportedViewConfigurations_XHandle, nsa_availableViewConfigurations.Handle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="viewConfiguration">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("selectViewConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectViewConfiguration (this global::AudioUnit.AUAudioUnit This, AUAudioUnitViewConfiguration viewConfiguration)
		{
			var viewConfiguration__handle__ = viewConfiguration!.GetNonNullHandle (nameof (viewConfiguration));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSelectViewConfiguration_XHandle, viewConfiguration__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewConfiguration);
		}
	} /* class AUAudioUnitViewControllerExtensions */
}
