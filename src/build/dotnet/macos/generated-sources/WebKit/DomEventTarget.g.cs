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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>DOMEventTarget</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "DOMEventTarget", WrapperType = typeof (DomEventTargetWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddEventListener", Selector = "addEventListener:listener:useCapture:", ParameterType = new Type [] { typeof (string), typeof (WebKit.IDomEventListener), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveEventListener", Selector = "removeEventListener:listener:useCapture:", ParameterType = new Type [] { typeof (string), typeof (WebKit.IDomEventListener), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchEvent", Selector = "dispatchEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (WebKit.DomEvent) }, ParameterByRef = new bool [] { false })]
	public partial interface IDomEventTarget : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddEventListener (IDomEventTarget This, string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("addEventListener:listener:useCapture:"), nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveEventListener (IDomEventTarget This, string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("removeEventListener:listener:useCapture:"), nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dispatchEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DispatchEvent (DomEvent evt)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DispatchEvent (IDomEventTarget This, DomEvent evt)
		{
			var evt__handle__ = evt!.GetNonNullHandle (nameof (evt));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("dispatchEvent:"), evt__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (evt);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AddEventListener(System.String,WebKit.IDomEventListener,System.Boolean)")]
		[DynamicDependencyAttribute ("DispatchEvent(WebKit.DomEvent)")]
		[DynamicDependencyAttribute ("RemoveEventListener(System.String,WebKit.IDomEventListener,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (DomEventTargetWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IDomEventTarget ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class DomEventTargetWrapper : BaseWrapper, IDomEventTarget {
		public DomEventTargetWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (DomEventTargetWrapper))]
		static DomEventTargetWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("addEventListener:listener:useCapture:"), nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("removeEventListener:listener:useCapture:"), nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dispatchEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool DispatchEvent (DomEvent evt)
		{
			var evt__handle__ = evt!.GetNonNullHandle (nameof (evt));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dispatchEvent:"), evt__handle__);
			GC.KeepAlive (evt);
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IDomEventTarget" /> (for the protocol <c>DOMEventTarget</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IDomEventTarget" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_DomEventTarget", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class DomEventTarget : NSObject, IDomEventTarget, INSCopying {
		/// <summary>Creates a new <see cref="DomEventTarget" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected DomEventTarget () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected DomEventTarget (NSObjectFlag t) : base (t)
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
		protected internal DomEventTarget (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dispatchEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DispatchEvent (DomEvent evt)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeEventListener:listener:useCapture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class DomEventTarget */
}
