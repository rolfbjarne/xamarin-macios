using System;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Net.NetworkInformation;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev.Tasks;
using Xamarin.MacDev;
using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class DetectDebugNetworkConfiguration : XamarinTask, ICancelableTask {
		#region Inputs

		[Required]
		public bool DebugOverWiFi { get; set; }

		public string DebuggerHosts { get; set; }

		[Required]
		public bool SdkIsSimulator { get; set; }

		#endregion

		#region Outputs

		[Output]
		public string DebugIPAddresses { get; set; }

		#endregion


		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			if (SdkIsSimulator) {
				DebugIPAddresses = IPAddress.Loopback.ToString ();
			} else if (DebugOverWiFi) {
				var ips = new List<string> ();
				string [] hosts = null;

				if (!string.IsNullOrEmpty (DebuggerHosts))
					hosts = DebuggerHosts.Split (new [] { ';' }, StringSplitOptions.RemoveEmptyEntries);

				if (hosts is null || hosts.Length == 0) {
					var properties = IPGlobalProperties.GetIPGlobalProperties ();
					var hostName = properties.HostName;

					try {
						var entry = Dns.GetHostEntry (hostName);

						ips.AddRange (entry.AddressList.Select (v => v.ToString ()));
					} catch {
						using (var socket = new Socket (SocketType.Dgram, ProtocolType.Udp)) {
							try {
								socket.Connect ("8.8.8.8", 53);

								var ipEndPoint = (IPEndPoint) socket.LocalEndPoint;

								ips.Add (ipEndPoint.Address.ToString ());
							} catch {
								Log.LogError (7001, null, MSBStrings.E7001);
								return false;
							}
						}
					}
				} else {
					foreach (var host in hosts) {
						IPAddress ip;

						if (IPAddress.TryParse (host, out ip))
							ips.Add (ip.ToString ());
					}
				}

				if (ips is null || ips.Count == 0) {
					Log.LogError (7002, null, MSBStrings.E7002);
					return false;
				}

				DebugIPAddresses = string.Join (";", ips);
			}

			Log.LogTaskProperty ("DebugIPAddresses", DebugIPAddresses);

			return !Log.HasLoggedErrors;
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
