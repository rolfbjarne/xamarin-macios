//
// Test the generated API fields (e.g. against typos or unexisting values for the platform)
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2012-2014 Xamarin Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

using NUnit.Framework;

#if XAMCORE_2_0
using Foundation;
using ObjCRuntime;
#elif MONOMAC
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
#else
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
#endif

namespace Introspection {

	[Preserve (AllMembers = true)]
	public abstract class ApiFieldTest : ApiBaseTest {
#if XAMCORE_2_0
		const string NSStringType = "Foundation.NSString";
#elif MONOMAC
		const string NSStringType = "MonoMac.Foundation.NSString";
#else
		const string NSStringType = "MonoTouch.Foundation.NSString";
#endif

		/// <summary>
		/// Override if you want to skip testing the specified type.
		/// </summary>
		/// <param name="type">Type to be tested</param>
		protected virtual bool Skip (Type type)
		{
			return false;
		}

		/// <summary>
		/// Override if you want to skip testing the specified property.
		/// </summary>
		/// <param name="property">Property to be tested</param>
		protected virtual bool Skip (PropertyInfo property)
		{
			return SkipDueToAttribute (property);
		}

		/// <summary>
		/// Override if you want to skip testing the specified constant.
		/// </summary>
		/// <param name="constantName">Constant name to ignore.</param>
		protected virtual bool Skip (string constantName, string libraryName)
		{
			return false;
		}

		/// <summary>
		/// Override if you want to skip testing the specified constant during notification tests
		/// </summary>
		/// <param name="declaredType">Type declaring said notification.</param>
		/// <param name="notificationName">Name of notification.</param>
		protected virtual bool SkipNotification (Type declaredType, string notificationName)
		{
			return false;
		}

		// check generated code, which are static properties, e.g.
		// [Field ("kCGImagePropertyIPTCObjectTypeReference")]
		// NSString IPTCObjectTypeReference { get; }
		bool CheckAgainstNull (PropertyInfo p, out string name)
		{
			name = String.Empty;
			var g = p.GetGetMethod (true);
			if (!g.IsStatic)
				return true;

			if (Skip (p))
				return true;
			
			try {
				// if it return nulls then it could be a typo...
				// or something not available in the executing version of iOS
				bool result = g.Invoke (null, null) != null;
				if (!result)
					name = p.DeclaringType.FullName + "." + p.Name;
				return result;
			}
			catch (Exception e) {
				Console.WriteLine ("[FAIL] Exception on '{0}' : {1}", p, e);
				name = p.DeclaringType.FullName + "." + p.Name;
				return false;
			}
		}

		static List<PropertyInfo> properties;

		IEnumerable<PropertyInfo> AllProperties ()
		{
			if (properties != null)
				return properties;

			properties = new List<PropertyInfo> ();
			foreach (Type t in Assembly.GetTypes ()) {
				if (Skip (t) || SkipDueToAttribute (t))
					continue;

				foreach (var p in t.GetProperties (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
					// looking for properties with getters only
					if (p.CanWrite || !p.CanRead)
						continue;
					if (SkipDueToAttribute (p))
						continue;

					properties.Add (p);
				}
			}
			return properties;
		}


		[Test]
		public void Notifications ()
		{
			var failed_fields = new List<string> ();

			Errors = 0;
			int c = 0, n = 0;
			foreach (var p in AllProperties ()) {
				if (p.PropertyType.FullName != NSStringType)
					continue;
				
				var f = p.GetCustomAttribute<FieldAttribute> ();
				if (f == null)
					continue;

				var name = f.SymbolName;
				if (!name.EndsWith ("Notification", StringComparison.Ordinal))
					continue;

				if (SkipNotification (p.DeclaringType, name))
					continue;

				var nested = p.DeclaringType.GetNestedTypes ();
				if (nested.Length == 0) {
					ReportError (name);
					failed_fields.Add (name);
				} else {
					bool found = false;
					foreach (var nt in nested) {
						if (nt.Name != "Notifications")
							continue;
						// look for the associated methods
						name = "Observe" + p.Name;
						if (name.EndsWith ("Notification", StringComparison.Ordinal))
							name = name.Substring (0, name.Length - "Notification".Length);
						foreach (var m in nt.GetMethods (BindingFlags.Static | BindingFlags.Public)) {
							if (name == m.Name) {
								found = true;
								break;
							}
						}
					}
					if (!found) {
						ReportError (name);
						failed_fields.Add (name);
					}
				}
				n++;
			}
			Assert.AreEqual (0, Errors, "{0} errors found in {1} fields validated: {2}", Errors, n, string.Join (", ", failed_fields));
		}
		
		[Test]
		public void NonNullNSStringFields ()
		{
			var failed_fields = new List<string> ();

			Errors = 0;
			int n = 0;
			foreach (var p in AllProperties ()) {
				if (p.PropertyType.FullName != NSStringType)
					continue;

				if (p.GetCustomAttribute<ObsoleteAttribute> () != null)
					continue;

				string name;
				bool result = CheckAgainstNull (p, out name);
				if (!result) {
					ReportError (name);
					failed_fields.Add (name);
				}
				n++;
			}
			Assert.AreEqual (0, Errors, "{0} errors found in {1} fields validated: {2}", Errors, n, string.Join (", ", failed_fields));
		}

		[Test]
		public void FieldExists ()
		{
			var failed_fields = new List<string> ();

			Errors = 0;
			int n = 0;
			foreach (var p in AllProperties ()) {
				var f = p.GetCustomAttribute<FieldAttribute> ();
				if (f == null)
					continue;

				string name = f.SymbolName;
				if (Skip (name, f.LibraryName))
					continue;

				string path = FindLibrary (f.LibraryName);
				IntPtr lib = Dlfcn.dlopen (path, 0);
				if (lib == IntPtr.Zero) {
					ReportError ("Could not open the library '{0}' to find the field '{1}': {2}", path, name, Dlfcn.dlerror ());
					failed_fields.Add (name);
				} else if (Dlfcn.GetIndirect (lib, name) == IntPtr.Zero) {
					ReportError ("Could not find the field '{0}' in {1}", name, path);
					failed_fields.Add (name);
				}
				Dlfcn.dlclose (lib);
				n++;
			}
			Assert.AreEqual (0, Errors, "{0} errors found in {1} fields validated: {2}", Errors, n, string.Join (", ", failed_fields));
		}
	}
}
