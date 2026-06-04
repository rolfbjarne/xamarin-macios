//
// NSSegmentedControl: Support for the NSSegmentedControl class
//
// Author:
//   Pavel Sich (pavel.sich@me.com)
//

#if !__MACCATALYST__

#nullable enable

namespace AppKit {

	public partial class NSSegmentedControl {
		NSActionDispatcher? dispatcher;

		/// <summary>Gets or sets the segmented cell associated with this control.</summary>
		public new NSSegmentedCell Cell {
			get { return (NSSegmentedCell) base.Cell; }
			set { base.Cell = value; }
		}

		/// <param name="labels">The labels.</param>
		///         <param name="trackingMode">The tracking mode.</param>
		///         <param name="action">The action to perform.</param>
		///         <summary>Froms labels.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSSegmentedControl FromLabels (string [] labels, NSSegmentSwitchTracking trackingMode, Action action)
		{
			var dispatcher = new NSActionDispatcher (action);
			var control = _FromLabels (labels, trackingMode, dispatcher, NSActionDispatcher.Selector);
			control.dispatcher = dispatcher;
			return control;
		}

		/// <param name="images">The images.</param>
		///         <param name="trackingMode">The tracking mode.</param>
		///         <param name="action">The action to perform.</param>
		///         <summary>Froms images.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSSegmentedControl FromImages (NSImage [] images, NSSegmentSwitchTracking trackingMode, Action action)
		{
			var dispatcher = new NSActionDispatcher (action);
			var control = _FromImages (images, trackingMode, dispatcher, NSActionDispatcher.Selector);
			control.dispatcher = dispatcher;
			return control;
		}

		/// <summary>Unselects all segments.</summary>
		public void UnselectAllSegments ()
		{
			NSSegmentSwitchTracking current = this.Cell.TrackingMode;
			this.Cell.TrackingMode = NSSegmentSwitchTracking.Momentary;

			for (nint i = 0; i < this.SegmentCount; i++)
				SetSelected (false, i);

			this.Cell.TrackingMode = current;
		}

	}
}
#endif // !__MACCATALYST__
