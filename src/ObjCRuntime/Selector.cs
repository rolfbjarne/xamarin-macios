//
// Copyright 2010, Novell, Inc.
// Copyright 2013 - 2014 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;

using CoreFoundation;
using Foundation;

#if !NET
using NativeHandle = System.IntPtr;
#endif

#nullable enable

namespace ObjCRuntime {
	public partial class Selector : NonRefcountedNativeObject, IEquatable<Selector> {
		internal const string Alloc = "alloc";
		internal const string Class = "class";
		internal const string Autorelease = "autorelease";
		internal const string PerformSelectorOnMainThreadWithObjectWaitUntilDone = "performSelectorOnMainThread:withObject:waitUntilDone:";
#if MONOMAC
		internal const string DoesNotRecognizeSelector = "doesNotRecognizeSelector:";
		internal const string PerformSelectorWithObjectAfterDelay = "performSelector:withObject:afterDelay:";
#endif

		string? name;

		public Selector (NativeHandle sel)
			: base (sel, false)
		{
			if (!sel_isMapped (sel))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (sel), "Not a selector handle.");
		}

		// this .ctor is required, like for any INativeObject implementation
		// even if selectors are not disposable
		[Preserve (Conditional = true)]
		internal Selector (IntPtr handle, bool /* unused */ owns)
			: base (handle, owns)
		{
		}

		protected override void Free ()
		{
			// Nothing to do here.
		}

		public Selector (string name)
			: base (GetHandle (name), false)
		{
			this.name = name;
		}

		public string Name {
			get {
				if (name == null)
					name = GetName (Handle);
				return name;
			}
		}

		public static bool operator!= (Selector left, Selector right) {
			return !(left == right);
		}

		public static bool operator== (Selector left, Selector right) {
			if (left is null)
				return (right is null);
			if (right is null)
				return false;

			// note: there's a sel_isEqual function but it's safe to compare pointers
			// ref: https://opensource.apple.com/source/objc4/objc4-551.1/runtime/objc-sel.mm.auto.html
			return left.Handle == right.Handle;
		}

		public override bool Equals (object? right)
		{
			return Equals (right as Selector);
		}

		public bool Equals (Selector? right)
		{
			if (right is null)
				return false;

			return Handle == right.Handle;
		}

		public override int GetHashCode ()
		{
			return Handle.GetHashCode ();
		}

		internal static string GetName (IntPtr handle)
		{
			return Marshal.PtrToStringAuto (sel_getName (handle))!;
		}

		// return null, instead of throwing, if an invalid pointer is used (e.g. IntPtr.Zero)
		// so this looks better in the debugger watch when no selector is assigned (ref: #10876)
		public static Selector? FromHandle (IntPtr sel)
		{
			if (!sel_isMapped (sel))
				return null;
			// create the selector without duplicating the sel_isMapped check
			return new Selector (sel, false);
		}

		public static Selector Register (IntPtr handle)
		{
			return new Selector (handle);
		}

		// objc/runtime.h
		[DllImport ("/usr/lib/libobjc.dylib")]
		extern static /* const char* */ IntPtr sel_getName (/* SEL */ IntPtr sel);

		// objc/runtime.h
		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint="sel_registerName")]
		public extern static /* SEL */ IntPtr GetHandle (/* const char* */ string name);

		// objc/objc.h
		[DllImport ("/usr/lib/libobjc.dylib")]
		[return: MarshalAs (UnmanagedType.U1)]
		extern static /* BOOL */ bool sel_isMapped (/* SEL */ IntPtr sel);
	}
}
