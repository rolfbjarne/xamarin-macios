using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public class OneToManyItems : Task {
		[Required]
		public ITaskItem [] Items { get; set; } = Array.Empty<ITaskItem> ();

		[Output]
		public ITaskItem [] OutputItems { get; set; } = Array.Empty<ITaskItem> ();

		public override bool Execute ()
		{
			var output = new List<ITaskItem> ();
			foreach (var item in Items) {
				foreach (var i in item.ItemSpec.Split (' '))
					output.Add (new TaskItem (i));
			}
			OutputItems = output.ToArray ();
			return true;
		}
	}
}
