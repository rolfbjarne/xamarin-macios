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
	/// <summary>Contains the row spand and column span of a cell.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityContainerDataTableCell", WrapperType = typeof (UIAccessibilityContainerDataTableCellWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRowRange", Selector = "accessibilityRowRange", ReturnType = typeof (NSRange))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityColumnRange", Selector = "accessibilityColumnRange", ReturnType = typeof (NSRange))]
	public partial interface IUIAccessibilityContainerDataTableCell : INativeObject, IDisposable
	{
		/// <summary>Returns the number of rows that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRowRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRowRange ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the number of rows that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRowRange (IUIAccessibilityContainerDataTableCell This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowRange"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the number of columns that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityColumnRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityColumnRange ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the number of columns that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityColumnRange (IUIAccessibilityContainerDataTableCell This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetAccessibilityColumnRange()")]
		[DynamicDependencyAttribute ("GetAccessibilityRowRange()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerDataTableCellWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityContainerDataTableCell ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityContainerDataTableCellWrapper : BaseWrapper, IUIAccessibilityContainerDataTableCell {
		public UIAccessibilityContainerDataTableCellWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerDataTableCellWrapper))]
		static UIAccessibilityContainerDataTableCellWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns the number of rows that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityRowRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRowRange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRowRange"));
			return ret;
		}
		/// <summary>Returns the number of columns that the cell spans.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityColumnRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityColumnRange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnRange"));
			return ret;
		}
	}
}
