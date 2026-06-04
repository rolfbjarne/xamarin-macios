using CoreLocation;

#nullable enable

namespace MapKit {

	public partial class MKPolyline {

		/// <param name="points">The points.</param>
		///         <summary>Froms points.</summary>
		///         <remarks>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="threads">This can be used from a background thread.</para>
		///         </remarks>
		public static unsafe MKPolyline FromPoints (MKMapPoint [] points)
		{
			if (points is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (points));
			if (points.Length == 0)
				return _FromPoints (IntPtr.Zero, 0);

			fixed (MKMapPoint* first = points) {
				return _FromPoints ((IntPtr) first, points.Length);
			}
		}

		/// <param name="coords">The coords.</param>
		///         <summary>Froms coordinates.</summary>
		///         <remarks>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="threads">This can be used from a background thread.</para>
		///         </remarks>
		public static unsafe MKPolyline FromCoordinates (CLLocationCoordinate2D [] coords)
		{
			if (coords is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (coords));
			if (coords.Length == 0)
				return _FromCoordinates (IntPtr.Zero, 0);

			fixed (CLLocationCoordinate2D* first = coords) {
				return _FromCoordinates ((IntPtr) first, coords.Length);
			}
		}
	}
}
