#nullable enable

namespace CoreTelephony {

	public partial class CTCall {
#if !COREBUILD
		/// <summary>Gets or sets the state dialing.</summary>
		public string? StateDialing {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateDialing");
			}
		}

		/// <summary>Gets or sets the state incoming.</summary>
		public string? StateIncoming {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateIncoming");
			}
		}

		/// <summary>Gets or sets the state connected.</summary>
		public string? StateConnected {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateConnected");
			}
		}

		/// <summary>Gets or sets the state disconnected.</summary>
		public string? StateDisconnected {
			get {
				return Dlfcn.SlowGetStringConstant (Constants.CoreTelephonyLibrary, "CTCallStateDisconnected");
			}
		}
#endif // !COREBUILD
	}
}
