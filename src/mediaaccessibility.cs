using System;

using ObjCRuntime;
using Foundation;

namespace MediaAccessibility {

#if NET
	[Static]
	interface MACaptionAppearance {
		[Notification]
		[Field ("kMACaptionAppearanceSettingsChangedNotification")]
		NSString SettingsChangedNotification { get; }
	}
#endif

	[Static]
	interface MAAudibleMedia {
		[Notification]
		[Field ("kMAAudibleMediaSettingsChangedNotification")]
		NSString SettingsChangedNotification { get; }
	}

	[Static]
	interface MAMediaCharacteristic {
		[Field ("MAMediaCharacteristicDescribesMusicAndSoundForAccessibility")]
		NSString DescribesMusicAndSoundForAccessibility { get; }

		[Field ("MAMediaCharacteristicDescribesVideoForAccessibility")]
		NSString DescribesVideoForAccessibility { get; }

		[Field ("MAMediaCharacteristicTranscribesSpokenDialogForAccessibility")]
		NSString TranscribesSpokenDialogForAccessibility { get; }
	}
}
