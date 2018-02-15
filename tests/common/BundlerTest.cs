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
#if __MACOS__
		[TestCase (Profile.macOSMobile)]
#else
		[TestCase (Profile.iOS)]
#endif
		public void RegisterProtocolOptimization (Profile profile)
		{
			using (var bundler = new BundlerTool ()) {
				bundler.Profile = profile;
				bundler.CreateTemporaryCacheDirectory ();
				bundler.CreateTemporaryApp (profile);
				bundler.Linker = LinkerOption.LinkAll;
				bundler.Registrar = RegistrarOption.Static;
				bundler.Optimize = new string [] { "register-protocols" };
				bundler.AssertExecute ();
				bundler.AssertWarningCount (0);

				AssemblyDefinition ad = AssemblyDefinition.ReadAssembly (bundler.GetPlatformAssemblyInApp ());
				var failures = new List<string> ();
				foreach (var attrib in ad.MainModule.GetCustomAttributes ()) {
					switch (attrib.AttributeType.Name) {
					case "ProtocolAttribute":
					case "ProtocolMemberAttribute":
					case "AdoptsAttribute":
						// Unfortunately the CustomAttribute doesn't know its owner, so we can't show that in the test failure message :(
						failures.Add ($"Found an unexpected attribute: {attrib.AttributeType.FullName}");
						break;
					}
				}
				Assert.That (failures, Is.Empty, "all these attributes should have been linked away");
			}
		}


		[Test]
#if __MACOS__
		[TestCase (Profile.macOSMobile)]
#else
		[TestCase (Profile.iOS)]
#endif
		public void MX2106 (Profile profile)
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

		[Test]
#if __MACOS__
		[TestCase (Profile.macOSMobile)]
#else
		[TestCase (Profile.iOS)]
#endif
		public void MX2107 (Profile profile)
		{
			using (var bundler = new BundlerTool ()) {
				var code = @"
using System;
using Foundation;
using ObjCRuntime;
class T {
	static void Main ()
	{
		TypeConverter.ToManaged (""@"");
		Runtime.ConnectMethod (typeof (NSObject), typeof (T).GetMethod (""Main""), new Selector (""sel""));
		Runtime.ConnectMethod (typeof (NSObject), typeof (T).GetMethod (""Main""), new ExportAttribute (""sel""));
		Runtime.ConnectMethod (typeof (T).GetMethod (""Main""), new Selector (""sel""));
		Runtime.RegisterAssembly (null);
		BlockLiteral bl = default (BlockLiteral);
		Action action = null;
		bl.SetupBlock (action, action);
		bl.SetupBlockUnsafe (action, action);
	}
}
";
				bundler.Profile = profile;
				bundler.CreateTemporaryCacheDirectory ();
				bundler.CreateTemporaryApp (profile, code: code, extraArg: "/debug:full");
				bundler.Linker = LinkerOption.LinkSdk;
				bundler.Registrar = RegistrarOption.Static;
				bundler.Optimize = new string [] { "remove-dynamic-registrar" };
				bundler.AssertExecute ();
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.TypeConverter.ToManaged (System.String)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Type, System.Reflection.MethodInfo, ObjCRuntime.Selector)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Type, System.Reflection.MethodInfo, Foundation.ExportAttribute)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Reflection.MethodInfo, ObjCRuntime.Selector)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.RegisterAssembly (System.Reflection.Assembly)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.BlockLiteral.SetupBlock (System.Delegate, System.Delegate)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.BlockLiteral.SetupBlockUnsafe (System.Delegate, System.Delegate)'.");
				bundler.AssertWarningCount (7);

				// try again with link all, now the warnings about SetupBlock[Unsafe] should be gone
				bundler.Linker = LinkerOption.LinkAll;
				bundler.AssertExecute ();
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.TypeConverter.ToManaged (System.String)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Type, System.Reflection.MethodInfo, ObjCRuntime.Selector)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Type, System.Reflection.MethodInfo, Foundation.ExportAttribute)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.ConnectMethod (System.Reflection.MethodInfo, ObjCRuntime.Selector)'.");
				bundler.AssertWarning (2107, "It's not safe to remove the dynamic registrar, because testApp references 'ObjCRuntime.Runtime.RegisterAssembly (System.Reflection.Assembly)'.");
				bundler.AssertWarningCount (5);
			}
		}

		[Test]
#if __MACOS__
		[TestCase (Profile.macOSMobile)]
#else
		[TestCase (Profile.iOS)]
#endif
		public void MX4105 (Profile profile)
		{
			using (var bundler = new BundlerTool ()) {
				var code = @"
using System;
using Foundation;
using ObjCRuntime;
class D : NSObject {
	[Export (""d1:"")]
	public void D1 (Delegate d)
	{
	}

	[Export (""d2:"")]
	public void D2 (MulticastDelegate d)
	{
	}

	[Export (""d3:"")]
	public void D3 (Action d)
	{
		// This should not show errors
	}

	[Export (""d4"")]
	public Delegate D4 ()
	{
		return null;
	}

	[Export (""d5"")]
	public MulticastDelegate D5 ()
	{
		return null;
	}

	[Export (""d6"")]
	public Action D6 ()
	{
		return null;
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
				bundler.Optimize = new string [] { "blockliteral-setupblock" };
				bundler.Registrar = RegistrarOption.Static;
				bundler.AssertExecuteFailure ();
				bundler.AssertError (4105, "The registrar cannot marshal the parameter of type `System.Delegate` in signature for method `D.D1`.");
				bundler.AssertError (4105, "The registrar cannot marshal the parameter of type `System.MulticastDelegate` in signature for method `D.D2`.");
				bundler.AssertWarning (4173, "The registrar can't compute the block signature for the delegate of type System.Delegate in the method D.D4 because System.Delegate doesn't have a specific signature.", "testApp.cs", 24);
				bundler.AssertWarning (4173, "The registrar can't compute the block signature for the delegate of type System.MulticastDelegate in the method D.D5 because System.MulticastDelegate doesn't have a specific signature.", "testApp.cs", 30);
				bundler.AssertErrorCount (2);
				bundler.AssertWarningCount (2);
			}
		}
	}
}
