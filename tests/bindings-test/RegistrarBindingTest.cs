﻿using System;
using System.Threading;

#if __UNIFIED__
using Foundation;
using ObjCRuntime;
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
#endif

using NUnit.Framework;

using Bindings.Test;

namespace Xamarin.BindingTests
{
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class RegistrarBindingTest
	{
		[Test]
		public void BlockCallback ()
		{
			using (var obj = new BlockCallbackTester ()) {
				obj.CallClassCallback ();

				obj.TestObject = new BlockCallbackClass ();
				obj.CallOptionalCallback ();
				obj.CallRequiredCallback ();
				ObjCBlockTester.TestClass = new Class (typeof (BlockCallbackClass));
				ObjCBlockTester.CallRequiredStaticCallback ();
				ObjCBlockTester.CallOptionalStaticCallback ();

				obj.TestObject = new BlockCallbackClassExplicit ();
				obj.CallOptionalCallback ();
				obj.CallRequiredCallback ();
				ObjCBlockTester.TestClass = new Class (typeof (BlockCallbackClassExplicit));
				ObjCBlockTester.CallRequiredStaticCallback ();
				ObjCBlockTester.CallOptionalStaticCallback ();
			}
		}

		class BlockCallbackClass : NSObject, IObjCProtocolBlockTest
		{
			public void RequiredCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("optionalCallback:")]
			public void OptionalCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("requiredStaticCallback:")]
			public static void RequiredStaticCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("optionalStaticCallback:")]
			public static void OptionalStaticCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}
		}

		class BlockCallbackClassExplicit : NSObject, IObjCProtocolBlockTest
		{
			// Explicitly implemented interface member
			void IObjCProtocolBlockTest.RequiredCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("optionalCallback:")]
			public void OptionalCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("requiredStaticCallback:")]
			public static void RequiredStaticCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}

			[Export ("optionalStaticCallback:")]
			public static void OptionalRequiredCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}
		}

		public class BlockCallbackTester : ObjCBlockTester
		{
			public override void ClassCallback (Action<int> completionHandler)
			{
				completionHandler (42);
			}
		}

		public class PropertyBlock : NSObject, IProtocolWithSingleBlockProperty {
			[Export ("myProperty")]
			public SimpleCallback MyProperty { get; set; }
		}
	}
}
