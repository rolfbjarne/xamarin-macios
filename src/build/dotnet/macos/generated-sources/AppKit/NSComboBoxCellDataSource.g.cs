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
	/// <summary>This interface represents the Objective-C protocol <c>NSComboBoxCellDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSComboBoxCellDataSource", WrapperType = typeof (NSComboBoxCellDataSourceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectValueForItem", Selector = "comboBoxCell:objectValueForItemAtIndex:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSComboBoxCell), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemCount", Selector = "numberOfItemsInComboBoxCell:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSComboBoxCell) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompletedString", Selector = "comboBoxCell:completedString:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSComboBoxCell), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IndexOfItem", Selector = "comboBoxCell:indexOfItemWithStringValue:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (NSComboBoxCell), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSComboBoxCellDataSource : INativeObject, IDisposable
	{
		/// <param name="comboBox">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("comboBoxCell:objectValueForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ObjectValueForItem (NSComboBoxCell comboBox, nint index)
		{
			return _ObjectValueForItem (this, comboBox, index);
		}
		/// <param name="comboBox">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ObjectValueForItem (INSComboBoxCellDataSource This, NSComboBoxCell comboBox, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("comboBoxCell:objectValueForItemAtIndex:"), comboBox__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("numberOfItemsInComboBoxCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ItemCount (NSComboBoxCell comboBox)
		{
			return _ItemCount (this, comboBox);
		}
		/// <param name="comboBox">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _ItemCount (INSComboBoxCellDataSource This, NSComboBoxCell comboBox)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfItemsInComboBoxCell:"), comboBox__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><param name="uncompletedString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("comboBoxCell:completedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CompletedString (NSComboBoxCell comboBox, string uncompletedString)
		{
			return _CompletedString (this, comboBox, uncompletedString);
		}
		/// <param name="comboBox">To be added.</param><param name="uncompletedString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _CompletedString (INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string uncompletedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			if (uncompletedString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uncompletedString));
			var nsuncompletedString = CFString.CreateNative (uncompletedString);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("comboBoxCell:completedString:"), comboBox__handle__, nsuncompletedString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			CFString.ReleaseNative (nsuncompletedString);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("comboBoxCell:indexOfItemWithStringValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint IndexOfItem (NSComboBoxCell comboBox, string value)
		{
			return _IndexOfItem (this, comboBox, value);
		}
		/// <param name="comboBox">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _IndexOfItem (INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("comboBoxCell:indexOfItemWithStringValue:"), comboBox__handle__, nsvalue);
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		[DynamicDependencyAttribute ("CompletedString(AppKit.NSComboBoxCell,System.String)")]
		[DynamicDependencyAttribute ("IndexOfItem(AppKit.NSComboBoxCell,System.String)")]
		[DynamicDependencyAttribute ("ItemCount(AppKit.NSComboBoxCell)")]
		[DynamicDependencyAttribute ("ObjectValueForItem(AppKit.NSComboBoxCell,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSComboBoxCellDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSComboBoxCellDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSComboBoxCellDataSource" /> interface to support all the methods from the NSComboBoxCellDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSComboBoxCellDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSComboBoxCellDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSComboBoxCellDataSource_Extensions {
		/// <param name="comboBox">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ObjectValueForItem (this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("comboBoxCell:objectValueForItemAtIndex:"), comboBox__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint ItemCount (this INSComboBoxCellDataSource This, NSComboBoxCell comboBox)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfItemsInComboBoxCell:"), comboBox__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><param name="uncompletedString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CompletedString (this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string uncompletedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			if (uncompletedString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uncompletedString));
			var nsuncompletedString = CFString.CreateNative (uncompletedString);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("comboBoxCell:completedString:"), comboBox__handle__, nsuncompletedString), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			CFString.ReleaseNative (nsuncompletedString);
			return ret!;
		}
		/// <param name="comboBox">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint IndexOfItem (this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var comboBox__handle__ = comboBox!.GetNonNullHandle (nameof (comboBox));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("comboBoxCell:indexOfItemWithStringValue:"), comboBox__handle__, nsvalue);
			GC.KeepAlive (This);
			GC.KeepAlive (comboBox);
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSComboBoxCellDataSourceWrapper : BaseWrapper, INSComboBoxCellDataSource {
		public NSComboBoxCellDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSComboBoxCellDataSourceWrapper))]
		static NSComboBoxCellDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSComboBoxCellDataSource" /> (for the protocol <c>NSComboBoxCellDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSComboBoxCellDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSComboBoxCellDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSComboBoxCellDataSource : NSObject, INSComboBoxCellDataSource {
		/// <summary>Creates a new <see cref="NSComboBoxCellDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSComboBoxCellDataSource () : base (NSObjectFlag.Empty)
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
		protected NSComboBoxCellDataSource (NSObjectFlag t) : base (t)
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
		protected internal NSComboBoxCellDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="comboBox">To be added.</param><param name="uncompletedString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("comboBoxCell:completedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CompletedString (NSComboBoxCell comboBox, string uncompletedString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="comboBox">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("comboBoxCell:indexOfItemWithStringValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint IndexOfItem (NSComboBoxCell comboBox, string value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="comboBox">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfItemsInComboBoxCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ItemCount (NSComboBoxCell comboBox)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="comboBox">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("comboBoxCell:objectValueForItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ObjectValueForItem (NSComboBoxCell comboBox, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSComboBoxCellDataSource */
}
