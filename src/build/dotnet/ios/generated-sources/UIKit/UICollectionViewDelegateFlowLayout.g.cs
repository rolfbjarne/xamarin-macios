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
	/// <summary>This interface represents the Objective-C protocol <c>UICollectionViewDelegateFlowLayout</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollectionViewDelegateFlowLayout", WrapperType = typeof (UICollectionViewDelegateFlowLayoutWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSizeForItem", Selector = "collectionView:layout:sizeForItemAtIndexPath:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInsetForSection", Selector = "collectionView:layout:insetForSectionAtIndex:", ReturnType = typeof (UIEdgeInsets), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMinimumLineSpacingForSection", Selector = "collectionView:layout:minimumLineSpacingForSectionAtIndex:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMinimumInteritemSpacingForSection", Selector = "collectionView:layout:minimumInteritemSpacingForSectionAtIndex:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReferenceSizeForHeader", Selector = "collectionView:layout:referenceSizeForHeaderInSection:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReferenceSizeForFooter", Selector = "collectionView:layout:referenceSizeForFooterInSection:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (UICollectionView), typeof (UICollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUICollectionViewDelegateFlowLayout : INativeObject, IDisposable, 
		UIKit.IUICollectionViewDelegate
	{
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="indexPath">To be added.</param><summary>The size of the specified item's cell.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSizeForItem (UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			return _GetSizeForItem (this, collectionView, layout, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="indexPath">To be added.</param><summary>The size of the specified item's cell.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetSizeForItem (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:layout:sizeForItemAtIndexPath:"), collectionView__handle__, layout__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The margins to apply to content in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets GetInsetForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			return _GetInsetForSection (this, collectionView, layout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The margins to apply to content in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIEdgeInsets _GetInsetForSection (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			UIEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetMinimumLineSpacingForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			return _GetMinimumLineSpacingForSection (this, collectionView, layout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetMinimumLineSpacingForSection (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumLineSpacingForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between items in the rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetMinimumInteritemSpacingForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			return _GetMinimumInteritemSpacingForSection (this, collectionView, layout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between items in the rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetMinimumInteritemSpacingForSection (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the header view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetReferenceSizeForHeader (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			return _GetReferenceSizeForHeader (this, collectionView, layout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the header view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetReferenceSizeForHeader (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForHeaderInSection:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the footer view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetReferenceSizeForFooter (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			return _GetReferenceSizeForFooter (this, collectionView, layout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the footer view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetReferenceSizeForFooter (IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForFooterInSection:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetInsetForSection(UIKit.UICollectionView,UIKit.UICollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetMinimumInteritemSpacingForSection(UIKit.UICollectionView,UIKit.UICollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetMinimumLineSpacingForSection(UIKit.UICollectionView,UIKit.UICollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetReferenceSizeForFooter(UIKit.UICollectionView,UIKit.UICollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetReferenceSizeForHeader(UIKit.UICollectionView,UIKit.UICollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetSizeForItem(UIKit.UICollectionView,UIKit.UICollectionViewLayout,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDelegateFlowLayoutWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDelegateFlowLayout ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDelegateFlowLayout" /> interface to support all the methods from the UICollectionViewDelegateFlowLayout protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDelegateFlowLayout" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDelegateFlowLayout protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDelegateFlowLayout_Extensions {
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="indexPath">To be added.</param><summary>The size of the specified item's cell.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetSizeForItem (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:layout:sizeForItemAtIndexPath:"), collectionView__handle__, layout__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The margins to apply to content in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIEdgeInsets GetInsetForSection (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			UIEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMinimumLineSpacingForSection (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumLineSpacingForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between items in the rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMinimumInteritemSpacingForSection (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the header view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetReferenceSizeForHeader (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForHeaderInSection:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the footer view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetReferenceSizeForFooter (this IUICollectionViewDelegateFlowLayout This, UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForFooterInSection:"), collectionView__handle__, layout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (layout);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDelegateFlowLayoutWrapper : BaseWrapper, IUICollectionViewDelegateFlowLayout {
		public UICollectionViewDelegateFlowLayoutWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDelegateFlowLayoutWrapper))]
		static UICollectionViewDelegateFlowLayoutWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUICollectionViewDelegateFlowLayout" /> (for the protocol <c>UICollectionViewDelegateFlowLayout</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUICollectionViewDelegateFlowLayout" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UICollectionViewDelegateFlowLayout", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollectionViewDelegateFlowLayout : UICollectionViewDelegate, IUICollectionViewDelegateFlowLayout {
		/// <summary>Creates a new <see cref="UICollectionViewDelegateFlowLayout" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollectionViewDelegateFlowLayout () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewDelegateFlowLayout (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewDelegateFlowLayout (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The margins to apply to content in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets GetInsetForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between items in the rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetMinimumInteritemSpacingForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The spacing between rows or columns of a section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetMinimumLineSpacingForSection (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the footer view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetReferenceSizeForFooter (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="section">To be added.</param><summary>The size of the header view for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetReferenceSizeForHeader (UICollectionView collectionView, UICollectionViewLayout layout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="layout">To be added.</param><param name="indexPath">To be added.</param><summary>The size of the specified item's cell.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetSizeForItem (UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollectionViewDelegateFlowLayout */
}
