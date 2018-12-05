using System;
using Foundation;
using ObjCRuntime;

namespace BI1064
{
	[BaseType (typeof (NSObject))]
	interface C
	{
		[Export ("testINativeObject:a:")]
		void TestINativeObject (ref INativeObject refValue, out INativeObject outValue);

		[Export ("testINSCoding:a:")]
		void TestINSCoding (ref INSCoding refValue, out INSCoding outValue);

		[Export ("testNSObject:a:")]
		void TestNSObject (ref NSObject refValue, out NSObject outValue);

		[Export ("testNSValue:a:")]
		void TestValue (ref NSValue refValue, out NSValue outValue);

		[Export ("testString:a:")]
		void TestString (ref string refValue, out string outValue);

		[Export ("testDateTime:a:")]
		void TestDateTime (ref DateTime refValue, out DateTime outValue);

		[Export ("testInt:a:")]
		void TestInt (ref int refValue, out int outValue);


		[Export ("testINativeObjectArray:a:")]
		void TestINativeObjectArray (ref INativeObject[] refValues, out INativeObject[] outValues);

		[Export ("testINSCodingArray:a:")]
		void TestINSCodingArray (ref INSCoding[] refValues, out INSCoding[] outValues);

		[Export ("testNSObjectArray:a:")]
		void TestNSObjectArray (ref NSObject[] refValues, out NSObject[] outValues);

		[Export ("testNSValueArray:a:")]
		void TestNSValueArray (ref NSValue[] refValues, out NSValue[] outValues);

		[Export ("testStringArray:a:")]
		void TestStringArray (ref string[] refStrings, out string[] outStrings);
	}
}
