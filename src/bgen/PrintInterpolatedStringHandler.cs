// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Runtime.CompilerServices;
using System.Text;

/// <summary>
/// Custom interpolated string handler that writes directly to a reusable StringBuilder,
/// avoiding the intermediate string allocation that would otherwise occur with $"..." in print() calls.
/// </summary>
[InterpolatedStringHandler]
public ref struct PrintInterpolatedStringHandler {
	readonly StringBuilder sb;

	public PrintInterpolatedStringHandler (int literalLength, int formattedCount, Generator generator)
	{
		sb = generator.reusable_print;
		sb.Clear ();
		sb.EnsureCapacity (literalLength + formattedCount * 8);
	}

	public void AppendLiteral (string s) => sb.Append (s);

	public void AppendFormatted<T> (T value) => sb.Append (value);

	public void AppendFormatted<T> (T value, string? format) => sb.AppendFormat ("{0:" + format + "}", value);

	public void AppendFormatted (string? value) => sb.Append (value);

	public void AppendFormatted (ReadOnlySpan<char> value) => sb.Append (value);

	internal StringBuilder GetStringBuilder () => sb;
}
