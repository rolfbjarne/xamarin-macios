using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.Macios.Generator.Context;

namespace Microsoft.Macios.Generator.Emitters;

class ClassEmitter (ClassBindingContext context, TabbedStringBuilder builder) : ICodeEmitter {
	public string SymbolName => context.SymbolName;

	public bool TryEmit ([NotNullWhen (false)] out ImmutableArray<Diagnostic>? diagnostics)
	{

		builder.AppendLine ();
		diagnostics = null;
		// add the namespace and the class declaration
		using (var namespaceBlock = builder.CreateBlock ($"namespace {context.Namespace}", true)) {
			using (var classBlock = namespaceBlock.CreateBlock ($"public partial class {SymbolName}", true)) {
				classBlock.AppendLine ("// TODO: add binding code here");
			}
		}
		return true;
	}
}
