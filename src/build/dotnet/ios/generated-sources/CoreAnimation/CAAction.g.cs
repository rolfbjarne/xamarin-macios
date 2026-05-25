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
namespace CoreAnimation {
	#pragma warning disable CS1573
	/// <summary>An interface implemented by objects that participate in animations coordinated by a CALayer.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAAction_protocol/index.html">Apple documentation for <c>CAAction</c></related>
	[Protocol (Name = "CAAction", WrapperType = typeof (CAActionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runActionForKey:object:arguments:", ParameterType = new Type [] { typeof (string), typeof (NSObject), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ICAAction : INativeObject, IDisposable
	{
		/// <param name="eventKey">To be added.</param><param name="obj">To be added.</param><param name="arguments"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("runActionForKey:object:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (string eventKey, NSObject obj, NSDictionary? arguments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="eventKey">To be added.</param><param name="obj">To be added.</param><param name="arguments"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RunAction (ICAAction This, string eventKey, NSObject obj, NSDictionary? arguments)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var arguments__handle__ = arguments.GetHandle ();
			var nseventKey = CFString.CreateNative (eventKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("runActionForKey:object:arguments:"), nseventKey, obj__handle__, arguments__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
			GC.KeepAlive (arguments);
			CFString.ReleaseNative (nseventKey);
		}
		[DynamicDependencyAttribute ("RunAction(System.String,Foundation.NSObject,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CAActionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICAAction ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CAActionWrapper : BaseWrapper, ICAAction {
		public CAActionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CAActionWrapper))]
		static CAActionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="eventKey">To be added.</param><param name="obj">To be added.</param><param name="arguments"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runActionForKey:object:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RunAction (string eventKey, NSObject obj, NSDictionary? arguments)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var arguments__handle__ = arguments.GetHandle ();
			var nseventKey = CFString.CreateNative (eventKey);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runActionForKey:object:arguments:"), nseventKey, obj__handle__, arguments__handle__);
			GC.KeepAlive (obj);
			GC.KeepAlive (arguments);
			CFString.ReleaseNative (nseventKey);
		}
	}
}
namespace CoreAnimation {
	/// <summary>An interface implemented by objects that participate in animations coordinated by a CALayer.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAAction_protocol/index.html">Apple documentation for <c>CAAction</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__CoreAnimation_CAAction", false)]
	[Model]
	public unsafe abstract partial class CAAction : NSObject, ICAAction {
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
		protected CAAction (NSObjectFlag t) : base (t)
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
		protected internal CAAction (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="eventKey">To be added.</param><param name="obj">To be added.</param><param name="arguments"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runActionForKey:object:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (string eventKey, NSObject obj, NSDictionary? arguments)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CAAction */
}
