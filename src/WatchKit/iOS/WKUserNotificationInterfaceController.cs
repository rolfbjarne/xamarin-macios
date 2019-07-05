#if __IOS__
using System;
using System.ComponentModel;

using Foundation;
using ObjCRuntime;

namespace WatchKit {
	[Register ("WKUserNotificationInterfaceController", SkipRegistration = true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	[Unavailable (PlatformName.iOS, PlatformArchitecture.All)]
	[Obsolete ("The WatchKit framework has been removed from iOS", true)]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public class WKUserNotificationInterfaceController : WKInterfaceController {
		public override IntPtr ClassHandle { get { throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS"); } }

		protected WKUserNotificationInterfaceController (NSObjectFlag t) : base (t)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		protected internal WKUserNotificationInterfaceController (IntPtr handle) : base (handle)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		public WKUserNotificationInterfaceController ()
			: base (NSObjectFlag.Empty)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		public virtual void DidReceiveLocalNotification (global::UIKit.UILocalNotification localNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		public virtual void DidReceiveNotification (global::UserNotifications.UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		public virtual void DidReceiveRemoteNotification (NSDictionary remoteNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V209))]global::System.Action<WKUserNotificationInterfaceType> completionHandler)
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}

		public virtual void DismissController ()
		{
			throw new PlatformNotSupportedException ("The WatchKit framework has been removed from iOS");
		}
	} /* class WKUserNotificationInterfaceController */
}
#endif // __IOS__
