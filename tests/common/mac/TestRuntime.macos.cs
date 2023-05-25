using System;

using AppKit;
using Foundation;

#nullable enable

partial class TestRuntime {
	public static bool RunAsync (TimeSpan timeout, Action action, Func<bool> check_completed, NSImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), action, check_completed, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Action action, Func<bool> check_completed, NSImage imageToShow = null)
	{
		Exception? ex = null;
		NSTimer.CreateScheduledTimer (0.01, (v) => {
			try {
				action ();
			} catch (Exception e) {
				ex = e;
			}
		});
		do {
			if (timeout < DateTime.Now)
				return false;
			NSRunLoop.Main.RunUntil (NSDate.Now.AddSeconds (0.1));
		} while (ex is null && !check_completed ());

		if (ex is not null)
			throw new Exception ($"Async callback failed: {ex.Message}", ex);

		return true;
	}
}
