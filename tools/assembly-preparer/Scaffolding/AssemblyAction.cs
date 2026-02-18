namespace Mono.Linker;

public enum AssemblyAction {
	Copy,
	Link,
	Save,
	Skip,
	CopyUsed,
	AddBypassNGen,
	AddBypassNGenUsed,
	Delete,
}
