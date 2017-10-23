using System;

using NUnit.Framework;

public abstract class BaseTester
{
	public virtual string Repository { get; protected set; }

	[SetUp]
	public void Setup ()
	{
		var samplerepo = Environment.GetEnvironmentVariable ("XAMARIN_SAMPLEREPOSITORY");
		if (!string.IsNullOrEmpty (samplerepo) && !string.Equals (Repository, samplerepo, StringComparison.OrdinalIgnoreCase))
			Assert.Ignore ($"This repository has been ignored, because it doesn't match the XAMARIN_SAMPLEREPOSITORY environment variable ({samplerepo}).");
	}
}
