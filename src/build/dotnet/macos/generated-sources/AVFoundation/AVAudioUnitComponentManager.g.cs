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
	/// <summary>Singleton that finds registered audio units, queries them wthout opening them, and supports user-defined audio unit tags.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiounitcomponentManager">Apple documentation for <c>AVAudioUnitComponentManager</c></related>
	[Register("AVAudioUnitComponentManager", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVAudioUnitComponentManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsMatchingDescription_X = "componentsMatchingDescription:";
		static readonly NativeHandle selComponentsMatchingDescription_XHandle = Selector.GetHandle ("componentsMatchingDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsMatchingPredicate_X = "componentsMatchingPredicate:";
		static readonly NativeHandle selComponentsMatchingPredicate_XHandle = Selector.GetHandle ("componentsMatchingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsPassingTest_X = "componentsPassingTest:";
		static readonly NativeHandle selComponentsPassingTest_XHandle = Selector.GetHandle ("componentsPassingTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedAudioUnitComponentManagerX = "sharedAudioUnitComponentManager";
		static readonly NativeHandle selSharedAudioUnitComponentManagerXHandle = Selector.GetHandle ("sharedAudioUnitComponentManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardLocalizedTagNamesX = "standardLocalizedTagNames";
		static readonly NativeHandle selStandardLocalizedTagNamesXHandle = Selector.GetHandle ("standardLocalizedTagNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagNamesX = "tagNames";
		static readonly NativeHandle selTagNamesXHandle = Selector.GetHandle ("tagNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAudioUnitComponentManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AVAudioUnitComponentManager (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AVAudioUnitComponentManager (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="predicate">To be added.</param><summary>Finds all of the audio units that are matched by the specified predicate.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("componentsMatchingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioUnitComponent[] GetComponents (NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			AVAudioUnitComponent[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentsMatchingPredicate_XHandle, predicate__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentsMatchingPredicate_XHandle, predicate__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			return ret!;
		}
		/// <param name="testHandler">To be added.</param><summary>Finds all of the audio units that are matched by the specified test handler.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("componentsPassingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVAudioUnitComponent[] GetComponents ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVAudioUnitComponentFilter))]AVAudioUnitComponentFilter testHandler)
		{
			if (testHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (testHandler));
			using var block_testHandler = Trampolines.SDAVAudioUnitComponentFilter.CreateBlock (testHandler);
			BlockLiteral *block_ptr_testHandler = &block_testHandler;
			AVAudioUnitComponent[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentsPassingTest_XHandle, (IntPtr) block_ptr_testHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentsPassingTest_XHandle, (IntPtr) block_ptr_testHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="desc">To be added.</param><summary>Finds all of the audio units that match the specified description.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("componentsMatchingDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudioUnitComponent[] GetComponents (global::AudioUnit.AudioComponentDescription desc)
		{
			AVAudioUnitComponent[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_AudioComponentDescription (this.Handle, selComponentsMatchingDescription_XHandle, desc), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVAudioUnitComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_AudioComponentDescription (&__objc_super__, selComponentsMatchingDescription_XHandle, desc), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Returns the audio manager singleton object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAudioUnitComponentManager SharedInstance {
			[Export ("sharedAudioUnitComponentManager")]
			get {
				AVAudioUnitComponentManager? ret;
				ret =  Runtime.GetNSObject<AVAudioUnitComponentManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedAudioUnitComponentManagerXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>Gets an array that contains all of the localized standard system tags that are defined by audio units that are registered on the device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] StandardLocalizedTagNames {
			[Export ("standardLocalizedTagNames")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardLocalizedTagNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardLocalizedTagNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets an array that contains all of the tags that are defined by the current user, as well as all of the tags that are defined by audio units that are registered on the device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] TagNames {
			[Export ("tagNames")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTagNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTagNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegistrationsChangedNotification;
		/// <summary>Notification constant for RegistrationsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRegistrationsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRegistrationsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged ((sender, args) => {
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
		/// void Callback (object sender, AVAudioUnitComponentManager.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged (Callback);
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
		///     AVAudioUnitComponentManager.RegistrationsChangedNotification, (notification) => { Console.WriteLine ("Received the notification RegistrationsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RegistrationsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (AVAudioUnitComponentManager.RegistrationsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("AVAudioUnitComponentManagerRegistrationsChangedNotification",  "AVFoundation")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged helper method instead.")]
		public static NSString RegistrationsChangedNotification {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RegistrationsChangedNotification is null)
					_RegistrationsChangedNotification = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVAudioUnitComponentManagerRegistrationsChangedNotification")!;
				return _RegistrationsChangedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AVFoundation.AVAudioUnitComponentManager" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioUnitComponentManager.RegistrationsChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioUnitComponentManager.RegistrationsChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged ((notification) => {
			///   Console.WriteLine ("Observed RegistrationsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRegistrationsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RegistrationsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AVFoundation.AVAudioUnitComponentManager.RegistrationsChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AVFoundation.AVAudioUnitComponentManager.RegistrationsChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RegistrationsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRegistrationsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RegistrationsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class AVAudioUnitComponentManager */
}
