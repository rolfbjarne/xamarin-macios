#if IOS
using Intents;

#nullable enable

namespace Intents {

	public partial class INSetClimateSettingsInCarIntent {
		/// <param name="enableFan">The enable fan.</param>
		///         <param name="enableAirConditioner">The enable air conditioner.</param>
		///         <param name="enableClimateControl">The enable climate control.</param>
		///         <param name="enableAutoMode">The enable auto mode.</param>
		///         <param name="airCirculationMode">The air circulation mode.</param>
		///         <param name="fanSpeedIndex">The fan speed index.</param>
		///         <param name="fanSpeedPercentage">The fan speed percentage.</param>
		///         <param name="relativeFanSpeedSetting">The relative fan speed setting.</param>
		///         <param name="temperature">The temperature.</param>
		///         <param name="relativeTemperatureSetting">The relative temperature setting.</param>
		///         <param name="climateZone">The climate zone.</param>
		///         <summary>To be added.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios12.0", "Use the overload that takes 'INSpeakableString carName'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'INSpeakableString carName'.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		public INSetClimateSettingsInCarIntent (bool? enableFan, bool? enableAirConditioner, bool? enableClimateControl, bool? enableAutoMode, INCarAirCirculationMode airCirculationMode, NSNumber fanSpeedIndex, NSNumber fanSpeedPercentage, INRelativeSetting relativeFanSpeedSetting, NSMeasurement<NSUnitTemperature> temperature, INRelativeSetting relativeTemperatureSetting, INCarSeat climateZone) :
			this (enableFan.HasValue ? new NSNumber (enableFan.Value) : null, enableAirConditioner.HasValue ? new NSNumber (enableAirConditioner.Value) : null,
				enableClimateControl.HasValue ? new NSNumber (enableClimateControl.Value) : null, enableAutoMode.HasValue ? new NSNumber (enableAutoMode.Value) : null,
				airCirculationMode, fanSpeedIndex, fanSpeedPercentage, relativeFanSpeedSetting, temperature, relativeTemperatureSetting, climateZone)
		{
		}
	}
}

#endif
