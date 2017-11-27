//
// Unit tests for CGColorSpace
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2012-2013, 2016 Xamarin Inc. All rights reserved.
//

using System;
using System.IO;
#if XAMCORE_2_0
using Foundation;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif
using CoreGraphics;
#else
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using NUnit.Framework;

#if XAMCORE_2_0
using RectangleF=CoreGraphics.CGRect;
using SizeF=CoreGraphics.CGSize;
using PointF=CoreGraphics.CGPoint;
#else
using nfloat=global::System.Single;
using nint=global::System.Int32;
using nuint=global::System.UInt32;
#endif

namespace MonoTouchFixtures.CoreGraphics {
	
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class ColorSpaceTest {
		
		void CheckUnknown (CGColorSpace cs)
		{
			Assert.That (cs.Components, Is.EqualTo ((nint) 0), "Unknown-0");
			Assert.That (cs.Handle, Is.EqualTo (IntPtr.Zero), "Unknown-Handle");
			Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.Unknown), "Unknown-Model");
			Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "Unknown-GetColorTable");
		}

#if !XAMCORE_3_0
		[Test]
		public void Null ()
		{
			CheckUnknown (CGColorSpace.Null);
		}
#endif
		
		[Test]
		public void CreateDeviceGray ()
		{
			using (var cs = CGColorSpace.CreateDeviceGray ()) {
				Assert.That (cs.Components, Is.EqualTo ((nint) 1), "1");
				Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.Monochrome), "Monochrome");
				Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
				// not indexed so no color table
				Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");

				if (TestRuntime.CheckXcodeVersion (5, 0))
					Assert.Null (cs.GetICCProfile (), "GetICCProfile");

				if (TestRuntime.CheckXcodeVersion (8, 0)) {
					// kCGColorSpaceDeviceGray is not a public constant, e.g. from CGColorSpaceNames.*
					Assert.That (cs.Name, Is.EqualTo ("kCGColorSpaceDeviceGray"), "Name");
					Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
					Assert.True (cs.SupportsOutput, "SupportsOutput");
					Assert.Null (cs.GetIccData (), "GetIccData");
				}
			}
		}

		[Test]
		public void CreateDeviceRGB ()
		{
			using (var cs = CGColorSpace.CreateDeviceRGB ()) {
				Assert.That (cs.Components, Is.EqualTo ((nint) 3), "3");
				Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.RGB), "RGB");
				Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
				// not indexed so no color table
				Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");

				if (TestRuntime.CheckXcodeVersion (5, 0))
					Assert.Null (cs.GetICCProfile (), "GetICCProfile");

				if (TestRuntime.CheckXcodeVersion (8, 0)) {
					// kCGColorSpaceDeviceRGB is not a public constant
					Assert.That (cs.Name, Is.EqualTo ("kCGColorSpaceDeviceRGB"), "Name");
					Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
					Assert.True (cs.SupportsOutput, "SupportsOutput");
					Assert.Null (cs.GetIccData (), "GetIccData");
				}
			}
		}

		[Test]
		public void CreateDeviceCMYK ()
		{
			using (var cs = CGColorSpace.CreateDeviceCmyk ()) {
				Assert.That (cs.Components, Is.EqualTo ((nint) 4), "4");
				Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.CMYK), "CMYK");
				Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
				// not indexed so no color table
				Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");

				if (TestRuntime.CheckXcodeVersion (5, 0))
					Assert.Null (cs.GetICCProfile (), "GetICCProfile");

				if (TestRuntime.CheckXcodeVersion (8, 0)) {
					// kCGColorSpaceDeviceCMYK is not a public constant
					Assert.That (cs.Name, Is.EqualTo ("kCGColorSpaceDeviceCMYK"), "Name");
					Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
					Assert.True (cs.SupportsOutput, "SupportsOutput");
					Assert.Null (cs.GetIccData (), "GetIccData");
				}
			}
		}

		[Test]
		public void CreateIndexed ()
		{
			// from: http://developer.apple.com/library/ios/#documentation/GraphicsImaging/Reference/CGColorSpace/Reference/reference.html
			//  m is the number of color components in the base color space
			nint m = 3; // RGB
			const int lastIndex = 2;
			// An array of m*(lastIndex+1) bytes
			byte[] table = new byte [3 * (lastIndex + 1)] { 1, 2, 3, 4, 5, 6, 255, 255, 255 };
			using (var base_cs = CGColorSpace.CreateDeviceRGB ())
			using (var cs = CGColorSpace.CreateIndexed (base_cs, lastIndex, table)) {
				Assert.That (cs.Components, Is.EqualTo ((nint) 1), "1");
				Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.Indexed), "Indexed");
				var bcs = cs.GetBaseColorSpace ();
				Assert.That (bcs.Components, Is.EqualTo (m), "Components");
				Assert.That (base_cs.Model, Is.EqualTo (bcs.Model), "GetBaseColorSpace");
				var new_table = cs.GetColorTable ();
				Assert.That (table, Is.EqualTo (new_table), "GetColorTable");

				if (TestRuntime.CheckXcodeVersion (5, 0))
					Assert.Null (cs.GetICCProfile (), "GetICCProfile");

				if (TestRuntime.CheckXcodeVersion (8, 0)) {
					Assert.Null (cs.Name, "Name");
					Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
					Assert.False (cs.SupportsOutput, "SupportsOutput");
					Assert.Null (cs.GetIccData (), "GetIccData");
				}
			}
		}

		[Test]
		public void CreateExtendedSrgb ()
		{
			if (!TestRuntime.CheckXcodeVersion (8, 0))
				Assert.Ignore ("Requires iOS 10+");
			
			using (var cs = CGColorSpace.CreateWithName (CGColorSpaceNames.ExtendedSrgb)) {
				Assert.That (cs.Components, Is.EqualTo ((nint)3), "3");
				Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.RGB), "RGB");
				Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
				// not indexed so no color table
				Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");

				using (var icc_profile = cs.GetICCProfile ())
					Assert.That (icc_profile.Length, Is.EqualTo (3144), "GetICCProfile");

				Assert.That (cs.Name, Is.EqualTo (CGColorSpaceNames.ExtendedSrgb.ToString ()), "Name");
				Assert.True (cs.IsWideGamutRgb, "IsWideGamutRgb");
				Assert.True (cs.SupportsOutput, "SupportsOutput");

				using (var icc_data = cs.GetIccData ())
					Assert.That (icc_data.Length, Is.EqualTo (3144), "GetIccData");
			}
		}

		[Test]
		public void Disposed ()
		{
			if (!TestRuntime.CheckXcodeVersion (8, 0))
				Assert.Ignore ("Requires iOS 10+");
			
			var cs = CGColorSpace.CreateWithName (CGColorSpaceNames.ExtendedSrgb);
			cs.Dispose ();

			Assert.That (cs.Components, Is.EqualTo ((nint)0), "0");
			Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.Unknown), "Unknown");
			Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
			Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");
			Assert.Null (cs.GetICCProfile (), "GetICCProfile");
			Assert.Null (cs.Name, "Name");
			Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
			Assert.False (cs.SupportsOutput, "SupportsOutput");
			Assert.Null (cs.GetIccData (), "GetIccData");
			// IOW all safe to call with a `nil` handle
		}

		[Test]
		public void CreateICCProfile ()
		{
			// of all the .icc profiles I have on my Mac then only one I found working is
			// for my old 15" sharp (secondary) display. Added it to the test suite
			// that should work on the iOS simulator - at least some as I'm not sure every Mac
			// has the file(s) so we're not trying (and fialing) to copy it into the bundle
			using (var icc = NSData.FromFile (Path.Combine (NSBundle.MainBundle.ResourcePath, "LL-171A-B-B797E457-16AB-C708-1E0F-32C19DBD47B5.icc")))
			using (var cs = CGColorSpace.CreateICCProfile (icc)) {
				TestICC (cs);
			}

			using (var space = CGColorSpace.CreateICCProfile ((NSData) null)) {
				Assert.IsNull (space, "null data");
			}
		}

		void TestICC (CGColorSpace cs)
		{
			Assert.That (cs.Components, Is.EqualTo ((nint) 3), "Components");
			Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.RGB), "Model");
			Assert.Null (cs.GetBaseColorSpace (), "GetBaseColorSpace");
			// not indexed so no color table
			Assert.That (cs.GetColorTable ().Length, Is.EqualTo (0), "GetColorTable");

			if (TestRuntime.CheckXcodeVersion (5, 0)) {
				using (var icc_profile = cs.GetICCProfile ())
					Assert.That (icc_profile.Length, Is.EqualTo (3284), "GetICCProfile");
			}

			if (TestRuntime.CheckXcodeVersion (8, 0)) {
				Assert.Null (cs.Name, "Name");
				Assert.False (cs.IsWideGamutRgb, "IsWideGamutRgb");
				Assert.True (cs.SupportsOutput, "SupportsOutput");
				using (var icc_data = cs.GetIccData ())
					Assert.That (icc_data.Length, Is.EqualTo (3284), "GetIccData");
			}
		}

		[Test]
		public void CreateIccData ()
		{
			TestRuntime.AssertXcodeVersion (8, 0);

			using (var icc = NSData.FromFile (Path.Combine (NSBundle.MainBundle.ResourcePath, "LL-171A-B-B797E457-16AB-C708-1E0F-32C19DBD47B5.icc"))) {
				using (var cs = CGColorSpace.CreateIccData (icc)) {
					TestICC (cs);
				}
				using (var provider = new CGDataProvider (icc)) {
					using (var cs = CGColorSpace.CreateIccData (provider)) {
						TestICC (cs);
					}
				}
			}

			using (var space = CGColorSpace.CreateIccData ((NSData) null)) {
				Assert.IsNull (space, "null data");
			}

			using (var space = CGColorSpace.CreateIccData ((CGDataProvider) null)) {
				Assert.IsNull (space, "null data provider");
			}
		}

		void CheckIndexedFile (CGImage img)
		{
			CGColorSpace cs = img.ColorSpace;
			Assert.That (cs.Components, Is.EqualTo ((nint)1), "Components");
			Assert.That (cs.Model, Is.EqualTo (CGColorSpaceModel.Indexed), "GetBaseColorSpace");
			var table = cs.GetColorTable ();
			Assert.That (table.Length, Is.EqualTo (768), "GetColorTable");
			cs.Dispose ();
		}

		[Test]
		public void Indexed_UIImage ()
		{
			// downloaded from http://www.schaik.com/pngsuite/#palette
			string file = Path.Combine (NSBundle.MainBundle.ResourcePath, "basn3p08.png");
#if MONOMAC
			using (var img = new NSImage (file)) {
#else
			using (var img = UIImage.FromFile (file)) {
#endif
				using (var cgimg = img.CGImage)
					CheckIndexedFile (cgimg);
			}
		}

		[Test]
		public void Indexed_Provider ()
		{
			string file = Path.Combine (NSBundle.MainBundle.ResourcePath, "basn3p08.png");
			using (var dp = new CGDataProvider (file)) {
				using (var img = CGImage.FromPNG (dp, null, false, CGColorRenderingIntent.Default)) {
					CheckIndexedFile (img);
				}
			}
		}

		[Test]
		public void CalibratedGray ()
		{
			var whitepoint = new nfloat [] { 1, 2, 3 };
			var blackpoint = new nfloat [] { 3, 2, 1 };
			var gamma = (nfloat) 1;

			Assert.Throws<ArgumentNullException> (() => CGColorSpace.CreateCalibratedGray (null, blackpoint, gamma), "null whitepoint");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedGray (new nfloat [0], blackpoint, gamma), "invalid whitepoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedGray (new nfloat [4], blackpoint, gamma), "invalid whitepoint4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedGray (whitepoint, new nfloat [0], gamma), "invalid blackpoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedGray (whitepoint, new nfloat [4], gamma), "invalid blackpoint4");

			using (var space = CGColorSpace.CreateCalibratedGray (whitepoint, blackpoint, gamma)) {
				Assert.IsNotNull (space, "all non-null");
			}

			using (var space = CGColorSpace.CreateCalibratedGray (whitepoint, null, gamma)) {
				Assert.IsNotNull (space, "null blackpoint");
			}
		}

		[Test]
		public void CalibratedRGB ()
		{
			var whitepoint = new nfloat [] { 1, 2, 3 };
			var blackpoint = new nfloat [] { 3, 2, 1 };
			var gamma = new nfloat [] { 1, 2, 3 };
			var matrix = new nfloat [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			Assert.Throws<ArgumentNullException> (() => CGColorSpace.CreateCalibratedRGB (null, blackpoint, gamma, matrix), "null whitepoint");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (new nfloat [0], blackpoint, gamma, matrix), "invalid whitepoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (new nfloat [4], blackpoint, gamma, matrix), "invalid whitepoint4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, new nfloat [0], gamma, matrix), "invalid blackpoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, new nfloat [4], gamma, matrix), "invalid blackpoint4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, new nfloat [0], matrix), "invalid gamma0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, new nfloat [4], matrix), "invalid gamma4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, gamma, new nfloat [0]), "invalid matrix0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, gamma, new nfloat [4]), "invalid matrix4");

			using (var space = CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, gamma, matrix)) {
				Assert.IsNotNull (space, "all non-null");
			}

			using (var space = CGColorSpace.CreateCalibratedRGB (whitepoint, null, gamma, matrix)) {
				Assert.IsNotNull (space, "null blackpoint");
			}

			using (var space = CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, null, matrix)) { 
				Assert.IsNotNull (space, "null gamma");
			}

			using (var space = CGColorSpace.CreateCalibratedRGB (whitepoint, blackpoint, gamma, null)) {
				Assert.IsNotNull (space, "all matrix-null");
			}

			using (var space = CGColorSpace.CreateCalibratedRGB (whitepoint, null, null, null)) {
				Assert.IsNotNull (space, "all null");
			}
		}

		[Test]
		public void Lab ()
		{
			var whitepoint = new nfloat [] { 1, 2, 3 };
			var blackpoint = new nfloat [] { 3, 2, 1 };
			var range = new nfloat [] { 1, 2, 3, 4 };
			Assert.Throws<ArgumentNullException> (() => CGColorSpace.CreateLab (null, blackpoint, range), "null whitepoint");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (new nfloat [0], blackpoint, range), "invalid whitepoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (new nfloat [4], blackpoint, range), "invalid whitepoint4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (whitepoint, new nfloat [0], range), "invalid blackpoint0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (whitepoint, new nfloat [4], range), "invalid blackpoint4");

			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (whitepoint, blackpoint, new nfloat [0]), "invalid range0");
			Assert.Throws<ArgumentException> (() => CGColorSpace.CreateLab (whitepoint, blackpoint, new nfloat [3]), "invalid range3");

			using (var space = CGColorSpace.CreateLab (whitepoint, blackpoint, range)) {
				Assert.IsNotNull (space, "all non-null");
			}

			using (var space = CGColorSpace.CreateLab (whitepoint, null, range)) {
				Assert.IsNotNull (space, "null blackpoint");
			}

			using (var space = CGColorSpace.CreateLab (whitepoint, blackpoint, null)) {
				Assert.IsNotNull (space, "null gamma");
			}

			using (var space = CGColorSpace.CreateLab (whitepoint, null, null)) {
				Assert.IsNotNull (space, "all null");
			}
		}
	}
}
