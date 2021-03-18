using System;
using System.Diagnostics;
using System.Linq;

using Foundation;

namespace CoreCLRPerfTest {
	public class ObjCBridge {
		public static void Run ()
		{
			var bridge = new ObjCBridge ();
			RunTest (nameof (NSObjectCreated), bridge.NSObjectCreated, 100000);
			RunTest (nameof (NSObjectCreatedAndDisposed), bridge.NSObjectCreatedAndDisposed, 100000);
			RunTest (nameof (CustomSubClassCreated), bridge.NSObjectCreated, 100000);
			RunTest (nameof (CustomSubClassCreatedAndDisposed), bridge.NSObjectCreatedAndDisposed, 100000);

			var invokeOnNSObject = new InvokeOnNSObject ();
			RunTest (nameof (invokeOnNSObject.CallClass), invokeOnNSObject.CallClass, 100000);

			var invokeOnCustomClass = new InvokeOnCustomClass ();
			RunTest (nameof (invokeOnCustomClass.CallInstanceMethodInNativeCode), invokeOnCustomClass.CallInstanceMethodInNativeCode, 100000);
			RunTest (nameof (invokeOnCustomClass.CallStaticMethodInNativeCode), invokeOnCustomClass.CallStaticMethodInNativeCode, 100000);
			RunTest (nameof (invokeOnCustomClass.CallOverriddenInstanceMethod), invokeOnCustomClass.CallOverriddenInstanceMethod, 100000);
			RunTest (nameof (invokeOnCustomClass.CallExportedInstanceMethod), invokeOnCustomClass.CallExportedInstanceMethod, 100000);
			RunTest (nameof (invokeOnCustomClass.CallExportedStaticMethod), invokeOnCustomClass.CallExportedStaticMethod, 100000);

			var marshalling = new Marshalling ();
			RunTest (nameof (marshalling.CallReturnString_EmptyString), marshalling.CallReturnString_EmptyString, 100000);
			RunTest (nameof (marshalling.CallReturnString_ShortString), marshalling.CallReturnString_ShortString, 100000);
			RunTest (nameof (marshalling.CallReturnString_LongString), marshalling.CallReturnString_LongString, 100000);
			RunTest (nameof (marshalling.CallReturnKnownManagedWrapper), marshalling.CallReturnKnownManagedWrapper, 100000);
			RunTest (nameof (marshalling.CallReturnUnknownManagedWrapper), marshalling.CallReturnUnknownManagedWrapper, 100000);

			var vm = new VM ();
			RunTest (nameof (vm.CreateObject), vm.CreateObject, 10000000);

		}

		static void RunTest (string name, Action test, int iterations)
		{
			test (); // warm up

			var watch = Stopwatch.StartNew ();
			for (var i = 0; i < iterations; i++)
				test ();
			watch.Stop ();

			var perMilliSecond = iterations / (double) watch.ElapsedMilliseconds;
			Console.WriteLine ($"Executed {name} for {iterations} iterations in {watch.Elapsed} resulting in {perMilliSecond} iterations per millisecond.");
		}

		void NSObjectCreated ()
		{
			new NSObject ();
		}

		void NSObjectCreatedAndDisposed ()
		{
			using (var obj = new NSObject ()) { }
		}

		void CustomSubClassCreated ()
		{
			new CustomSubClass ();
		}

		void CustomSubClassCreatedAndDisposed ()
		{
			using (var obj = new CustomSubClass ()) { }
		}

		class CustomSubClass : NSObject {

		}

	}

	class InvokeOnNSObject {
		NSObject obj = new NSObject ();

		public void CallClass ()
		{
			var c = obj.Class;
		}
	}

	class InvokeOnCustomClass {
		public void CallInstanceMethodInNativeCode ()
		{

		}

		public void CallStaticMethodInNativeCode ()
		{

		}

		public void CallOverriddenInstanceMethod ()
		{

		}

		public void CallExportedInstanceMethod ()
		{

		}

		public void CallExportedStaticMethod ()
		{

		}
	}

	class Marshalling {
		public void CallReturnString_EmptyString ()
		{

		}

		public void CallReturnString_ShortString ()
		{

		}

		public void CallReturnString_LongString ()
		{

		}

		public void CallReturnKnownManagedWrapper ()
		{

		}

		public void CallReturnUnknownManagedWrapper ()
		{

		}
	}

	class VM {
		public void CreateObject ()
		{
			new object ();
		}
	}
}
