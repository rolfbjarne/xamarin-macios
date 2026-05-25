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
	/// <summary>Provides the <see cref="P:UIKit.UILayoutSupport.Length" /> property, which specifies the distance, in points, from the nearest screen edge to the guide.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UILayoutSupport_Protocol/index.html">Apple documentation for <c>UILayoutSupport</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UILayoutSupport", WrapperType = typeof (UILayoutSupportWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Length", Selector = "length", PropertyType = typeof (NFloat), GetterSelector = "length", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TopAnchor", Selector = "topAnchor", PropertyType = typeof (NSLayoutYAxisAnchor), GetterSelector = "topAnchor", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BottomAnchor", Selector = "bottomAnchor", PropertyType = typeof (NSLayoutYAxisAnchor), GetterSelector = "bottomAnchor", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HeightAnchor", Selector = "heightAnchor", PropertyType = typeof (NSLayoutDimension), GetterSelector = "heightAnchor", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUILayoutSupport : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("BottomAnchor")]
		[DynamicDependencyAttribute ("HeightAnchor")]
		[DynamicDependencyAttribute ("Length")]
		[DynamicDependencyAttribute ("TopAnchor")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILayoutSupportWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUILayoutSupport ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the length of the part of a view controller's area that is covered with see-through UIKit bars.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat Length {
			[Export ("length")]
			get {
				return _GetLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetLength (IUILayoutSupport This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("length"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the top edge of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual NSLayoutYAxisAnchor TopAnchor {
			[Export ("topAnchor", ArgumentSemantic.Retain)]
			get {
				return _GetTopAnchor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSLayoutYAxisAnchor _GetTopAnchor (IUILayoutSupport This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSLayoutYAxisAnchor ret;
			ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("topAnchor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the bottom edge of the guide</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual NSLayoutYAxisAnchor BottomAnchor {
			[Export ("bottomAnchor", ArgumentSemantic.Retain)]
			get {
				return _GetBottomAnchor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSLayoutYAxisAnchor _GetBottomAnchor (IUILayoutSupport This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSLayoutYAxisAnchor ret;
			ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("bottomAnchor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the height of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual NSLayoutDimension HeightAnchor {
			[Export ("heightAnchor", ArgumentSemantic.Retain)]
			get {
				return _GetHeightAnchor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSLayoutDimension _GetHeightAnchor (IUILayoutSupport This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSLayoutDimension ret;
			ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("heightAnchor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UILayoutSupportWrapper : BaseWrapper, IUILayoutSupport {
		public UILayoutSupportWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UILayoutSupportWrapper))]
		static UILayoutSupportWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the length of the part of a view controller's area that is covered with see-through UIKit bars.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat Length {
			[Export ("length")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("length"));
				return ret;
			}
		}
		/// <summary>Returns the top edge of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public NSLayoutYAxisAnchor TopAnchor {
			[Export ("topAnchor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor ret;
				ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topAnchor")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the bottom edge of the guide</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public NSLayoutYAxisAnchor BottomAnchor {
			[Export ("bottomAnchor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutYAxisAnchor ret;
				ret =  Runtime.GetNSObject<NSLayoutYAxisAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bottomAnchor")), false)!;
				return ret;
			}
		}
		/// <summary>Returns the height of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public NSLayoutDimension HeightAnchor {
			[Export ("heightAnchor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutDimension ret;
				ret =  Runtime.GetNSObject<NSLayoutDimension> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heightAnchor")), false)!;
				return ret;
			}
		}
	}
}
namespace UIKit {
	/// <summary>Provides the <see cref="P:UIKit.UILayoutSupport.Length" /> property, which specifies the distance, in points, from the nearest screen edge to the guide.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UILayoutSupport_Protocol/index.html">Apple documentation for <c>UILayoutSupport</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UILayoutSupport", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UILayoutSupport : NSObject, IUILayoutSupport {
		/// <summary>Creates a new <see cref="UILayoutSupport" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UILayoutSupport () : base (NSObjectFlag.Empty)
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
		protected UILayoutSupport (NSObjectFlag t) : base (t)
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
		protected internal UILayoutSupport (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Returns the bottom edge of the guide</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor BottomAnchor {
			[Export ("bottomAnchor", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns the height of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutDimension HeightAnchor {
			[Export ("heightAnchor", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets the length of the part of a view controller's area that is covered with see-through UIKit bars.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Length {
			[Export ("length")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns the top edge of the guide.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSLayoutYAxisAnchor TopAnchor {
			[Export ("topAnchor", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UILayoutSupport */
}
