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
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTProfileLevel" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTProfileLevelKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H263_Profile0_Level10;
		/// <summary>The key for H.263, profile 0, level 1.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H263_Profile0_Level10",  "VideoToolbox")]
		public static NSString H263_Profile0_Level10 {
			get {
				if (_H263_Profile0_Level10 is null)
					_H263_Profile0_Level10 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H263_Profile0_Level10")!;
				return _H263_Profile0_Level10;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H263_Profile0_Level45;
		/// <summary>The key for H.263, profile 0, level 4.5.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H263_Profile0_Level45",  "VideoToolbox")]
		public static NSString H263_Profile0_Level45 {
			get {
				if (_H263_Profile0_Level45 is null)
					_H263_Profile0_Level45 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H263_Profile0_Level45")!;
				return _H263_Profile0_Level45;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H263_Profile3_Level45;
		/// <summary>The key for H.263, profile 3, level 4.5.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H263_Profile3_Level45",  "VideoToolbox")]
		public static NSString H263_Profile3_Level45 {
			get {
				if (_H263_Profile3_Level45 is null)
					_H263_Profile3_Level45 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H263_Profile3_Level45")!;
				return _H263_Profile3_Level45;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_1_3;
		/// <summary>The key for H.264, baseline profile, level 1.3.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_1_3",  "VideoToolbox")]
		public static NSString H264_Baseline_1_3 {
			get {
				if (_H264_Baseline_1_3 is null)
					_H264_Baseline_1_3 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_1_3")!;
				return _H264_Baseline_1_3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_3_0;
		/// <summary>The key for H.264, baseline profile, level 3.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_3_0",  "VideoToolbox")]
		public static NSString H264_Baseline_3_0 {
			get {
				if (_H264_Baseline_3_0 is null)
					_H264_Baseline_3_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_3_0")!;
				return _H264_Baseline_3_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_3_1;
		/// <summary>The key for H.264, baseline profile, level 3.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_3_1",  "VideoToolbox")]
		public static NSString H264_Baseline_3_1 {
			get {
				if (_H264_Baseline_3_1 is null)
					_H264_Baseline_3_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_3_1")!;
				return _H264_Baseline_3_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_3_2;
		/// <summary>The key for H.264, baseline profile, level 3.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_3_2",  "VideoToolbox")]
		public static NSString H264_Baseline_3_2 {
			get {
				if (_H264_Baseline_3_2 is null)
					_H264_Baseline_3_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_3_2")!;
				return _H264_Baseline_3_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_4_0;
		/// <summary>The key for H.264, baseline profile, level 4.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_4_0",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_4_0 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_4_0 is null)
					_H264_Baseline_4_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_4_0")!;
				return _H264_Baseline_4_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_4_1;
		/// <summary>The key for H.264, baseline profile, level 4.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_4_1",  "VideoToolbox")]
		public static NSString H264_Baseline_4_1 {
			get {
				if (_H264_Baseline_4_1 is null)
					_H264_Baseline_4_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_4_1")!;
				return _H264_Baseline_4_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_4_2;
		/// <summary>The key for H.264, baseline profile, level 4.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_4_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_4_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_4_2 is null)
					_H264_Baseline_4_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_4_2")!;
				return _H264_Baseline_4_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_5_0;
		/// <summary>The key for H.264, baseline profile, level 5.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_5_0",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_5_0 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_5_0 is null)
					_H264_Baseline_5_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_5_0")!;
				return _H264_Baseline_5_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_5_1;
		/// <summary>The key for H.264, baseline profile, level 5.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_5_1",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_5_1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_5_1 is null)
					_H264_Baseline_5_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_5_1")!;
				return _H264_Baseline_5_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_5_2;
		/// <summary>The key for H.264, baseline profile, level 5.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_5_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_5_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_5_2 is null)
					_H264_Baseline_5_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_5_2")!;
				return _H264_Baseline_5_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Baseline_AutoLevel;
		/// <summary>The key for H.264, baseline profile, with automatically determined level.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Baseline_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Baseline_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Baseline_AutoLevel is null)
					_H264_Baseline_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Baseline_AutoLevel")!;
				return _H264_Baseline_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_ConstrainedBaseline_AutoLevel;
		/// <summary>Represents the value associated with the constant 'kVTProfileLevel_H264_ConstrainedBaseline_AutoLevel'.</summary>
		[Field ("kVTProfileLevel_H264_ConstrainedBaseline_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString H264_ConstrainedBaseline_AutoLevel {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_H264_ConstrainedBaseline_AutoLevel is null)
					_H264_ConstrainedBaseline_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_ConstrainedBaseline_AutoLevel")!;
				return _H264_ConstrainedBaseline_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_ConstrainedHigh_AutoLevel;
		/// <summary>Represents the value associated with the constant 'kVTProfileLevel_H264_ConstrainedHigh_AutoLevel'.</summary>
		[Field ("kVTProfileLevel_H264_ConstrainedHigh_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString H264_ConstrainedHigh_AutoLevel {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_H264_ConstrainedHigh_AutoLevel is null)
					_H264_ConstrainedHigh_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_ConstrainedHigh_AutoLevel")!;
				return _H264_ConstrainedHigh_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Extended_5_0;
		/// <summary>The key for H.264, extended profile, level 5.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Extended_5_0",  "VideoToolbox")]
		public static NSString H264_Extended_5_0 {
			get {
				if (_H264_Extended_5_0 is null)
					_H264_Extended_5_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Extended_5_0")!;
				return _H264_Extended_5_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Extended_AutoLevel;
		/// <summary>The key for H.264, extended profile, with automatically determined level.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Extended_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Extended_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Extended_AutoLevel is null)
					_H264_Extended_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Extended_AutoLevel")!;
				return _H264_Extended_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_3_0;
		/// <summary>The key for H.264, high profile, level 3.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_3_0",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_3_0 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_3_0 is null)
					_H264_High_3_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_3_0")!;
				return _H264_High_3_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_3_1;
		/// <summary>The key for H.264, high profile, level 3.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_3_1",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_3_1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_3_1 is null)
					_H264_High_3_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_3_1")!;
				return _H264_High_3_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_3_2;
		/// <summary>The key for H.264, high profile, level 3.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_3_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_3_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_3_2 is null)
					_H264_High_3_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_3_2")!;
				return _H264_High_3_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_4_0;
		/// <summary>The key for H.264, high profile, level 4.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_4_0",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_4_0 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_4_0 is null)
					_H264_High_4_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_4_0")!;
				return _H264_High_4_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_4_1;
		/// <summary>The key for H.264, high profile, level 4.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_4_1",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_4_1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_4_1 is null)
					_H264_High_4_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_4_1")!;
				return _H264_High_4_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_4_2;
		/// <summary>The key for H.264, high profile, level 4.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_4_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_4_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_4_2 is null)
					_H264_High_4_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_4_2")!;
				return _H264_High_4_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_5_0;
		/// <summary>The key for H.264, high profile, level 5.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_5_0",  "VideoToolbox")]
		public static NSString H264_High_5_0 {
			get {
				if (_H264_High_5_0 is null)
					_H264_High_5_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_5_0")!;
				return _H264_High_5_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_5_1;
		/// <summary>The key for H.264, high profile, level 5.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_5_1",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_5_1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_5_1 is null)
					_H264_High_5_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_5_1")!;
				return _H264_High_5_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_5_2;
		/// <summary>The key for H.264, high profile, level 5.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_5_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_5_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_5_2 is null)
					_H264_High_5_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_5_2")!;
				return _H264_High_5_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_High_AutoLevel;
		/// <summary>The key for H.264, high profile, with automatically determined level.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_High_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_High_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_High_AutoLevel is null)
					_H264_High_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_High_AutoLevel")!;
				return _H264_High_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_3_0;
		/// <summary>The key for H.264, main profile, level 3.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_3_0",  "VideoToolbox")]
		public static NSString H264_Main_3_0 {
			get {
				if (_H264_Main_3_0 is null)
					_H264_Main_3_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_3_0")!;
				return _H264_Main_3_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_3_1;
		/// <summary>The key for H.264, main profile, level 3.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_3_1",  "VideoToolbox")]
		public static NSString H264_Main_3_1 {
			get {
				if (_H264_Main_3_1 is null)
					_H264_Main_3_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_3_1")!;
				return _H264_Main_3_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_3_2;
		/// <summary>The key for H.264, main profile, level 3.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_3_2",  "VideoToolbox")]
		public static NSString H264_Main_3_2 {
			get {
				if (_H264_Main_3_2 is null)
					_H264_Main_3_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_3_2")!;
				return _H264_Main_3_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_4_0;
		/// <summary>The key for H.264, main profile, level 4.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_4_0",  "VideoToolbox")]
		public static NSString H264_Main_4_0 {
			get {
				if (_H264_Main_4_0 is null)
					_H264_Main_4_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_4_0")!;
				return _H264_Main_4_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_4_1;
		/// <summary>The key for H.264, main profile, level 4.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_4_1",  "VideoToolbox")]
		public static NSString H264_Main_4_1 {
			get {
				if (_H264_Main_4_1 is null)
					_H264_Main_4_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_4_1")!;
				return _H264_Main_4_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_4_2;
		/// <summary>The key for H.264, main profile, level 4.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_4_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Main_4_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Main_4_2 is null)
					_H264_Main_4_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_4_2")!;
				return _H264_Main_4_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_5_0;
		/// <summary>The key for H.264, main profile, level 5.0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_5_0",  "VideoToolbox")]
		public static NSString H264_Main_5_0 {
			get {
				if (_H264_Main_5_0 is null)
					_H264_Main_5_0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_5_0")!;
				return _H264_Main_5_0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_5_1;
		/// <summary>The key for H.264, main profile, level 5.1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_5_1",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Main_5_1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Main_5_1 is null)
					_H264_Main_5_1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_5_1")!;
				return _H264_Main_5_1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_5_2;
		/// <summary>The key for H.264, main profile, level 5.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_5_2",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Main_5_2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Main_5_2 is null)
					_H264_Main_5_2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_5_2")!;
				return _H264_Main_5_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _H264_Main_AutoLevel;
		/// <summary>The key for H.264, main profile, with automatically determined level.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_H264_Main_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString H264_Main_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_H264_Main_AutoLevel is null)
					_H264_Main_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_H264_Main_AutoLevel")!;
				return _H264_Main_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hevc_Main10_AutoLevel;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_HEVC_Main10_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Hevc_Main10_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Hevc_Main10_AutoLevel is null)
					_Hevc_Main10_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_HEVC_Main10_AutoLevel")!;
				return _Hevc_Main10_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hevc_Main42210_AutoLevel;
		/// <summary>Represents the value associated with the constant 'kVTProfileLevel_HEVC_Main42210_AutoLevel'.</summary>
		[Field ("kVTProfileLevel_HEVC_Main42210_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public static NSString Hevc_Main42210_AutoLevel {
			[SupportedOSPlatform ("tvos15.4")]
			[SupportedOSPlatform ("macos12.3")]
			[SupportedOSPlatform ("ios15.4")]
			[SupportedOSPlatform ("maccatalyst15.4")]
			get {
				if (_Hevc_Main42210_AutoLevel is null)
					_Hevc_Main42210_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_HEVC_Main42210_AutoLevel")!;
				return _Hevc_Main42210_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hevc_Main_AutoLevel;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_HEVC_Main_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Hevc_Main_AutoLevel {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Hevc_Main_AutoLevel is null)
					_Hevc_Main_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_HEVC_Main_AutoLevel")!;
				return _Hevc_Main_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hevc_Monochrome10_AutoLevel;
		/// <summary>Represents the value associated with the constant 'kVTProfileLevel_HEVC_Monochrome10_AutoLevel'.</summary>
		[Field ("kVTProfileLevel_HEVC_Monochrome10_AutoLevel",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Hevc_Monochrome10_AutoLevel {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Hevc_Monochrome10_AutoLevel is null)
					_Hevc_Monochrome10_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_HEVC_Monochrome10_AutoLevel")!;
				return _Hevc_Monochrome10_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hevc_Monochrome_AutoLevel;
		/// <summary>Represents the value associated with the constant 'kVTProfileLevel_HEVC_Monochrome_AutoLevel'.</summary>
		[Field ("kVTProfileLevel_HEVC_Monochrome_AutoLevel",  "VideoToolbox")]
		public static NSString Hevc_Monochrome_AutoLevel {
			get {
				if (_Hevc_Monochrome_AutoLevel is null)
					_Hevc_Monochrome_AutoLevel = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_HEVC_Monochrome_AutoLevel")!;
				return _Hevc_Monochrome_AutoLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_AdvancedSimple_L0;
		/// <summary>The key for MPEG-4 video, advanced simple profile, level 0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L0",  "VideoToolbox")]
		public static NSString MP4V_AdvancedSimple_L0 {
			get {
				if (_MP4V_AdvancedSimple_L0 is null)
					_MP4V_AdvancedSimple_L0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_AdvancedSimple_L0")!;
				return _MP4V_AdvancedSimple_L0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_AdvancedSimple_L1;
		/// <summary>The key for MPEG-4 video, advanced simple profile, level 1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L1",  "VideoToolbox")]
		public static NSString MP4V_AdvancedSimple_L1 {
			get {
				if (_MP4V_AdvancedSimple_L1 is null)
					_MP4V_AdvancedSimple_L1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_AdvancedSimple_L1")!;
				return _MP4V_AdvancedSimple_L1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_AdvancedSimple_L2;
		/// <summary>The key for MPEG-4 video, advanced simple profile, level 2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L2",  "VideoToolbox")]
		public static NSString MP4V_AdvancedSimple_L2 {
			get {
				if (_MP4V_AdvancedSimple_L2 is null)
					_MP4V_AdvancedSimple_L2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_AdvancedSimple_L2")!;
				return _MP4V_AdvancedSimple_L2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_AdvancedSimple_L3;
		/// <summary>The key for MPEG-4 video, advanced simple profile, level 3.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L3",  "VideoToolbox")]
		public static NSString MP4V_AdvancedSimple_L3 {
			get {
				if (_MP4V_AdvancedSimple_L3 is null)
					_MP4V_AdvancedSimple_L3 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_AdvancedSimple_L3")!;
				return _MP4V_AdvancedSimple_L3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_AdvancedSimple_L4;
		/// <summary>The key for MPEG-4 video, advanced simple profile, level 4.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_AdvancedSimple_L4",  "VideoToolbox")]
		public static NSString MP4V_AdvancedSimple_L4 {
			get {
				if (_MP4V_AdvancedSimple_L4 is null)
					_MP4V_AdvancedSimple_L4 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_AdvancedSimple_L4")!;
				return _MP4V_AdvancedSimple_L4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Main_L2;
		/// <summary>The key for MPEG-4 video, main profile, level 2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Main_L2",  "VideoToolbox")]
		public static NSString MP4V_Main_L2 {
			get {
				if (_MP4V_Main_L2 is null)
					_MP4V_Main_L2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Main_L2")!;
				return _MP4V_Main_L2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Main_L3;
		/// <summary>The key for MPEG-4 video, main profile, level 3.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Main_L3",  "VideoToolbox")]
		public static NSString MP4V_Main_L3 {
			get {
				if (_MP4V_Main_L3 is null)
					_MP4V_Main_L3 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Main_L3")!;
				return _MP4V_Main_L3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Main_L4;
		/// <summary>The key for MPEG-4 video, main profile, level 4.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Main_L4",  "VideoToolbox")]
		public static NSString MP4V_Main_L4 {
			get {
				if (_MP4V_Main_L4 is null)
					_MP4V_Main_L4 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Main_L4")!;
				return _MP4V_Main_L4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Simple_L0;
		/// <summary>The key for MPEG-4 video, simple profile, level 0.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Simple_L0",  "VideoToolbox")]
		public static NSString MP4V_Simple_L0 {
			get {
				if (_MP4V_Simple_L0 is null)
					_MP4V_Simple_L0 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Simple_L0")!;
				return _MP4V_Simple_L0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Simple_L1;
		/// <summary>The key for MPEG-4 video, simple profile, level 1.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Simple_L1",  "VideoToolbox")]
		public static NSString MP4V_Simple_L1 {
			get {
				if (_MP4V_Simple_L1 is null)
					_MP4V_Simple_L1 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Simple_L1")!;
				return _MP4V_Simple_L1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Simple_L2;
		/// <summary>The key for MPEG-4 video, simple profile, level 2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Simple_L2",  "VideoToolbox")]
		public static NSString MP4V_Simple_L2 {
			get {
				if (_MP4V_Simple_L2 is null)
					_MP4V_Simple_L2 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Simple_L2")!;
				return _MP4V_Simple_L2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP4V_Simple_L3;
		/// <summary>The key for MPEG-4 video, simple profile, level 3.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTProfileLevel_MP4V_Simple_L3",  "VideoToolbox")]
		public static NSString MP4V_Simple_L3 {
			get {
				if (_MP4V_Simple_L3 is null)
					_MP4V_Simple_L3 = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTProfileLevel_MP4V_Simple_L3")!;
				return _MP4V_Simple_L3;
			}
		}
	} /* class VTProfileLevelKeys */
}
