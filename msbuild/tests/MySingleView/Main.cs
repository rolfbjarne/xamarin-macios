using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using MyLibrary;

namespace MySingleView
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			System.Console.WriteLine ("Hello world from Main! {0} args: {1}", args.Length, string.Join (" ", args));
			new TestFoo ();
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, typeof (AppDelegate));
			System.Console.WriteLine ("Bye, bye world from Main!");
		}
	}
}
