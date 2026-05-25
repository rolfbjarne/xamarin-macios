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
namespace FileProvider {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public unsafe static partial class NSFileProviderManager_ExternalDomain  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_X = "checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:";
		static readonly NativeHandle selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_XHandle = Selector.GetHandle ("checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFileProviderManager");
		[Export ("checkDomainsCanBeStored:onVolumeAtURL:unsupportedReason:error:")]
		[Obsolete ("Call 'NSFileProviderManager.CheckDomainsCanBeStored' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool CheckDomainsCanBeStored (this NSFileProviderManager This, out bool eligible, NSUrl volumeAtUrl, NSFileProviderVolumeUnsupportedReason* unsupportedReason, out NSError? error)
		{
			var volumeAtUrl__handle__ = volumeAtUrl!.GetNonNullHandle (nameof (volumeAtUrl));
			if (unsupportedReason is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (unsupportedReason));
			fixed (bool* eligible__pointer = &eligible) {
			NativeHandle errorValue = IntPtr.Zero;
			eligible = default;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_Boolean_NativeHandle_NSFileProviderVolumeUnsupportedReason__ref_NativeHandle (This.Handle, selCheckDomainsCanBeStored_OnVolumeAtURL_UnsupportedReason_Error_XHandle, (byte*) eligible__pointer, volumeAtUrl__handle__, unsupportedReason, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (volumeAtUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
			}
		}
	} /* class NSFileProviderManager_ExternalDomain */
}
