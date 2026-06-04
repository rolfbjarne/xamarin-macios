//
// Enums.cs: enums for JavaScriptCore
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013-2014 Xamarin Inc.

namespace JavaScriptCore {
	// untyped enum -> JSValueRef.h
	/// <summary>An enumeration whose values specify JavaScript types, including <c>Object</c> and <c>undefined</c>.</summary>
	public enum JSType {
		/// <summary>Indicates undefined.</summary>
		Undefined,
		/// <summary>Indicates null.</summary>
		Null,
		/// <summary>Indicates boolean.</summary>
		Boolean,
		/// <summary>Indicates number.</summary>
		Number,
		/// <summary>Indicates string.</summary>
		String,
		/// <summary>Indicates object.</summary>
		Object,
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		Symbol,
		[iOS (18, 0), MacCatalyst (18, 0), TV (18, 0), NoMac]
		BigInt,
	}

	// typedef unsigned -> JSObjectRef.h
	/// <summary>Enumerates attributes of properties.</summary>
	[Flags]
	public enum JSPropertyAttributes : uint {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates read only.</summary>
		ReadOnly = 1 << 1,
		/// <summary>Indicates dont enum.</summary>
		DontEnum = 1 << 2,
		/// <summary>Indicates dont delete.</summary>
		DontDelete = 1 << 3,
	}

	// typedef unsigned -> JSObjectRef.h
	/// <summary>Enumerates class attributes.</summary>
	[Flags]
	public enum JSClassAttributes : uint {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates no automatic prototype.</summary>
		NoAutomaticPrototype = 1 << 1,
	}

	[iOS (18, 0), MacCatalyst (18, 0), TV (18, 0), Mac (15, 0)]
	public enum JSRelationCondition : uint {
		Undefined,
		Equal,
		GreaterThan,
		LessThan,
	}
}
