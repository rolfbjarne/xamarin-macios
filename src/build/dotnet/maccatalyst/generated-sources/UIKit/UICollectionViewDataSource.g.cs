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
	/// <summary>The data source for a <see cref="T:UIKit.UICollectionView" />.</summary><remarks><para>
	/// As with other parts of iOS, such as <see cref="T:UIKit.UITableView" /> and <see cref="T:MapKit.MKMapView" />, <see cref="T:UIKit.UICollectionView" /> gets its data from a data source, which is exposed in MonoTouch via the <see cref="T:UIKit.UICollectionViewDataSource" /> class. This class is responsible for providing the content to the <see cref="T:UIKit.UICollectionView" /> including:
	/// </para><list type="bullet"><item><term>Cells – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> method.</term></item><item><term>Supplementary Views – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetViewForSupplementaryElement(UIKit.UICollectionView,Foundation.NSString,Foundation.NSIndexPath)" /> method.</term></item><item><term>Number of sections – Returned from <see cref="M:UIKit.UICollectionViewDataSource.NumberOfSections(UIKit.UICollectionView)" /> method. Defaults to 1 if not implemented.</term></item><item><term>Number of items per section – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetItemsCount(UIKit.UICollectionView,System.IntPtr)" /> method.</term></item></list><para>The <see cref="T:UIKit.UICollectionView" /> maintains a reuse queue, which efficiently reuses <see cref="T:UIKit.UICollectionReusableView" />s without allocating and de-allocating any more than necessary. The <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> and <see cref="M:UIKit.UICollectionViewDataSource.GetViewForSupplementaryElement(UIKit.UICollectionView,Foundation.NSString,Foundation.NSIndexPath)" /> are the functions that mutate the values of <see cref="T:UIKit.UICollectionReusableView" /> component views. Because these methods may be called frequently during scrolling (particularly <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" />), the application developer should avoid unnecessary calculation in them.</para><para>The following code, taken from the "Introduction to Collection Views," shows a simple <see cref="T:UIKit.UICollectionViewDataSource" /> implementation. There are 3 sections and a large <c>animal</c> array representing model data. The number of items per section is 1/3 of the total size of the <c>animals</c> array. The <c>AnimalCell</c> type is a subtype of <see cref="T:UIKit.UICollectionViewCell" /> and is defined as having a <see cref="T:UIKit.UIImage" /><c>Image</c> property; the <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> method sets this property in the reused <c>animalCell</c> from the <c>animals</c> data as appropriate. Similarly, the <see cref="T:UIKit.UICollectionViewDataSource" /> sets the <c>Text</c> property of a <c>Header</c> type defined in the project. </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// protected const int SectionCount = 3;
	/// 
	/// public override int NumberOfSections (UICollectionView collectionView)
	/// {
	///   return SectionCount;
	/// }
	/// 
	/// public override int GetItemsCount (UICollectionView collectionView, int section)
	/// {
	///   return animals.Count / SectionCount;
	/// }
	/// 
	/// public override UICollectionViewCell GetCell (UICollectionView collectionView, Foundation.NSIndexPath indexPath)
	/// {
	///   var animalCell = (AnimalCell)collectionView.DequeueReusableCell (animalCellId, indexPath);
	/// 
	///   var animal = animals [indexPath.Section * (animals.Count / SectionCount) + indexPath.Row];
	/// 
	///   animalCell.Image = animal.Image;
	/// 
	///   return animalCell;
	/// }
	/// 
	/// public override UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
	/// {
	///   var headerView = (Header)collectionView.DequeueReusableSupplementaryView (elementKind, headerId, indexPath);
	///   headerView.Text = "Supplementary View Section " + indexPath.Section.ToString ();
	///   return headerView;
	/// }
	/// 
	/// ]]></code></example><para>The <see cref="T:UIKit.UICollectionViewSource" /> combines the <see cref="T:UIKit.UICollectionViewDataSource" /> API and the <see cref="T:UIKit.UICollectionViewDelegate" /> API in a single convenience class. Rather than creating two classes to assign to the <see cref="P:UIKit.UICollectionView.DataSource" /> and <see cref="P:UIKit.UICollectionView.Delegate" /> properties, a single <see cref="T:UIKit.UICollectionViewSource" /> can be created and assigned to the <see cref="UIKit.UICollectionView.Source" /> property.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UICollectionViewDataSource_protocol/index.html">Apple documentation for <c>UICollectionViewDataSource</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UICollectionViewDataSource", WrapperType = typeof (UICollectionViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemsCount", Selector = "collectionView:numberOfItemsInSection:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UICollectionView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCell", Selector = "collectionView:cellForItemAtIndexPath:", ReturnType = typeof (UICollectionViewCell), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NumberOfSections", Selector = "numberOfSectionsInCollectionView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UICollectionView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewForSupplementaryElement", Selector = "collectionView:viewForSupplementaryElementOfKind:atIndexPath:", ReturnType = typeof (UICollectionReusableView), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSString), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanMoveItem", Selector = "collectionView:canMoveItemAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveItem", Selector = "collectionView:moveItemAtIndexPath:toIndexPath:", ParameterType = new Type [] { typeof (UICollectionView), typeof (NSIndexPath), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexTitles", Selector = "indexTitlesForCollectionView:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (UICollectionView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIndexPath", Selector = "collectionView:indexPathForIndexTitle:atIndex:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (UICollectionView), typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUICollectionViewDataSource : INativeObject, IDisposable
	{
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetItemsCount (IUICollectionViewDataSource This, UICollectionView collectionView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICollectionViewCell _GetCell (IUICollectionViewDataSource This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewCell? ret;
			ret =  Runtime.GetNSObject<UICollectionViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfSectionsInCollectionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UICollectionView collectionView)
		{
			return _NumberOfSections (this, collectionView);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NumberOfSections (IUICollectionViewDataSource This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			return _GetViewForSupplementaryElement (this, collectionView, elementKind, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICollectionReusableView _GetViewForSupplementaryElement (IUICollectionViewDataSource This, UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionReusableView? ret;
			ret =  Runtime.GetNSObject<UICollectionReusableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, elementKind__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:canMoveItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			return _CanMoveItem (this, collectionView, indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanMoveItem (IUICollectionViewDataSource This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canMoveItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:moveItemAtIndexPath:toIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			_MoveItem (this, collectionView, sourceIndexPath, destinationIndexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MoveItem (IUICollectionViewDataSource This, UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:moveItemAtIndexPath:toIndexPath:"), collectionView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("indexTitlesForCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetIndexTitles (UICollectionView collectionView)
		{
			return _GetIndexTitles (this, collectionView);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[]? _GetIndexTitles (IUICollectionViewDataSource This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexTitlesForCollectionView:"), collectionView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("collectionView:indexPathForIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (UICollectionView collectionView, string title, nint atIndex)
		{
			return _GetIndexPath (this, collectionView, title, atIndex);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _GetIndexPath (IUICollectionViewDataSource This, UICollectionView collectionView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:indexPathForIndexTitle:atIndex:"), collectionView__handle__, nstitle, atIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		[DynamicDependencyAttribute ("CanMoveItem(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetIndexPath(UIKit.UICollectionView,System.String,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetIndexTitles(UIKit.UICollectionView)")]
		[DynamicDependencyAttribute ("GetItemsCount(UIKit.UICollectionView,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetViewForSupplementaryElement(UIKit.UICollectionView,Foundation.NSString,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("MoveItem(UIKit.UICollectionView,Foundation.NSIndexPath,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("NumberOfSections(UIKit.UICollectionView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUICollectionViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUICollectionViewDataSource" /> interface to support all the methods from the UICollectionViewDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUICollectionViewDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UICollectionViewDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UICollectionViewDataSource_Extensions {
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint NumberOfSections (this IUICollectionViewDataSource This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UICollectionReusableView GetViewForSupplementaryElement (this IUICollectionViewDataSource This, UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionReusableView? ret;
			ret =  Runtime.GetNSObject<UICollectionReusableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, elementKind__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMoveItem (this IUICollectionViewDataSource This, UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:canMoveItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MoveItem (this IUICollectionViewDataSource This, UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectionView:moveItemAtIndexPath:toIndexPath:"), collectionView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[]? GetIndexTitles (this IUICollectionViewDataSource This, UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("indexTitlesForCollectionView:"), collectionView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexPath? GetIndexPath (this IUICollectionViewDataSource This, UICollectionView collectionView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("collectionView:indexPathForIndexTitle:atIndex:"), collectionView__handle__, nstitle, atIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (collectionView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UICollectionViewDataSourceWrapper : BaseWrapper, IUICollectionViewDataSource {
		public UICollectionViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UICollectionViewDataSourceWrapper))]
		static UICollectionViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewCell? ret;
			ret =  Runtime.GetNSObject<UICollectionViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>The data source for a <see cref="T:UIKit.UICollectionView" />.</summary><remarks><para>
	/// As with other parts of iOS, such as <see cref="T:UIKit.UITableView" /> and <see cref="T:MapKit.MKMapView" />, <see cref="T:UIKit.UICollectionView" /> gets its data from a data source, which is exposed in MonoTouch via the <see cref="T:UIKit.UICollectionViewDataSource" /> class. This class is responsible for providing the content to the <see cref="T:UIKit.UICollectionView" /> including:
	/// </para><list type="bullet"><item><term>Cells – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> method.</term></item><item><term>Supplementary Views – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetViewForSupplementaryElement(UIKit.UICollectionView,Foundation.NSString,Foundation.NSIndexPath)" /> method.</term></item><item><term>Number of sections – Returned from <see cref="M:UIKit.UICollectionViewDataSource.NumberOfSections(UIKit.UICollectionView)" /> method. Defaults to 1 if not implemented.</term></item><item><term>Number of items per section – Returned from <see cref="M:UIKit.UICollectionViewDataSource.GetItemsCount(UIKit.UICollectionView,System.IntPtr)" /> method.</term></item></list><para>The <see cref="T:UIKit.UICollectionView" /> maintains a reuse queue, which efficiently reuses <see cref="T:UIKit.UICollectionReusableView" />s without allocating and de-allocating any more than necessary. The <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> and <see cref="M:UIKit.UICollectionViewDataSource.GetViewForSupplementaryElement(UIKit.UICollectionView,Foundation.NSString,Foundation.NSIndexPath)" /> are the functions that mutate the values of <see cref="T:UIKit.UICollectionReusableView" /> component views. Because these methods may be called frequently during scrolling (particularly <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" />), the application developer should avoid unnecessary calculation in them.</para><para>The following code, taken from the "Introduction to Collection Views," shows a simple <see cref="T:UIKit.UICollectionViewDataSource" /> implementation. There are 3 sections and a large <c>animal</c> array representing model data. The number of items per section is 1/3 of the total size of the <c>animals</c> array. The <c>AnimalCell</c> type is a subtype of <see cref="T:UIKit.UICollectionViewCell" /> and is defined as having a <see cref="T:UIKit.UIImage" /><c>Image</c> property; the <see cref="M:UIKit.UICollectionViewDataSource.GetCell(UIKit.UICollectionView,Foundation.NSIndexPath)" /> method sets this property in the reused <c>animalCell</c> from the <c>animals</c> data as appropriate. Similarly, the <see cref="T:UIKit.UICollectionViewDataSource" /> sets the <c>Text</c> property of a <c>Header</c> type defined in the project. </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// protected const int SectionCount = 3;
	/// 
	/// public override int NumberOfSections (UICollectionView collectionView)
	/// {
	///   return SectionCount;
	/// }
	/// 
	/// public override int GetItemsCount (UICollectionView collectionView, int section)
	/// {
	///   return animals.Count / SectionCount;
	/// }
	/// 
	/// public override UICollectionViewCell GetCell (UICollectionView collectionView, Foundation.NSIndexPath indexPath)
	/// {
	///   var animalCell = (AnimalCell)collectionView.DequeueReusableCell (animalCellId, indexPath);
	/// 
	///   var animal = animals [indexPath.Section * (animals.Count / SectionCount) + indexPath.Row];
	/// 
	///   animalCell.Image = animal.Image;
	/// 
	///   return animalCell;
	/// }
	/// 
	/// public override UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
	/// {
	///   var headerView = (Header)collectionView.DequeueReusableSupplementaryView (elementKind, headerId, indexPath);
	///   headerView.Text = "Supplementary View Section " + indexPath.Section.ToString ();
	///   return headerView;
	/// }
	/// 
	/// ]]></code></example><para>The <see cref="T:UIKit.UICollectionViewSource" /> combines the <see cref="T:UIKit.UICollectionViewDataSource" /> API and the <see cref="T:UIKit.UICollectionViewDelegate" /> API in a single convenience class. Rather than creating two classes to assign to the <see cref="P:UIKit.UICollectionView.DataSource" /> and <see cref="P:UIKit.UICollectionView.Delegate" /> properties, a single <see cref="T:UIKit.UICollectionViewSource" /> can be created and assigned to the <see cref="UIKit.UICollectionView.Source" /> property.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UICollectionViewDataSource_protocol/index.html">Apple documentation for <c>UICollectionViewDataSource</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UICollectionViewDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UICollectionViewDataSource : NSObject, IUICollectionViewDataSource {
		/// <summary>Creates a new <see cref="UICollectionViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UICollectionViewDataSource () : base (NSObjectFlag.Empty)
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
		protected UICollectionViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canMoveItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:indexPathForIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (UICollectionView collectionView, string title, nint atIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexTitlesForCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetIndexTitles (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:moveItemAtIndexPath:toIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInCollectionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UICollectionView collectionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UICollectionViewDataSource */
}
