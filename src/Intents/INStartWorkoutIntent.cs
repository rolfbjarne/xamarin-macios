#if IOS
#if !__MACOS__

using Intents;

#nullable enable

namespace Intents {

	public partial class INStartWorkoutIntent {

		/// <param name="workoutName">The workout name.</param>
		/// <param name="goalValue">The goal value.</param>
		/// <param name="workoutGoalUnitType">The workout goal unit type.</param>
		/// <param name="workoutLocationType">The workout location type.</param>
		/// <param name="isOpenEnded">Whether the workout is open ended.</param>
		/// <summary>Creates a new intent to start a workout with the specified parameters.</summary>
		public INStartWorkoutIntent (INSpeakableString workoutName, NSNumber goalValue, INWorkoutGoalUnitType workoutGoalUnitType, INWorkoutLocationType workoutLocationType, bool? isOpenEnded) :
			this (workoutName, goalValue, workoutGoalUnitType, workoutLocationType, isOpenEnded.HasValue ? new NSNumber (isOpenEnded.Value) : null)
		{
		}
	}
}

#endif // !__MACOS__
#endif
