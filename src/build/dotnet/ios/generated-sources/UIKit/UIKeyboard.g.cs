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
namespace UIKit {
	/// <summary>The iPhone virtual keyboard.</summary><remarks><para>
	/// 	The UIKeyboard class contains constants and methods to track
	/// 	the visibility of the iPhone virtual keyboard.  iOS posts a
	/// 	number of notifications when the keyboard is shown, hidden or
	/// 	moved in the screen.   
	/// 
	/// </para><para>
	/// 	The preferred way of receiving UIKeyboard notification is to
	/// 	use the <see cref="UIKit.UIKeyboard.Notifications" /> class,
	/// 	which provides a strongly-typed set of APIs to track the
	/// 	changes to the keyboard state and provides strongly-typed
	/// 	accessors to the various parameters of the keyboard changes.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //
	/// // Lambda style
	/// //
	/// 
	/// // listening
	/// notification = UIKeyboard.Notifications.ObserveDidChangeFrame ((sender, args) => {
	/// /* Access strongly typed args */
	/// Console.WriteLine ("Notification: {0}", args.Notification);
	/// 
	/// Console.WriteLine ("FrameBegin", args.FrameBegin);
	/// Console.WriteLine ("FrameEnd", args.FrameEnd);
	/// Console.WriteLine ("AnimationDuration", args.AnimationDuration);
	/// Console.WriteLine ("AnimationCurve", args.AnimationCurve);
	/// });
	/// 
	/// // To stop listening:
	/// notification.Dispose ();
	/// 
	/// //
	/// // Method style
	/// //
	/// NSObject notification;
	/// void Callback (object sender, UIKit.UIKeyboardEventArgs args)
	/// {
	/// // Access strongly typed args
	/// Console.WriteLine ("Notification: {0}", args.Notification);
	/// 
	/// Console.WriteLine ("FrameBegin", args.FrameBegin);
	/// Console.WriteLine ("FrameEnd", args.FrameEnd);
	/// Console.WriteLine ("AnimationDuration", args.AnimationDuration);
	/// Console.WriteLine ("AnimationCurve", args.AnimationCurve);
	/// }
	/// 
	/// void Setup ()
	/// {
	/// notification = UIKeyboard.Notifications.ObserveDidChangeFrame (Callback);
	/// }
	/// 
	/// void Teardown ()
	/// {
	/// notification.Dispose ();
	/// }]]></code></example></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class UIKeyboard  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationCurveUserInfoKey;
		/// <summary>Represents the value associated with the constant UIKeyboardAnimationCurveUserInfoKey</summary><value></value><remarks></remarks>
		[Field ("UIKeyboardAnimationCurveUserInfoKey",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString AnimationCurveUserInfoKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_AnimationCurveUserInfoKey is null)
					_AnimationCurveUserInfoKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardAnimationCurveUserInfoKey")!;
				return _AnimationCurveUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationDurationUserInfoKey;
		/// <summary>Represents the value associated with the constant UIKeyboardAnimationDurationUserInfoKey</summary><value></value><remarks></remarks>
		[Field ("UIKeyboardAnimationDurationUserInfoKey",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString AnimationDurationUserInfoKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_AnimationDurationUserInfoKey is null)
					_AnimationDurationUserInfoKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardAnimationDurationUserInfoKey")!;
				return _AnimationDurationUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeFrameNotification;
		/// <summary>Notification constant for DidChangeFrame</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeFrame(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeFrame(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveDidChangeFrame ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveDidChangeFrame (Callback);
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
		///     UIKeyboard.DidChangeFrameNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeFrame", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeFrame", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.DidChangeFrameNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardDidChangeFrameNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveDidChangeFrame helper method instead.")]
		public static NSString DidChangeFrameNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_DidChangeFrameNotification is null)
					_DidChangeFrameNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardDidChangeFrameNotification")!;
				return _DidChangeFrameNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidHideNotification;
		/// <summary>Notification constant for DidHide</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidHide(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveDidHide(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveDidHide ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveDidHide (Callback);
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
		///     UIKeyboard.DidHideNotification, (notification) => { Console.WriteLine ("Received the notification DidHide", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidHide", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.DidHideNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardDidHideNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveDidHide helper method instead.")]
		public static NSString DidHideNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_DidHideNotification is null)
					_DidHideNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardDidHideNotification")!;
				return _DidHideNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidShowNotification;
		/// <summary>Notification constant for DidShow</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidShow(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveDidShow(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveDidShow ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveDidShow (Callback);
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
		///     UIKeyboard.DidShowNotification, (notification) => { Console.WriteLine ("Received the notification DidShow", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidShow", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.DidShowNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardDidShowNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveDidShow helper method instead.")]
		public static NSString DidShowNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_DidShowNotification is null)
					_DidShowNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardDidShowNotification")!;
				return _DidShowNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FrameBeginUserInfoKey;
		/// <summary>Represents the value associated with the constant UIKeyboardFrameBeginUserInfoKey</summary><value></value><remarks></remarks>
		[Field ("UIKeyboardFrameBeginUserInfoKey",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString FrameBeginUserInfoKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_FrameBeginUserInfoKey is null)
					_FrameBeginUserInfoKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardFrameBeginUserInfoKey")!;
				return _FrameBeginUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FrameEndUserInfoKey;
		/// <summary>Represents the value associated with the constant UIKeyboardFrameEndUserInfoKey</summary><value></value><remarks></remarks>
		[Field ("UIKeyboardFrameEndUserInfoKey",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString FrameEndUserInfoKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_FrameEndUserInfoKey is null)
					_FrameEndUserInfoKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardFrameEndUserInfoKey")!;
				return _FrameEndUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsLocalUserInfoKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIKeyboardIsLocalUserInfoKey",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public static NSString IsLocalUserInfoKey {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_IsLocalUserInfoKey is null)
					_IsLocalUserInfoKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardIsLocalUserInfoKey")!;
				return _IsLocalUserInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillChangeFrameNotification;
		/// <summary>Notification constant for WillChangeFrame</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillChangeFrame(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveWillChangeFrame(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveWillChangeFrame ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveWillChangeFrame (Callback);
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
		///     UIKeyboard.WillChangeFrameNotification, (notification) => { Console.WriteLine ("Received the notification WillChangeFrame", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillChangeFrame", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.WillChangeFrameNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardWillChangeFrameNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveWillChangeFrame helper method instead.")]
		public static NSString WillChangeFrameNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_WillChangeFrameNotification is null)
					_WillChangeFrameNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardWillChangeFrameNotification")!;
				return _WillChangeFrameNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillHideNotification;
		/// <summary>Notification constant for WillHide</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillHide(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveWillHide(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveWillHide ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveWillHide (Callback);
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
		///     UIKeyboard.WillHideNotification, (notification) => { Console.WriteLine ("Received the notification WillHide", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillHide", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.WillHideNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardWillHideNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveWillHide helper method instead.")]
		public static NSString WillHideNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_WillHideNotification is null)
					_WillHideNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardWillHideNotification")!;
				return _WillHideNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillShowNotification;
		/// <summary>Notification constant for WillShow</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillShow(NSObject,EventHandler{UIKeyboardEventArgs})" />
		///     or <see cref="Notifications.ObserveWillShow(EventHandler{UIKeyboardEventArgs})" /> methods,
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
		/// notification = UIKeyboard.Notifications.ObserveWillShow ((sender, args) => {
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
		/// void Callback (object sender, UIKeyboard.UIKeyboardEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIKeyboard.Notifications.ObserveWillShow (Callback);
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
		///     UIKeyboard.WillShowNotification, (notification) => { Console.WriteLine ("Received the notification WillShow", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillShow", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIKeyboard.WillShowNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIKeyboardWillShowNotification",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[Advice ("Use UIKeyboard.Notifications.ObserveWillShow helper method instead.")]
		public static NSString WillShowNotification {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_WillShowNotification is null)
					_WillShowNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyboardWillShowNotification")!;
				return _WillShowNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UIKeyboard" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidChangeFrameNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidChangeFrameNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveDidChangeFrame ((notification) => {
			///   Console.WriteLine ("Observed DidChangeFrameNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeFrame (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeFrameNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidChangeFrameNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidChangeFrameNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveDidChangeFrame (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeFrameNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeFrame (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeFrameNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidHideNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidHideNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveDidHide ((notification) => {
			///   Console.WriteLine ("Observed DidHideNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidHide (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidHideNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidHideNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidHideNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveDidHide (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidHideNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidHide (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidHideNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidShowNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidShowNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveDidShow ((notification) => {
			///   Console.WriteLine ("Observed DidShowNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidShow (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidShowNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.DidShowNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.DidShowNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveDidShow (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidShowNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidShow (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidShowNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillChangeFrameNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillChangeFrameNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveWillChangeFrame ((notification) => {
			///   Console.WriteLine ("Observed WillChangeFrameNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillChangeFrame (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillChangeFrameNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillChangeFrameNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillChangeFrameNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveWillChangeFrame (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillChangeFrameNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillChangeFrame (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillChangeFrameNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillHideNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillHideNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveWillHide ((notification) => {
			///   Console.WriteLine ("Observed WillHideNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillHide (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillHideNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillHideNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillHideNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveWillHide (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillHideNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillHide (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillHideNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillShowNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillShowNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIKeyboard.Notifications.ObserveWillShow ((notification) => {
			///   Console.WriteLine ("Observed WillShowNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillShow (EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillShowNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIKeyboard.WillShowNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIKeyboard.WillShowNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIKeyboard.Notifications.ObserveWillShow (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillShowNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillShow (NSObject objectToObserve, EventHandler<UIKit.UIKeyboardEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillShowNotification, notification => handler (null, new UIKit.UIKeyboardEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UIKeyboard */
}
