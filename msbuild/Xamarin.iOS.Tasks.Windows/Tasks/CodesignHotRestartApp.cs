using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Xamarin.iOS.Tasks.Windows.Properties;
using Xamarin.iOS.Windows;

namespace Xamarin.iOS.HotRestart.Tasks {
	public class CodesignHotRestartApp : Task, ICancelableTask {
		#region Inputs

		[Required]
		public string AppBundlePath { get; set; }

		[Required]
		public string BundleIdentifier { get; set; }

		[Required]
		public string CodeSigningPath { get; set; }

		[Required]
		public string ProvisioningProfilePath { get; set; }

		#endregion

		public override bool Execute ()
		{
			try {
				Log.LogWarning ("A");
				var hotRestartClient = new HotRestartClient ();
				Log.LogWarning ("B");
				var plistArgs = new Dictionary<string, string>
				{
					{ "CFBundleIdentifier", BundleIdentifier }
				};
				Log.LogWarning ("C");
				var password = hotRestartClient.CertificatesManager.GetCertificatePassword (certificatePath: CodeSigningPath);
				Log.LogWarning ("D");

				if (password == null) {
					Log.LogWarning ("D2");
					throw new Exception (Resources.Codesign_MissingPasswordFile);
				}

				Log.LogWarning ("E");
				hotRestartClient.Sign (AppBundlePath, ProvisioningProfilePath, CodeSigningPath, password, plistArgs);

				Log.LogWarning ("F");
			} catch (WindowsiOSException ex) {
				Log.LogWarning ("G");
				var message = GetFullExceptionMesage (ex);
				Log.LogWarning ("H");

				Log.LogError (null, ex.ErrorCode, null, null, 0, 0, 0, 0, message);
			}

			Log.LogWarning ("I");

			return !Log.HasLoggedErrors;
		}

		public void Cancel ()
		{
		}

		string GetFullExceptionMesage (Exception ex)
		{
			var messageBuilder = new StringBuilder ();

			return GetFullExceptionMesage (ex, messageBuilder);
		}

		string GetFullExceptionMesage (Exception ex, StringBuilder messageBuilder)
		{
			messageBuilder.AppendLine (ex.Message);

			if (ex.InnerException != null) {
				return GetFullExceptionMesage (ex.InnerException, messageBuilder);
			} else {
				return messageBuilder.ToString ();
			}
		}
	}
}
