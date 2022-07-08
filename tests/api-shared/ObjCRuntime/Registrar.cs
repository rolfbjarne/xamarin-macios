//
// Unit tests for the registrars.
//
// Authors:
//	Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2015 Xamarin Inc. All rights reserved.
//

using System;
using System.Reflection;
using System.Runtime.InteropServices;

using Foundation;
using ObjCRuntime;

namespace XamarinTests.ObjCRuntime {

	public enum Registrars {
		Static = 1,
		Dynamic = 4,
		AllStatic = Static,
		AllDynamic = Dynamic,
	}
		
	public class Registrar {
		[Register ("__registration_test_CLASS")]
		class RegistrationTestClass : NSObject {}

		public static Registrars CurrentRegistrar {
			get {
#if NET
				var types = new Type [] { typeof (NativeHandle), typeof (bool).MakeByRefType () };
#else
				var types = new Type [] { typeof (IntPtr), typeof (bool).MakeByRefType () };
#endif
				var find_type = typeof (Class).GetMethod ("FindType", BindingFlags.Static | BindingFlags.NonPublic, null, types, null);
				var type_to_find = typeof (RegistrationTestClass);
				var type = (Type) find_type.Invoke (null, new object [] { Class.GetHandle (type_to_find), false });
				var is_static = type_to_find == type;
				if (is_static) {
					return Registrars.Static;
				} else {
					return Registrars.Dynamic;
				}
			}
		}
	}
}
