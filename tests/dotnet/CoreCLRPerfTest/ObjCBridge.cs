using System;
using System.Diagnostics;
using System.Linq;

using Foundation;
using ObjCRuntime;

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

using Bindings.Test;

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
		ObjCRegistrarTest obj = new ObjCRegistrarTest ();
		Subclassed subclassed = new Subclassed ();
		IntPtr subclassed_class = Class.GetHandle (typeof (Subclassed));

		[Benchmark]
		public void CallInstanceMethodInNativeCode ()
		{
			obj.V ();
		}

		[Benchmark]
		public void CallStaticMethodInNativeCode ()
		{
			ObjCRegistrarTest.StaticV ();
		}

		[Benchmark]
		public void CallOverriddenInstanceMethod ()
		{

			MessageSend.void_objc_msgSend (subclassed.Handle, Selector.GetHandle ("v"));
		}

		[Benchmark]
		public void CallExportedInstanceMethod ()
		{
			MessageSend.void_objc_msgSend (subclassed.Handle, Selector.GetHandle ("exportedInstanceMethod"));

		}

		[Benchmark]
		public void CallExportedStaticMethod ()
		{
			MessageSend.void_objc_msgSend (subclassed_class, Selector.GetHandle ("exportedInstanceMethod"));
		}

		class Subclassed : ObjCRegistrarTest {
			public override void V ()
			{
			}

			[Export ("exportedInstanceMethod")]
			public void ExportedInstanceMethod ()
			{
			}

			[Export ("exportedStaticMethod")]
			public static void ExportedStaticMethod ()
			{
			}
		}
	}

	public class ArgumentMarshalling {
		ObjCRegistrarTest obj = new ObjCRegistrarTest ();
		IntPtr nsobject_class = Class.GetHandle (typeof (NSObject));

		[Benchmark]
		public void CallReturnString_EmptyString ()
		{
			obj.GetEmptyString ();
		}

		[Benchmark]
		public void CallReturnString_ShortString ()
		{
			obj.GetShortString ();
		}

		[Benchmark]
		public void CallReturnString_LongString ()
		{
			obj.GetLongString ();
		}

		// CallReturnKnownManagedWrapper

		NSObject someObjectKnownManagedWrapper;
		[IterationSetup (Target = nameof (CallReturnKnownManagedWrapper))]
		public void CallReturnKnownManagedWrapperSetup ()
		{
			// Create a new object that the bridge knows about
			someObjectKnownManagedWrapper = new NSObject ();
			MessageSend.void_objc_msgSend_IntPtr (obj.Handle, Selector.GetHandle ("setSomeObject:"), someObjectKnownManagedWrapper.Handle);
		}
		[Benchmark]
		public void CallReturnKnownManagedWrapper ()
		{
			// Now get that value again.
			var rv = obj.SomeObject;
		}
		[IterationCleanup (Target = nameof (CallReturnKnownManagedWrapper))]
		public void CallReturnKnownManagedWrapperCleanup ()
		{
			// cleanup after us
			someObjectKnownManagedWrapper.Dispose ();
			someObjectKnownManagedWrapper = null;
		}

		// CallReturnUnknownManagedWrapper

		IntPtr someObjectUnknownManagedWrapper;
		[IterationSetup (Target = nameof (CallReturnUnknownManagedWrapper))]
		public void CallReturnUnknownManagedWrapperSetup ()
		{
			// Create a new object that the bridge knows about
			someObjectUnknownManagedWrapper = MessageSend.IntPtr_objc_msgSend (MessageSend.IntPtr_objc_msgSend (nsobject_class, Selector.GetHandle ("alloc")), Selector.GetHandle ("init"));
			MessageSend.void_objc_msgSend_IntPtr (obj.Handle, Selector.GetHandle ("setSomeObject:"), someObjectUnknownManagedWrapper);
		}
		[Benchmark]
		public void CallReturnUnknownManagedWrapper ()
		{
			// Now get that value again.
			var rv = obj.SomeObject;
		}
		[IterationCleanup (Target = nameof (CallReturnUnknownManagedWrapper))]
		public void CCallReturnUnknownManagedWrapperCleanup ()
		{
			// cleanup after us
			MessageSend.void_objc_msgSend (someObjectUnknownManagedWrapper, Selector.GetHandle ("release"));
			someObjectUnknownManagedWrapper = IntPtr.Zero;
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
