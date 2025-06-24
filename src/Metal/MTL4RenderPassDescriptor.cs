using System;

using Foundation;
using Metal;
using ObjCRuntime;

#nullable enable

namespace Metal {
	public partial class MTL4RenderPassDescriptor {
		/// <summary>Get or set the custom sample positions.</summary>
		public MTLSamplePosition []? SamplePositions {
			get {
				var array = new MTLSamplePosition [128];
				nuint count;
				unsafe {
					fixed (MTLSamplePosition* ptr = array) {
						count = GetSamplePositions ((IntPtr) ptr, (nuint) array.Length);
					}
				}
				if (count == 0)
					return null;

				Array.Resize (ref array, (int) count);
				return array;
			}
			set {
				unsafe {
					fixed (MTLSamplePosition* valuePtr = value) {
						SetSamplePositions ((IntPtr) valuePtr, (nuint) (value?.Length ?? 0));
					}
				}
			}
		}
	}
}
