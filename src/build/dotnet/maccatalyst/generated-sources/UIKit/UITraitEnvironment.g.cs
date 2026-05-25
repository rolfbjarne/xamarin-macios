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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITraitEnvironment</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITraitEnvironment", WrapperType = typeof (UITraitEnvironmentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TraitCollectionDidChange", Selector = "traitCollectionDidChange:", ParameterType = new Type [] { typeof (UITraitCollection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TraitCollection", Selector = "traitCollection", PropertyType = typeof (UITraitCollection), GetterSelector = "traitCollection", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITraitEnvironment : INativeObject, IDisposable
	{
		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[global::Foundation.RequiredMember]
		[Export ("traitCollectionDidChange:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TraitCollectionDidChange (UITraitCollection? previousTraitCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[ObsoletedOSPlatform ("ios17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TraitCollectionDidChange (IUITraitEnvironment This, UITraitCollection? previousTraitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previousTraitCollection__handle__ = previousTraitCollection.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (previousTraitCollection);
		}
		[DynamicDependencyAttribute ("TraitCollection")]
		[DynamicDependencyAttribute ("TraitCollectionDidChange(UIKit.UITraitCollection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitEnvironmentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITraitEnvironment ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the trait collection that describes the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			get {
				return _GetTraitCollection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitCollection _GetTraitCollection (IUITraitEnvironment This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("traitCollection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITraitEnvironmentWrapper : BaseWrapper, IUITraitEnvironment {
		public UITraitEnvironmentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitEnvironmentWrapper))]
		static UITraitEnvironmentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[Export ("traitCollectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TraitCollectionDidChange (UITraitCollection? previousTraitCollection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previousTraitCollection__handle__ = previousTraitCollection.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionDidChange:"), previousTraitCollection__handle__);
			GC.KeepAlive (previousTraitCollection);
		}
		/// <summary>Gets the trait collection that describes the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection ret;
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitCollection")), false)!;
				return ret;
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITraitEnvironment" /> (for the protocol <c>UITraitEnvironment</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITraitEnvironment" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UITraitEnvironment", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UITraitEnvironment : NSObject, IUITraitEnvironment {
		/// <summary>Creates a new <see cref="UITraitEnvironment" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITraitEnvironment () : base (NSObjectFlag.Empty)
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
		protected UITraitEnvironment (NSObjectFlag t) : base (t)
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
		protected internal UITraitEnvironment (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="previousTraitCollection">To be added.</param><summary>The trait collection that describes the environmnent changed.</summary><remarks><para></para></remarks>
		[Export ("traitCollectionDidChange:")]
		[ObsoletedOSPlatform ("ios17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use the 'UITraitChangeObservable' protocol instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TraitCollectionDidChange (UITraitCollection? previousTraitCollection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the trait collection that describes the environment.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UITraitEnvironment */
}
