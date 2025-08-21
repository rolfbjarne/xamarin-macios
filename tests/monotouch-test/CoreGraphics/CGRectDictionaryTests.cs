// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

using Foundation;
using CoreGraphics;
using ObjCRuntime;

using NUnit.Framework;

namespace MonoTouchFixtures.CoreGraphics;

[TestFixture]
[Preserve (AllMembers = true)]
public class CGRectDictionaryTests {

	[Test]
	public void PropertiesTest ()
	{
		var rect = new CGRect (1, 2, 3, 4);
		using var dict = rect.ToDictionary ();
		var strongDict = new CGRectDictionary (dict);
		Assert.AreEqual (rect.X, strongDict.X, "X");
		Assert.AreEqual (rect.Y, strongDict.Y, "Y");
		Assert.AreEqual (rect.Height, strongDict.Height, "Height");
		Assert.AreEqual (rect.Width, strongDict.Width, "Width");

		var rect2 = strongDict.ToRect ();
		Assert.AreEqual (rect, rect2, "Rect");

		strongDict = new CGRectDictionary ();
		strongDict.X = 3;
		Assert.AreEqual (3, strongDict.X, "X 2");
		strongDict.Y = 4;
		Assert.AreEqual (4, strongDict.Y, "Y 2");
		strongDict.Width = 5;
		Assert.AreEqual (5, strongDict.Width, "Width 2");
		strongDict.Height = 6;
		Assert.AreEqual (6, strongDict.Height, "Height 2");
		rect2 = strongDict.ToRect ();
		Assert.AreEqual (new CGRect (3, 4, 5, 6), rect2, "Rect 2");
	}

	[Test]
	public void Default ()
	{
		var strongDict = new CGRectDictionary ();
		Assert.IsNull (strongDict.X, "X");
		Assert.IsNull (strongDict.Y, "Y");
		Assert.IsNull (strongDict.Width, "Width");
		Assert.IsNull (strongDict.Height, "Height");
		var rect = strongDict.ToRect ();
		Assert.AreEqual (default (CGRect), rect, "Rect");
	}

	[Test]
	public void ToStringTest1 ()
	{
		var strongDict = new CGRectDictionary ();
		Assert.AreEqual ("?", strongDict.ToString (), "A")
	}

	[Test]
	public void ToStringTest1 ()
	{
		var strongDict = new CGRectDictionary ();
		strongDict.X = 3;
		strongDict.Y = 4;
		Assert.AreEqual ("?", strongDict.ToString (), "B")
	}
}
