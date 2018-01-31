﻿using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Xamarin.MacDev.Tasks
{
	public static class LoggingExtensions
	{
		const MessageImportance TaskPropertyImportance = MessageImportance.Normal;

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, ITaskItem[] items)
		{
			if (items == null) {
				log.LogMessage (TaskPropertyImportance, "  {0}: <null>", propertyName);
				return;
			}

			log.LogMessage (TaskPropertyImportance, "  {0}:", propertyName);

			for (int i = 0; i < items.Length; i++)
				log.LogMessage (TaskPropertyImportance, "    {0}", items[i].ItemSpec);
		}

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, ITaskItem item)
		{
			if (item != null)
				log.LogMessage (TaskPropertyImportance, "  {0}: {1}", propertyName, item.ItemSpec);
			else
				log.LogMessage (TaskPropertyImportance, "  {0}: ", propertyName);
		}

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, string[] items)
		{
			if (items == null) {
				log.LogMessage (TaskPropertyImportance, "  {0}: <null>", propertyName);
				return;
			}

			log.LogMessage (TaskPropertyImportance, "  {0}:", propertyName);

			for (int i = 0; i < items.Length; i++)
				log.LogMessage (TaskPropertyImportance, "    {0}", items[i]);
		}

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, string value)
		{
			log.LogMessage (TaskPropertyImportance, "  {0}: {1}", propertyName, value ?? "<null>");
		}

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, bool value)
		{
			log.LogMessage (TaskPropertyImportance, "  {0}: {1}", propertyName, value);
		}

		public static void LogTaskProperty (this TaskLoggingHelper log, string propertyName, int value)
		{
			log.LogMessage (TaskPropertyImportance, "  {0}: {1}", propertyName, value);
		}

		/// <summary>
		/// Creates an MSBuild error following our MTErrors convention.</summary>
		/// <remarks>
		/// For every new error we need to update "docs/website/mtouch-errors.md" and "tools/mtouch/error.cs".</remarks>
		/// <param name="errorCode">In the 7xxx range for MSBuild error.</param>
		/// <param name="message">The error's message to be displayed in the error pad.</param>
		/// <param name="filePath">Path to the known guilty file or MSBuild by default so we display something nice in the error pad.</param>
		public static void MTError (this TaskLoggingHelper log, int errorCode, string message, string filePath = "MSBuild")
		{
			log.LogError (null, $"MT{errorCode}", null, filePath, 0, 0, 0, 0, message);
		}
	}
}
