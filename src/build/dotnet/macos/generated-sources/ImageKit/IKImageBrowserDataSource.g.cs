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
namespace ImageKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>IKImageBrowserDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "IKImageBrowserDataSource", WrapperType = typeof (IKImageBrowserDataSourceWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ItemCount", Selector = "numberOfItemsInImageBrowser:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "imageBrowser:itemAtIndex:", ReturnType = typeof (ImageKit.IIKImageBrowserItem), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveItems", Selector = "imageBrowser:removeItemsAtIndexes:", ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (NSIndexSet) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveItems", Selector = "imageBrowser:moveItemsAtIndexes:toIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (NSIndexSet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItemsToPasteboard", Selector = "imageBrowser:writeItemsAtIndexes:toPasteboard:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (NSIndexSet), typeof (NSPasteboard) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GroupCount", Selector = "numberOfGroupsInImageBrowser:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetGroup", Selector = "imageBrowser:groupAtIndex:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (ImageKit.IKImageBrowserView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IIKImageBrowserDataSource : INativeObject, IDisposable
	{
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("numberOfItemsInImageBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ItemCount (IKImageBrowserView aBrowser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _ItemCount (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfItemsInImageBrowser:"), aBrowser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("imageBrowser:itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IIKImageBrowserItem GetItem (IKImageBrowserView aBrowser, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IIKImageBrowserItem _GetItem (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, nint index)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			IIKImageBrowserItem? ret;
			ret =  Runtime.GetINativeObject<IIKImageBrowserItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:itemAtIndex:"), aBrowser__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:removeItemsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes)
		{
			_RemoveItems (this, aBrowser, indexes);
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveItems (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:removeItemsAtIndexes:"), aBrowser__handle__, indexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (indexes);
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><param name="destinationIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:moveItemsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
		{
			return _MoveItems (this, aBrowser, indexes, destinationIndex);
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><param name="destinationIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _MoveItems (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:moveItemsAtIndexes:toIndex:"), aBrowser__handle__, indexes__handle__, destinationIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (indexes);
			return ret != 0;
		}
		/// <param name="aBrowser">To be added.</param><param name="itemIndexes">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:writeItemsAtIndexes:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint WriteItemsToPasteboard (IKImageBrowserView aBrowser, NSIndexSet itemIndexes, global::AppKit.NSPasteboard pasteboard)
		{
			return _WriteItemsToPasteboard (this, aBrowser, itemIndexes, pasteboard);
		}
		/// <param name="aBrowser">To be added.</param><param name="itemIndexes">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _WriteItemsToPasteboard (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet itemIndexes, global::AppKit.NSPasteboard pasteboard)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var itemIndexes__handle__ = itemIndexes!.GetNonNullHandle (nameof (itemIndexes));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:writeItemsAtIndexes:toPasteboard:"), aBrowser__handle__, itemIndexes__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (itemIndexes);
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfGroupsInImageBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GroupCount (IKImageBrowserView aBrowser)
		{
			return _GroupCount (this, aBrowser);
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GroupCount (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfGroupsInImageBrowser:"), aBrowser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBrowser:groupAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetGroup (IKImageBrowserView aBrowser, nint index)
		{
			return _GetGroup (this, aBrowser, index);
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetGroup (IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, nint index)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:groupAtIndex:"), aBrowser__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetGroup(ImageKit.IKImageBrowserView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetItem(ImageKit.IKImageBrowserView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GroupCount(ImageKit.IKImageBrowserView)")]
		[DynamicDependencyAttribute ("ItemCount(ImageKit.IKImageBrowserView)")]
		[DynamicDependencyAttribute ("MoveItems(ImageKit.IKImageBrowserView,Foundation.NSIndexSet,System.IntPtr)")]
		[DynamicDependencyAttribute ("RemoveItems(ImageKit.IKImageBrowserView,Foundation.NSIndexSet)")]
		[DynamicDependencyAttribute ("WriteItemsToPasteboard(ImageKit.IKImageBrowserView,Foundation.NSIndexSet,AppKit.NSPasteboard)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IIKImageBrowserDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IIKImageBrowserDataSource" /> interface to support all the methods from the IKImageBrowserDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IIKImageBrowserDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original IKImageBrowserDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class IKImageBrowserDataSource_Extensions {
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveItems (this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:removeItemsAtIndexes:"), aBrowser__handle__, indexes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (indexes);
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><param name="destinationIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MoveItems (this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:moveItemsAtIndexes:toIndex:"), aBrowser__handle__, indexes__handle__, destinationIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (indexes);
			return ret != 0;
		}
		/// <param name="aBrowser">To be added.</param><param name="itemIndexes">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint WriteItemsToPasteboard (this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, NSIndexSet itemIndexes, global::AppKit.NSPasteboard pasteboard)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			var itemIndexes__handle__ = itemIndexes!.GetNonNullHandle (nameof (itemIndexes));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageBrowser:writeItemsAtIndexes:toPasteboard:"), aBrowser__handle__, itemIndexes__handle__, pasteboard__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			GC.KeepAlive (itemIndexes);
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GroupCount (this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfGroupsInImageBrowser:"), aBrowser__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetGroup (this IIKImageBrowserDataSource This, IKImageBrowserView aBrowser, nint index)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("imageBrowser:groupAtIndex:"), aBrowser__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class IKImageBrowserDataSourceWrapper : BaseWrapper, IIKImageBrowserDataSource {
		public IKImageBrowserDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserDataSourceWrapper))]
		static IKImageBrowserDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfItemsInImageBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint ItemCount (IKImageBrowserView aBrowser)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfItemsInImageBrowser:"), aBrowser__handle__);
			GC.KeepAlive (aBrowser);
			return ret!;
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBrowser:itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IIKImageBrowserItem GetItem (IKImageBrowserView aBrowser, nint index)
		{
			var aBrowser__handle__ = aBrowser!.GetNonNullHandle (nameof (aBrowser));
			IIKImageBrowserItem? ret;
			ret =  Runtime.GetINativeObject<IIKImageBrowserItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("imageBrowser:itemAtIndex:"), aBrowser__handle__, index), false)!;
			GC.KeepAlive (aBrowser);
			return ret!;
		}
	}
}
namespace ImageKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IIKImageBrowserDataSource" /> (for the protocol <c>IKImageBrowserDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IIKImageBrowserDataSource" />.</para>
	/// </summary>
	[Protocol(IsInformal = true)]
	[Register("Microsoft_macOS__ImageKit_IKImageBrowserDataSource", false)]
	[Model]
	public unsafe abstract partial class IKImageBrowserDataSource : NSObject, IIKImageBrowserDataSource {
		/// <summary>Creates a new <see cref="IKImageBrowserDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected IKImageBrowserDataSource () : base (NSObjectFlag.Empty)
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
		protected IKImageBrowserDataSource (NSObjectFlag t) : base (t)
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
		protected internal IKImageBrowserDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBrowser:groupAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetGroup (IKImageBrowserView aBrowser, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBrowser:itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IIKImageBrowserItem GetItem (IKImageBrowserView aBrowser, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfGroupsInImageBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GroupCount (IKImageBrowserView aBrowser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfItemsInImageBrowser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ItemCount (IKImageBrowserView aBrowser)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><param name="destinationIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBrowser:moveItemsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("imageBrowser:removeItemsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveItems (IKImageBrowserView aBrowser, NSIndexSet indexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="aBrowser">To be added.</param><param name="itemIndexes">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageBrowser:writeItemsAtIndexes:toPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint WriteItemsToPasteboard (IKImageBrowserView aBrowser, NSIndexSet itemIndexes, global::AppKit.NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupBackgroundColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupBackgroundColorKey",  "ImageKit")]
		public static NSString GroupBackgroundColorKey {
			get {
				if (_GroupBackgroundColorKey is null)
					_GroupBackgroundColorKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupBackgroundColorKey")!;
				return _GroupBackgroundColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupFooterLayer;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupFooterLayer",  "ImageKit")]
		public static NSString GroupFooterLayer {
			get {
				if (_GroupFooterLayer is null)
					_GroupFooterLayer = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupFooterLayer")!;
				return _GroupFooterLayer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupHeaderLayer;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupHeaderLayer",  "ImageKit")]
		public static NSString GroupHeaderLayer {
			get {
				if (_GroupHeaderLayer is null)
					_GroupHeaderLayer = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupHeaderLayer")!;
				return _GroupHeaderLayer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupRangeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupRangeKey",  "ImageKit")]
		public static NSString GroupRangeKey {
			get {
				if (_GroupRangeKey is null)
					_GroupRangeKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupRangeKey")!;
				return _GroupRangeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupStyleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupStyleKey",  "ImageKit")]
		public static NSString GroupStyleKey {
			get {
				if (_GroupStyleKey is null)
					_GroupStyleKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupStyleKey")!;
				return _GroupStyleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GroupTitleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserGroupTitleKey",  "ImageKit")]
		public static NSString GroupTitleKey {
			get {
				if (_GroupTitleKey is null)
					_GroupTitleKey = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserGroupTitleKey")!;
				return _GroupTitleKey;
			}
		}
	} /* class IKImageBrowserDataSource */
}
