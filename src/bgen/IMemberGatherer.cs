using System.Reflection;

#nullable enable

public interface IMemberGatherer {
	MethodInfo [] GetTypeContractMethods (Type source);
}
