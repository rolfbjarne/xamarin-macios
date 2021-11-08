#if __IOS__
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Versioning;

using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace WatchKit {
	[Register ("WKInterfaceDevice", SkipRegistration = true)]
#if NET
	[UnsupportedOSPlatform ("ios")]
#else
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
#endif
	[Obsolete (Constants.WatchKitRemoved)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public class WKInterfaceDevice : NSObject {
		public override NativeHandle ClassHandle { get { throw new PlatformNotSupportedException (Constants.WatchKitRemoved); } }

		protected WKInterfaceDevice (NSObjectFlag t) : base (t)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		protected internal WKInterfaceDevice (IntPtr handle) : base (handle)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual bool AddCachedImage (global::UIKit.UIImage image, string name)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual bool AddCachedImage (NSData imageData, string name)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void RemoveAllCachedImages ()
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void RemoveCachedImage (string name)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public static WKInterfaceDevice CurrentDevice {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual string LocalizedModel {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual string Model {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual string Name {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual CGRect ScreenBounds {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual nfloat ScreenScale {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual string SystemName {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual string SystemVersion {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public virtual NSDictionary WeakCachedImages {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public IReadOnlyDictionary<string,long> CachedImages {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public UIContentSizeCategory PreferredContentSizeCategory {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public string PreferredContentSizeCategoryString {
			get {
				throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
			}
		}

		public bool CheckSystemVersion (int major, int minor)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}
	} /* class WKInterfaceDevice */
}
#endif // __IOS__
