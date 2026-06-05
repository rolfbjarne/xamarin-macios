//
// Copyright 2010, Kenneth Pouncey
//
// composer.cs: Definitions for binding QuartzComposer.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using AppKit;
using CoreGraphics;
using CoreAnimation;
using CoreImage;
using CoreVideo;

namespace QuartzComposer {

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	interface QCComposition : NSCopying {
		/// <param name="path">The file path to the composition.</param>
		/// <summary>Creates a composition from a file at the specified path.</summary>
		/// <returns>A new composition instance, or <see langword="null" /> on failure.</returns>
		[Static]
		[Export ("compositionWithFile:")]
		QCComposition GetComposition (string path);

		/// <param name="data">The data containing the composition.</param>
		/// <summary>Creates a composition from the specified data.</summary>
		/// <returns>A new composition instance, or <see langword="null" /> on failure.</returns>
		[Static]
		[Export ("compositionWithData:")]
		QCComposition GetComposition (NSData data);

		/// <summary>Gets the protocols supported by this composition.</summary>
		[Export ("protocols")]
		string [] Protocols { get; }

		/// <summary>Gets the attributes dictionary for this composition.</summary>
		[Export ("attributes")]
		NSDictionary Attributes { get; }

		/// <summary>Gets the input keys for this composition.</summary>
		[Export ("inputKeys")]
		string [] InputKeys { get; }

		/// <summary>Gets the output keys for this composition.</summary>
		[Export ("outputKeys")]
		string [] OutputKeys { get; }

		/// <summary>Gets the identifier of this composition.</summary>
		[Export ("identifier")]
		string Identifier { get; }

		/// <summary>The key for the composition name attribute.</summary>
		[Field ("QCCompositionAttributeNameKey")]
		NSString AttributeNameKey { get; }

		/// <summary>The key for the composition description attribute.</summary>
		[Field ("QCCompositionAttributeDescriptionKey")]
		NSString AttributeDescriptionKey { get; }

		/// <summary>The key for the composition copyright attribute.</summary>
		[Field ("QCCompositionAttributeCopyrightKey")]
		NSString AttributeCopyrightKey { get; }

		/// <summary>The key for the composition built-in attribute.</summary>
		[Field ("QCCompositionAttributeBuiltInKey")]
		NSString AttributeBuiltInKey { get; }

		/// <summary>The key for the time-dependent attribute.</summary>
		[Field ("QCCompositionAttributeIsTimeDependentKey")]
		NSString AttributeIsTimeDependentKey { get; }

		/// <summary>The key for the has-consumers attribute.</summary>
		[Field ("QCCompositionAttributeHasConsumersKey")]
		NSString AttributeHasConsumersKey { get; }

		/// <summary>The key for the composition category attribute.</summary>
		[Field ("QCCompositionAttributeCategoryKey")]
		NSString AttributeCategoryKey { get; }

		/// <summary>The distortion category identifier.</summary>
		[Field ("QCCompositionCategoryDistortion")]
		NSString CategoryDistortion { get; }

		/// <summary>The stylize category identifier.</summary>
		[Field ("QCCompositionCategoryStylize")]
		NSString CategoryStylize { get; }

		/// <summary>The utility category identifier.</summary>
		[Field ("QCCompositionCategoryUtility")]
		NSString CategoryUtility { get; }

		/// <summary>The key for the input image.</summary>
		[Field ("QCCompositionInputImageKey")]
		NSString InputImageKey { get; }

		/// <summary>The key for the input source image.</summary>
		[Field ("QCCompositionInputSourceImageKey")]
		NSString InputSourceImageKey { get; }

		/// <summary>The key for the input destination image.</summary>
		[Field ("QCCompositionInputDestinationImageKey")]
		NSString InputDestinationImageKey { get; }

#if !XAMCORE_5_0
		// The 'InputRSSFeedURLKey' property has manual bindings.
		// The 'InputRSSArticleDurationKey' property has manual bindings.
#endif

		/// <summary>The key for the input preview mode.</summary>
		[Field ("QCCompositionInputPreviewModeKey")]
		NSString InputPreviewModeKey { get; }

		/// <summary>The key for the input X position.</summary>
		[Field ("QCCompositionInputXKey")]
		NSString InputXKey { get; }

		/// <summary>The key for the input Y position.</summary>
		[Field ("QCCompositionInputYKey")]
		NSString InputYKey { get; }

		/// <summary>The key for the input screen image.</summary>
		[Field ("QCCompositionInputScreenImageKey")]
		NSString InputScreenImageKey { get; }

		/// <summary>The key for the input audio peak.</summary>
		[Field ("QCCompositionInputAudioPeakKey")]
		NSString InputAudioPeakKey { get; }

		/// <summary>The key for the input audio spectrum.</summary>
		[Field ("QCCompositionInputAudioSpectrumKey")]
		NSString InputAudioSpectrumKey { get; }

		/// <summary>The key for the input track position.</summary>
		[Field ("QCCompositionInputTrackPositionKey")]
		NSString InputTrackPositionKey { get; }

		/// <summary>The key for the input track info.</summary>
		[Field ("QCCompositionInputTrackInfoKey")]
		NSString InputTrackInfoKey { get; }

		/// <summary>The key for the input track signal.</summary>
		[Field ("QCCompositionInputTrackSignalKey")]
		NSString InputTrackSignalKey { get; }

		/// <summary>The key for the input primary color.</summary>
		[Field ("QCCompositionInputPrimaryColorKey")]
		NSString InputPrimaryColorKey { get; }

		/// <summary>The key for the input secondary color.</summary>
		[Field ("QCCompositionInputSecondaryColorKey")]
		NSString InputSecondaryColorKey { get; }

		/// <summary>The key for the input pace.</summary>
		[Field ("QCCompositionInputPaceKey")]
		NSString InputPaceKey { get; }

		/// <summary>The key for the output image.</summary>
		[Field ("QCCompositionOutputImageKey")]
		NSString OutputImageKey { get; }

		/// <summary>The key for the output web page URL.</summary>
		[Field ("QCCompositionOutputWebPageURLKey")]
		NSString OutputWebPageURLKey { get; }

		/// <summary>The graphic animation protocol identifier.</summary>
		[Field ("QCCompositionProtocolGraphicAnimation")]
		NSString ProtocolGraphicAnimation { get; }

		/// <summary>The graphic transition protocol identifier.</summary>
		[Field ("QCCompositionProtocolGraphicTransition")]
		NSString ProtocolGraphicTransition { get; }

		/// <summary>The image filter protocol identifier.</summary>
		[Field ("QCCompositionProtocolImageFilter")]
		NSString ProtocolImageFilter { get; }

		/// <summary>The screen saver protocol identifier.</summary>
		[Field ("QCCompositionProtocolScreenSaver")]
		NSString ProtocolScreenSaver { get; }

#if !XAMCORE_5_0
		// The 'ProtocolRSSVisualizer' property has manual bindings.
#endif

		/// <summary>The music visualizer protocol identifier.</summary>
		[Field ("QCCompositionProtocolMusicVisualizer")]
		NSString ProtocolMusicVisualizer { get; }
	}


	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'Metal' instead.")]
	[BaseType (typeof (CAOpenGLLayer))]
	[DisableDefaultCtor] // return invalid handle
	interface QCCompositionLayer {

