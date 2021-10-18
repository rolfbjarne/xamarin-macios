//
// AudioBuffers: AudioBufferList wrapper class
//
// Authors:
//   Miguel de Icaza
//   Marek Safar (marek.safar@gmail.com)
//
// Copyright 2011, 2012 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#nullable enable

using System;
using System.Runtime.InteropServices;

using CoreFoundation;
using ObjCRuntime;

namespace AudioToolbox
{
	// CoreAudio.framework - CoreAudioTypes.h
	public class AudioBuffers : NonRefcountedNativeObject
	{
		public AudioBuffers (IntPtr address)
			: base (address, false)
		{
		}

		public AudioBuffers (IntPtr address, bool owns)
			: base (address, owns)
		{
		}

		unsafe static IntPtr Create (int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException (nameof (count));

			//
			// AudioBufferList is a int + array of AudioBuffer (int + int + intptr).
			// However due to alignment, the array of AudioBuffer comes at position 8
			// in 64bit architectures, which is why we're using IntPtr.Size here
			// in order to calculate the total size / position of the AudioBuffer elements.
			//

			var size = IntPtr.Size + count * sizeof (AudioBuffer);
			var address = Marshal.AllocHGlobal (size);

			Marshal.WriteInt32 (address, 0, count);
			AudioBuffer* ptr = (AudioBuffer*) (((byte*) address) + IntPtr.Size);
			for (int i = 0; i < count; i++) {
				ptr->NumberChannels = 0;
				ptr->DataByteSize = 0;
				ptr->Data = IntPtr.Zero;
				ptr++;
			}

			return address;
		}

		public unsafe AudioBuffers (int count)
			: base (Create (count), true)
		{
		}

		public unsafe int Count {
			get {
				return *(int *) (IntPtr) Handle;
			}
		}

		public AudioBuffer this [int index] {
			get {
				if (index >= Count)
					throw new ArgumentOutOfRangeException (nameof (index));

				//
				// Decodes
				//
				// struct AudioBufferList
				// {
				//    UInt32      mNumberBuffers;
				//    AudioBuffer mBuffers[1]; // this is a variable length array of mNumberBuffers elements
				// }
				//
				unsafe {
					byte *baddress = (byte *) (IntPtr) Handle;
					
					var ptr = baddress + IntPtr.Size + index * sizeof (AudioBuffer);
					return *(AudioBuffer *) ptr;
				}
			}
			set {
				if (index >= Count)
					throw new ArgumentOutOfRangeException (nameof (index));

				unsafe {
					byte *baddress = (byte *) (IntPtr) Handle;
					var ptr = (AudioBuffer *) (baddress + IntPtr.Size + index * sizeof (AudioBuffer));
					*ptr = value;
				}
			}
		}

		public static explicit operator IntPtr (AudioBuffers audioBuffers)
		{
			return audioBuffers.Handle;
		}

		public void SetData (int index, IntPtr data)
		{
			if (index >= Count)
				throw new ArgumentOutOfRangeException (nameof (index));

			unsafe {
				byte * baddress = (byte *) (IntPtr) Handle;
				var ptr = (IntPtr *)(baddress + IntPtr.Size + index * sizeof (AudioBuffer) + sizeof (int) + sizeof (int));
				*ptr = data;
			}
		}

		public void SetData (int index, IntPtr data, int dataByteSize)
		{
			if (index >= Count)
				throw new ArgumentOutOfRangeException (nameof (index));

			unsafe {
				byte *baddress = (byte *) (IntPtr) Handle;
				var ptr = (int *)(baddress + IntPtr.Size + index * sizeof (AudioBuffer) + sizeof (int));
				*ptr = dataByteSize;
				ptr++;
				IntPtr *iptr = (IntPtr *) ptr;
				*iptr = data;
			}
		}

		protected override void Free ()
		{
			if (Handle != IntPtr.Zero && Owns) {
				Marshal.FreeHGlobal (Handle);
			}
		}
	}
}
