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
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class UIActivityItemsConfigurationMetadataKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollaborationModeRestrictions;
		/// <summary>Represents the value associated with the constant 'UIActivityItemsConfigurationMetadataKeyCollaborationModeRestrictions'.</summary>
		[Field ("UIActivityItemsConfigurationMetadataKeyCollaborationModeRestrictions",  "UIKit")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString CollaborationModeRestrictions {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_CollaborationModeRestrictions is null)
					_CollaborationModeRestrictions = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityItemsConfigurationMetadataKeyCollaborationModeRestrictions")!;
				return _CollaborationModeRestrictions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinkPresentationMetadata;
		/// <summary>Represents the value associated with the constant 'UIActivityItemsConfigurationMetadataKeyLinkPresentationMetadata'.</summary>
		[Field ("UIActivityItemsConfigurationMetadataKeyLinkPresentationMetadata",  "UIKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString LinkPresentationMetadata {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_LinkPresentationMetadata is null)
					_LinkPresentationMetadata = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityItemsConfigurationMetadataKeyLinkPresentationMetadata")!;
				return _LinkPresentationMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MessageBody;
		/// <summary>Represents the value associated with the constant 'UIActivityItemsConfigurationMetadataKeyMessageBody'.</summary>
		[Field ("UIActivityItemsConfigurationMetadataKeyMessageBody",  "UIKit")]
		public static NSString MessageBody {
			get {
				if (_MessageBody is null)
					_MessageBody = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityItemsConfigurationMetadataKeyMessageBody")!;
				return _MessageBody;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShareRecipients;
		/// <summary>Represents the value associated with the constant 'UIActivityItemsConfigurationMetadataKeyShareRecipients'.</summary>
		[Field ("UIActivityItemsConfigurationMetadataKeyShareRecipients",  "UIKit")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString ShareRecipients {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_ShareRecipients is null)
					_ShareRecipients = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityItemsConfigurationMetadataKeyShareRecipients")!;
				return _ShareRecipients;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Title;
		/// <summary>Represents the value associated with the constant 'UIActivityItemsConfigurationMetadataKeyTitle'.</summary>
		[Field ("UIActivityItemsConfigurationMetadataKeyTitle",  "UIKit")]
		public static NSString Title {
			get {
				if (_Title is null)
					_Title = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityItemsConfigurationMetadataKeyTitle")!;
				return _Title;
			}
		}
	} /* class UIActivityItemsConfigurationMetadataKey */
}
