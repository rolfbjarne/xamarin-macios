﻿using System;
using System.IO;

using Microsoft.Build.Utilities;

using NUnit.Framework;

namespace Xamarin.iOS.Tasks
{
	class CustomBTouchTask : BTouch
	{
		public string GetCommandLineCommands ()
		{
			return base.GenerateCommandLineCommands ();
		}
	}

	[TestFixture]
	public class BTouchTaskTests : TestBase
	{
		[Test]
		public void StandardCommandline ()
		{
			var task = CreateTask<CustomBTouchTask> ();

			task.ApiDefinitions = new[] { new TaskItem ("apidefinition.cs") };
			task.References = new[] { new TaskItem ("a.dll"), new TaskItem ("b.dll"), new TaskItem ("c.dll") };

			var args = task.GetCommandLineCommands ();
			Assert.IsTrue (args.Contains ("-r " + Path.Combine (Environment.CurrentDirectory, "a.dll")), "#1a");
			Assert.IsTrue (args.Contains ("-r " + Path.Combine (Environment.CurrentDirectory, "b.dll")), "#1b");
			Assert.IsTrue (args.Contains ("-r " + Path.Combine (Environment.CurrentDirectory, "c.dll")), "#1c");
		}

		[Test]
		public void Bug656983 ()
		{
			var task = CreateTask<CustomBTouchTask> ();

			task.ApiDefinitions = new[] { new TaskItem ("apidefinition.cs") };
			task.References = new[] { new TaskItem ("a.dll"), new TaskItem ("b.dll"), new TaskItem ("c.dll") };
			task.ProjectDir = "~/"; // not important, but required (so can't be null)

			task.OutputAssembly = null; // default, but important for the bug (in case that default changes)
			task.ExtraArgs = "-invalid";
			var args = task.GetCommandLineCommands ();
			Assert.That (args.Contains (" -invalid"), "incorrect ExtraArg not causing an exception");
		}
	}
}

