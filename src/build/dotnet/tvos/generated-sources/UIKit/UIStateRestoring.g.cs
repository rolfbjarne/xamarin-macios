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
	/// <summary>This interface represents the Objective-C protocol <c>UIStateRestoring</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIStateRestoring", WrapperType = typeof (UIStateRestoringWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncodeRestorableState", Selector = "encodeRestorableStateWithCoder:", ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodeRestorableState", Selector = "decodeRestorableStateWithCoder:", ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationFinishedRestoringState", Selector = "applicationFinishedRestoringState")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RestorationParent", Selector = "restorationParent", PropertyType = typeof (IUIStateRestoring), GetterSelector = "restorationParent", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ObjectRestorationClass", Selector = "objectRestorationClass", PropertyType = typeof (Class), GetterSelector = "objectRestorationClass", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIStateRestoring : INativeObject, IDisposable
	{
		/// <param name="coder">To be added.</param><summary>Encodes state-related information.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("encodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			_EncodeRestorableState (this, coder);
		}
		/// <param name="coder">To be added.</param><summary>Encodes state-related information.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EncodeRestorableState (IUIStateRestoring This, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
		}
		/// <param name="coder">To be added.</param><summary>Decodes and restores state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("decodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodeRestorableState (NSCoder coder)
		{
			_DecodeRestorableState (this, coder);
		}
		/// <param name="coder">To be added.</param><summary>Decodes and restores state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DecodeRestorableState (IUIStateRestoring This, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
		}
		/// <summary>Indicates that the application has finished restoring state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationFinishedRestoringState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationFinishedRestoringState ()
		{
			_ApplicationFinishedRestoringState (this);
		}
		/// <summary>Indicates that the application has finished restoring state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ApplicationFinishedRestoringState (IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("applicationFinishedRestoringState"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("ApplicationFinishedRestoringState()")]
		[DynamicDependencyAttribute ("DecodeRestorableState(Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("EncodeRestorableState(Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("ObjectRestorationClass")]
		[DynamicDependencyAttribute ("RestorationParent")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIStateRestoringWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIStateRestoring ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the parent of the object to restore.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual IUIStateRestoring RestorationParent {
			[Export ("restorationParent")]
			get {
				return _GetRestorationParent (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIStateRestoring _GetRestorationParent (IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIStateRestoring ret;
			ret =  Runtime.GetINativeObject<IUIStateRestoring> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("restorationParent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the class that recreates the restored object.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual Class? ObjectRestorationClass {
			[Export ("objectRestorationClass")]
			get {
				return _GetObjectRestorationClass (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static Class _GetObjectRestorationClass (IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			Class ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("objectRestorationClass")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIStateRestoring" /> interface to support all the methods from the UIStateRestoring protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIStateRestoring" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIStateRestoring protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIStateRestoring_Extensions {
		/// <param name="coder">To be added.</param><summary>Encodes state-related information.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EncodeRestorableState (this IUIStateRestoring This, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("encodeRestorableStateWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
		}
		/// <param name="coder">To be added.</param><summary>Decodes and restores state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DecodeRestorableState (this IUIStateRestoring This, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodeRestorableStateWithCoder:"), coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coder);
		}
		/// <summary>Indicates that the application has finished restoring state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ApplicationFinishedRestoringState (this IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("applicationFinishedRestoringState"));
			GC.KeepAlive (This);
		}
		/// <summary>Gets the parent of the object to restore.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIStateRestoring GetRestorationParent (this IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIStateRestoring ret;
			ret =  Runtime.GetINativeObject<IUIStateRestoring> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("restorationParent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the class that recreates the restored object.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class GetObjectRestorationClass (this IUIStateRestoring This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			Class ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("objectRestorationClass")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIStateRestoringWrapper : BaseWrapper, IUIStateRestoring {
		public UIStateRestoringWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIStateRestoringWrapper))]
		static UIStateRestoringWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIStateRestoring" /> (for the protocol <c>UIStateRestoring</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIStateRestoring" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIStateRestoring", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIStateRestoring : NSObject, IUIStateRestoring {
		/// <summary>Creates a new <see cref="UIStateRestoring" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIStateRestoring () : base (NSObjectFlag.Empty)
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
		protected UIStateRestoring (NSObjectFlag t) : base (t)
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
		protected internal UIStateRestoring (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Indicates that the application has finished restoring state.</summary><remarks>To be added.</remarks>
		[Export ("applicationFinishedRestoringState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationFinishedRestoringState ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="coder">To be added.</param><summary>Decodes and restores state.</summary><remarks>To be added.</remarks>
		[Export ("decodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecodeRestorableState (NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="coder">To be added.</param><summary>Encodes state-related information.</summary><remarks>To be added.</remarks>
		[Export ("encodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the class that recreates the restored object.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class? ObjectRestorationClass {
			[Export ("objectRestorationClass")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets the parent of the object to restore.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIStateRestoring RestorationParent {
			[Export ("restorationParent")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIStateRestoring */
}
