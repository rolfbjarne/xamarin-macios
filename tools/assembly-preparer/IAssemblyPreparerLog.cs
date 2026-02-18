using System;
using Xamarin.Bundler;

namespace Xamarin.Build;

public interface IAssemblyPreparerLog {
	void Log (string message);
}

public class ConsoleLog : IAssemblyPreparerLog {
	public void Log (string message)
	{
		Console.WriteLine (message);
	}
}

class AggregateLog : IAssemblyPreparerLog {
	List<IAssemblyPreparerLog> logs = new ();

	public void Add (IAssemblyPreparerLog log)
	{
		logs.Add (log);
	}

	public void Log (string message)
	{
		foreach (var log in logs)
			log.Log (message);
	}
}
