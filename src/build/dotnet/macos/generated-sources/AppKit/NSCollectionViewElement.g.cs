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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionViewElement</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCollectionViewElement", WrapperType = typeof (NSCollectionViewElementWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForReuse", Selector = "prepareForReuse")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplyLayoutAttributes", Selector = "applyLayoutAttributes:", ParameterType = new Type [] { typeof (NSCollectionViewLayoutAttributes) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTransition", Selector = "willTransitionFromLayout:toLayout:", ParameterType = new Type [] { typeof (NSCollectionViewLayout), typeof (NSCollectionViewLayout) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTransition", Selector = "didTransitionFromLayout:toLayout:", ParameterType = new Type [] { typeof (NSCollectionViewLayout), typeof (NSCollectionViewLayout) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredLayoutAttributes", Selector = "preferredLayoutAttributesFittingAttributes:", ReturnType = typeof (NSCollectionViewLayoutAttributes), ParameterType = new Type [] { typeof (NSCollectionViewLayoutAttributes) }, ParameterByRef = new bool [] { false })]
	public partial interface INSCollectionViewElement : INativeObject, IDisposable, 
		AppKit.INSUserInterfaceItemIdentification
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("prepareForReuse")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForReuse ()
		{
			_PrepareForReuse (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrepareForReuse (INSCollectionViewElement This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("prepareForReuse"));
			GC.KeepAlive (This);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applyLayoutAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyLayoutAttributes (NSCollectionViewLayoutAttributes layoutAttributes)
		{
			_ApplyLayoutAttributes (this, layoutAttributes);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ApplyLayoutAttributes (INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutAttributes__handle__ = layoutAttributes!.GetNonNullHandle (nameof (layoutAttributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applyLayoutAttributes:"), layoutAttributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutAttributes);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("willTransitionFromLayout:toLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransition (NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			_WillTransition (this, oldLayout, newLayout);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTransition (INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willTransitionFromLayout:toLayout:"), oldLayout__handle__, newLayout__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldLayout);
			GC.KeepAlive (newLayout);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didTransitionFromLayout:toLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransition (NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			_DidTransition (this, oldLayout, newLayout);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidTransition (INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didTransitionFromLayout:toLayout:"), oldLayout__handle__, newLayout__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldLayout);
			GC.KeepAlive (newLayout);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("preferredLayoutAttributesFittingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes GetPreferredLayoutAttributes (NSCollectionViewLayoutAttributes layoutAttributes)
		{
			return _GetPreferredLayoutAttributes (this, layoutAttributes);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCollectionViewLayoutAttributes _GetPreferredLayoutAttributes (INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutAttributes__handle__ = layoutAttributes!.GetNonNullHandle (nameof (layoutAttributes));
			NSCollectionViewLayoutAttributes? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredLayoutAttributesFittingAttributes:"), layoutAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (layoutAttributes);
			return ret!;
		}
		[DynamicDependencyAttribute ("ApplyLayoutAttributes(AppKit.NSCollectionViewLayoutAttributes)")]
		[DynamicDependencyAttribute ("DidTransition(AppKit.NSCollectionViewLayout,AppKit.NSCollectionViewLayout)")]
		[DynamicDependencyAttribute ("GetPreferredLayoutAttributes(AppKit.NSCollectionViewLayoutAttributes)")]
		[DynamicDependencyAttribute ("PrepareForReuse()")]
		[DynamicDependencyAttribute ("WillTransition(AppKit.NSCollectionViewLayout,AppKit.NSCollectionViewLayout)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewElementWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionViewElement ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCollectionViewElement" /> interface to support all the methods from the NSCollectionViewElement protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCollectionViewElement" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCollectionViewElement protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCollectionViewElement_Extensions {
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrepareForReuse (this INSCollectionViewElement This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("prepareForReuse"));
			GC.KeepAlive (This);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ApplyLayoutAttributes (this INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutAttributes__handle__ = layoutAttributes!.GetNonNullHandle (nameof (layoutAttributes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applyLayoutAttributes:"), layoutAttributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (layoutAttributes);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTransition (this INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willTransitionFromLayout:toLayout:"), oldLayout__handle__, newLayout__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldLayout);
			GC.KeepAlive (newLayout);
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidTransition (this INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didTransitionFromLayout:toLayout:"), oldLayout__handle__, newLayout__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (oldLayout);
			GC.KeepAlive (newLayout);
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionViewLayoutAttributes GetPreferredLayoutAttributes (this INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutAttributes__handle__ = layoutAttributes!.GetNonNullHandle (nameof (layoutAttributes));
			NSCollectionViewLayoutAttributes? ret;
			ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredLayoutAttributesFittingAttributes:"), layoutAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (layoutAttributes);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionViewElementWrapper : BaseWrapper, INSCollectionViewElement {
		public NSCollectionViewElementWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewElementWrapper))]
		static NSCollectionViewElementWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				return ret;
			}
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCollectionViewElement" /> (for the protocol <c>NSCollectionViewElement</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCollectionViewElement" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCollectionViewElement", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionViewElement : NSObject, INSCollectionViewElement, INSUserInterfaceItemIdentification {
		/// <summary>Creates a new <see cref="NSCollectionViewElement" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCollectionViewElement () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSCollectionViewElement (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewElement (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("applyLayoutAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyLayoutAttributes (NSCollectionViewLayoutAttributes layoutAttributes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didTransitionFromLayout:toLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidTransition (NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="layoutAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("preferredLayoutAttributesFittingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes GetPreferredLayoutAttributes (NSCollectionViewLayoutAttributes layoutAttributes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("prepareForReuse")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForReuse ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="oldLayout">To be added.</param><param name="newLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("willTransitionFromLayout:toLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransition (NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSCollectionViewElement */
}
