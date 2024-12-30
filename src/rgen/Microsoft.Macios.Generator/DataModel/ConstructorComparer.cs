using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Macios.Generator.DataModel;

class ConstructorComparer : IComparer<Constructor> {
	public int Compare (Constructor x, Constructor y)
	{
		var typeComparison = String.Compare (x.Type, y.Type, StringComparison.Ordinal);
		if (typeComparison != 0)
			return typeComparison;
		var modifiersLengthCompare = x.Modifiers.Length.CompareTo (y.Modifiers.Length);
		if (modifiersLengthCompare != 0)
			return modifiersLengthCompare;

		// sort by the modifiers
		var xModifiers = x.Modifiers.Select (m => m.Text).Order ().ToArray ();
		var yModifiers = y.Modifiers.Select (m => m.Text).Order ().ToArray ();
		for (var i = 0; i < xModifiers.Length; i++) {
			var modiferCompare = String.Compare (xModifiers [i], yModifiers [i], StringComparison.Ordinal);
			if (modiferCompare != 0)
				return modiferCompare;
		}

		var attributesLengthCompare = x.Attributes.Length.CompareTo (y.Attributes.Length);
		if (attributesLengthCompare != 0)
			return attributesLengthCompare;

		// Sort by the attributes, this covers the need to sort by the os availability since that
		// information comes from the attributes. There is no need to sort twice by the same data
		var attributeComparer = new AttributeComparer ();
		var xAttributes = x.Attributes.Order (attributeComparer).ToArray ();
		var yAttributes = y.Attributes.Order (attributeComparer).ToArray ();
		for (var i = 0; i < xAttributes.Length; i++) {
			var attrCompare = attributeComparer.Compare (xAttributes [i], yAttributes [i]);
			if (attrCompare != 0)
				return attrCompare;
		}

		var parameterSizeCompare = x.Parameters.Length.CompareTo (y.Parameters.Length);
		if (parameterSizeCompare != 0)
			return parameterSizeCompare;

		// do not sort parameters, since they are added in order, just compare them
		var parameterComparer = new ParameterComparer ();
		for (var i = 0; i < x.Parameters.Length; i++) {
			var paramCompare = parameterComparer.Compare (x.Parameters [i], y.Parameters [i]);
			if (paramCompare != 0)
				return paramCompare;
		}
		return 0;
	}
}
