using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev;
using Xamarin.Messaging.Build.Client;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace Xamarin.MacDev.Tasks {
	public class TextureAtlas : XcodeToolTaskBase, ICancelableTask {
		readonly Dictionary<string, List<ITaskItem>> atlases = new Dictionary<string, List<ITaskItem>> ();

		#region Inputs

		public ITaskItem [] AtlasTextures { get; set; }

		#endregion

		protected override string DefaultBinDir {
			get { return DeveloperRootBinDir; }
		}

		protected override string ToolName {
			get { return "TextureAtlas"; }
		}

		protected override void AppendCommandLineArguments (IDictionary<string, string> environment, CommandLineBuilder args, ITaskItem input, ITaskItem output)
		{
			Log.LogMessage ($"TextureAtlas.AppendCommandLineArguments ({input.ItemSpec}, {output.ItemSpec}) => {input.GetMetadata ("FullPath")} {output.GetMetadata ("FullPath")}");
			args.AppendFileNameIfNotNull (input.GetMetadata ("FullPath"));
			args.AppendFileNameIfNotNull (Path.GetDirectoryName (output.GetMetadata ("FullPath")));
		}

		protected override string GetBundleRelativeOutputPath (IList<string> prefixes, ITaskItem input)
		{
			// Note: if the relative input dir is "relative/texture.atlas", then the relative output path will be "relative/texture.atlasc"
			var rv = Path.ChangeExtension (base.GetBundleRelativeOutputPath (prefixes, input), ".atlasc");
			Log.LogMessage ($"TextureAtlas.GetBundleRelativeOutputPath ({input.ItemSpec}) => {rv}");
			return rv;
		}

		protected override IEnumerable<ITaskItem> GetCompiledBundleResources (ITaskItem input, ITaskItem output)
		{
			var bundleDir = output.GetMetadata ("LogicalName");

			if (!Directory.Exists (output.ItemSpec))
				yield break;

			foreach (var file in Directory.GetFiles (output.ItemSpec)) {
				var fileName = Path.GetFileName (file);

				var relative = Path.Combine (output.ItemSpec, fileName);
				var logical = Path.Combine (bundleDir, fileName);
				var item = new TaskItem (relative);
				item.SetMetadata ("LocalDefiningProjectFullPath", input.GetMetadata ("LocalDefiningProjectFullPath"));
				item.SetMetadata ("LocalMSBuildProjectFullPath", input.GetMetadata ("LocalMSBuildProjectFullPath"));

				item.SetMetadata ("LogicalName", logical);
				item.SetMetadata ("Optimize", "false");

				Log.LogMessage ($"TextureAtlas.GetCompiledBundleResources ({input.ItemSpec}, {output.ItemSpec}) => {item.ItemSpec} LogicalName={logical}");

				yield return item;
			}

			yield break;
		}

		protected override bool NeedsBuilding (ITaskItem input, ITaskItem output)
		{
			var plist = Path.Combine (output.ItemSpec, Path.GetFileNameWithoutExtension (input.ItemSpec) + ".plist");

			if (!File.Exists (plist))
				return true;

			var items = atlases [input.ItemSpec];

			foreach (var item in items) {
				if (File.GetLastWriteTimeUtc (item.ItemSpec) > File.GetLastWriteTimeUtc (plist))
					return true;
			}

			return false;
		}

		protected override IEnumerable<ITaskItem> EnumerateInputs ()
		{
			if (AtlasTextures is null)
				yield break;

			// group the atlas textures by their parent .atlas directories
			foreach (var item in AtlasTextures) {
				var vpp = BundleResource.GetVirtualProjectPath (this, ProjectDir, item);
				var atlas = Path.GetDirectoryName (vpp);
				var logicalName = item.GetMetadata ("LogicalName");
				List<ITaskItem> items;
				Log.LogMessage ($"TextureAtlas.Processing atlas {item.ItemSpec} with LogicalName={logicalName} VirtualProjectPath={vpp} and atlas name {atlas}");

				if (!atlases.TryGetValue (atlas, out items)) {
					items = new List<ITaskItem> ();
					atlases.Add (atlas, items);
					Log.LogMessage ($"    => created new atlas {atlas}");
				} else {
					Log.LogMessage ($"    => added to atlas {atlas}");
				}

				items.Add (item);
			}

			foreach (var atlas in atlases.Keys)
				yield return new TaskItem (atlas);

			yield break;
		}

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			return base.Execute ();
		}

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
