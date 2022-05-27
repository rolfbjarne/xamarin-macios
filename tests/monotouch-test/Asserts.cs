using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#if !__WATCHOS__
using ModelIO;
using MetalPerformanceShaders;
#endif
#if HAS_SCENEKIT
using SceneKit;
#endif

#if NET
using System.Numerics;
using CoreGraphics;
using MatrixFloat2x2 = global::CoreGraphics.NMatrix2;
using MatrixFloat3x3 = global::CoreGraphics.NMatrix3;
using MatrixFloat4x3 = global::CoreGraphics.NMatrix4x3;
using Matrix4 = global::System.Numerics.Matrix4x4;
using MatrixFloat4x4 = global::CoreGraphics.NMatrix4;
using VectorFloat3 = global::CoreGraphics.NVector3;
using MatrixDouble4x4 = global::CoreGraphics.NMatrix4d;
using VectorDouble2 = global::CoreGraphics.NVector2d;
using VectorDouble3 = global::CoreGraphics.NVector3d;
using Vector4d = global::CoreGraphics.NVector4d;
using Vector2i = global::CoreGraphics.NVector2i;
using Vector4i = global::CoreGraphics.NVector4i;
using Quaterniond = global::CoreGraphics.NQuaterniond;
#else
using OpenTK;
using MatrixFloat2x2 = global::OpenTK.NMatrix2;
using MatrixFloat3x3 = global::OpenTK.NMatrix3;
using MatrixFloat4x3 = global::OpenTK.NMatrix4x3;
using MatrixFloat4x4 = global::OpenTK.NMatrix4;
using VectorFloat3 = global::OpenTK.NVector3;
using MatrixDouble4x4 = global::OpenTK.NMatrix4d;
using VectorDouble3 = global::OpenTK.NVector3d;
#endif

#if __MACOS__
#if NET
using pfloat = System.Runtime.InteropServices.NFloat;
#else
using pfloat = System.nfloat;
#endif
#else
using pfloat = System.Single;
#endif

using NUnit.Framework;

