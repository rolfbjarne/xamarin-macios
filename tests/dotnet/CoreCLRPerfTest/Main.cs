using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using AppKit;

using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Validators;

namespace CoreCLRPerfTest {
	static class MainClass {
		static int Main (string [] args)
		{
            try {
                // The call to NSApplication.Init is required
                NSApplication.Init ();

                var summaries = new List<Summary> ();

                summaries.AddRange (BenchmarkRunner.Run (typeof (MainClass).Assembly, new Config ()));

                PrintSummary (summaries.ToArray ());
            } catch (Exception e) {
                Console.WriteLine ("Unhandled exception: {0}", e);
                return 1;
			}

            return 0;
		}

        static void PrintSummary (params Summary[] summaries)
		{
            if (summaries == null)
                return;

            Console.WriteLine ($"Got {summaries.Length} summaries:");
            foreach (var s in summaries) {
                if (s == null) {
                    Console.WriteLine ("Null summary!");
                    continue;
                }
                Console.WriteLine (s);
                Console.WriteLine ($"Title: {s.Title}");
                Console.WriteLine ($"TotalTime: {s.TotalTime}");

            }
		}
	}

    public class Config : ManualConfig {
        public Config ()
        {
            AddJob (Job.MediumRun
                .WithLaunchCount (1)
                .WithToolchain (InProcessEmitToolchain.Instance)
                .WithIterationCount (5) // speed up a bit while writing the tests
                .WithWarmupCount (5) // speed up a bit while writing the tests
                .WithId ("InProcess")
            );

            WithOption (ConfigOptions.DisableOptimizationsValidator, true);

            Add (JitOptimizationsValidator.DontFailOnError); // ALLOW NON-OPTIMIZED DLLS

            Add (DefaultConfig.Instance.GetLoggers ().ToArray ()); // manual config has no loggers by default
            Add (DefaultConfig.Instance.GetExporters ().ToArray ()); // manual config has no exporters by default
            Add (DefaultConfig.Instance.GetColumnProviders ().ToArray ()); // manual config has no columns by default
        }
    }

    public class Sleeper {
        [Benchmark]
        public void Sleep ()
        {
            System.Threading.Thread.Sleep (1);
        }
    }
}
