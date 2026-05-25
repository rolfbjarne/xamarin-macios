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
namespace HomeKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class HMCharacteristicPropertyInternal  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Hidden;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicPropertyHidden'.</summary>
		[Field ("HMCharacteristicPropertyHidden",  "HomeKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Hidden {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Hidden is null)
					_Hidden = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicPropertyHidden")!;
				return _Hidden;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Readable;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicPropertyReadable'.</summary>
		[Field ("HMCharacteristicPropertyReadable",  "HomeKit")]
		public static NSString Readable {
			get {
				if (_Readable is null)
					_Readable = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicPropertyReadable")!;
				return _Readable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequiresAuthorizationData;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicPropertyRequiresAuthorizationData'.</summary>
		[Field ("HMCharacteristicPropertyRequiresAuthorizationData",  "HomeKit")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("macos")]
		public static NSString RequiresAuthorizationData {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[UnsupportedOSPlatform ("macos")]
			get {
				if (_RequiresAuthorizationData is null)
					_RequiresAuthorizationData = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicPropertyRequiresAuthorizationData")!;
				return _RequiresAuthorizationData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportsEventNotification;
		/// <summary>Notification constant for SupportsEvent</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSupportsEvent(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSupportsEvent(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = HMCharacteristicPropertyInternal.Notifications.ObserveSupportsEvent ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, HMCharacteristicPropertyInternal.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = HMCharacteristicPropertyInternal.Notifications.ObserveSupportsEvent (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     HMCharacteristicPropertyInternal.SupportsEventNotification, (notification) => { Console.WriteLine ("Received the notification SupportsEvent", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SupportsEvent", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (HMCharacteristicPropertyInternal.SupportsEventNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("HMCharacteristicPropertySupportsEventNotification",  "HomeKit")]
		[Advice ("Use HMCharacteristicPropertyInternal.Notifications.ObserveSupportsEvent helper method instead.")]
		public static NSString SupportsEventNotification {
			get {
				if (_SupportsEventNotification is null)
					_SupportsEventNotification = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicPropertySupportsEventNotification")!;
				return _SupportsEventNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Writable;
		/// <summary>Represents the value associated with the constant 'HMCharacteristicPropertyWritable'.</summary>
		[Field ("HMCharacteristicPropertyWritable",  "HomeKit")]
		public static NSString Writable {
			get {
				if (_Writable is null)
					_Writable = Dlfcn.GetStringConstant (Libraries.HomeKit.Handle, "HMCharacteristicPropertyWritable")!;
				return _Writable;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::HomeKit.HMCharacteristicPropertyInternal" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::HomeKit.HMCharacteristicPropertyInternal.SupportsEventNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::HomeKit.HMCharacteristicPropertyInternal.SupportsEventNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = HMCharacteristicPropertyInternal.Notifications.ObserveSupportsEvent ((notification) => {
			///   Console.WriteLine ("Observed SupportsEventNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSupportsEvent (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SupportsEventNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::HomeKit.HMCharacteristicPropertyInternal.SupportsEventNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::HomeKit.HMCharacteristicPropertyInternal.SupportsEventNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = HMCharacteristicPropertyInternal.Notifications.ObserveSupportsEvent (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SupportsEventNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSupportsEvent (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SupportsEventNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class HMCharacteristicPropertyInternal */
}
