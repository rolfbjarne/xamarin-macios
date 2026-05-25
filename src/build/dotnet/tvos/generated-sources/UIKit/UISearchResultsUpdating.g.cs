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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Protocol for updating the search results based on the contents of the search bar.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UISearchResultsUpdating_ClassRef/index.html">Apple documentation for <c>UISearchResultsUpdating</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UISearchResultsUpdating", WrapperType = typeof (UISearchResultsUpdatingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateSearchResultsForSearchController", Selector = "updateSearchResultsForSearchController:", ParameterType = new Type [] { typeof (UISearchController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateSearchResults", Selector = "updateSearchResultsForSearchController:selectingSearchSuggestion:", ParameterType = new Type [] { typeof (UISearchController), typeof (IUISearchSuggestion) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISearchResultsUpdating : INativeObject, IDisposable
	{
		/// <param name="searchController">To be added.</param><summary>Updates the results when the user makes changes or when the search bar becomes the first responder.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("updateSearchResultsForSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSearchResultsForSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>Updates the results when the user makes changes or when the search bar becomes the first responder.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateSearchResultsForSearchController (IUISearchResultsUpdating This, UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateSearchResultsForSearchController:"), searchController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
		}
		[global::Foundation.OptionalMember]
		[Export ("updateSearchResultsForSearchController:selectingSearchSuggestion:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSearchResults (UISearchController searchController, IUISearchSuggestion searchSuggestion)
		{
			_UpdateSearchResults (this, searchController, searchSuggestion);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateSearchResults (IUISearchResultsUpdating This, UISearchController searchController, IUISearchSuggestion searchSuggestion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			var searchSuggestion__handle__ = searchSuggestion!.GetNonNullHandle (nameof (searchSuggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateSearchResultsForSearchController:selectingSearchSuggestion:"), searchController__handle__, searchSuggestion__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
			GC.KeepAlive (searchSuggestion);
		}
		[DynamicDependencyAttribute ("UpdateSearchResults(UIKit.UISearchController,UIKit.IUISearchSuggestion)")]
		[DynamicDependencyAttribute ("UpdateSearchResultsForSearchController(UIKit.UISearchController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchResultsUpdatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchResultsUpdating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchResultsUpdating" /> interface to support all the methods from the UISearchResultsUpdating protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchResultsUpdating" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchResultsUpdating protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchResultsUpdating_Extensions {
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateSearchResults (this IUISearchResultsUpdating This, UISearchController searchController, IUISearchSuggestion searchSuggestion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			var searchSuggestion__handle__ = searchSuggestion!.GetNonNullHandle (nameof (searchSuggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("updateSearchResultsForSearchController:selectingSearchSuggestion:"), searchController__handle__, searchSuggestion__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchController);
			GC.KeepAlive (searchSuggestion);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchResultsUpdatingWrapper : BaseWrapper, IUISearchResultsUpdating {
		public UISearchResultsUpdatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchResultsUpdatingWrapper))]
		static UISearchResultsUpdatingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="searchController">To be added.</param><summary>Updates the results when the user makes changes or when the search bar becomes the first responder.</summary><remarks>To be added.</remarks>
		[Export ("updateSearchResultsForSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateSearchResultsForSearchController (UISearchController searchController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchController__handle__ = searchController!.GetNonNullHandle (nameof (searchController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateSearchResultsForSearchController:"), searchController__handle__);
			GC.KeepAlive (searchController);
		}
	}
}
namespace UIKit {
	/// <summary>Protocol for updating the search results based on the contents of the search bar.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UISearchResultsUpdating_ClassRef/index.html">Apple documentation for <c>UISearchResultsUpdating</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UISearchResultsUpdating", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UISearchResultsUpdating : NSObject, IUISearchResultsUpdating {
		/// <summary>Creates a new <see cref="UISearchResultsUpdating" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UISearchResultsUpdating () : base (NSObjectFlag.Empty)
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
		protected UISearchResultsUpdating (NSObjectFlag t) : base (t)
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
		protected internal UISearchResultsUpdating (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("updateSearchResultsForSearchController:selectingSearchSuggestion:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSearchResults (UISearchController searchController, IUISearchSuggestion searchSuggestion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchController">To be added.</param><summary>Updates the results when the user makes changes or when the search bar becomes the first responder.</summary><remarks>To be added.</remarks>
		[Export ("updateSearchResultsForSearchController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateSearchResultsForSearchController (UISearchController searchController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISearchResultsUpdating */
}
