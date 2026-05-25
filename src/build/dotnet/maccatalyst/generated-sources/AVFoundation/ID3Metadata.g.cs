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
namespace AVFoundation {
	/// <summary>Constants specifying ID3 metadata properties.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	partial class AVMetadataIdentifiers {
		public unsafe static partial class ID3Metadata  {
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AlbumSortOrder;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataAlbumSortOrder</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataAlbumSortOrder",  "AVFoundation")]
			public static NSString AlbumSortOrder {
				get {
					if (_AlbumSortOrder is null)
						_AlbumSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAlbumSortOrder")!;
					return _AlbumSortOrder;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AlbumTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataAlbumTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataAlbumTitle",  "AVFoundation")]
			public static NSString AlbumTitle {
				get {
					if (_AlbumTitle is null)
						_AlbumTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAlbumTitle")!;
					return _AlbumTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AttachedPicture;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataAttachedPicture</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataAttachedPicture",  "AVFoundation")]
			public static NSString AttachedPicture {
				get {
					if (_AttachedPicture is null)
						_AttachedPicture = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAttachedPicture")!;
					return _AttachedPicture;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AudioEncryption;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataAudioEncryption</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataAudioEncryption",  "AVFoundation")]
			public static NSString AudioEncryption {
				get {
					if (_AudioEncryption is null)
						_AudioEncryption = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAudioEncryption")!;
					return _AudioEncryption;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _AudioSeekPointIndex;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataAudioSeekPointIndex</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataAudioSeekPointIndex",  "AVFoundation")]
			public static NSString AudioSeekPointIndex {
				get {
					if (_AudioSeekPointIndex is null)
						_AudioSeekPointIndex = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataAudioSeekPointIndex")!;
					return _AudioSeekPointIndex;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Band;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataBand</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataBand",  "AVFoundation")]
			public static NSString Band {
				get {
					if (_Band is null)
						_Band = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataBand")!;
					return _Band;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _BeatsPerMinute;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataBeatsPerMinute</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataBeatsPerMinute",  "AVFoundation")]
			public static NSString BeatsPerMinute {
				get {
					if (_BeatsPerMinute is null)
						_BeatsPerMinute = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataBeatsPerMinute")!;
					return _BeatsPerMinute;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Comments;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataComments</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataComments",  "AVFoundation")]
			public static NSString Comments {
				get {
					if (_Comments is null)
						_Comments = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataComments")!;
					return _Comments;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Commercial;
			/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataCommercial",  "AVFoundation")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString Commercial {
				[SupportedOSPlatform ("maccatalyst")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_Commercial is null)
						_Commercial = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommercial")!;
					return _Commercial;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CommercialInformation;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataCommercialInformation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataCommercialInformation",  "AVFoundation")]
			public static NSString CommercialInformation {
				get {
					if (_CommercialInformation is null)
						_CommercialInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommercialInformation")!;
					return _CommercialInformation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Commerical;
			/// <summary>Developers should not use this deprecated property. </summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataCommerical",  "AVFoundation")]
			[ObsoletedOSPlatform ("ios9.0")]
			[ObsoletedOSPlatform ("tvos9.0")]
			[ObsoletedOSPlatform ("macos10.11")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			public static NSString Commerical {
				[ObsoletedOSPlatform ("ios9.0")]
				[ObsoletedOSPlatform ("tvos9.0")]
				[ObsoletedOSPlatform ("macos10.11")]
				[SupportedOSPlatform ("maccatalyst")]
				[ObsoletedOSPlatform ("maccatalyst13.1")]
				[SupportedOSPlatform ("ios")]
				[SupportedOSPlatform ("macos")]
				[SupportedOSPlatform ("tvos")]
				get {
					if (_Commerical is null)
						_Commerical = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCommerical")!;
					return _Commerical;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Composer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataComposer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataComposer",  "AVFoundation")]
			public static NSString Composer {
				get {
					if (_Composer is null)
						_Composer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataComposer")!;
					return _Composer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Conductor;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataConductor</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataConductor",  "AVFoundation")]
			public static NSString Conductor {
				get {
					if (_Conductor is null)
						_Conductor = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataConductor")!;
					return _Conductor;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ContentGroupDescription;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataContentGroupDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataContentGroupDescription",  "AVFoundation")]
			public static NSString ContentGroupDescription {
				get {
					if (_ContentGroupDescription is null)
						_ContentGroupDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataContentGroupDescription")!;
					return _ContentGroupDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ContentType;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataContentType</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataContentType",  "AVFoundation")]
			public static NSString ContentType {
				get {
					if (_ContentType is null)
						_ContentType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataContentType")!;
					return _ContentType;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Copyright;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataCopyright</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataCopyright",  "AVFoundation")]
			public static NSString Copyright {
				get {
					if (_Copyright is null)
						_Copyright = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCopyright")!;
					return _Copyright;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _CopyrightInformation;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataCopyrightInformation</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataCopyrightInformation",  "AVFoundation")]
			public static NSString CopyrightInformation {
				get {
					if (_CopyrightInformation is null)
						_CopyrightInformation = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataCopyrightInformation")!;
					return _CopyrightInformation;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Date;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataDate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataDate",  "AVFoundation")]
			public static NSString Date {
				get {
					if (_Date is null)
						_Date = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataDate")!;
					return _Date;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodedBy;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEncodedBy</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEncodedBy",  "AVFoundation")]
			public static NSString EncodedBy {
				get {
					if (_EncodedBy is null)
						_EncodedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodedBy")!;
					return _EncodedBy;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodedWith;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEncodedWith</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEncodedWith",  "AVFoundation")]
			public static NSString EncodedWith {
				get {
					if (_EncodedWith is null)
						_EncodedWith = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodedWith")!;
					return _EncodedWith;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EncodingTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEncodingTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEncodingTime",  "AVFoundation")]
			public static NSString EncodingTime {
				get {
					if (_EncodingTime is null)
						_EncodingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncodingTime")!;
					return _EncodingTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Encryption;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEncryption</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEncryption",  "AVFoundation")]
			public static NSString Encryption {
				get {
					if (_Encryption is null)
						_Encryption = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEncryption")!;
					return _Encryption;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Equalization;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEqualization</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEqualization",  "AVFoundation")]
			public static NSString Equalization {
				get {
					if (_Equalization is null)
						_Equalization = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEqualization")!;
					return _Equalization;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Equalization2;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEqualization2</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEqualization2",  "AVFoundation")]
			public static NSString Equalization2 {
				get {
					if (_Equalization2 is null)
						_Equalization2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEqualization2")!;
					return _Equalization2;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _EventTimingCodes;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataEventTimingCodes</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataEventTimingCodes",  "AVFoundation")]
			public static NSString EventTimingCodes {
				get {
					if (_EventTimingCodes is null)
						_EventTimingCodes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataEventTimingCodes")!;
					return _EventTimingCodes;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _FileOwner;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataFileOwner</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataFileOwner",  "AVFoundation")]
			public static NSString FileOwner {
				get {
					if (_FileOwner is null)
						_FileOwner = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataFileOwner")!;
					return _FileOwner;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _FileType;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataFileType</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataFileType",  "AVFoundation")]
			public static NSString FileType {
				get {
					if (_FileType is null)
						_FileType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataFileType")!;
					return _FileType;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _GeneralEncapsulatedObject;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataGeneralEncapsulatedObject</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataGeneralEncapsulatedObject",  "AVFoundation")]
			public static NSString GeneralEncapsulatedObject {
				get {
					if (_GeneralEncapsulatedObject is null)
						_GeneralEncapsulatedObject = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataGeneralEncapsulatedObject")!;
					return _GeneralEncapsulatedObject;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _GroupIdentifier;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataGroupIdentifier</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataGroupIdentifier",  "AVFoundation")]
			public static NSString GroupIdentifier {
				get {
					if (_GroupIdentifier is null)
						_GroupIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataGroupIdentifier")!;
					return _GroupIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InitialKey;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInitialKey</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInitialKey",  "AVFoundation")]
			public static NSString InitialKey {
				get {
					if (_InitialKey is null)
						_InitialKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInitialKey")!;
					return _InitialKey;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InternationalStandardRecordingCode;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInternationalStandardRecordingCode</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInternationalStandardRecordingCode",  "AVFoundation")]
			public static NSString InternationalStandardRecordingCode {
				get {
					if (_InternationalStandardRecordingCode is null)
						_InternationalStandardRecordingCode = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternationalStandardRecordingCode")!;
					return _InternationalStandardRecordingCode;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InternetRadioStationName;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInternetRadioStationName</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInternetRadioStationName",  "AVFoundation")]
			public static NSString InternetRadioStationName {
				get {
					if (_InternetRadioStationName is null)
						_InternetRadioStationName = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternetRadioStationName")!;
					return _InternetRadioStationName;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InternetRadioStationOwner;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInternetRadioStationOwner</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInternetRadioStationOwner",  "AVFoundation")]
			public static NSString InternetRadioStationOwner {
				get {
					if (_InternetRadioStationOwner is null)
						_InternetRadioStationOwner = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInternetRadioStationOwner")!;
					return _InternetRadioStationOwner;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InvolvedPeopleList_v23;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInvolvedPeopleList_v23</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInvolvedPeopleList_v23",  "AVFoundation")]
			public static NSString InvolvedPeopleList_v23 {
				get {
					if (_InvolvedPeopleList_v23 is null)
						_InvolvedPeopleList_v23 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInvolvedPeopleList_v23")!;
					return _InvolvedPeopleList_v23;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _InvolvedPeopleList_v24;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataInvolvedPeopleList_v24</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataInvolvedPeopleList_v24",  "AVFoundation")]
			public static NSString InvolvedPeopleList_v24 {
				get {
					if (_InvolvedPeopleList_v24 is null)
						_InvolvedPeopleList_v24 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataInvolvedPeopleList_v24")!;
					return _InvolvedPeopleList_v24;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Language;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataLanguage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataLanguage",  "AVFoundation")]
			public static NSString Language {
				get {
					if (_Language is null)
						_Language = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLanguage")!;
					return _Language;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _LeadPerformer;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataLeadPerformer</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataLeadPerformer",  "AVFoundation")]
			public static NSString LeadPerformer {
				get {
					if (_LeadPerformer is null)
						_LeadPerformer = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLeadPerformer")!;
					return _LeadPerformer;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Length;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataLength</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataLength",  "AVFoundation")]
			public static NSString Length {
				get {
					if (_Length is null)
						_Length = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLength")!;
					return _Length;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Link;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataLink</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataLink",  "AVFoundation")]
			public static NSString Link {
				get {
					if (_Link is null)
						_Link = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLink")!;
					return _Link;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Lyricist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataLyricist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataLyricist",  "AVFoundation")]
			public static NSString Lyricist {
				get {
					if (_Lyricist is null)
						_Lyricist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataLyricist")!;
					return _Lyricist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _MediaType;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataMediaType</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataMediaType",  "AVFoundation")]
			public static NSString MediaType {
				get {
					if (_MediaType is null)
						_MediaType = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMediaType")!;
					return _MediaType;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ModifiedBy;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataModifiedBy</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataModifiedBy",  "AVFoundation")]
			public static NSString ModifiedBy {
				get {
					if (_ModifiedBy is null)
						_ModifiedBy = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataModifiedBy")!;
					return _ModifiedBy;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Mood;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataMood</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataMood",  "AVFoundation")]
			public static NSString Mood {
				get {
					if (_Mood is null)
						_Mood = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMood")!;
					return _Mood;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _MpegLocationLookupTable;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataMPEGLocationLookupTable</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataMPEGLocationLookupTable",  "AVFoundation")]
			public static NSString MpegLocationLookupTable {
				get {
					if (_MpegLocationLookupTable is null)
						_MpegLocationLookupTable = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMPEGLocationLookupTable")!;
					return _MpegLocationLookupTable;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _MusicCDIdentifier;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataMusicCDIdentifier</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataMusicCDIdentifier",  "AVFoundation")]
			public static NSString MusicCDIdentifier {
				get {
					if (_MusicCDIdentifier is null)
						_MusicCDIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMusicCDIdentifier")!;
					return _MusicCDIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _MusicianCreditsList;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataMusicianCreditsList</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataMusicianCreditsList",  "AVFoundation")]
			public static NSString MusicianCreditsList {
				get {
					if (_MusicianCreditsList is null)
						_MusicianCreditsList = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataMusicianCreditsList")!;
					return _MusicianCreditsList;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OfficialArtistWebpage;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOfficialArtistWebpage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOfficialArtistWebpage",  "AVFoundation")]
			public static NSString OfficialArtistWebpage {
				get {
					if (_OfficialArtistWebpage is null)
						_OfficialArtistWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialArtistWebpage")!;
					return _OfficialArtistWebpage;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OfficialAudioFileWebpage;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOfficialAudioFileWebpage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOfficialAudioFileWebpage",  "AVFoundation")]
			public static NSString OfficialAudioFileWebpage {
				get {
					if (_OfficialAudioFileWebpage is null)
						_OfficialAudioFileWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialAudioFileWebpage")!;
					return _OfficialAudioFileWebpage;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OfficialAudioSourceWebpage;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOfficialAudioSourceWebpage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOfficialAudioSourceWebpage",  "AVFoundation")]
			public static NSString OfficialAudioSourceWebpage {
				get {
					if (_OfficialAudioSourceWebpage is null)
						_OfficialAudioSourceWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialAudioSourceWebpage")!;
					return _OfficialAudioSourceWebpage;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OfficialInternetRadioStationHomepage;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOfficialInternetRadioStationHomepage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOfficialInternetRadioStationHomepage",  "AVFoundation")]
			public static NSString OfficialInternetRadioStationHomepage {
				get {
					if (_OfficialInternetRadioStationHomepage is null)
						_OfficialInternetRadioStationHomepage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialInternetRadioStationHomepage")!;
					return _OfficialInternetRadioStationHomepage;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OfficialPublisherWebpage;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOfficialPublisherWebpage</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOfficialPublisherWebpage",  "AVFoundation")]
			public static NSString OfficialPublisherWebpage {
				get {
					if (_OfficialPublisherWebpage is null)
						_OfficialPublisherWebpage = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOfficialPublisherWebpage")!;
					return _OfficialPublisherWebpage;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalAlbumTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalAlbumTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalAlbumTitle",  "AVFoundation")]
			public static NSString OriginalAlbumTitle {
				get {
					if (_OriginalAlbumTitle is null)
						_OriginalAlbumTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalAlbumTitle")!;
					return _OriginalAlbumTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalArtist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalArtist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalArtist",  "AVFoundation")]
			public static NSString OriginalArtist {
				get {
					if (_OriginalArtist is null)
						_OriginalArtist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalArtist")!;
					return _OriginalArtist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalFilename;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalFilename</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalFilename",  "AVFoundation")]
			public static NSString OriginalFilename {
				get {
					if (_OriginalFilename is null)
						_OriginalFilename = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalFilename")!;
					return _OriginalFilename;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalLyricist;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalLyricist</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalLyricist",  "AVFoundation")]
			public static NSString OriginalLyricist {
				get {
					if (_OriginalLyricist is null)
						_OriginalLyricist = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalLyricist")!;
					return _OriginalLyricist;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalReleaseTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalReleaseTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalReleaseTime",  "AVFoundation")]
			public static NSString OriginalReleaseTime {
				get {
					if (_OriginalReleaseTime is null)
						_OriginalReleaseTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalReleaseTime")!;
					return _OriginalReleaseTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _OriginalReleaseYear;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOriginalReleaseYear</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOriginalReleaseYear",  "AVFoundation")]
			public static NSString OriginalReleaseYear {
				get {
					if (_OriginalReleaseYear is null)
						_OriginalReleaseYear = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOriginalReleaseYear")!;
					return _OriginalReleaseYear;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Ownership;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataOwnership</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataOwnership",  "AVFoundation")]
			public static NSString Ownership {
				get {
					if (_Ownership is null)
						_Ownership = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataOwnership")!;
					return _Ownership;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PartOfASet;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPartOfASet</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPartOfASet",  "AVFoundation")]
			public static NSString PartOfASet {
				get {
					if (_PartOfASet is null)
						_PartOfASet = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPartOfASet")!;
					return _PartOfASet;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Payment;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPayment</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPayment",  "AVFoundation")]
			public static NSString Payment {
				get {
					if (_Payment is null)
						_Payment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPayment")!;
					return _Payment;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PerformerSortOrder;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPerformerSortOrder</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPerformerSortOrder",  "AVFoundation")]
			public static NSString PerformerSortOrder {
				get {
					if (_PerformerSortOrder is null)
						_PerformerSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPerformerSortOrder")!;
					return _PerformerSortOrder;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PlayCounter;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPlayCounter</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPlayCounter",  "AVFoundation")]
			public static NSString PlayCounter {
				get {
					if (_PlayCounter is null)
						_PlayCounter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPlayCounter")!;
					return _PlayCounter;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PlaylistDelay;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPlaylistDelay</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPlaylistDelay",  "AVFoundation")]
			public static NSString PlaylistDelay {
				get {
					if (_PlaylistDelay is null)
						_PlaylistDelay = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPlaylistDelay")!;
					return _PlaylistDelay;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Popularimeter;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPopularimeter</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPopularimeter",  "AVFoundation")]
			public static NSString Popularimeter {
				get {
					if (_Popularimeter is null)
						_Popularimeter = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPopularimeter")!;
					return _Popularimeter;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _PositionSynchronization;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPositionSynchronization</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPositionSynchronization",  "AVFoundation")]
			public static NSString PositionSynchronization {
				get {
					if (_PositionSynchronization is null)
						_PositionSynchronization = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPositionSynchronization")!;
					return _PositionSynchronization;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Private;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPrivate</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPrivate",  "AVFoundation")]
			public static NSString Private {
				get {
					if (_Private is null)
						_Private = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPrivate")!;
					return _Private;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ProducedNotice;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataProducedNotice</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataProducedNotice",  "AVFoundation")]
			public static NSString ProducedNotice {
				get {
					if (_ProducedNotice is null)
						_ProducedNotice = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataProducedNotice")!;
					return _ProducedNotice;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Publisher;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataPublisher</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataPublisher",  "AVFoundation")]
			public static NSString Publisher {
				get {
					if (_Publisher is null)
						_Publisher = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataPublisher")!;
					return _Publisher;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RecommendedBufferSize;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataRecommendedBufferSize</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataRecommendedBufferSize",  "AVFoundation")]
			public static NSString RecommendedBufferSize {
				get {
					if (_RecommendedBufferSize is null)
						_RecommendedBufferSize = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecommendedBufferSize")!;
					return _RecommendedBufferSize;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RecordingDates;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataRecordingDates</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataRecordingDates",  "AVFoundation")]
			public static NSString RecordingDates {
				get {
					if (_RecordingDates is null)
						_RecordingDates = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecordingDates")!;
					return _RecordingDates;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RecordingTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataRecordingTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataRecordingTime",  "AVFoundation")]
			public static NSString RecordingTime {
				get {
					if (_RecordingTime is null)
						_RecordingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRecordingTime")!;
					return _RecordingTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RelativeVolumeAdjustment;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment",  "AVFoundation")]
			public static NSString RelativeVolumeAdjustment {
				get {
					if (_RelativeVolumeAdjustment is null)
						_RelativeVolumeAdjustment = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment")!;
					return _RelativeVolumeAdjustment;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _RelativeVolumeAdjustment2;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment2</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment2",  "AVFoundation")]
			public static NSString RelativeVolumeAdjustment2 {
				get {
					if (_RelativeVolumeAdjustment2 is null)
						_RelativeVolumeAdjustment2 = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataRelativeVolumeAdjustment2")!;
					return _RelativeVolumeAdjustment2;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _ReleaseTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataReleaseTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataReleaseTime",  "AVFoundation")]
			public static NSString ReleaseTime {
				get {
					if (_ReleaseTime is null)
						_ReleaseTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataReleaseTime")!;
					return _ReleaseTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Reverb;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataReverb</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataReverb",  "AVFoundation")]
			public static NSString Reverb {
				get {
					if (_Reverb is null)
						_Reverb = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataReverb")!;
					return _Reverb;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Seek;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSeek</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSeek",  "AVFoundation")]
			public static NSString Seek {
				get {
					if (_Seek is null)
						_Seek = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSeek")!;
					return _Seek;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SetSubtitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSetSubtitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSetSubtitle",  "AVFoundation")]
			public static NSString SetSubtitle {
				get {
					if (_SetSubtitle is null)
						_SetSubtitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSetSubtitle")!;
					return _SetSubtitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Signature;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSignature</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSignature",  "AVFoundation")]
			public static NSString Signature {
				get {
					if (_Signature is null)
						_Signature = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSignature")!;
					return _Signature;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Size;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSize</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSize",  "AVFoundation")]
			public static NSString Size {
				get {
					if (_Size is null)
						_Size = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSize")!;
					return _Size;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SubTitle;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSubTitle</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSubTitle",  "AVFoundation")]
			public static NSString SubTitle {
				get {
					if (_SubTitle is null)
						_SubTitle = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSubTitle")!;
					return _SubTitle;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SynchronizedLyric;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSynchronizedLyric</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSynchronizedLyric",  "AVFoundation")]
			public static NSString SynchronizedLyric {
				get {
					if (_SynchronizedLyric is null)
						_SynchronizedLyric = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSynchronizedLyric")!;
					return _SynchronizedLyric;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _SynchronizedTempoCodes;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataSynchronizedTempoCodes</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataSynchronizedTempoCodes",  "AVFoundation")]
			public static NSString SynchronizedTempoCodes {
				get {
					if (_SynchronizedTempoCodes is null)
						_SynchronizedTempoCodes = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataSynchronizedTempoCodes")!;
					return _SynchronizedTempoCodes;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TaggingTime;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTaggingTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTaggingTime",  "AVFoundation")]
			public static NSString TaggingTime {
				get {
					if (_TaggingTime is null)
						_TaggingTime = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTaggingTime")!;
					return _TaggingTime;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TermsOfUse;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTermsOfUse</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTermsOfUse",  "AVFoundation")]
			public static NSString TermsOfUse {
				get {
					if (_TermsOfUse is null)
						_TermsOfUse = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTermsOfUse")!;
					return _TermsOfUse;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Time;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTime</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTime",  "AVFoundation")]
			public static NSString Time {
				get {
					if (_Time is null)
						_Time = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTime")!;
					return _Time;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TitleDescription;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTitleDescription</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTitleDescription",  "AVFoundation")]
			public static NSString TitleDescription {
				get {
					if (_TitleDescription is null)
						_TitleDescription = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTitleDescription")!;
					return _TitleDescription;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TitleSortOrder;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTitleSortOrder</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTitleSortOrder",  "AVFoundation")]
			public static NSString TitleSortOrder {
				get {
					if (_TitleSortOrder is null)
						_TitleSortOrder = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTitleSortOrder")!;
					return _TitleSortOrder;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _TrackNumber;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataTrackNumber</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataTrackNumber",  "AVFoundation")]
			public static NSString TrackNumber {
				get {
					if (_TrackNumber is null)
						_TrackNumber = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataTrackNumber")!;
					return _TrackNumber;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UniqueFileIdentifier;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataUniqueFileIdentifier</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataUniqueFileIdentifier",  "AVFoundation")]
			public static NSString UniqueFileIdentifier {
				get {
					if (_UniqueFileIdentifier is null)
						_UniqueFileIdentifier = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUniqueFileIdentifier")!;
					return _UniqueFileIdentifier;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UnsynchronizedLyric;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataUnsynchronizedLyric</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataUnsynchronizedLyric",  "AVFoundation")]
			public static NSString UnsynchronizedLyric {
				get {
					if (_UnsynchronizedLyric is null)
						_UnsynchronizedLyric = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUnsynchronizedLyric")!;
					return _UnsynchronizedLyric;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserText;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataUserText</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataUserText",  "AVFoundation")]
			public static NSString UserText {
				get {
					if (_UserText is null)
						_UserText = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUserText")!;
					return _UserText;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _UserUrl;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataUserURL</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataUserURL",  "AVFoundation")]
			public static NSString UserUrl {
				get {
					if (_UserUrl is null)
						_UserUrl = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataUserURL")!;
					return _UserUrl;
				}
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			static NSString? _Year;
			/// <summary>Represents the value associated with the constant AVMetadataIdentifierID3MetadataYear</summary><value></value><remarks>To be added.</remarks>
			[Field ("AVMetadataIdentifierID3MetadataYear",  "AVFoundation")]
			public static NSString Year {
				get {
					if (_Year is null)
						_Year = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVMetadataIdentifierID3MetadataYear")!;
					return _Year;
				}
			}
		} /* class ID3Metadata */
	}
}
