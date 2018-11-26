using System;
using Foundation;

namespace NS
{
	[BaseType (typeof (NSObject))]
	interface C
	{
		[Export ("string")]
		void (ref string refString, out string outString);

		[Export ("nsarray")]
		void (ref NSValue[] refValues, out NSValue[] outValues);

		[Export ("stringarray")]
		void (ref string[] refStrings, out string[] outStrings);


	}

	[BaseType (typeof (NSObject))]
	interface RefO
	{
	}

	[Model]
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface P
	{
	}
}