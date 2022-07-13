using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Mono.Cecil;

using Xamarin.Bundler;
using Registrar;

namespace Xamarin.Bundler {
	class PInvokeWrapperGenerator {
		public Application App;
		public Dictionary<string, string> signatures = new Dictionary<string, string> ();
		public List<Exception> exceptions = new List<Exception> ();
		public StringBuilder signature = new StringBuilder ();
		public HashSet<string> names = new HashSet<string> ();

		public AutoIndentStringBuilder sb = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder hdr = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder decls = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder mthds = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder mthd_decls = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder mthd_impls = new AutoIndentStringBuilder ();
		AutoIndentStringBuilder ifaces = new AutoIndentStringBuilder ();

		public StaticRegistrar Registrar;
		public string HeaderPath;
		public string SourcePath;

		bool first;

		public bool Started {
			get {
				return first;
			}
		}

		public void Start ()
		{
			if (App.EnableDebug)
				hdr.WriteLine ("#define DEBUG 1");

			hdr.WriteLine ("#include <stdarg.h>");
			hdr.WriteLine ("#include <xamarin/xamarin.h>");
			hdr.WriteLine ("#include <objc/objc.h>");
			hdr.WriteLine ("#include <objc/runtime.h>");
			hdr.WriteLine ("#include <objc/message.h>");

			Registrar.GeneratePInvokeWrappersStart (hdr, decls, mthd_decls, mthd_impls, mthds, ifaces);

			mthds.WriteLine ($"#include \"{Path.GetFileName (HeaderPath)}\"");

			sb.WriteLine ("extern \"C\" {");

			// Disable "control reaches end of non-void function"
			// we throw exceptions in many code paths, which clang doesn't know about, triggering this warning.
			sb.WriteLine ("#pragma clang diagnostic ignored \"-Wreturn-type\"");

			// Disable "warning: 'X' is only available on xOS Y.Z or newer"
			sb.WriteLine ("#pragma clang diagnostic ignored \"-Wunguarded-availability-new\"");
		}

		public void End ()
		{
			if (!first)
				throw new Exception ("Generator not started");

			sb.WriteLine ("}");

			Registrar.GeneratePInvokeWrappersEnd ();

			var header =
				hdr.ToString () + "\n" +
				decls.ToString () + "\n" +
				ifaces.ToString () + "\n";
			var source =
				mthd_decls.ToString () + "\n" +
				mthds.ToString () + "\n" +
				sb.ToString () + "\n" +
				mthd_impls.ToString () + "\n";
			Driver.WriteIfDifferent (HeaderPath, header, true);
			Driver.WriteIfDifferent (SourcePath, source, true);
		}

		public void ProcessMethod (MethodDefinition method)
		{
			if (!first) {
				Start ();
				first = true;
			}

			Registrar.GeneratePInvokeWrapper (this, method);
		}
	}
}
