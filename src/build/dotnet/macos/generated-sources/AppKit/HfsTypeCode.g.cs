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
namespace AppKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum HfsTypeCode : uint {
		ClipboardIcon = 1129072976,
		ClippingUnknownTypeIcon = 1668051061,
		ClippingPictureTypeIcon = 1668051056,
		ClippingTextTypeIcon = 1668051060,
		ClippingSoundTypeIcon = 1668051059,
		DesktopIcon = 1684370283,
		FinderIcon = 1179534418,
		ComputerIcon = 1919905652,
		FontSuitcaseIcon = 1179011404,
		FullTrashIcon = 1718907496,
		GenericApplicationIcon = 1095782476,
		GenericCdromIcon = 1667523698,
		GenericControlPanelIcon = 1095782467,
		GenericControlStripModuleIcon = 1935959414,
		GenericComponentIcon = 1953001063,
		GenericDeskAccessoryIcon = 1095782468,
		GenericDocumentIcon = 1685021557,
		GenericEditionFileIcon = 1701082214,
		GenericExtensionIcon = 1229867348,
		GenericFileServerIcon = 1936881266,
		GenericFontIcon = 1717987692,
		GenericFontScalerIcon = 1935895666,
		GenericFloppyIcon = 1718382713,
		GenericHardDiskIcon = 1751413611,
		GenericIDiskIcon = 1768190827,
		GenericRemovableMediaIcon = 1919774582,
		GenericMoverObjectIcon = 1836021362,
		GenericPCCardIcon = 1885564259,
		GenericPreferencesIcon = 1886545254,
		GenericQueryDocumentIcon = 1902473849,
		GenericRamDiskIcon = 1918987620,
		GenericSharedLibraryIcon = 1936223330,
		GenericStationeryIcon = 1935961955,
		GenericSuitcaseIcon = 1937074548,
		GenericUrlIcon = 1735750252,
		GenericWormIcon = 2003792493,
		InternationalResourcesIcon = 1768319340,
		KeyboardLayoutIcon = 1801873772,
		SoundFileIcon = 1936091500,
		SystemSuitcaseIcon = 2054388083,
		TrashIcon = 1953657704,
		TrueTypeFontIcon = 1952868716,
		TrueTypeFlatFontIcon = 1936092788,
		TrueTypeMultiFlatFontIcon = 1953784678,
		UserIDiskIcon = 1969517419,
		UnknownFSObjectIcon = 1970169459,
		InternetLocationHttpIcon = 1768712308,
		InternetLocationFtpIcon = 1768711796,
		InternetLocationAppleShareIcon = 1768710502,
		InternetLocationAppleTalkZoneIcon = 1768710516,
		InternetLocationFileIcon = 1768711785,
		InternetLocationMailIcon = 1768713569,
		InternetLocationNewsIcon = 1768713847,
		InternetLocationNslNeighborhoodIcon = 1768713843,
		InternetLocationGenericIcon = 1768712037,
		GenericFolderIcon = 1718379634,
		DropFolderIcon = 1684172664,
		MountedFolderIcon = 1835955300,
		OpenFolderIcon = 1868983396,
		OwnedFolderIcon = 1870098020,
		PrivateFolderIcon = 1886549606,
		SharedFolderIcon = 1936221804,
		SharingPrivsNotApplicableIcon = 1936223841,
		SharingPrivsReadOnlyIcon = 1936224879,
		SharingPrivsReadWriteIcon = 1936224887,
		SharingPrivsUnknownIcon = 1936225643,
		SharingPrivsWritableIcon = 2003986804,
		UserFolderIcon = 1969646692,
		WorkgroupFolderIcon = 2003201124,
		GuestUserIcon = 1735750514,
		UserIcon = 1970496882,
		OwnerIcon = 1937077106,
		GroupIcon = 1735554416,
		AppearanceFolderIcon = 1634758770,
		AppleMenuFolderIcon = 1634561653,
		ApplicationsFolderIcon = 1634758771,
		ApplicationSupportFolderIcon = 1634956656,
		ColorSyncFolderIcon = 1886547814,
		ContextualMenuItemsFolderIcon = 1668116085,
		ControlPanelDisabledFolderIcon = 1668575812,
		ControlPanelFolderIcon = 1668575852,
		DocumentsFolderIcon = 1685021555,
		ExtensionsDisabledFolderIcon = 1702392900,
		ExtensionsFolderIcon = 1702392942,
		FavoritesFolderIcon = 1717663347,
		FontsFolderIcon = 1718578804,
		InternetSearchSitesFolderIcon = 1769173862,
		PublicFolderIcon = 1886741094,
		PrinterDescriptionFolderIcon = 1886413926,
		PrintMonitorFolderIcon = 1886547572,
		RecentApplicationsFolderIcon = 1918988400,
		RecentDocumentsFolderIcon = 1919184739,
		RecentServersFolderIcon = 1920168566,
		ShutdownItemsDisabledFolderIcon = 1936221252,
		ShutdownItemsFolderIcon = 1936221286,
		SpeakableItemsFolder = 1936747369,
		StartupItemsDisabledFolderIcon = 1937011268,
		StartupItemsFolderIcon = 1937011316,
		SystemExtensionDisabledFolderIcon = 1835098948,
		SystemFolderIcon = 1835098995,
		VoicesFolderIcon = 1719037795,
		AppleScriptBadgeIcon = 1935897200,
		LockedBadgeIcon = 1818387559,
		MountedBadgeIcon = 1835164775,
		SharedBadgeIcon = 1935828071,
		AliasBadgeIcon = 1633838183,
		AlertCautionBadgeIcon = 1667392615,
		AlertNoteIcon = 1852798053,
		AlertCautionIcon = 1667331444,
		AlertStopIcon = 1937010544,
		AppleTalkIcon = 1635019883,
		AppleTalkZoneIcon = 1635023470,
		AfpServerIcon = 1634103411,
		FtpServerIcon = 1718906995,
		HttpServerIcon = 1752461427,
		GenericNetworkIcon = 1735288180,
		IPFileServerIcon = 1769173622,
		ToolbarCustomizeIcon = 1952675187,
		ToolbarDeleteIcon = 1952736620,
		ToolbarFavoritesIcon = 1952866678,
		ToolbarHomeIcon = 1953001325,
		ToolbarAdvancedIcon = 1952604534,
		ToolbarInfoIcon = 1952606574,
		ToolbarLabelsIcon = 1952607330,
		ToolbarApplicationsFolderIcon = 1950445683,
		ToolbarDocumentsFolderIcon = 1950642019,
		ToolbarMovieFolderIcon = 1951231862,
		ToolbarMusicFolderIcon = 1951233395,
		ToolbarPicturesFolderIcon = 1951426915,
		ToolbarPublicFolderIcon = 1951429986,
		ToolbarDesktopFolderIcon = 1950643051,
		ToolbarDownloadsFolderIcon = 1950644078,
		ToolbarLibraryFolderIcon = 1951164770,
		ToolbarUtilitiesFolderIcon = 1951757420,
		ToolbarSitesFolderIcon = 1951626355,
		AppleLogoIcon = 1667330156,
		AppleMenuIcon = 1935765612,
		BackwardArrowIcon = 1650553455,
		FavoriteItemsIcon = 1717663346,
		ForwardArrowIcon = 1717662319,
		GridIcon = 1735551332,
		HelpIcon = 1751477360,
		KeepArrangedIcon = 1634889319,
		LockedIcon = 1819239275,
		NoFilesIcon = 1852205420,
		NoFolderIcon = 1852206180,
		NoWriteIcon = 1853321844,
		ProtectedApplicationFolderIcon = 1885433968,
		ProtectedSystemFolderIcon = 1886615923,
		RecentItemsIcon = 1919118964,
		ShortcutIcon = 1936224884,
		SortAscendingIcon = 1634954852,
		SortDescendingIcon = 1685286500,
		UnlockedIcon = 1970037611,
		ConnectToIcon = 1668178804,
		GenericWindowIcon = 1735879022,
		QuestionMarkIcon = 1903519091,
		DeleteAliasIcon = 1684106345,
		EjectMediaIcon = 1701471587,
		BurningIcon = 1651864174,
		RightContainerArrowIcon = 1919115634,
	}
}
