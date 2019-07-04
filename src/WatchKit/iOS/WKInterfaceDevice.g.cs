//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace WatchKit {
	[Register("WKInterfaceDevice", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceDevice : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceDevice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceDevice (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceDevice (IntPtr handle) : base (handle)
		{
		}

		[Export ("addCachedImage:name:")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddCachedImage (global::UIKit.UIImage image, string name)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCachedImage:name:"), image.Handle, nsname);
			} else {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCachedImage:name:"), image.Handle, nsname);
			}
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("addCachedImageWithData:name:")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddCachedImage (NSData imageData, string name)
		{
			if (imageData == null)
				throw new ArgumentNullException ("imageData");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCachedImageWithData:name:"), imageData.Handle, nsname);
			} else {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCachedImageWithData:name:"), imageData.Handle, nsname);
			}
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("removeAllCachedImages")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllCachedImages ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllCachedImages"));
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllCachedImages"));
			}
		}
		
		[Export ("removeCachedImageWithName:")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCachedImage (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCachedImageWithName:"), nsname);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCachedImageWithName:"), nsname);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WKInterfaceDevice CurrentDevice {
			[Export ("currentDevice")]
			get {
				WKInterfaceDevice ret;
				ret =  Runtime.GetNSObject<WKInterfaceDevice> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentDevice")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		public virtual string LocalizedModel {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
			[Export ("localizedModel")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("localizedModel")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("localizedModel")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		public virtual string Model {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
			[Export ("model")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("model")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("model")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		public virtual string Name {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ScreenBounds {
			[Export ("screenBounds")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("screenBounds"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("screenBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("screenBounds"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("screenBounds"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("screenBounds"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("screenBounds"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("screenBounds"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("screenBounds"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ScreenScale {
			[Export ("screenScale")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("screenScale"));
				} else {
					return global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("screenScale"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		public virtual string SystemName {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
			[Export ("systemName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("systemName")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("systemName")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
		public virtual string SystemVersion {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 2,0, PlatformArchitecture.All)]
			[Export ("systemVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("systemVersion")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("systemVersion")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		public virtual NSDictionary WeakCachedImages {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Export ("cachedImages")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cachedImages")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cachedImages")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSString _PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			get {
				NSString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSizeCategory")));
				} else {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("preferredContentSizeCategory")));
				}
				return ret;
			}
			
		}
		
	} /* class WKInterfaceDevice */
}
