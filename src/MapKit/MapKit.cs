//
// MapKit definitions
//
// Author:
//   Miguel de Icaza
//
// Copyright 2009 Novell, Inc.
// Copyright 2014-2015 Xamarin Inc.
//

using System.Runtime.CompilerServices;
using CoreGraphics;
using CoreLocation;

#nullable enable

namespace MapKit {

	// MKTileOverlay.h
	/// <summary>Encapsulates the index values of AParticular <see cref="MapKit.MKTileOverlay" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKTileOverlayPath {
		/// <summary>The index of the <see cref="MapKit.MKTileOverlay" /> along the X axis.</summary>
		public /* NSInteger */ nint X;
		/// <summary>The index of the <see cref="MapKit.MKTileOverlay" /> along the Y axis.</summary>
		public /* NSInteger */ nint Y;
		/// <summary>The Zoom level for the <see cref="MapKit.MKTileOverlay" />.</summary>
		///         <remarks>
		///           <list type="table">
		///             <listheader>
		///               <term>Zoom Level</term>
		///               <description>Number of tiles to map entire world</description>
		///             </listheader>
		///             <item>
		///               <term>0</term>
		///               <description>1</description>
		///             </item>
		///             <item>
		///               <term>1</term>
		///               <description>4</description>
		///             </item>
		///             <item>
		///               <term>2</term>
		///               <description>16</description>
		///             </item>
		///             <item>
		///               <term>n</term>
		///               <description>(2N)^2</description>
		///             </item>
		///           </list>
		///         </remarks>
		public /* NSInteger */ nint Z;
		/// <summary>The screen scaling factor for which the tile is intended. A value of 1.0 indicates standard resolution, a value of 2.0 indicates Retina displays.</summary>
		public /* CGFloat */ nfloat ContentScaleFactor;
	}

	// MKGeometry.h
	// note: CLLocationDegrees is double - see CLLocation.h
	/// <summary>The area spanned by a region of the map.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKCoordinateSpan {
		/// <summary>The amount of north-to-south distance in degrees.</summary>
		public /* CLLocationDegrees */ double LatitudeDelta;
		/// <summary>The amount of east-to-west distance in degrees.</summary>
		public /* CLLocationDegrees */ double LongitudeDelta;

		// MKCoordinateSpanMake
		/// <param name="latitudeDelta">The latitudeDelta.</param>
		/// <param name="longitudeDelta">The longitudeDelta.</param>
		/// <summary>Creates a coordinate span with the specified latitude and longitude deltas.</summary>
		public MKCoordinateSpan (double latitudeDelta, double longitudeDelta)
		{
			LatitudeDelta = latitudeDelta;
			LongitudeDelta = longitudeDelta;
		}

		/// <summary>Returns a string representation of this coordinate span.</summary>
		public override string ToString ()
		{
			return $"(LatitudeDelta={LatitudeDelta}, LongitudeDelta={LongitudeDelta}";
		}
	}

	// MKGeometry.h
	/// <summary>Defines a region of the map to display.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKCoordinateRegion {
		/// <summary>The center for the region of the map to display.</summary>
		///         <remarks>
		///         </remarks>
		public CLLocationCoordinate2D Center;
		/// <summary>Represents the dimensions and zoom level to display.</summary>
		///         <remarks>
		///         </remarks>
		public MKCoordinateSpan Span;

		// MKCoordinateRegionMake
		/// <param name="center">The center of the region.</param>
		///         <param name="span">The dimensions of the region.</param>
		///         <summary>Creates a new object representing a region of the map to display.</summary>
		///         <remarks>
		///         </remarks>
		public MKCoordinateRegion (CLLocationCoordinate2D center, MKCoordinateSpan span)
		{
			this.Center = center;
			this.Span = span;
		}

		// note: CLLocationDistance is double - see CLLocation.h
		/// <param name="center">The center of the region</param>
		///         <param name="latitudinalMeters">The latitude expressed in meters (north to south).</param>
		///         <param name="longitudinalMeters">The longitudinal expressed in meters (east to west).</param>
		///         <summary>Creates a new object representing a region of the map to display using a center and a distance (represented in meters).</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKCoordinateRegionMakeWithDistance")]
		extern static public MKCoordinateRegion FromDistance (CLLocationCoordinate2D center, /* CLLocationDistance */ double latitudinalMeters, /* CLLocationDistance */ double longitudinalMeters);

		/// <param name="rect">The MKMapRect source.</param>
		///         <summary>Returns a MKCoordinateRegion for the specified 2D-map rectangle.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKCoordinateRegionForMapRect")]
		extern static public MKCoordinateRegion FromMapRect (MKMapRect rect);

		/// <summary>Returns a string representation of this coordinate span.</summary>
		public override string ToString ()
		{
			return $"(Center={Center}, Span={Span}";
		}
	}

	// MKGeometry.h
	/// <include file="../../docs/api/MapKit/MKMapPoint.xml" path="/Documentation/Docs[@DocId='T:MapKit.MKMapPoint']/*" />
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKMapPoint {
		/// <summary>Gets or sets the X coordinate.</summary>
		public double X;
		/// <summary>Gets or sets the Y coordinate.</summary>
		public double Y;

		/// <param name="coordinate">The coordinate.</param>
		///         <summary>Converts a coordinate to a map point.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapPointForCoordinate")]
		public extern static MKMapPoint FromCoordinate (CLLocationCoordinate2D coordinate);

		/// <param name="mapPoint">The mapPoint.</param>
		///         <summary>Converts a map point to a coordinate.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKCoordinateForMapPoint")]
		public extern static CLLocationCoordinate2D ToCoordinate (MKMapPoint mapPoint);

		// MKMapPointMake
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <summary>Creates a map point with the specified x and y values.</summary>
		public MKMapPoint (double x, double y)
		{
			X = x;
			Y = y;
		}

		// MKMapPointEqualToPoint
		public static bool operator == (MKMapPoint a, MKMapPoint b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		public static bool operator != (MKMapPoint a, MKMapPoint b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		/// <param name="other">The other.</param>
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		public override bool Equals (object? other)
		{
			if (other is MKMapPoint) {
				var omap = (MKMapPoint) other;

				return omap.X == X && omap.Y == Y;
			}
			return false;
		}

		/// <summary>Returns a hash code for this instance.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (X, Y);
		}

		// MKStringFromMapPoint does not really exists, it's inlined in MKGeometry.h
		/// <summary>Returns a string representation of this coordinate span.</summary>
		public override string ToString ()
		{
			return String.Format ("{{{0}, {1}}}", X, Y);
		}
	}

	// MKGeometry.h
	/// <summary>The extent of a 2D map projection as measured in map points.</summary>
	///     <remarks>
	///     </remarks>
	///     <altmember cref="MapKit.MKMapPoint" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKMapSize {
		/// <summary>Gets or sets the width.</summary>
		public double Width;
		/// <summary>Gets or sets the height.</summary>
		public double Height;

		// MKMapSizeMake
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <summary>Creates a map size with the specified width and height.</summary>
		public MKMapSize (double width, double height)
		{
			Width = width;
			Height = height;
		}

		/// <summary>Creates a map size with the specified width and height.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static MKMapSize World { get { return new MKMapSize (0x10000000, 0x10000000); } }

		// MKMapSizeEqualToSize
		public static bool operator == (MKMapSize a, MKMapSize b)
		{
			return a.Width == b.Width && a.Height == b.Height;
		}

		public static bool operator != (MKMapSize a, MKMapSize b)
		{
			return a.Width != b.Width || a.Height != b.Height;
		}

		/// <param name="other">The other.</param>
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		public override bool Equals (object? other)
		{
			if (other is MKMapSize) {
				var omap = (MKMapSize) other;

				return omap.Width == Width && omap.Height == Height;
			}
			return false;
		}

		/// <summary>Returns a hash code for this instance.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (Width, Height);
		}

		// MKStringFromMapSize does not really exists, it's inlined in MKGeometry.h
		/// <summary>Returns a string representation of this coordinate span.</summary>
		public override string ToString ()
		{
			return String.Format ("{{{0}, {1}}}", Width, Height);
		}
	}

	// MKGeometry.h
	/// <summary>A rectangular area in a 2D map projection, measured in map points.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct MKMapRect {
		/// <summary>A known-invalid <see cref="MapKit.MKMapRect" /> (see <see cref="MapKit.MKMapRect.IsNull" />).</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static readonly MKMapRect Null = new MKMapRect (double.PositiveInfinity, double.PositiveInfinity, 0, 0);

		/// <summary>The starting location of the <see cref="MapKit.MKMapRect" />.</summary>
		///         <remarks>
		///           <para>Note that a <see cref="MapKit.MKMapRect" /> may have negative <see cref="MapKit.MKMapRect.Height" /> or <see cref="MapKit.MKMapRect.Width" />, so <see cref="MapKit.MKMapRect.Origin" /> is not necessarily located at [<see cref="MapKit.MKMapRect.MinX" />, <see cref="MapKit.MKMapRect.MinY" />].</para>
		///         </remarks>
		public MKMapPoint Origin;
		/// <summary>The extent of the <see cref="MapKit.MKMapRect" />.</summary>
		public MKMapSize Size;

		/// <param name="origin">The origin.</param>
		/// <param name="size">The size.</param>
		///         <summary>Creates a new <see cref="MapKit.MKMapPoint" /> struct with the specified <paramref name="origin" /> and <paramref name="size" />.</summary>
		public MKMapRect (MKMapPoint origin, MKMapSize size)
		{
			Origin = origin;
			Size = size;
		}

		// MKMapRectMake
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		///         <summary>Creates a new <see cref="MapKit.MKMapRect" /> originating at [<paramref name="x" />, <paramref name="y" />] and of the specified <paramref name="height" /> and <paramref name="width" />.</summary>
		public MKMapRect (double x, double y, double width, double height)
		{
			Origin.X = x;
			Origin.Y = y;
			Size.Width = width;
			Size.Height = height;
		}

		// MKMapRectGetMinX
		/// <summary>The minimum X-axis value of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MinX {
			get {
				return Origin.X;
			}
		}

		// MKMapRectGetMinY
		/// <summary>The minimum Y-axis value of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MinY {
			get {
				return Origin.Y;
			}
		}

		// MKMapRectGetMaxX
		/// <summary>The maximum X-axis value of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MaxX {
			get {
				return Origin.X + Size.Width;
			}
		}

		// MKMapRectGetMaxY
		/// <summary>The maximum Y-axis value of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MaxY {
			get {
				return Origin.Y + Size.Height;
			}
		}

		// MKMapRectGetMidX
		/// <summary>The X-axis midpoint of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MidX {
			get {
				return Origin.X + Size.Width / 2.0;
			}
		}

		// MKMapRectGetMidY
		/// <summary>The Y-axis midpoint of the <see cref="MapKit.MKMapRect" />.</summary>
		public double MidY {
			get {
				return Origin.Y + Size.Height / 2.0;
			}
		}

		// MKMapRectGetWidth
		/// <summary>The extent along the X-axis of the <see cref="MapKit.MKMapRect" />.</summary>
		public double Width {
			get {
				return Size.Width;
			}
		}

		// MKMapRectGetHeight
		/// <summary>The height of this <see cref="MapKit.MKMapRect" />, in degrees.</summary>
		public double Height {
			get {
				return Size.Height;
			}
		}

		// MKMapRectIsNull
		/// <summary>Whether the <see cref="MapKit.MKMapRect" /> is the known-invalid rectangle <see cref="MapKit.MKMapRect.Null" />.</summary>
		public bool IsNull {
			get {
				return Double.IsInfinity (Origin.X) || Double.IsInfinity (Origin.Y);
			}
		}

		// MKMapRectIsEmpty
		/// <summary>Whether the <see cref="MapKit.MKMapRect" /> has APositive area.</summary>
		public bool IsEmpty {
			get {
				return IsNull || Size.Width == 0 || Size.Height == 0;
			}
		}

		/// <summary>The <see cref="MapKit.MKMapRect" /> that represents the world in the 2D map projection.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]

