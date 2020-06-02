#if IOS

using Foundation;
using Intents;
using ObjCRuntime;

namespace Intents {

	public partial class INSetClimateSettingsInCarIntent {

		[Deprecated (PlatformName.iOS, 12, 0, message: "Use the overload that takes 'INSpeakableString carName'.")]
		public INSetClimateSettingsInCarIntent (bool? enableFan, bool? enableAirConditioner, bool? enableClimateControl, bool? enableAutoMode, INCarAirCirculationMode airCirculationMode, NSNumber fanSpeedIndex, NSNumber fanSpeedPercentage, INRelativeSetting relativeFanSpeedSetting, NSMeasurement<NSUnitTemperature> temperature, INRelativeSetting relativeTemperatureSetting, INCarSeat climateZone) :
			this (enableFan.HasValue ? new NSNumber (enableFan.Value) : null, enableAirConditioner.HasValue ? new NSNumber (enableAirConditioner.Value) : null, 
				enableClimateControl.HasValue ? new NSNumber (enableClimateControl.Value) : null, enableAutoMode.HasValue ? new NSNumber (enableAutoMode.Value) : null,
				airCirculationMode, fanSpeedIndex, fanSpeedPercentage, relativeFanSpeedSetting, temperature, relativeTemperatureSetting, climateZone)
		{
		}
	}
}

#endif
