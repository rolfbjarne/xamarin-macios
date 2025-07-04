using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using Foundation;
using Metal;

using NUnit.Framework;

namespace MonoTouchFixtures.Metal {
	[Preserve (AllMembers = true)]
	public class MTL4RenderPassDescriptorTest {

		[SetUp]
		public void SamplePositions ()
		{
			TestRuntime.AssertXcodeVersion (26, 0);

			using (var obj = new MTL4RenderPassDescriptor ()) {
				Assert.That (obj.SamplePositions, Is.Null, "#0");

				obj.SamplePositions = new MTLSamplePosition [] {
					new MTLSamplePosition () { X = 1, Y = 2 },
				};
				Assert.That (obj.SamplePositions, Is.Not.Null, "#1a");
				Assert.That (obj.SamplePositions.Length, Is.EqualTo (1), "#1b");
				Assert.That (obj.SamplePositions [0].X, Is.EqualTo (1), "#1x");
				Assert.That (obj.SamplePositions [0].Y, Is.EqualTo (2), "#1y");

				obj.SamplePositions = null;
				Assert.That (obj.SamplePositions, Is.Null, "#2");

				obj.SamplePositions = new MTLSamplePosition [0];
				Assert.That (obj.SamplePositions, Is.Null, "#3");

				obj.SamplePositions = new MTLSamplePosition [] {
					new MTLSamplePosition () { X = 3, Y = 4 },
					new MTLSamplePosition () { X = 1, Y = 2 },
				};
				Assert.That (obj.SamplePositions, Is.Not.Null, "#4a");
				Assert.That (obj.SamplePositions.Length, Is.EqualTo (2), "#4b");
				Assert.That (obj.SamplePositions [0].X, Is.EqualTo (3), "#4x0");
				Assert.That (obj.SamplePositions [0].Y, Is.EqualTo (4), "#4y0");
				Assert.That (obj.SamplePositions [1].X, Is.EqualTo (1), "#4x1");
				Assert.That (obj.SamplePositions [1].Y, Is.EqualTo (2), "#4y1");
			}
		}
	}
}
