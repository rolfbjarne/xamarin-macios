﻿using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

using NUnit.Framework;

using Xamarin.MacDev;
using Xamarin.MacDev.Tasks;

namespace Xamarin.iOS.Tasks
{
	[TestFixture]
	public class UtilityTests
	{
		[Test]
		public void TestAbsoluteToRelativePath ()
		{
			string rpath;

			rpath = PathUtils.AbsoluteToRelative ("/Users/user/source/Project", "/Users/user/Source/Project/Info.plist");
			Assert.AreEqual ("Info.plist", rpath, "#1");
		}
	}
}
