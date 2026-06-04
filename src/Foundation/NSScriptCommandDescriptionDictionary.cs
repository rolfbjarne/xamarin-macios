// Copyright 2015 Xamarin, Inc.

namespace Foundation {

#if MONOMAC || __MACCATALYST__

	/// <summary>Gets or sets the n s script command description dictionary keys.</summary>
	public static class NSScriptCommandDescriptionDictionaryKeys {
		private static NSString cmdClass = new NSString ("CommandClass");
		/// <summary>Gets or sets the command class key.</summary>
		public static NSString CommandClassKey {
			get { return cmdClass; }
		}

		/// <summary>Gets or sets the apple event code key.</summary>
		public static NSString AppleEventCodeKey {
			get { return NSScriptCommonKeys.AppleEventCodeKey; }
		}

		private static NSString codeClass = new NSString ("AppleEventClassCode");
		/// <summary>Gets or sets the apple event class code key.</summary>
		public static NSString AppleEventClassCodeKey {
			get { return codeClass; }
		}

		/// <summary>Gets or sets the type key.</summary>
		public static NSString TypeKey {
			get { return NSScriptCommonKeys.TypeKey; }
		}

		private static NSString resultAppEventCode = new NSString ("ResultAppleEventCode");
		/// <summary>Gets or sets the result apple event code key.</summary>
		public static NSString ResultAppleEventCodeKey {
			get { return resultAppEventCode; }
		}

		private static NSString args = new NSString ("Arguments");
		/// <summary>Gets or sets the arguments key.</summary>
		public static NSString ArgumentsKey {
			get { return args; }
		}
	}

	/// <summary>To be added.</summary>
	public partial class NSScriptCommandDescriptionDictionary {

		/// <param name="arg">The arg.</param>
		///         <summary>Add.</summary>
		public void Add (NSScriptCommandArgumentDescription arg)
		{
			if (arg is null)
				throw new ArgumentNullException ("arg");
			if (Arguments is null)
				Arguments = new NSMutableDictionary ();
			using (var nsName = new NSString (arg.Name)) {
				Arguments.Add (nsName, arg.Dictionary);
			}
		}

		/// <param name="arg">The arg.</param>
		///         <summary>Remove.</summary>
		public bool Remove (NSScriptCommandArgumentDescription arg)
		{
			if (arg is null)
				throw new ArgumentNullException ("arg");
			using (var nsName = new NSString (arg.Name)) {
				return Arguments?.Remove (nsName) ?? false;
			}
		}
	}

#endif

}
