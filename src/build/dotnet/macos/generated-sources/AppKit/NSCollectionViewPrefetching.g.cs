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
	/// <summary>This interface represents the Objective-C protocol <c>NSCollectionViewPrefetching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCollectionViewPrefetching", WrapperType = typeof (NSCollectionViewPrefetchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrefetchItems", Selector = "collectionView:prefetchItemsAtIndexPaths:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelPrefetching", Selector = "collectionView:cancelPrefetchingForItemsAtIndexPaths:", ParameterType = new Type [] { typeof (NSCollectionView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSCollectionViewPrefetching : INativeObject, IDisposable
	{
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:prefetchItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrefetchItems (NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrefetchItems (INSCollectionViewPrefetching This, NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		public virtual void CancelPrefetching (NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			_CancelPrefetching (this, collectionView, indexPaths);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelPrefetching (INSCollectionViewPrefetching This, NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:cancelPrefetchingForItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
		}
		[DynamicDependencyAttribute ("CancelPrefetching(AppKit.NSCollectionView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute ("PrefetchItems(AppKit.NSCollectionView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewPrefetchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCollectionViewPrefetching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSCollectionViewPrefetching" /> interface to support all the methods from the NSCollectionViewPrefetching protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSCollectionViewPrefetching" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSCollectionViewPrefetching protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSCollectionViewPrefetching_Extensions {
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPrefetching (this INSCollectionViewPrefetching This, NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
	internal unsafe sealed class NSCollectionViewPrefetchingWrapper : BaseWrapper, INSCollectionViewPrefetching {
		public NSCollectionViewPrefetchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCollectionViewPrefetchingWrapper))]
		static NSCollectionViewPrefetchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:prefetchItemsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PrefetchItems (NSCollectionView collectionView, NSIndexPath[] indexPaths)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:prefetchItemsAtIndexPaths:"), collectionView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (collectionView);
		}
	}
}
