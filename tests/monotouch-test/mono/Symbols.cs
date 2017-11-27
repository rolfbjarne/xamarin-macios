#if !MONOMAC
using System;
using System.Runtime.InteropServices;

#if XAMCORE_2_0
using Foundation;
using ObjCRuntime;
#else
using MonoTouch;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
#endif

using NUnit.Framework;

namespace MonoTouchFixtures {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public partial class Symbols {
		string [] symbols;

		[Test]
		public void FunctionNames ()
		{
			if (Runtime.Arch != Arch.DEVICE)
				Assert.Ignore ("This is a device-only test.");
			
			Collect ();
			Assert.That (symbols [1], Contains.Substring ("MonoTouchFixtures_Symbols_Collect"), "#1");
		}

		void Collect ()
		{
			var array = new IntPtr [50];
			var size = backtrace (array, array.Length);
			var symbols = backtrace_symbols (array, size);

			this.symbols = new string [size];
			for (int i = 0; i < size; i++) {
				this.symbols [i] = Marshal.PtrToStringAuto (Marshal.ReadIntPtr (symbols, i * IntPtr.Size));
//				Console.WriteLine (" #{0}: {1}", i, this.symbols [i]);
			}

			free (symbols);
		}

		[DllImport (Constants.libcLibrary)]
		static extern int backtrace (IntPtr[] array, int size);

		[DllImport (Constants.libcLibrary)]
		static extern IntPtr backtrace_symbols (IntPtr[] array, int size);

		[DllImport (Constants.libcLibrary)]
		static extern void free (IntPtr ptr);
	}
}
#endif