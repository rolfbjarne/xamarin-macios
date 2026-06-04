// Copyright 2014 Xamarin Inc
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//

#nullable enable

#if !MONOMAC

namespace AVFoundation {
	/// <summary>Enumerates physical locations of data sources on AV devices.</summary>
	public enum AVAudioDataSourceLocation {
		/// <summary>Indicates unknown.</summary>
		Unknown,
		/// <summary>Indicates upper.</summary>
		Upper,
		/// <summary>Indicates lower.</summary>
		Lower,
	}

	/// <summary>Enumerates physical orientations of data sources on AV devices.</summary>
	public enum AVAudioDataSourceOrientation {
		/// <summary>Indicates unknown.</summary>
		Unknown,
		/// <summary>Indicates top.</summary>
		Top,
		/// <summary>Indicates bottom.</summary>
		Bottom,
		/// <summary>Indicates front.</summary>
		Front,
		/// <summary>Indicates back.</summary>
		Back,
		/// <summary>Indicates left.</summary>
		Left,
		/// <summary>Indicates right.</summary>
		Right,
	}

	/// <summary>Enumerates microphone directivity values.</summary>
	public enum AVAudioDataSourcePolarPattern {
		/// <summary>Indicates unknown.</summary>
		Unknown,
		/// <summary>Indicates omnidirectional.</summary>
		Omnidirectional,
		/// <summary>Indicates cardioid.</summary>
		Cardioid,
		/// <summary>Indicates subcardioid.</summary>
		Subcardioid,
	}

	/// <summary>Describes a data source of an <see cref="AVFoundation.AVAudioSession" /> object.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiosessiondatasourcedescription">Apple documentation for <c>AVAudioSessionDataSourceDescription</c></related>
	public partial class AVAudioSessionDataSourceDescription {
		static internal AVAudioDataSourceLocation ToLocation (NSString? l)
		{
			if (l == AVAudioSession.LocationLower_)
				return AVAudioDataSourceLocation.Lower;
			else if (l == AVAudioSession.LocationUpper_)
				return AVAudioDataSourceLocation.Upper;
			else
				return AVAudioDataSourceLocation.Unknown;
		}

		static internal AVAudioDataSourceOrientation ToOrientation (NSString? o)
		{
			if (o == AVAudioSession.OrientationTop_)
				return AVAudioDataSourceOrientation.Top;
			if (o == AVAudioSession.OrientationBottom_)
				return AVAudioDataSourceOrientation.Bottom;
			if (o == AVAudioSession.OrientationFront_)
				return AVAudioDataSourceOrientation.Front;
			if (o == AVAudioSession.OrientationBack_)
				return AVAudioDataSourceOrientation.Back;
			return AVAudioDataSourceOrientation.Unknown;
		}

		static internal AVAudioDataSourcePolarPattern ToPolarPattern (NSString? p)
		{
			if (p == AVAudioSession.PolarPatternOmnidirectional_)
				return AVAudioDataSourcePolarPattern.Omnidirectional;
			if (p == AVAudioSession.PolarPatternCardioid_)
				return AVAudioDataSourcePolarPattern.Cardioid;
			if (p == AVAudioSession.PolarPatternSubcardioid_)
				return AVAudioDataSourcePolarPattern.Subcardioid;
			return AVAudioDataSourcePolarPattern.Unknown;
		}

		static internal NSString? ToToken (AVAudioDataSourcePolarPattern p)
		{
			switch (p) {
			case AVAudioDataSourcePolarPattern.Omnidirectional:
				return AVAudioSession.PolarPatternOmnidirectional_;
			case AVAudioDataSourcePolarPattern.Cardioid:
				return AVAudioSession.PolarPatternCardioid_;
			case AVAudioDataSourcePolarPattern.Subcardioid:
				return AVAudioSession.PolarPatternSubcardioid_;
			default:
				return null;
			}
		}

		/// <summary>Indicates the location of the data source on the device.</summary>
		///         <value>The value can be either LocationUpper or LocationLower from <see cref="AVFoundation.AVAudioSession" />.<para tool="nullallowed">This value can be <see langword="null" />.</para></value>
		public AVAudioDataSourceLocation Location {
			get {
				return ToLocation (Location_);
			}
		}

		/// <summary>Indicates the orientation of the data source on the device.</summary>
		///         <value>One of the constants in <see cref="AVFoundation.AVAudioSession" />’s Orientation properties (OrientationTop, OrientationBotton, OrientationFront, OrientationBack, OrientationLeft, OrientationRight).<para tool="nullallowed">This value can be <see langword="null" />.</para></value>
		///         <remarks>The data source can be pointing upwards, downwards, towards the user, away from the user, left or right.</remarks>
		public AVAudioDataSourceOrientation Orientation {
			get {
				return ToOrientation (Orientation_);
			}
		}

		/// <summary>The supported polar configurations by this audio data source.</summary>
		///         <value>Array of strings containing the names of the supported microphone directions for the source, one of PolarPatternOmnidirectional, PolarPatternCardioid, PolarPatternSubcardioid from <see cref="AVFoundation.AVAudioSession" />.</value>
		public AVAudioDataSourcePolarPattern []? SupportedPolarPatterns {
			get {
				var x = SupportedPolarPatterns_;
				if (x is null)
					return null;

				int n = x.Length;
				var r = new AVAudioDataSourcePolarPattern [n];
				for (int i = 0; i < n; i++)
					r [i] = ToPolarPattern (x [i]);
				return r;
			}
		}

		/// <summary>Indicates the currenly selected microphone direction.</summary>
		///         <value>The current setting for the microphone direction, one of PolarPatternOmnidirectional, PolarPatternCardioid, PolarPatternSubcardioid from <see cref="AVFoundation.AVAudioSession" /></value>
		public AVAudioDataSourcePolarPattern SelectedPolarPattern {
			get {
				return ToPolarPattern (SelectedPolarPattern_);
			}
		}

		/// <summary>The preferred microphone direction.</summary>
		///         <value>The current setting for the microphone direction, one of PolarPatternOmnidirectional, PolarPatternCardioid, PolarPatternSubcardioid from <see cref="AVFoundation.AVAudioSession" /></value>
		///         <remarks>To change this property, call the <see cref="AVFoundation.AVAudioSessionDataSourceDescription.SetPreferredPolarPattern(AVFoundation.AVAudioDataSourcePolarPattern,out Foundation.NSError)" />.</remarks>
		public AVAudioDataSourcePolarPattern PreferredPolarPattern {
			get {
				return ToPolarPattern (PreferredPolarPattern_);
			}
		}

		/// <param name="pattern">The pattern.</param>
		///         <param name="outError">The out error.</param>
		///         <summary>Sets the preferred directivity for the data source.</summary>
		///         <returns>To be added.</returns>
		public bool SetPreferredPolarPattern (AVAudioDataSourcePolarPattern pattern, out NSError outError)
		{
			return SetPreferredPolarPattern_ (ToToken (pattern), out outError);
		}
	}
}
#endif
