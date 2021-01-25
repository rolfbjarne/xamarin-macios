using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Foundation;
using UIKit;

namespace MySingleView
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{

			var t = new Thread (() =>
			{
				var counter = 0;
				while (true) {
					for (var i = 0; i < 10000; i++) {
						// This leaks:
						var obj1 = new WithDestructor ();
						// This does not:
						// var obj2 = new WithoutDestructor ();
						counter++;
					}
					Console.WriteLine ($"Counter: {counter}");
					GC.Collect ();
					Thread.Sleep (10);
				}
			});
			t.Start ();


			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}


	public class WithDestructor
	{
		~WithDestructor ()
		{
			Console.WriteLine ("~WithDestructor");
		}
	}

	public class WithoutDestructor {}

}
