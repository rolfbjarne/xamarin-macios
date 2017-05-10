using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using Mono.Cecil;

namespace Xamarin.Bundler
{
	public enum SymbolType
	{
		Function,
		ObjectiveCClass,
	}

	public class Symbol
	{
		public SymbolType Type;

		string name;
		public string Name {
			get {
				if (name != null)
					return name;
				if (ObjectiveCName != null)
					return "OBJC_CLASS_$_" + ObjectiveCName;
				throw new NotImplementedException ();
			}
			set {
				name = value;
			}
		}
		public string ObjectiveCName;
		public List<MemberReference> Members = new List<MemberReference> ();
	}

	public class Symbols : IEnumerable<Symbol>
	{
		Dictionary<string, Symbol> store = new Dictionary<string, Symbol> (StringComparer.Ordinal);

		public int Count {
			get {
				return store.Count;
			}
		}

		public void Add (Symbol symbol)
		{
			store.Add (symbol.Name, symbol);
		}

		public void AddFunction (string name)
		{
			Add (new Symbol { Name = name, Type = SymbolType.Function });
		}

		public IEnumerator<Symbol> GetEnumerator ()
		{
			return store.Values.GetEnumerator ();
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return store.Values.GetEnumerator ();
		}

		public Symbol Find (string name)
		{
			Symbol rv;
			store.TryGetValue (name, out rv);
			return rv;
		}

		public bool Contains (string name)
		{
			return store.ContainsKey (name);
		}

		public Symbol this [string name] {
			get {
				return store [name];
			}
		}

		public void Load (string filename)
		{
			using (var reader = new StreamReader (filename)) {
				string line;
				while ((line = reader.ReadLine ()) != null) {
					var eq = line.IndexOf ('=');
					var typestr = line.Substring (0, eq);
					var name = line.Substring (eq + 1);
					Add (new Symbol { Name = name, Type = (SymbolType)Enum.Parse (typeof (SymbolType), typestr) });
				}
			}
		}

		public void Save (string filename)
		{
			using (var writer = new StreamWriter (filename)) {
				foreach (var symbol in store.Values)
					writer.WriteLine ("{0}={1}", symbol.Type, symbol.Name);
			}
		}
	}
}
