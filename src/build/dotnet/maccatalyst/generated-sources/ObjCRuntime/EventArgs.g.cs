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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
		[Field ("AVAudioSessionInterruptionReasonKey", "AVFoundation")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionInterruptionReason Reason {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionReasonKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionInterruptionReason);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionInterruptionReason) nsn.UInt64Value;
			}
		}
		[Field ("AVAudioSessionInterruptionWasSuspendedKey", "AVFoundation")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean? WasSuspended {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionWasSuspendedKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k3);
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
	public partial class MicrophoneInjectionCapabilitiesChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MicrophoneInjectionCapabilitiesChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MicrophoneInjectionCapabilitiesChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionMicrophoneInjectionIsAvailableKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean IsAvailable {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionMicrophoneInjectionIsAvailableKey");
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
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class OutputMuteStateChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="OutputMuteStateChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public OutputMuteStateChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionMuteStateKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean IsMuted {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionMuteStateKey");
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
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class RenderingModeChangeNotificationEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="RenderingModeChangeNotificationEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public RenderingModeChangeNotificationEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionRenderingModeNewRenderingModeKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionRenderingMode NewRenderingMode {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionRenderingModeNewRenderingModeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionRenderingMode);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionRenderingMode) nsn.Int64Value;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVAudioSessionRouteChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVAudioSessionRouteChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVAudioSessionRouteChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionRouteChangeReasonKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionRouteChangeReason Reason {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionRouteChangeReasonKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionRouteChangeReason);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionRouteChangeReason) nsn.UInt64Value;
			}
		}
		[Field ("AVAudioSessionRouteChangePreviousRouteKey", "AVFoundation")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionRouteDescription PreviousRoute {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionRouteChangePreviousRouteKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<AVAudioSessionRouteDescription> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class AVAudioSessionSecondaryAudioHintEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="AVAudioSessionSecondaryAudioHintEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public AVAudioSessionSecondaryAudioHintEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionSilenceSecondaryAudioHintNotification", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionSilenceSecondaryAudioHintType Hint {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionSilenceSecondaryAudioHintNotification");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(AVAudioSessionSilenceSecondaryAudioHintType);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (AVFoundation.AVAudioSessionSilenceSecondaryAudioHintType) nsn.UInt64Value;
			}
		}
		[Field ("AVAudioSessionSilenceSecondaryAudioHintTypeKey", "AVFoundation")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVFoundation.AVAudioSessionRouteDescription HintType {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionSilenceSecondaryAudioHintTypeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return Runtime.GetNSObject<AVAudioSessionRouteDescription> (value)!;
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class SpatialPlaybackCapabilitiesChangedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="SpatialPlaybackCapabilitiesChangedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public SpatialPlaybackCapabilitiesChangedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("AVAudioSessionSpatialAudioEnabledKey", "AVFoundation")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean SpatialAudioEnabledKey {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.AVFoundation.Handle, "AVAudioSessionSpatialAudioEnabledKey");
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
namespace MediaPlayer {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class MPMoviePlayerFinishedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MPMoviePlayerFinishedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MPMoviePlayerFinishedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("MPMoviePlayerPlaybackDidFinishReasonUserInfoKey", "MediaPlayer")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MediaPlayer.MPMovieFinishReason FinishReason {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerPlaybackDidFinishReasonUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(MPMovieFinishReason);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (MediaPlayer.MPMovieFinishReason) nsn.Int64Value;
			}
		}
	}
}
namespace MediaPlayer {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class MPMoviePlayerThumbnailEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MPMoviePlayerThumbnailEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MPMoviePlayerThumbnailEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("MPMoviePlayerThumbnailImageKey", "MediaPlayer")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIKit.UIImage Image {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerThumbnailImageKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<UIImage> (value)!;
			}
		}
		[Field ("MPMoviePlayerThumbnailTimeKey", "MediaPlayer")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Double Time {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerThumbnailTimeKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(double);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.DoubleValue;
			}
		}
		[Field ("MPMoviePlayerThumbnailErrorKey", "MediaPlayer")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSError Error {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerThumbnailErrorKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return Runtime.GetNSObject<NSError> (value)!;
			}
		}
	}
}
namespace MediaPlayer {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class MPMoviePlayerTimedMetadataEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MPMoviePlayerTimedMetadataEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MPMoviePlayerTimedMetadataEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("MPMoviePlayerTimedMetadataUserInfoKey", "MediaPlayer")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MediaPlayer.MPTimedMetadata[] TimedMetadata {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerTimedMetadataUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return Array.Empty<MPTimedMetadata> ();
				return CFArray.ArrayFromHandle<MPTimedMetadata> (value)!;
			}
		}
	}
}
namespace MediaPlayer {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class MPMoviePlayerFullScreenEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MPMoviePlayerFullScreenEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MPMoviePlayerFullScreenEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("MPMoviePlayerFullscreenAnimationDurationUserInfoKey", "MediaPlayer")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Double AnimationDuration {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerFullscreenAnimationDurationUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(double);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.DoubleValue;
			}
		}
		[Field ("MPMoviePlayerFullscreenAnimationCurveUserInfoKey", "MediaPlayer")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIKit.UIViewAnimationCurve AnimationCurve {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MediaPlayer.Handle, "MPMoviePlayerFullscreenAnimationCurveUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(UIViewAnimationCurve);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (UIKit.UIViewAnimationCurve) nsn.Int64Value;
			}
		}
	}
}
namespace MessageUI {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class MFMessageAvailabilityChangedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="MFMessageAvailabilityChangedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public MFMessageAvailabilityChangedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("MFMessageComposeViewControllerTextMessageAvailabilityKey", "MessageUI")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean TextMessageAvailability {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.MessageUI.Handle, "MFMessageComposeViewControllerTextMessageAvailabilityKey");
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
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIAccessibilityAnnouncementFinishedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIAccessibilityAnnouncementFinishedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIAccessibilityAnnouncementFinishedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIAccessibilityAnnouncementKeyStringValue", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String Announcement {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIAccessibilityAnnouncementKeyStringValue");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("UIAccessibilityAnnouncementKeyWasSuccessful", "UIKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean WasSuccessful {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIAccessibilityAnnouncementKeyWasSuccessful");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(bool);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.BoolValue;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIContentSizeCategoryChangedEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIContentSizeCategoryChangedEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIContentSizeCategoryChangedEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIContentSizeCategoryNewValueKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSString WeakNewValue {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIContentSizeCategoryNewValueKey");
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
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIStatusBarFrameChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIStatusBarFrameChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIStatusBarFrameChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIApplicationStatusBarFrameUserInfoKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CoreGraphics.CGRect StatusBarFrame {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationStatusBarFrameUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(CGRect);
				using (var nsv = Runtime.GetNSObject<NSValue> (value)!)
					return nsv.CGRectValue;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIStatusBarOrientationChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIStatusBarOrientationChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIStatusBarOrientationChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIApplicationStatusBarOrientationUserInfoKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIKit.UIInterfaceOrientation StatusBarOrientation {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationStatusBarOrientationUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(UIInterfaceOrientation);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (UIKit.UIInterfaceOrientation) nsn.Int64Value;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIApplicationLaunchEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIApplicationLaunchEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIApplicationLaunchEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIApplicationLaunchOptionsURLKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSUrl Url {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationLaunchOptionsURLKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<NSUrl> (value)!;
			}
		}
		[Field ("UIApplicationLaunchOptionsSourceApplicationKey", "UIKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String SourceApplication {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationLaunchOptionsSourceApplicationKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				return CFString.FromHandle (value)!;
			}
		}
		[Field ("UIApplicationLaunchOptionsRemoteNotificationKey", "UIKit")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public Foundation.NSDictionary RemoteNotifications {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationLaunchOptionsRemoteNotificationKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				return Runtime.GetNSObject<NSDictionary> (value)!;
			}
		}
		[Field ("UIApplicationLaunchOptionsLocationKey", "UIKit")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Boolean LocationLaunch {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIApplicationLaunchOptionsLocationKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return false;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				return value != IntPtr.Zero;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIKeyboardEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIKeyboardEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIKeyboardEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIKeyboardFrameBeginUserInfoKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CoreGraphics.CGRect FrameBegin {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIKeyboardFrameBeginUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				if (value == IntPtr.Zero)
					return default(CGRect);
				using (var nsv = Runtime.GetNSObject<NSValue> (value)!)
					return nsv.CGRectValue;
			}
		}
		[Field ("UIKeyboardFrameEndUserInfoKey", "UIKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CoreGraphics.CGRect FrameEnd {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIKeyboardFrameEndUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return default(CGRect);
				using (var nsv = Runtime.GetNSObject<NSValue> (value)!)
					return nsv.CGRectValue;
			}
		}
		[Field ("UIKeyboardAnimationDurationUserInfoKey", "UIKit")]
		static IntPtr k2;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.Double AnimationDuration {
			get {
				NativeHandle value;
				if (k2 == IntPtr.Zero)
					k2 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIKeyboardAnimationDurationUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k2);
				if (value == IntPtr.Zero)
					return default(double);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return nsn.DoubleValue;
			}
		}
		[Field ("UIKeyboardAnimationCurveUserInfoKey", "UIKit")]
		static IntPtr k3;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIKit.UIViewAnimationCurve AnimationCurve {
			get {
				NativeHandle value;
				if (k3 == IntPtr.Zero)
					k3 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIKeyboardAnimationCurveUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k3);
				if (value == IntPtr.Zero)
					return default(UIViewAnimationCurve);
				using (var nsn = Runtime.GetNSObject<NSNumber> (value)!)
					return (UIKit.UIViewAnimationCurve) nsn.Int64Value;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIPasteboardChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIPasteboardChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIPasteboardChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIPasteboardChangedTypesAddedKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String[] TypesAdded {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIPasteboardChangedTypesAddedKey");
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
		[Field ("UIPasteboardChangedTypesRemovedKey", "UIKit")]
		static IntPtr k1;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public System.String[] TypesRemoved {
			get {
				NativeHandle value;
				if (k1 == IntPtr.Zero)
					k1 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIPasteboardChangedTypesRemovedKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					value = IntPtr.Zero;
				else
					value = userinfo.LowlevelObjectForKey (k1);
				if (value == IntPtr.Zero)
					return Array.Empty<string> ();
				return CFArray.StringArrayFromHandle (value)!;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides data for an event based on a posted <see cref="NSNotification" /> object.</summary>
	public partial class UIPointerLockStateDidChangeEventArgs : NSNotificationEventArgs {
		/// <summary>Initializes a new instance of the <see cref="UIPointerLockStateDidChangeEventArgs" /> class.</summary>
		/// <param name="notification">The underlying <see cref="NSNotification" /> object from the posted notification.</param>
		public UIPointerLockStateDidChangeEventArgs (NSNotification notification) : base (notification) 
		{
		}
		[Field ("UIPointerLockStateSceneUserInfoKey", "UIKit")]
		static IntPtr k0;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIKit.UIScene Scene {
			get {
				NativeHandle value;
				if (k0 == IntPtr.Zero)
					k0 = ObjCRuntime.Dlfcn.GetIntPtr (Libraries.UIKit.Handle, "UIPointerLockStateSceneUserInfoKey");
				var userinfo = Notification.UserInfo;
				if (userinfo is null)
					return null!;
				else
					value = userinfo.LowlevelObjectForKey (k0);
				return Runtime.GetNSObject<UIScene> (value)!;
			}
		}
	}
}
