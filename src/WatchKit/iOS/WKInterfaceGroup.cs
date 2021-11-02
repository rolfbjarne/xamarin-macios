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
	[Register ("WKInterfaceGroup", SkipRegistration = true)]
#if NET
	[UnsupportedOSPlatform ("ios")]
#else
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
#endif
	[Obsolete (Constants.WatchKitRemoved)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public class WKInterfaceGroup : WKInterfaceObject, IWKImageAnimatable {
		public override NativeHandle ClassHandle { get { throw new PlatformNotSupportedException (Constants.WatchKitRemoved); } }

		protected WKInterfaceGroup (NSObjectFlag t) : base (t)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		protected internal WKInterfaceGroup (NativeHandle handle) : base (handle)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetBackgroundColor (global::UIKit.UIColor color)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetBackgroundImage (global::UIKit.UIImage image)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetBackgroundImage (NSData imageData)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetBackgroundImage (string imageName)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void SetCornerRadius (nfloat cornerRadius)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void StartAnimating ()
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void StartAnimating (NSRange imageRange, double duration, nint repeatCount)
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}

		public virtual void StopAnimating ()
		{
			throw new PlatformNotSupportedException (Constants.WatchKitRemoved);
		}
	} /* class WKInterfaceGroup */
}
#endif // __IOS__
