#if NET
using Foundation;

#nullable enable

namespace FSKit {
	public partial class FSBlockDeviceResource {
		public unsafe void Read (byte [] buffer, long offset, nuint nbytes, Action<nuint, NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				Read ((IntPtr) bufferPtr, offset, nbytes, reply);
			}
		}

		public unsafe void SynchronousRead (byte [] buffer, long offset, nuint nbytes, Action<nuint, NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				SynchronousRead ((IntPtr) bufferPtr, offset, nbytes, reply);
			}
		}

		public unsafe void Write (byte [] buffer, long offset, nuint nbytes, Action<nuint, NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				Write ((IntPtr) bufferPtr, offset, nbytes, reply);
			}
		}

		public unsafe void SynchronousWrite (byte [] buffer, long offset, nuint nbytes, Action<nuint, NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				SynchronousWrite ((IntPtr) bufferPtr, offset, nbytes, reply);
			}
		}

		public unsafe void SynchronousMetaRead (byte [] buffer, long offset, nuint length, Action<NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				SynchronousMetaRead ((IntPtr) bufferPtr, offset, length, reply);
			}
		}

		public unsafe void SynchronousMetaRead (byte [] buffer, long offset, nuint length, FSMetaReadahead[] readAheadExtents, Action<NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				fixed (FSMetaReadahead* readAheadExtentsPtr = readAheadExtents) {
					SynchronousMetaRead ((IntPtr) bufferPtr, offset, length, (IntPtr) readAheadExtentsPtr, readAheadExtents.Length, reply);
				}
			}
		}

		public unsafe void MetaWrite (byte [] buffer, long offset, nuint length, Action<NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				MetaWrite ((IntPtr) bufferPtr, offset, length, reply);
			}
		}

		public unsafe void SynchronousMetaWrite (byte [] buffer, long offset, nuint length, Action<NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				SynchronousMetaWrite ((IntPtr) bufferPtr, offset, length, reply);
			}
		}

		public unsafe void SynchronousDelayedMetaWrite (byte [] buffer, long offset, nuint length, Action<NSError> reply)
		{
			fixed (byte* bufferPtr = buffer) {
				SynchronousDelayedMetaWrite ((IntPtr) bufferPtr, offset, length, reply);
			}
		}
	}
}
#endif // NET
