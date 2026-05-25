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
	/// <summary>This interface represents the Objective-C protocol <c>NSCloudSharingServiceDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCloudSharingServiceDelegate", WrapperType = typeof (NSCloudSharingServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Completed", Selector = "sharingService:didCompleteForItems:error:", ParameterType = new Type [] { typeof (NSSharingService), typeof (NSObject[]), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Options", Selector = "optionsForSharingService:shareProvider:", ReturnType = typeof (NSCloudKitSharingServiceOptions), ParameterType = new Type [] { typeof (NSSharingService), typeof (NSItemProvider) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Saved", Selector = "sharingService:didSaveShare:", ParameterType = new Type [] { typeof (NSSharingService), typeof (CKShare) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Stopped", Selector = "sharingService:didStopSharing:", ParameterType = new Type [] { typeof (NSSharingService), typeof (CKShare) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSCloudSharingServiceDelegate : INativeObject, IDisposable, 
		AppKit.INSSharingServiceDelegate
	{
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:didCompleteForItems:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Completed (NSSharingService sharingService, NSObject[] items, NSError? error)
		{
			_Completed (this, sharingService, items, error);
		}
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Completed (INSCloudSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError? error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var error__handle__ = error.GetHandle ();
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didCompleteForItems:error:"), sharingService__handle__, nsa_items.Handle, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (error);
		}
		/// <param name="cloudKitSharingService">To be added.</param><param name="provider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("optionsForSharingService:shareProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCloudKitSharingServiceOptions Options (NSSharingService cloudKitSharingService, NSItemProvider provider)
		{
			return _Options (this, cloudKitSharingService, provider);
		}
		/// <param name="cloudKitSharingService">To be added.</param><param name="provider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCloudKitSharingServiceOptions _Options (INSCloudSharingServiceDelegate This, NSSharingService cloudKitSharingService, NSItemProvider provider)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cloudKitSharingService__handle__ = cloudKitSharingService!.GetNonNullHandle (nameof (cloudKitSharingService));
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			NSCloudKitSharingServiceOptions ret;
			ret = (NSCloudKitSharingServiceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("optionsForSharingService:shareProvider:"), cloudKitSharingService__handle__, provider__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cloudKitSharingService);
			GC.KeepAlive (provider);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:didSaveShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Saved (NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			_Saved (this, sharingService, share);
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Saved (INSCloudSharingServiceDelegate This, NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didSaveShare:"), sharingService__handle__, share__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (share);
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingService:didStopSharing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			_Stopped (this, sharingService, share);
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Stopped (INSCloudSharingServiceDelegate This, NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didStopSharing:"), sharingService__handle__, share__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (share);
		}
		[DynamicDependencyAttribute ("Completed(AppKit.NSSharingService,Foundation.NSObject[],Foundation.NSError)")]
		[DynamicDependencyAttribute ("Options(AppKit.NSSharingService,Foundation.NSItemProvider)")]
		[DynamicDependencyAttribute ("Saved(AppKit.NSSharingService,CloudKit.CKShare)")]
		[DynamicDependencyAttribute ("Stopped(AppKit.NSSharingService,CloudKit.CKShare)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCloudSharingServiceDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCloudSharingServiceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCloudSharingServiceDelegate" /> interface to support all the methods from the NSCloudSharingServiceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCloudSharingServiceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCloudSharingServiceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCloudSharingServiceDelegate_Extensions {
		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Completed (this INSCloudSharingServiceDelegate This, NSSharingService sharingService, NSObject[] items, NSError? error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var error__handle__ = error.GetHandle ();
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didCompleteForItems:error:"), sharingService__handle__, nsa_items.Handle, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (error);
		}
		/// <param name="cloudKitSharingService">To be added.</param><param name="provider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCloudKitSharingServiceOptions Options (this INSCloudSharingServiceDelegate This, NSSharingService cloudKitSharingService, NSItemProvider provider)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cloudKitSharingService__handle__ = cloudKitSharingService!.GetNonNullHandle (nameof (cloudKitSharingService));
			var provider__handle__ = provider!.GetNonNullHandle (nameof (provider));
			NSCloudKitSharingServiceOptions ret;
			ret = (NSCloudKitSharingServiceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("optionsForSharingService:shareProvider:"), cloudKitSharingService__handle__, provider__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (cloudKitSharingService);
			GC.KeepAlive (provider);
			return ret!;
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Saved (this INSCloudSharingServiceDelegate This, NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didSaveShare:"), sharingService__handle__, share__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (share);
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Stopped (this INSCloudSharingServiceDelegate This, NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			var share__handle__ = share!.GetNonNullHandle (nameof (share));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingService:didStopSharing:"), sharingService__handle__, share__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingService);
			GC.KeepAlive (share);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCloudSharingServiceDelegateWrapper : BaseWrapper, INSCloudSharingServiceDelegate {
		public NSCloudSharingServiceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCloudSharingServiceDelegateWrapper))]
		static NSCloudSharingServiceDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCloudSharingServiceDelegate" /> (for the protocol <c>NSCloudSharingServiceDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCloudSharingServiceDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCloudSharingServiceDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCloudSharingServiceDelegate : NSSharingServiceDelegate, INSCloudSharingServiceDelegate {
		/// <summary>Creates a new <see cref="NSCloudSharingServiceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCloudSharingServiceDelegate () : base (NSObjectFlag.Empty)
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
		protected NSCloudSharingServiceDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSCloudSharingServiceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sharingService">To be added.</param><param name="items">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:didCompleteForItems:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Completed (NSSharingService sharingService, NSObject[] items, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cloudKitSharingService">To be added.</param><param name="provider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("optionsForSharingService:shareProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCloudKitSharingServiceOptions Options (NSSharingService cloudKitSharingService, NSItemProvider provider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:didSaveShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Saved (NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingService">To be added.</param><param name="share">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingService:didStopSharing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (NSSharingService sharingService, global::CloudKit.CKShare share)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSCloudSharingServiceDelegate */
}
