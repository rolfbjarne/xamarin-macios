//
// NSArray_GameplayKit.cs: Generic extensions to NSArray
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

#nullable enable

namespace GameplayKit {
	/// <summary>Gets or sets the n s array_ gameplay kit.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public static class NSArray_GameplayKit {

		/// <typeparam name="T">The type of elements in the array.</typeparam>
		///         <param name="This">The instance on which this method operates.</param>
		///         <param name="randomSource">The random source.</param>
		/// <summary>Returns a shuffled copy of the array using the specified random source.</summary>
		[Export ("shuffledArrayWithRandomSource:")]
		public static T [] GetShuffledArray<T> (this NSArray This, GKRandomSource randomSource) where T : class, INativeObject
		{
			if (randomSource is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (randomSource));
			var result = NSArray.NonNullArrayFromHandleDropNullElements<T> (Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("shuffledArrayWithRandomSource:"), randomSource.Handle));
			GC.KeepAlive (This);
			GC.KeepAlive (randomSource);
			return result;
		}

		/// <typeparam name="T">The type of elements in the array.</typeparam>
		///         <param name="This">The instance on which this method operates.</param>
		/// <summary>Returns a shuffled copy of the array.</summary>
		[Export ("shuffledArray")]
		public static T [] GetShuffledArray<T> (this NSArray This) where T : class, INativeObject
		{
			var result = NSArray.NonNullArrayFromHandleDropNullElements<T> (Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("shuffledArray")));
			GC.KeepAlive (This);
			return result;
		}
	}
}
