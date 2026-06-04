#nullable enable

namespace PassKit {

	public partial class PKContactFieldsExtensions {

		/// <param name="set">The set.</param>
		///         <summary>To be added.</summary>
		static public PKContactFields GetValue (NSSet set)
		{
			if (set is null)
				return PKContactFields.None;
			return PKContactFieldsExtensions.ToFlags (set.ToArray<NSString> ());
		}

		/// <param name="values">The values.</param>
		///         <summary>To be added.</summary>
		static public NSSet GetSet (PKContactFields values)
		{
			return new NSMutableSet (values.ToArray ());
		}
	}

	public partial class PKPaymentRequest {
		/// <summary>Gets or sets the required billing contact fields.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public PKContactFields RequiredBillingContactFields {
			get { return PKContactFieldsExtensions.GetValue (WeakRequiredBillingContactFields); }
			set { WeakRequiredBillingContactFields = PKContactFieldsExtensions.GetSet (value); }
		}

		/// <summary>Gets or sets the required shipping contact fields.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public PKContactFields RequiredShippingContactFields {
			get { return PKContactFieldsExtensions.GetValue (WeakRequiredShippingContactFields); }
			set { WeakRequiredShippingContactFields = PKContactFieldsExtensions.GetSet (value); }
		}
	}
}
