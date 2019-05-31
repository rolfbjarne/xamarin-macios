using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.Build.Tasks;
using System.Xml.Linq;

using F = System.IO.File;

namespace Xamarin.MacDev.Tasks
{
	public abstract class WriteItemsToFileBase : Task
	{
		static readonly XNamespace XmlNs = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");

		static readonly XName ProjectElementName = XmlNs + "Project";
		static readonly XName ItemGroupElementName = XmlNs + "ItemGroup";
		const string IncludeAttributeName = "Include";

		#region Inputs

		public string SessionId { get; set; }

		public ITaskItem[] Items { get; set; }
        
		public string ItemName { get; set; }

		[Output]
		[Required]
		public ITaskItem File { get; set; }

		public bool Overwrite { get; set; }

		public bool IncludeMetadata { get; set; }

		public bool CompareContents { get; set; } = true; // FIXME

		#endregion

		public override bool Execute ()
		{
			var items = this.Items;
			if (items == null)
				items = new ITaskItem[0];

			var document = new XDocument (
				new XElement (ProjectElementName,
					new XElement (ItemGroupElementName,
						items.Select (item => this.CreateElementFromItem(item)))));

			var filename = File.ItemSpec;
			if (!Overwrite && F.Exists (filename)) {
				Log.LogError ($"Target file {filename} already exists.");
				return false;
			}

			Directory.CreateDirectory (Path.GetDirectoryName (filename));

			if (CompareContents) {
				var tmpfile = filename + ".tmp";
				document.Save (tmpfile);
				if (F.Exists (filename)) {
					if (F.ReadAllText (tmpfile) == F.ReadAllText (filename)) {
						Log.LogMessage ($"Did not write to {filename} because it didn't change.");
						F.Delete (tmpfile);
						return true;
					} else {
						Log.LogMessage ($"Saving to {filename} (target is different).");
						Log.LogMessage ("Before:");
						Log.LogMessage (F.ReadAllText (filename));
						Log.LogMessage ("After:");
						Log.LogMessage (F.ReadAllText (tmpfile));
					}
					F.Copy /* FIXME */ (filename, filename + ".previous", true);
					F.Delete (filename);
				} else {
					Log.LogMessage ($"Saving to {filename} (target does not exist).");
				}
				F.Move (tmpfile, filename);
			} else {
				if (F.Exists (filename))
					F.Delete (filename);
				document.Save (filename);
				Log.LogMessage ($"Saving to {filename} (not comparing content).");
			}
			Log.LogMessage ($"Saved to {filename}.");

			return true;
		}

		private XElement CreateElementFromItem (ITaskItem item)
		{
			return new XElement (XmlNs + ItemName,
				new XAttribute (IncludeAttributeName, item.ItemSpec),
					this.CreateMetadataFromItem (item));
		}

		private IEnumerable<XElement> CreateMetadataFromItem (ITaskItem item)
		{
			if (this.IncludeMetadata) {
				var metadata = item.CloneCustomMetadata();

				return metadata.Keys
					.OfType<object> ()
					.Select (key => new XElement (XmlNs + key.ToString (), metadata[key].ToString ()));
			}

			return Enumerable.Empty<XElement> ();
		}
	}
}