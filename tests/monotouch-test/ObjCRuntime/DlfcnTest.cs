//
// Unit tests for Dlfcn
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2012 Xamarin Inc. All rights reserved.
//

using System;
using Foundation;
using ObjCRuntime;
using NUnit.Framework;

namespace MonoTouchFixtures.ObjCRuntime {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class DlfcnTest {

		[Test]
		public void OpenClose_libSystem ()
		{
			IntPtr handle = Dlfcn.dlopen ("/usr/lib/libSystem.dylib", 0);
			Assert.That (handle, Is.Not.EqualTo (IntPtr.Zero), "dlopen");
			var err = Dlfcn.dlclose (handle);
			var expected = 0;
#if !MONOMAC && !__MACCATALYST__
			if (Runtime.Arch == Arch.DEVICE && TestRuntime.CheckXcodeVersion (7, 0) && !TestRuntime.CheckXcodeVersion (10, 0)) {
				// Apple is doing some funky stuff with dlopen... this condition is to track if this change during betas
				expected = -1;
			}
#endif
			Assert.That (err, Is.EqualTo (expected), "dlclose");
		}

		[Test]
		public void GetVariables ()
		{
			var symbol = "_x_native_field";
			var handle = Dlfcn.dlopen ((IntPtr) Dlfcn.RTLD.Default);
			var originalValue = Dlfcn.GetUInt64 (handle, symbol);
			Assert.Multiple (() => {
				Assert.AreEqual (0, Dlfcn.GetInt16 (handle, symbol), "GetInt16");
				Assert.AreEqual (0, Dlfcn.GetInt32 (handle, symbol), "GetInt32");
				Assert.AreEqual (0, Dlfcn.GetInt64 (handle, symbol), "GetInt64");
				Assert.AreEqual (0, Dlfcn.GetNInt (handle, symbol), "GetNInt");
				Assert.AreEqual (0, Dlfcn.GetUInt16 (handle, symbol), "GetUInt16");
				Assert.AreEqual (0, Dlfcn.GetUInt32 (handle, symbol), "GetUInt32");
				Assert.AreEqual (0, Dlfcn.GetUInt64 (handle, symbol), "GetUInt64");
				Assert.AreEqual (0, Dlfcn.GetNUInt (handle, symbol), "GetNUInt");
				Assert.AreEqual (0, Dlfcn.GetNFloat (handle, symbol), "GetNFloat");
				Assert.AreEqual (0, Dlfcn.GetDouble (handle, symbol), "GetDouble");
				Assert.AreEqual (0, Dlfcn.GetIntPtr (handle, symbol), "GetIntPtr");
				Assert.AreEqual (0, Dlfcn.GetUIntPtr (handle, symbol), "GetUIntPtr");

				Dlfcn.SetInt16 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetInt16 (handle, symbol), "SetInt16");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetInt32 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetInt32 (handle, symbol), "SetInt32");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetInt64 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetInt64 (handle, symbol), "SetInt64");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetNInt (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetNInt (handle, symbol), "SetNInt");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetUInt16 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetUInt16 (handle, symbol), "SetUInt16");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetUInt32 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetUInt32 (handle, symbol), "SetUInt32");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetUInt64 (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetUInt64 (handle, symbol), "SetUInt64");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetNUInt (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetNUInt (handle, symbol), "SetNUInt");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetNFloat (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetNFloat (handle, symbol), "SetNFloat");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetDouble (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetDouble (handle, symbol), "SetDouble");
				Dlfcn.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetIntPtr (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetIntPtr (handle, symbol), "SetIntPtr");
				DlfcnTest.SetUInt64 (handle, symbol, originalValue);

				Dlfcn.SetUIntPtr (handle, symbol, 0x77);
				Assert.AreEqual (0x77, Dlfcn.GetUIntPtr (handle, symbol), "SetUIntPtr");
				DlfcnTest.SetUInt64 (handle, symbol, originalValue);
			});
		}
	}
}
