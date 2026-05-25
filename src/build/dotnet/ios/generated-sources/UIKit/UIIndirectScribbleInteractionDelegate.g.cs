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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIIndirectScribbleInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIIndirectScribbleInteractionDelegate", WrapperType = typeof (UIIndirectScribbleInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestElements", Selector = "indirectScribbleInteraction:requestElementsInRect:completion:", ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (CGRect), typeof (global::System.Action<NSObject[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V269) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsElementFocused", Selector = "indirectScribbleInteraction:isElementFocused:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFrameForElement", Selector = "indirectScribbleInteraction:frameForElement:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FocusElementIfNeeded", Selector = "indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:", ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject), typeof (CGPoint), typeof (global::System.Action<global::UIKit.IUITextInput>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V270) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDelayFocus", Selector = "indirectScribbleInteraction:shouldDelayFocusForElement:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginWriting", Selector = "indirectScribbleInteraction:willBeginWritingInElement:", ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishWriting", Selector = "indirectScribbleInteraction:didFinishWritingInElement:", ParameterType = new Type [] { typeof (UIIndirectScribbleInteraction), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIIndirectScribbleInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("indirectScribbleInteraction:requestElementsInRect:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestElements (UIIndirectScribbleInteraction interaction, CGRect rect, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<NSObject[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestElements (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, CGRect rect, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<NSObject[]> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V269.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:requestElementsInRect:completion:"), interaction__handle__, rect, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.RequiredMember]
		[Export ("indirectScribbleInteraction:isElementFocused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsElementFocused (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsElementFocused (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:isElementFocused:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("indirectScribbleInteraction:frameForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForElement (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrameForElement (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:frameForElement:"), interaction__handle__, elementIdentifier__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:frameForElement:"), interaction__handle__, elementIdentifier__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FocusElementIfNeeded (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier, CGPoint focusReferencePoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<IUITextInput> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FocusElementIfNeeded (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier, CGPoint focusReferencePoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<IUITextInput> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V270.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:"), interaction__handle__, elementIdentifier__handle__, focusReferencePoint, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
		[global::Foundation.OptionalMember]
		[Export ("indirectScribbleInteraction:shouldDelayFocusForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDelayFocus (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			return _ShouldDelayFocus (this, interaction, elementIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDelayFocus (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:shouldDelayFocusForElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("indirectScribbleInteraction:willBeginWritingInElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginWriting (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			_WillBeginWriting (this, interaction, elementIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginWriting (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:willBeginWritingInElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
		[global::Foundation.OptionalMember]
		[Export ("indirectScribbleInteraction:didFinishWritingInElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishWriting (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			_DidFinishWriting (this, interaction, elementIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishWriting (IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:didFinishWritingInElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
		[DynamicDependencyAttribute ("DidFinishWriting(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("FocusElementIfNeeded(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject,CoreGraphics.CGPoint,System.Action{UIKit.IUITextInput})")]
		[DynamicDependencyAttribute ("GetFrameForElement(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("IsElementFocused(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("RequestElements(UIKit.UIIndirectScribbleInteraction,CoreGraphics.CGRect,System.Action{Foundation.NSObject[]})")]
		[DynamicDependencyAttribute ("ShouldDelayFocus(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("WillBeginWriting(UIKit.UIIndirectScribbleInteraction,Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIIndirectScribbleInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIIndirectScribbleInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIIndirectScribbleInteractionDelegate" /> interface to support all the methods from the UIIndirectScribbleInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIIndirectScribbleInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIIndirectScribbleInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIIndirectScribbleInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDelayFocus (this IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:shouldDelayFocusForElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginWriting (this IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:willBeginWritingInElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishWriting (this IUIIndirectScribbleInteractionDelegate This, UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indirectScribbleInteraction:didFinishWritingInElement:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIIndirectScribbleInteractionDelegateWrapper : BaseWrapper, IUIIndirectScribbleInteractionDelegate {
		public UIIndirectScribbleInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIIndirectScribbleInteractionDelegateWrapper))]
		static UIIndirectScribbleInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("indirectScribbleInteraction:requestElementsInRect:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestElements (UIIndirectScribbleInteraction interaction, CGRect rect, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<NSObject[]> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V269.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("indirectScribbleInteraction:requestElementsInRect:completion:"), interaction__handle__, rect, (IntPtr) block_ptr_completion);
			GC.KeepAlive (interaction);
		}
		[Export ("indirectScribbleInteraction:isElementFocused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsElementFocused (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("indirectScribbleInteraction:isElementFocused:"), interaction__handle__, elementIdentifier__handle__);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret != 0;
		}
		[Export ("indirectScribbleInteraction:frameForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetFrameForElement (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("indirectScribbleInteraction:frameForElement:"), interaction__handle__, elementIdentifier__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("indirectScribbleInteraction:frameForElement:"), interaction__handle__, elementIdentifier__handle__);
			}
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
			return ret!;
		}
		[Export ("indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FocusElementIfNeeded (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier, CGPoint focusReferencePoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<IUITextInput> completion)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			var elementIdentifier__handle__ = elementIdentifier!.GetNonNullHandle (nameof (elementIdentifier));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V270.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:"), interaction__handle__, elementIdentifier__handle__, focusReferencePoint, (IntPtr) block_ptr_completion);
			GC.KeepAlive (interaction);
			GC.KeepAlive (elementIdentifier);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIIndirectScribbleInteractionDelegate" /> (for the protocol <c>UIIndirectScribbleInteractionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIIndirectScribbleInteractionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIIndirectScribbleInteractionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class UIIndirectScribbleInteractionDelegate : NSObject, IUIIndirectScribbleInteractionDelegate {
		/// <summary>Creates a new <see cref="UIIndirectScribbleInteractionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIIndirectScribbleInteractionDelegate () : base (NSObjectFlag.Empty)
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
		protected UIIndirectScribbleInteractionDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIIndirectScribbleInteractionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("indirectScribbleInteraction:didFinishWritingInElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishWriting (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:focusElementIfNeeded:referencePoint:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FocusElementIfNeeded (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier, CGPoint focusReferencePoint, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V270))]global::System.Action<IUITextInput> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:frameForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForElement (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:isElementFocused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsElementFocused (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:requestElementsInRect:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestElements (UIIndirectScribbleInteraction interaction, CGRect rect, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V269))]global::System.Action<NSObject[]> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:shouldDelayFocusForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDelayFocus (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("indirectScribbleInteraction:willBeginWritingInElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginWriting (UIIndirectScribbleInteraction interaction, NSObject elementIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIIndirectScribbleInteractionDelegate */
}
