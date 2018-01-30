// Tests are common to both mtouch and mmp
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using Mono.Cecil;

using Xamarin.Tests;

#if MONOTOUCH
using BundlerTool = Xamarin.MTouchTool;
#else
using BundlerTool = Xamarin.MmpTool;
#endif

namespace Xamarin
{
	[TestFixture]
	public class BundlerTests
	{
		[Test]
#if MONOTOUCH
		[TestCase (Profile.iOS)]
#else
		[TestCase (Profile.macOSMobile)]
#endif
		public void XX2106 (Profile profile)
		{
			using (var bundler = new BundlerTool ()) {
				var code = @"
using System;
using Foundation;
using ObjCRuntime;
class T {
	[BindingImpl (BindingImplOptions.Optimizable)]
	void SetupBlockOptimized_Delegate (Action callback, Delegate block_callback)
	{
		BlockLiteral block = new BlockLiteral ();
		block.SetupBlock (block_callback, callback);
		// don't need anything here, since this won't be executed
		block.CleanupBlock ();
	}

	[BindingImpl (BindingImplOptions.Optimizable)]
	void SetupBlockOptimized_MulticastDelegate (Action callback, MulticastDelegate block_callback)
	{
		BlockLiteral block = new BlockLiteral ();
		block.SetupBlock (block_callback, callback);
		// don't need anything here, since this won't be executed
		block.CleanupBlock ();
	}

	static void Main ()
	{
		Console.WriteLine (typeof (NSObject));
	}
}
";
				bundler.Profile = profile;
				bundler.CreateTemporaryCacheDirectory ();
				bundler.CreateTemporaryApp (profile, code: code, extraArg: "/debug:full");
				bundler.Linker = LinkerOption.LinkAll;
				bundler.Optimize = new string [] { "blockliteral-setupblock" };
				bundler.AssertExecute ();
				bundler.AssertWarning (2106, "Could not optimize the call to BlockLiteral.SetupBlock in System.Void T::SetupBlockOptimized_Delegate(System.Action,System.Delegate) because the type of the value passed as the first argument (the trampoline) is System.Delegate, which makes it impossible to compute the block signature.", "testApp.cs", 10);
				bundler.AssertWarning (2106, "Could not optimize the call to BlockLiteral.SetupBlock in System.Void T::SetupBlockOptimized_MulticastDelegate(System.Action,System.MulticastDelegate) because the type of the value passed as the first argument (the trampoline) is System.MulticastDelegate, which makes it impossible to compute the block signature.", "testApp.cs", 19);
				bundler.AssertWarningCount (2);
			}
		}
	}
}
