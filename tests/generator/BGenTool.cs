using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Mono.Cecil;

using Xamarin.Utils;

namespace Xamarin.Tests
{
	public enum Profile {
		None,
		iOS, 
		tvOS, 
		watchOS,
		macClassic,
		macModern,
		macFull,
		macSystem,
	}
	
	class BGenTool : Tool
	{
		AssemblyDefinition assembly;

		public Profile Profile;

		public List<string> ApiDefinitions = new List<string> ();
		public string TmpDirectory;

		protected override string ToolPath { get { return Configuration.BGenPath; } }
		protected override string MessagePrefix { get { return "BI"; } }
		protected override string MessageToolName { get { return "bgen"; } }

		string BuildArguments ()
		{
			var sb = new StringBuilder ();
			var targetFramework = (string) null;

			switch (Profile) {
			case Profile.None:
				break;
			case Profile.iOS:
				targetFramework = "Xamarin.iOS,v1.0";
				break;
			case Profile.tvOS:
				targetFramework = "Xamarin.TVOS,v1.0";
				break;
			case Profile.watchOS:
				targetFramework = "Xamarin.WatchOS,v1.0";
				break;
			case Profile.macClassic:
				targetFramework = "XamMac,v1.0";
				break;
			case Profile.macFull:
				targetFramework = "Xamarin.Mac,Version=v4.5,Profile=Full";
				break;
			case Profile.macModern:
				targetFramework = "Xamarin.Mac,Version=v2.0,Profile=Mobile";
				break;
			case Profile.macSystem:
				targetFramework = "Xamarin.Mac,Version=v4.5,Profile=System";
				break;
			default:
				throw new NotImplementedException ($"Profile: {Profile}");
			}

			if (!string.IsNullOrEmpty (targetFramework))
				sb.Append (" --target-framework=").Append (targetFramework);
			
			foreach (var ad in ApiDefinitions)
				sb.Append (" --api=").Append (StringUtils.Quote (ad));
			
			if (!string.IsNullOrEmpty (TmpDirectory))
				sb.Append (" --tmpdir=").Append (StringUtils.Quote (TmpDirectory));

			return sb.ToString ();
		}

		public void AssertExecute (string message)
		{
			Assert.AreEqual (0, Execute (BuildArguments ()), message);
		}

		public void AssertExecuteError (string message)
		{
			Assert.AreNotEqual (0, Execute (BuildArguments ()), message);
		}

		public void AssertPublicTypeCount (int count, string message = null)
		{
			LoadAssembly ();

			var actual = assembly.MainModule.Types.Where ((v) => v.IsPublic || v.IsNestedPublic);
			if (actual.Count () != count)
				Assert.Fail ($"Expected {count} public type(s), found {actual} public type(s). {message}\n\t{string.Join ("\n\t", actual.Select ((v) => v.FullName).ToArray ())}");
		}

		public void AssertPublicMethodCount (string typename, int count, string message = null)
		{
			LoadAssembly ();

			var t = assembly.MainModule.Types.FirstOrDefault ((v) => v.FullName == typename);
			var actual = t.Methods.Count ((v) => {
				if (v.IsPrivate || v.IsFamily || v.IsFamilyAndAssembly)
					return false;
				return true;
			});
			if (actual != count)
				Assert.Fail ($"Expected {count} publicly accessible method(s) in {typename}, found {actual} publicly accessible method(s). {message}");
		}

		public void AssertType (string fullname, TypeAttributes? attributes = null, string message = null)
		{
			LoadAssembly ();

			var t = assembly.MainModule.Types.FirstOrDefault ((v) => v.FullName == fullname);
			if (t == null)
				Assert.Fail ($"No type named '{fullname}' in the generated assembly. {message}");
			if (attributes != null)
				Assert.AreEqual (attributes.Value, t.Attributes, $"Incorrect attributes for type {fullname}.");
		}

		public void AssertMethod (string typename, string method, string returnType = null, params string [] parameterTypes)
		{
			LoadAssembly ();

			var t = assembly.MainModule.Types.First ((v) => v.FullName == typename);
			var m = t.Methods.FirstOrDefault ((v) => {
				if (v.Name != method)
					return false;
				if (v.Parameters.Count != parameterTypes.Length)
					return false;
				for (int i = 0; i < v.Parameters.Count; i++)
					if (v.Parameters [i].ParameterType.FullName != parameterTypes [i])
						return false;
				return true;
			});
			if (m == null)
				Assert.Fail ($"No method '{method}' with signature '{string.Join ("', '", parameterTypes)}' was found.");
		}

		void LoadAssembly ()
		{
			if (assembly == null)
				assembly = AssemblyDefinition.ReadAssembly (Path.Combine (TmpDirectory, "api.dll"));
		}

		void EnsureTempDir ()
		{
			if (TmpDirectory == null)
				TmpDirectory = Cache.CreateTemporaryDirectory ();
		}

		public void CreateTemporaryBinding (string api_definition)
		{
			EnsureTempDir ();
			var api = Path.Combine (TmpDirectory, "api.cs");
			File.WriteAllText (api, api_definition);
			ApiDefinitions.Add (api);
			WorkingDirectory = TmpDirectory;
		}
	}
}
