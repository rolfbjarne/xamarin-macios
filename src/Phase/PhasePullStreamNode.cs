using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using AudioToolbox;
using ObjCRuntime;

namespace Phase {
#if NET
	public unsafe delegate /* OSStatus */ int PhasePullStreamRenderBlock (
		/* BOOL * */ out bool isSilence,
		/* const AudioTimeStamp * */ ref readonly AudioTimeStamp timeStamp,
		/* AVAudioFrameCount */ uint frameCount,
		/* AudioBufferList * */ AudioBuffers outputData);

	public partial class PhasePullStreamNode {
		public PhasePullStreamRenderBlock RenderBlock {
			get {
				var rawRenderBlock = RenderBlockRaw;

				// It's not declared as nullable, but this avoids a potential crash if we get a NRE in the callback,
				if (rawRenderBlock is null)
					return null!;

				return new PhasePullStreamRenderBlock ((out bool isSilence, ref readonly AudioTimeStamp timeStamp, uint frameCount, AudioBuffers outputData) =>
				{
					byte isSilenceValue = 0;
					int rv;
					unsafe {
						fixed (AudioTimeStamp* timeStampPtr = &timeStamp) {
							byte* isSilencePtr = &isSilenceValue;
							rv = rawRenderBlock ((IntPtr) isSilencePtr, (IntPtr) timeStampPtr, frameCount, outputData.Handle);
						}
					}
					isSilence = isSilenceValue != 0;
					return rv;
				});
			}
			set {
				// It's not declared as nullable, but this avoids a potential crash if we get a NRE in the callback,
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));

				RenderBlockRaw = new PhasePullStreamRenderBlockRaw ((IntPtr isSilence, IntPtr timeStamp, uint frameCount, IntPtr outputData) =>
				{
					unsafe {
						byte* isSilencePtr = (byte *) isSilence;
						bool isSilenceValue = *isSilencePtr != 0;
						AudioTimeStamp* timeStampValue = (AudioTimeStamp *) timeStamp;
						var outputDataValue = new AudioBuffers (outputData);
						var rv = value (out isSilenceValue, ref Unsafe.AsRef<AudioTimeStamp> (timeStampValue), frameCount, outputDataValue);
						*isSilencePtr = isSilenceValue.AsByte ();
						return rv;
					}
				});
			}
		}
	}
#endif // NET
}
