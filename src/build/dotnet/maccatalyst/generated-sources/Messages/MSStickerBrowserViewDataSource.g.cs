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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Messages {
	#pragma warning disable CS1573
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/Messages/MSStickerBrowserViewDataSource">Apple documentation for <c>MSStickerBrowserViewDataSource</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MSStickerBrowserViewDataSource", WrapperType = typeof (MSStickerBrowserViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNumberOfStickers", Selector = "numberOfStickersInStickerBrowserView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (MSStickerBrowserView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSticker", Selector = "stickerBrowserView:stickerAtIndex:", ReturnType = typeof (MSSticker), ParameterType = new Type [] { typeof (MSStickerBrowserView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMSStickerBrowserViewDataSource : INativeObject, IDisposable
	{
		/// <param name="stickerBrowserView">To be added.</param><summary>The number of <see cref="T:Messages.MSSticker" /> objects held by this data source.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("numberOfStickersInStickerBrowserView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfStickers (MSStickerBrowserView stickerBrowserView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="stickerBrowserView">To be added.</param><summary>The number of <see cref="T:Messages.MSSticker" /> objects held by this data source.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNumberOfStickers (IMSStickerBrowserViewDataSource This, MSStickerBrowserView stickerBrowserView)
		{
			var stickerBrowserView__handle__ = stickerBrowserView!.GetNonNullHandle (nameof (stickerBrowserView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfStickersInStickerBrowserView:"), stickerBrowserView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (stickerBrowserView);
			return ret!;
		}
		/// <param name="stickerBrowserView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("stickerBrowserView:stickerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MSSticker GetSticker (MSStickerBrowserView stickerBrowserView, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="stickerBrowserView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MSSticker _GetSticker (IMSStickerBrowserViewDataSource This, MSStickerBrowserView stickerBrowserView, nint index)
		{
			var stickerBrowserView__handle__ = stickerBrowserView!.GetNonNullHandle (nameof (stickerBrowserView));
			MSSticker? ret;
			ret =  Runtime.GetNSObject<MSSticker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("stickerBrowserView:stickerAtIndex:"), stickerBrowserView__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (stickerBrowserView);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetNumberOfStickers(Messages.MSStickerBrowserView)")]
		[DynamicDependencyAttribute ("GetSticker(Messages.MSStickerBrowserView,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSStickerBrowserViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMSStickerBrowserViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MSStickerBrowserViewDataSourceWrapper : BaseWrapper, IMSStickerBrowserViewDataSource {
		public MSStickerBrowserViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSStickerBrowserViewDataSourceWrapper))]
		static MSStickerBrowserViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="stickerBrowserView">To be added.</param><summary>The number of <see cref="T:Messages.MSSticker" /> objects held by this data source.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfStickersInStickerBrowserView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetNumberOfStickers (MSStickerBrowserView stickerBrowserView)
		{
			var stickerBrowserView__handle__ = stickerBrowserView!.GetNonNullHandle (nameof (stickerBrowserView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfStickersInStickerBrowserView:"), stickerBrowserView__handle__);
			GC.KeepAlive (stickerBrowserView);
			return ret!;
		}
		/// <param name="stickerBrowserView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stickerBrowserView:stickerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MSSticker GetSticker (MSStickerBrowserView stickerBrowserView, nint index)
		{
			var stickerBrowserView__handle__ = stickerBrowserView!.GetNonNullHandle (nameof (stickerBrowserView));
			MSSticker? ret;
			ret =  Runtime.GetNSObject<MSSticker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("stickerBrowserView:stickerAtIndex:"), stickerBrowserView__handle__, index), false)!;
			GC.KeepAlive (stickerBrowserView);
			return ret!;
		}
	}
}
namespace Messages {
	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/Messages/MSStickerBrowserViewDataSource">Apple documentation for <c>MSStickerBrowserViewDataSource</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Messages_MSStickerBrowserViewDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class MSStickerBrowserViewDataSource : NSObject, IMSStickerBrowserViewDataSource {
		/// <summary>Creates a new <see cref="MSStickerBrowserViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MSStickerBrowserViewDataSource () : base (NSObjectFlag.Empty)
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
		protected MSStickerBrowserViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal MSStickerBrowserViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="stickerBrowserView">To be added.</param><summary>The number of <see cref="T:Messages.MSSticker" /> objects held by this data source.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfStickersInStickerBrowserView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfStickers (MSStickerBrowserView stickerBrowserView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="stickerBrowserView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stickerBrowserView:stickerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MSSticker GetSticker (MSStickerBrowserView stickerBrowserView, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MSStickerBrowserViewDataSource */
}
