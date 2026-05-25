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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class AVAudioSession  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InterruptionNotification;
		/// <summary>Notification constant for Interruption</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveInterruption(NSObject,EventHandler{AVAudioSessionInterruptionEventArgs})" />
		///     or <see cref="Notifications.ObserveInterruption(EventHandler{AVAudioSessionInterruptionEventArgs})" /> methods,
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
		/// notification = AVAudioSession.Notifications.ObserveInterruption ((sender, args) => {
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
		/// void Callback (object sender, AVAudioSession.AVAudioSessionInterruptionEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAudioSession.Notifications.ObserveInterruption (Callback);
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
		///     AVAudioSession.InterruptionNotification, (notification) => { Console.WriteLine ("Received the notification Interruption", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Interruption", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAudioSession.InterruptionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAudioSessionInterruptionNotification",  "AVFoundation")]
		[Advice ("Use AVAudioSession.Notifications.ObserveInterruption helper method instead.")]
		public static NSString InterruptionNotification {
			get {
				if (_InterruptionNotification is null)
					_InterruptionNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionInterruptionNotification")!;
				return _InterruptionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocationLower_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionLocationLower'.</summary>
		[Field ("AVAudioSessionLocationLower",  "AVFoundation")]
		internal static NSString LocationLower_ {
			get {
				if (_LocationLower_ is null)
					_LocationLower_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionLocationLower")!;
				return _LocationLower_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocationUpper_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionLocationUpper'.</summary>
		[Field ("AVAudioSessionLocationUpper",  "AVFoundation")]
		internal static NSString LocationUpper_ {
			get {
				if (_LocationUpper_ is null)
					_LocationUpper_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionLocationUpper")!;
				return _LocationUpper_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaServicesWereLostNotification;
		/// <summary>Notification constant for MediaServicesWereLost</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMediaServicesWereLost(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMediaServicesWereLost(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAudioSession.Notifications.ObserveMediaServicesWereLost ((sender, args) => {
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
		/// void Callback (object sender, AVAudioSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAudioSession.Notifications.ObserveMediaServicesWereLost (Callback);
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
		///     AVAudioSession.MediaServicesWereLostNotification, (notification) => { Console.WriteLine ("Received the notification MediaServicesWereLost", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MediaServicesWereLost", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAudioSession.MediaServicesWereLostNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAudioSessionMediaServicesWereLostNotification",  "AVFoundation")]
		[Advice ("Use AVAudioSession.Notifications.ObserveMediaServicesWereLost helper method instead.")]
		public static NSString MediaServicesWereLostNotification {
			get {
				if (_MediaServicesWereLostNotification is null)
					_MediaServicesWereLostNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionMediaServicesWereLostNotification")!;
				return _MediaServicesWereLostNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaServicesWereResetNotification;
		/// <summary>Notification constant for MediaServicesWereReset</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMediaServicesWereReset(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMediaServicesWereReset(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAudioSession.Notifications.ObserveMediaServicesWereReset ((sender, args) => {
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
		/// void Callback (object sender, AVAudioSession.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAudioSession.Notifications.ObserveMediaServicesWereReset (Callback);
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
		///     AVAudioSession.MediaServicesWereResetNotification, (notification) => { Console.WriteLine ("Received the notification MediaServicesWereReset", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MediaServicesWereReset", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAudioSession.MediaServicesWereResetNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAudioSessionMediaServicesWereResetNotification",  "AVFoundation")]
		[Advice ("Use AVAudioSession.Notifications.ObserveMediaServicesWereReset helper method instead.")]
		public static NSString MediaServicesWereResetNotification {
			get {
				if (_MediaServicesWereResetNotification is null)
					_MediaServicesWereResetNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionMediaServicesWereResetNotification")!;
				return _MediaServicesWereResetNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationBack_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionOrientationBack'.</summary>
		[Field ("AVAudioSessionOrientationBack",  "AVFoundation")]
		internal static NSString OrientationBack_ {
			get {
				if (_OrientationBack_ is null)
					_OrientationBack_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationBack")!;
				return _OrientationBack_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationBottom_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionOrientationBottom'.</summary>
		[Field ("AVAudioSessionOrientationBottom",  "AVFoundation")]
		internal static NSString OrientationBottom_ {
			get {
				if (_OrientationBottom_ is null)
					_OrientationBottom_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationBottom")!;
				return _OrientationBottom_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationFront_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionOrientationFront'.</summary>
		[Field ("AVAudioSessionOrientationFront",  "AVFoundation")]
		internal static NSString OrientationFront_ {
			get {
				if (_OrientationFront_ is null)
					_OrientationFront_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationFront")!;
				return _OrientationFront_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationLeft;
		/// <summary>Represents the value associated with the constant AVAudioSessionOrientationLeft</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioSessionOrientationLeft",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OrientationLeft {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OrientationLeft is null)
					_OrientationLeft = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationLeft")!;
				return _OrientationLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationRight;
		/// <summary>Represents the value associated with the constant AVAudioSessionOrientationRight</summary><value></value><remarks>To be added.</remarks>
		[Field ("AVAudioSessionOrientationRight",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OrientationRight {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OrientationRight is null)
					_OrientationRight = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationRight")!;
				return _OrientationRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrientationTop_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionOrientationTop'.</summary>
		[Field ("AVAudioSessionOrientationTop",  "AVFoundation")]
		internal static NSString OrientationTop_ {
			get {
				if (_OrientationTop_ is null)
					_OrientationTop_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionOrientationTop")!;
				return _OrientationTop_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PolarPatternCardioid_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionPolarPatternCardioid'.</summary>
		[Field ("AVAudioSessionPolarPatternCardioid",  "AVFoundation")]
		internal static NSString PolarPatternCardioid_ {
			get {
				if (_PolarPatternCardioid_ is null)
					_PolarPatternCardioid_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionPolarPatternCardioid")!;
				return _PolarPatternCardioid_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PolarPatternOmnidirectional_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionPolarPatternOmnidirectional'.</summary>
		[Field ("AVAudioSessionPolarPatternOmnidirectional",  "AVFoundation")]
		internal static NSString PolarPatternOmnidirectional_ {
			get {
				if (_PolarPatternOmnidirectional_ is null)
					_PolarPatternOmnidirectional_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionPolarPatternOmnidirectional")!;
				return _PolarPatternOmnidirectional_;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PolarPatternSubcardioid_;
		/// <summary>Represents the value associated with the constant 'AVAudioSessionPolarPatternSubcardioid'.</summary>
		[Field ("AVAudioSessionPolarPatternSubcardioid",  "AVFoundation")]
		internal static NSString PolarPatternSubcardioid_ {
			get {
				if (_PolarPatternSubcardioid_ is null)
					_PolarPatternSubcardioid_ = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioSessionPolarPatternSubcardioid")!;
				return _PolarPatternSubcardioid_;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVAudioSession" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.InterruptionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.InterruptionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAudioSession.Notifications.ObserveInterruption ((notification) => {
			///   Console.WriteLine ("Observed InterruptionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInterruption (EventHandler<AVFoundation.AVAudioSessionInterruptionEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InterruptionNotification, notification => handler (null, new AVFoundation.AVAudioSessionInterruptionEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.InterruptionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.InterruptionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAudioSession.Notifications.ObserveInterruption (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed InterruptionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveInterruption (NSObject objectToObserve, EventHandler<AVFoundation.AVAudioSessionInterruptionEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InterruptionNotification, notification => handler (null, new AVFoundation.AVAudioSessionInterruptionEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereLostNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereLostNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAudioSession.Notifications.ObserveMediaServicesWereLost ((notification) => {
			///   Console.WriteLine ("Observed MediaServicesWereLostNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaServicesWereLost (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaServicesWereLostNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereLostNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereLostNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAudioSession.Notifications.ObserveMediaServicesWereLost (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MediaServicesWereLostNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaServicesWereLost (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaServicesWereLostNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereResetNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereResetNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAudioSession.Notifications.ObserveMediaServicesWereReset ((notification) => {
			///   Console.WriteLine ("Observed MediaServicesWereResetNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaServicesWereReset (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaServicesWereResetNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereResetNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioSession.MediaServicesWereResetNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAudioSession.Notifications.ObserveMediaServicesWereReset (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MediaServicesWereResetNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMediaServicesWereReset (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MediaServicesWereResetNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVAudioSession */
}
