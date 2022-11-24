using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI {

	[Native]
	public enum PHLivePhotoViewPlaybackStyle : long {
		Undefined = 0,
		Full,
		Hint
	}

#if MONOMAC
	[NoiOS][NoTV][NoMacCatalyst]
	[Native]
	public enum PHLivePhotoViewContentMode : long {
		AspectFit,
		AspectFill,
	}
#else
	[NoMac]
	[Native]
	[Flags] // NS_OPTIONS
	public enum PHLivePhotoBadgeOptions : ulong {
		None = 0,
		OverContent = 1 << 0,
		LiveOff = 1 << 1,
	}
#endif
	[NoiOS]
	[NoTV]
	[NoWatch]
	public enum PHProjectCategory {
		[Field ("PHProjectCategoryBook")]
		Book,
		[Field ("PHProjectCategoryCalendar")]
		Calendar,
		[Field ("PHProjectCategoryCard")]
		Card,
		[Field ("PHProjectCategoryPrints")]
		Prints,
		[Field ("PHProjectCategorySlideshow")]
		Slideshow,
		[Field ("PHProjectCategoryWallDecor")]
		WallDecor,
		[Field ("PHProjectCategoryOther")]
		Other,
		[Field ("PHProjectCategoryUndefined")]
		Undefined,
	}

	[NoWatch, NoTV]
	[iOS (14, 0)]
	[Mac (13, 0)]
	[Native]
	public enum PHPickerConfigurationAssetRepresentationMode : long {
		Automatic = 0,
		Current = 1,
		Compatible = 2,
	}
}
