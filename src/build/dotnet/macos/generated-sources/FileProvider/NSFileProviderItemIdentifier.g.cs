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
	/// <summary>Uniquely identifies a File Provider-managed item.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSFileProviderItemIdentifier  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RootContainer;
		/// <summary>Gets the persistent name of the root directory in the shared hierarchy.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFileProviderRootContainerItemIdentifier",  "FileProvider")]
		public static NSString RootContainer {
			get {
				if (_RootContainer is null)
					_RootContainer = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderRootContainerItemIdentifier")!;
				return _RootContainer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrashContainer;
		/// <summary>Represents the value associated with the constant 'NSFileProviderTrashContainerItemIdentifier'.</summary>
		[Field ("NSFileProviderTrashContainerItemIdentifier",  "FileProvider")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TrashContainer {
			[SupportedOSPlatform ("ios16.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TrashContainer is null)
					_TrashContainer = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderTrashContainerItemIdentifier")!;
				return _TrashContainer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WorkingSetContainer;
		/// <summary>Gets the persistent name of the documents and directories.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFileProviderWorkingSetContainerItemIdentifier",  "FileProvider")]
		public static NSString WorkingSetContainer {
			get {
				if (_WorkingSetContainer is null)
					_WorkingSetContainer = Dlfcn.GetStringConstant (Libraries.FileProvider.Handle, "NSFileProviderWorkingSetContainerItemIdentifier")!;
				return _WorkingSetContainer;
			}
		}
	} /* class NSFileProviderItemIdentifier */
}
