using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Mono.Cecil;

using Clang.Ast;

namespace Extrospection {

	public class Runner {

		public Runner ()
		{
		}

		public void Execute (string pchFile, IEnumerable<string> assemblyNames, string outputDirectory = "")
		{
			var managed_reader = new AssemblyReader () {
				new MapNamesVisitor (), // must come first to map managed and native names.
				new ReleaseAttributeCheck (),
				new DesignatedInitializerCheck (),
				new DllImportCheck (),
				new EnumCheck (),
				new FieldCheck (),
				new ObjCInterfaceCheck (),
				new ObjCProtocolCheck (),
				new SelectorCheck (),
				new SimdCheck (),
				new RequiresSuperCheck (),
				new DeprecatedCheck (),
				new NullabilityCheck (),
				new UIAppearanceCheck (),
//				new ListNative (), // for debug
			};
			foreach (var assemblyName in assemblyNames) {
				var name = Path.GetFileNameWithoutExtension (assemblyName);
				if (name.EndsWith (".iOS", StringComparison.Ordinal))
					Helpers.Platform = Platforms.iOS;
				else if (name.EndsWith (".Mac", StringComparison.Ordinal) || name.EndsWith (".macOS", StringComparison.Ordinal))
					Helpers.Platform = Platforms.macOS;
				else if (name.EndsWith (".WatchOS", StringComparison.Ordinal))
					Helpers.Platform = Platforms.watchOS;
				else if (name.EndsWith (".TVOS", StringComparison.Ordinal) || name.EndsWith (".tvOS", StringComparison.Ordinal))
					Helpers.Platform = Platforms.tvOS;
				else if (name.EndsWith (".MacCatalyst", StringComparison.Ordinal))
					Helpers.Platform = Platforms.MacCatalyst;
				Helpers.IsDotNet = assemblyName.Contains ("/runtimes/");
				managed_reader.Load (assemblyName);
			}
			managed_reader.Process ();

			var reader = new AstReader ();
			foreach (var v in managed_reader) {
				reader.TranslationUnitParsed += tu => {
					tu.Accept (v);
				};
			}

			reader.Load (pchFile);

			managed_reader.End ();

			Log.Save (outputDirectory);
		}
	}

	class AssemblyReader : IEnumerable<BaseVisitor> {

		HashSet<AssemblyDefinition> assemblies = new HashSet<AssemblyDefinition> ();
		DefaultAssemblyResolver resolver = new DefaultAssemblyResolver ();

		public void Load (string filename)
		{
			resolver.AddSearchDirectory (Path.GetDirectoryName (filename));
			ReaderParameters rp = new ReaderParameters () {
				AssemblyResolver = resolver
			};
			assemblies.Add (AssemblyDefinition.ReadAssembly (filename, rp));
		}

		public void Process ()
		{
			foreach (var ad in assemblies) {
				foreach (var v in Visitors) {
					v.VisitManagedAssembly (ad);
					foreach (var module in ad.Modules) {
						v.VisitManagedModule (module);
						if (!module.HasTypes)
							continue;
						foreach (var td in module.Types)
							ProcessType (v, td);
					}
				}
			}
		}

		void ProcessType (BaseVisitor v, TypeDefinition type)
		{
			v.VisitManagedType (type);
			if (type.HasMethods) {
				foreach (var md in type.Methods)
					v.VisitManagedMethod (md);
			}

			if (type.HasNestedTypes) {
				foreach (var nested in type.NestedTypes)
					ProcessType (v, nested);
			}
		}

		List<BaseVisitor> Visitors { get; } = new List<BaseVisitor> ();

		public void Add (BaseVisitor visitor)
		{
			Visitors.Add (visitor);
		}

		public void End ()
		{
			foreach (var v in Visitors)
				v.End ();
		}

		public IEnumerator<BaseVisitor> GetEnumerator ()
		{
			return Visitors.GetEnumerator ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return Visitors.GetEnumerator ();
		}
	}

	public class BaseVisitor : AstVisitor {

		public virtual void VisitManagedAssembly (AssemblyDefinition assembly)
		{
		}

		public virtual void VisitManagedModule (ModuleDefinition module)
		{
		}

		public virtual void VisitManagedType (TypeDefinition type)
		{
		}

		public virtual void VisitManagedMethod (MethodDefinition method)
		{
		}

		// last chance to report errors
		public virtual void End ()
		{
		}
	}


	// debug
	class ListNative : BaseVisitor {

		public override void VisitDecl (Decl decl)
		{
			if (decl is FunctionDecl) {
				;
			} else if (decl is VarDecl) {
				;
			} else if (decl is ObjCProtocolDecl) {
				;
			} else if (decl is ObjCInterfaceDecl) {
				;
			} else if (decl is EnumDecl) {
				;
			} else {
				Console.WriteLine ("{0}\t{1}", decl, decl.GetType ().Name);
			}
		}
	}
}
