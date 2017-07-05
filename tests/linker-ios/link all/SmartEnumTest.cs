//
// Preserve tests
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2016 Xamarin Inc. All rights reserved.
//

using System;
using System.Reflection;
#if XAMCORE_2_0
using Foundation;
using ObjCRuntime;
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
#endif
using NUnit.Framework;

namespace LinkAll.Attributes
{

	public enum SmartEnum : int
	{
		Smart = 0,
	}

	public static class SmartEnumExtensions
	{
		public static NSString GetConstant (this SmartEnum self)
		{
			switch (self) {
			case SmartEnum.Smart:
				return (NSString) "Smart";
			default:
				return null;
			}
		}

		public static SmartEnum GetValue (NSString constant)
		{
			if (constant == null)
				throw new ArgumentNullException (nameof (constant));
			switch ((string) constant) {
			case "Smart":
				return SmartEnum.Smart;
			}
			throw new NotSupportedException ();
		}
	}

	public enum NotSmartEnum : int
	{
		NotSmart = 0,
	}

	public static class NotSmartEnumExtensions
	{
		public static NSString GetConstant (this NotSmartEnum self)
		{
			switch (self) {
			case NotSmartEnum.NotSmart:
				return (NSString) "NotSmart";
			default:
				return null;
			}
		}

		public static NotSmartEnum GetValue (NSString constant)
		{
			if (constant == null)
				throw new ArgumentNullException (nameof (constant));
			switch ((string) constant) {
			case "NotSmart":
				return NotSmartEnum.NotSmart;
			}
			throw new NotSupportedException ();
		}
	}

	[Preserve] // don't preserve all members
	class SmartConsumer : NSObject
	{
		// The Smart Get/Set methods should not be linked away, and neither should the Smart enums + extensions
		[Export ("getSmartEnumValue")]
		[return: BindAs (typeof (SmartEnum), OriginalType = typeof (NSString))]
		public SmartEnum GetSmartEnumValue ()
		{
			return SmartEnum.Smart;
		}

		[Export ("setSmartEnumValue:")]
		public void SetSmartEnumValue ([BindAs (typeof (SmartEnum), OriginalType = typeof (NSString))] SmartEnum value)
		{
		}

		// The NotSmart Get/Set methods should be linked away, together with the entire NotSmart enums + extensions
		[Export ("getNotSmartEnumValue")]
		[return: BindAs (typeof (NotSmartEnum), OriginalType = typeof (NSString))]
		public NotSmartEnum GetNotSmartEnumValue ()
		{
			return NotSmartEnum.NotSmart;
		}

		[Export ("setNotSmartEnumValue:")]
		public void SetNotSmartEnumValue ([BindAs (typeof (NotSmartEnum), OriginalType = typeof (NSString))] NotSmartEnum value)
		{
		}
	}

	[TestFixture]
	// we want the tests to be available because we use the linker
	[Preserve (AllMembers = true)]
	public class SmartEnumTest
	{
		[Test]
		public void Preserved ()
		{
			var smartEnum = GetType ().Assembly.GetType ("LinkAll.Attributes.SmartEnum");
			Assert.NotNull (smartEnum, "SmartEnum");
			var smartExtensions = GetType ().Assembly.GetType ("LinkAll.Attributes.SmartEnumExtensions");
			Assert.NotNull (smartExtensions);
			Assert.NotNull (smartExtensions.GetMethod ("GetConstant"));
			Assert.NotNull (smartExtensions.GetMethod ("GetValue"));
		}

		[Test]
		public void LinkedAway ()
		{
			Assert.IsNull (GetType ().Assembly.GetType ("LinkAll.Attributes.NotSmartEnum"));
			Assert.IsNull (GetType ().Assembly.GetType ("LinkAll.Attributes.SmartEnumExtensions"));
		}
	}
}