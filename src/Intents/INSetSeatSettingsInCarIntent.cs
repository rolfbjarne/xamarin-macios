#if IOS
using Intents;

#nullable enable

namespace Intents {

	public partial class INSetSeatSettingsInCarIntent {
		/// <param name="enableHeating">The enable heating.</param>
		///         <param name="enableCooling">The enable cooling.</param>
		///         <param name="enableMassage">The enable massage.</param>
		///         <param name="seat">The seat.</param>
		///         <param name="level">The level.</param>
		///         <param name="relativeLevelSetting">The relative level setting.</param>
		/// <summary>Creates a new intent to set seat settings in a car.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios12.0", "Use the overload that takes 'INSpeakableString carName'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'INSpeakableString carName'.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		public INSetSeatSettingsInCarIntent (bool? enableHeating, bool? enableCooling, bool? enableMassage, INCarSeat seat, NSNumber level, INRelativeSetting relativeLevelSetting) :
			this (enableHeating.HasValue ? new NSNumber (enableHeating.Value) : null, enableCooling.HasValue ? new NSNumber (enableCooling.Value) : null, enableMassage.HasValue ? new NSNumber (enableMassage.Value) : null, seat, level, relativeLevelSetting)
		{
		}
	}
}

#endif
