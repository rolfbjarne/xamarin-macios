﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.Build.Tasks;
using System.Xml.Linq;

namespace Xamarin.MacDev.Tasks
{
	public abstract class ReadItemsFromFileBase : Task
	{
		static readonly XNamespace XmlNs = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");

		static readonly XName ItemGroupElementName = XmlNs + "ItemGroup";
		const string IncludeAttributeName = "Include";

		#region Inputs

		public string SessionId { get; set; }

		[Output]
		[Required]
		public ITaskItem File { get; set; }

		// A directory whose contents will be listed, and stored into the specified TargetVariable
		// I couldn't figure out how to do this in the .targets file's xml after the call to
		// this target, so I ended up adding it here instead.
		public ITaskItem ListDirectory { get; set; }
		public ITaskItem ListDirectoryTargetVariable { get; set; }

		#endregion

		#region Outputs

		[Output]
		public ITaskItem[] Items { get; set; }

		#endregion

		public override bool Execute ()
		{
			var document = XDocument.Load (this.File.ItemSpec);

			this.Items = document.Root
				.Elements (ItemGroupElementName)
				.SelectMany (element => element.Elements ())
				.Select (element => this.CreateItemFromElement (element))
				.ToArray ();

			return true;
		}

		private ITaskItem CreateItemFromElement (XElement element)
		{
			var item = new TaskItem (element.Attribute (IncludeAttributeName).Value);

			foreach (var metadata in element.Elements ()) {
				item.SetMetadata (metadata.Name.LocalName, metadata.Value);
			}

			if (ListDirectory != null) {
				var files = Directory.GetFiles (ListDirectory.ItemSpec);
				item.SetMetadata (ListDirectoryTargetVariable.ItemSpec, string.Join (";", files));
			}

			return item;
		}
	}
}