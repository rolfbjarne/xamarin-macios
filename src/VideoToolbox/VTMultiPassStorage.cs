// 
// VTMultiPassStorage.cs: VideoToolbox VTMultiPassStorage class
//
// Authors:
//	Alex Soto (alex.soto@xamarin.com)
//     
// Copyright 2015 Xamarin Inc.
//

#nullable enable

using CoreFoundation;
using CoreMedia;

namespace VideoToolbox {
	/// <summary>Class that provides a storage for encoding metadata.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public class VTMultiPassStorage : NativeObject {
		bool closed;
		VTStatus closedStatus;

		[Preserve (Conditional = true)]
		internal VTMultiPassStorage (NativeHandle handle, bool owns)
			: base (handle, false)
		{
		}

		/// <inheritdoc />
		protected override void Dispose (bool disposing)
		{
			if (Handle != IntPtr.Zero)
				Close ();
			base.Dispose (disposing);
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		unsafe extern static /* OSStatus */ VTStatus VTMultiPassStorageCreate (
			/* CFAllocatorRef */IntPtr allocator, /* can be null */
			/* CFURLRef */ IntPtr fileUrl, /* can be null */
			/* CMTimeRange */ CMTimeRange timeRange, /* can be kCMTimeRangeInvalid */
			/* CFDictionaryRef */ IntPtr options, /* can be null */
			/* VTMultiPassStorageRef */ IntPtr* multiPassStorageOut);

		// Convenience method taking a strong dictionary
		/// <param name="options">The options to use.</param>
		///         <param name="fileUrl">The file url.</param>
		///         <param name="timeRange">The time range.</param>
		///         <summary>Create.</summary>
		public static VTMultiPassStorage? Create (
			VTMultiPassStorageCreationOptions? options,
			NSUrl? fileUrl = null,
			CMTimeRange? timeRange = null)
		{
			return Create (fileUrl, timeRange, options?.Dictionary);
		}

		/// <param name="fileUrl">The file url.</param>
		///         <param name="timeRange">The time range.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Create.</summary>
		public static VTMultiPassStorage? Create (
			NSUrl? fileUrl = null,
			CMTimeRange? timeRange = null,
			NSDictionary? options = null)
		{
			VTStatus status;
			IntPtr ret;
			unsafe {
				status = VTMultiPassStorageCreate (
				IntPtr.Zero,
				fileUrl.GetHandle (),
				timeRange ?? CMTimeRange.InvalidRange,
				options.GetHandle (),
				&ret);
				GC.KeepAlive (fileUrl);
				GC.KeepAlive (options);
			}

			if (status != VTStatus.Ok)
				return null;

			return new VTMultiPassStorage (ret, true);
		}

		[DllImport (Constants.VideoToolboxLibrary)]
		extern static /* OSStatus */ VTStatus VTMultiPassStorageClose (/* VTMultiPassStorage */ IntPtr multiPassStorage);

		/// <summary>Close.</summary>
		public VTStatus Close ()
		{
			if (closed)
				return closedStatus;
			closedStatus = VTMultiPassStorageClose (Handle);
			closed = true;
			return closedStatus;
		}
	}
}
