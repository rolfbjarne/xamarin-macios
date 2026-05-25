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
	/// <summary>This interface represents the Objective-C protocol <c>UIAccessibilityContainerDataTable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIAccessibilityContainerDataTable", WrapperType = typeof (UIAccessibilityContainerDataTableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityDataTableCellElement", Selector = "accessibilityDataTableCellElementForRow:column:", ReturnType = typeof (IUIAccessibilityContainerDataTableCell), ParameterType = new Type [] { typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityHeaderElementsForRow", Selector = "accessibilityHeaderElementsForRow:", ReturnType = typeof (IUIAccessibilityContainerDataTableCell[]), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAccessibilityHeaderElementsForColumn", Selector = "accessibilityHeaderElementsForColumn:", ReturnType = typeof (IUIAccessibilityContainerDataTableCell[]), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowCount", Selector = "accessibilityRowCount", PropertyType = typeof (UIntPtr), GetterSelector = "accessibilityRowCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnCount", Selector = "accessibilityColumnCount", PropertyType = typeof (UIntPtr), GetterSelector = "accessibilityColumnCount", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIAccessibilityContainerDataTable : INativeObject, IDisposable
	{
		/// <param name="row">The row that contains the desired element.</param><param name="column">The column that contains the desired element.</param><summary>Returns a description of the row span and column span for the cell that is located at the specified <paramref name="row" /> and <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("accessibilityDataTableCellElementForRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell? GetAccessibilityDataTableCellElement (nuint row, nuint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="row">The row that contains the desired element.</param><param name="column">The column that contains the desired element.</param><summary>Returns a description of the row span and column span for the cell that is located at the specified <paramref name="row" /> and <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIAccessibilityContainerDataTableCell? _GetAccessibilityDataTableCellElement (IUIAccessibilityContainerDataTable This, nuint row, nuint column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell ret;
			ret =  Runtime.GetINativeObject<IUIAccessibilityContainerDataTableCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("accessibilityDataTableCellElementForRow:column:"), row, column), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="row">The desired row.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityHeaderElementsForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForRow (nuint row)
		{
			return _GetAccessibilityHeaderElementsForRow (this, row);
		}
		/// <param name="row">The desired row.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIAccessibilityContainerDataTableCell[]? _GetAccessibilityHeaderElementsForRow (IUIAccessibilityContainerDataTable This, nuint row)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell[] ret;
			ret = CFArray.ArrayFromHandle<IUIAccessibilityContainerDataTableCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("accessibilityHeaderElementsForRow:"), row), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="column">The desired column.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("accessibilityHeaderElementsForColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForColumn (nuint column)
		{
			return _GetAccessibilityHeaderElementsForColumn (this, column);
		}
		/// <param name="column">The desired column.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIAccessibilityContainerDataTableCell[]? _GetAccessibilityHeaderElementsForColumn (IUIAccessibilityContainerDataTable This, nuint column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell[] ret;
			ret = CFArray.ArrayFromHandle<IUIAccessibilityContainerDataTableCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("accessibilityHeaderElementsForColumn:"), column), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("AccessibilityColumnCount")]
		[DynamicDependencyAttribute ("AccessibilityRowCount")]
		[DynamicDependencyAttribute ("GetAccessibilityDataTableCellElement(System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityHeaderElementsForColumn(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityHeaderElementsForRow(System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerDataTableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAccessibilityContainerDataTable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the number of rows in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			get {
				return _GetAccessibilityRowCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetAccessibilityRowCount (IUIAccessibilityContainerDataTable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowCount"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the number of columns in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			get {
				return _GetAccessibilityColumnCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetAccessibilityColumnCount (IUIAccessibilityContainerDataTable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnCount"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIAccessibilityContainerDataTable" /> interface to support all the methods from the UIAccessibilityContainerDataTable protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIAccessibilityContainerDataTable" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIAccessibilityContainerDataTable protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIAccessibilityContainerDataTable_Extensions {
		/// <param name="row">The desired row.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForRow (this IUIAccessibilityContainerDataTable This, nuint row)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell[] ret;
			ret = CFArray.ArrayFromHandle<IUIAccessibilityContainerDataTableCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("accessibilityHeaderElementsForRow:"), row), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="column">The desired column.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForColumn (this IUIAccessibilityContainerDataTable This, nuint column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell[] ret;
			ret = CFArray.ArrayFromHandle<IUIAccessibilityContainerDataTableCell>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("accessibilityHeaderElementsForColumn:"), column), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAccessibilityContainerDataTableWrapper : BaseWrapper, IUIAccessibilityContainerDataTable {
		public UIAccessibilityContainerDataTableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAccessibilityContainerDataTableWrapper))]
		static UIAccessibilityContainerDataTableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="row">The row that contains the desired element.</param><param name="column">The column that contains the desired element.</param><summary>Returns a description of the row span and column span for the cell that is located at the specified <paramref name="row" /> and <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityDataTableCellElementForRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIAccessibilityContainerDataTableCell? GetAccessibilityDataTableCellElement (nuint row, nuint column)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIAccessibilityContainerDataTableCell ret;
			ret =  Runtime.GetINativeObject<IUIAccessibilityContainerDataTableCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("accessibilityDataTableCellElementForRow:column:"), row, column), false)!;
			return ret;
		}
		/// <summary>Gets the number of rows in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRowCount"));
				return ret;
			}
		}
		/// <summary>Gets the number of columns in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnCount"));
				return ret;
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIAccessibilityContainerDataTable" /> (for the protocol <c>UIAccessibilityContainerDataTable</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIAccessibilityContainerDataTable" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIAccessibilityContainerDataTable", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UIAccessibilityContainerDataTable : NSObject, IUIAccessibilityContainerDataTable {
		/// <summary>Creates a new <see cref="UIAccessibilityContainerDataTable" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIAccessibilityContainerDataTable () : base (NSObjectFlag.Empty)
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
		protected UIAccessibilityContainerDataTable (NSObjectFlag t) : base (t)
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
		protected internal UIAccessibilityContainerDataTable (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="row">The row that contains the desired element.</param><param name="column">The column that contains the desired element.</param><summary>Returns a description of the row span and column span for the cell that is located at the specified <paramref name="row" /> and <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityDataTableCellElementForRow:column:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell? GetAccessibilityDataTableCellElement (nuint row, nuint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="column">The desired column.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="column" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityHeaderElementsForColumn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForColumn (nuint column)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="row">The desired row.</param><summary>Returns an array of description of the row span and column span for the header cells for the specified <paramref name="row" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityHeaderElementsForRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIAccessibilityContainerDataTableCell[]? GetAccessibilityHeaderElementsForRow (nuint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets the number of columns in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Gets the number of rows in the table.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIAccessibilityContainerDataTable */
}
