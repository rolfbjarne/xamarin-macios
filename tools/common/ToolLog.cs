// namespace Xamarin.Bundler;

// public interface IToolLog {
// 	int Verbosity { get; }
// 	void Log (string value);
// 	void Log (string format, params object? [] args);

// #if NET
// 	void Log (int min_verbosity, string value)
// 	{
// 		if (min_verbosity > Verbosity)
// 			return;

// 		Log (value);
// 	}

// 	void Log (int min_verbosity, string format, params object? [] args)
// 	{
// 		if (min_verbosity > Verbosity)
// 			return;

// 		Log (format, args);
// 	}

// 	void LogException (Exception ex)
// 	{
// 		Log ($"Unexpected exception: {ex}");
// 	}

// 	void LogError (ProductException ex)
// 	{
// 		Log ($"Error: {ex}");
// 	}

// 	void LogWarning (ProductException ex)
// 	{
// 		Log ($"Warning: {ex}");
// 	}
// #endif
// }

// #if !NET
// public static class ILoggerExtensions {
// 	public static void Log (this IToolLog log, int min_verbosity, string value)
// 	{
// 		if (min_verbosity > log.Verbosity)
// 			return;

// 		log.Log (value);
// 	}

// 	public static void Log (this IToolLog log, int min_verbosity, string format, params object? [] args)
// 	{
// 		if (min_verbosity > log.Verbosity)
// 			return;

// 		log.Log (format, args);
// 	}

// 	public static void LogException (this IToolLog log, Exception ex)
// 	{
// 		Log (log, 0, $"Unexpected exception: {ex}");
// 	}

// 	public static void LogError (this IToolLog log, ProductException ex)
// 	{
// 		Log (log, 0, $"Error: {ex}");
// 	}

// 	public static void LogWarning (this IToolLog log, ProductException ex)
// 	{
// 		Log (log, 0, $"Warning: {ex}");
// 	}
// }
// #endif
