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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
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
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Accessibility {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class AXAnimatedImagesUtilities  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimatedImagesEnabledDidChangeNotification;
		/// <summary>Notification constant for AnimatedImagesEnabledDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAnimatedImagesEnabledDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAnimatedImagesEnabledDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AXAnimatedImagesUtilities.Notifications.ObserveAnimatedImagesEnabledDidChange ((sender, args) => {
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
		/// void Callback (object sender, AXAnimatedImagesUtilities.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AXAnimatedImagesUtilities.Notifications.ObserveAnimatedImagesEnabledDidChange (Callback);
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
		///     AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification AnimatedImagesEnabledDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AnimatedImagesEnabledDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AXAnimatedImagesEnabledDidChangeNotification",  "Accessibility")]
		[Advice ("Use AXAnimatedImagesUtilities.Notifications.ObserveAnimatedImagesEnabledDidChange helper method instead.")]
		public static NSString AnimatedImagesEnabledDidChangeNotification {
			get {
				if (_AnimatedImagesEnabledDidChangeNotification is null)
					_AnimatedImagesEnabledDidChangeNotification = Dlfcn.GetStringConstant (Libraries.Accessibility.Handle, "AXAnimatedImagesEnabledDidChangeNotification")!;
				return _AnimatedImagesEnabledDidChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Accessibility.AXAnimatedImagesUtilities" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Accessibility.AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Accessibility.AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AXAnimatedImagesUtilities.Notifications.ObserveAnimatedImagesEnabledDidChange ((notification) => {
			///   Console.WriteLine ("Observed AnimatedImagesEnabledDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnimatedImagesEnabledDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnimatedImagesEnabledDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Accessibility.AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Accessibility.AXAnimatedImagesUtilities.AnimatedImagesEnabledDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AXAnimatedImagesUtilities.Notifications.ObserveAnimatedImagesEnabledDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AnimatedImagesEnabledDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnimatedImagesEnabledDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnimatedImagesEnabledDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AXAnimatedImagesUtilities */
}
