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
	/// <summary>Interface defining methods for collection view data source's that may prefetch data.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollectionViewDataSourcePrefetching", WrapperType = typeof (UICollectionViewDataSourcePrefetchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrefetchItems", Selector = "collectionView:prefetchItemsAtIndexPaths:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelPrefetching", Selector = "collectionView:cancelPrefetchingForItemsAtIndexPaths:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUICollectionViewDataSourcePrefetching : INativeObject, IDisposable
	{
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>Developers override this method to prefetch the data at the specified <paramref name="indexPaths" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:prefetchItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrefetchItems (UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>Developers override this method to prefetch the data at the specified <paramref name="indexPaths" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrefetchItems (IUICollectionViewDataSourcePrefetching This, UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:prefetchItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:cancelPrefetchingForItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelPrefetching (UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			_CancelPrefetching (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelPrefetching (IUICollectionViewDataSourcePrefetching This, UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:cancelPrefetchingForItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
		}
		[DynamicDependencyAttribute ("CancelPrefetching(UIKit.UICollectionView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute ("PrefetchItems(UIKit.UICollectionView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDataSourcePrefetchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDataSourcePrefetching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDataSourcePrefetching" /> interface to support all the methods from the UICollectionViewDataSourcePrefetching protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDataSourcePrefetching" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDataSourcePrefetching protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDataSourcePrefetching_Extensions {
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPrefetching (this IUICollectionViewDataSourcePrefetching This, UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:cancelPrefetchingForItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDataSourcePrefetchingWrapper : BaseWrapper, IUICollectionViewDataSourcePrefetching {
		public UICollectionViewDataSourcePrefetchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDataSourcePrefetchingWrapper))]
		static UICollectionViewDataSourcePrefetchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>Developers override this method to prefetch the data at the specified <paramref name="indexPaths" />.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:prefetchItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PrefetchItems (UICollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:prefetchItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (collectionView);
		}
	}
}
