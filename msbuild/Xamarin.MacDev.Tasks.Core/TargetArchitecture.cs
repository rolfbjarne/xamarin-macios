using System;
using System.Collections.Generic;

namespace Xamarin.MacDev {
	[Flags]
	public enum TargetArchitecture {
		Default = 0,

		i386 = 1,
		x86_64 = 2,

		ARMv6 = 4,
		ARMv7 = 8,
		ARMv7s = 16,
		ARMv7k = 32,
		ARM64 = 64,
		ARM64_32 = 128,

		// Note: needed for backwards compatability
		ARMv6_ARMv7 = ARMv6 | ARMv7,
	}

	public static class TargetArchitecture_Extensions {
		public static IList<TargetArchitecture> ToList (this TargetArchitecture architectures)
		{
			var list = new List<TargetArchitecture> ();

			for (int bit = 0; bit < 32; bit++) {
				var architecture = (TargetArchitecture) (1 << bit);

				if ((architectures & architecture) == 0)
					continue;

				list.Add (architecture);
			}

			return list;
		}

		public static Abi ToAbi (this TargetArchitecture architecture)
		{
			switch (architecture) {
			case TargetArchitecture.ARMv6:
				return Abi.ARMv6;
			case TargetArchitecture.ARMv7:
				return Abi.ARMv7;
			case TargetArchitecture.ARMv7k:
				return Abi.ARMv7k;
			case TargetArchitecture.ARMv7s:
				return Abi.ARMv7s;
			case TargetArchitecture.ARM64:
				return Abi.ARM64;
			case TargetArchitecture.ARM64_32:
				return Abi.ARM64_32;
			case TargetArchitecture.i386:
				return Abi.i386;
			case TargetArchitecture.x86_64:
				return Abi.x86_64;
			default:
				throw new Exception ($"Unknown architecture: {architecture}");
			}
		}
	}
}
