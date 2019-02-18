﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xharness
{
	public static class Extensions
	{
		public static string AsString (this AppRunnerTarget @this)
		{
			switch (@this) {
			case AppRunnerTarget.None:
				return null;
			case AppRunnerTarget.Device_iOS:
				return "ios-device";
			case AppRunnerTarget.Device_tvOS:
				return "tvos-device";
			case AppRunnerTarget.Device_watchOS:
				return "watchos-device";
			case AppRunnerTarget.Simulator_iOS:
				return "ios-simulator";
			case AppRunnerTarget.Simulator_iOS32:
				return "ios-simulator-32";
			case AppRunnerTarget.Simulator_iOS64:
				return "ios-simulator-64";
			case AppRunnerTarget.Simulator_tvOS:
				return "tvos-simulator";
			case AppRunnerTarget.Simulator_watchOS:
				return "watchos-simulator";
			default:
				throw new NotImplementedException ();
			}
		}

		public static AppRunnerTarget ParseAsAppRunnerTarget (this string @this)
		{
			switch (@this) {
			case "ios-device":
				return AppRunnerTarget.Device_iOS;
			case "tvos-device":
				return AppRunnerTarget.Device_tvOS;
			case "watchos-device":
				return AppRunnerTarget.Device_watchOS;
			case "ios-simulator":
				return AppRunnerTarget.Simulator_iOS;
			case "ios-simulator-32":
				return AppRunnerTarget.Simulator_iOS32;
			case "ios-simulator-64":
				return AppRunnerTarget.Simulator_iOS64;
			case "tvos-simulator":
				return AppRunnerTarget.Simulator_tvOS;
			case "watchos-simulator":
				return AppRunnerTarget.Simulator_watchOS;
			case null:
			case "":
				return AppRunnerTarget.None;
			default:
				throw new NotImplementedException (@this);
			}
		}

		public static Extension ParseFromNSExtensionPointIdentifier (this string @this)
		{
			switch (@this) {
			case "com.apple.widget-extension":
				return Extension.TodayExtension;
			case "com.apple.watchkit":
				return Extension.WatchKit2;
			default:
				throw new NotImplementedException ();
			}
		}

		public static string AsNSExtensionPointIdentifier (this Extension @this)
		{
			switch (@this) {
			case Extension.TodayExtension:
				return "com.apple.widget-extension";
			case Extension.WatchKit2:
				return "com.apple.watchkit";
			default:
				throw new NotImplementedException ();
			}
		}

		// Returns false if timed out
		public static async Task<bool> TimeoutAfter (this Task task, TimeSpan timeout)
		{
			if (timeout.Ticks < -1)
				return false;

			if (task == await Task.WhenAny (task, Task.Delay (timeout)))
				return true;
			else
				return false;
		}

		public static void DoNotAwait (this Task task)
		{
			// Don't do anything!
			// 
			// Here's why:
			// If you want to run a task in the background, and you don't care about the result, this is the obvious way to do so:
			//
			//     DoSomethingAsync ();
			//
			// which works fine, but the compiler warns that:
			// 
			//     Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.
			//
			// One potential fix is to assign the return value to variable:
			//
			//     var x = DoSomethingAsync ();
			//
			// But this creates unnecessary variables. It's also still slightly confusing (why assign to a variable that's not used?).
			// This extension method allows us to be more explicit:
			// 
			//     DoSomethingAsync ().DoNotAwait ();
			// 
			// This makes it abundantly clear that the intention is to not await 'DoSomething', and no warnings will be shown either.
		}
	
		public static IEnumerable<T> Shuffle<T> (this IEnumerable<T> collection)
		{
			var rnd = new Random ((int) DateTime.Now.Ticks);
			return collection.OrderBy (v => rnd.Next ());
		}
	}
}
