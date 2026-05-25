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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>Abstract implementation of <see cref="T:CarPlay.ICPListTemplateDelegate" />, the delegate object for <see cref="T:CarPlay.CPListTemplate" /> objects.</summary>
	[ObsoletedOSPlatform ("ios14.0", "Use 'CPListItem.Handler' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "CPListTemplateDelegate", WrapperType = typeof (CPListTemplateDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectListItem", Selector = "listTemplate:didSelectListItem:completionHandler:", ParameterType = new Type [] { typeof (CarPlay.CPListTemplate), typeof (CarPlay.CPListItem), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface ICPListTemplateDelegate : INativeObject, IDisposable
	{
		/// <param name="listTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to react to the selection of a list item.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("listTemplate:didSelectListItem:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectListItem (CPListTemplate listTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="listTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to react to the selection of a list item.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidSelectListItem (ICPListTemplateDelegate This, CPListTemplate listTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var listTemplate__handle__ = listTemplate!.GetNonNullHandle (nameof (listTemplate));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("listTemplate:didSelectListItem:completionHandler:"), listTemplate__handle__, item__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (listTemplate);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("DidSelectListItem(CarPlay.CPListTemplate,CarPlay.CPListItem,System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPListTemplateDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPListTemplateDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPListTemplateDelegateWrapper : BaseWrapper, ICPListTemplateDelegate {
		public CPListTemplateDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPListTemplateDelegateWrapper))]
		static CPListTemplateDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="listTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to react to the selection of a list item.</summary><remarks>To be added.</remarks>
		[Export ("listTemplate:didSelectListItem:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DidSelectListItem (CPListTemplate listTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var listTemplate__handle__ = listTemplate!.GetNonNullHandle (nameof (listTemplate));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("listTemplate:didSelectListItem:completionHandler:"), listTemplate__handle__, item__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (listTemplate);
			GC.KeepAlive (item);
		}
	}
}
namespace CarPlay {
	/// <summary>Abstract implementation of <see cref="T:CarPlay.ICPListTemplateDelegate" />, the delegate object for <see cref="T:CarPlay.CPListTemplate" /> objects.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPListTemplateDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("ios14.0", "Use 'CPListItem.Handler' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class CPListTemplateDelegate : NSObject, ICPListTemplateDelegate {
		/// <summary>Creates a new <see cref="CPListTemplateDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CPListTemplateDelegate () : base (NSObjectFlag.Empty)
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
		protected CPListTemplateDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPListTemplateDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="listTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to react to the selection of a list item.</summary><remarks>To be added.</remarks>
		[Export ("listTemplate:didSelectListItem:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidSelectListItem (CPListTemplate listTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPListTemplateDelegate */
}