		/// <param name="path">The file path to the composition.</param>
		/// <summary>Creates a composition layer from the file at the specified path.</summary>
		/// <returns>A new composition layer instance.</returns>
		[Static]
		[Export ("compositionLayerWithFile:")]
		QCCompositionLayer Create (string path);

		/// <param name="composition">The composition to use.</param>
		/// <summary>Creates a composition layer from the specified composition.</summary>
		/// <returns>A new composition layer instance.</returns>
		[Static]
		[Export ("compositionLayerWithComposition:")]
		QCCompositionLayer Create (QCComposition composition);

		/// <param name="path">The file path to the composition.</param>
		/// <summary>Initializes a composition layer from the file at the specified path.</summary>
		
		[Export ("initWithFile:")]
		NativeHandle Constructor (string path);

		/// <param name="composition">The composition to render.</param>
		/// <summary>Initializes a composition layer with the specified composition.</summary>
		
		[Export ("initWithComposition:")]
		NativeHandle Constructor (QCComposition composition);

		/// <summary>Gets the composition rendered by this layer.</summary>
		[Export ("composition")]
		QCComposition Composition { get; }

	}

	[Deprecated (PlatformName.MacOSX, 10, 15)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // crash when used (e.g. description) meant to be used thru sharedCompositionRepository
	interface QCCompositionRepository {
		/// <summary>Gets the shared composition repository.</summary>
		[Static]
		[Export ("sharedCompositionRepository")]
		QCCompositionRepository SharedCompositionRepository { get; }

		/// <param name="identifier">The identifier of the composition to find.</param>
		/// <summary>Gets a composition by its identifier.</summary>
		/// <returns>The composition with the specified identifier, or <see langword="null" />.</returns>
		[Export ("compositionWithIdentifier:")]
		QCComposition GetComposition (string identifier);

		/// <param name="protocols">The protocols to filter by.</param>
		/// <param name="attributes">The attributes to filter by.</param>
		/// <summary>Gets compositions matching the specified protocols and attributes.</summary>
		/// <returns>An array of matching compositions.</returns>
		[Export ("compositionsWithProtocols:andAttributes:")]
		QCComposition [] GetCompositions (NSArray protocols, NSDictionary attributes);

		/// <summary>Gets all available compositions.</summary>
		[Export ("allCompositions")]
		QCComposition [] AllCompositions { get; }

	}

}
