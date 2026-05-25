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
namespace UniformTypeIdentifiers {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class UTTypes  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ARReferenceObject;
		/// <summary>Represents the value associated with the constant 'UTTypeARReferenceObject'.</summary>
		[Field ("UTTypeARReferenceObject",  "UniformTypeIdentifiers")]
		public static UTType ARReferenceObject {
			get {
				if (_ARReferenceObject is null)
					_ARReferenceObject = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeARReferenceObject"))!;
				return _ARReferenceObject;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Ahap;
		/// <summary>Represents the value associated with the constant 'UTTypeAHAP'.</summary>
		[Field ("UTTypeAHAP",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public static UTType Ahap {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("ios17.0")]
			get {
				if (_Ahap is null)
					_Ahap = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAHAP"))!;
				return _Ahap;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Aiff;
		/// <summary>Represents the value associated with the constant 'UTTypeAIFF'.</summary>
		[Field ("UTTypeAIFF",  "UniformTypeIdentifiers")]
		public static UTType Aiff {
			get {
				if (_Aiff is null)
					_Aiff = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAIFF"))!;
				return _Aiff;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AliasFile;
		/// <summary>Represents the value associated with the constant 'UTTypeAliasFile'.</summary>
		[Field ("UTTypeAliasFile",  "UniformTypeIdentifiers")]
		public static UTType AliasFile {
			get {
				if (_AliasFile is null)
					_AliasFile = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAliasFile"))!;
				return _AliasFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AppleArchive;
		/// <summary>Represents the value associated with the constant 'UTTypeAppleArchive'.</summary>
		[Field ("UTTypeAppleArchive",  "UniformTypeIdentifiers")]
		public static UTType AppleArchive {
			get {
				if (_AppleArchive is null)
					_AppleArchive = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAppleArchive"))!;
				return _AppleArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AppleProtectedMpeg4Audio;
		/// <summary>Represents the value associated with the constant 'UTTypeAppleProtectedMPEG4Audio'.</summary>
		[Field ("UTTypeAppleProtectedMPEG4Audio",  "UniformTypeIdentifiers")]
		public static UTType AppleProtectedMpeg4Audio {
			get {
				if (_AppleProtectedMpeg4Audio is null)
					_AppleProtectedMpeg4Audio = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAppleProtectedMPEG4Audio"))!;
				return _AppleProtectedMpeg4Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AppleProtectedMpeg4Video;
		/// <summary>Represents the value associated with the constant 'UTTypeAppleProtectedMPEG4Video'.</summary>
		[Field ("UTTypeAppleProtectedMPEG4Video",  "UniformTypeIdentifiers")]
		public static UTType AppleProtectedMpeg4Video {
			get {
				if (_AppleProtectedMpeg4Video is null)
					_AppleProtectedMpeg4Video = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAppleProtectedMPEG4Video"))!;
				return _AppleProtectedMpeg4Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AppleScript;
		/// <summary>Represents the value associated with the constant 'UTTypeAppleScript'.</summary>
		[Field ("UTTypeAppleScript",  "UniformTypeIdentifiers")]
		public static UTType AppleScript {
			get {
				if (_AppleScript is null)
					_AppleScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAppleScript"))!;
				return _AppleScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Application;
		/// <summary>Represents the value associated with the constant 'UTTypeApplication'.</summary>
		[Field ("UTTypeApplication",  "UniformTypeIdentifiers")]
		public static UTType Application {
			get {
				if (_Application is null)
					_Application = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeApplication"))!;
				return _Application;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ApplicationBundle;
		/// <summary>Represents the value associated with the constant 'UTTypeApplicationBundle'.</summary>
		[Field ("UTTypeApplicationBundle",  "UniformTypeIdentifiers")]
		public static UTType ApplicationBundle {
			get {
				if (_ApplicationBundle is null)
					_ApplicationBundle = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeApplicationBundle"))!;
				return _ApplicationBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ApplicationExtension;
		/// <summary>Represents the value associated with the constant 'UTTypeApplicationExtension'.</summary>
		[Field ("UTTypeApplicationExtension",  "UniformTypeIdentifiers")]
		public static UTType ApplicationExtension {
			get {
				if (_ApplicationExtension is null)
					_ApplicationExtension = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeApplicationExtension"))!;
				return _ApplicationExtension;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Archive;
		/// <summary>Represents the value associated with the constant 'UTTypeArchive'.</summary>
		[Field ("UTTypeArchive",  "UniformTypeIdentifiers")]
		public static UTType Archive {
			get {
				if (_Archive is null)
					_Archive = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeArchive"))!;
				return _Archive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AssemblyLanguageSource;
		/// <summary>Represents the value associated with the constant 'UTTypeAssemblyLanguageSource'.</summary>
		[Field ("UTTypeAssemblyLanguageSource",  "UniformTypeIdentifiers")]
		public static UTType AssemblyLanguageSource {
			get {
				if (_AssemblyLanguageSource is null)
					_AssemblyLanguageSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAssemblyLanguageSource"))!;
				return _AssemblyLanguageSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Audio;
		/// <summary>Represents the value associated with the constant 'UTTypeAudio'.</summary>
		[Field ("UTTypeAudio",  "UniformTypeIdentifiers")]
		public static UTType Audio {
			get {
				if (_Audio is null)
					_Audio = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAudio"))!;
				return _Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _AudiovisualContent;
		/// <summary>Represents the value associated with the constant 'UTTypeAudiovisualContent'.</summary>
		[Field ("UTTypeAudiovisualContent",  "UniformTypeIdentifiers")]
		public static UTType AudiovisualContent {
			get {
				if (_AudiovisualContent is null)
					_AudiovisualContent = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAudiovisualContent"))!;
				return _AudiovisualContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Avi;
		/// <summary>Represents the value associated with the constant 'UTTypeAVI'.</summary>
		[Field ("UTTypeAVI",  "UniformTypeIdentifiers")]
		public static UTType Avi {
			get {
				if (_Avi is null)
					_Avi = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeAVI"))!;
				return _Avi;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _BZ2;
		/// <summary>Represents the value associated with the constant 'UTTypeBZ2'.</summary>
		[Field ("UTTypeBZ2",  "UniformTypeIdentifiers")]
		public static UTType BZ2 {
			get {
				if (_BZ2 is null)
					_BZ2 = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeBZ2"))!;
				return _BZ2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _BinaryPropertyList;
		/// <summary>Represents the value associated with the constant 'UTTypeBinaryPropertyList'.</summary>
		[Field ("UTTypeBinaryPropertyList",  "UniformTypeIdentifiers")]
		public static UTType BinaryPropertyList {
			get {
				if (_BinaryPropertyList is null)
					_BinaryPropertyList = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeBinaryPropertyList"))!;
				return _BinaryPropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Bmp;
		/// <summary>Represents the value associated with the constant 'UTTypeBMP'.</summary>
		[Field ("UTTypeBMP",  "UniformTypeIdentifiers")]
		public static UTType Bmp {
			get {
				if (_Bmp is null)
					_Bmp = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeBMP"))!;
				return _Bmp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Bookmark;
		/// <summary>Represents the value associated with the constant 'UTTypeBookmark'.</summary>
		[Field ("UTTypeBookmark",  "UniformTypeIdentifiers")]
		public static UTType Bookmark {
			get {
				if (_Bookmark is null)
					_Bookmark = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeBookmark"))!;
				return _Bookmark;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Bundle;
		/// <summary>Represents the value associated with the constant 'UTTypeBundle'.</summary>
		[Field ("UTTypeBundle",  "UniformTypeIdentifiers")]
		public static UTType Bundle {
			get {
				if (_Bundle is null)
					_Bundle = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeBundle"))!;
				return _Bundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CHeader;
		/// <summary>Represents the value associated with the constant 'UTTypeCHeader'.</summary>
		[Field ("UTTypeCHeader",  "UniformTypeIdentifiers")]
		public static UTType CHeader {
			get {
				if (_CHeader is null)
					_CHeader = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCHeader"))!;
				return _CHeader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CPlusPlusHeader;
		/// <summary>Represents the value associated with the constant 'UTTypeCPlusPlusHeader'.</summary>
		[Field ("UTTypeCPlusPlusHeader",  "UniformTypeIdentifiers")]
		public static UTType CPlusPlusHeader {
			get {
				if (_CPlusPlusHeader is null)
					_CPlusPlusHeader = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCPlusPlusHeader"))!;
				return _CPlusPlusHeader;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CPlusPlusSource;
		/// <summary>Represents the value associated with the constant 'UTTypeCPlusPlusSource'.</summary>
		[Field ("UTTypeCPlusPlusSource",  "UniformTypeIdentifiers")]
		public static UTType CPlusPlusSource {
			get {
				if (_CPlusPlusSource is null)
					_CPlusPlusSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCPlusPlusSource"))!;
				return _CPlusPlusSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CSource;
		/// <summary>Represents the value associated with the constant 'UTTypeCSource'.</summary>
		[Field ("UTTypeCSource",  "UniformTypeIdentifiers")]
		public static UTType CSource {
			get {
				if (_CSource is null)
					_CSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCSource"))!;
				return _CSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CalendarEvent;
		/// <summary>Represents the value associated with the constant 'UTTypeCalendarEvent'.</summary>
		[Field ("UTTypeCalendarEvent",  "UniformTypeIdentifiers")]
		public static UTType CalendarEvent {
			get {
				if (_CalendarEvent is null)
					_CalendarEvent = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCalendarEvent"))!;
				return _CalendarEvent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CommaSeparatedText;
		/// <summary>Represents the value associated with the constant 'UTTypeCommaSeparatedText'.</summary>
		[Field ("UTTypeCommaSeparatedText",  "UniformTypeIdentifiers")]
		public static UTType CommaSeparatedText {
			get {
				if (_CommaSeparatedText is null)
					_CommaSeparatedText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCommaSeparatedText"))!;
				return _CommaSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _CompositeContent;
		/// <summary>Represents the value associated with the constant 'UTTypeCompositeContent'.</summary>
		[Field ("UTTypeCompositeContent",  "UniformTypeIdentifiers")]
		public static UTType CompositeContent {
			get {
				if (_CompositeContent is null)
					_CompositeContent = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCompositeContent"))!;
				return _CompositeContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Contact;
		/// <summary>Represents the value associated with the constant 'UTTypeContact'.</summary>
		[Field ("UTTypeContact",  "UniformTypeIdentifiers")]
		public static UTType Contact {
			get {
				if (_Contact is null)
					_Contact = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeContact"))!;
				return _Contact;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Content;
		/// <summary>Represents the value associated with the constant 'UTTypeContent'.</summary>
		[Field ("UTTypeContent",  "UniformTypeIdentifiers")]
		public static UTType Content {
			get {
				if (_Content is null)
					_Content = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeContent"))!;
				return _Content;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Css;
		/// <summary>Represents the value associated with the constant 'UTTypeCSS'.</summary>
		[Field ("UTTypeCSS",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType Css {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_Css is null)
					_Css = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeCSS"))!;
				return _Css;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Data;
		/// <summary>Represents the value associated with the constant 'UTTypeData'.</summary>
		[Field ("UTTypeData",  "UniformTypeIdentifiers")]
		public static UTType Data {
			get {
				if (_Data is null)
					_Data = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeData"))!;
				return _Data;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Database;
		/// <summary>Represents the value associated with the constant 'UTTypeDatabase'.</summary>
		[Field ("UTTypeDatabase",  "UniformTypeIdentifiers")]
		public static UTType Database {
			get {
				if (_Database is null)
					_Database = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeDatabase"))!;
				return _Database;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _DelimitedText;
		/// <summary>Represents the value associated with the constant 'UTTypeDelimitedText'.</summary>
		[Field ("UTTypeDelimitedText",  "UniformTypeIdentifiers")]
		public static UTType DelimitedText {
			get {
				if (_DelimitedText is null)
					_DelimitedText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeDelimitedText"))!;
				return _DelimitedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Directory;
		/// <summary>Represents the value associated with the constant 'UTTypeDirectory'.</summary>
		[Field ("UTTypeDirectory",  "UniformTypeIdentifiers")]
		public static UTType Directory {
			get {
				if (_Directory is null)
					_Directory = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeDirectory"))!;
				return _Directory;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _DiskImage;
		/// <summary>Represents the value associated with the constant 'UTTypeDiskImage'.</summary>
		[Field ("UTTypeDiskImage",  "UniformTypeIdentifiers")]
		public static UTType DiskImage {
			get {
				if (_DiskImage is null)
					_DiskImage = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeDiskImage"))!;
				return _DiskImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Dng;
		/// <summary>Represents the value associated with the constant 'UTTypeDNG'.</summary>
		[Field ("UTTypeDNG",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType Dng {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_Dng is null)
					_Dng = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeDNG"))!;
				return _Dng;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _EmailMessage;
		/// <summary>Represents the value associated with the constant 'UTTypeEmailMessage'.</summary>
		[Field ("UTTypeEmailMessage",  "UniformTypeIdentifiers")]
		public static UTType EmailMessage {
			get {
				if (_EmailMessage is null)
					_EmailMessage = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeEmailMessage"))!;
				return _EmailMessage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Epub;
		/// <summary>Represents the value associated with the constant 'UTTypeEPUB'.</summary>
		[Field ("UTTypeEPUB",  "UniformTypeIdentifiers")]
		public static UTType Epub {
			get {
				if (_Epub is null)
					_Epub = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeEPUB"))!;
				return _Epub;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Exe;
		/// <summary>Represents the value associated with the constant 'UTTypeEXE'.</summary>
		[Field ("UTTypeEXE",  "UniformTypeIdentifiers")]
		public static UTType Exe {
			get {
				if (_Exe is null)
					_Exe = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeEXE"))!;
				return _Exe;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Executable;
		/// <summary>Represents the value associated with the constant 'UTTypeExecutable'.</summary>
		[Field ("UTTypeExecutable",  "UniformTypeIdentifiers")]
		public static UTType Executable {
			get {
				if (_Executable is null)
					_Executable = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeExecutable"))!;
				return _Executable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Exr;
		/// <summary>Represents the value associated with the constant 'UTTypeEXR'.</summary>
		[Field ("UTTypeEXR",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType Exr {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_Exr is null)
					_Exr = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeEXR"))!;
				return _Exr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _FileUrl;
		/// <summary>Represents the value associated with the constant 'UTTypeFileURL'.</summary>
		[Field ("UTTypeFileURL",  "UniformTypeIdentifiers")]
		public static UTType FileUrl {
			get {
				if (_FileUrl is null)
					_FileUrl = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeFileURL"))!;
				return _FileUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _FlatRtfd;
		/// <summary>Represents the value associated with the constant 'UTTypeFlatRTFD'.</summary>
		[Field ("UTTypeFlatRTFD",  "UniformTypeIdentifiers")]
		public static UTType FlatRtfd {
			get {
				if (_FlatRtfd is null)
					_FlatRtfd = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeFlatRTFD"))!;
				return _FlatRtfd;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Folder;
		/// <summary>Represents the value associated with the constant 'UTTypeFolder'.</summary>
		[Field ("UTTypeFolder",  "UniformTypeIdentifiers")]
		public static UTType Folder {
			get {
				if (_Folder is null)
					_Folder = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeFolder"))!;
				return _Folder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Font;
		/// <summary>Represents the value associated with the constant 'UTTypeFont'.</summary>
		[Field ("UTTypeFont",  "UniformTypeIdentifiers")]
		public static UTType Font {
			get {
				if (_Font is null)
					_Font = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeFont"))!;
				return _Font;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Framework;
		/// <summary>Represents the value associated with the constant 'UTTypeFramework'.</summary>
		[Field ("UTTypeFramework",  "UniformTypeIdentifiers")]
		public static UTType Framework {
			get {
				if (_Framework is null)
					_Framework = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeFramework"))!;
				return _Framework;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _GeoJson;
		/// <summary>Represents the value associated with the constant 'UTTypeGeoJSON'.</summary>
		[Field ("UTTypeGeoJSON",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType GeoJson {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_GeoJson is null)
					_GeoJson = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeGeoJSON"))!;
				return _GeoJson;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Gif;
		/// <summary>Represents the value associated with the constant 'UTTypeGIF'.</summary>
		[Field ("UTTypeGIF",  "UniformTypeIdentifiers")]
		public static UTType Gif {
			get {
				if (_Gif is null)
					_Gif = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeGIF"))!;
				return _Gif;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Gzip;
		/// <summary>Represents the value associated with the constant 'UTTypeGZIP'.</summary>
		[Field ("UTTypeGZIP",  "UniformTypeIdentifiers")]
		public static UTType Gzip {
			get {
				if (_Gzip is null)
					_Gzip = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeGZIP"))!;
				return _Gzip;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Heic;
		/// <summary>Represents the value associated with the constant 'UTTypeHEIC'.</summary>
		[Field ("UTTypeHEIC",  "UniformTypeIdentifiers")]
		public static UTType Heic {
			get {
				if (_Heic is null)
					_Heic = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeHEIC"))!;
				return _Heic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Heics;
		/// <summary>Represents the value associated with the constant 'UTTypeHEICS'.</summary>
		[Field ("UTTypeHEICS",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType Heics {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_Heics is null)
					_Heics = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeHEICS"))!;
				return _Heics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Heif;
		/// <summary>Represents the value associated with the constant 'UTTypeHEIF'.</summary>
		[Field ("UTTypeHEIF",  "UniformTypeIdentifiers")]
		public static UTType Heif {
			get {
				if (_Heif is null)
					_Heif = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeHEIF"))!;
				return _Heif;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Html;
		/// <summary>Represents the value associated with the constant 'UTTypeHTML'.</summary>
		[Field ("UTTypeHTML",  "UniformTypeIdentifiers")]
		public static UTType Html {
			get {
				if (_Html is null)
					_Html = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeHTML"))!;
				return _Html;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Icns;
		/// <summary>Represents the value associated with the constant 'UTTypeICNS'.</summary>
		[Field ("UTTypeICNS",  "UniformTypeIdentifiers")]
		public static UTType Icns {
			get {
				if (_Icns is null)
					_Icns = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeICNS"))!;
				return _Icns;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Ico;
		/// <summary>Represents the value associated with the constant 'UTTypeICO'.</summary>
		[Field ("UTTypeICO",  "UniformTypeIdentifiers")]
		public static UTType Ico {
			get {
				if (_Ico is null)
					_Ico = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeICO"))!;
				return _Ico;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Image;
		/// <summary>Represents the value associated with the constant 'UTTypeImage'.</summary>
		[Field ("UTTypeImage",  "UniformTypeIdentifiers")]
		public static UTType Image {
			get {
				if (_Image is null)
					_Image = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeImage"))!;
				return _Image;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _InternetLocation;
		/// <summary>Represents the value associated with the constant 'UTTypeInternetLocation'.</summary>
		[Field ("UTTypeInternetLocation",  "UniformTypeIdentifiers")]
		public static UTType InternetLocation {
			get {
				if (_InternetLocation is null)
					_InternetLocation = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeInternetLocation"))!;
				return _InternetLocation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Item;
		/// <summary>Represents the value associated with the constant 'UTTypeItem'.</summary>
		[Field ("UTTypeItem",  "UniformTypeIdentifiers")]
		public static UTType Item {
			get {
				if (_Item is null)
					_Item = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeItem"))!;
				return _Item;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _JavaScript;
		/// <summary>Represents the value associated with the constant 'UTTypeJavaScript'.</summary>
		[Field ("UTTypeJavaScript",  "UniformTypeIdentifiers")]
		public static UTType JavaScript {
			get {
				if (_JavaScript is null)
					_JavaScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeJavaScript"))!;
				return _JavaScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Jpeg;
		/// <summary>Represents the value associated with the constant 'UTTypeJPEG'.</summary>
		[Field ("UTTypeJPEG",  "UniformTypeIdentifiers")]
		public static UTType Jpeg {
			get {
				if (_Jpeg is null)
					_Jpeg = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeJPEG"))!;
				return _Jpeg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _JpegXl;
		/// <summary>Represents the value associated with the constant 'UTTypeJPEGXL'.</summary>
		[Field ("UTTypeJPEGXL",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public static UTType JpegXl {
			[SupportedOSPlatform ("tvos18.2")]
			[SupportedOSPlatform ("macos15.2")]
			[SupportedOSPlatform ("ios18.2")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			get {
				if (_JpegXl is null)
					_JpegXl = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeJPEGXL"))!;
				return _JpegXl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Json;
		/// <summary>Represents the value associated with the constant 'UTTypeJSON'.</summary>
		[Field ("UTTypeJSON",  "UniformTypeIdentifiers")]
		public static UTType Json {
			get {
				if (_Json is null)
					_Json = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeJSON"))!;
				return _Json;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _LinkPresentationMetadata;
		/// <summary>Represents the value associated with the constant 'UTTypeLinkPresentationMetadata'.</summary>
		[Field ("UTTypeLinkPresentationMetadata",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType LinkPresentationMetadata {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_LinkPresentationMetadata is null)
					_LinkPresentationMetadata = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeLinkPresentationMetadata"))!;
				return _LinkPresentationMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _LivePhoto;
		/// <summary>Represents the value associated with the constant 'UTTypeLivePhoto'.</summary>
		[Field ("UTTypeLivePhoto",  "UniformTypeIdentifiers")]
		public static UTType LivePhoto {
			get {
				if (_LivePhoto is null)
					_LivePhoto = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeLivePhoto"))!;
				return _LivePhoto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Log;
		/// <summary>Represents the value associated with the constant 'UTTypeLog'.</summary>
		[Field ("UTTypeLog",  "UniformTypeIdentifiers")]
		public static UTType Log {
			get {
				if (_Log is null)
					_Log = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeLog"))!;
				return _Log;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _M3uPlaylist;
		/// <summary>Represents the value associated with the constant 'UTTypeM3UPlaylist'.</summary>
		[Field ("UTTypeM3UPlaylist",  "UniformTypeIdentifiers")]
		public static UTType M3uPlaylist {
			get {
				if (_M3uPlaylist is null)
					_M3uPlaylist = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeM3UPlaylist"))!;
				return _M3uPlaylist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _MP3;
		/// <summary>Represents the value associated with the constant 'UTTypeMP3'.</summary>
		[Field ("UTTypeMP3",  "UniformTypeIdentifiers")]
		public static UTType MP3 {
			get {
				if (_MP3 is null)
					_MP3 = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMP3"))!;
				return _MP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Makefile;
		/// <summary>Represents the value associated with the constant 'UTTypeMakefile'.</summary>
		[Field ("UTTypeMakefile",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static UTType Makefile {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Makefile is null)
					_Makefile = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMakefile"))!;
				return _Makefile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Message;
		/// <summary>Represents the value associated with the constant 'UTTypeMessage'.</summary>
		[Field ("UTTypeMessage",  "UniformTypeIdentifiers")]
		public static UTType Message {
			get {
				if (_Message is null)
					_Message = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMessage"))!;
				return _Message;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Midi;
		/// <summary>Represents the value associated with the constant 'UTTypeMIDI'.</summary>
		[Field ("UTTypeMIDI",  "UniformTypeIdentifiers")]
		public static UTType Midi {
			get {
				if (_Midi is null)
					_Midi = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMIDI"))!;
				return _Midi;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _MountPoint;
		/// <summary>Represents the value associated with the constant 'UTTypeMountPoint'.</summary>
		[Field ("UTTypeMountPoint",  "UniformTypeIdentifiers")]
		public static UTType MountPoint {
			get {
				if (_MountPoint is null)
					_MountPoint = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMountPoint"))!;
				return _MountPoint;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Movie;
		/// <summary>Represents the value associated with the constant 'UTTypeMovie'.</summary>
		[Field ("UTTypeMovie",  "UniformTypeIdentifiers")]
		public static UTType Movie {
			get {
				if (_Movie is null)
					_Movie = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMovie"))!;
				return _Movie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Mpeg;
		/// <summary>Represents the value associated with the constant 'UTTypeMPEG'.</summary>
		[Field ("UTTypeMPEG",  "UniformTypeIdentifiers")]
		public static UTType Mpeg {
			get {
				if (_Mpeg is null)
					_Mpeg = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMPEG"))!;
				return _Mpeg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Mpeg2TransportStream;
		/// <summary>Represents the value associated with the constant 'UTTypeMPEG2TransportStream'.</summary>
		[Field ("UTTypeMPEG2TransportStream",  "UniformTypeIdentifiers")]
		public static UTType Mpeg2TransportStream {
			get {
				if (_Mpeg2TransportStream is null)
					_Mpeg2TransportStream = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMPEG2TransportStream"))!;
				return _Mpeg2TransportStream;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Mpeg2Video;
		/// <summary>Represents the value associated with the constant 'UTTypeMPEG2Video'.</summary>
		[Field ("UTTypeMPEG2Video",  "UniformTypeIdentifiers")]
		public static UTType Mpeg2Video {
			get {
				if (_Mpeg2Video is null)
					_Mpeg2Video = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMPEG2Video"))!;
				return _Mpeg2Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Mpeg4Audio;
		/// <summary>Represents the value associated with the constant 'UTTypeMPEG4Audio'.</summary>
		[Field ("UTTypeMPEG4Audio",  "UniformTypeIdentifiers")]
		public static UTType Mpeg4Audio {
			get {
				if (_Mpeg4Audio is null)
					_Mpeg4Audio = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMPEG4Audio"))!;
				return _Mpeg4Audio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Mpeg4Movie;
		/// <summary>Represents the value associated with the constant 'UTTypeMPEG4Movie'.</summary>
		[Field ("UTTypeMPEG4Movie",  "UniformTypeIdentifiers")]
		public static UTType Mpeg4Movie {
			get {
				if (_Mpeg4Movie is null)
					_Mpeg4Movie = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeMPEG4Movie"))!;
				return _Mpeg4Movie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ObjectiveCPlusPlusSource;
		/// <summary>Represents the value associated with the constant 'UTTypeObjectiveCPlusPlusSource'.</summary>
		[Field ("UTTypeObjectiveCPlusPlusSource",  "UniformTypeIdentifiers")]
		public static UTType ObjectiveCPlusPlusSource {
			get {
				if (_ObjectiveCPlusPlusSource is null)
					_ObjectiveCPlusPlusSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeObjectiveCPlusPlusSource"))!;
				return _ObjectiveCPlusPlusSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ObjectiveCSource;
		/// <summary>Represents the value associated with the constant 'UTTypeObjectiveCSource'.</summary>
		[Field ("UTTypeObjectiveCSource",  "UniformTypeIdentifiers")]
		public static UTType ObjectiveCSource {
			get {
				if (_ObjectiveCSource is null)
					_ObjectiveCSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeObjectiveCSource"))!;
				return _ObjectiveCSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _OsaScript;
		/// <summary>Represents the value associated with the constant 'UTTypeOSAScript'.</summary>
		[Field ("UTTypeOSAScript",  "UniformTypeIdentifiers")]
		public static UTType OsaScript {
			get {
				if (_OsaScript is null)
					_OsaScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeOSAScript"))!;
				return _OsaScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _OsaScriptBundle;
		/// <summary>Represents the value associated with the constant 'UTTypeOSAScriptBundle'.</summary>
		[Field ("UTTypeOSAScriptBundle",  "UniformTypeIdentifiers")]
		public static UTType OsaScriptBundle {
			get {
				if (_OsaScriptBundle is null)
					_OsaScriptBundle = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeOSAScriptBundle"))!;
				return _OsaScriptBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Package;
		/// <summary>Represents the value associated with the constant 'UTTypePackage'.</summary>
		[Field ("UTTypePackage",  "UniformTypeIdentifiers")]
		public static UTType Package {
			get {
				if (_Package is null)
					_Package = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePackage"))!;
				return _Package;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Pdf;
		/// <summary>Represents the value associated with the constant 'UTTypePDF'.</summary>
		[Field ("UTTypePDF",  "UniformTypeIdentifiers")]
		public static UTType Pdf {
			get {
				if (_Pdf is null)
					_Pdf = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePDF"))!;
				return _Pdf;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PerlScript;
		/// <summary>Represents the value associated with the constant 'UTTypePerlScript'.</summary>
		[Field ("UTTypePerlScript",  "UniformTypeIdentifiers")]
		public static UTType PerlScript {
			get {
				if (_PerlScript is null)
					_PerlScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePerlScript"))!;
				return _PerlScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PhpScript;
		/// <summary>Represents the value associated with the constant 'UTTypePHPScript'.</summary>
		[Field ("UTTypePHPScript",  "UniformTypeIdentifiers")]
		public static UTType PhpScript {
			get {
				if (_PhpScript is null)
					_PhpScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePHPScript"))!;
				return _PhpScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Pkcs12;
		/// <summary>Represents the value associated with the constant 'UTTypePKCS12'.</summary>
		[Field ("UTTypePKCS12",  "UniformTypeIdentifiers")]
		public static UTType Pkcs12 {
			get {
				if (_Pkcs12 is null)
					_Pkcs12 = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePKCS12"))!;
				return _Pkcs12;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PlainText;
		/// <summary>Represents the value associated with the constant 'UTTypePlainText'.</summary>
		[Field ("UTTypePlainText",  "UniformTypeIdentifiers")]
		public static UTType PlainText {
			get {
				if (_PlainText is null)
					_PlainText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePlainText"))!;
				return _PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Playlist;
		/// <summary>Represents the value associated with the constant 'UTTypePlaylist'.</summary>
		[Field ("UTTypePlaylist",  "UniformTypeIdentifiers")]
		public static UTType Playlist {
			get {
				if (_Playlist is null)
					_Playlist = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePlaylist"))!;
				return _Playlist;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PluginBundle;
		/// <summary>Represents the value associated with the constant 'UTTypePluginBundle'.</summary>
		[Field ("UTTypePluginBundle",  "UniformTypeIdentifiers")]
		public static UTType PluginBundle {
			get {
				if (_PluginBundle is null)
					_PluginBundle = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePluginBundle"))!;
				return _PluginBundle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Png;
		/// <summary>Represents the value associated with the constant 'UTTypePNG'.</summary>
		[Field ("UTTypePNG",  "UniformTypeIdentifiers")]
		public static UTType Png {
			get {
				if (_Png is null)
					_Png = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePNG"))!;
				return _Png;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Presentation;
		/// <summary>Represents the value associated with the constant 'UTTypePresentation'.</summary>
		[Field ("UTTypePresentation",  "UniformTypeIdentifiers")]
		public static UTType Presentation {
			get {
				if (_Presentation is null)
					_Presentation = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePresentation"))!;
				return _Presentation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PropertyList;
		/// <summary>Represents the value associated with the constant 'UTTypePropertyList'.</summary>
		[Field ("UTTypePropertyList",  "UniformTypeIdentifiers")]
		public static UTType PropertyList {
			get {
				if (_PropertyList is null)
					_PropertyList = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePropertyList"))!;
				return _PropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _PythonScript;
		/// <summary>Represents the value associated with the constant 'UTTypePythonScript'.</summary>
		[Field ("UTTypePythonScript",  "UniformTypeIdentifiers")]
		public static UTType PythonScript {
			get {
				if (_PythonScript is null)
					_PythonScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypePythonScript"))!;
				return _PythonScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _QuickLookGenerator;
		/// <summary>Represents the value associated with the constant 'UTTypeQuickLookGenerator'.</summary>
		[Field ("UTTypeQuickLookGenerator",  "UniformTypeIdentifiers")]
		public static UTType QuickLookGenerator {
			get {
				if (_QuickLookGenerator is null)
					_QuickLookGenerator = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeQuickLookGenerator"))!;
				return _QuickLookGenerator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _QuickTimeMovie;
		/// <summary>Represents the value associated with the constant 'UTTypeQuickTimeMovie'.</summary>
		[Field ("UTTypeQuickTimeMovie",  "UniformTypeIdentifiers")]
		public static UTType QuickTimeMovie {
			get {
				if (_QuickTimeMovie is null)
					_QuickTimeMovie = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeQuickTimeMovie"))!;
				return _QuickTimeMovie;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _RawImage;
		/// <summary>Represents the value associated with the constant 'UTTypeRAWImage'.</summary>
		[Field ("UTTypeRAWImage",  "UniformTypeIdentifiers")]
		public static UTType RawImage {
			get {
				if (_RawImage is null)
					_RawImage = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeRAWImage"))!;
				return _RawImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _RealityFile;
		/// <summary>Represents the value associated with the constant 'UTTypeRealityFile'.</summary>
		[Field ("UTTypeRealityFile",  "UniformTypeIdentifiers")]
		public static UTType RealityFile {
			get {
				if (_RealityFile is null)
					_RealityFile = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeRealityFile"))!;
				return _RealityFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Resolvable;
		/// <summary>Represents the value associated with the constant 'UTTypeResolvable'.</summary>
		[Field ("UTTypeResolvable",  "UniformTypeIdentifiers")]
		public static UTType Resolvable {
			get {
				if (_Resolvable is null)
					_Resolvable = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeResolvable"))!;
				return _Resolvable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Rtf;
		/// <summary>Represents the value associated with the constant 'UTTypeRTF'.</summary>
		[Field ("UTTypeRTF",  "UniformTypeIdentifiers")]
		public static UTType Rtf {
			get {
				if (_Rtf is null)
					_Rtf = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeRTF"))!;
				return _Rtf;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Rtfd;
		/// <summary>Represents the value associated with the constant 'UTTypeRTFD'.</summary>
		[Field ("UTTypeRTFD",  "UniformTypeIdentifiers")]
		public static UTType Rtfd {
			get {
				if (_Rtfd is null)
					_Rtfd = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeRTFD"))!;
				return _Rtfd;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _RubyScript;
		/// <summary>Represents the value associated with the constant 'UTTypeRubyScript'.</summary>
		[Field ("UTTypeRubyScript",  "UniformTypeIdentifiers")]
		public static UTType RubyScript {
			get {
				if (_RubyScript is null)
					_RubyScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeRubyScript"))!;
				return _RubyScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SceneKitScene;
		/// <summary>Represents the value associated with the constant 'UTTypeSceneKitScene'.</summary>
		[Field ("UTTypeSceneKitScene",  "UniformTypeIdentifiers")]
		public static UTType SceneKitScene {
			get {
				if (_SceneKitScene is null)
					_SceneKitScene = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSceneKitScene"))!;
				return _SceneKitScene;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Script;
		/// <summary>Represents the value associated with the constant 'UTTypeScript'.</summary>
		[Field ("UTTypeScript",  "UniformTypeIdentifiers")]
		public static UTType Script {
			get {
				if (_Script is null)
					_Script = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeScript"))!;
				return _Script;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ShellScript;
		/// <summary>Represents the value associated with the constant 'UTTypeShellScript'.</summary>
		[Field ("UTTypeShellScript",  "UniformTypeIdentifiers")]
		public static UTType ShellScript {
			get {
				if (_ShellScript is null)
					_ShellScript = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeShellScript"))!;
				return _ShellScript;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Shortcut;
		/// <summary>Represents the value associated with the constant 'UTTypeInternetShortcut'.</summary>
		[Field ("UTTypeInternetShortcut",  "UniformTypeIdentifiers")]
		public static UTType Shortcut {
			get {
				if (_Shortcut is null)
					_Shortcut = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeInternetShortcut"))!;
				return _Shortcut;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SourceCode;
		/// <summary>Represents the value associated with the constant 'UTTypeSourceCode'.</summary>
		[Field ("UTTypeSourceCode",  "UniformTypeIdentifiers")]
		public static UTType SourceCode {
			get {
				if (_SourceCode is null)
					_SourceCode = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSourceCode"))!;
				return _SourceCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SpotlightImporter;
		/// <summary>Represents the value associated with the constant 'UTTypeSpotlightImporter'.</summary>
		[Field ("UTTypeSpotlightImporter",  "UniformTypeIdentifiers")]
		public static UTType SpotlightImporter {
			get {
				if (_SpotlightImporter is null)
					_SpotlightImporter = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSpotlightImporter"))!;
				return _SpotlightImporter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Spreadsheet;
		/// <summary>Represents the value associated with the constant 'UTTypeSpreadsheet'.</summary>
		[Field ("UTTypeSpreadsheet",  "UniformTypeIdentifiers")]
		public static UTType Spreadsheet {
			get {
				if (_Spreadsheet is null)
					_Spreadsheet = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSpreadsheet"))!;
				return _Spreadsheet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Svg;
		/// <summary>Represents the value associated with the constant 'UTTypeSVG'.</summary>
		[Field ("UTTypeSVG",  "UniformTypeIdentifiers")]
		public static UTType Svg {
			get {
				if (_Svg is null)
					_Svg = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSVG"))!;
				return _Svg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SwiftSource;
		/// <summary>Represents the value associated with the constant 'UTTypeSwiftSource'.</summary>
		[Field ("UTTypeSwiftSource",  "UniformTypeIdentifiers")]
		public static UTType SwiftSource {
			get {
				if (_SwiftSource is null)
					_SwiftSource = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSwiftSource"))!;
				return _SwiftSource;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SymbolicLink;
		/// <summary>Represents the value associated with the constant 'UTTypeSymbolicLink'.</summary>
		[Field ("UTTypeSymbolicLink",  "UniformTypeIdentifiers")]
		public static UTType SymbolicLink {
			get {
				if (_SymbolicLink is null)
					_SymbolicLink = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSymbolicLink"))!;
				return _SymbolicLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _SystemPreferencesPane;
		/// <summary>Represents the value associated with the constant 'UTTypeSystemPreferencesPane'.</summary>
		[Field ("UTTypeSystemPreferencesPane",  "UniformTypeIdentifiers")]
		public static UTType SystemPreferencesPane {
			get {
				if (_SystemPreferencesPane is null)
					_SystemPreferencesPane = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeSystemPreferencesPane"))!;
				return _SystemPreferencesPane;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _TabSeparatedText;
		/// <summary>Represents the value associated with the constant 'UTTypeTabSeparatedText'.</summary>
		[Field ("UTTypeTabSeparatedText",  "UniformTypeIdentifiers")]
		public static UTType TabSeparatedText {
			get {
				if (_TabSeparatedText is null)
					_TabSeparatedText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeTabSeparatedText"))!;
				return _TabSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _TarArchive;
		/// <summary>Represents the value associated with the constant 'UTTypeTarArchive'.</summary>
		[Field ("UTTypeTarArchive",  "UniformTypeIdentifiers")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static UTType TarArchive {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_TarArchive is null)
					_TarArchive = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeTarArchive"))!;
				return _TarArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Text;
		/// <summary>Represents the value associated with the constant 'UTTypeText'.</summary>
		[Field ("UTTypeText",  "UniformTypeIdentifiers")]
		public static UTType Text {
			get {
				if (_Text is null)
					_Text = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeText"))!;
				return _Text;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ThreeDContent;
		/// <summary>Represents the value associated with the constant 'UTType3DContent'.</summary>
		[Field ("UTType3DContent",  "UniformTypeIdentifiers")]
		public static UTType ThreeDContent {
			get {
				if (_ThreeDContent is null)
					_ThreeDContent = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTType3DContent"))!;
				return _ThreeDContent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Tiff;
		/// <summary>Represents the value associated with the constant 'UTTypeTIFF'.</summary>
		[Field ("UTTypeTIFF",  "UniformTypeIdentifiers")]
		public static UTType Tiff {
			get {
				if (_Tiff is null)
					_Tiff = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeTIFF"))!;
				return _Tiff;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _ToDoItem;
		/// <summary>Represents the value associated with the constant 'UTTypeToDoItem'.</summary>
		[Field ("UTTypeToDoItem",  "UniformTypeIdentifiers")]
		public static UTType ToDoItem {
			get {
				if (_ToDoItem is null)
					_ToDoItem = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeToDoItem"))!;
				return _ToDoItem;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _UnixExecutable;
		/// <summary>Represents the value associated with the constant 'UTTypeUnixExecutable'.</summary>
		[Field ("UTTypeUnixExecutable",  "UniformTypeIdentifiers")]
		public static UTType UnixExecutable {
			get {
				if (_UnixExecutable is null)
					_UnixExecutable = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUnixExecutable"))!;
				return _UnixExecutable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Url;
		/// <summary>Represents the value associated with the constant 'UTTypeURL'.</summary>
		[Field ("UTTypeURL",  "UniformTypeIdentifiers")]
		public static UTType Url {
			get {
				if (_Url is null)
					_Url = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeURL"))!;
				return _Url;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _UrlBookmarkData;
		/// <summary>Represents the value associated with the constant 'UTTypeURLBookmarkData'.</summary>
		[Field ("UTTypeURLBookmarkData",  "UniformTypeIdentifiers")]
		public static UTType UrlBookmarkData {
			get {
				if (_UrlBookmarkData is null)
					_UrlBookmarkData = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeURLBookmarkData"))!;
				return _UrlBookmarkData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Usd;
		/// <summary>Represents the value associated with the constant 'UTTypeUSD'.</summary>
		[Field ("UTTypeUSD",  "UniformTypeIdentifiers")]
		public static UTType Usd {
			get {
				if (_Usd is null)
					_Usd = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUSD"))!;
				return _Usd;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Usdz;
		/// <summary>Represents the value associated with the constant 'UTTypeUSDZ'.</summary>
		[Field ("UTTypeUSDZ",  "UniformTypeIdentifiers")]
		public static UTType Usdz {
			get {
				if (_Usdz is null)
					_Usdz = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUSDZ"))!;
				return _Usdz;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Utf16ExternalPlainText;
		/// <summary>Represents the value associated with the constant 'UTTypeUTF16ExternalPlainText'.</summary>
		[Field ("UTTypeUTF16ExternalPlainText",  "UniformTypeIdentifiers")]
		public static UTType Utf16ExternalPlainText {
			get {
				if (_Utf16ExternalPlainText is null)
					_Utf16ExternalPlainText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUTF16ExternalPlainText"))!;
				return _Utf16ExternalPlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Utf16PlainText;
		/// <summary>Represents the value associated with the constant 'UTTypeUTF16PlainText'.</summary>
		[Field ("UTTypeUTF16PlainText",  "UniformTypeIdentifiers")]
		public static UTType Utf16PlainText {
			get {
				if (_Utf16PlainText is null)
					_Utf16PlainText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUTF16PlainText"))!;
				return _Utf16PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Utf8PlainText;
		/// <summary>Represents the value associated with the constant 'UTTypeUTF8PlainText'.</summary>
		[Field ("UTTypeUTF8PlainText",  "UniformTypeIdentifiers")]
		public static UTType Utf8PlainText {
			get {
				if (_Utf8PlainText is null)
					_Utf8PlainText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUTF8PlainText"))!;
				return _Utf8PlainText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Utf8TabSeparatedText;
		/// <summary>Represents the value associated with the constant 'UTTypeUTF8TabSeparatedText'.</summary>
		[Field ("UTTypeUTF8TabSeparatedText",  "UniformTypeIdentifiers")]
		public static UTType Utf8TabSeparatedText {
			get {
				if (_Utf8TabSeparatedText is null)
					_Utf8TabSeparatedText = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeUTF8TabSeparatedText"))!;
				return _Utf8TabSeparatedText;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _VCard;
		/// <summary>Represents the value associated with the constant 'UTTypeVCard'.</summary>
		[Field ("UTTypeVCard",  "UniformTypeIdentifiers")]
		public static UTType VCard {
			get {
				if (_VCard is null)
					_VCard = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeVCard"))!;
				return _VCard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Video;
		/// <summary>Represents the value associated with the constant 'UTTypeVideo'.</summary>
		[Field ("UTTypeVideo",  "UniformTypeIdentifiers")]
		public static UTType Video {
			get {
				if (_Video is null)
					_Video = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeVideo"))!;
				return _Video;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Volume;
		/// <summary>Represents the value associated with the constant 'UTTypeVolume'.</summary>
		[Field ("UTTypeVolume",  "UniformTypeIdentifiers")]
		public static UTType Volume {
			get {
				if (_Volume is null)
					_Volume = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeVolume"))!;
				return _Volume;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Wav;
		/// <summary>Represents the value associated with the constant 'UTTypeWAV'.</summary>
		[Field ("UTTypeWAV",  "UniformTypeIdentifiers")]
		public static UTType Wav {
			get {
				if (_Wav is null)
					_Wav = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeWAV"))!;
				return _Wav;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _WebArchive;
		/// <summary>Represents the value associated with the constant 'UTTypeWebArchive'.</summary>
		[Field ("UTTypeWebArchive",  "UniformTypeIdentifiers")]
		public static UTType WebArchive {
			get {
				if (_WebArchive is null)
					_WebArchive = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeWebArchive"))!;
				return _WebArchive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _WebP;
		/// <summary>Represents the value associated with the constant 'UTTypeWebP'.</summary>
		[Field ("UTTypeWebP",  "UniformTypeIdentifiers")]
		public static UTType WebP {
			get {
				if (_WebP is null)
					_WebP = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeWebP"))!;
				return _WebP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _X509Certificate;
		/// <summary>Represents the value associated with the constant 'UTTypeX509Certificate'.</summary>
		[Field ("UTTypeX509Certificate",  "UniformTypeIdentifiers")]
		public static UTType X509Certificate {
			get {
				if (_X509Certificate is null)
					_X509Certificate = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeX509Certificate"))!;
				return _X509Certificate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Xml;
		/// <summary>Represents the value associated with the constant 'UTTypeXML'.</summary>
		[Field ("UTTypeXML",  "UniformTypeIdentifiers")]
		public static UTType Xml {
			get {
				if (_Xml is null)
					_Xml = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeXML"))!;
				return _Xml;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _XmlPropertyList;
		/// <summary>Represents the value associated with the constant 'UTTypeXMLPropertyList'.</summary>
		[Field ("UTTypeXMLPropertyList",  "UniformTypeIdentifiers")]
		public static UTType XmlPropertyList {
			get {
				if (_XmlPropertyList is null)
					_XmlPropertyList = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeXMLPropertyList"))!;
				return _XmlPropertyList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _XpcService;
		/// <summary>Represents the value associated with the constant 'UTTypeXPCService'.</summary>
		[Field ("UTTypeXPCService",  "UniformTypeIdentifiers")]
		public static UTType XpcService {
			get {
				if (_XpcService is null)
					_XpcService = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeXPCService"))!;
				return _XpcService;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Yaml;
		/// <summary>Represents the value associated with the constant 'UTTypeYAML'.</summary>
		[Field ("UTTypeYAML",  "UniformTypeIdentifiers")]
		public static UTType Yaml {
			get {
				if (_Yaml is null)
					_Yaml = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeYAML"))!;
				return _Yaml;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static UTType? _Zip;
		/// <summary>Represents the value associated with the constant 'UTTypeZIP'.</summary>
		[Field ("UTTypeZIP",  "UniformTypeIdentifiers")]
		public static UTType Zip {
			get {
				if (_Zip is null)
					_Zip = Runtime.GetNSObject<UTType> (Dlfcn.GetIntPtr (Libraries.UniformTypeIdentifiers.Handle, "UTTypeZIP"))!;
				return _Zip;
			}
		}
	} /* class UTTypes */
}
