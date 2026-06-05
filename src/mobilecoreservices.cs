
namespace MobileCoreServices {

	/// <summary>Defines constants for Uniform Type Identifiers (UTIs) which are strings that identify a given class of type or item.</summary>
	///     <remarks>
	///       <para>Uniform Type Identifiers (UTIs) are Apple's method for identifying data types.</para>
	///       <para>UTIs use a reverse-DNS naming structure.  UTIs support multiple inheritance, allowing files to be identified with any number of relevant types, as appropriate to the contained data.</para>
	///     </remarks>
	[Deprecated (PlatformName.iOS, 14, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.TvOS, 14, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use the 'UniformTypeIdentifiers.UTType' API instead.")]
	[Partial]
	interface UTType {
		/// <summary>Represents the value associated with the constant kUTTypeItem</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeItem", "+CoreServices")]
		NSString Item { get; }

		/// <summary>Represents the value associated with the constant kUTTypeContent</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeContent", "+CoreServices")]
		NSString Content { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCompositeContent</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCompositeContent", "+CoreServices")]
		NSString CompositeContent { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMessage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMessage", "+CoreServices")]
		NSString Message { get; }

		/// <summary>Represents the value associated with the constant kUTTypeContact</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeContact", "+CoreServices")]
		NSString Contact { get; }

		/// <summary>Represents the value associated with the constant kUTTypeArchive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeArchive", "+CoreServices")]
		NSString Archive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeDiskImage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeDiskImage", "+CoreServices")]
		NSString DiskImage { get; }

		/// <summary>Represents the value associated with the constant kUTTypeData</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeData", "+CoreServices")]
		NSString Data { get; }

		/// <summary>Represents the value associated with the constant kUTTypeDirectory</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeDirectory", "+CoreServices")]
		NSString Directory { get; }

		/// <summary>Represents the value associated with the constant kUTTypeResolvable</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeResolvable", "+CoreServices")]
		NSString Resolvable { get; }

		/// <summary>Represents the value associated with the constant kUTTypeSymLink</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeSymLink", "+CoreServices")]
		NSString SymLink { get; }

		/// <summary>Represents the value associated with the constant kUTTypeExecutable</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeExecutable", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Executable { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMountPoint</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMountPoint", "+CoreServices")]
		NSString MountPoint { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAliasFile</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAliasFile", "+CoreServices")]
		NSString AliasFile { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAliasRecord</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAliasRecord", "+CoreServices")]
		NSString AliasRecord { get; }

		/// <summary>Represents the value associated with the constant kUTTypeURLBookmarkData</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeURLBookmarkData", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString URLBookmarkData { get; }

		/// <summary>Represents the value associated with the constant kUTTypeURL</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeURL", "+CoreServices")]
		NSString URL { get; }

		/// <summary>Represents the value associated with the constant kUTTypeFileURL</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeFileURL", "+CoreServices")]
		NSString FileURL { get; }

		/// <summary>Represents the value associated with the constant kUTTypeText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeText", "+CoreServices")]
		NSString Text { get; }

		/// <summary>Represents the value associated with the constant kUTTypePlainText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePlainText", "+CoreServices")]
		NSString PlainText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeUTF8PlainText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeUTF8PlainText", "+CoreServices")]
		NSString UTF8PlainText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeUTF16ExternalPlainText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeUTF16ExternalPlainText", "+CoreServices")]
		NSString UTF16ExternalPlainText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeUTF16PlainText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeUTF16PlainText", "+CoreServices")]
		NSString UTF16PlainText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeDelimitedText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeDelimitedText", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString DelimitedText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCommaSeparatedText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCommaSeparatedText", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString CommaSeparatedText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeTabSeparatedText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeTabSeparatedText", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString TabSeparatedText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeUTF8TabSeparatedText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeUTF8TabSeparatedText", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString UTF8TabSeparatedText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeRTF</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeRTF", "+CoreServices")]
		NSString RTF { get; }

		/// <summary>Represents the value associated with the constant kUTTypeHTML</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeHTML", "+CoreServices")]
		NSString HTML { get; }

		/// <summary>Represents the value associated with the constant kUTTypeXML</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeXML", "+CoreServices")]
		NSString XML { get; }

		/// <summary>Represents the value associated with the constant kUTTypeSourceCode</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeSourceCode", "+CoreServices")]
		NSString SourceCode { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAssemblyLanguageSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAssemblyLanguageSource", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString AssemblyLanguageSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCSource", "+CoreServices")]
		NSString CSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeObjectiveCSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeObjectiveCSource", "+CoreServices")]
		NSString ObjectiveCSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCPlusPlusSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCPlusPlusSource", "+CoreServices")]
		NSString CPlusPlusSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeObjectiveCPlusPlusSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeObjectiveCPlusPlusSource", "+CoreServices")]
		NSString ObjectiveCPlusPlusSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCHeader</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCHeader", "+CoreServices")]
		NSString CHeader { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCPlusPlusHeader</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCPlusPlusHeader", "+CoreServices")]
		NSString CPlusPlusHeader { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJavaSource</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJavaSource", "+CoreServices")]
		NSString JavaSource { get; }

		/// <summary>Represents the value associated with the constant kUTTypeScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Script { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAppleScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAppleScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString AppleScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypeOSAScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeOSAScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString OSAScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypeOSAScriptBundle</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeOSAScriptBundle", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString OSAScriptBundle { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJavaScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJavaScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString JavaScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypeShellScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeShellScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ShellScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypePerlScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePerlScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PerlScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypePythonScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePythonScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PythonScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypeRubyScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeRubyScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString RubyScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypePHPScript</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePHPScript", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PHPScript { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJSON</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJSON", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString JSON { get; }

		/// <summary>Represents the value associated with the constant kUTTypePropertyList</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePropertyList", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PropertyList { get; }

		/// <summary>Represents the value associated with the constant kUTTypeXMLPropertyList</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeXMLPropertyList", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString XMLPropertyList { get; }

		/// <summary>Represents the value associated with the constant kUTTypeBinaryPropertyList</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeBinaryPropertyList", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString BinaryPropertyList { get; }

		/// <summary>Represents the value associated with the constant kUTTypePDF</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePDF", "+CoreServices")]
		NSString PDF { get; }

		/// <summary>Represents the value associated with the constant kUTTypeRTFD</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeRTFD", "+CoreServices")]
		NSString RTFD { get; }

		/// <summary>Represents the value associated with the constant kUTTypeFlatRTFD</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeFlatRTFD", "+CoreServices")]
		NSString FlatRTFD { get; }

		/// <summary>Represents the value associated with the constant kUTTypeTXNTextAndMultimediaData</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeTXNTextAndMultimediaData", "+CoreServices")]
		NSString TXNTextAndMultimediaData { get; }

		/// <summary>Represents the value associated with the constant kUTTypeWebArchive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeWebArchive", "+CoreServices")]
		NSString WebArchive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeImage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeImage", "+CoreServices")]
		NSString Image { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJPEG</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJPEG", "+CoreServices")]
		NSString JPEG { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJPEG2000</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJPEG2000", "+CoreServices")]
		NSString JPEG2000 { get; }

		/// <summary>Represents the value associated with the constant kUTTypeTIFF</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeTIFF", "+CoreServices")]
		NSString TIFF { get; }

		/// <summary>Represents the value associated with the constant kUTTypePICT</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePICT", "+CoreServices")]
		NSString PICT { get; }

		/// <summary>Represents the value associated with the constant kUTTypeGIF</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeGIF", "+CoreServices")]
		NSString GIF { get; }

		/// <summary>Represents the value associated with the constant kUTTypePNG</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePNG", "+CoreServices")]
		NSString PNG { get; }

		/// <summary>Represents the value associated with the constant kUTTypeQuickTimeImage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeQuickTimeImage", "+CoreServices")]
		NSString QuickTimeImage { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAppleICNS</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAppleICNS", "+CoreServices")]
		NSString AppleICNS { get; }

		/// <summary>Represents the value associated with the constant kUTTypeBMP</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeBMP", "+CoreServices")]
		NSString BMP { get; }

		/// <summary>Represents the value associated with the constant kUTTypeICO</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeICO", "+CoreServices")]
		NSString ICO { get; }

		/// <summary>Represents the value associated with the constant kUTTypeRawImage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeRawImage", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString RawImage { get; }

		/// <summary>Represents the value associated with the constant kUTTypeScalableVectorGraphics</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeScalableVectorGraphics", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ScalableVectorGraphics { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAudiovisualContent</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAudiovisualContent", "+CoreServices")]
		NSString AudiovisualContent { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMovie</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMovie", "+CoreServices")]
		NSString Movie { get; }

		/// <summary>Represents the value associated with the constant kUTTypeVideo</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeVideo", "+CoreServices")]
		NSString Video { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAudio</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAudio", "+CoreServices")]
		NSString Audio { get; }

		/// <summary>Represents the value associated with the constant kUTTypeQuickTimeMovie</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeQuickTimeMovie", "+CoreServices")]
		NSString QuickTimeMovie { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMPEG</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMPEG", "+CoreServices")]
		NSString MPEG { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMPEG2Video</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMPEG2Video", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString MPEG2Video { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMPEG2TransportStream</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMPEG2TransportStream", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString MPEG2TransportStream { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMP3</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMP3", "+CoreServices")]
		NSString MP3 { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMPEG4</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMPEG4", "+CoreServices")]
		NSString MPEG4 { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMPEG4Audio</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMPEG4Audio", "+CoreServices")]
		NSString MPEG4Audio { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAppleProtectedMPEG4Audio</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAppleProtectedMPEG4Audio", "+CoreServices")]
		NSString AppleProtectedMPEG4Audio { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAppleProtectedMPEG4Video</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAppleProtectedMPEG4Video", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString AppleProtectedMPEG4Video { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAVIMovie</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAVIMovie", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString AVIMovie { get; }

		/// <summary>Represents the value associated with the constant kUTTypeAudioInterchangeFileFormat</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeAudioInterchangeFileFormat", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString AudioInterchangeFileFormat { get; }

		/// <summary>Represents the value associated with the constant kUTTypeWaveformAudio</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeWaveformAudio", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString WaveformAudio { get; }

		/// <summary>Represents the value associated with the constant kUTTypeMIDIAudio</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeMIDIAudio", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString MIDIAudio { get; }

		/// <summary>Represents the value associated with the constant kUTTypePlaylist</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePlaylist", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Playlist { get; }

		/// <summary>Represents the value associated with the constant kUTTypeM3UPlaylist</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeM3UPlaylist", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString M3UPlaylist { get; }

		/// <summary>Represents the value associated with the constant kUTTypeFolder</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeFolder", "+CoreServices")]
		NSString Folder { get; }

		/// <summary>Represents the value associated with the constant kUTTypeVolume</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeVolume", "+CoreServices")]
		NSString Volume { get; }

		/// <summary>Represents the value associated with the constant kUTTypePackage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePackage", "+CoreServices")]
		NSString Package { get; }

		/// <summary>Represents the value associated with the constant kUTTypeBundle</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeBundle", "+CoreServices")]
		NSString Bundle { get; }

		/// <summary>Represents the value associated with the constant kUTTypePluginBundle</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePluginBundle", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PluginBundle { get; }

		/// <summary>Represents the value associated with the constant kUTTypeSpotlightImporter</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeSpotlightImporter", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString SpotlightImporter { get; }

		/// <summary>Represents the value associated with the constant kUTTypeQuickLookGenerator</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeQuickLookGenerator", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString QuickLookGenerator { get; }

		/// <summary>Represents the value associated with the constant kUTTypeXPCService</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeXPCService", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString XPCService { get; }

		/// <summary>Represents the value associated with the constant kUTTypeFramework</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeFramework", "+CoreServices")]
		NSString Framework { get; }

		/// <summary>Represents the value associated with the constant kUTTypeApplication</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeApplication", "+CoreServices")]
		NSString Application { get; }

		/// <summary>Represents the value associated with the constant kUTTypeApplicationBundle</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeApplicationBundle", "+CoreServices")]
		NSString ApplicationBundle { get; }

		/// <summary>Represents the value associated with the constant kUTTypeApplicationFile</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeApplicationFile", "+CoreServices")]
		NSString ApplicationFile { get; }

		/// <summary>Represents the value associated with the constant kUTTypeUnixExecutable</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeUnixExecutable", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString UnixExecutable { get; }

		/// <summary>Represents the value associated with the constant kUTTypeWindowsExecutable</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeWindowsExecutable", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString WindowsExecutable { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJavaClass</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJavaClass", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString JavaClass { get; }

		/// <summary>Represents the value associated with the constant kUTTypeJavaArchive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeJavaArchive", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString JavaArchive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeSystemPreferencesPane</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeSystemPreferencesPane", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString SystemPreferencesPane { get; }

		/// <summary>Represents the value associated with the constant kUTTypeGNUZipArchive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeGNUZipArchive", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString GNUZipArchive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeBzip2Archive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeBzip2Archive", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Bzip2Archive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeZipArchive</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeZipArchive", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ZipArchive { get; }

		/// <summary>Represents the value associated with the constant kUTTypeSpreadsheet</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeSpreadsheet", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Spreadsheet { get; }

		/// <summary>Represents the value associated with the constant kUTTypePresentation</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePresentation", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Presentation { get; }

		/// <summary>Represents the value associated with the constant kUTTypeDatabase</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeDatabase", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Database { get; }

		/// <summary>Represents the value associated with the constant kUTTypeVCard</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeVCard", "+CoreServices")]
		NSString VCard { get; }

		/// <summary>Represents the value associated with the constant kUTTypeToDoItem</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeToDoItem", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ToDoItem { get; }

		/// <summary>Represents the value associated with the constant kUTTypeCalendarEvent</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeCalendarEvent", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString CalendarEvent { get; }

		/// <summary>Represents the value associated with the constant kUTTypeEmailMessage</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeEmailMessage", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString EmailMessage { get; }

		/// <summary>Represents the value associated with the constant kUTTypeInternetLocation</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeInternetLocation", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString InternetLocation { get; }

		/// <summary>Represents the value associated with the constant kUTTypeInkText</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeInkText", "+CoreServices")]
		NSString InkText { get; }

		/// <summary>Represents the value associated with the constant kUTTypeFont</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeFont", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Font { get; }

		/// <summary>Represents the value associated with the constant kUTTypeBookmark</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeBookmark", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Bookmark { get; }

		/// <summary>Represents the value associated with the constant kUTType3DContent</summary>
		///         <value>
		///         </value>
		[Field ("kUTType3DContent", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ThreeDContent { get; }

		/// <summary>Represents the value associated with the constant kUTTypePKCS12</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypePKCS12", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString PKCS12 { get; }

		/// <summary>Represents the value associated with the constant kUTTypeX509Certificate</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeX509Certificate", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString X509Certificate { get; }

		/// <summary>Represents the value associated with the constant kUTTypeElectronicPublication</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeElectronicPublication", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString ElectronicPublication { get; }

		/// <summary>Represents the value associated with the constant kUTTypeLog</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeLog", "+CoreServices")]
		[MacCatalyst (13, 1)]
		NSString Log { get; }

		/// <summary>Represents the value associated with the constant kUTExportedTypeDeclarationsKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTExportedTypeDeclarationsKey", "+CoreServices")]
		NSString ExportedTypeDeclarationsKey { get; }

		/// <summary>Represents the value associated with the constant kUTImportedTypeDeclarationsKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTImportedTypeDeclarationsKey", "+CoreServices")]
		NSString ImportedTypeDeclarationsKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeIdentifierKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeIdentifierKey", "+CoreServices")]
		NSString IdentifierKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeTagSpecificationKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeTagSpecificationKey", "+CoreServices")]
		NSString TagSpecificationKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeConformsToKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeConformsToKey", "+CoreServices")]
		NSString ConformsToKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeDescriptionKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeDescriptionKey", "+CoreServices")]
		NSString DescriptionKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeIconFileKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeIconFileKey", "+CoreServices")]
		NSString IconFileKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeReferenceURLKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeReferenceURLKey", "+CoreServices")]
		NSString ReferenceURLKey { get; }

		/// <summary>Represents the value associated with the constant kUTTypeVersionKey</summary>
		///         <value>
		///         </value>
		[Field ("kUTTypeVersionKey", "+CoreServices")]
		NSString VersionKey { get; }

		/// <summary>Represents the value associated with the constant kUTTagClassFilenameExtension</summary>
		///         <value>
		///         </value>
		[Field ("kUTTagClassFilenameExtension", "+CoreServices")]
		NSString TagClassFilenameExtension { get; }

		/// <summary>Represents the value associated with the constant kUTTagClassMIMEType</summary>
		///         <value>
		///         </value>
		[Field ("kUTTagClassMIMEType", "+CoreServices")]
		NSString TagClassMIMEType { get; }

		/// <summary>The UTI tag class for pasteboard types.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Field ("kUTTagClassNSPboardType", "+CoreServices")]
		NSString TagClassNSPboardType { get; }

		/// <summary>The UTI tag class for OSType codes.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Field ("kUTTagClassOSType", "+CoreServices")]
		NSString TagClassOSType { get; }

		/// <summary>The UTI for Swift source code.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTTypeSwiftSource", "+CoreServices")]
		NSString SwiftSource { get; }

		/// <summary>The UTI for Alembic 3D files.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTTypeAlembic", "ModelIO")]
		NSString Alembic { get; }

		/// <summary>The UTI for 3D objects.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTType3dObject", "ModelIO")]
		NSString k3dObject { get; }

		/// <summary>The UTI for polygon meshes.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTTypePolygon", "ModelIO")]
		NSString Polygon { get; }

		/// <summary>The UTI for stereolithography files.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTTypeStereolithography", "ModelIO")]
		NSString Stereolithography { get; }

		/// <summary>The UTI for Universal Scene Description files.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kUTTypeUniversalSceneDescription", "ModelIO")]
		NSString UniversalSceneDescription { get; }

		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		[Field ("kUTTypeUniversalSceneDescriptionMobile", "ModelIO")]
		NSString UniversalSceneDescriptionMobile { get; }

		/// <summary>The UTI for Live Photos.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Field ("kUTTypeLivePhoto", "+CoreServices")]
		NSString LivePhoto { get; }
	}
}
