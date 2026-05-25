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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextLayoutManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSTextLayoutManagerDelegate", WrapperType = typeof (NSTextLayoutManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextLayoutFragment", Selector = "textLayoutManager:textLayoutFragmentForLocation:inTextElement:", ReturnType = typeof (NSTextLayoutFragment), ParameterType = new Type [] { typeof (NSTextLayoutManager), typeof (INSTextLocation), typeof (NSTextElement) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBreakLineBeforeLocation", Selector = "textLayoutManager:shouldBreakLineBeforeLocation:hyphenating:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextLayoutManager), typeof (INSTextLocation), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetRenderingAttributes", Selector = "textLayoutManager:renderingAttributesForLink:atLocation:defaultAttributes:", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), ParameterType = new Type [] { typeof (NSTextLayoutManager), typeof (NSObject), typeof (INSTextLocation), typeof (global::Foundation.NSDictionary<NSString, NSObject>) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSTextLayoutManagerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("textLayoutManager:textLayoutFragmentForLocation:inTextElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutFragment GetTextLayoutFragment (NSTextLayoutManager textLayoutManager, INSTextLocation location, NSTextElement textElement)
		{
			return _GetTextLayoutFragment (this, textLayoutManager, location, textElement);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextLayoutFragment _GetTextLayoutFragment (INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, INSTextLocation location, NSTextElement textElement)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textElement__handle__ = textElement!.GetNonNullHandle (nameof (textElement));
			NSTextLayoutFragment? ret;
			ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutManager:textLayoutFragmentForLocation:inTextElement:"), textLayoutManager__handle__, location__handle__, textElement__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (location);
			GC.KeepAlive (textElement);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("textLayoutManager:shouldBreakLineBeforeLocation:hyphenating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineBeforeLocation (NSTextLayoutManager textLayoutManager, INSTextLocation location, bool hyphenating)
		{
			return _ShouldBreakLineBeforeLocation (this, textLayoutManager, location, hyphenating);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBreakLineBeforeLocation (INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, INSTextLocation location, bool hyphenating)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("textLayoutManager:shouldBreakLineBeforeLocation:hyphenating:"), textLayoutManager__handle__, location__handle__, hyphenating ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (location);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textLayoutManager:renderingAttributesForLink:atLocation:defaultAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? GetRenderingAttributes (NSTextLayoutManager textLayoutManager, NSObject link, INSTextLocation location, NSDictionary<NSString, NSObject> renderingAttributes)
		{
			return _GetRenderingAttributes (this, textLayoutManager, link, location, renderingAttributes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject>? _GetRenderingAttributes (INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, NSObject link, INSTextLocation location, NSDictionary<NSString, NSObject> renderingAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var renderingAttributes__handle__ = renderingAttributes!.GetNonNullHandle (nameof (renderingAttributes));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutManager:renderingAttributesForLink:atLocation:defaultAttributes:"), textLayoutManager__handle__, link__handle__, location__handle__, renderingAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (link);
			GC.KeepAlive (location);
			GC.KeepAlive (renderingAttributes);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetRenderingAttributes(AppKit.NSTextLayoutManager,Foundation.NSObject,AppKit.INSTextLocation,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject})")]
		[DynamicDependencyAttribute ("GetTextLayoutFragment(AppKit.NSTextLayoutManager,AppKit.INSTextLocation,AppKit.NSTextElement)")]
		[DynamicDependencyAttribute ("ShouldBreakLineBeforeLocation(AppKit.NSTextLayoutManager,AppKit.INSTextLocation,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLayoutManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextLayoutManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextLayoutManagerDelegate" /> interface to support all the methods from the NSTextLayoutManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextLayoutManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextLayoutManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextLayoutManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextLayoutFragment GetTextLayoutFragment (this INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, INSTextLocation location, NSTextElement textElement)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textElement__handle__ = textElement!.GetNonNullHandle (nameof (textElement));
			NSTextLayoutFragment? ret;
			ret =  Runtime.GetNSObject<NSTextLayoutFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutManager:textLayoutFragmentForLocation:inTextElement:"), textLayoutManager__handle__, location__handle__, textElement__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (location);
			GC.KeepAlive (textElement);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBreakLineBeforeLocation (this INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, INSTextLocation location, bool hyphenating)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("textLayoutManager:shouldBreakLineBeforeLocation:hyphenating:"), textLayoutManager__handle__, location__handle__, hyphenating ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (location);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject>? GetRenderingAttributes (this INSTextLayoutManagerDelegate This, NSTextLayoutManager textLayoutManager, NSObject link, INSTextLocation location, NSDictionary<NSString, NSObject> renderingAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLayoutManager__handle__ = textLayoutManager!.GetNonNullHandle (nameof (textLayoutManager));
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var renderingAttributes__handle__ = renderingAttributes!.GetNonNullHandle (nameof (renderingAttributes));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textLayoutManager:renderingAttributesForLink:atLocation:defaultAttributes:"), textLayoutManager__handle__, link__handle__, location__handle__, renderingAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (link);
			GC.KeepAlive (location);
			GC.KeepAlive (renderingAttributes);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextLayoutManagerDelegateWrapper : BaseWrapper, INSTextLayoutManagerDelegate {
		public NSTextLayoutManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLayoutManagerDelegateWrapper))]
		static NSTextLayoutManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextLayoutManagerDelegate" /> (for the protocol <c>NSTextLayoutManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextLayoutManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTextLayoutManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextLayoutManagerDelegate : NSObject, INSTextLayoutManagerDelegate {
		/// <summary>Creates a new <see cref="NSTextLayoutManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextLayoutManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTextLayoutManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTextLayoutManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textLayoutManager:renderingAttributesForLink:atLocation:defaultAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? GetRenderingAttributes (NSTextLayoutManager textLayoutManager, NSObject link, INSTextLocation location, NSDictionary<NSString, NSObject> renderingAttributes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textLayoutManager:textLayoutFragmentForLocation:inTextElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutFragment GetTextLayoutFragment (NSTextLayoutManager textLayoutManager, INSTextLocation location, NSTextElement textElement)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textLayoutManager:shouldBreakLineBeforeLocation:hyphenating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineBeforeLocation (NSTextLayoutManager textLayoutManager, INSTextLocation location, bool hyphenating)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTextLayoutManagerDelegate */
}
