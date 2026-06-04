// 
// CMMemoryPool.cs: Implements the managed CMMemoryPool
//
// Authors: Marek Safar (marek.safar@gmail.com)
//     
// Copyright 2012-2014 Xamarin Inc
//

#nullable enable

using CoreFoundation;

namespace CoreMedia {

	public partial class CMMemoryPool : NativeObject {
		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* CMMemoryPoolRef */ IntPtr CMMemoryPoolCreate (/* CFDictionaryRef */ IntPtr options);

		/// <summary>To be added.</summary>
		public CMMemoryPool ()
			: base (CMMemoryPoolCreate (IntPtr.Zero), true)
		{
		}

#if !COREBUILD
		static IntPtr Create (TimeSpan ageOutPeriod)
		{
			using (var n = new NSNumber (ageOutPeriod.TotalSeconds))
			using (var dict = new NSDictionary (AgeOutPeriodSelector, n)) {
				return CMMemoryPoolCreate (dict.Handle);
			}
		}

		/// <param name="ageOutPeriod">The age out period.</param>
		///         <summary>To be added.</summary>
		public CMMemoryPool (TimeSpan ageOutPeriod)
			: base (Create (ageOutPeriod), true)
		{
		}
#endif

		[DllImport (Constants.CoreMediaLibrary)]
		extern static /* CFAllocatorRef */ IntPtr CMMemoryPoolGetAllocator (/* CMMemoryPoolRef */ IntPtr pool);

		/// <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public CFAllocator GetAllocator ()
		{
			return new CFAllocator (CMMemoryPoolGetAllocator (Handle), false);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static void CMMemoryPoolFlush (/* CMMemoryPoolRef */ IntPtr pool);

		/// <summary>To be added.</summary>
		public void Flush ()
		{
			CMMemoryPoolFlush (Handle);
		}

		[DllImport (Constants.CoreMediaLibrary)]
		extern static void CMMemoryPoolInvalidate (/* CMMemoryPoolRef */ IntPtr pool);

		/// <summary>To be added.</summary>
		public void Invalidate ()
		{
			CMMemoryPoolInvalidate (Handle);
		}
	}
}
