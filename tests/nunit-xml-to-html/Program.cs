using System;
using System.IO;
using System.Xml;

class MainClass
{
	public static void Main (string [] args)
	{
		foreach (var arg in args) {
			var doc = new XmlDocument ();
			doc.Load (arg);
			Convert (doc, Console.Out);
		}
	}

	static void Convert (XmlDocument doc, TextWriter writer)
	{
		writer.WriteLine ("<!DOCTYPE html>");
		writer.WriteLine ("<html lang='en'>");
		writer.WriteLine ("<head>");
		writer.WriteLine ("<title>title</title>");
		writer.WriteLine ("<style>");
		writer.WriteLine (".assembly { padding: 5px; }");
		writer.WriteLine (".fixture { padding: 5px; }");
		writer.WriteLine (".testcase { padding: 5px; }");
		writer.WriteLine (".parameterizedmethod { }");
		writer.WriteLine (".testsuite { border-radius: 3px; border: 1px solid; }");
		writer.WriteLine (".results { padding-left: 10px; }");
		writer.WriteLine (".success-container { display: none;  border-color: #d6e9c6; }");
		writer.WriteLine (".ignored-container { display: block; border-color: #bce8f1; }");
		writer.WriteLine (".failure-container { display: block; border-color: #ebccd1; }");
		writer.WriteLine (".unknown-container { display: block; border-color: yellow; }");
		writer.WriteLine (".notrunnable-container { display: block; border-color: #ddd; }");
		writer.WriteLine (".success { background-color: #dff0d8; color: #3c763d; }");
		writer.WriteLine (".ignored { background-color: #d9edf7; color: #31708f; }");
		writer.WriteLine (".failure { background-color: #f2dede; color: #a94442; }");
		writer.WriteLine (".notrunnable { background-color: #f5f5f5; color: #333; }");
		writer.WriteLine (".unknown { background-color: pink; color: purple; }");
		writer.WriteLine ("</style>");
		writer.WriteLine ("</head>");
		writer.WriteLine ("<body>");
		var test_results = doc.SelectSingleNode ("test-results");
		var suites = test_results.SelectNodes ("test-suite");
		foreach (XmlNode suite in suites) {
			var info = ReadInfo (suite);
			writer.WriteLine ($"<div class='testsuite {info.CssClass}-container'>");
			writer.WriteLine ($"<div class='testsuite {info.CssClass}'>{HtmlEncode (info.Name)}</div>");
			writer.WriteLine ($"<div>");
			var assembly_suites = suite.SelectNodes ("results/test-suite");
			foreach (XmlNode asuite in assembly_suites) {
				var ainfo = ReadInfo (asuite);
				writer.WriteLine ($"<div class='testsuite assembly {ainfo.CssClass}-container'>");
				writer.WriteLine ($"<div class='testsuite assembly {ainfo.CssClass}'>{HtmlEncode (ainfo.Name)}</div>");
				var fixture_suites = asuite.SelectNodes ("results/test-suite");
				foreach (XmlNode fsuite in fixture_suites) {
					var finfo = ReadInfo (fsuite);
					writer.WriteLine ($"<div class='testsuite fixture {finfo.CssClass}-container'>");
					writer.WriteLine ($"<div class='testsuite fixture {finfo.CssClass}'>{HtmlEncode (finfo.Name)}</div>");
					PrintTestCases (writer, fsuite);
					var parameterized_suites = fsuite.SelectNodes ("results/test-suite");
					foreach (XmlNode psuite in parameterized_suites) {
						var pinfo = ReadInfo (psuite);
						writer.WriteLine ($"<div class='testsuite parameterizedmethod {pinfo.CssClass}-container'>");
						writer.WriteLine ($"<div class='testsuite parameterizedmethod {pinfo.CssClass}'>{HtmlEncode (pinfo.Name)}</div>");
						PrintTestCases (writer, psuite);
						writer.WriteLine ("</div>");
					}
					writer.WriteLine ("</div>");
				}
				writer.WriteLine ("</div>");
			}
			writer.WriteLine ("</div>");
			writer.WriteLine ("</div>");
		}
		writer.WriteLine ("</body>");
		writer.WriteLine ("</html>");
	}

	static void PrintTestCases (TextWriter writer, XmlNode node)
	{
		writer.WriteLine ($"<div class='results'>");
		var test_cases = node.SelectNodes ("results/test-case");
		foreach (XmlNode tcase in test_cases) {
			var info = ReadInfo (tcase);
			writer.WriteLine ($"<div class='testcase'>");
			if (!string.IsNullOrEmpty (info.FailureMessage)) {
				var lines = info.FailureMessage.Split ('\n');
				writer.WriteLine ($"<div class='testline {info.CssClass}'>{HtmlEncode (info.Name)}: {HtmlEncode (lines [0])}</div>");
				if (lines.Length > 1)
					writer.WriteLine ($"<div class='failure-message'><pre>{HtmlEncode (info.FailureMessage)}</pre></div>");
				if (!string.IsNullOrEmpty (info.FailureStackTrace))
					writer.WriteLine ($"<div class='failure-stack-trace'><pre>{HtmlEncode (info.FailureStackTrace)}</pre></div>");
			} else if (!string.IsNullOrEmpty (info.ReasonMessage)) {
				var lines = info.ReasonMessage.Split ('\n');
				writer.WriteLine ($"<div class='testline {info.CssClass}'>{HtmlEncode (info.Name)}: {HtmlEncode (lines [0])}</div>");
				if (lines.Length > 1)
					writer.WriteLine ($"<div class='reason-message'><pre>{HtmlEncode (info.ReasonMessage)}</pre></div>");
			} else {
				writer.WriteLine ($"<div class='testline {info.CssClass}'>{HtmlEncode (info.Name)}</div>");
			}
			writer.WriteLine ("</div>");
		}
		writer.WriteLine ("</div>");
	}

	class TestInfo
	{
		public string Name;
		public bool Executed;
		public string Result;
		public bool Success;
		public string Time;
		public int Asserts;
		public string Type;
		public string ReasonMessage;
		public string FailureMessage;
		public string FailureStackTrace;

		public string CssClass {
			get {
				if (Success) {
					return "success";
				} else {
					switch (Result) {
					case "Ignored":
						return "ignored";
					case "Failure":
						return "failure";
					default:
						return "unknown";
					}
				}
			}
		}
	}

	static TestInfo ReadInfo (XmlNode node)
	{
		var info = new TestInfo ();
		info.Name = node.Attributes ["name"]?.Value;
		info.Executed = node.Attributes ["executed"]?.Value == "True";
		info.Result = node.Attributes ["result"]?.Value;
		info.Success = node.Attributes ["success"]?.Value == "True";
		info.Time = node.Attributes ["time"]?.Value;
		int asserts;
		if (int.TryParse (node.Attributes ["asserts"]?.Value, out asserts))
			info.Asserts = asserts;
		info.Type = node.Attributes ["type"]?.Value;
		info.ReasonMessage = node.SelectSingleNode ("reason/message")?.InnerText;
		info.FailureMessage = node.SelectSingleNode ("failure/message")?.InnerText;
		info.FailureStackTrace = node.SelectSingleNode ("failure/stack-trace")?.InnerText;
		return info;

	}

	static string HtmlEncode (string value)
	{
		return System.Web.HttpUtility.HtmlEncode (value);
	}
}
