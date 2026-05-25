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
	/// <summary>This interface represents the Objective-C protocol <c>UITableViewDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITableViewDataSource", WrapperType = typeof (UITableViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RowsInSection", Selector = "tableView:numberOfRowsInSection:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCell", Selector = "tableView:cellForRowAtIndexPath:", ReturnType = typeof (UITableViewCell), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NumberOfSections", Selector = "numberOfSectionsInTableView:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TitleForHeader", Selector = "tableView:titleForHeaderInSection:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TitleForFooter", Selector = "tableView:titleForFooterInSection:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UITableView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanEditRow", Selector = "tableView:canEditRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanMoveRow", Selector = "tableView:canMoveRowAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SectionIndexTitles", Selector = "sectionIndexTitlesForTableView:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (UITableView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SectionFor", Selector = "tableView:sectionForSectionIndexTitle:atIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITableView), typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CommitEditingStyle", Selector = "tableView:commitEditingStyle:forRowAtIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (UITableViewCellEditingStyle), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveRow", Selector = "tableView:moveRowAtIndexPath:toIndexPath:", ParameterType = new Type [] { typeof (UITableView), typeof (NSIndexPath), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITableViewDataSource : INativeObject, IDisposable
	{
		/// <param name="tableView">To be added.</param><param name="section">Index of the section containing the rows.</param><summary>The number of rows in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("tableView:numberOfRowsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInSection (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="section">Index of the section containing the rows.</param><summary>The number of rows in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _RowsInSection (IUITableViewDataSource This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView__handle__, section);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view requesting the cell.</param><param name="indexPath">Location of the row where the cell will be displayed.</param><summary>Returns a cell that can be inserted at <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("tableView:cellForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view requesting the cell.</param><param name="indexPath">Location of the row where the cell will be displayed.</param><summary>Returns a cell that can be inserted at <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITableViewCell _GetCell (IUITableViewDataSource This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCell? ret;
			ret =  Runtime.GetNSObject<UITableViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="tableView">Table view displaying the sections.</param><summary>Returns the number of sections that are required to display the data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfSectionsInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UITableView tableView)
		{
			return _NumberOfSections (this, tableView);
		}
		/// <param name="tableView">Table view displaying the sections.</param><summary>Returns the number of sections that are required to display the data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NumberOfSections (IUITableViewDataSource This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the header.</param><summary>Called to populate the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:titleForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForHeader (UITableView tableView, nint section)
		{
			return _TitleForHeader (this, tableView, section);
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the header.</param><summary>Called to populate the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _TitleForHeader (IUITableViewDataSource This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:titleForHeaderInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the footer.</param><summary>Called to populate the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:titleForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForFooter (UITableView tableView, nint section)
		{
			return _TitleForFooter (this, tableView, section);
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the footer.</param><summary>Called to populate the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _TitleForFooter (IUITableViewDataSource This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:titleForFooterInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  should be editable.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:canEditRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _CanEditRow (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  should be editable.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanEditRow (IUITableViewDataSource This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canEditRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  can be moved to another location in the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:canMoveRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			return _CanMoveRow (this, tableView, indexPath);
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  can be moved to another location in the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanMoveRow (IUITableViewDataSource This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canMoveRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view that is displaying the index.</param><summary>Returns an array of titles to be displayed as an index on the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("sectionIndexTitlesForTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? SectionIndexTitles (UITableView tableView)
		{
			return _SectionIndexTitles (this, tableView);
		}
		/// <param name="tableView">Table view that is displaying the index.</param><summary>Returns an array of titles to be displayed as an index on the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[]? _SectionIndexTitles (IUITableViewDataSource This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sectionIndexTitlesForTableView:"), tableView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="title">The title that's displayed in the table view's index.</param><param name="atIndex">The index of the title in the array returned from the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" />.</param><summary>Returns the index of the section with the given <paramref name="tableView" /> and <paramref name="atIndex" />.</summary><returns>The index of the section in the table view.</returns><remarks><para>This method is only required for table views that have an index: they must have the <see cref="F:UIKit.UITableViewStyle.Plain" /> style and implement the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" /> property.</para><para>The index for a table view may contain fewer items than the number of actual sections in the table. This method is passed the text and index of an item in the index, and should return the position of the corresponding section. </para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:sectionForSectionIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SectionFor (UITableView tableView, string title, nint atIndex)
		{
			return _SectionFor (this, tableView, title, atIndex);
		}
		/// <param name="tableView">Table view containing the section.</param><param name="title">The title that's displayed in the table view's index.</param><param name="atIndex">The index of the title in the array returned from the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" />.</param><summary>Returns the index of the section with the given <paramref name="tableView" /> and <paramref name="atIndex" />.</summary><returns>The index of the section in the table view.</returns><remarks><para>This method is only required for table views that have an index: they must have the <see cref="F:UIKit.UITableViewStyle.Plain" /> style and implement the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" /> property.</para><para>The index for a table view may contain fewer items than the number of actual sections in the table. This method is passed the text and index of an item in the index, and should return the position of the corresponding section. </para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _SectionFor (IUITableViewDataSource This, UITableView tableView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:sectionForSectionIndexTitle:atIndex:"), tableView__handle__, nstitle, atIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="tableView">Table view requesting insertion or deletion.</param><param name="editingStyle">Cell editing style requested for the row at <paramref name="indexPath" />, such as <see cref="F:UIKit.UITableViewCellEditingStyle.Insert" /> or <see cref="F:UIKit.UITableViewCellEditingStyle.Delete" />.</param><param name="indexPath">Location of the row.</param><summary>Commits the insertion or deletion of the specified row.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:commitEditingStyle:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			_CommitEditingStyle (this, tableView, editingStyle, indexPath);
		}
		/// <param name="tableView">Table view requesting insertion or deletion.</param><param name="editingStyle">Cell editing style requested for the row at <paramref name="indexPath" />, such as <see cref="F:UIKit.UITableViewCellEditingStyle.Insert" /> or <see cref="F:UIKit.UITableViewCellEditingStyle.Delete" />.</param><param name="indexPath">Location of the row.</param><summary>Commits the insertion or deletion of the specified row.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CommitEditingStyle (IUITableViewDataSource This, UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("tableView:commitEditingStyle:forRowAtIndexPath:"), tableView__handle__, (IntPtr) (long) editingStyle, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row being moved.</param><param name="sourceIndexPath">Location of the row to be moved.</param><param name="destinationIndexPath">New location of the row.</param><summary>Called when a row has been moved so that the data source can 'implement' the changed row position that has been performed in the user interface. This ensures the data is kept in-sync with what is being displayed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tableView:moveRowAtIndexPath:toIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			_MoveRow (this, tableView, sourceIndexPath, destinationIndexPath);
		}
		/// <param name="tableView">Table view containing the row being moved.</param><param name="sourceIndexPath">Location of the row to be moved.</param><param name="destinationIndexPath">New location of the row.</param><summary>Called when a row has been moved so that the data source can 'implement' the changed row position that has been performed in the user interface. This ensures the data is kept in-sync with what is being displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MoveRow (IUITableViewDataSource This, UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:moveRowAtIndexPath:toIndexPath:"), tableView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
		[DynamicDependencyAttribute ("CanEditRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CanMoveRow(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("CommitEditingStyle(UIKit.UITableView,UIKit.UITableViewCellEditingStyle,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetCell(UIKit.UITableView,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("MoveRow(UIKit.UITableView,Foundation.NSIndexPath,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("NumberOfSections(UIKit.UITableView)")]
		[DynamicDependencyAttribute ("RowsInSection(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("SectionFor(UIKit.UITableView,System.String,System.IntPtr)")]
		[DynamicDependencyAttribute ("SectionIndexTitles(UIKit.UITableView)")]
		[DynamicDependencyAttribute ("TitleForFooter(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute ("TitleForHeader(UIKit.UITableView,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITableViewDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITableViewDataSource" /> interface to support all the methods from the UITableViewDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITableViewDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITableViewDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITableViewDataSource_Extensions {
		/// <param name="tableView">Table view displaying the sections.</param><summary>Returns the number of sections that are required to display the data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint NumberOfSections (this IUITableViewDataSource This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfSectionsInTableView:"), tableView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the header.</param><summary>Called to populate the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TitleForHeader (this IUITableViewDataSource This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:titleForHeaderInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the footer.</param><summary>Called to populate the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? TitleForFooter (this IUITableViewDataSource This, UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:titleForFooterInSection:"), tableView__handle__, section), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  should be editable.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanEditRow (this IUITableViewDataSource This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canEditRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  can be moved to another location in the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMoveRow (this IUITableViewDataSource This, UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:canMoveRowAtIndexPath:"), tableView__handle__, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="tableView">Table view that is displaying the index.</param><summary>Returns an array of titles to be displayed as an index on the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[]? SectionIndexTitles (this IUITableViewDataSource This, UITableView tableView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sectionIndexTitlesForTableView:"), tableView__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view containing the section.</param><param name="title">The title that's displayed in the table view's index.</param><param name="atIndex">The index of the title in the array returned from the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" />.</param><summary>Returns the index of the section with the given <paramref name="tableView" /> and <paramref name="atIndex" />.</summary><returns>The index of the section in the table view.</returns><remarks><para>This method is only required for table views that have an index: they must have the <see cref="F:UIKit.UITableViewStyle.Plain" /> style and implement the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" /> property.</para><para>The index for a table view may contain fewer items than the number of actual sections in the table. This method is passed the text and index of an item in the index, and should return the position of the corresponding section. </para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint SectionFor (this IUITableViewDataSource This, UITableView tableView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("tableView:sectionForSectionIndexTitle:atIndex:"), tableView__handle__, nstitle, atIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="tableView">Table view requesting insertion or deletion.</param><param name="editingStyle">Cell editing style requested for the row at <paramref name="indexPath" />, such as <see cref="F:UIKit.UITableViewCellEditingStyle.Insert" /> or <see cref="F:UIKit.UITableViewCellEditingStyle.Delete" />.</param><param name="indexPath">Location of the row.</param><summary>Commits the insertion or deletion of the specified row.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CommitEditingStyle (this IUITableViewDataSource This, UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("tableView:commitEditingStyle:forRowAtIndexPath:"), tableView__handle__, (IntPtr) (long) editingStyle, indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="tableView">Table view containing the row being moved.</param><param name="sourceIndexPath">Location of the row to be moved.</param><param name="destinationIndexPath">New location of the row.</param><summary>Called when a row has been moved so that the data source can 'implement' the changed row position that has been performed in the user interface. This ensures the data is kept in-sync with what is being displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MoveRow (this IUITableViewDataSource This, UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tableView:moveRowAtIndexPath:toIndexPath:"), tableView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (tableView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITableViewDataSourceWrapper : BaseWrapper, IUITableViewDataSource {
		public UITableViewDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITableViewDataSourceWrapper))]
		static UITableViewDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="tableView">To be added.</param><param name="section">Index of the section containing the rows.</param><summary>The number of rows in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:numberOfRowsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint RowsInSection (UITableView tableView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("tableView:numberOfRowsInSection:"), tableView__handle__, section);
			GC.KeepAlive (tableView);
			return ret!;
		}
		/// <param name="tableView">Table view requesting the cell.</param><param name="indexPath">Location of the row where the cell will be displayed.</param><summary>Returns a cell that can be inserted at <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:cellForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var tableView__handle__ = tableView!.GetNonNullHandle (nameof (tableView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITableViewCell? ret;
			ret =  Runtime.GetNSObject<UITableViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("tableView:cellForRowAtIndexPath:"), tableView__handle__, indexPath__handle__), false)!;
			GC.KeepAlive (tableView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITableViewDataSource" /> (for the protocol <c>UITableViewDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITableViewDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UITableViewDataSource", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UITableViewDataSource : NSObject, IUITableViewDataSource {
		/// <summary>Creates a new <see cref="UITableViewDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITableViewDataSource () : base (NSObjectFlag.Empty)
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
		protected UITableViewDataSource (NSObjectFlag t) : base (t)
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
		protected internal UITableViewDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  should be editable.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canEditRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row.</param><param name="indexPath">Location of the row.</param><summary>Whether the row located at  can be moved to another location in the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:canMoveRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view requesting insertion or deletion.</param><param name="editingStyle">Cell editing style requested for the row at <paramref name="indexPath" />, such as <see cref="F:UIKit.UITableViewCellEditingStyle.Insert" /> or <see cref="F:UIKit.UITableViewCellEditingStyle.Delete" />.</param><param name="indexPath">Location of the row.</param><summary>Commits the insertion or deletion of the specified row.</summary><remarks>To be added.</remarks>
		[Export ("tableView:commitEditingStyle:forRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view requesting the cell.</param><param name="indexPath">Location of the row where the cell will be displayed.</param><summary>Returns a cell that can be inserted at <paramref name="indexPath" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:cellForRowAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the row being moved.</param><param name="sourceIndexPath">Location of the row to be moved.</param><param name="destinationIndexPath">New location of the row.</param><summary>Called when a row has been moved so that the data source can 'implement' the changed row position that has been performed in the user interface. This ensures the data is kept in-sync with what is being displayed.</summary><remarks>To be added.</remarks>
		[Export ("tableView:moveRowAtIndexPath:toIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view displaying the sections.</param><summary>Returns the number of sections that are required to display the data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInTableView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">To be added.</param><param name="section">Index of the section containing the rows.</param><summary>The number of rows in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:numberOfRowsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RowsInSection (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the section.</param><param name="title">The title that's displayed in the table view's index.</param><param name="atIndex">The index of the title in the array returned from the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" />.</param><summary>Returns the index of the section with the given <paramref name="tableView" /> and <paramref name="atIndex" />.</summary><returns>The index of the section in the table view.</returns><remarks><para>This method is only required for table views that have an index: they must have the <see cref="F:UIKit.UITableViewStyle.Plain" /> style and implement the <see cref="M:UIKit.UITableViewSource.SectionIndexTitles(UIKit.UITableView)" /> property.</para><para>The index for a table view may contain fewer items than the number of actual sections in the table. This method is passed the text and index of an item in the index, and should return the position of the corresponding section. </para></remarks>
		[Export ("tableView:sectionForSectionIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SectionFor (UITableView tableView, string title, nint atIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view that is displaying the index.</param><summary>Returns an array of titles to be displayed as an index on the table view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sectionIndexTitlesForTableView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? SectionIndexTitles (UITableView tableView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the footer.</param><summary>Called to populate the footer for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForFooterInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForFooter (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="tableView">Table view containing the section.</param><param name="section">Index of the section displaying the header.</param><summary>Called to populate the header for the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tableView:titleForHeaderInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TitleForHeader (UITableView tableView, nint section)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITableViewDataSource */
}
