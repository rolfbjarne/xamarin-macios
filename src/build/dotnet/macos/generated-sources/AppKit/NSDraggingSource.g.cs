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
	/// <summary>This interface represents the Objective-C protocol <c>NSDraggingSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSDraggingSource", WrapperType = typeof (NSDraggingSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingSourceOperationMaskForLocal", Selector = "draggingSourceOperationMaskForLocal:", ReturnType = typeof (NSDragOperation), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NamesOfPromisedFilesDroppedAtDestination", Selector = "namesOfPromisedFilesDroppedAtDestination:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageBeganAt", Selector = "draggedImage:beganAt:", ParameterType = new Type [] { typeof (NSImage), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageEndedAtOperation", Selector = "draggedImage:endedAt:operation:", ParameterType = new Type [] { typeof (NSImage), typeof (CGPoint), typeof (NSDragOperation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageMovedTo", Selector = "draggedImage:movedTo:", ParameterType = new Type [] { typeof (NSImage), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedImageEndedAtDeposited", Selector = "draggedImage:endedAt:deposited:", ParameterType = new Type [] { typeof (NSImage), typeof (CGPoint), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IgnoreModifierKeysWhileDragging", Selector = "ignoreModifierKeysWhileDragging", PropertyType = typeof (bool), GetterSelector = "ignoreModifierKeysWhileDragging", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSDraggingSource : INativeObject, IDisposable
	{
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("draggingSourceOperationMaskForLocal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingSourceOperationMaskForLocal (bool flag)
		{
			return _DraggingSourceOperationMaskForLocal (this, flag);
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDragOperation _DraggingSourceOperationMaskForLocal (INSDraggingSource This, bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("draggingSourceOperationMaskForLocal:"), flag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			return _NamesOfPromisedFilesDroppedAtDestination (this, dropDestination);
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _NamesOfPromisedFilesDroppedAtDestination (INSDraggingSource This, NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:"), dropDestination__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("draggedImage:beganAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageBeganAt (NSImage image, CGPoint screenPoint)
		{
			_DraggedImageBeganAt (this, image, screenPoint);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggedImageBeganAt (INSDraggingSource This, NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("draggedImage:beganAt:"), image__handle__, screenPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("draggedImage:endedAt:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtOperation (NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			_DraggedImageEndedAtOperation (this, image, screenPoint, operation);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggedImageEndedAtOperation (INSDraggingSource This, NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("draggedImage:endedAt:operation:"), image__handle__, screenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("draggedImage:movedTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageMovedTo (NSImage image, CGPoint screenPoint)
		{
			_DraggedImageMovedTo (this, image, screenPoint);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggedImageMovedTo (INSDraggingSource This, NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("draggedImage:movedTo:"), image__handle__, screenPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("draggedImage:endedAt:deposited:")]
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtDeposited (NSImage image, CGPoint screenPoint, bool deposited)
		{
			_DraggedImageEndedAtDeposited (this, image, screenPoint, deposited);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggedImageEndedAtDeposited (INSDraggingSource This, NSImage image, CGPoint screenPoint, bool deposited)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_bool (This.Handle, Selector.GetHandle ("draggedImage:endedAt:deposited:"), image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		[DynamicDependencyAttribute ("DraggedImageBeganAt(AppKit.NSImage,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("DraggedImageEndedAtDeposited(AppKit.NSImage,CoreGraphics.CGPoint,System.Boolean)")]
		[DynamicDependencyAttribute ("DraggedImageEndedAtOperation(AppKit.NSImage,CoreGraphics.CGPoint,AppKit.NSDragOperation)")]
		[DynamicDependencyAttribute ("DraggedImageMovedTo(AppKit.NSImage,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("DraggingSourceOperationMaskForLocal(System.Boolean)")]
		[DynamicDependencyAttribute ("IgnoreModifierKeysWhileDragging")]
		[DynamicDependencyAttribute ("NamesOfPromisedFilesDroppedAtDestination(Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSDraggingSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IgnoreModifierKeysWhileDragging {
			[Export ("ignoreModifierKeysWhileDragging")]
			get {
				return _GetIgnoreModifierKeysWhileDragging (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIgnoreModifierKeysWhileDragging (INSDraggingSource This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("ignoreModifierKeysWhileDragging"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSDraggingSource" /> interface to support all the methods from the NSDraggingSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSDraggingSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSDraggingSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSDraggingSource_Extensions {
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDragOperation DraggingSourceOperationMaskForLocal (this INSDraggingSource This, bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDragOperation ret;
			ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("draggingSourceOperationMaskForLocal:"), flag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] NamesOfPromisedFilesDroppedAtDestination (this INSDraggingSource This, NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:"), dropDestination__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggedImageBeganAt (this INSDraggingSource This, NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("draggedImage:beganAt:"), image__handle__, screenPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggedImageEndedAtOperation (this INSDraggingSource This, NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("draggedImage:endedAt:operation:"), image__handle__, screenPoint, (UIntPtr) (ulong) operation);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggedImageMovedTo (this INSDraggingSource This, NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (This.Handle, Selector.GetHandle ("draggedImage:movedTo:"), image__handle__, screenPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggedImageEndedAtDeposited (this INSDraggingSource This, NSImage image, CGPoint screenPoint, bool deposited)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_bool (This.Handle, Selector.GetHandle ("draggedImage:endedAt:deposited:"), image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (image);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIgnoreModifierKeysWhileDragging (this INSDraggingSource This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("ignoreModifierKeysWhileDragging"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSDraggingSourceWrapper : BaseWrapper, INSDraggingSource {
		public NSDraggingSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDraggingSourceWrapper))]
		static NSDraggingSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSDraggingSource" /> (for the protocol <c>NSDraggingSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSDraggingSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSDraggingSource", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSDraggingSource : NSObject, INSDraggingSource {
		/// <summary>Creates a new <see cref="NSDraggingSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDraggingSource () : base (NSObjectFlag.Empty)
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
		protected NSDraggingSource (NSObjectFlag t) : base (t)
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
		protected internal NSDraggingSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:beganAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageBeganAt (NSImage image, CGPoint screenPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:deposited:")]
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtDeposited (NSImage image, CGPoint screenPoint, bool deposited)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:operation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtOperation (NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:movedTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageMovedTo (NSImage image, CGPoint screenPoint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("draggingSourceOperationMaskForLocal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingSourceOperationMaskForLocal (bool flag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IgnoreModifierKeysWhileDragging {
			[Export ("ignoreModifierKeysWhileDragging")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSDraggingSource */
}
