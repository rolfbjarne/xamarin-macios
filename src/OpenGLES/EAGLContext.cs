using System.Runtime.CompilerServices;

namespace OpenGLES {
	public partial class EAGLContext {
		/// <summary>Gets or sets the presentation mode.</summary>
		public enum PresentationMode {
			/// <summary>Indicates at time.</summary>
			AtTime = 0,
			/// <summary>Indicates after minimum duration.</summary>
			AfterMinimumDuration = 1,
		}

		[DllImport (Constants.OpenGLESLibrary)]
		unsafe extern static void EAGLGetVersion (nuint* major, nuint* minor);

		/// <param name="major">The major.</param>
		/// <param name="minor">The minor.</param>
		/// <summary>Writes the major and minor version numbers in the provided <see langword="out" /> parameters.</summary>
		public unsafe static void EAGLGetVersion (out nuint major, out nuint minor)
		{
			major = default;
			minor = default;
			fixed (nuint* majorPtr = &major, minorPtr = &minor)
				EAGLGetVersion (majorPtr, minorPtr);
		}

		/// <param name="target">The target.</param>
		/// <param name="presentationTime">The presentation time.</param>
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
		public virtual bool PresentRenderBuffer (nuint target, double presentationTime)
		{
			return _PresentRenderbufferAtTime (target, presentationTime);
		}

		/// <param name="target">The target.</param>
		/// <param name="presentationTime">The presentation time.</param>
		/// <param name="mode">The mode.</param>
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
		public virtual bool PresentRenderBuffer (nuint target, double presentationTime, PresentationMode mode)
		{
			switch (mode) {
			case PresentationMode.AtTime:
				return _PresentRenderbufferAtTime (target, presentationTime);
			case PresentationMode.AfterMinimumDuration:
				return _PresentRenderbufferAfterMinimumDuration (target, presentationTime);
			default:
				throw new ArgumentOutOfRangeException ($"Unknown presentation mode: {mode}", nameof (mode));
			}
		}
	}
}
