using Xamarin.Messaging.Build.Client;

namespace Xamarin.iOS.Tasks {
	public class CreateAssetPack : CreateAssetPackTaskBase {
		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			return base.Execute ();
		}

		public override void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (SessionId, BuildEngine4).Wait ();

			base.Cancel ();
		}
	}
}
