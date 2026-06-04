#nullable enable

namespace CoreTelephony {

	public partial class CTCall {
#if !COREBUILD
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public string? StateDialing {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateDialing");
			}
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public string? StateIncoming {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateIncoming");
			}
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public string? StateConnected {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateConnected");
			}
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public string? StateDisconnected {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateDisconnected");
			}
		}
#endif // !COREBUILD
	}
}
