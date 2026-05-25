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
	/// <summary>Delegate object for the <see cref="T:CarPlay.CPSearchTemplate" /> class.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "CPSearchTemplateDelegate", WrapperType = typeof (CPSearchTemplateDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatedSearchText", Selector = "searchTemplate:updatedSearchText:completionHandler:", ParameterType = new Type [] { typeof (CarPlay.CPSearchTemplate), typeof (string), typeof (CarPlay.CPSearchTemplateDelegateUpdateHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDCPSearchTemplateDelegateUpdateHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectedResult", Selector = "searchTemplate:selectedResult:completionHandler:", ParameterType = new Type [] { typeof (CarPlay.CPSearchTemplate), typeof (CarPlay.CPListItem), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchButtonPressed", Selector = "searchTemplateSearchButtonPressed:", ParameterType = new Type [] { typeof (CarPlay.CPSearchTemplate) }, ParameterByRef = new bool [] { false })]
	public partial interface ICPSearchTemplateDelegate : INativeObject, IDisposable
	{
		/// <param name="searchTemplate">To be added.</param><param name="searchText">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a change in the search text.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("searchTemplate:updatedSearchText:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdatedSearchText (CPSearchTemplate searchTemplate, string searchText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSearchTemplateDelegateUpdateHandler))]CPSearchTemplateDelegateUpdateHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchTemplate">To be added.</param><param name="searchText">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a change in the search text.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _UpdatedSearchText (ICPSearchTemplateDelegate This, CPSearchTemplate searchTemplate, string searchText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSearchTemplateDelegateUpdateHandler))]CPSearchTemplateDelegateUpdateHandler completionHandler)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			if (searchText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchText));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssearchText = CFString.CreateNative (searchText);
			using var block_completionHandler = Trampolines.SDCPSearchTemplateDelegateUpdateHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTemplate:updatedSearchText:completionHandler:"), searchTemplate__handle__, nssearchText, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTemplate);
			CFString.ReleaseNative (nssearchText);
		}
		/// <param name="searchTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a search selection.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("searchTemplate:selectedResult:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectedResult (CPSearchTemplate searchTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a search selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectedResult (ICPSearchTemplateDelegate This, CPSearchTemplate searchTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchTemplate:selectedResult:completionHandler:"), searchTemplate__handle__, item__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTemplate);
			GC.KeepAlive (item);
		}
		/// <param name="searchTemplate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchTemplateSearchButtonPressed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchButtonPressed (CPSearchTemplate searchTemplate)
		{
			_SearchButtonPressed (this, searchTemplate);
		}
		/// <param name="searchTemplate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SearchButtonPressed (ICPSearchTemplateDelegate This, CPSearchTemplate searchTemplate)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchTemplateSearchButtonPressed:"), searchTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTemplate);
		}
		[DynamicDependencyAttribute ("SearchButtonPressed(CarPlay.CPSearchTemplate)")]
		[DynamicDependencyAttribute ("SelectedResult(CarPlay.CPSearchTemplate,CarPlay.CPListItem,System.Action)")]
		[DynamicDependencyAttribute ("UpdatedSearchText(CarPlay.CPSearchTemplate,System.String,CarPlay.CPSearchTemplateDelegateUpdateHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSearchTemplateDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPSearchTemplateDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPSearchTemplateDelegate" /> interface to support all the methods from the CPSearchTemplateDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPSearchTemplateDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPSearchTemplateDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPSearchTemplateDelegate_Extensions {
		/// <param name="searchTemplate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SearchButtonPressed (this ICPSearchTemplateDelegate This, CPSearchTemplate searchTemplate)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchTemplateSearchButtonPressed:"), searchTemplate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchTemplate);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPSearchTemplateDelegateWrapper : BaseWrapper, ICPSearchTemplateDelegate {
		public CPSearchTemplateDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPSearchTemplateDelegateWrapper))]
		static CPSearchTemplateDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="searchTemplate">To be added.</param><param name="searchText">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a change in the search text.</summary><remarks>To be added.</remarks>
		[Export ("searchTemplate:updatedSearchText:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void UpdatedSearchText (CPSearchTemplate searchTemplate, string searchText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSearchTemplateDelegateUpdateHandler))]CPSearchTemplateDelegateUpdateHandler completionHandler)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			if (searchText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchText));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssearchText = CFString.CreateNative (searchText);
			using var block_completionHandler = Trampolines.SDCPSearchTemplateDelegateUpdateHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("searchTemplate:updatedSearchText:completionHandler:"), searchTemplate__handle__, nssearchText, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (searchTemplate);
			CFString.ReleaseNative (nssearchText);
		}
		/// <param name="searchTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a search selection.</summary><remarks>To be added.</remarks>
		[Export ("searchTemplate:selectedResult:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectedResult (CPSearchTemplate searchTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var searchTemplate__handle__ = searchTemplate!.GetNonNullHandle (nameof (searchTemplate));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("searchTemplate:selectedResult:completionHandler:"), searchTemplate__handle__, item__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (searchTemplate);
			GC.KeepAlive (item);
		}
	}
}
namespace CarPlay {
	/// <summary>Delegate object for the <see cref="T:CarPlay.CPSearchTemplate" /> class.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPSearchTemplateDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class CPSearchTemplateDelegate : NSObject, ICPSearchTemplateDelegate {
		/// <summary>Creates a new <see cref="CPSearchTemplateDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CPSearchTemplateDelegate () : base (NSObjectFlag.Empty)
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
		protected CPSearchTemplateDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPSearchTemplateDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="searchTemplate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("searchTemplateSearchButtonPressed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchButtonPressed (CPSearchTemplate searchTemplate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchTemplate">To be added.</param><param name="item">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a search selection.</summary><remarks>To be added.</remarks>
		[Export ("searchTemplate:selectedResult:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectedResult (CPSearchTemplate searchTemplate, CPListItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchTemplate">To be added.</param><param name="searchText">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers must override this method to respond to a change in the search text.</summary><remarks>To be added.</remarks>
		[Export ("searchTemplate:updatedSearchText:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdatedSearchText (CPSearchTemplate searchTemplate, string searchText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCPSearchTemplateDelegateUpdateHandler))]CPSearchTemplateDelegateUpdateHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPSearchTemplateDelegate */
}
