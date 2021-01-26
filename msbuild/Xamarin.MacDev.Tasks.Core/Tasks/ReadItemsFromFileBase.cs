using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.Build.Tasks;
using System.Xml.Linq;

namespace Xamarin.MacDev.Tasks
{
	public abstract class ReadItemsFromFileBase : XamarinTask
	{
		static readonly XNamespace XmlNs = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");

		static readonly XName ItemGroupElementName = XmlNs + "ItemGroup";
		const string IncludeAttributeName = "Include";

		#region Inputs

		[Required]
		public ITaskItem File { get; set; }

		#endregion

		#region Outputs

		// Also input
		[Output]
		public ITaskItem[] Items { get; set; }

		#endregion

		public override bool Execute ()
		{
			var document = XDocument.Load (this.File.ItemSpec);

			var items = document.Root
				.Elements (ItemGroupElementName)
				.SelectMany (element => element.Elements ())
				.Select (element => this.CreateItemFromElement (element))
				.ToArray ();

			if (Items == null) {
				Items = items;
			} else {
				// Merge the created items into the existing array of items
				// - If the item exists (based on ItemSpec), then copy the metadata into the existing item
				// - If the item does not exist, return the entire item
				var itemsMap = Items.ToDictionary (item => item.ItemSpec);
				var finalItems = new List<ITaskItem> ();
				foreach (var newItem in items) {
					if (itemsMap.TryGetValue (newItem.ItemSpec, out var existingItem)) {
						newItem.CopyMetadataTo (existingItem);
						finalItems.Add (existingItem);
					} else {
						finalItems.Add (newItem);
					}
				}
				Items = finalItems.ToArray ();
			}

			return true;
		}

		private ITaskItem CreateItemFromElement (XElement element)
		{
			var item = new TaskItem (element.Attribute (IncludeAttributeName).Value);

			foreach (var metadata in element.Elements ()) {
				item.SetMetadata (metadata.Name.LocalName, metadata.Value);
			}

			return item;
		}
	}
}
