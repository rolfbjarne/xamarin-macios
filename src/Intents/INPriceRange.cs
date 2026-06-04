//
// INPriceRange extensions and syntax sugar
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

#if IOS

#nullable enable

namespace Intents {
	/// <summary>Enumerates the minimum and maximum values of a price range.</summary>
	public enum INPriceRangeOption {
		/// <summary>The greatest price.</summary>
		Maximum,
		/// <summary>The lowest price.</summary>
		Minimum,
	}

	public partial class INPriceRange {

		/// <param name="option">The option.</param>
		///         <param name="price">The price.</param>
		///         <param name="currencyCode">The currency code.</param>
		///         <summary>To be added.</summary>
		public INPriceRange (INPriceRangeOption option, NSDecimalNumber price, string currencyCode)
			: base (NSObjectFlag.Empty)
		{
			switch (option) {
			case INPriceRangeOption.Maximum:
				InitializeHandle (InitWithMaximumPrice (price, currencyCode));
				break;
			case INPriceRangeOption.Minimum:
				InitializeHandle (InitWithMinimumPrice (price, currencyCode));
				break;
			default:
				throw new ArgumentOutOfRangeException (nameof (option), option, "Invalid enum value.");
			}
		}
	}
}
#endif // IOS
