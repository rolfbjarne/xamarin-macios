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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionViewDelegateFlowLayout</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCollectionViewDelegateFlowLayout", WrapperType = typeof (NSCollectionViewDelegateFlowLayoutWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SizeForItem", Selector = "collectionView:layout:sizeForItemAtIndexPath:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsetForSection", Selector = "collectionView:layout:insetForSectionAtIndex:", ReturnType = typeof (NSEdgeInsets), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MinimumLineSpacing", Selector = "collectionView:layout:minimumLineSpacingForSectionAtIndex:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MinimumInteritemSpacingForSection", Selector = "collectionView:layout:minimumInteritemSpacingForSectionAtIndex:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReferenceSizeForHeader", Selector = "collectionView:layout:referenceSizeForHeaderInSection:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReferenceSizeForFooter", Selector = "collectionView:layout:referenceSizeForFooterInSection:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSCollectionViewLayout), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSCollectionViewDelegateFlowLayout : INativeObject, IDisposable, 
		AppKit.INSCollectionViewDelegate
	{
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize SizeForItem (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
		{
			return _SizeForItem (this, collectionView, collectionViewLayout, indexPath);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _SizeForItem (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:layout:sizeForItemAtIndexPath:"), collectionView__handle__, collectionViewLayout__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEdgeInsets InsetForSection (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			return _InsetForSection (this, collectionView, collectionViewLayout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSEdgeInsets _InsetForSection (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			NSEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumLineSpacing (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			return _MinimumLineSpacing (this, collectionView, collectionViewLayout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _MinimumLineSpacing (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumLineSpacingForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumInteritemSpacingForSection (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			return _MinimumInteritemSpacingForSection (this, collectionView, collectionViewLayout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _MinimumInteritemSpacingForSection (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ReferenceSizeForHeader (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			return _ReferenceSizeForHeader (this, collectionView, collectionViewLayout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _ReferenceSizeForHeader (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForHeaderInSection:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ReferenceSizeForFooter (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			return _ReferenceSizeForFooter (this, collectionView, collectionViewLayout, section);
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _ReferenceSizeForFooter (INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForFooterInSection:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		[DynamicDependencyAttribute ("InsetForSection(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("MinimumInteritemSpacingForSection(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("MinimumLineSpacing(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("ReferenceSizeForFooter(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("ReferenceSizeForHeader(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,System.IntPtr)")]
		[DynamicDependencyAttribute ("SizeForItem(AppKit.NSCollectionView,AppKit.NSCollectionViewLayout,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDelegateFlowLayoutWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionViewDelegateFlowLayout ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCollectionViewDelegateFlowLayout" /> interface to support all the methods from the NSCollectionViewDelegateFlowLayout protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCollectionViewDelegateFlowLayout" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCollectionViewDelegateFlowLayout protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCollectionViewDelegateFlowLayout_Extensions {
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize SizeForItem (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:layout:sizeForItemAtIndexPath:"), collectionView__handle__, collectionViewLayout__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEdgeInsets InsetForSection (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			NSEdgeInsets ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:insetForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat MinimumLineSpacing (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumLineSpacingForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat MinimumInteritemSpacingForSection (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize ReferenceSizeForHeader (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForHeaderInSection:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize ReferenceSizeForFooter (this INSCollectionViewDelegateFlowLayout This, NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var collectionViewLayout__handle__ = collectionViewLayout!.GetNonNullHandle (nameof (collectionViewLayout));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:layout:referenceSizeForFooterInSection:"), collectionView__handle__, collectionViewLayout__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (collectionViewLayout);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCollectionViewDelegateFlowLayoutWrapper : BaseWrapper, INSCollectionViewDelegateFlowLayout {
		public NSCollectionViewDelegateFlowLayoutWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewDelegateFlowLayoutWrapper))]
		static NSCollectionViewDelegateFlowLayoutWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSCollectionViewDelegateFlowLayout" /> (for the protocol <c>NSCollectionViewDelegateFlowLayout</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSCollectionViewDelegateFlowLayout" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSCollectionViewDelegateFlowLayout", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionViewDelegateFlowLayout : NSObject, INSCollectionViewDelegateFlowLayout, INSCollectionViewDelegate {
		/// <summary>Creates a new <see cref="NSCollectionViewDelegateFlowLayout" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCollectionViewDelegateFlowLayout () : base (NSObjectFlag.Empty)
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
		protected NSCollectionViewDelegateFlowLayout (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewDelegateFlowLayout (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collectionView:acceptDrop:index:dropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, nint index, NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:acceptDrop:indexPath:dropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, NSIndexPath indexPath, NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canDragItemsAtIndexes:withEvent:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSIndexSet indexes, NSEvent evt)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canDragItemsAtIndexPaths:withEvent:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDragItems (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingItem:forRepresentedObjectAtIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingItemEnded (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayingSupplementaryViewEnded (NSCollectionView collectionView, NSView view, string elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="dragOperation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:endedAtPoint:dragOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionEnded (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSDragOperation dragOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="session">To be added.</param><param name="screenPoint">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexPaths:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession session, CGPoint screenPoint, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="draggingSession">To be added.</param><param name="screenPoint">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:draggingSession:willBeginAtPoint:forItemsAtIndexes:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingSessionWillBegin (NSCollectionView collectionView, NSDraggingSession draggingSession, CGPoint screenPoint, NSIndexSet indexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="theEvent">To be added.</param><param name="dragImageOffset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:draggingImageForItemsAtIndexPaths:withEvent:offset:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSImage GetDraggingImage (NSCollectionView collectionView, NSSet indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="dropURL">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexPaths:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetNamesOfPromisedFiles (NSCollectionView collectionView, NSUrl dropURL, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:pasteboardWriterForItemAtIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting? GetPasteboardWriter (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:insetForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEdgeInsets InsetForSection (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didChangeItemsAtIndexPaths:toHighlightState:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsChanged (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didDeselectItemsAtIndexPaths:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsDeselected (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didSelectItemsAtIndexPaths:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemsSelected (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumInteritemSpacingForSection (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumLineSpacing (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="dropUrl">To be added.</param><param name="indexes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:namesOfPromisedFilesDroppedAtDestination:forDraggedItemsAtIndexes:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'NSFilePromiseReceiver' objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSCollectionView collectionView, NSUrl dropUrl, NSIndexSet indexes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:pasteboardWriterForItemAtIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSPasteboardWriting PasteboardWriterForItem (NSCollectionView collectionView, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ReferenceSizeForFooter (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ReferenceSizeForHeader (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="highlightState">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldChangeItemsAtIndexPaths:toHighlightState:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldChangeItems (NSCollectionView collectionView, NSSet indexPaths, NSCollectionViewItemHighlightState highlightState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldDeselectItemsAtIndexPaths:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldDeselectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSelectItemsAtIndexPaths:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet ShouldSelectItems (NSCollectionView collectionView, NSSet indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="collectionViewLayout">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize SizeForItem (NSCollectionView collectionView, NSCollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewTransitionLayout TransitionLayout (NSCollectionView collectionView, NSCollectionViewLayout fromLayout, NSCollectionViewLayout toLayout)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:updateDraggingItemsForDrag:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDraggingItemsForDrag (NSCollectionView collectionView, INSDraggingInfo draggingInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:validateDrop:proposedIndex:dropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref nint dropIndex, ref NSCollectionViewDropOperation dropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("collectionView:validateDrop:proposedIndexPath:dropOperation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDragOperation ValidateDrop (NSCollectionView collectionView, INSDraggingInfo draggingInfo, ref NSIndexPath proposedDropIndexPath, ref NSCollectionViewDropOperation proposedDropOperation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="item">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplayItem:forRepresentedObjectAtIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayItem (NSCollectionView collectionView, NSCollectionViewItem item, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (NSCollectionView collectionView, NSView view, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexes">To be added.</param><param name="toPasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:writeItemsAtIndexes:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSIndexSet indexes, NSPasteboard toPasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:writeItemsAtIndexPaths:toPasteboard:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the 'GetPasteboardWriter' method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteItems (NSCollectionView collectionView, NSSet indexPaths, NSPasteboard pasteboard)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSCollectionViewDelegateFlowLayout */
}
