//
// This file contains a generic version of NSArray
//
// Authors:
//		Alex Soto	(alex.soto@xamarin.com)
//
// Copyright 2015, Xamarin Inc.
//

#nullable enable

using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace Foundation {
#if false // https://github.com/xamarin/xamarin-macios/issues/15577
	public delegate bool NSOrderedCollectionDifferenceEquivalenceTest<TValue> (TValue? first, TValue? second);
	internal delegate bool NSOrderedCollectionDifferenceEquivalenceTestProxy (IntPtr blockLiteral, /* NSObject */ IntPtr first, /* NSObject */ IntPtr second);
#endif
#if NET
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("tvos12.2")]
#endif
	[Register (SkipRegistration = true)]
	public sealed partial class NSArray<TKey> : NSArray, IEnumerable<TKey>
		where TKey : class, INativeObject {

		public NSArray ()
		{
		}

		public NSArray (NSCoder coder) : base (coder)
		{
		}

		internal NSArray (NativeHandle handle) : base (handle)
		{
		}

		static public NSArray<TKey> FromNSObjects (params TKey [] items)
		{
			if (items is null)
				throw new ArgumentNullException (nameof (items));

			return FromNSObjects (items.Length, items);
		}

		static public NSArray<TKey> FromNSObjects (int count, params TKey [] items)
		{
			if (items is null)
				throw new ArgumentNullException (nameof (items));

			if (count > items.Length)
				throw new ArgumentException ("count is larger than the number of items", "count");

			IntPtr buf = Marshal.AllocHGlobal ((IntPtr) (count * IntPtr.Size));
			for (nint i = 0; i < count; i++) {
				var item = items [i];
				IntPtr h = item is null ? NSNull.Null.Handle : item.Handle;
				Marshal.WriteIntPtr (buf, (int) (i * IntPtr.Size), h);
			}
			IntPtr ret = NSArray.FromObjects (buf, count);
			var arr = Runtime.GetNSObject<NSArray<TKey>> (ret)!;
			Marshal.FreeHGlobal (buf);
			return arr;
		}

		#region IEnumerable<TKey>
		/// <summary>Returns an enumerator that iterates through the array.</summary>
		/// <returns>An enumerator that can be used to iterate through the array.</returns>
		public new IEnumerator<TKey> GetEnumerator ()
		{
			return new NSFastEnumerator<TKey> (this);
		}
		#endregion

		#region IEnumerable implementation
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return new NSFastEnumerator<TKey> (this);
		}
		#endregion

		public TKey this [nint idx] {
			get {
				return GetItem<TKey> ((nuint) idx);
			}
		}

		public new TKey [] ToArray ()
		{
			return base.ToArray<TKey> ();
		}

#if false // https://github.com/xamarin/xamarin-macios/issues/15577

#if !NET
		[TV (13,0), iOS (13,0)]
#else
		[SupportedOSPlatform ("macos12.0")]
#endif
		public NSOrderedCollectionDifference<TKey>? GetDifference (TKey[] other, NSOrderedCollectionDifferenceCalculationOptions options)
			=> Runtime.GetNSObject <NSOrderedCollectionDifference<TKey>> (_GetDifference (NSArray.FromNSObjects (other), options));

#if !NET
		[TV (13,0), iOS (13,0)]
#else
		[SupportedOSPlatform ("macos12.0")]
#endif
		public NSOrderedCollectionDifference<TKey>? GetDifference (TKey[] other)
			=> Runtime.GetNSObject <NSOrderedCollectionDifference<TKey>> (_GetDifference (NSArray.FromNSObjects (other)));

#if !NET
		[TV (13,0), iOS (13,0)]
#else
		[SupportedOSPlatform ("macos12.0")]
#endif
		public TKey[]? GetArrayByApplyingDifference (NSOrderedCollectionDifference difference)
			=> NSArray.ArrayFromHandle<TKey> (_GetArrayByApplyingDifference (difference));
		static readonly NSOrderedCollectionDifferenceEquivalenceTestProxy static_DiffEqualityGeneric = DiffEqualityHandlerGeneric;

		[MonoPInvokeCallback (typeof (NSOrderedCollectionDifferenceEquivalenceTestProxy))]
		static bool DiffEqualityHandlerGeneric (IntPtr block, IntPtr first, IntPtr second)
		{
			var callback = BlockLiteral.GetTarget<NSOrderedCollectionDifferenceEquivalenceTest<TKey>> (block);
			if (callback is not null) {
				var nsFirst = Runtime.GetINativeObject<TKey> (first, false);
				var nsSecond = Runtime.GetINativeObject<TKey> (second, false);
				return callback (nsFirst, nsSecond);
			}
			return false;
		}

#if !NET
		[TV (13,0), iOS (13,0)]
#else
		[SupportedOSPlatform ("macos12.0")]
#endif
		public NSOrderedCollectionDifference<TKey>? GetDifferenceFromArray (NSArray<TKey> other, NSOrderedCollectionDifferenceCalculationOptions options, NSOrderedCollectionDifferenceEquivalenceTest<TKey> equivalenceTest) 
		{
			if (equivalenceTest is null)
				throw new ArgumentNullException (nameof (equivalenceTest));

			var block = new BlockLiteral ();
			block.SetupBlock (static_DiffEqualityGeneric, equivalenceTest);
			try {
				return Runtime.GetNSObject<NSOrderedCollectionDifference<TKey>> (_GetDifferenceFromArray (other, options, ref block));
			} finally {
				block.CleanupBlock ();
			}
		}
#endif
	}
}
