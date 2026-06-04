#nullable enable

namespace FinderSync {
	/// <summary>To be added.</summary>
	[Native]
	public enum FIMenuKind : ulong {
		/// <summary>Indicates contextual menu for items.</summary>
		ContextualMenuForItems = 0,
		/// <summary>Indicates contextual menu for container.</summary>
		ContextualMenuForContainer = 1,
		/// <summary>Indicates contextual menu for sidebar.</summary>
		ContextualMenuForSidebar = 2,
		/// <summary>Indicates toolbar item menu.</summary>
		ToolbarItemMenu = 3,
	}
}
