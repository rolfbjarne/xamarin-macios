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
namespace MobileCoreServices {
	/// <summary>Defines constants for Uniform Type Identifiers (UTIs) which are strings that identify a given class of type or item.</summary><remarks><para>Uniform Type Identifiers (UTIs) are Apple's method for identifying data types.</para><para>UTIs use a reverse-DNS naming structure.  UTIs support multiple inheritance, allowing files to be identified with any number of relevant types, as appropriate to the contained data.</para></remarks>
	[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[ObsoletedOSPlatform ("macos11.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UTType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AVIMovie;
		/// <summary>Represents the value associated with the constant kUTTypeAVIMovie</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAVIMovie",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AVIMovie {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AVIMovie is null)
					_AVIMovie = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAVIMovie")!;
				return _AVIMovie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Alembic;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTypeAlembic",  "ModelIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Alembic {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Alembic is null)
					_Alembic = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTTypeAlembic")!;
				return _Alembic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AliasFile;
		/// <summary>Represents the value associated with the constant kUTTypeAliasFile</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAliasFile",  "CoreServices")]
		public static NSString AliasFile {
			get {
				if (_AliasFile is null)
					_AliasFile = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAliasFile")!;
				return _AliasFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AliasRecord;
		/// <summary>Represents the value associated with the constant kUTTypeAliasRecord</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAliasRecord",  "CoreServices")]
		public static NSString AliasRecord {
			get {
				if (_AliasRecord is null)
					_AliasRecord = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAliasRecord")!;
				return _AliasRecord;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleICNS;
		/// <summary>Represents the value associated with the constant kUTTypeAppleICNS</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAppleICNS",  "CoreServices")]
		public static NSString AppleICNS {
			get {
				if (_AppleICNS is null)
					_AppleICNS = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAppleICNS")!;
				return _AppleICNS;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleProtectedMPEG4Audio;
		/// <summary>Represents the value associated with the constant kUTTypeAppleProtectedMPEG4Audio</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAppleProtectedMPEG4Audio",  "CoreServices")]
		public static NSString AppleProtectedMPEG4Audio {
			get {
				if (_AppleProtectedMPEG4Audio is null)
					_AppleProtectedMPEG4Audio = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAppleProtectedMPEG4Audio")!;
				return _AppleProtectedMPEG4Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleProtectedMPEG4Video;
		/// <summary>Represents the value associated with the constant kUTTypeAppleProtectedMPEG4Video</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAppleProtectedMPEG4Video",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AppleProtectedMPEG4Video {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AppleProtectedMPEG4Video is null)
					_AppleProtectedMPEG4Video = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAppleProtectedMPEG4Video")!;
				return _AppleProtectedMPEG4Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AppleScript;
		/// <summary>Represents the value associated with the constant kUTTypeAppleScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAppleScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AppleScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AppleScript is null)
					_AppleScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAppleScript")!;
				return _AppleScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Application;
		/// <summary>Represents the value associated with the constant kUTTypeApplication</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeApplication",  "CoreServices")]
		public static NSString Application {
			get {
				if (_Application is null)
					_Application = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeApplication")!;
				return _Application;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationBundle;
		/// <summary>Represents the value associated with the constant kUTTypeApplicationBundle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeApplicationBundle",  "CoreServices")]
		public static NSString ApplicationBundle {
			get {
				if (_ApplicationBundle is null)
					_ApplicationBundle = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeApplicationBundle")!;
				return _ApplicationBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationFile;
		/// <summary>Represents the value associated with the constant kUTTypeApplicationFile</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeApplicationFile",  "CoreServices")]
		public static NSString ApplicationFile {
			get {
				if (_ApplicationFile is null)
					_ApplicationFile = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeApplicationFile")!;
				return _ApplicationFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Archive;
		/// <summary>Represents the value associated with the constant kUTTypeArchive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeArchive",  "CoreServices")]
		public static NSString Archive {
			get {
				if (_Archive is null)
					_Archive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeArchive")!;
				return _Archive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssemblyLanguageSource;
		/// <summary>Represents the value associated with the constant kUTTypeAssemblyLanguageSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAssemblyLanguageSource",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AssemblyLanguageSource {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AssemblyLanguageSource is null)
					_AssemblyLanguageSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAssemblyLanguageSource")!;
				return _AssemblyLanguageSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Audio;
		/// <summary>Represents the value associated with the constant kUTTypeAudio</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAudio",  "CoreServices")]
		public static NSString Audio {
			get {
				if (_Audio is null)
					_Audio = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAudio")!;
				return _Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudioInterchangeFileFormat;
		/// <summary>Represents the value associated with the constant kUTTypeAudioInterchangeFileFormat</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAudioInterchangeFileFormat",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AudioInterchangeFileFormat {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AudioInterchangeFileFormat is null)
					_AudioInterchangeFileFormat = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAudioInterchangeFileFormat")!;
				return _AudioInterchangeFileFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AudiovisualContent;
		/// <summary>Represents the value associated with the constant kUTTypeAudiovisualContent</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeAudiovisualContent",  "CoreServices")]
		public static NSString AudiovisualContent {
			get {
				if (_AudiovisualContent is null)
					_AudiovisualContent = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeAudiovisualContent")!;
				return _AudiovisualContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BMP;
		/// <summary>Represents the value associated with the constant kUTTypeBMP</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeBMP",  "CoreServices")]
		public static NSString BMP {
			get {
				if (_BMP is null)
					_BMP = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeBMP")!;
				return _BMP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BinaryPropertyList;
		/// <summary>Represents the value associated with the constant kUTTypeBinaryPropertyList</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeBinaryPropertyList",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString BinaryPropertyList {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_BinaryPropertyList is null)
					_BinaryPropertyList = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeBinaryPropertyList")!;
				return _BinaryPropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bookmark;
		/// <summary>Represents the value associated with the constant kUTTypeBookmark</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeBookmark",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Bookmark {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Bookmark is null)
					_Bookmark = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeBookmark")!;
				return _Bookmark;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bundle;
		/// <summary>Represents the value associated with the constant kUTTypeBundle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeBundle",  "CoreServices")]
		public static NSString Bundle {
			get {
				if (_Bundle is null)
					_Bundle = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeBundle")!;
				return _Bundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Bzip2Archive;
		/// <summary>Represents the value associated with the constant kUTTypeBzip2Archive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeBzip2Archive",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Bzip2Archive {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Bzip2Archive is null)
					_Bzip2Archive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeBzip2Archive")!;
				return _Bzip2Archive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CHeader;
		/// <summary>Represents the value associated with the constant kUTTypeCHeader</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCHeader",  "CoreServices")]
		public static NSString CHeader {
			get {
				if (_CHeader is null)
					_CHeader = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCHeader")!;
				return _CHeader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CPlusPlusHeader;
		/// <summary>Represents the value associated with the constant kUTTypeCPlusPlusHeader</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCPlusPlusHeader",  "CoreServices")]
		public static NSString CPlusPlusHeader {
			get {
				if (_CPlusPlusHeader is null)
					_CPlusPlusHeader = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCPlusPlusHeader")!;
				return _CPlusPlusHeader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CPlusPlusSource;
		/// <summary>Represents the value associated with the constant kUTTypeCPlusPlusSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCPlusPlusSource",  "CoreServices")]
		public static NSString CPlusPlusSource {
			get {
				if (_CPlusPlusSource is null)
					_CPlusPlusSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCPlusPlusSource")!;
				return _CPlusPlusSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CSource;
		/// <summary>Represents the value associated with the constant kUTTypeCSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCSource",  "CoreServices")]
		public static NSString CSource {
			get {
				if (_CSource is null)
					_CSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCSource")!;
				return _CSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalendarEvent;
		/// <summary>Represents the value associated with the constant kUTTypeCalendarEvent</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCalendarEvent",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CalendarEvent {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CalendarEvent is null)
					_CalendarEvent = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCalendarEvent")!;
				return _CalendarEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CommaSeparatedText;
		/// <summary>Represents the value associated with the constant kUTTypeCommaSeparatedText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCommaSeparatedText",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CommaSeparatedText {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CommaSeparatedText is null)
					_CommaSeparatedText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCommaSeparatedText")!;
				return _CommaSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompositeContent;
		/// <summary>Represents the value associated with the constant kUTTypeCompositeContent</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeCompositeContent",  "CoreServices")]
		public static NSString CompositeContent {
			get {
				if (_CompositeContent is null)
					_CompositeContent = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeCompositeContent")!;
				return _CompositeContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConformsToKey;
		/// <summary>Represents the value associated with the constant kUTTypeConformsToKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeConformsToKey",  "CoreServices")]
		public static NSString ConformsToKey {
			get {
				if (_ConformsToKey is null)
					_ConformsToKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeConformsToKey")!;
				return _ConformsToKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Contact;
		/// <summary>Represents the value associated with the constant kUTTypeContact</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeContact",  "CoreServices")]
		public static NSString Contact {
			get {
				if (_Contact is null)
					_Contact = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeContact")!;
				return _Contact;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Content;
		/// <summary>Represents the value associated with the constant kUTTypeContent</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeContent",  "CoreServices")]
		public static NSString Content {
			get {
				if (_Content is null)
					_Content = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeContent")!;
				return _Content;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Data;
		/// <summary>Represents the value associated with the constant kUTTypeData</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeData",  "CoreServices")]
		public static NSString Data {
			get {
				if (_Data is null)
					_Data = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeData")!;
				return _Data;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Database;
		/// <summary>Represents the value associated with the constant kUTTypeDatabase</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeDatabase",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Database {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Database is null)
					_Database = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeDatabase")!;
				return _Database;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DelimitedText;
		/// <summary>Represents the value associated with the constant kUTTypeDelimitedText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeDelimitedText",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DelimitedText {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DelimitedText is null)
					_DelimitedText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeDelimitedText")!;
				return _DelimitedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DescriptionKey;
		/// <summary>Represents the value associated with the constant kUTTypeDescriptionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeDescriptionKey",  "CoreServices")]
		public static NSString DescriptionKey {
			get {
				if (_DescriptionKey is null)
					_DescriptionKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeDescriptionKey")!;
				return _DescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Directory;
		/// <summary>Represents the value associated with the constant kUTTypeDirectory</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeDirectory",  "CoreServices")]
		public static NSString Directory {
			get {
				if (_Directory is null)
					_Directory = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeDirectory")!;
				return _Directory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DiskImage;
		/// <summary>Represents the value associated with the constant kUTTypeDiskImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeDiskImage",  "CoreServices")]
		public static NSString DiskImage {
			get {
				if (_DiskImage is null)
					_DiskImage = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeDiskImage")!;
				return _DiskImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElectronicPublication;
		/// <summary>Represents the value associated with the constant kUTTypeElectronicPublication</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeElectronicPublication",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ElectronicPublication {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ElectronicPublication is null)
					_ElectronicPublication = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeElectronicPublication")!;
				return _ElectronicPublication;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailMessage;
		/// <summary>Represents the value associated with the constant kUTTypeEmailMessage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeEmailMessage",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString EmailMessage {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EmailMessage is null)
					_EmailMessage = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeEmailMessage")!;
				return _EmailMessage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Executable;
		/// <summary>Represents the value associated with the constant kUTTypeExecutable</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeExecutable",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Executable {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Executable is null)
					_Executable = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeExecutable")!;
				return _Executable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExportedTypeDeclarationsKey;
		/// <summary>Represents the value associated with the constant kUTExportedTypeDeclarationsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTExportedTypeDeclarationsKey",  "CoreServices")]
		public static NSString ExportedTypeDeclarationsKey {
			get {
				if (_ExportedTypeDeclarationsKey is null)
					_ExportedTypeDeclarationsKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTExportedTypeDeclarationsKey")!;
				return _ExportedTypeDeclarationsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileURL;
		/// <summary>Represents the value associated with the constant kUTTypeFileURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeFileURL",  "CoreServices")]
		public static NSString FileURL {
			get {
				if (_FileURL is null)
					_FileURL = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeFileURL")!;
				return _FileURL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlatRTFD;
		/// <summary>Represents the value associated with the constant kUTTypeFlatRTFD</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeFlatRTFD",  "CoreServices")]
		public static NSString FlatRTFD {
			get {
				if (_FlatRTFD is null)
					_FlatRTFD = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeFlatRTFD")!;
				return _FlatRTFD;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Folder;
		/// <summary>Represents the value associated with the constant kUTTypeFolder</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeFolder",  "CoreServices")]
		public static NSString Folder {
			get {
				if (_Folder is null)
					_Folder = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeFolder")!;
				return _Folder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Font;
		/// <summary>Represents the value associated with the constant kUTTypeFont</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeFont",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Font {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Font is null)
					_Font = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeFont")!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Framework;
		/// <summary>Represents the value associated with the constant kUTTypeFramework</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeFramework",  "CoreServices")]
		public static NSString Framework {
			get {
				if (_Framework is null)
					_Framework = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeFramework")!;
				return _Framework;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GIF;
		/// <summary>Represents the value associated with the constant kUTTypeGIF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeGIF",  "CoreServices")]
		public static NSString GIF {
			get {
				if (_GIF is null)
					_GIF = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeGIF")!;
				return _GIF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GNUZipArchive;
		/// <summary>Represents the value associated with the constant kUTTypeGNUZipArchive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeGNUZipArchive",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GNUZipArchive {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GNUZipArchive is null)
					_GNUZipArchive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeGNUZipArchive")!;
				return _GNUZipArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HTML;
		/// <summary>Represents the value associated with the constant kUTTypeHTML</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeHTML",  "CoreServices")]
		public static NSString HTML {
			get {
				if (_HTML is null)
					_HTML = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeHTML")!;
				return _HTML;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ICO;
		/// <summary>Represents the value associated with the constant kUTTypeICO</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeICO",  "CoreServices")]
		public static NSString ICO {
			get {
				if (_ICO is null)
					_ICO = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeICO")!;
				return _ICO;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IconFileKey;
		/// <summary>Represents the value associated with the constant kUTTypeIconFileKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeIconFileKey",  "CoreServices")]
		public static NSString IconFileKey {
			get {
				if (_IconFileKey is null)
					_IconFileKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeIconFileKey")!;
				return _IconFileKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IdentifierKey;
		/// <summary>Represents the value associated with the constant kUTTypeIdentifierKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeIdentifierKey",  "CoreServices")]
		public static NSString IdentifierKey {
			get {
				if (_IdentifierKey is null)
					_IdentifierKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeIdentifierKey")!;
				return _IdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Image;
		/// <summary>Represents the value associated with the constant kUTTypeImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeImage",  "CoreServices")]
		public static NSString Image {
			get {
				if (_Image is null)
					_Image = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeImage")!;
				return _Image;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImportedTypeDeclarationsKey;
		/// <summary>Represents the value associated with the constant kUTImportedTypeDeclarationsKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTImportedTypeDeclarationsKey",  "CoreServices")]
		public static NSString ImportedTypeDeclarationsKey {
			get {
				if (_ImportedTypeDeclarationsKey is null)
					_ImportedTypeDeclarationsKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTImportedTypeDeclarationsKey")!;
				return _ImportedTypeDeclarationsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InkText;
		/// <summary>Represents the value associated with the constant kUTTypeInkText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeInkText",  "CoreServices")]
		public static NSString InkText {
			get {
				if (_InkText is null)
					_InkText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeInkText")!;
				return _InkText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InternetLocation;
		/// <summary>Represents the value associated with the constant kUTTypeInternetLocation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeInternetLocation",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString InternetLocation {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_InternetLocation is null)
					_InternetLocation = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeInternetLocation")!;
				return _InternetLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Item;
		/// <summary>Represents the value associated with the constant kUTTypeItem</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeItem",  "CoreServices")]
		public static NSString Item {
			get {
				if (_Item is null)
					_Item = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeItem")!;
				return _Item;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JPEG;
		/// <summary>Represents the value associated with the constant kUTTypeJPEG</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJPEG",  "CoreServices")]
		public static NSString JPEG {
			get {
				if (_JPEG is null)
					_JPEG = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJPEG")!;
				return _JPEG;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JPEG2000;
		/// <summary>Represents the value associated with the constant kUTTypeJPEG2000</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJPEG2000",  "CoreServices")]
		public static NSString JPEG2000 {
			get {
				if (_JPEG2000 is null)
					_JPEG2000 = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJPEG2000")!;
				return _JPEG2000;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JSON;
		/// <summary>Represents the value associated with the constant kUTTypeJSON</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJSON",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString JSON {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_JSON is null)
					_JSON = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJSON")!;
				return _JSON;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JavaArchive;
		/// <summary>Represents the value associated with the constant kUTTypeJavaArchive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJavaArchive",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString JavaArchive {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_JavaArchive is null)
					_JavaArchive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJavaArchive")!;
				return _JavaArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JavaClass;
		/// <summary>Represents the value associated with the constant kUTTypeJavaClass</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJavaClass",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString JavaClass {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_JavaClass is null)
					_JavaClass = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJavaClass")!;
				return _JavaClass;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JavaScript;
		/// <summary>Represents the value associated with the constant kUTTypeJavaScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJavaScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString JavaScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_JavaScript is null)
					_JavaScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJavaScript")!;
				return _JavaScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JavaSource;
		/// <summary>Represents the value associated with the constant kUTTypeJavaSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeJavaSource",  "CoreServices")]
		public static NSString JavaSource {
			get {
				if (_JavaSource is null)
					_JavaSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeJavaSource")!;
				return _JavaSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Log;
		/// <summary>Represents the value associated with the constant kUTTypeLog</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeLog",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Log {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Log is null)
					_Log = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeLog")!;
				return _Log;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _M3UPlaylist;
		/// <summary>Represents the value associated with the constant kUTTypeM3UPlaylist</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeM3UPlaylist",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString M3UPlaylist {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_M3UPlaylist is null)
					_M3UPlaylist = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeM3UPlaylist")!;
				return _M3UPlaylist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MIDIAudio;
		/// <summary>Represents the value associated with the constant kUTTypeMIDIAudio</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMIDIAudio",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MIDIAudio {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MIDIAudio is null)
					_MIDIAudio = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMIDIAudio")!;
				return _MIDIAudio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MP3;
		/// <summary>Represents the value associated with the constant kUTTypeMP3</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMP3",  "CoreServices")]
		public static NSString MP3 {
			get {
				if (_MP3 is null)
					_MP3 = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMP3")!;
				return _MP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MPEG;
		/// <summary>Represents the value associated with the constant kUTTypeMPEG</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMPEG",  "CoreServices")]
		public static NSString MPEG {
			get {
				if (_MPEG is null)
					_MPEG = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMPEG")!;
				return _MPEG;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MPEG2TransportStream;
		/// <summary>Represents the value associated with the constant kUTTypeMPEG2TransportStream</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMPEG2TransportStream",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MPEG2TransportStream {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MPEG2TransportStream is null)
					_MPEG2TransportStream = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMPEG2TransportStream")!;
				return _MPEG2TransportStream;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MPEG2Video;
		/// <summary>Represents the value associated with the constant kUTTypeMPEG2Video</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMPEG2Video",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MPEG2Video {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MPEG2Video is null)
					_MPEG2Video = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMPEG2Video")!;
				return _MPEG2Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MPEG4;
		/// <summary>Represents the value associated with the constant kUTTypeMPEG4</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMPEG4",  "CoreServices")]
		public static NSString MPEG4 {
			get {
				if (_MPEG4 is null)
					_MPEG4 = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMPEG4")!;
				return _MPEG4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MPEG4Audio;
		/// <summary>Represents the value associated with the constant kUTTypeMPEG4Audio</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMPEG4Audio",  "CoreServices")]
		public static NSString MPEG4Audio {
			get {
				if (_MPEG4Audio is null)
					_MPEG4Audio = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMPEG4Audio")!;
				return _MPEG4Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Message;
		/// <summary>Represents the value associated with the constant kUTTypeMessage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMessage",  "CoreServices")]
		public static NSString Message {
			get {
				if (_Message is null)
					_Message = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMessage")!;
				return _Message;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MountPoint;
		/// <summary>Represents the value associated with the constant kUTTypeMountPoint</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMountPoint",  "CoreServices")]
		public static NSString MountPoint {
			get {
				if (_MountPoint is null)
					_MountPoint = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMountPoint")!;
				return _MountPoint;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Movie;
		/// <summary>Represents the value associated with the constant kUTTypeMovie</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeMovie",  "CoreServices")]
		public static NSString Movie {
			get {
				if (_Movie is null)
					_Movie = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeMovie")!;
				return _Movie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OSAScript;
		/// <summary>Represents the value associated with the constant kUTTypeOSAScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeOSAScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OSAScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OSAScript is null)
					_OSAScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeOSAScript")!;
				return _OSAScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OSAScriptBundle;
		/// <summary>Represents the value associated with the constant kUTTypeOSAScriptBundle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeOSAScriptBundle",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OSAScriptBundle {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OSAScriptBundle is null)
					_OSAScriptBundle = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeOSAScriptBundle")!;
				return _OSAScriptBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ObjectiveCPlusPlusSource;
		/// <summary>Represents the value associated with the constant kUTTypeObjectiveCPlusPlusSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeObjectiveCPlusPlusSource",  "CoreServices")]
		public static NSString ObjectiveCPlusPlusSource {
			get {
				if (_ObjectiveCPlusPlusSource is null)
					_ObjectiveCPlusPlusSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeObjectiveCPlusPlusSource")!;
				return _ObjectiveCPlusPlusSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ObjectiveCSource;
		/// <summary>Represents the value associated with the constant kUTTypeObjectiveCSource</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeObjectiveCSource",  "CoreServices")]
		public static NSString ObjectiveCSource {
			get {
				if (_ObjectiveCSource is null)
					_ObjectiveCSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeObjectiveCSource")!;
				return _ObjectiveCSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PDF;
		/// <summary>Represents the value associated with the constant kUTTypePDF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePDF",  "CoreServices")]
		public static NSString PDF {
			get {
				if (_PDF is null)
					_PDF = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePDF")!;
				return _PDF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PHPScript;
		/// <summary>Represents the value associated with the constant kUTTypePHPScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePHPScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PHPScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PHPScript is null)
					_PHPScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePHPScript")!;
				return _PHPScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PICT;
		/// <summary>Represents the value associated with the constant kUTTypePICT</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePICT",  "CoreServices")]
		public static NSString PICT {
			get {
				if (_PICT is null)
					_PICT = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePICT")!;
				return _PICT;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PKCS12;
		/// <summary>Represents the value associated with the constant kUTTypePKCS12</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePKCS12",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PKCS12 {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PKCS12 is null)
					_PKCS12 = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePKCS12")!;
				return _PKCS12;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PNG;
		/// <summary>Represents the value associated with the constant kUTTypePNG</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePNG",  "CoreServices")]
		public static NSString PNG {
			get {
				if (_PNG is null)
					_PNG = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePNG")!;
				return _PNG;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Package;
		/// <summary>Represents the value associated with the constant kUTTypePackage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePackage",  "CoreServices")]
		public static NSString Package {
			get {
				if (_Package is null)
					_Package = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePackage")!;
				return _Package;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PerlScript;
		/// <summary>Represents the value associated with the constant kUTTypePerlScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePerlScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PerlScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PerlScript is null)
					_PerlScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePerlScript")!;
				return _PerlScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlainText;
		/// <summary>Represents the value associated with the constant kUTTypePlainText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePlainText",  "CoreServices")]
		public static NSString PlainText {
			get {
				if (_PlainText is null)
					_PlainText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePlainText")!;
				return _PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Playlist;
		/// <summary>Represents the value associated with the constant kUTTypePlaylist</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePlaylist",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Playlist {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Playlist is null)
					_Playlist = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePlaylist")!;
				return _Playlist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PluginBundle;
		/// <summary>Represents the value associated with the constant kUTTypePluginBundle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePluginBundle",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PluginBundle {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PluginBundle is null)
					_PluginBundle = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePluginBundle")!;
				return _PluginBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Polygon;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTypePolygon",  "ModelIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Polygon {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Polygon is null)
					_Polygon = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTTypePolygon")!;
				return _Polygon;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Presentation;
		/// <summary>Represents the value associated with the constant kUTTypePresentation</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePresentation",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Presentation {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Presentation is null)
					_Presentation = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePresentation")!;
				return _Presentation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropertyList;
		/// <summary>Represents the value associated with the constant kUTTypePropertyList</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePropertyList",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PropertyList {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PropertyList is null)
					_PropertyList = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePropertyList")!;
				return _PropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PythonScript;
		/// <summary>Represents the value associated with the constant kUTTypePythonScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypePythonScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString PythonScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_PythonScript is null)
					_PythonScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypePythonScript")!;
				return _PythonScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickLookGenerator;
		/// <summary>Represents the value associated with the constant kUTTypeQuickLookGenerator</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeQuickLookGenerator",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString QuickLookGenerator {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_QuickLookGenerator is null)
					_QuickLookGenerator = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeQuickLookGenerator")!;
				return _QuickLookGenerator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeImage;
		/// <summary>Represents the value associated with the constant kUTTypeQuickTimeImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeQuickTimeImage",  "CoreServices")]
		public static NSString QuickTimeImage {
			get {
				if (_QuickTimeImage is null)
					_QuickTimeImage = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeQuickTimeImage")!;
				return _QuickTimeImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickTimeMovie;
		/// <summary>Represents the value associated with the constant kUTTypeQuickTimeMovie</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeQuickTimeMovie",  "CoreServices")]
		public static NSString QuickTimeMovie {
			get {
				if (_QuickTimeMovie is null)
					_QuickTimeMovie = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeQuickTimeMovie")!;
				return _QuickTimeMovie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RTF;
		/// <summary>Represents the value associated with the constant kUTTypeRTF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeRTF",  "CoreServices")]
		public static NSString RTF {
			get {
				if (_RTF is null)
					_RTF = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeRTF")!;
				return _RTF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RTFD;
		/// <summary>Represents the value associated with the constant kUTTypeRTFD</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeRTFD",  "CoreServices")]
		public static NSString RTFD {
			get {
				if (_RTFD is null)
					_RTFD = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeRTFD")!;
				return _RTFD;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RawImage;
		/// <summary>Represents the value associated with the constant kUTTypeRawImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeRawImage",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RawImage {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RawImage is null)
					_RawImage = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeRawImage")!;
				return _RawImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReferenceURLKey;
		/// <summary>Represents the value associated with the constant kUTTypeReferenceURLKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeReferenceURLKey",  "CoreServices")]
		public static NSString ReferenceURLKey {
			get {
				if (_ReferenceURLKey is null)
					_ReferenceURLKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeReferenceURLKey")!;
				return _ReferenceURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Resolvable;
		/// <summary>Represents the value associated with the constant kUTTypeResolvable</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeResolvable",  "CoreServices")]
		public static NSString Resolvable {
			get {
				if (_Resolvable is null)
					_Resolvable = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeResolvable")!;
				return _Resolvable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RubyScript;
		/// <summary>Represents the value associated with the constant kUTTypeRubyScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeRubyScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RubyScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RubyScript is null)
					_RubyScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeRubyScript")!;
				return _RubyScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalableVectorGraphics;
		/// <summary>Represents the value associated with the constant kUTTypeScalableVectorGraphics</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeScalableVectorGraphics",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ScalableVectorGraphics {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ScalableVectorGraphics is null)
					_ScalableVectorGraphics = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeScalableVectorGraphics")!;
				return _ScalableVectorGraphics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Script;
		/// <summary>Represents the value associated with the constant kUTTypeScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Script {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Script is null)
					_Script = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeScript")!;
				return _Script;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShellScript;
		/// <summary>Represents the value associated with the constant kUTTypeShellScript</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeShellScript",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ShellScript {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ShellScript is null)
					_ShellScript = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeShellScript")!;
				return _ShellScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceCode;
		/// <summary>Represents the value associated with the constant kUTTypeSourceCode</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeSourceCode",  "CoreServices")]
		public static NSString SourceCode {
			get {
				if (_SourceCode is null)
					_SourceCode = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSourceCode")!;
				return _SourceCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpotlightImporter;
		/// <summary>Represents the value associated with the constant kUTTypeSpotlightImporter</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeSpotlightImporter",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SpotlightImporter {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SpotlightImporter is null)
					_SpotlightImporter = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSpotlightImporter")!;
				return _SpotlightImporter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Spreadsheet;
		/// <summary>Represents the value associated with the constant kUTTypeSpreadsheet</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeSpreadsheet",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Spreadsheet {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Spreadsheet is null)
					_Spreadsheet = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSpreadsheet")!;
				return _Spreadsheet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Stereolithography;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTypeStereolithography",  "ModelIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Stereolithography {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Stereolithography is null)
					_Stereolithography = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTTypeStereolithography")!;
				return _Stereolithography;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SwiftSource;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTypeSwiftSource",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SwiftSource {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SwiftSource is null)
					_SwiftSource = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSwiftSource")!;
				return _SwiftSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SymLink;
		/// <summary>Represents the value associated with the constant kUTTypeSymLink</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeSymLink",  "CoreServices")]
		public static NSString SymLink {
			get {
				if (_SymLink is null)
					_SymLink = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSymLink")!;
				return _SymLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemPreferencesPane;
		/// <summary>Represents the value associated with the constant kUTTypeSystemPreferencesPane</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeSystemPreferencesPane",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString SystemPreferencesPane {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_SystemPreferencesPane is null)
					_SystemPreferencesPane = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeSystemPreferencesPane")!;
				return _SystemPreferencesPane;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TIFF;
		/// <summary>Represents the value associated with the constant kUTTypeTIFF</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeTIFF",  "CoreServices")]
		public static NSString TIFF {
			get {
				if (_TIFF is null)
					_TIFF = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeTIFF")!;
				return _TIFF;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TXNTextAndMultimediaData;
		/// <summary>Represents the value associated with the constant kUTTypeTXNTextAndMultimediaData</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeTXNTextAndMultimediaData",  "CoreServices")]
		public static NSString TXNTextAndMultimediaData {
			get {
				if (_TXNTextAndMultimediaData is null)
					_TXNTextAndMultimediaData = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeTXNTextAndMultimediaData")!;
				return _TXNTextAndMultimediaData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TabSeparatedText;
		/// <summary>Represents the value associated with the constant kUTTypeTabSeparatedText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeTabSeparatedText",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TabSeparatedText {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TabSeparatedText is null)
					_TabSeparatedText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeTabSeparatedText")!;
				return _TabSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TagClassFilenameExtension;
		/// <summary>Represents the value associated with the constant kUTTagClassFilenameExtension</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTagClassFilenameExtension",  "CoreServices")]
		public static NSString TagClassFilenameExtension {
			get {
				if (_TagClassFilenameExtension is null)
					_TagClassFilenameExtension = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTagClassFilenameExtension")!;
				return _TagClassFilenameExtension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TagClassMIMEType;
		/// <summary>Represents the value associated with the constant kUTTagClassMIMEType</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTagClassMIMEType",  "CoreServices")]
		public static NSString TagClassMIMEType {
			get {
				if (_TagClassMIMEType is null)
					_TagClassMIMEType = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTagClassMIMEType")!;
				return _TagClassMIMEType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TagClassNSPboardType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTagClassNSPboardType",  "CoreServices")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString TagClassNSPboardType {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TagClassNSPboardType is null)
					_TagClassNSPboardType = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTagClassNSPboardType")!;
				return _TagClassNSPboardType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TagClassOSType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTagClassOSType",  "CoreServices")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString TagClassOSType {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TagClassOSType is null)
					_TagClassOSType = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTagClassOSType")!;
				return _TagClassOSType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TagSpecificationKey;
		/// <summary>Represents the value associated with the constant kUTTypeTagSpecificationKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeTagSpecificationKey",  "CoreServices")]
		public static NSString TagSpecificationKey {
			get {
				if (_TagSpecificationKey is null)
					_TagSpecificationKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeTagSpecificationKey")!;
				return _TagSpecificationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Text;
		/// <summary>Represents the value associated with the constant kUTTypeText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeText",  "CoreServices")]
		public static NSString Text {
			get {
				if (_Text is null)
					_Text = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeText")!;
				return _Text;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThreeDContent;
		/// <summary>Represents the value associated with the constant kUTType3DContent</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTType3DContent",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ThreeDContent {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ThreeDContent is null)
					_ThreeDContent = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTType3DContent")!;
				return _ThreeDContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ToDoItem;
		/// <summary>Represents the value associated with the constant kUTTypeToDoItem</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeToDoItem",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ToDoItem {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ToDoItem is null)
					_ToDoItem = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeToDoItem")!;
				return _ToDoItem;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _URL;
		/// <summary>Represents the value associated with the constant kUTTypeURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeURL",  "CoreServices")]
		public static NSString URL {
			get {
				if (_URL is null)
					_URL = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeURL")!;
				return _URL;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _URLBookmarkData;
		/// <summary>Represents the value associated with the constant kUTTypeURLBookmarkData</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeURLBookmarkData",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString URLBookmarkData {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_URLBookmarkData is null)
					_URLBookmarkData = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeURLBookmarkData")!;
				return _URLBookmarkData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UTF16ExternalPlainText;
		/// <summary>Represents the value associated with the constant kUTTypeUTF16ExternalPlainText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeUTF16ExternalPlainText",  "CoreServices")]
		public static NSString UTF16ExternalPlainText {
			get {
				if (_UTF16ExternalPlainText is null)
					_UTF16ExternalPlainText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeUTF16ExternalPlainText")!;
				return _UTF16ExternalPlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UTF16PlainText;
		/// <summary>Represents the value associated with the constant kUTTypeUTF16PlainText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeUTF16PlainText",  "CoreServices")]
		public static NSString UTF16PlainText {
			get {
				if (_UTF16PlainText is null)
					_UTF16PlainText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeUTF16PlainText")!;
				return _UTF16PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UTF8PlainText;
		/// <summary>Represents the value associated with the constant kUTTypeUTF8PlainText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeUTF8PlainText",  "CoreServices")]
		public static NSString UTF8PlainText {
			get {
				if (_UTF8PlainText is null)
					_UTF8PlainText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeUTF8PlainText")!;
				return _UTF8PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UTF8TabSeparatedText;
		/// <summary>Represents the value associated with the constant kUTTypeUTF8TabSeparatedText</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeUTF8TabSeparatedText",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UTF8TabSeparatedText {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UTF8TabSeparatedText is null)
					_UTF8TabSeparatedText = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeUTF8TabSeparatedText")!;
				return _UTF8TabSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UniversalSceneDescription;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTTypeUniversalSceneDescription",  "ModelIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UniversalSceneDescription {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UniversalSceneDescription is null)
					_UniversalSceneDescription = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTTypeUniversalSceneDescription")!;
				return _UniversalSceneDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UniversalSceneDescriptionMobile;
		/// <summary>Represents the value associated with the constant 'kUTTypeUniversalSceneDescriptionMobile'.</summary>
		[Field ("kUTTypeUniversalSceneDescriptionMobile",  "ModelIO")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString UniversalSceneDescriptionMobile {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UniversalSceneDescriptionMobile is null)
					_UniversalSceneDescriptionMobile = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTTypeUniversalSceneDescriptionMobile")!;
				return _UniversalSceneDescriptionMobile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnixExecutable;
		/// <summary>Represents the value associated with the constant kUTTypeUnixExecutable</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeUnixExecutable",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UnixExecutable {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UnixExecutable is null)
					_UnixExecutable = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeUnixExecutable")!;
				return _UnixExecutable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VCard;
		/// <summary>Represents the value associated with the constant kUTTypeVCard</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeVCard",  "CoreServices")]
		public static NSString VCard {
			get {
				if (_VCard is null)
					_VCard = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeVCard")!;
				return _VCard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VersionKey;
		/// <summary>Represents the value associated with the constant kUTTypeVersionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeVersionKey",  "CoreServices")]
		public static NSString VersionKey {
			get {
				if (_VersionKey is null)
					_VersionKey = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeVersionKey")!;
				return _VersionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Video;
		/// <summary>Represents the value associated with the constant kUTTypeVideo</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeVideo",  "CoreServices")]
		public static NSString Video {
			get {
				if (_Video is null)
					_Video = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeVideo")!;
				return _Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Volume;
		/// <summary>Represents the value associated with the constant kUTTypeVolume</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeVolume",  "CoreServices")]
		public static NSString Volume {
			get {
				if (_Volume is null)
					_Volume = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeVolume")!;
				return _Volume;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WaveformAudio;
		/// <summary>Represents the value associated with the constant kUTTypeWaveformAudio</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeWaveformAudio",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString WaveformAudio {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_WaveformAudio is null)
					_WaveformAudio = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeWaveformAudio")!;
				return _WaveformAudio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WebArchive;
		/// <summary>Represents the value associated with the constant kUTTypeWebArchive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeWebArchive",  "CoreServices")]
		public static NSString WebArchive {
			get {
				if (_WebArchive is null)
					_WebArchive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeWebArchive")!;
				return _WebArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowsExecutable;
		/// <summary>Represents the value associated with the constant kUTTypeWindowsExecutable</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeWindowsExecutable",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString WindowsExecutable {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_WindowsExecutable is null)
					_WindowsExecutable = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeWindowsExecutable")!;
				return _WindowsExecutable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _X509Certificate;
		/// <summary>Represents the value associated with the constant kUTTypeX509Certificate</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeX509Certificate",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString X509Certificate {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_X509Certificate is null)
					_X509Certificate = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeX509Certificate")!;
				return _X509Certificate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XML;
		/// <summary>Represents the value associated with the constant kUTTypeXML</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeXML",  "CoreServices")]
		public static NSString XML {
			get {
				if (_XML is null)
					_XML = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeXML")!;
				return _XML;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XMLPropertyList;
		/// <summary>Represents the value associated with the constant kUTTypeXMLPropertyList</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeXMLPropertyList",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString XMLPropertyList {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_XMLPropertyList is null)
					_XMLPropertyList = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeXMLPropertyList")!;
				return _XMLPropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _XPCService;
		/// <summary>Represents the value associated with the constant kUTTypeXPCService</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeXPCService",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString XPCService {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_XPCService is null)
					_XPCService = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeXPCService")!;
				return _XPCService;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ZipArchive;
		/// <summary>Represents the value associated with the constant kUTTypeZipArchive</summary><value></value><remarks>To be added.</remarks>
		[Field ("kUTTypeZipArchive",  "CoreServices")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ZipArchive {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ZipArchive is null)
					_ZipArchive = Dlfcn.GetStringConstant (Libraries.CoreServices.Handle, "kUTTypeZipArchive")!;
				return _ZipArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _k3dObject;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kUTType3dObject",  "ModelIO")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString k3dObject {
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("ios14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("macos12.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_k3dObject is null)
					_k3dObject = Dlfcn.GetStringConstant (Libraries.ModelIO.Handle, "kUTType3dObject")!;
				return _k3dObject;
			}
		}
	} /* class UTType */
}
