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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for the CloudKit sharing controller.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/UIKit/UICloudSharingControllerDelegate">Apple documentation for <c>UICloudSharingControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UICloudSharingControllerDelegate", WrapperType = typeof (UICloudSharingControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FailedToSaveShare", Selector = "cloudSharingController:failedToSaveShareWithError:", ParameterType = new Type [] { typeof (UICloudSharingController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemTitle", Selector = "itemTitleForCloudSharingController:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UICloudSharingController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemThumbnailData", Selector = "itemThumbnailDataForCloudSharingController:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (UICloudSharingController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemType", Selector = "itemTypeForCloudSharingController:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UICloudSharingController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSaveShare", Selector = "cloudSharingControllerDidSaveShare:", ParameterType = new Type [] { typeof (UICloudSharingController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopSharing", Selector = "cloudSharingControllerDidStopSharing:", ParameterType = new Type [] { typeof (UICloudSharingController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUICloudSharingControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="csc">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("cloudSharingController:failedToSaveShareWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToSaveShare (UICloudSharingController csc, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToSaveShare (IUICloudSharingControllerDelegate This, UICloudSharingController csc, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cloudSharingController:failedToSaveShareWithError:"), csc__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			GC.KeepAlive (error);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("itemTitleForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetItemTitle (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetItemTitle (IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemTitleForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			return ret!;
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("itemThumbnailDataForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetItemThumbnailData (UICloudSharingController csc)
		{
			return _GetItemThumbnailData (this, csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData? _GetItemThumbnailData (IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemThumbnailDataForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			return ret!;
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("itemTypeForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetItemType (UICloudSharingController csc)
		{
			return _GetItemType (this, csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetItemType (IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemTypeForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			return ret!;
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cloudSharingControllerDidSaveShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSaveShare (UICloudSharingController csc)
		{
			_DidSaveShare (this, csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSaveShare (IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudSharingControllerDidSaveShare:"), csc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cloudSharingControllerDidStopSharing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopSharing (UICloudSharingController csc)
		{
			_DidStopSharing (this, csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopSharing (IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudSharingControllerDidStopSharing:"), csc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
		}
		[DynamicDependencyAttribute ("DidSaveShare(UIKit.UICloudSharingController)")]
		[DynamicDependencyAttribute ("DidStopSharing(UIKit.UICloudSharingController)")]
		[DynamicDependencyAttribute ("FailedToSaveShare(UIKit.UICloudSharingController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("GetItemThumbnailData(UIKit.UICloudSharingController)")]
		[DynamicDependencyAttribute ("GetItemTitle(UIKit.UICloudSharingController)")]
		[DynamicDependencyAttribute ("GetItemType(UIKit.UICloudSharingController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICloudSharingControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICloudSharingControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICloudSharingControllerDelegate" /> interface to support all the methods from the UICloudSharingControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICloudSharingControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICloudSharingControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICloudSharingControllerDelegate_Extensions {
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetItemThumbnailData (this IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemThumbnailDataForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			return ret!;
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetItemType (this IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemTypeForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
			return ret!;
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSaveShare (this IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudSharingControllerDidSaveShare:"), csc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopSharing (this IUICloudSharingControllerDelegate This, UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudSharingControllerDidStopSharing:"), csc__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (csc);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICloudSharingControllerDelegateWrapper : BaseWrapper, IUICloudSharingControllerDelegate {
		public UICloudSharingControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICloudSharingControllerDelegateWrapper))]
		static UICloudSharingControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="csc">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cloudSharingController:failedToSaveShareWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FailedToSaveShare (UICloudSharingController csc, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("cloudSharingController:failedToSaveShareWithError:"), csc__handle__, error__handle__);
			GC.KeepAlive (csc);
			GC.KeepAlive (error);
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemTitleForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? GetItemTitle (UICloudSharingController csc)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var csc__handle__ = csc!.GetNonNullHandle (nameof (csc));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("itemTitleForCloudSharingController:"), csc__handle__), false)!;
			GC.KeepAlive (csc);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for the CloudKit sharing controller.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/UIKit/UICloudSharingControllerDelegate">Apple documentation for <c>UICloudSharingControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UICloudSharingControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UICloudSharingControllerDelegate : NSObject, IUICloudSharingControllerDelegate {
		/// <summary>Creates a new <see cref="UICloudSharingControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UICloudSharingControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UICloudSharingControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UICloudSharingControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cloudSharingControllerDidSaveShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSaveShare (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cloudSharingControllerDidStopSharing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopSharing (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cloudSharingController:failedToSaveShareWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToSaveShare (UICloudSharingController csc, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemThumbnailDataForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetItemThumbnailData (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemTitleForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetItemTitle (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="csc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemTypeForCloudSharingController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetItemType (UICloudSharingController csc)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICloudSharingControllerDelegate */
}
