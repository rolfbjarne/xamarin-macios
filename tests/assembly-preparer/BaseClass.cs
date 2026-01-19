namespace AssemblyPreparerTests;

public abstract class BaseClass {
	public void AssertPrepare (AssemblyPreparer preparer)
	{
		if (!preparer.Prepare (out var exceptions))
			Assert.Fail ($"Prepare failed, excepetions:\n\t{string.Join ("\n\t", exceptions.Select (v => v.ToString ()))}");
		Assert.That (exceptions, Is.Empty, "Exceptions");
	}
}
