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
	/// <summary>This interface represents the Objective-C protocol <c>NSRuleEditorDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSRuleEditorDelegate", WrapperType = typeof (NSRuleEditorDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfChildren", Selector = "ruleEditor:numberOfChildrenForCriterion:withRowType:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSRuleEditor), typeof (NSObject), typeof (NSRuleEditorRowType) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ChildForCriterion", Selector = "ruleEditor:child:forCriterion:withRowType:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSRuleEditor), typeof (IntPtr), typeof (NSObject), typeof (NSRuleEditorRowType) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DisplayValue", Selector = "ruleEditor:displayValueForCriterion:inRow:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSRuleEditor), typeof (NSObject), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PredicateParts", Selector = "ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (NSRuleEditor), typeof (NSObject), typeof (NSObject), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RowsDidChange", Selector = "ruleEditorRowsDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "controlTextDidEndEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Changed", Selector = "controlTextDidChange:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingBegan", Selector = "controlTextDidBeginEditing:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	public partial interface INSRuleEditorDelegate : INativeObject, IDisposable
	{
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfChildren (NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NumberOfChildren (INSRuleEditorDelegate This, NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("ruleEditor:numberOfChildrenForCriterion:withRowType:"), editor__handle__, criterion__handle__, (UIntPtr) (ulong) rowType);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
		/// <param name="editor">To be added.</param><param name="index">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("ruleEditor:child:forCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ChildForCriterion (NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="index">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ChildForCriterion (INSRuleEditorDelegate This, NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("ruleEditor:child:forCriterion:withRowType:"), editor__handle__, index, criterion__handle__, (UIntPtr) (ulong) rowType), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("ruleEditor:displayValueForCriterion:inRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject DisplayValue (NSRuleEditor editor, NSObject criterion, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _DisplayValue (INSRuleEditorDelegate This, NSRuleEditor editor, NSObject criterion, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("ruleEditor:displayValueForCriterion:inRow:"), editor__handle__, criterion__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="value">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary PredicateParts (NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
		{
			return _PredicateParts (this, editor, criterion, value, row);
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="value">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _PredicateParts (INSRuleEditorDelegate This, NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:"), editor__handle__, criterion__handle__, value__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			GC.KeepAlive (value);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("ruleEditorRowsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowsDidChange (NSNotification notification)
		{
			_RowsDidChange (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RowsDidChange (INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("ruleEditorRowsDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (NSNotification notification)
		{
			_EditingEnded (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingEnded (INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidEndEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (NSNotification notification)
		{
			_Changed (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Changed (INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controlTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingBegan (NSNotification notification)
		{
			_EditingBegan (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EditingBegan (INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidBeginEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		[DynamicDependencyAttribute ("Changed(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("ChildForCriterion(AppKit.NSRuleEditor,System.IntPtr,Foundation.NSObject,AppKit.NSRuleEditorRowType)")]
		[DynamicDependencyAttribute ("DisplayValue(AppKit.NSRuleEditor,Foundation.NSObject,System.IntPtr)")]
		[DynamicDependencyAttribute ("EditingBegan(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("EditingEnded(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("NumberOfChildren(AppKit.NSRuleEditor,Foundation.NSObject,AppKit.NSRuleEditorRowType)")]
		[DynamicDependencyAttribute ("PredicateParts(AppKit.NSRuleEditor,Foundation.NSObject,Foundation.NSObject,System.IntPtr)")]
		[DynamicDependencyAttribute ("RowsDidChange(Foundation.NSNotification)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSRuleEditorDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSRuleEditorDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSRuleEditorDelegate" /> interface to support all the methods from the NSRuleEditorDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSRuleEditorDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSRuleEditorDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSRuleEditorDelegate_Extensions {
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="value">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary PredicateParts (this INSRuleEditorDelegate This, NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:"), editor__handle__, criterion__handle__, value__handle__, row), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			GC.KeepAlive (value);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RowsDidChange (this INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("ruleEditorRowsDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingEnded (this INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidEndEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Changed (this INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidChange:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EditingBegan (this INSRuleEditorDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controlTextDidBeginEditing:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSRuleEditorDelegateWrapper : BaseWrapper, INSRuleEditorDelegate {
		public NSRuleEditorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSRuleEditorDelegateWrapper))]
		static NSRuleEditorDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint NumberOfChildren (NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("ruleEditor:numberOfChildrenForCriterion:withRowType:"), editor__handle__, criterion__handle__, (UIntPtr) (ulong) rowType);
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
		/// <param name="editor">To be added.</param><param name="index">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:child:forCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject ChildForCriterion (NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("ruleEditor:child:forCriterion:withRowType:"), editor__handle__, index, criterion__handle__, (UIntPtr) (ulong) rowType), false)!;
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:displayValueForCriterion:inRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject DisplayValue (NSRuleEditor editor, NSObject criterion, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			var criterion__handle__ = criterion!.GetNonNullHandle (nameof (criterion));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("ruleEditor:displayValueForCriterion:inRow:"), editor__handle__, criterion__handle__, row), false)!;
			GC.KeepAlive (editor);
			GC.KeepAlive (criterion);
			return ret!;
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSRuleEditorDelegate" /> (for the protocol <c>NSRuleEditorDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSRuleEditorDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSRuleEditorDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSRuleEditorDelegate : NSObject, INSRuleEditorDelegate {
		/// <summary>Creates a new <see cref="NSRuleEditorDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSRuleEditorDelegate () : base (NSObjectFlag.Empty)
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
		protected NSRuleEditorDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSRuleEditorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="index">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:child:forCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ChildForCriterion (NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:displayValueForCriterion:inRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject DisplayValue (NSRuleEditor editor, NSObject criterion, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingBegan (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controlTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="rowType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfChildren (NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="editor">To be added.</param><param name="criterion">To be added.</param><param name="value">To be added.</param><param name="row">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary PredicateParts (NSRuleEditor editor, NSObject criterion, NSObject value, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("ruleEditorRowsDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RowsDidChange (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSRuleEditorDelegate */
}
