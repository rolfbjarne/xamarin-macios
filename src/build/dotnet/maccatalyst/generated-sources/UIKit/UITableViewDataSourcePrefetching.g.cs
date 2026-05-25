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
	/// <summary>Interface for table view data sources that can prefetch their data.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITableViewDataSourcePrefetching", WrapperType = typeof (UITableViewDataSourcePrefetchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrefetchRows", Selector = "tableView:prefetchRowsAtIndexPaths:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelPrefetching", Selector = "tableView:cancelPrefetchingForRowsAtIndexPaths:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath[]) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUITableViewDataSourcePrefetching : INativeObject, IDisposable
	{
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("tableView:prefetchRowsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrefetchRows (UITableView tableView, NSIndexPath[] indexPaths)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrefetchRows (IUITableViewDataSourcePrefetching This, UITableView tableView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:prefetchRowsAtIndexPaths:"), tableView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>Cancels the prefetching of table data.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:cancelPrefetchingForRowsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelPrefetching (UITableView tableView, NSIndexPath[] indexPaths)
		{
			_CancelPrefetching (this, tableView, indexPaths);
		}
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>Cancels the prefetching of table data.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelPrefetching (IUITableViewDataSourcePrefetching This, UITableView tableView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:cancelPrefetchingForRowsAtIndexPaths:"), tableView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
		[DynamicDependencyAttribute ("CancelPrefetching(UIKit.UITableView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute ("PrefetchRows(UIKit.UITableView,Foundation.NSIndexPath[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDataSourcePrefetchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITableViewDataSourcePrefetching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITableViewDataSourcePrefetching" /> interface to support all the methods from the UITableViewDataSourcePrefetching protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITableViewDataSourcePrefetching" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITableViewDataSourcePrefetching protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITableViewDataSourcePrefetching_Extensions {
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>Cancels the prefetching of table data.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPrefetching (this IUITableViewDataSourcePrefetching This, UITableView tableView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:cancelPrefetchingForRowsAtIndexPaths:"), tableView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITableViewDataSourcePrefetchingWrapper : BaseWrapper, IUITableViewDataSourcePrefetching {
		public UITableViewDataSourcePrefetchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDataSourcePrefetchingWrapper))]
		static UITableViewDataSourcePrefetchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="tableView">To be added.</param><param name="indexPaths">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tableView:prefetchRowsAtIndexPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PrefetchRows (UITableView tableView, NSIndexPath[] indexPaths)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:prefetchRowsAtIndexPaths:"), tableView__handle__, nsa_indexPaths.Handle);
			GC.KeepAlive (tableView);
		}
	}
}
