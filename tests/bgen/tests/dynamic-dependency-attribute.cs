using System;
using System.Diagnostics.CodeAnalysis;
using Foundation;
using ObjCRuntime;

namespace NS {
	[BaseType (typeof (NSObject))]
	interface MyClass {
		[Static, Export ("currentContext"), NullAllowed]
		NSObject CurrentContext {
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicConstructors, "Foundation.NSProxy", "Microsoft.macOS")]
			get;
			set;
		}

		[Export ("doSomething")]
		[DynamicDependency ("Create", "NS.MyClass", "api0")]
		void DoSomething ();
	}
}
