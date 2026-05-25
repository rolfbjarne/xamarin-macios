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
namespace Photos {
	#pragma warning disable CS1573
	/// <summary>Provides methods relating to changes in the <see cref="T:Photos.PHPhotoLibrary" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHPhotoLibraryChangeObserver_Protocol/index.html">Apple documentation for <c>PHPhotoLibraryChangeObserver</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "PHPhotoLibraryChangeObserver", WrapperType = typeof (PHPhotoLibraryChangeObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PhotoLibraryDidChange", Selector = "photoLibraryDidChange:", ParameterType = new Type [] { typeof (PHChange) }, ParameterByRef = new bool [] { false })]
	public partial interface IPHPhotoLibraryChangeObserver : INativeObject, IDisposable
	{
		/// <param name="changeInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("photoLibraryDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PhotoLibraryDidChange (PHChange changeInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="changeInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PhotoLibraryDidChange (IPHPhotoLibraryChangeObserver This, PHChange changeInstance)
		{
			var changeInstance__handle__ = changeInstance!.GetNonNullHandle (nameof (changeInstance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("photoLibraryDidChange:"), changeInstance__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (changeInstance);
		}
		[DynamicDependencyAttribute ("PhotoLibraryDidChange(Photos.PHChange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHPhotoLibraryChangeObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHPhotoLibraryChangeObserver ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHPhotoLibraryChangeObserverWrapper : BaseWrapper, IPHPhotoLibraryChangeObserver {
		public PHPhotoLibraryChangeObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHPhotoLibraryChangeObserverWrapper))]
		static PHPhotoLibraryChangeObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="changeInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("photoLibraryDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PhotoLibraryDidChange (PHChange changeInstance)
		{
			var changeInstance__handle__ = changeInstance!.GetNonNullHandle (nameof (changeInstance));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("photoLibraryDidChange:"), changeInstance__handle__);
			GC.KeepAlive (changeInstance);
		}
	}
}
namespace Photos {
	/// <summary>Provides methods relating to changes in the <see cref="T:Photos.PHPhotoLibrary" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Photos/Reference/PHPhotoLibraryChangeObserver_Protocol/index.html">Apple documentation for <c>PHPhotoLibraryChangeObserver</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__Photos_PHPhotoLibraryChangeObserver", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class PHPhotoLibraryChangeObserver : NSObject, IPHPhotoLibraryChangeObserver {
		/// <summary>Creates a new <see cref="PHPhotoLibraryChangeObserver" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PHPhotoLibraryChangeObserver () : base (NSObjectFlag.Empty)
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
		protected PHPhotoLibraryChangeObserver (NSObjectFlag t) : base (t)
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
		protected internal PHPhotoLibraryChangeObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="changeInstance">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("photoLibraryDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PhotoLibraryDidChange (PHChange changeInstance)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PHPhotoLibraryChangeObserver */
}
