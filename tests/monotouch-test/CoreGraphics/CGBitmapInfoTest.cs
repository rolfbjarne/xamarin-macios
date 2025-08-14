// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MonoTouchFixtures.CoreGraphics {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class CGBitmapInfoTest {
		[Test]
		public void Extensions ()
		{
			Assert.AreEqual (CGImageAlphaInfo.PremultipliedLast, ((CGBitmapInfo) CGImageAlphaInfo.PremultipliedLast).GetAlphaInfo (), "GetAlphaInfo");
			Assert.AreEqual (CGImageComponentInfo.Float, ((CGBitmapInfo) CGImageComponentInfo.PremultipliedLast).GetComponentInfo (), "CGImageComponentInfo");
			Assert.AreEqual (CGImageByteOrderInfo.ByteOrder32Little, ((CGBitmapInfo) CGImageByteOrderInfo.PremultipliedLast).GetByteOrderInfo (), "CGImageByteOrderInfo");
			Assert.AreEqual (CGImagePixelFormatInfo.Rgb101010, ((CGBitmapInfo) CGImagePixelFormatInfo.PremultipliedLast).GetPixelFormatInfo (), "CGImagePixelFormatInfo");
		}
	}
}
