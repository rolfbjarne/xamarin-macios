//
// CoreMotion's struct and enum definitions used by the API file
//

#nullable enable

namespace CoreMotion {

	// CMAccelerometer.h
	/// <summary>A 3D vector containing acceleration values.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct CMAcceleration {
		/// <summary>Acceleration along the X axis, in Gs.</summary>
		public double X;
		/// <summary>Acceleration along the Y axis, in Gs.</summary>
		public double Y;
		/// <summary>Acceleration along the Z axis, in Gs.</summary>
		public double Z;

		/// <param name="x">The x.</param>
		///         <param name="y">The y.</param>
		///         <param name="z">The z.</param>
		///         <summary>Creates a new <see cref="CoreMotion.CMAcceleration" /> object, along the specified axes, with values in Gs.</summary>
		public CMAcceleration (double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>A string, of the form $"a=({x},{y},{z})".</summary>
		public override string ToString ()
		{
			return String.Format ("a=({0},{1},{2})", X, Y, Z);
		}
	}

	// CMAttitude.h
	/// <include file="../../docs/api/CoreMotion/CMRotationMatrix.xml" path="/Documentation/Docs[@DocId='T:CoreMotion.CMRotationMatrix']/*" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct CMRotationMatrix {
		/// <summary>The m11.</summary>
		public double m11;
		/// <summary>The m12.</summary>
		public double m12;
		/// <summary>The m13.</summary>
		public double m13;
		/// <summary>The m21.</summary>
		public double m21;
		/// <summary>The m22.</summary>
		public double m22;
		/// <summary>The m23.</summary>
		public double m23;
		/// <summary>The m31.</summary>
		public double m31;
		/// <summary>The m32.</summary>
		public double m32;
		/// <summary>The m33.</summary>
		public double m33;
	}

	// CMAttitude.h
	/// <summary>Represents a Quaternion, used as one of the possible CMAttitude representations.</summary>
	///     <remarks>
	///       <para>Quaternions can be used to specify a non-ambiguous rotation. They avoid the issue of gymbal lock and are simpler to compose.</para>
	///     </remarks>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct CMQuaternion {
		/// <summary>The imaginary x component.</summary>
		public double x;
		/// <summary>The imaginary y component.</summary>
		public double y;
		/// <summary>The imaginary z component.</summary>
		public double z;
		/// <summary>The real part of the quaternion.</summary>
		public double w;

		/// <param name="x">The x.</param>
		///         <param name="y">The y.</param>
		///         <param name="z">The z.</param>
		///         <param name="w">The w.</param>
		///         <summary>Constructs a new <see cref="CoreMotion.CMQuaternion" /> with the specified components.</summary>
		public CMQuaternion (double x, double y, double z, double w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>In the form $"quaternion({x},{y},{z},{w}").</summary>
		public override string ToString ()
		{
			return String.Format ("quaternion=({0},{1},{2},{3})", x, y, z, w);
		}
	}

	// CMGyro.h
	/// <summary>3D rotation rate.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct CMRotationRate {
		/// <summary>The rotation rate around the X axis, in radians per second.</summary>
		public double x;
		/// <summary>The rotation rate around the Y axis, in radians per second.</summary>
		public double y;
		/// <summary>The rotation rate around the Z axis, in radians per second.</summary>
		public double z;

		/// <param name="x">The x.</param>
		///         <param name="y">The y.</param>
		///         <param name="z">The z.</param>
		///         <summary>Creates a new <see cref="CoreMotion.CMRotationRate" /> that rotates around the various axes at the specified rate, in radians per second.</summary>
		public CMRotationRate (double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>A string of the form $"rotationRate=({x},{y},{z}"	string".</summary>
		public override string ToString ()
		{
			return String.Format ("rotationRate=({0},{1},{2}", x, y, z);
		}
	}

	// untyped enum -> CMDeviceMotion.h
	/// <summary>An enumeration whose values specify the quality of the magnetometer calibration.</summary>
	public enum CMMagneticFieldCalibrationAccuracy {
		/// <summary>Magnetic calibration has not occurred.</summary>
		Uncalibrated = -1,
		/// <summary>The magnetic calibration was marginal.</summary>
		Low,
		/// <summary>The magnetic calibration was of medium quality.</summary>
		Medium,
		/// <summary>The magnetic calibration was of high quality.</summary>
		High,
	}
}
