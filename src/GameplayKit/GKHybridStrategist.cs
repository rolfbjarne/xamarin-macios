using System.ComponentModel;

#nullable enable

#if !XAMCORE_5_0 && !__MACOS__
namespace GameplayKit {
	/// <summary>A <see cref="GameplayKit.IGKStrategist" /> that combines Monte Carlo Tree Search and local search via MinMax.</summary>
	[Register ("GKHybridStrategist", SkipRegistration = true)]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public class GKHybridStrategist : NSObject, IGKStrategist {
		/// <summary>Do not use</summary>
		public override NativeHandle ClassHandle => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		/// <summary>Default constructor, initializes a new instance of this class.</summary>
		///         <remarks />
		public GKHybridStrategist () : base (NSObjectFlag.Empty) => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		/// <summary>Do not use</summary>
		protected GKHybridStrategist (NSObjectFlag t) : base (t) => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		/// <summary>Do not use</summary>
		protected internal GKHybridStrategist (NativeHandle handle) : base (handle) => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		/// <summary>Gets the best move for the active player.</summary>
		public virtual IGKGameModelUpdate GetBestMoveForActivePlayer () => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		/// <summary>Gets or sets the budget.</summary>
		public virtual nuint Budget {
			get => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
			set => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		}
		/// <summary>Gets or sets the exploration parameter.</summary>
		public virtual nuint ExplorationParameter {
			get => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
			set => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		}
		/// <summary>Gets or sets the game model.</summary>
		public virtual IGKGameModel? GameModel {
			get => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
			set => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		}
		/// <summary>Gets or sets the max look ahead depth.</summary>
		public virtual nuint MaxLookAheadDepth {
			get => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
			set => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		}
		/// <summary>Gets or sets the random source.</summary>
		public virtual IGKRandom? RandomSource {
			get => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
			set => throw new PlatformNotSupportedException (Constants.TypeRemovedAllPlatforms);
		}
	}
}
#endif // !XAMCORE_5_0 && !__MACOS__
