#if NET

using ObjCRuntime;

#nullable enable

namespace FSKit {
	public partial class FSTaskOptionsBundle {
		/// <summary>Create a new <see cref="FSTaskOptionsBundle" /> instance using the specified arguments.</summary>
		/// <param name="arguments">The arguments to process when creating the bundle.</param>
		/// <param name="extensionId">The identifier of the extension whose parameters are being processed.</param>
		/// <param name="taskType">The type of the task.</param>
		/// <param name="errorHandler">The callback that will be called in case of errors.</param>
		public static FSTaskOptionsBundle Create (string[] arguments, string extensionId, FSTaskType taskType, FSTaskOptionsBundleCreateErrorHandler errorHandler)
		{
			var argv = TransientString.AllocStringArray (arguments);
			try {
				return _Create (argv, arguments.Length, extensionId, taskType, errorHandler);
			} finally {
				TransientString.FreeStringArray (argv, arguments.Length);
			}
		}
	}
}
#endif // NET
