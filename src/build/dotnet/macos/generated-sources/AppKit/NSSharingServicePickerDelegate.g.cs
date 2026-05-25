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
	/// <summary>This interface represents the Objective-C protocol <c>NSSharingServicePickerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSSharingServicePickerDelegate", WrapperType = typeof (NSSharingServicePickerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SharingServicesForItems", Selector = "sharingServicePicker:sharingServicesForItems:proposedSharingServices:", ReturnType = typeof (NSSharingService[]), ParameterType = new Type [] { typeof (NSSharingServicePicker), typeof (NSObject[]), typeof (NSSharingService[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DelegateForSharingService", Selector = "sharingServicePicker:delegateForSharingService:", ReturnType = typeof (INSSharingServiceDelegate), ParameterType = new Type [] { typeof (NSSharingServicePicker), typeof (NSSharingService) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChooseSharingService", Selector = "sharingServicePicker:didChooseSharingService:", ParameterType = new Type [] { typeof (NSSharingServicePicker), typeof (NSSharingService) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCollaborationModeRestrictions", Selector = "sharingServicePickerCollaborationModeRestrictions:", ReturnType = typeof (NSSharingCollaborationModeRestriction[]), ParameterType = new Type [] { typeof (NSSharingServicePicker) }, ParameterByRef = new bool [] { false })]
	public partial interface INSSharingServicePickerDelegate : INativeObject, IDisposable
	{
		/// <param name="sharingServicePicker">To be added.</param><param name="items">To be added.</param><param name="proposedServices">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSharingService[] SharingServicesForItems (NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			return _SharingServicesForItems (this, sharingServicePicker, items, proposedServices);
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="items">To be added.</param><param name="proposedServices">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSharingService[] _SharingServicesForItems (INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			if (proposedServices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proposedServices));
			using var nsa_items = NSArray.FromNSObjects (items);
			using var nsa_proposedServices = NSArray.FromNSObjects (proposedServices);
			NSSharingService[]? ret;
			ret = CFArray.ArrayFromHandle<NSSharingService>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:sharingServicesForItems:proposedSharingServices:"), sharingServicePicker__handle__, nsa_items.Handle, nsa_proposedServices.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			return ret!;
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="sharingService">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingServicePicker:delegateForSharingService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSSharingServiceDelegate DelegateForSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			return _DelegateForSharingService (this, sharingServicePicker, sharingService);
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="sharingService">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSSharingServiceDelegate _DelegateForSharingService (INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			INSSharingServiceDelegate? ret;
			ret =  Runtime.GetINativeObject<INSSharingServiceDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:delegateForSharingService:"), sharingServicePicker__handle__, sharingService__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			GC.KeepAlive (sharingService);
			return ret!;
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="service">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sharingServicePicker:didChooseSharingService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChooseSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			_DidChooseSharingService (this, sharingServicePicker, service);
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="service">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChooseSharingService (INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:didChooseSharingService:"), sharingServicePicker__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			GC.KeepAlive (service);
		}
		[global::Foundation.OptionalMember]
		[Export ("sharingServicePickerCollaborationModeRestrictions:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSharingCollaborationModeRestriction[]? GetCollaborationModeRestrictions (NSSharingServicePicker sharingServicePicker)
		{
			return _GetCollaborationModeRestrictions (this, sharingServicePicker);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSSharingCollaborationModeRestriction[]? _GetCollaborationModeRestrictions (INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			NSSharingCollaborationModeRestriction[]? ret;
			ret = CFArray.ArrayFromHandle<NSSharingCollaborationModeRestriction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePickerCollaborationModeRestrictions:"), sharingServicePicker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			return ret!;
		}
		[DynamicDependencyAttribute ("DelegateForSharingService(AppKit.NSSharingServicePicker,AppKit.NSSharingService)")]
		[DynamicDependencyAttribute ("DidChooseSharingService(AppKit.NSSharingServicePicker,AppKit.NSSharingService)")]
		[DynamicDependencyAttribute ("GetCollaborationModeRestrictions(AppKit.NSSharingServicePicker)")]
		[DynamicDependencyAttribute ("SharingServicesForItems(AppKit.NSSharingServicePicker,Foundation.NSObject[],AppKit.NSSharingService[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSharingServicePickerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSSharingServicePickerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSSharingServicePickerDelegate" /> interface to support all the methods from the NSSharingServicePickerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSSharingServicePickerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSSharingServicePickerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSSharingServicePickerDelegate_Extensions {
		/// <param name="sharingServicePicker">To be added.</param><param name="items">To be added.</param><param name="proposedServices">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSharingService[] SharingServicesForItems (this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			if (proposedServices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proposedServices));
			using var nsa_items = NSArray.FromNSObjects (items);
			using var nsa_proposedServices = NSArray.FromNSObjects (proposedServices);
			NSSharingService[]? ret;
			ret = CFArray.ArrayFromHandle<NSSharingService>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:sharingServicesForItems:proposedSharingServices:"), sharingServicePicker__handle__, nsa_items.Handle, nsa_proposedServices.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			return ret!;
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="sharingService">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSSharingServiceDelegate DelegateForSharingService (this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			var sharingService__handle__ = sharingService!.GetNonNullHandle (nameof (sharingService));
			INSSharingServiceDelegate? ret;
			ret =  Runtime.GetINativeObject<INSSharingServiceDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:delegateForSharingService:"), sharingServicePicker__handle__, sharingService__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			GC.KeepAlive (sharingService);
			return ret!;
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="service">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChooseSharingService (this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			var service__handle__ = service!.GetNonNullHandle (nameof (service));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePicker:didChooseSharingService:"), sharingServicePicker__handle__, service__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			GC.KeepAlive (service);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSharingCollaborationModeRestriction[]? GetCollaborationModeRestrictions (this INSSharingServicePickerDelegate This, NSSharingServicePicker sharingServicePicker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sharingServicePicker__handle__ = sharingServicePicker!.GetNonNullHandle (nameof (sharingServicePicker));
			NSSharingCollaborationModeRestriction[]? ret;
			ret = CFArray.ArrayFromHandle<NSSharingCollaborationModeRestriction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sharingServicePickerCollaborationModeRestrictions:"), sharingServicePicker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (sharingServicePicker);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSSharingServicePickerDelegateWrapper : BaseWrapper, INSSharingServicePickerDelegate {
		public NSSharingServicePickerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSharingServicePickerDelegateWrapper))]
		static NSSharingServicePickerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSSharingServicePickerDelegate" /> (for the protocol <c>NSSharingServicePickerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSSharingServicePickerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSSharingServicePickerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSharingServicePickerDelegate : NSObject, INSSharingServicePickerDelegate {
		/// <summary>Creates a new <see cref="NSSharingServicePickerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSharingServicePickerDelegate () : base (NSObjectFlag.Empty)
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
		protected NSSharingServicePickerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSSharingServicePickerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sharingServicePicker">To be added.</param><param name="sharingService">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sharingServicePicker:delegateForSharingService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSSharingServiceDelegate DelegateForSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="service">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sharingServicePicker:didChooseSharingService:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChooseSharingService (NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sharingServicePickerCollaborationModeRestrictions:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSharingCollaborationModeRestriction[]? GetCollaborationModeRestrictions (NSSharingServicePicker sharingServicePicker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sharingServicePicker">To be added.</param><param name="items">To be added.</param><param name="proposedServices">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSharingService[] SharingServicesForItems (NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSSharingServicePickerDelegate */
}
