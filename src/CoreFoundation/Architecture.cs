#nullable enable

using CoreFoundation;

namespace CoreFoundation {
	/// <summary>Provides access to information about Core Foundation bundles.</summary>
	public partial class CFBundle {

		// from machine.h
		// #define CPU_ARCH_ABI64       0x01000000
		// #define CPU_TYPE_X86        ((cpu_type_t) 7)
		// #define CPU_TYPE_X86_64     (CPU_TYPE_X86 | CPU_ARCH_ABI64)
		// #define CPU_TYPE_ARM        ((cpu_type_t) 12)
		// #define CPU_TYPE_ARM64      (CPU_TYPE_ARM | CPU_ARCH_ABI64)
		// #define CPU_TYPE_POWERPC    ((cpu_type_t) 18)
		// #define CPU_TYPE_POWERPC64  (CPU_TYPE_POWERPC | CPU_ARCH_ABI64)
		/// <summary>Specifies the CPU architecture of a binary.</summary>
		public enum Architecture {
			/// <summary>Indicates i386.</summary>
			I386 = 0x00000007,
			/// <summary>Indicates x86_64.</summary>
			X86_64 = 0x01000007,
			/// <summary>Indicates ARM.</summary>
			ARM = 0x0000000c,
			/// <summary>Indicates AR m64.</summary>
			ARM64 = 0x01000000 | ARM,
			/// <summary>Indicates PPC.</summary>
			PPC = 0x00000012,
			/// <summary>Indicates PP c64.</summary>
			PPC64 = 0x01000000 | PPC,
		}
	}
}
