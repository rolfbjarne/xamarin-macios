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
	/// <summary>This interface represents the Objective-C protocol <c>NSDatePickerCellDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSDatePickerCellDelegate", WrapperType = typeof (NSDatePickerCellDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateProposedDateValue", Selector = "datePickerCell:validateProposedDateValue:timeInterval:", ParameterType = new Type [] { typeof (NSDatePickerCell), typeof (NSDate), typeof (double) }, ParameterByRef = new bool [] { false, true, false })]
	public partial interface INSDatePickerCellDelegate : INativeObject, IDisposable
	{
		/// <param name="aDatePickerCell">To be added.</param><param name="proposedDateValue">To be added.</param><param name="proposedTimeInterval">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("datePickerCell:validateProposedDateValue:timeInterval:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateProposedDateValue (NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
		{
			_ValidateProposedDateValue (this, aDatePickerCell, ref proposedDateValue, proposedTimeInterval);
		}
		/// <param name="aDatePickerCell">To be added.</param><param name="proposedDateValue">To be added.</param><param name="proposedTimeInterval">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ValidateProposedDateValue (INSDatePickerCellDelegate This, NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aDatePickerCell__handle__ = aDatePickerCell!.GetNonNullHandle (nameof (aDatePickerCell));
			var proposedDateValueValue = Runtime.RetainAndAutoreleaseNativeObject (proposedDateValue);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_NativeHandle_Double (This.Handle, Selector.GetHandle ("datePickerCell:validateProposedDateValue:timeInterval:"), aDatePickerCell__handle__, &proposedDateValueValue, proposedTimeInterval);
			GC.KeepAlive (This);
			GC.KeepAlive (aDatePickerCell);
			proposedDateValue = Runtime.GetNSObject<NSDate> (proposedDateValueValue)!;
		}
		[DynamicDependencyAttribute ("ValidateProposedDateValue(AppKit.NSDatePickerCell,Foundation.NSDate@,System.Double)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDatePickerCellDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSDatePickerCellDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSDatePickerCellDelegate" /> interface to support all the methods from the NSDatePickerCellDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSDatePickerCellDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSDatePickerCellDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSDatePickerCellDelegate_Extensions {
		/// <param name="aDatePickerCell">To be added.</param><param name="proposedDateValue">To be added.</param><param name="proposedTimeInterval">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ValidateProposedDateValue (this INSDatePickerCellDelegate This, NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aDatePickerCell__handle__ = aDatePickerCell!.GetNonNullHandle (nameof (aDatePickerCell));
			var proposedDateValueValue = Runtime.RetainAndAutoreleaseNativeObject (proposedDateValue);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_NativeHandle_Double (This.Handle, Selector.GetHandle ("datePickerCell:validateProposedDateValue:timeInterval:"), aDatePickerCell__handle__, &proposedDateValueValue, proposedTimeInterval);
			GC.KeepAlive (This);
			GC.KeepAlive (aDatePickerCell);
			proposedDateValue = Runtime.GetNSObject<NSDate> (proposedDateValueValue)!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSDatePickerCellDelegateWrapper : BaseWrapper, INSDatePickerCellDelegate {
		public NSDatePickerCellDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDatePickerCellDelegateWrapper))]
		static NSDatePickerCellDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSDatePickerCellDelegate" /> (for the protocol <c>NSDatePickerCellDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSDatePickerCellDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSDatePickerCellDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSDatePickerCellDelegate : NSObject, INSDatePickerCellDelegate {
		/// <summary>Creates a new <see cref="NSDatePickerCellDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDatePickerCellDelegate () : base (NSObjectFlag.Empty)
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
		protected NSDatePickerCellDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSDatePickerCellDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="aDatePickerCell">To be added.</param><param name="proposedDateValue">To be added.</param><param name="proposedTimeInterval">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("datePickerCell:validateProposedDateValue:timeInterval:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ValidateProposedDateValue (NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSDatePickerCellDelegate */
}
