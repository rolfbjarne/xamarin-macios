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
	/// <summary>This interface represents the Objective-C protocol <c>UIPageControlProgressDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UIPageControlProgressDelegate", WrapperType = typeof (UIPageControlProgressDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInitialProgressForPage", Selector = "pageControlProgress:initialProgressForPage:", ReturnType = typeof (float), ParameterType = new Type [] { typeof (UIPageControlProgress), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "VisibilityDidChange", Selector = "pageControlProgressVisibilityDidChange:", ParameterType = new Type [] { typeof (UIPageControlProgress) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIPageControlProgressDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("pageControlProgress:initialProgressForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetInitialProgressForPage (UIPageControlProgress progress, nint page)
		{
			return _GetInitialProgressForPage (this, progress, page);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInitialProgressForPage (IUIPageControlProgressDelegate This, UIPageControlProgress progress, nint page)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pageControlProgress:initialProgressForPage:"), progress__handle__, page);
			GC.KeepAlive (This);
			GC.KeepAlive (progress);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("pageControlProgressVisibilityDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void VisibilityDidChange (UIPageControlProgress progress)
		{
			_VisibilityDidChange (this, progress);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _VisibilityDidChange (IUIPageControlProgressDelegate This, UIPageControlProgress progress)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControlProgressVisibilityDidChange:"), progress__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (progress);
		}
		[DynamicDependencyAttribute ("GetInitialProgressForPage(UIKit.UIPageControlProgress,System.IntPtr)")]
		[DynamicDependencyAttribute ("VisibilityDidChange(UIKit.UIPageControlProgress)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageControlProgressDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPageControlProgressDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPageControlProgressDelegate" /> interface to support all the methods from the UIPageControlProgressDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPageControlProgressDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPageControlProgressDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPageControlProgressDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetInitialProgressForPage (this IUIPageControlProgressDelegate This, UIPageControlProgress progress, nint page)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pageControlProgress:initialProgressForPage:"), progress__handle__, page);
			GC.KeepAlive (This);
			GC.KeepAlive (progress);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void VisibilityDidChange (this IUIPageControlProgressDelegate This, UIPageControlProgress progress)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageControlProgressVisibilityDidChange:"), progress__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (progress);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPageControlProgressDelegateWrapper : BaseWrapper, IUIPageControlProgressDelegate {
		public UIPageControlProgressDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageControlProgressDelegateWrapper))]
		static UIPageControlProgressDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPageControlProgressDelegate" /> (for the protocol <c>UIPageControlProgressDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPageControlProgressDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIPageControlProgressDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class UIPageControlProgressDelegate : NSObject, IUIPageControlProgressDelegate {
		/// <summary>Creates a new <see cref="UIPageControlProgressDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPageControlProgressDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPageControlProgressDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPageControlProgressDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("pageControlProgress:initialProgressForPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetInitialProgressForPage (UIPageControlProgress progress, nint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("pageControlProgressVisibilityDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void VisibilityDidChange (UIPageControlProgress progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPageControlProgressDelegate */
}
