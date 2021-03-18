using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

using AppKit;

namespace CoreCLRPerfTest {
	static class MainClass {
		static int Main (string [] args)
		{
            try {
                // The call to NSApplication.Init is required
                NSApplication.Init ();

                ObjCBridge.Run ();

                var summaries = new List<Summary> ();

                // summaries.Add (BenchmarkRunner.Run<Sleeper> ());

                summaries.AddRange (BenchmarkRunner.Run (typeof (MainClass).Assembly));

                //var summaries = BenchmarkSwitcher.FromAssembly (typeof (MainClass).Assembly).Run (args);
                //var config = DefaultConfig.Instance.AddJob (Job.Default.WithToolchain (InProcessEmitToolchain.Instance));
                //var summary = BenchmarkSwitcher.FromAssembly (typeof (MainClass).Assembly).Run (args, config);


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
                .WithId ("InProcess"));

            WithOption (ConfigOptions.DisableOptimizationsValidator, true);

            Add (JitOptimizationsValidator.DontFailOnError); // ALLOW NON-OPTIMIZED DLLS

            Add (DefaultConfig.Instance.GetLoggers ().ToArray ()); // manual config has no loggers by default
            Add (DefaultConfig.Instance.GetExporters ().ToArray ()); // manual config has no exporters by default
            Add (DefaultConfig.Instance.GetColumnProviders ().ToArray ()); // manual config has no columns by default

            Console.WriteLine ("Configured");
        }
    }

    [Config (typeof (Config))]
    public class Sleeper {

        public Sleeper()
        {
            Console.WriteLine ("Md5VsSha256");
        }

        [Benchmark]
        public void Sleep ()
        {
            Console.WriteLine ("Sleep");
            System.Threading.Thread.Sleep (1);
        }
    }

    // TODO: Figure out how to make it work with BenchmarkDotNet

}