public static class Asserts
{
	public static void AreEqual (bool expected, bool actual, string message)
	{
		Assert.AreEqual (expected, actual, $"{message} (M) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (float expected, float actual, string message)
	{
		Assert.AreEqual (expected, actual, $"{message} (M) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (float expected, float actual, float delta, string message)
	{
		Assert.AreEqual (expected, actual, delta, message);
	}

	public static void AreEqual (Vector2 expected, Vector2 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector3 expected, Vector3 actual, string message)
	{

		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector3 expected, Vector3 actual, float delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector3 expected, VectorFloat3 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (VectorFloat3 expected, Vector3 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (VectorFloat3 expected, VectorFloat3 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (VectorFloat3 expected, VectorFloat3 actual, float delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector4 expected, Vector4 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, $"{message} (W) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector4 expected, Vector4 actual, float delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, delta, $"{message} (W) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (Matrix2 expected, Matrix2 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix3 expected, Matrix3 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix3 expected, Matrix3 actual, float delta, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, delta, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, delta, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, delta, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, delta, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, delta, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, delta, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, delta, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, delta, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, delta, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}
#endif

	public static void AreEqual (Matrix4 expected, Matrix4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix4 expected, Matrix4 actual, float delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, delta, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, delta, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, delta, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, delta, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector2i expected, Vector2i actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector4i expected, Vector4i actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, $"{message} (W) expected: {expected} actual: {actual}");
	}

#if !__WATCHOS__
	public static void AreEqual (MDLAxisAlignedBoundingBox expected, MDLAxisAlignedBoundingBox actual, string message)
	{
		AreEqual (expected.MaxBounds, actual.MaxBounds, $"{message} (MaxBounds) expected: {expected} actual: {actual}");
		AreEqual (expected.MinBounds, actual.MinBounds, $"{message} (MinBounds) expected: {expected} actual: {actual}");
	}
#endif // !__WATCHOS__

	public static void AreEqual (Quaternion expected, Quaternion actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, $"{message} (W) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Quaternion [] expected, Quaternion [] actual, string message)
	{
		if (expected == null) {
			if (actual == null)
				return;
			Assert.Fail ($"Expected null, got {actual}. {message}");
		} else if (actual == null) {
			Assert.Fail ($"Expected {expected}, got null. {message}");
		}

		Assert.AreEqual (expected.Length, actual.Length, $"{message} array lengths");
		for (var i = 0; i < expected.Length; i++) {
			AreEqual (expected [i], actual [i], message + $" [{i}]");
		}
	}

	public static void AreEqual (Quaterniond expected, Quaterniond actual, string message)
	{
		if (expected == null) {
			if (actual == null)
				return;
			Assert.Fail ($"Expected null, got {actual}. {message}");
		} else if (actual == null) {
			Assert.Fail ($"Expected {expected}, got null. {message}");
		}

		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, $"{message} (W) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Quaterniond expected, Quaterniond actual, double delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, delta, $"{message} (W) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Quaterniond [] expected, Quaterniond [] actual, string message)
	{
		Assert.AreEqual (expected.Length, actual.Length, $"{message} array lengths");
		for (var i = 0; i < expected.Length; i++) {
			AreEqual (expected [i], actual [i], message + $" [{i}]");
		}
	}

#if !__WATCHOS__
	public static void AreEqual (MPSImageHistogramInfo expected, MPSImageHistogramInfo actual, string message)
	{
		Assert.AreEqual (expected.HistogramForAlpha, actual.HistogramForAlpha, $"{message} HistogramForAlpha expected: {expected} actual: {actual}");
		Asserts.AreEqual (expected.MaxPixelValue, actual.MaxPixelValue, $"{message} MaxPixelValue expected: {expected} actual: {actual}");
		Asserts.AreEqual (expected.MinPixelValue, actual.MinPixelValue, $"{message} MinPixelValue expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.NumberOfHistogramEntries, actual.NumberOfHistogramEntries, $"{message} NumberOfHistogramEntries expected: {expected} actual: {actual}");
	}
#endif // !__WATCHOS__

	public static void AreEqual (MatrixFloat2x2 expected, MatrixFloat2x2 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat2x2 expected, MatrixFloat2x2 actual, float delta, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, delta, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, delta, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, delta, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, delta, $"{message} (R1C1) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (Matrix2 expected, MatrixFloat2x2 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat2x2 expected, Matrix2 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
	}
#endif // !NET

	public static void AreEqual (MatrixFloat3x3 expected, MatrixFloat3x3 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat3x3 expected, MatrixFloat3x3 actual, float delta, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, delta, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, delta, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, delta, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, delta, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, delta, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, delta, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, delta, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, delta, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, delta, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (Matrix3 expected, MatrixFloat3x3 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat3x3 expected, Matrix3 actual, string message)
	{
		AreEqual (expected.R0C0, actual.R0C0, $"{message} (R0C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C1, actual.R0C1, $"{message} (R0C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R0C2, actual.R0C2, $"{message} (R0C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C0, actual.R1C0, $"{message} (R1C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C1, actual.R1C1, $"{message} (R1C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R1C2, actual.R1C2, $"{message} (R1C2) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C0, actual.R2C0, $"{message} (R2C0) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C1, actual.R2C1, $"{message} (R2C1) expected: {expected} actual: {actual}");
		AreEqual (expected.R2C2, actual.R2C2, $"{message} (R2C2) expected: {expected} actual: {actual}");
	}
#endif

	public static void AreEqual (MatrixFloat4x4 expected, MatrixFloat4x4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat4x4 expected, MatrixFloat4x4 actual, float delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, delta, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, delta, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, delta, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, delta, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix4 expected, MatrixFloat4x4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix4 expected, MatrixFloat4x4 actual, float delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, delta, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, delta, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, delta, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, delta, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixFloat4x4 expected, Matrix4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

#region Double Based Types
	public static void AreEqual (double expected, double actual, string message)
	{
		Assert.AreEqual (expected, actual, $"{message} (M) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (double expected, double actual, double delta, string message)
	{
		Assert.AreEqual (expected, actual, delta, message);
	}

#if !NET
	public static void AreEqual (Vector2d expected, Vector2d actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
	}
#endif

#if NET
	public static void AreEqual (VectorDouble2 expected, VectorDouble2 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, message + " (X)");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, message + " (Y)");
	}

	public static void AreEqual (VectorDouble2 expected, VectorDouble2 actual, double delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, message + " (X)");
		Assert.AreEqual (expected.Y, actual.Y, delta, message + " (Y)");
	}
#endif

#if !NET
	public static void AreEqual (Vector3d expected, Vector3d actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector3d expected, Vector3d actual, double delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector3d expected, VectorDouble3 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (VectorDouble3 expected, Vector3d actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}
#endif

	public static void AreEqual (VectorDouble3 expected, VectorDouble3 actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, 0.001, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, 0.001, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, 0.001, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (VectorDouble3 expected, VectorDouble3 actual, double delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector4d expected, Vector4d actual, string message)
	{
		Assert.AreEqual (expected.X, actual.X, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, $"{message} (W) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Vector4d expected, Vector4d actual, double delta, string message)
	{
		Assert.AreEqual (expected.X, actual.X, delta, $"{message} (X) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Y, actual.Y, delta, $"{message} (Y) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.Z, actual.Z, delta, $"{message} (Z) expected: {expected} actual: {actual}");
		Assert.AreEqual (expected.W, actual.W, delta, $"{message} (W) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (Matrix4d expected, Matrix4d actual, string message)
	{
		AreEqual (expected.Column0, actual.Column0, $"{message} (Col0) expected: {expected} actual: {actual}");
		AreEqual (expected.Column1, actual.Column1, $"{message} (Col1) expected: {expected} actual: {actual}");
		AreEqual (expected.Column2, actual.Column2, $"{message} (Col2) expected: {expected} actual: {actual}");
		AreEqual (expected.Column3, actual.Column3, $"{message} (Col3) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix4d expected, Matrix4d actual, double delta, string message)
	{
		AreEqual (expected.Column0, actual.Column0, delta, $"{message} (Col0) expected: {expected} actual: {actual}");
		AreEqual (expected.Column1, actual.Column1, delta, $"{message} (Col1) expected: {expected} actual: {actual}");
		AreEqual (expected.Column2, actual.Column2, delta, $"{message} (Col2) expected: {expected} actual: {actual}");
		AreEqual (expected.Column3, actual.Column3, delta, $"{message} (Col3) expected: {expected} actual: {actual}");
	}
#endif //!NET

	public static void AreEqual (MatrixDouble4x4 expected, MatrixDouble4x4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (MatrixDouble4x4 expected, MatrixDouble4x4 actual, double delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, delta, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, delta, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, delta, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, delta, $"{message} (M44) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (Matrix4d expected, MatrixDouble4x4 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}

	public static void AreEqual (Matrix4d expected, NMatrix4d actual, double delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, delta, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, delta, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, delta, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, delta, $"{message} (M44) expected: {expected} actual: {actual}");
	}
#endif // !NET

	public static void AreEqual (NMatrix4x3 expected, NMatrix4x3 actual, float delta, string message)
	{
		AreEqual (expected.M11, actual.M11, delta, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, delta, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, delta, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, delta, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, delta, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, delta, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, delta, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, delta, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, delta, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, delta, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, delta, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, delta, $"{message} (M34) expected: {expected} actual: {actual}");
	}

#if !NET
	public static void AreEqual (NMatrix4d expected, Matrix4d actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M41, actual.M41, $"{message} (M41) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M42, actual.M42, $"{message} (M42) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M43, actual.M43, $"{message} (M43) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
		AreEqual (expected.M44, actual.M44, $"{message} (M44) expected: {expected} actual: {actual}");
	}
#endif

	public static void AreEqual (NMatrix4x3 expected, NMatrix4x3 actual, string message)
	{
		AreEqual (expected.M11, actual.M11, $"{message} (M11) expected: {expected} actual: {actual}");
		AreEqual (expected.M21, actual.M21, $"{message} (M21) expected: {expected} actual: {actual}");
		AreEqual (expected.M31, actual.M31, $"{message} (M31) expected: {expected} actual: {actual}");
		AreEqual (expected.M12, actual.M12, $"{message} (M12) expected: {expected} actual: {actual}");
		AreEqual (expected.M22, actual.M22, $"{message} (M22) expected: {expected} actual: {actual}");
		AreEqual (expected.M32, actual.M32, $"{message} (M32) expected: {expected} actual: {actual}");
		AreEqual (expected.M13, actual.M13, $"{message} (M13) expected: {expected} actual: {actual}");
		AreEqual (expected.M23, actual.M23, $"{message} (M23) expected: {expected} actual: {actual}");
		AreEqual (expected.M33, actual.M33, $"{message} (M33) expected: {expected} actual: {actual}");
		AreEqual (expected.M14, actual.M14, $"{message} (M14) expected: {expected} actual: {actual}");
		AreEqual (expected.M24, actual.M24, $"{message} (M24) expected: {expected} actual: {actual}");
		AreEqual (expected.M34, actual.M34, $"{message} (M34) expected: {expected} actual: {actual}");
	}
#endregion

#if HAS_SCENEKIT
	public static void AreEqual (SCNVector3 expected, SCNVector3 actual, string message)
	{
		if (Is.EqualTo (expected.X).ApplyTo (actual.X).IsSuccess &&
			Is.EqualTo (expected.Y).ApplyTo (actual.Y).IsSuccess &&
			Is.EqualTo (expected.Z).ApplyTo (actual.Z).IsSuccess)
			return;
		Assert.Fail ($"{message} expected: {expected} to be equal to: {actual}");
	}

	public static void AreEqual (SCNVector3 expected, SCNVector3 actual, float delta, string message)
	{
		if ((actual.X >= expected.X - delta) && (actual.X <= expected.X + delta) &&
			(actual.Y >= expected.Y - delta) && (actual.Y <= expected.Y + delta) &&
			(actual.Z >= expected.Z - delta) && (actual.Z <= expected.Z + delta))
			return;
		Assert.Fail ($"{message} expected: {expected} to be equal to: {actual} with delta {delta}");
	}

	public static void AreEqual (SCNVector4 expected, SCNVector4 actual, string message)
	{
		if (Is.EqualTo (expected.X).ApplyTo (actual.X).IsSuccess &&
			Is.EqualTo (expected.Y).ApplyTo (actual.Y).IsSuccess &&
			Is.EqualTo (expected.Z).ApplyTo (actual.Z).IsSuccess &&
			Is.EqualTo (expected.W).ApplyTo (actual.W).IsSuccess)
			return;
		Assert.That (actual.X, Is.EqualTo (expected.X), $"{message} (X) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Y, Is.EqualTo (expected.Y), $"{message} (Y) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Z, Is.EqualTo (expected.Z), $"{message} (Z) expected: {expected} to be equal to: {actual}");
		Assert.Fail ("huh?");
	}


	public static void AreEqual (SCNVector4 expected, SCNVector4 actual, float delta, string message)
	{
		if (Is.EqualTo (expected.X).Within (delta).ApplyTo (actual.X).IsSuccess &&
			Is.EqualTo (expected.Y).Within (delta).ApplyTo (actual.Y).IsSuccess &&
			Is.EqualTo (expected.Z).Within (delta).ApplyTo (actual.Z).IsSuccess &&
			Is.EqualTo (expected.W).Within (delta).ApplyTo (actual.W).IsSuccess)
			return;
		Assert.That (actual.X, Is.EqualTo (expected.X).Within (delta), $"{message} (X) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Y, Is.EqualTo (expected.Y).Within (delta), $"{message} (Y) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Z, Is.EqualTo (expected.Z).Within (delta), $"{message} (Z) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.W, Is.EqualTo (expected.W).Within (delta), $"{message} (W) expected: {expected} to be equal to: {actual}");
		Assert.Fail ("huh?");
	}

	public static void AreEqual (SCNQuaternion expected, SCNQuaternion actual, string message)
	{
		if (Is.EqualTo (expected.X).ApplyTo (actual.X).IsSuccess &&
			Is.EqualTo (expected.Y).ApplyTo (actual.Y).IsSuccess &&
			Is.EqualTo (expected.Z).ApplyTo (actual.Z).IsSuccess &&
			Is.EqualTo (expected.W).ApplyTo (actual.W).IsSuccess)
			return;
		Assert.Fail ($"{message} expected: {expected} to be equal to: {actual}");
	}

	public static void AreEqual (SCNQuaternion expected, SCNQuaternion actual, float delta, string message)
	{
		if (Is.EqualTo (expected.X).Within (delta).ApplyTo (actual.X).IsSuccess &&
			Is.EqualTo (expected.Y).Within (delta).ApplyTo (actual.Y).IsSuccess &&
			Is.EqualTo (expected.Z).Within (delta).ApplyTo (actual.Z).IsSuccess &&
			Is.EqualTo (expected.W).Within (delta).ApplyTo (actual.W).IsSuccess)
			return;
		Assert.That (actual.X, Is.EqualTo (expected.X).Within (delta), $"{message} (X) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Y, Is.EqualTo (expected.Y).Within (delta), $"{message} (Y) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.Z, Is.EqualTo (expected.Z).Within (delta), $"{message} (Z) expected: {expected} to be equal to: {actual}");
		Assert.That (actual.W, Is.EqualTo (expected.W).Within (delta), $"{message} (W) expected: {expected} to be equal to: {actual}");
		Assert.Fail ("huh?");
	}

	public static void AreEqual (SCNMatrix4 expected, SCNMatrix4 actual, string message)
	{
		if (Is.EqualTo (expected.M11).ApplyTo (actual.M11).IsSuccess &&
			Is.EqualTo (expected.M21).ApplyTo (actual.M21).IsSuccess &&
			Is.EqualTo (expected.M31).ApplyTo (actual.M31).IsSuccess &&
			Is.EqualTo (expected.M41).ApplyTo (actual.M41).IsSuccess &&
			Is.EqualTo (expected.M12).ApplyTo (actual.M12).IsSuccess &&
			Is.EqualTo (expected.M22).ApplyTo (actual.M22).IsSuccess &&
			Is.EqualTo (expected.M32).ApplyTo (actual.M32).IsSuccess &&
			Is.EqualTo (expected.M42).ApplyTo (actual.M42).IsSuccess &&
			Is.EqualTo (expected.M13).ApplyTo (actual.M13).IsSuccess &&
			Is.EqualTo (expected.M23).ApplyTo (actual.M23).IsSuccess &&
			Is.EqualTo (expected.M33).ApplyTo (actual.M33).IsSuccess &&
			Is.EqualTo (expected.M43).ApplyTo (actual.M43).IsSuccess &&
			Is.EqualTo (expected.M14).ApplyTo (actual.M14).IsSuccess &&
			Is.EqualTo (expected.M24).ApplyTo (actual.M24).IsSuccess &&
			Is.EqualTo (expected.M34).ApplyTo (actual.M34).IsSuccess &&
			Is.EqualTo (expected.M44).ApplyTo (actual.M44).IsSuccess) {

			var size = Marshal.SizeOf (typeof (SCNMatrix4));
			unsafe {
				byte* e = (byte*) (void*) &expected;
				byte* a = (byte*) (void*) &actual;
				AreEqual (e, a, size, message);
			}
			return;
		}

		var actualString = actual.ToString ();

		var expectedString = expected.ToString ();

		var d11 = Is.EqualTo (expected.M11).ApplyTo (actual.M11).IsSuccess ? "✅" : "❌";
		var d21 = Is.EqualTo (expected.M21).ApplyTo (actual.M21).IsSuccess ? "✅" : "❌";
		var d31 = Is.EqualTo (expected.M31).ApplyTo (actual.M31).IsSuccess ? "✅" : "❌";
		var d41 = Is.EqualTo (expected.M41).ApplyTo (actual.M41).IsSuccess ? "✅" : "❌";
		var d12 = Is.EqualTo (expected.M12).ApplyTo (actual.M12).IsSuccess ? "✅" : "❌";
		var d22 = Is.EqualTo (expected.M22).ApplyTo (actual.M22).IsSuccess ? "✅" : "❌";
		var d32 = Is.EqualTo (expected.M32).ApplyTo (actual.M32).IsSuccess ? "✅" : "❌";
		var d42 = Is.EqualTo (expected.M42).ApplyTo (actual.M42).IsSuccess ? "✅" : "❌";
		var d13 = Is.EqualTo (expected.M13).ApplyTo (actual.M13).IsSuccess ? "✅" : "❌";
		var d23 = Is.EqualTo (expected.M23).ApplyTo (actual.M23).IsSuccess ? "✅" : "❌";
		var d33 = Is.EqualTo (expected.M33).ApplyTo (actual.M33).IsSuccess ? "✅" : "❌";
		var d43 = Is.EqualTo (expected.M43).ApplyTo (actual.M43).IsSuccess ? "✅" : "❌";
		var d14 = Is.EqualTo (expected.M14).ApplyTo (actual.M14).IsSuccess ? "✅" : "❌";
		var d24 = Is.EqualTo (expected.M24).ApplyTo (actual.M24).IsSuccess ? "✅" : "❌";
		var d34 = Is.EqualTo (expected.M34).ApplyTo (actual.M34).IsSuccess ? "✅" : "❌";
		var d44 = Is.EqualTo (expected.M44).ApplyTo (actual.M44).IsSuccess ? "✅" : "❌";
		var diffRow1 = $"({d11}, {d12}, {d13}, {d14})";
		var diffRow2 = $"({d21}, {d22}, {d23}, {d24})";
		var diffRow3 = $"({d31}, {d32}, {d33}, {d34})";
		var diffRow4 = $"({d41}, {d42}, {d43}, {d44})";
		var diffString = $"{diffRow1}\n{diffRow2}\n{diffRow3}\n{diffRow4}";

		var msg = $"Expected:\n{expectedString}\nActual:\n{actualString}\nDiff:\n{diffString}";
		Console.WriteLine (msg);
		Assert.Fail (message + "\n" + msg);
	}

	public static void AreEqual (SCNMatrix4 expected, SCNMatrix4 actual, float delta, string message)
	{
		if (Is.EqualTo (expected.M11).Within (delta).ApplyTo (actual.M11).IsSuccess &&
			Is.EqualTo (expected.M21).Within (delta).ApplyTo (actual.M21).IsSuccess &&
			Is.EqualTo (expected.M31).Within (delta).ApplyTo (actual.M31).IsSuccess &&
			Is.EqualTo (expected.M41).Within (delta).ApplyTo (actual.M41).IsSuccess &&
			Is.EqualTo (expected.M12).Within (delta).ApplyTo (actual.M12).IsSuccess &&
			Is.EqualTo (expected.M22).Within (delta).ApplyTo (actual.M22).IsSuccess &&
			Is.EqualTo (expected.M32).Within (delta).ApplyTo (actual.M32).IsSuccess &&
			Is.EqualTo (expected.M42).Within (delta).ApplyTo (actual.M42).IsSuccess &&
			Is.EqualTo (expected.M13).Within (delta).ApplyTo (actual.M13).IsSuccess &&
			Is.EqualTo (expected.M23).Within (delta).ApplyTo (actual.M23).IsSuccess &&
			Is.EqualTo (expected.M33).Within (delta).ApplyTo (actual.M33).IsSuccess &&
			Is.EqualTo (expected.M43).Within (delta).ApplyTo (actual.M43).IsSuccess &&
			Is.EqualTo (expected.M14).Within (delta).ApplyTo (actual.M14).IsSuccess &&
			Is.EqualTo (expected.M24).Within (delta).ApplyTo (actual.M24).IsSuccess &&
			Is.EqualTo (expected.M34).Within (delta).ApplyTo (actual.M34).IsSuccess &&
			Is.EqualTo (expected.M44).Within (delta).ApplyTo (actual.M44).IsSuccess)
			return;

		var actualString = actual.ToString ();

		var expectedString = expected.ToString ();

		var d11 = Is.EqualTo (expected.M11).Within (delta).ApplyTo (actual.M11).IsSuccess ? "✅" : "❌";
		var d21 = Is.EqualTo (expected.M21).Within (delta).ApplyTo (actual.M21).IsSuccess ? "✅" : "❌";
		var d31 = Is.EqualTo (expected.M31).Within (delta).ApplyTo (actual.M31).IsSuccess ? "✅" : "❌";
		var d41 = Is.EqualTo (expected.M41).Within (delta).ApplyTo (actual.M41).IsSuccess ? "✅" : "❌";
		var d12 = Is.EqualTo (expected.M12).Within (delta).ApplyTo (actual.M12).IsSuccess ? "✅" : "❌";
		var d22 = Is.EqualTo (expected.M22).Within (delta).ApplyTo (actual.M22).IsSuccess ? "✅" : "❌";
		var d32 = Is.EqualTo (expected.M32).Within (delta).ApplyTo (actual.M32).IsSuccess ? "✅" : "❌";
		var d42 = Is.EqualTo (expected.M42).Within (delta).ApplyTo (actual.M42).IsSuccess ? "✅" : "❌";
		var d13 = Is.EqualTo (expected.M13).Within (delta).ApplyTo (actual.M13).IsSuccess ? "✅" : "❌";
		var d23 = Is.EqualTo (expected.M23).Within (delta).ApplyTo (actual.M23).IsSuccess ? "✅" : "❌";
		var d33 = Is.EqualTo (expected.M33).Within (delta).ApplyTo (actual.M33).IsSuccess ? "✅" : "❌";
		var d43 = Is.EqualTo (expected.M43).Within (delta).ApplyTo (actual.M43).IsSuccess ? "✅" : "❌";
		var d14 = Is.EqualTo (expected.M14).Within (delta).ApplyTo (actual.M14).IsSuccess ? "✅" : "❌";
		var d24 = Is.EqualTo (expected.M24).Within (delta).ApplyTo (actual.M24).IsSuccess ? "✅" : "❌";
		var d34 = Is.EqualTo (expected.M34).Within (delta).ApplyTo (actual.M34).IsSuccess ? "✅" : "❌";
		var d44 = Is.EqualTo (expected.M44).Within (delta).ApplyTo (actual.M44).IsSuccess ? "✅" : "❌";
		var diffRow1 = $"({d11}, {d12}, {d13}, {d14})";
		var diffRow2 = $"({d21}, {d22}, {d23}, {d24})";
		var diffRow3 = $"({d31}, {d32}, {d33}, {d34})";
		var diffRow4 = $"({d41}, {d42}, {d43}, {d44})";
		var diffString = $"{diffRow1}\n{diffRow2}\n{diffRow3}\n{diffRow4}";

		var msg = $"Expected:\n{expectedString}\nActual:\n{actualString}\nDiff:\n{diffString}";
		Console.WriteLine (msg);
		Assert.Fail (message + "\n" + msg);
	}

	// The m## arguments correspond with the M## fields in SCNMatrix4
	// For .NET this means the first four values are the first column (and the first row for legacy Xamarin).
	public static void AreEqual (SCNMatrix4 actual, string message,
		pfloat m11, pfloat m12, pfloat m13, pfloat m14,
		pfloat m21, pfloat m22, pfloat m23, pfloat m24,
		pfloat m31, pfloat m32, pfloat m33, pfloat m34,
		pfloat m41, pfloat m42, pfloat m43, pfloat m44,
		double delta
	)
	{
		if (Is.EqualTo (m11).Within (delta).ApplyTo (actual.M11).IsSuccess &&
			Is.EqualTo (m21).Within (delta).ApplyTo (actual.M21).IsSuccess &&
			Is.EqualTo (m31).Within (delta).ApplyTo (actual.M31).IsSuccess &&
			Is.EqualTo (m41).Within (delta).ApplyTo (actual.M41).IsSuccess &&
			Is.EqualTo (m12).Within (delta).ApplyTo (actual.M12).IsSuccess &&
			Is.EqualTo (m22).Within (delta).ApplyTo (actual.M22).IsSuccess &&
			Is.EqualTo (m32).Within (delta).ApplyTo (actual.M32).IsSuccess &&
			Is.EqualTo (m42).Within (delta).ApplyTo (actual.M42).IsSuccess &&
			Is.EqualTo (m13).Within (delta).ApplyTo (actual.M13).IsSuccess &&
			Is.EqualTo (m23).Within (delta).ApplyTo (actual.M23).IsSuccess &&
			Is.EqualTo (m33).Within (delta).ApplyTo (actual.M33).IsSuccess &&
			Is.EqualTo (m43).Within (delta).ApplyTo (actual.M43).IsSuccess &&
			Is.EqualTo (m14).Within (delta).ApplyTo (actual.M14).IsSuccess &&
			Is.EqualTo (m24).Within (delta).ApplyTo (actual.M24).IsSuccess &&
			Is.EqualTo (m34).Within (delta).ApplyTo (actual.M34).IsSuccess &&
			Is.EqualTo (m44).Within (delta).ApplyTo (actual.M44).IsSuccess)
			return;

		var actualString = actual.ToString ();

#if NET
		var row1 = $"({m11}, {m21}, {m31}, {m41})";
		var row2 = $"({m12}, {m22}, {m32}, {m42})";
		var row3 = $"({m13}, {m23}, {m33}, {m43})";
		var row4 = $"({m14}, {m24}, {m34}, {m44})";
#else
		var row1 = $"({m11}, {m12}, {m13}, {m14})";
		var row2 = $"({m21}, {m22}, {m23}, {m24})";
		var row3 = $"({m31}, {m32}, {m33}, {m34})";
		var row4 = $"({m41}, {m42}, {m43}, {m44})";
#endif
		var expectedString = $"{row1}\n{row2}\n{row3}\n{row4}";

		var d11 = Is.EqualTo (m11).Within (delta).ApplyTo (actual.M11).IsSuccess ? "✅" : "❌";
		var d21 = Is.EqualTo (m21).Within (delta).ApplyTo (actual.M21).IsSuccess ? "✅" : "❌";
		var d31 = Is.EqualTo (m31).Within (delta).ApplyTo (actual.M31).IsSuccess ? "✅" : "❌";
		var d41 = Is.EqualTo (m41).Within (delta).ApplyTo (actual.M41).IsSuccess ? "✅" : "❌";
		var d12 = Is.EqualTo (m12).Within (delta).ApplyTo (actual.M12).IsSuccess ? "✅" : "❌";
		var d22 = Is.EqualTo (m22).Within (delta).ApplyTo (actual.M22).IsSuccess ? "✅" : "❌";
		var d32 = Is.EqualTo (m32).Within (delta).ApplyTo (actual.M32).IsSuccess ? "✅" : "❌";
		var d42 = Is.EqualTo (m42).Within (delta).ApplyTo (actual.M42).IsSuccess ? "✅" : "❌";
		var d13 = Is.EqualTo (m13).Within (delta).ApplyTo (actual.M13).IsSuccess ? "✅" : "❌";
		var d23 = Is.EqualTo (m23).Within (delta).ApplyTo (actual.M23).IsSuccess ? "✅" : "❌";
		var d33 = Is.EqualTo (m33).Within (delta).ApplyTo (actual.M33).IsSuccess ? "✅" : "❌";
		var d43 = Is.EqualTo (m43).Within (delta).ApplyTo (actual.M43).IsSuccess ? "✅" : "❌";
		var d14 = Is.EqualTo (m14).Within (delta).ApplyTo (actual.M14).IsSuccess ? "✅" : "❌";
		var d24 = Is.EqualTo (m24).Within (delta).ApplyTo (actual.M24).IsSuccess ? "✅" : "❌";
		var d34 = Is.EqualTo (m34).Within (delta).ApplyTo (actual.M34).IsSuccess ? "✅" : "❌";
		var d44 = Is.EqualTo (m44).Within (delta).ApplyTo (actual.M44).IsSuccess ? "✅" : "❌";
		var diffRow1 = $"({d11}, {d12}, {d13}, {d14})";
		var diffRow2 = $"({d21}, {d22}, {d23}, {d24})";
		var diffRow3 = $"({d31}, {d32}, {d33}, {d34})";
		var diffRow4 = $"({d41}, {d42}, {d43}, {d44})";
		var diffString = $"{diffRow1}\n{diffRow2}\n{diffRow3}\n{diffRow4}";

		var msg = $"Expected:\n{expectedString}\nActual:\n{actualString}\nDiff:\n{diffString}";
		Console.WriteLine (msg);
		Assert.Fail (message + "\n" + msg);
	}

	public unsafe static void AreEqual (byte* expected, byte* actual, int length, string message)
	{
		// Check if the byte arrays are identical
		var equal = true;
		for (var i = 0; i < length; i++) {
			var e = expected [i];
			var a = actual [i];
			equal &= e == a;
		}
		if (equal)
			return;
		// They're not. Create the assertion message and assert.
		var e_sb = new StringBuilder ();
		var a_sb = new StringBuilder ();
		var d_sb = new StringBuilder ();
		for (var i = 0; i < length; i++) {
			var e = expected [i];
			var a = actual [i];
			e_sb.Append ($"0x{e:X2} ");
			a_sb.Append ($"0x{a:X2} ");
			if (e == a) {
				d_sb.Append ("     ");
			} else {
				d_sb.Append ("^^^^ ");
			}
		}
		Assert.Fail ($"{message}\nExpected: {e_sb}\nActual:   {a_sb}\n          {d_sb}");
	}
#endif // HAS_SCENEKIT
	}
