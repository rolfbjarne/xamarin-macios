using System;

using NUnit.Framework;

public abstract class BaseTester
{
	public string Repository { get; private set; }

	protected BaseTester (string repository)
	{
		Repository = repository;
	}
}
