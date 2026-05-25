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
	/// <summary>A frame of reference on the screen.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UICoordinateSpace_protocol/index.html">Apple documentation for <c>UICoordinateSpace</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICoordinateSpace", WrapperType = typeof (UICoordinateSpaceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertPointToCoordinateSpace", Selector = "convertPoint:toCoordinateSpace:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint), typeof (IUICoordinateSpace) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertPointFromCoordinateSpace", Selector = "convertPoint:fromCoordinateSpace:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint), typeof (IUICoordinateSpace) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertRectToCoordinateSpace", Selector = "convertRect:toCoordinateSpace:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect), typeof (IUICoordinateSpace) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConvertRectFromCoordinateSpace", Selector = "convertRect:fromCoordinateSpace:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (CGRect), typeof (IUICoordinateSpace) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Bounds", Selector = "bounds", PropertyType = typeof (CGRect), GetterSelector = "bounds", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUICoordinateSpace : INativeObject, IDisposable
	{
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("convertPoint:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _ConvertPointToCoordinateSpace (IUICoordinateSpace This, CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("convertPoint:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _ConvertPointFromCoordinateSpace (IUICoordinateSpace This, CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("convertRect:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _ConvertRectToCoordinateSpace (IUICoordinateSpace This, CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("convertRect:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _ConvertRectFromCoordinateSpace (IUICoordinateSpace This, CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		[DynamicDependencyAttribute ("Bounds")]
		[DynamicDependencyAttribute ("ConvertPointFromCoordinateSpace(CoreGraphics.CGPoint,UIKit.IUICoordinateSpace)")]
		[DynamicDependencyAttribute ("ConvertPointToCoordinateSpace(CoreGraphics.CGPoint,UIKit.IUICoordinateSpace)")]
		[DynamicDependencyAttribute ("ConvertRectFromCoordinateSpace(CoreGraphics.CGRect,UIKit.IUICoordinateSpace)")]
		[DynamicDependencyAttribute ("ConvertRectToCoordinateSpace(CoreGraphics.CGRect,UIKit.IUICoordinateSpace)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICoordinateSpaceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICoordinateSpace ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				return _GetBounds (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetBounds (IUICoordinateSpace This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("bounds"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICoordinateSpaceWrapper : BaseWrapper, IUICoordinateSpace {
		public UICoordinateSpaceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICoordinateSpaceWrapper))]
		static UICoordinateSpaceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:fromCoordinateSpace:"), point, coordinateSpace__handle__);
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var coordinateSpace__handle__ = coordinateSpace!.GetNonNullHandle (nameof (coordinateSpace));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:fromCoordinateSpace:"), rect, coordinateSpace__handle__);
			}
			GC.KeepAlive (coordinateSpace);
			return ret!;
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect Bounds {
			[Export ("bounds")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("bounds"));
				}
				return ret!;
			}
		}
	}
}
namespace UIKit {
	/// <summary>A frame of reference on the screen.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UICoordinateSpace_protocol/index.html">Apple documentation for <c>UICoordinateSpace</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UICoordinateSpace", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UICoordinateSpace : NSObject, IUICoordinateSpace {
		/// <summary>Creates a new <see cref="UICoordinateSpace" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UICoordinateSpace () : base (NSObjectFlag.Empty)
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
		protected UICoordinateSpace (NSObjectFlag t) : base (t)
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
		protected internal UICoordinateSpace (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToCoordinateSpace (CGPoint point, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="rect">To be added.</param><param name="coordinateSpace">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toCoordinateSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToCoordinateSpace (CGRect rect, IUICoordinateSpace coordinateSpace)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the bounding rectangle of the object in its own coordinate space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UICoordinateSpace */
}
