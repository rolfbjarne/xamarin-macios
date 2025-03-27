using System;

using Foundation;
using GameController;

using NUnit.Framework;

namespace MonoTouchFixtures.GameController {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class GCInputTest {
		[Test]
		public void ButtonNames ()
		{
			Assert.Multiple (() => {
				AssertButtonName (GCInput.GetBackLeftButton (0), GCInputButtonName.ButtonA, "BackLeftButton");
				AssertButtonName (GCInput.GetBackLeftButtonName (0), "ButtonA", "BackLeftButtonName");

				AssertButtonName (GCInput.GetBackRightButton (0), GCInputButtonName.ButtonA, "BackRightButton");
				AssertButtonName (GCInput.GetBackRightButtonName (0), "ButtonA", "BackRightButtonName");

				AssertButtonName (GCInput.GetArcadeButton (0), GCInputButtonName.ButtonA, "ArcadeButton");
				AssertButtonName (GCInput.GetArcadeButtonName (0), "ButtonA", "ArcadeButtonName");
			});
		}

		void AssertButtonName (GCInputButtonName? name, GCInputButtonName expected, string message)
		{
			Assert.That (name, Is.Not.Null, $"{message}: null");
			Assert.AreEqual (name.Value, expected, $"{message}: value");
		}

		void AssertButtonName (NSString? name, string expected, string message)
		{
			Assert.That (name, Is.Not.Null, $"{message}: null");
			Assert.AreEqual (name.ToString (), expected, $"{message}: value");
		}
	}
}
