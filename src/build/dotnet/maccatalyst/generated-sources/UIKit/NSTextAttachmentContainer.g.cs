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
	/// <summary>Defines the relationship between <see cref="T:UIKit.NSTextAttachment" />s and a <see cref="T:UIKit.NSLayoutManager" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/NSTextAttachmentContainer_Protocol/index.html">Apple documentation for <c>NSTextAttachmentContainer</c></related>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSTextAttachmentContainer", WrapperType = typeof (NSTextAttachmentContainerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImageForBounds", Selector = "imageForBounds:textContainer:characterIndex:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (CGRect), typeof (NSTextContainer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttachmentBounds", Selector = "attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSTextContainer), typeof (CGRect), typeof (CGPoint), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSTextAttachmentContainer : INativeObject, IDisposable
	{
		/// <param name="bounds">To be added.</param><param name="textContainer">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns an image rendered in <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("imageForBounds:textContainer:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? GetImageForBounds (CGRect bounds, NSTextContainer? textContainer, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="bounds">To be added.</param><param name="textContainer">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns an image rendered in <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage? _GetImageForBounds (INSTextAttachmentContainer This, CGRect bounds, NSTextContainer? textContainer, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("imageForBounds:textContainer:characterIndex:"), bounds, textContainer__handle__, characterIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		/// <param name="textContainer">To be added.</param><param name="proposedLineFragment">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns the bounds of the text attachment.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAttachmentBounds (NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textContainer">To be added.</param><param name="proposedLineFragment">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns the bounds of the text attachment.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAttachmentBounds (INSTextAttachmentContainer This, NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, proposedLineFragment, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGPoint_UIntPtr (This.Handle, Selector.GetHandle ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, proposedLineFragment, glyphPosition, characterIndex);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAttachmentBounds(UIKit.NSTextContainer,CoreGraphics.CGRect,CoreGraphics.CGPoint,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetImageForBounds(CoreGraphics.CGRect,UIKit.NSTextContainer,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextAttachmentContainer ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextAttachmentContainerWrapper : BaseWrapper, INSTextAttachmentContainer {
		public NSTextAttachmentContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentContainerWrapper))]
		static NSTextAttachmentContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="bounds">To be added.</param><param name="textContainer">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns an image rendered in <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageForBounds:textContainer:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIImage? GetImageForBounds (CGRect bounds, NSTextContainer? textContainer, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("imageForBounds:textContainer:characterIndex:"), bounds, textContainer__handle__, characterIndex), false)!;
			GC.KeepAlive (textContainer);
			return ret!;
		}
		/// <param name="textContainer">To be added.</param><param name="proposedLineFragment">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns the bounds of the text attachment.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAttachmentBounds (NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, Selector.GetHandle ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, proposedLineFragment, glyphPosition, characterIndex);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, Selector.GetHandle ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer__handle__, proposedLineFragment, glyphPosition, characterIndex);
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Defines the relationship between <see cref="T:UIKit.NSTextAttachment" />s and a <see cref="T:UIKit.NSLayoutManager" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/NSTextAttachmentContainer_Protocol/index.html">Apple documentation for <c>NSTextAttachmentContainer</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_NSTextAttachmentContainer", false)]
	[Model]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class NSTextAttachmentContainer : NSObject, INSTextAttachmentContainer {
		/// <summary>Creates a new <see cref="NSTextAttachmentContainer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSTextAttachmentContainer () : base (NSObjectFlag.Empty)
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
		protected NSTextAttachmentContainer (NSObjectFlag t) : base (t)
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
		protected internal NSTextAttachmentContainer (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textContainer">To be added.</param><param name="proposedLineFragment">To be added.</param><param name="glyphPosition">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns the bounds of the text attachment.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAttachmentBounds (NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="bounds">To be added.</param><param name="textContainer">To be added.</param><param name="characterIndex">To be added.</param><summary>Returns an image rendered in <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageForBounds:textContainer:characterIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? GetImageForBounds (CGRect bounds, NSTextContainer? textContainer, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTextAttachmentContainer */
}
