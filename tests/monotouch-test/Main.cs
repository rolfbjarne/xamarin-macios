#if !MONOMAC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Foundation;
using UIKit;
using ObjCRuntime;
using System.Runtime.InteropServices;

#nullable enable

namespace Foundation {
	public static class NSRunLoop_Extensions {
		// Returns true if task completed before the timeout,
		// otherwise returns false
		public static bool RunUntil (this NSRunLoop self, Task task, DateTime timeout)
		{
			while (true) {
				if (task.IsCompleted)
					return true;
				if (timeout <= DateTime.Now)
					return false;
				self.RunUntil (NSDate.Now.AddSeconds (0.1));
			}
		}
	}
}

partial class TestRuntime {
	public static bool RunAsync (TimeSpan timeout, Task task, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), task, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Task task, UIImage imageToShow = null)
	{
		return RunAsync (timeout, task, Task.CompletedTask, imageToShow);
	}

	public static bool RunAsync (TimeSpan timeout, Task startTask, Task completionTask, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), startTask, completionTask, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Task startTask, Task completionTask, UIImage imageToShow = null)
	{
#if !__WATCHOS__
		using var ui = AppDelegate.ShowAsyncUI (imageToShow);
#endif

		var runLoop = NSRunLoop.Main;
		if (!runLoop.RunUntil (startTask, timeout))
			return false;
		startTask.GetAwaiter ().GetResult (); // Trigger any captured exceptions.

		if (!runLoop.RunUntil (completionTask, timeout))
			return false;
		completionTask.GetAwaiter ().GetResult (); // Trigger any captured exceptions.

		return true;
	}

	public static bool RunAsync (TimeSpan timeout, Task startTask, Func<bool> check_completed, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), startTask, check_completed, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Task startTask, Func<bool> check_completed, UIImage imageToShow = null)
	{
		var completionTaskSource = new TaskCompletionSource<bool> ();

		var checkCompletionTimer = NSTimer.CreateRepeatingScheduledTimer (0.1, (NSTimer timer) => {
			if (check_completed ()) {
				completionTaskSource.SetResult (true);
				timer.Invalidate ();
			}
		});

		try {
			return RunAsync (timeout, startTask, completionTaskSource.Task, imageToShow);
		} finally {
			checkCompletionTimer.Invalidate ();
		}
	}

	public static bool RunAsync (TimeSpan timeout, Func<Task> startTask, Func<bool> check_completed, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), startTask, check_completed, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Func<Task> startTask, Func<bool> check_completed, UIImage imageToShow = null)
	{
		return RunAsync (timeout, startTask (), check_completed, imageToShow);
	}

	public static bool RunAsync (TimeSpan timeout, Func<Task> startTask, Task completionTask, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), startTask, completionTask, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Func<Task> startTask, Task completionTask, UIImage imageToShow = null)
	{
		return RunAsync (timeout, startTask (), completionTask, imageToShow);
	}

	public static bool RunAsync (TimeSpan timeout, Action action, Func<bool> check_completed, UIImage imageToShow = null)
	{
		return RunAsync (DateTime.Now.Add (timeout), action, check_completed, imageToShow);
	}

	public static bool RunAsync (DateTime timeout, Action action, Func<bool> check_completed, UIImage imageToShow = null)
	{
		var startTask = new Task (action);
		return RunAsync (timeout, startTask, check_completed, imageToShow);
	}
}

// This prevents the need for putting lots of #ifdefs inside the list of usings.
#if __WATCHOS__
namespace System.Drawing {}
namespace OpenTK {}
#endif
#endif
