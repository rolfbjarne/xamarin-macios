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
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVAudioSessionInterruptionEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVAudioSessionInterruptionEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVAudioSessionInterruptionEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionInterruptionTypeKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionInterruptionType InterruptionType {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionTypeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionInterruptionType);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionInterruptionType) nsn.UInt64Value;
			}
		}
		[Field ("AVAudioSessionInterruptionOptionKey", "AVFoundation")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionInterruptionOptions Option {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionOptionKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionInterruptionOptions);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionInterruptionOptions) nsn.UInt64Value;
			}
		}
		[Field ("AVAudioSessionInterruptionWasSuspendedKey", "AVFoundation")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean? WasSuspended {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionWasSuspendedKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				if (value == IntPtr.Zero)
					return null;
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.BoolValue;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVCaptureSessionRuntimeErrorEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVCaptureSessionRuntimeErrorEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVCaptureSessionRuntimeErrorEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVCaptureSessionErrorKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSError Error {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVCaptureSessionErrorKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSError> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVPlayerRateDidChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVPlayerRateDidChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVPlayerRateDidChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVPlayerRateDidChangeReasonKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSString RateDidChangeStringReason {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeReasonKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSString> (value)!;
			}
		}
		[Field ("AVPlayerRateDidChangeOriginatingParticipantKey", "AVFoundation")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSString RateDidChangeOriginatingParticipant {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVPlayerRateDidChangeOriginatingParticipantKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSString> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVPlayerItemErrorEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVPlayerItemErrorEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVPlayerItemErrorEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVPlayerItemFailedToPlayToEndTimeErrorKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSError Error {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeErrorKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSError> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVPlayerItemTimeJumpedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVPlayerItemTimeJumpedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVPlayerItemTimeJumpedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVPlayerItemTimeJumpedOriginatingParticipantKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSString OriginatingParticipant {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVPlayerItemTimeJumpedOriginatingParticipantKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSString> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AudioRendererWasFlushedAutomaticallyEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AudioRendererWasFlushedAutomaticallyEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AudioRendererWasFlushedAutomaticallyEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVSampleBufferAudioRendererFlushTimeKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal Foundation.NSValue _AudioRendererFlushTime {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVSampleBufferAudioRendererFlushTimeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSValue> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSAnimationProgressMarkEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSAnimationProgressMarkEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSAnimationProgressMarkEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSAnimationProgressMark", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Single Progress {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSAnimationProgressMark");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(float);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.FloatValue;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSApplicationDidFinishLaunchingEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSApplicationDidFinishLaunchingEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSApplicationDidFinishLaunchingEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSApplicationLaunchIsDefaultLaunchKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean IsLaunchDefault {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSApplicationLaunchIsDefaultLaunchKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(bool);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.BoolValue;
			}
		}
		[Field ("NSApplicationLaunchUserNotificationKey", "AppKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean IsLaunchFromUserNotification {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSApplicationLaunchUserNotificationKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return false;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return value != IntPtr.Zero;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSControlTextEditingEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSControlTextEditingEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSControlTextEditingEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSFontCollectionChangedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSFontCollectionChangedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSFontCollectionChangedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSFontCollectionActionKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal Foundation.NSString _Action {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSFontCollectionActionKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSString> (value)!;
			}
		}
		[Field ("NSFontCollectionNameKey", "AppKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String Name {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSFontCollectionNameKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSFontCollectionOldNameKey", "AppKit")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String OldName {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSFontCollectionOldNameKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSFontCollectionVisibilityKey", "AppKit")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal Foundation.NSNumber _Visibility {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSFontCollectionVisibilityKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				return Runtime.GetNSObject<NSNumber> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSMenuItemIndexEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSMenuItemIndexEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSMenuItemIndexEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSMenuItemEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSMenuItemEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSMenuItemEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSViewColumnMoveEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSViewColumnMoveEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSViewColumnMoveEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSViewColumnResizeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSViewColumnResizeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSViewColumnResizeEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSOutlineViewItemEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSOutlineViewItemEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSOutlineViewItemEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSPopoverCloseEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSPopoverCloseEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSPopoverCloseEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSPopoverCloseReasonKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal Foundation.NSString _Reason {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSPopoverCloseReasonKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSString> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSSplitViewDividerIndexEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSSplitViewDividerIndexEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSSplitViewDividerIndexEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSTextDidEndEditingEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSTextDidEndEditingEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSTextDidEndEditingEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSTextAlternativesSelectedAlternativeStringEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSTextAlternativesSelectedAlternativeStringEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSTextAlternativesSelectedAlternativeStringEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSTextViewDidChangeSelectionEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSTextViewDidChangeSelectionEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSTextViewDidChangeSelectionEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSTextViewWillChangeNotifyingTextViewEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSTextViewWillChangeNotifyingTextViewEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSTextViewWillChangeNotifyingTextViewEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSToolbarItemEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSToolbarItemEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSToolbarItemEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSToolbarItemKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AppKit.NSToolbarItem Item {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSToolbarItemKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSToolbarItem> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWindowBackingPropertiesEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWindowBackingPropertiesEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWindowBackingPropertiesEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSBackingPropertyOldScaleFactorKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.IntPtr OldScaleFactor {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSBackingPropertyOldScaleFactorKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(IntPtr);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.NIntValue;
			}
		}
		[Field ("NSBackingPropertyOldColorSpaceKey", "AppKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AppKit.NSColorSpace OldColorSpace {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSBackingPropertyOldColorSpaceKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSColorSpace> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWindowExposeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWindowExposeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWindowExposeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		public CoreGraphics.CGRect ExposedRect {
			get {
				NativeHandle value;
				using (var str = new NSString ("NSExposedRect")){
					var userinfo = Notification.UserInfo;
					if (userinfo is null)
						value = IntPtr.Zero;
					else
						value = userinfo.LowlevelObjectForKey (str.Handle);
				}
				if (value == IntPtr.Zero)
					return default(CGRect);
				using (var nsv = Runtime.GetNSObject<NSValue> (value)!)
					return nsv.CGRectValue;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWorkspaceApplicationEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWorkspaceApplicationEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWorkspaceApplicationEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSWorkspaceApplicationKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AppKit.NSRunningApplication Application {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceApplicationKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSRunningApplication> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWorkspaceMountEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWorkspaceMountEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWorkspaceMountEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSWorkspaceVolumeLocalizedNameKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String VolumeLocalizedName {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeLocalizedNameKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSWorkspaceVolumeURLKey", "AppKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUrl VolumeUrl {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeURLKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSUrl> (value)!;
			}
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWorkspaceFileOperationEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWorkspaceFileOperationEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWorkspaceFileOperationEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
namespace AppKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSWorkspaceRenamedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSWorkspaceRenamedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSWorkspaceRenamedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSWorkspaceVolumeLocalizedNameKey", "AppKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String VolumeLocalizedName {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeLocalizedNameKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSWorkspaceVolumeURLKey", "AppKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUrl VolumeUrl {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeURLKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSUrl> (value)!;
			}
		}
		[Field ("NSWorkspaceVolumeOldLocalizedNameKey", "AppKit")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String OldVolumeLocalizedName {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeOldLocalizedNameKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSWorkspaceVolumeOldURLKey", "AppKit")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUrl OldVolumeUrl {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AppKit.Handle, "NSWorkspaceVolumeOldURLKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				return Runtime.GetNSObject<NSUrl> (value)!;
			}
		}
	}
}
namespace CoreData {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSManagedObjectsIdsChangedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSManagedObjectsIdsChangedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSManagedObjectsIdsChangedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSDeletedObjectIDsKey", "CoreData")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet DeletedObjectIds {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSDeletedObjectIDsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSInsertedObjectIDsKey", "CoreData")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet InsertedObjectIdsKey {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSInsertedObjectIDsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSInvalidatedObjectIDsKey", "CoreData")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet InvalidatedObjectIdsKey {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSInvalidatedObjectIDsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSRefreshedObjectIDsKey", "CoreData")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet RefreshedObjectIdsKey {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSRefreshedObjectIDsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSUpdatedObjectIDsKey", "CoreData")]
		static IntPtr k4;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet UpdatedObjectIdsKey {
			get {
				NativeHandle value;
				if (k4 == IntPtr.Zero)
					k4 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSUpdatedObjectIDsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k4);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
	}
}
namespace CoreData {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSManagedObjectChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSManagedObjectChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSManagedObjectChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSInsertedObjectsKey", "CoreData")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet InsertedObjects {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSInsertedObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSUpdatedObjectsKey", "CoreData")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet UpdatedObjects {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSUpdatedObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSDeletedObjectsKey", "CoreData")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet DeletedObjects {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSDeletedObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSRefreshedObjectsKey", "CoreData")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet RefreshedObjects {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSRefreshedObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSInvalidatedObjectsKey", "CoreData")]
		static IntPtr k4;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSSet InvalidatedObjects {
			get {
				NativeHandle value;
				if (k4 == IntPtr.Zero)
					k4 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSInvalidatedObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k4);
				return Runtime.GetNSObject<NSSet> (value)!;
			}
		}
		[Field ("NSInvalidatedAllObjectsKey", "CoreData")]
		static IntPtr k5;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean InvalidatedAllObjects {
			get {
				NativeHandle value;
				if (k5 == IntPtr.Zero)
					k5 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSInvalidatedAllObjectsKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return false;
				else
					value = userinfo.LowlevelObjectForKey (k5);
				return value != IntPtr.Zero;
			}
		}
	}
}
namespace CoreData {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSPersistentStoreRemoteChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSPersistentStoreRemoteChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSPersistentStoreRemoteChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSStoreUUIDKey", "CoreData")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUuid Uuid {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSStoreUUIDKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSUuid> (value)!;
			}
		}
		[Field ("NSPersistentStoreURLKey", "CoreData")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String Url {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSPersistentStoreURLKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("NSPersistentHistoryTokenKey", "CoreData")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CoreData.NSPersistentHistoryToken PersistentHistoryTracking {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSPersistentHistoryTokenKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return Runtime.GetNSObject<CoreData.NSPersistentHistoryToken> (value)!;
			}
		}
	}
}
namespace CoreData {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSPersistentStoreCoordinatorStoreChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSPersistentStoreCoordinatorStoreChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSPersistentStoreCoordinatorStoreChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSPersistentStoreUbiquitousTransitionTypeKey", "CoreData")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CoreData.NSPersistentStoreUbiquitousTransitionType EventType {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousTransitionTypeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(CoreData.NSPersistentStoreUbiquitousTransitionType);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (CoreData.NSPersistentStoreUbiquitousTransitionType) nsn.UInt64Value;
			}
		}
	}
}
namespace ExternalAccessory {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class EAAccessoryEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="EAAccessoryEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public EAAccessoryEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("EAAccessoryKey", "ExternalAccessory")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ExternalAccessory.EAAccessory Accessory {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.ExternalAccessory.Handle, "EAAccessoryKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<ExternalAccessory.EAAccessory> (value)!;
			}
		}
		[Field ("EAAccessorySelectedKey", "ExternalAccessory")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ExternalAccessory.EAAccessory Selected {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.ExternalAccessory.Handle, "EAAccessorySelectedKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<ExternalAccessory.EAAccessory> (value)!;
			}
		}
	}
}
namespace Foundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSFileHandleConnectionAcceptedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSFileHandleConnectionAcceptedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSFileHandleConnectionAcceptedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSFileHandleNotificationFileHandleItem", "Foundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSFileHandle NearSocketConnection {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.Foundation.Handle, "NSFileHandleNotificationFileHandleItem");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSFileHandle> (value)!;
			}
		}
		public System.IntPtr UnixErrorCode {
			get {
				NativeHandle value;
				using (var str = new NSString ("NSFileHandleError")){
					var userinfo = Notification.UserInfo;
					if (userinfo is null)
						value = IntPtr.Zero;
					else
						value = userinfo.LowlevelObjectForKey (str.Handle);
				}
				if (value == IntPtr.Zero)
					return default(IntPtr);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.NIntValue;
			}
		}
	}
}
namespace Foundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSFileHandleReadEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSFileHandleReadEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSFileHandleReadEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSFileHandleNotificationDataItem", "Foundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSData AvailableData {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.Foundation.Handle, "NSFileHandleNotificationDataItem");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSData> (value)!;
			}
		}
		public System.IntPtr UnixErrorCode {
			get {
				NativeHandle value;
				using (var str = new NSString ("NSFileHandleError")){
					var userinfo = Notification.UserInfo;
					if (userinfo is null)
						value = IntPtr.Zero;
					else
						value = userinfo.LowlevelObjectForKey (str.Handle);
				}
				if (value == IntPtr.Zero)
					return default(IntPtr);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.NIntValue;
			}
		}
	}
}
namespace Foundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSUbiquitousKeyValueStoreChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSUbiquitousKeyValueStoreChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSUbiquitousKeyValueStoreChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSUbiquitousKeyValueStoreChangedKeysKey", "Foundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String[] ChangedKeys {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangedKeysKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return Array.Empty<string> ();
				return CFArray.StringArrayFromHandle (value)!;
			}
		}
		[Field ("NSUbiquitousKeyValueStoreChangeReasonKey", "Foundation")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUbiquitousKeyValueStoreChangeReason ChangeReason {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangeReasonKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(NSUbiquitousKeyValueStoreChangeReason);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (Foundation.NSUbiquitousKeyValueStoreChangeReason) nsn.Int64Value;
			}
		}
	}
}
namespace Foundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class NSUndoManagerCloseUndoGroupEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="NSUndoManagerCloseUndoGroupEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public NSUndoManagerCloseUndoGroupEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("NSUndoManagerGroupIsDiscardableKey", "Foundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean? Discardable {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.Foundation.Handle, "NSUndoManagerGroupIsDiscardableKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return null;
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.BoolValue;
			}
		}
	}
}
namespace PdfKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class PdfViewAnnotationHitEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="PdfViewAnnotationHitEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public PdfViewAnnotationHitEventArgs (NSNotification notification) : base (notification) 
		{
		}
	}
}
