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
	/// <summary>Constants that specify common identifiers for metadata.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class CommonIdentifier  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AccessibilityDescription;
			/// <summary>Represents the value associated with the constant 'AVMetadataCommonIdentifierAccessibilityDescription'.</summary>
			[Field ("AVMetadataCommonIdentifierAccessibilityDescription",  "AVFoundation")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			public static NSString AccessibilityDescription {
				[SupportedOSPlatform ("tvos14.0")]
				[SupportedOSPlatform ("ios14.0")]
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("macos")]
				get {
					if (_AccessibilityDescription is null)
						_AccessibilityDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAccessibilityDescription")!;
					return _AccessibilityDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AlbumName;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierAlbumName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierAlbumName",  "AVFoundation")]
			public static NSString AlbumName {
				get {
					if (_AlbumName is null)
						_AlbumName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAlbumName")!;
					return _AlbumName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Artist;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierArtist",  "AVFoundation")]
			public static NSString Artist {
				get {
					if (_Artist is null)
						_Artist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierArtist")!;
					return _Artist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Artwork;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierArtwork</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierArtwork",  "AVFoundation")]
			public static NSString Artwork {
				get {
					if (_Artwork is null)
						_Artwork = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierArtwork")!;
					return _Artwork;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AssetIdentifier;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierAssetIdentifier</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierAssetIdentifier",  "AVFoundation")]
			public static NSString AssetIdentifier {
				get {
					if (_AssetIdentifier is null)
						_AssetIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAssetIdentifier")!;
					return _AssetIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Author;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierAuthor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierAuthor",  "AVFoundation")]
			public static NSString Author {
				get {
					if (_Author is null)
						_Author = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierAuthor")!;
					return _Author;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Contributor;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierContributor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierContributor",  "AVFoundation")]
			public static NSString Contributor {
				get {
					if (_Contributor is null)
						_Contributor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierContributor")!;
					return _Contributor;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Copyrights;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierCopyrights</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierCopyrights",  "AVFoundation")]
			public static NSString Copyrights {
				get {
					if (_Copyrights is null)
						_Copyrights = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCopyrights")!;
					return _Copyrights;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CreationDate;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierCreationDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierCreationDate",  "AVFoundation")]
			public static NSString CreationDate {
				get {
					if (_CreationDate is null)
						_CreationDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCreationDate")!;
					return _CreationDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Creator;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierCreator</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierCreator",  "AVFoundation")]
			public static NSString Creator {
				get {
					if (_Creator is null)
						_Creator = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierCreator")!;
					return _Creator;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Description;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierDescription",  "AVFoundation")]
			public static NSString Description {
				get {
					if (_Description is null)
						_Description = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierDescription")!;
					return _Description;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Format;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierFormat</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierFormat",  "AVFoundation")]
			public static NSString Format {
				get {
					if (_Format is null)
						_Format = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierFormat")!;
					return _Format;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Language;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierLanguage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierLanguage",  "AVFoundation")]
			public static NSString Language {
				get {
					if (_Language is null)
						_Language = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLanguage")!;
					return _Language;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LastModifiedDate;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierLastModifiedDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierLastModifiedDate",  "AVFoundation")]
			public static NSString LastModifiedDate {
				get {
					if (_LastModifiedDate is null)
						_LastModifiedDate = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLastModifiedDate")!;
					return _LastModifiedDate;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Location;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierLocation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierLocation",  "AVFoundation")]
			public static NSString Location {
				get {
					if (_Location is null)
						_Location = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierLocation")!;
					return _Location;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Make;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierMake</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierMake",  "AVFoundation")]
			public static NSString Make {
				get {
					if (_Make is null)
						_Make = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierMake")!;
					return _Make;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Model;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierModel</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierModel",  "AVFoundation")]
			public static NSString Model {
				get {
					if (_Model is null)
						_Model = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierModel")!;
					return _Model;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Publisher;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierPublisher</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierPublisher",  "AVFoundation")]
			public static NSString Publisher {
				get {
					if (_Publisher is null)
						_Publisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierPublisher")!;
					return _Publisher;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Relation;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierRelation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierRelation",  "AVFoundation")]
			public static NSString Relation {
				get {
					if (_Relation is null)
						_Relation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierRelation")!;
					return _Relation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Software;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierSoftware</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierSoftware",  "AVFoundation")]
			public static NSString Software {
				get {
					if (_Software is null)
						_Software = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSoftware")!;
					return _Software;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Source;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierSource</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierSource",  "AVFoundation")]
			public static NSString Source {
				get {
					if (_Source is null)
						_Source = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSource")!;
					return _Source;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Subject;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierSubject</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierSubject",  "AVFoundation")]
			public static NSString Subject {
				get {
					if (_Subject is null)
						_Subject = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierSubject")!;
					return _Subject;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Title;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierTitle",  "AVFoundation")]
			public static NSString Title {
				get {
					if (_Title is null)
						_Title = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierTitle")!;
					return _Title;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Type;
			/// <summary>Represents the value associated with the constant AVMetadataCommonIdentifierType</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataCommonIdentifierType",  "AVFoundation")]
			public static NSString Type {
				get {
					if (_Type is null)
						_Type = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataCommonIdentifierType")!;
					return _Type;
				}
			}
		} /* class CommonIdentifier */
	}
}
