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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:Foundation.NSUserActivity" /> objects, exposing events relating to an activity begun on one device and continued on another.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AppKit/Reference/NSUserActivityDelegate_Protocol/index.html">Apple documentation for <c>NSUserActivityDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSUserActivityDelegate", WrapperType = typeof (NSUserActivityDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityWillSave", Selector = "userActivityWillSave:", ParameterType = new Type [] { typeof (NSUserActivity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityWasContinued", Selector = "userActivityWasContinued:", ParameterType = new Type [] { typeof (NSUserActivity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityReceivedData", Selector = "userActivity:didReceiveInputStream:outputStream:", ParameterType = new Type [] { typeof (NSUserActivity), typeof (NSInputStream), typeof (NSOutputStream) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSUserActivityDelegate : INativeObject, IDisposable
	{
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userActivityWillSave:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityWillSave (NSUserActivity userActivity)
		{
			_UserActivityWillSave (this, userActivity);
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserActivityWillSave (INSUserActivityDelegate This, NSUserActivity userActivity)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("userActivityWillSave:"), userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userActivityWasContinued:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityWasContinued (NSUserActivity userActivity)
		{
			_UserActivityWasContinued (this, userActivity);
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserActivityWasContinued (INSUserActivityDelegate This, NSUserActivity userActivity)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("userActivityWasContinued:"), userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
		}
		/// <param name="userActivity">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userActivity:didReceiveInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityReceivedData (NSUserActivity userActivity, NSInputStream inputStream, NSOutputStream outputStream)
		{
			_UserActivityReceivedData (this, userActivity, inputStream, outputStream);
		}
		/// <param name="userActivity">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserActivityReceivedData (INSUserActivityDelegate This, NSUserActivity userActivity, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userActivity:didReceiveInputStream:outputStream:"), userActivity__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
		[DynamicDependencyAttribute ("UserActivityReceivedData(Foundation.NSUserActivity,Foundation.NSInputStream,Foundation.NSOutputStream)")]
		[DynamicDependencyAttribute ("UserActivityWasContinued(Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("UserActivityWillSave(Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserActivityDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUserActivityDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUserActivityDelegate" /> interface to support all the methods from the NSUserActivityDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUserActivityDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSUserActivityDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUserActivityDelegate_Extensions {
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserActivityWillSave (this INSUserActivityDelegate This, NSUserActivity userActivity)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("userActivityWillSave:"), userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserActivityWasContinued (this INSUserActivityDelegate This, NSUserActivity userActivity)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("userActivityWasContinued:"), userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
		}
		/// <param name="userActivity">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserActivityReceivedData (this INSUserActivityDelegate This, NSUserActivity userActivity, NSInputStream inputStream, NSOutputStream outputStream)
		{
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			var inputStream__handle__ = inputStream!.GetNonNullHandle (nameof (inputStream));
			var outputStream__handle__ = outputStream!.GetNonNullHandle (nameof (outputStream));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userActivity:didReceiveInputStream:outputStream:"), userActivity__handle__, inputStream__handle__, outputStream__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (userActivity);
			GC.KeepAlive (inputStream);
			GC.KeepAlive (outputStream);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUserActivityDelegateWrapper : BaseWrapper, INSUserActivityDelegate {
		public NSUserActivityDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserActivityDelegateWrapper))]
		static NSUserActivityDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>Delegate object for <see cref="T:Foundation.NSUserActivity" /> objects, exposing events relating to an activity begun on one device and continued on another.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AppKit/Reference/NSUserActivityDelegate_Protocol/index.html">Apple documentation for <c>NSUserActivityDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Foundation_NSUserActivityDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSUserActivityDelegate : NSObject, INSUserActivityDelegate {
		/// <summary>Creates a new <see cref="NSUserActivityDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUserActivityDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

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
		protected NSUserActivityDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal NSUserActivityDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="userActivity">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("userActivity:didReceiveInputStream:outputStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityReceivedData (NSUserActivity userActivity, NSInputStream inputStream, NSOutputStream outputStream)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("userActivityWasContinued:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityWasContinued (NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="userActivity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("userActivityWillSave:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityWillSave (NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUserActivityDelegate */
}
