namespace Mono.Linker;

using Mono.Cecil;

public interface IMarkHandler {
	void Initialize (LinkContext context, MarkContext markContext);
}