#if XAMCORE_5_0
		public static MKMapRect World {
			get {
				return new MKMapRect (0, 0, 0x10000000, 0x10000000);
			}
		}
#else
		public MKMapRect World {
			get {
				return new MKMapRect (0, 0, 0x10000000, 0x10000000);
			}
		}
#endif

		// MKMapRectEqualToRect
		public static bool operator == (MKMapRect a, MKMapRect b)
		{
			return a.Origin == b.Origin && a.Size == b.Size;
		}

		public static bool operator != (MKMapRect a, MKMapRect b)
		{
			return a.Origin != b.Origin || a.Size != b.Size;
		}

		/// <param name="other">The other.</param>
		///         <summary>Whether this <see cref="MapKit.MKMapRect" /> has the same <see cref="MapKit.MKMapRect.Origin" /> and <see cref="MapKit.MKMapRect.Size" /> values as the <paramref name="other" />.</summary>
		public override bool Equals (object? other)
		{
			if (other is MKMapRect) {
				var omap = (MKMapRect) other;

				return omap.Origin == Origin && omap.Size == Size;
			}
			return false;
		}

		/// <summary>Returns a hash of this <see cref="MapKit.MKMapRect" /> struct's value.</summary>
		public override int GetHashCode ()
		{
			return HashCode.Combine (Origin, Size);
		}

		// MKStringFromMapRect does not really exists, it's inlined in MKGeometry.h
		/// <summary>A brief representation of the origin and size of the <see cref="MapKit.MKMapRect" />.</summary>
		public override string ToString ()
		{
			return string.Format ("{{{0}, {1}}}", Origin, Size);
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectContainsPoint")]
		static extern byte MKMapRectContainsPoint (MKMapRect rect, MKMapPoint point);

		/// <param name="point">The point.</param>
		///         <summary>Whether the <see cref="MapKit.MKMapRect" /> contains <paramref name="point" />.</summary>
		public bool Contains (MKMapPoint point)
		{
			return MKMapRectContainsPoint (this, point) != 0;
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectContainsRect")]
		static extern byte MKMapRectContainsRect (MKMapRect rect1, MKMapRect rect2);

		/// <param name="rect">The rect.</param>
		///         <summary>Whether <paramref name="rect" /> is entirely within the bounds of this <see cref="MapKit.MKMapRect" />.</summary>
		public bool Contains (MKMapRect rect)
		{
			return MKMapRectContainsRect (this, rect) != 0;
		}

		/// <param name="rect1">The rect1.</param>
		/// <param name="rect2">The rect2.</param>
		///         <summary>Returns the rectangle covering both <paramref name="rect1" /> and <paramref name="rect2" />.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectUnion")]
		static public extern MKMapRect Union (MKMapRect rect1, MKMapRect rect2);

		/// <param name="rect1">The rect1.</param>
		/// <param name="rect2">The rect2.</param>
		///         <summary>Static method returning the intersection of <paramref name="rect1" /> with <paramref name="rect2" />.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectIntersection")]
		static public extern MKMapRect Intersection (MKMapRect rect1, MKMapRect rect2);

		[DllImport (Constants.MapKitLibrary)]
		static extern byte MKMapRectIntersectsRect (MKMapRect rect1, MKMapRect rect2);

		/// <param name="rect1">The rect1.</param>
		/// <param name="rect2">The rect2.</param>
		///         <summary>Whether <paramref name="rect1" /> and <paramref name="rect2" /> overlap.</summary>
		public static bool Intersects (MKMapRect rect1, MKMapRect rect2)
		{
			return MKMapRectIntersectsRect (rect1, rect2) != 0;
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectInset")]
		static extern MKMapRect MKMapRectInset (MKMapRect rect, double dx, double dy);

		/// <param name="dx">The dx.</param>
		/// <param name="dy">The dy.</param>
		///         <summary>Returns a new <see cref="MapKit.MKMapRect" /> based on <c>this</c>, offset by <paramref name="dx" /> and <paramref name="dy" />.</summary>
		public MKMapRect Inset (double dx, double dy)
		{
			return MKMapRectInset (this, dx, dy);
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectOffset")]
		static extern MKMapRect MKMapRectOffset (MKMapRect rect, double dx, double dy);

		/// <param name="dx">The dx.</param>
		/// <param name="dy">The dy.</param>
		///         <summary>A new <see cref="MapKit.MKMapRect" /> whose origin is shifted by <paramref name="dx" /> and <paramref name="dy" />.</summary>
		public MKMapRect Offset (double dx, double dy)
		{
			return MKMapRectOffset (this, dx, dy);
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectDivide")]
		unsafe static extern void MKMapRectDivide (MKMapRect rect, MKMapRect* slice, MKMapRect* remainder, double amount, CGRectEdge edge);

#if !COREBUILD
		/// <param name="amount">The amount.</param>
		/// <param name="edge">The edge.</param>
		/// <param name="remainder">The remainder.</param>
		///         <summary>Splits this <see cref="MapKit.MKMapRect" /> into a two smaller rectangle (returned value and <paramref name="remainder" />).</summary>
		///         <remarks>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// var rect = new MKMapRect(new MKMapPoint(19, -122), new MKMapSize(10, 10));
		///
		/// //Cannot make null because MKMapRect is a value type
		/// var r2 = new MKMapRect();
		///
		/// //Divide into smaller rectangles
		/// var slice = rect.Divide (5.0, new CGRectEdge(), out r2);
		/// // slice = {{19,-122},{5, 10}} , r2 = {{24, -122},{5, 10}}
		///     ]]></code>
		///           </example>
		///         </remarks>
		public MKMapRect Divide (double amount, CGRectEdge edge, out MKMapRect remainder)
		{
			MKMapRect slice;
			remainder = default;
			unsafe {
				fixed (MKMapRect* remainderPtr = &remainder)
					MKMapRectDivide (this, &slice, remainderPtr, amount, edge);
			}
			return slice;
		}
#endif

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectSpans180thMeridian")]
		static extern byte MKMapRectSpans180thMeridian (MKMapRect rect);

		/// <summary>Whether the <see cref="MapKit.MKMapRect" /> crosses the ante-meridian.</summary>
		public bool Spans180thMeridian {
			get { return MKMapRectSpans180thMeridian (this) != 0; }
		}

		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapRectRemainder")]
		static extern MKMapRect MKMapRectRemainder (MKMapRect rect);

		/// <summary>A new <see cref="MapKit.MKMapRect" /> that has been normalized to remove areas outside the world map's boundaries.</summary>
		public MKMapRect Remainder ()
		{
			return MKMapRectRemainder (this);
		}
	}

	// MKGeometry.h
	/// <summary>Helper class containing methods for calculating distances and latitude-dependent scales.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public static class MKGeometry {

		/// <param name="latitude">The latitude.</param>
		///         <summary>Gets the number of map points per meter at the specified latitude.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMapPointsPerMeterAtLatitude")]
		static extern public double MapPointsPerMeterAtLatitude (/* CLLocationDegrees */ double latitude);

		/// <param name="latitude">The latitude.</param>
		///         <summary>Gets the number of meters per map point at the specified latitude.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMetersPerMapPointAtLatitude")]
		static extern public /* CLLocationDistance */ double MetersPerMapPointAtLatitude (/* CLLocationDegrees */ double latitude);

		/// <param name="a">The a.</param>
		/// <param name="b">The b.</param>
		///         <summary>Gets the distance in meters between two map points.</summary>
		[DllImport (Constants.MapKitLibrary, EntryPoint = "MKMetersBetweenMapPoints")]
		static extern public /* CLLocationDistance */ double MetersBetweenMapPoints (MKMapPoint a, MKMapPoint b);
	}

#if COREBUILD
	public partial class MKMapLaunchOptions : NSObject {
	}
#endif
}
