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
namespace CoreSpotlight {
	/// <summary>Represents keys that identify commonly used mailboxes.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CSMailboxKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Archive;
		/// <summary>The key for the Archive mailbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxArchive",  "CoreSpotlight")]
		public static NSString Archive {
			get {
				if (_Archive is null)
					_Archive = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxArchive")!;
				return _Archive;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Drafts;
		/// <summary>The key for the Drafts mailbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxDrafts",  "CoreSpotlight")]
		public static NSString Drafts {
			get {
				if (_Drafts is null)
					_Drafts = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxDrafts")!;
				return _Drafts;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Inbox;
		/// <summary>The key for the Inbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxInbox",  "CoreSpotlight")]
		public static NSString Inbox {
			get {
				if (_Inbox is null)
					_Inbox = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxInbox")!;
				return _Inbox;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Junk;
		/// <summary>The key for the Junk mailbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxJunk",  "CoreSpotlight")]
		public static NSString Junk {
			get {
				if (_Junk is null)
					_Junk = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxJunk")!;
				return _Junk;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sent;
		/// <summary>The key for the Sent mailbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxSent",  "CoreSpotlight")]
		public static NSString Sent {
			get {
				if (_Sent is null)
					_Sent = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxSent")!;
				return _Sent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Trash;
		/// <summary>The key for the Trash mailbox.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CSMailboxTrash",  "CoreSpotlight")]
		public static NSString Trash {
			get {
				if (_Trash is null)
					_Trash = Dlfcn.GetStringConstant (Libraries.CoreSpotlight.Handle, "CSMailboxTrash")!;
				return _Trash;
			}
		}
	} /* class CSMailboxKey */
}
