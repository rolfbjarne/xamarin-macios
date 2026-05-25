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
namespace NotificationCenter {
	#pragma warning disable CS1573
	/// <summary>Customizes the appearance and behavior of a widget.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NotificationCenter/Reference/NCWidgetProviding_Protocol/index.html">Apple documentation for <c>NCWidgetProviding</c></related>
	[ObsoletedOSPlatform ("ios14.0")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NCWidgetProviding", WrapperType = typeof (NCWidgetProvidingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetPerformUpdate", Selector = "widgetPerformUpdateWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<global::NotificationCenter.NCUpdateResult>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V88) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWidgetMarginInsets", Selector = "widgetMarginInsetsForProposedMarginInsets:", ReturnType = typeof (NSEdgeInsets), ParameterType = new Type [] { typeof (NSEdgeInsets) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetDidBeginEditing", Selector = "widgetDidBeginEditing")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetDidEndEditing", Selector = "widgetDidEndEditing")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WidgetAllowsEditing", Selector = "widgetAllowsEditing", PropertyType = typeof (bool), GetterSelector = "widgetAllowsEditing", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INCWidgetProviding : INativeObject, IDisposable
	{
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetPerformUpdateWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WidgetPerformUpdate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<NCUpdateResult> completionHandler)
		{
			_WidgetPerformUpdate (this, completionHandler);
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WidgetPerformUpdate (INCWidgetProviding This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<NCUpdateResult> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V88.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("widgetPerformUpdateWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="defaultMarginInsets">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetMarginInsetsForProposedMarginInsets:")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSEdgeInsets GetWidgetMarginInsets (global::AppKit.NSEdgeInsets defaultMarginInsets)
		{
			return _GetWidgetMarginInsets (this, defaultMarginInsets);
		}
		/// <param name="defaultMarginInsets">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSEdgeInsets _GetWidgetMarginInsets (INCWidgetProviding This, global::AppKit.NSEdgeInsets defaultMarginInsets)
		{
			global::AppKit.NSEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_NSEdgeInsets (This.Handle, Selector.GetHandle ("widgetMarginInsetsForProposedMarginInsets:"), defaultMarginInsets);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret_NSEdgeInsets (This.Handle, Selector.GetHandle ("widgetMarginInsetsForProposedMarginInsets:"), defaultMarginInsets);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetDidBeginEditing")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WidgetDidBeginEditing ()
		{
			_WidgetDidBeginEditing (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WidgetDidBeginEditing (INCWidgetProviding This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("widgetDidBeginEditing"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("widgetDidEndEditing")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WidgetDidEndEditing ()
		{
			_WidgetDidEndEditing (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WidgetDidEndEditing (INCWidgetProviding This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("widgetDidEndEditing"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetWidgetMarginInsets(AppKit.NSEdgeInsets)")]
		[DynamicDependencyAttribute ("WidgetAllowsEditing")]
		[DynamicDependencyAttribute ("WidgetDidBeginEditing()")]
		[DynamicDependencyAttribute ("WidgetDidEndEditing()")]
		[DynamicDependencyAttribute ("WidgetPerformUpdate(System.Action{NotificationCenter.NCUpdateResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NCWidgetProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INCWidgetProviding ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual bool WidgetAllowsEditing {
			[Export ("widgetAllowsEditing")]
			get {
				return _GetWidgetAllowsEditing (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetWidgetAllowsEditing (INCWidgetProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("widgetAllowsEditing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INCWidgetProviding" /> interface to support all the methods from the NCWidgetProviding protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INCWidgetProviding" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NCWidgetProviding protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NCWidgetProviding_Extensions {
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WidgetPerformUpdate (this INCWidgetProviding This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<NCUpdateResult> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V88.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("widgetPerformUpdateWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		/// <param name="defaultMarginInsets">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSEdgeInsets GetWidgetMarginInsets (this INCWidgetProviding This, global::AppKit.NSEdgeInsets defaultMarginInsets)
		{
			global::AppKit.NSEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_NSEdgeInsets (This.Handle, Selector.GetHandle ("widgetMarginInsetsForProposedMarginInsets:"), defaultMarginInsets);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret_NSEdgeInsets (This.Handle, Selector.GetHandle ("widgetMarginInsetsForProposedMarginInsets:"), defaultMarginInsets);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WidgetDidBeginEditing (this INCWidgetProviding This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("widgetDidBeginEditing"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WidgetDidEndEditing (this INCWidgetProviding This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("widgetDidEndEditing"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetWidgetAllowsEditing (this INCWidgetProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("widgetAllowsEditing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NCWidgetProvidingWrapper : BaseWrapper, INCWidgetProviding {
		public NCWidgetProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NCWidgetProvidingWrapper))]
		static NCWidgetProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace NotificationCenter {
	/// <summary>Customizes the appearance and behavior of a widget.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NotificationCenter/Reference/NCWidgetProviding_Protocol/index.html">Apple documentation for <c>NCWidgetProviding</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__NotificationCenter_NCWidgetProviding", false)]
	[Model]
	[ObsoletedOSPlatform ("ios14.0")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NCWidgetProviding : NSObject, INCWidgetProviding {
		/// <summary>Creates a new <see cref="NCWidgetProviding" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NCWidgetProviding () : base (NSObjectFlag.Empty)
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
		protected NCWidgetProviding (NSObjectFlag t) : base (t)
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
		protected internal NCWidgetProviding (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="defaultMarginInsets">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("widgetMarginInsetsForProposedMarginInsets:")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSEdgeInsets GetWidgetMarginInsets (global::AppKit.NSEdgeInsets defaultMarginInsets)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetDidBeginEditing")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WidgetDidBeginEditing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetDidEndEditing")]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WidgetDidEndEditing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("widgetPerformUpdateWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WidgetPerformUpdate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<NCUpdateResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		public virtual bool WidgetAllowsEditing {
			[Export ("widgetAllowsEditing")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NCWidgetProviding */
}
