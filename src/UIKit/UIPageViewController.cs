//
// UIPageViewController.cs: Helper methods for the UIPageViewController
//
// Copyright 2011-2012, Xamarin, Inc.
//
// Author:
//  Miguel de Icaza
//

namespace UIKit {
	public partial class UIPageViewController {
		/// <param name="style">The style.</param>
		///         <param name="navigationOrientation">The navigation orientation.</param>
		///         <param name="spineLocation">The spine location.</param>
		///         <summary>Creates an initialized <see cref="UIKit.UIPageViewController" /> object by using a <see cref="UIKit.UIPageViewControllerTransitionStyle" /> of transition between pages, a <see cref="UIKit.UIPageViewControllerNavigationOrientation" /> orientation of navigation, and a <paramref name="spineLocation" />.</summary>
		public UIPageViewController (UIPageViewControllerTransitionStyle style, UIPageViewControllerNavigationOrientation navigationOrientation, UIPageViewControllerSpineLocation spineLocation) : this (style, navigationOrientation, NSDictionary.FromObjectsAndKeys (new object [] { spineLocation }, new object [] { OptionSpineLocationKey }))
		{
		}

		/// <param name="style">The style.</param>
		/// <param name="navigationOrientation">The navigation orientation.</param>
		/// <param name="spineLocation">The spine location.</param>
		/// <param name="interPageSpacing">The inter page spacing.</param>
		/// <summary>Creates a new page view controller with the specified style, orientation, spine location, and inter-page spacing.</summary>
		public UIPageViewController (UIPageViewControllerTransitionStyle style, UIPageViewControllerNavigationOrientation navigationOrientation, UIPageViewControllerSpineLocation spineLocation, float interPageSpacing) : this (style, navigationOrientation, NSDictionary.FromObjectsAndKeys (new object [] { spineLocation, interPageSpacing }, new object [] { OptionSpineLocationKey, OptionInterPageSpacingKey }))
		{
		}

		/// <param name="style">The style.</param>
		/// <param name="navigationOrientation">The navigation orientation.</param>
		/// <summary>Creates a new page view controller with the specified style and orientation.</summary>
		public UIPageViewController (UIPageViewControllerTransitionStyle style, UIPageViewControllerNavigationOrientation navigationOrientation) : this (style, navigationOrientation, NSDictionary.FromObjectsAndKeys (new object [] { UIPageViewControllerSpineLocation.Mid }, new object [] { OptionSpineLocationKey }))
		{
		}

	}
}
