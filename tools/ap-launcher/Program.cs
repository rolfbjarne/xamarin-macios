using Xamarin.Build;
using Xamarin.Bundler;

class Program {
	public static int Main(string[] args)
	{	
		var optionsFile = args.Single (v => v.StartsWith ("--options-file=")).Substring("--options-file=".Length);
		var makeReproPath = args.SingleOrDefault (v => v.StartsWith ("--make-repro-path="))?.Substring("--make-repro-path=".Length) ?? "";

		var api = new List<AssemblyPreparerInfo> ();
		foreach (var inputArgs in args.Where (v => v.StartsWith ("--input-assembly=")).Select (v => v.Substring("--input-assembly=".Length))) {
			var ia = inputArgs.Split ('|');
			var inputPath = ia.Single (v => v.StartsWith ("InputPath="))?.Substring("InputPath=".Length) ?? throw new InvalidOperationException ("InputPath is required");
			var outputPath = ia.Single (v => v.StartsWith ("OutputPath="))?.Substring("OutputPath=".Length) ?? throw new InvalidOperationException ("OutputPath is required");
			var isTrimmableString = ia.Single (v => v.StartsWith ("IsTrimmable="))?.Substring("IsTrimmable=".Length);
			var isTrimmable = string.IsNullOrEmpty (isTrimmableString) ? (bool?) null : string.Equals (isTrimmableString, "true", StringComparison.OrdinalIgnoreCase);
			var trimMode = ia.Single (v => v.StartsWith ("TrimMode="))?.Substring("TrimMode=".Length) ?? "";

			api.Add (new AssemblyPreparerInfo (inputPath, outputPath, isTrimmable, trimMode));
		}

		var infos = api.ToArray ();
		var logger = new TestLogger ();
		using var preparer = new AssemblyPreparer (logger, infos, optionsFile);
		preparer.MakeReproPath = makeReproPath ?? "";
		var rv = preparer.Prepare (out var exceptions);
		
		return 0;
	}
}

class TestLogger : IToolLog
{
	public int Verbosity => 0;

	public void Log (string value)
	{
		Console.WriteLine (value);
	}

	public void Log (string format, params object? [] args)
	{
		Console.WriteLine (format, args);
	}

	public void LogException (Exception ex)
	{
		Console.WriteLine (ex.ToString());
	}
	
	public void LogError (ProductException ex)
	{
		Console.WriteLine (ex.ToString());
	}

	public void LogWarning (ProductException ex)
	{
		Console.WriteLine (ex.ToString());
	}
}
