#if !__MACCATALYST__

#nullable enable

namespace AppKit {
	public partial class NSCollectionView {
		/// <param name="itemClass">The item class.</param>
		/// <param name="identifier">The identifier to use.</param>
		/// <summary>Registers the specified class for use as a collection view item with the given identifier.</summary>
		public void RegisterClassForItem (Type itemClass, string identifier)
		{
			_RegisterClassForItem (Class.GetHandle (itemClass), identifier);
		}

		/// <param name="viewClass">The view class.</param>
		/// <param name="kind">The kind.</param>
		/// <param name="identifier">The identifier to use.</param>
		/// <summary>Registers the specified class for use as a supplementary view with the given kind and identifier.</summary>
		public void RegisterClassForSupplementaryView (Type viewClass, NSString kind, string identifier)
		{
			_RegisterClassForSupplementaryView (Class.GetHandle (viewClass), kind, identifier);
		}
	}
}
#endif // !__MACCATALYST__
