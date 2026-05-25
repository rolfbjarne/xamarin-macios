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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSDraggingDestination</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSDraggingDestination", WrapperType = typeof (NSDraggingDestinationWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEntered", Selector = "draggingEntered:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingUpdated", Selector = "draggingUpdated:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingExited", Selector = "draggingExited:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForDragOperation", Selector = "prepareForDragOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformDragOperation", Selector = "performDragOperation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConcludeDragOperation", Selector = "concludeDragOperation:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEnded", Selector = "draggingEnded:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WantsPeriodicDraggingUpdates", Selector = "wantsPeriodicDraggingUpdates", PropertyType = typeof (bool), GetterSelector = "wantsPeriodicDraggingUpdates", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSDraggingDestination : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("draggingEntered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingEntered (INSDraggingInfo sender)
		{
			return _DraggingEntered (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _DraggingEntered (INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEntered:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("draggingUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingUpdated (INSDraggingInfo sender)
		{
			return _DraggingUpdated (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _DraggingUpdated (INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingUpdated:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("draggingExited:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingExited (INSDraggingInfo? sender)
		{
			_DraggingExited (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingExited (INSDraggingDestination This, INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingExited:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("prepareForDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrepareForDragOperation (INSDraggingInfo sender)
		{
			return _PrepareForDragOperation (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _PrepareForDragOperation (INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareForDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("performDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformDragOperation (INSDraggingInfo sender)
		{
			return _PerformDragOperation (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _PerformDragOperation (INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("concludeDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcludeDragOperation (INSDraggingInfo? sender)
		{
			_ConcludeDragOperation (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ConcludeDragOperation (INSDraggingDestination This, INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("concludeDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[global::Foundation.OptionalMember]
		[Export ("draggingEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (INSDraggingInfo sender)
		{
			_DraggingEnded (this, sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingEnded (INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEnded:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[DynamicDependencyAttribute ("ConcludeDragOperation(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("DraggingEnded(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("DraggingEntered(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("DraggingExited(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("DraggingUpdated(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("PerformDragOperation(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("PrepareForDragOperation(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("WantsPeriodicDraggingUpdates")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingDestinationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSDraggingDestination ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[global::Foundation.OptionalMember]
		public virtual bool WantsPeriodicDraggingUpdates {
			[Export ("wantsPeriodicDraggingUpdates")]
			get {
				return _GetWantsPeriodicDraggingUpdates (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetWantsPeriodicDraggingUpdates (INSDraggingDestination This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("wantsPeriodicDraggingUpdates"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSDraggingDestination" /> interface to support all the methods from the NSDraggingDestination protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSDraggingDestination" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSDraggingDestination protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSDraggingDestination_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation DraggingEntered (this INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEntered:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation DraggingUpdated (this INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingUpdated:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingExited (this INSDraggingDestination This, INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingExited:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PrepareForDragOperation (this INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareForDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PerformDragOperation (this INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConcludeDragOperation (this INSDraggingDestination This, INSDraggingInfo? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("concludeDragOperation:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingEnded (this INSDraggingDestination This, INSDraggingInfo sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEnded:"), sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetWantsPeriodicDraggingUpdates (this INSDraggingDestination This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("wantsPeriodicDraggingUpdates"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSDraggingDestinationWrapper : BaseWrapper, INSDraggingDestination {
		public NSDraggingDestinationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingDestinationWrapper))]
		static NSDraggingDestinationWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSDraggingDestination" /> (for the protocol <c>NSDraggingDestination</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSDraggingDestination" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSDraggingDestination", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSDraggingDestination : NSObject, INSDraggingDestination {
		/// <summary>Creates a new <see cref="NSDraggingDestination" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDraggingDestination () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSDraggingDestination (NSObjectFlag t) : base (t)
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
		protected internal NSDraggingDestination (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("concludeDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConcludeDragOperation (INSDraggingInfo? sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("draggingEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (INSDraggingInfo sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("draggingEntered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingEntered (INSDraggingInfo sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("draggingExited:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingExited (INSDraggingInfo? sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("draggingUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingUpdated (INSDraggingInfo sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("performDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformDragOperation (INSDraggingInfo sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("prepareForDragOperation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrepareForDragOperation (INSDraggingInfo sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool WantsPeriodicDraggingUpdates {
			[Export ("wantsPeriodicDraggingUpdates")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSDraggingDestination */
}
