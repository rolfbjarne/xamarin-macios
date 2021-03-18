using System;
using System.Diagnostics;
using System.Linq;

using Foundation;

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
	public class ObjCBridge {
		[Benchmark]
		public void NSObjectCreated ()
		{
			new NSObject ();
		}

		[Benchmark]
		public void NSObjectCreatedAndDisposed ()
		{
			using (var obj = new NSObject ()) { }
		}

		[Benchmark]
		public void CustomSubClassCreated ()
		{
			new CustomSubClass ();
		}

		[Benchmark]
		public void CustomSubClassCreatedAndDisposed ()
		{
			using (var obj = new CustomSubClass ()) { }
		}

		class CustomSubClass : NSObject {

		}

	}

	public class InvokeOnNSObject {
		NSObject obj = new NSObject ();

		[Benchmark]
		public void CallClass ()
		{
			var c = obj.Class;
		}
	}

	public class InvokeOnCustomClass {
		[Benchmark]
		public void CallInstanceMethodInNativeCode ()
		{

		}

		[Benchmark]
		public void CallStaticMethodInNativeCode ()
		{

		}

		[Benchmark]
		public void CallOverriddenInstanceMethod ()
		{

		}

		[Benchmark]
		public void CallExportedInstanceMethod ()
		{

		}

		[Benchmark]
		public void CallExportedStaticMethod ()
		{

		}
	}

	public class Marshalling {
		[Benchmark]
		public void CallReturnString_EmptyString ()
		{

		}

		[Benchmark]
		public void CallReturnString_ShortString ()
		{

		}

		[Benchmark]
		public void CallReturnString_LongString ()
		{

		}

		[Benchmark]
		public void CallReturnKnownManagedWrapper ()
		{

		}

		[Benchmark]
		public void CallReturnUnknownManagedWrapper ()
		{

		}
	}

	public class VM {
		[Benchmark]
		public void CreateObject ()
		{
			new object ();
		}
	}
}
