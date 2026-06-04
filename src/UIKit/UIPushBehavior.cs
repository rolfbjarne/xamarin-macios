namespace UIKit {
	public partial class UIPushBehavior {
		/// <param name="mode">The mode.</param>
		///         <param name="items">The items.</param>
		/// <summary>Creates a new push behavior with the specified mode and dynamic items.</summary>
		public UIPushBehavior (UIPushBehaviorMode mode, params IUIDynamicItem [] items) : this (items, mode) { }
	}
}
