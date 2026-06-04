#nullable enable

#if !MONOMAC

namespace NetworkExtension {

	public partial class NEFilterProvider {

		// not fields, but defines :|
		// we bind them like [Field]s so, if they ever get done properly, then it won't be a breaking change

		static NSString? _RemediationURLFlowURL;
		static NSString? _RemediationURLFlowURLHostname;
		static NSString? _RemediationURLOrganization;
		static NSString? _RemediationURLUsername;

		/// <summary>Gets or sets the remediation url flow url.</summary>
		public static NSString RemediationUrlFlowUrl {
			get {
				if (_RemediationURLFlowURL is null)
					_RemediationURLFlowURL = new NSString ("NE_FLOW_HOSTNAME");
				return _RemediationURLFlowURL;
			}
		}

		/// <summary>Gets or sets the remediation url flow url hostname.</summary>
		public static NSString RemediationUrlFlowUrlHostname {
			get {
				if (_RemediationURLFlowURLHostname is null)
					_RemediationURLFlowURLHostname = new NSString ("NE_FLOW_URL");
				return _RemediationURLFlowURLHostname;
			}
		}

		/// <summary>Gets or sets the remediation url organization.</summary>
		public static NSString RemediationUrlOrganization {
			get {
				if (_RemediationURLOrganization is null)
					_RemediationURLOrganization = new NSString ("NE_ORGANIZATION");
				return _RemediationURLOrganization;
			}
		}

		/// <summary>Gets or sets the remediation url username.</summary>
		public static NSString RemediationUrlUsername {
			get {
				if (_RemediationURLUsername is null)
					_RemediationURLUsername = new NSString ("NE_USERNAME");
				return _RemediationURLUsername;
			}
		}
	}
}

#endif
