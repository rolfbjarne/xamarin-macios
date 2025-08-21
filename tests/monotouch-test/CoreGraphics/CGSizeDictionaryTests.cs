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
public class CGSizeDictionaryTests {

	[Test]
	public void PropertiesTest ()
	{
		var size = new CGSize ((nfloat) 1, (nfloat) 2);
		using var dict = size.ToDictionary ();
		var strongDict = new CGSizeDictionary (dict);
		Assert.AreEqual (size.Width, strongDict.Width, "Width");
		Assert.AreEqual (size.Height, strongDict.Height, "Height");

		var size2 = strongDict.ToSize ();
		Assert.AreEqual (size, size2, "Size");

		strongDict = new CGSizeDictionary ();
		strongDict.Width = 3;
		Assert.AreEqual (3, strongDict.Width, "Width 2");
		strongDict.Height = 4;
		Assert.AreEqual (4, strongDict.Height, "Height 2");
		size2 = strongDict.ToSize ();
		Assert.AreEqual (new CGSize (3, 4), size2, "Size 2");
	}

	[Test]
	public void Default ()
	{
		var strongDict = new CGSizeDictionary ();
		Assert.IsNull (strongDict.Width, "Width");
		Assert.IsNull (strongDict.Height, "Height");
		var size = strongDict.ToSize ();
		Assert.AreEqual (default (CGSize), size, "Size");
	}

	[Test]
	public void ToStringTest1 ()
	{
		var strongDict = new CGSizeDictionary ();
		Assert.AreEqual ("?", strongDict.ToString (), "A")
	}

	[Test]
	public void ToStringTest1 ()
	{
		var strongDict = new CGSizeDictionary ();
		strongDict.Width = 3;
		strongDict.Height = 4;
		Assert.AreEqual ("?", strongDict.ToString (), "B")
	}
}
