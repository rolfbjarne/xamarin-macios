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
	/// <summary>This interface represents the Objective-C protocol <c>UITextInputTokenizer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextInputTokenizer", WrapperType = typeof (UITextInputTokenizerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetRangeEnclosingPosition", Selector = "rangeEnclosingPosition:withGranularity:inDirection:", ReturnType = typeof (UITextRange), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextGranularity), typeof (UITextDirection) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProbeDirection", Selector = "isPosition:atBoundary:inDirection:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextGranularity), typeof (UITextDirection) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPosition", Selector = "positionFromPosition:toBoundary:inDirection:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextGranularity), typeof (UITextDirection) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProbeDirectionWithinTextUnit", Selector = "isPosition:withinTextUnit:inDirection:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextGranularity), typeof (UITextDirection) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUITextInputTokenizer : INativeObject, IDisposable
	{
		/// <param name="position">To be added.</param><param name="granularity">To be added.</param><param name="direction">To be added.</param><summary>The range for the text enclosing a text position in a text unit of the specified granularity in the specified direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("rangeEnclosingPosition:withGranularity:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetRangeEnclosingPosition (UITextPosition position, UITextGranularity granularity, UITextDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="position">To be added.</param><param name="granularity">To be added.</param><param name="direction">To be added.</param><summary>The range for the text enclosing a text position in a text unit of the specified granularity in the specified direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetRangeEnclosingPosition (IUITextInputTokenizer This, UITextPosition position, UITextGranularity granularity, UITextDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rangeEnclosingPosition:withGranularity:inDirection:"), position__handle__, (IntPtr) (long) granularity, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (position);
			return ret!;
		}
		/// <param name="probePosition">To be added.</param><param name="atBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is at a <paramref name="atBoundary" /> type of boundary taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("isPosition:atBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProbeDirection (UITextPosition probePosition, UITextGranularity atBoundary, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="probePosition">To be added.</param><param name="atBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is at a <paramref name="atBoundary" /> type of boundary taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ProbeDirection (IUITextInputTokenizer This, UITextPosition probePosition, UITextGranularity atBoundary, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var probePosition__handle__ = probePosition!.GetNonNullHandle (nameof (probePosition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("isPosition:atBoundary:inDirection:"), probePosition__handle__, (IntPtr) (long) atBoundary, (IntPtr) (long) inDirection);
			GC.KeepAlive (This);
			GC.KeepAlive (probePosition);
			return ret != 0;
		}
		/// <param name="fromPosition">To be added.</param><param name="toBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns the next <paramref name="toBoundary" /> type of boundary in the <paramref name="inDirection" /> direction from <paramref name="fromPosition" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("positionFromPosition:toBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, UITextGranularity toBoundary, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fromPosition">To be added.</param><param name="toBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns the next <paramref name="toBoundary" /> type of boundary in the <paramref name="inDirection" /> direction from <paramref name="fromPosition" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetPosition (IUITextInputTokenizer This, UITextPosition fromPosition, UITextGranularity toBoundary, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("positionFromPosition:toBoundary:inDirection:"), fromPosition__handle__, (IntPtr) (long) toBoundary, (IntPtr) (long) inDirection), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="probePosition">To be added.</param><param name="withinTextUnit">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is within a <paramref name="withinTextUnit" /> type of text unit taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("isPosition:withinTextUnit:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProbeDirectionWithinTextUnit (UITextPosition probePosition, UITextGranularity withinTextUnit, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="probePosition">To be added.</param><param name="withinTextUnit">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is within a <paramref name="withinTextUnit" /> type of text unit taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ProbeDirectionWithinTextUnit (IUITextInputTokenizer This, UITextPosition probePosition, UITextGranularity withinTextUnit, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var probePosition__handle__ = probePosition!.GetNonNullHandle (nameof (probePosition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("isPosition:withinTextUnit:inDirection:"), probePosition__handle__, (IntPtr) (long) withinTextUnit, (IntPtr) (long) inDirection);
			GC.KeepAlive (This);
			GC.KeepAlive (probePosition);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("GetPosition(UIKit.UITextPosition,UIKit.UITextGranularity,UIKit.UITextDirection)")]
		[DynamicDependencyAttribute ("GetRangeEnclosingPosition(UIKit.UITextPosition,UIKit.UITextGranularity,UIKit.UITextDirection)")]
		[DynamicDependencyAttribute ("ProbeDirection(UIKit.UITextPosition,UIKit.UITextGranularity,UIKit.UITextDirection)")]
		[DynamicDependencyAttribute ("ProbeDirectionWithinTextUnit(UIKit.UITextPosition,UIKit.UITextGranularity,UIKit.UITextDirection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputTokenizerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextInputTokenizer ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextInputTokenizerWrapper : BaseWrapper, IUITextInputTokenizer {
		public UITextInputTokenizerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputTokenizerWrapper))]
		static UITextInputTokenizerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="position">To be added.</param><param name="granularity">To be added.</param><param name="direction">To be added.</param><summary>The range for the text enclosing a text position in a text unit of the specified granularity in the specified direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeEnclosingPosition:withGranularity:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange GetRangeEnclosingPosition (UITextPosition position, UITextGranularity granularity, UITextDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("rangeEnclosingPosition:withGranularity:inDirection:"), position__handle__, (IntPtr) (long) granularity, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (position);
			return ret!;
		}
		/// <param name="probePosition">To be added.</param><param name="atBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is at a <paramref name="atBoundary" /> type of boundary taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isPosition:atBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ProbeDirection (UITextPosition probePosition, UITextGranularity atBoundary, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var probePosition__handle__ = probePosition!.GetNonNullHandle (nameof (probePosition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("isPosition:atBoundary:inDirection:"), probePosition__handle__, (IntPtr) (long) atBoundary, (IntPtr) (long) inDirection);
			GC.KeepAlive (probePosition);
			return ret != 0;
		}
		/// <param name="fromPosition">To be added.</param><param name="toBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns the next <paramref name="toBoundary" /> type of boundary in the <paramref name="inDirection" /> direction from <paramref name="fromPosition" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("positionFromPosition:toBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetPosition (UITextPosition fromPosition, UITextGranularity toBoundary, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:toBoundary:inDirection:"), fromPosition__handle__, (IntPtr) (long) toBoundary, (IntPtr) (long) inDirection), false)!;
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="probePosition">To be added.</param><param name="withinTextUnit">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is within a <paramref name="withinTextUnit" /> type of text unit taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isPosition:withinTextUnit:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ProbeDirectionWithinTextUnit (UITextPosition probePosition, UITextGranularity withinTextUnit, UITextDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var probePosition__handle__ = probePosition!.GetNonNullHandle (nameof (probePosition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("isPosition:withinTextUnit:inDirection:"), probePosition__handle__, (IntPtr) (long) withinTextUnit, (IntPtr) (long) inDirection);
			GC.KeepAlive (probePosition);
			return ret != 0;
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUITextInputTokenizer" /> (for the protocol <c>UITextInputTokenizer</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUITextInputTokenizer" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UITextInputTokenizer", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class UITextInputTokenizer : NSObject, IUITextInputTokenizer {
		/// <summary>Creates a new <see cref="UITextInputTokenizer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UITextInputTokenizer () : base (NSObjectFlag.Empty)
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
		protected UITextInputTokenizer (NSObjectFlag t) : base (t)
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
		protected internal UITextInputTokenizer (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="fromPosition">To be added.</param><param name="toBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns the next <paramref name="toBoundary" /> type of boundary in the <paramref name="inDirection" /> direction from <paramref name="fromPosition" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("positionFromPosition:toBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, UITextGranularity toBoundary, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="position">To be added.</param><param name="granularity">To be added.</param><param name="direction">To be added.</param><summary>The range for the text enclosing a text position in a text unit of the specified granularity in the specified direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeEnclosingPosition:withGranularity:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetRangeEnclosingPosition (UITextPosition position, UITextGranularity granularity, UITextDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="probePosition">To be added.</param><param name="atBoundary">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is at a <paramref name="atBoundary" /> type of boundary taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isPosition:atBoundary:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProbeDirection (UITextPosition probePosition, UITextGranularity atBoundary, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="probePosition">To be added.</param><param name="withinTextUnit">To be added.</param><param name="inDirection">To be added.</param><summary>Returns whether the <paramref name="probePosition" /> position is within a <paramref name="withinTextUnit" /> type of text unit taken from the <paramref name="inDirection" /> direction.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isPosition:withinTextUnit:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProbeDirectionWithinTextUnit (UITextPosition probePosition, UITextGranularity withinTextUnit, UITextDirection inDirection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UITextInputTokenizer */
}
