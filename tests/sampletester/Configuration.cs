using System;
using System.IO;

public static class Configuration
{
	public static string RootDirectory {
		get {
			// I'd like to clone the samples into a subdirectory that will be cleaned on the bots,
			// but using a subdirectory in xamarin-macios makes nuget-dependending projects pick
			// up xamarin-macios' Nuget.Config, which sets the repository path, and the nugets are
			// restored to location the projects don't expect.
			// So instead clone the sample repositories into /tmp
			//return Path.Combine (Path.GetDirectoryName (System.Reflection.Assembly.GetExecutingAssembly ().Location), "repositories");
			return Path.Combine ("/private/tmp/xamarin-macios-sample-builder/repositories");
		}
	}
}
