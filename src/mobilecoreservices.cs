using Foundation;
using ObjCRuntime;

namespace MobileCoreServices {

	[Deprecated (PlatformName.iOS, 14, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.TvOS, 14, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.WatchOS, 7, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Partial]
	interface UTType {
		[Field ("kUTTypeItem", "+CoreServices")]
		NSString Item { get; }

		[Field ("kUTTypeContent", "+CoreServices")]
		NSString Content { get; }

		[Field ("kUTTypeCompositeContent", "+CoreServices")]
		NSString CompositeContent { get; }

		[Field ("kUTTypeMessage", "+CoreServices")]
		NSString Message { get; }

		[Field ("kUTTypeContact", "+CoreServices")]
		NSString Contact { get; }

		[Field ("kUTTypeArchive", "+CoreServices")]
		NSString Archive { get; }

		[Field ("kUTTypeDiskImage", "+CoreServices")]
		NSString DiskImage { get; }

		[Field ("kUTTypeData", "+CoreServices")]
		NSString Data { get; }

		[Field ("kUTTypeDirectory", "+CoreServices")]
		NSString Directory { get; }

		[Field ("kUTTypeResolvable", "+CoreServices")]
		NSString Resolvable { get; }

		[Field ("kUTTypeSymLink", "+CoreServices")]
		NSString SymLink { get; }

		[Field ("kUTTypeExecutable", "+CoreServices")]
		NSString Executable { get; }

		[Field ("kUTTypeMountPoint", "+CoreServices")]
		NSString MountPoint { get; }

		[Field ("kUTTypeAliasFile", "+CoreServices")]
		NSString AliasFile { get; }

		[Field ("kUTTypeAliasRecord", "+CoreServices")]
		NSString AliasRecord { get; }

		[Field ("kUTTypeURLBookmarkData", "+CoreServices")]
		NSString URLBookmarkData { get; }

		[Field ("kUTTypeURL", "+CoreServices")]
		NSString URL { get; }

		[Field ("kUTTypeFileURL", "+CoreServices")]
		NSString FileURL { get; }

		[Field ("kUTTypeText", "+CoreServices")]
		NSString Text { get; }

		[Field ("kUTTypePlainText", "+CoreServices")]
		NSString PlainText { get; }

		[Field ("kUTTypeUTF8PlainText", "+CoreServices")]
		NSString UTF8PlainText { get; }

		[Field ("kUTTypeUTF16ExternalPlainText", "+CoreServices")]
		NSString UTF16ExternalPlainText { get; }

		[Field ("kUTTypeUTF16PlainText", "+CoreServices")]
		NSString UTF16PlainText { get; }

		[Field ("kUTTypeDelimitedText", "+CoreServices")]
		NSString DelimitedText { get; }

		[Field ("kUTTypeCommaSeparatedText", "+CoreServices")]
		NSString CommaSeparatedText { get; }

		[Field ("kUTTypeTabSeparatedText", "+CoreServices")]
		NSString TabSeparatedText { get; }

		[Field ("kUTTypeUTF8TabSeparatedText", "+CoreServices")]
		NSString UTF8TabSeparatedText { get; }

		[Field ("kUTTypeRTF", "+CoreServices")]
		NSString RTF { get; }

		[Field ("kUTTypeHTML", "+CoreServices")]
		NSString HTML { get; }

		[Field ("kUTTypeXML", "+CoreServices")]
		NSString XML { get; }

		[Field ("kUTTypeSourceCode", "+CoreServices")]
		NSString SourceCode { get; }

		[Field ("kUTTypeAssemblyLanguageSource", "+CoreServices")]
		NSString AssemblyLanguageSource { get; }

		[Field ("kUTTypeCSource", "+CoreServices")]
		NSString CSource { get; }

		[Field ("kUTTypeObjectiveCSource", "+CoreServices")]
		NSString ObjectiveCSource { get; }

		[Field ("kUTTypeCPlusPlusSource", "+CoreServices")]
		NSString CPlusPlusSource { get; }

		[Field ("kUTTypeObjectiveCPlusPlusSource", "+CoreServices")]
		NSString ObjectiveCPlusPlusSource { get; }

		[Field ("kUTTypeCHeader", "+CoreServices")]
		NSString CHeader { get; }

		[Field ("kUTTypeCPlusPlusHeader", "+CoreServices")]
		NSString CPlusPlusHeader { get; }

		[Field ("kUTTypeJavaSource", "+CoreServices")]
		NSString JavaSource { get; }

		[Field ("kUTTypeScript", "+CoreServices")]
		NSString Script { get; }

		[Field ("kUTTypeAppleScript", "+CoreServices")]
		NSString AppleScript { get; }

		[Field ("kUTTypeOSAScript", "+CoreServices")]
		NSString OSAScript { get; }

		[Field ("kUTTypeOSAScriptBundle", "+CoreServices")]
		NSString OSAScriptBundle { get; }

		[Field ("kUTTypeJavaScript", "+CoreServices")]
		NSString JavaScript { get; }

		[Field ("kUTTypeShellScript", "+CoreServices")]
		NSString ShellScript { get; }

		[Field ("kUTTypePerlScript", "+CoreServices")]
		NSString PerlScript { get; }

		[Field ("kUTTypePythonScript", "+CoreServices")]
		NSString PythonScript { get; }

		[Field ("kUTTypeRubyScript", "+CoreServices")]
		NSString RubyScript { get; }

		[Field ("kUTTypePHPScript", "+CoreServices")]
		NSString PHPScript { get; }

		[Field ("kUTTypeJSON", "+CoreServices")]
		NSString JSON { get; }

		[Field ("kUTTypePropertyList", "+CoreServices")]
		NSString PropertyList { get; }

		[Field ("kUTTypeXMLPropertyList", "+CoreServices")]
		NSString XMLPropertyList { get; }

		[Field ("kUTTypeBinaryPropertyList", "+CoreServices")]
		NSString BinaryPropertyList { get; }

		[Field ("kUTTypePDF", "+CoreServices")]
		NSString PDF { get; }

		[Field ("kUTTypeRTFD", "+CoreServices")]
		NSString RTFD { get; }

		[Field ("kUTTypeFlatRTFD", "+CoreServices")]
		NSString FlatRTFD { get; }

		[Field ("kUTTypeTXNTextAndMultimediaData", "+CoreServices")]
		NSString TXNTextAndMultimediaData { get; }

		[Field ("kUTTypeWebArchive", "+CoreServices")]
		NSString WebArchive { get; }

		[Field ("kUTTypeImage", "+CoreServices")]
		NSString Image { get; }

		[Field ("kUTTypeJPEG", "+CoreServices")]
		NSString JPEG { get; }

		[Field ("kUTTypeJPEG2000", "+CoreServices")]
		NSString JPEG2000 { get; }

		[Field ("kUTTypeTIFF", "+CoreServices")]
		NSString TIFF { get; }

		[Field ("kUTTypePICT", "+CoreServices")]
		NSString PICT { get; }

		[Field ("kUTTypeGIF", "+CoreServices")]
		NSString GIF { get; }

		[Field ("kUTTypePNG", "+CoreServices")]
		NSString PNG { get; }

		[Field ("kUTTypeQuickTimeImage", "+CoreServices")]
		NSString QuickTimeImage { get; }

		[Field ("kUTTypeAppleICNS", "+CoreServices")]
		NSString AppleICNS { get; }

		[Field ("kUTTypeBMP", "+CoreServices")]
		NSString BMP { get; }

		[Field ("kUTTypeICO", "+CoreServices")]
		NSString ICO { get; }

		[Field ("kUTTypeRawImage", "+CoreServices")]
		NSString RawImage { get; }

		[Field ("kUTTypeScalableVectorGraphics", "+CoreServices")]
		NSString ScalableVectorGraphics { get; }

		[Field ("kUTTypeAudiovisualContent", "+CoreServices")]
		NSString AudiovisualContent { get; }

		[Field ("kUTTypeMovie", "+CoreServices")]
		NSString Movie { get; }

		[Field ("kUTTypeVideo", "+CoreServices")]
		NSString Video { get; }

		[Field ("kUTTypeAudio", "+CoreServices")]
		NSString Audio { get; }

		[Field ("kUTTypeQuickTimeMovie", "+CoreServices")]
		NSString QuickTimeMovie { get; }

		[Field ("kUTTypeMPEG", "+CoreServices")]
		NSString MPEG { get; }

		[Field ("kUTTypeMPEG2Video", "+CoreServices")]
		NSString MPEG2Video { get; }

		[Field ("kUTTypeMPEG2TransportStream", "+CoreServices")]
		NSString MPEG2TransportStream { get; }

		[Field ("kUTTypeMP3", "+CoreServices")]
		NSString MP3 { get; }

		[Field ("kUTTypeMPEG4", "+CoreServices")]
		NSString MPEG4 { get; }

		[Field ("kUTTypeMPEG4Audio", "+CoreServices")]
		NSString MPEG4Audio { get; }

		[Field ("kUTTypeAppleProtectedMPEG4Audio", "+CoreServices")]
		NSString AppleProtectedMPEG4Audio { get; }

		[Field ("kUTTypeAppleProtectedMPEG4Video", "+CoreServices")]
		NSString AppleProtectedMPEG4Video { get; }

		[Field ("kUTTypeAVIMovie", "+CoreServices")]
		NSString AVIMovie { get; }

		[Field ("kUTTypeAudioInterchangeFileFormat", "+CoreServices")]
		NSString AudioInterchangeFileFormat { get; }

		[Field ("kUTTypeWaveformAudio", "+CoreServices")]
		NSString WaveformAudio { get; }

		[Field ("kUTTypeMIDIAudio", "+CoreServices")]
		NSString MIDIAudio { get; }

		[Field ("kUTTypePlaylist", "+CoreServices")]
		NSString Playlist { get; }

		[Field ("kUTTypeM3UPlaylist", "+CoreServices")]
		NSString M3UPlaylist { get; }

		[Field ("kUTTypeFolder", "+CoreServices")]
		NSString Folder { get; }

		[Field ("kUTTypeVolume", "+CoreServices")]
		NSString Volume { get; }

		[Field ("kUTTypePackage", "+CoreServices")]
		NSString Package { get; }

		[Field ("kUTTypeBundle", "+CoreServices")]
		NSString Bundle { get; }

		[Field ("kUTTypePluginBundle", "+CoreServices")]
		NSString PluginBundle { get; }

		[Field ("kUTTypeSpotlightImporter", "+CoreServices")]
		NSString SpotlightImporter { get; }

		[Field ("kUTTypeQuickLookGenerator", "+CoreServices")]
		NSString QuickLookGenerator { get; }

		[Field ("kUTTypeXPCService", "+CoreServices")]
		NSString XPCService { get; }

		[Field ("kUTTypeFramework", "+CoreServices")]
		NSString Framework { get; }

		[Field ("kUTTypeApplication", "+CoreServices")]
		NSString Application { get; }

		[Field ("kUTTypeApplicationBundle", "+CoreServices")]
		NSString ApplicationBundle { get; }

		[Field ("kUTTypeApplicationFile", "+CoreServices")]
		NSString ApplicationFile { get; }

		[Field ("kUTTypeUnixExecutable", "+CoreServices")]
		NSString UnixExecutable { get; }

		[Field ("kUTTypeWindowsExecutable", "+CoreServices")]
		NSString WindowsExecutable { get; }

		[Field ("kUTTypeJavaClass", "+CoreServices")]
		NSString JavaClass { get; }

		[Field ("kUTTypeJavaArchive", "+CoreServices")]
		NSString JavaArchive { get; }

		[Field ("kUTTypeSystemPreferencesPane", "+CoreServices")]
		NSString SystemPreferencesPane { get; }

		[Field ("kUTTypeGNUZipArchive", "+CoreServices")]
		NSString GNUZipArchive { get; }

		[Field ("kUTTypeBzip2Archive", "+CoreServices")]
		NSString Bzip2Archive { get; }

		[Field ("kUTTypeZipArchive", "+CoreServices")]
		NSString ZipArchive { get; }

		[Field ("kUTTypeSpreadsheet", "+CoreServices")]
		NSString Spreadsheet { get; }

		[Field ("kUTTypePresentation", "+CoreServices")]
		NSString Presentation { get; }

		[Field ("kUTTypeDatabase", "+CoreServices")]
		NSString Database { get; }

		[Field ("kUTTypeVCard", "+CoreServices")]
		NSString VCard { get; }

		[Field ("kUTTypeToDoItem", "+CoreServices")]
		NSString ToDoItem { get; }

		[Field ("kUTTypeCalendarEvent", "+CoreServices")]
		NSString CalendarEvent { get; }

		[Field ("kUTTypeEmailMessage", "+CoreServices")]
		NSString EmailMessage { get; }

		[Field ("kUTTypeInternetLocation", "+CoreServices")]
		NSString InternetLocation { get; }

		[Field ("kUTTypeInkText", "+CoreServices")]
		NSString InkText { get; }

		[Field ("kUTTypeFont", "+CoreServices")]
		NSString Font { get; }

		[Field ("kUTTypeBookmark", "+CoreServices")]
		NSString Bookmark { get; }

		[Field ("kUTType3DContent", "+CoreServices")]
		NSString ThreeDContent { get; }

		[Field ("kUTTypePKCS12", "+CoreServices")]
		NSString PKCS12 { get; }

		[Field ("kUTTypeX509Certificate", "+CoreServices")]
		NSString X509Certificate { get; }

		[Field ("kUTTypeElectronicPublication", "+CoreServices")]
		NSString ElectronicPublication { get; }

		[Field ("kUTTypeLog", "+CoreServices")]
		NSString Log { get; }

		[Field ("kUTExportedTypeDeclarationsKey", "+CoreServices")]
		NSString ExportedTypeDeclarationsKey { get; }

		[Field ("kUTImportedTypeDeclarationsKey", "+CoreServices")]
		NSString ImportedTypeDeclarationsKey { get; }

		[Field ("kUTTypeIdentifierKey", "+CoreServices")]
		NSString IdentifierKey { get; }

		[Field ("kUTTypeTagSpecificationKey", "+CoreServices")]
		NSString TagSpecificationKey { get; }

		[Field ("kUTTypeConformsToKey", "+CoreServices")]
		NSString ConformsToKey { get; }

		[Field ("kUTTypeDescriptionKey", "+CoreServices")]
		NSString DescriptionKey { get; }

		[Field ("kUTTypeIconFileKey", "+CoreServices")]
		NSString IconFileKey { get; }

		[Field ("kUTTypeReferenceURLKey", "+CoreServices")]
		NSString ReferenceURLKey { get; }

		[Field ("kUTTypeVersionKey", "+CoreServices")]
		NSString VersionKey { get; }

		[Field ("kUTTagClassFilenameExtension", "+CoreServices")]
		NSString TagClassFilenameExtension { get; }

		[Field ("kUTTagClassMIMEType", "+CoreServices")]
		NSString TagClassMIMEType { get; }

		[NoiOS]
		[NoMacCatalyst]
		[NoWatch]
		[NoTV]
		[Field ("kUTTagClassNSPboardType", "+CoreServices")]
		NSString TagClassNSPboardType { get; }

		[NoiOS]
		[NoMacCatalyst]
		[NoWatch]
		[NoTV]
		[Field ("kUTTagClassOSType", "+CoreServices")]
		NSString TagClassOSType { get; }

		[Field ("kUTTypeSwiftSource", "+CoreServices")]
		NSString SwiftSource { get; }

		[NoWatch]
		[Field ("kUTTypeAlembic", "ModelIO")]
		NSString Alembic { get; }

		[NoWatch]
		[Field ("kUTType3dObject", "ModelIO")]
		NSString k3dObject { get; }

		[NoWatch]
		[Field ("kUTTypePolygon", "ModelIO")]
		NSString Polygon { get; }

		[NoWatch]
		[Field ("kUTTypeStereolithography", "ModelIO")]
		NSString Stereolithography { get; }

		[NoWatch]
		[Field ("kUTTypeUniversalSceneDescription", "ModelIO")]
		NSString UniversalSceneDescription { get; }

		[NoWatch]
		[iOS (15, 0), Mac (12, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kUTTypeUniversalSceneDescriptionMobile", "ModelIO")]
		NSString UniversalSceneDescriptionMobile { get; }

		[NoMac]
		[Field ("kUTTypeLivePhoto", "+CoreServices")]
		NSString LivePhoto { get; }
	}
}
