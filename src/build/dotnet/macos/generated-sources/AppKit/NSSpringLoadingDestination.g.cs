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
	/// <summary>This interface represents the Objective-C protocol <c>NSSpringLoadingDestination</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSSpringLoadingDestination", WrapperType = typeof (NSSpringLoadingDestinationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Activated", Selector = "springLoadingActivated:draggingInfo:", ParameterType = new Type [] { typeof (bool), typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HighlightChanged", Selector = "springLoadingHighlightChanged:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Entered", Selector = "springLoadingEntered:", ReturnType = typeof (NSSpringLoadingOptions), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Updated", Selector = "springLoadingUpdated:", ReturnType = typeof (NSSpringLoadingOptions), ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Exited", Selector = "springLoadingExited:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEnded", Selector = "draggingEnded:", ParameterType = new Type [] { typeof (INSDraggingInfo) }, ParameterByRef = new bool [] { false })]
	public partial interface INSSpringLoadingDestination : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("springLoadingActivated:draggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Activated (bool activated, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Activated (INSSpringLoadingDestination This, bool activated, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingActivated:draggingInfo:"), activated ? (byte) 1 : (byte) 0, draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
		[global::Foundation.RequiredMember]
		[Export ("springLoadingHighlightChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HighlightChanged (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HighlightChanged (INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingHighlightChanged:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("springLoadingEntered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSpringLoadingOptions Entered (INSDraggingInfo draggingInfo)
		{
			return _Entered (this, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSpringLoadingOptions _Entered (INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			NSSpringLoadingOptions ret;
			ret = (NSSpringLoadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingEntered:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("springLoadingUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSpringLoadingOptions Updated (INSDraggingInfo draggingInfo)
		{
			return _Updated (this, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSpringLoadingOptions _Updated (INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			NSSpringLoadingOptions ret;
			ret = (NSSpringLoadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingUpdated:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("springLoadingExited:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Exited (INSDraggingInfo draggingInfo)
		{
			_Exited (this, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Exited (INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingExited:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
		[global::Foundation.OptionalMember]
		[Export ("draggingEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (INSDraggingInfo draggingInfo)
		{
			_DraggingEnded (this, draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggingEnded (INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEnded:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
		[DynamicDependencyAttribute ("Activated(System.Boolean,AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("DraggingEnded(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("Entered(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("Exited(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("HighlightChanged(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute ("Updated(AppKit.INSDraggingInfo)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSpringLoadingDestinationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSSpringLoadingDestination ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSSpringLoadingDestination" /> interface to support all the methods from the NSSpringLoadingDestination protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSSpringLoadingDestination" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSSpringLoadingDestination protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSSpringLoadingDestination_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSpringLoadingOptions Entered (this INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			NSSpringLoadingOptions ret;
			ret = (NSSpringLoadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingEntered:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSpringLoadingOptions Updated (this INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			NSSpringLoadingOptions ret;
			ret = (NSSpringLoadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingUpdated:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Exited (this INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("springLoadingExited:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggingEnded (this INSSpringLoadingDestination This, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("draggingEnded:"), draggingInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (draggingInfo);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSSpringLoadingDestinationWrapper : BaseWrapper, INSSpringLoadingDestination {
		public NSSpringLoadingDestinationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSpringLoadingDestinationWrapper))]
		static NSSpringLoadingDestinationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("springLoadingActivated:draggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Activated (bool activated, INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("springLoadingActivated:draggingInfo:"), activated ? (byte) 1 : (byte) 0, draggingInfo__handle__);
			GC.KeepAlive (draggingInfo);
		}
		[Export ("springLoadingHighlightChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HighlightChanged (INSDraggingInfo draggingInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var draggingInfo__handle__ = draggingInfo!.GetNonNullHandle (nameof (draggingInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("springLoadingHighlightChanged:"), draggingInfo__handle__);
			GC.KeepAlive (draggingInfo);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSSpringLoadingDestination" /> (for the protocol <c>NSSpringLoadingDestination</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSSpringLoadingDestination" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSSpringLoadingDestination", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSSpringLoadingDestination : NSObject, INSSpringLoadingDestination {
		/// <summary>Creates a new <see cref="NSSpringLoadingDestination" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSSpringLoadingDestination () : base (NSObjectFlag.Empty)
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
		protected NSSpringLoadingDestination (NSObjectFlag t) : base (t)
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
		protected internal NSSpringLoadingDestination (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("springLoadingActivated:draggingInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Activated (bool activated, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("draggingEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("springLoadingEntered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSpringLoadingOptions Entered (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("springLoadingExited:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Exited (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("springLoadingHighlightChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HighlightChanged (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("springLoadingUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSpringLoadingOptions Updated (INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSSpringLoadingDestination */
}
