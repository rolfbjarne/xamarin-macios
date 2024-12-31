#pragma warning disable APL0003
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Macios.Generator.Attributes;
using Microsoft.Macios.Generator.Availability;
using Microsoft.Macios.Generator.Extensions;
using ObjCBindings;
using ObjCRuntime;
using Xamarin.Tests;
using Xamarin.Utils;
using Xunit;

namespace Microsoft.Macios.Generator.Tests.Extensions;

public class TypeSymbolExtensionsTests : BaseGeneratorTestClass {
	class TestDataGetAttributeDataPresent : IEnumerable<object []> {
		public IEnumerator<object []> GetEnumerator ()
		{
			var attributesText = @"
using System;

namespace Test;

public class SimpleAttribute : Attribute {
}

public class AttributeWithParamsAttribute : Attribute {
        public AttributeWithParams (string name, int value) {
        }
}

";

			var classText = @"
using System;

namespace Test;

[Simple, AttributeWithParams (""test"", 2)]
public class TestClass {
}
";
			var classAttrs = new HashSet<string> { "Test.SimpleAttribute", "Test.AttributeWithParamsAttribute" };

			yield return [classText, attributesText, classAttrs];

			var interfaceText = @"
using System;

namespace Test;

[Simple]
public interface ITestInterface {
}
";
			var interfaceAttrs = new HashSet<string> { "Test.SimpleAttribute" };
			yield return [interfaceText, attributesText, interfaceAttrs];

			var enumText = @"
namespace Test;

public enum TestEnum {
	First,
	Second,
}
";
			HashSet<string> enumAttrs = new ();
			yield return [enumText, attributesText, enumAttrs];
		}

		IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
	}

	[Theory]
	[AllSupportedPlatformsClassData<TestDataGetAttributeDataPresent>]
	public void GetAttributeDataPresent (ApplePlatform platform, string inputText, string attributesText,
		HashSet<string> expectedAttributes)
	{
		var (compilation, syntaxTrees) = CreateCompilation (platform, sources: [inputText, attributesText]);
		Assert.Equal (2, syntaxTrees.Length);
		var semanticModel = compilation.GetSemanticModel (syntaxTrees [0]);
		var declaration = syntaxTrees [0].GetRoot ()
			.DescendantNodes ()
			.OfType<BaseTypeDeclarationSyntax> ()
			.FirstOrDefault ();
		Assert.NotNull (declaration);
		var symbol = semanticModel.GetDeclaredSymbol (declaration);
		Assert.NotNull (symbol);
		var attrs = symbol.GetAttributeData ();
		Assert.Equal (expectedAttributes.Count, attrs.Keys.Count);
		Assert.Multiple (() => {
			foreach (var attrName in attrs.Keys) {
				Assert.Contains (attrName, expectedAttributes);
				Assert.Single (attrs [attrName]);
			}
		});
	}

	class TestDataGetParents : IEnumerable<object []> {
		public IEnumerator<object []> GetEnumerator ()
		{
			const string nestedMethodNestedClass = @"
using System;

namespace Test;

public class ParentClass{
	public class ChildClass{
		public void Method(){}
	}
}
";
			Func<SyntaxNode, MemberDeclarationSyntax?> getNestedMethod =
				rootNode => rootNode.DescendantNodes ().OfType<MethodDeclarationSyntax> ().LastOrDefault ();
			var nestedMethodNestedClassParents = new [] { "ChildClass", "ParentClass" };
			yield return [nestedMethodNestedClass, getNestedMethod, nestedMethodNestedClassParents];

			const string methodInClass = @"
using System;

namespace Test;

public class ParentClass{
	public void Method(){}
}
";
			var methodParents = new [] { "ParentClass" };
			yield return [methodInClass, getNestedMethod, methodParents];

			const string nestedNamespacesNestedClass = @"
using System;

namespace Test {
	namespace Foo {
		namespace Bar {
			public class ParentClass{
				public void Method(){}
			}
		}
	}
}
";

			var nestedNamespacesParents = new [] { "ParentClass" };
			yield return [nestedNamespacesNestedClass, getNestedMethod, nestedNamespacesParents];


			Func<SyntaxNode, MemberDeclarationSyntax?> getEnumValue =
				rootNode => rootNode.DescendantNodes ().OfType<EnumMemberDeclarationSyntax> ().LastOrDefault ();
			const string enumValueNested = @"
using System;

namespace Test;

public class ParentClass {
	public class ChildClass {
		public enum MyEnum {
			First,
		}
	}
}
";
			var enumParensts = new [] { "MyEnum", "ChildClass", "ParentClass" };
			yield return [enumValueNested, getEnumValue, enumParensts];
		}

		IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
	}

	[Theory]
	[AllSupportedPlatformsClassData<TestDataGetParents>]
	public void GetParentTests (ApplePlatform platform, string inputText,
		Func<SyntaxNode, MemberDeclarationSyntax?> getNode, string [] expectedParents)
	{
		var (compilation, syntaxTrees) = CreateCompilation (platform, sources: inputText);
		Assert.Single (syntaxTrees);
		var semanticModel = compilation.GetSemanticModel (syntaxTrees [0]);
		var declaration = getNode (syntaxTrees [0].GetRoot ());
		Assert.NotNull (declaration);
		var symbol = semanticModel.GetDeclaredSymbol (declaration);
		Assert.NotNull (symbol);
		var parents = symbol.GetParents ().Select (p => p.Name).ToArray ();
		Assert.Equal (expectedParents, parents);
	}

	class TestDataGetSupportedPlatforms : IEnumerable<object []> {
		public IEnumerator<object []> GetEnumerator ()
		{

			var builder = SymbolAvailability.CreateBuilder ();
			Func<SyntaxNode, MemberDeclarationSyntax?> getNestedMethod =
				rootNode => rootNode.DescendantNodes ().OfType<MethodDeclarationSyntax> ().LastOrDefault ();

			// base member decorated, not child
			const string decoratedParent = @"
using System;
using System.Runtime.Versioning;

namespace Test;

[SupportedOSPlatform (""ios12.0"")]
public class ParentClass{
	public void Method(){}
}
";
			builder.Add (new SupportedOSPlatformData ("ios12.0"));
			yield return [decoratedParent, getNestedMethod, builder.ToImmutable ()];
			builder.Clear ();

			// base member decorated, child decorated
			const string decoratedParentAndChild = @"
using System;
using System.Runtime.Versioning;

namespace Test;

[SupportedOSPlatform (""ios"")]
public class ParentClass{
	[UnsupportedOSPlatform (""tvos"")]
	[SupportedOSPlatform (""ios12.0"")]
	public void Method(){}
}
";
			builder.Add (new SupportedOSPlatformData ("ios12.0"));
			builder.Add (new UnsupportedOSPlatformData ("tvos"));
			yield return [decoratedParentAndChild, getNestedMethod, builder.ToImmutable ()];
			builder.Clear ();

			// base member, child, granchild not decorated
			const string grandChild = @"
using System;
using System.Runtime.Versioning;

namespace Test;

[SupportedOSPlatform (""ios"")]
public class ParentClass{
	[UnsupportedOSPlatform (""tvos"")]
	public class ChildClass {
		public void Method(){}
	}
}
";
			builder.Add (new SupportedOSPlatformData ("ios"));
			builder.Add (new UnsupportedOSPlatformData ("tvos"));
			yield return [grandChild, getNestedMethod, builder.ToImmutable ()];
			builder.Clear ();

			// all decorated
			const string allDecorated = @"
using System;
using System.Runtime.Versioning;

namespace Test;

[SupportedOSPlatform (""ios"")]
public class ParentClass{
	[UnsupportedOSPlatform (""tvos"")]
	public class ChildClass {
		[SupportedOSPlatform (""ios13.0"")]
		public void Method(){}
	}
}
";
			builder.Add (new SupportedOSPlatformData ("ios13.0"));
			builder.Add (new UnsupportedOSPlatformData ("tvos"));
			yield return [allDecorated, getNestedMethod, builder.ToImmutable ()];
			builder.Clear ();

			// enum decorated
			Func<SyntaxNode, MemberDeclarationSyntax?> getEnumValue =
				rootNode => rootNode.DescendantNodes ().OfType<EnumMemberDeclarationSyntax> ().LastOrDefault ();
			const string enumDecorated = @"
using System;
using System.Runtime.Versioning;

namespace Test;

[SupportedOSPlatform (""ios"")]
public class ParentClass{
	[UnsupportedOSPlatform (""tvos"")]
	public enum MyEnum {
		[SupportedOSPlatform (""ios13.0"")]
		First,
	}
}
";

			builder.Add (new SupportedOSPlatformData ("ios13.0"));
			builder.Add (new UnsupportedOSPlatformData ("tvos"));
			yield return [enumDecorated, getEnumValue, builder.ToImmutable ()];
			builder.Clear ();

		}

		IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
	}

	[Theory]
	[AllSupportedPlatformsClassData<TestDataGetSupportedPlatforms>]
	void GetSupportedPlatforms (ApplePlatform platform, string inputText,
		Func<SyntaxNode, MemberDeclarationSyntax?> getNode,
		SymbolAvailability expectedAvailability)
	{
		var (compilation, syntaxTrees) = CreateCompilation (platform, sources: inputText);
		Assert.Single (syntaxTrees);
		var semanticModel = compilation.GetSemanticModel (syntaxTrees [0]);
		var declaration = getNode (syntaxTrees [0].GetRoot ());
		Assert.NotNull (declaration);
		var symbol = semanticModel.GetDeclaredSymbol (declaration);
		Assert.NotNull (symbol);
		var availability = symbol.GetSupportedPlatforms ();
		Assert.Equal (availability, expectedAvailability);
	}

	class TestDataGetExportData : IEnumerable<object []> {
		public IEnumerator<object []> GetEnumerator ()
		{
			const string noAttrPropertyClass = @"
using ObjCBindings;

namespace NS;

[BindingType]
public partial class MyClass {
	public static partial string Name { get; set; } = string.Empty;
}
";
			yield return [noAttrPropertyClass, Field.Default, null!];

			const string fieldPropertyClass = @"
using ObjCBindings;

namespace NS;

[BindingType]
public partial class MyClass {
	[Export<Field> (""CONSTANT"")]
	public static partial string Name { get; set; } = string.Empty;
}
";
			yield return [fieldPropertyClass, Field.Default, new ExportData<Field> ("CONSTANT")];
			const string singlePropertyClass = @"
using ObjCBindings;

namespace NS;

[BindingType]
public partial class MyClass {
	[Export<Property> (""name"")]
	public partial string Name { get; set; } = string.Empty;
}
";
			yield return [singlePropertyClass, Property.Default, new ExportData<Property> ("name")];

			const string notificationPropertyClass = @"
using ObjCBindings;

namespace NS;

[BindingType]
public partial class MyClass {
	[Export<Property> (""name"", Property.Notification)]
	public partial string Name { get; set; } = string.Empty;
}
";
			yield return [notificationPropertyClass,
				Property.Default,
				new ExportData<Property> ("name", ArgumentSemantic.None, Property.Notification)];
		}

		IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
	}

	[Theory]
	[AllSupportedPlatformsClassData<TestDataGetExportData>]
	void GetExportData<T> (ApplePlatform platform, string inputText, T @enum, ExportData<T>? expectedData) where T : Enum
	{
		Assert.NotNull (@enum);
		var (compilation, syntaxTrees) = CreateCompilation (platform, sources: inputText);
		Assert.Single (syntaxTrees);
		var declaration = syntaxTrees [0].GetRoot ()
			.DescendantNodes ()
			.OfType<PropertyDeclarationSyntax> ()
			.FirstOrDefault ();
		Assert.NotNull (declaration);
		var semanticModel = compilation.GetSemanticModel (syntaxTrees [0]);
		Assert.NotNull (semanticModel);
		var symbol = semanticModel.GetDeclaredSymbol (declaration);
		Assert.NotNull (symbol);
		var exportData = symbol.GetExportData<T> ();
		Assert.Equal (expectedData, exportData);
	}
}
