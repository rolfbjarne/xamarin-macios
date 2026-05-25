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
namespace AVFoundation {
	/// <summary>Defines constants whose values are keys to retrieve metadata error information.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVErrorKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Device;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorDeviceKey",  "AVFoundation")]
		public static NSString Device {
			get {
				if (_Device is null)
					_Device = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorDeviceKey")!;
				return _Device;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVFoundationErrorDomain",  "AVFoundation")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVFoundationErrorDomain")!;
				return _ErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileSize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorFileSizeKey",  "AVFoundation")]
		public static NSString FileSize {
			get {
				if (_FileSize is null)
					_FileSize = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorFileSizeKey")!;
				return _FileSize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorFileTypeKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString FileType {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_FileType is null)
					_FileType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorFileTypeKey")!;
				return _FileType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSubType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorMediaSubTypeKey",  "AVFoundation")]
		public static NSString MediaSubType {
			get {
				if (_MediaSubType is null)
					_MediaSubType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorMediaSubTypeKey")!;
				return _MediaSubType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorMediaTypeKey",  "AVFoundation")]
		public static NSString MediaType {
			get {
				if (_MediaType is null)
					_MediaType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorMediaTypeKey")!;
				return _MediaType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersistentTrackID;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorPersistentTrackIDKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PersistentTrackID {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PersistentTrackID is null)
					_PersistentTrackID = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorPersistentTrackIDKey")!;
				return _PersistentTrackID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Pid;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorPIDKey",  "AVFoundation")]
		public static NSString Pid {
			get {
				if (_Pid is null)
					_Pid = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorPIDKey")!;
				return _Pid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresentationTimeStamp;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorPresentationTimeStampKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PresentationTimeStamp {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PresentationTimeStamp is null)
					_PresentationTimeStamp = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorPresentationTimeStampKey")!;
				return _PresentationTimeStamp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordingSuccessfullyFinished;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorRecordingSuccessfullyFinishedKey",  "AVFoundation")]
		public static NSString RecordingSuccessfullyFinished {
			get {
				if (_RecordingSuccessfullyFinished is null)
					_RecordingSuccessfullyFinished = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorRecordingSuccessfullyFinishedKey")!;
				return _RecordingSuccessfullyFinished;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Time;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("AVErrorTimeKey",  "AVFoundation")]
		public static NSString Time {
			get {
				if (_Time is null)
					_Time = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVErrorTimeKey")!;
				return _Time;
			}
		}
	} /* class AVErrorKeys */
}
