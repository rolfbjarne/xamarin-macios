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
	/// <summary>Interface for pasting and dropping text via item providers.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextPasteDelegate", WrapperType = typeof (UITextPasteDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransformPasteItem", Selector = "textPasteConfigurationSupporting:transformPasteItem:", ParameterType = new Type [] { typeof (IUITextPasteConfigurationSupporting), typeof (IUITextPasteItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CombineItemAttributedStrings", Selector = "textPasteConfigurationSupporting:combineItemAttributedStrings:forRange:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (IUITextPasteConfigurationSupporting), typeof (NSAttributedString[]), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformPaste", Selector = "textPasteConfigurationSupporting:performPasteOfAttributedString:toRange:", ReturnType = typeof (UITextRange), ParameterType = new Type [] { typeof (IUITextPasteConfigurationSupporting), typeof (NSAttributedString), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAnimatePaste", Selector = "textPasteConfigurationSupporting:shouldAnimatePasteOfAttributedString:toRange:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IUITextPasteConfigurationSupporting), typeof (NSAttributedString), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITextPasteDelegate : INativeObject, IDisposable
	{
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="item">The paste item.</param><summary>Method that is called to transform the paste item as it is pasted.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textPasteConfigurationSupporting:transformPasteItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransformPasteItem (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, IUITextPasteItem item)
		{
			_TransformPasteItem (this, textPasteConfigurationSupporting, item);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="item">The paste item.</param><summary>Method that is called to transform the paste item as it is pasted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TransformPasteItem (IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, IUITextPasteItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:transformPasteItem:"), textPasteConfigurationSupporting__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (item);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="itemStrings">The strings to combine.</param><param name="textRange">The range in which to paste or drop the combined strings.</param><summary>Method that is called to combine multiple attributed strings.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textPasteConfigurationSupporting:combineItemAttributedStrings:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString CombineItemAttributedStrings (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString[] itemStrings, UITextRange textRange)
		{
			return _CombineItemAttributedStrings (this, textPasteConfigurationSupporting, itemStrings, textRange);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="itemStrings">The strings to combine.</param><param name="textRange">The range in which to paste or drop the combined strings.</param><summary>Method that is called to combine multiple attributed strings.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _CombineItemAttributedStrings (IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString[] itemStrings, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			if (itemStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemStrings));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			using var nsa_itemStrings = NSArray.FromNSObjects (itemStrings);
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:combineItemAttributedStrings:forRange:"), textPasteConfigurationSupporting__handle__, nsa_itemStrings.Handle, textRange__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">To be added.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Method that is called to incorporate the pasted data into the application content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textPasteConfigurationSupporting:performPasteOfAttributedString:toRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange PerformPaste (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			return _PerformPaste (this, textPasteConfigurationSupporting, attributedString, textRange);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">To be added.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Method that is called to incorporate the pasted data into the application content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _PerformPaste (IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:performPasteOfAttributedString:toRange:"), textPasteConfigurationSupporting__handle__, attributedString__handle__, textRange__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (attributedString);
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">The string to paste.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Returns a Boolean value that tells the system whether to animate the paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textPasteConfigurationSupporting:shouldAnimatePasteOfAttributedString:toRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAnimatePaste (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			return _ShouldAnimatePaste (this, textPasteConfigurationSupporting, attributedString, textRange);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">The string to paste.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Returns a Boolean value that tells the system whether to animate the paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAnimatePaste (IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:shouldAnimatePasteOfAttributedString:toRange:"), textPasteConfigurationSupporting__handle__, attributedString__handle__, textRange__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (attributedString);
			GC.KeepAlive (textRange);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("CombineItemAttributedStrings(UIKit.IUITextPasteConfigurationSupporting,Foundation.NSAttributedString[],UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("PerformPaste(UIKit.IUITextPasteConfigurationSupporting,Foundation.NSAttributedString,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("ShouldAnimatePaste(UIKit.IUITextPasteConfigurationSupporting,Foundation.NSAttributedString,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("TransformPasteItem(UIKit.IUITextPasteConfigurationSupporting,UIKit.IUITextPasteItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextPasteDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextPasteDelegate" /> interface to support all the methods from the UITextPasteDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextPasteDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextPasteDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextPasteDelegate_Extensions {
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="item">The paste item.</param><summary>Method that is called to transform the paste item as it is pasted.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TransformPasteItem (this IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, IUITextPasteItem item)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:transformPasteItem:"), textPasteConfigurationSupporting__handle__, item__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (item);
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="itemStrings">The strings to combine.</param><param name="textRange">The range in which to paste or drop the combined strings.</param><summary>Method that is called to combine multiple attributed strings.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString CombineItemAttributedStrings (this IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString[] itemStrings, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			if (itemStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemStrings));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			using var nsa_itemStrings = NSArray.FromNSObjects (itemStrings);
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:combineItemAttributedStrings:forRange:"), textPasteConfigurationSupporting__handle__, nsa_itemStrings.Handle, textRange__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">To be added.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Method that is called to incorporate the pasted data into the application content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextRange PerformPaste (this IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:performPasteOfAttributedString:toRange:"), textPasteConfigurationSupporting__handle__, attributedString__handle__, textRange__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (attributedString);
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">The string to paste.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Returns a Boolean value that tells the system whether to animate the paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAnimatePaste (this IUITextPasteDelegate This, IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPasteConfigurationSupporting__handle__ = textPasteConfigurationSupporting!.GetNonNullHandle (nameof (textPasteConfigurationSupporting));
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textPasteConfigurationSupporting:shouldAnimatePasteOfAttributedString:toRange:"), textPasteConfigurationSupporting__handle__, attributedString__handle__, textRange__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPasteConfigurationSupporting);
			GC.KeepAlive (attributedString);
			GC.KeepAlive (textRange);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextPasteDelegateWrapper : BaseWrapper, IUITextPasteDelegate {
		public UITextPasteDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextPasteDelegateWrapper))]
		static UITextPasteDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Interface for pasting and dropping text via item providers.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UITextPasteDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UITextPasteDelegate : NSObject, IUITextPasteDelegate {
		/// <summary>Creates a new <see cref="UITextPasteDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextPasteDelegate () : base (NSObjectFlag.Empty)
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
		protected UITextPasteDelegate (NSObjectFlag t) : base (t)
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
		protected internal UITextPasteDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="itemStrings">The strings to combine.</param><param name="textRange">The range in which to paste or drop the combined strings.</param><summary>Method that is called to combine multiple attributed strings.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textPasteConfigurationSupporting:combineItemAttributedStrings:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString CombineItemAttributedStrings (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString[] itemStrings, UITextRange textRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">To be added.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Method that is called to incorporate the pasted data into the application content.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textPasteConfigurationSupporting:performPasteOfAttributedString:toRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange PerformPaste (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="attributedString">The string to paste.</param><param name="textRange">The range in which to paste or drop the string.</param><summary>Returns a Boolean value that tells the system whether to animate the paste operation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textPasteConfigurationSupporting:shouldAnimatePasteOfAttributedString:toRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAnimatePaste (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, NSAttributedString attributedString, UITextRange textRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textPasteConfigurationSupporting">The receiving object.</param><param name="item">The paste item.</param><summary>Method that is called to transform the paste item as it is pasted.</summary><remarks>To be added.</remarks>
		[Export ("textPasteConfigurationSupporting:transformPasteItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransformPasteItem (IUITextPasteConfigurationSupporting textPasteConfigurationSupporting, IUITextPasteItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextPasteDelegate */
}
