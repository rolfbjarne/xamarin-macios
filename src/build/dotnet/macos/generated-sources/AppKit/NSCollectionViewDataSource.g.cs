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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionViewDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCollectionViewDataSource", WrapperType = typeof (NSCollectionViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNumberofItems", Selector = "collectionView:numberOfItemsInSection:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSCollectionView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "collectionView:itemForRepresentedObjectAtIndexPath:", ReturnType = typeof (NSCollectionViewItem), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNumberOfSections", Selector = "numberOfSectionsInCollectionView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSCollectionView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "collectionView:viewForSupplementaryElementOfKind:atIndexPath:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSString), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSCollectionViewDataSource : INativeObject, IDisposable
	{
		/// <param name="collectionView">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberofItems (NSCollectionView collectionView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNumberofItems (INSCollectionViewDataSource This, NSCollectionView collectionView, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:itemForRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem GetItem (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCollectionViewItem _GetItem (INSCollectionViewDataSource This, NSCollectionView collectionView, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewItem? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:itemForRepresentedObjectAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfSectionsInCollectionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfSections (NSCollectionView collectionView)
		{
			return _GetNumberOfSections (this, collectionView);
		}
		/// <param name="collectionView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNumberOfSections (INSCollectionViewDataSource This, NSCollectionView collectionView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="kind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
		{
			return _GetView (this, collectionView, kind, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="kind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSView _GetView (INSCollectionViewDataSource This, NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, kind__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (kind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetItem(AppKit.NSCollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetNumberofItems(AppKit.NSCollectionView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetNumberOfSections(AppKit.NSCollectionView)")]
		[DynamicDependencyAttribute ("GetView(AppKit.NSCollectionView,Foundation.NSString,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCollectionViewDataSource" /> interface to support all the methods from the NSCollectionViewDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCollectionViewDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCollectionViewDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCollectionViewDataSource_Extensions {
		/// <param name="collectionView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetNumberOfSections (this INSCollectionViewDataSource This, NSCollectionView collectionView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="kind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSView GetView (this INSCollectionViewDataSource This, NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, kind__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (kind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionViewDataSourceWrapper : BaseWrapper, INSCollectionViewDataSource {
		public NSCollectionViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDataSourceWrapper))]
		static NSCollectionViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetNumberofItems (NSCollectionView collectionView, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemForRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCollectionViewItem GetItem (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewItem? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:itemForRepresentedObjectAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCollectionViewDataSource" /> (for the protocol <c>NSCollectionViewDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCollectionViewDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCollectionViewDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSCollectionViewDataSource : NSObject, INSCollectionViewDataSource {
		/// <summary>Creates a new <see cref="NSCollectionViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSCollectionViewDataSource () : base (NSObjectFlag.Empty)
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
		protected NSCollectionViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemForRepresentedObjectAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem GetItem (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInCollectionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfSections (NSCollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberofItems (NSCollectionView collectionView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="kind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSCollectionViewDataSource */
}
