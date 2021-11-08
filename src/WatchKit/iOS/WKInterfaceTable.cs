#if __IOS__
using System;
using System.ComponentModel;
using System.Runtime.Versioning;

using Foundation;
using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace WatchKit {
	[Register ("WKInterfaceTable", SkipRegistration = true)]
#if NET
	[UnsupportedOSPlatform ("ios")]
#else
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
#endif
	[Obsolete (Constants.WatchKitRemoved)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public class WKInterfaceTable : WKInterfaceObject {
		public override NativeHandle ClassHandle { get { throw new PlatformNotSupportedException (Constants.WatchKitRemoved); } }

		protected WKInterfaceTable (NSObjectFlag t) : base (t)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		protected internal WKInterfaceTable (IntPtr handle) : base (handle)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual NSObject GetRowController (nint index)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void InsertRows (NSIndexSet rowIndexes, string rowType)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void RemoveRows (NSIndexSet rowIndexes)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void ScrollToRow (nint index)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetNumberOfRows (nint numberOfRows, string rowType)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetRowTypes (string[] rowTypes)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual nint NumberOfRows {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}
	} /* class WKInterfaceTable */
}
#endif // __IOS__
