using System;
using System.Reflection;

using NUnit.Framework;

public abstract class BaseTester
{
	string repo;
	public virtual string Repository {
		get {
			if (repo == null)
				repo = (string) GetType ().GetField ("REPO", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue (null);
			return repo;
		}
		protected set {
			repo = value;
		}
	}

	string hash;
	public virtual string Hash {
		get {
			if (hash == null)
				hash = (string)GetType ().GetField ("HASH", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).GetValue (null);
			return hash;
		}
		protected set {
			hash = value;
		}
	}

	protected BaseTester ()
	{
	}

	protected BaseTester (string repository, string hash)
	{
		Repository = repository;
		Hash = hash;
	}
}
