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
	/// <summary>Base interface for the UIAccessibilityContainer protocol.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityContainer", WrapperType = typeof (UIAccessibilityContainerWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccessibilityElementCount", Selector = "accessibilityElementCount", ReturnType = typeof (IntPtr))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityElementAt", Selector = "accessibilityElementAtIndex:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexOfAccessibilityElement", Selector = "indexOfAccessibilityElement:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityElements", Selector = "accessibilityElements", ReturnType = typeof (NSObject))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAccessibilityElements", Selector = "setAccessibilityElements:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityContainerType", Selector = "accessibilityContainerType", PropertyType = typeof (UIAccessibilityContainerType), GetterSelector = "accessibilityContainerType", SetterSelector = "setAccessibilityContainerType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IUIAccessibilityContainer : INativeObject, IDisposable
	{
		/// <summary>Returns the number of elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityElementCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint AccessibilityElementCount ()
		{
			return _AccessibilityElementCount (this);
		}
		/// <summary>Returns the number of elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _AccessibilityElementCount (IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityElementCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="index">The index of the item to get.</param><summary>Returns the element at <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityElementAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityElementAt (nint index)
		{
			return _GetAccessibilityElementAt (this, index);
		}
		/// <param name="index">The index of the item to get.</param><summary>Returns the element at <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityElementAt (IUIAccessibilityContainer This, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityElementAtIndex:"), index), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="element">The element whose index to get.</param><summary>Returns the index of <paramref name="element" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("indexOfAccessibilityElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndexOfAccessibilityElement (NSObject element)
		{
			return _GetIndexOfAccessibilityElement (this, element);
		}
		/// <param name="element">The element whose index to get.</param><summary>Returns the index of <paramref name="element" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetIndexOfAccessibilityElement (IUIAccessibilityContainer This, NSObject element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexOfAccessibilityElement:"), element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		/// <summary>Returns the elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityElements")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityElements ()
		{
			return _GetAccessibilityElements (this);
		}
		/// <summary>Returns the elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityElements (IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="elements">To be added.</param><summary>Assigns <paramref name="elements" /> to the contents of the accessibility container.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("setAccessibilityElements:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAccessibilityElements (NSObject? elements)
		{
			_SetAccessibilityElements (this, elements);
		}
		/// <param name="elements">To be added.</param><summary>Assigns <paramref name="elements" /> to the contents of the accessibility container.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityElements (IUIAccessibilityContainer This, NSObject? elements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elements__handle__ = elements.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityElements:"), elements__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (elements);
		}
		[DynamicDependencyAttribute ("AccessibilityContainerType")]
		[DynamicDependencyAttribute ("AccessibilityElementCount()")]
		[DynamicDependencyAttribute ("GetAccessibilityElementAt(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityElements()")]
		[DynamicDependencyAttribute ("GetIndexOfAccessibilityElement(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SetAccessibilityElements(Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityContainer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>A value that tells whether the container is a table, or list, or etc.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual UIAccessibilityContainerType AccessibilityContainerType {
			[Export ("accessibilityContainerType", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityContainerType (this);
			}
			[Export ("setAccessibilityContainerType:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityContainerType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIAccessibilityContainerType _GetAccessibilityContainerType (IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIAccessibilityContainerType ret;
			ret = (UIAccessibilityContainerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityContainerType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityContainerType (IUIAccessibilityContainer This, UIAccessibilityContainerType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityContainerType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIAccessibilityContainer" /> interface to support all the methods from the UIAccessibilityContainer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIAccessibilityContainer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIAccessibilityContainer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIAccessibilityContainer_Extensions {
		/// <summary>Returns the number of elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint AccessibilityElementCount (this IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityElementCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="index">The index of the item to get.</param><summary>Returns the element at <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetAccessibilityElementAt (this IUIAccessibilityContainer This, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityElementAtIndex:"), index), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="element">The element whose index to get.</param><summary>Returns the index of <paramref name="element" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetIndexOfAccessibilityElement (this IUIAccessibilityContainer This, NSObject element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexOfAccessibilityElement:"), element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		/// <summary>Returns the elements in the accessibility container.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetAccessibilityElements (this IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="elements">To be added.</param><summary>Assigns <paramref name="elements" /> to the contents of the accessibility container.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityElements (this IUIAccessibilityContainer This, NSObject? elements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elements__handle__ = elements.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityElements:"), elements__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (elements);
		}
		/// <summary>A value that tells whether the container is a table, or list, or etc.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIAccessibilityContainerType GetAccessibilityContainerType (this IUIAccessibilityContainer This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIAccessibilityContainerType ret;
			ret = (UIAccessibilityContainerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityContainerType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>A value that tells whether the container is a table, or list, or etc.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityContainerType (this IUIAccessibilityContainer This, UIAccessibilityContainerType value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityContainerType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityContainerWrapper : BaseWrapper, IUIAccessibilityContainer {
		public UIAccessibilityContainerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerWrapper))]
		static UIAccessibilityContainerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
