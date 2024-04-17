using System;
using Foundation;
using ObjCRuntime;

namespace Protocols {
	[Protocol]
	interface OptionalProtocolCompat {
		[Export ("optionalMethod")]
		int OptionalMethod ();

		[Export ("optionalProperty")]
		int OptionalProperty { get; set; }

		[Internal]
		[Export ("internalOptionalMethod")]
		int InternalOptionalMethod ();

		[Internal]
		[Export ("internalOptionalProperty")]
		int InternalOptionalProperty { get; set; }

		[Static]
		[Export ("staticOptionalMethod")]
		int StaticOptionalMethod ();

		[Static]
		[Export ("staticOptionalProperty")]
		int StaticOptionalProperty { get; set; }

		[Export ("optionalPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject OptionalPropertyWeakSemantics { get; set; }

		[Static]
		[Export ("staticOptionalPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject StaticOptionalPropertyWeakSemantics { get; set; }
	}

	[Protocol]
	interface RequiredProtocolCompat {
		[Abstract]
		[Export ("requiredMethod")]
		int RequiredMethod ();

		[Abstract]
		[Export ("requiredProperty")]
		int RequiredProperty { get; set; }

		[Abstract]
		[Internal]
		[Export ("internalRequiredMethod")]
		int InternalRequiredMethod ();

		[Abstract]
		[Internal]
		[Export ("internalRequiredProperty")]
		int InternalRequiredProperty { get; set; }

		[Abstract]
		[Static]
		[Export ("staticRequiredMethod")]
		int StaticRequiredMethod ();

		[Abstract]
		[Static]
		[Export ("staticRequiredProperty")]
		int StaticRequiredProperty { get; set; }

		[Abstract]
		[Export ("requiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject RequiredPropertyWeakSemantics { get; set; }

		[Abstract]
		[Static]
		[Export ("staticRequiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject StaticRequiredPropertyWeakSemantics { get; set; }
	}

	[Protocol]
	interface RequiredProtocolCompatWithExtensions {
		[Abstract (GenerateExtensionMethod = true)]
		[Export ("requiredMethod")]
		int RequiredMethod ();

		[Abstract (GenerateExtensionMethod = true)]
		[Export ("requiredProperty")]
		int RequiredProperty { get; set; }

		[Abstract (GenerateExtensionMethod = true)]
		[Internal]
		[Export ("internalRequiredMethod")]
		int InternalRequiredMethod ();

		[Abstract (GenerateExtensionMethod = true)]
		[Internal]
		[Export ("internalRequiredProperty")]
		int InternalRequiredProperty { get; set; }

		[Abstract (GenerateExtensionMethod = true)]
		[Static]
		[Export ("staticRequiredMethod")]
		int StaticRequiredMethod ();

		[Abstract (GenerateExtensionMethod = true)]
		[Static]
		[Export ("staticRequiredProperty")]
		int StaticRequiredProperty { get; set; }

		[Abstract (GenerateExtensionMethod = true)]
		[Export ("requiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject RequiredPropertyWeakSemantics { get; set; }

		[Abstract (GenerateExtensionMethod = true)]
		[Static]
		[Export ("staticRequiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject StaticRequiredPropertyWeakSemantics { get; set; }
	}

	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface OptionalProtocol {
		[Export ("optionalMethod")]
		int OptionalMethod ();

		[Export ("optionalProperty")]
		int OptionalProperty { get; set; }

		[Internal]
		[Export ("internalOptionalMethod")]
		int InternalOptionalMethod ();

		[Internal]
		[Export ("internalOptionalProperty")]
		int InternalOptionalProperty { get; set; }

		[Static]
		[Export ("staticOptionalMethod")]
		int StaticOptionalMethod ();

		[Static]
		[Export ("staticOptionalProperty")]
		int StaticOptionalProperty { get; set; }

		[Export ("optionalPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject OptionalPropertyWeakSemantics { get; set; }

		[Static]
		[Export ("staticOptionalPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject StaticOptionalPropertyWeakSemantics { get; set; }
	}

	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface RequiredProtocol {
		[Abstract]
		[Export ("requiredMethod")]
		int RequiredMethod ();

		[Abstract]
		[Export ("requiredProperty")]
		int RequiredProperty { get; set; }

		[Abstract]
		[Internal]
		[Export ("internalRequiredMethod")]
		int InternalRequiredMethod ();

		[Abstract]
		[Internal]
		[Export ("internalRequiredProperty")]
		int InternalRequiredProperty { get; set; }

		[Abstract]
		[Static]
		[Export ("staticRequiredMethod")]
		int StaticRequiredMethod ();

		[Abstract]
		[Static]
		[Export ("staticRequiredProperty")]
		int StaticRequiredProperty { get; set; }

		[Abstract]
		[Export ("requiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject RequiredPropertyWeakSemantics { get; set; }

		[Abstract]
		[Static]
		[Export ("staticRequiredPropertyWeakSemantics", ArgumentSemantic.Weak)]
		NSObject StaticRequiredPropertyWeakSemantics { get; set; }
	}

	[BaseType (typeof (NSObject))]
	interface MyObject : OptionalProtocol, RequiredProtocol {
	}

	[BaseType (typeof (NSObject))]
	interface MyObject2 : OptionalProtocolCompat, RequiredProtocolCompat {
	}
}
